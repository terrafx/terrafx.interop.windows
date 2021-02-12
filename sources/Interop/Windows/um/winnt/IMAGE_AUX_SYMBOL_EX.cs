// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct IMAGE_AUX_SYMBOL_EX
    {
        [FieldOffset(0)]
        [NativeTypeName("struct (anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/winnt.h:17616:5)")]
        public _Sym_e__Struct Sym;

        [FieldOffset(0)]
        [NativeTypeName("struct (anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/winnt.h:17621:5)")]
        public _File_e__Struct File;

        [FieldOffset(0)]
        [NativeTypeName("struct (anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/winnt.h:17624:5)")]
        public _Section_e__Struct Section;

        [FieldOffset(0)]
        [NativeTypeName("_IMAGE_AUX_SYMBOL_EX::(anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/winnt.h:17635:5)")]
        public _Anonymous_e__Struct Anonymous;

        public ref IMAGE_AUX_SYMBOL_TOKEN_DEF TokenDef
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.TokenDef, 1));
            }
        }

        public Span<byte> rgbReserved
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return MemoryMarshal.CreateSpan(ref Anonymous.rgbReserved[0], 2);
            }
        }

        [FieldOffset(0)]
        [NativeTypeName("struct (anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/winnt.h:17639:5)")]
        public _CRC_e__Struct CRC;

        [StructLayout(LayoutKind.Sequential, Pack = 2)]
        public unsafe partial struct _Sym_e__Struct
        {
            [NativeTypeName("DWORD")]
            public uint WeakDefaultSymIndex;

            [NativeTypeName("DWORD")]
            public uint WeakSearchType;

            [NativeTypeName("BYTE [12]")]
            public fixed byte rgbReserved[12];
        }

        public unsafe partial struct _File_e__Struct
        {
            [NativeTypeName("BYTE [20]")]
            public fixed byte Name[20];
        }

        [StructLayout(LayoutKind.Sequential, Pack = 2)]
        public unsafe partial struct _Section_e__Struct
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

        public unsafe partial struct _Anonymous_e__Struct
        {
            public IMAGE_AUX_SYMBOL_TOKEN_DEF TokenDef;

            [NativeTypeName("BYTE [2]")]
            public fixed byte rgbReserved[2];
        }

        [StructLayout(LayoutKind.Sequential, Pack = 2)]
        public unsafe partial struct _CRC_e__Struct
        {
            [NativeTypeName("DWORD")]
            public uint crc;

            [NativeTypeName("BYTE [16]")]
            public fixed byte rgbReserved[16];
        }
    }
}
