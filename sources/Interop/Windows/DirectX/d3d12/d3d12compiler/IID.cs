// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12compiler.h in microsoft/DirectX-Headers tag v1.620.2
// Original source is Copyright © Microsoft. Licensed under the MIT license

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.DirectX;

namespace TerraFX.Interop.Windows;

public static partial class IID
{
    /// <include file='IID.xml' path='doc/member[@name="IID.IID_ID3D12CompilerFactoryChild"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_ID3D12CompilerFactoryChild
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x20, 0x64, 0xD0, 0xE0,
                0x31, 0x9F,
                0xE8, 0x47,
                0xAE,
                0x9A,
                0xDD,
                0x2B,
                0xA2,
                0x5A,
                0xC0,
                0xBC
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='IID.xml' path='doc/member[@name="IID.IID_ID3D12CompilerCacheSession"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_ID3D12CompilerCacheSession
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xE6, 0xE5, 0x04, 0x57,
                0x4B, 0x05,
                0x38, 0x47,
                0xB6,
                0x61,
                0x7B,
                0x0D,
                0x68,
                0xD8,
                0xDD,
                0xE2
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='IID.xml' path='doc/member[@name="IID.IID_ID3D12CompilerStateObject"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_ID3D12CompilerStateObject
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xA4, 0xCC, 0x81, 0x59,
                0xAE, 0xE8,
                0xCA, 0x44,
                0x9B,
                0x92,
                0x4F,
                0xA8,
                0x6F,
                0x5A,
                0x3A,
                0x3A
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='IID.xml' path='doc/member[@name="IID.IID_ID3D12Compiler"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_ID3D12Compiler
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x12, 0x3C, 0x40, 0x8C,
                0x3B, 0x99,
                0x83, 0x45,
                0x80,
                0xF1,
                0x68,
                0x24,
                0x13,
                0x8F,
                0xA6,
                0x8E
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='IID.xml' path='doc/member[@name="IID.IID_ID3D12Compiler1"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_ID3D12Compiler1
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xF2, 0xF9, 0x24, 0xE5,
                0x7E, 0x49,
                0xE2, 0x43,
                0x93,
                0x86,
                0x02,
                0xD5,
                0x3B,
                0xDC,
                0x2D,
                0x52
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='IID.xml' path='doc/member[@name="IID.IID_ID3D12CompilerFactory"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_ID3D12CompilerFactory
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x59, 0x4B, 0xEE, 0xC1,
                0x59, 0x3F,
                0xA5, 0x47,
                0x9B,
                0x4E,
                0xA8,
                0x55,
                0xC8,
                0x58,
                0xA8,
                0x78
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
