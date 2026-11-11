// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.620.2
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_FEATURE_DATA_VIDEO_ENCODER_CPU_RESOLVE.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_ENCODER_CPU_RESOLVE"]/*' />
public partial struct D3D12_FEATURE_DATA_VIDEO_ENCODER_CPU_RESOLVE
{
    /// <include file='D3D12_FEATURE_DATA_VIDEO_ENCODER_CPU_RESOLVE.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_ENCODER_CPU_RESOLVE.NodeIndex"]/*' />
    public uint NodeIndex;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_ENCODER_CPU_RESOLVE.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_ENCODER_CPU_RESOLVE.Codec"]/*' />
    public D3D12_VIDEO_ENCODER_CODEC Codec;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_ENCODER_CPU_RESOLVE.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_ENCODER_CPU_RESOLVE.Profile"]/*' />
    public D3D12_VIDEO_ENCODER_PROFILE_DESC Profile;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_ENCODER_CPU_RESOLVE.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_ENCODER_CPU_RESOLVE.InputFormat"]/*' />
    public DXGI_FORMAT InputFormat;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_ENCODER_CPU_RESOLVE.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_ENCODER_CPU_RESOLVE.Resolution"]/*' />
    public D3D12_VIDEO_ENCODER_PICTURE_RESOLUTION_DESC Resolution;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_ENCODER_CPU_RESOLVE.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_ENCODER_CPU_RESOLVE.CodecConfiguration"]/*' />
    public D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION CodecConfiguration;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_ENCODER_CPU_RESOLVE.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_ENCODER_CPU_RESOLVE.SupportFlags"]/*' />
    public D3D12_VIDEO_ENCODER_CPU_RESOLVE_SUPPORT_FLAGS SupportFlags;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_ENCODER_CPU_RESOLVE.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_ENCODER_CPU_RESOLVE.QPMapResolvedRowPitch"]/*' />
    public uint QPMapResolvedRowPitch;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_ENCODER_CPU_RESOLVE.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_ENCODER_CPU_RESOLVE.SATDMapResolvedRowPitch"]/*' />
    public uint SATDMapResolvedRowPitch;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_ENCODER_CPU_RESOLVE.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_ENCODER_CPU_RESOLVE.BitAllocationMapResolvedRowPitch"]/*' />
    public uint BitAllocationMapResolvedRowPitch;
}
