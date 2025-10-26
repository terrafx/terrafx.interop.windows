// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.618.2
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_VIDEO_ENCODER_HEAP_DESC1.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_HEAP_DESC1"]/*' />
public unsafe partial struct D3D12_VIDEO_ENCODER_HEAP_DESC1
{
    /// <include file='D3D12_VIDEO_ENCODER_HEAP_DESC1.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_HEAP_DESC1.NodeMask"]/*' />
    public uint NodeMask;

    /// <include file='D3D12_VIDEO_ENCODER_HEAP_DESC1.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_HEAP_DESC1.Flags"]/*' />
    public D3D12_VIDEO_ENCODER_HEAP_FLAGS Flags;

    /// <include file='D3D12_VIDEO_ENCODER_HEAP_DESC1.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_HEAP_DESC1.EncodeCodec"]/*' />
    public D3D12_VIDEO_ENCODER_CODEC EncodeCodec;

    /// <include file='D3D12_VIDEO_ENCODER_HEAP_DESC1.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_HEAP_DESC1.EncodeProfile"]/*' />
    public D3D12_VIDEO_ENCODER_PROFILE_DESC EncodeProfile;

    /// <include file='D3D12_VIDEO_ENCODER_HEAP_DESC1.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_HEAP_DESC1.EncodeLevel"]/*' />
    public D3D12_VIDEO_ENCODER_LEVEL_SETTING EncodeLevel;

    /// <include file='D3D12_VIDEO_ENCODER_HEAP_DESC1.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_HEAP_DESC1.ResolutionsListCount"]/*' />
    public uint ResolutionsListCount;

    /// <include file='D3D12_VIDEO_ENCODER_HEAP_DESC1.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_HEAP_DESC1.pResolutionList"]/*' />
    [NativeTypeName("const D3D12_VIDEO_ENCODER_PICTURE_RESOLUTION_DESC *")]
    public D3D12_VIDEO_ENCODER_PICTURE_RESOLUTION_DESC* pResolutionList;

    /// <include file='D3D12_VIDEO_ENCODER_HEAP_DESC1.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_HEAP_DESC1.Pow2DownscaleFactor"]/*' />
    public uint Pow2DownscaleFactor;
}
