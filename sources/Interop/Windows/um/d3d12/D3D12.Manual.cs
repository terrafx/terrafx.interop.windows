// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using static TerraFX.Interop.D3D12_FILTER_REDUCTION_TYPE;
using static TerraFX.Interop.D3D12_FILTER_TYPE;

namespace TerraFX.Interop
{
    public static unsafe partial class D3D12
    {
        public const uint D3D12_16BIT_INDEX_STRIP_CUT_VALUE = 0xFFFF;

        public const uint D3D12_32BIT_INDEX_STRIP_CUT_VALUE = 0xFFFFFFFF;

        public const uint D3D12_8BIT_INDEX_STRIP_CUT_VALUE = 0xFF;

        public const uint D3D12_APPEND_ALIGNED_ELEMENT = 0xFFFFFFFF;

        public const uint D3D12_ARRAY_AXIS_ADDRESS_RANGE_BIT_COUNT = 9;

        public const uint D3D12_CLIP_OR_CULL_DISTANCE_COUNT = 8;

        public const uint D3D12_CLIP_OR_CULL_DISTANCE_ELEMENT_COUNT = 2;

        public const uint D3D12_COMMONSHADER_CONSTANT_BUFFER_API_SLOT_COUNT = 14;

        public const uint D3D12_COMMONSHADER_CONSTANT_BUFFER_COMPONENTS = 4;

        public const uint D3D12_COMMONSHADER_CONSTANT_BUFFER_COMPONENT_BIT_COUNT = 32;

        public const uint D3D12_COMMONSHADER_CONSTANT_BUFFER_HW_SLOT_COUNT = 15;

        public const uint D3D12_COMMONSHADER_CONSTANT_BUFFER_PARTIAL_UPDATE_EXTENTS_BYTE_ALIGNMENT = 16;

        public const uint D3D12_COMMONSHADER_CONSTANT_BUFFER_REGISTER_COMPONENTS = 4;

        public const uint D3D12_COMMONSHADER_CONSTANT_BUFFER_REGISTER_COUNT = 15;

        public const uint D3D12_COMMONSHADER_CONSTANT_BUFFER_REGISTER_READS_PER_INST = 1;

        public const uint D3D12_COMMONSHADER_CONSTANT_BUFFER_REGISTER_READ_PORTS = 1;

        public const uint D3D12_COMMONSHADER_FLOWCONTROL_NESTING_LIMIT = 64;

        public const uint D3D12_COMMONSHADER_IMMEDIATE_CONSTANT_BUFFER_REGISTER_COMPONENTS = 4;

        public const uint D3D12_COMMONSHADER_IMMEDIATE_CONSTANT_BUFFER_REGISTER_COUNT = 1;

        public const uint D3D12_COMMONSHADER_IMMEDIATE_CONSTANT_BUFFER_REGISTER_READS_PER_INST = 1;

        public const uint D3D12_COMMONSHADER_IMMEDIATE_CONSTANT_BUFFER_REGISTER_READ_PORTS = 1;

        public const uint D3D12_COMMONSHADER_IMMEDIATE_VALUE_COMPONENT_BIT_COUNT = 32;

        public const uint D3D12_COMMONSHADER_INPUT_RESOURCE_REGISTER_COMPONENTS = 1;

        public const uint D3D12_COMMONSHADER_INPUT_RESOURCE_REGISTER_COUNT = 128;

        public const uint D3D12_COMMONSHADER_INPUT_RESOURCE_REGISTER_READS_PER_INST = 1;

        public const uint D3D12_COMMONSHADER_INPUT_RESOURCE_REGISTER_READ_PORTS = 1;

        public const uint D3D12_COMMONSHADER_INPUT_RESOURCE_SLOT_COUNT = 128;

        public const uint D3D12_COMMONSHADER_SAMPLER_REGISTER_COMPONENTS = 1;

        public const uint D3D12_COMMONSHADER_SAMPLER_REGISTER_COUNT = 16;

        public const uint D3D12_COMMONSHADER_SAMPLER_REGISTER_READS_PER_INST = 1;

        public const uint D3D12_COMMONSHADER_SAMPLER_REGISTER_READ_PORTS = 1;

        public const uint D3D12_COMMONSHADER_SAMPLER_SLOT_COUNT = 16;

        public const uint D3D12_COMMONSHADER_SUBROUTINE_NESTING_LIMIT = 32;

        public const uint D3D12_COMMONSHADER_TEMP_REGISTER_COMPONENTS = 4;

        public const uint D3D12_COMMONSHADER_TEMP_REGISTER_COMPONENT_BIT_COUNT = 32;

        public const uint D3D12_COMMONSHADER_TEMP_REGISTER_COUNT = 4096;

        public const uint D3D12_COMMONSHADER_TEMP_REGISTER_READS_PER_INST = 3;

        public const uint D3D12_COMMONSHADER_TEMP_REGISTER_READ_PORTS = 3;

        public const uint D3D12_COMMONSHADER_TEXCOORD_RANGE_REDUCTION_MAX = 10;

        public const int D3D12_COMMONSHADER_TEXCOORD_RANGE_REDUCTION_MIN = -10;

        public const int D3D12_COMMONSHADER_TEXEL_OFFSET_MAX_NEGATIVE = -8;

        public const uint D3D12_COMMONSHADER_TEXEL_OFFSET_MAX_POSITIVE = 7;

        public const uint D3D12_CONSTANT_BUFFER_DATA_PLACEMENT_ALIGNMENT = 256;

        public const uint D3D12_CS_4_X_BUCKET00_MAX_BYTES_TGSM_WRITABLE_PER_THREAD = 256;

        public const uint D3D12_CS_4_X_BUCKET00_MAX_NUM_THREADS_PER_GROUP = 64;

        public const uint D3D12_CS_4_X_BUCKET01_MAX_BYTES_TGSM_WRITABLE_PER_THREAD = 240;

        public const uint D3D12_CS_4_X_BUCKET01_MAX_NUM_THREADS_PER_GROUP = 68;

        public const uint D3D12_CS_4_X_BUCKET02_MAX_BYTES_TGSM_WRITABLE_PER_THREAD = 224;

        public const uint D3D12_CS_4_X_BUCKET02_MAX_NUM_THREADS_PER_GROUP = 72;

        public const uint D3D12_CS_4_X_BUCKET03_MAX_BYTES_TGSM_WRITABLE_PER_THREAD = 208;

        public const uint D3D12_CS_4_X_BUCKET03_MAX_NUM_THREADS_PER_GROUP = 76;

        public const uint D3D12_CS_4_X_BUCKET04_MAX_BYTES_TGSM_WRITABLE_PER_THREAD = 192;

        public const uint D3D12_CS_4_X_BUCKET04_MAX_NUM_THREADS_PER_GROUP = 84;

        public const uint D3D12_CS_4_X_BUCKET05_MAX_BYTES_TGSM_WRITABLE_PER_THREAD = 176;

        public const uint D3D12_CS_4_X_BUCKET05_MAX_NUM_THREADS_PER_GROUP = 92;

        public const uint D3D12_CS_4_X_BUCKET06_MAX_BYTES_TGSM_WRITABLE_PER_THREAD = 160;

        public const uint D3D12_CS_4_X_BUCKET06_MAX_NUM_THREADS_PER_GROUP = 100;

        public const uint D3D12_CS_4_X_BUCKET07_MAX_BYTES_TGSM_WRITABLE_PER_THREAD = 144;

        public const uint D3D12_CS_4_X_BUCKET07_MAX_NUM_THREADS_PER_GROUP = 112;

        public const uint D3D12_CS_4_X_BUCKET08_MAX_BYTES_TGSM_WRITABLE_PER_THREAD = 128;

        public const uint D3D12_CS_4_X_BUCKET08_MAX_NUM_THREADS_PER_GROUP = 128;

        public const uint D3D12_CS_4_X_BUCKET09_MAX_BYTES_TGSM_WRITABLE_PER_THREAD = 112;

        public const uint D3D12_CS_4_X_BUCKET09_MAX_NUM_THREADS_PER_GROUP = 144;

        public const uint D3D12_CS_4_X_BUCKET10_MAX_BYTES_TGSM_WRITABLE_PER_THREAD = 96;

