// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11shadertracing.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

public static partial class D3D11
{
    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_TRACE_COMPONENT_X"]/*' />
    [NativeTypeName("#define D3D11_TRACE_COMPONENT_X 0x1")]
    public const int D3D11_TRACE_COMPONENT_X = 0x1;

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_TRACE_COMPONENT_Y"]/*' />
    [NativeTypeName("#define D3D11_TRACE_COMPONENT_Y 0x2")]
    public const int D3D11_TRACE_COMPONENT_Y = 0x2;

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_TRACE_COMPONENT_Z"]/*' />
    [NativeTypeName("#define D3D11_TRACE_COMPONENT_Z 0x4")]
    public const int D3D11_TRACE_COMPONENT_Z = 0x4;

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_TRACE_COMPONENT_W"]/*' />
    [NativeTypeName("#define D3D11_TRACE_COMPONENT_W 0x8")]
    public const int D3D11_TRACE_COMPONENT_W = 0x8;

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_SHADER_TRACE_FLAG_RECORD_REGISTER_WRITES"]/*' />
    [NativeTypeName("#define D3D11_SHADER_TRACE_FLAG_RECORD_REGISTER_WRITES 0x1")]
    public const int D3D11_SHADER_TRACE_FLAG_RECORD_REGISTER_WRITES = 0x1;

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_SHADER_TRACE_FLAG_RECORD_REGISTER_READS"]/*' />
    [NativeTypeName("#define D3D11_SHADER_TRACE_FLAG_RECORD_REGISTER_READS 0x2")]
    public const int D3D11_SHADER_TRACE_FLAG_RECORD_REGISTER_READS = 0x2;

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_TRACE_REGISTER_FLAGS_RELATIVE_INDEXING"]/*' />
    [NativeTypeName("#define D3D11_TRACE_REGISTER_FLAGS_RELATIVE_INDEXING 0x1")]
    public const int D3D11_TRACE_REGISTER_FLAGS_RELATIVE_INDEXING = 0x1;

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_TRACE_MISC_GS_EMIT"]/*' />
    [NativeTypeName("#define D3D11_TRACE_MISC_GS_EMIT 0x1")]
    public const int D3D11_TRACE_MISC_GS_EMIT = 0x1;

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_TRACE_MISC_GS_CUT"]/*' />
    [NativeTypeName("#define D3D11_TRACE_MISC_GS_CUT 0x2")]
    public const int D3D11_TRACE_MISC_GS_CUT = 0x2;

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_TRACE_MISC_PS_DISCARD"]/*' />
    [NativeTypeName("#define D3D11_TRACE_MISC_PS_DISCARD 0x4")]
    public const int D3D11_TRACE_MISC_PS_DISCARD = 0x4;

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_TRACE_MISC_GS_EMIT_STREAM"]/*' />
    [NativeTypeName("#define D3D11_TRACE_MISC_GS_EMIT_STREAM 0x8")]
    public const int D3D11_TRACE_MISC_GS_EMIT_STREAM = 0x8;

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_TRACE_MISC_GS_CUT_STREAM"]/*' />
    [NativeTypeName("#define D3D11_TRACE_MISC_GS_CUT_STREAM 0x10")]
    public const int D3D11_TRACE_MISC_GS_CUT_STREAM = 0x10;

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_TRACE_MISC_HALT"]/*' />
    [NativeTypeName("#define D3D11_TRACE_MISC_HALT 0x20")]
    public const int D3D11_TRACE_MISC_HALT = 0x20;

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_TRACE_MISC_MESSAGE"]/*' />
    [NativeTypeName("#define D3D11_TRACE_MISC_MESSAGE 0x40")]
    public const int D3D11_TRACE_MISC_MESSAGE = 0x40;
}
