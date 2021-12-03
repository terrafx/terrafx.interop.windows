// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using TerraFX.Interop.Windows;

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_FEATURE_DATA_ARCHITECTURE.xml' path='doc/member[@name="D3D12_FEATURE_DATA_ARCHITECTURE"]/*' />
public partial struct D3D12_FEATURE_DATA_ARCHITECTURE
{
    /// <include file='D3D12_FEATURE_DATA_ARCHITECTURE.xml' path='doc/member[@name="D3D12_FEATURE_DATA_ARCHITECTURE.NodeIndex"]/*' />
    public uint NodeIndex;

    /// <include file='D3D12_FEATURE_DATA_ARCHITECTURE.xml' path='doc/member[@name="D3D12_FEATURE_DATA_ARCHITECTURE.TileBasedRenderer"]/*' />
    public BOOL TileBasedRenderer;

    /// <include file='D3D12_FEATURE_DATA_ARCHITECTURE.xml' path='doc/member[@name="D3D12_FEATURE_DATA_ARCHITECTURE.UMA"]/*' />
    public BOOL UMA;

    /// <include file='D3D12_FEATURE_DATA_ARCHITECTURE.xml' path='doc/member[@name="D3D12_FEATURE_DATA_ARCHITECTURE.CacheCoherentUMA"]/*' />
    public BOOL CacheCoherentUMA;
}
