// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct D3D12_FEATURE_DATA_WAVE_MMA
    {
        public D3D12_WAVE_MMA_INPUT_DATATYPE InputDataType;

        public D3D12_WAVE_MMA_DIMENSION M;

        public D3D12_WAVE_MMA_DIMENSION N;

        [NativeTypeName("BOOL")]
        public int Supported;

        [NativeTypeName("UINT")]
        public uint K;

        public D3D12_WAVE_MMA_ACCUM_DATATYPE AccumDataTypes;

        [NativeTypeName("UINT")]
        public uint RequiredWaveLaneCountMin;

        [NativeTypeName("UINT")]
        public uint RequiredWaveLaneCountMax;
    }
}
