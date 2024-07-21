// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='EXTLOGPEN.xml' path='doc/member[@name="EXTLOGPEN"]/*' />
public partial struct EXTLOGPEN
{
    /// <include file='EXTLOGPEN.xml' path='doc/member[@name="EXTLOGPEN.elpPenStyle"]/*' />
    [NativeTypeName("DWORD")]
    public uint elpPenStyle;

    /// <include file='EXTLOGPEN.xml' path='doc/member[@name="EXTLOGPEN.elpWidth"]/*' />
    [NativeTypeName("DWORD")]
    public uint elpWidth;

    /// <include file='EXTLOGPEN.xml' path='doc/member[@name="EXTLOGPEN.elpBrushStyle"]/*' />
    public uint elpBrushStyle;

    /// <include file='EXTLOGPEN.xml' path='doc/member[@name="EXTLOGPEN.elpColor"]/*' />
    public COLORREF elpColor;

    /// <include file='EXTLOGPEN.xml' path='doc/member[@name="EXTLOGPEN.elpHatch"]/*' />
    [NativeTypeName("ULONG_PTR")]
    public nuint elpHatch;

    /// <include file='EXTLOGPEN.xml' path='doc/member[@name="EXTLOGPEN.elpNumEntries"]/*' />
    [NativeTypeName("DWORD")]
    public uint elpNumEntries;

    /// <include file='EXTLOGPEN.xml' path='doc/member[@name="EXTLOGPEN.elpStyleEntry"]/*' />
    [NativeTypeName("DWORD[1]")]
    public _elpStyleEntry_e__FixedBuffer elpStyleEntry;

    /// <include file='_elpStyleEntry_e__FixedBuffer.xml' path='doc/member[@name="_elpStyleEntry_e__FixedBuffer"]/*' />
    public partial struct _elpStyleEntry_e__FixedBuffer
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
