// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12video.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct D3D12_RESOLVE_VIDEO_MOTION_VECTOR_HEAP_INPUT
    {
        [NativeTypeName("ID3D12VideoMotionVectorHeap *")]
        public ID3D12VideoMotionVectorHeap* pMotionVectorHeap;

        [NativeTypeName("UINT")]
        public uint PixelWidth;

        [NativeTypeName("UINT")]
        public uint PixelHeight;
    }
}
