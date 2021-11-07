// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;

namespace TerraFX.Interop
{
    [SupportedOSPlatform("windows10.0")]
    public unsafe partial struct STORAGE_PHYSICAL_DEVICE_DATA
    {
        [NativeTypeName("DWORD")]
        public uint DeviceId;

        [NativeTypeName("DWORD")]
        public uint Role;

        public STORAGE_COMPONENT_HEALTH_STATUS HealthStatus;

        public STORAGE_PROTOCOL_TYPE CommandProtocol;

        public STORAGE_SPEC_VERSION SpecVersion;

        public STORAGE_DEVICE_FORM_FACTOR FormFactor;

        [NativeTypeName("BYTE [8]")]
        public fixed byte Vendor[8];

        [NativeTypeName("BYTE [40]")]
        public fixed byte Model[40];

        [NativeTypeName("BYTE [16]")]
        public fixed byte FirmwareRevision[16];

        [NativeTypeName("DWORDLONG")]
        public ulong Capacity;

        [NativeTypeName("BYTE [32]")]
        public fixed byte PhysicalLocation[32];

        [NativeTypeName("DWORD [2]")]
        public fixed uint Reserved[2];
    }
}
