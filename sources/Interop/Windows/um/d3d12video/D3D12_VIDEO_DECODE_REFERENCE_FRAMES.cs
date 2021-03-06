// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12video.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct D3D12_VIDEO_DECODE_REFERENCE_FRAMES
    {
        [NativeTypeName("UINT")]
        public uint NumTexture2Ds;

        public ID3D12Resource** ppTexture2Ds;

        [NativeTypeName("UINT *")]
        public uint* pSubresources;

        public ID3D12VideoDecoderHeap** ppHeaps;
    }
}