        public const uint D3D12_CS_4_X_BUCKET10_MAX_NUM_THREADS_PER_GROUP = 168;

        public const uint D3D12_CS_4_X_BUCKET11_MAX_BYTES_TGSM_WRITABLE_PER_THREAD = 80;

        public const uint D3D12_CS_4_X_BUCKET11_MAX_NUM_THREADS_PER_GROUP = 204;

        public const uint D3D12_CS_4_X_BUCKET12_MAX_BYTES_TGSM_WRITABLE_PER_THREAD = 64;

        public const uint D3D12_CS_4_X_BUCKET12_MAX_NUM_THREADS_PER_GROUP = 256;

        public const uint D3D12_CS_4_X_BUCKET13_MAX_BYTES_TGSM_WRITABLE_PER_THREAD = 48;

        public const uint D3D12_CS_4_X_BUCKET13_MAX_NUM_THREADS_PER_GROUP = 340;

        public const uint D3D12_CS_4_X_BUCKET14_MAX_BYTES_TGSM_WRITABLE_PER_THREAD = 32;

        public const uint D3D12_CS_4_X_BUCKET14_MAX_NUM_THREADS_PER_GROUP = 512;

        public const uint D3D12_CS_4_X_BUCKET15_MAX_BYTES_TGSM_WRITABLE_PER_THREAD = 16;

        public const uint D3D12_CS_4_X_BUCKET15_MAX_NUM_THREADS_PER_GROUP = 768;

        public const uint D3D12_CS_4_X_DISPATCH_MAX_THREAD_GROUPS_IN_Z_DIMENSION = 1;

        public const uint D3D12_CS_4_X_RAW_UAV_BYTE_ALIGNMENT = 256;

        public const uint D3D12_CS_4_X_THREAD_GROUP_MAX_THREADS_PER_GROUP = 768;

        public const uint D3D12_CS_4_X_THREAD_GROUP_MAX_X = 768;

        public const uint D3D12_CS_4_X_THREAD_GROUP_MAX_Y = 768;

        public const uint D3D12_CS_4_X_UAV_REGISTER_COUNT = 1;

        public const uint D3D12_CS_DISPATCH_MAX_THREAD_GROUPS_PER_DIMENSION = 65535;

        public const uint D3D12_CS_TGSM_REGISTER_COUNT = 8192;

        public const uint D3D12_CS_TGSM_REGISTER_READS_PER_INST = 1;

        public const uint D3D12_CS_TGSM_RESOURCE_REGISTER_COMPONENTS = 1;

        public const uint D3D12_CS_TGSM_RESOURCE_REGISTER_READ_PORTS = 1;

        public const uint D3D12_CS_THREADGROUPID_REGISTER_COMPONENTS = 3;

        public const uint D3D12_CS_THREADGROUPID_REGISTER_COUNT = 1;

        public const uint D3D12_CS_THREADIDINGROUPFLATTENED_REGISTER_COMPONENTS = 1;

        public const uint D3D12_CS_THREADIDINGROUPFLATTENED_REGISTER_COUNT = 1;

        public const uint D3D12_CS_THREADIDINGROUP_REGISTER_COMPONENTS = 3;

        public const uint D3D12_CS_THREADIDINGROUP_REGISTER_COUNT = 1;

        public const uint D3D12_CS_THREADID_REGISTER_COMPONENTS = 3;

        public const uint D3D12_CS_THREADID_REGISTER_COUNT = 1;

        public const uint D3D12_CS_THREAD_GROUP_MAX_THREADS_PER_GROUP = 1024;

        public const uint D3D12_CS_THREAD_GROUP_MAX_X = 1024;

        public const uint D3D12_CS_THREAD_GROUP_MAX_Y = 1024;

        public const uint D3D12_CS_THREAD_GROUP_MAX_Z = 64;

        public const uint D3D12_CS_THREAD_GROUP_MIN_X = 1;

        public const uint D3D12_CS_THREAD_GROUP_MIN_Y = 1;

        public const uint D3D12_CS_THREAD_GROUP_MIN_Z = 1;

        public const uint D3D12_CS_THREAD_LOCAL_TEMP_REGISTER_POOL = 16384;

        public const float D3D12_DEFAULT_BLEND_FACTOR_ALPHA = 1.0f;

        public const float D3D12_DEFAULT_BLEND_FACTOR_BLUE = 1.0f;

        public const float D3D12_DEFAULT_BLEND_FACTOR_GREEN = 1.0f;

        public const float D3D12_DEFAULT_BLEND_FACTOR_RED = 1.0f;

        public const float D3D12_DEFAULT_BORDER_COLOR_COMPONENT = 0.0f;

        public const int D3D12_DEFAULT_DEPTH_BIAS = 0;

        public const float D3D12_DEFAULT_DEPTH_BIAS_CLAMP = 0.0f;

        public const uint D3D12_DEFAULT_MAX_ANISOTROPY = 16;

        public const float D3D12_DEFAULT_MIP_LOD_BIAS = 0.0f;

        public const uint D3D12_DEFAULT_MSAA_RESOURCE_PLACEMENT_ALIGNMENT = 4194304;

        public const uint D3D12_DEFAULT_RENDER_TARGET_ARRAY_INDEX = 0;

        public const uint D3D12_DEFAULT_RESOURCE_PLACEMENT_ALIGNMENT = 65536;

        public const uint D3D12_DEFAULT_SAMPLE_MASK = 0xFFFFFFFF;

        public const uint D3D12_DEFAULT_SCISSOR_ENDX = 0;

        public const uint D3D12_DEFAULT_SCISSOR_ENDY = 0;

        public const uint D3D12_DEFAULT_SCISSOR_STARTX = 0;

        public const uint D3D12_DEFAULT_SCISSOR_STARTY = 0;

        public const float D3D12_DEFAULT_SLOPE_SCALED_DEPTH_BIAS = 0.0f;

        public const uint D3D12_DEFAULT_STENCIL_READ_MASK = 0xFF;

        public const uint D3D12_DEFAULT_STENCIL_REFERENCE = 0;

        public const uint D3D12_DEFAULT_STENCIL_WRITE_MASK = 0xFF;

        public const uint D3D12_DEFAULT_VIEWPORT_AND_SCISSORRECT_INDEX = 0;

        public const uint D3D12_DEFAULT_VIEWPORT_HEIGHT = 0;

        public const float D3D12_DEFAULT_VIEWPORT_MAX_DEPTH = 0.0f;

        public const float D3D12_DEFAULT_VIEWPORT_MIN_DEPTH = 0.0f;

        public const uint D3D12_DEFAULT_VIEWPORT_TOPLEFTX = 0;

        public const uint D3D12_DEFAULT_VIEWPORT_TOPLEFTY = 0;

        public const uint D3D12_DEFAULT_VIEWPORT_WIDTH = 0;

        public const uint D3D12_DESCRIPTOR_RANGE_OFFSET_APPEND = 0xFFFFFFFF;

        public const uint D3D12_DRIVER_RESERVED_REGISTER_SPACE_VALUES_END = 0xFFFFFFF7;

        public const uint D3D12_DRIVER_RESERVED_REGISTER_SPACE_VALUES_START = 0xFFFFFFF0;

        public const uint D3D12_DS_INPUT_CONTROL_POINTS_MAX_TOTAL_SCALARS = 3968;

        public const uint D3D12_DS_INPUT_CONTROL_POINT_REGISTER_COMPONENTS = 4;

        public const uint D3D12_DS_INPUT_CONTROL_POINT_REGISTER_COMPONENT_BIT_COUNT = 32;

        public const uint D3D12_DS_INPUT_CONTROL_POINT_REGISTER_COUNT = 32;

        public const uint D3D12_DS_INPUT_CONTROL_POINT_REGISTER_READS_PER_INST = 2;

        public const uint D3D12_DS_INPUT_CONTROL_POINT_REGISTER_READ_PORTS = 1;

        public const uint D3D12_DS_INPUT_DOMAIN_POINT_REGISTER_COMPONENTS = 3;

        public const uint D3D12_DS_INPUT_DOMAIN_POINT_REGISTER_COMPONENT_BIT_COUNT = 32;

