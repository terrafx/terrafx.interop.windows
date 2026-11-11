// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/minwinbase.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class EXCEPTION
{
    /// <include file='EXCEPTION.xml' path='doc/member[@name="EXCEPTION.EXCEPTION_DEBUG_EVENT"]/*' />
    [NativeTypeName("#define EXCEPTION_DEBUG_EVENT 1")]
    public const int EXCEPTION_DEBUG_EVENT = 1;

    /// <include file='EXCEPTION.xml' path='doc/member[@name="EXCEPTION.EXCEPTION_ACCESS_VIOLATION"]/*' />
    [NativeTypeName("#define EXCEPTION_ACCESS_VIOLATION STATUS_ACCESS_VIOLATION")]
    public const uint EXCEPTION_ACCESS_VIOLATION = ((uint)(0xC0000005));

    /// <include file='EXCEPTION.xml' path='doc/member[@name="EXCEPTION.EXCEPTION_DATATYPE_MISALIGNMENT"]/*' />
    [NativeTypeName("#define EXCEPTION_DATATYPE_MISALIGNMENT STATUS_DATATYPE_MISALIGNMENT")]
    public const uint EXCEPTION_DATATYPE_MISALIGNMENT = ((uint)(0x80000002));

    /// <include file='EXCEPTION.xml' path='doc/member[@name="EXCEPTION.EXCEPTION_BREAKPOINT"]/*' />
    [NativeTypeName("#define EXCEPTION_BREAKPOINT STATUS_BREAKPOINT")]
    public const uint EXCEPTION_BREAKPOINT = ((uint)(0x80000003));

    /// <include file='EXCEPTION.xml' path='doc/member[@name="EXCEPTION.EXCEPTION_SINGLE_STEP"]/*' />
    [NativeTypeName("#define EXCEPTION_SINGLE_STEP STATUS_SINGLE_STEP")]
    public const uint EXCEPTION_SINGLE_STEP = ((uint)(0x80000004));

    /// <include file='EXCEPTION.xml' path='doc/member[@name="EXCEPTION.EXCEPTION_ARRAY_BOUNDS_EXCEEDED"]/*' />
    [NativeTypeName("#define EXCEPTION_ARRAY_BOUNDS_EXCEEDED STATUS_ARRAY_BOUNDS_EXCEEDED")]
    public const uint EXCEPTION_ARRAY_BOUNDS_EXCEEDED = ((uint)(0xC000008C));

    /// <include file='EXCEPTION.xml' path='doc/member[@name="EXCEPTION.EXCEPTION_FLT_DENORMAL_OPERAND"]/*' />
    [NativeTypeName("#define EXCEPTION_FLT_DENORMAL_OPERAND STATUS_FLOAT_DENORMAL_OPERAND")]
    public const uint EXCEPTION_FLT_DENORMAL_OPERAND = ((uint)(0xC000008D));

    /// <include file='EXCEPTION.xml' path='doc/member[@name="EXCEPTION.EXCEPTION_FLT_DIVIDE_BY_ZERO"]/*' />
    [NativeTypeName("#define EXCEPTION_FLT_DIVIDE_BY_ZERO STATUS_FLOAT_DIVIDE_BY_ZERO")]
    public const uint EXCEPTION_FLT_DIVIDE_BY_ZERO = ((uint)(0xC000008E));

    /// <include file='EXCEPTION.xml' path='doc/member[@name="EXCEPTION.EXCEPTION_FLT_INEXACT_RESULT"]/*' />
    [NativeTypeName("#define EXCEPTION_FLT_INEXACT_RESULT STATUS_FLOAT_INEXACT_RESULT")]
    public const uint EXCEPTION_FLT_INEXACT_RESULT = ((uint)(0xC000008F));

    /// <include file='EXCEPTION.xml' path='doc/member[@name="EXCEPTION.EXCEPTION_FLT_INVALID_OPERATION"]/*' />
    [NativeTypeName("#define EXCEPTION_FLT_INVALID_OPERATION STATUS_FLOAT_INVALID_OPERATION")]
    public const uint EXCEPTION_FLT_INVALID_OPERATION = ((uint)(0xC0000090));

    /// <include file='EXCEPTION.xml' path='doc/member[@name="EXCEPTION.EXCEPTION_FLT_OVERFLOW"]/*' />
    [NativeTypeName("#define EXCEPTION_FLT_OVERFLOW STATUS_FLOAT_OVERFLOW")]
    public const uint EXCEPTION_FLT_OVERFLOW = ((uint)(0xC0000091));

    /// <include file='EXCEPTION.xml' path='doc/member[@name="EXCEPTION.EXCEPTION_FLT_STACK_CHECK"]/*' />
    [NativeTypeName("#define EXCEPTION_FLT_STACK_CHECK STATUS_FLOAT_STACK_CHECK")]
    public const uint EXCEPTION_FLT_STACK_CHECK = ((uint)(0xC0000092));

    /// <include file='EXCEPTION.xml' path='doc/member[@name="EXCEPTION.EXCEPTION_FLT_UNDERFLOW"]/*' />
    [NativeTypeName("#define EXCEPTION_FLT_UNDERFLOW STATUS_FLOAT_UNDERFLOW")]
    public const uint EXCEPTION_FLT_UNDERFLOW = ((uint)(0xC0000093));

    /// <include file='EXCEPTION.xml' path='doc/member[@name="EXCEPTION.EXCEPTION_INT_DIVIDE_BY_ZERO"]/*' />
    [NativeTypeName("#define EXCEPTION_INT_DIVIDE_BY_ZERO STATUS_INTEGER_DIVIDE_BY_ZERO")]
    public const uint EXCEPTION_INT_DIVIDE_BY_ZERO = ((uint)(0xC0000094));

    /// <include file='EXCEPTION.xml' path='doc/member[@name="EXCEPTION.EXCEPTION_INT_OVERFLOW"]/*' />
    [NativeTypeName("#define EXCEPTION_INT_OVERFLOW STATUS_INTEGER_OVERFLOW")]
    public const uint EXCEPTION_INT_OVERFLOW = ((uint)(0xC0000095));

    /// <include file='EXCEPTION.xml' path='doc/member[@name="EXCEPTION.EXCEPTION_PRIV_INSTRUCTION"]/*' />
    [NativeTypeName("#define EXCEPTION_PRIV_INSTRUCTION STATUS_PRIVILEGED_INSTRUCTION")]
    public const uint EXCEPTION_PRIV_INSTRUCTION = ((uint)(0xC0000096));

    /// <include file='EXCEPTION.xml' path='doc/member[@name="EXCEPTION.EXCEPTION_IN_PAGE_ERROR"]/*' />
    [NativeTypeName("#define EXCEPTION_IN_PAGE_ERROR STATUS_IN_PAGE_ERROR")]
    public const uint EXCEPTION_IN_PAGE_ERROR = ((uint)(0xC0000006));

    /// <include file='EXCEPTION.xml' path='doc/member[@name="EXCEPTION.EXCEPTION_ILLEGAL_INSTRUCTION"]/*' />
    [NativeTypeName("#define EXCEPTION_ILLEGAL_INSTRUCTION STATUS_ILLEGAL_INSTRUCTION")]
    public const uint EXCEPTION_ILLEGAL_INSTRUCTION = ((uint)(0xC000001D));

    /// <include file='EXCEPTION.xml' path='doc/member[@name="EXCEPTION.EXCEPTION_NONCONTINUABLE_EXCEPTION"]/*' />
    [NativeTypeName("#define EXCEPTION_NONCONTINUABLE_EXCEPTION STATUS_NONCONTINUABLE_EXCEPTION")]
    public const uint EXCEPTION_NONCONTINUABLE_EXCEPTION = ((uint)(0xC0000025));

    /// <include file='EXCEPTION.xml' path='doc/member[@name="EXCEPTION.EXCEPTION_STACK_OVERFLOW"]/*' />
    [NativeTypeName("#define EXCEPTION_STACK_OVERFLOW STATUS_STACK_OVERFLOW")]
    public const uint EXCEPTION_STACK_OVERFLOW = ((uint)(0xC00000FD));

    /// <include file='EXCEPTION.xml' path='doc/member[@name="EXCEPTION.EXCEPTION_INVALID_DISPOSITION"]/*' />
    [NativeTypeName("#define EXCEPTION_INVALID_DISPOSITION STATUS_INVALID_DISPOSITION")]
    public const uint EXCEPTION_INVALID_DISPOSITION = ((uint)(0xC0000026));

    /// <include file='EXCEPTION.xml' path='doc/member[@name="EXCEPTION.EXCEPTION_GUARD_PAGE"]/*' />
    [NativeTypeName("#define EXCEPTION_GUARD_PAGE STATUS_GUARD_PAGE_VIOLATION")]
    public const uint EXCEPTION_GUARD_PAGE = ((uint)(0x80000001));

    /// <include file='EXCEPTION.xml' path='doc/member[@name="EXCEPTION.EXCEPTION_INVALID_HANDLE"]/*' />
    [NativeTypeName("#define EXCEPTION_INVALID_HANDLE STATUS_INVALID_HANDLE")]
    public const uint EXCEPTION_INVALID_HANDLE = ((uint)(0xC0000008));
}
