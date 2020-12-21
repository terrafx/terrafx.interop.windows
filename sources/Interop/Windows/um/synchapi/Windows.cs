// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/synchapi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        [DllImport("kernel32", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern void InitializeSRWLock([NativeTypeName("PSRWLOCK")] RTL_SRWLOCK* SRWLock);

        [DllImport("kernel32", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern void ReleaseSRWLockExclusive([NativeTypeName("PSRWLOCK")] RTL_SRWLOCK* SRWLock);

        [DllImport("kernel32", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern void ReleaseSRWLockShared([NativeTypeName("PSRWLOCK")] RTL_SRWLOCK* SRWLock);

        [DllImport("kernel32", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern void AcquireSRWLockExclusive([NativeTypeName("PSRWLOCK")] RTL_SRWLOCK* SRWLock);

        [DllImport("kernel32", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern void AcquireSRWLockShared([NativeTypeName("PSRWLOCK")] RTL_SRWLOCK* SRWLock);

        [DllImport("kernel32", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOLEAN")]
        public static extern byte TryAcquireSRWLockExclusive([NativeTypeName("PSRWLOCK")] RTL_SRWLOCK* SRWLock);

        [DllImport("kernel32", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOLEAN")]
        public static extern byte TryAcquireSRWLockShared([NativeTypeName("PSRWLOCK")] RTL_SRWLOCK* SRWLock);

        [DllImport("kernel32", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern void InitializeCriticalSection([NativeTypeName("LPCRITICAL_SECTION")] RTL_CRITICAL_SECTION* lpCriticalSection);

        [DllImport("kernel32", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern void EnterCriticalSection([NativeTypeName("LPCRITICAL_SECTION")] RTL_CRITICAL_SECTION* lpCriticalSection);

        [DllImport("kernel32", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern void LeaveCriticalSection([NativeTypeName("LPCRITICAL_SECTION")] RTL_CRITICAL_SECTION* lpCriticalSection);

        [DllImport("kernel32", CallingConvention = CallingConvention.StdCall, ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int InitializeCriticalSectionAndSpinCount([NativeTypeName("LPCRITICAL_SECTION")] RTL_CRITICAL_SECTION* lpCriticalSection, [NativeTypeName("DWORD")] uint dwSpinCount);

        [DllImport("kernel32", CallingConvention = CallingConvention.StdCall, ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int InitializeCriticalSectionEx([NativeTypeName("LPCRITICAL_SECTION")] RTL_CRITICAL_SECTION* lpCriticalSection, [NativeTypeName("DWORD")] uint dwSpinCount, [NativeTypeName("DWORD")] uint Flags);

        [DllImport("kernel32", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint SetCriticalSectionSpinCount([NativeTypeName("LPCRITICAL_SECTION")] RTL_CRITICAL_SECTION* lpCriticalSection, [NativeTypeName("DWORD")] uint dwSpinCount);

        [DllImport("kernel32", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int TryEnterCriticalSection([NativeTypeName("LPCRITICAL_SECTION")] RTL_CRITICAL_SECTION* lpCriticalSection);

        [DllImport("kernel32", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern void DeleteCriticalSection([NativeTypeName("LPCRITICAL_SECTION")] RTL_CRITICAL_SECTION* lpCriticalSection);

        [DllImport("kernel32", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern void InitOnceInitialize([NativeTypeName("PINIT_ONCE")] RTL_RUN_ONCE* InitOnce);

        [DllImport("kernel32", CallingConvention = CallingConvention.StdCall, ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
#if !NETSTANDARD2_0
        public static extern int InitOnceExecuteOnce([NativeTypeName("PINIT_ONCE")] RTL_RUN_ONCE* InitOnce, [NativeTypeName("PINIT_ONCE_FN")] delegate* unmanaged<RTL_RUN_ONCE*, void*, void**, int> InitFn, [NativeTypeName("PVOID")] void* Parameter, [NativeTypeName("LPVOID *")] void** Context);
#else
        public static extern int InitOnceExecuteOnce([NativeTypeName("PINIT_ONCE")] RTL_RUN_ONCE* InitOnce, [NativeTypeName("PINIT_ONCE_FN")] delegate* unmanaged[Stdcall]<RTL_RUN_ONCE*, void*, void**, int> InitFn, [NativeTypeName("PVOID")] void* Parameter, [NativeTypeName("LPVOID *")] void** Context);
#endif


        [DllImport("kernel32", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int InitOnceBeginInitialize([NativeTypeName("LPINIT_ONCE")] RTL_RUN_ONCE* lpInitOnce, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("PBOOL")] int* fPending, [NativeTypeName("LPVOID *")] void** lpContext);

        [DllImport("kernel32", CallingConvention = CallingConvention.StdCall, ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int InitOnceComplete([NativeTypeName("LPINIT_ONCE")] RTL_RUN_ONCE* lpInitOnce, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LPVOID")] void* lpContext);

        [DllImport("kernel32", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern void InitializeConditionVariable([NativeTypeName("PCONDITION_VARIABLE")] RTL_CONDITION_VARIABLE* ConditionVariable);

        [DllImport("kernel32", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern void WakeConditionVariable([NativeTypeName("PCONDITION_VARIABLE")] RTL_CONDITION_VARIABLE* ConditionVariable);

        [DllImport("kernel32", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern void WakeAllConditionVariable([NativeTypeName("PCONDITION_VARIABLE")] RTL_CONDITION_VARIABLE* ConditionVariable);

        [DllImport("kernel32", CallingConvention = CallingConvention.StdCall, ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SleepConditionVariableCS([NativeTypeName("PCONDITION_VARIABLE")] RTL_CONDITION_VARIABLE* ConditionVariable, [NativeTypeName("PCRITICAL_SECTION")] RTL_CRITICAL_SECTION* CriticalSection, [NativeTypeName("DWORD")] uint dwMilliseconds);

        [DllImport("kernel32", CallingConvention = CallingConvention.StdCall, ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SleepConditionVariableSRW([NativeTypeName("PCONDITION_VARIABLE")] RTL_CONDITION_VARIABLE* ConditionVariable, [NativeTypeName("PSRWLOCK")] RTL_SRWLOCK* SRWLock, [NativeTypeName("DWORD")] uint dwMilliseconds, [NativeTypeName("ULONG")] uint Flags);

        [DllImport("kernel32", CallingConvention = CallingConvention.StdCall, ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetEvent([NativeTypeName("HANDLE")] IntPtr hEvent);

        [DllImport("kernel32", CallingConvention = CallingConvention.StdCall, ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ResetEvent([NativeTypeName("HANDLE")] IntPtr hEvent);

        [DllImport("kernel32", CallingConvention = CallingConvention.StdCall, ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ReleaseSemaphore([NativeTypeName("HANDLE")] IntPtr hSemaphore, [NativeTypeName("LONG")] int lReleaseCount, [NativeTypeName("LPLONG")] int* lpPreviousCount);

        [DllImport("kernel32", CallingConvention = CallingConvention.StdCall, ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ReleaseMutex([NativeTypeName("HANDLE")] IntPtr hMutex);

        [DllImport("kernel32", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint WaitForSingleObject([NativeTypeName("HANDLE")] IntPtr hHandle, [NativeTypeName("DWORD")] uint dwMilliseconds);

        [DllImport("kernel32", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint SleepEx([NativeTypeName("DWORD")] uint dwMilliseconds, [NativeTypeName("BOOL")] int bAlertable);

        [DllImport("kernel32", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint WaitForSingleObjectEx([NativeTypeName("HANDLE")] IntPtr hHandle, [NativeTypeName("DWORD")] uint dwMilliseconds, [NativeTypeName("BOOL")] int bAlertable);

        [DllImport("kernel32", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint WaitForMultipleObjectsEx([NativeTypeName("DWORD")] uint nCount, [NativeTypeName("const HANDLE *")] IntPtr* lpHandles, [NativeTypeName("BOOL")] int bWaitAll, [NativeTypeName("DWORD")] uint dwMilliseconds, [NativeTypeName("BOOL")] int bAlertable);

        [DllImport("kernel32", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern IntPtr CreateMutexA([NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpMutexAttributes, [NativeTypeName("BOOL")] int bInitialOwner, [NativeTypeName("LPCSTR")] sbyte* lpName);

        [DllImport("kernel32", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern IntPtr CreateMutexW([NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpMutexAttributes, [NativeTypeName("BOOL")] int bInitialOwner, [NativeTypeName("LPCWSTR")] ushort* lpName);

        [DllImport("kernel32", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern IntPtr OpenMutexW([NativeTypeName("DWORD")] uint dwDesiredAccess, [NativeTypeName("BOOL")] int bInheritHandle, [NativeTypeName("LPCWSTR")] ushort* lpName);

        [DllImport("kernel32", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern IntPtr CreateEventA([NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpEventAttributes, [NativeTypeName("BOOL")] int bManualReset, [NativeTypeName("BOOL")] int bInitialState, [NativeTypeName("LPCSTR")] sbyte* lpName);

        [DllImport("kernel32", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern IntPtr CreateEventW([NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpEventAttributes, [NativeTypeName("BOOL")] int bManualReset, [NativeTypeName("BOOL")] int bInitialState, [NativeTypeName("LPCWSTR")] ushort* lpName);

        [DllImport("kernel32", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern IntPtr OpenEventA([NativeTypeName("DWORD")] uint dwDesiredAccess, [NativeTypeName("BOOL")] int bInheritHandle, [NativeTypeName("LPCSTR")] sbyte* lpName);

        [DllImport("kernel32", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern IntPtr OpenEventW([NativeTypeName("DWORD")] uint dwDesiredAccess, [NativeTypeName("BOOL")] int bInheritHandle, [NativeTypeName("LPCWSTR")] ushort* lpName);

        [DllImport("kernel32", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern IntPtr OpenSemaphoreW([NativeTypeName("DWORD")] uint dwDesiredAccess, [NativeTypeName("BOOL")] int bInheritHandle, [NativeTypeName("LPCWSTR")] ushort* lpName);

        [DllImport("kernel32", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern IntPtr OpenWaitableTimerW([NativeTypeName("DWORD")] uint dwDesiredAccess, [NativeTypeName("BOOL")] int bInheritHandle, [NativeTypeName("LPCWSTR")] ushort* lpTimerName);

        [DllImport("kernel32", CallingConvention = CallingConvention.StdCall, ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
#if !NETSTANDARD2_0
        public static extern int SetWaitableTimerEx([NativeTypeName("HANDLE")] IntPtr hTimer, [NativeTypeName("const LARGE_INTEGER *")] LARGE_INTEGER* lpDueTime, [NativeTypeName("LONG")] int lPeriod, [NativeTypeName("PTIMERAPCROUTINE")] delegate* unmanaged<void*, uint, uint, void> pfnCompletionRoutine, [NativeTypeName("LPVOID")] void* lpArgToCompletionRoutine, [NativeTypeName("PREASON_CONTEXT")] REASON_CONTEXT* WakeContext, [NativeTypeName("ULONG")] uint TolerableDelay);
#else
        public static extern int SetWaitableTimerEx([NativeTypeName("HANDLE")] IntPtr hTimer, [NativeTypeName("const LARGE_INTEGER *")] LARGE_INTEGER* lpDueTime, [NativeTypeName("LONG")] int lPeriod, [NativeTypeName("PTIMERAPCROUTINE")] delegate* unmanaged[Stdcall]<void*, uint, uint, void> pfnCompletionRoutine, [NativeTypeName("LPVOID")] void* lpArgToCompletionRoutine, [NativeTypeName("PREASON_CONTEXT")] REASON_CONTEXT* WakeContext, [NativeTypeName("ULONG")] uint TolerableDelay);
#endif


        [DllImport("kernel32", CallingConvention = CallingConvention.StdCall, ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
#if !NETSTANDARD2_0
        public static extern int SetWaitableTimer([NativeTypeName("HANDLE")] IntPtr hTimer, [NativeTypeName("const LARGE_INTEGER *")] LARGE_INTEGER* lpDueTime, [NativeTypeName("LONG")] int lPeriod, [NativeTypeName("PTIMERAPCROUTINE")] delegate* unmanaged<void*, uint, uint, void> pfnCompletionRoutine, [NativeTypeName("LPVOID")] void* lpArgToCompletionRoutine, [NativeTypeName("BOOL")] int fResume);
#else
        public static extern int SetWaitableTimer([NativeTypeName("HANDLE")] IntPtr hTimer, [NativeTypeName("const LARGE_INTEGER *")] LARGE_INTEGER* lpDueTime, [NativeTypeName("LONG")] int lPeriod, [NativeTypeName("PTIMERAPCROUTINE")] delegate* unmanaged[Stdcall]<void*, uint, uint, void> pfnCompletionRoutine, [NativeTypeName("LPVOID")] void* lpArgToCompletionRoutine, [NativeTypeName("BOOL")] int fResume);
#endif


        [DllImport("kernel32", CallingConvention = CallingConvention.StdCall, ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CancelWaitableTimer([NativeTypeName("HANDLE")] IntPtr hTimer);

        [DllImport("kernel32", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern IntPtr CreateMutexExA([NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpMutexAttributes, [NativeTypeName("LPCSTR")] sbyte* lpName, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("DWORD")] uint dwDesiredAccess);

        [DllImport("kernel32", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern IntPtr CreateMutexExW([NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpMutexAttributes, [NativeTypeName("LPCWSTR")] ushort* lpName, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("DWORD")] uint dwDesiredAccess);

        [DllImport("kernel32", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern IntPtr CreateEventExA([NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpEventAttributes, [NativeTypeName("LPCSTR")] sbyte* lpName, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("DWORD")] uint dwDesiredAccess);

        [DllImport("kernel32", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern IntPtr CreateEventExW([NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpEventAttributes, [NativeTypeName("LPCWSTR")] ushort* lpName, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("DWORD")] uint dwDesiredAccess);

        [DllImport("kernel32", CallingConvention = CallingConvention.StdCall, ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern IntPtr CreateSemaphoreExW([NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpSemaphoreAttributes, [NativeTypeName("LONG")] int lInitialCount, [NativeTypeName("LONG")] int lMaximumCount, [NativeTypeName("LPCWSTR")] ushort* lpName, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("DWORD")] uint dwDesiredAccess);

        [DllImport("kernel32", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern IntPtr CreateWaitableTimerExW([NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpTimerAttributes, [NativeTypeName("LPCWSTR")] ushort* lpTimerName, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("DWORD")] uint dwDesiredAccess);

        [DllImport("kernel32", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int EnterSynchronizationBarrier([NativeTypeName("LPSYNCHRONIZATION_BARRIER")] RTL_BARRIER* lpBarrier, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("kernel32", CallingConvention = CallingConvention.StdCall, ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int InitializeSynchronizationBarrier([NativeTypeName("LPSYNCHRONIZATION_BARRIER")] RTL_BARRIER* lpBarrier, [NativeTypeName("LONG")] int lTotalThreads, [NativeTypeName("LONG")] int lSpinCount);

        [DllImport("kernel32", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int DeleteSynchronizationBarrier([NativeTypeName("LPSYNCHRONIZATION_BARRIER")] RTL_BARRIER* lpBarrier);

        [DllImport("kernel32", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern void Sleep([NativeTypeName("DWORD")] uint dwMilliseconds);

        [DllImport("kernel32", CallingConvention = CallingConvention.StdCall, ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int WaitOnAddress([NativeTypeName("volatile void *")] void* Address, [NativeTypeName("PVOID")] void* CompareAddress, [NativeTypeName("SIZE_T")] nuint AddressSize, [NativeTypeName("DWORD")] uint dwMilliseconds);

        [DllImport("kernel32", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern void WakeByAddressSingle([NativeTypeName("PVOID")] void* Address);

        [DllImport("kernel32", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern void WakeByAddressAll([NativeTypeName("PVOID")] void* Address);

        [DllImport("kernel32", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint SignalObjectAndWait([NativeTypeName("HANDLE")] IntPtr hObjectToSignal, [NativeTypeName("HANDLE")] IntPtr hObjectToWaitOn, [NativeTypeName("DWORD")] uint dwMilliseconds, [NativeTypeName("BOOL")] int bAlertable);

        [DllImport("kernel32", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint WaitForMultipleObjects([NativeTypeName("DWORD")] uint nCount, [NativeTypeName("const HANDLE *")] IntPtr* lpHandles, [NativeTypeName("BOOL")] int bWaitAll, [NativeTypeName("DWORD")] uint dwMilliseconds);

        [DllImport("kernel32", CallingConvention = CallingConvention.StdCall, ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern IntPtr CreateSemaphoreW([NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpSemaphoreAttributes, [NativeTypeName("LONG")] int lInitialCount, [NativeTypeName("LONG")] int lMaximumCount, [NativeTypeName("LPCWSTR")] ushort* lpName);

        [DllImport("kernel32", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern IntPtr CreateWaitableTimerW([NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpTimerAttributes, [NativeTypeName("BOOL")] int bManualReset, [NativeTypeName("LPCWSTR")] ushort* lpTimerName);

        [NativeTypeName("#define INIT_ONCE_CHECK_ONLY RTL_RUN_ONCE_CHECK_ONLY")]
        public const uint INIT_ONCE_CHECK_ONLY = 0x00000001U;

        [NativeTypeName("#define INIT_ONCE_ASYNC RTL_RUN_ONCE_ASYNC")]
        public const uint INIT_ONCE_ASYNC = 0x00000002U;

        [NativeTypeName("#define INIT_ONCE_INIT_FAILED RTL_RUN_ONCE_INIT_FAILED")]
        public const uint INIT_ONCE_INIT_FAILED = 0x00000004U;

        [NativeTypeName("#define INIT_ONCE_CTX_RESERVED_BITS RTL_RUN_ONCE_CTX_RESERVED_BITS")]
        public const int INIT_ONCE_CTX_RESERVED_BITS = 2;

        [NativeTypeName("#define CONDITION_VARIABLE_LOCKMODE_SHARED RTL_CONDITION_VARIABLE_LOCKMODE_SHARED")]
        public const int CONDITION_VARIABLE_LOCKMODE_SHARED = 0x1;

        [NativeTypeName("#define MUTEX_MODIFY_STATE MUTANT_QUERY_STATE")]
        public const int MUTEX_MODIFY_STATE = 0x0001;

        [NativeTypeName("#define MUTEX_ALL_ACCESS MUTANT_ALL_ACCESS")]
        public const int MUTEX_ALL_ACCESS = ((0x000F0000) | (0x00100000) | 0x0001);

        [NativeTypeName("#define CreateMutex CreateMutexW")]
        public static readonly delegate*<SECURITY_ATTRIBUTES*, int, ushort*, IntPtr> CreateMutex = &CreateMutexW;

        [NativeTypeName("#define OpenMutex OpenMutexW")]
        public static readonly delegate*<uint, int, ushort*, IntPtr> OpenMutex = &OpenMutexW;

        [NativeTypeName("#define CreateEvent CreateEventW")]
        public static readonly delegate*<SECURITY_ATTRIBUTES*, int, int, ushort*, IntPtr> CreateEvent = &CreateEventW;

        [NativeTypeName("#define OpenEvent OpenEventW")]
        public static readonly delegate*<uint, int, ushort*, IntPtr> OpenEvent = &OpenEventW;

        [NativeTypeName("#define OpenSemaphore OpenSemaphoreW")]
        public static readonly delegate*<uint, int, ushort*, IntPtr> OpenSemaphore = &OpenSemaphoreW;

        [NativeTypeName("#define OpenWaitableTimer OpenWaitableTimerW")]
        public static readonly delegate*<uint, int, ushort*, IntPtr> OpenWaitableTimer = &OpenWaitableTimerW;

        [NativeTypeName("#define CREATE_MUTEX_INITIAL_OWNER 0x00000001")]
        public const int CREATE_MUTEX_INITIAL_OWNER = 0x00000001;

        [NativeTypeName("#define CreateMutexEx CreateMutexExW")]
        public static readonly delegate*<SECURITY_ATTRIBUTES*, ushort*, uint, uint, IntPtr> CreateMutexEx = &CreateMutexExW;

        [NativeTypeName("#define CREATE_EVENT_MANUAL_RESET 0x00000001")]
        public const int CREATE_EVENT_MANUAL_RESET = 0x00000001;

        [NativeTypeName("#define CREATE_EVENT_INITIAL_SET 0x00000002")]
        public const int CREATE_EVENT_INITIAL_SET = 0x00000002;

        [NativeTypeName("#define CreateEventEx CreateEventExW")]
        public static readonly delegate*<SECURITY_ATTRIBUTES*, ushort*, uint, uint, IntPtr> CreateEventEx = &CreateEventExW;

        [NativeTypeName("#define CreateSemaphoreEx CreateSemaphoreExW")]
        public static readonly delegate*<SECURITY_ATTRIBUTES*, int, int, ushort*, uint, uint, IntPtr> CreateSemaphoreEx = &CreateSemaphoreExW;

        [NativeTypeName("#define CREATE_WAITABLE_TIMER_MANUAL_RESET 0x00000001")]
        public const int CREATE_WAITABLE_TIMER_MANUAL_RESET = 0x00000001;

        [NativeTypeName("#define CREATE_WAITABLE_TIMER_HIGH_RESOLUTION 0x00000002")]
        public const int CREATE_WAITABLE_TIMER_HIGH_RESOLUTION = 0x00000002;

        [NativeTypeName("#define CreateWaitableTimerEx CreateWaitableTimerExW")]
        public static readonly delegate*<SECURITY_ATTRIBUTES*, ushort*, uint, uint, IntPtr> CreateWaitableTimerEx = &CreateWaitableTimerExW;

        [NativeTypeName("#define SYNCHRONIZATION_BARRIER_FLAGS_SPIN_ONLY 0x01")]
        public const int SYNCHRONIZATION_BARRIER_FLAGS_SPIN_ONLY = 0x01;

        [NativeTypeName("#define SYNCHRONIZATION_BARRIER_FLAGS_BLOCK_ONLY 0x02")]
        public const int SYNCHRONIZATION_BARRIER_FLAGS_BLOCK_ONLY = 0x02;

        [NativeTypeName("#define SYNCHRONIZATION_BARRIER_FLAGS_NO_DELETE 0x04")]
        public const int SYNCHRONIZATION_BARRIER_FLAGS_NO_DELETE = 0x04;

        [NativeTypeName("#define CreateSemaphore CreateSemaphoreW")]
        public static readonly delegate*<SECURITY_ATTRIBUTES*, int, int, ushort*, IntPtr> CreateSemaphore = &CreateSemaphoreW;

        [NativeTypeName("#define CreateWaitableTimer CreateWaitableTimerW")]
        public static readonly delegate*<SECURITY_ATTRIBUTES*, int, ushort*, IntPtr> CreateWaitableTimer = &CreateWaitableTimerW;
    }
}
