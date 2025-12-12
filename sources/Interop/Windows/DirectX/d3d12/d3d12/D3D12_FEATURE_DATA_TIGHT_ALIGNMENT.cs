// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.618.5
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_FEATURE_DATA_TIGHT_ALIGNMENT.xml' path='doc/member[@name="D3D12_FEATURE_DATA_TIGHT_ALIGNMENT"]/*' />
public partial struct D3D12_FEATURE_DATA_TIGHT_ALIGNMENT
{
    /// <include file='D3D12_FEATURE_DATA_TIGHT_ALIGNMENT.xml' path='doc/member[@name="D3D12_FEATURE_DATA_TIGHT_ALIGNMENT.SupportTier"]/*' />
    public D3D12_TIGHT_ALIGNMENT_TIER SupportTier;
}
