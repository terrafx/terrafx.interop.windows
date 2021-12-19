// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dxcore_interface.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

/// <include file='DXCoreHardwareIDParts.xml' path='doc/member[@name="DXCoreHardwareIDParts"]/*' />
public partial struct DXCoreHardwareIDParts
{
    /// <include file='DXCoreHardwareIDParts.xml' path='doc/member[@name="DXCoreHardwareIDParts.vendorID"]/*' />
    [NativeTypeName("uint32_t")]
    public uint vendorID;

    /// <include file='DXCoreHardwareIDParts.xml' path='doc/member[@name="DXCoreHardwareIDParts.deviceID"]/*' />
    [NativeTypeName("uint32_t")]
    public uint deviceID;

    /// <include file='DXCoreHardwareIDParts.xml' path='doc/member[@name="DXCoreHardwareIDParts.subSystemID"]/*' />
    [NativeTypeName("uint32_t")]
    public uint subSystemID;

    /// <include file='DXCoreHardwareIDParts.xml' path='doc/member[@name="DXCoreHardwareIDParts.subVendorID"]/*' />
    [NativeTypeName("uint32_t")]
    public uint subVendorID;

    /// <include file='DXCoreHardwareIDParts.xml' path='doc/member[@name="DXCoreHardwareIDParts.revisionID"]/*' />
    [NativeTypeName("uint32_t")]
    public uint revisionID;
}
