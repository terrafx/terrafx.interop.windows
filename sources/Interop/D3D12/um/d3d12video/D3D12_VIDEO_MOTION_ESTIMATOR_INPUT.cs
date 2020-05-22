// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12video.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct D3D12_VIDEO_MOTION_ESTIMATOR_INPUT
    {
        [NativeTypeName("ID3D12Resource *")]
        public ID3D12Resource* pInputTexture2D;

        [NativeTypeName("UINT")]
        public uint InputSubresourceIndex;

        [NativeTypeName("ID3D12Resource *")]
        public ID3D12Resource* pReferenceTexture2D;

        [NativeTypeName("UINT")]
        public uint ReferenceSubresourceIndex;

        [NativeTypeName("ID3D12VideoMotionVectorHeap *")]
        public ID3D12VideoMotionVectorHeap* pHintMotionVectorHeap;
    }
}
