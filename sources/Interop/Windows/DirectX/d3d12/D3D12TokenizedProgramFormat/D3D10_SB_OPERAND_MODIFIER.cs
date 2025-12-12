// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from D3D12TokenizedProgramFormat.hpp in microsoft/DirectX-Headers tag v1.618.5
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace TerraFX.Interop.DirectX;

/// <include file='D3D10_SB_OPERAND_MODIFIER.xml' path='doc/member[@name="D3D10_SB_OPERAND_MODIFIER"]/*' />
public enum D3D10_SB_OPERAND_MODIFIER
{
    /// <include file='D3D10_SB_OPERAND_MODIFIER.xml' path='doc/member[@name="D3D10_SB_OPERAND_MODIFIER.D3D10_SB_OPERAND_MODIFIER_NONE"]/*' />
    D3D10_SB_OPERAND_MODIFIER_NONE = 0,

    /// <include file='D3D10_SB_OPERAND_MODIFIER.xml' path='doc/member[@name="D3D10_SB_OPERAND_MODIFIER.D3D10_SB_OPERAND_MODIFIER_NEG"]/*' />
    D3D10_SB_OPERAND_MODIFIER_NEG = 1,

    /// <include file='D3D10_SB_OPERAND_MODIFIER.xml' path='doc/member[@name="D3D10_SB_OPERAND_MODIFIER.D3D10_SB_OPERAND_MODIFIER_ABS"]/*' />
    D3D10_SB_OPERAND_MODIFIER_ABS = 2,

    /// <include file='D3D10_SB_OPERAND_MODIFIER.xml' path='doc/member[@name="D3D10_SB_OPERAND_MODIFIER.D3D10_SB_OPERAND_MODIFIER_ABSNEG"]/*' />
    D3D10_SB_OPERAND_MODIFIER_ABSNEG = 3,
}
