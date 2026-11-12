// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;
using NUnit.Framework;
using static TerraFX.Interop.DirectX.D3D12_CACHE_VALUE_TYPE_FLAGS;
using static TerraFX.Interop.DirectX.D3D12_SHADER_CACHE_FLAGS;
using static TerraFX.Interop.DirectX.D3D12_SHADER_CACHE_MODE;
using static TerraFX.Interop.DirectX.D3D12_SHADER_CACHE_SESSION_FILE_FLAGS;

namespace TerraFX.Interop.DirectX.UnitTests;

/// <summary>Validates manually ported shader-cache session descriptor helpers.</summary>
public static unsafe class D3DX12ShaderCacheDescManualTests
{
    /// <summary>File-session descriptors rebind their owned file entry after wrapper copies.</summary>
    [Test]
    public static void CD3DX12_SHADER_CACHE_SESSION_DESC1_RebindsCopiedFileStorage()
    {
        char[] path = "cache.bin".ToCharArray();
        fixed (char* pPath = path)
        {
            CD3DX12_SHADER_CACHE_SESSION_DESC1 original = new(pPath);
            CD3DX12_SHADER_CACHE_SESSION_DESC1 copy = original;
            D3D12_SHADER_CACHE_SESSION_DESC1 originalDesc = original.GetDescriptor();
            D3D12_SHADER_CACHE_SESSION_DESC1 copyDesc = copy.GetDescriptor();

            Assert.That(originalDesc.Mode, Is.EqualTo(D3D12_SHADER_CACHE_MODE_FILE));
            Assert.That(originalDesc.File.NumDescs, Is.EqualTo(1U));
            Assert.That((nint)originalDesc.File.pDescs->pPath, Is.EqualTo((nint)pPath));
            Assert.That((nint)copyDesc.File.pDescs, Is.Not.EqualTo((nint)originalDesc.File.pDescs));
            Assert.That((nint)copyDesc.File.pDescs->pPath, Is.EqualTo((nint)pPath));
        }
    }

    /// <summary>Memory and file session factories preserve their explicit mode and backing descriptor.</summary>
    [Test]
    public static void CD3DX12_SHADER_CACHE_SESSION_DESC1_CreatesMemoryAndExternalFileSessions()
    {
        CD3DX12_SHADER_CACHE_SESSION_DESC1 memory = CD3DX12_SHADER_CACHE_SESSION_DESC1.MemorySession(Guid.Empty, version: 3, maximumInMemoryCacheSizeBytes: 8192);
        D3D12_SHADER_CACHE_SESSION_DESC1 memoryDesc = memory.GetDescriptor();

        Assert.That(memoryDesc.Mode, Is.EqualTo(D3D12_SHADER_CACHE_MODE_MEMORY));
        Assert.That(memoryDesc.Memory.Version, Is.EqualTo(3UL));
        Assert.That(memoryDesc.Memory.MaximumInMemoryCacheSizeBytes, Is.EqualTo(8192U));

        D3D12_SHADER_CACHE_SESSION_DESC legacyMemoryDesc = new()
        {
            Identifier = Guid.Empty,
            Mode = D3D12_SHADER_CACHE_MODE_MEMORY,
            Flags = D3D12_SHADER_CACHE_FLAG_DRIVER_VERSIONED,
            MaximumInMemoryCacheSizeBytes = 4096,
            MaximumInMemoryCacheEntries = 4,
            MaximumValueFileSizeBytes = 16384,
            Version = 6,
        };
        CD3DX12_SHADER_CACHE_SESSION_DESC1 legacyMemorySession = new(in legacyMemoryDesc);
        D3D12_SHADER_CACHE_SESSION_DESC1 convertedLegacyMemoryDesc = legacyMemorySession.GetDescriptor();

        Assert.That(convertedLegacyMemoryDesc.Mode, Is.EqualTo(D3D12_SHADER_CACHE_MODE_MEMORY));
        Assert.That(convertedLegacyMemoryDesc.Memory.MaximumInMemoryCacheSizeBytes, Is.EqualTo(4096U));
        Assert.That(convertedLegacyMemoryDesc.Memory.MaximumInMemoryCacheEntries, Is.EqualTo(4U));
        Assert.That(convertedLegacyMemoryDesc.Memory.Version, Is.EqualTo(6UL));

        D3D12_SHADER_CACHE_SESSION_DESC legacyDesc = new()
        {
            Identifier = Guid.Empty,
            Mode = D3D12_SHADER_CACHE_MODE_DISK,
            Flags = D3D12_SHADER_CACHE_FLAG_DRIVER_VERSIONED,
            MaximumInMemoryCacheSizeBytes = 4096,
            MaximumInMemoryCacheEntries = 4,
            MaximumValueFileSizeBytes = 16384,
            Version = 7,
        };
        CD3DX12_SHADER_CACHE_SESSION_DESC1 legacySession = new(in legacyDesc);
        D3D12_SHADER_CACHE_SESSION_DESC1 convertedLegacyDesc = legacySession.GetDescriptor();

        Assert.That(convertedLegacyDesc.Mode, Is.EqualTo(D3D12_SHADER_CACHE_MODE_DISK));
        Assert.That((nint)convertedLegacyDesc.Disk.pDirectory, Is.EqualTo((nint)0));
        Assert.That(convertedLegacyDesc.Disk.MaximumInMemoryCacheSizeBytes, Is.EqualTo(4096U));
        Assert.That(convertedLegacyDesc.Disk.MaximumInMemoryCacheEntries, Is.EqualTo(4U));
        Assert.That(convertedLegacyDesc.Disk.MaximumValueFileSizeBytes, Is.EqualTo(16384UL));
        Assert.That(convertedLegacyDesc.Disk.Version, Is.EqualTo(7UL));

        D3D12_CACHE_FILE_DESC file = new()
        {
            Types = D3D12_CACHE_VALUE_TYPE_FLAGS_OBJECT_CODE,
            MaximumSizeBytes = 1024,
        };
        CD3DX12_SHADER_CACHE_SESSION_DESC1 fileSession = CD3DX12_SHADER_CACHE_SESSION_DESC1.FileSession(&file, 1, D3D12_SHADER_CACHE_SESSION_FILE_FLAG_NONE);
        D3D12_SHADER_CACHE_SESSION_DESC1 fileDesc = fileSession.GetDescriptor();

        Assert.That(fileDesc.Mode, Is.EqualTo(D3D12_SHADER_CACHE_MODE_FILE));
        Assert.That(fileDesc.File.NumDescs, Is.EqualTo(1U));
        Assert.That((nint)fileDesc.File.pDescs, Is.EqualTo((nint)(&file)));
    }
}
