// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.611.2
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_ROOT_SIGNATURE_DESC2.xml' path='doc/member[@name="D3D12_ROOT_SIGNATURE_DESC2"]/*' />
public unsafe partial struct D3D12_ROOT_SIGNATURE_DESC2
{
    /// <include file='D3D12_ROOT_SIGNATURE_DESC2.xml' path='doc/member[@name="D3D12_ROOT_SIGNATURE_DESC2.NumParameters"]/*' />
    public uint NumParameters;

    /// <include file='D3D12_ROOT_SIGNATURE_DESC2.xml' path='doc/member[@name="D3D12_ROOT_SIGNATURE_DESC2.pParameters"]/*' />
    [NativeTypeName("const D3D12_ROOT_PARAMETER1 *")]
    public D3D12_ROOT_PARAMETER1* pParameters;

    /// <include file='D3D12_ROOT_SIGNATURE_DESC2.xml' path='doc/member[@name="D3D12_ROOT_SIGNATURE_DESC2.NumStaticSamplers"]/*' />
    public uint NumStaticSamplers;

    /// <include file='D3D12_ROOT_SIGNATURE_DESC2.xml' path='doc/member[@name="D3D12_ROOT_SIGNATURE_DESC2.pStaticSamplers"]/*' />
    [NativeTypeName("const D3D12_STATIC_SAMPLER_DESC1 *")]
    public D3D12_STATIC_SAMPLER_DESC1* pStaticSamplers;

    /// <include file='D3D12_ROOT_SIGNATURE_DESC2.xml' path='doc/member[@name="D3D12_ROOT_SIGNATURE_DESC2.Flags"]/*' />
    public D3D12_ROOT_SIGNATURE_FLAGS Flags;
}
