// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12video.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct D3D12_VIDEO_PROCESS_INPUT_STREAM_DESC
    {
        public DXGI_FORMAT Format;

        public DXGI_COLOR_SPACE_TYPE ColorSpace;

        public DXGI_RATIONAL SourceAspectRatio;

        public DXGI_RATIONAL DestinationAspectRatio;

        public DXGI_RATIONAL FrameRate;

        public D3D12_VIDEO_SIZE_RANGE SourceSizeRange;

        public D3D12_VIDEO_SIZE_RANGE DestinationSizeRange;

        public BOOL EnableOrientation;

        public D3D12_VIDEO_PROCESS_FILTER_FLAGS FilterFlags;

        public D3D12_VIDEO_FRAME_STEREO_FORMAT StereoFormat;

        public D3D12_VIDEO_FIELD_TYPE FieldType;

        public D3D12_VIDEO_PROCESS_DEINTERLACE_FLAGS DeinterlaceMode;

        public BOOL EnableAlphaBlending;

        public D3D12_VIDEO_PROCESS_LUMA_KEY LumaKey;

        public uint NumPastFrames;

        public uint NumFutureFrames;

        public BOOL EnableAutoProcessing;
    }
}
