// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct D3D12_FEATURE_DATA_D3D12_OPTIONS5
    {
        [NativeTypeName("BOOL")]
        public int SRVOnlyTiledResourceTier3;

        public D3D12_RENDER_PASS_TIER RenderPassesTier;

        public D3D12_RAYTRACING_TIER RaytracingTier;
    }
}
