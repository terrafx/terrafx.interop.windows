// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct D3D12_FEATURE_DATA_D3D12_OPTIONS
    {
        [NativeTypeName("BOOL")]
        public int DoublePrecisionFloatShaderOps;

        [NativeTypeName("BOOL")]
        public int OutputMergerLogicOp;

        public D3D12_SHADER_MIN_PRECISION_SUPPORT MinPrecisionSupport;

        public D3D12_TILED_RESOURCES_TIER TiledResourcesTier;

        public D3D12_RESOURCE_BINDING_TIER ResourceBindingTier;

        [NativeTypeName("BOOL")]
        public int PSSpecifiedStencilRefSupported;

        [NativeTypeName("BOOL")]
        public int TypedUAVLoadAdditionalFormats;

        [NativeTypeName("BOOL")]
        public int ROVsSupported;

        public D3D12_CONSERVATIVE_RASTERIZATION_TIER ConservativeRasterizationTier;

        [NativeTypeName("UINT")]
        public uint MaxGPUVirtualAddressBitsPerResource;

        [NativeTypeName("BOOL")]
        public int StandardSwizzle64KBSupported;

        public D3D12_CROSS_NODE_SHARING_TIER CrossNodeSharingTier;

        [NativeTypeName("BOOL")]
        public int CrossAdapterRowMajorTextureSupported;

        [NativeTypeName("BOOL")]
        public int VPAndRTArrayIndexFromAnyShaderFeedingRasterizerSupportedWithoutGSEmulation;

        public D3D12_RESOURCE_HEAP_TIER ResourceHeapTier;
    }
}
