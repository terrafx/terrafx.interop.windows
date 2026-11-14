// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d10.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

public static partial class D3D10
{
    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_16BIT_INDEX_STRIP_CUT_VALUE"]/*' />
    [NativeTypeName("#define D3D10_16BIT_INDEX_STRIP_CUT_VALUE ( 0xffff )")]
    public const int D3D10_16BIT_INDEX_STRIP_CUT_VALUE = (0xffff);

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_32BIT_INDEX_STRIP_CUT_VALUE"]/*' />
    [NativeTypeName("#define D3D10_32BIT_INDEX_STRIP_CUT_VALUE ( 0xffffffff )")]
    public const uint D3D10_32BIT_INDEX_STRIP_CUT_VALUE = (0xffffffff);

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_8BIT_INDEX_STRIP_CUT_VALUE"]/*' />
    [NativeTypeName("#define D3D10_8BIT_INDEX_STRIP_CUT_VALUE ( 0xff )")]
    public const int D3D10_8BIT_INDEX_STRIP_CUT_VALUE = (0xff);

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_ARRAY_AXIS_ADDRESS_RANGE_BIT_COUNT"]/*' />
    [NativeTypeName("#define D3D10_ARRAY_AXIS_ADDRESS_RANGE_BIT_COUNT ( 9 )")]
    public const int D3D10_ARRAY_AXIS_ADDRESS_RANGE_BIT_COUNT = (9);

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_CLIP_OR_CULL_DISTANCE_COUNT"]/*' />
    [NativeTypeName("#define D3D10_CLIP_OR_CULL_DISTANCE_COUNT ( 8 )")]
    public const int D3D10_CLIP_OR_CULL_DISTANCE_COUNT = (8);

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_CLIP_OR_CULL_DISTANCE_ELEMENT_COUNT"]/*' />
    [NativeTypeName("#define D3D10_CLIP_OR_CULL_DISTANCE_ELEMENT_COUNT ( 2 )")]
    public const int D3D10_CLIP_OR_CULL_DISTANCE_ELEMENT_COUNT = (2);

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_COMMONSHADER_CONSTANT_BUFFER_API_SLOT_COUNT"]/*' />
    [NativeTypeName("#define D3D10_COMMONSHADER_CONSTANT_BUFFER_API_SLOT_COUNT ( 14 )")]
    public const int D3D10_COMMONSHADER_CONSTANT_BUFFER_API_SLOT_COUNT = (14);

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_COMMONSHADER_CONSTANT_BUFFER_COMPONENTS"]/*' />
    [NativeTypeName("#define D3D10_COMMONSHADER_CONSTANT_BUFFER_COMPONENTS ( 4 )")]
    public const int D3D10_COMMONSHADER_CONSTANT_BUFFER_COMPONENTS = (4);

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_COMMONSHADER_CONSTANT_BUFFER_COMPONENT_BIT_COUNT"]/*' />
    [NativeTypeName("#define D3D10_COMMONSHADER_CONSTANT_BUFFER_COMPONENT_BIT_COUNT ( 32 )")]
    public const int D3D10_COMMONSHADER_CONSTANT_BUFFER_COMPONENT_BIT_COUNT = (32);

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_COMMONSHADER_CONSTANT_BUFFER_HW_SLOT_COUNT"]/*' />
    [NativeTypeName("#define D3D10_COMMONSHADER_CONSTANT_BUFFER_HW_SLOT_COUNT ( 15 )")]
    public const int D3D10_COMMONSHADER_CONSTANT_BUFFER_HW_SLOT_COUNT = (15);

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_COMMONSHADER_CONSTANT_BUFFER_REGISTER_COMPONENTS"]/*' />
    [NativeTypeName("#define D3D10_COMMONSHADER_CONSTANT_BUFFER_REGISTER_COMPONENTS ( 4 )")]
    public const int D3D10_COMMONSHADER_CONSTANT_BUFFER_REGISTER_COMPONENTS = (4);

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_COMMONSHADER_CONSTANT_BUFFER_REGISTER_COUNT"]/*' />
    [NativeTypeName("#define D3D10_COMMONSHADER_CONSTANT_BUFFER_REGISTER_COUNT ( 15 )")]
    public const int D3D10_COMMONSHADER_CONSTANT_BUFFER_REGISTER_COUNT = (15);

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_COMMONSHADER_CONSTANT_BUFFER_REGISTER_READS_PER_INST"]/*' />
    [NativeTypeName("#define D3D10_COMMONSHADER_CONSTANT_BUFFER_REGISTER_READS_PER_INST ( 1 )")]
    public const int D3D10_COMMONSHADER_CONSTANT_BUFFER_REGISTER_READS_PER_INST = (1);

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_COMMONSHADER_CONSTANT_BUFFER_REGISTER_READ_PORTS"]/*' />
    [NativeTypeName("#define D3D10_COMMONSHADER_CONSTANT_BUFFER_REGISTER_READ_PORTS ( 1 )")]
    public const int D3D10_COMMONSHADER_CONSTANT_BUFFER_REGISTER_READ_PORTS = (1);

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_COMMONSHADER_FLOWCONTROL_NESTING_LIMIT"]/*' />
    [NativeTypeName("#define D3D10_COMMONSHADER_FLOWCONTROL_NESTING_LIMIT ( 64 )")]
    public const int D3D10_COMMONSHADER_FLOWCONTROL_NESTING_LIMIT = (64);

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_COMMONSHADER_IMMEDIATE_CONSTANT_BUFFER_REGISTER_COMPONENTS"]/*' />
    [NativeTypeName("#define D3D10_COMMONSHADER_IMMEDIATE_CONSTANT_BUFFER_REGISTER_COMPONENTS ( 4 )")]
    public const int D3D10_COMMONSHADER_IMMEDIATE_CONSTANT_BUFFER_REGISTER_COMPONENTS = (4);

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_COMMONSHADER_IMMEDIATE_CONSTANT_BUFFER_REGISTER_COUNT"]/*' />
    [NativeTypeName("#define D3D10_COMMONSHADER_IMMEDIATE_CONSTANT_BUFFER_REGISTER_COUNT ( 1 )")]
    public const int D3D10_COMMONSHADER_IMMEDIATE_CONSTANT_BUFFER_REGISTER_COUNT = (1);

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_COMMONSHADER_IMMEDIATE_CONSTANT_BUFFER_REGISTER_READS_PER_INST"]/*' />
    [NativeTypeName("#define D3D10_COMMONSHADER_IMMEDIATE_CONSTANT_BUFFER_REGISTER_READS_PER_INST ( 1 )")]
    public const int D3D10_COMMONSHADER_IMMEDIATE_CONSTANT_BUFFER_REGISTER_READS_PER_INST = (1);

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_COMMONSHADER_IMMEDIATE_CONSTANT_BUFFER_REGISTER_READ_PORTS"]/*' />
    [NativeTypeName("#define D3D10_COMMONSHADER_IMMEDIATE_CONSTANT_BUFFER_REGISTER_READ_PORTS ( 1 )")]
    public const int D3D10_COMMONSHADER_IMMEDIATE_CONSTANT_BUFFER_REGISTER_READ_PORTS = (1);

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_COMMONSHADER_IMMEDIATE_VALUE_COMPONENT_BIT_COUNT"]/*' />
    [NativeTypeName("#define D3D10_COMMONSHADER_IMMEDIATE_VALUE_COMPONENT_BIT_COUNT ( 32 )")]
    public const int D3D10_COMMONSHADER_IMMEDIATE_VALUE_COMPONENT_BIT_COUNT = (32);

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_COMMONSHADER_INPUT_RESOURCE_REGISTER_COMPONENTS"]/*' />
    [NativeTypeName("#define D3D10_COMMONSHADER_INPUT_RESOURCE_REGISTER_COMPONENTS ( 1 )")]
    public const int D3D10_COMMONSHADER_INPUT_RESOURCE_REGISTER_COMPONENTS = (1);

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_COMMONSHADER_INPUT_RESOURCE_REGISTER_COUNT"]/*' />
    [NativeTypeName("#define D3D10_COMMONSHADER_INPUT_RESOURCE_REGISTER_COUNT ( 128 )")]
    public const int D3D10_COMMONSHADER_INPUT_RESOURCE_REGISTER_COUNT = (128);

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_COMMONSHADER_INPUT_RESOURCE_REGISTER_READS_PER_INST"]/*' />
    [NativeTypeName("#define D3D10_COMMONSHADER_INPUT_RESOURCE_REGISTER_READS_PER_INST ( 1 )")]
    public const int D3D10_COMMONSHADER_INPUT_RESOURCE_REGISTER_READS_PER_INST = (1);

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_COMMONSHADER_INPUT_RESOURCE_REGISTER_READ_PORTS"]/*' />
    [NativeTypeName("#define D3D10_COMMONSHADER_INPUT_RESOURCE_REGISTER_READ_PORTS ( 1 )")]
    public const int D3D10_COMMONSHADER_INPUT_RESOURCE_REGISTER_READ_PORTS = (1);

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_COMMONSHADER_INPUT_RESOURCE_SLOT_COUNT"]/*' />
    [NativeTypeName("#define D3D10_COMMONSHADER_INPUT_RESOURCE_SLOT_COUNT ( 128 )")]
    public const int D3D10_COMMONSHADER_INPUT_RESOURCE_SLOT_COUNT = (128);

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_COMMONSHADER_SAMPLER_REGISTER_COMPONENTS"]/*' />
    [NativeTypeName("#define D3D10_COMMONSHADER_SAMPLER_REGISTER_COMPONENTS ( 1 )")]
    public const int D3D10_COMMONSHADER_SAMPLER_REGISTER_COMPONENTS = (1);

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_COMMONSHADER_SAMPLER_REGISTER_COUNT"]/*' />
    [NativeTypeName("#define D3D10_COMMONSHADER_SAMPLER_REGISTER_COUNT ( 16 )")]
    public const int D3D10_COMMONSHADER_SAMPLER_REGISTER_COUNT = (16);

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_COMMONSHADER_SAMPLER_REGISTER_READS_PER_INST"]/*' />
    [NativeTypeName("#define D3D10_COMMONSHADER_SAMPLER_REGISTER_READS_PER_INST ( 1 )")]
    public const int D3D10_COMMONSHADER_SAMPLER_REGISTER_READS_PER_INST = (1);

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_COMMONSHADER_SAMPLER_REGISTER_READ_PORTS"]/*' />
    [NativeTypeName("#define D3D10_COMMONSHADER_SAMPLER_REGISTER_READ_PORTS ( 1 )")]
    public const int D3D10_COMMONSHADER_SAMPLER_REGISTER_READ_PORTS = (1);

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_COMMONSHADER_SAMPLER_SLOT_COUNT"]/*' />
    [NativeTypeName("#define D3D10_COMMONSHADER_SAMPLER_SLOT_COUNT ( 16 )")]
    public const int D3D10_COMMONSHADER_SAMPLER_SLOT_COUNT = (16);

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_COMMONSHADER_SUBROUTINE_NESTING_LIMIT"]/*' />
    [NativeTypeName("#define D3D10_COMMONSHADER_SUBROUTINE_NESTING_LIMIT ( 32 )")]
    public const int D3D10_COMMONSHADER_SUBROUTINE_NESTING_LIMIT = (32);

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_COMMONSHADER_TEMP_REGISTER_COMPONENTS"]/*' />
    [NativeTypeName("#define D3D10_COMMONSHADER_TEMP_REGISTER_COMPONENTS ( 4 )")]
    public const int D3D10_COMMONSHADER_TEMP_REGISTER_COMPONENTS = (4);

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_COMMONSHADER_TEMP_REGISTER_COMPONENT_BIT_COUNT"]/*' />
    [NativeTypeName("#define D3D10_COMMONSHADER_TEMP_REGISTER_COMPONENT_BIT_COUNT ( 32 )")]
    public const int D3D10_COMMONSHADER_TEMP_REGISTER_COMPONENT_BIT_COUNT = (32);

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_COMMONSHADER_TEMP_REGISTER_COUNT"]/*' />
    [NativeTypeName("#define D3D10_COMMONSHADER_TEMP_REGISTER_COUNT ( 4096 )")]
    public const int D3D10_COMMONSHADER_TEMP_REGISTER_COUNT = (4096);

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_COMMONSHADER_TEMP_REGISTER_READS_PER_INST"]/*' />
    [NativeTypeName("#define D3D10_COMMONSHADER_TEMP_REGISTER_READS_PER_INST ( 3 )")]
    public const int D3D10_COMMONSHADER_TEMP_REGISTER_READS_PER_INST = (3);

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_COMMONSHADER_TEMP_REGISTER_READ_PORTS"]/*' />
    [NativeTypeName("#define D3D10_COMMONSHADER_TEMP_REGISTER_READ_PORTS ( 3 )")]
    public const int D3D10_COMMONSHADER_TEMP_REGISTER_READ_PORTS = (3);

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_COMMONSHADER_TEXCOORD_RANGE_REDUCTION_MAX"]/*' />
    [NativeTypeName("#define D3D10_COMMONSHADER_TEXCOORD_RANGE_REDUCTION_MAX ( 10 )")]
    public const int D3D10_COMMONSHADER_TEXCOORD_RANGE_REDUCTION_MAX = (10);

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_COMMONSHADER_TEXCOORD_RANGE_REDUCTION_MIN"]/*' />
    [NativeTypeName("#define D3D10_COMMONSHADER_TEXCOORD_RANGE_REDUCTION_MIN ( -10 )")]
    public const int D3D10_COMMONSHADER_TEXCOORD_RANGE_REDUCTION_MIN = (-10);

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_COMMONSHADER_TEXEL_OFFSET_MAX_NEGATIVE"]/*' />
    [NativeTypeName("#define D3D10_COMMONSHADER_TEXEL_OFFSET_MAX_NEGATIVE ( -8 )")]
    public const int D3D10_COMMONSHADER_TEXEL_OFFSET_MAX_NEGATIVE = (-8);

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_COMMONSHADER_TEXEL_OFFSET_MAX_POSITIVE"]/*' />
    [NativeTypeName("#define D3D10_COMMONSHADER_TEXEL_OFFSET_MAX_POSITIVE ( 7 )")]
    public const int D3D10_COMMONSHADER_TEXEL_OFFSET_MAX_POSITIVE = (7);

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_DEFAULT_BLEND_FACTOR_ALPHA"]/*' />
    [NativeTypeName("#define D3D10_DEFAULT_BLEND_FACTOR_ALPHA ( 1.0f )")]
    public const float D3D10_DEFAULT_BLEND_FACTOR_ALPHA = (1.0f);

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_DEFAULT_BLEND_FACTOR_BLUE"]/*' />
    [NativeTypeName("#define D3D10_DEFAULT_BLEND_FACTOR_BLUE ( 1.0f )")]
    public const float D3D10_DEFAULT_BLEND_FACTOR_BLUE = (1.0f);

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_DEFAULT_BLEND_FACTOR_GREEN"]/*' />
    [NativeTypeName("#define D3D10_DEFAULT_BLEND_FACTOR_GREEN ( 1.0f )")]
    public const float D3D10_DEFAULT_BLEND_FACTOR_GREEN = (1.0f);

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_DEFAULT_BLEND_FACTOR_RED"]/*' />
    [NativeTypeName("#define D3D10_DEFAULT_BLEND_FACTOR_RED ( 1.0f )")]
    public const float D3D10_DEFAULT_BLEND_FACTOR_RED = (1.0f);

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_DEFAULT_BORDER_COLOR_COMPONENT"]/*' />
    [NativeTypeName("#define D3D10_DEFAULT_BORDER_COLOR_COMPONENT ( 0.0f )")]
    public const float D3D10_DEFAULT_BORDER_COLOR_COMPONENT = (0.0f);

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_DEFAULT_DEPTH_BIAS"]/*' />
    [NativeTypeName("#define D3D10_DEFAULT_DEPTH_BIAS ( 0 )")]
    public const int D3D10_DEFAULT_DEPTH_BIAS = (0);

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_DEFAULT_DEPTH_BIAS_CLAMP"]/*' />
    [NativeTypeName("#define D3D10_DEFAULT_DEPTH_BIAS_CLAMP ( 0.0f )")]
    public const float D3D10_DEFAULT_DEPTH_BIAS_CLAMP = (0.0f);

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_DEFAULT_MAX_ANISOTROPY"]/*' />
    [NativeTypeName("#define D3D10_DEFAULT_MAX_ANISOTROPY ( 16.0f )")]
    public const float D3D10_DEFAULT_MAX_ANISOTROPY = (16.0f);

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_DEFAULT_MIP_LOD_BIAS"]/*' />
    [NativeTypeName("#define D3D10_DEFAULT_MIP_LOD_BIAS ( 0.0f )")]
    public const float D3D10_DEFAULT_MIP_LOD_BIAS = (0.0f);

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_DEFAULT_RENDER_TARGET_ARRAY_INDEX"]/*' />
    [NativeTypeName("#define D3D10_DEFAULT_RENDER_TARGET_ARRAY_INDEX ( 0 )")]
    public const int D3D10_DEFAULT_RENDER_TARGET_ARRAY_INDEX = (0);

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_DEFAULT_SAMPLE_MASK"]/*' />
    [NativeTypeName("#define D3D10_DEFAULT_SAMPLE_MASK ( 0xffffffff )")]
    public const uint D3D10_DEFAULT_SAMPLE_MASK = (0xffffffff);

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_DEFAULT_SCISSOR_ENDX"]/*' />
    [NativeTypeName("#define D3D10_DEFAULT_SCISSOR_ENDX ( 0 )")]
    public const int D3D10_DEFAULT_SCISSOR_ENDX = (0);

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_DEFAULT_SCISSOR_ENDY"]/*' />
    [NativeTypeName("#define D3D10_DEFAULT_SCISSOR_ENDY ( 0 )")]
    public const int D3D10_DEFAULT_SCISSOR_ENDY = (0);

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_DEFAULT_SCISSOR_STARTX"]/*' />
    [NativeTypeName("#define D3D10_DEFAULT_SCISSOR_STARTX ( 0 )")]
    public const int D3D10_DEFAULT_SCISSOR_STARTX = (0);

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_DEFAULT_SCISSOR_STARTY"]/*' />
    [NativeTypeName("#define D3D10_DEFAULT_SCISSOR_STARTY ( 0 )")]
    public const int D3D10_DEFAULT_SCISSOR_STARTY = (0);

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_DEFAULT_SLOPE_SCALED_DEPTH_BIAS"]/*' />
    [NativeTypeName("#define D3D10_DEFAULT_SLOPE_SCALED_DEPTH_BIAS ( 0.0f )")]
    public const float D3D10_DEFAULT_SLOPE_SCALED_DEPTH_BIAS = (0.0f);

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_DEFAULT_STENCIL_READ_MASK"]/*' />
    [NativeTypeName("#define D3D10_DEFAULT_STENCIL_READ_MASK ( 0xff )")]
    public const int D3D10_DEFAULT_STENCIL_READ_MASK = (0xff);

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_DEFAULT_STENCIL_REFERENCE"]/*' />
    [NativeTypeName("#define D3D10_DEFAULT_STENCIL_REFERENCE ( 0 )")]
    public const int D3D10_DEFAULT_STENCIL_REFERENCE = (0);

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_DEFAULT_STENCIL_WRITE_MASK"]/*' />
    [NativeTypeName("#define D3D10_DEFAULT_STENCIL_WRITE_MASK ( 0xff )")]
    public const int D3D10_DEFAULT_STENCIL_WRITE_MASK = (0xff);

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_DEFAULT_VIEWPORT_AND_SCISSORRECT_INDEX"]/*' />
    [NativeTypeName("#define D3D10_DEFAULT_VIEWPORT_AND_SCISSORRECT_INDEX ( 0 )")]
    public const int D3D10_DEFAULT_VIEWPORT_AND_SCISSORRECT_INDEX = (0);

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_DEFAULT_VIEWPORT_HEIGHT"]/*' />
    [NativeTypeName("#define D3D10_DEFAULT_VIEWPORT_HEIGHT ( 0 )")]
    public const int D3D10_DEFAULT_VIEWPORT_HEIGHT = (0);

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_DEFAULT_VIEWPORT_MAX_DEPTH"]/*' />
    [NativeTypeName("#define D3D10_DEFAULT_VIEWPORT_MAX_DEPTH ( 0.0f )")]
    public const float D3D10_DEFAULT_VIEWPORT_MAX_DEPTH = (0.0f);

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_DEFAULT_VIEWPORT_MIN_DEPTH"]/*' />
    [NativeTypeName("#define D3D10_DEFAULT_VIEWPORT_MIN_DEPTH ( 0.0f )")]
    public const float D3D10_DEFAULT_VIEWPORT_MIN_DEPTH = (0.0f);

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_DEFAULT_VIEWPORT_TOPLEFTX"]/*' />
    [NativeTypeName("#define D3D10_DEFAULT_VIEWPORT_TOPLEFTX ( 0 )")]
    public const int D3D10_DEFAULT_VIEWPORT_TOPLEFTX = (0);

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_DEFAULT_VIEWPORT_TOPLEFTY"]/*' />
    [NativeTypeName("#define D3D10_DEFAULT_VIEWPORT_TOPLEFTY ( 0 )")]
    public const int D3D10_DEFAULT_VIEWPORT_TOPLEFTY = (0);

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_DEFAULT_VIEWPORT_WIDTH"]/*' />
    [NativeTypeName("#define D3D10_DEFAULT_VIEWPORT_WIDTH ( 0 )")]
    public const int D3D10_DEFAULT_VIEWPORT_WIDTH = (0);

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_FLOAT16_FUSED_TOLERANCE_IN_ULP"]/*' />
    [NativeTypeName("#define D3D10_FLOAT16_FUSED_TOLERANCE_IN_ULP ( 0.6 )")]
    public const double D3D10_FLOAT16_FUSED_TOLERANCE_IN_ULP = (0.6);

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_FLOAT32_MAX"]/*' />
    [NativeTypeName("#define D3D10_FLOAT32_MAX ( 3.402823466e+38f )")]
    public const float D3D10_FLOAT32_MAX = (3.402823466e+38f);

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_FLOAT32_TO_INTEGER_TOLERANCE_IN_ULP"]/*' />
    [NativeTypeName("#define D3D10_FLOAT32_TO_INTEGER_TOLERANCE_IN_ULP ( 0.6f )")]
    public const float D3D10_FLOAT32_TO_INTEGER_TOLERANCE_IN_ULP = (0.6f);

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_FLOAT_TO_SRGB_EXPONENT_DENOMINATOR"]/*' />
    [NativeTypeName("#define D3D10_FLOAT_TO_SRGB_EXPONENT_DENOMINATOR ( 2.4f )")]
    public const float D3D10_FLOAT_TO_SRGB_EXPONENT_DENOMINATOR = (2.4f);

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_FLOAT_TO_SRGB_EXPONENT_NUMERATOR"]/*' />
    [NativeTypeName("#define D3D10_FLOAT_TO_SRGB_EXPONENT_NUMERATOR ( 1.0f )")]
    public const float D3D10_FLOAT_TO_SRGB_EXPONENT_NUMERATOR = (1.0f);

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_FLOAT_TO_SRGB_OFFSET"]/*' />
    [NativeTypeName("#define D3D10_FLOAT_TO_SRGB_OFFSET ( 0.055f )")]
    public const float D3D10_FLOAT_TO_SRGB_OFFSET = (0.055f);

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_FLOAT_TO_SRGB_SCALE_1"]/*' />
    [NativeTypeName("#define D3D10_FLOAT_TO_SRGB_SCALE_1 ( 12.92f )")]
    public const float D3D10_FLOAT_TO_SRGB_SCALE_1 = (12.92f);

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_FLOAT_TO_SRGB_SCALE_2"]/*' />
    [NativeTypeName("#define D3D10_FLOAT_TO_SRGB_SCALE_2 ( 1.055f )")]
    public const float D3D10_FLOAT_TO_SRGB_SCALE_2 = (1.055f);

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_FLOAT_TO_SRGB_THRESHOLD"]/*' />
    [NativeTypeName("#define D3D10_FLOAT_TO_SRGB_THRESHOLD ( 0.0031308f )")]
    public const float D3D10_FLOAT_TO_SRGB_THRESHOLD = (0.0031308f);

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_FTOI_INSTRUCTION_MAX_INPUT"]/*' />
    [NativeTypeName("#define D3D10_FTOI_INSTRUCTION_MAX_INPUT ( 2147483647.999f )")]
    public const float D3D10_FTOI_INSTRUCTION_MAX_INPUT = (2147483647.999f);

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_FTOI_INSTRUCTION_MIN_INPUT"]/*' />
    [NativeTypeName("#define D3D10_FTOI_INSTRUCTION_MIN_INPUT ( -2147483648.999f )")]
    public const float D3D10_FTOI_INSTRUCTION_MIN_INPUT = (-2147483648.999f);

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_FTOU_INSTRUCTION_MAX_INPUT"]/*' />
    [NativeTypeName("#define D3D10_FTOU_INSTRUCTION_MAX_INPUT ( 4294967295.999f )")]
    public const float D3D10_FTOU_INSTRUCTION_MAX_INPUT = (4294967295.999f);

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_FTOU_INSTRUCTION_MIN_INPUT"]/*' />
    [NativeTypeName("#define D3D10_FTOU_INSTRUCTION_MIN_INPUT ( 0.0f )")]
    public const float D3D10_FTOU_INSTRUCTION_MIN_INPUT = (0.0f);

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_GS_INPUT_PRIM_CONST_REGISTER_COMPONENTS"]/*' />
    [NativeTypeName("#define D3D10_GS_INPUT_PRIM_CONST_REGISTER_COMPONENTS ( 1 )")]
    public const int D3D10_GS_INPUT_PRIM_CONST_REGISTER_COMPONENTS = (1);

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_GS_INPUT_PRIM_CONST_REGISTER_COMPONENT_BIT_COUNT"]/*' />
    [NativeTypeName("#define D3D10_GS_INPUT_PRIM_CONST_REGISTER_COMPONENT_BIT_COUNT ( 32 )")]
    public const int D3D10_GS_INPUT_PRIM_CONST_REGISTER_COMPONENT_BIT_COUNT = (32);

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_GS_INPUT_PRIM_CONST_REGISTER_COUNT"]/*' />
    [NativeTypeName("#define D3D10_GS_INPUT_PRIM_CONST_REGISTER_COUNT ( 1 )")]
    public const int D3D10_GS_INPUT_PRIM_CONST_REGISTER_COUNT = (1);

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_GS_INPUT_PRIM_CONST_REGISTER_READS_PER_INST"]/*' />
    [NativeTypeName("#define D3D10_GS_INPUT_PRIM_CONST_REGISTER_READS_PER_INST ( 2 )")]
    public const int D3D10_GS_INPUT_PRIM_CONST_REGISTER_READS_PER_INST = (2);

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_GS_INPUT_PRIM_CONST_REGISTER_READ_PORTS"]/*' />
    [NativeTypeName("#define D3D10_GS_INPUT_PRIM_CONST_REGISTER_READ_PORTS ( 1 )")]
    public const int D3D10_GS_INPUT_PRIM_CONST_REGISTER_READ_PORTS = (1);

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_GS_INPUT_REGISTER_COMPONENTS"]/*' />
    [NativeTypeName("#define D3D10_GS_INPUT_REGISTER_COMPONENTS ( 4 )")]
    public const int D3D10_GS_INPUT_REGISTER_COMPONENTS = (4);

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_GS_INPUT_REGISTER_COMPONENT_BIT_COUNT"]/*' />
    [NativeTypeName("#define D3D10_GS_INPUT_REGISTER_COMPONENT_BIT_COUNT ( 32 )")]
    public const int D3D10_GS_INPUT_REGISTER_COMPONENT_BIT_COUNT = (32);

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_GS_INPUT_REGISTER_COUNT"]/*' />
    [NativeTypeName("#define D3D10_GS_INPUT_REGISTER_COUNT ( 16 )")]
    public const int D3D10_GS_INPUT_REGISTER_COUNT = (16);

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_GS_INPUT_REGISTER_READS_PER_INST"]/*' />
    [NativeTypeName("#define D3D10_GS_INPUT_REGISTER_READS_PER_INST ( 2 )")]
    public const int D3D10_GS_INPUT_REGISTER_READS_PER_INST = (2);

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_GS_INPUT_REGISTER_READ_PORTS"]/*' />
    [NativeTypeName("#define D3D10_GS_INPUT_REGISTER_READ_PORTS ( 1 )")]
    public const int D3D10_GS_INPUT_REGISTER_READ_PORTS = (1);

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_GS_INPUT_REGISTER_VERTICES"]/*' />
    [NativeTypeName("#define D3D10_GS_INPUT_REGISTER_VERTICES ( 6 )")]
    public const int D3D10_GS_INPUT_REGISTER_VERTICES = (6);

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_GS_OUTPUT_ELEMENTS"]/*' />
    [NativeTypeName("#define D3D10_GS_OUTPUT_ELEMENTS ( 32 )")]
    public const int D3D10_GS_OUTPUT_ELEMENTS = (32);

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_GS_OUTPUT_REGISTER_COMPONENTS"]/*' />
    [NativeTypeName("#define D3D10_GS_OUTPUT_REGISTER_COMPONENTS ( 4 )")]
    public const int D3D10_GS_OUTPUT_REGISTER_COMPONENTS = (4);

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_GS_OUTPUT_REGISTER_COMPONENT_BIT_COUNT"]/*' />
    [NativeTypeName("#define D3D10_GS_OUTPUT_REGISTER_COMPONENT_BIT_COUNT ( 32 )")]
    public const int D3D10_GS_OUTPUT_REGISTER_COMPONENT_BIT_COUNT = (32);

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_GS_OUTPUT_REGISTER_COUNT"]/*' />
    [NativeTypeName("#define D3D10_GS_OUTPUT_REGISTER_COUNT ( 32 )")]
    public const int D3D10_GS_OUTPUT_REGISTER_COUNT = (32);

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_IA_DEFAULT_INDEX_BUFFER_OFFSET_IN_BYTES"]/*' />
    [NativeTypeName("#define D3D10_IA_DEFAULT_INDEX_BUFFER_OFFSET_IN_BYTES ( 0 )")]
    public const int D3D10_IA_DEFAULT_INDEX_BUFFER_OFFSET_IN_BYTES = (0);

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_IA_DEFAULT_PRIMITIVE_TOPOLOGY"]/*' />
    [NativeTypeName("#define D3D10_IA_DEFAULT_PRIMITIVE_TOPOLOGY ( 0 )")]
    public const int D3D10_IA_DEFAULT_PRIMITIVE_TOPOLOGY = (0);

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_IA_DEFAULT_VERTEX_BUFFER_OFFSET_IN_BYTES"]/*' />
    [NativeTypeName("#define D3D10_IA_DEFAULT_VERTEX_BUFFER_OFFSET_IN_BYTES ( 0 )")]
    public const int D3D10_IA_DEFAULT_VERTEX_BUFFER_OFFSET_IN_BYTES = (0);

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_IA_INDEX_INPUT_RESOURCE_SLOT_COUNT"]/*' />
    [NativeTypeName("#define D3D10_IA_INDEX_INPUT_RESOURCE_SLOT_COUNT ( 1 )")]
    public const int D3D10_IA_INDEX_INPUT_RESOURCE_SLOT_COUNT = (1);

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_IA_INSTANCE_ID_BIT_COUNT"]/*' />
    [NativeTypeName("#define D3D10_IA_INSTANCE_ID_BIT_COUNT ( 32 )")]
    public const int D3D10_IA_INSTANCE_ID_BIT_COUNT = (32);

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_IA_INTEGER_ARITHMETIC_BIT_COUNT"]/*' />
    [NativeTypeName("#define D3D10_IA_INTEGER_ARITHMETIC_BIT_COUNT ( 32 )")]
    public const int D3D10_IA_INTEGER_ARITHMETIC_BIT_COUNT = (32);

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_IA_PRIMITIVE_ID_BIT_COUNT"]/*' />
    [NativeTypeName("#define D3D10_IA_PRIMITIVE_ID_BIT_COUNT ( 32 )")]
    public const int D3D10_IA_PRIMITIVE_ID_BIT_COUNT = (32);

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_IA_VERTEX_ID_BIT_COUNT"]/*' />
    [NativeTypeName("#define D3D10_IA_VERTEX_ID_BIT_COUNT ( 32 )")]
    public const int D3D10_IA_VERTEX_ID_BIT_COUNT = (32);

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_IA_VERTEX_INPUT_RESOURCE_SLOT_COUNT"]/*' />
    [NativeTypeName("#define D3D10_IA_VERTEX_INPUT_RESOURCE_SLOT_COUNT ( 16 )")]
    public const int D3D10_IA_VERTEX_INPUT_RESOURCE_SLOT_COUNT = (16);

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_IA_VERTEX_INPUT_STRUCTURE_ELEMENTS_COMPONENTS"]/*' />
    [NativeTypeName("#define D3D10_IA_VERTEX_INPUT_STRUCTURE_ELEMENTS_COMPONENTS ( 64 )")]
    public const int D3D10_IA_VERTEX_INPUT_STRUCTURE_ELEMENTS_COMPONENTS = (64);

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_IA_VERTEX_INPUT_STRUCTURE_ELEMENT_COUNT"]/*' />
    [NativeTypeName("#define D3D10_IA_VERTEX_INPUT_STRUCTURE_ELEMENT_COUNT ( 16 )")]
    public const int D3D10_IA_VERTEX_INPUT_STRUCTURE_ELEMENT_COUNT = (16);

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_INTEGER_DIVIDE_BY_ZERO_QUOTIENT"]/*' />
    [NativeTypeName("#define D3D10_INTEGER_DIVIDE_BY_ZERO_QUOTIENT ( 0xffffffff )")]
    public const uint D3D10_INTEGER_DIVIDE_BY_ZERO_QUOTIENT = (0xffffffff);

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_INTEGER_DIVIDE_BY_ZERO_REMAINDER"]/*' />
    [NativeTypeName("#define D3D10_INTEGER_DIVIDE_BY_ZERO_REMAINDER ( 0xffffffff )")]
    public const uint D3D10_INTEGER_DIVIDE_BY_ZERO_REMAINDER = (0xffffffff);

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_LINEAR_GAMMA"]/*' />
    [NativeTypeName("#define D3D10_LINEAR_GAMMA ( 1.0f )")]
    public const float D3D10_LINEAR_GAMMA = (1.0f);

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_MAX_BORDER_COLOR_COMPONENT"]/*' />
    [NativeTypeName("#define D3D10_MAX_BORDER_COLOR_COMPONENT ( 1.0f )")]
    public const float D3D10_MAX_BORDER_COLOR_COMPONENT = (1.0f);

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_MAX_DEPTH"]/*' />
    [NativeTypeName("#define D3D10_MAX_DEPTH ( 1.0f )")]
    public const float D3D10_MAX_DEPTH = (1.0f);

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_MAX_MAXANISOTROPY"]/*' />
    [NativeTypeName("#define D3D10_MAX_MAXANISOTROPY ( 16 )")]
    public const int D3D10_MAX_MAXANISOTROPY = (16);

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_MAX_MULTISAMPLE_SAMPLE_COUNT"]/*' />
    [NativeTypeName("#define D3D10_MAX_MULTISAMPLE_SAMPLE_COUNT ( 32 )")]
    public const int D3D10_MAX_MULTISAMPLE_SAMPLE_COUNT = (32);

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_MAX_POSITION_VALUE"]/*' />
    [NativeTypeName("#define D3D10_MAX_POSITION_VALUE ( 3.402823466e+34f )")]
    public const float D3D10_MAX_POSITION_VALUE = (3.402823466e+34f);

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_MAX_TEXTURE_DIMENSION_2_TO_EXP"]/*' />
    [NativeTypeName("#define D3D10_MAX_TEXTURE_DIMENSION_2_TO_EXP ( 17 )")]
    public const int D3D10_MAX_TEXTURE_DIMENSION_2_TO_EXP = (17);

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_MIN_BORDER_COLOR_COMPONENT"]/*' />
    [NativeTypeName("#define D3D10_MIN_BORDER_COLOR_COMPONENT ( 0.0f )")]
    public const float D3D10_MIN_BORDER_COLOR_COMPONENT = (0.0f);

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_MIN_DEPTH"]/*' />
    [NativeTypeName("#define D3D10_MIN_DEPTH ( 0.0f )")]
    public const float D3D10_MIN_DEPTH = (0.0f);

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_MIN_MAXANISOTROPY"]/*' />
    [NativeTypeName("#define D3D10_MIN_MAXANISOTROPY ( 0 )")]
    public const int D3D10_MIN_MAXANISOTROPY = (0);

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_MIP_LOD_BIAS_MAX"]/*' />
    [NativeTypeName("#define D3D10_MIP_LOD_BIAS_MAX ( 15.99f )")]
    public const float D3D10_MIP_LOD_BIAS_MAX = (15.99f);

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_MIP_LOD_BIAS_MIN"]/*' />
    [NativeTypeName("#define D3D10_MIP_LOD_BIAS_MIN ( -16.0f )")]
    public const float D3D10_MIP_LOD_BIAS_MIN = (-16.0f);

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_MIP_LOD_FRACTIONAL_BIT_COUNT"]/*' />
    [NativeTypeName("#define D3D10_MIP_LOD_FRACTIONAL_BIT_COUNT ( 6 )")]
    public const int D3D10_MIP_LOD_FRACTIONAL_BIT_COUNT = (6);

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_MIP_LOD_RANGE_BIT_COUNT"]/*' />
    [NativeTypeName("#define D3D10_MIP_LOD_RANGE_BIT_COUNT ( 8 )")]
    public const int D3D10_MIP_LOD_RANGE_BIT_COUNT = (8);

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_MULTISAMPLE_ANTIALIAS_LINE_WIDTH"]/*' />
    [NativeTypeName("#define D3D10_MULTISAMPLE_ANTIALIAS_LINE_WIDTH ( 1.4f )")]
    public const float D3D10_MULTISAMPLE_ANTIALIAS_LINE_WIDTH = (1.4f);

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_NONSAMPLE_FETCH_OUT_OF_RANGE_ACCESS_RESULT"]/*' />
    [NativeTypeName("#define D3D10_NONSAMPLE_FETCH_OUT_OF_RANGE_ACCESS_RESULT ( 0 )")]
    public const int D3D10_NONSAMPLE_FETCH_OUT_OF_RANGE_ACCESS_RESULT = (0);

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_PIXEL_ADDRESS_RANGE_BIT_COUNT"]/*' />
    [NativeTypeName("#define D3D10_PIXEL_ADDRESS_RANGE_BIT_COUNT ( 13 )")]
    public const int D3D10_PIXEL_ADDRESS_RANGE_BIT_COUNT = (13);

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_PRE_SCISSOR_PIXEL_ADDRESS_RANGE_BIT_COUNT"]/*' />
    [NativeTypeName("#define D3D10_PRE_SCISSOR_PIXEL_ADDRESS_RANGE_BIT_COUNT ( 15 )")]
    public const int D3D10_PRE_SCISSOR_PIXEL_ADDRESS_RANGE_BIT_COUNT = (15);

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_PS_FRONTFACING_DEFAULT_VALUE"]/*' />
    [NativeTypeName("#define D3D10_PS_FRONTFACING_DEFAULT_VALUE ( 0xffffffff )")]
    public const uint D3D10_PS_FRONTFACING_DEFAULT_VALUE = (0xffffffff);

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_PS_FRONTFACING_FALSE_VALUE"]/*' />
    [NativeTypeName("#define D3D10_PS_FRONTFACING_FALSE_VALUE ( 0 )")]
    public const int D3D10_PS_FRONTFACING_FALSE_VALUE = (0);

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_PS_FRONTFACING_TRUE_VALUE"]/*' />
    [NativeTypeName("#define D3D10_PS_FRONTFACING_TRUE_VALUE ( 0xffffffff )")]
    public const uint D3D10_PS_FRONTFACING_TRUE_VALUE = (0xffffffff);

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_PS_INPUT_REGISTER_COMPONENTS"]/*' />
    [NativeTypeName("#define D3D10_PS_INPUT_REGISTER_COMPONENTS ( 4 )")]
    public const int D3D10_PS_INPUT_REGISTER_COMPONENTS = (4);

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_PS_INPUT_REGISTER_COMPONENT_BIT_COUNT"]/*' />
    [NativeTypeName("#define D3D10_PS_INPUT_REGISTER_COMPONENT_BIT_COUNT ( 32 )")]
    public const int D3D10_PS_INPUT_REGISTER_COMPONENT_BIT_COUNT = (32);

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_PS_INPUT_REGISTER_COUNT"]/*' />
    [NativeTypeName("#define D3D10_PS_INPUT_REGISTER_COUNT ( 32 )")]
    public const int D3D10_PS_INPUT_REGISTER_COUNT = (32);

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_PS_INPUT_REGISTER_READS_PER_INST"]/*' />
    [NativeTypeName("#define D3D10_PS_INPUT_REGISTER_READS_PER_INST ( 2 )")]
    public const int D3D10_PS_INPUT_REGISTER_READS_PER_INST = (2);

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_PS_INPUT_REGISTER_READ_PORTS"]/*' />
    [NativeTypeName("#define D3D10_PS_INPUT_REGISTER_READ_PORTS ( 1 )")]
    public const int D3D10_PS_INPUT_REGISTER_READ_PORTS = (1);

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_PS_LEGACY_PIXEL_CENTER_FRACTIONAL_COMPONENT"]/*' />
    [NativeTypeName("#define D3D10_PS_LEGACY_PIXEL_CENTER_FRACTIONAL_COMPONENT ( 0.0f )")]
    public const float D3D10_PS_LEGACY_PIXEL_CENTER_FRACTIONAL_COMPONENT = (0.0f);

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_PS_OUTPUT_DEPTH_REGISTER_COMPONENTS"]/*' />
    [NativeTypeName("#define D3D10_PS_OUTPUT_DEPTH_REGISTER_COMPONENTS ( 1 )")]
    public const int D3D10_PS_OUTPUT_DEPTH_REGISTER_COMPONENTS = (1);

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_PS_OUTPUT_DEPTH_REGISTER_COMPONENT_BIT_COUNT"]/*' />
    [NativeTypeName("#define D3D10_PS_OUTPUT_DEPTH_REGISTER_COMPONENT_BIT_COUNT ( 32 )")]
    public const int D3D10_PS_OUTPUT_DEPTH_REGISTER_COMPONENT_BIT_COUNT = (32);

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_PS_OUTPUT_DEPTH_REGISTER_COUNT"]/*' />
    [NativeTypeName("#define D3D10_PS_OUTPUT_DEPTH_REGISTER_COUNT ( 1 )")]
    public const int D3D10_PS_OUTPUT_DEPTH_REGISTER_COUNT = (1);

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_PS_OUTPUT_REGISTER_COMPONENTS"]/*' />
    [NativeTypeName("#define D3D10_PS_OUTPUT_REGISTER_COMPONENTS ( 4 )")]
    public const int D3D10_PS_OUTPUT_REGISTER_COMPONENTS = (4);

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_PS_OUTPUT_REGISTER_COMPONENT_BIT_COUNT"]/*' />
    [NativeTypeName("#define D3D10_PS_OUTPUT_REGISTER_COMPONENT_BIT_COUNT ( 32 )")]
    public const int D3D10_PS_OUTPUT_REGISTER_COMPONENT_BIT_COUNT = (32);

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_PS_OUTPUT_REGISTER_COUNT"]/*' />
    [NativeTypeName("#define D3D10_PS_OUTPUT_REGISTER_COUNT ( 8 )")]
    public const int D3D10_PS_OUTPUT_REGISTER_COUNT = (8);

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_PS_PIXEL_CENTER_FRACTIONAL_COMPONENT"]/*' />
    [NativeTypeName("#define D3D10_PS_PIXEL_CENTER_FRACTIONAL_COMPONENT ( 0.5f )")]
    public const float D3D10_PS_PIXEL_CENTER_FRACTIONAL_COMPONENT = (0.5f);

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_REQ_BLEND_OBJECT_COUNT_PER_CONTEXT"]/*' />
    [NativeTypeName("#define D3D10_REQ_BLEND_OBJECT_COUNT_PER_CONTEXT ( 4096 )")]
    public const int D3D10_REQ_BLEND_OBJECT_COUNT_PER_CONTEXT = (4096);

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_REQ_BUFFER_RESOURCE_TEXEL_COUNT_2_TO_EXP"]/*' />
    [NativeTypeName("#define D3D10_REQ_BUFFER_RESOURCE_TEXEL_COUNT_2_TO_EXP ( 27 )")]
    public const int D3D10_REQ_BUFFER_RESOURCE_TEXEL_COUNT_2_TO_EXP = (27);

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_REQ_CONSTANT_BUFFER_ELEMENT_COUNT"]/*' />
    [NativeTypeName("#define D3D10_REQ_CONSTANT_BUFFER_ELEMENT_COUNT ( 4096 )")]
    public const int D3D10_REQ_CONSTANT_BUFFER_ELEMENT_COUNT = (4096);

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_REQ_DEPTH_STENCIL_OBJECT_COUNT_PER_CONTEXT"]/*' />
    [NativeTypeName("#define D3D10_REQ_DEPTH_STENCIL_OBJECT_COUNT_PER_CONTEXT ( 4096 )")]
    public const int D3D10_REQ_DEPTH_STENCIL_OBJECT_COUNT_PER_CONTEXT = (4096);

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_REQ_DRAWINDEXED_INDEX_COUNT_2_TO_EXP"]/*' />
    [NativeTypeName("#define D3D10_REQ_DRAWINDEXED_INDEX_COUNT_2_TO_EXP ( 32 )")]
    public const int D3D10_REQ_DRAWINDEXED_INDEX_COUNT_2_TO_EXP = (32);

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_REQ_DRAW_VERTEX_COUNT_2_TO_EXP"]/*' />
    [NativeTypeName("#define D3D10_REQ_DRAW_VERTEX_COUNT_2_TO_EXP ( 32 )")]
    public const int D3D10_REQ_DRAW_VERTEX_COUNT_2_TO_EXP = (32);

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_REQ_FILTERING_HW_ADDRESSABLE_RESOURCE_DIMENSION"]/*' />
    [NativeTypeName("#define D3D10_REQ_FILTERING_HW_ADDRESSABLE_RESOURCE_DIMENSION ( 8192 )")]
    public const int D3D10_REQ_FILTERING_HW_ADDRESSABLE_RESOURCE_DIMENSION = (8192);

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_REQ_GS_INVOCATION_32BIT_OUTPUT_COMPONENT_LIMIT"]/*' />
    [NativeTypeName("#define D3D10_REQ_GS_INVOCATION_32BIT_OUTPUT_COMPONENT_LIMIT ( 1024 )")]
    public const int D3D10_REQ_GS_INVOCATION_32BIT_OUTPUT_COMPONENT_LIMIT = (1024);

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_REQ_IMMEDIATE_CONSTANT_BUFFER_ELEMENT_COUNT"]/*' />
    [NativeTypeName("#define D3D10_REQ_IMMEDIATE_CONSTANT_BUFFER_ELEMENT_COUNT ( 4096 )")]
    public const int D3D10_REQ_IMMEDIATE_CONSTANT_BUFFER_ELEMENT_COUNT = (4096);

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_REQ_MAXANISOTROPY"]/*' />
    [NativeTypeName("#define D3D10_REQ_MAXANISOTROPY ( 16 )")]
    public const int D3D10_REQ_MAXANISOTROPY = (16);

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_REQ_MIP_LEVELS"]/*' />
    [NativeTypeName("#define D3D10_REQ_MIP_LEVELS ( 14 )")]
    public const int D3D10_REQ_MIP_LEVELS = (14);

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_REQ_MULTI_ELEMENT_STRUCTURE_SIZE_IN_BYTES"]/*' />
    [NativeTypeName("#define D3D10_REQ_MULTI_ELEMENT_STRUCTURE_SIZE_IN_BYTES ( 2048 )")]
    public const int D3D10_REQ_MULTI_ELEMENT_STRUCTURE_SIZE_IN_BYTES = (2048);

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_REQ_RASTERIZER_OBJECT_COUNT_PER_CONTEXT"]/*' />
    [NativeTypeName("#define D3D10_REQ_RASTERIZER_OBJECT_COUNT_PER_CONTEXT ( 4096 )")]
    public const int D3D10_REQ_RASTERIZER_OBJECT_COUNT_PER_CONTEXT = (4096);

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_REQ_RENDER_TO_BUFFER_WINDOW_WIDTH"]/*' />
    [NativeTypeName("#define D3D10_REQ_RENDER_TO_BUFFER_WINDOW_WIDTH ( 8192 )")]
    public const int D3D10_REQ_RENDER_TO_BUFFER_WINDOW_WIDTH = (8192);

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_REQ_RESOURCE_SIZE_IN_MEGABYTES"]/*' />
    [NativeTypeName("#define D3D10_REQ_RESOURCE_SIZE_IN_MEGABYTES ( 128 )")]
    public const int D3D10_REQ_RESOURCE_SIZE_IN_MEGABYTES = (128);

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_REQ_RESOURCE_VIEW_COUNT_PER_CONTEXT_2_TO_EXP"]/*' />
    [NativeTypeName("#define D3D10_REQ_RESOURCE_VIEW_COUNT_PER_CONTEXT_2_TO_EXP ( 20 )")]
    public const int D3D10_REQ_RESOURCE_VIEW_COUNT_PER_CONTEXT_2_TO_EXP = (20);

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_REQ_SAMPLER_OBJECT_COUNT_PER_CONTEXT"]/*' />
    [NativeTypeName("#define D3D10_REQ_SAMPLER_OBJECT_COUNT_PER_CONTEXT ( 4096 )")]
    public const int D3D10_REQ_SAMPLER_OBJECT_COUNT_PER_CONTEXT = (4096);

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_REQ_TEXTURE1D_ARRAY_AXIS_DIMENSION"]/*' />
    [NativeTypeName("#define D3D10_REQ_TEXTURE1D_ARRAY_AXIS_DIMENSION ( 512 )")]
    public const int D3D10_REQ_TEXTURE1D_ARRAY_AXIS_DIMENSION = (512);

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_REQ_TEXTURE1D_U_DIMENSION"]/*' />
    [NativeTypeName("#define D3D10_REQ_TEXTURE1D_U_DIMENSION ( 8192 )")]
    public const int D3D10_REQ_TEXTURE1D_U_DIMENSION = (8192);

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_REQ_TEXTURE2D_ARRAY_AXIS_DIMENSION"]/*' />
    [NativeTypeName("#define D3D10_REQ_TEXTURE2D_ARRAY_AXIS_DIMENSION ( 512 )")]
    public const int D3D10_REQ_TEXTURE2D_ARRAY_AXIS_DIMENSION = (512);

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_REQ_TEXTURE2D_U_OR_V_DIMENSION"]/*' />
    [NativeTypeName("#define D3D10_REQ_TEXTURE2D_U_OR_V_DIMENSION ( 8192 )")]
    public const int D3D10_REQ_TEXTURE2D_U_OR_V_DIMENSION = (8192);

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_REQ_TEXTURE3D_U_V_OR_W_DIMENSION"]/*' />
    [NativeTypeName("#define D3D10_REQ_TEXTURE3D_U_V_OR_W_DIMENSION ( 2048 )")]
    public const int D3D10_REQ_TEXTURE3D_U_V_OR_W_DIMENSION = (2048);

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_REQ_TEXTURECUBE_DIMENSION"]/*' />
    [NativeTypeName("#define D3D10_REQ_TEXTURECUBE_DIMENSION ( 8192 )")]
    public const int D3D10_REQ_TEXTURECUBE_DIMENSION = (8192);

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_RESINFO_INSTRUCTION_MISSING_COMPONENT_RETVAL"]/*' />
    [NativeTypeName("#define D3D10_RESINFO_INSTRUCTION_MISSING_COMPONENT_RETVAL ( 0 )")]
    public const int D3D10_RESINFO_INSTRUCTION_MISSING_COMPONENT_RETVAL = (0);

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_SHADER_MAJOR_VERSION"]/*' />
    [NativeTypeName("#define D3D10_SHADER_MAJOR_VERSION ( 4 )")]
    public const int D3D10_SHADER_MAJOR_VERSION = (4);

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_SHADER_MINOR_VERSION"]/*' />
    [NativeTypeName("#define D3D10_SHADER_MINOR_VERSION ( 0 )")]
    public const int D3D10_SHADER_MINOR_VERSION = (0);

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_SHIFT_INSTRUCTION_PAD_VALUE"]/*' />
    [NativeTypeName("#define D3D10_SHIFT_INSTRUCTION_PAD_VALUE ( 0 )")]
    public const int D3D10_SHIFT_INSTRUCTION_PAD_VALUE = (0);

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_SHIFT_INSTRUCTION_SHIFT_VALUE_BIT_COUNT"]/*' />
    [NativeTypeName("#define D3D10_SHIFT_INSTRUCTION_SHIFT_VALUE_BIT_COUNT ( 5 )")]
    public const int D3D10_SHIFT_INSTRUCTION_SHIFT_VALUE_BIT_COUNT = (5);

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_SIMULTANEOUS_RENDER_TARGET_COUNT"]/*' />
    [NativeTypeName("#define D3D10_SIMULTANEOUS_RENDER_TARGET_COUNT ( 8 )")]
    public const int D3D10_SIMULTANEOUS_RENDER_TARGET_COUNT = (8);

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_SO_BUFFER_MAX_STRIDE_IN_BYTES"]/*' />
    [NativeTypeName("#define D3D10_SO_BUFFER_MAX_STRIDE_IN_BYTES ( 2048 )")]
    public const int D3D10_SO_BUFFER_MAX_STRIDE_IN_BYTES = (2048);

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_SO_BUFFER_MAX_WRITE_WINDOW_IN_BYTES"]/*' />
    [NativeTypeName("#define D3D10_SO_BUFFER_MAX_WRITE_WINDOW_IN_BYTES ( 256 )")]
    public const int D3D10_SO_BUFFER_MAX_WRITE_WINDOW_IN_BYTES = (256);

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_SO_BUFFER_SLOT_COUNT"]/*' />
    [NativeTypeName("#define D3D10_SO_BUFFER_SLOT_COUNT ( 4 )")]
    public const int D3D10_SO_BUFFER_SLOT_COUNT = (4);

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_SO_DDI_REGISTER_INDEX_DENOTING_GAP"]/*' />
    [NativeTypeName("#define D3D10_SO_DDI_REGISTER_INDEX_DENOTING_GAP ( 0xffffffff )")]
    public const uint D3D10_SO_DDI_REGISTER_INDEX_DENOTING_GAP = (0xffffffff);

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_SO_MULTIPLE_BUFFER_ELEMENTS_PER_BUFFER"]/*' />
    [NativeTypeName("#define D3D10_SO_MULTIPLE_BUFFER_ELEMENTS_PER_BUFFER ( 1 )")]
    public const int D3D10_SO_MULTIPLE_BUFFER_ELEMENTS_PER_BUFFER = (1);

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_SO_SINGLE_BUFFER_COMPONENT_LIMIT"]/*' />
    [NativeTypeName("#define D3D10_SO_SINGLE_BUFFER_COMPONENT_LIMIT ( 64 )")]
    public const int D3D10_SO_SINGLE_BUFFER_COMPONENT_LIMIT = (64);

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_SRGB_GAMMA"]/*' />
    [NativeTypeName("#define D3D10_SRGB_GAMMA ( 2.2f )")]
    public const float D3D10_SRGB_GAMMA = (2.2f);

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_SRGB_TO_FLOAT_DENOMINATOR_1"]/*' />
    [NativeTypeName("#define D3D10_SRGB_TO_FLOAT_DENOMINATOR_1 ( 12.92f )")]
    public const float D3D10_SRGB_TO_FLOAT_DENOMINATOR_1 = (12.92f);

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_SRGB_TO_FLOAT_DENOMINATOR_2"]/*' />
    [NativeTypeName("#define D3D10_SRGB_TO_FLOAT_DENOMINATOR_2 ( 1.055f )")]
    public const float D3D10_SRGB_TO_FLOAT_DENOMINATOR_2 = (1.055f);

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_SRGB_TO_FLOAT_EXPONENT"]/*' />
    [NativeTypeName("#define D3D10_SRGB_TO_FLOAT_EXPONENT ( 2.4f )")]
    public const float D3D10_SRGB_TO_FLOAT_EXPONENT = (2.4f);

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_SRGB_TO_FLOAT_OFFSET"]/*' />
    [NativeTypeName("#define D3D10_SRGB_TO_FLOAT_OFFSET ( 0.055f )")]
    public const float D3D10_SRGB_TO_FLOAT_OFFSET = (0.055f);

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_SRGB_TO_FLOAT_THRESHOLD"]/*' />
    [NativeTypeName("#define D3D10_SRGB_TO_FLOAT_THRESHOLD ( 0.04045f )")]
    public const float D3D10_SRGB_TO_FLOAT_THRESHOLD = (0.04045f);

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_SRGB_TO_FLOAT_TOLERANCE_IN_ULP"]/*' />
    [NativeTypeName("#define D3D10_SRGB_TO_FLOAT_TOLERANCE_IN_ULP ( 0.5f )")]
    public const float D3D10_SRGB_TO_FLOAT_TOLERANCE_IN_ULP = (0.5f);

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_STANDARD_COMPONENT_BIT_COUNT"]/*' />
    [NativeTypeName("#define D3D10_STANDARD_COMPONENT_BIT_COUNT ( 32 )")]
    public const int D3D10_STANDARD_COMPONENT_BIT_COUNT = (32);

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_STANDARD_COMPONENT_BIT_COUNT_DOUBLED"]/*' />
    [NativeTypeName("#define D3D10_STANDARD_COMPONENT_BIT_COUNT_DOUBLED ( 64 )")]
    public const int D3D10_STANDARD_COMPONENT_BIT_COUNT_DOUBLED = (64);

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_STANDARD_MAXIMUM_ELEMENT_ALIGNMENT_BYTE_MULTIPLE"]/*' />
    [NativeTypeName("#define D3D10_STANDARD_MAXIMUM_ELEMENT_ALIGNMENT_BYTE_MULTIPLE ( 4 )")]
    public const int D3D10_STANDARD_MAXIMUM_ELEMENT_ALIGNMENT_BYTE_MULTIPLE = (4);

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_STANDARD_PIXEL_COMPONENT_COUNT"]/*' />
    [NativeTypeName("#define D3D10_STANDARD_PIXEL_COMPONENT_COUNT ( 128 )")]
    public const int D3D10_STANDARD_PIXEL_COMPONENT_COUNT = (128);

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_STANDARD_PIXEL_ELEMENT_COUNT"]/*' />
    [NativeTypeName("#define D3D10_STANDARD_PIXEL_ELEMENT_COUNT ( 32 )")]
    public const int D3D10_STANDARD_PIXEL_ELEMENT_COUNT = (32);

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_STANDARD_VECTOR_SIZE"]/*' />
    [NativeTypeName("#define D3D10_STANDARD_VECTOR_SIZE ( 4 )")]
    public const int D3D10_STANDARD_VECTOR_SIZE = (4);

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_STANDARD_VERTEX_ELEMENT_COUNT"]/*' />
    [NativeTypeName("#define D3D10_STANDARD_VERTEX_ELEMENT_COUNT ( 16 )")]
    public const int D3D10_STANDARD_VERTEX_ELEMENT_COUNT = (16);

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_STANDARD_VERTEX_TOTAL_COMPONENT_COUNT"]/*' />
    [NativeTypeName("#define D3D10_STANDARD_VERTEX_TOTAL_COMPONENT_COUNT ( 64 )")]
    public const int D3D10_STANDARD_VERTEX_TOTAL_COMPONENT_COUNT = (64);

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_SUBPIXEL_FRACTIONAL_BIT_COUNT"]/*' />
    [NativeTypeName("#define D3D10_SUBPIXEL_FRACTIONAL_BIT_COUNT ( 8 )")]
    public const int D3D10_SUBPIXEL_FRACTIONAL_BIT_COUNT = (8);

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_SUBTEXEL_FRACTIONAL_BIT_COUNT"]/*' />
    [NativeTypeName("#define D3D10_SUBTEXEL_FRACTIONAL_BIT_COUNT ( 6 )")]
    public const int D3D10_SUBTEXEL_FRACTIONAL_BIT_COUNT = (6);

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_TEXEL_ADDRESS_RANGE_BIT_COUNT"]/*' />
    [NativeTypeName("#define D3D10_TEXEL_ADDRESS_RANGE_BIT_COUNT ( 18 )")]
    public const int D3D10_TEXEL_ADDRESS_RANGE_BIT_COUNT = (18);

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_UNBOUND_MEMORY_ACCESS_RESULT"]/*' />
    [NativeTypeName("#define D3D10_UNBOUND_MEMORY_ACCESS_RESULT ( 0 )")]
    public const int D3D10_UNBOUND_MEMORY_ACCESS_RESULT = (0);

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_VIEWPORT_AND_SCISSORRECT_MAX_INDEX"]/*' />
    [NativeTypeName("#define D3D10_VIEWPORT_AND_SCISSORRECT_MAX_INDEX ( 15 )")]
    public const int D3D10_VIEWPORT_AND_SCISSORRECT_MAX_INDEX = (15);

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_VIEWPORT_AND_SCISSORRECT_OBJECT_COUNT_PER_PIPELINE"]/*' />
    [NativeTypeName("#define D3D10_VIEWPORT_AND_SCISSORRECT_OBJECT_COUNT_PER_PIPELINE ( 16 )")]
    public const int D3D10_VIEWPORT_AND_SCISSORRECT_OBJECT_COUNT_PER_PIPELINE = (16);

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_VIEWPORT_BOUNDS_MAX"]/*' />
    [NativeTypeName("#define D3D10_VIEWPORT_BOUNDS_MAX ( 16383 )")]
    public const int D3D10_VIEWPORT_BOUNDS_MAX = (16383);

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_VIEWPORT_BOUNDS_MIN"]/*' />
    [NativeTypeName("#define D3D10_VIEWPORT_BOUNDS_MIN ( -16384 )")]
    public const int D3D10_VIEWPORT_BOUNDS_MIN = (-16384);

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_VS_INPUT_REGISTER_COMPONENTS"]/*' />
    [NativeTypeName("#define D3D10_VS_INPUT_REGISTER_COMPONENTS ( 4 )")]
    public const int D3D10_VS_INPUT_REGISTER_COMPONENTS = (4);

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_VS_INPUT_REGISTER_COMPONENT_BIT_COUNT"]/*' />
    [NativeTypeName("#define D3D10_VS_INPUT_REGISTER_COMPONENT_BIT_COUNT ( 32 )")]
    public const int D3D10_VS_INPUT_REGISTER_COMPONENT_BIT_COUNT = (32);

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_VS_INPUT_REGISTER_COUNT"]/*' />
    [NativeTypeName("#define D3D10_VS_INPUT_REGISTER_COUNT ( 16 )")]
    public const int D3D10_VS_INPUT_REGISTER_COUNT = (16);

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_VS_INPUT_REGISTER_READS_PER_INST"]/*' />
    [NativeTypeName("#define D3D10_VS_INPUT_REGISTER_READS_PER_INST ( 2 )")]
    public const int D3D10_VS_INPUT_REGISTER_READS_PER_INST = (2);

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_VS_INPUT_REGISTER_READ_PORTS"]/*' />
    [NativeTypeName("#define D3D10_VS_INPUT_REGISTER_READ_PORTS ( 1 )")]
    public const int D3D10_VS_INPUT_REGISTER_READ_PORTS = (1);

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_VS_OUTPUT_REGISTER_COMPONENTS"]/*' />
    [NativeTypeName("#define D3D10_VS_OUTPUT_REGISTER_COMPONENTS ( 4 )")]
    public const int D3D10_VS_OUTPUT_REGISTER_COMPONENTS = (4);

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_VS_OUTPUT_REGISTER_COMPONENT_BIT_COUNT"]/*' />
    [NativeTypeName("#define D3D10_VS_OUTPUT_REGISTER_COMPONENT_BIT_COUNT ( 32 )")]
    public const int D3D10_VS_OUTPUT_REGISTER_COMPONENT_BIT_COUNT = (32);

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_VS_OUTPUT_REGISTER_COUNT"]/*' />
    [NativeTypeName("#define D3D10_VS_OUTPUT_REGISTER_COUNT ( 16 )")]
    public const int D3D10_VS_OUTPUT_REGISTER_COUNT = (16);

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_WHQL_CONTEXT_COUNT_FOR_RESOURCE_LIMIT"]/*' />
    [NativeTypeName("#define D3D10_WHQL_CONTEXT_COUNT_FOR_RESOURCE_LIMIT ( 10 )")]
    public const int D3D10_WHQL_CONTEXT_COUNT_FOR_RESOURCE_LIMIT = (10);

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_WHQL_DRAWINDEXED_INDEX_COUNT_2_TO_EXP"]/*' />
    [NativeTypeName("#define D3D10_WHQL_DRAWINDEXED_INDEX_COUNT_2_TO_EXP ( 25 )")]
    public const int D3D10_WHQL_DRAWINDEXED_INDEX_COUNT_2_TO_EXP = (25);

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_WHQL_DRAW_VERTEX_COUNT_2_TO_EXP"]/*' />
    [NativeTypeName("#define D3D10_WHQL_DRAW_VERTEX_COUNT_2_TO_EXP ( 25 )")]
    public const int D3D10_WHQL_DRAW_VERTEX_COUNT_2_TO_EXP = (25);

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_APPEND_ALIGNED_ELEMENT"]/*' />
    [NativeTypeName("#define D3D10_APPEND_ALIGNED_ELEMENT ( 0xffffffff )")]
    public const uint D3D10_APPEND_ALIGNED_ELEMENT = (0xffffffff);

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_FILTER_TYPE_MASK"]/*' />
    [NativeTypeName("#define D3D10_FILTER_TYPE_MASK ( 0x3 )")]
    public const int D3D10_FILTER_TYPE_MASK = (0x3);

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_MIN_FILTER_SHIFT"]/*' />
    [NativeTypeName("#define D3D10_MIN_FILTER_SHIFT ( 4 )")]
    public const int D3D10_MIN_FILTER_SHIFT = (4);

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_MAG_FILTER_SHIFT"]/*' />
    [NativeTypeName("#define D3D10_MAG_FILTER_SHIFT ( 2 )")]
    public const int D3D10_MAG_FILTER_SHIFT = (2);

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_MIP_FILTER_SHIFT"]/*' />
    [NativeTypeName("#define D3D10_MIP_FILTER_SHIFT ( 0 )")]
    public const int D3D10_MIP_FILTER_SHIFT = (0);

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_COMPARISON_FILTERING_BIT"]/*' />
    [NativeTypeName("#define D3D10_COMPARISON_FILTERING_BIT ( 0x80 )")]
    public const int D3D10_COMPARISON_FILTERING_BIT = (0x80);

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_ANISOTROPIC_FILTERING_BIT"]/*' />
    [NativeTypeName("#define D3D10_ANISOTROPIC_FILTERING_BIT ( 0x40 )")]
    public const int D3D10_ANISOTROPIC_FILTERING_BIT = (0x40);

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_TEXT_1BIT_BIT"]/*' />
    [NativeTypeName("#define D3D10_TEXT_1BIT_BIT ( 0x80000000 )")]
    public const uint D3D10_TEXT_1BIT_BIT = (0x80000000);

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_SDK_VERSION"]/*' />
    [NativeTypeName("#define D3D10_SDK_VERSION ( 29 )")]
    public const int D3D10_SDK_VERSION = (29);
}
