// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.618.2
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_PROGRAM_TYPE.xml' path='doc/member[@name="D3D12_PROGRAM_TYPE"]/*' />
public enum D3D12_PROGRAM_TYPE
{
    /// <include file='D3D12_PROGRAM_TYPE.xml' path='doc/member[@name="D3D12_PROGRAM_TYPE.D3D12_PROGRAM_TYPE_GENERIC_PIPELINE"]/*' />
    D3D12_PROGRAM_TYPE_GENERIC_PIPELINE = 1,

    /// <include file='D3D12_PROGRAM_TYPE.xml' path='doc/member[@name="D3D12_PROGRAM_TYPE.D3D12_PROGRAM_TYPE_RAYTRACING_PIPELINE"]/*' />
    D3D12_PROGRAM_TYPE_RAYTRACING_PIPELINE = 4,

    /// <include file='D3D12_PROGRAM_TYPE.xml' path='doc/member[@name="D3D12_PROGRAM_TYPE.D3D12_PROGRAM_TYPE_WORK_GRAPH"]/*' />
    D3D12_PROGRAM_TYPE_WORK_GRAPH = 5,
}
