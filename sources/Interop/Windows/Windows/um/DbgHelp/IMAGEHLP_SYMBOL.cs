// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/DbgHelp.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='IMAGEHLP_SYMBOL.xml' path='doc/member[@name="IMAGEHLP_SYMBOL"]/*' />
public partial struct IMAGEHLP_SYMBOL
{
    /// <include file='IMAGEHLP_SYMBOL.xml' path='doc/member[@name="IMAGEHLP_SYMBOL.SizeOfStruct"]/*' />
    [NativeTypeName("DWORD")]
    public uint SizeOfStruct;

    /// <include file='IMAGEHLP_SYMBOL.xml' path='doc/member[@name="IMAGEHLP_SYMBOL.Address"]/*' />
    [NativeTypeName("DWORD")]
    public uint Address;

    /// <include file='IMAGEHLP_SYMBOL.xml' path='doc/member[@name="IMAGEHLP_SYMBOL.Size"]/*' />
    [NativeTypeName("DWORD")]
    public uint Size;

    /// <include file='IMAGEHLP_SYMBOL.xml' path='doc/member[@name="IMAGEHLP_SYMBOL.Flags"]/*' />
    [NativeTypeName("DWORD")]
    public uint Flags;

    /// <include file='IMAGEHLP_SYMBOL.xml' path='doc/member[@name="IMAGEHLP_SYMBOL.MaxNameLength"]/*' />
    [NativeTypeName("DWORD")]
    public uint MaxNameLength;

    /// <include file='IMAGEHLP_SYMBOL.xml' path='doc/member[@name="IMAGEHLP_SYMBOL.Name"]/*' />
    [NativeTypeName("CHAR[1]")]
    public _Name_e__FixedBuffer Name;

    /// <include file='_Name_e__FixedBuffer.xml' path='doc/member[@name="_Name_e__FixedBuffer"]/*' />
    [Obsolete("Possible string represented as a fixed-sized buffer.")]
    public partial struct _Name_e__FixedBuffer
    {
        public sbyte e0;

        [UnscopedRef]
        public ref sbyte this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Unsafe.Add(ref e0, index);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<sbyte> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
    }
}
