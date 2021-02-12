// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct STORAGE_MINIPORT_DESCRIPTOR
    {
        [NativeTypeName("DWORD")]
        public uint Version;

        [NativeTypeName("DWORD")]
        public uint Size;

        public STORAGE_PORT_CODE_SET Portdriver;

        [NativeTypeName("BOOLEAN")]
        public byte LUNResetSupported;

        [NativeTypeName("BOOLEAN")]
        public byte TargetResetSupported;

        [NativeTypeName("WORD")]
        public ushort IoTimeoutValue;

        [NativeTypeName("BOOLEAN")]
        public byte ExtraIoInfoSupported;

        [NativeTypeName("BYTE [3]")]
        public fixed byte Reserved0[3];

        [NativeTypeName("DWORD")]
        public uint Reserved1;
    }
}
