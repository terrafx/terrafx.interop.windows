// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct STORAGE_TEMPERATURE_INFO
    {
        [NativeTypeName("WORD")]
        public ushort Index;

        [NativeTypeName("SHORT")]
        public short Temperature;

        [NativeTypeName("SHORT")]
        public short OverThreshold;

        [NativeTypeName("SHORT")]
        public short UnderThreshold;

        [NativeTypeName("BOOLEAN")]
        public byte OverThresholdChangable;

        [NativeTypeName("BOOLEAN")]
        public byte UnderThresholdChangable;

        [NativeTypeName("BOOLEAN")]
        public byte EventGenerated;

        [NativeTypeName("BYTE")]
        public byte Reserved0;

        [NativeTypeName("DWORD")]
        public uint Reserved1;
    }
}
