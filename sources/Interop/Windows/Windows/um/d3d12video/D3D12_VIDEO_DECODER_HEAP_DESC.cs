// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12video.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows
{
    public partial struct D3D12_VIDEO_DECODER_HEAP_DESC
    {
        public uint NodeMask;

        public D3D12_VIDEO_DECODE_CONFIGURATION Configuration;

        public uint DecodeWidth;

        public uint DecodeHeight;

        public DXGI_FORMAT Format;

        public DXGI_RATIONAL FrameRate;

        public uint BitRate;

        public uint MaxDecodePictureBufferCount;
    }
}
