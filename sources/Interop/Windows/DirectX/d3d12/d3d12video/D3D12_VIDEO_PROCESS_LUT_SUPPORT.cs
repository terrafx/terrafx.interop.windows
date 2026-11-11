// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.620.2
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_VIDEO_PROCESS_LUT_SUPPORT.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_LUT_SUPPORT"]/*' />
public partial struct D3D12_VIDEO_PROCESS_LUT_SUPPORT
{
    /// <include file='D3D12_VIDEO_PROCESS_LUT_SUPPORT.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_LUT_SUPPORT.Format1DLUT"]/*' />
    public DXGI_FORMAT Format1DLUT;

    /// <include file='D3D12_VIDEO_PROCESS_LUT_SUPPORT.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_LUT_SUPPORT.Format3DLUT"]/*' />
    public DXGI_FORMAT Format3DLUT;

    /// <include file='D3D12_VIDEO_PROCESS_LUT_SUPPORT.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_LUT_SUPPORT.ColorSpace3DLUTOutput"]/*' />
    public DXGI_COLOR_SPACE_TYPE ColorSpace3DLUTOutput;

    /// <include file='D3D12_VIDEO_PROCESS_LUT_SUPPORT.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_LUT_SUPPORT.Flags"]/*' />
    public D3D12_VIDEO_PROCESS_LUT_SUPPORT_FLAGS Flags;

    /// <include file='D3D12_VIDEO_PROCESS_LUT_SUPPORT.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_LUT_SUPPORT.Native1DLUTSize"]/*' />
    public uint Native1DLUTSize;

    /// <include file='D3D12_VIDEO_PROCESS_LUT_SUPPORT.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_LUT_SUPPORT.Interpolation3DLUTFlags"]/*' />
    public D3D12_VIDEO_PROCESS_3DLUT_INTERPOLATION_MODE_SUPPORT_FLAGS Interpolation3DLUTFlags;

    /// <include file='D3D12_VIDEO_PROCESS_LUT_SUPPORT.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_LUT_SUPPORT.Dimension3DLUTFlags"]/*' />
    public D3D12_VIDEO_PROCESS_3DLUT_TABLE_DIMENSION_SUPPORT_FLAGS Dimension3DLUTFlags;
}
