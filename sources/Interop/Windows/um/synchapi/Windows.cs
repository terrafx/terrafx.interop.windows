// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/synchapi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        [DllImport("kernel32", EntryPoint = "InitializeSRWLock", ExactSpelling = true)]
        public static extern void InitializeSRWLock([NativeTypeName("PSRWLOCK")] RTL_SRWLOCK* SRWLock);

        [DllImport("kernel32", EntryPoint = "ReleaseSRWLockExclusive", ExactSpelling = true)]
        public static extern void ReleaseSRWLockExclusive([NativeTypeName("PSRWLOCK")] RTL_SRWLOCK* SRWLock);

        [DllImport("kernel32", EntryPoint = "ReleaseSRWLockShared", ExactSpelling = true)]
        public static extern void ReleaseSRWLockShared([NativeTypeName("PSRWLOCK")] RTL_SRWLOCK* SRWLock);

        [DllImport("kernel32", EntryPoint = "AcquireSRWLockExclusive", ExactSpelling = true)]
        public static extern void AcquireSRWLockExclusive([NativeTypeName("PSRWLOCK")] RTL_SRWLOCK* SRWLock);

        [DllImport("kernel32", EntryPoint = "AcquireSRWLockShared", ExactSpelling = true)]
        public static extern void AcquireSRWLockShared([NativeTypeName("PSRWLOCK")] RTL_SRWLOCK* SRWLock);

        [DllImport("kernel32", EntryPoint = "TryAcquireSRWLockExclusive", ExactSpelling = true)]
        [return: NativeTypeName("BOOLEAN")]
        public static extern byte TryAcquireSRWLockExclusive([NativeTypeName("PSRWLOCK")] RTL_SRWLOCK* SRWLock);

        [DllImport("kernel32", EntryPoint = "TryAcquireSRWLockShared", ExactSpelling = true)]
        [return: NativeTypeName("BOOLEAN")]
        public static extern byte TryAcquireSRWLockShared([NativeTypeName("PSRWLOCK")] RTL_SRWLOCK* SRWLock);

        [DllImport("kernel32", EntryPoint = "InitializeCriticalSection", ExactSpelling = true)]
        public static extern void InitializeCriticalSection([NativeTypeName("LPCRITICAL_SECTION")] RTL_CRITICAL_SECTION* lpCriticalSection);

        [DllImport("kernel32", EntryPoint = "EnterCriticalSection", ExactSpelling = true)]
        public static extern void EnterCriticalSection([NativeTypeName("LPCRITICAL_SECTION")] RTL_CRITICAL_SECTION* lpCriticalSection);

        [DllImport("kernel32", EntryPoint = "LeaveCriticalSection", ExactSpelling = true)]
        public static extern void LeaveCriticalSection([NativeTypeName("LPCRITICAL_SECTION")] RTL_CRITICAL_SECTION* lpCriticalSection);

        [DllImport("kernel32", EntryPoint = "InitializeCriticalSectionAndSpinCount", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int InitializeCriticalSectionAndSpinCount([NativeTypeName("LPCRITICAL_SECTION")] RTL_CRITICAL_SECTION* lpCriticalSection, [NativeTypeName("DWORD")] uint dwSpinCount);

        [DllImport("kernel32", EntryPoint = "InitializeCriticalSectionEx", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int InitializeCriticalSectionEx([NativeTypeName("LPCRITICAL_SECTION")] RTL_CRITICAL_SECTION* lpCriticalSection, [NativeTypeName("DWORD")] uint dwSpinCount, [NativeTypeName("DWORD")] uint Flags);

        [DllImport("kernel32", EntryPoint = "SetCriticalSectionSpinCount", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint SetCriticalSectionSpinCount([NativeTypeName("LPCRITICAL_SECTION")] RTL_CRITICAL_SECTION* lpCriticalSection, [NativeTypeName("DWORD")] uint dwSpinCount);

        [DllImport("kernel32", EntryPoint = "TryEnterCriticalSection", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int TryEnterCriticalSection([NativeTypeName("LPCRITICAL_SECTION")] RTL_CRITICAL_SECTION* lpCriticalSection);

        [DllImport("kernel32", EntryPoint = "DeleteCriticalSection", ExactSpelling = true)]
        public static extern void DeleteCriticalSection([NativeTypeName("LPCRITICAL_SECTION")] RTL_CRITICAL_SECTION* lpCriticalSection);

        [DllImport("kernel32", EntryPoint = "InitOnceInitialize", ExactSpelling = true)]
        public static extern void InitOnceInitialize([NativeTypeName("PINIT_ONCE")] RTL_RUN_ONCE* InitOnce);

        [DllImport("kernel32", EntryPoint = "InitOnceExecuteOnce", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int InitOnceExecuteOnce([NativeTypeName("PINIT_ONCE")] RTL_RUN_ONCE* InitOnce, [NativeTypeName("PINIT_ONCE_FN")] delegate* stdcall<RTL_RUN_ONCE*, void*, void**, int> InitFn, [NativeTypeName("PVOID")] void* Parameter, [NativeTypeName("LPVOID *")] void** Context);

        [DllImport("kernel32", EntryPoint = "InitOnceBeginInitialize", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int InitOnceBeginInitialize([NativeTypeName("LPINIT_ONCE")] RTL_RUN_ONCE* lpInitOnce, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("PBOOL")] int* fPending, [NativeTypeName("LPVOID *")] void** lpContext);

        [DllImport("kernel32", EntryPoint = "InitOnceComplete", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int InitOnceComplete([NativeTypeName("LPINIT_ONCE")] RTL_RUN_ONCE* lpInitOnce, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LPVOID")] void* lpContext);

        [DllImport("kernel32", EntryPoint = "InitializeConditionVariable", ExactSpelling = true)]
        public static extern void InitializeConditionVariable([NativeTypeName("PCONDITION_VARIABLE")] RTL_CONDITION_VARIABLE* ConditionVariable);

        [DllImport("kernel32", EntryPoint = "WakeConditionVariable", ExactSpelling = true)]
        public static extern void WakeConditionVariable([NativeTypeName("PCONDITION_VARIABLE")] RTL_CONDITION_VARIABLE* ConditionVariable);

        [DllImport("kernel32", EntryPoint = "WakeAllConditionVariable", ExactSpelling = true)]
        public static extern void WakeAllConditionVariable([NativeTypeName("PCONDITION_VARIABLE")] RTL_CONDITION_VARIABLE* ConditionVariable);

        [DllImport("kernel32", EntryPoint = "SleepConditionVariableCS", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SleepConditionVariableCS([NativeTypeName("PCONDITION_VARIABLE")] RTL_CONDITION_VARIABLE* ConditionVariable, [NativeTypeName("PCRITICAL_SECTION")] RTL_CRITICAL_SECTION* CriticalSection, [NativeTypeName("DWORD")] uint dwMilliseconds);

        [DllImport("kernel32", EntryPoint = "SleepConditionVariableSRW", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SleepConditionVariableSRW([NativeTypeName("PCONDITION_VARIABLE")] RTL_CONDITION_VARIABLE* ConditionVariable, [NativeTypeName("PSRWLOCK")] RTL_SRWLOCK* SRWLock, [NativeTypeName("DWORD")] uint dwMilliseconds, [NativeTypeName("ULONG")] uint Flags);

        [DllImport("kernel32", EntryPoint = "SetEvent", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetEvent([NativeTypeName("HANDLE")] IntPtr hEvent);

        [DllImport("kernel32", EntryPoint = "ResetEvent", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ResetEvent([NativeTypeName("HANDLE")] IntPtr hEvent);

        [DllImport("kernel32", EntryPoint = "ReleaseSemaphore", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ReleaseSemaphore([NativeTypeName("HANDLE")] IntPtr hSemaphore, [NativeTypeName("LONG")] int lReleaseCount, [NativeTypeName("LPLONG")] int* lpPreviousCount);

        [DllImport("kernel32", EntryPoint = "ReleaseMutex", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ReleaseMutex([NativeTypeName("HANDLE")] IntPtr hMutex);

        [DllImport("kernel32", EntryPoint = "WaitForSingleObject", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint WaitForSingleObject([NativeTypeName("HANDLE")] IntPtr hHandle, [NativeTypeName("DWORD")] uint dwMilliseconds);

        [DllImport("kernel32", EntryPoint = "SleepEx", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint SleepEx([NativeTypeName("DWORD")] uint dwMilliseconds, [NativeTypeName("BOOL")] int bAlertable);

        [DllImport("kernel32", EntryPoint = "WaitForSingleObjectEx", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint WaitForSingleObjectEx([NativeTypeName("HANDLE")] IntPtr hHandle, [NativeTypeName("DWORD")] uint dwMilliseconds, [NativeTypeName("BOOL")] int bAlertable);

        [DllImport("kernel32", EntryPoint = "WaitForMultipleObjectsEx", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint WaitForMultipleObjectsEx([NativeTypeName("DWORD")] uint nCount, [NativeTypeName("const HANDLE *")] void** lpHandles, [NativeTypeName("BOOL")] int bWaitAll, [NativeTypeName("DWORD")] uint dwMilliseconds, [NativeTypeName("BOOL")] int bAlertable);

        [DllImport("kernel32", EntryPoint = "CreateMutexA", ExactSpelling = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern IntPtr CreateMutexA([NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpMutexAttributes, [NativeTypeName("BOOL")] int bInitialOwner, [NativeTypeName("LPCSTR")] sbyte* lpName);

        [DllImport("kernel32", EntryPoint = "CreateMutexW", ExactSpelling = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern IntPtr CreateMutexW([NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpMutexAttributes, [NativeTypeName("BOOL")] int bInitialOwner, [NativeTypeName("LPCWSTR")] ushort* lpName);

        [DllImport("kernel32", EntryPoint = "OpenMutexW", ExactSpelling = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern IntPtr OpenMutexW([NativeTypeName("DWORD")] uint dwDesiredAccess, [NativeTypeName("BOOL")] int bInheritHandle, [NativeTypeName("LPCWSTR")] ushort* lpName);

        [DllImport("kernel32", EntryPoint = "CreateEventA", ExactSpelling = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern IntPtr CreateEventA([NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpEventAttributes, [NativeTypeName("BOOL")] int bManualReset, [NativeTypeName("BOOL")] int bInitialState, [NativeTypeName("LPCSTR")] sbyte* lpName);

        [DllImport("kernel32", EntryPoint = "CreateEventW", ExactSpelling = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern IntPtr CreateEventW([NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpEventAttributes, [NativeTypeName("BOOL")] int bManualReset, [NativeTypeName("BOOL")] int bInitialState, [NativeTypeName("LPCWSTR")] ushort* lpName);

        [DllImport("kernel32", EntryPoint = "OpenEventA", ExactSpelling = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern IntPtr OpenEventA([NativeTypeName("DWORD")] uint dwDesiredAccess, [NativeTypeName("BOOL")] int bInheritHandle, [NativeTypeName("LPCSTR")] sbyte* lpName);

        [DllImport("kernel32", EntryPoint = "OpenEventW", ExactSpelling = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern IntPtr OpenEventW([NativeTypeName("DWORD")] uint dwDesiredAccess, [NativeTypeName("BOOL")] int bInheritHandle, [NativeTypeName("LPCWSTR")] ushort* lpName);

        [DllImport("kernel32", EntryPoint = "OpenSemaphoreW", ExactSpelling = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern IntPtr OpenSemaphoreW([NativeTypeName("DWORD")] uint dwDesiredAccess, [NativeTypeName("BOOL")] int bInheritHandle, [NativeTypeName("LPCWSTR")] ushort* lpName);

        [DllImport("kernel32", EntryPoint = "OpenWaitableTimerW", ExactSpelling = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern IntPtr OpenWaitableTimerW([NativeTypeName("DWORD")] uint dwDesiredAccess, [NativeTypeName("BOOL")] int bInheritHandle, [NativeTypeName("LPCWSTR")] ushort* lpTimerName);

        [DllImport("kernel32", EntryPoint = "SetWaitableTimerEx", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetWaitableTimerEx([NativeTypeName("HANDLE")] IntPtr hTimer, [NativeTypeName("const LARGE_INTEGER *")] LARGE_INTEGER* lpDueTime, [NativeTypeName("LONG")] int lPeriod, [NativeTypeName("PTIMERAPCROUTINE")] delegate* stdcall<void*, uint, uint, void> pfnCompletionRoutine, [NativeTypeName("LPVOID")] void* lpArgToCompletionRoutine, [NativeTypeName("PREASON_CONTEXT")] REASON_CONTEXT* WakeContext, [NativeTypeName("ULONG")] uint TolerableDelay);

        [DllImport("kernel32", EntryPoint = "SetWaitableTimer", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetWaitableTimer([NativeTypeName("HANDLE")] IntPtr hTimer, [NativeTypeName("const LARGE_INTEGER *")] LARGE_INTEGER* lpDueTime, [NativeTypeName("LONG")] int lPeriod, [NativeTypeName("PTIMERAPCROUTINE")] delegate* stdcall<void*, uint, uint, void> pfnCompletionRoutine, [NativeTypeName("LPVOID")] void* lpArgToCompletionRoutine, [NativeTypeName("BOOL")] int fResume);

        [DllImport("kernel32", EntryPoint = "CancelWaitableTimer", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CancelWaitableTimer([NativeTypeName("HANDLE")] IntPtr hTimer);

        [DllImport("kernel32", EntryPoint = "CreateMutexExA", ExactSpelling = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern IntPtr CreateMutexExA([NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpMutexAttributes, [NativeTypeName("LPCSTR")] sbyte* lpName, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("DWORD")] uint dwDesiredAccess);

        [DllImport("kernel32", EntryPoint = "CreateMutexExW", ExactSpelling = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern IntPtr CreateMutexExW([NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpMutexAttributes, [NativeTypeName("LPCWSTR")] ushort* lpName, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("DWORD")] uint dwDesiredAccess);

        [DllImport("kernel32", EntryPoint = "CreateEventExA", ExactSpelling = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern IntPtr CreateEventExA([NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpEventAttributes, [NativeTypeName("LPCSTR")] sbyte* lpName, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("DWORD")] uint dwDesiredAccess);

        [DllImport("kernel32", EntryPoint = "CreateEventExW", ExactSpelling = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern IntPtr CreateEventExW([NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpEventAttributes, [NativeTypeName("LPCWSTR")] ushort* lpName, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("DWORD")] uint dwDesiredAccess);

        [DllImport("kernel32", EntryPoint = "CreateSemaphoreExW", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern IntPtr CreateSemaphoreExW([NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpSemaphoreAttributes, [NativeTypeName("LONG")] int lInitialCount, [NativeTypeName("LONG")] int lMaximumCount, [NativeTypeName("LPCWSTR")] ushort* lpName, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("DWORD")] uint dwDesiredAccess);

        [DllImport("kernel32", EntryPoint = "CreateWaitableTimerExW", ExactSpelling = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern IntPtr CreateWaitableTimerExW([NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpTimerAttributes, [NativeTypeName("LPCWSTR")] ushort* lpTimerName, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("DWORD")] uint dwDesiredAccess);

        [DllImport("kernel32", EntryPoint = "EnterSynchronizationBarrier", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int EnterSynchronizationBarrier([NativeTypeName("LPSYNCHRONIZATION_BARRIER")] RTL_BARRIER* lpBarrier, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("kernel32", EntryPoint = "InitializeSynchronizationBarrier", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int InitializeSynchronizationBarrier([NativeTypeName("LPSYNCHRONIZATION_BARRIER")] RTL_BARRIER* lpBarrier, [NativeTypeName("LONG")] int lTotalThreads, [NativeTypeName("LONG")] int lSpinCount);

        [DllImport("kernel32", EntryPoint = "DeleteSynchronizationBarrier", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int DeleteSynchronizationBarrier([NativeTypeName("LPSYNCHRONIZATION_BARRIER")] RTL_BARRIER* lpBarrier);

        [DllImport("kernel32", EntryPoint = "Sleep", ExactSpelling = true)]
        public static extern void Sleep([NativeTypeName("DWORD")] uint dwMilliseconds);

        [DllImport("kernel32", EntryPoint = "WaitOnAddress", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int WaitOnAddress([NativeTypeName("volatile void *")] void* Address, [NativeTypeName("PVOID")] void* CompareAddress, [NativeTypeName("SIZE_T")] nuint AddressSize, [NativeTypeName("DWORD")] uint dwMilliseconds);

        [DllImport("kernel32", EntryPoint = "WakeByAddressSingle", ExactSpelling = true)]
        public static extern void WakeByAddressSingle([NativeTypeName("PVOID")] void* Address);

        [DllImport("kernel32", EntryPoint = "WakeByAddressAll", ExactSpelling = true)]
        public static extern void WakeByAddressAll([NativeTypeName("PVOID")] void* Address);

        [DllImport("kernel32", EntryPoint = "SignalObjectAndWait", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint SignalObjectAndWait([NativeTypeName("HANDLE")] IntPtr hObjectToSignal, [NativeTypeName("HANDLE")] IntPtr hObjectToWaitOn, [NativeTypeName("DWORD")] uint dwMilliseconds, [NativeTypeName("BOOL")] int bAlertable);

        [DllImport("kernel32", EntryPoint = "WaitForMultipleObjects", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint WaitForMultipleObjects([NativeTypeName("DWORD")] uint nCount, [NativeTypeName("const HANDLE *")] void** lpHandles, [NativeTypeName("BOOL")] int bWaitAll, [NativeTypeName("DWORD")] uint dwMilliseconds);

        [DllImport("kernel32", EntryPoint = "CreateSemaphoreW", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern IntPtr CreateSemaphoreW([NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpSemaphoreAttributes, [NativeTypeName("LONG")] int lInitialCount, [NativeTypeName("LONG")] int lMaximumCount, [NativeTypeName("LPCWSTR")] ushort* lpName);

        [DllImport("kernel32", EntryPoint = "CreateWaitableTimerW", ExactSpelling = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern IntPtr CreateWaitableTimerW([NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpTimerAttributes, [NativeTypeName("BOOL")] int bManualReset, [NativeTypeName("LPCWSTR")] ushort* lpTimerName);
    }
}
