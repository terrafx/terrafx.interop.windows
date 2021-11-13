// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows
{
    public unsafe partial struct STORAGE_HW_FIRMWARE_DOWNLOAD_V2
    {
        [NativeTypeName("DWORD")]
        public uint Version;

        [NativeTypeName("DWORD")]
        public uint Size;

        [NativeTypeName("DWORD")]
        public uint Flags;

        public byte Slot;

        [NativeTypeName("BYTE [3]")]
        public fixed byte Reserved[3];

        [NativeTypeName("DWORDLONG")]
        public ulong Offset;

        [NativeTypeName("DWORDLONG")]
        public ulong BufferSize;

        [NativeTypeName("DWORD")]
        public uint ImageSize;

        [NativeTypeName("DWORD")]
        public uint Reserved2;

        [NativeTypeName("BYTE [1]")]
        public fixed byte ImageBuffer[1];
    }
}
