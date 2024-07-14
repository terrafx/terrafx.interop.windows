// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='IMAGE_AUX_SYMBOL_EX.xml' path='doc/member[@name="IMAGE_AUX_SYMBOL_EX"]/*' />
[StructLayout(LayoutKind.Explicit)]
public partial struct IMAGE_AUX_SYMBOL_EX
{
    /// <include file='IMAGE_AUX_SYMBOL_EX.xml' path='doc/member[@name="IMAGE_AUX_SYMBOL_EX.Sym"]/*' />
    [FieldOffset(0)]
    [NativeTypeName("__AnonymousRecord_winnt_L18987_C5")]
    public _Sym_e__Struct Sym;

    /// <include file='IMAGE_AUX_SYMBOL_EX.xml' path='doc/member[@name="IMAGE_AUX_SYMBOL_EX.File"]/*' />
    [FieldOffset(0)]
    [NativeTypeName("__AnonymousRecord_winnt_L18992_C5")]
    public _File_e__Struct File;

    /// <include file='IMAGE_AUX_SYMBOL_EX.xml' path='doc/member[@name="IMAGE_AUX_SYMBOL_EX.Section"]/*' />
    [FieldOffset(0)]
    [NativeTypeName("__AnonymousRecord_winnt_L18995_C5")]
    public _Section_e__Struct Section;

    /// <include file='IMAGE_AUX_SYMBOL_EX.xml' path='doc/member[@name="IMAGE_AUX_SYMBOL_EX.Anonymous"]/*' />
    [FieldOffset(0)]
    [NativeTypeName("__AnonymousRecord_winnt_L19006_C5")]
    public _Anonymous_e__Struct Anonymous;

