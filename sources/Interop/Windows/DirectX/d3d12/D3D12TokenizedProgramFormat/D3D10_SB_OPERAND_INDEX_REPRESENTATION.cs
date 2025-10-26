// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from D3D12TokenizedProgramFormat.hpp in microsoft/DirectX-Headers tag v1.618.2
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace TerraFX.Interop.DirectX;

/// <include file='D3D10_SB_OPERAND_INDEX_REPRESENTATION.xml' path='doc/member[@name="D3D10_SB_OPERAND_INDEX_REPRESENTATION"]/*' />
public enum D3D10_SB_OPERAND_INDEX_REPRESENTATION
{
    /// <include file='D3D10_SB_OPERAND_INDEX_REPRESENTATION.xml' path='doc/member[@name="D3D10_SB_OPERAND_INDEX_REPRESENTATION.D3D10_SB_OPERAND_INDEX_IMMEDIATE32"]/*' />
    D3D10_SB_OPERAND_INDEX_IMMEDIATE32 = 0,

    /// <include file='D3D10_SB_OPERAND_INDEX_REPRESENTATION.xml' path='doc/member[@name="D3D10_SB_OPERAND_INDEX_REPRESENTATION.D3D10_SB_OPERAND_INDEX_IMMEDIATE64"]/*' />
    D3D10_SB_OPERAND_INDEX_IMMEDIATE64 = 1,

    /// <include file='D3D10_SB_OPERAND_INDEX_REPRESENTATION.xml' path='doc/member[@name="D3D10_SB_OPERAND_INDEX_REPRESENTATION.D3D10_SB_OPERAND_INDEX_RELATIVE"]/*' />
    D3D10_SB_OPERAND_INDEX_RELATIVE = 2,

    /// <include file='D3D10_SB_OPERAND_INDEX_REPRESENTATION.xml' path='doc/member[@name="D3D10_SB_OPERAND_INDEX_REPRESENTATION.D3D10_SB_OPERAND_INDEX_IMMEDIATE32_PLUS_RELATIVE"]/*' />
    D3D10_SB_OPERAND_INDEX_IMMEDIATE32_PLUS_RELATIVE = 3,

    /// <include file='D3D10_SB_OPERAND_INDEX_REPRESENTATION.xml' path='doc/member[@name="D3D10_SB_OPERAND_INDEX_REPRESENTATION.D3D10_SB_OPERAND_INDEX_IMMEDIATE64_PLUS_RELATIVE"]/*' />
    D3D10_SB_OPERAND_INDEX_IMMEDIATE64_PLUS_RELATIVE = 4,
}
