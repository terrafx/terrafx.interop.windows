// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/shtypes.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='SHITEMID.xml' path='doc/member[@name="SHITEMID"]/*' />
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct SHITEMID
{
    /// <include file='SHITEMID.xml' path='doc/member[@name="SHITEMID.cb"]/*' />
    public ushort cb;

    /// <include file='SHITEMID.xml' path='doc/member[@name="SHITEMID.abID"]/*' />
    [NativeTypeName("BYTE[1]")]
    public _abID_e__FixedBuffer abID;

    /// <include file='_abID_e__FixedBuffer.xml' path='doc/member[@name="_abID_e__FixedBuffer"]/*' />
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public partial struct _abID_e__FixedBuffer
    {
        public byte e0;

        [UnscopedRef]
        public ref byte this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Unsafe.Add(ref e0, index);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<byte> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
    }
}
