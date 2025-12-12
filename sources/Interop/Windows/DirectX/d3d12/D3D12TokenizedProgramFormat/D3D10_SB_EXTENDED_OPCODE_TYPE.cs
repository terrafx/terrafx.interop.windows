// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from D3D12TokenizedProgramFormat.hpp in microsoft/DirectX-Headers tag v1.618.5
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace TerraFX.Interop.DirectX;

/// <include file='D3D10_SB_EXTENDED_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_EXTENDED_OPCODE_TYPE"]/*' />
public enum D3D10_SB_EXTENDED_OPCODE_TYPE
{
    /// <include file='D3D10_SB_EXTENDED_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_EXTENDED_OPCODE_TYPE.D3D10_SB_EXTENDED_OPCODE_EMPTY"]/*' />
    D3D10_SB_EXTENDED_OPCODE_EMPTY = 0,

    /// <include file='D3D10_SB_EXTENDED_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_EXTENDED_OPCODE_TYPE.D3D10_SB_EXTENDED_OPCODE_SAMPLE_CONTROLS"]/*' />
    D3D10_SB_EXTENDED_OPCODE_SAMPLE_CONTROLS = 1,

    /// <include file='D3D10_SB_EXTENDED_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_EXTENDED_OPCODE_TYPE.D3D11_SB_EXTENDED_OPCODE_RESOURCE_DIM"]/*' />
    D3D11_SB_EXTENDED_OPCODE_RESOURCE_DIM = 2,

    /// <include file='D3D10_SB_EXTENDED_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_EXTENDED_OPCODE_TYPE.D3D11_SB_EXTENDED_OPCODE_RESOURCE_RETURN_TYPE"]/*' />
    D3D11_SB_EXTENDED_OPCODE_RESOURCE_RETURN_TYPE = 3,
}
