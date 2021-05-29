// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct D3D12_FEATURE_DATA_D3D12_OPTIONS6
    {
        [NativeTypeName("BOOL")]
        public int AdditionalShadingRatesSupported;

        [NativeTypeName("BOOL")]
        public int PerPrimitiveShadingRateSupportedWithViewportIndexing;

        public D3D12_VARIABLE_SHADING_RATE_TIER VariableShadingRateTier;

        [NativeTypeName("UINT")]
        public uint ShadingRateImageTileSize;

        [NativeTypeName("BOOL")]
        public int BackgroundProcessingSupported;
    }
}
