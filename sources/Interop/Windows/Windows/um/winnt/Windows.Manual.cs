// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using System.Security.Cryptography;

namespace TerraFX.Interop.Windows;

public static unsafe partial class Windows
{
    public static int MEMORY_ALLOCATION_ALIGNMENT
    {
        get
        {
            if (sizeof(nint) == 4)
            {
                return 8;
            }
            else
            {
                return 16;
            }
        }
    }

    public static int MAXIMUM_PROC_PER_GROUP
    {
        get
        {
            if (sizeof(nint) == 4)
            {
                return 32;
            }
            else
            {
                return 64;
            }
        }
    }

    [NativeTypeName("#define MAXIMUM_PROCESSORS MAXIMUM_PROC_PER_GROUP")]
    public static int MAXIMUM_PROCESSORS => MAXIMUM_PROC_PER_GROUP;

    [NativeTypeName("#define MAXIMUM_SUPPORTED_EXTENSION 512")]
    public const int MAXIMUM_SUPPORTED_EXTENSION = 512;

    [NativeTypeName("#define INITIAL_MXCSR 0x1f80")]
    public const int INITIAL_MXCSR = 0x1f80;

    [NativeTypeName("#define INITIAL_FPCSR 0x027f")]
    public const int INITIAL_FPCSR = 0x027f;

    [NativeTypeName("#define RUNTIME_FUNCTION_INDIRECT 0x1")]
    public const int RUNTIME_FUNCTION_INDIRECT = 0x1;

    [NativeTypeName("#define UNW_FLAG_NHANDLER 0x0")]
    public const int UNW_FLAG_NHANDLER = 0x0;

    [NativeTypeName("#define UNW_FLAG_EHANDLER 0x1")]
    public const int UNW_FLAG_EHANDLER = 0x1;

    [NativeTypeName("#define UNW_FLAG_UHANDLER 0x2")]
    public const int UNW_FLAG_UHANDLER = 0x2;

    [NativeTypeName("#define UNW_FLAG_CHAININFO 0x4")]
    public const int UNW_FLAG_CHAININFO = 0x4;

    [NativeTypeName("#define UNW_FLAG_NO_EPILOGUE 0x80000000UL")]
    public const uint UNW_FLAG_NO_EPILOGUE = 0x80000000U;

    [NativeTypeName("#define UNWIND_CHAIN_LIMIT 32")]
    public const int UNWIND_CHAIN_LIMIT = 32;

    [NativeTypeName("#define OUT_OF_PROCESS_FUNCTION_TABLE_CALLBACK_EXPORT_NAME \"OutOfProcessFunctionTableCallback\"")]
    public static ReadOnlySpan<byte> OUT_OF_PROCESS_FUNCTION_TABLE_CALLBACK_EXPORT_NAME => "OutOfProcessFunctionTableCallback"u8;

    [NativeTypeName("#define ARM64_MAX_BREAKPOINTS 8")]
    public const int ARM64_MAX_BREAKPOINTS = 8;

    [NativeTypeName("#define ARM64_MAX_WATCHPOINTS 2")]
    public const int ARM64_MAX_WATCHPOINTS = 2;

    [NativeTypeName("#define NONVOL_INT_NUMREG_ARM64 (11)")]
    public const int NONVOL_INT_NUMREG_ARM64 = (11);

    [NativeTypeName("#define NONVOL_FP_NUMREG_ARM64 (8)")]
    public const int NONVOL_FP_NUMREG_ARM64 = (8);

    [NativeTypeName("#define NONVOL_INT_SIZE_ARM64 (NONVOL_INT_NUMREG_ARM64 * sizeof(DWORD64))")]
    public const uint NONVOL_INT_SIZE_ARM64 = ((11) * 8);

    [NativeTypeName("#define NONVOL_FP_SIZE_ARM64 (NONVOL_FP_NUMREG_ARM64 * sizeof(double))")]
    public const uint NONVOL_FP_SIZE_ARM64 = ((8) * 8);

