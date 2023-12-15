// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.611.2
// Original source is Copyright © Microsoft. Licensed under the MIT license

using TerraFX.Interop.Windows;

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_RASTERIZER_DESC1.xml' path='doc/member[@name="D3D12_RASTERIZER_DESC1"]/*' />
public partial struct D3D12_RASTERIZER_DESC1
{
    /// <include file='D3D12_RASTERIZER_DESC1.xml' path='doc/member[@name="D3D12_RASTERIZER_DESC1.FillMode"]/*' />
    public D3D12_FILL_MODE FillMode;

    /// <include file='D3D12_RASTERIZER_DESC1.xml' path='doc/member[@name="D3D12_RASTERIZER_DESC1.CullMode"]/*' />
    public D3D12_CULL_MODE CullMode;

    /// <include file='D3D12_RASTERIZER_DESC1.xml' path='doc/member[@name="D3D12_RASTERIZER_DESC1.FrontCounterClockwise"]/*' />
    public BOOL FrontCounterClockwise;

    /// <include file='D3D12_RASTERIZER_DESC1.xml' path='doc/member[@name="D3D12_RASTERIZER_DESC1.DepthBias"]/*' />
    public float DepthBias;

    /// <include file='D3D12_RASTERIZER_DESC1.xml' path='doc/member[@name="D3D12_RASTERIZER_DESC1.DepthBiasClamp"]/*' />
    public float DepthBiasClamp;

    /// <include file='D3D12_RASTERIZER_DESC1.xml' path='doc/member[@name="D3D12_RASTERIZER_DESC1.SlopeScaledDepthBias"]/*' />
    public float SlopeScaledDepthBias;

    /// <include file='D3D12_RASTERIZER_DESC1.xml' path='doc/member[@name="D3D12_RASTERIZER_DESC1.DepthClipEnable"]/*' />
    public BOOL DepthClipEnable;

    /// <include file='D3D12_RASTERIZER_DESC1.xml' path='doc/member[@name="D3D12_RASTERIZER_DESC1.MultisampleEnable"]/*' />
    public BOOL MultisampleEnable;

    /// <include file='D3D12_RASTERIZER_DESC1.xml' path='doc/member[@name="D3D12_RASTERIZER_DESC1.AntialiasedLineEnable"]/*' />
    public BOOL AntialiasedLineEnable;

    /// <include file='D3D12_RASTERIZER_DESC1.xml' path='doc/member[@name="D3D12_RASTERIZER_DESC1.ForcedSampleCount"]/*' />
    public uint ForcedSampleCount;

    /// <include file='D3D12_RASTERIZER_DESC1.xml' path='doc/member[@name="D3D12_RASTERIZER_DESC1.ConservativeRaster"]/*' />
    public D3D12_CONSERVATIVE_RASTERIZATION_MODE ConservativeRaster;
}
