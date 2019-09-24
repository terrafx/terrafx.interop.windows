// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d3d12.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.D3D12_FEATURE;
using static TerraFX.Interop.D3D12_FILTER_TYPE;
using static TerraFX.Interop.D3D12_FILTER_REDUCTION_TYPE;
using static TerraFX.Interop.D3D12_RESOURCE_DIMENSION;
using static TerraFX.Interop.D3D12_TEXTURE_LAYOUT;
using static TerraFX.Interop.Windows;

namespace TerraFX.Interop
{
    public static unsafe partial class D3D12
    {
        private const string DllName = nameof(D3D12);

        public const int D3D12_ANISOTROPIC_FILTERING_BIT = 0x40;

        public const int D3D12_DEFAULT_SHADER_4_COMPONENT_MAPPING = 0x1688;

        public static readonly Guid D3D12ExperimentalShaderModels = new Guid(0x76F5573E, 0xF13A, 0x40F5, 0xB2, 0x97, 0x81, 0xCE, 0x9E, 0x18, 0x93, 0x3F);

        public const uint D3D12_16BIT_INDEX_STRIP_CUT_VALUE = 0xffff;

        public const uint D3D12_32BIT_INDEX_STRIP_CUT_VALUE = 0xffffffff;

        public const uint D3D12_8BIT_INDEX_STRIP_CUT_VALUE = 0xff;

        public const uint D3D12_APPEND_ALIGNED_ELEMENT = 0xffffffff;

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

        public const uint D3D12_DEFAULT_SAMPLE_MASK = 0xffffffff;

        public const uint D3D12_DEFAULT_SCISSOR_ENDX = 0;

        public const uint D3D12_DEFAULT_SCISSOR_ENDY = 0;

        public const uint D3D12_DEFAULT_SCISSOR_STARTX = 0;

        public const uint D3D12_DEFAULT_SCISSOR_STARTY = 0;

        public const float D3D12_DEFAULT_SLOPE_SCALED_DEPTH_BIAS = 0.0f;

        public const uint D3D12_DEFAULT_STENCIL_READ_MASK = 0xff;

        public const uint D3D12_DEFAULT_STENCIL_REFERENCE = 0;

        public const uint D3D12_DEFAULT_STENCIL_WRITE_MASK = 0xff;

        public const uint D3D12_DEFAULT_VIEWPORT_AND_SCISSORRECT_INDEX = 0;

        public const uint D3D12_DEFAULT_VIEWPORT_HEIGHT = 0;

        public const float D3D12_DEFAULT_VIEWPORT_MAX_DEPTH = 0.0f;

        public const float D3D12_DEFAULT_VIEWPORT_MIN_DEPTH = 0.0f;

        public const uint D3D12_DEFAULT_VIEWPORT_TOPLEFTX = 0;

        public const uint D3D12_DEFAULT_VIEWPORT_TOPLEFTY = 0;

        public const uint D3D12_DEFAULT_VIEWPORT_WIDTH = 0;

        public const uint D3D12_DESCRIPTOR_RANGE_OFFSET_APPEND = 0xffffffff;

        public const uint D3D12_DRIVER_RESERVED_REGISTER_SPACE_VALUES_END = 0xfffffff7;

        public const uint D3D12_DRIVER_RESERVED_REGISTER_SPACE_VALUES_START = 0xfffffff0;

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

        public const uint D3D12_HS_FORK_PHASE_INSTANCE_COUNT_UPPER_BOUND = 0xffffffff;

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

        public const uint D3D12_HS_JOIN_PHASE_INSTANCE_COUNT_UPPER_BOUND = 0xffffffff;

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

        public const uint D3D12_INTEGER_DIVIDE_BY_ZERO_QUOTIENT = 0xffffffff;

        public const uint D3D12_INTEGER_DIVIDE_BY_ZERO_REMAINDER = 0xffffffff;

        public const uint D3D12_KEEP_RENDER_TARGETS_AND_DEPTH_STENCIL = 0xffffffff;

        public const uint D3D12_KEEP_UNORDERED_ACCESS_VIEWS = 0xffffffff;

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

        public const uint D3D12_OS_RESERVED_REGISTER_SPACE_VALUES_END = 0xffffffff;

        public const uint D3D12_OS_RESERVED_REGISTER_SPACE_VALUES_START = 0xfffffff8;

