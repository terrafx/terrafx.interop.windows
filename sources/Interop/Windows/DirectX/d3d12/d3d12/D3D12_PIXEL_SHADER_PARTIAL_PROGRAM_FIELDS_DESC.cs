// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.620.2
// Original source is Copyright © Microsoft. Licensed under the MIT license

using TerraFX.Interop.Windows;

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_PIXEL_SHADER_PARTIAL_PROGRAM_FIELDS_DESC.xml' path='doc/member[@name="D3D12_PIXEL_SHADER_PARTIAL_PROGRAM_FIELDS_DESC"]/*' />
public partial struct D3D12_PIXEL_SHADER_PARTIAL_PROGRAM_FIELDS_DESC
{
    /// <include file='D3D12_PIXEL_SHADER_PARTIAL_PROGRAM_FIELDS_DESC.xml' path='doc/member[@name="D3D12_PIXEL_SHADER_PARTIAL_PROGRAM_FIELDS_DESC.LineRasterizationMode"]/*' />
    public D3D12_LINE_RASTERIZATION_MODE LineRasterizationMode;

    /// <include file='D3D12_PIXEL_SHADER_PARTIAL_PROGRAM_FIELDS_DESC.xml' path='doc/member[@name="D3D12_PIXEL_SHADER_PARTIAL_PROGRAM_FIELDS_DESC.ForcedSampleCount"]/*' />
    public uint ForcedSampleCount;

    /// <include file='D3D12_PIXEL_SHADER_PARTIAL_PROGRAM_FIELDS_DESC.xml' path='doc/member[@name="D3D12_PIXEL_SHADER_PARTIAL_PROGRAM_FIELDS_DESC.AlphaToCoverageEnable"]/*' />
    public BOOL AlphaToCoverageEnable;

    /// <include file='D3D12_PIXEL_SHADER_PARTIAL_PROGRAM_FIELDS_DESC.xml' path='doc/member[@name="D3D12_PIXEL_SHADER_PARTIAL_PROGRAM_FIELDS_DESC.DualSourceBlendEnable"]/*' />
    public BOOL DualSourceBlendEnable;

    /// <include file='D3D12_PIXEL_SHADER_PARTIAL_PROGRAM_FIELDS_DESC.xml' path='doc/member[@name="D3D12_PIXEL_SHADER_PARTIAL_PROGRAM_FIELDS_DESC.LateLinkRasterizerSubobject"]/*' />
    public BOOL LateLinkRasterizerSubobject;

    /// <include file='D3D12_PIXEL_SHADER_PARTIAL_PROGRAM_FIELDS_DESC.xml' path='doc/member[@name="D3D12_PIXEL_SHADER_PARTIAL_PROGRAM_FIELDS_DESC.LateLinkBlendSubobject"]/*' />
    public BOOL LateLinkBlendSubobject;

    /// <include file='D3D12_PIXEL_SHADER_PARTIAL_PROGRAM_FIELDS_DESC.xml' path='doc/member[@name="D3D12_PIXEL_SHADER_PARTIAL_PROGRAM_FIELDS_DESC.LateLinkSampleMaskSubobject"]/*' />
    public BOOL LateLinkSampleMaskSubobject;

    /// <include file='D3D12_PIXEL_SHADER_PARTIAL_PROGRAM_FIELDS_DESC.xml' path='doc/member[@name="D3D12_PIXEL_SHADER_PARTIAL_PROGRAM_FIELDS_DESC.LateLinkSampleDescSubobject"]/*' />
    public BOOL LateLinkSampleDescSubobject;

    /// <include file='D3D12_PIXEL_SHADER_PARTIAL_PROGRAM_FIELDS_DESC.xml' path='doc/member[@name="D3D12_PIXEL_SHADER_PARTIAL_PROGRAM_FIELDS_DESC.LateLinkDepthStencilFormatSubobject"]/*' />
    public BOOL LateLinkDepthStencilFormatSubobject;

    /// <include file='D3D12_PIXEL_SHADER_PARTIAL_PROGRAM_FIELDS_DESC.xml' path='doc/member[@name="D3D12_PIXEL_SHADER_PARTIAL_PROGRAM_FIELDS_DESC.LateLinkRenderTargetFormatSubobject"]/*' />
    public BOOL LateLinkRenderTargetFormatSubobject;

    /// <include file='D3D12_PIXEL_SHADER_PARTIAL_PROGRAM_FIELDS_DESC.xml' path='doc/member[@name="D3D12_PIXEL_SHADER_PARTIAL_PROGRAM_FIELDS_DESC.LateLinkDepthStencilSubobject"]/*' />
    public BOOL LateLinkDepthStencilSubobject;
}
