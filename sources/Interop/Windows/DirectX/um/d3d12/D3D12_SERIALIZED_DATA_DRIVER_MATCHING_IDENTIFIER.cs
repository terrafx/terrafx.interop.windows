// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_SERIALIZED_DATA_DRIVER_MATCHING_IDENTIFIER.xml' path='doc/member[@name="D3D12_SERIALIZED_DATA_DRIVER_MATCHING_IDENTIFIER"]/*' />
public unsafe partial struct D3D12_SERIALIZED_DATA_DRIVER_MATCHING_IDENTIFIER
{
    /// <include file='D3D12_SERIALIZED_DATA_DRIVER_MATCHING_IDENTIFIER.xml' path='doc/member[@name="D3D12_SERIALIZED_DATA_DRIVER_MATCHING_IDENTIFIER.DriverOpaqueGUID"]/*' />
    public Guid DriverOpaqueGUID;

    /// <include file='D3D12_SERIALIZED_DATA_DRIVER_MATCHING_IDENTIFIER.xml' path='doc/member[@name="D3D12_SERIALIZED_DATA_DRIVER_MATCHING_IDENTIFIER.DriverOpaqueVersioningData"]/*' />
    [NativeTypeName("BYTE[16]")]
    public fixed byte DriverOpaqueVersioningData[16];
}
