// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from cvconst.h in the Debug Interface Access SDK
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the MIT License (MIT).

namespace TerraFX.Interop.Windows;

/// <include file='CV_HLSLREG_e.xml' path='doc/member[@name="CV_HLSLREG_e"]/*' />
public enum CV_HLSLREG_e
{
    /// <include file='CV_HLSLREG_e.xml' path='doc/member[@name="CV_HLSLREG_e.CV_HLSLREG_TEMP"]/*' />
    CV_HLSLREG_TEMP = 0,

    /// <include file='CV_HLSLREG_e.xml' path='doc/member[@name="CV_HLSLREG_e.CV_HLSLREG_INPUT"]/*' />
    CV_HLSLREG_INPUT = 1,

    /// <include file='CV_HLSLREG_e.xml' path='doc/member[@name="CV_HLSLREG_e.CV_HLSLREG_OUTPUT"]/*' />
    CV_HLSLREG_OUTPUT = 2,

    /// <include file='CV_HLSLREG_e.xml' path='doc/member[@name="CV_HLSLREG_e.CV_HLSLREG_INDEXABLE_TEMP"]/*' />
    CV_HLSLREG_INDEXABLE_TEMP = 3,

    /// <include file='CV_HLSLREG_e.xml' path='doc/member[@name="CV_HLSLREG_e.CV_HLSLREG_IMMEDIATE32"]/*' />
    CV_HLSLREG_IMMEDIATE32 = 4,

    /// <include file='CV_HLSLREG_e.xml' path='doc/member[@name="CV_HLSLREG_e.CV_HLSLREG_IMMEDIATE64"]/*' />
    CV_HLSLREG_IMMEDIATE64 = 5,

    /// <include file='CV_HLSLREG_e.xml' path='doc/member[@name="CV_HLSLREG_e.CV_HLSLREG_SAMPLER"]/*' />
    CV_HLSLREG_SAMPLER = 6,

    /// <include file='CV_HLSLREG_e.xml' path='doc/member[@name="CV_HLSLREG_e.CV_HLSLREG_RESOURCE"]/*' />
    CV_HLSLREG_RESOURCE = 7,

    /// <include file='CV_HLSLREG_e.xml' path='doc/member[@name="CV_HLSLREG_e.CV_HLSLREG_CONSTANT_BUFFER"]/*' />
    CV_HLSLREG_CONSTANT_BUFFER = 8,

    /// <include file='CV_HLSLREG_e.xml' path='doc/member[@name="CV_HLSLREG_e.CV_HLSLREG_IMMEDIATE_CONSTANT_BUFFER"]/*' />
    CV_HLSLREG_IMMEDIATE_CONSTANT_BUFFER = 9,

    /// <include file='CV_HLSLREG_e.xml' path='doc/member[@name="CV_HLSLREG_e.CV_HLSLREG_LABEL"]/*' />
    CV_HLSLREG_LABEL = 10,

    /// <include file='CV_HLSLREG_e.xml' path='doc/member[@name="CV_HLSLREG_e.CV_HLSLREG_INPUT_PRIMITIVEID"]/*' />
    CV_HLSLREG_INPUT_PRIMITIVEID = 11,

    /// <include file='CV_HLSLREG_e.xml' path='doc/member[@name="CV_HLSLREG_e.CV_HLSLREG_OUTPUT_DEPTH"]/*' />
    CV_HLSLREG_OUTPUT_DEPTH = 12,

    /// <include file='CV_HLSLREG_e.xml' path='doc/member[@name="CV_HLSLREG_e.CV_HLSLREG_NULL"]/*' />
    CV_HLSLREG_NULL = 13,

    /// <include file='CV_HLSLREG_e.xml' path='doc/member[@name="CV_HLSLREG_e.CV_HLSLREG_RASTERIZER"]/*' />
    CV_HLSLREG_RASTERIZER = 14,

    /// <include file='CV_HLSLREG_e.xml' path='doc/member[@name="CV_HLSLREG_e.CV_HLSLREG_OUTPUT_COVERAGE_MASK"]/*' />
    CV_HLSLREG_OUTPUT_COVERAGE_MASK = 15,

    /// <include file='CV_HLSLREG_e.xml' path='doc/member[@name="CV_HLSLREG_e.CV_HLSLREG_STREAM"]/*' />
    CV_HLSLREG_STREAM = 16,

    /// <include file='CV_HLSLREG_e.xml' path='doc/member[@name="CV_HLSLREG_e.CV_HLSLREG_FUNCTION_BODY"]/*' />
    CV_HLSLREG_FUNCTION_BODY = 17,

    /// <include file='CV_HLSLREG_e.xml' path='doc/member[@name="CV_HLSLREG_e.CV_HLSLREG_FUNCTION_TABLE"]/*' />
    CV_HLSLREG_FUNCTION_TABLE = 18,

    /// <include file='CV_HLSLREG_e.xml' path='doc/member[@name="CV_HLSLREG_e.CV_HLSLREG_INTERFACE"]/*' />
    CV_HLSLREG_INTERFACE = 19,

    /// <include file='CV_HLSLREG_e.xml' path='doc/member[@name="CV_HLSLREG_e.CV_HLSLREG_FUNCTION_INPUT"]/*' />
    CV_HLSLREG_FUNCTION_INPUT = 20,

    /// <include file='CV_HLSLREG_e.xml' path='doc/member[@name="CV_HLSLREG_e.CV_HLSLREG_FUNCTION_OUTPUT"]/*' />
    CV_HLSLREG_FUNCTION_OUTPUT = 21,

