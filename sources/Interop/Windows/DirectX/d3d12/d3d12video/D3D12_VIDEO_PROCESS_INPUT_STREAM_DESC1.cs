// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.620.2
// Original source is Copyright © Microsoft. Licensed under the MIT license

using TerraFX.Interop.Windows;

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_VIDEO_PROCESS_INPUT_STREAM_DESC1.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_INPUT_STREAM_DESC1"]/*' />
public partial struct D3D12_VIDEO_PROCESS_INPUT_STREAM_DESC1
{
    /// <include file='D3D12_VIDEO_PROCESS_INPUT_STREAM_DESC1.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_INPUT_STREAM_DESC1.Format"]/*' />
    public DXGI_FORMAT Format;

    /// <include file='D3D12_VIDEO_PROCESS_INPUT_STREAM_DESC1.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_INPUT_STREAM_DESC1.ColorSpace"]/*' />
    public DXGI_COLOR_SPACE_TYPE ColorSpace;

    /// <include file='D3D12_VIDEO_PROCESS_INPUT_STREAM_DESC1.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_INPUT_STREAM_DESC1.SourceAspectRatio"]/*' />
    public DXGI_RATIONAL SourceAspectRatio;

    /// <include file='D3D12_VIDEO_PROCESS_INPUT_STREAM_DESC1.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_INPUT_STREAM_DESC1.DestinationAspectRatio"]/*' />
    public DXGI_RATIONAL DestinationAspectRatio;

    /// <include file='D3D12_VIDEO_PROCESS_INPUT_STREAM_DESC1.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_INPUT_STREAM_DESC1.FrameRate"]/*' />
    public DXGI_RATIONAL FrameRate;

    /// <include file='D3D12_VIDEO_PROCESS_INPUT_STREAM_DESC1.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_INPUT_STREAM_DESC1.SourceSizeRange"]/*' />
    public D3D12_VIDEO_SIZE_RANGE SourceSizeRange;

    /// <include file='D3D12_VIDEO_PROCESS_INPUT_STREAM_DESC1.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_INPUT_STREAM_DESC1.DestinationSizeRange"]/*' />
    public D3D12_VIDEO_SIZE_RANGE DestinationSizeRange;

    /// <include file='D3D12_VIDEO_PROCESS_INPUT_STREAM_DESC1.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_INPUT_STREAM_DESC1.EnableOrientation"]/*' />
    public BOOL EnableOrientation;

    /// <include file='D3D12_VIDEO_PROCESS_INPUT_STREAM_DESC1.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_INPUT_STREAM_DESC1.FilterFlags"]/*' />
    public D3D12_VIDEO_PROCESS_FILTER_FLAGS FilterFlags;

    /// <include file='D3D12_VIDEO_PROCESS_INPUT_STREAM_DESC1.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_INPUT_STREAM_DESC1.StereoFormat"]/*' />
    public D3D12_VIDEO_FRAME_STEREO_FORMAT StereoFormat;

    /// <include file='D3D12_VIDEO_PROCESS_INPUT_STREAM_DESC1.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_INPUT_STREAM_DESC1.FieldType"]/*' />
    public D3D12_VIDEO_FIELD_TYPE FieldType;

    /// <include file='D3D12_VIDEO_PROCESS_INPUT_STREAM_DESC1.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_INPUT_STREAM_DESC1.DeinterlaceMode"]/*' />
    public D3D12_VIDEO_PROCESS_DEINTERLACE_FLAGS DeinterlaceMode;

    /// <include file='D3D12_VIDEO_PROCESS_INPUT_STREAM_DESC1.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_INPUT_STREAM_DESC1.EnableAlphaBlending"]/*' />
    public BOOL EnableAlphaBlending;

    /// <include file='D3D12_VIDEO_PROCESS_INPUT_STREAM_DESC1.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_INPUT_STREAM_DESC1.LumaKey"]/*' />
    public D3D12_VIDEO_PROCESS_LUMA_KEY LumaKey;

    /// <include file='D3D12_VIDEO_PROCESS_INPUT_STREAM_DESC1.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_INPUT_STREAM_DESC1.NumPastFrames"]/*' />
    public uint NumPastFrames;

    /// <include file='D3D12_VIDEO_PROCESS_INPUT_STREAM_DESC1.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_INPUT_STREAM_DESC1.NumFutureFrames"]/*' />
    public uint NumFutureFrames;

    /// <include file='D3D12_VIDEO_PROCESS_INPUT_STREAM_DESC1.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_INPUT_STREAM_DESC1.EnableAutoProcessing"]/*' />
    public BOOL EnableAutoProcessing;

    /// <include file='D3D12_VIDEO_PROCESS_INPUT_STREAM_DESC1.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_INPUT_STREAM_DESC1.ConfigurationLUT"]/*' />
    public D3D12_VIDEO_PROCESS_LUT_TRANSFORM_CONFIGURATION ConfigurationLUT;
}