    [NativeTypeName("#define SIZE_OF_80387_REGISTERS 80")]
    public const int SIZE_OF_80387_REGISTERS = 80;

    [NativeTypeName("#define MEMORY_CURRENT_PARTITION_HANDLE ((HANDLE) (LONG_PTR) -1)")]
    public static HANDLE MEMORY_CURRENT_PARTITION_HANDLE => unchecked((HANDLE)((nint)(-1)));

    [NativeTypeName("#define MEMORY_SYSTEM_PARTITION_HANDLE ((HANDLE) (LONG_PTR) -2)")]
    public static HANDLE MEMORY_SYSTEM_PARTITION_HANDLE => unchecked((HANDLE)((nint)(-2)));

    [NativeTypeName("#define MEMORY_EXISTING_VAD_PARTITION_HANDLE ((HANDLE) (LONG_PTR) -3)")]
    public static HANDLE MEMORY_EXISTING_VAD_PARTITION_HANDLE => unchecked((HANDLE)((nint)(-3)));

    [NativeTypeName("#define RTL_CONDITION_VARIABLE_LOCKMODE_SHARED 0x1")]
    public const int RTL_CONDITION_VARIABLE_LOCKMODE_SHARED = 0x1;

    [NativeTypeName("#define RTL_CORRELATION_VECTOR_STRING_LENGTH 129")]
    public const int RTL_CORRELATION_VECTOR_STRING_LENGTH = 129;

    [NativeTypeName("#define RTL_CORRELATION_VECTOR_VERSION_1 ((CHAR)1)")]
    public const sbyte RTL_CORRELATION_VECTOR_VERSION_1 = 1;

    [NativeTypeName("#define RTL_CORRELATION_VECTOR_VERSION_2 ((CHAR)2)")]
    public const sbyte RTL_CORRELATION_VECTOR_VERSION_2 = 2;

    [NativeTypeName("#define RTL_CORRELATION_VECTOR_VERSION_CURRENT RTL_CORRELATION_VECTOR_VERSION_2")]
    public const sbyte RTL_CORRELATION_VECTOR_VERSION_CURRENT = RTL_CORRELATION_VECTOR_VERSION_2;

    [NativeTypeName("#define RTL_CORRELATION_VECTOR_V1_PREFIX_LENGTH 16")]
    public const int RTL_CORRELATION_VECTOR_V1_PREFIX_LENGTH = 16;

    [NativeTypeName("#define RTL_CORRELATION_VECTOR_V1_LENGTH 64")]
    public const int RTL_CORRELATION_VECTOR_V1_LENGTH = 64;

    [NativeTypeName("#define RTL_CORRELATION_VECTOR_V2_PREFIX_LENGTH 22")]
    public const int RTL_CORRELATION_VECTOR_V2_PREFIX_LENGTH = 22;

    [NativeTypeName("#define RTL_CORRELATION_VECTOR_V2_LENGTH 128")]
    public const int RTL_CORRELATION_VECTOR_V2_LENGTH = 128;

    [NativeTypeName("#define RTL_CRITICAL_SECTION_FLAG_NO_DEBUG_INFO 0x01000000")]
    public const uint RTL_CRITICAL_SECTION_FLAG_NO_DEBUG_INFO = 0x01000000;

    [NativeTypeName("#define RTL_CRITICAL_SECTION_FLAG_DYNAMIC_SPIN 0x02000000")]
    public const uint RTL_CRITICAL_SECTION_FLAG_DYNAMIC_SPIN = 0x02000000;

    [NativeTypeName("#define RTL_CRITICAL_SECTION_FLAG_STATIC_INIT 0x04000000")]
    public const uint RTL_CRITICAL_SECTION_FLAG_STATIC_INIT = 0x04000000;

    [NativeTypeName("#define RTL_CRITICAL_SECTION_FLAG_RESOURCE_TYPE 0x08000000")]
    public const uint RTL_CRITICAL_SECTION_FLAG_RESOURCE_TYPE = 0x08000000;

