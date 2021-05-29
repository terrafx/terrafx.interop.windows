// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public partial struct IMAGE_OPTIONAL_HEADER64
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

        [NativeTypeName("ULONGLONG")]
        public ulong ImageBase;

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

        [NativeTypeName("ULONGLONG")]
        public ulong SizeOfStackReserve;

        [NativeTypeName("ULONGLONG")]
        public ulong SizeOfStackCommit;

        [NativeTypeName("ULONGLONG")]
        public ulong SizeOfHeapReserve;

        [NativeTypeName("ULONGLONG")]
        public ulong SizeOfHeapCommit;

        [NativeTypeName("DWORD")]
        public uint LoaderFlags;

        [NativeTypeName("DWORD")]
        public uint NumberOfRvaAndSizes;

        [NativeTypeName("IMAGE_DATA_DIRECTORY [16]")]
        public _DataDirectory_e__FixedBuffer DataDirectory;

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public partial struct _DataDirectory_e__FixedBuffer
        {
            public IMAGE_DATA_DIRECTORY e0;
            public IMAGE_DATA_DIRECTORY e1;
            public IMAGE_DATA_DIRECTORY e2;
            public IMAGE_DATA_DIRECTORY e3;
            public IMAGE_DATA_DIRECTORY e4;
            public IMAGE_DATA_DIRECTORY e5;
            public IMAGE_DATA_DIRECTORY e6;
            public IMAGE_DATA_DIRECTORY e7;
            public IMAGE_DATA_DIRECTORY e8;
            public IMAGE_DATA_DIRECTORY e9;
            public IMAGE_DATA_DIRECTORY e10;
            public IMAGE_DATA_DIRECTORY e11;
            public IMAGE_DATA_DIRECTORY e12;
            public IMAGE_DATA_DIRECTORY e13;
            public IMAGE_DATA_DIRECTORY e14;
            public IMAGE_DATA_DIRECTORY e15;

            public ref IMAGE_DATA_DIRECTORY this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref AsSpan()[index];
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public Span<IMAGE_DATA_DIRECTORY> AsSpan() => MemoryMarshal.CreateSpan(ref e0, 16);
        }
    }
}
