// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/d3d9types.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

public static partial class D3DSHADER
{
    /// <include file='D3DSHADER.xml' path='doc/member[@name="D3DSHADER.D3DSHADER_COMPARISON_SHIFT"]/*' />
    [NativeTypeName("#define D3DSHADER_COMPARISON_SHIFT D3DSP_OPCODESPECIFICCONTROL_SHIFT")]
    public const int D3DSHADER_COMPARISON_SHIFT = 16;

    /// <include file='D3DSHADER.xml' path='doc/member[@name="D3DSHADER.D3DSHADER_COMPARISON_MASK"]/*' />
    [NativeTypeName("#define D3DSHADER_COMPARISON_MASK (0x7<<D3DSHADER_COMPARISON_SHIFT)")]
    public const int D3DSHADER_COMPARISON_MASK = (0x7 << 16);

    /// <include file='D3DSHADER.xml' path='doc/member[@name="D3DSHADER.D3DSHADER_INSTRUCTION_PREDICATED"]/*' />
    [NativeTypeName("#define D3DSHADER_INSTRUCTION_PREDICATED (0x1 << 28)")]
    public const int D3DSHADER_INSTRUCTION_PREDICATED = (0x1 << 28);

    /// <include file='D3DSHADER.xml' path='doc/member[@name="D3DSHADER.D3DSHADER_ADDRESSMODE_SHIFT"]/*' />
    [NativeTypeName("#define D3DSHADER_ADDRESSMODE_SHIFT 13")]
    public const int D3DSHADER_ADDRESSMODE_SHIFT = 13;

    /// <include file='D3DSHADER.xml' path='doc/member[@name="D3DSHADER.D3DSHADER_ADDRESSMODE_MASK"]/*' />
    [NativeTypeName("#define D3DSHADER_ADDRESSMODE_MASK (1 << D3DSHADER_ADDRESSMODE_SHIFT)")]
    public const int D3DSHADER_ADDRESSMODE_MASK = (1 << 13);
}
