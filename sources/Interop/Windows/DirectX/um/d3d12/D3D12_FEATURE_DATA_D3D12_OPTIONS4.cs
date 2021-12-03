// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using TerraFX.Interop.Windows;

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_FEATURE_DATA_D3D12_OPTIONS4.xml' path='doc/member[@name="D3D12_FEATURE_DATA_D3D12_OPTIONS4"]/*' />
public partial struct D3D12_FEATURE_DATA_D3D12_OPTIONS4
{
    /// <include file='D3D12_FEATURE_DATA_D3D12_OPTIONS4.xml' path='doc/member[@name="D3D12_FEATURE_DATA_D3D12_OPTIONS4.MSAA64KBAlignedTextureSupported"]/*' />
    public BOOL MSAA64KBAlignedTextureSupported;

    /// <include file='D3D12_FEATURE_DATA_D3D12_OPTIONS4.xml' path='doc/member[@name="D3D12_FEATURE_DATA_D3D12_OPTIONS4.SharedResourceCompatibilityTier"]/*' />
    public D3D12_SHARED_RESOURCE_COMPATIBILITY_TIER SharedResourceCompatibilityTier;

    /// <include file='D3D12_FEATURE_DATA_D3D12_OPTIONS4.xml' path='doc/member[@name="D3D12_FEATURE_DATA_D3D12_OPTIONS4.Native16BitShaderOpsSupported"]/*' />
    public BOOL Native16BitShaderOpsSupported;
}
