// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShlObj_core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='CIDA.xml' path='doc/member[@name="CIDA"]/*' />
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct CIDA
{
    /// <include file='CIDA.xml' path='doc/member[@name="CIDA.cidl"]/*' />
    public uint cidl;

    /// <include file='CIDA.xml' path='doc/member[@name="CIDA.aoffset"]/*' />
    [NativeTypeName("UINT[1]")]
    public _aoffset_e__FixedBuffer aoffset;

    /// <include file='_aoffset_e__FixedBuffer.xml' path='doc/member[@name="_aoffset_e__FixedBuffer"]/*' />
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public partial struct _aoffset_e__FixedBuffer
    {
        public uint e0;

        [UnscopedRef]
        public ref uint this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Unsafe.Add(ref e0, index);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<uint> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
    }
}
