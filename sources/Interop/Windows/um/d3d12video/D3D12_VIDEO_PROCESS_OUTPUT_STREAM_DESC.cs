// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12video.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct D3D12_VIDEO_PROCESS_OUTPUT_STREAM_DESC
    {
        public DXGI_FORMAT Format;

        public DXGI_COLOR_SPACE_TYPE ColorSpace;

        public D3D12_VIDEO_PROCESS_ALPHA_FILL_MODE AlphaFillMode;

        [NativeTypeName("UINT")]
        public uint AlphaFillModeSourceStreamIndex;

        [NativeTypeName("FLOAT [4]")]
        public fixed float BackgroundColor[4];

        public DXGI_RATIONAL FrameRate;

        [NativeTypeName("BOOL")]
        public int EnableStereo;
    }
}
