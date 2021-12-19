// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12video.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using TerraFX.Interop.Windows;

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_FEATURE_DATA_VIDEO_ARCHITECTURE.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_ARCHITECTURE"]/*' />
public partial struct D3D12_FEATURE_DATA_VIDEO_ARCHITECTURE
{
    /// <include file='D3D12_FEATURE_DATA_VIDEO_ARCHITECTURE.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_ARCHITECTURE.IOCoherent"]/*' />
    public BOOL IOCoherent;
}
