// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12video.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct D3D12_RESOLVE_VIDEO_MOTION_VECTOR_HEAP_OUTPUT
    {
        [NativeTypeName("ID3D12Resource *")]
        public ID3D12Resource* pMotionVectorTexture2D;

        public D3D12_RESOURCE_COORDINATE MotionVectorCoordinate;
    }
}
