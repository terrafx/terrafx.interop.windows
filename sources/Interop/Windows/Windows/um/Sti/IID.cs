// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/Sti.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

public static partial class IID
{
    /// <include file='IID.xml' path='doc/member[@name="IID.IID_IStillImageW"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_IStillImageW
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x80, 0xD8, 0x1B, 0x64,
                0xC8, 0x2D,
                0xD0, 0x11,
                0x90,
                0xEA,
                0x00,
                0xAA,
                0x00,
                0x60,
                0xF8,
                0x6C
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='IID.xml' path='doc/member[@name="IID.IID_IStiDevice"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid IID_IStiDevice
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x80, 0x5A, 0xFA, 0x6C,
                0xC8, 0x2D,
                0xD0, 0x11,
                0x90,
                0xEA,
                0x00,
                0xAA,
                0x00,
                0x60,
                0xF8,
                0x6C
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='IID.xml' path='doc/member[@name="IID.IID_IStillImage"]/*' />
    [NativeTypeName("#define IID_IStillImage IID_IStillImageW")]
    public static ref readonly Guid IID_IStillImage => ref IID_IStillImageW;
}
