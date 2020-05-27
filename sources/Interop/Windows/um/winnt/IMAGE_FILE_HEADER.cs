// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct IMAGE_FILE_HEADER
    {
        [NativeTypeName("WORD")]
        public ushort Machine;

        [NativeTypeName("WORD")]
        public ushort NumberOfSections;

        [NativeTypeName("DWORD")]
        public uint TimeDateStamp;

        [NativeTypeName("DWORD")]
        public uint PointerToSymbolTable;

        [NativeTypeName("DWORD")]
        public uint NumberOfSymbols;

        [NativeTypeName("WORD")]
        public ushort SizeOfOptionalHeader;

        [NativeTypeName("WORD")]
        public ushort Characteristics;
    }
}
