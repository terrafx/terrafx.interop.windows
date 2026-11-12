// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.620.2
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_VIDEO_PROCESS_3DLUT_INTERPOLATION_MODE.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_3DLUT_INTERPOLATION_MODE"]/*' />
public enum D3D12_VIDEO_PROCESS_3DLUT_INTERPOLATION_MODE
{
    /// <include file='D3D12_VIDEO_PROCESS_3DLUT_INTERPOLATION_MODE.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_3DLUT_INTERPOLATION_MODE.D3D12_VIDEO_PROCESS_3DLUT_INTERPOLATION_MODE_TRILINEAR"]/*' />
    D3D12_VIDEO_PROCESS_3DLUT_INTERPOLATION_MODE_TRILINEAR = 0,

    /// <include file='D3D12_VIDEO_PROCESS_3DLUT_INTERPOLATION_MODE.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_3DLUT_INTERPOLATION_MODE.D3D12_VIDEO_PROCESS_3DLUT_INTERPOLATION_MODE_TETRAHEDRAL"]/*' />
    D3D12_VIDEO_PROCESS_3DLUT_INTERPOLATION_MODE_TETRAHEDRAL = 1,
}