    [NativeTypeName("#define RTL_CRITICAL_SECTION_FLAG_FORCE_DEBUG_INFO 0x10000000")]
    public const uint RTL_CRITICAL_SECTION_FLAG_FORCE_DEBUG_INFO = 0x10000000;

    [NativeTypeName("#define RTL_CRITICAL_SECTION_ALL_FLAG_BITS 0xFF000000")]
    public const uint RTL_CRITICAL_SECTION_ALL_FLAG_BITS = 0xFF000000;

    [NativeTypeName("#define RTL_CRITICAL_SECTION_FLAG_RESERVED (RTL_CRITICAL_SECTION_ALL_FLAG_BITS & (~(RTL_CRITICAL_SECTION_FLAG_NO_DEBUG_INFO | RTL_CRITICAL_SECTION_FLAG_DYNAMIC_SPIN | RTL_CRITICAL_SECTION_FLAG_STATIC_INIT | RTL_CRITICAL_SECTION_FLAG_RESOURCE_TYPE | RTL_CRITICAL_SECTION_FLAG_FORCE_DEBUG_INFO)))")]
    public const uint RTL_CRITICAL_SECTION_FLAG_RESERVED = RTL_CRITICAL_SECTION_ALL_FLAG_BITS & ~(RTL_CRITICAL_SECTION_FLAG_NO_DEBUG_INFO | RTL_CRITICAL_SECTION_FLAG_DYNAMIC_SPIN | RTL_CRITICAL_SECTION_FLAG_STATIC_INIT | RTL_CRITICAL_SECTION_FLAG_RESOURCE_TYPE | RTL_CRITICAL_SECTION_FLAG_FORCE_DEBUG_INFO);

    [NativeTypeName("#define RTL_CRITICAL_SECTION_DEBUG_FLAG_STATIC_INIT 0x00000001")]
    public const int RTL_CRITICAL_SECTION_DEBUG_FLAG_STATIC_INIT = 0x00000001;

    [NativeTypeName("#define RTL_RUN_ONCE_CHECK_ONLY 0x00000001UL")]
    public const uint RTL_RUN_ONCE_CHECK_ONLY = 0x00000001;

    [NativeTypeName("#define RTL_RUN_ONCE_ASYNC 0x00000002UL")]
    public const uint RTL_RUN_ONCE_ASYNC = 0x00000002;

    [NativeTypeName("#define RTL_RUN_ONCE_INIT_FAILED 0x00000004UL")]
    public const uint RTL_RUN_ONCE_INIT_FAILED = 0x00000004;

    [NativeTypeName("#define RTL_RUN_ONCE_CTX_RESERVED_BITS 2")]
    public const int RTL_RUN_ONCE_CTX_RESERVED_BITS = 2;

    [NativeTypeName("#define RTL_UMS_VERSION (0x0100)")]
    public const int RTL_UMS_VERSION = 0x0100;

    [NativeTypeName("#define RTL_VIRTUAL_UNWIND2_VALIDATE_PAC 0x00000001UL")]
    public const uint RTL_VIRTUAL_UNWIND2_VALIDATE_PAC = 0x00000001;

    [NativeTypeName("#define IMAGE_ENCLAVE_MINIMUM_CONFIG_SIZE FIELD_OFFSET(IMAGE_ENCLAVE_CONFIG, EnclaveFlags)")]
    [SupportedOSPlatform("windows10.0.16299.0")]
    public static uint IMAGE_ENCLAVE_MINIMUM_CONFIG_SIZE
    {
        get
        {
            if (sizeof(nint) == 4)
            {
                return (uint)Marshal.OffsetOf<IMAGE_ENCLAVE_CONFIG32>(nameof(IMAGE_ENCLAVE_CONFIG32.EnclaveFlags)).ToInt32();
            }
            else
            {
                return (uint)Marshal.OffsetOf<IMAGE_ENCLAVE_CONFIG64>(nameof(IMAGE_ENCLAVE_CONFIG64.EnclaveFlags)).ToInt32();
            }
        }
    }