    /// <include file='IMAGE_AUX_SYMBOL_EX.xml' path='doc/member[@name="IMAGE_AUX_SYMBOL_EX.CRC"]/*' />
    [FieldOffset(0)]
    [NativeTypeName("__AnonymousRecord_winnt_L19010_C5")]
    public _CRC_e__Struct CRC;

    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.TokenDef"]/*' />
    [UnscopedRef]
    public ref IMAGE_AUX_SYMBOL_TOKEN_DEF TokenDef
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.TokenDef;
        }
    }

    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.rgbReserved"]/*' />
    [UnscopedRef]
    public Span<byte> rgbReserved
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return Anonymous.rgbReserved;
        }
    }

    /// <include file='_Sym_e__Struct.xml' path='doc/member[@name="_Sym_e__Struct"]/*' />
    [StructLayout(LayoutKind.Sequential, Pack = 2)]
    public partial struct _Sym_e__Struct
    {
        /// <include file='_Sym_e__Struct.xml' path='doc/member[@name="_Sym_e__Struct.WeakDefaultSymIndex"]/*' />
        [NativeTypeName("DWORD")]
        public uint WeakDefaultSymIndex;

        /// <include file='_Sym_e__Struct.xml' path='doc/member[@name="_Sym_e__Struct.WeakSearchType"]/*' />
        [NativeTypeName("DWORD")]
        public uint WeakSearchType;

        /// <include file='_Sym_e__Struct.xml' path='doc/member[@name="_Sym_e__Struct.rgbReserved"]/*' />
        [NativeTypeName("BYTE[12]")]
        public _rgbReserved_e__FixedBuffer rgbReserved;

        /// <include file='_rgbReserved_e__FixedBuffer.xml' path='doc/member[@name="_rgbReserved_e__FixedBuffer"]/*' />
        [StructLayout(LayoutKind.Sequential, Pack = 2)]
        [InlineArray(12)]
        public partial struct _rgbReserved_e__FixedBuffer
        {
            public byte e0;
        }
    }

    /// <include file='_File_e__Struct.xml' path='doc/member[@name="_File_e__Struct"]/*' />
    public partial struct _File_e__Struct
    {
        /// <include file='_File_e__Struct.xml' path='doc/member[@name="_File_e__Struct.Name"]/*' />
        [NativeTypeName("BYTE[20]")]
        public _Name_e__FixedBuffer Name;

        /// <include file='_Name_e__FixedBuffer.xml' path='doc/member[@name="_Name_e__FixedBuffer"]/*' />
        [InlineArray(20)]
        public partial struct _Name_e__FixedBuffer
        {
            public byte e0;
        }
    }

    /// <include file='_Section_e__Struct.xml' path='doc/member[@name="_Section_e__Struct"]/*' />
    [StructLayout(LayoutKind.Sequential, Pack = 2)]
    public partial struct _Section_e__Struct
    {
        /// <include file='_Section_e__Struct.xml' path='doc/member[@name="_Section_e__Struct.Length"]/*' />
        [NativeTypeName("DWORD")]
        public uint Length;

        /// <include file='_Section_e__Struct.xml' path='doc/member[@name="_Section_e__Struct.NumberOfRelocations"]/*' />
        [NativeTypeName("WORD")]
        public ushort NumberOfRelocations;

        /// <include file='_Section_e__Struct.xml' path='doc/member[@name="_Section_e__Struct.NumberOfLinenumbers"]/*' />
        [NativeTypeName("WORD")]
        public ushort NumberOfLinenumbers;

        /// <include file='_Section_e__Struct.xml' path='doc/member[@name="_Section_e__Struct.CheckSum"]/*' />
        [NativeTypeName("DWORD")]
        public uint CheckSum;

        /// <include file='_Section_e__Struct.xml' path='doc/member[@name="_Section_e__Struct.Number"]/*' />
        public short Number;

        /// <include file='_Section_e__Struct.xml' path='doc/member[@name="_Section_e__Struct.Selection"]/*' />
        public byte Selection;

        /// <include file='_Section_e__Struct.xml' path='doc/member[@name="_Section_e__Struct.bReserved"]/*' />
        public byte bReserved;

        /// <include file='_Section_e__Struct.xml' path='doc/member[@name="_Section_e__Struct.HighNumber"]/*' />
        public short HighNumber;

        /// <include file='_Section_e__Struct.xml' path='doc/member[@name="_Section_e__Struct.rgbReserved"]/*' />
        [NativeTypeName("BYTE[2]")]
        public _rgbReserved_e__FixedBuffer rgbReserved;

        /// <include file='_rgbReserved_e__FixedBuffer.xml' path='doc/member[@name="_rgbReserved_e__FixedBuffer"]/*' />
        [StructLayout(LayoutKind.Sequential, Pack = 2)]
        [InlineArray(2)]
        public partial struct _rgbReserved_e__FixedBuffer
        {
            public byte e0;
        }
    }

    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct"]/*' />
    public partial struct _Anonymous_e__Struct
    {
        /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.TokenDef"]/*' />
        public IMAGE_AUX_SYMBOL_TOKEN_DEF TokenDef;

        /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.rgbReserved"]/*' />
        [NativeTypeName("BYTE[2]")]
        public _rgbReserved_e__FixedBuffer rgbReserved;

        /// <include file='_rgbReserved_e__FixedBuffer.xml' path='doc/member[@name="_rgbReserved_e__FixedBuffer"]/*' />
        [InlineArray(2)]
        public partial struct _rgbReserved_e__FixedBuffer
        {
            public byte e0;
        }
    }

    /// <include file='_CRC_e__Struct.xml' path='doc/member[@name="_CRC_e__Struct"]/*' />
    [StructLayout(LayoutKind.Sequential, Pack = 2)]
    public partial struct _CRC_e__Struct
    {
        /// <include file='_CRC_e__Struct.xml' path='doc/member[@name="_CRC_e__Struct.crc"]/*' />
        [NativeTypeName("DWORD")]
        public uint crc;

        /// <include file='_CRC_e__Struct.xml' path='doc/member[@name="_CRC_e__Struct.rgbReserved"]/*' />
        [NativeTypeName("BYTE[16]")]
        public _rgbReserved_e__FixedBuffer rgbReserved;

        /// <include file='_rgbReserved_e__FixedBuffer.xml' path='doc/member[@name="_rgbReserved_e__FixedBuffer"]/*' />
        [StructLayout(LayoutKind.Sequential, Pack = 2)]
        [InlineArray(16)]
        public partial struct _rgbReserved_e__FixedBuffer
        {
            public byte e0;
        }
    }
}
