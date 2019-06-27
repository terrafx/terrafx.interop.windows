// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d3d12.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public struct D3D12_FEATURE_DATA_MULTISAMPLE_QUALITY_LEVELS
    {
        #region Fields
        public DXGI_FORMAT Format;

        [NativeTypeName("UINT")]
        public uint SampleCount;

        public D3D12_MULTISAMPLE_QUALITY_LEVEL_FLAGS Flags;

        [NativeTypeName("UINT")]
        public uint NumQualityLevels;
        #endregion
    }
}
