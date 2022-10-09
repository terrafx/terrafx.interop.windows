// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dxcore_interface.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;

namespace TerraFX.Interop.DirectX;

/// <include file='DXCoreHardwareID.xml' path='doc/member[@name="DXCoreHardwareID"]/*' />
[SupportedOSPlatform("windows10.0.19041.0")]
public partial struct DXCoreHardwareID
{
    /// <include file='DXCoreHardwareID.xml' path='doc/member[@name="DXCoreHardwareID.vendorID"]/*' />
    [NativeTypeName("uint32_t")]
    public uint vendorID;

    /// <include file='DXCoreHardwareID.xml' path='doc/member[@name="DXCoreHardwareID.deviceID"]/*' />
    [NativeTypeName("uint32_t")]
    public uint deviceID;

    /// <include file='DXCoreHardwareID.xml' path='doc/member[@name="DXCoreHardwareID.subSysID"]/*' />
    [NativeTypeName("uint32_t")]
    public uint subSysID;

    /// <include file='DXCoreHardwareID.xml' path='doc/member[@name="DXCoreHardwareID.revision"]/*' />
    [NativeTypeName("uint32_t")]
    public uint revision;
}
