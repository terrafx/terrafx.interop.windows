// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/imm.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='CANDIDATELIST.xml' path='doc/member[@name="CANDIDATELIST"]/*' />
public partial struct CANDIDATELIST
{
    /// <include file='CANDIDATELIST.xml' path='doc/member[@name="CANDIDATELIST.dwSize"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwSize;

    /// <include file='CANDIDATELIST.xml' path='doc/member[@name="CANDIDATELIST.dwStyle"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwStyle;

    /// <include file='CANDIDATELIST.xml' path='doc/member[@name="CANDIDATELIST.dwCount"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwCount;

    /// <include file='CANDIDATELIST.xml' path='doc/member[@name="CANDIDATELIST.dwSelection"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwSelection;

    /// <include file='CANDIDATELIST.xml' path='doc/member[@name="CANDIDATELIST.dwPageStart"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwPageStart;

    /// <include file='CANDIDATELIST.xml' path='doc/member[@name="CANDIDATELIST.dwPageSize"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwPageSize;

    /// <include file='CANDIDATELIST.xml' path='doc/member[@name="CANDIDATELIST.dwOffset"]/*' />
    [NativeTypeName("DWORD[1]")]
    public _dwOffset_e__FixedBuffer dwOffset;

    /// <include file='_dwOffset_e__FixedBuffer.xml' path='doc/member[@name="_dwOffset_e__FixedBuffer"]/*' />
    public partial struct _dwOffset_e__FixedBuffer
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
