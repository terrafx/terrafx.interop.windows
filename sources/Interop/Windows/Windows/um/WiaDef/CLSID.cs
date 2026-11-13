// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WiaDef.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

public static partial class CLSID
{
    /// <include file='CLSID.xml' path='doc/member[@name="CLSID.CLSID_WiaDefaultSegFilter"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid CLSID_WiaDefaultSegFilter
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x0B, 0xD3, 0xF4, 0xD4,
                0x29, 0x0B,
                0x08, 0x45,
                0x89,
                0x22,
                0x0C,
                0x57,
                0x97,
                0xD4,
                0x27,
                0x65
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
