// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;
using static TerraFX.Interop.DirectX.D3D12_CACHE_VALUE_TYPE_FLAGS;
using static TerraFX.Interop.DirectX.D3D12_SHADER_CACHE_FLAGS;
using static TerraFX.Interop.DirectX.D3D12_SHADER_CACHE_MODE;
using static TerraFX.Interop.DirectX.D3D12_SHADER_CACHE_SESSION_FILE_FLAGS;
using static TerraFX.Interop.DirectX.D3D12_SHADER_CACHE_SESSION_REGISTERED_FLAGS;

namespace TerraFX.Interop.DirectX;

/// <summary>Builds shader-cache session descriptors while keeping file-descriptor storage local to this value.</summary>
public unsafe ref struct CD3DX12_SHADER_CACHE_SESSION_DESC1
{
    private D3D12_SHADER_CACHE_SESSION_DESC1 _desc;
    private D3D12_CACHE_FILE_DESC _singleDesc;
    private bool _ownsSingleDesc;

    public CD3DX12_SHADER_CACHE_SESSION_DESC1()
    {
        _desc = default;
        _singleDesc = default;
        _ownsSingleDesc = false;
    }

    public CD3DX12_SHADER_CACHE_SESSION_DESC1(scoped in D3D12_SHADER_CACHE_SESSION_DESC1 desc)
    {
        _desc = desc;
        _singleDesc = default;
        _ownsSingleDesc = false;
    }

    public CD3DX12_SHADER_CACHE_SESSION_DESC1(scoped in D3D12_SHADER_CACHE_SESSION_DESC desc)
        : this()
    {
        _desc.Mode = desc.Mode;
        if (desc.Mode == D3D12_SHADER_CACHE_MODE_MEMORY)
        {
            _desc.Memory = new D3D12_SHADER_CACHE_SESSION_MEMORY_DESC
            {
                Identifier = desc.Identifier,
                Flags = desc.Flags,
                MaximumInMemoryCacheSizeBytes = desc.MaximumInMemoryCacheSizeBytes,
                MaximumInMemoryCacheEntries = desc.MaximumInMemoryCacheEntries,
                Version = desc.Version,
            };
        }
        else
        {
            _desc.Disk = new D3D12_SHADER_CACHE_SESSION_DISK_DESC
            {
                Identifier = desc.Identifier,
                Flags = desc.Flags,
                pDirectory = null,
                MaximumInMemoryCacheSizeBytes = desc.MaximumInMemoryCacheSizeBytes,
                MaximumInMemoryCacheEntries = desc.MaximumInMemoryCacheEntries,
                MaximumValueFileSizeBytes = desc.MaximumValueFileSizeBytes,
                Version = desc.Version,
            };
        }
    }

    public CD3DX12_SHADER_CACHE_SESSION_DESC1(scoped in D3D12_SHADER_CACHE_SESSION_MEMORY_DESC desc)
        : this()
    {
        _desc.Mode = D3D12_SHADER_CACHE_MODE_MEMORY;
        _desc.Memory = desc;
    }

    public CD3DX12_SHADER_CACHE_SESSION_DESC1(scoped in D3D12_SHADER_CACHE_SESSION_DISK_DESC desc)
        : this()
    {
        _desc.Mode = D3D12_SHADER_CACHE_MODE_DISK;
        _desc.Disk = desc;
    }

    public CD3DX12_SHADER_CACHE_SESSION_DESC1(scoped in D3D12_SHADER_CACHE_SESSION_REGISTERED_DESC desc)
        : this()
    {
        _desc.Mode = D3D12_SHADER_CACHE_MODE_REGISTERED;
        _desc.Registered = desc;
    }

    public CD3DX12_SHADER_CACHE_SESSION_DESC1(scoped in D3D12_SHADER_CACHE_SESSION_FILE_DESC desc)
        : this()
    {
        _desc.Mode = D3D12_SHADER_CACHE_MODE_FILE;
        _desc.File = desc;
    }

    public CD3DX12_SHADER_CACHE_SESSION_DESC1(char* path, D3D12_CACHE_VALUE_TYPE_FLAGS types = D3D12_CACHE_VALUE_TYPE_FLAGS_OBJECT_CODE | D3D12_CACHE_VALUE_TYPE_FLAGS_METADATA, D3D12_SHADER_CACHE_SESSION_FILE_FLAGS flags = D3D12_SHADER_CACHE_SESSION_FILE_FLAG_NONE)
        : this()
    {
        SetFile(path, types, flags);
    }

    public static CD3DX12_SHADER_CACHE_SESSION_DESC1 MemorySession(Guid identifier, ulong version = 0, D3D12_SHADER_CACHE_FLAGS flags = D3D12_SHADER_CACHE_FLAG_NONE, uint maximumInMemoryCacheSizeBytes = 0, uint maximumInMemoryCacheEntries = 0)
    {
        D3D12_SHADER_CACHE_SESSION_MEMORY_DESC desc = new()
        {
            Identifier = identifier,
            Flags = flags,
            MaximumInMemoryCacheSizeBytes = maximumInMemoryCacheSizeBytes,
            MaximumInMemoryCacheEntries = maximumInMemoryCacheEntries,
            Version = version,
        };
        return new CD3DX12_SHADER_CACHE_SESSION_DESC1(in desc);
    }

    public static CD3DX12_SHADER_CACHE_SESSION_DESC1 DiskSession(Guid identifier, ulong version = 0, D3D12_SHADER_CACHE_FLAGS flags = D3D12_SHADER_CACHE_FLAG_NONE, uint maximumInMemoryCacheSizeBytes = 0, uint maximumInMemoryCacheEntries = 0, ulong maximumValueFileSizeBytes = 0, char* directory = null)
    {
        D3D12_SHADER_CACHE_SESSION_DISK_DESC desc = new()
        {
            Identifier = identifier,
            Flags = flags,
            pDirectory = directory,
            MaximumInMemoryCacheSizeBytes = maximumInMemoryCacheSizeBytes,
            MaximumInMemoryCacheEntries = maximumInMemoryCacheEntries,
            MaximumValueFileSizeBytes = maximumValueFileSizeBytes,
            Version = version,
        };
        return new CD3DX12_SHADER_CACHE_SESSION_DESC1(in desc);
    }

    public static CD3DX12_SHADER_CACHE_SESSION_DESC1 RegisteredSession(char* componentName, D3D12_SHADER_CACHE_SESSION_REGISTERED_FLAGS flags = D3D12_SHADER_CACHE_SESSION_REGISTERED_FLAG_NONE)
    {
        D3D12_SHADER_CACHE_SESSION_REGISTERED_DESC desc = new()
        {
            pComponentName = componentName,
            Flags = flags,
        };
        return new CD3DX12_SHADER_CACHE_SESSION_DESC1(in desc);
    }

    public static CD3DX12_SHADER_CACHE_SESSION_DESC1 FileSession(D3D12_CACHE_FILE_DESC* descriptions, uint count, D3D12_SHADER_CACHE_SESSION_FILE_FLAGS flags = D3D12_SHADER_CACHE_SESSION_FILE_FLAG_NONE)
    {
        D3D12_SHADER_CACHE_SESSION_FILE_DESC desc = new()
        {
            pDescs = descriptions,
            NumDescs = count,
            Flags = flags,
        };
        return new CD3DX12_SHADER_CACHE_SESSION_DESC1(in desc);
    }

    public void SetFile(char* path, D3D12_CACHE_VALUE_TYPE_FLAGS types = D3D12_CACHE_VALUE_TYPE_FLAGS_OBJECT_CODE | D3D12_CACHE_VALUE_TYPE_FLAGS_METADATA, D3D12_SHADER_CACHE_SESSION_FILE_FLAGS flags = D3D12_SHADER_CACHE_SESSION_FILE_FLAG_NONE, ulong maximumSizeBytes = 0)
    {
        _desc.Mode = D3D12_SHADER_CACHE_MODE_FILE;
        _singleDesc = new D3D12_CACHE_FILE_DESC
        {
            Types = types,
            MaximumSizeBytes = maximumSizeBytes,
            pPath = path,
        };
        _desc.File = new D3D12_SHADER_CACHE_SESSION_FILE_DESC
        {
            NumDescs = 1,
            Flags = flags,
        };
        _ownsSingleDesc = true;
    }

    /// <summary>Returns a descriptor whose owned file storage remains valid while this value is alive and unmoved.</summary>
    public D3D12_SHADER_CACHE_SESSION_DESC1 GetDescriptor()
    {
        D3D12_SHADER_CACHE_SESSION_DESC1 desc = _desc;
        if (_ownsSingleDesc)
        {
            fixed (D3D12_CACHE_FILE_DESC* pSingleDesc = &_singleDesc)
            {
                desc.File.pDescs = pSingleDesc;
            }
        }
        return desc;
    }
}
