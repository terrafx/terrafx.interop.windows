// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public partial struct IMAGE_SYMBOL
    {
        [NativeTypeName("union (anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/um/winnt.h:17210:5)")]
        public _N_e__Union N;

        [NativeTypeName("DWORD")]
        public uint Value;

        [NativeTypeName("SHORT")]
        public short SectionNumber;

        [NativeTypeName("WORD")]
        public ushort Type;

        [NativeTypeName("BYTE")]
        public byte StorageClass;

        [NativeTypeName("BYTE")]
        public byte NumberOfAuxSymbols;

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _N_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("BYTE [8]")]
            public fixed byte ShortName[8];

            [FieldOffset(0)]
            [NativeTypeName("struct (anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/um/winnt.h:17212:9)")]
            public _Name_e__Union Name;

            [FieldOffset(0)]
            [NativeTypeName("DWORD [2]")]
            public fixed uint LongName[2];

            public partial struct _Name_e__Union
            {
                [NativeTypeName("DWORD")]
                public uint Short;

                [NativeTypeName("DWORD")]
                public uint Long;
            }
        }
    }
}
