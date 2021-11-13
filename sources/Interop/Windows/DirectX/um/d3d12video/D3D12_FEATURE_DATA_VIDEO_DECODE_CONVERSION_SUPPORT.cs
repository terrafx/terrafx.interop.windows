// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12video.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX
{
    public partial struct D3D12_FEATURE_DATA_VIDEO_DECODE_CONVERSION_SUPPORT
    {
        public uint NodeIndex;

        public D3D12_VIDEO_DECODE_CONFIGURATION Configuration;

        public D3D12_VIDEO_SAMPLE DecodeSample;

        public D3D12_VIDEO_FORMAT OutputFormat;

        public DXGI_RATIONAL FrameRate;

        public uint BitRate;

        public D3D12_VIDEO_DECODE_CONVERSION_SUPPORT_FLAGS SupportFlags;

        public D3D12_VIDEO_SCALE_SUPPORT ScaleSupport;
    }
}
