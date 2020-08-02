// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct STORAGE_ZONE_DESCRIPTOR
    {
        [NativeTypeName("DWORD")]
        public uint Size;

        public STORAGE_ZONE_TYPES ZoneType;

        public STORAGE_ZONE_CONDITION ZoneCondition;

        [NativeTypeName("BOOLEAN")]
        public byte ResetWritePointerRecommend;

        [NativeTypeName("BYTE [3]")]
        public fixed byte Reserved0[3];

        [NativeTypeName("DWORDLONG")]
        public ulong ZoneSize;

        [NativeTypeName("DWORDLONG")]
        public ulong WritePointerOffset;
    }
}