        public const uint D3D12_DS_INPUT_DOMAIN_POINT_REGISTER_COUNT = 1;

        public const uint D3D12_DS_INPUT_DOMAIN_POINT_REGISTER_READS_PER_INST = 2;

        public const uint D3D12_DS_INPUT_DOMAIN_POINT_REGISTER_READ_PORTS = 1;

        public const uint D3D12_DS_INPUT_PATCH_CONSTANT_REGISTER_COMPONENTS = 4;

        public const uint D3D12_DS_INPUT_PATCH_CONSTANT_REGISTER_COMPONENT_BIT_COUNT = 32;

        public const uint D3D12_DS_INPUT_PATCH_CONSTANT_REGISTER_COUNT = 32;

        public const uint D3D12_DS_INPUT_PATCH_CONSTANT_REGISTER_READS_PER_INST = 2;

        public const uint D3D12_DS_INPUT_PATCH_CONSTANT_REGISTER_READ_PORTS = 1;

        public const uint D3D12_DS_INPUT_PRIMITIVE_ID_REGISTER_COMPONENTS = 1;

        public const uint D3D12_DS_INPUT_PRIMITIVE_ID_REGISTER_COMPONENT_BIT_COUNT = 32;

        public const uint D3D12_DS_INPUT_PRIMITIVE_ID_REGISTER_COUNT = 1;

        public const uint D3D12_DS_INPUT_PRIMITIVE_ID_REGISTER_READS_PER_INST = 2;

        public const uint D3D12_DS_INPUT_PRIMITIVE_ID_REGISTER_READ_PORTS = 1;

        public const uint D3D12_DS_OUTPUT_REGISTER_COMPONENTS = 4;

        public const uint D3D12_DS_OUTPUT_REGISTER_COMPONENT_BIT_COUNT = 32;

        public const uint D3D12_DS_OUTPUT_REGISTER_COUNT = 32;

        public const float D3D12_FLOAT16_FUSED_TOLERANCE_IN_ULP = 0.6f;

        public const float D3D12_FLOAT32_MAX = 3.402823466e+38f;

        public const float D3D12_FLOAT32_TO_INTEGER_TOLERANCE_IN_ULP = 0.6f;

        public const float D3D12_FLOAT_TO_SRGB_EXPONENT_DENOMINATOR = 2.4f;

        public const float D3D12_FLOAT_TO_SRGB_EXPONENT_NUMERATOR = 1.0f;

        public const float D3D12_FLOAT_TO_SRGB_OFFSET = 0.055f;

        public const float D3D12_FLOAT_TO_SRGB_SCALE_1 = 12.92f;

        public const float D3D12_FLOAT_TO_SRGB_SCALE_2 = 1.055f;

        public const float D3D12_FLOAT_TO_SRGB_THRESHOLD = 0.0031308f;

        public const float D3D12_FTOI_INSTRUCTION_MAX_INPUT = 2147483647.999f;

        public const float D3D12_FTOI_INSTRUCTION_MIN_INPUT = -2147483648.999f;

        public const float D3D12_FTOU_INSTRUCTION_MAX_INPUT = 4294967295.999f;

        public const float D3D12_FTOU_INSTRUCTION_MIN_INPUT = 0.0f;

        public const uint D3D12_GS_INPUT_INSTANCE_ID_READS_PER_INST = 2;

        public const uint D3D12_GS_INPUT_INSTANCE_ID_READ_PORTS = 1;

        public const uint D3D12_GS_INPUT_INSTANCE_ID_REGISTER_COMPONENTS = 1;

        public const uint D3D12_GS_INPUT_INSTANCE_ID_REGISTER_COMPONENT_BIT_COUNT = 32;

        public const uint D3D12_GS_INPUT_INSTANCE_ID_REGISTER_COUNT = 1;

        public const uint D3D12_GS_INPUT_PRIM_CONST_REGISTER_COMPONENTS = 1;

        public const uint D3D12_GS_INPUT_PRIM_CONST_REGISTER_COMPONENT_BIT_COUNT = 32;

        public const uint D3D12_GS_INPUT_PRIM_CONST_REGISTER_COUNT = 1;

        public const uint D3D12_GS_INPUT_PRIM_CONST_REGISTER_READS_PER_INST = 2;

        public const uint D3D12_GS_INPUT_PRIM_CONST_REGISTER_READ_PORTS = 1;

        public const uint D3D12_GS_INPUT_REGISTER_COMPONENTS = 4;

        public const uint D3D12_GS_INPUT_REGISTER_COMPONENT_BIT_COUNT = 32;

        public const uint D3D12_GS_INPUT_REGISTER_COUNT = 32;

        public const uint D3D12_GS_INPUT_REGISTER_READS_PER_INST = 2;

        public const uint D3D12_GS_INPUT_REGISTER_READ_PORTS = 1;

        public const uint D3D12_GS_INPUT_REGISTER_VERTICES = 32;

        public const uint D3D12_GS_MAX_INSTANCE_COUNT = 32;

        public const uint D3D12_GS_MAX_OUTPUT_VERTEX_COUNT_ACROSS_INSTANCES = 1024;

        public const uint D3D12_GS_OUTPUT_ELEMENTS = 32;

        public const uint D3D12_GS_OUTPUT_REGISTER_COMPONENTS = 4;

        public const uint D3D12_GS_OUTPUT_REGISTER_COMPONENT_BIT_COUNT = 32;

        public const uint D3D12_GS_OUTPUT_REGISTER_COUNT = 32;

        public const uint D3D12_HS_CONTROL_POINT_PHASE_INPUT_REGISTER_COUNT = 32;

        public const uint D3D12_HS_CONTROL_POINT_PHASE_OUTPUT_REGISTER_COUNT = 32;

        public const uint D3D12_HS_CONTROL_POINT_REGISTER_COMPONENTS = 4;

        public const uint D3D12_HS_CONTROL_POINT_REGISTER_COMPONENT_BIT_COUNT = 32;

        public const uint D3D12_HS_CONTROL_POINT_REGISTER_READS_PER_INST = 2;

        public const uint D3D12_HS_CONTROL_POINT_REGISTER_READ_PORTS = 1;

        public const uint D3D12_HS_FORK_PHASE_INSTANCE_COUNT_UPPER_BOUND = 0xFFFFFFFF;

        public const uint D3D12_HS_INPUT_FORK_INSTANCE_ID_REGISTER_COMPONENTS = 1;

        public const uint D3D12_HS_INPUT_FORK_INSTANCE_ID_REGISTER_COMPONENT_BIT_COUNT = 32;

        public const uint D3D12_HS_INPUT_FORK_INSTANCE_ID_REGISTER_COUNT = 1;

        public const uint D3D12_HS_INPUT_FORK_INSTANCE_ID_REGISTER_READS_PER_INST = 2;

        public const uint D3D12_HS_INPUT_FORK_INSTANCE_ID_REGISTER_READ_PORTS = 1;

        public const uint D3D12_HS_INPUT_JOIN_INSTANCE_ID_REGISTER_COMPONENTS = 1;

        public const uint D3D12_HS_INPUT_JOIN_INSTANCE_ID_REGISTER_COMPONENT_BIT_COUNT = 32;

        public const uint D3D12_HS_INPUT_JOIN_INSTANCE_ID_REGISTER_COUNT = 1;

        public const uint D3D12_HS_INPUT_JOIN_INSTANCE_ID_REGISTER_READS_PER_INST = 2;

        public const uint D3D12_HS_INPUT_JOIN_INSTANCE_ID_REGISTER_READ_PORTS = 1;

        public const uint D3D12_HS_INPUT_PRIMITIVE_ID_REGISTER_COMPONENTS = 1;

        public const uint D3D12_HS_INPUT_PRIMITIVE_ID_REGISTER_COMPONENT_BIT_COUNT = 32;

        public const uint D3D12_HS_INPUT_PRIMITIVE_ID_REGISTER_COUNT = 1;

        public const uint D3D12_HS_INPUT_PRIMITIVE_ID_REGISTER_READS_PER_INST = 2;

        public const uint D3D12_HS_INPUT_PRIMITIVE_ID_REGISTER_READ_PORTS = 1;

