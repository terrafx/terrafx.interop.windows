// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dxcore_interface.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;

namespace TerraFX.Interop
{
    [SupportedOSPlatform("windows10.0.19041.0")]
    public partial struct DXCoreHardwareID
    {
        [NativeTypeName("uint32_t")]
        public uint vendorID;

        [NativeTypeName("uint32_t")]
        public uint deviceID;

        [NativeTypeName("uint32_t")]
        public uint subSysID;

        [NativeTypeName("uint32_t")]
        public uint revision;
    }
}
