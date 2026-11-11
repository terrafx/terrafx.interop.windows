// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class STATUS
{
    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_WAIT_0"]/*' />
    [NativeTypeName("#define STATUS_WAIT_0 ((DWORD   )0x00000000L)")]
    public const uint STATUS_WAIT_0 = ((uint)(0x00000000));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_ABANDONED_WAIT_0"]/*' />
    [NativeTypeName("#define STATUS_ABANDONED_WAIT_0 ((DWORD   )0x00000080L)")]
    public const uint STATUS_ABANDONED_WAIT_0 = ((uint)(0x00000080));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_USER_APC"]/*' />
    [NativeTypeName("#define STATUS_USER_APC ((DWORD   )0x000000C0L)")]
    public const uint STATUS_USER_APC = ((uint)(0x000000C0));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_TIMEOUT"]/*' />
    [NativeTypeName("#define STATUS_TIMEOUT ((DWORD   )0x00000102L)")]
    public const uint STATUS_TIMEOUT = ((uint)(0x00000102));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_PENDING"]/*' />
    [NativeTypeName("#define STATUS_PENDING ((DWORD   )0x00000103L)")]
    public const uint STATUS_PENDING = ((uint)(0x00000103));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_SEGMENT_NOTIFICATION"]/*' />
    [NativeTypeName("#define STATUS_SEGMENT_NOTIFICATION ((DWORD   )0x40000005L)")]
    public const uint STATUS_SEGMENT_NOTIFICATION = ((uint)(0x40000005));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FATAL_APP_EXIT"]/*' />
    [NativeTypeName("#define STATUS_FATAL_APP_EXIT ((DWORD   )0x40000015L)")]
    public const uint STATUS_FATAL_APP_EXIT = ((uint)(0x40000015));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_GUARD_PAGE_VIOLATION"]/*' />
    [NativeTypeName("#define STATUS_GUARD_PAGE_VIOLATION ((DWORD   )0x80000001L)")]
    public const uint STATUS_GUARD_PAGE_VIOLATION = ((uint)(0x80000001));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_DATATYPE_MISALIGNMENT"]/*' />
    [NativeTypeName("#define STATUS_DATATYPE_MISALIGNMENT ((DWORD   )0x80000002L)")]
    public const uint STATUS_DATATYPE_MISALIGNMENT = ((uint)(0x80000002));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_BREAKPOINT"]/*' />
    [NativeTypeName("#define STATUS_BREAKPOINT ((DWORD   )0x80000003L)")]
    public const uint STATUS_BREAKPOINT = ((uint)(0x80000003));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_SINGLE_STEP"]/*' />
    [NativeTypeName("#define STATUS_SINGLE_STEP ((DWORD   )0x80000004L)")]
    public const uint STATUS_SINGLE_STEP = ((uint)(0x80000004));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_LONGJUMP"]/*' />
    [NativeTypeName("#define STATUS_LONGJUMP ((DWORD   )0x80000026L)")]
    public const uint STATUS_LONGJUMP = ((uint)(0x80000026));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_UNWIND_CONSOLIDATE"]/*' />
    [NativeTypeName("#define STATUS_UNWIND_CONSOLIDATE ((DWORD   )0x80000029L)")]
    public const uint STATUS_UNWIND_CONSOLIDATE = ((uint)(0x80000029));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_ACCESS_VIOLATION"]/*' />
    [NativeTypeName("#define STATUS_ACCESS_VIOLATION ((DWORD   )0xC0000005L)")]
    public const uint STATUS_ACCESS_VIOLATION = ((uint)(0xC0000005));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_IN_PAGE_ERROR"]/*' />
    [NativeTypeName("#define STATUS_IN_PAGE_ERROR ((DWORD   )0xC0000006L)")]
    public const uint STATUS_IN_PAGE_ERROR = ((uint)(0xC0000006));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_INVALID_HANDLE"]/*' />
    [NativeTypeName("#define STATUS_INVALID_HANDLE ((DWORD   )0xC0000008L)")]
    public const uint STATUS_INVALID_HANDLE = ((uint)(0xC0000008));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_INVALID_PARAMETER"]/*' />
    [NativeTypeName("#define STATUS_INVALID_PARAMETER ((DWORD   )0xC000000DL)")]
    public const uint STATUS_INVALID_PARAMETER = ((uint)(0xC000000D));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_NO_MEMORY"]/*' />
    [NativeTypeName("#define STATUS_NO_MEMORY ((DWORD   )0xC0000017L)")]
    public const uint STATUS_NO_MEMORY = ((uint)(0xC0000017));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_ILLEGAL_INSTRUCTION"]/*' />
    [NativeTypeName("#define STATUS_ILLEGAL_INSTRUCTION ((DWORD   )0xC000001DL)")]
    public const uint STATUS_ILLEGAL_INSTRUCTION = ((uint)(0xC000001D));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_NONCONTINUABLE_EXCEPTION"]/*' />
    [NativeTypeName("#define STATUS_NONCONTINUABLE_EXCEPTION ((DWORD   )0xC0000025L)")]
    public const uint STATUS_NONCONTINUABLE_EXCEPTION = ((uint)(0xC0000025));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_INVALID_DISPOSITION"]/*' />
    [NativeTypeName("#define STATUS_INVALID_DISPOSITION ((DWORD   )0xC0000026L)")]
    public const uint STATUS_INVALID_DISPOSITION = ((uint)(0xC0000026));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_ARRAY_BOUNDS_EXCEEDED"]/*' />
    [NativeTypeName("#define STATUS_ARRAY_BOUNDS_EXCEEDED ((DWORD   )0xC000008CL)")]
    public const uint STATUS_ARRAY_BOUNDS_EXCEEDED = ((uint)(0xC000008C));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FLOAT_DENORMAL_OPERAND"]/*' />
    [NativeTypeName("#define STATUS_FLOAT_DENORMAL_OPERAND ((DWORD   )0xC000008DL)")]
    public const uint STATUS_FLOAT_DENORMAL_OPERAND = ((uint)(0xC000008D));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FLOAT_DIVIDE_BY_ZERO"]/*' />
    [NativeTypeName("#define STATUS_FLOAT_DIVIDE_BY_ZERO ((DWORD   )0xC000008EL)")]
    public const uint STATUS_FLOAT_DIVIDE_BY_ZERO = ((uint)(0xC000008E));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FLOAT_INEXACT_RESULT"]/*' />
    [NativeTypeName("#define STATUS_FLOAT_INEXACT_RESULT ((DWORD   )0xC000008FL)")]
    public const uint STATUS_FLOAT_INEXACT_RESULT = ((uint)(0xC000008F));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FLOAT_INVALID_OPERATION"]/*' />
    [NativeTypeName("#define STATUS_FLOAT_INVALID_OPERATION ((DWORD   )0xC0000090L)")]
    public const uint STATUS_FLOAT_INVALID_OPERATION = ((uint)(0xC0000090));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FLOAT_OVERFLOW"]/*' />
    [NativeTypeName("#define STATUS_FLOAT_OVERFLOW ((DWORD   )0xC0000091L)")]
    public const uint STATUS_FLOAT_OVERFLOW = ((uint)(0xC0000091));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FLOAT_STACK_CHECK"]/*' />
    [NativeTypeName("#define STATUS_FLOAT_STACK_CHECK ((DWORD   )0xC0000092L)")]
    public const uint STATUS_FLOAT_STACK_CHECK = ((uint)(0xC0000092));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FLOAT_UNDERFLOW"]/*' />
    [NativeTypeName("#define STATUS_FLOAT_UNDERFLOW ((DWORD   )0xC0000093L)")]
    public const uint STATUS_FLOAT_UNDERFLOW = ((uint)(0xC0000093));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_INTEGER_DIVIDE_BY_ZERO"]/*' />
    [NativeTypeName("#define STATUS_INTEGER_DIVIDE_BY_ZERO ((DWORD   )0xC0000094L)")]
    public const uint STATUS_INTEGER_DIVIDE_BY_ZERO = ((uint)(0xC0000094));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_INTEGER_OVERFLOW"]/*' />
    [NativeTypeName("#define STATUS_INTEGER_OVERFLOW ((DWORD   )0xC0000095L)")]
    public const uint STATUS_INTEGER_OVERFLOW = ((uint)(0xC0000095));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_PRIVILEGED_INSTRUCTION"]/*' />
    [NativeTypeName("#define STATUS_PRIVILEGED_INSTRUCTION ((DWORD   )0xC0000096L)")]
    public const uint STATUS_PRIVILEGED_INSTRUCTION = ((uint)(0xC0000096));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_STACK_OVERFLOW"]/*' />
    [NativeTypeName("#define STATUS_STACK_OVERFLOW ((DWORD   )0xC00000FDL)")]
    public const uint STATUS_STACK_OVERFLOW = ((uint)(0xC00000FD));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_DLL_NOT_FOUND"]/*' />
    [NativeTypeName("#define STATUS_DLL_NOT_FOUND ((DWORD   )0xC0000135L)")]
    public const uint STATUS_DLL_NOT_FOUND = ((uint)(0xC0000135));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_ORDINAL_NOT_FOUND"]/*' />
    [NativeTypeName("#define STATUS_ORDINAL_NOT_FOUND ((DWORD   )0xC0000138L)")]
    public const uint STATUS_ORDINAL_NOT_FOUND = ((uint)(0xC0000138));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_ENTRYPOINT_NOT_FOUND"]/*' />
    [NativeTypeName("#define STATUS_ENTRYPOINT_NOT_FOUND ((DWORD   )0xC0000139L)")]
    public const uint STATUS_ENTRYPOINT_NOT_FOUND = ((uint)(0xC0000139));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_CONTROL_C_EXIT"]/*' />
    [NativeTypeName("#define STATUS_CONTROL_C_EXIT ((DWORD   )0xC000013AL)")]
    public const uint STATUS_CONTROL_C_EXIT = ((uint)(0xC000013A));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_DLL_INIT_FAILED"]/*' />
    [NativeTypeName("#define STATUS_DLL_INIT_FAILED ((DWORD   )0xC0000142L)")]
    public const uint STATUS_DLL_INIT_FAILED = ((uint)(0xC0000142));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_CONTROL_STACK_VIOLATION"]/*' />
    [NativeTypeName("#define STATUS_CONTROL_STACK_VIOLATION ((DWORD   )0xC00001B2L)")]
    public const uint STATUS_CONTROL_STACK_VIOLATION = ((uint)(0xC00001B2));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FLOAT_MULTIPLE_FAULTS"]/*' />
    [NativeTypeName("#define STATUS_FLOAT_MULTIPLE_FAULTS ((DWORD   )0xC00002B4L)")]
    public const uint STATUS_FLOAT_MULTIPLE_FAULTS = ((uint)(0xC00002B4));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_FLOAT_MULTIPLE_TRAPS"]/*' />
    [NativeTypeName("#define STATUS_FLOAT_MULTIPLE_TRAPS ((DWORD   )0xC00002B5L)")]
    public const uint STATUS_FLOAT_MULTIPLE_TRAPS = ((uint)(0xC00002B5));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_REG_NAT_CONSUMPTION"]/*' />
    [NativeTypeName("#define STATUS_REG_NAT_CONSUMPTION ((DWORD   )0xC00002C9L)")]
    public const uint STATUS_REG_NAT_CONSUMPTION = ((uint)(0xC00002C9));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_HEAP_CORRUPTION"]/*' />
    [NativeTypeName("#define STATUS_HEAP_CORRUPTION ((DWORD   )0xC0000374L)")]
    public const uint STATUS_HEAP_CORRUPTION = ((uint)(0xC0000374));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_STACK_BUFFER_OVERRUN"]/*' />
    [NativeTypeName("#define STATUS_STACK_BUFFER_OVERRUN ((DWORD   )0xC0000409L)")]
    public const uint STATUS_STACK_BUFFER_OVERRUN = ((uint)(0xC0000409));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_INVALID_CRUNTIME_PARAMETER"]/*' />
    [NativeTypeName("#define STATUS_INVALID_CRUNTIME_PARAMETER ((DWORD   )0xC0000417L)")]
    public const uint STATUS_INVALID_CRUNTIME_PARAMETER = ((uint)(0xC0000417));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_ASSERTION_FAILURE"]/*' />
    [NativeTypeName("#define STATUS_ASSERTION_FAILURE ((DWORD   )0xC0000420L)")]
    public const uint STATUS_ASSERTION_FAILURE = ((uint)(0xC0000420));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_ENCLAVE_VIOLATION"]/*' />
    [NativeTypeName("#define STATUS_ENCLAVE_VIOLATION ((DWORD   )0xC00004A2L)")]
    public const uint STATUS_ENCLAVE_VIOLATION = ((uint)(0xC00004A2));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_INTERRUPTED"]/*' />
    [NativeTypeName("#define STATUS_INTERRUPTED ((DWORD   )0xC0000515L)")]
    public const uint STATUS_INTERRUPTED = ((uint)(0xC0000515));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_THREAD_NOT_RUNNING"]/*' />
    [NativeTypeName("#define STATUS_THREAD_NOT_RUNNING ((DWORD   )0xC0000516L)")]
    public const uint STATUS_THREAD_NOT_RUNNING = ((uint)(0xC0000516));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_ALREADY_REGISTERED"]/*' />
    [NativeTypeName("#define STATUS_ALREADY_REGISTERED ((DWORD   )0xC0000718L)")]
    public const uint STATUS_ALREADY_REGISTERED = ((uint)(0xC0000718));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_SXS_EARLY_DEACTIVATION"]/*' />
    [NativeTypeName("#define STATUS_SXS_EARLY_DEACTIVATION ((DWORD   )0xC015000FL)")]
    public const uint STATUS_SXS_EARLY_DEACTIVATION = ((uint)(0xC015000F));

    /// <include file='STATUS.xml' path='doc/member[@name="STATUS.STATUS_SXS_INVALID_DEACTIVATION"]/*' />
    [NativeTypeName("#define STATUS_SXS_INVALID_DEACTIVATION ((DWORD   )0xC0150010L)")]
    public const uint STATUS_SXS_INVALID_DEACTIVATION = ((uint)(0xC0150010));
}
