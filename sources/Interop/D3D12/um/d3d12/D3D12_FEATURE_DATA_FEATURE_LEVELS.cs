// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d3d12.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe struct D3D12_FEATURE_DATA_FEATURE_LEVELS
    {
        [NativeTypeName("UINT")]
        public uint NumFeatureLevels;

        [NativeTypeName("D3D_FEATURE_LEVEL[]")]
        public D3D_FEATURE_LEVEL* pFeatureLevelsRequested;

        public D3D_FEATURE_LEVEL MaxSupportedFeatureLevel;
    }
}
