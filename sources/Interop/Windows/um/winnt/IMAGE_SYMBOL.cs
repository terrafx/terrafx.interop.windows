// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [StructLayout(LayoutKind.Sequential, Pack = 2)]
    public partial struct IMAGE_SYMBOL
    {
        [NativeTypeName("union (anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.20348.0/um/winnt.h:18664:5)")]
        public _N_e__Union N;

        [NativeTypeName("DWORD")]
        public uint Value;

        public short SectionNumber;

        [NativeTypeName("WORD")]
        public ushort Type;

        public byte StorageClass;

        public byte NumberOfAuxSymbols;

        [StructLayout(LayoutKind.Explicit, Pack = 2)]
        public unsafe partial struct _N_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("BYTE [8]")]
            public fixed byte ShortName[8];

            [FieldOffset(0)]
            [NativeTypeName("struct (anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.20348.0/um/winnt.h:18666:9)")]
            public _Name_e__Struct Name;

            [FieldOffset(0)]
            [NativeTypeName("DWORD [2]")]
            public fixed uint LongName[2];

            [StructLayout(LayoutKind.Sequential, Pack = 2)]
            public partial struct _Name_e__Struct
            {
                [NativeTypeName("DWORD")]
                public uint Short;

                [NativeTypeName("DWORD")]
                public uint Long;
            }
        }
    }
}
