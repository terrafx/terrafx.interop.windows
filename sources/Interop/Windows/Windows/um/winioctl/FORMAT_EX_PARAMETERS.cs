// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows
{
    public unsafe partial struct FORMAT_EX_PARAMETERS
    {
        public MEDIA_TYPE MediaType;

        [NativeTypeName("DWORD")]
        public uint StartCylinderNumber;

        [NativeTypeName("DWORD")]
        public uint EndCylinderNumber;

        [NativeTypeName("DWORD")]
        public uint StartHeadNumber;

        [NativeTypeName("DWORD")]
        public uint EndHeadNumber;

        [NativeTypeName("WORD")]
        public ushort FormatGapLength;

        [NativeTypeName("WORD")]
        public ushort SectorsPerTrack;

        [NativeTypeName("WORD [1]")]
        public fixed ushort SectorNumber[1];
    }
}
