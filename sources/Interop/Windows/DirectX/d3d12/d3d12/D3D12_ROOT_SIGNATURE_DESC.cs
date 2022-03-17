// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_ROOT_SIGNATURE_DESC.xml' path='doc/member[@name="D3D12_ROOT_SIGNATURE_DESC"]/*' />
public unsafe partial struct D3D12_ROOT_SIGNATURE_DESC
{
    /// <include file='D3D12_ROOT_SIGNATURE_DESC.xml' path='doc/member[@name="D3D12_ROOT_SIGNATURE_DESC.NumParameters"]/*' />
    public uint NumParameters;

    /// <include file='D3D12_ROOT_SIGNATURE_DESC.xml' path='doc/member[@name="D3D12_ROOT_SIGNATURE_DESC.pParameters"]/*' />
    [NativeTypeName("const D3D12_ROOT_PARAMETER *")]
    public D3D12_ROOT_PARAMETER* pParameters;

    /// <include file='D3D12_ROOT_SIGNATURE_DESC.xml' path='doc/member[@name="D3D12_ROOT_SIGNATURE_DESC.NumStaticSamplers"]/*' />
    public uint NumStaticSamplers;

    /// <include file='D3D12_ROOT_SIGNATURE_DESC.xml' path='doc/member[@name="D3D12_ROOT_SIGNATURE_DESC.pStaticSamplers"]/*' />
    [NativeTypeName("const D3D12_STATIC_SAMPLER_DESC *")]
    public D3D12_STATIC_SAMPLER_DESC* pStaticSamplers;

    /// <include file='D3D12_ROOT_SIGNATURE_DESC.xml' path='doc/member[@name="D3D12_ROOT_SIGNATURE_DESC.Flags"]/*' />
    public D3D12_ROOT_SIGNATURE_FLAGS Flags;
}
