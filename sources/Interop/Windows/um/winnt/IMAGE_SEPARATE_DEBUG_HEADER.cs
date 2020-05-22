// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct IMAGE_SEPARATE_DEBUG_HEADER
    {
        [NativeTypeName("WORD")]
        public ushort Signature;

        [NativeTypeName("WORD")]
        public ushort Flags;

        [NativeTypeName("WORD")]
        public ushort Machine;

        [NativeTypeName("WORD")]
        public ushort Characteristics;

        [NativeTypeName("DWORD")]
        public uint TimeDateStamp;

        [NativeTypeName("DWORD")]
        public uint CheckSum;

        [NativeTypeName("DWORD")]
        public uint ImageBase;

        [NativeTypeName("DWORD")]
        public uint SizeOfImage;

        [NativeTypeName("DWORD")]
        public uint NumberOfSections;

        [NativeTypeName("DWORD")]
        public uint ExportedNamesSize;

        [NativeTypeName("DWORD")]
        public uint DebugDirectorySize;

        [NativeTypeName("DWORD")]
        public uint SectionAlignment;

        [NativeTypeName("DWORD [2]")]
        public fixed uint Reserved[2];
    }
}