    [NativeTypeName("#define REPARSE_GUID_DATA_BUFFER_HEADER_SIZE UFIELD_OFFSET(REPARSE_GUID_DATA_BUFFER, GenericReparseBuffer)")]
    public static uint REPARSE_GUID_DATA_BUFFER_HEADER_SIZE
        => (uint)Marshal.OffsetOf<REPARSE_GUID_DATA_BUFFER>(nameof(REPARSE_GUID_DATA_BUFFER.GenericReparseBuffer)).ToInt32();

    [return: NativeTypeName("#define MAKELANGID(p, s) ((((WORD)(s)) << 10) | (WORD)(p))")]
    public static ushort MAKELANGID(ushort p, ushort s) => unchecked((ushort)((s << 10) | p));

    [return: NativeTypeName("#define PRIMARYLANGID(lgid) ((WORD)(lgid) & 0x3ff)")]
    public static ushort PRIMARYLANGID(ushort lgid) => (ushort)(lgid & 0x3FF);

    [return: NativeTypeName("#define SUBLANGID(lgid) ((WORD)(lgid) >> 10)")]
    public static ushort SUBLANGID(ushort lgid) => (ushort)(lgid >> 10);

    [return: NativeTypeName("#define MAKELCID(lgid, srtid) ((DWORD)((((DWORD)((WORD)(srtid))) << 16) | ((DWORD)((WORD)(lgid)))))")]
    public static uint MAKELCID(ushort lgid, ushort srtid) => ((uint)srtid << 16) | lgid;

    [return: NativeTypeName("#define MAKESORTLCID(lgid, srtid, ver) ((DWORD)((MAKELCID(lgid, srtid)) | (((DWORD)((WORD)(ver))) << 20)))")]
    public static uint MAKESORTLCID(ushort lgid, ushort srtid, ushort ver) => MAKELCID(lgid, srtid) | ((uint)ver << 20);

    [return: NativeTypeName("#define LANGIDFROMLCID(lcid) ((WORD)(lcid))")]
    public static ushort LANGIDFROMLCID(uint lcid) => unchecked((ushort)lcid);

    [return: NativeTypeName("#define SORTIDFROMLCID(lcid) ((WORD)((((DWORD)(lcid)) >> 16) & 0xf))")]
    public static ushort SORTIDFROMLCID(uint lcid) => (ushort)((lcid >> 16) & 0xF);

    [return: NativeTypeName("#define SORTVERSIONFROMLCID(lcid) ((WORD)((((DWORD)(lcid)) >> 20) & 0xf))")]
    public static ushort SORTVERSIONFROMLCID(uint lcid) => (ushort)((lcid >> 20) & 0xF);

    [return: NativeTypeName("#define MANDATORY_LEVEL_TO_MANDATORY_RID(IL) (IL * 0x1000)")]
    public static uint MANDATORY_LEVEL_TO_MANDATORY_RID(uint IL) => IL * 0x1000;

    [return: NativeTypeName("#define VALID_IMPERSONATION_LEVEL(L) (((L) >= SECURITY_MIN_IMPERSONATION_LEVEL) && ((L) <= SECURITY_MAX_IMPERSONATION_LEVEL))")]
    public static bool VALID_IMPERSONATION_LEVEL(SECURITY_IMPERSONATION_LEVEL L)
        => ((int)L >= (int)(SECURITY.SECURITY_MIN_IMPERSONATION_LEVEL))
        && ((int)L <= (int)(SECURITY.SECURITY_MAX_IMPERSONATION_LEVEL));

    [return: NativeTypeName("#define SECURITY_SID_SIZE(SubAuthorityCount_) (sizeof(SID) - sizeof(DWORD) + (SubAuthorityCount_) * sizeof(DWORD))")]
    public static nuint SECURITY_SID_SIZE(uint SubAuthorityCount_)
        => (nuint)(sizeof(SID) - sizeof(uint)) + ((nuint)SubAuthorityCount_ * (nuint)sizeof(uint));

