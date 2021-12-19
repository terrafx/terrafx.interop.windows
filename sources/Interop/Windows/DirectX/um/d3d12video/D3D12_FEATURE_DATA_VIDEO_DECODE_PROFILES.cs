// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12video.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_FEATURE_DATA_VIDEO_DECODE_PROFILES.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_DECODE_PROFILES"]/*' />
public unsafe partial struct D3D12_FEATURE_DATA_VIDEO_DECODE_PROFILES
{
    /// <include file='D3D12_FEATURE_DATA_VIDEO_DECODE_PROFILES.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_DECODE_PROFILES.NodeIndex"]/*' />
    public uint NodeIndex;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_DECODE_PROFILES.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_DECODE_PROFILES.ProfileCount"]/*' />
    public uint ProfileCount;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_DECODE_PROFILES.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_DECODE_PROFILES.pProfiles"]/*' />
    public Guid* pProfiles;
}
