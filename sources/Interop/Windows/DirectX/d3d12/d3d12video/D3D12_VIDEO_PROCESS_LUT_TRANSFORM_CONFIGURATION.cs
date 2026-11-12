// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.620.2
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_VIDEO_PROCESS_LUT_TRANSFORM_CONFIGURATION.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_LUT_TRANSFORM_CONFIGURATION"]/*' />
public partial struct D3D12_VIDEO_PROCESS_LUT_TRANSFORM_CONFIGURATION
{
    /// <include file='D3D12_VIDEO_PROCESS_LUT_TRANSFORM_CONFIGURATION.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_LUT_TRANSFORM_CONFIGURATION.ConfigFlags"]/*' />
    public D3D12_VIDEO_PROCESS_LUT_TRANSFORM_CONFIGURATION_FLAGS ConfigFlags;

    /// <include file='D3D12_VIDEO_PROCESS_LUT_TRANSFORM_CONFIGURATION.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_LUT_TRANSFORM_CONFIGURATION.UpsampledChromaInput"]/*' />
    public DXGI_COLOR_SPACE_TYPE UpsampledChromaInput;

    /// <include file='D3D12_VIDEO_PROCESS_LUT_TRANSFORM_CONFIGURATION.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_LUT_TRANSFORM_CONFIGURATION.Format1DLUT"]/*' />
    public DXGI_FORMAT Format1DLUT;

    /// <include file='D3D12_VIDEO_PROCESS_LUT_TRANSFORM_CONFIGURATION.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_LUT_TRANSFORM_CONFIGURATION.Format3DLUT"]/*' />
    public DXGI_FORMAT Format3DLUT;

    /// <include file='D3D12_VIDEO_PROCESS_LUT_TRANSFORM_CONFIGURATION.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_LUT_TRANSFORM_CONFIGURATION.ColorSpace3DLUTOutput"]/*' />
    public DXGI_COLOR_SPACE_TYPE ColorSpace3DLUTOutput;

    /// <include file='D3D12_VIDEO_PROCESS_LUT_TRANSFORM_CONFIGURATION.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_LUT_TRANSFORM_CONFIGURATION.Interpolation3DLUT"]/*' />
    public D3D12_VIDEO_PROCESS_3DLUT_INTERPOLATION_MODE Interpolation3DLUT;

    /// <include file='D3D12_VIDEO_PROCESS_LUT_TRANSFORM_CONFIGURATION.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_LUT_TRANSFORM_CONFIGURATION.Dimension3DLUT"]/*' />
    public D3D12_VIDEO_PROCESS_3DLUT_TABLE_DIMENSION Dimension3DLUT;
}
