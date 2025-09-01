// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.616.0
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_SERIALIZED_DATA_TYPE.xml' path='doc/member[@name="D3D12_SERIALIZED_DATA_TYPE"]/*' />
public enum D3D12_SERIALIZED_DATA_TYPE
{
    /// <include file='D3D12_SERIALIZED_DATA_TYPE.xml' path='doc/member[@name="D3D12_SERIALIZED_DATA_TYPE.D3D12_SERIALIZED_DATA_RAYTRACING_ACCELERATION_STRUCTURE"]/*' />
    D3D12_SERIALIZED_DATA_RAYTRACING_ACCELERATION_STRUCTURE = 0,

    /// <include file='D3D12_SERIALIZED_DATA_TYPE.xml' path='doc/member[@name="D3D12_SERIALIZED_DATA_TYPE.D3D12_SERIALIZED_DATA_APPLICATION_SPECIFIC_DRIVER_STATE"]/*' />
    D3D12_SERIALIZED_DATA_APPLICATION_SPECIFIC_DRIVER_STATE = 0x1,
}
