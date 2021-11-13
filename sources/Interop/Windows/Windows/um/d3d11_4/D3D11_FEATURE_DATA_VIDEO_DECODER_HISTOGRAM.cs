// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11_4.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows
{
    public partial struct D3D11_FEATURE_DATA_VIDEO_DECODER_HISTOGRAM
    {
        public D3D11_VIDEO_DECODER_DESC DecoderDesc;

        public D3D11_VIDEO_DECODER_HISTOGRAM_COMPONENT_FLAGS Components;

        public uint BinCount;

        public uint CounterBitDepth;
    }
}
