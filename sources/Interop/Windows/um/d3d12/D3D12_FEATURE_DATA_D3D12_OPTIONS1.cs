// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d3d12.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using TerraFX.Utilities;

namespace TerraFX.Interop
{
    [Unmanaged]
    public struct D3D12_FEATURE_DATA_D3D12_OPTIONS1
    {
        #region Fields
        [NativeTypeName("BOOL")]
        public int WaveOps;

        [NativeTypeName("UINT")]
        public uint WaveLaneCountMin;

        [NativeTypeName("UINT")]
        public uint WaveLaneCountMax;

        [NativeTypeName("UINT")]
        public uint TotalLaneCount;

        [NativeTypeName("BOOL")]
        public int ExpandedComputeResourceStates;

        [NativeTypeName("BOOL")]
        public int Int64ShaderOps;
        #endregion
    }
}
