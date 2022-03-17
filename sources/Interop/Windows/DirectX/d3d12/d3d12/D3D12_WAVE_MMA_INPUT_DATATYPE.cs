// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_WAVE_MMA_INPUT_DATATYPE.xml' path='doc/member[@name="D3D12_WAVE_MMA_INPUT_DATATYPE"]/*' />
public enum D3D12_WAVE_MMA_INPUT_DATATYPE
{
    /// <include file='D3D12_WAVE_MMA_INPUT_DATATYPE.xml' path='doc/member[@name="D3D12_WAVE_MMA_INPUT_DATATYPE.D3D12_WAVE_MMA_INPUT_DATATYPE_INVALID"]/*' />
    D3D12_WAVE_MMA_INPUT_DATATYPE_INVALID = 0,

    /// <include file='D3D12_WAVE_MMA_INPUT_DATATYPE.xml' path='doc/member[@name="D3D12_WAVE_MMA_INPUT_DATATYPE.D3D12_WAVE_MMA_INPUT_DATATYPE_BYTE"]/*' />
    D3D12_WAVE_MMA_INPUT_DATATYPE_BYTE = (D3D12_WAVE_MMA_INPUT_DATATYPE_INVALID + 1),

    /// <include file='D3D12_WAVE_MMA_INPUT_DATATYPE.xml' path='doc/member[@name="D3D12_WAVE_MMA_INPUT_DATATYPE.D3D12_WAVE_MMA_INPUT_DATATYPE_FLOAT16"]/*' />
    D3D12_WAVE_MMA_INPUT_DATATYPE_FLOAT16 = (D3D12_WAVE_MMA_INPUT_DATATYPE_BYTE + 1),

    /// <include file='D3D12_WAVE_MMA_INPUT_DATATYPE.xml' path='doc/member[@name="D3D12_WAVE_MMA_INPUT_DATATYPE.D3D12_WAVE_MMA_INPUT_DATATYPE_FLOAT"]/*' />
    D3D12_WAVE_MMA_INPUT_DATATYPE_FLOAT = (D3D12_WAVE_MMA_INPUT_DATATYPE_FLOAT16 + 1),
}
