// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.618.2
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_VIDEO_ENCODER_INPUT_MAP_SESSION_INFO.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_INPUT_MAP_SESSION_INFO"]/*' />
public partial struct D3D12_VIDEO_ENCODER_INPUT_MAP_SESSION_INFO
{
    /// <include file='D3D12_VIDEO_ENCODER_INPUT_MAP_SESSION_INFO.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_INPUT_MAP_SESSION_INFO.Codec"]/*' />
    public D3D12_VIDEO_ENCODER_CODEC Codec;

    /// <include file='D3D12_VIDEO_ENCODER_INPUT_MAP_SESSION_INFO.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_INPUT_MAP_SESSION_INFO.Profile"]/*' />
    public D3D12_VIDEO_ENCODER_PROFILE_DESC Profile;

    /// <include file='D3D12_VIDEO_ENCODER_INPUT_MAP_SESSION_INFO.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_INPUT_MAP_SESSION_INFO.Level"]/*' />
    public D3D12_VIDEO_ENCODER_LEVEL_SETTING Level;

    /// <include file='D3D12_VIDEO_ENCODER_INPUT_MAP_SESSION_INFO.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_INPUT_MAP_SESSION_INFO.InputFormat"]/*' />
    public DXGI_FORMAT InputFormat;

    /// <include file='D3D12_VIDEO_ENCODER_INPUT_MAP_SESSION_INFO.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_INPUT_MAP_SESSION_INFO.InputResolution"]/*' />
    public D3D12_VIDEO_ENCODER_PICTURE_RESOLUTION_DESC InputResolution;

    /// <include file='D3D12_VIDEO_ENCODER_INPUT_MAP_SESSION_INFO.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_INPUT_MAP_SESSION_INFO.CodecConfiguration"]/*' />
    public D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION CodecConfiguration;

    /// <include file='D3D12_VIDEO_ENCODER_INPUT_MAP_SESSION_INFO.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_INPUT_MAP_SESSION_INFO.SubregionFrameEncoding"]/*' />
    public D3D12_VIDEO_ENCODER_FRAME_SUBREGION_LAYOUT_MODE SubregionFrameEncoding;

    /// <include file='D3D12_VIDEO_ENCODER_INPUT_MAP_SESSION_INFO.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_INPUT_MAP_SESSION_INFO.SubregionFrameEncodingData"]/*' />
    public D3D12_VIDEO_ENCODER_PICTURE_CONTROL_SUBREGIONS_LAYOUT_DATA SubregionFrameEncodingData;
}
