// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [StructLayout(LayoutKind.Explicit)]
    public partial struct IMAGE_AUX_SYMBOL_EX
    {
        [FieldOffset(0)]
        [NativeTypeName("struct (anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/winnt.h:17425:5)")]
        public _Sym_e__Union Sym;

        [FieldOffset(0)]
        [NativeTypeName("struct (anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/winnt.h:17430:5)")]
        public _File_e__Union File;

        [FieldOffset(0)]
        [NativeTypeName("struct (anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/winnt.h:17433:5)")]
        public _Section_e__Union Section;

        [FieldOffset(0)]
        [NativeTypeName("_IMAGE_AUX_SYMBOL_EX::(anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/winnt.h:17444:5)")]
        public _Anonymous_e__Union Anonymous;

        [FieldOffset(0)]
        [NativeTypeName("struct (anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/winnt.h:17448:5)")]
        public _CRC_e__Union CRC;

        public unsafe partial struct _Sym_e__Union
        {
            [NativeTypeName("DWORD")]
            public uint WeakDefaultSymIndex;

            [NativeTypeName("DWORD")]
            public uint WeakSearchType;

            [NativeTypeName("BYTE [12]")]
            public fixed byte rgbReserved[12];
        }

        public unsafe partial struct _File_e__Union
        {
            [NativeTypeName("BYTE [20]")]
            public fixed byte Name[20];
        }

        public unsafe partial struct _Section_e__Union
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

            [NativeTypeName("BYTE [2]")]
            public fixed byte rgbReserved[2];
        }

        public unsafe partial struct _Anonymous_e__Union
        {
            public IMAGE_AUX_SYMBOL_TOKEN_DEF TokenDef;

            [NativeTypeName("BYTE [2]")]
            public fixed byte rgbReserved[2];
        }

        public unsafe partial struct _CRC_e__Union
        {
            [NativeTypeName("DWORD")]
            public uint crc;

            [NativeTypeName("BYTE [16]")]
            public fixed byte rgbReserved[16];
        }
    }
}
