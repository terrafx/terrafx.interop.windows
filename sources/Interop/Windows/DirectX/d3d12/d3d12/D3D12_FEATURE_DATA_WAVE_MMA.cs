// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using TerraFX.Interop.Windows;

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_FEATURE_DATA_WAVE_MMA.xml' path='doc/member[@name="D3D12_FEATURE_DATA_WAVE_MMA"]/*' />
public partial struct D3D12_FEATURE_DATA_WAVE_MMA
{
    /// <include file='D3D12_FEATURE_DATA_WAVE_MMA.xml' path='doc/member[@name="D3D12_FEATURE_DATA_WAVE_MMA.InputDataType"]/*' />
    public D3D12_WAVE_MMA_INPUT_DATATYPE InputDataType;

    /// <include file='D3D12_FEATURE_DATA_WAVE_MMA.xml' path='doc/member[@name="D3D12_FEATURE_DATA_WAVE_MMA.M"]/*' />
    public D3D12_WAVE_MMA_DIMENSION M;

    /// <include file='D3D12_FEATURE_DATA_WAVE_MMA.xml' path='doc/member[@name="D3D12_FEATURE_DATA_WAVE_MMA.N"]/*' />
    public D3D12_WAVE_MMA_DIMENSION N;

    /// <include file='D3D12_FEATURE_DATA_WAVE_MMA.xml' path='doc/member[@name="D3D12_FEATURE_DATA_WAVE_MMA.Supported"]/*' />
    public BOOL Supported;

    /// <include file='D3D12_FEATURE_DATA_WAVE_MMA.xml' path='doc/member[@name="D3D12_FEATURE_DATA_WAVE_MMA.K"]/*' />
    public uint K;

    /// <include file='D3D12_FEATURE_DATA_WAVE_MMA.xml' path='doc/member[@name="D3D12_FEATURE_DATA_WAVE_MMA.AccumDataTypes"]/*' />
    public D3D12_WAVE_MMA_ACCUM_DATATYPE AccumDataTypes;

    /// <include file='D3D12_FEATURE_DATA_WAVE_MMA.xml' path='doc/member[@name="D3D12_FEATURE_DATA_WAVE_MMA.RequiredWaveLaneCountMin"]/*' />
    public uint RequiredWaveLaneCountMin;

    /// <include file='D3D12_FEATURE_DATA_WAVE_MMA.xml' path='doc/member[@name="D3D12_FEATURE_DATA_WAVE_MMA.RequiredWaveLaneCountMax"]/*' />
    public uint RequiredWaveLaneCountMax;
}
