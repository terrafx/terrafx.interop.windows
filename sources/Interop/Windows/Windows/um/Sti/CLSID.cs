// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/Sti.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

public static partial class CLSID
{
    /// <include file='CLSID.xml' path='doc/member[@name="CLSID.CLSID_Sti"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_Sti
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xE0, 0xF8, 0x23, 0xB3,
                0x68, 0x2E,
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
}
