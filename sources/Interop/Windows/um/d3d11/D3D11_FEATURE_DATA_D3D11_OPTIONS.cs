// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct D3D11_FEATURE_DATA_D3D11_OPTIONS
    {
        [NativeTypeName("BOOL")]
        public int OutputMergerLogicOp;

        [NativeTypeName("BOOL")]
        public int UAVOnlyRenderingForcedSampleCount;

        [NativeTypeName("BOOL")]
        public int DiscardAPIsSeenByDriver;

        [NativeTypeName("BOOL")]
        public int FlagsForUpdateAndCopySeenByDriver;

        [NativeTypeName("BOOL")]
        public int ClearView;

        [NativeTypeName("BOOL")]
        public int CopyWithOverlap;

        [NativeTypeName("BOOL")]
        public int ConstantBufferPartialUpdate;

        [NativeTypeName("BOOL")]
        public int ConstantBufferOffsetting;

        [NativeTypeName("BOOL")]
        public int MapNoOverwriteOnDynamicConstantBuffer;

        [NativeTypeName("BOOL")]
        public int MapNoOverwriteOnDynamicBufferSRV;

        [NativeTypeName("BOOL")]
        public int MultisampleRTVWithForcedSampleCountOne;

        [NativeTypeName("BOOL")]
        public int SAD4ShaderInstructions;

        [NativeTypeName("BOOL")]
        public int ExtendedDoublesShaderInstructions;

        [NativeTypeName("BOOL")]
        public int ExtendedResourceSharing;
    }
}
