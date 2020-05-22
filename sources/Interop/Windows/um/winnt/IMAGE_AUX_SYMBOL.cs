// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [StructLayout(LayoutKind.Explicit)]
    public partial struct IMAGE_AUX_SYMBOL
    {
        [FieldOffset(0)]
        [NativeTypeName("struct (anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/winnt.h:17383:5)")]
        public _Sym_e__Union Sym;

        [FieldOffset(0)]
        [NativeTypeName("struct (anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/winnt.h:17403:5)")]
        public _File_e__Union File;

        [FieldOffset(0)]
        [NativeTypeName("struct (anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/winnt.h:17406:5)")]
        public _Section_e__Union Section;

        [FieldOffset(0)]
        public IMAGE_AUX_SYMBOL_TOKEN_DEF TokenDef;

        [FieldOffset(0)]
        [NativeTypeName("struct (anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/winnt.h:17417:5)")]
        public _CRC_e__Union CRC;

        public partial struct _Sym_e__Union
        {
            [NativeTypeName("DWORD")]
            public uint TagIndex;

            [NativeTypeName("union (anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/winnt.h:17385:9)")]
            public _Misc_e__Union Misc;

            [NativeTypeName("union (anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/winnt.h:17392:9)")]
            public _FcnAry_e__Union FcnAry;

            [NativeTypeName("WORD")]
            public ushort TvIndex;

            [StructLayout(LayoutKind.Explicit)]
            public partial struct _Misc_e__Union
            {
                [FieldOffset(0)]
                [NativeTypeName("struct (anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/winnt.h:17386:13)")]
                public _LnSz_e__Union LnSz;

                [FieldOffset(0)]
                [NativeTypeName("DWORD")]
                public uint TotalSize;

                public partial struct _LnSz_e__Union
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
                [NativeTypeName("struct (anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/winnt.h:17393:13)")]
                public _Function_e__Union Function;

                [FieldOffset(0)]
                [NativeTypeName("struct (anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/winnt.h:17397:13)")]
                public _Array_e__Union Array;

                public partial struct _Function_e__Union
                {
                    [NativeTypeName("DWORD")]
                    public uint PointerToLinenumber;

                    [NativeTypeName("DWORD")]
                    public uint PointerToNextFunction;
                }

                public unsafe partial struct _Array_e__Union
                {
                    [NativeTypeName("WORD [4]")]
                    public fixed ushort Dimension[4];
                }
            }
        }

        public unsafe partial struct _File_e__Union
        {
            [NativeTypeName("BYTE [18]")]
            public fixed byte Name[18];
        }

        public partial struct _Section_e__Union
        {
            [NativeTypeName("DWORD")]
            public uint Length;

            [NativeTypeName("WORD")]
            public ushort NumberOfRelocations;

            [NativeTypeName("WORD")]
            public ushort NumberOfLinenumbers;

            [NativeTypeName("DWORD")]
            public uint CheckSum;

            [NativeTypeName("SHORT")]
            public short Number;

            [NativeTypeName("BYTE")]
            public byte Selection;

            [NativeTypeName("BYTE")]
            public byte bReserved;

            [NativeTypeName("SHORT")]
            public short HighNumber;
        }

        public unsafe partial struct _CRC_e__Union
        {
            [NativeTypeName("DWORD")]
            public uint crc;

            [NativeTypeName("BYTE [14]")]
            public fixed byte rgbReserved[14];
        }
    }
}