        public const uint D3D12_HS_JOIN_PHASE_INSTANCE_COUNT_UPPER_BOUND = 0xFFFFFFFF;

        public const float D3D12_HS_MAXTESSFACTOR_LOWER_BOUND = 1.0f;

        public const float D3D12_HS_MAXTESSFACTOR_UPPER_BOUND = 64.0f;

        public const uint D3D12_HS_OUTPUT_CONTROL_POINTS_MAX_TOTAL_SCALARS = 3968;

        public const uint D3D12_HS_OUTPUT_CONTROL_POINT_ID_REGISTER_COMPONENTS = 1;

        public const uint D3D12_HS_OUTPUT_CONTROL_POINT_ID_REGISTER_COMPONENT_BIT_COUNT = 32;

        public const uint D3D12_HS_OUTPUT_CONTROL_POINT_ID_REGISTER_COUNT = 1;

        public const uint D3D12_HS_OUTPUT_CONTROL_POINT_ID_REGISTER_READS_PER_INST = 2;

        public const uint D3D12_HS_OUTPUT_CONTROL_POINT_ID_REGISTER_READ_PORTS = 1;

        public const uint D3D12_HS_OUTPUT_PATCH_CONSTANT_REGISTER_COMPONENTS = 4;

        public const uint D3D12_HS_OUTPUT_PATCH_CONSTANT_REGISTER_COMPONENT_BIT_COUNT = 32;

        public const uint D3D12_HS_OUTPUT_PATCH_CONSTANT_REGISTER_COUNT = 32;

        public const uint D3D12_HS_OUTPUT_PATCH_CONSTANT_REGISTER_READS_PER_INST = 2;

        public const uint D3D12_HS_OUTPUT_PATCH_CONSTANT_REGISTER_READ_PORTS = 1;

        public const uint D3D12_HS_OUTPUT_PATCH_CONSTANT_REGISTER_SCALAR_COMPONENTS = 128;

        public const uint D3D12_IA_DEFAULT_INDEX_BUFFER_OFFSET_IN_BYTES = 0;

        public const uint D3D12_IA_DEFAULT_PRIMITIVE_TOPOLOGY = 0;

        public const uint D3D12_IA_DEFAULT_VERTEX_BUFFER_OFFSET_IN_BYTES = 0;

        public const uint D3D12_IA_INDEX_INPUT_RESOURCE_SLOT_COUNT = 1;

        public const uint D3D12_IA_INSTANCE_ID_BIT_COUNT = 32;

        public const uint D3D12_IA_INTEGER_ARITHMETIC_BIT_COUNT = 32;

        public const uint D3D12_IA_PATCH_MAX_CONTROL_POINT_COUNT = 32;

        public const uint D3D12_IA_PRIMITIVE_ID_BIT_COUNT = 32;

        public const uint D3D12_IA_VERTEX_ID_BIT_COUNT = 32;

        public const uint D3D12_IA_VERTEX_INPUT_RESOURCE_SLOT_COUNT = 32;

        public const uint D3D12_IA_VERTEX_INPUT_STRUCTURE_ELEMENTS_COMPONENTS = 128;

        public const uint D3D12_IA_VERTEX_INPUT_STRUCTURE_ELEMENT_COUNT = 32;

        public const uint D3D12_INTEGER_DIVIDE_BY_ZERO_QUOTIENT = 0xFFFFFFFF;

        public const uint D3D12_INTEGER_DIVIDE_BY_ZERO_REMAINDER = 0xFFFFFFFF;

        public const uint D3D12_KEEP_RENDER_TARGETS_AND_DEPTH_STENCIL = 0xFFFFFFFF;

        public const uint D3D12_KEEP_UNORDERED_ACCESS_VIEWS = 0xFFFFFFFF;

        public const float D3D12_LINEAR_GAMMA = 1.0f;

        public const uint D3D12_MAJOR_VERSION = 12;

        public const float D3D12_MAX_BORDER_COLOR_COMPONENT = 1.0f;

        public const float D3D12_MAX_DEPTH = 1.0f;

        public const uint D3D12_MAX_LIVE_STATIC_SAMPLERS = 2032;

        public const uint D3D12_MAX_MAXANISOTROPY = 16;

        public const uint D3D12_MAX_MULTISAMPLE_SAMPLE_COUNT = 32;

        public const float D3D12_MAX_POSITION_VALUE = 3.402823466e+34f;

        public const uint D3D12_MAX_ROOT_COST = 64;

        public const uint D3D12_MAX_SHADER_VISIBLE_DESCRIPTOR_HEAP_SIZE_TIER_1 = 1000000;

        public const uint D3D12_MAX_SHADER_VISIBLE_DESCRIPTOR_HEAP_SIZE_TIER_2 = 1000000;

        public const uint D3D12_MAX_SHADER_VISIBLE_SAMPLER_HEAP_SIZE = 2048;

        public const uint D3D12_MAX_TEXTURE_DIMENSION_2_TO_EXP = 17;

        public const uint D3D12_MAX_VIEW_INSTANCE_COUNT = 4;

        public const uint D3D12_MINOR_VERSION = 0;

        public const float D3D12_MIN_BORDER_COLOR_COMPONENT = 0.0f;

        public const float D3D12_MIN_DEPTH = 0.0f;

        public const uint D3D12_MIN_MAXANISOTROPY = 0;

        public const float D3D12_MIP_LOD_BIAS_MAX = 15.99f;

        public const float D3D12_MIP_LOD_BIAS_MIN = -16.0f;

        public const uint D3D12_MIP_LOD_FRACTIONAL_BIT_COUNT = 8;

        public const uint D3D12_MIP_LOD_RANGE_BIT_COUNT = 8;

        public const float D3D12_MULTISAMPLE_ANTIALIAS_LINE_WIDTH = 1.4f;

        public const uint D3D12_NONSAMPLE_FETCH_OUT_OF_RANGE_ACCESS_RESULT = 0;

        public const uint D3D12_OS_RESERVED_REGISTER_SPACE_VALUES_END = 0xFFFFFFFF;

        public const uint D3D12_OS_RESERVED_REGISTER_SPACE_VALUES_START = 0xFFFFFFF8;

        public const uint D3D12_PACKED_TILE = 0xFFFFFFFF;

        public const uint D3D12_PIXEL_ADDRESS_RANGE_BIT_COUNT = 15;

        public const uint D3D12_PRE_SCISSOR_PIXEL_ADDRESS_RANGE_BIT_COUNT = 16;

        public const uint D3D12_PS_CS_UAV_REGISTER_COMPONENTS = 1;

        public const uint D3D12_PS_CS_UAV_REGISTER_COUNT = 8;

        public const uint D3D12_PS_CS_UAV_REGISTER_READS_PER_INST = 1;

        public const uint D3D12_PS_CS_UAV_REGISTER_READ_PORTS = 1;

        public const uint D3D12_PS_FRONTFACING_DEFAULT_VALUE = 0xFFFFFFFF;

        public const uint D3D12_PS_FRONTFACING_FALSE_VALUE = 0x00000000;

        public const uint D3D12_PS_FRONTFACING_TRUE_VALUE = 0xFFFFFFFF;

        public const uint D3D12_PS_INPUT_REGISTER_COMPONENTS = 4;

        public const uint D3D12_PS_INPUT_REGISTER_COMPONENT_BIT_COUNT = 32;

        public const uint D3D12_PS_INPUT_REGISTER_COUNT = 32;

        public const uint D3D12_PS_INPUT_REGISTER_READS_PER_INST = 2;

        public const uint D3D12_PS_INPUT_REGISTER_READ_PORTS = 1;

        public const float D3D12_PS_LEGACY_PIXEL_CENTER_FRACTIONAL_COMPONENT = 0.0f;

        public const uint D3D12_PS_OUTPUT_DEPTH_REGISTER_COMPONENTS = 1;

        public const uint D3D12_PS_OUTPUT_DEPTH_REGISTER_COMPONENT_BIT_COUNT = 32;

        public const uint D3D12_PS_OUTPUT_DEPTH_REGISTER_COUNT = 1;

        public const uint D3D12_PS_OUTPUT_MASK_REGISTER_COMPONENTS = 1;

        public const uint D3D12_PS_OUTPUT_MASK_REGISTER_COMPONENT_BIT_COUNT = 32;

