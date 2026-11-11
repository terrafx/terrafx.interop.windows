// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from D3D12TokenizedProgramFormat.hpp in microsoft/DirectX-Headers tag v1.620.2
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace TerraFX.Interop.DirectX;

public static partial class D3D11
{
    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_SB_INSTRUCTION_PRECISE_VALUES_MASK"]/*' />
    [NativeTypeName("#define D3D11_SB_INSTRUCTION_PRECISE_VALUES_MASK 0x00780000")]
    public const int D3D11_SB_INSTRUCTION_PRECISE_VALUES_MASK = 0x00780000;

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_SB_INSTRUCTION_PRECISE_VALUES_SHIFT"]/*' />
    [NativeTypeName("#define D3D11_SB_INSTRUCTION_PRECISE_VALUES_SHIFT 19")]
    public const int D3D11_SB_INSTRUCTION_PRECISE_VALUES_SHIFT = 19;

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_SB_SYNC_THREADS_IN_GROUP"]/*' />
    [NativeTypeName("#define D3D11_SB_SYNC_THREADS_IN_GROUP 0x00000800")]
    public const int D3D11_SB_SYNC_THREADS_IN_GROUP = 0x00000800;

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_SB_SYNC_THREAD_GROUP_SHARED_MEMORY"]/*' />
    [NativeTypeName("#define D3D11_SB_SYNC_THREAD_GROUP_SHARED_MEMORY 0x00001000")]
    public const int D3D11_SB_SYNC_THREAD_GROUP_SHARED_MEMORY = 0x00001000;

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_SB_SYNC_UNORDERED_ACCESS_VIEW_MEMORY_GROUP"]/*' />
    [NativeTypeName("#define D3D11_SB_SYNC_UNORDERED_ACCESS_VIEW_MEMORY_GROUP 0x00002000")]
    public const int D3D11_SB_SYNC_UNORDERED_ACCESS_VIEW_MEMORY_GROUP = 0x00002000;

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_SB_SYNC_UNORDERED_ACCESS_VIEW_MEMORY_GLOBAL"]/*' />
    [NativeTypeName("#define D3D11_SB_SYNC_UNORDERED_ACCESS_VIEW_MEMORY_GLOBAL 0x00004000")]
    public const int D3D11_SB_SYNC_UNORDERED_ACCESS_VIEW_MEMORY_GLOBAL = 0x00004000;

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_SB_SYNC_FLAGS_MASK"]/*' />
    [NativeTypeName("#define D3D11_SB_SYNC_FLAGS_MASK 0x00007800")]
    public const int D3D11_SB_SYNC_FLAGS_MASK = 0x00007800;

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_SB_MAX_SIMULTANEOUS_EXTENDED_OPCODES"]/*' />
    [NativeTypeName("#define D3D11_SB_MAX_SIMULTANEOUS_EXTENDED_OPCODES 3")]
    public const int D3D11_SB_MAX_SIMULTANEOUS_EXTENDED_OPCODES = 3;

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_SB_EXTENDED_RESOURCE_DIMENSION_MASK"]/*' />
    [NativeTypeName("#define D3D11_SB_EXTENDED_RESOURCE_DIMENSION_MASK 0x000007C0")]
    public const int D3D11_SB_EXTENDED_RESOURCE_DIMENSION_MASK = 0x000007C0;

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_SB_EXTENDED_RESOURCE_DIMENSION_SHIFT"]/*' />
    [NativeTypeName("#define D3D11_SB_EXTENDED_RESOURCE_DIMENSION_SHIFT 6")]
    public const int D3D11_SB_EXTENDED_RESOURCE_DIMENSION_SHIFT = 6;

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_SB_EXTENDED_RESOURCE_DIMENSION_STRUCTURE_STRIDE_MASK"]/*' />
    [NativeTypeName("#define D3D11_SB_EXTENDED_RESOURCE_DIMENSION_STRUCTURE_STRIDE_MASK 0x007FF800")]
    public const int D3D11_SB_EXTENDED_RESOURCE_DIMENSION_STRUCTURE_STRIDE_MASK = 0x007FF800;

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_SB_EXTENDED_RESOURCE_DIMENSION_STRUCTURE_STRIDE_SHIFT"]/*' />
    [NativeTypeName("#define D3D11_SB_EXTENDED_RESOURCE_DIMENSION_STRUCTURE_STRIDE_SHIFT 11")]
    public const int D3D11_SB_EXTENDED_RESOURCE_DIMENSION_STRUCTURE_STRIDE_SHIFT = 11;

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_SB_EXTENDED_RESOURCE_RETURN_TYPE_SHIFT"]/*' />
    [NativeTypeName("#define D3D11_SB_EXTENDED_RESOURCE_RETURN_TYPE_SHIFT 6")]
    public const int D3D11_SB_EXTENDED_RESOURCE_RETURN_TYPE_SHIFT = 6;

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_SB_OPERAND_MIN_PRECISION_MASK"]/*' />
    [NativeTypeName("#define D3D11_SB_OPERAND_MIN_PRECISION_MASK 0x0001C000")]
    public const int D3D11_SB_OPERAND_MIN_PRECISION_MASK = 0x0001C000;

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_SB_OPERAND_MIN_PRECISION_SHIFT"]/*' />
    [NativeTypeName("#define D3D11_SB_OPERAND_MIN_PRECISION_SHIFT 14")]
    public const int D3D11_SB_OPERAND_MIN_PRECISION_SHIFT = 14;

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_SB_GLOBAL_FLAG_ENABLE_DOUBLE_PRECISION_FLOAT_OPS"]/*' />
    [NativeTypeName("#define D3D11_SB_GLOBAL_FLAG_ENABLE_DOUBLE_PRECISION_FLOAT_OPS (1<<12)")]
    public const int D3D11_SB_GLOBAL_FLAG_ENABLE_DOUBLE_PRECISION_FLOAT_OPS = (1 << 12);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_SB_GLOBAL_FLAG_FORCE_EARLY_DEPTH_STENCIL"]/*' />
    [NativeTypeName("#define D3D11_SB_GLOBAL_FLAG_FORCE_EARLY_DEPTH_STENCIL (1<<13)")]
    public const int D3D11_SB_GLOBAL_FLAG_FORCE_EARLY_DEPTH_STENCIL = (1 << 13);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_SB_GLOBAL_FLAG_ENABLE_RAW_AND_STRUCTURED_BUFFERS"]/*' />
    [NativeTypeName("#define D3D11_SB_GLOBAL_FLAG_ENABLE_RAW_AND_STRUCTURED_BUFFERS (1<<14)")]
    public const int D3D11_SB_GLOBAL_FLAG_ENABLE_RAW_AND_STRUCTURED_BUFFERS = (1 << 14);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_1_SB_GLOBAL_FLAG_SKIP_OPTIMIZATION"]/*' />
    [NativeTypeName("#define D3D11_1_SB_GLOBAL_FLAG_SKIP_OPTIMIZATION (1<<15)")]
    public const int D3D11_1_SB_GLOBAL_FLAG_SKIP_OPTIMIZATION = (1 << 15);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_1_SB_GLOBAL_FLAG_ENABLE_MINIMUM_PRECISION"]/*' />
    [NativeTypeName("#define D3D11_1_SB_GLOBAL_FLAG_ENABLE_MINIMUM_PRECISION (1<<16)")]
    public const int D3D11_1_SB_GLOBAL_FLAG_ENABLE_MINIMUM_PRECISION = (1 << 16);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_1_SB_GLOBAL_FLAG_ENABLE_DOUBLE_EXTENSIONS"]/*' />
    [NativeTypeName("#define D3D11_1_SB_GLOBAL_FLAG_ENABLE_DOUBLE_EXTENSIONS (1<<17)")]
    public const int D3D11_1_SB_GLOBAL_FLAG_ENABLE_DOUBLE_EXTENSIONS = (1 << 17);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_1_SB_GLOBAL_FLAG_ENABLE_SHADER_EXTENSIONS"]/*' />
    [NativeTypeName("#define D3D11_1_SB_GLOBAL_FLAG_ENABLE_SHADER_EXTENSIONS (1<<18)")]
    public const int D3D11_1_SB_GLOBAL_FLAG_ENABLE_SHADER_EXTENSIONS = (1 << 18);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_SB_INPUT_CONTROL_POINT_COUNT_MASK"]/*' />
    [NativeTypeName("#define D3D11_SB_INPUT_CONTROL_POINT_COUNT_MASK 0x0001f800")]
    public const int D3D11_SB_INPUT_CONTROL_POINT_COUNT_MASK = 0x0001f800;

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_SB_INPUT_CONTROL_POINT_COUNT_SHIFT"]/*' />
    [NativeTypeName("#define D3D11_SB_INPUT_CONTROL_POINT_COUNT_SHIFT 11")]
    public const int D3D11_SB_INPUT_CONTROL_POINT_COUNT_SHIFT = 11;

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_SB_OUTPUT_CONTROL_POINT_COUNT_MASK"]/*' />
    [NativeTypeName("#define D3D11_SB_OUTPUT_CONTROL_POINT_COUNT_MASK 0x0001f800")]
    public const int D3D11_SB_OUTPUT_CONTROL_POINT_COUNT_MASK = 0x0001f800;

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_SB_OUTPUT_CONTROL_POINT_COUNT_SHIFT"]/*' />
    [NativeTypeName("#define D3D11_SB_OUTPUT_CONTROL_POINT_COUNT_SHIFT 11")]
    public const int D3D11_SB_OUTPUT_CONTROL_POINT_COUNT_SHIFT = 11;

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_SB_TESS_DOMAIN_MASK"]/*' />
    [NativeTypeName("#define D3D11_SB_TESS_DOMAIN_MASK 0x00001800")]
    public const int D3D11_SB_TESS_DOMAIN_MASK = 0x00001800;

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_SB_TESS_DOMAIN_SHIFT"]/*' />
    [NativeTypeName("#define D3D11_SB_TESS_DOMAIN_SHIFT 11")]
    public const int D3D11_SB_TESS_DOMAIN_SHIFT = 11;

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_SB_TESS_PARTITIONING_MASK"]/*' />
    [NativeTypeName("#define D3D11_SB_TESS_PARTITIONING_MASK 0x00003800")]
    public const int D3D11_SB_TESS_PARTITIONING_MASK = 0x00003800;

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_SB_TESS_PARTITIONING_SHIFT"]/*' />
    [NativeTypeName("#define D3D11_SB_TESS_PARTITIONING_SHIFT 11")]
    public const int D3D11_SB_TESS_PARTITIONING_SHIFT = 11;

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_SB_TESS_OUTPUT_PRIMITIVE_MASK"]/*' />
    [NativeTypeName("#define D3D11_SB_TESS_OUTPUT_PRIMITIVE_MASK 0x00003800")]
    public const int D3D11_SB_TESS_OUTPUT_PRIMITIVE_MASK = 0x00003800;

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_SB_TESS_OUTPUT_PRIMITIVE_SHIFT"]/*' />
    [NativeTypeName("#define D3D11_SB_TESS_OUTPUT_PRIMITIVE_SHIFT 11")]
    public const int D3D11_SB_TESS_OUTPUT_PRIMITIVE_SHIFT = 11;

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_SB_INTERFACE_INDEXED_BIT_MASK"]/*' />
    [NativeTypeName("#define D3D11_SB_INTERFACE_INDEXED_BIT_MASK 0x00000800")]
    public const int D3D11_SB_INTERFACE_INDEXED_BIT_MASK = 0x00000800;

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_SB_INTERFACE_INDEXED_BIT_SHIFT"]/*' />
    [NativeTypeName("#define D3D11_SB_INTERFACE_INDEXED_BIT_SHIFT 11")]
    public const int D3D11_SB_INTERFACE_INDEXED_BIT_SHIFT = 11;

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_SB_INTERFACE_TABLE_LENGTH_MASK"]/*' />
    [NativeTypeName("#define D3D11_SB_INTERFACE_TABLE_LENGTH_MASK 0x0000ffff")]
    public const int D3D11_SB_INTERFACE_TABLE_LENGTH_MASK = 0x0000ffff;

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_SB_INTERFACE_TABLE_LENGTH_SHIFT"]/*' />
    [NativeTypeName("#define D3D11_SB_INTERFACE_TABLE_LENGTH_SHIFT 0")]
    public const int D3D11_SB_INTERFACE_TABLE_LENGTH_SHIFT = 0;

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_SB_INTERFACE_ARRAY_LENGTH_MASK"]/*' />
    [NativeTypeName("#define D3D11_SB_INTERFACE_ARRAY_LENGTH_MASK 0xffff0000")]
    public const uint D3D11_SB_INTERFACE_ARRAY_LENGTH_MASK = 0xffff0000;

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_SB_INTERFACE_ARRAY_LENGTH_SHIFT"]/*' />
    [NativeTypeName("#define D3D11_SB_INTERFACE_ARRAY_LENGTH_SHIFT 16")]
    public const int D3D11_SB_INTERFACE_ARRAY_LENGTH_SHIFT = 16;

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_SB_GLOBALLY_COHERENT_ACCESS"]/*' />
    [NativeTypeName("#define D3D11_SB_GLOBALLY_COHERENT_ACCESS 0x00010000")]
    public const int D3D11_SB_GLOBALLY_COHERENT_ACCESS = 0x00010000;

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_SB_ACCESS_COHERENCY_MASK"]/*' />
    [NativeTypeName("#define D3D11_SB_ACCESS_COHERENCY_MASK 0x00010000")]
    public const int D3D11_SB_ACCESS_COHERENCY_MASK = 0x00010000;

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_SB_RASTERIZER_ORDERED_ACCESS"]/*' />
    [NativeTypeName("#define D3D11_SB_RASTERIZER_ORDERED_ACCESS 0x00020000")]
    public const int D3D11_SB_RASTERIZER_ORDERED_ACCESS = 0x00020000;

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_SB_RESOURCE_FLAGS_MASK"]/*' />
    [NativeTypeName("#define D3D11_SB_RESOURCE_FLAGS_MASK (D3D11_SB_GLOBALLY_COHERENT_ACCESS|D3D11_SB_RASTERIZER_ORDERED_ACCESS|D3D11_SB_UAV_HAS_ORDER_PRESERVING_COUNTER)")]
    public const int D3D11_SB_RESOURCE_FLAGS_MASK = (0x00010000 | 0x00020000 | 0x00800000);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_SB_UAV_HAS_ORDER_PRESERVING_COUNTER"]/*' />
    [NativeTypeName("#define D3D11_SB_UAV_HAS_ORDER_PRESERVING_COUNTER 0x00800000")]
    public const int D3D11_SB_UAV_HAS_ORDER_PRESERVING_COUNTER = 0x00800000;

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_SB_UAV_FLAGS_MASK"]/*' />
    [NativeTypeName("#define D3D11_SB_UAV_FLAGS_MASK 0x00800000")]
    public const int D3D11_SB_UAV_FLAGS_MASK = 0x00800000;
}
