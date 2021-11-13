// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/iphlpapi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows
{
    [SupportedOSPlatform("windows10.0.22000.0")]
    public partial struct INTERFACE_TIMESTAMP_CAPABILITIES
    {
        [NativeTypeName("ULONG64")]
        public ulong HardwareClockFrequencyHz;

        [NativeTypeName("BOOLEAN")]
        public byte SupportsCrossTimestamp;

        public INTERFACE_HARDWARE_TIMESTAMP_CAPABILITIES HardwareCapabilities;

        public INTERFACE_SOFTWARE_TIMESTAMP_CAPABILITIES SoftwareCapabilities;
    }
}
