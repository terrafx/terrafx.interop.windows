// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows
{
    public unsafe partial struct IMAGE_SECTION_HEADER
    {
        [NativeTypeName("BYTE [8]")]
        public fixed byte Name[8];

        [NativeTypeName("union (anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.20348.0/um/winnt.h:18578:5)")]
        public _Misc_e__Union Misc;

        [NativeTypeName("DWORD")]
        public uint VirtualAddress;

        [NativeTypeName("DWORD")]
        public uint SizeOfRawData;

        [NativeTypeName("DWORD")]
        public uint PointerToRawData;

        [NativeTypeName("DWORD")]
        public uint PointerToRelocations;

        [NativeTypeName("DWORD")]
        public uint PointerToLinenumbers;

        [NativeTypeName("WORD")]
        public ushort NumberOfRelocations;

        [NativeTypeName("WORD")]
        public ushort NumberOfLinenumbers;

        [NativeTypeName("DWORD")]
        public uint Characteristics;

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Misc_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("DWORD")]
            public uint PhysicalAddress;

            [FieldOffset(0)]
            [NativeTypeName("DWORD")]
            public uint VirtualSize;
        }
    }
}
