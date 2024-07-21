// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from D3D12TokenizedProgramFormat.hpp in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace TerraFX.Interop.DirectX;

/// <include file='D3D10_SB_TOKENIZED_PROGRAM_TYPE.xml' path='doc/member[@name="D3D10_SB_TOKENIZED_PROGRAM_TYPE"]/*' />
public enum D3D10_SB_TOKENIZED_PROGRAM_TYPE
{
    /// <include file='D3D10_SB_TOKENIZED_PROGRAM_TYPE.xml' path='doc/member[@name="D3D10_SB_TOKENIZED_PROGRAM_TYPE.D3D10_SB_PIXEL_SHADER"]/*' />
    D3D10_SB_PIXEL_SHADER = 0,

    /// <include file='D3D10_SB_TOKENIZED_PROGRAM_TYPE.xml' path='doc/member[@name="D3D10_SB_TOKENIZED_PROGRAM_TYPE.D3D10_SB_VERTEX_SHADER"]/*' />
    D3D10_SB_VERTEX_SHADER = 1,

    /// <include file='D3D10_SB_TOKENIZED_PROGRAM_TYPE.xml' path='doc/member[@name="D3D10_SB_TOKENIZED_PROGRAM_TYPE.D3D10_SB_GEOMETRY_SHADER"]/*' />
    D3D10_SB_GEOMETRY_SHADER = 2,

    /// <include file='D3D10_SB_TOKENIZED_PROGRAM_TYPE.xml' path='doc/member[@name="D3D10_SB_TOKENIZED_PROGRAM_TYPE.D3D11_SB_HULL_SHADER"]/*' />
    D3D11_SB_HULL_SHADER = 3,

    /// <include file='D3D10_SB_TOKENIZED_PROGRAM_TYPE.xml' path='doc/member[@name="D3D10_SB_TOKENIZED_PROGRAM_TYPE.D3D11_SB_DOMAIN_SHADER"]/*' />
    D3D11_SB_DOMAIN_SHADER = 4,

    /// <include file='D3D10_SB_TOKENIZED_PROGRAM_TYPE.xml' path='doc/member[@name="D3D10_SB_TOKENIZED_PROGRAM_TYPE.D3D11_SB_COMPUTE_SHADER"]/*' />
    D3D11_SB_COMPUTE_SHADER = 5,

    /// <include file='D3D10_SB_TOKENIZED_PROGRAM_TYPE.xml' path='doc/member[@name="D3D10_SB_TOKENIZED_PROGRAM_TYPE.D3D12_SB_MESH_SHADER"]/*' />
    D3D12_SB_MESH_SHADER = 13,

    /// <include file='D3D10_SB_TOKENIZED_PROGRAM_TYPE.xml' path='doc/member[@name="D3D10_SB_TOKENIZED_PROGRAM_TYPE.D3D12_SB_AMPLIFICATION_SHADER"]/*' />
    D3D12_SB_AMPLIFICATION_SHADER = 14,

    /// <include file='D3D10_SB_TOKENIZED_PROGRAM_TYPE.xml' path='doc/member[@name="D3D10_SB_TOKENIZED_PROGRAM_TYPE.D3D11_SB_RESERVED0"]/*' />
    D3D11_SB_RESERVED0 = 0xFFF0,
}
