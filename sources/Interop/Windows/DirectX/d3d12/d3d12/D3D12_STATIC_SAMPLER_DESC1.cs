// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_STATIC_SAMPLER_DESC1.xml' path='doc/member[@name="D3D12_STATIC_SAMPLER_DESC1"]/*' />
public partial struct D3D12_STATIC_SAMPLER_DESC1
{
    /// <include file='D3D12_STATIC_SAMPLER_DESC1.xml' path='doc/member[@name="D3D12_STATIC_SAMPLER_DESC1.Filter"]/*' />
    public D3D12_FILTER Filter;

    /// <include file='D3D12_STATIC_SAMPLER_DESC1.xml' path='doc/member[@name="D3D12_STATIC_SAMPLER_DESC1.AddressU"]/*' />
    public D3D12_TEXTURE_ADDRESS_MODE AddressU;

    /// <include file='D3D12_STATIC_SAMPLER_DESC1.xml' path='doc/member[@name="D3D12_STATIC_SAMPLER_DESC1.AddressV"]/*' />
    public D3D12_TEXTURE_ADDRESS_MODE AddressV;

    /// <include file='D3D12_STATIC_SAMPLER_DESC1.xml' path='doc/member[@name="D3D12_STATIC_SAMPLER_DESC1.AddressW"]/*' />
    public D3D12_TEXTURE_ADDRESS_MODE AddressW;

    /// <include file='D3D12_STATIC_SAMPLER_DESC1.xml' path='doc/member[@name="D3D12_STATIC_SAMPLER_DESC1.MipLODBias"]/*' />
    public float MipLODBias;

    /// <include file='D3D12_STATIC_SAMPLER_DESC1.xml' path='doc/member[@name="D3D12_STATIC_SAMPLER_DESC1.MaxAnisotropy"]/*' />
    public uint MaxAnisotropy;

    /// <include file='D3D12_STATIC_SAMPLER_DESC1.xml' path='doc/member[@name="D3D12_STATIC_SAMPLER_DESC1.ComparisonFunc"]/*' />
    public D3D12_COMPARISON_FUNC ComparisonFunc;

    /// <include file='D3D12_STATIC_SAMPLER_DESC1.xml' path='doc/member[@name="D3D12_STATIC_SAMPLER_DESC1.BorderColor"]/*' />
    public D3D12_STATIC_BORDER_COLOR BorderColor;

    /// <include file='D3D12_STATIC_SAMPLER_DESC1.xml' path='doc/member[@name="D3D12_STATIC_SAMPLER_DESC1.MinLOD"]/*' />
    public float MinLOD;

    /// <include file='D3D12_STATIC_SAMPLER_DESC1.xml' path='doc/member[@name="D3D12_STATIC_SAMPLER_DESC1.MaxLOD"]/*' />
    public float MaxLOD;

    /// <include file='D3D12_STATIC_SAMPLER_DESC1.xml' path='doc/member[@name="D3D12_STATIC_SAMPLER_DESC1.ShaderRegister"]/*' />
    public uint ShaderRegister;

    /// <include file='D3D12_STATIC_SAMPLER_DESC1.xml' path='doc/member[@name="D3D12_STATIC_SAMPLER_DESC1.RegisterSpace"]/*' />
    public uint RegisterSpace;

    /// <include file='D3D12_STATIC_SAMPLER_DESC1.xml' path='doc/member[@name="D3D12_STATIC_SAMPLER_DESC1.ShaderVisibility"]/*' />
    public D3D12_SHADER_VISIBILITY ShaderVisibility;

    /// <include file='D3D12_STATIC_SAMPLER_DESC1.xml' path='doc/member[@name="D3D12_STATIC_SAMPLER_DESC1.Flags"]/*' />
    public D3D12_SAMPLER_FLAGS Flags;
}
