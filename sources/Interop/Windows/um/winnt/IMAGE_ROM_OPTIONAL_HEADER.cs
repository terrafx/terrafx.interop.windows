// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct IMAGE_ROM_OPTIONAL_HEADER
    {
        [NativeTypeName("WORD")]
        public ushort Magic;

        [NativeTypeName("BYTE")]
        public byte MajorLinkerVersion;

        [NativeTypeName("BYTE")]
        public byte MinorLinkerVersion;

        [NativeTypeName("DWORD")]
        public uint SizeOfCode;

        [NativeTypeName("DWORD")]
        public uint SizeOfInitializedData;

        [NativeTypeName("DWORD")]
        public uint SizeOfUninitializedData;

        [NativeTypeName("DWORD")]
        public uint AddressOfEntryPoint;

        [NativeTypeName("DWORD")]
        public uint BaseOfCode;

        [NativeTypeName("DWORD")]
        public uint BaseOfData;

        [NativeTypeName("DWORD")]
        public uint BaseOfBss;

        [NativeTypeName("DWORD")]
        public uint GprMask;

        [NativeTypeName("DWORD [4]")]
        public fixed uint CprMask[4];

        [NativeTypeName("DWORD")]
        public uint GpValue;
    }
}