    /// <include file='CV_HLSLREG_e.xml' path='doc/member[@name="CV_HLSLREG_e.CV_HLSLREG_OUTPUT_CONTROL_POINT_ID"]/*' />
    CV_HLSLREG_OUTPUT_CONTROL_POINT_ID = 22,

    /// <include file='CV_HLSLREG_e.xml' path='doc/member[@name="CV_HLSLREG_e.CV_HLSLREG_INPUT_FORK_INSTANCE_ID"]/*' />
    CV_HLSLREG_INPUT_FORK_INSTANCE_ID = 23,

    /// <include file='CV_HLSLREG_e.xml' path='doc/member[@name="CV_HLSLREG_e.CV_HLSLREG_INPUT_JOIN_INSTANCE_ID"]/*' />
    CV_HLSLREG_INPUT_JOIN_INSTANCE_ID = 24,

    /// <include file='CV_HLSLREG_e.xml' path='doc/member[@name="CV_HLSLREG_e.CV_HLSLREG_INPUT_CONTROL_POINT"]/*' />
    CV_HLSLREG_INPUT_CONTROL_POINT = 25,

    /// <include file='CV_HLSLREG_e.xml' path='doc/member[@name="CV_HLSLREG_e.CV_HLSLREG_OUTPUT_CONTROL_POINT"]/*' />
    CV_HLSLREG_OUTPUT_CONTROL_POINT = 26,

    /// <include file='CV_HLSLREG_e.xml' path='doc/member[@name="CV_HLSLREG_e.CV_HLSLREG_INPUT_PATCH_CONSTANT"]/*' />
    CV_HLSLREG_INPUT_PATCH_CONSTANT = 27,

    /// <include file='CV_HLSLREG_e.xml' path='doc/member[@name="CV_HLSLREG_e.CV_HLSLREG_INPUT_DOMAIN_POINT"]/*' />
    CV_HLSLREG_INPUT_DOMAIN_POINT = 28,

    /// <include file='CV_HLSLREG_e.xml' path='doc/member[@name="CV_HLSLREG_e.CV_HLSLREG_THIS_POINTER"]/*' />
    CV_HLSLREG_THIS_POINTER = 29,

    /// <include file='CV_HLSLREG_e.xml' path='doc/member[@name="CV_HLSLREG_e.CV_HLSLREG_UNORDERED_ACCESS_VIEW"]/*' />
    CV_HLSLREG_UNORDERED_ACCESS_VIEW = 30,

    /// <include file='CV_HLSLREG_e.xml' path='doc/member[@name="CV_HLSLREG_e.CV_HLSLREG_THREAD_GROUP_SHARED_MEMORY"]/*' />
    CV_HLSLREG_THREAD_GROUP_SHARED_MEMORY = 31,

    /// <include file='CV_HLSLREG_e.xml' path='doc/member[@name="CV_HLSLREG_e.CV_HLSLREG_INPUT_THREAD_ID"]/*' />
    CV_HLSLREG_INPUT_THREAD_ID = 32,

    /// <include file='CV_HLSLREG_e.xml' path='doc/member[@name="CV_HLSLREG_e.CV_HLSLREG_INPUT_THREAD_GROUP_ID"]/*' />
    CV_HLSLREG_INPUT_THREAD_GROUP_ID = 33,

    /// <include file='CV_HLSLREG_e.xml' path='doc/member[@name="CV_HLSLREG_e.CV_HLSLREG_INPUT_THREAD_ID_IN_GROUP"]/*' />
    CV_HLSLREG_INPUT_THREAD_ID_IN_GROUP = 34,

    /// <include file='CV_HLSLREG_e.xml' path='doc/member[@name="CV_HLSLREG_e.CV_HLSLREG_INPUT_COVERAGE_MASK"]/*' />
    CV_HLSLREG_INPUT_COVERAGE_MASK = 35,

    /// <include file='CV_HLSLREG_e.xml' path='doc/member[@name="CV_HLSLREG_e.CV_HLSLREG_INPUT_THREAD_ID_IN_GROUP_FLATTENED"]/*' />
    CV_HLSLREG_INPUT_THREAD_ID_IN_GROUP_FLATTENED = 36,

    /// <include file='CV_HLSLREG_e.xml' path='doc/member[@name="CV_HLSLREG_e.CV_HLSLREG_INPUT_GS_INSTANCE_ID"]/*' />
    CV_HLSLREG_INPUT_GS_INSTANCE_ID = 37,

    /// <include file='CV_HLSLREG_e.xml' path='doc/member[@name="CV_HLSLREG_e.CV_HLSLREG_OUTPUT_DEPTH_GREATER_EQUAL"]/*' />
    CV_HLSLREG_OUTPUT_DEPTH_GREATER_EQUAL = 38,

    /// <include file='CV_HLSLREG_e.xml' path='doc/member[@name="CV_HLSLREG_e.CV_HLSLREG_OUTPUT_DEPTH_LESS_EQUAL"]/*' />
    CV_HLSLREG_OUTPUT_DEPTH_LESS_EQUAL = 39,

    /// <include file='CV_HLSLREG_e.xml' path='doc/member[@name="CV_HLSLREG_e.CV_HLSLREG_CYCLE_COUNTER"]/*' />
    CV_HLSLREG_CYCLE_COUNTER = 40,
}