        public const uint D3D12_PACKED_TILE = 0xffffffff;

        public const uint D3D12_PIXEL_ADDRESS_RANGE_BIT_COUNT = 15;

        public const uint D3D12_PRE_SCISSOR_PIXEL_ADDRESS_RANGE_BIT_COUNT = 16;

        public const uint D3D12_PS_CS_UAV_REGISTER_COMPONENTS = 1;

        public const uint D3D12_PS_CS_UAV_REGISTER_COUNT = 8;

        public const uint D3D12_PS_CS_UAV_REGISTER_READS_PER_INST = 1;

        public const uint D3D12_PS_CS_UAV_REGISTER_READ_PORTS = 1;

        public const uint D3D12_PS_FRONTFACING_DEFAULT_VALUE = 0xffffffff;

        public const uint D3D12_PS_FRONTFACING_FALSE_VALUE = 0;

        public const uint D3D12_PS_FRONTFACING_TRUE_VALUE = 0xffffffff;

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

        public const uint D3D12_RESOURCE_BARRIER_ALL_SUBRESOURCES = 0xffffffff;

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

        public const uint D3D12_SO_DDI_REGISTER_INDEX_DENOTING_GAP = 0xffffffff;

        public const uint D3D12_SO_NO_RASTERIZED_STREAM = 0xffffffff;

        public const uint D3D12_SO_OUTPUT_COMPONENT_COUNT = 128;

        public const uint D3D12_SO_STREAM_COUNT = 4;

        public const uint D3D12_SPEC_DATE_DAY = 14;

        public const uint D3D12_SPEC_DATE_MONTH = 11;

        public const uint D3D12_SPEC_DATE_YEAR = 2014;

        public const double D3D12_SPEC_VERSION = 1.16;

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

        public const uint D3D12_SYSTEM_RESERVED_REGISTER_SPACE_VALUES_END = 0xffffffff;

        public const uint D3D12_SYSTEM_RESERVED_REGISTER_SPACE_VALUES_START = 0xfffffff0;

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

        public const uint D3D12_UAV_COUNTER_PLACEMENT_ALIGNMENT = 4096;

        public const uint D3D12_UAV_SLOT_COUNT = 64;

        public const uint D3D12_UNBOUND_MEMORY_ACCESS_RESULT = 0;

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

        public const int D3D12_SHADER_COMPONENT_MAPPING_MASK = 0x7;

        public const int D3D12_SHADER_COMPONENT_MAPPING_SHIFT = 3;

        public const int D3D12_SHADER_COMPONENT_MAPPING_ALWAYS_SET_BIT_AVOIDING_ZEROMEM_MISTAKES = 1 << (D3D12_SHADER_COMPONENT_MAPPING_SHIFT * 4);

        public const int D3D12_FILTER_REDUCTION_TYPE_MASK = 0x3;

        public const int D3D12_FILTER_REDUCTION_TYPE_SHIFT = 7;

        public const int D3D12_FILTER_TYPE_MASK = 0x3;

        public const int D3D12_MIN_FILTER_SHIFT = 4;

        public const int D3D12_MAG_FILTER_SHIFT = 2;

        public const int D3D12_MIP_FILTER_SHIFT = 0;

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

        public static readonly Guid IID_ID3D12PipelineState = new Guid(0x765A30F3, 0xF624, 0x4C6F, 0xA8, 0x28, 0xAC, 0xE9, 0x48, 0x62, 0x24, 0x45);

        public static readonly Guid IID_ID3D12DescriptorHeap = new Guid(0x8EFB471D, 0x616C, 0x4F49, 0x90, 0xF7, 0x12, 0x7B, 0xB7, 0x63, 0xFA, 0x51);

        public static readonly Guid IID_ID3D12QueryHeap = new Guid(0x0D9658AE, 0xED45, 0x469E, 0xA6, 0x1D, 0x97, 0x0E, 0xC5, 0x83, 0xCA, 0xB4);

        public static readonly Guid IID_ID3D12CommandSignature = new Guid(0xC36A797C, 0xEC80, 0x4F0A, 0x89, 0x85, 0xA7, 0xB2, 0x47, 0x50, 0x82, 0xD1);

        public static readonly Guid IID_ID3D12CommandList = new Guid(0x7116D91C, 0xE7E4, 0x47CE, 0xB8, 0xC6, 0xEC, 0x81, 0x68, 0xF4, 0x37, 0xE5);