        public const uint D3D12_PS_OUTPUT_MASK_REGISTER_COUNT = 1;

        public const uint D3D12_PS_OUTPUT_REGISTER_COMPONENTS = 4;

        public const uint D3D12_PS_OUTPUT_REGISTER_COMPONENT_BIT_COUNT = 32;

        public const uint D3D12_PS_OUTPUT_REGISTER_COUNT = 8;

        public const float D3D12_PS_PIXEL_CENTER_FRACTIONAL_COMPONENT = 0.5f;

        public const uint D3D12_RAW_UAV_SRV_BYTE_ALIGNMENT = 16;

        public const uint D3D12_RAYTRACING_AABB_BYTE_ALIGNMENT = 8;

        public const uint D3D12_RAYTRACING_ACCELERATION_STRUCTURE_BYTE_ALIGNMENT = 256;

        public const uint D3D12_RAYTRACING_INSTANCE_DESCS_BYTE_ALIGNMENT = 16;

        public const uint D3D12_RAYTRACING_MAX_ATTRIBUTE_SIZE_IN_BYTES = 32;

        public const uint D3D12_RAYTRACING_MAX_DECLARABLE_TRACE_RECURSION_DEPTH = 31;

        public const uint D3D12_RAYTRACING_MAX_GEOMETRIES_PER_BOTTOM_LEVEL_ACCELERATION_STRUCTURE = 16777216;

        public const uint D3D12_RAYTRACING_MAX_INSTANCES_PER_TOP_LEVEL_ACCELERATION_STRUCTURE = 16777216;

        public const uint D3D12_RAYTRACING_MAX_PRIMITIVES_PER_BOTTOM_LEVEL_ACCELERATION_STRUCTURE = 536870912;

        public const uint D3D12_RAYTRACING_MAX_RAY_GENERATION_SHADER_THREADS = 1073741824;

        public const uint D3D12_RAYTRACING_MAX_SHADER_RECORD_STRIDE = 4096;

        public const uint D3D12_RAYTRACING_SHADER_RECORD_BYTE_ALIGNMENT = 32;

        public const uint D3D12_RAYTRACING_SHADER_TABLE_BYTE_ALIGNMENT = 64;

        public const uint D3D12_RAYTRACING_TRANSFORM3X4_BYTE_ALIGNMENT = 16;

        public const uint D3D12_REQ_BLEND_OBJECT_COUNT_PER_DEVICE = 4096;

        public const uint D3D12_REQ_BUFFER_RESOURCE_TEXEL_COUNT_2_TO_EXP = 27;

        public const uint D3D12_REQ_CONSTANT_BUFFER_ELEMENT_COUNT = 4096;

        public const uint D3D12_REQ_DEPTH_STENCIL_OBJECT_COUNT_PER_DEVICE = 4096;

        public const uint D3D12_REQ_DRAWINDEXED_INDEX_COUNT_2_TO_EXP = 32;

        public const uint D3D12_REQ_DRAW_VERTEX_COUNT_2_TO_EXP = 32;

        public const uint D3D12_REQ_FILTERING_HW_ADDRESSABLE_RESOURCE_DIMENSION = 16384;

        public const uint D3D12_REQ_GS_INVOCATION_32BIT_OUTPUT_COMPONENT_LIMIT = 1024;

        public const uint D3D12_REQ_IMMEDIATE_CONSTANT_BUFFER_ELEMENT_COUNT = 4096;

        public const uint D3D12_REQ_MAXANISOTROPY = 16;

        public const uint D3D12_REQ_MIP_LEVELS = 15;

        public const uint D3D12_REQ_MULTI_ELEMENT_STRUCTURE_SIZE_IN_BYTES = 2048;

        public const uint D3D12_REQ_RASTERIZER_OBJECT_COUNT_PER_DEVICE = 4096;

        public const uint D3D12_REQ_RENDER_TO_BUFFER_WINDOW_WIDTH = 16384;

        public const uint D3D12_REQ_RESOURCE_SIZE_IN_MEGABYTES_EXPRESSION_A_TERM = 128;

        public const float D3D12_REQ_RESOURCE_SIZE_IN_MEGABYTES_EXPRESSION_B_TERM = 0.25f;

        public const uint D3D12_REQ_RESOURCE_SIZE_IN_MEGABYTES_EXPRESSION_C_TERM = 2048;

        public const uint D3D12_REQ_RESOURCE_VIEW_COUNT_PER_DEVICE_2_TO_EXP = 20;

        public const uint D3D12_REQ_SAMPLER_OBJECT_COUNT_PER_DEVICE = 4096;

        public const uint D3D12_REQ_SUBRESOURCES = 30720;

        public const uint D3D12_REQ_TEXTURE1D_ARRAY_AXIS_DIMENSION = 2048;

        public const uint D3D12_REQ_TEXTURE1D_U_DIMENSION = 16384;

        public const uint D3D12_REQ_TEXTURE2D_ARRAY_AXIS_DIMENSION = 2048;

        public const uint D3D12_REQ_TEXTURE2D_U_OR_V_DIMENSION = 16384;

        public const uint D3D12_REQ_TEXTURE3D_U_V_OR_W_DIMENSION = 2048;

        public const uint D3D12_REQ_TEXTURECUBE_DIMENSION = 16384;

        public const uint D3D12_RESINFO_INSTRUCTION_MISSING_COMPONENT_RETVAL = 0;

        public const uint D3D12_RESOURCE_BARRIER_ALL_SUBRESOURCES = 0xFFFFFFFF;

        public const uint D3D12_RS_SET_SHADING_RATE_COMBINER_COUNT = 2;

        public const uint D3D12_SHADER_IDENTIFIER_SIZE_IN_BYTES = 32;

        public const uint D3D12_SHADER_MAJOR_VERSION = 5;

        public const uint D3D12_SHADER_MAX_INSTANCES = 65535;

        public const uint D3D12_SHADER_MAX_INTERFACES = 253;

        public const uint D3D12_SHADER_MAX_INTERFACE_CALL_SITES = 4096;

        public const uint D3D12_SHADER_MAX_TYPES = 65535;

        public const uint D3D12_SHADER_MINOR_VERSION = 1;

        public const uint D3D12_SHIFT_INSTRUCTION_PAD_VALUE = 0;

        public const uint D3D12_SHIFT_INSTRUCTION_SHIFT_VALUE_BIT_COUNT = 5;

        public const uint D3D12_SIMULTANEOUS_RENDER_TARGET_COUNT = 8;

        public const uint D3D12_SMALL_MSAA_RESOURCE_PLACEMENT_ALIGNMENT = 65536;

        public const uint D3D12_SMALL_RESOURCE_PLACEMENT_ALIGNMENT = 4096;

        public const uint D3D12_SO_BUFFER_MAX_STRIDE_IN_BYTES = 2048;

        public const uint D3D12_SO_BUFFER_MAX_WRITE_WINDOW_IN_BYTES = 512;

        public const uint D3D12_SO_BUFFER_SLOT_COUNT = 4;

        public const uint D3D12_SO_DDI_REGISTER_INDEX_DENOTING_GAP = 0xFFFFFFFF;

        public const uint D3D12_SO_NO_RASTERIZED_STREAM = 0xFFFFFFFF;

        public const uint D3D12_SO_OUTPUT_COMPONENT_COUNT = 128;

        public const uint D3D12_SO_STREAM_COUNT = 4;

        public const uint D3D12_SPEC_DATE_DAY = 14;

        public const uint D3D12_SPEC_DATE_MONTH = 11;

        public const uint D3D12_SPEC_DATE_YEAR = 2014;

        public const float D3D12_SPEC_VERSION = 1.16f;

        public const float D3D12_SRGB_GAMMA = 2.2f;

        public const float D3D12_SRGB_TO_FLOAT_DENOMINATOR_1 = 12.92f;

        public const float D3D12_SRGB_TO_FLOAT_DENOMINATOR_2 = 1.055f;

        public const float D3D12_SRGB_TO_FLOAT_EXPONENT = 2.4f;

        public const float D3D12_SRGB_TO_FLOAT_OFFSET = 0.055f;

        public const float D3D12_SRGB_TO_FLOAT_THRESHOLD = 0.04045f;

