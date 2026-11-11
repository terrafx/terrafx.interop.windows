// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from D3D12TokenizedProgramFormat.hpp in microsoft/DirectX-Headers tag v1.620.2
// Original source is Copyright © Microsoft. Licensed under the MIT license

using static TerraFX.Interop.DirectX.D3D10_SB_4_COMPONENT_NAME;

namespace TerraFX.Interop.DirectX;

public static partial class D3D10
{
    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_SB_TOKENIZED_PROGRAM_TYPE_MASK"]/*' />
    [NativeTypeName("#define D3D10_SB_TOKENIZED_PROGRAM_TYPE_MASK 0xffff0000")]
    public const uint D3D10_SB_TOKENIZED_PROGRAM_TYPE_MASK = 0xffff0000;

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_SB_TOKENIZED_PROGRAM_TYPE_SHIFT"]/*' />
    [NativeTypeName("#define D3D10_SB_TOKENIZED_PROGRAM_TYPE_SHIFT 16")]
    public const int D3D10_SB_TOKENIZED_PROGRAM_TYPE_SHIFT = 16;

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_SB_TOKENIZED_PROGRAM_MAJOR_VERSION_MASK"]/*' />
    [NativeTypeName("#define D3D10_SB_TOKENIZED_PROGRAM_MAJOR_VERSION_MASK 0x000000f0")]
    public const int D3D10_SB_TOKENIZED_PROGRAM_MAJOR_VERSION_MASK = 0x000000f0;

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_SB_TOKENIZED_PROGRAM_MAJOR_VERSION_SHIFT"]/*' />
    [NativeTypeName("#define D3D10_SB_TOKENIZED_PROGRAM_MAJOR_VERSION_SHIFT 4")]
    public const int D3D10_SB_TOKENIZED_PROGRAM_MAJOR_VERSION_SHIFT = 4;

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_SB_TOKENIZED_PROGRAM_MINOR_VERSION_MASK"]/*' />
    [NativeTypeName("#define D3D10_SB_TOKENIZED_PROGRAM_MINOR_VERSION_MASK 0x0000000f")]
    public const int D3D10_SB_TOKENIZED_PROGRAM_MINOR_VERSION_MASK = 0x0000000f;

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_SB_OPCODE_TYPE_MASK"]/*' />
    [NativeTypeName("#define D3D10_SB_OPCODE_TYPE_MASK 0x00007ff")]
    public const int D3D10_SB_OPCODE_TYPE_MASK = 0x00007ff;

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_SB_TOKENIZED_INSTRUCTION_LENGTH_MASK"]/*' />
    [NativeTypeName("#define D3D10_SB_TOKENIZED_INSTRUCTION_LENGTH_MASK 0x7f000000")]
    public const int D3D10_SB_TOKENIZED_INSTRUCTION_LENGTH_MASK = 0x7f000000;

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_SB_TOKENIZED_INSTRUCTION_LENGTH_SHIFT"]/*' />
    [NativeTypeName("#define D3D10_SB_TOKENIZED_INSTRUCTION_LENGTH_SHIFT 24")]
    public const int D3D10_SB_TOKENIZED_INSTRUCTION_LENGTH_SHIFT = 24;

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_SB_INSTRUCTION_SATURATE_MASK"]/*' />
    [NativeTypeName("#define D3D10_SB_INSTRUCTION_SATURATE_MASK 0x00002000")]
    public const int D3D10_SB_INSTRUCTION_SATURATE_MASK = 0x00002000;

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_SB_INSTRUCTION_TEST_BOOLEAN_MASK"]/*' />
    [NativeTypeName("#define D3D10_SB_INSTRUCTION_TEST_BOOLEAN_MASK 0x00040000")]
    public const int D3D10_SB_INSTRUCTION_TEST_BOOLEAN_MASK = 0x00040000;

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_SB_INSTRUCTION_TEST_BOOLEAN_SHIFT"]/*' />
    [NativeTypeName("#define D3D10_SB_INSTRUCTION_TEST_BOOLEAN_SHIFT 18")]
    public const int D3D10_SB_INSTRUCTION_TEST_BOOLEAN_SHIFT = 18;

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_SB_RESINFO_INSTRUCTION_RETURN_TYPE_MASK"]/*' />
    [NativeTypeName("#define D3D10_SB_RESINFO_INSTRUCTION_RETURN_TYPE_MASK 0x00001800")]
    public const int D3D10_SB_RESINFO_INSTRUCTION_RETURN_TYPE_MASK = 0x00001800;

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_SB_RESINFO_INSTRUCTION_RETURN_TYPE_SHIFT"]/*' />
    [NativeTypeName("#define D3D10_SB_RESINFO_INSTRUCTION_RETURN_TYPE_SHIFT 11")]
    public const int D3D10_SB_RESINFO_INSTRUCTION_RETURN_TYPE_SHIFT = 11;

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_SB_OPCODE_EXTENDED_MASK"]/*' />
    [NativeTypeName("#define D3D10_SB_OPCODE_EXTENDED_MASK 0x80000000")]
    public const uint D3D10_SB_OPCODE_EXTENDED_MASK = 0x80000000;

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_SB_OPCODE_EXTENDED_SHIFT"]/*' />
    [NativeTypeName("#define D3D10_SB_OPCODE_EXTENDED_SHIFT 31")]
    public const int D3D10_SB_OPCODE_EXTENDED_SHIFT = 31;

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_SB_EXTENDED_OPCODE_TYPE_MASK"]/*' />
    [NativeTypeName("#define D3D10_SB_EXTENDED_OPCODE_TYPE_MASK 0x0000003f")]
    public const int D3D10_SB_EXTENDED_OPCODE_TYPE_MASK = 0x0000003f;

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_SB_IMMEDIATE_ADDRESS_OFFSET_COORD_MASK"]/*' />
    [NativeTypeName("#define D3D10_SB_IMMEDIATE_ADDRESS_OFFSET_COORD_MASK (3)")]
    public const int D3D10_SB_IMMEDIATE_ADDRESS_OFFSET_COORD_MASK = (3);

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_SB_RESOURCE_RETURN_TYPE_MASK"]/*' />
    [NativeTypeName("#define D3D10_SB_RESOURCE_RETURN_TYPE_MASK 0x0000000f")]
    public const int D3D10_SB_RESOURCE_RETURN_TYPE_MASK = 0x0000000f;

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_SB_RESOURCE_RETURN_TYPE_NUMBITS"]/*' />
    [NativeTypeName("#define D3D10_SB_RESOURCE_RETURN_TYPE_NUMBITS 0x00000004")]
    public const int D3D10_SB_RESOURCE_RETURN_TYPE_NUMBITS = 0x00000004;

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_SB_CUSTOMDATA_CLASS_MASK"]/*' />
    [NativeTypeName("#define D3D10_SB_CUSTOMDATA_CLASS_MASK 0xfffff800")]
    public const uint D3D10_SB_CUSTOMDATA_CLASS_MASK = 0xfffff800;

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_SB_CUSTOMDATA_CLASS_SHIFT"]/*' />
    [NativeTypeName("#define D3D10_SB_CUSTOMDATA_CLASS_SHIFT 11")]
    public const int D3D10_SB_CUSTOMDATA_CLASS_SHIFT = 11;

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_SB_OPERAND_NUM_COMPONENTS_MASK"]/*' />
    [NativeTypeName("#define D3D10_SB_OPERAND_NUM_COMPONENTS_MASK 0x00000003")]
    public const int D3D10_SB_OPERAND_NUM_COMPONENTS_MASK = 0x00000003;

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_SB_OPERAND_4_COMPONENT_SELECTION_MODE_MASK"]/*' />
    [NativeTypeName("#define D3D10_SB_OPERAND_4_COMPONENT_SELECTION_MODE_MASK 0x0000000c")]
    public const int D3D10_SB_OPERAND_4_COMPONENT_SELECTION_MODE_MASK = 0x0000000c;

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_SB_OPERAND_4_COMPONENT_SELECTION_MODE_SHIFT"]/*' />
    [NativeTypeName("#define D3D10_SB_OPERAND_4_COMPONENT_SELECTION_MODE_SHIFT 2")]
    public const int D3D10_SB_OPERAND_4_COMPONENT_SELECTION_MODE_SHIFT = 2;

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_SB_4_COMPONENT_NAME_MASK"]/*' />
    [NativeTypeName("#define D3D10_SB_4_COMPONENT_NAME_MASK 3")]
    public const int D3D10_SB_4_COMPONENT_NAME_MASK = 3;

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_SB_OPERAND_4_COMPONENT_MASK_MASK"]/*' />
    [NativeTypeName("#define D3D10_SB_OPERAND_4_COMPONENT_MASK_MASK 0x000000f0")]
    public const int D3D10_SB_OPERAND_4_COMPONENT_MASK_MASK = 0x000000f0;

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_SB_OPERAND_4_COMPONENT_MASK_SHIFT"]/*' />
    [NativeTypeName("#define D3D10_SB_OPERAND_4_COMPONENT_MASK_SHIFT 4")]
    public const int D3D10_SB_OPERAND_4_COMPONENT_MASK_SHIFT = 4;

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_SB_OPERAND_4_COMPONENT_MASK_X"]/*' />
    [NativeTypeName("#define D3D10_SB_OPERAND_4_COMPONENT_MASK_X 0x00000010")]
    public const int D3D10_SB_OPERAND_4_COMPONENT_MASK_X = 0x00000010;

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_SB_OPERAND_4_COMPONENT_MASK_Y"]/*' />
    [NativeTypeName("#define D3D10_SB_OPERAND_4_COMPONENT_MASK_Y 0x00000020")]
    public const int D3D10_SB_OPERAND_4_COMPONENT_MASK_Y = 0x00000020;

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_SB_OPERAND_4_COMPONENT_MASK_Z"]/*' />
    [NativeTypeName("#define D3D10_SB_OPERAND_4_COMPONENT_MASK_Z 0x00000040")]
    public const int D3D10_SB_OPERAND_4_COMPONENT_MASK_Z = 0x00000040;

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_SB_OPERAND_4_COMPONENT_MASK_W"]/*' />
    [NativeTypeName("#define D3D10_SB_OPERAND_4_COMPONENT_MASK_W 0x00000080")]
    public const int D3D10_SB_OPERAND_4_COMPONENT_MASK_W = 0x00000080;

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_SB_OPERAND_4_COMPONENT_MASK_R"]/*' />
    [NativeTypeName("#define D3D10_SB_OPERAND_4_COMPONENT_MASK_R D3D10_SB_OPERAND_4_COMPONENT_MASK_X")]
    public const int D3D10_SB_OPERAND_4_COMPONENT_MASK_R = 0x00000010;

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_SB_OPERAND_4_COMPONENT_MASK_G"]/*' />
    [NativeTypeName("#define D3D10_SB_OPERAND_4_COMPONENT_MASK_G D3D10_SB_OPERAND_4_COMPONENT_MASK_Y")]
    public const int D3D10_SB_OPERAND_4_COMPONENT_MASK_G = 0x00000020;

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_SB_OPERAND_4_COMPONENT_MASK_B"]/*' />
    [NativeTypeName("#define D3D10_SB_OPERAND_4_COMPONENT_MASK_B D3D10_SB_OPERAND_4_COMPONENT_MASK_Z")]
    public const int D3D10_SB_OPERAND_4_COMPONENT_MASK_B = 0x00000040;

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_SB_OPERAND_4_COMPONENT_MASK_A"]/*' />
    [NativeTypeName("#define D3D10_SB_OPERAND_4_COMPONENT_MASK_A D3D10_SB_OPERAND_4_COMPONENT_MASK_W")]
    public const int D3D10_SB_OPERAND_4_COMPONENT_MASK_A = 0x00000080;

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_SB_OPERAND_4_COMPONENT_MASK_ALL"]/*' />
    [NativeTypeName("#define D3D10_SB_OPERAND_4_COMPONENT_MASK_ALL D3D10_SB_OPERAND_4_COMPONENT_MASK_MASK")]
    public const int D3D10_SB_OPERAND_4_COMPONENT_MASK_ALL = 0x000000f0;

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_SB_OPERAND_4_COMPONENT_SWIZZLE_MASK"]/*' />
    [NativeTypeName("#define D3D10_SB_OPERAND_4_COMPONENT_SWIZZLE_MASK 0x00000ff0")]
    public const int D3D10_SB_OPERAND_4_COMPONENT_SWIZZLE_MASK = 0x00000ff0;

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_SB_OPERAND_4_COMPONENT_SWIZZLE_SHIFT"]/*' />
    [NativeTypeName("#define D3D10_SB_OPERAND_4_COMPONENT_SWIZZLE_SHIFT 4")]
    public const int D3D10_SB_OPERAND_4_COMPONENT_SWIZZLE_SHIFT = 4;

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_SB_OPERAND_4_COMPONENT_NOSWIZZLE"]/*' />
    [NativeTypeName("#define D3D10_SB_OPERAND_4_COMPONENT_NOSWIZZLE ENCODE_D3D10_SB_OPERAND_4_COMPONENT_SWIZZLE(D3D10_SB_4_COMPONENT_X,\\\r\n                                                                                   D3D10_SB_4_COMPONENT_Y,\\\r\n                                                                                   D3D10_SB_4_COMPONENT_Z,\\\r\n                                                                                   D3D10_SB_4_COMPONENT_W)")]
    public const int D3D10_SB_OPERAND_4_COMPONENT_NOSWIZZLE = ((((int)(D3D10_SB_4_COMPONENT_X) & 3) | (((int)(D3D10_SB_4_COMPONENT_Y) & 3) << 2) | (((int)(D3D10_SB_4_COMPONENT_Z) & 3) << 4) | (((int)(D3D10_SB_4_COMPONENT_W) & 3) << 6)) << 4);

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_SB_OPERAND_4_COMPONENT_REPLICATEX"]/*' />
    [NativeTypeName("#define D3D10_SB_OPERAND_4_COMPONENT_REPLICATEX ENCODE_D3D10_SB_OPERAND_4_COMPONENT_SWIZZLE(D3D10_SB_4_COMPONENT_X,\\\r\n                                                                                   D3D10_SB_4_COMPONENT_X,\\\r\n                                                                                   D3D10_SB_4_COMPONENT_X,\\\r\n                                                                                   D3D10_SB_4_COMPONENT_X)")]
    public const int D3D10_SB_OPERAND_4_COMPONENT_REPLICATEX = ((((int)(D3D10_SB_4_COMPONENT_X) & 3) | (((int)(D3D10_SB_4_COMPONENT_X) & 3) << 2) | (((int)(D3D10_SB_4_COMPONENT_X) & 3) << 4) | (((int)(D3D10_SB_4_COMPONENT_X) & 3) << 6)) << 4);

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_SB_OPERAND_4_COMPONENT_REPLICATEY"]/*' />
    [NativeTypeName("#define D3D10_SB_OPERAND_4_COMPONENT_REPLICATEY ENCODE_D3D10_SB_OPERAND_4_COMPONENT_SWIZZLE(D3D10_SB_4_COMPONENT_Y,\\\r\n                                                                                   D3D10_SB_4_COMPONENT_Y,\\\r\n                                                                                   D3D10_SB_4_COMPONENT_Y,\\\r\n                                                                                   D3D10_SB_4_COMPONENT_Y)")]
    public const int D3D10_SB_OPERAND_4_COMPONENT_REPLICATEY = ((((int)(D3D10_SB_4_COMPONENT_Y) & 3) | (((int)(D3D10_SB_4_COMPONENT_Y) & 3) << 2) | (((int)(D3D10_SB_4_COMPONENT_Y) & 3) << 4) | (((int)(D3D10_SB_4_COMPONENT_Y) & 3) << 6)) << 4);

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_SB_OPERAND_4_COMPONENT_REPLICATEZ"]/*' />
    [NativeTypeName("#define D3D10_SB_OPERAND_4_COMPONENT_REPLICATEZ ENCODE_D3D10_SB_OPERAND_4_COMPONENT_SWIZZLE(D3D10_SB_4_COMPONENT_Z,\\\r\n                                                                                   D3D10_SB_4_COMPONENT_Z,\\\r\n                                                                                   D3D10_SB_4_COMPONENT_Z,\\\r\n                                                                                   D3D10_SB_4_COMPONENT_Z)")]
    public const int D3D10_SB_OPERAND_4_COMPONENT_REPLICATEZ = ((((int)(D3D10_SB_4_COMPONENT_Z) & 3) | (((int)(D3D10_SB_4_COMPONENT_Z) & 3) << 2) | (((int)(D3D10_SB_4_COMPONENT_Z) & 3) << 4) | (((int)(D3D10_SB_4_COMPONENT_Z) & 3) << 6)) << 4);

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_SB_OPERAND_4_COMPONENT_REPLICATEW"]/*' />
    [NativeTypeName("#define D3D10_SB_OPERAND_4_COMPONENT_REPLICATEW ENCODE_D3D10_SB_OPERAND_4_COMPONENT_SWIZZLE(D3D10_SB_4_COMPONENT_W,\\\r\n                                                                                   D3D10_SB_4_COMPONENT_W,\\\r\n                                                                                   D3D10_SB_4_COMPONENT_W,\\\r\n                                                                                   D3D10_SB_4_COMPONENT_W)")]
    public const int D3D10_SB_OPERAND_4_COMPONENT_REPLICATEW = ((((int)(D3D10_SB_4_COMPONENT_W) & 3) | (((int)(D3D10_SB_4_COMPONENT_W) & 3) << 2) | (((int)(D3D10_SB_4_COMPONENT_W) & 3) << 4) | (((int)(D3D10_SB_4_COMPONENT_W) & 3) << 6)) << 4);

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_SB_OPERAND_4_COMPONENT_REPLICATERED"]/*' />
    [NativeTypeName("#define D3D10_SB_OPERAND_4_COMPONENT_REPLICATERED D3D10_SB_OPERAND_4_COMPONENT_REPLICATEX")]
    public const int D3D10_SB_OPERAND_4_COMPONENT_REPLICATERED = ((((int)(D3D10_SB_4_COMPONENT_X) & 3) | (((int)(D3D10_SB_4_COMPONENT_X) & 3) << 2) | (((int)(D3D10_SB_4_COMPONENT_X) & 3) << 4) | (((int)(D3D10_SB_4_COMPONENT_X) & 3) << 6)) << 4);

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_SB_OPERAND_4_COMPONENT_REPLICATEGREEN"]/*' />
    [NativeTypeName("#define D3D10_SB_OPERAND_4_COMPONENT_REPLICATEGREEN D3D10_SB_OPERAND_4_COMPONENT_REPLICATEY")]
    public const int D3D10_SB_OPERAND_4_COMPONENT_REPLICATEGREEN = ((((int)(D3D10_SB_4_COMPONENT_Y) & 3) | (((int)(D3D10_SB_4_COMPONENT_Y) & 3) << 2) | (((int)(D3D10_SB_4_COMPONENT_Y) & 3) << 4) | (((int)(D3D10_SB_4_COMPONENT_Y) & 3) << 6)) << 4);

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_SB_OPERAND_4_COMPONENT_REPLICATEBLUE"]/*' />
    [NativeTypeName("#define D3D10_SB_OPERAND_4_COMPONENT_REPLICATEBLUE D3D10_SB_OPERAND_4_COMPONENT_REPLICATEZ")]
    public const int D3D10_SB_OPERAND_4_COMPONENT_REPLICATEBLUE = ((((int)(D3D10_SB_4_COMPONENT_Z) & 3) | (((int)(D3D10_SB_4_COMPONENT_Z) & 3) << 2) | (((int)(D3D10_SB_4_COMPONENT_Z) & 3) << 4) | (((int)(D3D10_SB_4_COMPONENT_Z) & 3) << 6)) << 4);

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_SB_OPERAND_4_COMPONENT_REPLICATEALPHA"]/*' />
    [NativeTypeName("#define D3D10_SB_OPERAND_4_COMPONENT_REPLICATEALPHA D3D10_SB_OPERAND_4_COMPONENT_REPLICATEW")]
    public const int D3D10_SB_OPERAND_4_COMPONENT_REPLICATEALPHA = ((((int)(D3D10_SB_4_COMPONENT_W) & 3) | (((int)(D3D10_SB_4_COMPONENT_W) & 3) << 2) | (((int)(D3D10_SB_4_COMPONENT_W) & 3) << 4) | (((int)(D3D10_SB_4_COMPONENT_W) & 3) << 6)) << 4);

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_SB_OPERAND_4_COMPONENT_SELECT_1_MASK"]/*' />
    [NativeTypeName("#define D3D10_SB_OPERAND_4_COMPONENT_SELECT_1_MASK 0x00000030")]
    public const int D3D10_SB_OPERAND_4_COMPONENT_SELECT_1_MASK = 0x00000030;

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_SB_OPERAND_4_COMPONENT_SELECT_1_SHIFT"]/*' />
    [NativeTypeName("#define D3D10_SB_OPERAND_4_COMPONENT_SELECT_1_SHIFT 4")]
    public const int D3D10_SB_OPERAND_4_COMPONENT_SELECT_1_SHIFT = 4;

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_SB_OPERAND_TYPE_MASK"]/*' />
    [NativeTypeName("#define D3D10_SB_OPERAND_TYPE_MASK 0x000ff000")]
    public const int D3D10_SB_OPERAND_TYPE_MASK = 0x000ff000;

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_SB_OPERAND_TYPE_SHIFT"]/*' />
    [NativeTypeName("#define D3D10_SB_OPERAND_TYPE_SHIFT 12")]
    public const int D3D10_SB_OPERAND_TYPE_SHIFT = 12;

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_SB_OPERAND_INDEX_DIMENSION_MASK"]/*' />
    [NativeTypeName("#define D3D10_SB_OPERAND_INDEX_DIMENSION_MASK 0x00300000")]
    public const int D3D10_SB_OPERAND_INDEX_DIMENSION_MASK = 0x00300000;

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_SB_OPERAND_INDEX_DIMENSION_SHIFT"]/*' />
    [NativeTypeName("#define D3D10_SB_OPERAND_INDEX_DIMENSION_SHIFT 20")]
    public const int D3D10_SB_OPERAND_INDEX_DIMENSION_SHIFT = 20;

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_SB_OPERAND_EXTENDED_MASK"]/*' />
    [NativeTypeName("#define D3D10_SB_OPERAND_EXTENDED_MASK 0x80000000")]
    public const uint D3D10_SB_OPERAND_EXTENDED_MASK = 0x80000000;

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_SB_OPERAND_EXTENDED_SHIFT"]/*' />
    [NativeTypeName("#define D3D10_SB_OPERAND_EXTENDED_SHIFT 31")]
    public const int D3D10_SB_OPERAND_EXTENDED_SHIFT = 31;

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_SB_EXTENDED_OPERAND_TYPE_MASK"]/*' />
    [NativeTypeName("#define D3D10_SB_EXTENDED_OPERAND_TYPE_MASK 0x0000003f")]
    public const int D3D10_SB_EXTENDED_OPERAND_TYPE_MASK = 0x0000003f;

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_SB_OPERAND_MODIFIER_MASK"]/*' />
    [NativeTypeName("#define D3D10_SB_OPERAND_MODIFIER_MASK 0x00003fc0")]
    public const int D3D10_SB_OPERAND_MODIFIER_MASK = 0x00003fc0;

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_SB_OPERAND_MODIFIER_SHIFT"]/*' />
    [NativeTypeName("#define D3D10_SB_OPERAND_MODIFIER_SHIFT 6")]
    public const int D3D10_SB_OPERAND_MODIFIER_SHIFT = 6;

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_SB_OPERAND_DOUBLE_EXTENDED_MASK"]/*' />
    [NativeTypeName("#define D3D10_SB_OPERAND_DOUBLE_EXTENDED_MASK 0x80000000")]
    public const uint D3D10_SB_OPERAND_DOUBLE_EXTENDED_MASK = 0x80000000;

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_SB_OPERAND_DOUBLE_EXTENDED_SHIFT"]/*' />
    [NativeTypeName("#define D3D10_SB_OPERAND_DOUBLE_EXTENDED_SHIFT 31")]
    public const int D3D10_SB_OPERAND_DOUBLE_EXTENDED_SHIFT = 31;

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_SB_NAME_MASK"]/*' />
    [NativeTypeName("#define D3D10_SB_NAME_MASK 0x0000ffff")]
    public const int D3D10_SB_NAME_MASK = 0x0000ffff;

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_SB_GLOBAL_FLAG_REFACTORING_ALLOWED"]/*' />
    [NativeTypeName("#define D3D10_SB_GLOBAL_FLAG_REFACTORING_ALLOWED (1<<11)")]
    public const int D3D10_SB_GLOBAL_FLAG_REFACTORING_ALLOWED = (1 << 11);

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_SB_GLOBAL_FLAGS_MASK"]/*' />
    [NativeTypeName("#define D3D10_SB_GLOBAL_FLAGS_MASK 0x00fff800")]
    public const int D3D10_SB_GLOBAL_FLAGS_MASK = 0x00fff800;

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_SB_RESOURCE_DIMENSION_MASK"]/*' />
    [NativeTypeName("#define D3D10_SB_RESOURCE_DIMENSION_MASK 0x0000F800")]
    public const int D3D10_SB_RESOURCE_DIMENSION_MASK = 0x0000F800;

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_SB_RESOURCE_DIMENSION_SHIFT"]/*' />
    [NativeTypeName("#define D3D10_SB_RESOURCE_DIMENSION_SHIFT 11")]
    public const int D3D10_SB_RESOURCE_DIMENSION_SHIFT = 11;

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_SB_RESOURCE_SAMPLE_COUNT_MASK"]/*' />
    [NativeTypeName("#define D3D10_SB_RESOURCE_SAMPLE_COUNT_MASK 0x07F0000")]
    public const int D3D10_SB_RESOURCE_SAMPLE_COUNT_MASK = 0x07F0000;

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_SB_RESOURCE_SAMPLE_COUNT_SHIFT"]/*' />
    [NativeTypeName("#define D3D10_SB_RESOURCE_SAMPLE_COUNT_SHIFT 16")]
    public const int D3D10_SB_RESOURCE_SAMPLE_COUNT_SHIFT = 16;

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_SB_SAMPLER_MODE_MASK"]/*' />
    [NativeTypeName("#define D3D10_SB_SAMPLER_MODE_MASK 0x00007800")]
    public const int D3D10_SB_SAMPLER_MODE_MASK = 0x00007800;

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_SB_SAMPLER_MODE_SHIFT"]/*' />
    [NativeTypeName("#define D3D10_SB_SAMPLER_MODE_SHIFT 11")]
    public const int D3D10_SB_SAMPLER_MODE_SHIFT = 11;

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_SB_INPUT_INTERPOLATION_MODE_MASK"]/*' />
    [NativeTypeName("#define D3D10_SB_INPUT_INTERPOLATION_MODE_MASK 0x00007800")]
    public const int D3D10_SB_INPUT_INTERPOLATION_MODE_MASK = 0x00007800;

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_SB_INPUT_INTERPOLATION_MODE_SHIFT"]/*' />
    [NativeTypeName("#define D3D10_SB_INPUT_INTERPOLATION_MODE_SHIFT 11")]
    public const int D3D10_SB_INPUT_INTERPOLATION_MODE_SHIFT = 11;

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_SB_CONSTANT_BUFFER_ACCESS_PATTERN_MASK"]/*' />
    [NativeTypeName("#define D3D10_SB_CONSTANT_BUFFER_ACCESS_PATTERN_MASK 0x00000800")]
    public const int D3D10_SB_CONSTANT_BUFFER_ACCESS_PATTERN_MASK = 0x00000800;

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_SB_CONSTANT_BUFFER_ACCESS_PATTERN_SHIFT"]/*' />
    [NativeTypeName("#define D3D10_SB_CONSTANT_BUFFER_ACCESS_PATTERN_SHIFT 11")]
    public const int D3D10_SB_CONSTANT_BUFFER_ACCESS_PATTERN_SHIFT = 11;

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_SB_GS_INPUT_PRIMITIVE_MASK"]/*' />
    [NativeTypeName("#define D3D10_SB_GS_INPUT_PRIMITIVE_MASK 0x0001f800")]
    public const int D3D10_SB_GS_INPUT_PRIMITIVE_MASK = 0x0001f800;

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_SB_GS_INPUT_PRIMITIVE_SHIFT"]/*' />
    [NativeTypeName("#define D3D10_SB_GS_INPUT_PRIMITIVE_SHIFT 11")]
    public const int D3D10_SB_GS_INPUT_PRIMITIVE_SHIFT = 11;

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_SB_GS_OUTPUT_PRIMITIVE_TOPOLOGY_MASK"]/*' />
    [NativeTypeName("#define D3D10_SB_GS_OUTPUT_PRIMITIVE_TOPOLOGY_MASK 0x0001f800")]
    public const int D3D10_SB_GS_OUTPUT_PRIMITIVE_TOPOLOGY_MASK = 0x0001f800;

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_SB_GS_OUTPUT_PRIMITIVE_TOPOLOGY_SHIFT"]/*' />
    [NativeTypeName("#define D3D10_SB_GS_OUTPUT_PRIMITIVE_TOPOLOGY_SHIFT 11")]
    public const int D3D10_SB_GS_OUTPUT_PRIMITIVE_TOPOLOGY_SHIFT = 11;

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_SB_INSTRUCTION_RETURN_TYPE_MASK"]/*' />
    [NativeTypeName("#define D3D10_SB_INSTRUCTION_RETURN_TYPE_MASK 0x00001800")]
    public const int D3D10_SB_INSTRUCTION_RETURN_TYPE_MASK = 0x00001800;

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_SB_INSTRUCTION_RETURN_TYPE_SHIFT"]/*' />
    [NativeTypeName("#define D3D10_SB_INSTRUCTION_RETURN_TYPE_SHIFT 11")]
    public const int D3D10_SB_INSTRUCTION_RETURN_TYPE_SHIFT = 11;
}
