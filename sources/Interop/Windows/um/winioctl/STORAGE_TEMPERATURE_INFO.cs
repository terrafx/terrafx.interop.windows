// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct STORAGE_TEMPERATURE_INFO
    {
        [NativeTypeName("WORD")]
        public ushort Index;

        public short Temperature;

        public short OverThreshold;

        public short UnderThreshold;

        [NativeTypeName("BOOLEAN")]
        public byte OverThresholdChangable;

        [NativeTypeName("BOOLEAN")]
        public byte UnderThresholdChangable;

        [NativeTypeName("BOOLEAN")]
        public byte EventGenerated;

        public byte Reserved0;

        [NativeTypeName("DWORD")]
        public uint Reserved1;
    }
}
