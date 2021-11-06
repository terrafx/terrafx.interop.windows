// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/minidumpapiset.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        [DllImport("DbgHelp", ExactSpelling = true)]
        public static extern BOOL MiniDumpWriteDump(HANDLE hProcess, [NativeTypeName("DWORD")] uint ProcessId, HANDLE hFile, MINIDUMP_TYPE DumpType, [NativeTypeName("PMINIDUMP_EXCEPTION_INFORMATION")] MINIDUMP_EXCEPTION_INFORMATION* ExceptionParam, [NativeTypeName("PMINIDUMP_USER_STREAM_INFORMATION")] MINIDUMP_USER_STREAM_INFORMATION* UserStreamParam, [NativeTypeName("PMINIDUMP_CALLBACK_INFORMATION")] MINIDUMP_CALLBACK_INFORMATION* CallbackParam);

        [DllImport("DbgHelp", ExactSpelling = true)]
        public static extern BOOL MiniDumpReadDumpStream([NativeTypeName("PVOID")] void* BaseOfDump, [NativeTypeName("ULONG")] uint StreamNumber, [NativeTypeName("PMINIDUMP_DIRECTORY *")] MINIDUMP_DIRECTORY** Dir, [NativeTypeName("PVOID *")] void** StreamPointer, [NativeTypeName("ULONG *")] uint* StreamSize);

        [NativeTypeName("#define MINIDUMP_SIGNATURE ('PMDM')")]
        public const int MINIDUMP_SIGNATURE = (0x504D444D);

        [NativeTypeName("#define MINIDUMP_VERSION (42899)")]
        public const int MINIDUMP_VERSION = (42899);

        [NativeTypeName("#define MINIDUMP_MISC1_PROCESS_ID 0x00000001")]
        public const int MINIDUMP_MISC1_PROCESS_ID = 0x00000001;

        [NativeTypeName("#define MINIDUMP_MISC1_PROCESS_TIMES 0x00000002")]
        public const int MINIDUMP_MISC1_PROCESS_TIMES = 0x00000002;

        [NativeTypeName("#define MINIDUMP_MISC1_PROCESSOR_POWER_INFO 0x00000004")]
        public const int MINIDUMP_MISC1_PROCESSOR_POWER_INFO = 0x00000004;

        [NativeTypeName("#define MINIDUMP_MISC3_PROCESS_INTEGRITY 0x00000010")]
        public const int MINIDUMP_MISC3_PROCESS_INTEGRITY = 0x00000010;

        [NativeTypeName("#define MINIDUMP_MISC3_PROCESS_EXECUTE_FLAGS 0x00000020")]
        public const int MINIDUMP_MISC3_PROCESS_EXECUTE_FLAGS = 0x00000020;

        [NativeTypeName("#define MINIDUMP_MISC3_TIMEZONE 0x00000040")]
        public const int MINIDUMP_MISC3_TIMEZONE = 0x00000040;

        [NativeTypeName("#define MINIDUMP_MISC3_PROTECTED_PROCESS 0x00000080")]
        public const int MINIDUMP_MISC3_PROTECTED_PROCESS = 0x00000080;

        [NativeTypeName("#define MINIDUMP_MISC4_BUILDSTRING 0x00000100")]
        public const int MINIDUMP_MISC4_BUILDSTRING = 0x00000100;

        [NativeTypeName("#define MINIDUMP_MISC5_PROCESS_COOKIE 0x00000200")]
        public const int MINIDUMP_MISC5_PROCESS_COOKIE = 0x00000200;

        [NativeTypeName("#define MINIDUMP_THREAD_INFO_ERROR_THREAD 0x00000001")]
        public const int MINIDUMP_THREAD_INFO_ERROR_THREAD = 0x00000001;

        [NativeTypeName("#define MINIDUMP_THREAD_INFO_WRITING_THREAD 0x00000002")]
        public const int MINIDUMP_THREAD_INFO_WRITING_THREAD = 0x00000002;

        [NativeTypeName("#define MINIDUMP_THREAD_INFO_EXITED_THREAD 0x00000004")]
        public const int MINIDUMP_THREAD_INFO_EXITED_THREAD = 0x00000004;

        [NativeTypeName("#define MINIDUMP_THREAD_INFO_INVALID_INFO 0x00000008")]
        public const int MINIDUMP_THREAD_INFO_INVALID_INFO = 0x00000008;

        [NativeTypeName("#define MINIDUMP_THREAD_INFO_INVALID_CONTEXT 0x00000010")]
        public const int MINIDUMP_THREAD_INFO_INVALID_CONTEXT = 0x00000010;

        [NativeTypeName("#define MINIDUMP_THREAD_INFO_INVALID_TEB 0x00000020")]
        public const int MINIDUMP_THREAD_INFO_INVALID_TEB = 0x00000020;

        [NativeTypeName("#define MINIDUMP_SYSMEMINFO1_FILECACHE_TRANSITIONREPURPOSECOUNT_FLAGS 0x0001")]
        public const int MINIDUMP_SYSMEMINFO1_FILECACHE_TRANSITIONREPURPOSECOUNT_FLAGS = 0x0001;

        [NativeTypeName("#define MINIDUMP_SYSMEMINFO1_BASICPERF 0x0002")]
        public const int MINIDUMP_SYSMEMINFO1_BASICPERF = 0x0002;

        [NativeTypeName("#define MINIDUMP_SYSMEMINFO1_PERF_CCTOTALDIRTYPAGES_CCDIRTYPAGETHRESHOLD 0x0004")]
        public const int MINIDUMP_SYSMEMINFO1_PERF_CCTOTALDIRTYPAGES_CCDIRTYPAGETHRESHOLD = 0x0004;

        [NativeTypeName("#define MINIDUMP_SYSMEMINFO1_PERF_RESIDENTAVAILABLEPAGES_SHAREDCOMMITPAGES 0x0008")]
        public const int MINIDUMP_SYSMEMINFO1_PERF_RESIDENTAVAILABLEPAGES_SHAREDCOMMITPAGES = 0x0008;

        [NativeTypeName("#define MINIDUMP_PROCESS_VM_COUNTERS 0x0001")]
        public const int MINIDUMP_PROCESS_VM_COUNTERS = 0x0001;

        [NativeTypeName("#define MINIDUMP_PROCESS_VM_COUNTERS_VIRTUALSIZE 0x0002")]
        public const int MINIDUMP_PROCESS_VM_COUNTERS_VIRTUALSIZE = 0x0002;

        [NativeTypeName("#define MINIDUMP_PROCESS_VM_COUNTERS_EX 0x0004")]
        public const int MINIDUMP_PROCESS_VM_COUNTERS_EX = 0x0004;

        [NativeTypeName("#define MINIDUMP_PROCESS_VM_COUNTERS_EX2 0x0008")]
        public const int MINIDUMP_PROCESS_VM_COUNTERS_EX2 = 0x0008;

        [NativeTypeName("#define MINIDUMP_PROCESS_VM_COUNTERS_JOB 0x0010")]
        public const int MINIDUMP_PROCESS_VM_COUNTERS_JOB = 0x0010;
    }
}
