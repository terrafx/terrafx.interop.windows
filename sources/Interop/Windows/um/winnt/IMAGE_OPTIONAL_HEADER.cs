// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public partial struct IMAGE_OPTIONAL_HEADER
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
        public uint ImageBase;

        [NativeTypeName("DWORD")]
        public uint SectionAlignment;

        [NativeTypeName("DWORD")]
        public uint FileAlignment;

        [NativeTypeName("WORD")]
        public ushort MajorOperatingSystemVersion;

        [NativeTypeName("WORD")]
        public ushort MinorOperatingSystemVersion;

        [NativeTypeName("WORD")]
        public ushort MajorImageVersion;

        [NativeTypeName("WORD")]
        public ushort MinorImageVersion;

        [NativeTypeName("WORD")]
        public ushort MajorSubsystemVersion;

        [NativeTypeName("WORD")]
        public ushort MinorSubsystemVersion;

        [NativeTypeName("DWORD")]
        public uint Win32VersionValue;

        [NativeTypeName("DWORD")]
        public uint SizeOfImage;

        [NativeTypeName("DWORD")]
        public uint SizeOfHeaders;

        [NativeTypeName("DWORD")]
        public uint CheckSum;

        [NativeTypeName("WORD")]
        public ushort Subsystem;

        [NativeTypeName("WORD")]
        public ushort DllCharacteristics;

        [NativeTypeName("DWORD")]
        public uint SizeOfStackReserve;

        [NativeTypeName("DWORD")]
        public uint SizeOfStackCommit;

        [NativeTypeName("DWORD")]
        public uint SizeOfHeapReserve;

        [NativeTypeName("DWORD")]
        public uint SizeOfHeapCommit;

        [NativeTypeName("DWORD")]
        public uint LoaderFlags;

        [NativeTypeName("DWORD")]
        public uint NumberOfRvaAndSizes;

        [NativeTypeName("IMAGE_DATA_DIRECTORY [16]")]
        public _DataDirectory_e__FixedBuffer DataDirectory;

        public partial struct _DataDirectory_e__FixedBuffer
        {
            internal IMAGE_DATA_DIRECTORY e0;
            internal IMAGE_DATA_DIRECTORY e1;
            internal IMAGE_DATA_DIRECTORY e2;
            internal IMAGE_DATA_DIRECTORY e3;
            internal IMAGE_DATA_DIRECTORY e4;
            internal IMAGE_DATA_DIRECTORY e5;
            internal IMAGE_DATA_DIRECTORY e6;
            internal IMAGE_DATA_DIRECTORY e7;
            internal IMAGE_DATA_DIRECTORY e8;
            internal IMAGE_DATA_DIRECTORY e9;
            internal IMAGE_DATA_DIRECTORY e10;
            internal IMAGE_DATA_DIRECTORY e11;
            internal IMAGE_DATA_DIRECTORY e12;
            internal IMAGE_DATA_DIRECTORY e13;
            internal IMAGE_DATA_DIRECTORY e14;
            internal IMAGE_DATA_DIRECTORY e15;

            public ref IMAGE_DATA_DIRECTORY this[int index] => ref AsSpan()[index];

            public Span<IMAGE_DATA_DIRECTORY> AsSpan() => MemoryMarshal.CreateSpan(ref e0, 16);
        }
    }
}
