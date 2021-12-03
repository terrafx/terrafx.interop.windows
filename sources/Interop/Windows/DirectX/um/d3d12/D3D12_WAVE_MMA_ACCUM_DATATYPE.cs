// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_WAVE_MMA_ACCUM_DATATYPE.xml' path='doc/member[@name="D3D12_WAVE_MMA_ACCUM_DATATYPE"]/*' />
[Flags]
public enum D3D12_WAVE_MMA_ACCUM_DATATYPE
{
    /// <include file='D3D12_WAVE_MMA_ACCUM_DATATYPE.xml' path='doc/member[@name="D3D12_WAVE_MMA_ACCUM_DATATYPE.D3D12_WAVE_MMA_ACCUM_DATATYPE_NONE"]/*' />
    D3D12_WAVE_MMA_ACCUM_DATATYPE_NONE = 0,

    /// <include file='D3D12_WAVE_MMA_ACCUM_DATATYPE.xml' path='doc/member[@name="D3D12_WAVE_MMA_ACCUM_DATATYPE.D3D12_WAVE_MMA_ACCUM_DATATYPE_INT32"]/*' />
    D3D12_WAVE_MMA_ACCUM_DATATYPE_INT32 = 0x1,

    /// <include file='D3D12_WAVE_MMA_ACCUM_DATATYPE.xml' path='doc/member[@name="D3D12_WAVE_MMA_ACCUM_DATATYPE.D3D12_WAVE_MMA_ACCUM_DATATYPE_FLOAT16"]/*' />
    D3D12_WAVE_MMA_ACCUM_DATATYPE_FLOAT16 = 0x2,

    /// <include file='D3D12_WAVE_MMA_ACCUM_DATATYPE.xml' path='doc/member[@name="D3D12_WAVE_MMA_ACCUM_DATATYPE.D3D12_WAVE_MMA_ACCUM_DATATYPE_FLOAT"]/*' />
    D3D12_WAVE_MMA_ACCUM_DATATYPE_FLOAT = 0x4,
}
