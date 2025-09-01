// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from D3D12TokenizedProgramFormat.hpp in microsoft/DirectX-Headers tag v1.616.0
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace TerraFX.Interop.DirectX;

/// <include file='D3D10_SB_OPERAND_4_COMPONENT_SELECTION_MODE.xml' path='doc/member[@name="D3D10_SB_OPERAND_4_COMPONENT_SELECTION_MODE"]/*' />
public enum D3D10_SB_OPERAND_4_COMPONENT_SELECTION_MODE
{
    /// <include file='D3D10_SB_OPERAND_4_COMPONENT_SELECTION_MODE.xml' path='doc/member[@name="D3D10_SB_OPERAND_4_COMPONENT_SELECTION_MODE.D3D10_SB_OPERAND_4_COMPONENT_MASK_MODE"]/*' />
    D3D10_SB_OPERAND_4_COMPONENT_MASK_MODE = 0,

    /// <include file='D3D10_SB_OPERAND_4_COMPONENT_SELECTION_MODE.xml' path='doc/member[@name="D3D10_SB_OPERAND_4_COMPONENT_SELECTION_MODE.D3D10_SB_OPERAND_4_COMPONENT_SWIZZLE_MODE"]/*' />
    D3D10_SB_OPERAND_4_COMPONENT_SWIZZLE_MODE = 1,

    /// <include file='D3D10_SB_OPERAND_4_COMPONENT_SELECTION_MODE.xml' path='doc/member[@name="D3D10_SB_OPERAND_4_COMPONENT_SELECTION_MODE.D3D10_SB_OPERAND_4_COMPONENT_SELECT_1_MODE"]/*' />
    D3D10_SB_OPERAND_4_COMPONENT_SELECT_1_MODE = 2,
}
