// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_RAYTRACING_ACCELERATION_STRUCTURE_TYPE.xml' path='doc/member[@name="D3D12_RAYTRACING_ACCELERATION_STRUCTURE_TYPE"]/*' />
public enum D3D12_RAYTRACING_ACCELERATION_STRUCTURE_TYPE
{
    /// <include file='D3D12_RAYTRACING_ACCELERATION_STRUCTURE_TYPE.xml' path='doc/member[@name="D3D12_RAYTRACING_ACCELERATION_STRUCTURE_TYPE.D3D12_RAYTRACING_ACCELERATION_STRUCTURE_TYPE_TOP_LEVEL"]/*' />
    D3D12_RAYTRACING_ACCELERATION_STRUCTURE_TYPE_TOP_LEVEL = 0,

    /// <include file='D3D12_RAYTRACING_ACCELERATION_STRUCTURE_TYPE.xml' path='doc/member[@name="D3D12_RAYTRACING_ACCELERATION_STRUCTURE_TYPE.D3D12_RAYTRACING_ACCELERATION_STRUCTURE_TYPE_BOTTOM_LEVEL"]/*' />
    D3D12_RAYTRACING_ACCELERATION_STRUCTURE_TYPE_BOTTOM_LEVEL = 0x1,
}
