// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct D3D11_FEATURE_DATA_D3D11_OPTIONS2
    {
        [NativeTypeName("BOOL")]
        public int PSSpecifiedStencilRefSupported;

        [NativeTypeName("BOOL")]
        public int TypedUAVLoadAdditionalFormats;

        [NativeTypeName("BOOL")]
        public int ROVsSupported;

        public D3D11_CONSERVATIVE_RASTERIZATION_TIER ConservativeRasterizationTier;

        public D3D11_TILED_RESOURCES_TIER TiledResourcesTier;

        [NativeTypeName("BOOL")]
        public int MapOnDefaultTextures;

        [NativeTypeName("BOOL")]
        public int StandardSwizzle;

        [NativeTypeName("BOOL")]
        public int UnifiedMemoryArchitecture;
    }
}
