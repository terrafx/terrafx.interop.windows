// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12video.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_RESOLVE_VIDEO_MOTION_VECTOR_HEAP_OUTPUT.xml' path='doc/member[@name="D3D12_RESOLVE_VIDEO_MOTION_VECTOR_HEAP_OUTPUT"]/*' />
[SupportedOSPlatform("windows10.0.19041.0")]
public unsafe partial struct D3D12_RESOLVE_VIDEO_MOTION_VECTOR_HEAP_OUTPUT
{
    /// <include file='D3D12_RESOLVE_VIDEO_MOTION_VECTOR_HEAP_OUTPUT.xml' path='doc/member[@name="D3D12_RESOLVE_VIDEO_MOTION_VECTOR_HEAP_OUTPUT.pMotionVectorTexture2D"]/*' />
    public ID3D12Resource* pMotionVectorTexture2D;

    /// <include file='D3D12_RESOLVE_VIDEO_MOTION_VECTOR_HEAP_OUTPUT.xml' path='doc/member[@name="D3D12_RESOLVE_VIDEO_MOTION_VECTOR_HEAP_OUTPUT.MotionVectorCoordinate"]/*' />
    public D3D12_RESOURCE_COORDINATE MotionVectorCoordinate;
}
