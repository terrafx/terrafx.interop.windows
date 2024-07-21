// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/DbgHelp.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='SYMBOL_INFO.xml' path='doc/member[@name="SYMBOL_INFO"]/*' />
public partial struct SYMBOL_INFO
{
    /// <include file='SYMBOL_INFO.xml' path='doc/member[@name="SYMBOL_INFO.SizeOfStruct"]/*' />
    [NativeTypeName("ULONG")]
    public uint SizeOfStruct;

    /// <include file='SYMBOL_INFO.xml' path='doc/member[@name="SYMBOL_INFO.TypeIndex"]/*' />
    [NativeTypeName("ULONG")]
    public uint TypeIndex;

    /// <include file='SYMBOL_INFO.xml' path='doc/member[@name="SYMBOL_INFO.Reserved"]/*' />
    [NativeTypeName("ULONG64[2]")]
    public _Reserved_e__FixedBuffer Reserved;

    /// <include file='SYMBOL_INFO.xml' path='doc/member[@name="SYMBOL_INFO.Index"]/*' />
    [NativeTypeName("ULONG")]
    public uint Index;

    /// <include file='SYMBOL_INFO.xml' path='doc/member[@name="SYMBOL_INFO.Size"]/*' />
    [NativeTypeName("ULONG")]
    public uint Size;

    /// <include file='SYMBOL_INFO.xml' path='doc/member[@name="SYMBOL_INFO.ModBase"]/*' />
    [NativeTypeName("ULONG64")]
    public ulong ModBase;

    /// <include file='SYMBOL_INFO.xml' path='doc/member[@name="SYMBOL_INFO.Flags"]/*' />
    [NativeTypeName("ULONG")]
    public uint Flags;

    /// <include file='SYMBOL_INFO.xml' path='doc/member[@name="SYMBOL_INFO.Value"]/*' />
    [NativeTypeName("ULONG64")]
    public ulong Value;

    /// <include file='SYMBOL_INFO.xml' path='doc/member[@name="SYMBOL_INFO.Address"]/*' />
    [NativeTypeName("ULONG64")]
    public ulong Address;

    /// <include file='SYMBOL_INFO.xml' path='doc/member[@name="SYMBOL_INFO.Register"]/*' />
    [NativeTypeName("ULONG")]
    public uint Register;

    /// <include file='SYMBOL_INFO.xml' path='doc/member[@name="SYMBOL_INFO.Scope"]/*' />
    [NativeTypeName("ULONG")]
    public uint Scope;

    /// <include file='SYMBOL_INFO.xml' path='doc/member[@name="SYMBOL_INFO.Tag"]/*' />
    [NativeTypeName("ULONG")]
    public uint Tag;

    /// <include file='SYMBOL_INFO.xml' path='doc/member[@name="SYMBOL_INFO.NameLen"]/*' />
    [NativeTypeName("ULONG")]
    public uint NameLen;

    /// <include file='SYMBOL_INFO.xml' path='doc/member[@name="SYMBOL_INFO.MaxNameLen"]/*' />
    [NativeTypeName("ULONG")]
    public uint MaxNameLen;

    /// <include file='SYMBOL_INFO.xml' path='doc/member[@name="SYMBOL_INFO.Name"]/*' />
    [NativeTypeName("CHAR[1]")]
    public _Name_e__FixedBuffer Name;

    /// <include file='_Reserved_e__FixedBuffer.xml' path='doc/member[@name="_Reserved_e__FixedBuffer"]/*' />
    [InlineArray(2)]
    public partial struct _Reserved_e__FixedBuffer
    {
        public ulong e0;
    }

    /// <include file='_Name_e__FixedBuffer.xml' path='doc/member[@name="_Name_e__FixedBuffer"]/*' />
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
