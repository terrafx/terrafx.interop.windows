// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.620.2
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_VIDEO_PROCESS_LUT_UPDATE_FLAGS.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_LUT_UPDATE_FLAGS"]/*' />
public enum D3D12_VIDEO_PROCESS_LUT_UPDATE_FLAGS
{
    /// <include file='D3D12_VIDEO_PROCESS_LUT_UPDATE_FLAGS.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_LUT_UPDATE_FLAGS.D3D12_VIDEO_PROCESS_LUT_UPDATE_FLAG_NONE"]/*' />
    D3D12_VIDEO_PROCESS_LUT_UPDATE_FLAG_NONE = 0,

    /// <include file='D3D12_VIDEO_PROCESS_LUT_UPDATE_FLAGS.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_LUT_UPDATE_FLAGS.D3D12_VIDEO_PROCESS_LUT_UPDATE_FLAG_CSC"]/*' />
    D3D12_VIDEO_PROCESS_LUT_UPDATE_FLAG_CSC = 0x1,

    /// <include file='D3D12_VIDEO_PROCESS_LUT_UPDATE_FLAGS.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_LUT_UPDATE_FLAGS.D3D12_VIDEO_PROCESS_LUT_UPDATE_FLAG_1DLUT"]/*' />
    D3D12_VIDEO_PROCESS_LUT_UPDATE_FLAG_1DLUT = 0x2,

    /// <include file='D3D12_VIDEO_PROCESS_LUT_UPDATE_FLAGS.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_LUT_UPDATE_FLAGS.D3D12_VIDEO_PROCESS_LUT_UPDATE_FLAG_1DLUT_SPACING"]/*' />
    D3D12_VIDEO_PROCESS_LUT_UPDATE_FLAG_1DLUT_SPACING = 0x4,

    /// <include file='D3D12_VIDEO_PROCESS_LUT_UPDATE_FLAGS.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_LUT_UPDATE_FLAGS.D3D12_VIDEO_PROCESS_LUT_UPDATE_FLAG_3DLUT"]/*' />
    D3D12_VIDEO_PROCESS_LUT_UPDATE_FLAG_3DLUT = 0x8,
}
