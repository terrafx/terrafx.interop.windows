// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ProcessSnapshot.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct PSS_VA_SPACE_ENTRY
    {
        [NativeTypeName("void *")]
        public void* BaseAddress;

        [NativeTypeName("void *")]
        public void* AllocationBase;

        [NativeTypeName("DWORD")]
        public uint AllocationProtect;

        [NativeTypeName("ULONG_PTR")]
        public nuint RegionSize;

        [NativeTypeName("DWORD")]
        public uint State;

        [NativeTypeName("DWORD")]
        public uint Protect;

        [NativeTypeName("DWORD")]
        public uint Type;

        [NativeTypeName("DWORD")]
        public uint TimeDateStamp;

        [NativeTypeName("DWORD")]
        public uint SizeOfImage;

        [NativeTypeName("void *")]
        public void* ImageBase;

        [NativeTypeName("DWORD")]
        public uint CheckSum;

        [NativeTypeName("WORD")]
        public ushort MappedFileNameLength;

        [NativeTypeName("const wchar_t *")]
        public ushort* MappedFileName;
    }
}