        public static readonly Guid IID_ID3D12GraphicsCommandList = new Guid(0x5B160D0F, 0xAC1B, 0x4185, 0x8B, 0xA8, 0xB3, 0xAE, 0x42, 0xA5, 0xA4, 0x55);

        public static readonly Guid IID_ID3D12GraphicsCommandList1 = new Guid(0x553103FB, 0x1FE7, 0x4557, 0xBB, 0x38, 0x94, 0x6D, 0x7D, 0x0E, 0x7C, 0xA7);

        public static readonly Guid IID_ID3D12CommandQueue = new Guid(0x0EC870A6, 0x5D7E, 0x4C22, 0x8C, 0xFC, 0x5B, 0xAA, 0xE0, 0x76, 0x16, 0xED);

        public static readonly Guid IID_ID3D12Device = new Guid(0x189819F1, 0x1DB6, 0x4B57, 0xBE, 0x54, 0x18, 0x21, 0x33, 0x9B, 0x85, 0xF7);

        public static readonly Guid IID_ID3D12PipelineLibrary = new Guid(0xC64226A8, 0x9201, 0x46AF, 0xB4, 0xCC, 0x53, 0xFB, 0x9F, 0xF7, 0x41, 0x4F);

        public static readonly Guid IID_ID3D12PipelineLibrary1 = new Guid(0x80EABF42, 0x2568, 0x4E5E, 0xBD, 0x82, 0xC3, 0x7F, 0x86, 0x96, 0x1D, 0xC3);

        public static readonly Guid IID_ID3D12Device1 = new Guid(0x77ACCE80, 0x638E, 0x4E65, 0x88, 0x95, 0xC1, 0xF2, 0x33, 0x86, 0x86, 0x3E);

        public static readonly Guid IID_ID3D12Device2 = new Guid(0x30BAA41E, 0xB15B, 0x475C, 0xA0, 0xBB, 0x1A, 0xF5, 0xC5, 0xB6, 0x43, 0x28);

        public static readonly Guid IID_ID3D12Tools = new Guid(0x7071E1F0, 0xE84B, 0x4B33, 0x97, 0x4F, 0x12, 0xFA, 0x49, 0xDE, 0x65, 0xC5);

