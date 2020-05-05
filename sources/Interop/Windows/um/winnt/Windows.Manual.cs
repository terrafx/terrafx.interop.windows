// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public static partial class Windows
    {
        public const uint STATUS_WAIT_0 = 0x00000000;

        public const uint STATUS_ABANDONED_WAIT_0 = 0x00000080;

        public const uint STATUS_USER_APC = 0x000000C0;

        public const uint STATUS_TIMEOUT = 0x00000102;

        public const uint STATUS_PENDING = 0x00000103;

        public const uint DBG_EXCEPTION_HANDLED = 0x00010001;

        public const uint DBG_CONTINUE = 0x00010002;

        public const uint STATUS_SEGMENT_NOTIFICATION = 0x40000005;

        public const uint STATUS_FATAL_APP_EXIT = 0x40000015;

        public const uint DBG_REPLY_LATER = 0x40010001;

        public const uint DBG_TERMINATE_THREAD = 0x40010003;

        public const uint DBG_TERMINATE_PROCESS = 0x40010004;

        public const uint DBG_CONTROL_C = 0x40010005;

        public const uint DBG_PRINTEXCEPTION_C = 0x40010006;

        public const uint DBG_RIPEXCEPTION = 0x40010007;

        public const uint DBG_CONTROL_BREAK = 0x40010008;

        public const uint DBG_COMMAND_EXCEPTION = 0x40010009;

        public const uint DBG_PRINTEXCEPTION_WIDE_C = 0x4001000A;

        public const uint STATUS_GUARD_PAGE_VIOLATION = 0x80000001;

        public const uint STATUS_DATATYPE_MISALIGNMENT = 0x80000002;

        public const uint STATUS_BREAKPOINT = 0x80000003;

        public const uint STATUS_SINGLE_STEP = 0x80000004;

        public const uint STATUS_LONGJUMP = 0x80000026;

        public const uint STATUS_UNWIND_CONSOLIDATE = 0x80000029;

        public const uint DBG_EXCEPTION_NOT_HANDLED = 0x80010001;

        public const uint STATUS_ACCESS_VIOLATION = 0xC0000005;

        public const uint STATUS_IN_PAGE_ERROR = 0xC0000006;

        public const uint STATUS_INVALID_HANDLE = 0xC0000008;

        public const uint STATUS_INVALID_PARAMETER = 0xC000000D;

        public const uint STATUS_NO_MEMORY = 0xC0000017;

        public const uint STATUS_ILLEGAL_INSTRUCTION = 0xC000001D;

        public const uint STATUS_NONCONTINUABLE_EXCEPTION = 0xC0000025;

        public const uint STATUS_INVALID_DISPOSITION = 0xC0000026;

        public const uint STATUS_ARRAY_BOUNDS_EXCEEDED = 0xC000008C;

        public const uint STATUS_FLOAT_DENORMAL_OPERAND = 0xC000008D;

        public const uint STATUS_FLOAT_DIVIDE_BY_ZERO = 0xC000008E;

        public const uint STATUS_FLOAT_INEXACT_RESULT = 0xC000008F;

        public const uint STATUS_FLOAT_INVALID_OPERATION = 0xC0000090;

        public const uint STATUS_FLOAT_OVERFLOW = 0xC0000091;

        public const uint STATUS_FLOAT_STACK_CHECK = 0xC0000092;

        public const uint STATUS_FLOAT_UNDERFLOW = 0xC0000093;

        public const uint STATUS_INTEGER_DIVIDE_BY_ZERO = 0xC0000094;

        public const uint STATUS_INTEGER_OVERFLOW = 0xC0000095;

        public const uint STATUS_PRIVILEGED_INSTRUCTION = 0xC0000096;

        public const uint STATUS_STACK_OVERFLOW = 0xC00000FD;

        public const uint STATUS_DLL_NOT_FOUND = 0xC0000135;

        public const uint STATUS_ORDINAL_NOT_FOUND = 0xC0000138;

        public const uint STATUS_ENTRYPOINT_NOT_FOUND = 0xC0000139;

        public const uint STATUS_CONTROL_C_EXIT = 0xC000013A;

        public const uint STATUS_DLL_INIT_FAILED = 0xC0000142;

        public const uint STATUS_FLOAT_MULTIPLE_FAULTS = 0xC00002B4;

        public const uint STATUS_FLOAT_MULTIPLE_TRAPS = 0xC00002B5;

        public const uint STATUS_REG_NAT_CONSUMPTION = 0xC00002C9;

        public const uint STATUS_HEAP_CORRUPTION = 0xC0000374;

        public const uint STATUS_STACK_BUFFER_OVERRUN = 0xC0000409;

        public const uint STATUS_INVALID_CRUNTIME_PARAMETER = 0xC0000417;

        public const uint STATUS_ASSERTION_FAILURE = 0xC0000420;

        public const uint STATUS_ENCLAVE_VIOLATION = 0xC00004A2;

        public const uint STATUS_INTERRUPTED = 0xC0000515;

        public const uint STATUS_THREAD_NOT_RUNNING = 0xC0000516;

        public const uint STATUS_ALREADY_REGISTERED = 0xC0000718;

        public const uint STATUS_SXS_EARLY_DEACTIVATION = 0xC015000F;

        public const uint STATUS_SXS_INVALID_DEACTIVATION = 0xC0150010;

        public const uint DELETE = 0x00010000;

        public const uint READ_CONTROL = 0x00020000;

        public const uint WRITE_DAC = 0x00040000;

        public const uint WRITE_OWNER = 0x00080000;

        public const uint SYNCHRONIZE = 0x00100000;

        public const uint STANDARD_RIGHTS_REQUIRED = 0x000F0000;

        public const uint STANDARD_RIGHTS_READ = READ_CONTROL;

        public const uint STANDARD_RIGHTS_WRITE = READ_CONTROL;

        public const uint STANDARD_RIGHTS_EXECUTE = READ_CONTROL;

        public const uint STANDARD_RIGHTS_ALL = 0x001F0000;

        public const uint SPECIFIC_RIGHTS_ALL = 0x0000FFFF;

        public const uint ACCESS_SYSTEM_SECURITY = 0x01000000;

        public const uint MAXIMUM_ALLOWED = 0x02000000;

        public const uint GENERIC_READ = 0x80000000;

        public const uint GENERIC_WRITE = 0x40000000;

        public const uint GENERIC_EXECUTE = 0x20000000;

        public const uint GENERIC_ALL = 0x10000000;

        public const uint MUTANT_QUERY_STATE = 0x0001;

        public const uint MUTANT_ALL_ACCESS = STANDARD_RIGHTS_REQUIRED | SYNCHRONIZE | MUTANT_QUERY_STATE;

        public const uint SEMAPHORE_MODIFY_STATE = 0x0002;

        public const uint SEMAPHORE_ALL_ACCESS = STANDARD_RIGHTS_REQUIRED | SYNCHRONIZE | 0x3;

        public const uint RTL_RUN_ONCE_CHECK_ONLY = 0x00000001;

        public const uint RTL_RUN_ONCE_ASYNC = 0x00000002;

        public const uint RTL_RUN_ONCE_INIT_FAILED = 0x00000004;

        public const uint RTL_RUN_ONCE_CTX_RESERVED_BITS = 2;

        public const uint RTL_CONDITION_VARIABLE_INIT = 0;

        public const uint RTL_CONDITION_VARIABLE_LOCKMODE_SHARED = 0x1;

        public const uint APPLICATION_ERROR_MASK = 0x20000000;

        public const uint ERROR_SEVERITY_SUCCESS = 0x00000000;

        public const uint ERROR_SEVERITY_INFORMATIONAL = 0x40000000;

        public const uint ERROR_SEVERITY_WARNING = 0x80000000;

        public const uint ERROR_SEVERITY_ERROR = 0xC0000000;
    }
}
