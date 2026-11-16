// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/d3d9types.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

public static partial class D3DSI_
{
    /// <include file='D3DSI_.xml' path='doc/member[@name="D3DSI_.D3DSI_OPCODE_MASK"]/*' />
    [NativeTypeName("#define D3DSI_OPCODE_MASK 0x0000FFFF")]
    public const int D3DSI_OPCODE_MASK = 0x0000FFFF;

    /// <include file='D3DSI_.xml' path='doc/member[@name="D3DSI_.D3DSI_INSTLENGTH_MASK"]/*' />
    [NativeTypeName("#define D3DSI_INSTLENGTH_MASK 0x0F000000")]
    public const int D3DSI_INSTLENGTH_MASK = 0x0F000000;

    /// <include file='D3DSI_.xml' path='doc/member[@name="D3DSI_.D3DSI_INSTLENGTH_SHIFT"]/*' />
    [NativeTypeName("#define D3DSI_INSTLENGTH_SHIFT 24")]
    public const int D3DSI_INSTLENGTH_SHIFT = 24;

    /// <include file='D3DSI_.xml' path='doc/member[@name="D3DSI_.D3DSI_COISSUE"]/*' />
    [NativeTypeName("#define D3DSI_COISSUE 0x40000000")]
    public const int D3DSI_COISSUE = 0x40000000;

    /// <include file='D3DSI_.xml' path='doc/member[@name="D3DSI_.D3DSI_TEXLD_PROJECT"]/*' />
    [NativeTypeName("#define D3DSI_TEXLD_PROJECT (0x01 << D3DSP_OPCODESPECIFICCONTROL_SHIFT)")]
    public const int D3DSI_TEXLD_PROJECT = (0x01 << 16);

    /// <include file='D3DSI_.xml' path='doc/member[@name="D3DSI_.D3DSI_TEXLD_BIAS"]/*' />
    [NativeTypeName("#define D3DSI_TEXLD_BIAS (0x02 << D3DSP_OPCODESPECIFICCONTROL_SHIFT)")]
    public const int D3DSI_TEXLD_BIAS = (0x02 << 16);

    /// <include file='D3DSI_.xml' path='doc/member[@name="D3DSI_.D3DSI_COMMENTSIZE_SHIFT"]/*' />
    [NativeTypeName("#define D3DSI_COMMENTSIZE_SHIFT 16")]
    public const int D3DSI_COMMENTSIZE_SHIFT = 16;

    /// <include file='D3DSI_.xml' path='doc/member[@name="D3DSI_.D3DSI_COMMENTSIZE_MASK"]/*' />
    [NativeTypeName("#define D3DSI_COMMENTSIZE_MASK 0x7FFF0000")]
    public const int D3DSI_COMMENTSIZE_MASK = 0x7FFF0000;
}
