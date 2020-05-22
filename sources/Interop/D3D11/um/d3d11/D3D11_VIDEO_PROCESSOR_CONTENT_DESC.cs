// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct D3D11_VIDEO_PROCESSOR_CONTENT_DESC
    {
        public D3D11_VIDEO_FRAME_FORMAT InputFrameFormat;

        public DXGI_RATIONAL InputFrameRate;

        [NativeTypeName("UINT")]
        public uint InputWidth;

        [NativeTypeName("UINT")]
        public uint InputHeight;

        public DXGI_RATIONAL OutputFrameRate;

        [NativeTypeName("UINT")]
        public uint OutputWidth;

        [NativeTypeName("UINT")]
        public uint OutputHeight;

        public D3D11_VIDEO_USAGE Usage;
    }
}