    [return: NativeTypeName("#define RtlCopyMemory(Destination, Source, Length) memcpy((Destination), (Source), (Length))")]
    public static void* RtlCopyMemory(void* Destination, void* Source, nuint Length)
    {
        Buffer.MemoryCopy(Source, Destination, (ulong)Length, (ulong)Length);
        return Destination;
    }

    [return: NativeTypeName("#define RtlMoveMemory(Destination, Source, Length) memmove((Destination), (Source), (Length))")]
    public static void* RtlMoveMemory(void* Destination, void* Source, nuint Length)
    {
        Buffer.MemoryCopy(Source, Destination, (ulong)Length, (ulong)Length);
        return Destination;
    }

    [return: NativeTypeName("#define RtlFillMemory(Destination, Length, Fill) memset((Destination), (Fill), (Length))")]
    public static void* RtlFillMemory(void* Destination, nuint Length, int Fill)
    {
        NativeMemory.Fill(Destination, Length, unchecked((byte)Fill));
        return Destination;
    }

    [return: NativeTypeName("#define RtlZeroMemory(Destination, Length) memset((Destination), 0, (Length))")]
    public static void* RtlZeroMemory(void* Destination, nuint Length)
    {
        NativeMemory.Clear(Destination, Length);
        return Destination;
    }

    [return: NativeTypeName("PVOID")]
    public static void* RtlSecureZeroMemory(void* Ptr, nuint Count)
    {
        void* result = Ptr;

        while (Count != 0)
        {
            int currentLength = (Count > int.MaxValue) ? int.MaxValue : (int)Count;
            CryptographicOperations.ZeroMemory(new Span<byte>(Ptr, currentLength));
            Ptr = (byte*)Ptr + currentLength;
            Count -= (nuint)currentLength;
        }

        return result;
    }

    [return: NativeTypeName("volatile PVOID")]
    public static void* RtlSecureZeroMemory2(void* Ptr, nuint Count)
        => RtlSecureZeroMemory(Ptr, Count);

    [return: NativeTypeName("BOOLEAN")]
    public static bool RtlConstantTimeEqualMemory(void* Left, void* Right, nuint Length)
    {
        bool equal = true;

        while (Length != 0)
        {
            int currentLength = (Length > int.MaxValue) ? int.MaxValue : (int)Length;
            equal &= CryptographicOperations.FixedTimeEquals(new ReadOnlySpan<byte>(Left, currentLength), new ReadOnlySpan<byte>(Right, currentLength));
            Left = (byte*)Left + currentLength;
            Right = (byte*)Right + currentLength;
            Length -= (nuint)currentLength;
        }

        return equal;
    }

    [return: NativeTypeName("#define IS_UNWINDING(Flag) ((Flag & EXCEPTION_UNWIND) != 0)")]
    public static bool IS_UNWINDING(int Flag) => (Flag & EXCEPTION.EXCEPTION_UNWIND) != 0;

    [return: NativeTypeName("#define IS_DISPATCHING(Flag) ((Flag & EXCEPTION_UNWIND) == 0)")]
    public static bool IS_DISPATCHING(int Flag) => (Flag & EXCEPTION.EXCEPTION_UNWIND) == 0;

    [return: NativeTypeName("#define IS_TARGET_UNWIND(Flag) (Flag & EXCEPTION_TARGET_UNWIND)")]
    public static int IS_TARGET_UNWIND(int Flag) => Flag & EXCEPTION.EXCEPTION_TARGET_UNWIND;

    [return: NativeTypeName("#define IsReparseTagMicrosoft(_tag) ((_tag) & 0x80000000)")]
    public static uint IsReparseTagMicrosoft(uint _tag) => _tag & 0x80000000;

    [return: NativeTypeName("#define IsReparseTagReserved(_tag) ((_tag) & 0x40000000)")]
    public static uint IsReparseTagReserved(uint _tag) => _tag & 0x40000000;

    [return: NativeTypeName("#define IsReparseTagNameSurrogate(_tag) ((_tag) & 0x20000000)")]
    public static uint IsReparseTagNameSurrogate(uint _tag) => _tag & 0x20000000;

