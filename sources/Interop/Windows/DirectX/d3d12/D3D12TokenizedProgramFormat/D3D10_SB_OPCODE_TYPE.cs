// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from D3D12TokenizedProgramFormat.hpp in microsoft/DirectX-Headers tag v1.618.5
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace TerraFX.Interop.DirectX;

/// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE"]/*' />
public enum D3D10_SB_OPCODE_TYPE
{
    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D10_SB_OPCODE_ADD"]/*' />
    D3D10_SB_OPCODE_ADD,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D10_SB_OPCODE_AND"]/*' />
    D3D10_SB_OPCODE_AND,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D10_SB_OPCODE_BREAK"]/*' />
    D3D10_SB_OPCODE_BREAK,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D10_SB_OPCODE_BREAKC"]/*' />
    D3D10_SB_OPCODE_BREAKC,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D10_SB_OPCODE_CALL"]/*' />
    D3D10_SB_OPCODE_CALL,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D10_SB_OPCODE_CALLC"]/*' />
    D3D10_SB_OPCODE_CALLC,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D10_SB_OPCODE_CASE"]/*' />
    D3D10_SB_OPCODE_CASE,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D10_SB_OPCODE_CONTINUE"]/*' />
    D3D10_SB_OPCODE_CONTINUE,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D10_SB_OPCODE_CONTINUEC"]/*' />
    D3D10_SB_OPCODE_CONTINUEC,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D10_SB_OPCODE_CUT"]/*' />
    D3D10_SB_OPCODE_CUT,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D10_SB_OPCODE_DEFAULT"]/*' />
    D3D10_SB_OPCODE_DEFAULT,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D10_SB_OPCODE_DERIV_RTX"]/*' />
    D3D10_SB_OPCODE_DERIV_RTX,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D10_SB_OPCODE_DERIV_RTY"]/*' />
    D3D10_SB_OPCODE_DERIV_RTY,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D10_SB_OPCODE_DISCARD"]/*' />
    D3D10_SB_OPCODE_DISCARD,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D10_SB_OPCODE_DIV"]/*' />
    D3D10_SB_OPCODE_DIV,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D10_SB_OPCODE_DP2"]/*' />
    D3D10_SB_OPCODE_DP2,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D10_SB_OPCODE_DP3"]/*' />
    D3D10_SB_OPCODE_DP3,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D10_SB_OPCODE_DP4"]/*' />
    D3D10_SB_OPCODE_DP4,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D10_SB_OPCODE_ELSE"]/*' />
    D3D10_SB_OPCODE_ELSE,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D10_SB_OPCODE_EMIT"]/*' />
    D3D10_SB_OPCODE_EMIT,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D10_SB_OPCODE_EMITTHENCUT"]/*' />
    D3D10_SB_OPCODE_EMITTHENCUT,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D10_SB_OPCODE_ENDIF"]/*' />
    D3D10_SB_OPCODE_ENDIF,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D10_SB_OPCODE_ENDLOOP"]/*' />
    D3D10_SB_OPCODE_ENDLOOP,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D10_SB_OPCODE_ENDSWITCH"]/*' />
    D3D10_SB_OPCODE_ENDSWITCH,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D10_SB_OPCODE_EQ"]/*' />
    D3D10_SB_OPCODE_EQ,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D10_SB_OPCODE_EXP"]/*' />
    D3D10_SB_OPCODE_EXP,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D10_SB_OPCODE_FRC"]/*' />
    D3D10_SB_OPCODE_FRC,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D10_SB_OPCODE_FTOI"]/*' />
    D3D10_SB_OPCODE_FTOI,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D10_SB_OPCODE_FTOU"]/*' />
    D3D10_SB_OPCODE_FTOU,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D10_SB_OPCODE_GE"]/*' />
    D3D10_SB_OPCODE_GE,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D10_SB_OPCODE_IADD"]/*' />
    D3D10_SB_OPCODE_IADD,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D10_SB_OPCODE_IF"]/*' />
    D3D10_SB_OPCODE_IF,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D10_SB_OPCODE_IEQ"]/*' />
    D3D10_SB_OPCODE_IEQ,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D10_SB_OPCODE_IGE"]/*' />
    D3D10_SB_OPCODE_IGE,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D10_SB_OPCODE_ILT"]/*' />
    D3D10_SB_OPCODE_ILT,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D10_SB_OPCODE_IMAD"]/*' />
    D3D10_SB_OPCODE_IMAD,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D10_SB_OPCODE_IMAX"]/*' />
    D3D10_SB_OPCODE_IMAX,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D10_SB_OPCODE_IMIN"]/*' />
    D3D10_SB_OPCODE_IMIN,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D10_SB_OPCODE_IMUL"]/*' />
    D3D10_SB_OPCODE_IMUL,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D10_SB_OPCODE_INE"]/*' />
    D3D10_SB_OPCODE_INE,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D10_SB_OPCODE_INEG"]/*' />
    D3D10_SB_OPCODE_INEG,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D10_SB_OPCODE_ISHL"]/*' />
    D3D10_SB_OPCODE_ISHL,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D10_SB_OPCODE_ISHR"]/*' />
    D3D10_SB_OPCODE_ISHR,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D10_SB_OPCODE_ITOF"]/*' />
    D3D10_SB_OPCODE_ITOF,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D10_SB_OPCODE_LABEL"]/*' />
    D3D10_SB_OPCODE_LABEL,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D10_SB_OPCODE_LD"]/*' />
    D3D10_SB_OPCODE_LD,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D10_SB_OPCODE_LD_MS"]/*' />
    D3D10_SB_OPCODE_LD_MS,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D10_SB_OPCODE_LOG"]/*' />
    D3D10_SB_OPCODE_LOG,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D10_SB_OPCODE_LOOP"]/*' />
    D3D10_SB_OPCODE_LOOP,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D10_SB_OPCODE_LT"]/*' />
    D3D10_SB_OPCODE_LT,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D10_SB_OPCODE_MAD"]/*' />
    D3D10_SB_OPCODE_MAD,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D10_SB_OPCODE_MIN"]/*' />
    D3D10_SB_OPCODE_MIN,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D10_SB_OPCODE_MAX"]/*' />
    D3D10_SB_OPCODE_MAX,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D10_SB_OPCODE_CUSTOMDATA"]/*' />
    D3D10_SB_OPCODE_CUSTOMDATA,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D10_SB_OPCODE_MOV"]/*' />
    D3D10_SB_OPCODE_MOV,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D10_SB_OPCODE_MOVC"]/*' />
    D3D10_SB_OPCODE_MOVC,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D10_SB_OPCODE_MUL"]/*' />
    D3D10_SB_OPCODE_MUL,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D10_SB_OPCODE_NE"]/*' />
    D3D10_SB_OPCODE_NE,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D10_SB_OPCODE_NOP"]/*' />
    D3D10_SB_OPCODE_NOP,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D10_SB_OPCODE_NOT"]/*' />
    D3D10_SB_OPCODE_NOT,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D10_SB_OPCODE_OR"]/*' />
    D3D10_SB_OPCODE_OR,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D10_SB_OPCODE_RESINFO"]/*' />
    D3D10_SB_OPCODE_RESINFO,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D10_SB_OPCODE_RET"]/*' />
    D3D10_SB_OPCODE_RET,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D10_SB_OPCODE_RETC"]/*' />
    D3D10_SB_OPCODE_RETC,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D10_SB_OPCODE_ROUND_NE"]/*' />
    D3D10_SB_OPCODE_ROUND_NE,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D10_SB_OPCODE_ROUND_NI"]/*' />
    D3D10_SB_OPCODE_ROUND_NI,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D10_SB_OPCODE_ROUND_PI"]/*' />
    D3D10_SB_OPCODE_ROUND_PI,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D10_SB_OPCODE_ROUND_Z"]/*' />
    D3D10_SB_OPCODE_ROUND_Z,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D10_SB_OPCODE_RSQ"]/*' />
    D3D10_SB_OPCODE_RSQ,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D10_SB_OPCODE_SAMPLE"]/*' />
    D3D10_SB_OPCODE_SAMPLE,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D10_SB_OPCODE_SAMPLE_C"]/*' />
    D3D10_SB_OPCODE_SAMPLE_C,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D10_SB_OPCODE_SAMPLE_C_LZ"]/*' />
    D3D10_SB_OPCODE_SAMPLE_C_LZ,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D10_SB_OPCODE_SAMPLE_L"]/*' />
    D3D10_SB_OPCODE_SAMPLE_L,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D10_SB_OPCODE_SAMPLE_D"]/*' />
    D3D10_SB_OPCODE_SAMPLE_D,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D10_SB_OPCODE_SAMPLE_B"]/*' />
    D3D10_SB_OPCODE_SAMPLE_B,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D10_SB_OPCODE_SQRT"]/*' />
    D3D10_SB_OPCODE_SQRT,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D10_SB_OPCODE_SWITCH"]/*' />
    D3D10_SB_OPCODE_SWITCH,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D10_SB_OPCODE_SINCOS"]/*' />
    D3D10_SB_OPCODE_SINCOS,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D10_SB_OPCODE_UDIV"]/*' />
    D3D10_SB_OPCODE_UDIV,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D10_SB_OPCODE_ULT"]/*' />
    D3D10_SB_OPCODE_ULT,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D10_SB_OPCODE_UGE"]/*' />
    D3D10_SB_OPCODE_UGE,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D10_SB_OPCODE_UMUL"]/*' />
    D3D10_SB_OPCODE_UMUL,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D10_SB_OPCODE_UMAD"]/*' />
    D3D10_SB_OPCODE_UMAD,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D10_SB_OPCODE_UMAX"]/*' />
    D3D10_SB_OPCODE_UMAX,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D10_SB_OPCODE_UMIN"]/*' />
    D3D10_SB_OPCODE_UMIN,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D10_SB_OPCODE_USHR"]/*' />
    D3D10_SB_OPCODE_USHR,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D10_SB_OPCODE_UTOF"]/*' />
    D3D10_SB_OPCODE_UTOF,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D10_SB_OPCODE_XOR"]/*' />
    D3D10_SB_OPCODE_XOR,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D10_SB_OPCODE_DCL_RESOURCE"]/*' />
    D3D10_SB_OPCODE_DCL_RESOURCE,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D10_SB_OPCODE_DCL_CONSTANT_BUFFER"]/*' />
    D3D10_SB_OPCODE_DCL_CONSTANT_BUFFER,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D10_SB_OPCODE_DCL_SAMPLER"]/*' />
    D3D10_SB_OPCODE_DCL_SAMPLER,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D10_SB_OPCODE_DCL_INDEX_RANGE"]/*' />
    D3D10_SB_OPCODE_DCL_INDEX_RANGE,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D10_SB_OPCODE_DCL_GS_OUTPUT_PRIMITIVE_TOPOLOGY"]/*' />
    D3D10_SB_OPCODE_DCL_GS_OUTPUT_PRIMITIVE_TOPOLOGY,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D10_SB_OPCODE_DCL_GS_INPUT_PRIMITIVE"]/*' />
    D3D10_SB_OPCODE_DCL_GS_INPUT_PRIMITIVE,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D10_SB_OPCODE_DCL_MAX_OUTPUT_VERTEX_COUNT"]/*' />
    D3D10_SB_OPCODE_DCL_MAX_OUTPUT_VERTEX_COUNT,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D10_SB_OPCODE_DCL_INPUT"]/*' />
    D3D10_SB_OPCODE_DCL_INPUT,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D10_SB_OPCODE_DCL_INPUT_SGV"]/*' />
    D3D10_SB_OPCODE_DCL_INPUT_SGV,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D10_SB_OPCODE_DCL_INPUT_SIV"]/*' />
    D3D10_SB_OPCODE_DCL_INPUT_SIV,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D10_SB_OPCODE_DCL_INPUT_PS"]/*' />
    D3D10_SB_OPCODE_DCL_INPUT_PS,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D10_SB_OPCODE_DCL_INPUT_PS_SGV"]/*' />
    D3D10_SB_OPCODE_DCL_INPUT_PS_SGV,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D10_SB_OPCODE_DCL_INPUT_PS_SIV"]/*' />
    D3D10_SB_OPCODE_DCL_INPUT_PS_SIV,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D10_SB_OPCODE_DCL_OUTPUT"]/*' />
    D3D10_SB_OPCODE_DCL_OUTPUT,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D10_SB_OPCODE_DCL_OUTPUT_SGV"]/*' />
    D3D10_SB_OPCODE_DCL_OUTPUT_SGV,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D10_SB_OPCODE_DCL_OUTPUT_SIV"]/*' />
    D3D10_SB_OPCODE_DCL_OUTPUT_SIV,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D10_SB_OPCODE_DCL_TEMPS"]/*' />
    D3D10_SB_OPCODE_DCL_TEMPS,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D10_SB_OPCODE_DCL_INDEXABLE_TEMP"]/*' />
    D3D10_SB_OPCODE_DCL_INDEXABLE_TEMP,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D10_SB_OPCODE_DCL_GLOBAL_FLAGS"]/*' />
    D3D10_SB_OPCODE_DCL_GLOBAL_FLAGS,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D10_SB_OPCODE_RESERVED0"]/*' />
    D3D10_SB_OPCODE_RESERVED0,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D10_1_SB_OPCODE_LOD"]/*' />
    D3D10_1_SB_OPCODE_LOD,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D10_1_SB_OPCODE_GATHER4"]/*' />
    D3D10_1_SB_OPCODE_GATHER4,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D10_1_SB_OPCODE_SAMPLE_POS"]/*' />
    D3D10_1_SB_OPCODE_SAMPLE_POS,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D10_1_SB_OPCODE_SAMPLE_INFO"]/*' />
    D3D10_1_SB_OPCODE_SAMPLE_INFO,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D10_1_SB_OPCODE_RESERVED1"]/*' />
    D3D10_1_SB_OPCODE_RESERVED1,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D11_SB_OPCODE_HS_DECLS"]/*' />
    D3D11_SB_OPCODE_HS_DECLS,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D11_SB_OPCODE_HS_CONTROL_POINT_PHASE"]/*' />
    D3D11_SB_OPCODE_HS_CONTROL_POINT_PHASE,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D11_SB_OPCODE_HS_FORK_PHASE"]/*' />
    D3D11_SB_OPCODE_HS_FORK_PHASE,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D11_SB_OPCODE_HS_JOIN_PHASE"]/*' />
    D3D11_SB_OPCODE_HS_JOIN_PHASE,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D11_SB_OPCODE_EMIT_STREAM"]/*' />
    D3D11_SB_OPCODE_EMIT_STREAM,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D11_SB_OPCODE_CUT_STREAM"]/*' />
    D3D11_SB_OPCODE_CUT_STREAM,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D11_SB_OPCODE_EMITTHENCUT_STREAM"]/*' />
    D3D11_SB_OPCODE_EMITTHENCUT_STREAM,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D11_SB_OPCODE_INTERFACE_CALL"]/*' />
    D3D11_SB_OPCODE_INTERFACE_CALL,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D11_SB_OPCODE_BUFINFO"]/*' />
    D3D11_SB_OPCODE_BUFINFO,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D11_SB_OPCODE_DERIV_RTX_COARSE"]/*' />
    D3D11_SB_OPCODE_DERIV_RTX_COARSE,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D11_SB_OPCODE_DERIV_RTX_FINE"]/*' />
    D3D11_SB_OPCODE_DERIV_RTX_FINE,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D11_SB_OPCODE_DERIV_RTY_COARSE"]/*' />
    D3D11_SB_OPCODE_DERIV_RTY_COARSE,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D11_SB_OPCODE_DERIV_RTY_FINE"]/*' />
    D3D11_SB_OPCODE_DERIV_RTY_FINE,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D11_SB_OPCODE_GATHER4_C"]/*' />
    D3D11_SB_OPCODE_GATHER4_C,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D11_SB_OPCODE_GATHER4_PO"]/*' />
    D3D11_SB_OPCODE_GATHER4_PO,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D11_SB_OPCODE_GATHER4_PO_C"]/*' />
    D3D11_SB_OPCODE_GATHER4_PO_C,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D11_SB_OPCODE_RCP"]/*' />
    D3D11_SB_OPCODE_RCP,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D11_SB_OPCODE_F32TOF16"]/*' />
    D3D11_SB_OPCODE_F32TOF16,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D11_SB_OPCODE_F16TOF32"]/*' />
    D3D11_SB_OPCODE_F16TOF32,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D11_SB_OPCODE_UADDC"]/*' />
    D3D11_SB_OPCODE_UADDC,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D11_SB_OPCODE_USUBB"]/*' />
    D3D11_SB_OPCODE_USUBB,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D11_SB_OPCODE_COUNTBITS"]/*' />
    D3D11_SB_OPCODE_COUNTBITS,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D11_SB_OPCODE_FIRSTBIT_HI"]/*' />
    D3D11_SB_OPCODE_FIRSTBIT_HI,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D11_SB_OPCODE_FIRSTBIT_LO"]/*' />
    D3D11_SB_OPCODE_FIRSTBIT_LO,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D11_SB_OPCODE_FIRSTBIT_SHI"]/*' />
    D3D11_SB_OPCODE_FIRSTBIT_SHI,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D11_SB_OPCODE_UBFE"]/*' />
    D3D11_SB_OPCODE_UBFE,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D11_SB_OPCODE_IBFE"]/*' />
    D3D11_SB_OPCODE_IBFE,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D11_SB_OPCODE_BFI"]/*' />
    D3D11_SB_OPCODE_BFI,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D11_SB_OPCODE_BFREV"]/*' />
    D3D11_SB_OPCODE_BFREV,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D11_SB_OPCODE_SWAPC"]/*' />
    D3D11_SB_OPCODE_SWAPC,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D11_SB_OPCODE_DCL_STREAM"]/*' />
    D3D11_SB_OPCODE_DCL_STREAM,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D11_SB_OPCODE_DCL_FUNCTION_BODY"]/*' />
    D3D11_SB_OPCODE_DCL_FUNCTION_BODY,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D11_SB_OPCODE_DCL_FUNCTION_TABLE"]/*' />
    D3D11_SB_OPCODE_DCL_FUNCTION_TABLE,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D11_SB_OPCODE_DCL_INTERFACE"]/*' />
    D3D11_SB_OPCODE_DCL_INTERFACE,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D11_SB_OPCODE_DCL_INPUT_CONTROL_POINT_COUNT"]/*' />
    D3D11_SB_OPCODE_DCL_INPUT_CONTROL_POINT_COUNT,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D11_SB_OPCODE_DCL_OUTPUT_CONTROL_POINT_COUNT"]/*' />
    D3D11_SB_OPCODE_DCL_OUTPUT_CONTROL_POINT_COUNT,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D11_SB_OPCODE_DCL_TESS_DOMAIN"]/*' />
    D3D11_SB_OPCODE_DCL_TESS_DOMAIN,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D11_SB_OPCODE_DCL_TESS_PARTITIONING"]/*' />
    D3D11_SB_OPCODE_DCL_TESS_PARTITIONING,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D11_SB_OPCODE_DCL_TESS_OUTPUT_PRIMITIVE"]/*' />
    D3D11_SB_OPCODE_DCL_TESS_OUTPUT_PRIMITIVE,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D11_SB_OPCODE_DCL_HS_MAX_TESSFACTOR"]/*' />
    D3D11_SB_OPCODE_DCL_HS_MAX_TESSFACTOR,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D11_SB_OPCODE_DCL_HS_FORK_PHASE_INSTANCE_COUNT"]/*' />
    D3D11_SB_OPCODE_DCL_HS_FORK_PHASE_INSTANCE_COUNT,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D11_SB_OPCODE_DCL_HS_JOIN_PHASE_INSTANCE_COUNT"]/*' />
    D3D11_SB_OPCODE_DCL_HS_JOIN_PHASE_INSTANCE_COUNT,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D11_SB_OPCODE_DCL_THREAD_GROUP"]/*' />
    D3D11_SB_OPCODE_DCL_THREAD_GROUP,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D11_SB_OPCODE_DCL_UNORDERED_ACCESS_VIEW_TYPED"]/*' />
    D3D11_SB_OPCODE_DCL_UNORDERED_ACCESS_VIEW_TYPED,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D11_SB_OPCODE_DCL_UNORDERED_ACCESS_VIEW_RAW"]/*' />
    D3D11_SB_OPCODE_DCL_UNORDERED_ACCESS_VIEW_RAW,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D11_SB_OPCODE_DCL_UNORDERED_ACCESS_VIEW_STRUCTURED"]/*' />
    D3D11_SB_OPCODE_DCL_UNORDERED_ACCESS_VIEW_STRUCTURED,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D11_SB_OPCODE_DCL_THREAD_GROUP_SHARED_MEMORY_RAW"]/*' />
    D3D11_SB_OPCODE_DCL_THREAD_GROUP_SHARED_MEMORY_RAW,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D11_SB_OPCODE_DCL_THREAD_GROUP_SHARED_MEMORY_STRUCTURED"]/*' />
    D3D11_SB_OPCODE_DCL_THREAD_GROUP_SHARED_MEMORY_STRUCTURED,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D11_SB_OPCODE_DCL_RESOURCE_RAW"]/*' />
    D3D11_SB_OPCODE_DCL_RESOURCE_RAW,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D11_SB_OPCODE_DCL_RESOURCE_STRUCTURED"]/*' />
    D3D11_SB_OPCODE_DCL_RESOURCE_STRUCTURED,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D11_SB_OPCODE_LD_UAV_TYPED"]/*' />
    D3D11_SB_OPCODE_LD_UAV_TYPED,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D11_SB_OPCODE_STORE_UAV_TYPED"]/*' />
    D3D11_SB_OPCODE_STORE_UAV_TYPED,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D11_SB_OPCODE_LD_RAW"]/*' />
    D3D11_SB_OPCODE_LD_RAW,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D11_SB_OPCODE_STORE_RAW"]/*' />
    D3D11_SB_OPCODE_STORE_RAW,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D11_SB_OPCODE_LD_STRUCTURED"]/*' />
    D3D11_SB_OPCODE_LD_STRUCTURED,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D11_SB_OPCODE_STORE_STRUCTURED"]/*' />
    D3D11_SB_OPCODE_STORE_STRUCTURED,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D11_SB_OPCODE_ATOMIC_AND"]/*' />
    D3D11_SB_OPCODE_ATOMIC_AND,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D11_SB_OPCODE_ATOMIC_OR"]/*' />
    D3D11_SB_OPCODE_ATOMIC_OR,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D11_SB_OPCODE_ATOMIC_XOR"]/*' />
    D3D11_SB_OPCODE_ATOMIC_XOR,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D11_SB_OPCODE_ATOMIC_CMP_STORE"]/*' />
    D3D11_SB_OPCODE_ATOMIC_CMP_STORE,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D11_SB_OPCODE_ATOMIC_IADD"]/*' />
    D3D11_SB_OPCODE_ATOMIC_IADD,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D11_SB_OPCODE_ATOMIC_IMAX"]/*' />
    D3D11_SB_OPCODE_ATOMIC_IMAX,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D11_SB_OPCODE_ATOMIC_IMIN"]/*' />
    D3D11_SB_OPCODE_ATOMIC_IMIN,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D11_SB_OPCODE_ATOMIC_UMAX"]/*' />
    D3D11_SB_OPCODE_ATOMIC_UMAX,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D11_SB_OPCODE_ATOMIC_UMIN"]/*' />
    D3D11_SB_OPCODE_ATOMIC_UMIN,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D11_SB_OPCODE_IMM_ATOMIC_ALLOC"]/*' />
    D3D11_SB_OPCODE_IMM_ATOMIC_ALLOC,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D11_SB_OPCODE_IMM_ATOMIC_CONSUME"]/*' />
    D3D11_SB_OPCODE_IMM_ATOMIC_CONSUME,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D11_SB_OPCODE_IMM_ATOMIC_IADD"]/*' />
    D3D11_SB_OPCODE_IMM_ATOMIC_IADD,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D11_SB_OPCODE_IMM_ATOMIC_AND"]/*' />
    D3D11_SB_OPCODE_IMM_ATOMIC_AND,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D11_SB_OPCODE_IMM_ATOMIC_OR"]/*' />
    D3D11_SB_OPCODE_IMM_ATOMIC_OR,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D11_SB_OPCODE_IMM_ATOMIC_XOR"]/*' />
    D3D11_SB_OPCODE_IMM_ATOMIC_XOR,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D11_SB_OPCODE_IMM_ATOMIC_EXCH"]/*' />
    D3D11_SB_OPCODE_IMM_ATOMIC_EXCH,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D11_SB_OPCODE_IMM_ATOMIC_CMP_EXCH"]/*' />
    D3D11_SB_OPCODE_IMM_ATOMIC_CMP_EXCH,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D11_SB_OPCODE_IMM_ATOMIC_IMAX"]/*' />
    D3D11_SB_OPCODE_IMM_ATOMIC_IMAX,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D11_SB_OPCODE_IMM_ATOMIC_IMIN"]/*' />
    D3D11_SB_OPCODE_IMM_ATOMIC_IMIN,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D11_SB_OPCODE_IMM_ATOMIC_UMAX"]/*' />
    D3D11_SB_OPCODE_IMM_ATOMIC_UMAX,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D11_SB_OPCODE_IMM_ATOMIC_UMIN"]/*' />
    D3D11_SB_OPCODE_IMM_ATOMIC_UMIN,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D11_SB_OPCODE_SYNC"]/*' />
    D3D11_SB_OPCODE_SYNC,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D11_SB_OPCODE_DADD"]/*' />
    D3D11_SB_OPCODE_DADD,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D11_SB_OPCODE_DMAX"]/*' />
    D3D11_SB_OPCODE_DMAX,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D11_SB_OPCODE_DMIN"]/*' />
    D3D11_SB_OPCODE_DMIN,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D11_SB_OPCODE_DMUL"]/*' />
    D3D11_SB_OPCODE_DMUL,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D11_SB_OPCODE_DEQ"]/*' />
    D3D11_SB_OPCODE_DEQ,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D11_SB_OPCODE_DGE"]/*' />
    D3D11_SB_OPCODE_DGE,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D11_SB_OPCODE_DLT"]/*' />
    D3D11_SB_OPCODE_DLT,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D11_SB_OPCODE_DNE"]/*' />
    D3D11_SB_OPCODE_DNE,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D11_SB_OPCODE_DMOV"]/*' />
    D3D11_SB_OPCODE_DMOV,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D11_SB_OPCODE_DMOVC"]/*' />
    D3D11_SB_OPCODE_DMOVC,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D11_SB_OPCODE_DTOF"]/*' />
    D3D11_SB_OPCODE_DTOF,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D11_SB_OPCODE_FTOD"]/*' />
    D3D11_SB_OPCODE_FTOD,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D11_SB_OPCODE_EVAL_SNAPPED"]/*' />
    D3D11_SB_OPCODE_EVAL_SNAPPED,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D11_SB_OPCODE_EVAL_SAMPLE_INDEX"]/*' />
    D3D11_SB_OPCODE_EVAL_SAMPLE_INDEX,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D11_SB_OPCODE_EVAL_CENTROID"]/*' />
    D3D11_SB_OPCODE_EVAL_CENTROID,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D11_SB_OPCODE_DCL_GS_INSTANCE_COUNT"]/*' />
    D3D11_SB_OPCODE_DCL_GS_INSTANCE_COUNT,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D11_SB_OPCODE_ABORT"]/*' />
    D3D11_SB_OPCODE_ABORT,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D11_SB_OPCODE_DEBUG_BREAK"]/*' />
    D3D11_SB_OPCODE_DEBUG_BREAK,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D11_SB_OPCODE_RESERVED0"]/*' />
    D3D11_SB_OPCODE_RESERVED0,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D11_1_SB_OPCODE_DDIV"]/*' />
    D3D11_1_SB_OPCODE_DDIV,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D11_1_SB_OPCODE_DFMA"]/*' />
    D3D11_1_SB_OPCODE_DFMA,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D11_1_SB_OPCODE_DRCP"]/*' />
    D3D11_1_SB_OPCODE_DRCP,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D11_1_SB_OPCODE_MSAD"]/*' />
    D3D11_1_SB_OPCODE_MSAD,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D11_1_SB_OPCODE_DTOI"]/*' />
    D3D11_1_SB_OPCODE_DTOI,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D11_1_SB_OPCODE_DTOU"]/*' />
    D3D11_1_SB_OPCODE_DTOU,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D11_1_SB_OPCODE_ITOD"]/*' />
    D3D11_1_SB_OPCODE_ITOD,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D11_1_SB_OPCODE_UTOD"]/*' />
    D3D11_1_SB_OPCODE_UTOD,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D11_1_SB_OPCODE_RESERVED0"]/*' />
    D3D11_1_SB_OPCODE_RESERVED0,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3DWDDM1_3_SB_OPCODE_GATHER4_FEEDBACK"]/*' />
    D3DWDDM1_3_SB_OPCODE_GATHER4_FEEDBACK,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3DWDDM1_3_SB_OPCODE_GATHER4_C_FEEDBACK"]/*' />
    D3DWDDM1_3_SB_OPCODE_GATHER4_C_FEEDBACK,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3DWDDM1_3_SB_OPCODE_GATHER4_PO_FEEDBACK"]/*' />
    D3DWDDM1_3_SB_OPCODE_GATHER4_PO_FEEDBACK,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3DWDDM1_3_SB_OPCODE_GATHER4_PO_C_FEEDBACK"]/*' />
    D3DWDDM1_3_SB_OPCODE_GATHER4_PO_C_FEEDBACK,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3DWDDM1_3_SB_OPCODE_LD_FEEDBACK"]/*' />
    D3DWDDM1_3_SB_OPCODE_LD_FEEDBACK,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3DWDDM1_3_SB_OPCODE_LD_MS_FEEDBACK"]/*' />
    D3DWDDM1_3_SB_OPCODE_LD_MS_FEEDBACK,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3DWDDM1_3_SB_OPCODE_LD_UAV_TYPED_FEEDBACK"]/*' />
    D3DWDDM1_3_SB_OPCODE_LD_UAV_TYPED_FEEDBACK,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3DWDDM1_3_SB_OPCODE_LD_RAW_FEEDBACK"]/*' />
    D3DWDDM1_3_SB_OPCODE_LD_RAW_FEEDBACK,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3DWDDM1_3_SB_OPCODE_LD_STRUCTURED_FEEDBACK"]/*' />
    D3DWDDM1_3_SB_OPCODE_LD_STRUCTURED_FEEDBACK,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3DWDDM1_3_SB_OPCODE_SAMPLE_L_FEEDBACK"]/*' />
    D3DWDDM1_3_SB_OPCODE_SAMPLE_L_FEEDBACK,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3DWDDM1_3_SB_OPCODE_SAMPLE_C_LZ_FEEDBACK"]/*' />
    D3DWDDM1_3_SB_OPCODE_SAMPLE_C_LZ_FEEDBACK,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3DWDDM1_3_SB_OPCODE_SAMPLE_CLAMP_FEEDBACK"]/*' />
    D3DWDDM1_3_SB_OPCODE_SAMPLE_CLAMP_FEEDBACK,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3DWDDM1_3_SB_OPCODE_SAMPLE_B_CLAMP_FEEDBACK"]/*' />
    D3DWDDM1_3_SB_OPCODE_SAMPLE_B_CLAMP_FEEDBACK,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3DWDDM1_3_SB_OPCODE_SAMPLE_D_CLAMP_FEEDBACK"]/*' />
    D3DWDDM1_3_SB_OPCODE_SAMPLE_D_CLAMP_FEEDBACK,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3DWDDM1_3_SB_OPCODE_SAMPLE_C_CLAMP_FEEDBACK"]/*' />
    D3DWDDM1_3_SB_OPCODE_SAMPLE_C_CLAMP_FEEDBACK,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3DWDDM1_3_SB_OPCODE_CHECK_ACCESS_FULLY_MAPPED"]/*' />
    D3DWDDM1_3_SB_OPCODE_CHECK_ACCESS_FULLY_MAPPED,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3DWDDM1_3_SB_OPCODE_RESERVED0"]/*' />
    D3DWDDM1_3_SB_OPCODE_RESERVED0,

    /// <include file='D3D10_SB_OPCODE_TYPE.xml' path='doc/member[@name="D3D10_SB_OPCODE_TYPE.D3D10_SB_NUM_OPCODES"]/*' />
    D3D10_SB_NUM_OPCODES,
}
