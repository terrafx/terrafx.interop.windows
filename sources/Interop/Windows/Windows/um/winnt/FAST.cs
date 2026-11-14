// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class FAST
{
    /// <include file='FAST.xml' path='doc/member[@name="FAST.FAST_FAIL_LEGACY_GS_VIOLATION"]/*' />
    [NativeTypeName("#define FAST_FAIL_LEGACY_GS_VIOLATION 0")]
    public const int FAST_FAIL_LEGACY_GS_VIOLATION = 0;

    /// <include file='FAST.xml' path='doc/member[@name="FAST.FAST_FAIL_VTGUARD_CHECK_FAILURE"]/*' />
    [NativeTypeName("#define FAST_FAIL_VTGUARD_CHECK_FAILURE 1")]
    public const int FAST_FAIL_VTGUARD_CHECK_FAILURE = 1;

    /// <include file='FAST.xml' path='doc/member[@name="FAST.FAST_FAIL_STACK_COOKIE_CHECK_FAILURE"]/*' />
    [NativeTypeName("#define FAST_FAIL_STACK_COOKIE_CHECK_FAILURE 2")]
    public const int FAST_FAIL_STACK_COOKIE_CHECK_FAILURE = 2;

    /// <include file='FAST.xml' path='doc/member[@name="FAST.FAST_FAIL_CORRUPT_LIST_ENTRY"]/*' />
    [NativeTypeName("#define FAST_FAIL_CORRUPT_LIST_ENTRY 3")]
    public const int FAST_FAIL_CORRUPT_LIST_ENTRY = 3;

    /// <include file='FAST.xml' path='doc/member[@name="FAST.FAST_FAIL_INCORRECT_STACK"]/*' />
    [NativeTypeName("#define FAST_FAIL_INCORRECT_STACK 4")]
    public const int FAST_FAIL_INCORRECT_STACK = 4;

    /// <include file='FAST.xml' path='doc/member[@name="FAST.FAST_FAIL_INVALID_ARG"]/*' />
    [NativeTypeName("#define FAST_FAIL_INVALID_ARG 5")]
    public const int FAST_FAIL_INVALID_ARG = 5;

    /// <include file='FAST.xml' path='doc/member[@name="FAST.FAST_FAIL_GS_COOKIE_INIT"]/*' />
    [NativeTypeName("#define FAST_FAIL_GS_COOKIE_INIT 6")]
    public const int FAST_FAIL_GS_COOKIE_INIT = 6;

    /// <include file='FAST.xml' path='doc/member[@name="FAST.FAST_FAIL_FATAL_APP_EXIT"]/*' />
    [NativeTypeName("#define FAST_FAIL_FATAL_APP_EXIT 7")]
    public const int FAST_FAIL_FATAL_APP_EXIT = 7;

    /// <include file='FAST.xml' path='doc/member[@name="FAST.FAST_FAIL_RANGE_CHECK_FAILURE"]/*' />
    [NativeTypeName("#define FAST_FAIL_RANGE_CHECK_FAILURE 8")]
    public const int FAST_FAIL_RANGE_CHECK_FAILURE = 8;

    /// <include file='FAST.xml' path='doc/member[@name="FAST.FAST_FAIL_UNSAFE_REGISTRY_ACCESS"]/*' />
    [NativeTypeName("#define FAST_FAIL_UNSAFE_REGISTRY_ACCESS 9")]
    public const int FAST_FAIL_UNSAFE_REGISTRY_ACCESS = 9;

    /// <include file='FAST.xml' path='doc/member[@name="FAST.FAST_FAIL_GUARD_ICALL_CHECK_FAILURE"]/*' />
    [NativeTypeName("#define FAST_FAIL_GUARD_ICALL_CHECK_FAILURE 10")]
    public const int FAST_FAIL_GUARD_ICALL_CHECK_FAILURE = 10;

    /// <include file='FAST.xml' path='doc/member[@name="FAST.FAST_FAIL_GUARD_WRITE_CHECK_FAILURE"]/*' />
    [NativeTypeName("#define FAST_FAIL_GUARD_WRITE_CHECK_FAILURE 11")]
    public const int FAST_FAIL_GUARD_WRITE_CHECK_FAILURE = 11;

    /// <include file='FAST.xml' path='doc/member[@name="FAST.FAST_FAIL_INVALID_FIBER_SWITCH"]/*' />
    [NativeTypeName("#define FAST_FAIL_INVALID_FIBER_SWITCH 12")]
    public const int FAST_FAIL_INVALID_FIBER_SWITCH = 12;

    /// <include file='FAST.xml' path='doc/member[@name="FAST.FAST_FAIL_INVALID_SET_OF_CONTEXT"]/*' />
    [NativeTypeName("#define FAST_FAIL_INVALID_SET_OF_CONTEXT 13")]
    public const int FAST_FAIL_INVALID_SET_OF_CONTEXT = 13;

    /// <include file='FAST.xml' path='doc/member[@name="FAST.FAST_FAIL_INVALID_REFERENCE_COUNT"]/*' />
    [NativeTypeName("#define FAST_FAIL_INVALID_REFERENCE_COUNT 14")]
    public const int FAST_FAIL_INVALID_REFERENCE_COUNT = 14;

    /// <include file='FAST.xml' path='doc/member[@name="FAST.FAST_FAIL_INVALID_JUMP_BUFFER"]/*' />
    [NativeTypeName("#define FAST_FAIL_INVALID_JUMP_BUFFER 18")]
    public const int FAST_FAIL_INVALID_JUMP_BUFFER = 18;

    /// <include file='FAST.xml' path='doc/member[@name="FAST.FAST_FAIL_MRDATA_MODIFIED"]/*' />
    [NativeTypeName("#define FAST_FAIL_MRDATA_MODIFIED 19")]
    public const int FAST_FAIL_MRDATA_MODIFIED = 19;

    /// <include file='FAST.xml' path='doc/member[@name="FAST.FAST_FAIL_CERTIFICATION_FAILURE"]/*' />
    [NativeTypeName("#define FAST_FAIL_CERTIFICATION_FAILURE 20")]
    public const int FAST_FAIL_CERTIFICATION_FAILURE = 20;

    /// <include file='FAST.xml' path='doc/member[@name="FAST.FAST_FAIL_INVALID_EXCEPTION_CHAIN"]/*' />
    [NativeTypeName("#define FAST_FAIL_INVALID_EXCEPTION_CHAIN 21")]
    public const int FAST_FAIL_INVALID_EXCEPTION_CHAIN = 21;

    /// <include file='FAST.xml' path='doc/member[@name="FAST.FAST_FAIL_CRYPTO_LIBRARY"]/*' />
    [NativeTypeName("#define FAST_FAIL_CRYPTO_LIBRARY 22")]
    public const int FAST_FAIL_CRYPTO_LIBRARY = 22;

    /// <include file='FAST.xml' path='doc/member[@name="FAST.FAST_FAIL_INVALID_CALL_IN_DLL_CALLOUT"]/*' />
    [NativeTypeName("#define FAST_FAIL_INVALID_CALL_IN_DLL_CALLOUT 23")]
    public const int FAST_FAIL_INVALID_CALL_IN_DLL_CALLOUT = 23;

    /// <include file='FAST.xml' path='doc/member[@name="FAST.FAST_FAIL_INVALID_IMAGE_BASE"]/*' />
    [NativeTypeName("#define FAST_FAIL_INVALID_IMAGE_BASE 24")]
    public const int FAST_FAIL_INVALID_IMAGE_BASE = 24;

    /// <include file='FAST.xml' path='doc/member[@name="FAST.FAST_FAIL_DLOAD_PROTECTION_FAILURE"]/*' />
    [NativeTypeName("#define FAST_FAIL_DLOAD_PROTECTION_FAILURE 25")]
    public const int FAST_FAIL_DLOAD_PROTECTION_FAILURE = 25;

    /// <include file='FAST.xml' path='doc/member[@name="FAST.FAST_FAIL_UNSAFE_EXTENSION_CALL"]/*' />
    [NativeTypeName("#define FAST_FAIL_UNSAFE_EXTENSION_CALL 26")]
    public const int FAST_FAIL_UNSAFE_EXTENSION_CALL = 26;

    /// <include file='FAST.xml' path='doc/member[@name="FAST.FAST_FAIL_DEPRECATED_SERVICE_INVOKED"]/*' />
    [NativeTypeName("#define FAST_FAIL_DEPRECATED_SERVICE_INVOKED 27")]
    public const int FAST_FAIL_DEPRECATED_SERVICE_INVOKED = 27;

    /// <include file='FAST.xml' path='doc/member[@name="FAST.FAST_FAIL_INVALID_BUFFER_ACCESS"]/*' />
    [NativeTypeName("#define FAST_FAIL_INVALID_BUFFER_ACCESS 28")]
    public const int FAST_FAIL_INVALID_BUFFER_ACCESS = 28;

    /// <include file='FAST.xml' path='doc/member[@name="FAST.FAST_FAIL_INVALID_BALANCED_TREE"]/*' />
    [NativeTypeName("#define FAST_FAIL_INVALID_BALANCED_TREE 29")]
    public const int FAST_FAIL_INVALID_BALANCED_TREE = 29;

    /// <include file='FAST.xml' path='doc/member[@name="FAST.FAST_FAIL_INVALID_NEXT_THREAD"]/*' />
    [NativeTypeName("#define FAST_FAIL_INVALID_NEXT_THREAD 30")]
    public const int FAST_FAIL_INVALID_NEXT_THREAD = 30;

    /// <include file='FAST.xml' path='doc/member[@name="FAST.FAST_FAIL_GUARD_ICALL_CHECK_SUPPRESSED"]/*' />
    [NativeTypeName("#define FAST_FAIL_GUARD_ICALL_CHECK_SUPPRESSED 31")]
    public const int FAST_FAIL_GUARD_ICALL_CHECK_SUPPRESSED = 31;

    /// <include file='FAST.xml' path='doc/member[@name="FAST.FAST_FAIL_APCS_DISABLED"]/*' />
    [NativeTypeName("#define FAST_FAIL_APCS_DISABLED 32")]
    public const int FAST_FAIL_APCS_DISABLED = 32;

    /// <include file='FAST.xml' path='doc/member[@name="FAST.FAST_FAIL_INVALID_IDLE_STATE"]/*' />
    [NativeTypeName("#define FAST_FAIL_INVALID_IDLE_STATE 33")]
    public const int FAST_FAIL_INVALID_IDLE_STATE = 33;

    /// <include file='FAST.xml' path='doc/member[@name="FAST.FAST_FAIL_MRDATA_PROTECTION_FAILURE"]/*' />
    [NativeTypeName("#define FAST_FAIL_MRDATA_PROTECTION_FAILURE 34")]
    public const int FAST_FAIL_MRDATA_PROTECTION_FAILURE = 34;

    /// <include file='FAST.xml' path='doc/member[@name="FAST.FAST_FAIL_UNEXPECTED_HEAP_EXCEPTION"]/*' />
    [NativeTypeName("#define FAST_FAIL_UNEXPECTED_HEAP_EXCEPTION 35")]
    public const int FAST_FAIL_UNEXPECTED_HEAP_EXCEPTION = 35;

    /// <include file='FAST.xml' path='doc/member[@name="FAST.FAST_FAIL_INVALID_LOCK_STATE"]/*' />
    [NativeTypeName("#define FAST_FAIL_INVALID_LOCK_STATE 36")]
    public const int FAST_FAIL_INVALID_LOCK_STATE = 36;

    /// <include file='FAST.xml' path='doc/member[@name="FAST.FAST_FAIL_GUARD_JUMPTABLE"]/*' />
    [NativeTypeName("#define FAST_FAIL_GUARD_JUMPTABLE 37")]
    public const int FAST_FAIL_GUARD_JUMPTABLE = 37;

    /// <include file='FAST.xml' path='doc/member[@name="FAST.FAST_FAIL_INVALID_LONGJUMP_TARGET"]/*' />
    [NativeTypeName("#define FAST_FAIL_INVALID_LONGJUMP_TARGET 38")]
    public const int FAST_FAIL_INVALID_LONGJUMP_TARGET = 38;

    /// <include file='FAST.xml' path='doc/member[@name="FAST.FAST_FAIL_INVALID_DISPATCH_CONTEXT"]/*' />
    [NativeTypeName("#define FAST_FAIL_INVALID_DISPATCH_CONTEXT 39")]
    public const int FAST_FAIL_INVALID_DISPATCH_CONTEXT = 39;

    /// <include file='FAST.xml' path='doc/member[@name="FAST.FAST_FAIL_INVALID_THREAD"]/*' />
    [NativeTypeName("#define FAST_FAIL_INVALID_THREAD 40")]
    public const int FAST_FAIL_INVALID_THREAD = 40;

    /// <include file='FAST.xml' path='doc/member[@name="FAST.FAST_FAIL_INVALID_SYSCALL_NUMBER"]/*' />
    [NativeTypeName("#define FAST_FAIL_INVALID_SYSCALL_NUMBER 41")]
    public const int FAST_FAIL_INVALID_SYSCALL_NUMBER = 41;

    /// <include file='FAST.xml' path='doc/member[@name="FAST.FAST_FAIL_INVALID_FILE_OPERATION"]/*' />
    [NativeTypeName("#define FAST_FAIL_INVALID_FILE_OPERATION 42")]
    public const int FAST_FAIL_INVALID_FILE_OPERATION = 42;

    /// <include file='FAST.xml' path='doc/member[@name="FAST.FAST_FAIL_LPAC_ACCESS_DENIED"]/*' />
    [NativeTypeName("#define FAST_FAIL_LPAC_ACCESS_DENIED 43")]
    public const int FAST_FAIL_LPAC_ACCESS_DENIED = 43;

    /// <include file='FAST.xml' path='doc/member[@name="FAST.FAST_FAIL_GUARD_SS_FAILURE"]/*' />
    [NativeTypeName("#define FAST_FAIL_GUARD_SS_FAILURE 44")]
    public const int FAST_FAIL_GUARD_SS_FAILURE = 44;

    /// <include file='FAST.xml' path='doc/member[@name="FAST.FAST_FAIL_LOADER_CONTINUITY_FAILURE"]/*' />
    [NativeTypeName("#define FAST_FAIL_LOADER_CONTINUITY_FAILURE 45")]
    public const int FAST_FAIL_LOADER_CONTINUITY_FAILURE = 45;

    /// <include file='FAST.xml' path='doc/member[@name="FAST.FAST_FAIL_GUARD_EXPORT_SUPPRESSION_FAILURE"]/*' />
    [NativeTypeName("#define FAST_FAIL_GUARD_EXPORT_SUPPRESSION_FAILURE 46")]
    public const int FAST_FAIL_GUARD_EXPORT_SUPPRESSION_FAILURE = 46;

    /// <include file='FAST.xml' path='doc/member[@name="FAST.FAST_FAIL_INVALID_CONTROL_STACK"]/*' />
    [NativeTypeName("#define FAST_FAIL_INVALID_CONTROL_STACK 47")]
    public const int FAST_FAIL_INVALID_CONTROL_STACK = 47;

    /// <include file='FAST.xml' path='doc/member[@name="FAST.FAST_FAIL_SET_CONTEXT_DENIED"]/*' />
    [NativeTypeName("#define FAST_FAIL_SET_CONTEXT_DENIED 48")]
    public const int FAST_FAIL_SET_CONTEXT_DENIED = 48;

    /// <include file='FAST.xml' path='doc/member[@name="FAST.FAST_FAIL_INVALID_IAT"]/*' />
    [NativeTypeName("#define FAST_FAIL_INVALID_IAT 49")]
    public const int FAST_FAIL_INVALID_IAT = 49;

    /// <include file='FAST.xml' path='doc/member[@name="FAST.FAST_FAIL_HEAP_METADATA_CORRUPTION"]/*' />
    [NativeTypeName("#define FAST_FAIL_HEAP_METADATA_CORRUPTION 50")]
    public const int FAST_FAIL_HEAP_METADATA_CORRUPTION = 50;

    /// <include file='FAST.xml' path='doc/member[@name="FAST.FAST_FAIL_PAYLOAD_RESTRICTION_VIOLATION"]/*' />
    [NativeTypeName("#define FAST_FAIL_PAYLOAD_RESTRICTION_VIOLATION 51")]
    public const int FAST_FAIL_PAYLOAD_RESTRICTION_VIOLATION = 51;

    /// <include file='FAST.xml' path='doc/member[@name="FAST.FAST_FAIL_LOW_LABEL_ACCESS_DENIED"]/*' />
    [NativeTypeName("#define FAST_FAIL_LOW_LABEL_ACCESS_DENIED 52")]
    public const int FAST_FAIL_LOW_LABEL_ACCESS_DENIED = 52;

    /// <include file='FAST.xml' path='doc/member[@name="FAST.FAST_FAIL_ENCLAVE_CALL_FAILURE"]/*' />
    [NativeTypeName("#define FAST_FAIL_ENCLAVE_CALL_FAILURE 53")]
    public const int FAST_FAIL_ENCLAVE_CALL_FAILURE = 53;

    /// <include file='FAST.xml' path='doc/member[@name="FAST.FAST_FAIL_UNHANDLED_LSS_EXCEPTON"]/*' />
    [NativeTypeName("#define FAST_FAIL_UNHANDLED_LSS_EXCEPTON 54")]
    public const int FAST_FAIL_UNHANDLED_LSS_EXCEPTON = 54;

    /// <include file='FAST.xml' path='doc/member[@name="FAST.FAST_FAIL_ADMINLESS_ACCESS_DENIED"]/*' />
    [NativeTypeName("#define FAST_FAIL_ADMINLESS_ACCESS_DENIED 55")]
    public const int FAST_FAIL_ADMINLESS_ACCESS_DENIED = 55;

    /// <include file='FAST.xml' path='doc/member[@name="FAST.FAST_FAIL_UNEXPECTED_CALL"]/*' />
    [NativeTypeName("#define FAST_FAIL_UNEXPECTED_CALL 56")]
    public const int FAST_FAIL_UNEXPECTED_CALL = 56;

    /// <include file='FAST.xml' path='doc/member[@name="FAST.FAST_FAIL_CONTROL_INVALID_RETURN_ADDRESS"]/*' />
    [NativeTypeName("#define FAST_FAIL_CONTROL_INVALID_RETURN_ADDRESS 57")]
    public const int FAST_FAIL_CONTROL_INVALID_RETURN_ADDRESS = 57;

    /// <include file='FAST.xml' path='doc/member[@name="FAST.FAST_FAIL_UNEXPECTED_HOST_BEHAVIOR"]/*' />
    [NativeTypeName("#define FAST_FAIL_UNEXPECTED_HOST_BEHAVIOR 58")]
    public const int FAST_FAIL_UNEXPECTED_HOST_BEHAVIOR = 58;

    /// <include file='FAST.xml' path='doc/member[@name="FAST.FAST_FAIL_FLAGS_CORRUPTION"]/*' />
    [NativeTypeName("#define FAST_FAIL_FLAGS_CORRUPTION 59")]
    public const int FAST_FAIL_FLAGS_CORRUPTION = 59;

    /// <include file='FAST.xml' path='doc/member[@name="FAST.FAST_FAIL_VEH_CORRUPTION"]/*' />
    [NativeTypeName("#define FAST_FAIL_VEH_CORRUPTION 60")]
    public const int FAST_FAIL_VEH_CORRUPTION = 60;

    /// <include file='FAST.xml' path='doc/member[@name="FAST.FAST_FAIL_ETW_CORRUPTION"]/*' />
    [NativeTypeName("#define FAST_FAIL_ETW_CORRUPTION 61")]
    public const int FAST_FAIL_ETW_CORRUPTION = 61;

    /// <include file='FAST.xml' path='doc/member[@name="FAST.FAST_FAIL_RIO_ABORT"]/*' />
    [NativeTypeName("#define FAST_FAIL_RIO_ABORT 62")]
    public const int FAST_FAIL_RIO_ABORT = 62;

    /// <include file='FAST.xml' path='doc/member[@name="FAST.FAST_FAIL_INVALID_PFN"]/*' />
    [NativeTypeName("#define FAST_FAIL_INVALID_PFN 63")]
    public const int FAST_FAIL_INVALID_PFN = 63;

    /// <include file='FAST.xml' path='doc/member[@name="FAST.FAST_FAIL_GUARD_ICALL_CHECK_FAILURE_XFG"]/*' />
    [NativeTypeName("#define FAST_FAIL_GUARD_ICALL_CHECK_FAILURE_XFG 64")]
    public const int FAST_FAIL_GUARD_ICALL_CHECK_FAILURE_XFG = 64;

    /// <include file='FAST.xml' path='doc/member[@name="FAST.FAST_FAIL_CAST_GUARD"]/*' />
    [NativeTypeName("#define FAST_FAIL_CAST_GUARD 65")]
    public const int FAST_FAIL_CAST_GUARD = 65;

    /// <include file='FAST.xml' path='doc/member[@name="FAST.FAST_FAIL_HOST_VISIBILITY_CHANGE"]/*' />
    [NativeTypeName("#define FAST_FAIL_HOST_VISIBILITY_CHANGE 66")]
    public const int FAST_FAIL_HOST_VISIBILITY_CHANGE = 66;

    /// <include file='FAST.xml' path='doc/member[@name="FAST.FAST_FAIL_KERNEL_CET_SHADOW_STACK_ASSIST"]/*' />
    [NativeTypeName("#define FAST_FAIL_KERNEL_CET_SHADOW_STACK_ASSIST 67")]
    public const int FAST_FAIL_KERNEL_CET_SHADOW_STACK_ASSIST = 67;

    /// <include file='FAST.xml' path='doc/member[@name="FAST.FAST_FAIL_PATCH_CALLBACK_FAILED"]/*' />
    [NativeTypeName("#define FAST_FAIL_PATCH_CALLBACK_FAILED 68")]
    public const int FAST_FAIL_PATCH_CALLBACK_FAILED = 68;

    /// <include file='FAST.xml' path='doc/member[@name="FAST.FAST_FAIL_NTDLL_PATCH_FAILED"]/*' />
    [NativeTypeName("#define FAST_FAIL_NTDLL_PATCH_FAILED 69")]
    public const int FAST_FAIL_NTDLL_PATCH_FAILED = 69;

    /// <include file='FAST.xml' path='doc/member[@name="FAST.FAST_FAIL_INVALID_FLS_DATA"]/*' />
    [NativeTypeName("#define FAST_FAIL_INVALID_FLS_DATA 70")]
    public const int FAST_FAIL_INVALID_FLS_DATA = 70;

    /// <include file='FAST.xml' path='doc/member[@name="FAST.FAST_FAIL_ASAN_ERROR"]/*' />
    [NativeTypeName("#define FAST_FAIL_ASAN_ERROR 71")]
    public const int FAST_FAIL_ASAN_ERROR = 71;

    /// <include file='FAST.xml' path='doc/member[@name="FAST.FAST_FAIL_CLR_EXCEPTION_AOT"]/*' />
    [NativeTypeName("#define FAST_FAIL_CLR_EXCEPTION_AOT 72")]
    public const int FAST_FAIL_CLR_EXCEPTION_AOT = 72;

    /// <include file='FAST.xml' path='doc/member[@name="FAST.FAST_FAIL_POINTER_AUTH_INVALID_RETURN_ADDRESS"]/*' />
    [NativeTypeName("#define FAST_FAIL_POINTER_AUTH_INVALID_RETURN_ADDRESS 73")]
    public const int FAST_FAIL_POINTER_AUTH_INVALID_RETURN_ADDRESS = 73;

    /// <include file='FAST.xml' path='doc/member[@name="FAST.FAST_FAIL_INVALID_THREAD_STATE"]/*' />
    [NativeTypeName("#define FAST_FAIL_INVALID_THREAD_STATE 74")]
    public const int FAST_FAIL_INVALID_THREAD_STATE = 74;

    /// <include file='FAST.xml' path='doc/member[@name="FAST.FAST_FAIL_CORRUPT_WOW64_STATE"]/*' />
    [NativeTypeName("#define FAST_FAIL_CORRUPT_WOW64_STATE 75")]
    public const int FAST_FAIL_CORRUPT_WOW64_STATE = 75;

    /// <include file='FAST.xml' path='doc/member[@name="FAST.FAST_FAIL_INVALID_EXTENDED_STATE"]/*' />
    [NativeTypeName("#define FAST_FAIL_INVALID_EXTENDED_STATE 76")]
    public const int FAST_FAIL_INVALID_EXTENDED_STATE = 76;

    /// <include file='FAST.xml' path='doc/member[@name="FAST.FAST_FAIL_KERNEL_POINTER_EXPECTED"]/*' />
    [NativeTypeName("#define FAST_FAIL_KERNEL_POINTER_EXPECTED 77")]
    public const int FAST_FAIL_KERNEL_POINTER_EXPECTED = 77;

    /// <include file='FAST.xml' path='doc/member[@name="FAST.FAST_FAIL_INVALID_SME_STATE"]/*' />
    [NativeTypeName("#define FAST_FAIL_INVALID_SME_STATE 78")]
    public const int FAST_FAIL_INVALID_SME_STATE = 78;

    /// <include file='FAST.xml' path='doc/member[@name="FAST.FAST_FAIL_INVALID_FAST_FAIL_CODE"]/*' />
    [NativeTypeName("#define FAST_FAIL_INVALID_FAST_FAIL_CODE 0xFFFFFFFF")]
    public const uint FAST_FAIL_INVALID_FAST_FAIL_CODE = 0xFFFFFFFF;
}
