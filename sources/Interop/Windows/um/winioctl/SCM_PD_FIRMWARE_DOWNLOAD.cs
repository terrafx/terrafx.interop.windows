// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct SCM_PD_FIRMWARE_DOWNLOAD
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

        [NativeTypeName("DWORD64")]
        public ulong Offset;

        [NativeTypeName("DWORD")]
        public uint FirmwareImageSizeInBytes;

        [NativeTypeName("BYTE [1]")]
        public fixed byte FirmwareImage[1];
    }
}
