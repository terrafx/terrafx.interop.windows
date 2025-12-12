// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3dshadercacheregistration.h in microsoft/DirectX-Headers tag v1.618.5
// Original source is Copyright © Microsoft. Licensed under the MIT license

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.DirectX;

namespace TerraFX.Interop.Windows;

public static partial class IID
{
    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_ID3DShaderCacheInstallerClient
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x30, 0xE9, 0x6E, 0xA1,
                0xF6, 0xD9,
                0x22, 0x42,
                0xA5,
                0x14,
                0x24,
                0x44,
                0x73,
                0xE5,
                0xD2,
                0x66
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_ID3DShaderCacheComponent
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x00, 0xBF, 0xD1, 0xEE,
                0xC7, 0xF5,
                0xF7, 0x4C,
                0x88,
                0x5C,
                0xD0,
                0xF9,
                0xC0,
                0xCB,
                0x48,
                0x28
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_ID3DShaderCacheApplication
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xE2, 0x8E, 0x68, 0xFC,
                0x35, 0x1B,
                0x13, 0x49,
                0x93,
                0xBE,
                0x1C,
                0xA3,
                0xFA,
                0x7D,
                0xF3,
                0x9E
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_ID3DShaderCacheInstaller
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xE1, 0x0D, 0xE3, 0xBB,
                0x18, 0x63,
                0x26, 0x45,
                0xAE,
                0x17,
                0x77,
                0x66,
                0x93,
                0x19,
                0x1B,
                0xB4
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_ID3DShaderCacheExplorer
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x22, 0x23, 0x43, 0x90,
                0xF5, 0x32,
                0x7F, 0x48,
                0x92,
                0x64,
                0xE9,
                0x39,
                0x0F,
                0xA5,
                0x8B,
                0x2A
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_ID3DShaderCacheInstallerFactory
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xE4, 0xDF, 0xB2, 0x09,
                0x0F, 0x84,
                0x1A, 0x40,
                0x80,
                0x4C,
                0x0D,
                0xD8,
                0xAA,
                0xDC,
                0x9E,
                0x9F
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