    [return: NativeTypeName("#define IsReparseTagDirectory(_tag) ((_tag) & 0x10000000)")]
    public static uint IsReparseTagDirectory(uint _tag) => _tag & 0x10000000;

    [return: NativeTypeName("#define IsVirtualDiskFileShared(HandleState) (((HandleState) & SharedVirtualDiskHandleStateFileShared) != 0)")]
    public static bool IsVirtualDiskFileShared(SharedVirtualDiskHandleState HandleState)
        => (((uint)HandleState & (uint)SharedVirtualDiskHandleState.SharedVirtualDiskHandleStateFileShared) != 0);

    [return: NativeTypeName("#define BTYPE(x) ((x) & N_BTMASK)")]
    public static int BTYPE(int x) => x & N_BTMASK;

    [return: NativeTypeName("#define DECREF(x) ((((x) >> N_TSHIFT) & ~N_BTMASK) | ((x) & N_BTMASK))")]
    public static int DECREF(int x) => ((x >> N_TSHIFT) & ~N_BTMASK) | (x & N_BTMASK);

    [return: NativeTypeName("#define INCREF(x) ((((x) & ~N_BTMASK) << N_TSHIFT) | (IMAGE_SYM_DTYPE_POINTER << N_BTSHFT) | ((x) & N_BTMASK))")]
    public static int INCREF(int x) => ((x & ~N_BTMASK) << N_TSHIFT) | (IMAGE.IMAGE_SYM_DTYPE_POINTER << N_BTSHFT) | (x & N_BTMASK);

    [return: NativeTypeName("#define ISARY(x) (((x) & N_TMASK) == (IMAGE_SYM_DTYPE_ARRAY << N_BTSHFT))")]
    public static bool ISARY(int x) => (x & N_TMASK) == (IMAGE.IMAGE_SYM_DTYPE_ARRAY << N_BTSHFT);

    [return: NativeTypeName("#define ISFCN(x) (((x) & N_TMASK) == (IMAGE_SYM_DTYPE_FUNCTION << N_BTSHFT))")]
    public static bool ISFCN(int x) => (x & N_TMASK) == (IMAGE.IMAGE_SYM_DTYPE_FUNCTION << N_BTSHFT);

    [return: NativeTypeName("#define ISPTR(x) (((x) & N_TMASK) == (IMAGE_SYM_DTYPE_POINTER << N_BTSHFT))")]
    public static bool ISPTR(int x) => (x & N_TMASK) == (IMAGE.IMAGE_SYM_DTYPE_POINTER << N_BTSHFT);

    [return: NativeTypeName("#define ISTAG(x) ((x) == IMAGE_SYM_CLASS_STRUCT_TAG || (x) == IMAGE_SYM_CLASS_UNION_TAG || (x) == IMAGE_SYM_CLASS_ENUM_TAG)")]
    public static bool ISTAG(int x)
        => (x == IMAGE.IMAGE_SYM_CLASS_STRUCT_TAG)
        || (x == IMAGE.IMAGE_SYM_CLASS_UNION_TAG)
        || (x == IMAGE.IMAGE_SYM_CLASS_ENUM_TAG);

    [return: NativeTypeName("#define Int32x32To64(a, b) (((__int64)((long)(a))) * ((__int64)((long)(b))))")]
    public static long Int32x32To64(int a, int b) => (long)a * b;

    [return: NativeTypeName("#define UInt32x32To64(a, b) (((unsigned __int64)((unsigned int)(a))) * ((unsigned __int64)((unsigned int)(b))))")]
    public static ulong UInt32x32To64(uint a, uint b) => (ulong)a * b;

    [return: NativeTypeName("#define Int64ShllMod32(a, b) (((unsigned __int64)(a)) << (b))")]
    public static ulong Int64ShllMod32(ulong a, int b) => a << b;

    [return: NativeTypeName("#define Int64ShraMod32(a, b) (((__int64)(a)) >> (b))")]
    public static long Int64ShraMod32(long a, int b) => a >> b;

