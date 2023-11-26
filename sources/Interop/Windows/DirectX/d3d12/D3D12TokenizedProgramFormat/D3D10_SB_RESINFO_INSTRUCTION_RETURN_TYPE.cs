// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from D3D12TokenizedProgramFormat.hpp in microsoft/DirectX-Headers tag v1.611.2
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace TerraFX.Interop.DirectX;

/// <include file='D3D10_SB_RESINFO_INSTRUCTION_RETURN_TYPE.xml' path='doc/member[@name="D3D10_SB_RESINFO_INSTRUCTION_RETURN_TYPE"]/*' />
public enum D3D10_SB_RESINFO_INSTRUCTION_RETURN_TYPE
{
    /// <include file='D3D10_SB_RESINFO_INSTRUCTION_RETURN_TYPE.xml' path='doc/member[@name="D3D10_SB_RESINFO_INSTRUCTION_RETURN_TYPE.D3D10_SB_RESINFO_INSTRUCTION_RETURN_FLOAT"]/*' />
    D3D10_SB_RESINFO_INSTRUCTION_RETURN_FLOAT = 0,

    /// <include file='D3D10_SB_RESINFO_INSTRUCTION_RETURN_TYPE.xml' path='doc/member[@name="D3D10_SB_RESINFO_INSTRUCTION_RETURN_TYPE.D3D10_SB_RESINFO_INSTRUCTION_RETURN_RCPFLOAT"]/*' />
    D3D10_SB_RESINFO_INSTRUCTION_RETURN_RCPFLOAT = 1,

    /// <include file='D3D10_SB_RESINFO_INSTRUCTION_RETURN_TYPE.xml' path='doc/member[@name="D3D10_SB_RESINFO_INSTRUCTION_RETURN_TYPE.D3D10_SB_RESINFO_INSTRUCTION_RETURN_UINT"]/*' />
    D3D10_SB_RESINFO_INSTRUCTION_RETURN_UINT = 2,
}
