// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/gdipluspixelformats.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Gdiplus;

/// <include file='ColorPalette.xml' path='doc/member[@name="ColorPalette"]/*' />
public partial struct ColorPalette
{
    /// <include file='ColorPalette.xml' path='doc/member[@name="ColorPalette.Flags"]/*' />
    public uint Flags;

    /// <include file='ColorPalette.xml' path='doc/member[@name="ColorPalette.Count"]/*' />
    public uint Count;

    /// <include file='ColorPalette.xml' path='doc/member[@name="ColorPalette.Entries"]/*' />
    [NativeTypeName("ARGB[1]")]
    public _Entries_e__FixedBuffer Entries;

    /// <include file='_Entries_e__FixedBuffer.xml' path='doc/member[@name="_Entries_e__FixedBuffer"]/*' />
    public partial struct _Entries_e__FixedBuffer
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