    [return: NativeTypeName("#define Int64ShrlMod32(a, b) (((unsigned __int64)(a)) >> (b))")]
    public static ulong Int64ShrlMod32(ulong a, int b) => a >> b;

    // Runtime-function and SLIST record layouts vary by architecture, so these ABI pointers remain opaque.
    [DllImport("kernel32", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
    [return: NativeTypeName("BOOLEAN")]
    public static extern byte RtlAddFunctionTable([NativeTypeName("PRUNTIME_FUNCTION")] void* FunctionTable, uint EntryCount, nuint BaseAddress);

    [DllImport("kernel32", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
    [return: NativeTypeName("BOOLEAN")]
    public static extern byte RtlDeleteFunctionTable([NativeTypeName("PRUNTIME_FUNCTION")] void* FunctionTable);

    [DllImport("kernel32", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
    [return: NativeTypeName("BOOLEAN")]
    public static extern byte RtlInstallFunctionTableCallback(nuint TableIdentifier, nuint BaseAddress, uint Length, void* Callback, void* Context, char* OutOfProcessCallbackDll);

    [SupportedOSPlatform("windows6.2")]
    [DllImport("ntdll", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint RtlAddGrowableFunctionTable([NativeTypeName("PVOID *")] void** DynamicTable, [NativeTypeName("PRUNTIME_FUNCTION")] void* FunctionTable, uint EntryCount, uint MaximumEntryCount, nuint RangeBase, nuint RangeEnd);

    [SupportedOSPlatform("windows6.2")]
    [DllImport("ntdll", ExactSpelling = true)]
    public static extern void RtlGrowFunctionTable(void* DynamicTable, uint NewEntryCount);

    [SupportedOSPlatform("windows6.2")]
    [DllImport("ntdll", ExactSpelling = true)]
    public static extern void RtlDeleteGrowableFunctionTable(void* DynamicTable);

    [DllImport("kernel32", ExactSpelling = true)]
    public static extern void RtlCaptureContext([NativeTypeName("PCONTEXT")] void* ContextRecord);

    [DllImport("ntdll", ExactSpelling = true)]
    [return: NativeTypeName("WORD")]
    public static extern ushort RtlCaptureStackBackTrace(uint FramesToSkip, uint FramesToCapture, void** BackTrace, uint* BackTraceHash);

    [SupportedOSPlatform("windows10.0.10240.0")]
    [DllImport("ntdll", ExactSpelling = true)]
    public static extern void RtlGetDeviceFamilyInfoEnum(ulong* pullUAPInfo, uint* pulDeviceFamily, uint* pulDeviceForm);

    [SupportedOSPlatform("windows10.0.18362.0")]
    [DllImport("ntdll", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint RtlConvertDeviceFamilyInfoToString(uint* pulDeviceFamilyBufferSize, uint* pulDeviceFormBufferSize, char* DeviceFamily, char* DeviceForm);

    [DllImport("ntdll", ExactSpelling = true)]
    public static extern void RtlInitializeSListHead([NativeTypeName("PSLIST_HEADER")] void* ListHead);

    [DllImport("ntdll", ExactSpelling = true)]
    public static extern SLIST_ENTRY* RtlFirstEntrySList([NativeTypeName("const SLIST_HEADER *")] void* ListHead);

    [DllImport("ntdll", ExactSpelling = true)]
    public static extern SLIST_ENTRY* RtlInterlockedPopEntrySList([NativeTypeName("PSLIST_HEADER")] void* ListHead);

    [DllImport("ntdll", ExactSpelling = true)]
    public static extern SLIST_ENTRY* RtlInterlockedPushEntrySList([NativeTypeName("PSLIST_HEADER")] void* ListHead, [NativeTypeName("PSLIST_ENTRY")] SLIST_ENTRY* ListEntry);

    [DllImport("ntdll", ExactSpelling = true)]
    public static extern SLIST_ENTRY* RtlInterlockedPushListSListEx([NativeTypeName("PSLIST_HEADER")] void* ListHead, [NativeTypeName("PSLIST_ENTRY")] SLIST_ENTRY* List, [NativeTypeName("PSLIST_ENTRY")] SLIST_ENTRY* ListEnd, uint Count);

    [DllImport("ntdll", ExactSpelling = true)]
    public static extern SLIST_ENTRY* RtlInterlockedFlushSList([NativeTypeName("PSLIST_HEADER")] void* ListHead);

    [DllImport("ntdll", ExactSpelling = true)]
    [return: NativeTypeName("WORD")]
    public static extern ushort RtlQueryDepthSList(void* ListHead);

    [SupportedOSPlatform("windows10.0.22000.0")]
    [DllImport("api-ms-win-core-rtlsupport-l1-2-2", ExactSpelling = true)]
    [return: NativeTypeName("BOOLEAN")]
    public static extern byte RtlIsEcCode(ulong CodePointer);

    [DllImport("kernel32", ExactSpelling = true)]
    [return: NativeTypeName("PRUNTIME_FUNCTION")]
    public static extern void* RtlLookupFunctionEntry(nuint ControlPc, nuint* ImageBase, UNWIND_HISTORY_TABLE* HistoryTable);

    [DllImport("kernel32", ExactSpelling = true)]
    public static extern void* RtlPcToFileHeader(void* PcValue, void** BaseOfImage);

    [DllImport("kernel32", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
    public static extern void RtlRestoreContext([NativeTypeName("PCONTEXT")] void* ContextRecord, EXCEPTION_RECORD* ExceptionRecord);

    [DllImport("kernel32", ExactSpelling = true)]
    public static extern void RtlUnwind(void* TargetFrame, void* TargetIp, EXCEPTION_RECORD* ExceptionRecord, void* ReturnValue);

    [DllImport("kernel32", ExactSpelling = true)]
    public static extern void RtlUnwindEx(void* TargetFrame, void* TargetIp, EXCEPTION_RECORD* ExceptionRecord, void* ReturnValue, [NativeTypeName("PCONTEXT")] void* ContextRecord, [NativeTypeName("PUNWIND_HISTORY_TABLE")] void* HistoryTable);

    [DllImport("kernel32", ExactSpelling = true)]
    [return: NativeTypeName("PEXCEPTION_ROUTINE")]
    public static extern void* RtlVirtualUnwind(uint HandlerType, nuint ImageBase, nuint ControlPc, void* FunctionEntry, void* ContextRecord, void** HandlerData, nuint* EstablisherFrame, void* ContextPointers);

    [SupportedOSPlatform("windows10.0.16299.0")]
    [DllImport("ntdll", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint RtlInitializeCorrelationVector(CORRELATION_VECTOR* CorrelationVector, int Version, [NativeTypeName("const GUID *")] Guid* Guid);

    [SupportedOSPlatform("windows10.0.16299.0")]
    [DllImport("ntdll", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint RtlIncrementCorrelationVector(CORRELATION_VECTOR* CorrelationVector);

    [SupportedOSPlatform("windows10.0.16299.0")]
    [DllImport("ntdll", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint RtlExtendCorrelationVector(CORRELATION_VECTOR* CorrelationVector);

    [SupportedOSPlatform("windows10.0.16299.0")]
    [DllImport("ntdll", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint RtlValidateCorrelationVector(CORRELATION_VECTOR* CorrelationVector);

    [DllImport("ntdll", ExactSpelling = true)]
    [return: NativeTypeName("SIZE_T")]
    public static extern nuint RtlCompareMemory(void* Source1, void* Source2, nuint Length);

    [return: NativeTypeName("#define RtlCompareDeviceMemory RtlCompareMemory")]
    public static nuint RtlCompareDeviceMemory(void* Source1, void* Source2, nuint Length)
        => RtlCompareMemory(Source1, Source2, Length);

    [return: NativeTypeName("#define RtlEqualMemory(Destination, Source, Length) (!memcmp((Destination), (Source), (Length)))")]
    public static bool RtlEqualMemory(void* Destination, void* Source, nuint Length)
        => RtlCompareMemory(Destination, Source, Length) == Length;

}
