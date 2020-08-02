// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct PHYSICAL_ELEMENT_STATUS_REQUEST
    {
        [NativeTypeName("DWORD")]
        public uint Version;

        [NativeTypeName("DWORD")]
        public uint Size;

        [NativeTypeName("DWORD")]
        public uint StartingElement;

        [NativeTypeName("BYTE")]
        public byte Filter;

        [NativeTypeName("BYTE")]
        public byte ReportType;

        [NativeTypeName("BYTE [2]")]
        public fixed byte Reserved[2];
    }
}
