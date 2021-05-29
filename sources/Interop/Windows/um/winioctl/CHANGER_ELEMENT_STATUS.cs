// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct CHANGER_ELEMENT_STATUS
    {
        public CHANGER_ELEMENT Element;

        public CHANGER_ELEMENT SrcElementAddress;

        [NativeTypeName("DWORD")]
        public uint Flags;

        [NativeTypeName("DWORD")]
        public uint ExceptionCode;

        [NativeTypeName("BYTE")]
        public byte TargetId;

        [NativeTypeName("BYTE")]
        public byte Lun;

        [NativeTypeName("WORD")]
        public ushort Reserved;

        [NativeTypeName("BYTE [36]")]
        public fixed byte PrimaryVolumeID[36];

        [NativeTypeName("BYTE [36]")]
        public fixed byte AlternateVolumeID[36];
    }
}
