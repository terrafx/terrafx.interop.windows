// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_SERIALIZED_RAYTRACING_ACCELERATION_STRUCTURE_HEADER.xml' path='doc/member[@name="D3D12_SERIALIZED_RAYTRACING_ACCELERATION_STRUCTURE_HEADER"]/*' />
public partial struct D3D12_SERIALIZED_RAYTRACING_ACCELERATION_STRUCTURE_HEADER
{
    /// <include file='D3D12_SERIALIZED_RAYTRACING_ACCELERATION_STRUCTURE_HEADER.xml' path='doc/member[@name="D3D12_SERIALIZED_RAYTRACING_ACCELERATION_STRUCTURE_HEADER.DriverMatchingIdentifier"]/*' />
    public D3D12_SERIALIZED_DATA_DRIVER_MATCHING_IDENTIFIER DriverMatchingIdentifier;

    /// <include file='D3D12_SERIALIZED_RAYTRACING_ACCELERATION_STRUCTURE_HEADER.xml' path='doc/member[@name="D3D12_SERIALIZED_RAYTRACING_ACCELERATION_STRUCTURE_HEADER.SerializedSizeInBytesIncludingHeader"]/*' />
    [NativeTypeName("UINT64")]
    public ulong SerializedSizeInBytesIncludingHeader;

    /// <include file='D3D12_SERIALIZED_RAYTRACING_ACCELERATION_STRUCTURE_HEADER.xml' path='doc/member[@name="D3D12_SERIALIZED_RAYTRACING_ACCELERATION_STRUCTURE_HEADER.DeserializedSizeInBytes"]/*' />
    [NativeTypeName("UINT64")]
    public ulong DeserializedSizeInBytes;

    /// <include file='D3D12_SERIALIZED_RAYTRACING_ACCELERATION_STRUCTURE_HEADER.xml' path='doc/member[@name="D3D12_SERIALIZED_RAYTRACING_ACCELERATION_STRUCTURE_HEADER.NumBottomLevelAccelerationStructurePointersAfterHeader"]/*' />
    [NativeTypeName("UINT64")]
    public ulong NumBottomLevelAccelerationStructurePointersAfterHeader;
}
