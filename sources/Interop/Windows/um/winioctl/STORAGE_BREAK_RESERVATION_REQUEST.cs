// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct STORAGE_BREAK_RESERVATION_REQUEST
    {
        [NativeTypeName("DWORD")]
        public uint Length;

        [NativeTypeName("BYTE")]
        public byte _unused;

        [NativeTypeName("BYTE")]
        public byte PathId;

        [NativeTypeName("BYTE")]
        public byte TargetId;

        [NativeTypeName("BYTE")]
        public byte Lun;
    }
}