        public const float D3D12_SRGB_TO_FLOAT_TOLERANCE_IN_ULP = 0.5f;

        public const uint D3D12_STANDARD_COMPONENT_BIT_COUNT = 32;

        public const uint D3D12_STANDARD_COMPONENT_BIT_COUNT_DOUBLED = 64;

        public const uint D3D12_STANDARD_MAXIMUM_ELEMENT_ALIGNMENT_BYTE_MULTIPLE = 4;

        public const uint D3D12_STANDARD_PIXEL_COMPONENT_COUNT = 128;

        public const uint D3D12_STANDARD_PIXEL_ELEMENT_COUNT = 32;

        public const uint D3D12_STANDARD_VECTOR_SIZE = 4;

        public const uint D3D12_STANDARD_VERTEX_ELEMENT_COUNT = 32;

        public const uint D3D12_STANDARD_VERTEX_TOTAL_COMPONENT_COUNT = 64;

        public const uint D3D12_SUBPIXEL_FRACTIONAL_BIT_COUNT = 8;

        public const uint D3D12_SUBTEXEL_FRACTIONAL_BIT_COUNT = 8;

        public const uint D3D12_SYSTEM_RESERVED_REGISTER_SPACE_VALUES_END = 0xFFFFFFFF;

        public const uint D3D12_SYSTEM_RESERVED_REGISTER_SPACE_VALUES_START = 0xFFFFFFF0;

        public const uint D3D12_TESSELLATOR_MAX_EVEN_TESSELLATION_FACTOR = 64;

        public const uint D3D12_TESSELLATOR_MAX_ISOLINE_DENSITY_TESSELLATION_FACTOR = 64;

        public const uint D3D12_TESSELLATOR_MAX_ODD_TESSELLATION_FACTOR = 63;

        public const uint D3D12_TESSELLATOR_MAX_TESSELLATION_FACTOR = 64;

        public const uint D3D12_TESSELLATOR_MIN_EVEN_TESSELLATION_FACTOR = 2;

        public const uint D3D12_TESSELLATOR_MIN_ISOLINE_DENSITY_TESSELLATION_FACTOR = 1;

        public const uint D3D12_TESSELLATOR_MIN_ODD_TESSELLATION_FACTOR = 1;

        public const uint D3D12_TEXEL_ADDRESS_RANGE_BIT_COUNT = 16;

        public const uint D3D12_TEXTURE_DATA_PITCH_ALIGNMENT = 256;

        public const uint D3D12_TEXTURE_DATA_PLACEMENT_ALIGNMENT = 512;

        public const uint D3D12_TILED_RESOURCE_TILE_SIZE_IN_BYTES = 65536;

        public const uint D3D12_TRACKED_WORKLOAD_MAX_INSTANCES = 32;

        public const uint D3D12_UAV_COUNTER_PLACEMENT_ALIGNMENT = 4096;

        public const uint D3D12_UAV_SLOT_COUNT = 64;

        public const uint D3D12_UNBOUND_MEMORY_ACCESS_RESULT = 0;

        public const uint D3D12_VIDEO_DECODE_MAX_ARGUMENTS = 10;

        public const uint D3D12_VIDEO_DECODE_MAX_HISTOGRAM_COMPONENTS = 4;

        public const uint D3D12_VIDEO_DECODE_MIN_BITSTREAM_OFFSET_ALIGNMENT = 256;

        public const uint D3D12_VIDEO_DECODE_MIN_HISTOGRAM_OFFSET_ALIGNMENT = 256;

        public const uint D3D12_VIDEO_DECODE_STATUS_MACROBLOCKS_AFFECTED_UNKNOWN = 0xFFFFFFFF;

        public const uint D3D12_VIDEO_PROCESS_MAX_FILTERS = 32;

        public const uint D3D12_VIDEO_PROCESS_STEREO_VIEWS = 2;

        public const uint D3D12_VIEWPORT_AND_SCISSORRECT_MAX_INDEX = 15;

        public const uint D3D12_VIEWPORT_AND_SCISSORRECT_OBJECT_COUNT_PER_PIPELINE = 16;

        public const uint D3D12_VIEWPORT_BOUNDS_MAX = 32767;

        public const int D3D12_VIEWPORT_BOUNDS_MIN = -32768;

        public const uint D3D12_VS_INPUT_REGISTER_COMPONENTS = 4;

        public const uint D3D12_VS_INPUT_REGISTER_COMPONENT_BIT_COUNT = 32;

        public const uint D3D12_VS_INPUT_REGISTER_COUNT = 32;

        public const uint D3D12_VS_INPUT_REGISTER_READS_PER_INST = 2;

        public const uint D3D12_VS_INPUT_REGISTER_READ_PORTS = 1;

        public const uint D3D12_VS_OUTPUT_REGISTER_COMPONENTS = 4;

        public const uint D3D12_VS_OUTPUT_REGISTER_COMPONENT_BIT_COUNT = 32;

        public const uint D3D12_VS_OUTPUT_REGISTER_COUNT = 32;

        public const uint D3D12_WHQL_CONTEXT_COUNT_FOR_RESOURCE_LIMIT = 10;

        public const uint D3D12_WHQL_DRAWINDEXED_INDEX_COUNT_2_TO_EXP = 25;

        public const uint D3D12_WHQL_DRAW_VERTEX_COUNT_2_TO_EXP = 25;

        public const uint D3D12_SHADER_COMPONENT_MAPPING_MASK = 0x7;

        public const uint D3D12_SHADER_COMPONENT_MAPPING_SHIFT = 3;

        public const uint D3D12_SHADER_COMPONENT_MAPPING_ALWAYS_SET_BIT_AVOIDING_ZEROMEM_MISTAKES = 1 << (unchecked((int)D3D12_SHADER_COMPONENT_MAPPING_SHIFT) * 4);

        public const uint D3D12_DEFAULT_SHADER_4_COMPONENT_MAPPING = 0x1688;

        public const uint D3D12_FILTER_REDUCTION_TYPE_MASK = 0x00000003;

        public const uint D3D12_FILTER_REDUCTION_TYPE_SHIFT = 7;

        public const uint D3D12_FILTER_TYPE_MASK = 0x00000003;

        public const uint D3D12_MIN_FILTER_SHIFT = 4;

        public const uint D3D12_MAG_FILTER_SHIFT = 2;

        public const uint D3D12_MIP_FILTER_SHIFT = 0;

        public const uint D3D12_ANISOTROPIC_FILTERING_BIT = 0x00000040;

        public const uint D3D12_SHADING_RATE_X_AXIS_SHIFT = 2;

        public const uint D3D12_SHADING_RATE_VALID_MASK = 3;

        public static readonly Guid D3D12ExperimentalShaderModels = new Guid(0x76F5573E, 0xF13A, 0x40F5, 0xB2, 0x97, 0x81, 0xCE, 0x9E, 0x18, 0x93, 0x3F);

        public static readonly Guid D3D12TiledResourceTier4 = new Guid(0xC9C4725F, 0xA81A, 0x4F56, 0x8C, 0x5B, 0xC5, 0x10, 0x39, 0xD6, 0x94, 0xFB);

        public static readonly Guid D3D12MetaCommand = new Guid(0xC734C97E, 0x8077, 0x48C8, 0x9F, 0xDC, 0xD9, 0xD1, 0xDD, 0x31, 0xDD, 0x77);

        public static readonly Guid D3D12ComputeOnlyDevices = new Guid(0x50F7AB08, 0x4B6D, 0x4E14, 0x89, 0xA5, 0x5D, 0x16, 0xCD, 0x27, 0x25, 0x94);

        public static readonly Guid IID_ID3D12Object = new Guid(0xC4FEC28F, 0x7966, 0x4E95, 0x9F, 0x94, 0xF4, 0x31, 0xCB, 0x56, 0xC3, 0xB8);

        public static readonly Guid IID_ID3D12DeviceChild = new Guid(0x905DB94B, 0xA00C, 0x4140, 0x9D, 0xF5, 0x2B, 0x64, 0xCA, 0x9E, 0xA3, 0x57);