        [DllImport(DllName, BestFitMapping = false, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Unicode, EntryPoint = "D3D12SerializeRootSignature", ExactSpelling = true, PreserveSig = true, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public static extern int D3D12SerializeRootSignature(
            [In] D3D12_ROOT_SIGNATURE_DESC* pRootSignature,
            [In] D3D_ROOT_SIGNATURE_VERSION Version,
            [Out] ID3DBlob** ppBlob,
            [Out] ID3DBlob** ppErrorBlob = null
        );

        [DllImport(DllName, BestFitMapping = false, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Unicode, EntryPoint = "D3D12CreateRootSignatureDeserializer", ExactSpelling = true, PreserveSig = true, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public static extern int D3D12CreateRootSignatureDeserializer(
            [In, NativeTypeName("LPCVOID")] void* pSrcData,
            [In, NativeTypeName("SIZE_T")] UIntPtr SrcDataSizeInBytes,
            [In, NativeTypeName("REFIID")] Guid* pRootSignatureDeserializerInterface,
            [Out] void** ppRootSignatureDeserializer
        );

        [DllImport(DllName, BestFitMapping = false, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Unicode, EntryPoint = "D3D12CreateVersionedRootSignatureDeserializer", ExactSpelling = true, PreserveSig = true, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public static extern int D3D12SerializeVersionedRootSignature(
            [In] D3D12_VERSIONED_ROOT_SIGNATURE_DESC* pRootSignature,
            [Out] ID3DBlob** ppBlob,
            [Out] ID3DBlob** ppErrorBlob = null
        );

        [DllImport(DllName, BestFitMapping = false, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Unicode, EntryPoint = "D3D12CreateVersionedRootSignatureDeserializer", ExactSpelling = true, PreserveSig = true, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public static extern int D3D12CreateVersionedRootSignatureDeserializer(
            [In, NativeTypeName("LPCVOID")] void* pSrcData,
            [In, NativeTypeName("SIZE_T")] UIntPtr SrcDataSizeInBytes,
            [In, NativeTypeName("REFIID")] Guid* pRootSignatureDeserializerInterface,
            [Out] void** ppRootSignatureDeserializer
        );

        [DllImport(DllName, BestFitMapping = false, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Unicode, EntryPoint = "D3D12CreateDevice", ExactSpelling = true, PreserveSig = true, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public static extern int D3D12CreateDevice(
            [In, Optional] IUnknown* pAdapter,
            [In] D3D_FEATURE_LEVEL MinimumFeatureLevel,
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppDevice = null
        );

        [DllImport(DllName, BestFitMapping = false, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Unicode, EntryPoint = "D3D12GetDebugInterface", ExactSpelling = true, PreserveSig = true, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public static extern int D3D12GetDebugInterface(
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvDebug = null
        );

        [DllImport(DllName, BestFitMapping = false, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Unicode, EntryPoint = "D3D12EnableExperimentalFeatures", ExactSpelling = true, PreserveSig = true, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public static extern int D3D12EnableExperimentalFeatures(
            [In, NativeTypeName("UINT")] uint NumFeatures,
            [In, NativeTypeName("IID[]")] Guid* pIIDs,
            [In] void* pConfigurationStructs = null,
            [In, NativeTypeName("UINT[]")] uint* pConfigurationStructSizes = null
        );

        public static int D3D12_ENCODE_SHADER_4_COMPONENT_MAPPING(D3D12_SHADER_COMPONENT_MAPPING Src0, D3D12_SHADER_COMPONENT_MAPPING Src1, D3D12_SHADER_COMPONENT_MAPPING Src2, D3D12_SHADER_COMPONENT_MAPPING Src3)
        {
            return ((int)Src0 & D3D12_SHADER_COMPONENT_MAPPING_MASK)
                 | (((int)Src1 & D3D12_SHADER_COMPONENT_MAPPING_MASK) << D3D12_SHADER_COMPONENT_MAPPING_SHIFT)
                 | (((int)Src2 & D3D12_SHADER_COMPONENT_MAPPING_MASK) << (D3D12_SHADER_COMPONENT_MAPPING_SHIFT * 2))
                 | (((int)Src3 & D3D12_SHADER_COMPONENT_MAPPING_MASK) << (D3D12_SHADER_COMPONENT_MAPPING_SHIFT * 3))
                 | D3D12_SHADER_COMPONENT_MAPPING_ALWAYS_SET_BIT_AVOIDING_ZEROMEM_MISTAKES;
        }

        public static D3D12_SHADER_COMPONENT_MAPPING D3D12_DECODE_SHADER_4_COMPONENT_MAPPING(int ComponentToExtract, int Mapping)
        {
            return (D3D12_SHADER_COMPONENT_MAPPING)((Mapping >> (D3D12_SHADER_COMPONENT_MAPPING_SHIFT * ComponentToExtract)) & D3D12_SHADER_COMPONENT_MAPPING_MASK);
        }

        public static D3D12_FILTER D3D12_ENCODE_BASIC_FILTER(D3D12_FILTER_TYPE min, D3D12_FILTER_TYPE mag, D3D12_FILTER_TYPE mip, D3D12_FILTER_REDUCTION_TYPE reduction)
        {
            return (D3D12_FILTER)((((int)min & D3D12_FILTER_TYPE_MASK) << D3D12_MIN_FILTER_SHIFT)
                                | (((int)mag & D3D12_FILTER_TYPE_MASK) << D3D12_MAG_FILTER_SHIFT)
                                | (((int)mip & D3D12_FILTER_TYPE_MASK) << D3D12_MIP_FILTER_SHIFT)
                                | (((int)reduction & D3D12_FILTER_REDUCTION_TYPE_MASK) << D3D12_FILTER_REDUCTION_TYPE_SHIFT));
        }

        public static D3D12_FILTER D3D12_ENCODE_ANISOTROPIC_FILTER(D3D12_FILTER_REDUCTION_TYPE reduction)
        {
            return (D3D12_FILTER)(D3D12_ANISOTROPIC_FILTERING_BIT
                                | (int)D3D12_ENCODE_BASIC_FILTER(D3D12_FILTER_TYPE_LINEAR, D3D12_FILTER_TYPE_LINEAR, D3D12_FILTER_TYPE_LINEAR, reduction));
        }

        public static D3D12_FILTER_TYPE D3D12_DECODE_MIN_FILTER(D3D12_FILTER D3D12Filter)
        {
            return (D3D12_FILTER_TYPE)(((int)D3D12Filter >> D3D12_MIN_FILTER_SHIFT) & D3D12_FILTER_TYPE_MASK);
        }

        public static D3D12_FILTER_TYPE D3D12_DECODE_MAG_FILTER(D3D12_FILTER D3D12Filter)
        {
            return (D3D12_FILTER_TYPE)(((int)D3D12Filter >> D3D12_MAG_FILTER_SHIFT) & D3D12_FILTER_TYPE_MASK);
        }

        public static D3D12_FILTER_TYPE D3D12_DECODE_MIP_FILTER(D3D12_FILTER D3D12Filter)
        {
            return (D3D12_FILTER_TYPE)(((int)D3D12Filter >> D3D12_MIP_FILTER_SHIFT) & D3D12_FILTER_TYPE_MASK);
        }

        public static D3D12_FILTER_REDUCTION_TYPE D3D12_DECODE_FILTER_REDUCTION(D3D12_FILTER D3D12Filter)
        {
            return (D3D12_FILTER_REDUCTION_TYPE)(((int)D3D12Filter >> D3D12_FILTER_REDUCTION_TYPE_SHIFT) & D3D12_FILTER_REDUCTION_TYPE_MASK);
        }

        public static bool D3D12_DECODE_IS_COMPARISON_FILTER(D3D12_FILTER D3D12Filter)
        {
            return D3D12_DECODE_FILTER_REDUCTION(D3D12Filter) == D3D12_FILTER_REDUCTION_TYPE_COMPARISON;
        }
        public static bool D3D12_DECODE_IS_ANISOTROPIC_FILTER(D3D12_FILTER D3D12Filter)
        {
            return (((int)D3D12Filter & D3D12_ANISOTROPIC_FILTERING_BIT) != 0)
                && (D3D12_FILTER_TYPE_LINEAR == D3D12_DECODE_MIN_FILTER(D3D12Filter))
                && (D3D12_FILTER_TYPE_LINEAR == D3D12_DECODE_MAG_FILTER(D3D12Filter))
                && (D3D12_FILTER_TYPE_LINEAR == D3D12_DECODE_MIP_FILTER(D3D12Filter));
        }

        public static uint D3D12CalcSubresource(uint MipSlice, uint ArraySlice, uint PlaneSlice, uint MipLevels, uint ArraySize)
        {
            return MipSlice + (ArraySlice * MipLevels) + (PlaneSlice * MipLevels * ArraySize);
        }

        public static void D3D12DecomposeSubresource(uint Subresource, uint MipLevels, uint ArraySize, uint* MipSlice, uint* ArraySlice, uint* PlaneSlice)
        {
            *MipSlice = Subresource % MipLevels;
            *ArraySlice = Subresource / MipLevels % ArraySize;
            *PlaneSlice = Subresource / (MipLevels * ArraySize);
        }

        public static byte D3D12GetFormatPlaneCount(ID3D12Device* pDevice, DXGI_FORMAT Format)
        {
            var formatInfo = new D3D12_FEATURE_DATA_FORMAT_INFO() { Format = Format };
            if (FAILED(pDevice->CheckFeatureSupport(D3D12_FEATURE_FORMAT_INFO, &formatInfo, (uint)sizeof(D3D12_FEATURE_DATA_FORMAT_INFO))))
            {
                return 0;
            }
            return formatInfo.PlaneCount;
        }

        //------------------------------------------------------------------------------------------------
        // Row-by-row memcpy
        public static void MemcpySubresource(D3D12_MEMCPY_DEST* pDest, D3D12_SUBRESOURCE_DATA* pSrc, UIntPtr RowSizeInBytes, uint NumRows, uint NumSlices)
        {
            for (var z = 0u; z < NumSlices; ++z)
            {
                byte* pDestSlice = (byte*)pDest->pData;
                byte* pSrcSlice = (byte*)pSrc->pData;
                if (IntPtr.Size == 4)
                {
                    pDestSlice += (uint)pDest->SlicePitch * z;
                    pSrcSlice += (uint)pSrc->SlicePitch * z;
                }
                else
                {
                    pDestSlice += (ulong)pDest->SlicePitch * z;
                    pSrcSlice += (ulong)pSrc->SlicePitch * z;
                }
                for (var y = 0u; y < NumRows; ++y)
                {
                    byte* pTempDest = pDestSlice;
                    byte* pTempSrc = pSrcSlice;

                    if (IntPtr.Size == 4)
                    {
                        pTempDest += (uint)pDest->RowPitch * y;
                        pTempSrc += (uint)pSrc->RowPitch * y;
                    }
                    else
                    {
                        pTempDest += (ulong)pDest->RowPitch * y;
                        pTempSrc += (ulong)pSrc->RowPitch * y;
                    }

                    Buffer.MemoryCopy(pTempSrc, pTempDest, (long)RowSizeInBytes, (long)RowSizeInBytes);
                }
            }
        }

        //------------------------------------------------------------------------------------------------
        // Returns required size of a buffer to be used for data upload
        public static ulong GetRequiredIntermediateSize(ID3D12Resource* pDestinationResource, uint FirstSubresource, uint NumSubresources)
        {
            D3D12_RESOURCE_DESC Desc = pDestinationResource->GetDesc();
            ulong RequiredSize = 0;
    
            ID3D12Device* pDevice;
            Guid iid = IID_ID3D12Device;
            pDestinationResource->GetDevice(&iid, (void**)&pDevice);
            pDevice->GetCopyableFootprints(&Desc, FirstSubresource, NumSubresources, 0, null, null, null, &RequiredSize);
            pDevice->Release();
    
            return RequiredSize;
        }

        //------------------------------------------------------------------------------------------------
        // All arrays must be populated (e.g. by calling GetCopyableFootprints)
        public static ulong UpdateSubresources(ID3D12GraphicsCommandList* pCmdList, ID3D12Resource* pDestinationResource, ID3D12Resource* pIntermediate, uint FirstSubresource, uint NumSubresources, ulong RequiredSize, D3D12_PLACED_SUBRESOURCE_FOOTPRINT* pLayouts, uint* pNumRows, ulong* pRowSizesInBytes, D3D12_SUBRESOURCE_DATA* pSrcData)
        {
            // Minor validation
            D3D12_RESOURCE_DESC IntermediateDesc = pIntermediate->GetDesc();
            D3D12_RESOURCE_DESC DestinationDesc = pDestinationResource->GetDesc();
            if (IntermediateDesc.Dimension != D3D12_RESOURCE_DIMENSION_BUFFER ||
                IntermediateDesc.Width < RequiredSize + pLayouts[0].Offset ||
                RequiredSize > ((IntPtr.Size == 4) ? uint.MaxValue : ulong.MaxValue) ||
                (DestinationDesc.Dimension == D3D12_RESOURCE_DIMENSION_BUFFER &&
                    (FirstSubresource != 0 || NumSubresources != 1)))
            {
                return 0;
            }

            byte* pData;
            int hr = pIntermediate->Map(0, null, (void**)&pData);
            if (FAILED(hr))
            {
                return 0;
            }

            for (var i = 0u; i < NumSubresources; ++i)
            {
                if (pRowSizesInBytes[i] > ((IntPtr.Size == 4) ? uint.MaxValue : ulong.MaxValue))
                    return 0;
                var DestData = new D3D12_MEMCPY_DEST {
                    pData = pData + pLayouts[i].Offset,
                    RowPitch = (UIntPtr)pLayouts[i].Footprint.RowPitch,
                    SlicePitch = (UIntPtr)(pLayouts[i].Footprint.RowPitch * pNumRows[i])
                };
                MemcpySubresource(&DestData, &pSrcData[i], (UIntPtr)pRowSizesInBytes[i], pNumRows[i], pLayouts[i].Footprint.Depth);
            }
            pIntermediate->Unmap(0, null);

            if (DestinationDesc.Dimension == D3D12_RESOURCE_DIMENSION_BUFFER)
            {
                var SrcBox = new D3D12_BOX((int)pLayouts[0].Offset, (int)(pLayouts[0].Offset + pLayouts[0].Footprint.Width));
                pCmdList->CopyBufferRegion(
                    pDestinationResource, 0, pIntermediate, pLayouts[0].Offset, pLayouts[0].Footprint.Width);
            }
            else
            {
                for (var i = 0u; i < NumSubresources; ++i)
                {
                    var Dst = new D3D12_TEXTURE_COPY_LOCATION(pDestinationResource, i + FirstSubresource);
                    var Src = new D3D12_TEXTURE_COPY_LOCATION(pIntermediate, pLayouts + i);
                    pCmdList->CopyTextureRegion(&Dst, 0, 0, 0, &Src, null);
                }
            }
            return RequiredSize;
        }

        //------------------------------------------------------------------------------------------------
        // Heap-allocating UpdateSubresources implementation
        public static ulong UpdateSubresources(ID3D12GraphicsCommandList* pCmdList, ID3D12Resource* pDestinationResource, ID3D12Resource* pIntermediate, ulong IntermediateOffset, uint FirstSubresource, uint NumSubresources, D3D12_SUBRESOURCE_DATA* pSrcData)
        {
            ulong RequiredSize = 0;
            ulong MemToAlloc = (ulong)(sizeof(D3D12_PLACED_SUBRESOURCE_FOOTPRINT) + sizeof(uint) + sizeof(ulong)) * NumSubresources;
            if (MemToAlloc > ((IntPtr.Size == 4) ? uint.MaxValue : ulong.MaxValue))
            {
                return 0;
            }
            void* pMem = Marshal.AllocHGlobal((IntPtr)MemToAlloc).ToPointer();
            if (pMem == null)
            {
                return 0;
            }
            D3D12_PLACED_SUBRESOURCE_FOOTPRINT* pLayouts = (D3D12_PLACED_SUBRESOURCE_FOOTPRINT*)pMem;
            ulong* pRowSizesInBytes = (ulong*)(pLayouts + NumSubresources);
            uint* pNumRows = (uint*)(pRowSizesInBytes + NumSubresources);

            D3D12_RESOURCE_DESC Desc = pDestinationResource->GetDesc();
            ID3D12Device* pDevice;
            var iid = IID_ID3D12Device;
            pDestinationResource->GetDevice(&iid, (void**)&pDevice);
            pDevice->GetCopyableFootprints(&Desc, FirstSubresource, NumSubresources, IntermediateOffset, pLayouts, pNumRows, pRowSizesInBytes, &RequiredSize);
            pDevice->Release();

            ulong Result = UpdateSubresources(pCmdList, pDestinationResource, pIntermediate, FirstSubresource, NumSubresources, RequiredSize, pLayouts, pNumRows, pRowSizesInBytes, pSrcData);
            Marshal.FreeHGlobal((IntPtr)pMem);
            return Result;
        }

        //------------------------------------------------------------------------------------------------
        // Stack-allocating UpdateSubresources implementation
        public static ulong UpdateSubresources(uint MaxSubresources, ID3D12GraphicsCommandList* pCmdList, ID3D12Resource* pDestinationResource, ID3D12Resource* pIntermediate, ulong IntermediateOffset, uint FirstSubresource, uint NumSubresources, D3D12_SUBRESOURCE_DATA* pSrcData)
        {
            ulong RequiredSize = 0;
            var Layouts = stackalloc D3D12_PLACED_SUBRESOURCE_FOOTPRINT[(int)MaxSubresources];
            var NumRows = stackalloc uint[(int)MaxSubresources];
            var RowSizesInBytes = stackalloc ulong[(int)MaxSubresources];

            D3D12_RESOURCE_DESC Desc = pDestinationResource->GetDesc();
            ID3D12Device* pDevice;
            var iid = IID_ID3D12Device;
            pDestinationResource->GetDevice(&iid, (void**)&pDevice);
            pDevice->GetCopyableFootprints(&Desc, FirstSubresource, NumSubresources, IntermediateOffset, Layouts, NumRows, RowSizesInBytes, &RequiredSize);
            pDevice->Release();
    
            return UpdateSubresources(pCmdList, pDestinationResource, pIntermediate, FirstSubresource, NumSubresources, RequiredSize, Layouts, NumRows, RowSizesInBytes, pSrcData);
        }

        public static bool D3D12IsLayoutOpaque(D3D12_TEXTURE_LAYOUT Layout)
        {
            return (Layout == D3D12_TEXTURE_LAYOUT_UNKNOWN) || (Layout == D3D12_TEXTURE_LAYOUT_64KB_UNDEFINED_SWIZZLE);
        }

        public static ID3D12CommandList** CommandListCast(ID3D12GraphicsCommandList** pp)
        {
            // This cast is useful for passing strongly typed command list pointers into
            // ExecuteCommandLists.
            // This cast is valid as long as the const-ness is respected. D3D12 APIs do
            // respect the const-ness of their arguments.
            return (ID3D12CommandList**)pp;
        }
    }
}
