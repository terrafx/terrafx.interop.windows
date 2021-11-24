// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

[StructLayout(LayoutKind.Explicit)]
public partial struct IMAGE_AUX_SYMBOL
{
    [FieldOffset(0)]
    [NativeTypeName("struct (anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.20348.0/um/winnt.h:18837:5)")]
    public _Sym_e__Struct Sym;

    [FieldOffset(0)]
    [NativeTypeName("struct (anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.20348.0/um/winnt.h:18857:5)")]
    public _File_e__Struct File;

    [FieldOffset(0)]
    [NativeTypeName("struct (anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.20348.0/um/winnt.h:18860:5)")]
    public _Section_e__Struct Section;

    [FieldOffset(0)]
    public IMAGE_AUX_SYMBOL_TOKEN_DEF TokenDef;

    [FieldOffset(0)]
    [NativeTypeName("struct (anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.20348.0/um/winnt.h:18871:5)")]
    public _CRC_e__Struct CRC;

    [StructLayout(LayoutKind.Sequential, Pack = 2)]
    public partial struct _Sym_e__Struct
    {
        [NativeTypeName("DWORD")]
        public uint TagIndex;

        [NativeTypeName("union (anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.20348.0/um/winnt.h:18839:9)")]
        public _Misc_e__Union Misc;

        [NativeTypeName("union (anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.20348.0/um/winnt.h:18846:9)")]
        public _FcnAry_e__Union FcnAry;

        [NativeTypeName("WORD")]
        public ushort TvIndex;

        [StructLayout(LayoutKind.Explicit, Pack = 2)]
        public partial struct _Misc_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("struct (anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.20348.0/um/winnt.h:18840:13)")]
            public _LnSz_e__Struct LnSz;

            [FieldOffset(0)]
            [NativeTypeName("DWORD")]
            public uint TotalSize;

            public partial struct _LnSz_e__Struct
            {
                [NativeTypeName("WORD")]
                public ushort Linenumber;

                [NativeTypeName("WORD")]
                public ushort Size;
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _FcnAry_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("struct (anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.20348.0/um/winnt.h:18847:13)")]
            public _Function_e__Struct Function;

            [FieldOffset(0)]
            [NativeTypeName("struct (anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.20348.0/um/winnt.h:18851:13)")]
            public _Array_e__Struct Array;

            [StructLayout(LayoutKind.Sequential, Pack = 2)]
            public partial struct _Function_e__Struct
            {
                [NativeTypeName("DWORD")]
                public uint PointerToLinenumber;

                [NativeTypeName("DWORD")]
                public uint PointerToNextFunction;
            }

            public unsafe partial struct _Array_e__Struct
            {
                [NativeTypeName("WORD [4]")]
                public fixed ushort Dimension[4];
            }
        }
    }

    public unsafe partial struct _File_e__Struct
    {
        [NativeTypeName("BYTE [18]")]
        public fixed byte Name[18];
    }

    [StructLayout(LayoutKind.Sequential, Pack = 2)]
    public partial struct _Section_e__Struct
    {
        [NativeTypeName("DWORD")]
        public uint Length;

        [NativeTypeName("WORD")]
        public ushort NumberOfRelocations;

        [NativeTypeName("WORD")]
        public ushort NumberOfLinenumbers;

        [NativeTypeName("DWORD")]
        public uint CheckSum;

        public short Number;

        public byte Selection;

        public byte bReserved;

        public short HighNumber;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 2)]
    public unsafe partial struct _CRC_e__Struct
    {
        [NativeTypeName("DWORD")]
        public uint crc;

        [NativeTypeName("BYTE [14]")]
        public fixed byte rgbReserved[14];
    }
}
