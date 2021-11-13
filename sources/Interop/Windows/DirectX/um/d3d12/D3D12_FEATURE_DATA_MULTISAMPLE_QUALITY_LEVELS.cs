// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX
{
    public partial struct D3D12_FEATURE_DATA_MULTISAMPLE_QUALITY_LEVELS
    {
        public DXGI_FORMAT Format;

        public uint SampleCount;

        public D3D12_MULTISAMPLE_QUALITY_LEVEL_FLAGS Flags;

        public uint NumQualityLevels;
    }
}