        public static readonly Guid IID_ID3D12RootSignature = new Guid(0xC54A6B66, 0x72DF, 0x4EE8, 0x8B, 0xE5, 0xA9, 0x46, 0xA1, 0x42, 0x92, 0x14);

        public static readonly Guid IID_ID3D12RootSignatureDeserializer = new Guid(0x34AB647B, 0x3CC8, 0x46AC, 0x84, 0x1B, 0xC0, 0x96, 0x56, 0x45, 0xC0, 0x46);

        public static readonly Guid IID_ID3D12VersionedRootSignatureDeserializer = new Guid(0x7F91CE67, 0x090C, 0x4BB7, 0xB7, 0x8E, 0xED, 0x8F, 0xF2, 0xE3, 0x1D, 0xA0);

        public static readonly Guid IID_ID3D12Pageable = new Guid(0x63EE58FB, 0x1268, 0x4835, 0x86, 0xDA, 0xF0, 0x08, 0xCE, 0x62, 0xF0, 0xD6);

        public static readonly Guid IID_ID3D12Heap = new Guid(0x6B3B2502, 0x6E51, 0x45B3, 0x90, 0xEE, 0x98, 0x84, 0x26, 0x5E, 0x8D, 0xF3);

        public static readonly Guid IID_ID3D12Resource = new Guid(0x696442BE, 0xA72E, 0x4059, 0xBC, 0x79, 0x5B, 0x5C, 0x98, 0x04, 0x0F, 0xAD);

        public static readonly Guid IID_ID3D12CommandAllocator = new Guid(0x6102DEE4, 0xAF59, 0x4B09, 0xB9, 0x99, 0xB4, 0x4D, 0x73, 0xF0, 0x9B, 0x24);

        public static readonly Guid IID_ID3D12Fence = new Guid(0x0A753DCF, 0xC4D8, 0x4B91, 0xAD, 0xF6, 0xBE, 0x5A, 0x60, 0xD9, 0x5A, 0x76);

        public static readonly Guid IID_ID3D12Fence1 = new Guid(0x433685FE, 0xE22B, 0x4CA0, 0xA8, 0xDB, 0xB5, 0xB4, 0xF4, 0xDD, 0x0E, 0x4A);

        public static readonly Guid IID_ID3D12PipelineState = new Guid(0x765A30F3, 0xF624, 0x4C6F, 0xA8, 0x28, 0xAC, 0xE9, 0x48, 0x62, 0x24, 0x45);

        public static readonly Guid IID_ID3D12DescriptorHeap = new Guid(0x8EFB471D, 0x616C, 0x4F49, 0x90, 0xF7, 0x12, 0x7B, 0xB7, 0x63, 0xFA, 0x51);

        public static readonly Guid IID_ID3D12QueryHeap = new Guid(0x0D9658AE, 0xED45, 0x469E, 0xA6, 0x1D, 0x97, 0x0E, 0xC5, 0x83, 0xCA, 0xB4);

        public static readonly Guid IID_ID3D12CommandSignature = new Guid(0xC36A797C, 0xEC80, 0x4F0A, 0x89, 0x85, 0xA7, 0xB2, 0x47, 0x50, 0x82, 0xD1);

        public static readonly Guid IID_ID3D12CommandList = new Guid(0x7116D91C, 0xE7E4, 0x47CE, 0xB8, 0xC6, 0xEC, 0x81, 0x68, 0xF4, 0x37, 0xE5);

        public static readonly Guid IID_ID3D12GraphicsCommandList = new Guid(0x5B160D0F, 0xAC1B, 0x4185, 0x8B, 0xA8, 0xB3, 0xAE, 0x42, 0xA5, 0xA4, 0x55);

        public static readonly Guid IID_ID3D12GraphicsCommandList1 = new Guid(0x553103FB, 0x1FE7, 0x4557, 0xBB, 0x38, 0x94, 0x6D, 0x7D, 0x0E, 0x7C, 0xA7);

        public static readonly Guid IID_ID3D12GraphicsCommandList2 = new Guid(0x38C3E585, 0xFF17, 0x412C, 0x91, 0x50, 0x4F, 0xC6, 0xF9, 0xD7, 0x2A, 0x28);

        public static readonly Guid IID_ID3D12CommandQueue = new Guid(0x0EC870A6, 0x5D7E, 0x4C22, 0x8C, 0xFC, 0x5B, 0xAA, 0xE0, 0x76, 0x16, 0xED);

        public static readonly Guid IID_ID3D12Device = new Guid(0x189819F1, 0x1DB6, 0x4B57, 0xBE, 0x54, 0x18, 0x21, 0x33, 0x9B, 0x85, 0xF7);

        public static readonly Guid IID_ID3D12PipelineLibrary = new Guid(0xC64226A8, 0x9201, 0x46AF, 0xB4, 0xCC, 0x53, 0xFB, 0x9F, 0xF7, 0x41, 0x4F);

        public static readonly Guid IID_ID3D12PipelineLibrary1 = new Guid(0x80EABF42, 0x2568, 0x4E5E, 0xBD, 0x82, 0xC3, 0x7F, 0x86, 0x96, 0x1D, 0xC3);

        public static readonly Guid IID_ID3D12Device1 = new Guid(0x77ACCE80, 0x638E, 0x4E65, 0x88, 0x95, 0xC1, 0xF2, 0x33, 0x86, 0x86, 0x3E);

        public static readonly Guid IID_ID3D12Device2 = new Guid(0x30BAA41E, 0xB15B, 0x475C, 0xA0, 0xBB, 0x1A, 0xF5, 0xC5, 0xB6, 0x43, 0x28);

        public static readonly Guid IID_ID3D12Device3 = new Guid(0x81DADC15, 0x2BAD, 0x4392, 0x93, 0xC5, 0x10, 0x13, 0x45, 0xC4, 0xAA, 0x98);

        public static readonly Guid IID_ID3D12ProtectedSession = new Guid(0xA1533D18, 0x0AC1, 0x4084, 0x85, 0xB9, 0x89, 0xA9, 0x61, 0x16, 0x80, 0x6B);

        public static readonly Guid IID_ID3D12ProtectedResourceSession = new Guid(0x6CD696F4, 0xF289, 0x40CC, 0x80, 0x91, 0x5A, 0x6C, 0x0A, 0x09, 0x9C, 0x3D);

        public static readonly Guid IID_ID3D12Device4 = new Guid(0xE865DF17, 0xA9EE, 0x46F9, 0xA4, 0x63, 0x30, 0x98, 0x31, 0x5A, 0xA2, 0xE5);

        public static readonly Guid IID_ID3D12LifetimeOwner = new Guid(0xE667AF9F, 0xCD56, 0x4F46, 0x83, 0xCE, 0x03, 0x2E, 0x59, 0x5D, 0x70, 0xA8);

        public static readonly Guid IID_ID3D12SwapChainAssistant = new Guid(0xF1DF64B6, 0x57FD, 0x49CD, 0x88, 0x07, 0xC0, 0xEB, 0x88, 0xB4, 0x5C, 0x8F);

        public static readonly Guid IID_ID3D12LifetimeTracker = new Guid(0x3FD03D36, 0x4EB1, 0x424A, 0xA5, 0x82, 0x49, 0x4E, 0xCB, 0x8B, 0xA8, 0x13);

        public static readonly Guid IID_ID3D12StateObject = new Guid(0x47016943, 0xFCA8, 0x4594, 0x93, 0xEA, 0xAF, 0x25, 0x8B, 0x55, 0x34, 0x6D);

        public static readonly Guid IID_ID3D12StateObjectProperties = new Guid(0xDE5FA827, 0x9BF9, 0x4F26, 0x89, 0xFF, 0xD7, 0xF5, 0x6F, 0xDE, 0x38, 0x60);

        public static readonly Guid IID_ID3D12Device5 = new Guid(0x8B4F173B, 0x2FEA, 0x4B80, 0x8F, 0x58, 0x43, 0x07, 0x19, 0x1A, 0xB9, 0x5D);

        public static readonly Guid IID_ID3D12DeviceRemovedExtendedDataSettings = new Guid(0x82BC481C, 0x6B9B, 0x4030, 0xAE, 0xDB, 0x7E, 0xE3, 0xD1, 0xDF, 0x1E, 0x63);

