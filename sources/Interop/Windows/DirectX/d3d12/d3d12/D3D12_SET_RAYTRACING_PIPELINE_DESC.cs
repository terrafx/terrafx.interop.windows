// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.616.0
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_SET_RAYTRACING_PIPELINE_DESC.xml' path='doc/member[@name="D3D12_SET_RAYTRACING_PIPELINE_DESC"]/*' />
public partial struct D3D12_SET_RAYTRACING_PIPELINE_DESC
{
    /// <include file='D3D12_SET_RAYTRACING_PIPELINE_DESC.xml' path='doc/member[@name="D3D12_SET_RAYTRACING_PIPELINE_DESC.ProgramIdentifier"]/*' />
    public D3D12_PROGRAM_IDENTIFIER ProgramIdentifier;
}
