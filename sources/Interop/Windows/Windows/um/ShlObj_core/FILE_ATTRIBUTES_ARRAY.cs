// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShlObj_core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='FILE_ATTRIBUTES_ARRAY.xml' path='doc/member[@name="FILE_ATTRIBUTES_ARRAY"]/*' />
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct FILE_ATTRIBUTES_ARRAY
{
    /// <include file='FILE_ATTRIBUTES_ARRAY.xml' path='doc/member[@name="FILE_ATTRIBUTES_ARRAY.cItems"]/*' />
    public uint cItems;

    /// <include file='FILE_ATTRIBUTES_ARRAY.xml' path='doc/member[@name="FILE_ATTRIBUTES_ARRAY.dwSumFileAttributes"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwSumFileAttributes;

    /// <include file='FILE_ATTRIBUTES_ARRAY.xml' path='doc/member[@name="FILE_ATTRIBUTES_ARRAY.dwProductFileAttributes"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwProductFileAttributes;

    /// <include file='FILE_ATTRIBUTES_ARRAY.xml' path='doc/member[@name="FILE_ATTRIBUTES_ARRAY.rgdwFileAttributes"]/*' />
    [NativeTypeName("DWORD[1]")]
    public _rgdwFileAttributes_e__FixedBuffer rgdwFileAttributes;

    /// <include file='_rgdwFileAttributes_e__FixedBuffer.xml' path='doc/member[@name="_rgdwFileAttributes_e__FixedBuffer"]/*' />
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public partial struct _rgdwFileAttributes_e__FixedBuffer
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
