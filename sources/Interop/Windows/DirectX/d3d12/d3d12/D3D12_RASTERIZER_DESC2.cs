// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.618.5
// Original source is Copyright © Microsoft. Licensed under the MIT license

using TerraFX.Interop.Windows;

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_RASTERIZER_DESC2.xml' path='doc/member[@name="D3D12_RASTERIZER_DESC2"]/*' />
public partial struct D3D12_RASTERIZER_DESC2
{
    /// <include file='D3D12_RASTERIZER_DESC2.xml' path='doc/member[@name="D3D12_RASTERIZER_DESC2.FillMode"]/*' />
    public D3D12_FILL_MODE FillMode;

    /// <include file='D3D12_RASTERIZER_DESC2.xml' path='doc/member[@name="D3D12_RASTERIZER_DESC2.CullMode"]/*' />
    public D3D12_CULL_MODE CullMode;

    /// <include file='D3D12_RASTERIZER_DESC2.xml' path='doc/member[@name="D3D12_RASTERIZER_DESC2.FrontCounterClockwise"]/*' />
    public BOOL FrontCounterClockwise;

    /// <include file='D3D12_RASTERIZER_DESC2.xml' path='doc/member[@name="D3D12_RASTERIZER_DESC2.DepthBias"]/*' />
    public float DepthBias;

    /// <include file='D3D12_RASTERIZER_DESC2.xml' path='doc/member[@name="D3D12_RASTERIZER_DESC2.DepthBiasClamp"]/*' />
    public float DepthBiasClamp;

    /// <include file='D3D12_RASTERIZER_DESC2.xml' path='doc/member[@name="D3D12_RASTERIZER_DESC2.SlopeScaledDepthBias"]/*' />
    public float SlopeScaledDepthBias;

    /// <include file='D3D12_RASTERIZER_DESC2.xml' path='doc/member[@name="D3D12_RASTERIZER_DESC2.DepthClipEnable"]/*' />
    public BOOL DepthClipEnable;

    /// <include file='D3D12_RASTERIZER_DESC2.xml' path='doc/member[@name="D3D12_RASTERIZER_DESC2.LineRasterizationMode"]/*' />
    public D3D12_LINE_RASTERIZATION_MODE LineRasterizationMode;

    /// <include file='D3D12_RASTERIZER_DESC2.xml' path='doc/member[@name="D3D12_RASTERIZER_DESC2.ForcedSampleCount"]/*' />
    public uint ForcedSampleCount;

    /// <include file='D3D12_RASTERIZER_DESC2.xml' path='doc/member[@name="D3D12_RASTERIZER_DESC2.ConservativeRaster"]/*' />
    public D3D12_CONSERVATIVE_RASTERIZATION_MODE ConservativeRaster;
}