        public static readonly Guid IID_ID3D12DeviceRemovedExtendedData = new Guid(0x98931D33, 0x5AE8, 0x4791, 0xAA, 0x3C, 0x1A, 0x73, 0xA2, 0x93, 0x4E, 0x71);

        public static readonly Guid IID_ID3D12Device6 = new Guid(0xC70B221B, 0x40E4, 0x4A17, 0x89, 0xAF, 0x02, 0x5A, 0x07, 0x27, 0xA6, 0xDC);

        public static readonly Guid IID_ID3D12Resource1 = new Guid(0x9D5E227A, 0x4430, 0x4161, 0x88, 0xB3, 0x3E, 0xCA, 0x6B, 0xB1, 0x6E, 0x19);

        public static readonly Guid IID_ID3D12Heap1 = new Guid(0x572F7389, 0x2168, 0x49E3, 0x96, 0x93, 0xD6, 0xDF, 0x58, 0x71, 0xBF, 0x6D);

        public static readonly Guid IID_ID3D12GraphicsCommandList3 = new Guid(0x6FDA83A7, 0xB84C, 0x4E38, 0x9A, 0xC8, 0xC7, 0xBD, 0x22, 0x01, 0x6B, 0x3D);

        public static readonly Guid IID_ID3D12MetaCommand = new Guid(0xDBB84C27, 0x36CE, 0x4FC9, 0xB8, 0x01, 0xF0, 0x48, 0xC4, 0x6A, 0xC5, 0x70);

        public static readonly Guid IID_ID3D12GraphicsCommandList4 = new Guid(0x8754318E, 0xD3A9, 0x4541, 0x98, 0xCF, 0x64, 0x5B, 0x50, 0xDC, 0x48, 0x74);

        public static readonly Guid IID_ID3D12Tools = new Guid(0x7071E1F0, 0xE84B, 0x4B33, 0x97, 0x4F, 0x12, 0xFA, 0x49, 0xDE, 0x65, 0xC5);

        public static readonly Guid IID_ID3D12GraphicsCommandList5 = new Guid(0x55050859, 0x4024, 0x474C, 0x87, 0xF5, 0x64, 0x72, 0xEA, 0xEE, 0x44, 0xEA);

        public static uint D3D12_ENCODE_SHADER_4_COMPONENT_MAPPING(D3D12_SHADER_COMPONENT_MAPPING Src0, D3D12_SHADER_COMPONENT_MAPPING Src1, D3D12_SHADER_COMPONENT_MAPPING Src2, D3D12_SHADER_COMPONENT_MAPPING Src3)
        {
            return ((uint)Src0 & D3D12_SHADER_COMPONENT_MAPPING_MASK)
                | (((uint)Src1 & D3D12_SHADER_COMPONENT_MAPPING_MASK) << unchecked((int)D3D12_SHADER_COMPONENT_MAPPING_SHIFT))
                | (((uint)Src2 & D3D12_SHADER_COMPONENT_MAPPING_MASK) << (unchecked((int)D3D12_SHADER_COMPONENT_MAPPING_SHIFT) * 2))
                | (((uint)Src3 & D3D12_SHADER_COMPONENT_MAPPING_MASK) << (unchecked((int)D3D12_SHADER_COMPONENT_MAPPING_SHIFT) * 3))
                | D3D12_SHADER_COMPONENT_MAPPING_ALWAYS_SET_BIT_AVOIDING_ZEROMEM_MISTAKES;
        }

        public static D3D12_SHADER_COMPONENT_MAPPING D3D12_DECODE_SHADER_4_COMPONENT_MAPPING(int ComponentToExtract, uint Mapping) => (D3D12_SHADER_COMPONENT_MAPPING)((Mapping >> (unchecked((int)D3D12_SHADER_COMPONENT_MAPPING_SHIFT) * ComponentToExtract)) & D3D12_SHADER_COMPONENT_MAPPING_MASK);

        public static D3D12_FILTER D3D12_ENCODE_BASIC_FILTER(D3D12_FILTER_TYPE min, D3D12_FILTER_TYPE mag, D3D12_FILTER_TYPE mip, D3D12_FILTER_REDUCTION_TYPE reduction)
        {
            return (D3D12_FILTER)((((uint)min & D3D12_FILTER_TYPE_MASK) << unchecked((int)D3D12_MIN_FILTER_SHIFT))
                                | (((uint)mag & D3D12_FILTER_TYPE_MASK) << unchecked((int)D3D12_MAG_FILTER_SHIFT))
                                | (((uint)mip & D3D12_FILTER_TYPE_MASK) << unchecked((int)D3D12_MIP_FILTER_SHIFT))
                                | (((uint)reduction & D3D12_FILTER_REDUCTION_TYPE_MASK) << unchecked((int)D3D12_FILTER_REDUCTION_TYPE_SHIFT)));
        }

        public static D3D12_FILTER D3D12_ENCODE_ANISOTROPIC_FILTER(D3D12_FILTER_REDUCTION_TYPE reduction) => (D3D12_FILTER)(D3D12_ANISOTROPIC_FILTERING_BIT | (uint)D3D12_ENCODE_BASIC_FILTER(D3D12_FILTER_TYPE_LINEAR, D3D12_FILTER_TYPE_LINEAR, D3D12_FILTER_TYPE_LINEAR, reduction));

        public static D3D12_FILTER_TYPE D3D12_DECODE_MIN_FILTER(D3D12_FILTER D3D12Filter) => (D3D12_FILTER_TYPE)(((uint)D3D12Filter >> unchecked((int)D3D12_MIN_FILTER_SHIFT)) & D3D12_FILTER_TYPE_MASK);

        public static D3D12_FILTER_TYPE D3D12_DECODE_MAG_FILTER(D3D12_FILTER D3D12Filter) => (D3D12_FILTER_TYPE)(((uint)D3D12Filter >> unchecked((int)D3D12_MAG_FILTER_SHIFT)) & D3D12_FILTER_TYPE_MASK);

        public static D3D12_FILTER_TYPE D3D12_DECODE_MIP_FILTER(D3D12_FILTER D3D12Filter) => (D3D12_FILTER_TYPE)(((uint)D3D12Filter >> unchecked((int)D3D12_MIP_FILTER_SHIFT)) & D3D12_FILTER_TYPE_MASK);

        public static D3D12_FILTER_REDUCTION_TYPE D3D12_DECODE_FILTER_REDUCTION(D3D12_FILTER D3D12Filter) => (D3D12_FILTER_REDUCTION_TYPE)(((uint)D3D12Filter >> unchecked((int)D3D12_FILTER_REDUCTION_TYPE_SHIFT)) & D3D12_FILTER_REDUCTION_TYPE_MASK);

        public static bool D3D12_DECODE_IS_COMPARISON_FILTER(D3D12_FILTER D3D12Filter) => D3D12_DECODE_FILTER_REDUCTION(D3D12Filter) == D3D12_FILTER_REDUCTION_TYPE_COMPARISON;

        public static bool D3D12_DECODE_IS_ANISOTROPIC_FILTER(D3D12_FILTER D3D12Filter)
        {
            return (((uint)D3D12Filter & D3D12_ANISOTROPIC_FILTERING_BIT) != 0)
                && (D3D12_FILTER_TYPE_LINEAR == D3D12_DECODE_MIN_FILTER(D3D12Filter))
                && (D3D12_FILTER_TYPE_LINEAR == D3D12_DECODE_MAG_FILTER(D3D12Filter))
                && (D3D12_FILTER_TYPE_LINEAR == D3D12_DECODE_MIP_FILTER(D3D12Filter));
        }

        public static uint D3D12_MAKE_COARSE_SHADING_RATE(uint x, uint y) => (x << unchecked((int)D3D12_SHADING_RATE_X_AXIS_SHIFT)) | y;

        public static uint D3D12_GET_COARSE_SHADING_RATE_X_AXIS(uint x) => (x >> unchecked((int)D3D12_SHADING_RATE_X_AXIS_SHIFT)) & D3D12_SHADING_RATE_VALID_MASK;

        public static uint D3D12_GET_COARSE_SHADING_RATE_Y_AXIS(uint y) => y & D3D12_SHADING_RATE_VALID_MASK;
    }
}
