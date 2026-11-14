// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3dcompiler.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

public static unsafe partial class D3D
{
    /// <include file='D3D.xml' path='doc/member[@name="D3D.D3D_COMPILER_VERSION"]/*' />
    [NativeTypeName("#define D3D_COMPILER_VERSION 47")]
    public const int D3D_COMPILER_VERSION = 47;

    /// <include file='D3D.xml' path='doc/member[@name="D3D.D3D_COMPILE_STANDARD_FILE_INCLUDE"]/*' />
    [NativeTypeName("#define D3D_COMPILE_STANDARD_FILE_INCLUDE ((ID3DInclude*)(UINT_PTR)1)")]
    public static ID3DInclude* D3D_COMPILE_STANDARD_FILE_INCLUDE => ((ID3DInclude*)((nuint)(1)));

    /// <include file='D3D.xml' path='doc/member[@name="D3D.D3D_DISASM_ENABLE_COLOR_CODE"]/*' />
    [NativeTypeName("#define D3D_DISASM_ENABLE_COLOR_CODE 0x00000001")]
    public const int D3D_DISASM_ENABLE_COLOR_CODE = 0x00000001;

    /// <include file='D3D.xml' path='doc/member[@name="D3D.D3D_DISASM_ENABLE_DEFAULT_VALUE_PRINTS"]/*' />
    [NativeTypeName("#define D3D_DISASM_ENABLE_DEFAULT_VALUE_PRINTS 0x00000002")]
    public const int D3D_DISASM_ENABLE_DEFAULT_VALUE_PRINTS = 0x00000002;

    /// <include file='D3D.xml' path='doc/member[@name="D3D.D3D_DISASM_ENABLE_INSTRUCTION_NUMBERING"]/*' />
    [NativeTypeName("#define D3D_DISASM_ENABLE_INSTRUCTION_NUMBERING 0x00000004")]
    public const int D3D_DISASM_ENABLE_INSTRUCTION_NUMBERING = 0x00000004;

    /// <include file='D3D.xml' path='doc/member[@name="D3D.D3D_DISASM_ENABLE_INSTRUCTION_CYCLE"]/*' />
    [NativeTypeName("#define D3D_DISASM_ENABLE_INSTRUCTION_CYCLE 0x00000008")]
    public const int D3D_DISASM_ENABLE_INSTRUCTION_CYCLE = 0x00000008;

    /// <include file='D3D.xml' path='doc/member[@name="D3D.D3D_DISASM_DISABLE_DEBUG_INFO"]/*' />
    [NativeTypeName("#define D3D_DISASM_DISABLE_DEBUG_INFO 0x00000010")]
    public const int D3D_DISASM_DISABLE_DEBUG_INFO = 0x00000010;

    /// <include file='D3D.xml' path='doc/member[@name="D3D.D3D_DISASM_ENABLE_INSTRUCTION_OFFSET"]/*' />
    [NativeTypeName("#define D3D_DISASM_ENABLE_INSTRUCTION_OFFSET 0x00000020")]
    public const int D3D_DISASM_ENABLE_INSTRUCTION_OFFSET = 0x00000020;

    /// <include file='D3D.xml' path='doc/member[@name="D3D.D3D_DISASM_INSTRUCTION_ONLY"]/*' />
    [NativeTypeName("#define D3D_DISASM_INSTRUCTION_ONLY 0x00000040")]
    public const int D3D_DISASM_INSTRUCTION_ONLY = 0x00000040;

    /// <include file='D3D.xml' path='doc/member[@name="D3D.D3D_DISASM_PRINT_HEX_LITERALS"]/*' />
    [NativeTypeName("#define D3D_DISASM_PRINT_HEX_LITERALS 0x00000080")]
    public const int D3D_DISASM_PRINT_HEX_LITERALS = 0x00000080;

    /// <include file='D3D.xml' path='doc/member[@name="D3D.D3D_GET_INST_OFFSETS_INCLUDE_NON_EXECUTABLE"]/*' />
    [NativeTypeName("#define D3D_GET_INST_OFFSETS_INCLUDE_NON_EXECUTABLE 0x00000001")]
    public const int D3D_GET_INST_OFFSETS_INCLUDE_NON_EXECUTABLE = 0x00000001;

    /// <include file='D3D.xml' path='doc/member[@name="D3D.D3D_COMPRESS_SHADER_KEEP_ALL_PARTS"]/*' />
    [NativeTypeName("#define D3D_COMPRESS_SHADER_KEEP_ALL_PARTS 0x00000001")]
    public const int D3D_COMPRESS_SHADER_KEEP_ALL_PARTS = 0x00000001;
}
