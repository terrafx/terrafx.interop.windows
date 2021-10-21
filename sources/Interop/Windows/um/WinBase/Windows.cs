// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinBase.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.PROC_THREAD_ATTRIBUTE_NUM;
using static TerraFX.Interop.SECURITY_IMPERSONATION_LEVEL;

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("HGLOBAL")]
        public static extern IntPtr GlobalAlloc([NativeTypeName("UINT")] uint uFlags, [NativeTypeName("SIZE_T")] nuint dwBytes);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("HGLOBAL")]
        public static extern IntPtr GlobalReAlloc([NativeTypeName("HGLOBAL")] IntPtr hMem, [NativeTypeName("SIZE_T")] nuint dwBytes, [NativeTypeName("UINT")] uint uFlags);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("SIZE_T")]
        public static extern nuint GlobalSize([NativeTypeName("HGLOBAL")] IntPtr hMem);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GlobalUnlock([NativeTypeName("HGLOBAL")] IntPtr hMem);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("LPVOID")]
        public static extern void* GlobalLock([NativeTypeName("HGLOBAL")] IntPtr hMem);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint GlobalFlags([NativeTypeName("HGLOBAL")] IntPtr hMem);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("HGLOBAL")]
        public static extern IntPtr GlobalHandle([NativeTypeName("LPCVOID")] void* pMem);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("HGLOBAL")]
        public static extern IntPtr GlobalFree([NativeTypeName("HGLOBAL")] IntPtr hMem);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("SIZE_T")]
        public static extern nuint GlobalCompact([NativeTypeName("DWORD")] uint dwMinFree);

        [DllImport("kernel32", ExactSpelling = true)]
        public static extern void GlobalFix([NativeTypeName("HGLOBAL")] IntPtr hMem);

        [DllImport("kernel32", ExactSpelling = true)]
        public static extern void GlobalUnfix([NativeTypeName("HGLOBAL")] IntPtr hMem);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("LPVOID")]
        public static extern void* GlobalWire([NativeTypeName("HGLOBAL")] IntPtr hMem);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GlobalUnWire([NativeTypeName("HGLOBAL")] IntPtr hMem);

        [DllImport("kernel32", ExactSpelling = true)]
        public static extern void GlobalMemoryStatus([NativeTypeName("LPMEMORYSTATUS")] MEMORYSTATUS* lpBuffer);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("HLOCAL")]
        public static extern IntPtr LocalAlloc([NativeTypeName("UINT")] uint uFlags, [NativeTypeName("SIZE_T")] nuint uBytes);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("HLOCAL")]
        public static extern IntPtr LocalReAlloc([NativeTypeName("HLOCAL")] IntPtr hMem, [NativeTypeName("SIZE_T")] nuint uBytes, [NativeTypeName("UINT")] uint uFlags);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("LPVOID")]
        public static extern void* LocalLock([NativeTypeName("HLOCAL")] IntPtr hMem);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("HLOCAL")]
        public static extern IntPtr LocalHandle([NativeTypeName("LPCVOID")] void* pMem);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int LocalUnlock([NativeTypeName("HLOCAL")] IntPtr hMem);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("SIZE_T")]
        public static extern nuint LocalSize([NativeTypeName("HLOCAL")] IntPtr hMem);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint LocalFlags([NativeTypeName("HLOCAL")] IntPtr hMem);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("HLOCAL")]
        public static extern IntPtr LocalFree([NativeTypeName("HLOCAL")] IntPtr hMem);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("SIZE_T")]
        public static extern nuint LocalShrink([NativeTypeName("HLOCAL")] IntPtr hMem, [NativeTypeName("UINT")] uint cbNewSize);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("SIZE_T")]
        public static extern nuint LocalCompact([NativeTypeName("UINT")] uint uMinFree);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetBinaryTypeA([NativeTypeName("LPCSTR")] sbyte* lpApplicationName, [NativeTypeName("LPDWORD")] uint* lpBinaryType);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetBinaryTypeW([NativeTypeName("LPCWSTR")] ushort* lpApplicationName, [NativeTypeName("LPDWORD")] uint* lpBinaryType);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetShortPathNameA([NativeTypeName("LPCSTR")] sbyte* lpszLongPath, [NativeTypeName("LPSTR")] sbyte* lpszShortPath, [NativeTypeName("DWORD")] uint cchBuffer);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetLongPathNameTransactedA([NativeTypeName("LPCSTR")] sbyte* lpszShortPath, [NativeTypeName("LPSTR")] sbyte* lpszLongPath, [NativeTypeName("DWORD")] uint cchBuffer, [NativeTypeName("HANDLE")] IntPtr hTransaction);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetLongPathNameTransactedW([NativeTypeName("LPCWSTR")] ushort* lpszShortPath, [NativeTypeName("LPWSTR")] ushort* lpszLongPath, [NativeTypeName("DWORD")] uint cchBuffer, [NativeTypeName("HANDLE")] IntPtr hTransaction);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetProcessAffinityMask([NativeTypeName("HANDLE")] IntPtr hProcess, [NativeTypeName("PDWORD_PTR")] nuint* lpProcessAffinityMask, [NativeTypeName("PDWORD_PTR")] nuint* lpSystemAffinityMask);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetProcessAffinityMask([NativeTypeName("HANDLE")] IntPtr hProcess, [NativeTypeName("DWORD_PTR")] nuint dwProcessAffinityMask);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetProcessIoCounters([NativeTypeName("HANDLE")] IntPtr hProcess, [NativeTypeName("PIO_COUNTERS")] IO_COUNTERS* lpIoCounters);

        [DllImport("kernel32", ExactSpelling = true)]
        public static extern void FatalExit(int ExitCode);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetEnvironmentStringsA([NativeTypeName("LPCH")] sbyte* NewEnvironment);

        [DllImport("kernel32", ExactSpelling = true)]
        public static extern void SwitchToFiber([NativeTypeName("LPVOID")] void* lpFiber);

        [DllImport("kernel32", ExactSpelling = true)]
        public static extern void DeleteFiber([NativeTypeName("LPVOID")] void* lpFiber);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ConvertFiberToThread();

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("LPVOID")]
        public static extern void* CreateFiberEx([NativeTypeName("SIZE_T")] nuint dwStackCommitSize, [NativeTypeName("SIZE_T")] nuint dwStackReserveSize, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LPFIBER_START_ROUTINE")] delegate* unmanaged<void*, void> lpStartAddress, [NativeTypeName("LPVOID")] void* lpParameter);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("LPVOID")]
        public static extern void* ConvertThreadToFiberEx([NativeTypeName("LPVOID")] void* lpParameter, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("LPVOID")]
        public static extern void* CreateFiber([NativeTypeName("SIZE_T")] nuint dwStackSize, [NativeTypeName("LPFIBER_START_ROUTINE")] delegate* unmanaged<void*, void> lpStartAddress, [NativeTypeName("LPVOID")] void* lpParameter);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("LPVOID")]
        public static extern void* ConvertThreadToFiber([NativeTypeName("LPVOID")] void* lpParameter);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CreateUmsCompletionList([NativeTypeName("PUMS_COMPLETION_LIST *")] void** UmsCompletionList);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int DequeueUmsCompletionListItems([NativeTypeName("PUMS_COMPLETION_LIST")] void* UmsCompletionList, [NativeTypeName("DWORD")] uint WaitTimeOut, [NativeTypeName("PUMS_CONTEXT *")] void** UmsThreadList);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetUmsCompletionListEvent([NativeTypeName("PUMS_COMPLETION_LIST")] void* UmsCompletionList, [NativeTypeName("PHANDLE")] IntPtr* UmsCompletionEvent);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ExecuteUmsThread([NativeTypeName("PUMS_CONTEXT")] void* UmsThread);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int UmsThreadYield([NativeTypeName("PVOID")] void* SchedulerParam);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int DeleteUmsCompletionList([NativeTypeName("PUMS_COMPLETION_LIST")] void* UmsCompletionList);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("PUMS_CONTEXT")]
        public static extern void* GetCurrentUmsThread();

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("PUMS_CONTEXT")]
        public static extern void* GetNextUmsListItem([NativeTypeName("PUMS_CONTEXT")] void* UmsContext);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int QueryUmsThreadInformation([NativeTypeName("PUMS_CONTEXT")] void* UmsThread, [NativeTypeName("UMS_THREAD_INFO_CLASS")] RTL_UMS_THREAD_INFO_CLASS UmsThreadInfoClass, [NativeTypeName("PVOID")] void* UmsThreadInformation, [NativeTypeName("ULONG")] uint UmsThreadInformationLength, [NativeTypeName("PULONG")] uint* ReturnLength);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetUmsThreadInformation([NativeTypeName("PUMS_CONTEXT")] void* UmsThread, [NativeTypeName("UMS_THREAD_INFO_CLASS")] RTL_UMS_THREAD_INFO_CLASS UmsThreadInfoClass, [NativeTypeName("PVOID")] void* UmsThreadInformation, [NativeTypeName("ULONG")] uint UmsThreadInformationLength);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int DeleteUmsThreadContext([NativeTypeName("PUMS_CONTEXT")] void* UmsThread);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CreateUmsThreadContext([NativeTypeName("PUMS_CONTEXT *")] void** lpUmsThread);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int EnterUmsSchedulingMode([NativeTypeName("PUMS_SCHEDULER_STARTUP_INFO")] UMS_SCHEDULER_STARTUP_INFO* SchedulerStartupInfo);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetUmsSystemThreadInformation([NativeTypeName("HANDLE")] IntPtr ThreadHandle, [NativeTypeName("PUMS_SYSTEM_THREAD_INFORMATION")] UMS_SYSTEM_THREAD_INFORMATION* SystemThreadInfo);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("DWORD_PTR")]
        public static extern nuint SetThreadAffinityMask([NativeTypeName("HANDLE")] IntPtr hThread, [NativeTypeName("DWORD_PTR")] nuint dwThreadAffinityMask);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetProcessDEPPolicy([NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetProcessDEPPolicy([NativeTypeName("HANDLE")] IntPtr hProcess, [NativeTypeName("LPDWORD")] uint* lpFlags, [NativeTypeName("PBOOL")] int* lpPermanent);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int RequestWakeupLatency(LATENCY_TIME latency);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int IsSystemResumeAutomatic();

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetThreadSelectorEntry([NativeTypeName("HANDLE")] IntPtr hThread, [NativeTypeName("DWORD")] uint dwSelector, [NativeTypeName("LPLDT_ENTRY")] LDT_ENTRY* lpSelectorEntry);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("EXECUTION_STATE")]
        public static extern uint SetThreadExecutionState([NativeTypeName("EXECUTION_STATE")] uint esFlags);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern IntPtr PowerCreateRequest([NativeTypeName("PREASON_CONTEXT")] REASON_CONTEXT* Context);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int PowerSetRequest([NativeTypeName("HANDLE")] IntPtr PowerRequest, POWER_REQUEST_TYPE RequestType);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int PowerClearRequest([NativeTypeName("HANDLE")] IntPtr PowerRequest, POWER_REQUEST_TYPE RequestType);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetFileCompletionNotificationModes([NativeTypeName("HANDLE")] IntPtr FileHandle, [NativeTypeName("UCHAR")] byte Flags);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int Wow64GetThreadSelectorEntry([NativeTypeName("HANDLE")] IntPtr hThread, [NativeTypeName("DWORD")] uint dwSelector, [NativeTypeName("PWOW64_LDT_ENTRY")] WOW64_LDT_ENTRY* lpSelectorEntry);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int DebugSetProcessKillOnExit([NativeTypeName("BOOL")] int KillOnExit);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int DebugBreakProcess([NativeTypeName("HANDLE")] IntPtr Process);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int PulseEvent([NativeTypeName("HANDLE")] IntPtr hEvent);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("ATOM")]
        public static extern ushort GlobalDeleteAtom([NativeTypeName("ATOM")] ushort nAtom);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int InitAtomTable([NativeTypeName("DWORD")] uint nSize);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("ATOM")]
        public static extern ushort DeleteAtom([NativeTypeName("ATOM")] ushort nAtom);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint SetHandleCount([NativeTypeName("UINT")] uint uNumber);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int RequestDeviceWakeup([NativeTypeName("HANDLE")] IntPtr hDevice);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CancelDeviceWakeupRequest([NativeTypeName("HANDLE")] IntPtr hDevice);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetDevicePowerState([NativeTypeName("HANDLE")] IntPtr hDevice, [NativeTypeName("BOOL *")] int* pfOn);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetMessageWaitingIndicator([NativeTypeName("HANDLE")] IntPtr hMsgIndicator, [NativeTypeName("ULONG")] uint ulMsgCount);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetFileShortNameA([NativeTypeName("HANDLE")] IntPtr hFile, [NativeTypeName("LPCSTR")] sbyte* lpShortName);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetFileShortNameW([NativeTypeName("HANDLE")] IntPtr hFile, [NativeTypeName("LPCWSTR")] ushort* lpShortName);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint LoadModule([NativeTypeName("LPCSTR")] sbyte* lpModuleName, [NativeTypeName("LPVOID")] void* lpParameterBlock);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint WinExec([NativeTypeName("LPCSTR")] sbyte* lpCmdLine, [NativeTypeName("UINT")] uint uCmdShow);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ClearCommBreak([NativeTypeName("HANDLE")] IntPtr hFile);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ClearCommError([NativeTypeName("HANDLE")] IntPtr hFile, [NativeTypeName("LPDWORD")] uint* lpErrors, [NativeTypeName("LPCOMSTAT")] COMSTAT* lpStat);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupComm([NativeTypeName("HANDLE")] IntPtr hFile, [NativeTypeName("DWORD")] uint dwInQueue, [NativeTypeName("DWORD")] uint dwOutQueue);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int EscapeCommFunction([NativeTypeName("HANDLE")] IntPtr hFile, [NativeTypeName("DWORD")] uint dwFunc);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetCommConfig([NativeTypeName("HANDLE")] IntPtr hCommDev, [NativeTypeName("LPCOMMCONFIG")] COMMCONFIG* lpCC, [NativeTypeName("LPDWORD")] uint* lpdwSize);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetCommMask([NativeTypeName("HANDLE")] IntPtr hFile, [NativeTypeName("LPDWORD")] uint* lpEvtMask);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetCommProperties([NativeTypeName("HANDLE")] IntPtr hFile, [NativeTypeName("LPCOMMPROP")] COMMPROP* lpCommProp);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetCommModemStatus([NativeTypeName("HANDLE")] IntPtr hFile, [NativeTypeName("LPDWORD")] uint* lpModemStat);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetCommState([NativeTypeName("HANDLE")] IntPtr hFile, [NativeTypeName("LPDCB")] DCB* lpDCB);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetCommTimeouts([NativeTypeName("HANDLE")] IntPtr hFile, [NativeTypeName("LPCOMMTIMEOUTS")] COMMTIMEOUTS* lpCommTimeouts);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int PurgeComm([NativeTypeName("HANDLE")] IntPtr hFile, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetCommBreak([NativeTypeName("HANDLE")] IntPtr hFile);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetCommConfig([NativeTypeName("HANDLE")] IntPtr hCommDev, [NativeTypeName("LPCOMMCONFIG")] COMMCONFIG* lpCC, [NativeTypeName("DWORD")] uint dwSize);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetCommMask([NativeTypeName("HANDLE")] IntPtr hFile, [NativeTypeName("DWORD")] uint dwEvtMask);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetCommState([NativeTypeName("HANDLE")] IntPtr hFile, [NativeTypeName("LPDCB")] DCB* lpDCB);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetCommTimeouts([NativeTypeName("HANDLE")] IntPtr hFile, [NativeTypeName("LPCOMMTIMEOUTS")] COMMTIMEOUTS* lpCommTimeouts);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int TransmitCommChar([NativeTypeName("HANDLE")] IntPtr hFile, [NativeTypeName("char")] sbyte cChar);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int WaitCommEvent([NativeTypeName("HANDLE")] IntPtr hFile, [NativeTypeName("LPDWORD")] uint* lpEvtMask, [NativeTypeName("LPOVERLAPPED")] OVERLAPPED* lpOverlapped);

        [DllImport("kernelbase", ExactSpelling = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern IntPtr OpenCommPort([NativeTypeName("ULONG")] uint uPortNumber, [NativeTypeName("DWORD")] uint dwDesiredAccess, [NativeTypeName("DWORD")] uint dwFlagsAndAttributes);

        [DllImport("kernelbase", ExactSpelling = true)]
        [return: NativeTypeName("ULONG")]
        public static extern uint GetCommPorts([NativeTypeName("PULONG")] uint* lpPortNumbers, [NativeTypeName("ULONG")] uint uPortNumbersCount, [NativeTypeName("PULONG")] uint* puPortNumbersFound);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint SetTapePosition([NativeTypeName("HANDLE")] IntPtr hDevice, [NativeTypeName("DWORD")] uint dwPositionMethod, [NativeTypeName("DWORD")] uint dwPartition, [NativeTypeName("DWORD")] uint dwOffsetLow, [NativeTypeName("DWORD")] uint dwOffsetHigh, [NativeTypeName("BOOL")] int bImmediate);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetTapePosition([NativeTypeName("HANDLE")] IntPtr hDevice, [NativeTypeName("DWORD")] uint dwPositionType, [NativeTypeName("LPDWORD")] uint* lpdwPartition, [NativeTypeName("LPDWORD")] uint* lpdwOffsetLow, [NativeTypeName("LPDWORD")] uint* lpdwOffsetHigh);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint PrepareTape([NativeTypeName("HANDLE")] IntPtr hDevice, [NativeTypeName("DWORD")] uint dwOperation, [NativeTypeName("BOOL")] int bImmediate);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint EraseTape([NativeTypeName("HANDLE")] IntPtr hDevice, [NativeTypeName("DWORD")] uint dwEraseType, [NativeTypeName("BOOL")] int bImmediate);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint CreateTapePartition([NativeTypeName("HANDLE")] IntPtr hDevice, [NativeTypeName("DWORD")] uint dwPartitionMethod, [NativeTypeName("DWORD")] uint dwCount, [NativeTypeName("DWORD")] uint dwSize);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint WriteTapemark([NativeTypeName("HANDLE")] IntPtr hDevice, [NativeTypeName("DWORD")] uint dwTapemarkType, [NativeTypeName("DWORD")] uint dwTapemarkCount, [NativeTypeName("BOOL")] int bImmediate);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetTapeStatus([NativeTypeName("HANDLE")] IntPtr hDevice);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetTapeParameters([NativeTypeName("HANDLE")] IntPtr hDevice, [NativeTypeName("DWORD")] uint dwOperation, [NativeTypeName("LPDWORD")] uint* lpdwSize, [NativeTypeName("LPVOID")] void* lpTapeInformation);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint SetTapeParameters([NativeTypeName("HANDLE")] IntPtr hDevice, [NativeTypeName("DWORD")] uint dwOperation, [NativeTypeName("LPVOID")] void* lpTapeInformation);

        [DllImport("kernel32", ExactSpelling = true)]
        public static extern int MulDiv(int nNumber, int nNumerator, int nDenominator);

        [DllImport("kernel32", ExactSpelling = true)]
        public static extern DEP_SYSTEM_POLICY_TYPE GetSystemDEPPolicy();

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetSystemRegistryQuota([NativeTypeName("PDWORD")] uint* pdwQuotaAllowed, [NativeTypeName("PDWORD")] uint* pdwQuotaUsed);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int FileTimeToDosDateTime([NativeTypeName("const FILETIME *")] FILETIME* lpFileTime, [NativeTypeName("LPWORD")] ushort* lpFatDate, [NativeTypeName("LPWORD")] ushort* lpFatTime);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int DosDateTimeToFileTime([NativeTypeName("WORD")] ushort wFatDate, [NativeTypeName("WORD")] ushort wFatTime, [NativeTypeName("LPFILETIME")] FILETIME* lpFileTime);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint FormatMessageA([NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LPCVOID")] void* lpSource, [NativeTypeName("DWORD")] uint dwMessageId, [NativeTypeName("DWORD")] uint dwLanguageId, [NativeTypeName("LPSTR")] sbyte* lpBuffer, [NativeTypeName("DWORD")] uint nSize, [NativeTypeName("va_list *")] sbyte** Arguments);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint FormatMessageW([NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LPCVOID")] void* lpSource, [NativeTypeName("DWORD")] uint dwMessageId, [NativeTypeName("DWORD")] uint dwLanguageId, [NativeTypeName("LPWSTR")] ushort* lpBuffer, [NativeTypeName("DWORD")] uint nSize, [NativeTypeName("va_list *")] sbyte** Arguments);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern IntPtr CreateMailslotA([NativeTypeName("LPCSTR")] sbyte* lpName, [NativeTypeName("DWORD")] uint nMaxMessageSize, [NativeTypeName("DWORD")] uint lReadTimeout, [NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpSecurityAttributes);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern IntPtr CreateMailslotW([NativeTypeName("LPCWSTR")] ushort* lpName, [NativeTypeName("DWORD")] uint nMaxMessageSize, [NativeTypeName("DWORD")] uint lReadTimeout, [NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpSecurityAttributes);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetMailslotInfo([NativeTypeName("HANDLE")] IntPtr hMailslot, [NativeTypeName("LPDWORD")] uint* lpMaxMessageSize, [NativeTypeName("LPDWORD")] uint* lpNextSize, [NativeTypeName("LPDWORD")] uint* lpMessageCount, [NativeTypeName("LPDWORD")] uint* lpReadTimeout);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetMailslotInfo([NativeTypeName("HANDLE")] IntPtr hMailslot, [NativeTypeName("DWORD")] uint lReadTimeout);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int EncryptFileA([NativeTypeName("LPCSTR")] sbyte* lpFileName);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int EncryptFileW([NativeTypeName("LPCWSTR")] ushort* lpFileName);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int DecryptFileA([NativeTypeName("LPCSTR")] sbyte* lpFileName, [NativeTypeName("DWORD")] uint dwReserved);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int DecryptFileW([NativeTypeName("LPCWSTR")] ushort* lpFileName, [NativeTypeName("DWORD")] uint dwReserved);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int FileEncryptionStatusA([NativeTypeName("LPCSTR")] sbyte* lpFileName, [NativeTypeName("LPDWORD")] uint* lpStatus);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int FileEncryptionStatusW([NativeTypeName("LPCWSTR")] ushort* lpFileName, [NativeTypeName("LPDWORD")] uint* lpStatus);

        [DllImport("advapi32", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint OpenEncryptedFileRawA([NativeTypeName("LPCSTR")] sbyte* lpFileName, [NativeTypeName("ULONG")] uint ulFlags, [NativeTypeName("PVOID *")] void** pvContext);

        [DllImport("advapi32", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint OpenEncryptedFileRawW([NativeTypeName("LPCWSTR")] ushort* lpFileName, [NativeTypeName("ULONG")] uint ulFlags, [NativeTypeName("PVOID *")] void** pvContext);

        [DllImport("advapi32", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint ReadEncryptedFileRaw([NativeTypeName("PFE_EXPORT_FUNC")] delegate* unmanaged<byte*, void*, uint, uint> pfExportCallback, [NativeTypeName("PVOID")] void* pvCallbackContext, [NativeTypeName("PVOID")] void* pvContext);

        [DllImport("advapi32", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint WriteEncryptedFileRaw([NativeTypeName("PFE_IMPORT_FUNC")] delegate* unmanaged<byte*, void*, uint*, uint> pfImportCallback, [NativeTypeName("PVOID")] void* pvCallbackContext, [NativeTypeName("PVOID")] void* pvContext);

        [DllImport("advapi32", ExactSpelling = true)]
        public static extern void CloseEncryptedFileRaw([NativeTypeName("PVOID")] void* pvContext);

        [DllImport("kernel32", ExactSpelling = true)]
        public static extern int lstrcmpA([NativeTypeName("LPCSTR")] sbyte* lpString1, [NativeTypeName("LPCSTR")] sbyte* lpString2);

        [DllImport("kernel32", ExactSpelling = true)]
        public static extern int lstrcmpW([NativeTypeName("LPCWSTR")] ushort* lpString1, [NativeTypeName("LPCWSTR")] ushort* lpString2);

        [DllImport("kernel32", ExactSpelling = true)]
        public static extern int lstrcmpiA([NativeTypeName("LPCSTR")] sbyte* lpString1, [NativeTypeName("LPCSTR")] sbyte* lpString2);

        [DllImport("kernel32", ExactSpelling = true)]
        public static extern int lstrcmpiW([NativeTypeName("LPCWSTR")] ushort* lpString1, [NativeTypeName("LPCWSTR")] ushort* lpString2);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("LPSTR")]
        public static extern sbyte* lstrcpynA([NativeTypeName("LPSTR")] sbyte* lpString1, [NativeTypeName("LPCSTR")] sbyte* lpString2, int iMaxLength);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("LPWSTR")]
        public static extern ushort* lstrcpynW([NativeTypeName("LPWSTR")] ushort* lpString1, [NativeTypeName("LPCWSTR")] ushort* lpString2, int iMaxLength);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("LPSTR")]
        public static extern sbyte* lstrcpyA([NativeTypeName("LPSTR")] sbyte* lpString1, [NativeTypeName("LPCSTR")] sbyte* lpString2);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("LPWSTR")]
        public static extern ushort* lstrcpyW([NativeTypeName("LPWSTR")] ushort* lpString1, [NativeTypeName("LPCWSTR")] ushort* lpString2);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("LPSTR")]
        public static extern sbyte* lstrcatA([NativeTypeName("LPSTR")] sbyte* lpString1, [NativeTypeName("LPCSTR")] sbyte* lpString2);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("LPWSTR")]
        public static extern ushort* lstrcatW([NativeTypeName("LPWSTR")] ushort* lpString1, [NativeTypeName("LPCWSTR")] ushort* lpString2);

        [DllImport("kernel32", ExactSpelling = true)]
        public static extern int lstrlenA([NativeTypeName("LPCSTR")] sbyte* lpString);

        [DllImport("kernel32", ExactSpelling = true)]
        public static extern int lstrlenW([NativeTypeName("LPCWSTR")] ushort* lpString);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("HFILE")]
        public static extern int OpenFile([NativeTypeName("LPCSTR")] sbyte* lpFileName, [NativeTypeName("LPOFSTRUCT")] OFSTRUCT* lpReOpenBuff, [NativeTypeName("UINT")] uint uStyle);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("HFILE")]
        public static extern int _lopen([NativeTypeName("LPCSTR")] sbyte* lpPathName, int iReadWrite);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("HFILE")]
        public static extern int _lcreat([NativeTypeName("LPCSTR")] sbyte* lpPathName, int iAttribute);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint _lread([NativeTypeName("HFILE")] int hFile, [NativeTypeName("LPVOID")] void* lpBuffer, [NativeTypeName("UINT")] uint uBytes);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint _lwrite([NativeTypeName("HFILE")] int hFile, [NativeTypeName("LPCCH")] sbyte* lpBuffer, [NativeTypeName("UINT")] uint uBytes);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("HFILE")]
        public static extern int _lclose([NativeTypeName("HFILE")] int hFile);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("LONG")]
        public static extern int _llseek([NativeTypeName("HFILE")] int hFile, [NativeTypeName("LONG")] int lOffset, int iOrigin);

        [DllImport("advapi32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int IsTextUnicode([NativeTypeName("const void *")] void* lpv, int iSize, [NativeTypeName("LPINT")] int* lpiResult);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int BackupRead([NativeTypeName("HANDLE")] IntPtr hFile, [NativeTypeName("LPBYTE")] byte* lpBuffer, [NativeTypeName("DWORD")] uint nNumberOfBytesToRead, [NativeTypeName("LPDWORD")] uint* lpNumberOfBytesRead, [NativeTypeName("BOOL")] int bAbort, [NativeTypeName("BOOL")] int bProcessSecurity, [NativeTypeName("LPVOID *")] void** lpContext);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int BackupSeek([NativeTypeName("HANDLE")] IntPtr hFile, [NativeTypeName("DWORD")] uint dwLowBytesToSeek, [NativeTypeName("DWORD")] uint dwHighBytesToSeek, [NativeTypeName("LPDWORD")] uint* lpdwLowByteSeeked, [NativeTypeName("LPDWORD")] uint* lpdwHighByteSeeked, [NativeTypeName("LPVOID *")] void** lpContext);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int BackupWrite([NativeTypeName("HANDLE")] IntPtr hFile, [NativeTypeName("LPBYTE")] byte* lpBuffer, [NativeTypeName("DWORD")] uint nNumberOfBytesToWrite, [NativeTypeName("LPDWORD")] uint* lpNumberOfBytesWritten, [NativeTypeName("BOOL")] int bAbort, [NativeTypeName("BOOL")] int bProcessSecurity, [NativeTypeName("LPVOID *")] void** lpContext);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern IntPtr OpenMutexA([NativeTypeName("DWORD")] uint dwDesiredAccess, [NativeTypeName("BOOL")] int bInheritHandle, [NativeTypeName("LPCSTR")] sbyte* lpName);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern IntPtr CreateSemaphoreA([NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpSemaphoreAttributes, [NativeTypeName("LONG")] int lInitialCount, [NativeTypeName("LONG")] int lMaximumCount, [NativeTypeName("LPCSTR")] sbyte* lpName);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern IntPtr OpenSemaphoreA([NativeTypeName("DWORD")] uint dwDesiredAccess, [NativeTypeName("BOOL")] int bInheritHandle, [NativeTypeName("LPCSTR")] sbyte* lpName);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern IntPtr CreateWaitableTimerA([NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpTimerAttributes, [NativeTypeName("BOOL")] int bManualReset, [NativeTypeName("LPCSTR")] sbyte* lpTimerName);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern IntPtr OpenWaitableTimerA([NativeTypeName("DWORD")] uint dwDesiredAccess, [NativeTypeName("BOOL")] int bInheritHandle, [NativeTypeName("LPCSTR")] sbyte* lpTimerName);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern IntPtr CreateSemaphoreExA([NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpSemaphoreAttributes, [NativeTypeName("LONG")] int lInitialCount, [NativeTypeName("LONG")] int lMaximumCount, [NativeTypeName("LPCSTR")] sbyte* lpName, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("DWORD")] uint dwDesiredAccess);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern IntPtr CreateWaitableTimerExA([NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpTimerAttributes, [NativeTypeName("LPCSTR")] sbyte* lpTimerName, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("DWORD")] uint dwDesiredAccess);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern IntPtr CreateFileMappingA([NativeTypeName("HANDLE")] IntPtr hFile, [NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpFileMappingAttributes, [NativeTypeName("DWORD")] uint flProtect, [NativeTypeName("DWORD")] uint dwMaximumSizeHigh, [NativeTypeName("DWORD")] uint dwMaximumSizeLow, [NativeTypeName("LPCSTR")] sbyte* lpName);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern IntPtr CreateFileMappingNumaA([NativeTypeName("HANDLE")] IntPtr hFile, [NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpFileMappingAttributes, [NativeTypeName("DWORD")] uint flProtect, [NativeTypeName("DWORD")] uint dwMaximumSizeHigh, [NativeTypeName("DWORD")] uint dwMaximumSizeLow, [NativeTypeName("LPCSTR")] sbyte* lpName, [NativeTypeName("DWORD")] uint nndPreferred);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern IntPtr OpenFileMappingA([NativeTypeName("DWORD")] uint dwDesiredAccess, [NativeTypeName("BOOL")] int bInheritHandle, [NativeTypeName("LPCSTR")] sbyte* lpName);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetLogicalDriveStringsA([NativeTypeName("DWORD")] uint nBufferLength, [NativeTypeName("LPSTR")] sbyte* lpBuffer);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("HMODULE")]
        public static extern IntPtr LoadPackagedLibrary([NativeTypeName("LPCWSTR")] ushort* lpwLibFileName, [NativeTypeName("DWORD")] uint Reserved);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int QueryFullProcessImageNameA([NativeTypeName("HANDLE")] IntPtr hProcess, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LPSTR")] sbyte* lpExeName, [NativeTypeName("PDWORD")] uint* lpdwSize);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int QueryFullProcessImageNameW([NativeTypeName("HANDLE")] IntPtr hProcess, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LPWSTR")] ushort* lpExeName, [NativeTypeName("PDWORD")] uint* lpdwSize);

        [DllImport("kernel32", ExactSpelling = true)]
        public static extern void GetStartupInfoA([NativeTypeName("LPSTARTUPINFOA")] STARTUPINFOA* lpStartupInfo);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetFirmwareEnvironmentVariableA([NativeTypeName("LPCSTR")] sbyte* lpName, [NativeTypeName("LPCSTR")] sbyte* lpGuid, [NativeTypeName("PVOID")] void* pBuffer, [NativeTypeName("DWORD")] uint nSize);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetFirmwareEnvironmentVariableW([NativeTypeName("LPCWSTR")] ushort* lpName, [NativeTypeName("LPCWSTR")] ushort* lpGuid, [NativeTypeName("PVOID")] void* pBuffer, [NativeTypeName("DWORD")] uint nSize);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetFirmwareEnvironmentVariableExA([NativeTypeName("LPCSTR")] sbyte* lpName, [NativeTypeName("LPCSTR")] sbyte* lpGuid, [NativeTypeName("PVOID")] void* pBuffer, [NativeTypeName("DWORD")] uint nSize, [NativeTypeName("PDWORD")] uint* pdwAttribubutes);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetFirmwareEnvironmentVariableExW([NativeTypeName("LPCWSTR")] ushort* lpName, [NativeTypeName("LPCWSTR")] ushort* lpGuid, [NativeTypeName("PVOID")] void* pBuffer, [NativeTypeName("DWORD")] uint nSize, [NativeTypeName("PDWORD")] uint* pdwAttribubutes);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetFirmwareEnvironmentVariableA([NativeTypeName("LPCSTR")] sbyte* lpName, [NativeTypeName("LPCSTR")] sbyte* lpGuid, [NativeTypeName("PVOID")] void* pValue, [NativeTypeName("DWORD")] uint nSize);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetFirmwareEnvironmentVariableW([NativeTypeName("LPCWSTR")] ushort* lpName, [NativeTypeName("LPCWSTR")] ushort* lpGuid, [NativeTypeName("PVOID")] void* pValue, [NativeTypeName("DWORD")] uint nSize);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetFirmwareEnvironmentVariableExA([NativeTypeName("LPCSTR")] sbyte* lpName, [NativeTypeName("LPCSTR")] sbyte* lpGuid, [NativeTypeName("PVOID")] void* pValue, [NativeTypeName("DWORD")] uint nSize, [NativeTypeName("DWORD")] uint dwAttributes);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetFirmwareEnvironmentVariableExW([NativeTypeName("LPCWSTR")] ushort* lpName, [NativeTypeName("LPCWSTR")] ushort* lpGuid, [NativeTypeName("PVOID")] void* pValue, [NativeTypeName("DWORD")] uint nSize, [NativeTypeName("DWORD")] uint dwAttributes);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetFirmwareType([NativeTypeName("PFIRMWARE_TYPE")] FIRMWARE_TYPE* FirmwareType);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int IsNativeVhdBoot([NativeTypeName("PBOOL")] int* NativeVhdBoot);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("HRSRC")]
        public static extern IntPtr FindResourceA([NativeTypeName("HMODULE")] IntPtr hModule, [NativeTypeName("LPCSTR")] sbyte* lpName, [NativeTypeName("LPCSTR")] sbyte* lpType);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("HRSRC")]
        public static extern IntPtr FindResourceExA([NativeTypeName("HMODULE")] IntPtr hModule, [NativeTypeName("LPCSTR")] sbyte* lpType, [NativeTypeName("LPCSTR")] sbyte* lpName, [NativeTypeName("WORD")] ushort wLanguage);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int EnumResourceTypesA([NativeTypeName("HMODULE")] IntPtr hModule, [NativeTypeName("ENUMRESTYPEPROCA")] delegate* unmanaged<IntPtr, sbyte*, nint, int> lpEnumFunc, [NativeTypeName("LONG_PTR")] nint lParam);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int EnumResourceTypesW([NativeTypeName("HMODULE")] IntPtr hModule, [NativeTypeName("ENUMRESTYPEPROCW")] delegate* unmanaged<IntPtr, ushort*, nint, int> lpEnumFunc, [NativeTypeName("LONG_PTR")] nint lParam);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int EnumResourceLanguagesA([NativeTypeName("HMODULE")] IntPtr hModule, [NativeTypeName("LPCSTR")] sbyte* lpType, [NativeTypeName("LPCSTR")] sbyte* lpName, [NativeTypeName("ENUMRESLANGPROCA")] delegate* unmanaged<IntPtr, sbyte*, sbyte*, ushort, nint, int> lpEnumFunc, [NativeTypeName("LONG_PTR")] nint lParam);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int EnumResourceLanguagesW([NativeTypeName("HMODULE")] IntPtr hModule, [NativeTypeName("LPCWSTR")] ushort* lpType, [NativeTypeName("LPCWSTR")] ushort* lpName, [NativeTypeName("ENUMRESLANGPROCW")] delegate* unmanaged<IntPtr, ushort*, ushort*, ushort, nint, int> lpEnumFunc, [NativeTypeName("LONG_PTR")] nint lParam);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern IntPtr BeginUpdateResourceA([NativeTypeName("LPCSTR")] sbyte* pFileName, [NativeTypeName("BOOL")] int bDeleteExistingResources);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern IntPtr BeginUpdateResourceW([NativeTypeName("LPCWSTR")] ushort* pFileName, [NativeTypeName("BOOL")] int bDeleteExistingResources);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int UpdateResourceA([NativeTypeName("HANDLE")] IntPtr hUpdate, [NativeTypeName("LPCSTR")] sbyte* lpType, [NativeTypeName("LPCSTR")] sbyte* lpName, [NativeTypeName("WORD")] ushort wLanguage, [NativeTypeName("LPVOID")] void* lpData, [NativeTypeName("DWORD")] uint cb);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int UpdateResourceW([NativeTypeName("HANDLE")] IntPtr hUpdate, [NativeTypeName("LPCWSTR")] ushort* lpType, [NativeTypeName("LPCWSTR")] ushort* lpName, [NativeTypeName("WORD")] ushort wLanguage, [NativeTypeName("LPVOID")] void* lpData, [NativeTypeName("DWORD")] uint cb);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int EndUpdateResourceA([NativeTypeName("HANDLE")] IntPtr hUpdate, [NativeTypeName("BOOL")] int fDiscard);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int EndUpdateResourceW([NativeTypeName("HANDLE")] IntPtr hUpdate, [NativeTypeName("BOOL")] int fDiscard);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("ATOM")]
        public static extern ushort GlobalAddAtomA([NativeTypeName("LPCSTR")] sbyte* lpString);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("ATOM")]
        public static extern ushort GlobalAddAtomW([NativeTypeName("LPCWSTR")] ushort* lpString);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("ATOM")]
        public static extern ushort GlobalAddAtomExA([NativeTypeName("LPCSTR")] sbyte* lpString, [NativeTypeName("DWORD")] uint Flags);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("ATOM")]
        public static extern ushort GlobalAddAtomExW([NativeTypeName("LPCWSTR")] ushort* lpString, [NativeTypeName("DWORD")] uint Flags);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("ATOM")]
        public static extern ushort GlobalFindAtomA([NativeTypeName("LPCSTR")] sbyte* lpString);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("ATOM")]
        public static extern ushort GlobalFindAtomW([NativeTypeName("LPCWSTR")] ushort* lpString);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint GlobalGetAtomNameA([NativeTypeName("ATOM")] ushort nAtom, [NativeTypeName("LPSTR")] sbyte* lpBuffer, int nSize);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint GlobalGetAtomNameW([NativeTypeName("ATOM")] ushort nAtom, [NativeTypeName("LPWSTR")] ushort* lpBuffer, int nSize);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("ATOM")]
        public static extern ushort AddAtomA([NativeTypeName("LPCSTR")] sbyte* lpString);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("ATOM")]
        public static extern ushort AddAtomW([NativeTypeName("LPCWSTR")] ushort* lpString);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("ATOM")]
        public static extern ushort FindAtomA([NativeTypeName("LPCSTR")] sbyte* lpString);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("ATOM")]
        public static extern ushort FindAtomW([NativeTypeName("LPCWSTR")] ushort* lpString);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint GetAtomNameA([NativeTypeName("ATOM")] ushort nAtom, [NativeTypeName("LPSTR")] sbyte* lpBuffer, int nSize);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint GetAtomNameW([NativeTypeName("ATOM")] ushort nAtom, [NativeTypeName("LPWSTR")] ushort* lpBuffer, int nSize);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint GetProfileIntA([NativeTypeName("LPCSTR")] sbyte* lpAppName, [NativeTypeName("LPCSTR")] sbyte* lpKeyName, [NativeTypeName("INT")] int nDefault);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint GetProfileIntW([NativeTypeName("LPCWSTR")] ushort* lpAppName, [NativeTypeName("LPCWSTR")] ushort* lpKeyName, [NativeTypeName("INT")] int nDefault);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetProfileStringA([NativeTypeName("LPCSTR")] sbyte* lpAppName, [NativeTypeName("LPCSTR")] sbyte* lpKeyName, [NativeTypeName("LPCSTR")] sbyte* lpDefault, [NativeTypeName("LPSTR")] sbyte* lpReturnedString, [NativeTypeName("DWORD")] uint nSize);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetProfileStringW([NativeTypeName("LPCWSTR")] ushort* lpAppName, [NativeTypeName("LPCWSTR")] ushort* lpKeyName, [NativeTypeName("LPCWSTR")] ushort* lpDefault, [NativeTypeName("LPWSTR")] ushort* lpReturnedString, [NativeTypeName("DWORD")] uint nSize);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int WriteProfileStringA([NativeTypeName("LPCSTR")] sbyte* lpAppName, [NativeTypeName("LPCSTR")] sbyte* lpKeyName, [NativeTypeName("LPCSTR")] sbyte* lpString);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int WriteProfileStringW([NativeTypeName("LPCWSTR")] ushort* lpAppName, [NativeTypeName("LPCWSTR")] ushort* lpKeyName, [NativeTypeName("LPCWSTR")] ushort* lpString);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetProfileSectionA([NativeTypeName("LPCSTR")] sbyte* lpAppName, [NativeTypeName("LPSTR")] sbyte* lpReturnedString, [NativeTypeName("DWORD")] uint nSize);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetProfileSectionW([NativeTypeName("LPCWSTR")] ushort* lpAppName, [NativeTypeName("LPWSTR")] ushort* lpReturnedString, [NativeTypeName("DWORD")] uint nSize);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int WriteProfileSectionA([NativeTypeName("LPCSTR")] sbyte* lpAppName, [NativeTypeName("LPCSTR")] sbyte* lpString);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int WriteProfileSectionW([NativeTypeName("LPCWSTR")] ushort* lpAppName, [NativeTypeName("LPCWSTR")] ushort* lpString);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint GetPrivateProfileIntA([NativeTypeName("LPCSTR")] sbyte* lpAppName, [NativeTypeName("LPCSTR")] sbyte* lpKeyName, [NativeTypeName("INT")] int nDefault, [NativeTypeName("LPCSTR")] sbyte* lpFileName);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint GetPrivateProfileIntW([NativeTypeName("LPCWSTR")] ushort* lpAppName, [NativeTypeName("LPCWSTR")] ushort* lpKeyName, [NativeTypeName("INT")] int nDefault, [NativeTypeName("LPCWSTR")] ushort* lpFileName);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetPrivateProfileStringA([NativeTypeName("LPCSTR")] sbyte* lpAppName, [NativeTypeName("LPCSTR")] sbyte* lpKeyName, [NativeTypeName("LPCSTR")] sbyte* lpDefault, [NativeTypeName("LPSTR")] sbyte* lpReturnedString, [NativeTypeName("DWORD")] uint nSize, [NativeTypeName("LPCSTR")] sbyte* lpFileName);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetPrivateProfileStringW([NativeTypeName("LPCWSTR")] ushort* lpAppName, [NativeTypeName("LPCWSTR")] ushort* lpKeyName, [NativeTypeName("LPCWSTR")] ushort* lpDefault, [NativeTypeName("LPWSTR")] ushort* lpReturnedString, [NativeTypeName("DWORD")] uint nSize, [NativeTypeName("LPCWSTR")] ushort* lpFileName);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int WritePrivateProfileStringA([NativeTypeName("LPCSTR")] sbyte* lpAppName, [NativeTypeName("LPCSTR")] sbyte* lpKeyName, [NativeTypeName("LPCSTR")] sbyte* lpString, [NativeTypeName("LPCSTR")] sbyte* lpFileName);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int WritePrivateProfileStringW([NativeTypeName("LPCWSTR")] ushort* lpAppName, [NativeTypeName("LPCWSTR")] ushort* lpKeyName, [NativeTypeName("LPCWSTR")] ushort* lpString, [NativeTypeName("LPCWSTR")] ushort* lpFileName);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetPrivateProfileSectionA([NativeTypeName("LPCSTR")] sbyte* lpAppName, [NativeTypeName("LPSTR")] sbyte* lpReturnedString, [NativeTypeName("DWORD")] uint nSize, [NativeTypeName("LPCSTR")] sbyte* lpFileName);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetPrivateProfileSectionW([NativeTypeName("LPCWSTR")] ushort* lpAppName, [NativeTypeName("LPWSTR")] ushort* lpReturnedString, [NativeTypeName("DWORD")] uint nSize, [NativeTypeName("LPCWSTR")] ushort* lpFileName);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int WritePrivateProfileSectionA([NativeTypeName("LPCSTR")] sbyte* lpAppName, [NativeTypeName("LPCSTR")] sbyte* lpString, [NativeTypeName("LPCSTR")] sbyte* lpFileName);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int WritePrivateProfileSectionW([NativeTypeName("LPCWSTR")] ushort* lpAppName, [NativeTypeName("LPCWSTR")] ushort* lpString, [NativeTypeName("LPCWSTR")] ushort* lpFileName);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetPrivateProfileSectionNamesA([NativeTypeName("LPSTR")] sbyte* lpszReturnBuffer, [NativeTypeName("DWORD")] uint nSize, [NativeTypeName("LPCSTR")] sbyte* lpFileName);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetPrivateProfileSectionNamesW([NativeTypeName("LPWSTR")] ushort* lpszReturnBuffer, [NativeTypeName("DWORD")] uint nSize, [NativeTypeName("LPCWSTR")] ushort* lpFileName);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetPrivateProfileStructA([NativeTypeName("LPCSTR")] sbyte* lpszSection, [NativeTypeName("LPCSTR")] sbyte* lpszKey, [NativeTypeName("LPVOID")] void* lpStruct, [NativeTypeName("UINT")] uint uSizeStruct, [NativeTypeName("LPCSTR")] sbyte* szFile);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetPrivateProfileStructW([NativeTypeName("LPCWSTR")] ushort* lpszSection, [NativeTypeName("LPCWSTR")] ushort* lpszKey, [NativeTypeName("LPVOID")] void* lpStruct, [NativeTypeName("UINT")] uint uSizeStruct, [NativeTypeName("LPCWSTR")] ushort* szFile);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int WritePrivateProfileStructA([NativeTypeName("LPCSTR")] sbyte* lpszSection, [NativeTypeName("LPCSTR")] sbyte* lpszKey, [NativeTypeName("LPVOID")] void* lpStruct, [NativeTypeName("UINT")] uint uSizeStruct, [NativeTypeName("LPCSTR")] sbyte* szFile);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int WritePrivateProfileStructW([NativeTypeName("LPCWSTR")] ushort* lpszSection, [NativeTypeName("LPCWSTR")] ushort* lpszKey, [NativeTypeName("LPVOID")] void* lpStruct, [NativeTypeName("UINT")] uint uSizeStruct, [NativeTypeName("LPCWSTR")] ushort* szFile);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetDllDirectoryA([NativeTypeName("LPCSTR")] sbyte* lpPathName);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetDllDirectoryW([NativeTypeName("LPCWSTR")] ushort* lpPathName);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetDllDirectoryA([NativeTypeName("DWORD")] uint nBufferLength, [NativeTypeName("LPSTR")] sbyte* lpBuffer);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetDllDirectoryW([NativeTypeName("DWORD")] uint nBufferLength, [NativeTypeName("LPWSTR")] ushort* lpBuffer);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetSearchPathMode([NativeTypeName("DWORD")] uint Flags);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CreateDirectoryExA([NativeTypeName("LPCSTR")] sbyte* lpTemplateDirectory, [NativeTypeName("LPCSTR")] sbyte* lpNewDirectory, [NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpSecurityAttributes);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CreateDirectoryExW([NativeTypeName("LPCWSTR")] ushort* lpTemplateDirectory, [NativeTypeName("LPCWSTR")] ushort* lpNewDirectory, [NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpSecurityAttributes);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CreateDirectoryTransactedA([NativeTypeName("LPCSTR")] sbyte* lpTemplateDirectory, [NativeTypeName("LPCSTR")] sbyte* lpNewDirectory, [NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpSecurityAttributes, [NativeTypeName("HANDLE")] IntPtr hTransaction);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CreateDirectoryTransactedW([NativeTypeName("LPCWSTR")] ushort* lpTemplateDirectory, [NativeTypeName("LPCWSTR")] ushort* lpNewDirectory, [NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpSecurityAttributes, [NativeTypeName("HANDLE")] IntPtr hTransaction);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int RemoveDirectoryTransactedA([NativeTypeName("LPCSTR")] sbyte* lpPathName, [NativeTypeName("HANDLE")] IntPtr hTransaction);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int RemoveDirectoryTransactedW([NativeTypeName("LPCWSTR")] ushort* lpPathName, [NativeTypeName("HANDLE")] IntPtr hTransaction);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetFullPathNameTransactedA([NativeTypeName("LPCSTR")] sbyte* lpFileName, [NativeTypeName("DWORD")] uint nBufferLength, [NativeTypeName("LPSTR")] sbyte* lpBuffer, [NativeTypeName("LPSTR *")] sbyte** lpFilePart, [NativeTypeName("HANDLE")] IntPtr hTransaction);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetFullPathNameTransactedW([NativeTypeName("LPCWSTR")] ushort* lpFileName, [NativeTypeName("DWORD")] uint nBufferLength, [NativeTypeName("LPWSTR")] ushort* lpBuffer, [NativeTypeName("LPWSTR *")] ushort** lpFilePart, [NativeTypeName("HANDLE")] IntPtr hTransaction);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int DefineDosDeviceA([NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LPCSTR")] sbyte* lpDeviceName, [NativeTypeName("LPCSTR")] sbyte* lpTargetPath);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint QueryDosDeviceA([NativeTypeName("LPCSTR")] sbyte* lpDeviceName, [NativeTypeName("LPSTR")] sbyte* lpTargetPath, [NativeTypeName("DWORD")] uint ucchMax);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern IntPtr CreateFileTransactedA([NativeTypeName("LPCSTR")] sbyte* lpFileName, [NativeTypeName("DWORD")] uint dwDesiredAccess, [NativeTypeName("DWORD")] uint dwShareMode, [NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpSecurityAttributes, [NativeTypeName("DWORD")] uint dwCreationDisposition, [NativeTypeName("DWORD")] uint dwFlagsAndAttributes, [NativeTypeName("HANDLE")] IntPtr hTemplateFile, [NativeTypeName("HANDLE")] IntPtr hTransaction, [NativeTypeName("PUSHORT")] ushort* pusMiniVersion, [NativeTypeName("PVOID")] void* lpExtendedParameter);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern IntPtr CreateFileTransactedW([NativeTypeName("LPCWSTR")] ushort* lpFileName, [NativeTypeName("DWORD")] uint dwDesiredAccess, [NativeTypeName("DWORD")] uint dwShareMode, [NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpSecurityAttributes, [NativeTypeName("DWORD")] uint dwCreationDisposition, [NativeTypeName("DWORD")] uint dwFlagsAndAttributes, [NativeTypeName("HANDLE")] IntPtr hTemplateFile, [NativeTypeName("HANDLE")] IntPtr hTransaction, [NativeTypeName("PUSHORT")] ushort* pusMiniVersion, [NativeTypeName("PVOID")] void* lpExtendedParameter);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern IntPtr ReOpenFile([NativeTypeName("HANDLE")] IntPtr hOriginalFile, [NativeTypeName("DWORD")] uint dwDesiredAccess, [NativeTypeName("DWORD")] uint dwShareMode, [NativeTypeName("DWORD")] uint dwFlagsAndAttributes);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetFileAttributesTransactedA([NativeTypeName("LPCSTR")] sbyte* lpFileName, [NativeTypeName("DWORD")] uint dwFileAttributes, [NativeTypeName("HANDLE")] IntPtr hTransaction);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetFileAttributesTransactedW([NativeTypeName("LPCWSTR")] ushort* lpFileName, [NativeTypeName("DWORD")] uint dwFileAttributes, [NativeTypeName("HANDLE")] IntPtr hTransaction);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetFileAttributesTransactedA([NativeTypeName("LPCSTR")] sbyte* lpFileName, GET_FILEEX_INFO_LEVELS fInfoLevelId, [NativeTypeName("LPVOID")] void* lpFileInformation, [NativeTypeName("HANDLE")] IntPtr hTransaction);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetFileAttributesTransactedW([NativeTypeName("LPCWSTR")] ushort* lpFileName, GET_FILEEX_INFO_LEVELS fInfoLevelId, [NativeTypeName("LPVOID")] void* lpFileInformation, [NativeTypeName("HANDLE")] IntPtr hTransaction);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetCompressedFileSizeTransactedA([NativeTypeName("LPCSTR")] sbyte* lpFileName, [NativeTypeName("LPDWORD")] uint* lpFileSizeHigh, [NativeTypeName("HANDLE")] IntPtr hTransaction);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetCompressedFileSizeTransactedW([NativeTypeName("LPCWSTR")] ushort* lpFileName, [NativeTypeName("LPDWORD")] uint* lpFileSizeHigh, [NativeTypeName("HANDLE")] IntPtr hTransaction);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int DeleteFileTransactedA([NativeTypeName("LPCSTR")] sbyte* lpFileName, [NativeTypeName("HANDLE")] IntPtr hTransaction);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int DeleteFileTransactedW([NativeTypeName("LPCWSTR")] ushort* lpFileName, [NativeTypeName("HANDLE")] IntPtr hTransaction);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CheckNameLegalDOS8Dot3A([NativeTypeName("LPCSTR")] sbyte* lpName, [NativeTypeName("LPSTR")] sbyte* lpOemName, [NativeTypeName("DWORD")] uint OemNameSize, [NativeTypeName("PBOOL")] int* pbNameContainsSpaces, [NativeTypeName("PBOOL")] int* pbNameLegal);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CheckNameLegalDOS8Dot3W([NativeTypeName("LPCWSTR")] ushort* lpName, [NativeTypeName("LPSTR")] sbyte* lpOemName, [NativeTypeName("DWORD")] uint OemNameSize, [NativeTypeName("PBOOL")] int* pbNameContainsSpaces, [NativeTypeName("PBOOL")] int* pbNameLegal);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern IntPtr FindFirstFileTransactedA([NativeTypeName("LPCSTR")] sbyte* lpFileName, FINDEX_INFO_LEVELS fInfoLevelId, [NativeTypeName("LPVOID")] void* lpFindFileData, FINDEX_SEARCH_OPS fSearchOp, [NativeTypeName("LPVOID")] void* lpSearchFilter, [NativeTypeName("DWORD")] uint dwAdditionalFlags, [NativeTypeName("HANDLE")] IntPtr hTransaction);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern IntPtr FindFirstFileTransactedW([NativeTypeName("LPCWSTR")] ushort* lpFileName, FINDEX_INFO_LEVELS fInfoLevelId, [NativeTypeName("LPVOID")] void* lpFindFileData, FINDEX_SEARCH_OPS fSearchOp, [NativeTypeName("LPVOID")] void* lpSearchFilter, [NativeTypeName("DWORD")] uint dwAdditionalFlags, [NativeTypeName("HANDLE")] IntPtr hTransaction);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CopyFileA([NativeTypeName("LPCSTR")] sbyte* lpExistingFileName, [NativeTypeName("LPCSTR")] sbyte* lpNewFileName, [NativeTypeName("BOOL")] int bFailIfExists);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CopyFileW([NativeTypeName("LPCWSTR")] ushort* lpExistingFileName, [NativeTypeName("LPCWSTR")] ushort* lpNewFileName, [NativeTypeName("BOOL")] int bFailIfExists);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CopyFileExA([NativeTypeName("LPCSTR")] sbyte* lpExistingFileName, [NativeTypeName("LPCSTR")] sbyte* lpNewFileName, [NativeTypeName("LPPROGRESS_ROUTINE")] delegate* unmanaged<LARGE_INTEGER, LARGE_INTEGER, LARGE_INTEGER, LARGE_INTEGER, uint, uint, IntPtr, IntPtr, void*, uint> lpProgressRoutine, [NativeTypeName("LPVOID")] void* lpData, [NativeTypeName("LPBOOL")] int* pbCancel, [NativeTypeName("DWORD")] uint dwCopyFlags);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CopyFileExW([NativeTypeName("LPCWSTR")] ushort* lpExistingFileName, [NativeTypeName("LPCWSTR")] ushort* lpNewFileName, [NativeTypeName("LPPROGRESS_ROUTINE")] delegate* unmanaged<LARGE_INTEGER, LARGE_INTEGER, LARGE_INTEGER, LARGE_INTEGER, uint, uint, IntPtr, IntPtr, void*, uint> lpProgressRoutine, [NativeTypeName("LPVOID")] void* lpData, [NativeTypeName("LPBOOL")] int* pbCancel, [NativeTypeName("DWORD")] uint dwCopyFlags);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CopyFileTransactedA([NativeTypeName("LPCSTR")] sbyte* lpExistingFileName, [NativeTypeName("LPCSTR")] sbyte* lpNewFileName, [NativeTypeName("LPPROGRESS_ROUTINE")] delegate* unmanaged<LARGE_INTEGER, LARGE_INTEGER, LARGE_INTEGER, LARGE_INTEGER, uint, uint, IntPtr, IntPtr, void*, uint> lpProgressRoutine, [NativeTypeName("LPVOID")] void* lpData, [NativeTypeName("LPBOOL")] int* pbCancel, [NativeTypeName("DWORD")] uint dwCopyFlags, [NativeTypeName("HANDLE")] IntPtr hTransaction);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CopyFileTransactedW([NativeTypeName("LPCWSTR")] ushort* lpExistingFileName, [NativeTypeName("LPCWSTR")] ushort* lpNewFileName, [NativeTypeName("LPPROGRESS_ROUTINE")] delegate* unmanaged<LARGE_INTEGER, LARGE_INTEGER, LARGE_INTEGER, LARGE_INTEGER, uint, uint, IntPtr, IntPtr, void*, uint> lpProgressRoutine, [NativeTypeName("LPVOID")] void* lpData, [NativeTypeName("LPBOOL")] int* pbCancel, [NativeTypeName("DWORD")] uint dwCopyFlags, [NativeTypeName("HANDLE")] IntPtr hTransaction);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CopyFile2([NativeTypeName("PCWSTR")] ushort* pwszExistingFileName, [NativeTypeName("PCWSTR")] ushort* pwszNewFileName, COPYFILE2_EXTENDED_PARAMETERS* pExtendedParameters);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int MoveFileA([NativeTypeName("LPCSTR")] sbyte* lpExistingFileName, [NativeTypeName("LPCSTR")] sbyte* lpNewFileName);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int MoveFileW([NativeTypeName("LPCWSTR")] ushort* lpExistingFileName, [NativeTypeName("LPCWSTR")] ushort* lpNewFileName);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int MoveFileExA([NativeTypeName("LPCSTR")] sbyte* lpExistingFileName, [NativeTypeName("LPCSTR")] sbyte* lpNewFileName, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int MoveFileExW([NativeTypeName("LPCWSTR")] ushort* lpExistingFileName, [NativeTypeName("LPCWSTR")] ushort* lpNewFileName, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int MoveFileWithProgressA([NativeTypeName("LPCSTR")] sbyte* lpExistingFileName, [NativeTypeName("LPCSTR")] sbyte* lpNewFileName, [NativeTypeName("LPPROGRESS_ROUTINE")] delegate* unmanaged<LARGE_INTEGER, LARGE_INTEGER, LARGE_INTEGER, LARGE_INTEGER, uint, uint, IntPtr, IntPtr, void*, uint> lpProgressRoutine, [NativeTypeName("LPVOID")] void* lpData, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int MoveFileWithProgressW([NativeTypeName("LPCWSTR")] ushort* lpExistingFileName, [NativeTypeName("LPCWSTR")] ushort* lpNewFileName, [NativeTypeName("LPPROGRESS_ROUTINE")] delegate* unmanaged<LARGE_INTEGER, LARGE_INTEGER, LARGE_INTEGER, LARGE_INTEGER, uint, uint, IntPtr, IntPtr, void*, uint> lpProgressRoutine, [NativeTypeName("LPVOID")] void* lpData, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int MoveFileTransactedA([NativeTypeName("LPCSTR")] sbyte* lpExistingFileName, [NativeTypeName("LPCSTR")] sbyte* lpNewFileName, [NativeTypeName("LPPROGRESS_ROUTINE")] delegate* unmanaged<LARGE_INTEGER, LARGE_INTEGER, LARGE_INTEGER, LARGE_INTEGER, uint, uint, IntPtr, IntPtr, void*, uint> lpProgressRoutine, [NativeTypeName("LPVOID")] void* lpData, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("HANDLE")] IntPtr hTransaction);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int MoveFileTransactedW([NativeTypeName("LPCWSTR")] ushort* lpExistingFileName, [NativeTypeName("LPCWSTR")] ushort* lpNewFileName, [NativeTypeName("LPPROGRESS_ROUTINE")] delegate* unmanaged<LARGE_INTEGER, LARGE_INTEGER, LARGE_INTEGER, LARGE_INTEGER, uint, uint, IntPtr, IntPtr, void*, uint> lpProgressRoutine, [NativeTypeName("LPVOID")] void* lpData, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("HANDLE")] IntPtr hTransaction);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ReplaceFileA([NativeTypeName("LPCSTR")] sbyte* lpReplacedFileName, [NativeTypeName("LPCSTR")] sbyte* lpReplacementFileName, [NativeTypeName("LPCSTR")] sbyte* lpBackupFileName, [NativeTypeName("DWORD")] uint dwReplaceFlags, [NativeTypeName("LPVOID")] void* lpExclude, [NativeTypeName("LPVOID")] void* lpReserved);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ReplaceFileW([NativeTypeName("LPCWSTR")] ushort* lpReplacedFileName, [NativeTypeName("LPCWSTR")] ushort* lpReplacementFileName, [NativeTypeName("LPCWSTR")] ushort* lpBackupFileName, [NativeTypeName("DWORD")] uint dwReplaceFlags, [NativeTypeName("LPVOID")] void* lpExclude, [NativeTypeName("LPVOID")] void* lpReserved);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CreateHardLinkA([NativeTypeName("LPCSTR")] sbyte* lpFileName, [NativeTypeName("LPCSTR")] sbyte* lpExistingFileName, [NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpSecurityAttributes);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CreateHardLinkW([NativeTypeName("LPCWSTR")] ushort* lpFileName, [NativeTypeName("LPCWSTR")] ushort* lpExistingFileName, [NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpSecurityAttributes);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CreateHardLinkTransactedA([NativeTypeName("LPCSTR")] sbyte* lpFileName, [NativeTypeName("LPCSTR")] sbyte* lpExistingFileName, [NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpSecurityAttributes, [NativeTypeName("HANDLE")] IntPtr hTransaction);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CreateHardLinkTransactedW([NativeTypeName("LPCWSTR")] ushort* lpFileName, [NativeTypeName("LPCWSTR")] ushort* lpExistingFileName, [NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpSecurityAttributes, [NativeTypeName("HANDLE")] IntPtr hTransaction);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern IntPtr FindFirstStreamTransactedW([NativeTypeName("LPCWSTR")] ushort* lpFileName, STREAM_INFO_LEVELS InfoLevel, [NativeTypeName("LPVOID")] void* lpFindStreamData, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("HANDLE")] IntPtr hTransaction);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern IntPtr FindFirstFileNameTransactedW([NativeTypeName("LPCWSTR")] ushort* lpFileName, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LPDWORD")] uint* StringLength, [NativeTypeName("PWSTR")] ushort* LinkName, [NativeTypeName("HANDLE")] IntPtr hTransaction);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern IntPtr CreateNamedPipeA([NativeTypeName("LPCSTR")] sbyte* lpName, [NativeTypeName("DWORD")] uint dwOpenMode, [NativeTypeName("DWORD")] uint dwPipeMode, [NativeTypeName("DWORD")] uint nMaxInstances, [NativeTypeName("DWORD")] uint nOutBufferSize, [NativeTypeName("DWORD")] uint nInBufferSize, [NativeTypeName("DWORD")] uint nDefaultTimeOut, [NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpSecurityAttributes);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetNamedPipeHandleStateA([NativeTypeName("HANDLE")] IntPtr hNamedPipe, [NativeTypeName("LPDWORD")] uint* lpState, [NativeTypeName("LPDWORD")] uint* lpCurInstances, [NativeTypeName("LPDWORD")] uint* lpMaxCollectionCount, [NativeTypeName("LPDWORD")] uint* lpCollectDataTimeout, [NativeTypeName("LPSTR")] sbyte* lpUserName, [NativeTypeName("DWORD")] uint nMaxUserNameSize);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CallNamedPipeA([NativeTypeName("LPCSTR")] sbyte* lpNamedPipeName, [NativeTypeName("LPVOID")] void* lpInBuffer, [NativeTypeName("DWORD")] uint nInBufferSize, [NativeTypeName("LPVOID")] void* lpOutBuffer, [NativeTypeName("DWORD")] uint nOutBufferSize, [NativeTypeName("LPDWORD")] uint* lpBytesRead, [NativeTypeName("DWORD")] uint nTimeOut);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int WaitNamedPipeA([NativeTypeName("LPCSTR")] sbyte* lpNamedPipeName, [NativeTypeName("DWORD")] uint nTimeOut);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetNamedPipeClientComputerNameA([NativeTypeName("HANDLE")] IntPtr Pipe, [NativeTypeName("LPSTR")] sbyte* ClientComputerName, [NativeTypeName("ULONG")] uint ClientComputerNameLength);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetNamedPipeClientProcessId([NativeTypeName("HANDLE")] IntPtr Pipe, [NativeTypeName("PULONG")] uint* ClientProcessId);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetNamedPipeClientSessionId([NativeTypeName("HANDLE")] IntPtr Pipe, [NativeTypeName("PULONG")] uint* ClientSessionId);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetNamedPipeServerProcessId([NativeTypeName("HANDLE")] IntPtr Pipe, [NativeTypeName("PULONG")] uint* ServerProcessId);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetNamedPipeServerSessionId([NativeTypeName("HANDLE")] IntPtr Pipe, [NativeTypeName("PULONG")] uint* ServerSessionId);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetVolumeLabelA([NativeTypeName("LPCSTR")] sbyte* lpRootPathName, [NativeTypeName("LPCSTR")] sbyte* lpVolumeName);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetVolumeLabelW([NativeTypeName("LPCWSTR")] ushort* lpRootPathName, [NativeTypeName("LPCWSTR")] ushort* lpVolumeName);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetFileBandwidthReservation([NativeTypeName("HANDLE")] IntPtr hFile, [NativeTypeName("DWORD")] uint nPeriodMilliseconds, [NativeTypeName("DWORD")] uint nBytesPerPeriod, [NativeTypeName("BOOL")] int bDiscardable, [NativeTypeName("LPDWORD")] uint* lpTransferSize, [NativeTypeName("LPDWORD")] uint* lpNumOutstandingRequests);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetFileBandwidthReservation([NativeTypeName("HANDLE")] IntPtr hFile, [NativeTypeName("LPDWORD")] uint* lpPeriodMilliseconds, [NativeTypeName("LPDWORD")] uint* lpBytesPerPeriod, [NativeTypeName("LPBOOL")] int* pDiscardable, [NativeTypeName("LPDWORD")] uint* lpTransferSize, [NativeTypeName("LPDWORD")] uint* lpNumOutstandingRequests);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ClearEventLogA([NativeTypeName("HANDLE")] IntPtr hEventLog, [NativeTypeName("LPCSTR")] sbyte* lpBackupFileName);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ClearEventLogW([NativeTypeName("HANDLE")] IntPtr hEventLog, [NativeTypeName("LPCWSTR")] ushort* lpBackupFileName);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int BackupEventLogA([NativeTypeName("HANDLE")] IntPtr hEventLog, [NativeTypeName("LPCSTR")] sbyte* lpBackupFileName);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int BackupEventLogW([NativeTypeName("HANDLE")] IntPtr hEventLog, [NativeTypeName("LPCWSTR")] ushort* lpBackupFileName);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CloseEventLog([NativeTypeName("HANDLE")] IntPtr hEventLog);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int DeregisterEventSource([NativeTypeName("HANDLE")] IntPtr hEventLog);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int NotifyChangeEventLog([NativeTypeName("HANDLE")] IntPtr hEventLog, [NativeTypeName("HANDLE")] IntPtr hEvent);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetNumberOfEventLogRecords([NativeTypeName("HANDLE")] IntPtr hEventLog, [NativeTypeName("PDWORD")] uint* NumberOfRecords);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetOldestEventLogRecord([NativeTypeName("HANDLE")] IntPtr hEventLog, [NativeTypeName("PDWORD")] uint* OldestRecord);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern IntPtr OpenEventLogA([NativeTypeName("LPCSTR")] sbyte* lpUNCServerName, [NativeTypeName("LPCSTR")] sbyte* lpSourceName);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern IntPtr OpenEventLogW([NativeTypeName("LPCWSTR")] ushort* lpUNCServerName, [NativeTypeName("LPCWSTR")] ushort* lpSourceName);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern IntPtr RegisterEventSourceA([NativeTypeName("LPCSTR")] sbyte* lpUNCServerName, [NativeTypeName("LPCSTR")] sbyte* lpSourceName);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern IntPtr RegisterEventSourceW([NativeTypeName("LPCWSTR")] ushort* lpUNCServerName, [NativeTypeName("LPCWSTR")] ushort* lpSourceName);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern IntPtr OpenBackupEventLogA([NativeTypeName("LPCSTR")] sbyte* lpUNCServerName, [NativeTypeName("LPCSTR")] sbyte* lpFileName);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern IntPtr OpenBackupEventLogW([NativeTypeName("LPCWSTR")] ushort* lpUNCServerName, [NativeTypeName("LPCWSTR")] ushort* lpFileName);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ReadEventLogA([NativeTypeName("HANDLE")] IntPtr hEventLog, [NativeTypeName("DWORD")] uint dwReadFlags, [NativeTypeName("DWORD")] uint dwRecordOffset, [NativeTypeName("LPVOID")] void* lpBuffer, [NativeTypeName("DWORD")] uint nNumberOfBytesToRead, [NativeTypeName("DWORD *")] uint* pnBytesRead, [NativeTypeName("DWORD *")] uint* pnMinNumberOfBytesNeeded);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ReadEventLogW([NativeTypeName("HANDLE")] IntPtr hEventLog, [NativeTypeName("DWORD")] uint dwReadFlags, [NativeTypeName("DWORD")] uint dwRecordOffset, [NativeTypeName("LPVOID")] void* lpBuffer, [NativeTypeName("DWORD")] uint nNumberOfBytesToRead, [NativeTypeName("DWORD *")] uint* pnBytesRead, [NativeTypeName("DWORD *")] uint* pnMinNumberOfBytesNeeded);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ReportEventA([NativeTypeName("HANDLE")] IntPtr hEventLog, [NativeTypeName("WORD")] ushort wType, [NativeTypeName("WORD")] ushort wCategory, [NativeTypeName("DWORD")] uint dwEventID, [NativeTypeName("PSID")] void* lpUserSid, [NativeTypeName("WORD")] ushort wNumStrings, [NativeTypeName("DWORD")] uint dwDataSize, [NativeTypeName("LPCSTR *")] sbyte** lpStrings, [NativeTypeName("LPVOID")] void* lpRawData);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ReportEventW([NativeTypeName("HANDLE")] IntPtr hEventLog, [NativeTypeName("WORD")] ushort wType, [NativeTypeName("WORD")] ushort wCategory, [NativeTypeName("DWORD")] uint dwEventID, [NativeTypeName("PSID")] void* lpUserSid, [NativeTypeName("WORD")] ushort wNumStrings, [NativeTypeName("DWORD")] uint dwDataSize, [NativeTypeName("LPCWSTR *")] ushort** lpStrings, [NativeTypeName("LPVOID")] void* lpRawData);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetEventLogInformation([NativeTypeName("HANDLE")] IntPtr hEventLog, [NativeTypeName("DWORD")] uint dwInfoLevel, [NativeTypeName("LPVOID")] void* lpBuffer, [NativeTypeName("DWORD")] uint cbBufSize, [NativeTypeName("LPDWORD")] uint* pcbBytesNeeded);

        [DllImport("advapi32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int OperationStart(OPERATION_START_PARAMETERS* OperationStartParams);

        [DllImport("advapi32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int OperationEnd(OPERATION_END_PARAMETERS* OperationEndParams);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int AccessCheckAndAuditAlarmA([NativeTypeName("LPCSTR")] sbyte* SubsystemName, [NativeTypeName("LPVOID")] void* HandleId, [NativeTypeName("LPSTR")] sbyte* ObjectTypeName, [NativeTypeName("LPSTR")] sbyte* ObjectName, [NativeTypeName("PSECURITY_DESCRIPTOR")] void* SecurityDescriptor, [NativeTypeName("DWORD")] uint DesiredAccess, [NativeTypeName("PGENERIC_MAPPING")] GENERIC_MAPPING* GenericMapping, [NativeTypeName("BOOL")] int ObjectCreation, [NativeTypeName("LPDWORD")] uint* GrantedAccess, [NativeTypeName("LPBOOL")] int* AccessStatus, [NativeTypeName("LPBOOL")] int* pfGenerateOnClose);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int AccessCheckByTypeAndAuditAlarmA([NativeTypeName("LPCSTR")] sbyte* SubsystemName, [NativeTypeName("LPVOID")] void* HandleId, [NativeTypeName("LPCSTR")] sbyte* ObjectTypeName, [NativeTypeName("LPCSTR")] sbyte* ObjectName, [NativeTypeName("PSECURITY_DESCRIPTOR")] void* SecurityDescriptor, [NativeTypeName("PSID")] void* PrincipalSelfSid, [NativeTypeName("DWORD")] uint DesiredAccess, AUDIT_EVENT_TYPE AuditType, [NativeTypeName("DWORD")] uint Flags, [NativeTypeName("POBJECT_TYPE_LIST")] OBJECT_TYPE_LIST* ObjectTypeList, [NativeTypeName("DWORD")] uint ObjectTypeListLength, [NativeTypeName("PGENERIC_MAPPING")] GENERIC_MAPPING* GenericMapping, [NativeTypeName("BOOL")] int ObjectCreation, [NativeTypeName("LPDWORD")] uint* GrantedAccess, [NativeTypeName("LPBOOL")] int* AccessStatus, [NativeTypeName("LPBOOL")] int* pfGenerateOnClose);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int AccessCheckByTypeResultListAndAuditAlarmA([NativeTypeName("LPCSTR")] sbyte* SubsystemName, [NativeTypeName("LPVOID")] void* HandleId, [NativeTypeName("LPCSTR")] sbyte* ObjectTypeName, [NativeTypeName("LPCSTR")] sbyte* ObjectName, [NativeTypeName("PSECURITY_DESCRIPTOR")] void* SecurityDescriptor, [NativeTypeName("PSID")] void* PrincipalSelfSid, [NativeTypeName("DWORD")] uint DesiredAccess, AUDIT_EVENT_TYPE AuditType, [NativeTypeName("DWORD")] uint Flags, [NativeTypeName("POBJECT_TYPE_LIST")] OBJECT_TYPE_LIST* ObjectTypeList, [NativeTypeName("DWORD")] uint ObjectTypeListLength, [NativeTypeName("PGENERIC_MAPPING")] GENERIC_MAPPING* GenericMapping, [NativeTypeName("BOOL")] int ObjectCreation, [NativeTypeName("LPDWORD")] uint* GrantedAccess, [NativeTypeName("LPDWORD")] uint* AccessStatusList, [NativeTypeName("LPBOOL")] int* pfGenerateOnClose);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int AccessCheckByTypeResultListAndAuditAlarmByHandleA([NativeTypeName("LPCSTR")] sbyte* SubsystemName, [NativeTypeName("LPVOID")] void* HandleId, [NativeTypeName("HANDLE")] IntPtr ClientToken, [NativeTypeName("LPCSTR")] sbyte* ObjectTypeName, [NativeTypeName("LPCSTR")] sbyte* ObjectName, [NativeTypeName("PSECURITY_DESCRIPTOR")] void* SecurityDescriptor, [NativeTypeName("PSID")] void* PrincipalSelfSid, [NativeTypeName("DWORD")] uint DesiredAccess, AUDIT_EVENT_TYPE AuditType, [NativeTypeName("DWORD")] uint Flags, [NativeTypeName("POBJECT_TYPE_LIST")] OBJECT_TYPE_LIST* ObjectTypeList, [NativeTypeName("DWORD")] uint ObjectTypeListLength, [NativeTypeName("PGENERIC_MAPPING")] GENERIC_MAPPING* GenericMapping, [NativeTypeName("BOOL")] int ObjectCreation, [NativeTypeName("LPDWORD")] uint* GrantedAccess, [NativeTypeName("LPDWORD")] uint* AccessStatusList, [NativeTypeName("LPBOOL")] int* pfGenerateOnClose);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ObjectOpenAuditAlarmA([NativeTypeName("LPCSTR")] sbyte* SubsystemName, [NativeTypeName("LPVOID")] void* HandleId, [NativeTypeName("LPSTR")] sbyte* ObjectTypeName, [NativeTypeName("LPSTR")] sbyte* ObjectName, [NativeTypeName("PSECURITY_DESCRIPTOR")] void* pSecurityDescriptor, [NativeTypeName("HANDLE")] IntPtr ClientToken, [NativeTypeName("DWORD")] uint DesiredAccess, [NativeTypeName("DWORD")] uint GrantedAccess, [NativeTypeName("PPRIVILEGE_SET")] PRIVILEGE_SET* Privileges, [NativeTypeName("BOOL")] int ObjectCreation, [NativeTypeName("BOOL")] int AccessGranted, [NativeTypeName("LPBOOL")] int* GenerateOnClose);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ObjectPrivilegeAuditAlarmA([NativeTypeName("LPCSTR")] sbyte* SubsystemName, [NativeTypeName("LPVOID")] void* HandleId, [NativeTypeName("HANDLE")] IntPtr ClientToken, [NativeTypeName("DWORD")] uint DesiredAccess, [NativeTypeName("PPRIVILEGE_SET")] PRIVILEGE_SET* Privileges, [NativeTypeName("BOOL")] int AccessGranted);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ObjectCloseAuditAlarmA([NativeTypeName("LPCSTR")] sbyte* SubsystemName, [NativeTypeName("LPVOID")] void* HandleId, [NativeTypeName("BOOL")] int GenerateOnClose);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ObjectDeleteAuditAlarmA([NativeTypeName("LPCSTR")] sbyte* SubsystemName, [NativeTypeName("LPVOID")] void* HandleId, [NativeTypeName("BOOL")] int GenerateOnClose);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int PrivilegedServiceAuditAlarmA([NativeTypeName("LPCSTR")] sbyte* SubsystemName, [NativeTypeName("LPCSTR")] sbyte* ServiceName, [NativeTypeName("HANDLE")] IntPtr ClientToken, [NativeTypeName("PPRIVILEGE_SET")] PRIVILEGE_SET* Privileges, [NativeTypeName("BOOL")] int AccessGranted);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int AddConditionalAce([NativeTypeName("PACL")] ACL* pAcl, [NativeTypeName("DWORD")] uint dwAceRevision, [NativeTypeName("DWORD")] uint AceFlags, [NativeTypeName("UCHAR")] byte AceType, [NativeTypeName("DWORD")] uint AccessMask, [NativeTypeName("PSID")] void* pSid, [NativeTypeName("PWCHAR")] ushort* ConditionStr, [NativeTypeName("DWORD *")] uint* ReturnLength);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetFileSecurityA([NativeTypeName("LPCSTR")] sbyte* lpFileName, [NativeTypeName("SECURITY_INFORMATION")] uint SecurityInformation, [NativeTypeName("PSECURITY_DESCRIPTOR")] void* pSecurityDescriptor);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetFileSecurityA([NativeTypeName("LPCSTR")] sbyte* lpFileName, [NativeTypeName("SECURITY_INFORMATION")] uint RequestedInformation, [NativeTypeName("PSECURITY_DESCRIPTOR")] void* pSecurityDescriptor, [NativeTypeName("DWORD")] uint nLength, [NativeTypeName("LPDWORD")] uint* lpnLengthNeeded);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ReadDirectoryChangesW([NativeTypeName("HANDLE")] IntPtr hDirectory, [NativeTypeName("LPVOID")] void* lpBuffer, [NativeTypeName("DWORD")] uint nBufferLength, [NativeTypeName("BOOL")] int bWatchSubtree, [NativeTypeName("DWORD")] uint dwNotifyFilter, [NativeTypeName("LPDWORD")] uint* lpBytesReturned, [NativeTypeName("LPOVERLAPPED")] OVERLAPPED* lpOverlapped, [NativeTypeName("LPOVERLAPPED_COMPLETION_ROUTINE")] delegate* unmanaged<uint, uint, OVERLAPPED*, void> lpCompletionRoutine);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ReadDirectoryChangesExW([NativeTypeName("HANDLE")] IntPtr hDirectory, [NativeTypeName("LPVOID")] void* lpBuffer, [NativeTypeName("DWORD")] uint nBufferLength, [NativeTypeName("BOOL")] int bWatchSubtree, [NativeTypeName("DWORD")] uint dwNotifyFilter, [NativeTypeName("LPDWORD")] uint* lpBytesReturned, [NativeTypeName("LPOVERLAPPED")] OVERLAPPED* lpOverlapped, [NativeTypeName("LPOVERLAPPED_COMPLETION_ROUTINE")] delegate* unmanaged<uint, uint, OVERLAPPED*, void> lpCompletionRoutine, READ_DIRECTORY_NOTIFY_INFORMATION_CLASS ReadDirectoryNotifyInformationClass);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("LPVOID")]
        public static extern void* MapViewOfFileExNuma([NativeTypeName("HANDLE")] IntPtr hFileMappingObject, [NativeTypeName("DWORD")] uint dwDesiredAccess, [NativeTypeName("DWORD")] uint dwFileOffsetHigh, [NativeTypeName("DWORD")] uint dwFileOffsetLow, [NativeTypeName("SIZE_T")] nuint dwNumberOfBytesToMap, [NativeTypeName("LPVOID")] void* lpBaseAddress, [NativeTypeName("DWORD")] uint nndPreferred);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int IsBadReadPtr([NativeTypeName("const void *")] void* lp, [NativeTypeName("UINT_PTR")] nuint ucb);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int IsBadWritePtr([NativeTypeName("LPVOID")] void* lp, [NativeTypeName("UINT_PTR")] nuint ucb);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int IsBadHugeReadPtr([NativeTypeName("const void *")] void* lp, [NativeTypeName("UINT_PTR")] nuint ucb);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int IsBadHugeWritePtr([NativeTypeName("LPVOID")] void* lp, [NativeTypeName("UINT_PTR")] nuint ucb);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int IsBadCodePtr([NativeTypeName("FARPROC")] delegate* unmanaged<int> lpfn);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int IsBadStringPtrA([NativeTypeName("LPCSTR")] sbyte* lpsz, [NativeTypeName("UINT_PTR")] nuint ucchMax);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int IsBadStringPtrW([NativeTypeName("LPCWSTR")] ushort* lpsz, [NativeTypeName("UINT_PTR")] nuint ucchMax);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int LookupAccountSidA([NativeTypeName("LPCSTR")] sbyte* lpSystemName, [NativeTypeName("PSID")] void* Sid, [NativeTypeName("LPSTR")] sbyte* Name, [NativeTypeName("LPDWORD")] uint* cchName, [NativeTypeName("LPSTR")] sbyte* ReferencedDomainName, [NativeTypeName("LPDWORD")] uint* cchReferencedDomainName, [NativeTypeName("PSID_NAME_USE")] SID_NAME_USE* peUse);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int LookupAccountSidW([NativeTypeName("LPCWSTR")] ushort* lpSystemName, [NativeTypeName("PSID")] void* Sid, [NativeTypeName("LPWSTR")] ushort* Name, [NativeTypeName("LPDWORD")] uint* cchName, [NativeTypeName("LPWSTR")] ushort* ReferencedDomainName, [NativeTypeName("LPDWORD")] uint* cchReferencedDomainName, [NativeTypeName("PSID_NAME_USE")] SID_NAME_USE* peUse);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int LookupAccountNameA([NativeTypeName("LPCSTR")] sbyte* lpSystemName, [NativeTypeName("LPCSTR")] sbyte* lpAccountName, [NativeTypeName("PSID")] void* Sid, [NativeTypeName("LPDWORD")] uint* cbSid, [NativeTypeName("LPSTR")] sbyte* ReferencedDomainName, [NativeTypeName("LPDWORD")] uint* cchReferencedDomainName, [NativeTypeName("PSID_NAME_USE")] SID_NAME_USE* peUse);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int LookupAccountNameW([NativeTypeName("LPCWSTR")] ushort* lpSystemName, [NativeTypeName("LPCWSTR")] ushort* lpAccountName, [NativeTypeName("PSID")] void* Sid, [NativeTypeName("LPDWORD")] uint* cbSid, [NativeTypeName("LPWSTR")] ushort* ReferencedDomainName, [NativeTypeName("LPDWORD")] uint* cchReferencedDomainName, [NativeTypeName("PSID_NAME_USE")] SID_NAME_USE* peUse);

        [DllImport("sechost", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int LookupAccountSidLocalA([NativeTypeName("PSID")] void* Sid, [NativeTypeName("LPSTR")] sbyte* Name, [NativeTypeName("LPDWORD")] uint* cchName, [NativeTypeName("LPSTR")] sbyte* ReferencedDomainName, [NativeTypeName("LPDWORD")] uint* cchReferencedDomainName, [NativeTypeName("PSID_NAME_USE")] SID_NAME_USE* peUse);

        [DllImport("sechost", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int LookupAccountSidLocalW([NativeTypeName("PSID")] void* Sid, [NativeTypeName("LPWSTR")] ushort* Name, [NativeTypeName("LPDWORD")] uint* cchName, [NativeTypeName("LPWSTR")] ushort* ReferencedDomainName, [NativeTypeName("LPDWORD")] uint* cchReferencedDomainName, [NativeTypeName("PSID_NAME_USE")] SID_NAME_USE* peUse);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int LookupPrivilegeValueA([NativeTypeName("LPCSTR")] sbyte* lpSystemName, [NativeTypeName("LPCSTR")] sbyte* lpName, [NativeTypeName("PLUID")] LUID* lpLuid);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int LookupPrivilegeValueW([NativeTypeName("LPCWSTR")] ushort* lpSystemName, [NativeTypeName("LPCWSTR")] ushort* lpName, [NativeTypeName("PLUID")] LUID* lpLuid);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int LookupPrivilegeNameA([NativeTypeName("LPCSTR")] sbyte* lpSystemName, [NativeTypeName("PLUID")] LUID* lpLuid, [NativeTypeName("LPSTR")] sbyte* lpName, [NativeTypeName("LPDWORD")] uint* cchName);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int LookupPrivilegeNameW([NativeTypeName("LPCWSTR")] ushort* lpSystemName, [NativeTypeName("PLUID")] LUID* lpLuid, [NativeTypeName("LPWSTR")] ushort* lpName, [NativeTypeName("LPDWORD")] uint* cchName);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int LookupPrivilegeDisplayNameA([NativeTypeName("LPCSTR")] sbyte* lpSystemName, [NativeTypeName("LPCSTR")] sbyte* lpName, [NativeTypeName("LPSTR")] sbyte* lpDisplayName, [NativeTypeName("LPDWORD")] uint* cchDisplayName, [NativeTypeName("LPDWORD")] uint* lpLanguageId);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int LookupPrivilegeDisplayNameW([NativeTypeName("LPCWSTR")] ushort* lpSystemName, [NativeTypeName("LPCWSTR")] ushort* lpName, [NativeTypeName("LPWSTR")] ushort* lpDisplayName, [NativeTypeName("LPDWORD")] uint* cchDisplayName, [NativeTypeName("LPDWORD")] uint* lpLanguageId);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int BuildCommDCBA([NativeTypeName("LPCSTR")] sbyte* lpDef, [NativeTypeName("LPDCB")] DCB* lpDCB);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int BuildCommDCBW([NativeTypeName("LPCWSTR")] ushort* lpDef, [NativeTypeName("LPDCB")] DCB* lpDCB);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int BuildCommDCBAndTimeoutsA([NativeTypeName("LPCSTR")] sbyte* lpDef, [NativeTypeName("LPDCB")] DCB* lpDCB, [NativeTypeName("LPCOMMTIMEOUTS")] COMMTIMEOUTS* lpCommTimeouts);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int BuildCommDCBAndTimeoutsW([NativeTypeName("LPCWSTR")] ushort* lpDef, [NativeTypeName("LPDCB")] DCB* lpDCB, [NativeTypeName("LPCOMMTIMEOUTS")] COMMTIMEOUTS* lpCommTimeouts);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CommConfigDialogA([NativeTypeName("LPCSTR")] sbyte* lpszName, [NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("LPCOMMCONFIG")] COMMCONFIG* lpCC);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CommConfigDialogW([NativeTypeName("LPCWSTR")] ushort* lpszName, [NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("LPCOMMCONFIG")] COMMCONFIG* lpCC);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetDefaultCommConfigA([NativeTypeName("LPCSTR")] sbyte* lpszName, [NativeTypeName("LPCOMMCONFIG")] COMMCONFIG* lpCC, [NativeTypeName("LPDWORD")] uint* lpdwSize);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetDefaultCommConfigW([NativeTypeName("LPCWSTR")] ushort* lpszName, [NativeTypeName("LPCOMMCONFIG")] COMMCONFIG* lpCC, [NativeTypeName("LPDWORD")] uint* lpdwSize);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetDefaultCommConfigA([NativeTypeName("LPCSTR")] sbyte* lpszName, [NativeTypeName("LPCOMMCONFIG")] COMMCONFIG* lpCC, [NativeTypeName("DWORD")] uint dwSize);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetDefaultCommConfigW([NativeTypeName("LPCWSTR")] ushort* lpszName, [NativeTypeName("LPCOMMCONFIG")] COMMCONFIG* lpCC, [NativeTypeName("DWORD")] uint dwSize);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetComputerNameA([NativeTypeName("LPSTR")] sbyte* lpBuffer, [NativeTypeName("LPDWORD")] uint* nSize);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetComputerNameW([NativeTypeName("LPWSTR")] ushort* lpBuffer, [NativeTypeName("LPDWORD")] uint* nSize);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int DnsHostnameToComputerNameA([NativeTypeName("LPCSTR")] sbyte* Hostname, [NativeTypeName("LPSTR")] sbyte* ComputerName, [NativeTypeName("LPDWORD")] uint* nSize);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int DnsHostnameToComputerNameW([NativeTypeName("LPCWSTR")] ushort* Hostname, [NativeTypeName("LPWSTR")] ushort* ComputerName, [NativeTypeName("LPDWORD")] uint* nSize);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetUserNameA([NativeTypeName("LPSTR")] sbyte* lpBuffer, [NativeTypeName("LPDWORD")] uint* pcbBuffer);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetUserNameW([NativeTypeName("LPWSTR")] ushort* lpBuffer, [NativeTypeName("LPDWORD")] uint* pcbBuffer);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int LogonUserA([NativeTypeName("LPCSTR")] sbyte* lpszUsername, [NativeTypeName("LPCSTR")] sbyte* lpszDomain, [NativeTypeName("LPCSTR")] sbyte* lpszPassword, [NativeTypeName("DWORD")] uint dwLogonType, [NativeTypeName("DWORD")] uint dwLogonProvider, [NativeTypeName("PHANDLE")] IntPtr* phToken);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int LogonUserW([NativeTypeName("LPCWSTR")] ushort* lpszUsername, [NativeTypeName("LPCWSTR")] ushort* lpszDomain, [NativeTypeName("LPCWSTR")] ushort* lpszPassword, [NativeTypeName("DWORD")] uint dwLogonType, [NativeTypeName("DWORD")] uint dwLogonProvider, [NativeTypeName("PHANDLE")] IntPtr* phToken);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int LogonUserExA([NativeTypeName("LPCSTR")] sbyte* lpszUsername, [NativeTypeName("LPCSTR")] sbyte* lpszDomain, [NativeTypeName("LPCSTR")] sbyte* lpszPassword, [NativeTypeName("DWORD")] uint dwLogonType, [NativeTypeName("DWORD")] uint dwLogonProvider, [NativeTypeName("PHANDLE")] IntPtr* phToken, [NativeTypeName("PSID *")] void** ppLogonSid, [NativeTypeName("PVOID *")] void** ppProfileBuffer, [NativeTypeName("LPDWORD")] uint* pdwProfileLength, [NativeTypeName("PQUOTA_LIMITS")] QUOTA_LIMITS* pQuotaLimits);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int LogonUserExW([NativeTypeName("LPCWSTR")] ushort* lpszUsername, [NativeTypeName("LPCWSTR")] ushort* lpszDomain, [NativeTypeName("LPCWSTR")] ushort* lpszPassword, [NativeTypeName("DWORD")] uint dwLogonType, [NativeTypeName("DWORD")] uint dwLogonProvider, [NativeTypeName("PHANDLE")] IntPtr* phToken, [NativeTypeName("PSID *")] void** ppLogonSid, [NativeTypeName("PVOID *")] void** ppProfileBuffer, [NativeTypeName("LPDWORD")] uint* pdwProfileLength, [NativeTypeName("PQUOTA_LIMITS")] QUOTA_LIMITS* pQuotaLimits);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CreateProcessWithLogonW([NativeTypeName("LPCWSTR")] ushort* lpUsername, [NativeTypeName("LPCWSTR")] ushort* lpDomain, [NativeTypeName("LPCWSTR")] ushort* lpPassword, [NativeTypeName("DWORD")] uint dwLogonFlags, [NativeTypeName("LPCWSTR")] ushort* lpApplicationName, [NativeTypeName("LPWSTR")] ushort* lpCommandLine, [NativeTypeName("DWORD")] uint dwCreationFlags, [NativeTypeName("LPVOID")] void* lpEnvironment, [NativeTypeName("LPCWSTR")] ushort* lpCurrentDirectory, [NativeTypeName("LPSTARTUPINFOW")] STARTUPINFOW* lpStartupInfo, [NativeTypeName("LPPROCESS_INFORMATION")] PROCESS_INFORMATION* lpProcessInformation);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CreateProcessWithTokenW([NativeTypeName("HANDLE")] IntPtr hToken, [NativeTypeName("DWORD")] uint dwLogonFlags, [NativeTypeName("LPCWSTR")] ushort* lpApplicationName, [NativeTypeName("LPWSTR")] ushort* lpCommandLine, [NativeTypeName("DWORD")] uint dwCreationFlags, [NativeTypeName("LPVOID")] void* lpEnvironment, [NativeTypeName("LPCWSTR")] ushort* lpCurrentDirectory, [NativeTypeName("LPSTARTUPINFOW")] STARTUPINFOW* lpStartupInfo, [NativeTypeName("LPPROCESS_INFORMATION")] PROCESS_INFORMATION* lpProcessInformation);

        [DllImport("advapi32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int IsTokenUntrusted([NativeTypeName("HANDLE")] IntPtr TokenHandle);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int RegisterWaitForSingleObject([NativeTypeName("PHANDLE")] IntPtr* phNewWaitObject, [NativeTypeName("HANDLE")] IntPtr hObject, [NativeTypeName("WAITORTIMERCALLBACK")] delegate* unmanaged<void*, byte, void> Callback, [NativeTypeName("PVOID")] void* Context, [NativeTypeName("ULONG")] uint dwMilliseconds, [NativeTypeName("ULONG")] uint dwFlags);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int UnregisterWait([NativeTypeName("HANDLE")] IntPtr WaitHandle);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int BindIoCompletionCallback([NativeTypeName("HANDLE")] IntPtr FileHandle, [NativeTypeName("LPOVERLAPPED_COMPLETION_ROUTINE")] delegate* unmanaged<uint, uint, OVERLAPPED*, void> Function, [NativeTypeName("ULONG")] uint Flags);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern IntPtr SetTimerQueueTimer([NativeTypeName("HANDLE")] IntPtr TimerQueue, [NativeTypeName("WAITORTIMERCALLBACK")] delegate* unmanaged<void*, byte, void> Callback, [NativeTypeName("PVOID")] void* Parameter, [NativeTypeName("DWORD")] uint DueTime, [NativeTypeName("DWORD")] uint Period, [NativeTypeName("BOOL")] int PreferIo);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CancelTimerQueueTimer([NativeTypeName("HANDLE")] IntPtr TimerQueue, [NativeTypeName("HANDLE")] IntPtr Timer);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern IntPtr CreatePrivateNamespaceA([NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpPrivateNamespaceAttributes, [NativeTypeName("LPVOID")] void* lpBoundaryDescriptor, [NativeTypeName("LPCSTR")] sbyte* lpAliasPrefix);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern IntPtr OpenPrivateNamespaceA([NativeTypeName("LPVOID")] void* lpBoundaryDescriptor, [NativeTypeName("LPCSTR")] sbyte* lpAliasPrefix);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern IntPtr CreateBoundaryDescriptorA([NativeTypeName("LPCSTR")] sbyte* Name, [NativeTypeName("ULONG")] uint Flags);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int AddIntegrityLabelToBoundaryDescriptor([NativeTypeName("HANDLE *")] IntPtr* BoundaryDescriptor, [NativeTypeName("PSID")] void* IntegrityLabel);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetCurrentHwProfileA([NativeTypeName("LPHW_PROFILE_INFOA")] HW_PROFILE_INFOA* lpHwProfileInfo);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetCurrentHwProfileW([NativeTypeName("LPHW_PROFILE_INFOW")] HW_PROFILE_INFOW* lpHwProfileInfo);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int VerifyVersionInfoA([NativeTypeName("LPOSVERSIONINFOEXA")] OSVERSIONINFOEXA* lpVersionInformation, [NativeTypeName("DWORD")] uint dwTypeMask, [NativeTypeName("DWORDLONG")] ulong dwlConditionMask);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int VerifyVersionInfoW([NativeTypeName("LPOSVERSIONINFOEXW")] OSVERSIONINFOEXW* lpVersionInformation, [NativeTypeName("DWORD")] uint dwTypeMask, [NativeTypeName("DWORDLONG")] ulong dwlConditionMask);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetSystemPowerState([NativeTypeName("BOOL")] int fSuspend, [NativeTypeName("BOOL")] int fForce);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetSystemPowerStatus([NativeTypeName("LPSYSTEM_POWER_STATUS")] SYSTEM_POWER_STATUS* lpSystemPowerStatus);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int MapUserPhysicalPagesScatter([NativeTypeName("PVOID *")] void** VirtualAddresses, [NativeTypeName("ULONG_PTR")] nuint NumberOfPages, [NativeTypeName("PULONG_PTR")] uint* PageArray);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern IntPtr CreateJobObjectA([NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpJobAttributes, [NativeTypeName("LPCSTR")] sbyte* lpName);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern IntPtr OpenJobObjectA([NativeTypeName("DWORD")] uint dwDesiredAccess, [NativeTypeName("BOOL")] int bInheritHandle, [NativeTypeName("LPCSTR")] sbyte* lpName);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CreateJobSet([NativeTypeName("ULONG")] uint NumJob, [NativeTypeName("PJOB_SET_ARRAY")] JOB_SET_ARRAY* UserJobSet, [NativeTypeName("ULONG")] uint Flags);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern IntPtr FindFirstVolumeA([NativeTypeName("LPSTR")] sbyte* lpszVolumeName, [NativeTypeName("DWORD")] uint cchBufferLength);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int FindNextVolumeA([NativeTypeName("HANDLE")] IntPtr hFindVolume, [NativeTypeName("LPSTR")] sbyte* lpszVolumeName, [NativeTypeName("DWORD")] uint cchBufferLength);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern IntPtr FindFirstVolumeMountPointA([NativeTypeName("LPCSTR")] sbyte* lpszRootPathName, [NativeTypeName("LPSTR")] sbyte* lpszVolumeMountPoint, [NativeTypeName("DWORD")] uint cchBufferLength);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern IntPtr FindFirstVolumeMountPointW([NativeTypeName("LPCWSTR")] ushort* lpszRootPathName, [NativeTypeName("LPWSTR")] ushort* lpszVolumeMountPoint, [NativeTypeName("DWORD")] uint cchBufferLength);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int FindNextVolumeMountPointA([NativeTypeName("HANDLE")] IntPtr hFindVolumeMountPoint, [NativeTypeName("LPSTR")] sbyte* lpszVolumeMountPoint, [NativeTypeName("DWORD")] uint cchBufferLength);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int FindNextVolumeMountPointW([NativeTypeName("HANDLE")] IntPtr hFindVolumeMountPoint, [NativeTypeName("LPWSTR")] ushort* lpszVolumeMountPoint, [NativeTypeName("DWORD")] uint cchBufferLength);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int FindVolumeMountPointClose([NativeTypeName("HANDLE")] IntPtr hFindVolumeMountPoint);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetVolumeMountPointA([NativeTypeName("LPCSTR")] sbyte* lpszVolumeMountPoint, [NativeTypeName("LPCSTR")] sbyte* lpszVolumeName);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetVolumeMountPointW([NativeTypeName("LPCWSTR")] ushort* lpszVolumeMountPoint, [NativeTypeName("LPCWSTR")] ushort* lpszVolumeName);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int DeleteVolumeMountPointA([NativeTypeName("LPCSTR")] sbyte* lpszVolumeMountPoint);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetVolumeNameForVolumeMountPointA([NativeTypeName("LPCSTR")] sbyte* lpszVolumeMountPoint, [NativeTypeName("LPSTR")] sbyte* lpszVolumeName, [NativeTypeName("DWORD")] uint cchBufferLength);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetVolumePathNameA([NativeTypeName("LPCSTR")] sbyte* lpszFileName, [NativeTypeName("LPSTR")] sbyte* lpszVolumePathName, [NativeTypeName("DWORD")] uint cchBufferLength);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetVolumePathNamesForVolumeNameA([NativeTypeName("LPCSTR")] sbyte* lpszVolumeName, [NativeTypeName("LPCH")] sbyte* lpszVolumePathNames, [NativeTypeName("DWORD")] uint cchBufferLength, [NativeTypeName("PDWORD")] uint* lpcchReturnLength);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern IntPtr CreateActCtxA([NativeTypeName("PCACTCTXA")] ACTCTXA* pActCtx);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern IntPtr CreateActCtxW([NativeTypeName("PCACTCTXW")] ACTCTXW* pActCtx);

        [DllImport("kernel32", ExactSpelling = true)]
        public static extern void AddRefActCtx([NativeTypeName("HANDLE")] IntPtr hActCtx);

        [DllImport("kernel32", ExactSpelling = true)]
        public static extern void ReleaseActCtx([NativeTypeName("HANDLE")] IntPtr hActCtx);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ZombifyActCtx([NativeTypeName("HANDLE")] IntPtr hActCtx);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ActivateActCtx([NativeTypeName("HANDLE")] IntPtr hActCtx, [NativeTypeName("ULONG_PTR *")] nuint* lpCookie);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int DeactivateActCtx([NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("ULONG_PTR")] nuint ulCookie);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetCurrentActCtx([NativeTypeName("HANDLE *")] IntPtr* lphActCtx);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int FindActCtxSectionStringA([NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("const GUID *")] Guid* lpExtensionGuid, [NativeTypeName("ULONG")] uint ulSectionId, [NativeTypeName("LPCSTR")] sbyte* lpStringToFind, [NativeTypeName("PACTCTX_SECTION_KEYED_DATA")] ACTCTX_SECTION_KEYED_DATA* ReturnedData);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int FindActCtxSectionStringW([NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("const GUID *")] Guid* lpExtensionGuid, [NativeTypeName("ULONG")] uint ulSectionId, [NativeTypeName("LPCWSTR")] ushort* lpStringToFind, [NativeTypeName("PACTCTX_SECTION_KEYED_DATA")] ACTCTX_SECTION_KEYED_DATA* ReturnedData);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int FindActCtxSectionGuid([NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("const GUID *")] Guid* lpExtensionGuid, [NativeTypeName("ULONG")] uint ulSectionId, [NativeTypeName("const GUID *")] Guid* lpGuidToFind, [NativeTypeName("PACTCTX_SECTION_KEYED_DATA")] ACTCTX_SECTION_KEYED_DATA* ReturnedData);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int QueryActCtxW([NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("HANDLE")] IntPtr hActCtx, [NativeTypeName("PVOID")] void* pvSubInstance, [NativeTypeName("ULONG")] uint ulInfoClass, [NativeTypeName("PVOID")] void* pvBuffer, [NativeTypeName("SIZE_T")] nuint cbBuffer, [NativeTypeName("SIZE_T *")] nuint* pcbWrittenOrRequired);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint WTSGetActiveConsoleSessionId();

        [DllImport("kernelbase", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint WTSGetServiceSessionId();

        [DllImport("kernelbase", ExactSpelling = true)]
        [return: NativeTypeName("BOOLEAN")]
        public static extern byte WTSIsServerContainer();

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("WORD")]
        public static extern ushort GetActiveProcessorGroupCount();

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("WORD")]
        public static extern ushort GetMaximumProcessorGroupCount();

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetActiveProcessorCount([NativeTypeName("WORD")] ushort GroupNumber);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetMaximumProcessorCount([NativeTypeName("WORD")] ushort GroupNumber);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetNumaProcessorNode([NativeTypeName("UCHAR")] byte Processor, [NativeTypeName("PUCHAR")] byte* NodeNumber);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetNumaNodeNumberFromHandle([NativeTypeName("HANDLE")] IntPtr hFile, [NativeTypeName("PUSHORT")] ushort* NodeNumber);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetNumaProcessorNodeEx([NativeTypeName("PPROCESSOR_NUMBER")] PROCESSOR_NUMBER* Processor, [NativeTypeName("PUSHORT")] ushort* NodeNumber);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetNumaNodeProcessorMask([NativeTypeName("UCHAR")] byte Node, [NativeTypeName("PULONGLONG")] ulong* ProcessorMask);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetNumaAvailableMemoryNode([NativeTypeName("UCHAR")] byte Node, [NativeTypeName("PULONGLONG")] ulong* AvailableBytes);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetNumaAvailableMemoryNodeEx([NativeTypeName("USHORT")] ushort Node, [NativeTypeName("PULONGLONG")] ulong* AvailableBytes);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetNumaProximityNode([NativeTypeName("ULONG")] uint ProximityId, [NativeTypeName("PUCHAR")] byte* NodeNumber);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int RegisterApplicationRecoveryCallback([NativeTypeName("APPLICATION_RECOVERY_CALLBACK")] delegate* unmanaged<void*, uint> pRecoveyCallback, [NativeTypeName("PVOID")] void* pvParameter, [NativeTypeName("DWORD")] uint dwPingInterval, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int UnregisterApplicationRecoveryCallback();

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int RegisterApplicationRestart([NativeTypeName("PCWSTR")] ushort* pwzCommandline, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int UnregisterApplicationRestart();

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int GetApplicationRecoveryCallback([NativeTypeName("HANDLE")] IntPtr hProcess, [NativeTypeName("APPLICATION_RECOVERY_CALLBACK *")] delegate* unmanaged<void*, uint>* pRecoveryCallback, [NativeTypeName("PVOID *")] void** ppvParameter, [NativeTypeName("PDWORD")] uint* pdwPingInterval, [NativeTypeName("PDWORD")] uint* pdwFlags);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int GetApplicationRestartSettings([NativeTypeName("HANDLE")] IntPtr hProcess, [NativeTypeName("PWSTR")] ushort* pwzCommandline, [NativeTypeName("PDWORD")] uint* pcchSize, [NativeTypeName("PDWORD")] uint* pdwFlags);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int ApplicationRecoveryInProgress([NativeTypeName("PBOOL")] int* pbCancelled);

        [DllImport("kernel32", ExactSpelling = true)]
        public static extern void ApplicationRecoveryFinished([NativeTypeName("BOOL")] int bSuccess);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetFileInformationByHandleEx([NativeTypeName("HANDLE")] IntPtr hFile, FILE_INFO_BY_HANDLE_CLASS FileInformationClass, [NativeTypeName("LPVOID")] void* lpFileInformation, [NativeTypeName("DWORD")] uint dwBufferSize);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern IntPtr OpenFileById([NativeTypeName("HANDLE")] IntPtr hVolumeHint, [NativeTypeName("LPFILE_ID_DESCRIPTOR")] FILE_ID_DESCRIPTOR* lpFileId, [NativeTypeName("DWORD")] uint dwDesiredAccess, [NativeTypeName("DWORD")] uint dwShareMode, [NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpSecurityAttributes, [NativeTypeName("DWORD")] uint dwFlagsAndAttributes);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOLEAN")]
        public static extern byte CreateSymbolicLinkA([NativeTypeName("LPCSTR")] sbyte* lpSymlinkFileName, [NativeTypeName("LPCSTR")] sbyte* lpTargetFileName, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOLEAN")]
        public static extern byte CreateSymbolicLinkW([NativeTypeName("LPCWSTR")] ushort* lpSymlinkFileName, [NativeTypeName("LPCWSTR")] ushort* lpTargetFileName, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int QueryActCtxSettingsW([NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("HANDLE")] IntPtr hActCtx, [NativeTypeName("PCWSTR")] ushort* settingsNameSpace, [NativeTypeName("PCWSTR")] ushort* settingName, [NativeTypeName("PWSTR")] ushort* pvBuffer, [NativeTypeName("SIZE_T")] nuint dwBuffer, [NativeTypeName("SIZE_T *")] nuint* pdwWrittenOrRequired);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOLEAN")]
        public static extern byte CreateSymbolicLinkTransactedA([NativeTypeName("LPCSTR")] sbyte* lpSymlinkFileName, [NativeTypeName("LPCSTR")] sbyte* lpTargetFileName, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("HANDLE")] IntPtr hTransaction);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOLEAN")]
        public static extern byte CreateSymbolicLinkTransactedW([NativeTypeName("LPCWSTR")] ushort* lpSymlinkFileName, [NativeTypeName("LPCWSTR")] ushort* lpTargetFileName, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("HANDLE")] IntPtr hTransaction);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ReplacePartitionUnit([NativeTypeName("PWSTR")] ushort* TargetPartition, [NativeTypeName("PWSTR")] ushort* SparePartition, [NativeTypeName("ULONG")] uint Flags);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int AddSecureMemoryCacheCallback([NativeTypeName("PSECURE_MEMORY_CACHE_CALLBACK")] delegate* unmanaged<void*, nuint, byte> pfnCallBack);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int RemoveSecureMemoryCacheCallback([NativeTypeName("PSECURE_MEMORY_CACHE_CALLBACK")] delegate* unmanaged<void*, nuint, byte> pfnCallBack);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CopyContext([NativeTypeName("PCONTEXT")] CONTEXT* Destination, [NativeTypeName("DWORD")] uint ContextFlags, [NativeTypeName("PCONTEXT")] CONTEXT* Source);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int InitializeContext([NativeTypeName("PVOID")] void* Buffer, [NativeTypeName("DWORD")] uint ContextFlags, [NativeTypeName("PCONTEXT *")] CONTEXT** Context, [NativeTypeName("PDWORD")] uint* ContextLength);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int InitializeContext2([NativeTypeName("PVOID")] void* Buffer, [NativeTypeName("DWORD")] uint ContextFlags, [NativeTypeName("PCONTEXT *")] CONTEXT** Context, [NativeTypeName("PDWORD")] uint* ContextLength, [NativeTypeName("ULONG64")] ulong XStateCompactionMask);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("DWORD64")]
        public static extern ulong GetEnabledXStateFeatures();

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetXStateFeaturesMask([NativeTypeName("PCONTEXT")] CONTEXT* Context, [NativeTypeName("PDWORD64")] ulong* FeatureMask);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("PVOID")]
        public static extern void* LocateXStateFeature([NativeTypeName("PCONTEXT")] CONTEXT* Context, [NativeTypeName("DWORD")] uint FeatureId, [NativeTypeName("PDWORD")] uint* Length);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetXStateFeaturesMask([NativeTypeName("PCONTEXT")] CONTEXT* Context, [NativeTypeName("DWORD64")] ulong FeatureMask);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("DWORD64")]
        public static extern ulong GetThreadEnabledXStateFeatures();

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int EnableProcessOptionalXStateFeatures([NativeTypeName("DWORD64")] ulong Features);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint EnableThreadProfiling([NativeTypeName("HANDLE")] IntPtr ThreadHandle, [NativeTypeName("DWORD")] uint Flags, [NativeTypeName("DWORD64")] ulong HardwareCounters, [NativeTypeName("HANDLE *")] IntPtr* PerformanceDataHandle);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint DisableThreadProfiling([NativeTypeName("HANDLE")] IntPtr PerformanceDataHandle);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint QueryThreadProfiling([NativeTypeName("HANDLE")] IntPtr ThreadHandle, [NativeTypeName("PBOOLEAN")] byte* Enabled);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint ReadThreadProfilingData([NativeTypeName("HANDLE")] IntPtr PerformanceDataHandle, [NativeTypeName("DWORD")] uint Flags, [NativeTypeName("PPERFORMANCE_DATA")] PERFORMANCE_DATA* PerformanceData);

        [DllImport("kernelbase", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint RaiseCustomSystemEventTrigger([NativeTypeName("PCUSTOM_SYSTEM_EVENT_TRIGGER_CONFIG")] CUSTOM_SYSTEM_EVENT_TRIGGER_CONFIG* CustomSystemEventTriggerConfig);

        [NativeTypeName("#define FILE_BEGIN 0")]
        public const int FILE_BEGIN = 0;

        [NativeTypeName("#define FILE_CURRENT 1")]
        public const int FILE_CURRENT = 1;

        [NativeTypeName("#define FILE_END 2")]
        public const int FILE_END = 2;

        [NativeTypeName("#define WAIT_FAILED ((DWORD)0xFFFFFFFF)")]
        public const uint WAIT_FAILED = ((uint)(0xFFFFFFFF));

        [NativeTypeName("#define WAIT_OBJECT_0 ((STATUS_WAIT_0 ) + 0 )")]
        public const uint WAIT_OBJECT_0 = ((((uint)(0x00000000))) + 0);

        [NativeTypeName("#define WAIT_ABANDONED ((STATUS_ABANDONED_WAIT_0 ) + 0 )")]
        public const uint WAIT_ABANDONED = ((((uint)(0x00000080))) + 0);

        [NativeTypeName("#define WAIT_ABANDONED_0 ((STATUS_ABANDONED_WAIT_0 ) + 0 )")]
        public const uint WAIT_ABANDONED_0 = ((((uint)(0x00000080))) + 0);

        [NativeTypeName("#define WAIT_IO_COMPLETION STATUS_USER_APC")]
        public const uint WAIT_IO_COMPLETION = ((uint)(0x000000C0));

        [NativeTypeName("#define FILE_FLAG_WRITE_THROUGH 0x80000000")]
        public const uint FILE_FLAG_WRITE_THROUGH = 0x80000000;

        [NativeTypeName("#define FILE_FLAG_OVERLAPPED 0x40000000")]
        public const int FILE_FLAG_OVERLAPPED = 0x40000000;

        [NativeTypeName("#define FILE_FLAG_NO_BUFFERING 0x20000000")]
        public const int FILE_FLAG_NO_BUFFERING = 0x20000000;

        [NativeTypeName("#define FILE_FLAG_RANDOM_ACCESS 0x10000000")]
        public const int FILE_FLAG_RANDOM_ACCESS = 0x10000000;

        [NativeTypeName("#define FILE_FLAG_SEQUENTIAL_SCAN 0x08000000")]
        public const int FILE_FLAG_SEQUENTIAL_SCAN = 0x08000000;

        [NativeTypeName("#define FILE_FLAG_DELETE_ON_CLOSE 0x04000000")]
        public const int FILE_FLAG_DELETE_ON_CLOSE = 0x04000000;

        [NativeTypeName("#define FILE_FLAG_BACKUP_SEMANTICS 0x02000000")]
        public const int FILE_FLAG_BACKUP_SEMANTICS = 0x02000000;

        [NativeTypeName("#define FILE_FLAG_POSIX_SEMANTICS 0x01000000")]
        public const int FILE_FLAG_POSIX_SEMANTICS = 0x01000000;

        [NativeTypeName("#define FILE_FLAG_SESSION_AWARE 0x00800000")]
        public const int FILE_FLAG_SESSION_AWARE = 0x00800000;

        [NativeTypeName("#define FILE_FLAG_OPEN_REPARSE_POINT 0x00200000")]
        public const int FILE_FLAG_OPEN_REPARSE_POINT = 0x00200000;

        [NativeTypeName("#define FILE_FLAG_OPEN_NO_RECALL 0x00100000")]
        public const int FILE_FLAG_OPEN_NO_RECALL = 0x00100000;

        [NativeTypeName("#define FILE_FLAG_FIRST_PIPE_INSTANCE 0x00080000")]
        public const int FILE_FLAG_FIRST_PIPE_INSTANCE = 0x00080000;

        [NativeTypeName("#define FILE_FLAG_OPEN_REQUIRING_OPLOCK 0x00040000")]
        public const int FILE_FLAG_OPEN_REQUIRING_OPLOCK = 0x00040000;

        [NativeTypeName("#define PROGRESS_CONTINUE 0")]
        public const int PROGRESS_CONTINUE = 0;

        [NativeTypeName("#define PROGRESS_CANCEL 1")]
        public const int PROGRESS_CANCEL = 1;

        [NativeTypeName("#define PROGRESS_STOP 2")]
        public const int PROGRESS_STOP = 2;

        [NativeTypeName("#define PROGRESS_QUIET 3")]
        public const int PROGRESS_QUIET = 3;

        [NativeTypeName("#define CALLBACK_CHUNK_FINISHED 0x00000000")]
        public const int CALLBACK_CHUNK_FINISHED = 0x00000000;

        [NativeTypeName("#define CALLBACK_STREAM_SWITCH 0x00000001")]
        public const int CALLBACK_STREAM_SWITCH = 0x00000001;

        [NativeTypeName("#define COPY_FILE_FAIL_IF_EXISTS 0x00000001")]
        public const int COPY_FILE_FAIL_IF_EXISTS = 0x00000001;

        [NativeTypeName("#define COPY_FILE_RESTARTABLE 0x00000002")]
        public const int COPY_FILE_RESTARTABLE = 0x00000002;

        [NativeTypeName("#define COPY_FILE_OPEN_SOURCE_FOR_WRITE 0x00000004")]
        public const int COPY_FILE_OPEN_SOURCE_FOR_WRITE = 0x00000004;

        [NativeTypeName("#define COPY_FILE_ALLOW_DECRYPTED_DESTINATION 0x00000008")]
        public const int COPY_FILE_ALLOW_DECRYPTED_DESTINATION = 0x00000008;

        [NativeTypeName("#define COPY_FILE_COPY_SYMLINK 0x00000800")]
        public const int COPY_FILE_COPY_SYMLINK = 0x00000800;

        [NativeTypeName("#define COPY_FILE_NO_BUFFERING 0x00001000")]
        public const int COPY_FILE_NO_BUFFERING = 0x00001000;

        [NativeTypeName("#define COPY_FILE_REQUEST_SECURITY_PRIVILEGES 0x00002000")]
        public const int COPY_FILE_REQUEST_SECURITY_PRIVILEGES = 0x00002000;

        [NativeTypeName("#define COPY_FILE_RESUME_FROM_PAUSE 0x00004000")]
        public const int COPY_FILE_RESUME_FROM_PAUSE = 0x00004000;

        [NativeTypeName("#define COPY_FILE_NO_OFFLOAD 0x00040000")]
        public const int COPY_FILE_NO_OFFLOAD = 0x00040000;

        [NativeTypeName("#define COPY_FILE_IGNORE_EDP_BLOCK 0x00400000")]
        public const int COPY_FILE_IGNORE_EDP_BLOCK = 0x00400000;

        [NativeTypeName("#define COPY_FILE_IGNORE_SOURCE_ENCRYPTION 0x00800000")]
        public const int COPY_FILE_IGNORE_SOURCE_ENCRYPTION = 0x00800000;

        [NativeTypeName("#define COPY_FILE_DONT_REQUEST_DEST_WRITE_DAC 0x02000000")]
        public const int COPY_FILE_DONT_REQUEST_DEST_WRITE_DAC = 0x02000000;

        [NativeTypeName("#define COPY_FILE_REQUEST_COMPRESSED_TRAFFIC 0x10000000")]
        public const int COPY_FILE_REQUEST_COMPRESSED_TRAFFIC = 0x10000000;

        [NativeTypeName("#define COPY_FILE_OPEN_AND_COPY_REPARSE_POINT 0x00200000")]
        public const int COPY_FILE_OPEN_AND_COPY_REPARSE_POINT = 0x00200000;

        [NativeTypeName("#define COPY_FILE_DIRECTORY 0x00000080")]
        public const int COPY_FILE_DIRECTORY = 0x00000080;

        [NativeTypeName("#define COPY_FILE_SKIP_ALTERNATE_STREAMS 0x00008000")]
        public const int COPY_FILE_SKIP_ALTERNATE_STREAMS = 0x00008000;

        [NativeTypeName("#define COPY_FILE_DISABLE_PRE_ALLOCATION 0x04000000")]
        public const int COPY_FILE_DISABLE_PRE_ALLOCATION = 0x04000000;

        [NativeTypeName("#define COPY_FILE_ENABLE_LOW_FREE_SPACE_MODE 0x08000000")]
        public const int COPY_FILE_ENABLE_LOW_FREE_SPACE_MODE = 0x08000000;

        [NativeTypeName("#define REPLACEFILE_WRITE_THROUGH 0x00000001")]
        public const int REPLACEFILE_WRITE_THROUGH = 0x00000001;

        [NativeTypeName("#define REPLACEFILE_IGNORE_MERGE_ERRORS 0x00000002")]
        public const int REPLACEFILE_IGNORE_MERGE_ERRORS = 0x00000002;

        [NativeTypeName("#define REPLACEFILE_IGNORE_ACL_ERRORS 0x00000004")]
        public const int REPLACEFILE_IGNORE_ACL_ERRORS = 0x00000004;

        [NativeTypeName("#define PIPE_ACCESS_INBOUND 0x00000001")]
        public const int PIPE_ACCESS_INBOUND = 0x00000001;

        [NativeTypeName("#define PIPE_ACCESS_OUTBOUND 0x00000002")]
        public const int PIPE_ACCESS_OUTBOUND = 0x00000002;

        [NativeTypeName("#define PIPE_ACCESS_DUPLEX 0x00000003")]
        public const int PIPE_ACCESS_DUPLEX = 0x00000003;

        [NativeTypeName("#define PIPE_CLIENT_END 0x00000000")]
        public const int PIPE_CLIENT_END = 0x00000000;

        [NativeTypeName("#define PIPE_SERVER_END 0x00000001")]
        public const int PIPE_SERVER_END = 0x00000001;

        [NativeTypeName("#define PIPE_WAIT 0x00000000")]
        public const int PIPE_WAIT = 0x00000000;

        [NativeTypeName("#define PIPE_NOWAIT 0x00000001")]
        public const int PIPE_NOWAIT = 0x00000001;

        [NativeTypeName("#define PIPE_READMODE_BYTE 0x00000000")]
        public const int PIPE_READMODE_BYTE = 0x00000000;

        [NativeTypeName("#define PIPE_READMODE_MESSAGE 0x00000002")]
        public const int PIPE_READMODE_MESSAGE = 0x00000002;

        [NativeTypeName("#define PIPE_TYPE_BYTE 0x00000000")]
        public const int PIPE_TYPE_BYTE = 0x00000000;

        [NativeTypeName("#define PIPE_TYPE_MESSAGE 0x00000004")]
        public const int PIPE_TYPE_MESSAGE = 0x00000004;

        [NativeTypeName("#define PIPE_ACCEPT_REMOTE_CLIENTS 0x00000000")]
        public const int PIPE_ACCEPT_REMOTE_CLIENTS = 0x00000000;

        [NativeTypeName("#define PIPE_REJECT_REMOTE_CLIENTS 0x00000008")]
        public const int PIPE_REJECT_REMOTE_CLIENTS = 0x00000008;

        [NativeTypeName("#define PIPE_UNLIMITED_INSTANCES 255")]
        public const int PIPE_UNLIMITED_INSTANCES = 255;

        [NativeTypeName("#define SECURITY_ANONYMOUS ( SecurityAnonymous      << 16 )")]
        public const int SECURITY_ANONYMOUS = ((int)(SecurityAnonymous) << 16);

        [NativeTypeName("#define SECURITY_IDENTIFICATION ( SecurityIdentification << 16 )")]
        public const int SECURITY_IDENTIFICATION = ((int)(SecurityIdentification) << 16);

        [NativeTypeName("#define SECURITY_IMPERSONATION ( SecurityImpersonation  << 16 )")]
        public const int SECURITY_IMPERSONATION = ((int)(SecurityImpersonation) << 16);

        [NativeTypeName("#define SECURITY_DELEGATION ( SecurityDelegation     << 16 )")]
        public const int SECURITY_DELEGATION = ((int)(SecurityDelegation) << 16);

        [NativeTypeName("#define SECURITY_CONTEXT_TRACKING 0x00040000")]
        public const int SECURITY_CONTEXT_TRACKING = 0x00040000;

        [NativeTypeName("#define SECURITY_EFFECTIVE_ONLY 0x00080000")]
        public const int SECURITY_EFFECTIVE_ONLY = 0x00080000;

        [NativeTypeName("#define SECURITY_SQOS_PRESENT 0x00100000")]
        public const int SECURITY_SQOS_PRESENT = 0x00100000;

        [NativeTypeName("#define SECURITY_VALID_SQOS_FLAGS 0x001F0000")]
        public const int SECURITY_VALID_SQOS_FLAGS = 0x001F0000;

        [NativeTypeName("#define FAIL_FAST_GENERATE_EXCEPTION_ADDRESS 0x1")]
        public const int FAIL_FAST_GENERATE_EXCEPTION_ADDRESS = 0x1;

        [NativeTypeName("#define FAIL_FAST_NO_HARD_ERROR_DLG 0x2")]
        public const int FAIL_FAST_NO_HARD_ERROR_DLG = 0x2;

        [NativeTypeName("#define SP_SERIALCOMM ((DWORD)0x00000001)")]
        public const uint SP_SERIALCOMM = ((uint)(0x00000001));

        [NativeTypeName("#define PST_UNSPECIFIED ((DWORD)0x00000000)")]
        public const uint PST_UNSPECIFIED = ((uint)(0x00000000));

        [NativeTypeName("#define PST_RS232 ((DWORD)0x00000001)")]
        public const uint PST_RS232 = ((uint)(0x00000001));

        [NativeTypeName("#define PST_PARALLELPORT ((DWORD)0x00000002)")]
        public const uint PST_PARALLELPORT = ((uint)(0x00000002));

        [NativeTypeName("#define PST_RS422 ((DWORD)0x00000003)")]
        public const uint PST_RS422 = ((uint)(0x00000003));

        [NativeTypeName("#define PST_RS423 ((DWORD)0x00000004)")]
        public const uint PST_RS423 = ((uint)(0x00000004));

        [NativeTypeName("#define PST_RS449 ((DWORD)0x00000005)")]
        public const uint PST_RS449 = ((uint)(0x00000005));

        [NativeTypeName("#define PST_MODEM ((DWORD)0x00000006)")]
        public const uint PST_MODEM = ((uint)(0x00000006));

        [NativeTypeName("#define PST_FAX ((DWORD)0x00000021)")]
        public const uint PST_FAX = ((uint)(0x00000021));

        [NativeTypeName("#define PST_SCANNER ((DWORD)0x00000022)")]
        public const uint PST_SCANNER = ((uint)(0x00000022));

        [NativeTypeName("#define PST_NETWORK_BRIDGE ((DWORD)0x00000100)")]
        public const uint PST_NETWORK_BRIDGE = ((uint)(0x00000100));

        [NativeTypeName("#define PST_LAT ((DWORD)0x00000101)")]
        public const uint PST_LAT = ((uint)(0x00000101));

        [NativeTypeName("#define PST_TCPIP_TELNET ((DWORD)0x00000102)")]
        public const uint PST_TCPIP_TELNET = ((uint)(0x00000102));

        [NativeTypeName("#define PST_X25 ((DWORD)0x00000103)")]
        public const uint PST_X25 = ((uint)(0x00000103));

        [NativeTypeName("#define PCF_DTRDSR ((DWORD)0x0001)")]
        public const uint PCF_DTRDSR = ((uint)(0x0001));

        [NativeTypeName("#define PCF_RTSCTS ((DWORD)0x0002)")]
        public const uint PCF_RTSCTS = ((uint)(0x0002));

        [NativeTypeName("#define PCF_RLSD ((DWORD)0x0004)")]
        public const uint PCF_RLSD = ((uint)(0x0004));

        [NativeTypeName("#define PCF_PARITY_CHECK ((DWORD)0x0008)")]
        public const uint PCF_PARITY_CHECK = ((uint)(0x0008));

        [NativeTypeName("#define PCF_XONXOFF ((DWORD)0x0010)")]
        public const uint PCF_XONXOFF = ((uint)(0x0010));

        [NativeTypeName("#define PCF_SETXCHAR ((DWORD)0x0020)")]
        public const uint PCF_SETXCHAR = ((uint)(0x0020));

        [NativeTypeName("#define PCF_TOTALTIMEOUTS ((DWORD)0x0040)")]
        public const uint PCF_TOTALTIMEOUTS = ((uint)(0x0040));

        [NativeTypeName("#define PCF_INTTIMEOUTS ((DWORD)0x0080)")]
        public const uint PCF_INTTIMEOUTS = ((uint)(0x0080));

        [NativeTypeName("#define PCF_SPECIALCHARS ((DWORD)0x0100)")]
        public const uint PCF_SPECIALCHARS = ((uint)(0x0100));

        [NativeTypeName("#define PCF_16BITMODE ((DWORD)0x0200)")]
        public const uint PCF_16BITMODE = ((uint)(0x0200));

        [NativeTypeName("#define SP_PARITY ((DWORD)0x0001)")]
        public const uint SP_PARITY = ((uint)(0x0001));

        [NativeTypeName("#define SP_BAUD ((DWORD)0x0002)")]
        public const uint SP_BAUD = ((uint)(0x0002));

        [NativeTypeName("#define SP_DATABITS ((DWORD)0x0004)")]
        public const uint SP_DATABITS = ((uint)(0x0004));

        [NativeTypeName("#define SP_STOPBITS ((DWORD)0x0008)")]
        public const uint SP_STOPBITS = ((uint)(0x0008));

        [NativeTypeName("#define SP_HANDSHAKING ((DWORD)0x0010)")]
        public const uint SP_HANDSHAKING = ((uint)(0x0010));

        [NativeTypeName("#define SP_PARITY_CHECK ((DWORD)0x0020)")]
        public const uint SP_PARITY_CHECK = ((uint)(0x0020));

        [NativeTypeName("#define SP_RLSD ((DWORD)0x0040)")]
        public const uint SP_RLSD = ((uint)(0x0040));

        [NativeTypeName("#define BAUD_075 ((DWORD)0x00000001)")]
        public const uint BAUD_075 = ((uint)(0x00000001));

        [NativeTypeName("#define BAUD_110 ((DWORD)0x00000002)")]
        public const uint BAUD_110 = ((uint)(0x00000002));

        [NativeTypeName("#define BAUD_134_5 ((DWORD)0x00000004)")]
        public const uint BAUD_134_5 = ((uint)(0x00000004));

        [NativeTypeName("#define BAUD_150 ((DWORD)0x00000008)")]
        public const uint BAUD_150 = ((uint)(0x00000008));

        [NativeTypeName("#define BAUD_300 ((DWORD)0x00000010)")]
        public const uint BAUD_300 = ((uint)(0x00000010));

        [NativeTypeName("#define BAUD_600 ((DWORD)0x00000020)")]
        public const uint BAUD_600 = ((uint)(0x00000020));

        [NativeTypeName("#define BAUD_1200 ((DWORD)0x00000040)")]
        public const uint BAUD_1200 = ((uint)(0x00000040));

        [NativeTypeName("#define BAUD_1800 ((DWORD)0x00000080)")]
        public const uint BAUD_1800 = ((uint)(0x00000080));

        [NativeTypeName("#define BAUD_2400 ((DWORD)0x00000100)")]
        public const uint BAUD_2400 = ((uint)(0x00000100));

        [NativeTypeName("#define BAUD_4800 ((DWORD)0x00000200)")]
        public const uint BAUD_4800 = ((uint)(0x00000200));

        [NativeTypeName("#define BAUD_7200 ((DWORD)0x00000400)")]
        public const uint BAUD_7200 = ((uint)(0x00000400));

        [NativeTypeName("#define BAUD_9600 ((DWORD)0x00000800)")]
        public const uint BAUD_9600 = ((uint)(0x00000800));

        [NativeTypeName("#define BAUD_14400 ((DWORD)0x00001000)")]
        public const uint BAUD_14400 = ((uint)(0x00001000));

        [NativeTypeName("#define BAUD_19200 ((DWORD)0x00002000)")]
        public const uint BAUD_19200 = ((uint)(0x00002000));

        [NativeTypeName("#define BAUD_38400 ((DWORD)0x00004000)")]
        public const uint BAUD_38400 = ((uint)(0x00004000));

        [NativeTypeName("#define BAUD_56K ((DWORD)0x00008000)")]
        public const uint BAUD_56K = ((uint)(0x00008000));

        [NativeTypeName("#define BAUD_128K ((DWORD)0x00010000)")]
        public const uint BAUD_128K = ((uint)(0x00010000));

        [NativeTypeName("#define BAUD_115200 ((DWORD)0x00020000)")]
        public const uint BAUD_115200 = ((uint)(0x00020000));

        [NativeTypeName("#define BAUD_57600 ((DWORD)0x00040000)")]
        public const uint BAUD_57600 = ((uint)(0x00040000));

        [NativeTypeName("#define BAUD_USER ((DWORD)0x10000000)")]
        public const uint BAUD_USER = ((uint)(0x10000000));

        [NativeTypeName("#define DATABITS_5 ((WORD)0x0001)")]
        public const ushort DATABITS_5 = ((ushort)(0x0001));

        [NativeTypeName("#define DATABITS_6 ((WORD)0x0002)")]
        public const ushort DATABITS_6 = ((ushort)(0x0002));

        [NativeTypeName("#define DATABITS_7 ((WORD)0x0004)")]
        public const ushort DATABITS_7 = ((ushort)(0x0004));

        [NativeTypeName("#define DATABITS_8 ((WORD)0x0008)")]
        public const ushort DATABITS_8 = ((ushort)(0x0008));

        [NativeTypeName("#define DATABITS_16 ((WORD)0x0010)")]
        public const ushort DATABITS_16 = ((ushort)(0x0010));

        [NativeTypeName("#define DATABITS_16X ((WORD)0x0020)")]
        public const ushort DATABITS_16X = ((ushort)(0x0020));

        [NativeTypeName("#define STOPBITS_10 ((WORD)0x0001)")]
        public const ushort STOPBITS_10 = ((ushort)(0x0001));

        [NativeTypeName("#define STOPBITS_15 ((WORD)0x0002)")]
        public const ushort STOPBITS_15 = ((ushort)(0x0002));

        [NativeTypeName("#define STOPBITS_20 ((WORD)0x0004)")]
        public const ushort STOPBITS_20 = ((ushort)(0x0004));

        [NativeTypeName("#define PARITY_NONE ((WORD)0x0100)")]
        public const ushort PARITY_NONE = ((ushort)(0x0100));

        [NativeTypeName("#define PARITY_ODD ((WORD)0x0200)")]
        public const ushort PARITY_ODD = ((ushort)(0x0200));

        [NativeTypeName("#define PARITY_EVEN ((WORD)0x0400)")]
        public const ushort PARITY_EVEN = ((ushort)(0x0400));

        [NativeTypeName("#define PARITY_MARK ((WORD)0x0800)")]
        public const ushort PARITY_MARK = ((ushort)(0x0800));

        [NativeTypeName("#define PARITY_SPACE ((WORD)0x1000)")]
        public const ushort PARITY_SPACE = ((ushort)(0x1000));

        [NativeTypeName("#define COMMPROP_INITIALIZED ((DWORD)0xE73CF52E)")]
        public const uint COMMPROP_INITIALIZED = ((uint)(0xE73CF52E));

        [NativeTypeName("#define DTR_CONTROL_DISABLE 0x00")]
        public const int DTR_CONTROL_DISABLE = 0x00;

        [NativeTypeName("#define DTR_CONTROL_ENABLE 0x01")]
        public const int DTR_CONTROL_ENABLE = 0x01;

        [NativeTypeName("#define DTR_CONTROL_HANDSHAKE 0x02")]
        public const int DTR_CONTROL_HANDSHAKE = 0x02;

        [NativeTypeName("#define RTS_CONTROL_DISABLE 0x00")]
        public const int RTS_CONTROL_DISABLE = 0x00;

        [NativeTypeName("#define RTS_CONTROL_ENABLE 0x01")]
        public const int RTS_CONTROL_ENABLE = 0x01;

        [NativeTypeName("#define RTS_CONTROL_HANDSHAKE 0x02")]
        public const int RTS_CONTROL_HANDSHAKE = 0x02;

        [NativeTypeName("#define RTS_CONTROL_TOGGLE 0x03")]
        public const int RTS_CONTROL_TOGGLE = 0x03;

        [NativeTypeName("#define GMEM_FIXED 0x0000")]
        public const int GMEM_FIXED = 0x0000;

        [NativeTypeName("#define GMEM_MOVEABLE 0x0002")]
        public const int GMEM_MOVEABLE = 0x0002;

        [NativeTypeName("#define GMEM_NOCOMPACT 0x0010")]
        public const int GMEM_NOCOMPACT = 0x0010;

        [NativeTypeName("#define GMEM_NODISCARD 0x0020")]
        public const int GMEM_NODISCARD = 0x0020;

        [NativeTypeName("#define GMEM_ZEROINIT 0x0040")]
        public const int GMEM_ZEROINIT = 0x0040;

        [NativeTypeName("#define GMEM_MODIFY 0x0080")]
        public const int GMEM_MODIFY = 0x0080;

        [NativeTypeName("#define GMEM_DISCARDABLE 0x0100")]
        public const int GMEM_DISCARDABLE = 0x0100;

        [NativeTypeName("#define GMEM_NOT_BANKED 0x1000")]
        public const int GMEM_NOT_BANKED = 0x1000;

        [NativeTypeName("#define GMEM_SHARE 0x2000")]
        public const int GMEM_SHARE = 0x2000;

        [NativeTypeName("#define GMEM_DDESHARE 0x2000")]
        public const int GMEM_DDESHARE = 0x2000;

        [NativeTypeName("#define GMEM_NOTIFY 0x4000")]
        public const int GMEM_NOTIFY = 0x4000;

        [NativeTypeName("#define GMEM_LOWER GMEM_NOT_BANKED")]
        public const int GMEM_LOWER = 0x1000;

        [NativeTypeName("#define GMEM_VALID_FLAGS 0x7F72")]
        public const int GMEM_VALID_FLAGS = 0x7F72;

        [NativeTypeName("#define GMEM_INVALID_HANDLE 0x8000")]
        public const int GMEM_INVALID_HANDLE = 0x8000;

        [NativeTypeName("#define GHND (GMEM_MOVEABLE | GMEM_ZEROINIT)")]
        public const int GHND = (0x0002 | 0x0040);

        [NativeTypeName("#define GPTR (GMEM_FIXED | GMEM_ZEROINIT)")]
        public const int GPTR = (0x0000 | 0x0040);

        [NativeTypeName("#define GMEM_DISCARDED 0x4000")]
        public const int GMEM_DISCARDED = 0x4000;

        [NativeTypeName("#define GMEM_LOCKCOUNT 0x00FF")]
        public const int GMEM_LOCKCOUNT = 0x00FF;

        [NativeTypeName("#define DEBUG_PROCESS 0x00000001")]
        public const int DEBUG_PROCESS = 0x00000001;

        [NativeTypeName("#define DEBUG_ONLY_THIS_PROCESS 0x00000002")]
        public const int DEBUG_ONLY_THIS_PROCESS = 0x00000002;

        [NativeTypeName("#define CREATE_SUSPENDED 0x00000004")]
        public const int CREATE_SUSPENDED = 0x00000004;

        [NativeTypeName("#define DETACHED_PROCESS 0x00000008")]
        public const int DETACHED_PROCESS = 0x00000008;

        [NativeTypeName("#define CREATE_NEW_CONSOLE 0x00000010")]
        public const int CREATE_NEW_CONSOLE = 0x00000010;

        [NativeTypeName("#define NORMAL_PRIORITY_CLASS 0x00000020")]
        public const int NORMAL_PRIORITY_CLASS = 0x00000020;

        [NativeTypeName("#define IDLE_PRIORITY_CLASS 0x00000040")]
        public const int IDLE_PRIORITY_CLASS = 0x00000040;

        [NativeTypeName("#define HIGH_PRIORITY_CLASS 0x00000080")]
        public const int HIGH_PRIORITY_CLASS = 0x00000080;

        [NativeTypeName("#define REALTIME_PRIORITY_CLASS 0x00000100")]
        public const int REALTIME_PRIORITY_CLASS = 0x00000100;

        [NativeTypeName("#define CREATE_NEW_PROCESS_GROUP 0x00000200")]
        public const int CREATE_NEW_PROCESS_GROUP = 0x00000200;

        [NativeTypeName("#define CREATE_UNICODE_ENVIRONMENT 0x00000400")]
        public const int CREATE_UNICODE_ENVIRONMENT = 0x00000400;

        [NativeTypeName("#define CREATE_SEPARATE_WOW_VDM 0x00000800")]
        public const int CREATE_SEPARATE_WOW_VDM = 0x00000800;

        [NativeTypeName("#define CREATE_SHARED_WOW_VDM 0x00001000")]
        public const int CREATE_SHARED_WOW_VDM = 0x00001000;

        [NativeTypeName("#define CREATE_FORCEDOS 0x00002000")]
        public const int CREATE_FORCEDOS = 0x00002000;

        [NativeTypeName("#define BELOW_NORMAL_PRIORITY_CLASS 0x00004000")]
        public const int BELOW_NORMAL_PRIORITY_CLASS = 0x00004000;

        [NativeTypeName("#define ABOVE_NORMAL_PRIORITY_CLASS 0x00008000")]
        public const int ABOVE_NORMAL_PRIORITY_CLASS = 0x00008000;

        [NativeTypeName("#define INHERIT_PARENT_AFFINITY 0x00010000")]
        public const int INHERIT_PARENT_AFFINITY = 0x00010000;

        [NativeTypeName("#define INHERIT_CALLER_PRIORITY 0x00020000")]
        public const int INHERIT_CALLER_PRIORITY = 0x00020000;

        [NativeTypeName("#define CREATE_PROTECTED_PROCESS 0x00040000")]
        public const int CREATE_PROTECTED_PROCESS = 0x00040000;

        [NativeTypeName("#define EXTENDED_STARTUPINFO_PRESENT 0x00080000")]
        public const int EXTENDED_STARTUPINFO_PRESENT = 0x00080000;

        [NativeTypeName("#define PROCESS_MODE_BACKGROUND_BEGIN 0x00100000")]
        public const int PROCESS_MODE_BACKGROUND_BEGIN = 0x00100000;

        [NativeTypeName("#define PROCESS_MODE_BACKGROUND_END 0x00200000")]
        public const int PROCESS_MODE_BACKGROUND_END = 0x00200000;

        [NativeTypeName("#define CREATE_SECURE_PROCESS 0x00400000")]
        public const int CREATE_SECURE_PROCESS = 0x00400000;

        [NativeTypeName("#define CREATE_BREAKAWAY_FROM_JOB 0x01000000")]
        public const int CREATE_BREAKAWAY_FROM_JOB = 0x01000000;

        [NativeTypeName("#define CREATE_PRESERVE_CODE_AUTHZ_LEVEL 0x02000000")]
        public const int CREATE_PRESERVE_CODE_AUTHZ_LEVEL = 0x02000000;

        [NativeTypeName("#define CREATE_DEFAULT_ERROR_MODE 0x04000000")]
        public const int CREATE_DEFAULT_ERROR_MODE = 0x04000000;

        [NativeTypeName("#define CREATE_NO_WINDOW 0x08000000")]
        public const int CREATE_NO_WINDOW = 0x08000000;

        [NativeTypeName("#define PROFILE_USER 0x10000000")]
        public const int PROFILE_USER = 0x10000000;

        [NativeTypeName("#define PROFILE_KERNEL 0x20000000")]
        public const int PROFILE_KERNEL = 0x20000000;

        [NativeTypeName("#define PROFILE_SERVER 0x40000000")]
        public const int PROFILE_SERVER = 0x40000000;

        [NativeTypeName("#define CREATE_IGNORE_SYSTEM_DEFAULT 0x80000000")]
        public const uint CREATE_IGNORE_SYSTEM_DEFAULT = 0x80000000;

        [NativeTypeName("#define STACK_SIZE_PARAM_IS_A_RESERVATION 0x00010000")]
        public const int STACK_SIZE_PARAM_IS_A_RESERVATION = 0x00010000;

        [NativeTypeName("#define THREAD_PRIORITY_LOWEST THREAD_BASE_PRIORITY_MIN")]
        public const int THREAD_PRIORITY_LOWEST = (-2);

        [NativeTypeName("#define THREAD_PRIORITY_BELOW_NORMAL (THREAD_PRIORITY_LOWEST+1)")]
        public const int THREAD_PRIORITY_BELOW_NORMAL = ((-2) + 1);

        [NativeTypeName("#define THREAD_PRIORITY_NORMAL 0")]
        public const int THREAD_PRIORITY_NORMAL = 0;

        [NativeTypeName("#define THREAD_PRIORITY_HIGHEST THREAD_BASE_PRIORITY_MAX")]
        public const int THREAD_PRIORITY_HIGHEST = 2;

        [NativeTypeName("#define THREAD_PRIORITY_ABOVE_NORMAL (THREAD_PRIORITY_HIGHEST-1)")]
        public const int THREAD_PRIORITY_ABOVE_NORMAL = (2 - 1);

        [NativeTypeName("#define THREAD_PRIORITY_ERROR_RETURN (MAXLONG)")]
        public const int THREAD_PRIORITY_ERROR_RETURN = (0x7fffffff);

        [NativeTypeName("#define THREAD_PRIORITY_TIME_CRITICAL THREAD_BASE_PRIORITY_LOWRT")]
        public const int THREAD_PRIORITY_TIME_CRITICAL = 15;

        [NativeTypeName("#define THREAD_PRIORITY_IDLE THREAD_BASE_PRIORITY_IDLE")]
        public const int THREAD_PRIORITY_IDLE = (-15);

        [NativeTypeName("#define THREAD_MODE_BACKGROUND_BEGIN 0x00010000")]
        public const int THREAD_MODE_BACKGROUND_BEGIN = 0x00010000;

        [NativeTypeName("#define THREAD_MODE_BACKGROUND_END 0x00020000")]
        public const int THREAD_MODE_BACKGROUND_END = 0x00020000;

        [NativeTypeName("#define VOLUME_NAME_DOS 0x0")]
        public const int VOLUME_NAME_DOS = 0x0;

        [NativeTypeName("#define VOLUME_NAME_GUID 0x1")]
        public const int VOLUME_NAME_GUID = 0x1;

        [NativeTypeName("#define VOLUME_NAME_NT 0x2")]
        public const int VOLUME_NAME_NT = 0x2;

        [NativeTypeName("#define VOLUME_NAME_NONE 0x4")]
        public const int VOLUME_NAME_NONE = 0x4;

        [NativeTypeName("#define FILE_NAME_NORMALIZED 0x0")]
        public const int FILE_NAME_NORMALIZED = 0x0;

        [NativeTypeName("#define FILE_NAME_OPENED 0x8")]
        public const int FILE_NAME_OPENED = 0x8;

        [NativeTypeName("#define DRIVE_UNKNOWN 0")]
        public const int DRIVE_UNKNOWN = 0;

        [NativeTypeName("#define DRIVE_NO_ROOT_DIR 1")]
        public const int DRIVE_NO_ROOT_DIR = 1;

        [NativeTypeName("#define DRIVE_REMOVABLE 2")]
        public const int DRIVE_REMOVABLE = 2;

        [NativeTypeName("#define DRIVE_FIXED 3")]
        public const int DRIVE_FIXED = 3;

        [NativeTypeName("#define DRIVE_REMOTE 4")]
        public const int DRIVE_REMOTE = 4;

        [NativeTypeName("#define DRIVE_CDROM 5")]
        public const int DRIVE_CDROM = 5;

        [NativeTypeName("#define DRIVE_RAMDISK 6")]
        public const int DRIVE_RAMDISK = 6;

        [NativeTypeName("#define FILE_TYPE_UNKNOWN 0x0000")]
        public const int FILE_TYPE_UNKNOWN = 0x0000;

        [NativeTypeName("#define FILE_TYPE_DISK 0x0001")]
        public const int FILE_TYPE_DISK = 0x0001;

        [NativeTypeName("#define FILE_TYPE_CHAR 0x0002")]
        public const int FILE_TYPE_CHAR = 0x0002;

        [NativeTypeName("#define FILE_TYPE_PIPE 0x0003")]
        public const int FILE_TYPE_PIPE = 0x0003;

        [NativeTypeName("#define FILE_TYPE_REMOTE 0x8000")]
        public const int FILE_TYPE_REMOTE = 0x8000;

        [NativeTypeName("#define STD_INPUT_HANDLE ((DWORD)-10)")]
        public const uint STD_INPUT_HANDLE = unchecked((uint)(-10));

        [NativeTypeName("#define STD_OUTPUT_HANDLE ((DWORD)-11)")]
        public const uint STD_OUTPUT_HANDLE = unchecked((uint)(-11));

        [NativeTypeName("#define STD_ERROR_HANDLE ((DWORD)-12)")]
        public const uint STD_ERROR_HANDLE = unchecked((uint)(-12));

        [NativeTypeName("#define NOPARITY 0")]
        public const int NOPARITY = 0;

        [NativeTypeName("#define ODDPARITY 1")]
        public const int ODDPARITY = 1;

        [NativeTypeName("#define EVENPARITY 2")]
        public const int EVENPARITY = 2;

        [NativeTypeName("#define MARKPARITY 3")]
        public const int MARKPARITY = 3;

        [NativeTypeName("#define SPACEPARITY 4")]
        public const int SPACEPARITY = 4;

        [NativeTypeName("#define ONESTOPBIT 0")]
        public const int ONESTOPBIT = 0;

        [NativeTypeName("#define ONE5STOPBITS 1")]
        public const int ONE5STOPBITS = 1;

        [NativeTypeName("#define TWOSTOPBITS 2")]
        public const int TWOSTOPBITS = 2;

        [NativeTypeName("#define IGNORE 0")]
        public const int IGNORE = 0;

        [NativeTypeName("#define INFINITE 0xFFFFFFFF")]
        public const uint INFINITE = 0xFFFFFFFF;

        [NativeTypeName("#define CBR_110 110")]
        public const int CBR_110 = 110;

        [NativeTypeName("#define CBR_300 300")]
        public const int CBR_300 = 300;

        [NativeTypeName("#define CBR_600 600")]
        public const int CBR_600 = 600;

        [NativeTypeName("#define CBR_1200 1200")]
        public const int CBR_1200 = 1200;

        [NativeTypeName("#define CBR_2400 2400")]
        public const int CBR_2400 = 2400;

        [NativeTypeName("#define CBR_4800 4800")]
        public const int CBR_4800 = 4800;

        [NativeTypeName("#define CBR_9600 9600")]
        public const int CBR_9600 = 9600;

        [NativeTypeName("#define CBR_14400 14400")]
        public const int CBR_14400 = 14400;

        [NativeTypeName("#define CBR_19200 19200")]
        public const int CBR_19200 = 19200;

        [NativeTypeName("#define CBR_38400 38400")]
        public const int CBR_38400 = 38400;

        [NativeTypeName("#define CBR_56000 56000")]
        public const int CBR_56000 = 56000;

        [NativeTypeName("#define CBR_57600 57600")]
        public const int CBR_57600 = 57600;

        [NativeTypeName("#define CBR_115200 115200")]
        public const int CBR_115200 = 115200;

        [NativeTypeName("#define CBR_128000 128000")]
        public const int CBR_128000 = 128000;

        [NativeTypeName("#define CBR_256000 256000")]
        public const int CBR_256000 = 256000;

        [NativeTypeName("#define CE_RXOVER 0x0001")]
        public const int CE_RXOVER = 0x0001;

        [NativeTypeName("#define CE_OVERRUN 0x0002")]
        public const int CE_OVERRUN = 0x0002;

        [NativeTypeName("#define CE_RXPARITY 0x0004")]
        public const int CE_RXPARITY = 0x0004;

        [NativeTypeName("#define CE_FRAME 0x0008")]
        public const int CE_FRAME = 0x0008;

        [NativeTypeName("#define CE_BREAK 0x0010")]
        public const int CE_BREAK = 0x0010;

        [NativeTypeName("#define CE_TXFULL 0x0100")]
        public const int CE_TXFULL = 0x0100;

        [NativeTypeName("#define CE_PTO 0x0200")]
        public const int CE_PTO = 0x0200;

        [NativeTypeName("#define CE_IOE 0x0400")]
        public const int CE_IOE = 0x0400;

        [NativeTypeName("#define CE_DNS 0x0800")]
        public const int CE_DNS = 0x0800;

        [NativeTypeName("#define CE_OOP 0x1000")]
        public const int CE_OOP = 0x1000;

        [NativeTypeName("#define CE_MODE 0x8000")]
        public const int CE_MODE = 0x8000;

        [NativeTypeName("#define IE_BADID (-1)")]
        public const int IE_BADID = (-1);

        [NativeTypeName("#define IE_OPEN (-2)")]
        public const int IE_OPEN = (-2);

        [NativeTypeName("#define IE_NOPEN (-3)")]
        public const int IE_NOPEN = (-3);

        [NativeTypeName("#define IE_MEMORY (-4)")]
        public const int IE_MEMORY = (-4);

        [NativeTypeName("#define IE_DEFAULT (-5)")]
        public const int IE_DEFAULT = (-5);

        [NativeTypeName("#define IE_HARDWARE (-10)")]
        public const int IE_HARDWARE = (-10);

        [NativeTypeName("#define IE_BYTESIZE (-11)")]
        public const int IE_BYTESIZE = (-11);

        [NativeTypeName("#define IE_BAUDRATE (-12)")]
        public const int IE_BAUDRATE = (-12);

        [NativeTypeName("#define EV_RXCHAR 0x0001")]
        public const int EV_RXCHAR = 0x0001;

        [NativeTypeName("#define EV_RXFLAG 0x0002")]
        public const int EV_RXFLAG = 0x0002;

        [NativeTypeName("#define EV_TXEMPTY 0x0004")]
        public const int EV_TXEMPTY = 0x0004;

        [NativeTypeName("#define EV_CTS 0x0008")]
        public const int EV_CTS = 0x0008;

        [NativeTypeName("#define EV_DSR 0x0010")]
        public const int EV_DSR = 0x0010;

        [NativeTypeName("#define EV_RLSD 0x0020")]
        public const int EV_RLSD = 0x0020;

        [NativeTypeName("#define EV_BREAK 0x0040")]
        public const int EV_BREAK = 0x0040;

        [NativeTypeName("#define EV_ERR 0x0080")]
        public const int EV_ERR = 0x0080;

        [NativeTypeName("#define EV_RING 0x0100")]
        public const int EV_RING = 0x0100;

        [NativeTypeName("#define EV_PERR 0x0200")]
        public const int EV_PERR = 0x0200;

        [NativeTypeName("#define EV_RX80FULL 0x0400")]
        public const int EV_RX80FULL = 0x0400;

        [NativeTypeName("#define EV_EVENT1 0x0800")]
        public const int EV_EVENT1 = 0x0800;

        [NativeTypeName("#define EV_EVENT2 0x1000")]
        public const int EV_EVENT2 = 0x1000;

        [NativeTypeName("#define SETXOFF 1")]
        public const int SETXOFF = 1;

        [NativeTypeName("#define SETXON 2")]
        public const int SETXON = 2;

        [NativeTypeName("#define SETRTS 3")]
        public const int SETRTS = 3;

        [NativeTypeName("#define CLRRTS 4")]
        public const int CLRRTS = 4;

        [NativeTypeName("#define SETDTR 5")]
        public const int SETDTR = 5;

        [NativeTypeName("#define CLRDTR 6")]
        public const int CLRDTR = 6;

        [NativeTypeName("#define RESETDEV 7")]
        public const int RESETDEV = 7;

        [NativeTypeName("#define SETBREAK 8")]
        public const int SETBREAK = 8;

        [NativeTypeName("#define CLRBREAK 9")]
        public const int CLRBREAK = 9;

        [NativeTypeName("#define PURGE_TXABORT 0x0001")]
        public const int PURGE_TXABORT = 0x0001;

        [NativeTypeName("#define PURGE_RXABORT 0x0002")]
        public const int PURGE_RXABORT = 0x0002;

        [NativeTypeName("#define PURGE_TXCLEAR 0x0004")]
        public const int PURGE_TXCLEAR = 0x0004;

        [NativeTypeName("#define PURGE_RXCLEAR 0x0008")]
        public const int PURGE_RXCLEAR = 0x0008;

        [NativeTypeName("#define LPTx 0x80")]
        public const int LPTx = 0x80;

        [NativeTypeName("#define MS_CTS_ON ((DWORD)0x0010)")]
        public const uint MS_CTS_ON = ((uint)(0x0010));

        [NativeTypeName("#define MS_DSR_ON ((DWORD)0x0020)")]
        public const uint MS_DSR_ON = ((uint)(0x0020));

        [NativeTypeName("#define MS_RING_ON ((DWORD)0x0040)")]
        public const uint MS_RING_ON = ((uint)(0x0040));

        [NativeTypeName("#define MS_RLSD_ON ((DWORD)0x0080)")]
        public const uint MS_RLSD_ON = ((uint)(0x0080));

        [NativeTypeName("#define S_QUEUEEMPTY 0")]
        public const int S_QUEUEEMPTY = 0;

        [NativeTypeName("#define S_THRESHOLD 1")]
        public const int S_THRESHOLD = 1;

        [NativeTypeName("#define S_ALLTHRESHOLD 2")]
        public const int S_ALLTHRESHOLD = 2;

        [NativeTypeName("#define S_NORMAL 0")]
        public const int S_NORMAL = 0;

        [NativeTypeName("#define S_LEGATO 1")]
        public const int S_LEGATO = 1;

        [NativeTypeName("#define S_STACCATO 2")]
        public const int S_STACCATO = 2;

        [NativeTypeName("#define S_PERIOD512 0")]
        public const int S_PERIOD512 = 0;

        [NativeTypeName("#define S_PERIOD1024 1")]
        public const int S_PERIOD1024 = 1;

        [NativeTypeName("#define S_PERIOD2048 2")]
        public const int S_PERIOD2048 = 2;

        [NativeTypeName("#define S_PERIODVOICE 3")]
        public const int S_PERIODVOICE = 3;

        [NativeTypeName("#define S_WHITE512 4")]
        public const int S_WHITE512 = 4;

        [NativeTypeName("#define S_WHITE1024 5")]
        public const int S_WHITE1024 = 5;

        [NativeTypeName("#define S_WHITE2048 6")]
        public const int S_WHITE2048 = 6;

        [NativeTypeName("#define S_WHITEVOICE 7")]
        public const int S_WHITEVOICE = 7;

        [NativeTypeName("#define S_SERDVNA (-1)")]
        public const int S_SERDVNA = (-1);

        [NativeTypeName("#define S_SEROFM (-2)")]
        public const int S_SEROFM = (-2);

        [NativeTypeName("#define S_SERMACT (-3)")]
        public const int S_SERMACT = (-3);

        [NativeTypeName("#define S_SERQFUL (-4)")]
        public const int S_SERQFUL = (-4);

        [NativeTypeName("#define S_SERBDNT (-5)")]
        public const int S_SERBDNT = (-5);

        [NativeTypeName("#define S_SERDLN (-6)")]
        public const int S_SERDLN = (-6);

        [NativeTypeName("#define S_SERDCC (-7)")]
        public const int S_SERDCC = (-7);

        [NativeTypeName("#define S_SERDTP (-8)")]
        public const int S_SERDTP = (-8);

        [NativeTypeName("#define S_SERDVL (-9)")]
        public const int S_SERDVL = (-9);

        [NativeTypeName("#define S_SERDMD (-10)")]
        public const int S_SERDMD = (-10);

        [NativeTypeName("#define S_SERDSH (-11)")]
        public const int S_SERDSH = (-11);

        [NativeTypeName("#define S_SERDPT (-12)")]
        public const int S_SERDPT = (-12);

        [NativeTypeName("#define S_SERDFQ (-13)")]
        public const int S_SERDFQ = (-13);

        [NativeTypeName("#define S_SERDDR (-14)")]
        public const int S_SERDDR = (-14);

        [NativeTypeName("#define S_SERDSR (-15)")]
        public const int S_SERDSR = (-15);

        [NativeTypeName("#define S_SERDST (-16)")]
        public const int S_SERDST = (-16);

        [NativeTypeName("#define NMPWAIT_WAIT_FOREVER 0xffffffff")]
        public const uint NMPWAIT_WAIT_FOREVER = 0xffffffff;

        [NativeTypeName("#define NMPWAIT_NOWAIT 0x00000001")]
        public const int NMPWAIT_NOWAIT = 0x00000001;

        [NativeTypeName("#define NMPWAIT_USE_DEFAULT_WAIT 0x00000000")]
        public const int NMPWAIT_USE_DEFAULT_WAIT = 0x00000000;

        [NativeTypeName("#define FS_CASE_IS_PRESERVED FILE_CASE_PRESERVED_NAMES")]
        public const int FS_CASE_IS_PRESERVED = 0x00000002;

        [NativeTypeName("#define FS_CASE_SENSITIVE FILE_CASE_SENSITIVE_SEARCH")]
        public const int FS_CASE_SENSITIVE = 0x00000001;

        [NativeTypeName("#define FS_UNICODE_STORED_ON_DISK FILE_UNICODE_ON_DISK")]
        public const int FS_UNICODE_STORED_ON_DISK = 0x00000004;

        [NativeTypeName("#define FS_PERSISTENT_ACLS FILE_PERSISTENT_ACLS")]
        public const int FS_PERSISTENT_ACLS = 0x00000008;

        [NativeTypeName("#define FS_VOL_IS_COMPRESSED FILE_VOLUME_IS_COMPRESSED")]
        public const int FS_VOL_IS_COMPRESSED = 0x00008000;

        [NativeTypeName("#define FS_FILE_COMPRESSION FILE_FILE_COMPRESSION")]
        public const int FS_FILE_COMPRESSION = 0x00000010;

        [NativeTypeName("#define FS_FILE_ENCRYPTION FILE_SUPPORTS_ENCRYPTION")]
        public const int FS_FILE_ENCRYPTION = 0x00020000;

        [NativeTypeName("#define OF_READ 0x00000000")]
        public const int OF_READ = 0x00000000;

        [NativeTypeName("#define OF_WRITE 0x00000001")]
        public const int OF_WRITE = 0x00000001;

        [NativeTypeName("#define OF_READWRITE 0x00000002")]
        public const int OF_READWRITE = 0x00000002;

        [NativeTypeName("#define OF_SHARE_COMPAT 0x00000000")]
        public const int OF_SHARE_COMPAT = 0x00000000;

        [NativeTypeName("#define OF_SHARE_EXCLUSIVE 0x00000010")]
        public const int OF_SHARE_EXCLUSIVE = 0x00000010;

        [NativeTypeName("#define OF_SHARE_DENY_WRITE 0x00000020")]
        public const int OF_SHARE_DENY_WRITE = 0x00000020;

        [NativeTypeName("#define OF_SHARE_DENY_READ 0x00000030")]
        public const int OF_SHARE_DENY_READ = 0x00000030;

        [NativeTypeName("#define OF_SHARE_DENY_NONE 0x00000040")]
        public const int OF_SHARE_DENY_NONE = 0x00000040;

        [NativeTypeName("#define OF_PARSE 0x00000100")]
        public const int OF_PARSE = 0x00000100;

        [NativeTypeName("#define OF_DELETE 0x00000200")]
        public const int OF_DELETE = 0x00000200;

        [NativeTypeName("#define OF_VERIFY 0x00000400")]
        public const int OF_VERIFY = 0x00000400;

        [NativeTypeName("#define OF_CANCEL 0x00000800")]
        public const int OF_CANCEL = 0x00000800;

        [NativeTypeName("#define OF_CREATE 0x00001000")]
        public const int OF_CREATE = 0x00001000;

        [NativeTypeName("#define OF_PROMPT 0x00002000")]
        public const int OF_PROMPT = 0x00002000;

        [NativeTypeName("#define OF_EXIST 0x00004000")]
        public const int OF_EXIST = 0x00004000;

        [NativeTypeName("#define OF_REOPEN 0x00008000")]
        public const int OF_REOPEN = 0x00008000;

        [NativeTypeName("#define OFS_MAXPATHNAME 128")]
        public const int OFS_MAXPATHNAME = 128;

        [NativeTypeName("#define MAXINTATOM 0xC000")]
        public const int MAXINTATOM = 0xC000;

        [NativeTypeName("#define INVALID_ATOM ((ATOM)0)")]
        public const ushort INVALID_ATOM = ((ushort)(0));

        [NativeTypeName("#define SCS_32BIT_BINARY 0")]
        public const int SCS_32BIT_BINARY = 0;

        [NativeTypeName("#define SCS_DOS_BINARY 1")]
        public const int SCS_DOS_BINARY = 1;

        [NativeTypeName("#define SCS_WOW_BINARY 2")]
        public const int SCS_WOW_BINARY = 2;

        [NativeTypeName("#define SCS_PIF_BINARY 3")]
        public const int SCS_PIF_BINARY = 3;

        [NativeTypeName("#define SCS_POSIX_BINARY 4")]
        public const int SCS_POSIX_BINARY = 4;

        [NativeTypeName("#define SCS_OS216_BINARY 5")]
        public const int SCS_OS216_BINARY = 5;

        [NativeTypeName("#define SCS_64BIT_BINARY 6")]
        public const int SCS_64BIT_BINARY = 6;

        [NativeTypeName("#define SCS_THIS_PLATFORM_BINARY SCS_32BIT_BINARY")]
        public const int SCS_THIS_PLATFORM_BINARY = 0;

        [NativeTypeName("#define GetBinaryType GetBinaryTypeW")]
        public static delegate*<ushort*, uint*, int> GetBinaryType => &GetBinaryTypeW;

        [NativeTypeName("#define GetLongPathNameTransacted GetLongPathNameTransactedW")]
        public static delegate*<ushort*, ushort*, uint, IntPtr, uint> GetLongPathNameTransacted => &GetLongPathNameTransactedW;

        [NativeTypeName("#define FIBER_FLAG_FLOAT_SWITCH 0x1")]
        public const int FIBER_FLAG_FLOAT_SWITCH = 0x1;

        [NativeTypeName("#define UMS_VERSION RTL_UMS_VERSION")]
        public const int UMS_VERSION = (0x0100);

        [NativeTypeName("#define PROCESS_DEP_ENABLE 0x00000001")]
        public const int PROCESS_DEP_ENABLE = 0x00000001;

        [NativeTypeName("#define PROCESS_DEP_DISABLE_ATL_THUNK_EMULATION 0x00000002")]
        public const int PROCESS_DEP_DISABLE_ATL_THUNK_EMULATION = 0x00000002;

        [NativeTypeName("#define FILE_SKIP_COMPLETION_PORT_ON_SUCCESS 0x1")]
        public const int FILE_SKIP_COMPLETION_PORT_ON_SUCCESS = 0x1;

        [NativeTypeName("#define FILE_SKIP_SET_EVENT_ON_HANDLE 0x2")]
        public const int FILE_SKIP_SET_EVENT_ON_HANDLE = 0x2;

        [NativeTypeName("#define SEM_FAILCRITICALERRORS 0x0001")]
        public const int SEM_FAILCRITICALERRORS = 0x0001;

        [NativeTypeName("#define SEM_NOGPFAULTERRORBOX 0x0002")]
        public const int SEM_NOGPFAULTERRORBOX = 0x0002;

        [NativeTypeName("#define SEM_NOALIGNMENTFAULTEXCEPT 0x0004")]
        public const int SEM_NOALIGNMENTFAULTEXCEPT = 0x0004;

        [NativeTypeName("#define SEM_NOOPENFILEERRORBOX 0x8000")]
        public const int SEM_NOOPENFILEERRORBOX = 0x8000;

        [NativeTypeName("#define CRITICAL_SECTION_NO_DEBUG_INFO RTL_CRITICAL_SECTION_FLAG_NO_DEBUG_INFO")]
        public const int CRITICAL_SECTION_NO_DEBUG_INFO = 0x01000000;

        [NativeTypeName("#define SetFileShortName SetFileShortNameW")]
        public static delegate*<IntPtr, ushort*, int> SetFileShortName => &SetFileShortNameW;

        [NativeTypeName("#define HANDLE_FLAG_INHERIT 0x00000001")]
        public const int HANDLE_FLAG_INHERIT = 0x00000001;

        [NativeTypeName("#define HANDLE_FLAG_PROTECT_FROM_CLOSE 0x00000002")]
        public const int HANDLE_FLAG_PROTECT_FROM_CLOSE = 0x00000002;

        [NativeTypeName("#define HINSTANCE_ERROR 32")]
        public const int HINSTANCE_ERROR = 32;

        [NativeTypeName("#define GET_TAPE_MEDIA_INFORMATION 0")]
        public const int GET_TAPE_MEDIA_INFORMATION = 0;

        [NativeTypeName("#define GET_TAPE_DRIVE_INFORMATION 1")]
        public const int GET_TAPE_DRIVE_INFORMATION = 1;

        [NativeTypeName("#define SET_TAPE_MEDIA_INFORMATION 0")]
        public const int SET_TAPE_MEDIA_INFORMATION = 0;

        [NativeTypeName("#define SET_TAPE_DRIVE_INFORMATION 1")]
        public const int SET_TAPE_DRIVE_INFORMATION = 1;

        [NativeTypeName("#define FORMAT_MESSAGE_ALLOCATE_BUFFER 0x00000100")]
        public const int FORMAT_MESSAGE_ALLOCATE_BUFFER = 0x00000100;

        [NativeTypeName("#define FormatMessage FormatMessageW")]
        public static delegate*<uint, void*, uint, uint, ushort*, uint, sbyte**, uint> FormatMessage => &FormatMessageW;

        [NativeTypeName("#define FORMAT_MESSAGE_IGNORE_INSERTS 0x00000200")]
        public const int FORMAT_MESSAGE_IGNORE_INSERTS = 0x00000200;

        [NativeTypeName("#define FORMAT_MESSAGE_FROM_STRING 0x00000400")]
        public const int FORMAT_MESSAGE_FROM_STRING = 0x00000400;

        [NativeTypeName("#define FORMAT_MESSAGE_FROM_HMODULE 0x00000800")]
        public const int FORMAT_MESSAGE_FROM_HMODULE = 0x00000800;

        [NativeTypeName("#define FORMAT_MESSAGE_FROM_SYSTEM 0x00001000")]
        public const int FORMAT_MESSAGE_FROM_SYSTEM = 0x00001000;

        [NativeTypeName("#define FORMAT_MESSAGE_ARGUMENT_ARRAY 0x00002000")]
        public const int FORMAT_MESSAGE_ARGUMENT_ARRAY = 0x00002000;

        [NativeTypeName("#define FORMAT_MESSAGE_MAX_WIDTH_MASK 0x000000FF")]
        public const int FORMAT_MESSAGE_MAX_WIDTH_MASK = 0x000000FF;

        [NativeTypeName("#define CreateMailslot CreateMailslotW")]
        public static delegate*<ushort*, uint, uint, SECURITY_ATTRIBUTES*, IntPtr> CreateMailslot => &CreateMailslotW;

        [NativeTypeName("#define EncryptFile EncryptFileW")]
        public static delegate*<ushort*, int> EncryptFile => &EncryptFileW;

        [NativeTypeName("#define DecryptFile DecryptFileW")]
        public static delegate*<ushort*, uint, int> DecryptFile => &DecryptFileW;

        [NativeTypeName("#define FILE_ENCRYPTABLE 0")]
        public const int FILE_ENCRYPTABLE = 0;

        [NativeTypeName("#define FILE_IS_ENCRYPTED 1")]
        public const int FILE_IS_ENCRYPTED = 1;

        [NativeTypeName("#define FILE_SYSTEM_ATTR 2")]
        public const int FILE_SYSTEM_ATTR = 2;

        [NativeTypeName("#define FILE_ROOT_DIR 3")]
        public const int FILE_ROOT_DIR = 3;

        [NativeTypeName("#define FILE_SYSTEM_DIR 4")]
        public const int FILE_SYSTEM_DIR = 4;

        [NativeTypeName("#define FILE_UNKNOWN 5")]
        public const int FILE_UNKNOWN = 5;

        [NativeTypeName("#define FILE_SYSTEM_NOT_SUPPORT 6")]
        public const int FILE_SYSTEM_NOT_SUPPORT = 6;

        [NativeTypeName("#define FILE_USER_DISALLOWED 7")]
        public const int FILE_USER_DISALLOWED = 7;

        [NativeTypeName("#define FILE_READ_ONLY 8")]
        public const int FILE_READ_ONLY = 8;

        [NativeTypeName("#define FILE_DIR_DISALLOWED 9")]
        public const int FILE_DIR_DISALLOWED = 9;

        [NativeTypeName("#define FileEncryptionStatus FileEncryptionStatusW")]
        public static delegate*<ushort*, uint*, int> FileEncryptionStatus => &FileEncryptionStatusW;

        [NativeTypeName("#define EFS_USE_RECOVERY_KEYS (0x1)")]
        public const int EFS_USE_RECOVERY_KEYS = (0x1);

        [NativeTypeName("#define CREATE_FOR_IMPORT (1)")]
        public const int CREATE_FOR_IMPORT = (1);

        [NativeTypeName("#define CREATE_FOR_DIR (2)")]
        public const int CREATE_FOR_DIR = (2);

        [NativeTypeName("#define OVERWRITE_HIDDEN (4)")]
        public const int OVERWRITE_HIDDEN = (4);

        [NativeTypeName("#define EFSRPC_SECURE_ONLY (8)")]
        public const int EFSRPC_SECURE_ONLY = (8);

        [NativeTypeName("#define EFS_DROP_ALTERNATE_STREAMS (0x10)")]
        public const int EFS_DROP_ALTERNATE_STREAMS = (0x10);

        [NativeTypeName("#define OpenEncryptedFileRaw OpenEncryptedFileRawW")]
        public static delegate*<ushort*, uint, void**, uint> OpenEncryptedFileRaw => &OpenEncryptedFileRawW;

        [NativeTypeName("#define lstrcmp lstrcmpW")]
        public static delegate*<ushort*, ushort*, int> lstrcmp => &lstrcmpW;

        [NativeTypeName("#define lstrcmpi lstrcmpiW")]
        public static delegate*<ushort*, ushort*, int> lstrcmpi => &lstrcmpiW;

        [NativeTypeName("#define lstrcpyn lstrcpynW")]
        public static delegate*<ushort*, ushort*, int, ushort*> lstrcpyn => &lstrcpynW;

        [NativeTypeName("#define lstrcpy lstrcpyW")]
        public static delegate*<ushort*, ushort*, ushort*> lstrcpy => &lstrcpyW;

        [NativeTypeName("#define lstrcat lstrcatW")]
        public static delegate*<ushort*, ushort*, ushort*> lstrcat => &lstrcatW;

        [NativeTypeName("#define lstrlen lstrlenW")]
        public static delegate*<ushort*, int> lstrlen => &lstrlenW;

        [NativeTypeName("#define BACKUP_INVALID 0x00000000")]
        public const int BACKUP_INVALID = 0x00000000;

        [NativeTypeName("#define BACKUP_DATA 0x00000001")]
        public const int BACKUP_DATA = 0x00000001;

        [NativeTypeName("#define BACKUP_EA_DATA 0x00000002")]
        public const int BACKUP_EA_DATA = 0x00000002;

        [NativeTypeName("#define BACKUP_SECURITY_DATA 0x00000003")]
        public const int BACKUP_SECURITY_DATA = 0x00000003;

        [NativeTypeName("#define BACKUP_ALTERNATE_DATA 0x00000004")]
        public const int BACKUP_ALTERNATE_DATA = 0x00000004;

        [NativeTypeName("#define BACKUP_LINK 0x00000005")]
        public const int BACKUP_LINK = 0x00000005;

        [NativeTypeName("#define BACKUP_PROPERTY_DATA 0x00000006")]
        public const int BACKUP_PROPERTY_DATA = 0x00000006;

        [NativeTypeName("#define BACKUP_OBJECT_ID 0x00000007")]
        public const int BACKUP_OBJECT_ID = 0x00000007;

        [NativeTypeName("#define BACKUP_REPARSE_DATA 0x00000008")]
        public const int BACKUP_REPARSE_DATA = 0x00000008;

        [NativeTypeName("#define BACKUP_SPARSE_BLOCK 0x00000009")]
        public const int BACKUP_SPARSE_BLOCK = 0x00000009;

        [NativeTypeName("#define BACKUP_TXFS_DATA 0x0000000a")]
        public const int BACKUP_TXFS_DATA = 0x0000000a;

        [NativeTypeName("#define BACKUP_GHOSTED_FILE_EXTENTS 0x0000000b")]
        public const int BACKUP_GHOSTED_FILE_EXTENTS = 0x0000000b;

        [NativeTypeName("#define STREAM_NORMAL_ATTRIBUTE 0x00000000")]
        public const int STREAM_NORMAL_ATTRIBUTE = 0x00000000;

        [NativeTypeName("#define STREAM_MODIFIED_WHEN_READ 0x00000001")]
        public const int STREAM_MODIFIED_WHEN_READ = 0x00000001;

        [NativeTypeName("#define STREAM_CONTAINS_SECURITY 0x00000002")]
        public const int STREAM_CONTAINS_SECURITY = 0x00000002;

        [NativeTypeName("#define STREAM_CONTAINS_PROPERTIES 0x00000004")]
        public const int STREAM_CONTAINS_PROPERTIES = 0x00000004;

        [NativeTypeName("#define STREAM_SPARSE_ATTRIBUTE 0x00000008")]
        public const int STREAM_SPARSE_ATTRIBUTE = 0x00000008;

        [NativeTypeName("#define STREAM_CONTAINS_GHOSTED_FILE_EXTENTS 0x00000010")]
        public const int STREAM_CONTAINS_GHOSTED_FILE_EXTENTS = 0x00000010;

        [NativeTypeName("#define STARTF_USESHOWWINDOW 0x00000001")]
        public const int STARTF_USESHOWWINDOW = 0x00000001;

        [NativeTypeName("#define STARTF_USESIZE 0x00000002")]
        public const int STARTF_USESIZE = 0x00000002;

        [NativeTypeName("#define STARTF_USEPOSITION 0x00000004")]
        public const int STARTF_USEPOSITION = 0x00000004;

        [NativeTypeName("#define STARTF_USECOUNTCHARS 0x00000008")]
        public const int STARTF_USECOUNTCHARS = 0x00000008;

        [NativeTypeName("#define STARTF_USEFILLATTRIBUTE 0x00000010")]
        public const int STARTF_USEFILLATTRIBUTE = 0x00000010;

        [NativeTypeName("#define STARTF_RUNFULLSCREEN 0x00000020")]
        public const int STARTF_RUNFULLSCREEN = 0x00000020;

        [NativeTypeName("#define STARTF_FORCEONFEEDBACK 0x00000040")]
        public const int STARTF_FORCEONFEEDBACK = 0x00000040;

        [NativeTypeName("#define STARTF_FORCEOFFFEEDBACK 0x00000080")]
        public const int STARTF_FORCEOFFFEEDBACK = 0x00000080;

        [NativeTypeName("#define STARTF_USESTDHANDLES 0x00000100")]
        public const int STARTF_USESTDHANDLES = 0x00000100;

        [NativeTypeName("#define STARTF_USEHOTKEY 0x00000200")]
        public const int STARTF_USEHOTKEY = 0x00000200;

        [NativeTypeName("#define STARTF_TITLEISLINKNAME 0x00000800")]
        public const int STARTF_TITLEISLINKNAME = 0x00000800;

        [NativeTypeName("#define STARTF_TITLEISAPPID 0x00001000")]
        public const int STARTF_TITLEISAPPID = 0x00001000;

        [NativeTypeName("#define STARTF_PREVENTPINNING 0x00002000")]
        public const int STARTF_PREVENTPINNING = 0x00002000;

        [NativeTypeName("#define STARTF_UNTRUSTEDSOURCE 0x00008000")]
        public const int STARTF_UNTRUSTEDSOURCE = 0x00008000;

        [NativeTypeName("#define STARTF_HOLOGRAPHIC 0x00040000")]
        public const int STARTF_HOLOGRAPHIC = 0x00040000;

        [NativeTypeName("#define SHUTDOWN_NORETRY 0x00000001")]
        public const int SHUTDOWN_NORETRY = 0x00000001;

        [NativeTypeName("#define PROTECTION_LEVEL_WINTCB_LIGHT 0x00000000")]
        public const int PROTECTION_LEVEL_WINTCB_LIGHT = 0x00000000;

        [NativeTypeName("#define PROTECTION_LEVEL_WINDOWS 0x00000001")]
        public const int PROTECTION_LEVEL_WINDOWS = 0x00000001;

        [NativeTypeName("#define PROTECTION_LEVEL_WINDOWS_LIGHT 0x00000002")]
        public const int PROTECTION_LEVEL_WINDOWS_LIGHT = 0x00000002;

        [NativeTypeName("#define PROTECTION_LEVEL_ANTIMALWARE_LIGHT 0x00000003")]
        public const int PROTECTION_LEVEL_ANTIMALWARE_LIGHT = 0x00000003;

        [NativeTypeName("#define PROTECTION_LEVEL_LSA_LIGHT 0x00000004")]
        public const int PROTECTION_LEVEL_LSA_LIGHT = 0x00000004;

        [NativeTypeName("#define PROTECTION_LEVEL_WINTCB 0x00000005")]
        public const int PROTECTION_LEVEL_WINTCB = 0x00000005;

        [NativeTypeName("#define PROTECTION_LEVEL_CODEGEN_LIGHT 0x00000006")]
        public const int PROTECTION_LEVEL_CODEGEN_LIGHT = 0x00000006;

        [NativeTypeName("#define PROTECTION_LEVEL_AUTHENTICODE 0x00000007")]
        public const int PROTECTION_LEVEL_AUTHENTICODE = 0x00000007;

        [NativeTypeName("#define PROTECTION_LEVEL_PPL_APP 0x00000008")]
        public const int PROTECTION_LEVEL_PPL_APP = 0x00000008;

        [NativeTypeName("#define PROTECTION_LEVEL_SAME 0xFFFFFFFF")]
        public const uint PROTECTION_LEVEL_SAME = 0xFFFFFFFF;

        [NativeTypeName("#define PROTECTION_LEVEL_NONE 0xFFFFFFFE")]
        public const uint PROTECTION_LEVEL_NONE = 0xFFFFFFFE;

        [NativeTypeName("#define PROCESS_NAME_NATIVE 0x00000001")]
        public const int PROCESS_NAME_NATIVE = 0x00000001;

        [NativeTypeName("#define QueryFullProcessImageName QueryFullProcessImageNameW")]
        public static delegate*<IntPtr, uint, ushort*, uint*, int> QueryFullProcessImageName => &QueryFullProcessImageNameW;

        [NativeTypeName("#define PROC_THREAD_ATTRIBUTE_NUMBER 0x0000FFFF")]
        public const int PROC_THREAD_ATTRIBUTE_NUMBER = 0x0000FFFF;

        [NativeTypeName("#define PROC_THREAD_ATTRIBUTE_THREAD 0x00010000")]
        public const int PROC_THREAD_ATTRIBUTE_THREAD = 0x00010000;

        [NativeTypeName("#define PROC_THREAD_ATTRIBUTE_INPUT 0x00020000")]
        public const int PROC_THREAD_ATTRIBUTE_INPUT = 0x00020000;

        [NativeTypeName("#define PROC_THREAD_ATTRIBUTE_ADDITIVE 0x00040000")]
        public const int PROC_THREAD_ATTRIBUTE_ADDITIVE = 0x00040000;

        [NativeTypeName("#define PROC_THREAD_ATTRIBUTE_PARENT_PROCESS ProcThreadAttributeValue (ProcThreadAttributeParentProcess, FALSE, TRUE, FALSE)")]
        public const int PROC_THREAD_ATTRIBUTE_PARENT_PROCESS = (((int)(ProcThreadAttributeParentProcess) & 0x0000FFFF) | ((0 != 0) ? 0x00010000 : 0) | ((1 != 0) ? 0x00020000 : 0) | ((0 != 0) ? 0x00040000 : 0));

        [NativeTypeName("#define PROC_THREAD_ATTRIBUTE_HANDLE_LIST ProcThreadAttributeValue (ProcThreadAttributeHandleList, FALSE, TRUE, FALSE)")]
        public const int PROC_THREAD_ATTRIBUTE_HANDLE_LIST = (((int)(ProcThreadAttributeHandleList) & 0x0000FFFF) | ((0 != 0) ? 0x00010000 : 0) | ((1 != 0) ? 0x00020000 : 0) | ((0 != 0) ? 0x00040000 : 0));

        [NativeTypeName("#define PROC_THREAD_ATTRIBUTE_GROUP_AFFINITY ProcThreadAttributeValue (ProcThreadAttributeGroupAffinity, TRUE, TRUE, FALSE)")]
        public const int PROC_THREAD_ATTRIBUTE_GROUP_AFFINITY = (((int)(ProcThreadAttributeGroupAffinity) & 0x0000FFFF) | ((1 != 0) ? 0x00010000 : 0) | ((1 != 0) ? 0x00020000 : 0) | ((0 != 0) ? 0x00040000 : 0));

        [NativeTypeName("#define PROC_THREAD_ATTRIBUTE_PREFERRED_NODE ProcThreadAttributeValue (ProcThreadAttributePreferredNode, FALSE, TRUE, FALSE)")]
        public const int PROC_THREAD_ATTRIBUTE_PREFERRED_NODE = (((int)(ProcThreadAttributePreferredNode) & 0x0000FFFF) | ((0 != 0) ? 0x00010000 : 0) | ((1 != 0) ? 0x00020000 : 0) | ((0 != 0) ? 0x00040000 : 0));

        [NativeTypeName("#define PROC_THREAD_ATTRIBUTE_IDEAL_PROCESSOR ProcThreadAttributeValue (ProcThreadAttributeIdealProcessor, TRUE, TRUE, FALSE)")]
        public const int PROC_THREAD_ATTRIBUTE_IDEAL_PROCESSOR = (((int)(ProcThreadAttributeIdealProcessor) & 0x0000FFFF) | ((1 != 0) ? 0x00010000 : 0) | ((1 != 0) ? 0x00020000 : 0) | ((0 != 0) ? 0x00040000 : 0));

        [NativeTypeName("#define PROC_THREAD_ATTRIBUTE_UMS_THREAD ProcThreadAttributeValue (ProcThreadAttributeUmsThread, TRUE, TRUE, FALSE)")]
        public const int PROC_THREAD_ATTRIBUTE_UMS_THREAD = (((int)(ProcThreadAttributeUmsThread) & 0x0000FFFF) | ((1 != 0) ? 0x00010000 : 0) | ((1 != 0) ? 0x00020000 : 0) | ((0 != 0) ? 0x00040000 : 0));

        [NativeTypeName("#define PROC_THREAD_ATTRIBUTE_MITIGATION_POLICY ProcThreadAttributeValue (ProcThreadAttributeMitigationPolicy, FALSE, TRUE, FALSE)")]
        public const int PROC_THREAD_ATTRIBUTE_MITIGATION_POLICY = (((int)(ProcThreadAttributeMitigationPolicy) & 0x0000FFFF) | ((0 != 0) ? 0x00010000 : 0) | ((1 != 0) ? 0x00020000 : 0) | ((0 != 0) ? 0x00040000 : 0));

        [NativeTypeName("#define PROC_THREAD_ATTRIBUTE_SECURITY_CAPABILITIES ProcThreadAttributeValue (ProcThreadAttributeSecurityCapabilities, FALSE, TRUE, FALSE)")]
        public const int PROC_THREAD_ATTRIBUTE_SECURITY_CAPABILITIES = (((int)(ProcThreadAttributeSecurityCapabilities) & 0x0000FFFF) | ((0 != 0) ? 0x00010000 : 0) | ((1 != 0) ? 0x00020000 : 0) | ((0 != 0) ? 0x00040000 : 0));

        [NativeTypeName("#define PROC_THREAD_ATTRIBUTE_PROTECTION_LEVEL ProcThreadAttributeValue (ProcThreadAttributeProtectionLevel, FALSE, TRUE, FALSE)")]
        public const int PROC_THREAD_ATTRIBUTE_PROTECTION_LEVEL = (((int)(ProcThreadAttributeProtectionLevel) & 0x0000FFFF) | ((0 != 0) ? 0x00010000 : 0) | ((1 != 0) ? 0x00020000 : 0) | ((0 != 0) ? 0x00040000 : 0));

        [NativeTypeName("#define PROC_THREAD_ATTRIBUTE_PSEUDOCONSOLE ProcThreadAttributeValue (ProcThreadAttributePseudoConsole, FALSE, TRUE, FALSE)")]
        public const int PROC_THREAD_ATTRIBUTE_PSEUDOCONSOLE = (((int)(ProcThreadAttributePseudoConsole) & 0x0000FFFF) | ((0 != 0) ? 0x00010000 : 0) | ((1 != 0) ? 0x00020000 : 0) | ((0 != 0) ? 0x00040000 : 0));

        [NativeTypeName("#define PROC_THREAD_ATTRIBUTE_MACHINE_TYPE ProcThreadAttributeValue (ProcThreadAttributeMachineType, FALSE, TRUE, FALSE)")]
        public const int PROC_THREAD_ATTRIBUTE_MACHINE_TYPE = (((int)(ProcThreadAttributeMachineType) & 0x0000FFFF) | ((0 != 0) ? 0x00010000 : 0) | ((1 != 0) ? 0x00020000 : 0) | ((0 != 0) ? 0x00040000 : 0));

        [NativeTypeName("#define PROC_THREAD_ATTRIBUTE_ENABLE_OPTIONAL_XSTATE_FEATURES ProcThreadAttributeValue (ProcThreadAttributeEnableOptionalXStateFeatures, TRUE, TRUE, FALSE)")]
        public const int PROC_THREAD_ATTRIBUTE_ENABLE_OPTIONAL_XSTATE_FEATURES = (((int)(ProcThreadAttributeEnableOptionalXStateFeatures) & 0x0000FFFF) | ((1 != 0) ? 0x00010000 : 0) | ((1 != 0) ? 0x00020000 : 0) | ((0 != 0) ? 0x00040000 : 0));

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY_DEP_ENABLE 0x01")]
        public const int PROCESS_CREATION_MITIGATION_POLICY_DEP_ENABLE = 0x01;

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY_DEP_ATL_THUNK_ENABLE 0x02")]
        public const int PROCESS_CREATION_MITIGATION_POLICY_DEP_ATL_THUNK_ENABLE = 0x02;

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY_SEHOP_ENABLE 0x04")]
        public const int PROCESS_CREATION_MITIGATION_POLICY_SEHOP_ENABLE = 0x04;

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY_FORCE_RELOCATE_IMAGES_MASK (0x00000003 <<  8)")]
        public const int PROCESS_CREATION_MITIGATION_POLICY_FORCE_RELOCATE_IMAGES_MASK = (0x00000003 << 8);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY_FORCE_RELOCATE_IMAGES_DEFER (0x00000000 <<  8)")]
        public const int PROCESS_CREATION_MITIGATION_POLICY_FORCE_RELOCATE_IMAGES_DEFER = (0x00000000 << 8);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY_FORCE_RELOCATE_IMAGES_ALWAYS_ON (0x00000001 <<  8)")]
        public const int PROCESS_CREATION_MITIGATION_POLICY_FORCE_RELOCATE_IMAGES_ALWAYS_ON = (0x00000001 << 8);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY_FORCE_RELOCATE_IMAGES_ALWAYS_OFF (0x00000002 <<  8)")]
        public const int PROCESS_CREATION_MITIGATION_POLICY_FORCE_RELOCATE_IMAGES_ALWAYS_OFF = (0x00000002 << 8);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY_FORCE_RELOCATE_IMAGES_ALWAYS_ON_REQ_RELOCS (0x00000003 <<  8)")]
        public const int PROCESS_CREATION_MITIGATION_POLICY_FORCE_RELOCATE_IMAGES_ALWAYS_ON_REQ_RELOCS = (0x00000003 << 8);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY_HEAP_TERMINATE_MASK (0x00000003 << 12)")]
        public const int PROCESS_CREATION_MITIGATION_POLICY_HEAP_TERMINATE_MASK = (0x00000003 << 12);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY_HEAP_TERMINATE_DEFER (0x00000000 << 12)")]
        public const int PROCESS_CREATION_MITIGATION_POLICY_HEAP_TERMINATE_DEFER = (0x00000000 << 12);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY_HEAP_TERMINATE_ALWAYS_ON (0x00000001 << 12)")]
        public const int PROCESS_CREATION_MITIGATION_POLICY_HEAP_TERMINATE_ALWAYS_ON = (0x00000001 << 12);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY_HEAP_TERMINATE_ALWAYS_OFF (0x00000002 << 12)")]
        public const int PROCESS_CREATION_MITIGATION_POLICY_HEAP_TERMINATE_ALWAYS_OFF = (0x00000002 << 12);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY_HEAP_TERMINATE_RESERVED (0x00000003 << 12)")]
        public const int PROCESS_CREATION_MITIGATION_POLICY_HEAP_TERMINATE_RESERVED = (0x00000003 << 12);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY_BOTTOM_UP_ASLR_MASK (0x00000003 << 16)")]
        public const int PROCESS_CREATION_MITIGATION_POLICY_BOTTOM_UP_ASLR_MASK = (0x00000003 << 16);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY_BOTTOM_UP_ASLR_DEFER (0x00000000 << 16)")]
        public const int PROCESS_CREATION_MITIGATION_POLICY_BOTTOM_UP_ASLR_DEFER = (0x00000000 << 16);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY_BOTTOM_UP_ASLR_ALWAYS_ON (0x00000001 << 16)")]
        public const int PROCESS_CREATION_MITIGATION_POLICY_BOTTOM_UP_ASLR_ALWAYS_ON = (0x00000001 << 16);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY_BOTTOM_UP_ASLR_ALWAYS_OFF (0x00000002 << 16)")]
        public const int PROCESS_CREATION_MITIGATION_POLICY_BOTTOM_UP_ASLR_ALWAYS_OFF = (0x00000002 << 16);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY_BOTTOM_UP_ASLR_RESERVED (0x00000003 << 16)")]
        public const int PROCESS_CREATION_MITIGATION_POLICY_BOTTOM_UP_ASLR_RESERVED = (0x00000003 << 16);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY_HIGH_ENTROPY_ASLR_MASK (0x00000003 << 20)")]
        public const int PROCESS_CREATION_MITIGATION_POLICY_HIGH_ENTROPY_ASLR_MASK = (0x00000003 << 20);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY_HIGH_ENTROPY_ASLR_DEFER (0x00000000 << 20)")]
        public const int PROCESS_CREATION_MITIGATION_POLICY_HIGH_ENTROPY_ASLR_DEFER = (0x00000000 << 20);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY_HIGH_ENTROPY_ASLR_ALWAYS_ON (0x00000001 << 20)")]
        public const int PROCESS_CREATION_MITIGATION_POLICY_HIGH_ENTROPY_ASLR_ALWAYS_ON = (0x00000001 << 20);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY_HIGH_ENTROPY_ASLR_ALWAYS_OFF (0x00000002 << 20)")]
        public const int PROCESS_CREATION_MITIGATION_POLICY_HIGH_ENTROPY_ASLR_ALWAYS_OFF = (0x00000002 << 20);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY_HIGH_ENTROPY_ASLR_RESERVED (0x00000003 << 20)")]
        public const int PROCESS_CREATION_MITIGATION_POLICY_HIGH_ENTROPY_ASLR_RESERVED = (0x00000003 << 20);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY_STRICT_HANDLE_CHECKS_MASK (0x00000003 << 24)")]
        public const int PROCESS_CREATION_MITIGATION_POLICY_STRICT_HANDLE_CHECKS_MASK = (0x00000003 << 24);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY_STRICT_HANDLE_CHECKS_DEFER (0x00000000 << 24)")]
        public const int PROCESS_CREATION_MITIGATION_POLICY_STRICT_HANDLE_CHECKS_DEFER = (0x00000000 << 24);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY_STRICT_HANDLE_CHECKS_ALWAYS_ON (0x00000001 << 24)")]
        public const int PROCESS_CREATION_MITIGATION_POLICY_STRICT_HANDLE_CHECKS_ALWAYS_ON = (0x00000001 << 24);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY_STRICT_HANDLE_CHECKS_ALWAYS_OFF (0x00000002 << 24)")]
        public const int PROCESS_CREATION_MITIGATION_POLICY_STRICT_HANDLE_CHECKS_ALWAYS_OFF = (0x00000002 << 24);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY_STRICT_HANDLE_CHECKS_RESERVED (0x00000003 << 24)")]
        public const int PROCESS_CREATION_MITIGATION_POLICY_STRICT_HANDLE_CHECKS_RESERVED = (0x00000003 << 24);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY_WIN32K_SYSTEM_CALL_DISABLE_MASK (0x00000003 << 28)")]
        public const int PROCESS_CREATION_MITIGATION_POLICY_WIN32K_SYSTEM_CALL_DISABLE_MASK = (0x00000003 << 28);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY_WIN32K_SYSTEM_CALL_DISABLE_DEFER (0x00000000 << 28)")]
        public const int PROCESS_CREATION_MITIGATION_POLICY_WIN32K_SYSTEM_CALL_DISABLE_DEFER = (0x00000000 << 28);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY_WIN32K_SYSTEM_CALL_DISABLE_ALWAYS_ON (0x00000001 << 28)")]
        public const int PROCESS_CREATION_MITIGATION_POLICY_WIN32K_SYSTEM_CALL_DISABLE_ALWAYS_ON = (0x00000001 << 28);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY_WIN32K_SYSTEM_CALL_DISABLE_ALWAYS_OFF (0x00000002 << 28)")]
        public const int PROCESS_CREATION_MITIGATION_POLICY_WIN32K_SYSTEM_CALL_DISABLE_ALWAYS_OFF = (0x00000002 << 28);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY_WIN32K_SYSTEM_CALL_DISABLE_RESERVED (0x00000003 << 28)")]
        public const int PROCESS_CREATION_MITIGATION_POLICY_WIN32K_SYSTEM_CALL_DISABLE_RESERVED = (0x00000003 << 28);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY_EXTENSION_POINT_DISABLE_MASK (0x00000003ui64 << 32)")]
        public const ulong PROCESS_CREATION_MITIGATION_POLICY_EXTENSION_POINT_DISABLE_MASK = (0x00000003UL << 32);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY_EXTENSION_POINT_DISABLE_DEFER (0x00000000ui64 << 32)")]
        public const ulong PROCESS_CREATION_MITIGATION_POLICY_EXTENSION_POINT_DISABLE_DEFER = (0x00000000UL << 32);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY_EXTENSION_POINT_DISABLE_ALWAYS_ON (0x00000001ui64 << 32)")]
        public const ulong PROCESS_CREATION_MITIGATION_POLICY_EXTENSION_POINT_DISABLE_ALWAYS_ON = (0x00000001UL << 32);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY_EXTENSION_POINT_DISABLE_ALWAYS_OFF (0x00000002ui64 << 32)")]
        public const ulong PROCESS_CREATION_MITIGATION_POLICY_EXTENSION_POINT_DISABLE_ALWAYS_OFF = (0x00000002UL << 32);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY_EXTENSION_POINT_DISABLE_RESERVED (0x00000003ui64 << 32)")]
        public const ulong PROCESS_CREATION_MITIGATION_POLICY_EXTENSION_POINT_DISABLE_RESERVED = (0x00000003UL << 32);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY_PROHIBIT_DYNAMIC_CODE_MASK (0x00000003ui64 << 36)")]
        public const ulong PROCESS_CREATION_MITIGATION_POLICY_PROHIBIT_DYNAMIC_CODE_MASK = (0x00000003UL << 36);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY_PROHIBIT_DYNAMIC_CODE_DEFER (0x00000000ui64 << 36)")]
        public const ulong PROCESS_CREATION_MITIGATION_POLICY_PROHIBIT_DYNAMIC_CODE_DEFER = (0x00000000UL << 36);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY_PROHIBIT_DYNAMIC_CODE_ALWAYS_ON (0x00000001ui64 << 36)")]
        public const ulong PROCESS_CREATION_MITIGATION_POLICY_PROHIBIT_DYNAMIC_CODE_ALWAYS_ON = (0x00000001UL << 36);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY_PROHIBIT_DYNAMIC_CODE_ALWAYS_OFF (0x00000002ui64 << 36)")]
        public const ulong PROCESS_CREATION_MITIGATION_POLICY_PROHIBIT_DYNAMIC_CODE_ALWAYS_OFF = (0x00000002UL << 36);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY_PROHIBIT_DYNAMIC_CODE_ALWAYS_ON_ALLOW_OPT_OUT (0x00000003ui64 << 36)")]
        public const ulong PROCESS_CREATION_MITIGATION_POLICY_PROHIBIT_DYNAMIC_CODE_ALWAYS_ON_ALLOW_OPT_OUT = (0x00000003UL << 36);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY_CONTROL_FLOW_GUARD_MASK (0x00000003ui64 << 40)")]
        public const ulong PROCESS_CREATION_MITIGATION_POLICY_CONTROL_FLOW_GUARD_MASK = (0x00000003UL << 40);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY_CONTROL_FLOW_GUARD_DEFER (0x00000000ui64 << 40)")]
        public const ulong PROCESS_CREATION_MITIGATION_POLICY_CONTROL_FLOW_GUARD_DEFER = (0x00000000UL << 40);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY_CONTROL_FLOW_GUARD_ALWAYS_ON (0x00000001ui64 << 40)")]
        public const ulong PROCESS_CREATION_MITIGATION_POLICY_CONTROL_FLOW_GUARD_ALWAYS_ON = (0x00000001UL << 40);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY_CONTROL_FLOW_GUARD_ALWAYS_OFF (0x00000002ui64 << 40)")]
        public const ulong PROCESS_CREATION_MITIGATION_POLICY_CONTROL_FLOW_GUARD_ALWAYS_OFF = (0x00000002UL << 40);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY_CONTROL_FLOW_GUARD_EXPORT_SUPPRESSION (0x00000003ui64 << 40)")]
        public const ulong PROCESS_CREATION_MITIGATION_POLICY_CONTROL_FLOW_GUARD_EXPORT_SUPPRESSION = (0x00000003UL << 40);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY_BLOCK_NON_MICROSOFT_BINARIES_MASK (0x00000003ui64 << 44)")]
        public const ulong PROCESS_CREATION_MITIGATION_POLICY_BLOCK_NON_MICROSOFT_BINARIES_MASK = (0x00000003UL << 44);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY_BLOCK_NON_MICROSOFT_BINARIES_DEFER (0x00000000ui64 << 44)")]
        public const ulong PROCESS_CREATION_MITIGATION_POLICY_BLOCK_NON_MICROSOFT_BINARIES_DEFER = (0x00000000UL << 44);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY_BLOCK_NON_MICROSOFT_BINARIES_ALWAYS_ON (0x00000001ui64 << 44)")]
        public const ulong PROCESS_CREATION_MITIGATION_POLICY_BLOCK_NON_MICROSOFT_BINARIES_ALWAYS_ON = (0x00000001UL << 44);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY_BLOCK_NON_MICROSOFT_BINARIES_ALWAYS_OFF (0x00000002ui64 << 44)")]
        public const ulong PROCESS_CREATION_MITIGATION_POLICY_BLOCK_NON_MICROSOFT_BINARIES_ALWAYS_OFF = (0x00000002UL << 44);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY_BLOCK_NON_MICROSOFT_BINARIES_ALLOW_STORE (0x00000003ui64 << 44)")]
        public const ulong PROCESS_CREATION_MITIGATION_POLICY_BLOCK_NON_MICROSOFT_BINARIES_ALLOW_STORE = (0x00000003UL << 44);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY_FONT_DISABLE_MASK (0x00000003ui64 << 48)")]
        public const ulong PROCESS_CREATION_MITIGATION_POLICY_FONT_DISABLE_MASK = (0x00000003UL << 48);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY_FONT_DISABLE_DEFER (0x00000000ui64 << 48)")]
        public const ulong PROCESS_CREATION_MITIGATION_POLICY_FONT_DISABLE_DEFER = (0x00000000UL << 48);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY_FONT_DISABLE_ALWAYS_ON (0x00000001ui64 << 48)")]
        public const ulong PROCESS_CREATION_MITIGATION_POLICY_FONT_DISABLE_ALWAYS_ON = (0x00000001UL << 48);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY_FONT_DISABLE_ALWAYS_OFF (0x00000002ui64 << 48)")]
        public const ulong PROCESS_CREATION_MITIGATION_POLICY_FONT_DISABLE_ALWAYS_OFF = (0x00000002UL << 48);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY_AUDIT_NONSYSTEM_FONTS (0x00000003ui64 << 48)")]
        public const ulong PROCESS_CREATION_MITIGATION_POLICY_AUDIT_NONSYSTEM_FONTS = (0x00000003UL << 48);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY_IMAGE_LOAD_NO_REMOTE_MASK (0x00000003ui64 << 52)")]
        public const ulong PROCESS_CREATION_MITIGATION_POLICY_IMAGE_LOAD_NO_REMOTE_MASK = (0x00000003UL << 52);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY_IMAGE_LOAD_NO_REMOTE_DEFER (0x00000000ui64 << 52)")]
        public const ulong PROCESS_CREATION_MITIGATION_POLICY_IMAGE_LOAD_NO_REMOTE_DEFER = (0x00000000UL << 52);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY_IMAGE_LOAD_NO_REMOTE_ALWAYS_ON (0x00000001ui64 << 52)")]
        public const ulong PROCESS_CREATION_MITIGATION_POLICY_IMAGE_LOAD_NO_REMOTE_ALWAYS_ON = (0x00000001UL << 52);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY_IMAGE_LOAD_NO_REMOTE_ALWAYS_OFF (0x00000002ui64 << 52)")]
        public const ulong PROCESS_CREATION_MITIGATION_POLICY_IMAGE_LOAD_NO_REMOTE_ALWAYS_OFF = (0x00000002UL << 52);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY_IMAGE_LOAD_NO_REMOTE_RESERVED (0x00000003ui64 << 52)")]
        public const ulong PROCESS_CREATION_MITIGATION_POLICY_IMAGE_LOAD_NO_REMOTE_RESERVED = (0x00000003UL << 52);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY_IMAGE_LOAD_NO_LOW_LABEL_MASK (0x00000003ui64 << 56)")]
        public const ulong PROCESS_CREATION_MITIGATION_POLICY_IMAGE_LOAD_NO_LOW_LABEL_MASK = (0x00000003UL << 56);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY_IMAGE_LOAD_NO_LOW_LABEL_DEFER (0x00000000ui64 << 56)")]
        public const ulong PROCESS_CREATION_MITIGATION_POLICY_IMAGE_LOAD_NO_LOW_LABEL_DEFER = (0x00000000UL << 56);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY_IMAGE_LOAD_NO_LOW_LABEL_ALWAYS_ON (0x00000001ui64 << 56)")]
        public const ulong PROCESS_CREATION_MITIGATION_POLICY_IMAGE_LOAD_NO_LOW_LABEL_ALWAYS_ON = (0x00000001UL << 56);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY_IMAGE_LOAD_NO_LOW_LABEL_ALWAYS_OFF (0x00000002ui64 << 56)")]
        public const ulong PROCESS_CREATION_MITIGATION_POLICY_IMAGE_LOAD_NO_LOW_LABEL_ALWAYS_OFF = (0x00000002UL << 56);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY_IMAGE_LOAD_NO_LOW_LABEL_RESERVED (0x00000003ui64 << 56)")]
        public const ulong PROCESS_CREATION_MITIGATION_POLICY_IMAGE_LOAD_NO_LOW_LABEL_RESERVED = (0x00000003UL << 56);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY_IMAGE_LOAD_PREFER_SYSTEM32_MASK (0x00000003ui64 << 60)")]
        public const ulong PROCESS_CREATION_MITIGATION_POLICY_IMAGE_LOAD_PREFER_SYSTEM32_MASK = (0x00000003UL << 60);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY_IMAGE_LOAD_PREFER_SYSTEM32_DEFER (0x00000000ui64 << 60)")]
        public const ulong PROCESS_CREATION_MITIGATION_POLICY_IMAGE_LOAD_PREFER_SYSTEM32_DEFER = (0x00000000UL << 60);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY_IMAGE_LOAD_PREFER_SYSTEM32_ALWAYS_ON (0x00000001ui64 << 60)")]
        public const ulong PROCESS_CREATION_MITIGATION_POLICY_IMAGE_LOAD_PREFER_SYSTEM32_ALWAYS_ON = (0x00000001UL << 60);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY_IMAGE_LOAD_PREFER_SYSTEM32_ALWAYS_OFF (0x00000002ui64 << 60)")]
        public const ulong PROCESS_CREATION_MITIGATION_POLICY_IMAGE_LOAD_PREFER_SYSTEM32_ALWAYS_OFF = (0x00000002UL << 60);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY_IMAGE_LOAD_PREFER_SYSTEM32_RESERVED (0x00000003ui64 << 60)")]
        public const ulong PROCESS_CREATION_MITIGATION_POLICY_IMAGE_LOAD_PREFER_SYSTEM32_RESERVED = (0x00000003UL << 60);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY2_LOADER_INTEGRITY_CONTINUITY_MASK (0x00000003ui64 << 4)")]
        public const ulong PROCESS_CREATION_MITIGATION_POLICY2_LOADER_INTEGRITY_CONTINUITY_MASK = (0x00000003UL << 4);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY2_LOADER_INTEGRITY_CONTINUITY_DEFER (0x00000000ui64 << 4)")]
        public const ulong PROCESS_CREATION_MITIGATION_POLICY2_LOADER_INTEGRITY_CONTINUITY_DEFER = (0x00000000UL << 4);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY2_LOADER_INTEGRITY_CONTINUITY_ALWAYS_ON (0x00000001ui64 << 4)")]
        public const ulong PROCESS_CREATION_MITIGATION_POLICY2_LOADER_INTEGRITY_CONTINUITY_ALWAYS_ON = (0x00000001UL << 4);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY2_LOADER_INTEGRITY_CONTINUITY_ALWAYS_OFF (0x00000002ui64 << 4)")]
        public const ulong PROCESS_CREATION_MITIGATION_POLICY2_LOADER_INTEGRITY_CONTINUITY_ALWAYS_OFF = (0x00000002UL << 4);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY2_LOADER_INTEGRITY_CONTINUITY_AUDIT (0x00000003ui64 << 4)")]
        public const ulong PROCESS_CREATION_MITIGATION_POLICY2_LOADER_INTEGRITY_CONTINUITY_AUDIT = (0x00000003UL << 4);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY2_STRICT_CONTROL_FLOW_GUARD_MASK (0x00000003ui64 << 8)")]
        public const ulong PROCESS_CREATION_MITIGATION_POLICY2_STRICT_CONTROL_FLOW_GUARD_MASK = (0x00000003UL << 8);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY2_STRICT_CONTROL_FLOW_GUARD_DEFER (0x00000000ui64 << 8)")]
        public const ulong PROCESS_CREATION_MITIGATION_POLICY2_STRICT_CONTROL_FLOW_GUARD_DEFER = (0x00000000UL << 8);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY2_STRICT_CONTROL_FLOW_GUARD_ALWAYS_ON (0x00000001ui64 << 8)")]
        public const ulong PROCESS_CREATION_MITIGATION_POLICY2_STRICT_CONTROL_FLOW_GUARD_ALWAYS_ON = (0x00000001UL << 8);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY2_STRICT_CONTROL_FLOW_GUARD_ALWAYS_OFF (0x00000002ui64 << 8)")]
        public const ulong PROCESS_CREATION_MITIGATION_POLICY2_STRICT_CONTROL_FLOW_GUARD_ALWAYS_OFF = (0x00000002UL << 8);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY2_STRICT_CONTROL_FLOW_GUARD_RESERVED (0x00000003ui64 << 8)")]
        public const ulong PROCESS_CREATION_MITIGATION_POLICY2_STRICT_CONTROL_FLOW_GUARD_RESERVED = (0x00000003UL << 8);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY2_MODULE_TAMPERING_PROTECTION_MASK (0x00000003ui64 << 12)")]
        public const ulong PROCESS_CREATION_MITIGATION_POLICY2_MODULE_TAMPERING_PROTECTION_MASK = (0x00000003UL << 12);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY2_MODULE_TAMPERING_PROTECTION_DEFER (0x00000000ui64 << 12)")]
        public const ulong PROCESS_CREATION_MITIGATION_POLICY2_MODULE_TAMPERING_PROTECTION_DEFER = (0x00000000UL << 12);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY2_MODULE_TAMPERING_PROTECTION_ALWAYS_ON (0x00000001ui64 << 12)")]
        public const ulong PROCESS_CREATION_MITIGATION_POLICY2_MODULE_TAMPERING_PROTECTION_ALWAYS_ON = (0x00000001UL << 12);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY2_MODULE_TAMPERING_PROTECTION_ALWAYS_OFF (0x00000002ui64 << 12)")]
        public const ulong PROCESS_CREATION_MITIGATION_POLICY2_MODULE_TAMPERING_PROTECTION_ALWAYS_OFF = (0x00000002UL << 12);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY2_MODULE_TAMPERING_PROTECTION_NOINHERIT (0x00000003ui64 << 12)")]
        public const ulong PROCESS_CREATION_MITIGATION_POLICY2_MODULE_TAMPERING_PROTECTION_NOINHERIT = (0x00000003UL << 12);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY2_RESTRICT_INDIRECT_BRANCH_PREDICTION_MASK (0x00000003ui64 << 16)")]
        public const ulong PROCESS_CREATION_MITIGATION_POLICY2_RESTRICT_INDIRECT_BRANCH_PREDICTION_MASK = (0x00000003UL << 16);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY2_RESTRICT_INDIRECT_BRANCH_PREDICTION_DEFER (0x00000000ui64 << 16)")]
        public const ulong PROCESS_CREATION_MITIGATION_POLICY2_RESTRICT_INDIRECT_BRANCH_PREDICTION_DEFER = (0x00000000UL << 16);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY2_RESTRICT_INDIRECT_BRANCH_PREDICTION_ALWAYS_ON (0x00000001ui64 << 16)")]
        public const ulong PROCESS_CREATION_MITIGATION_POLICY2_RESTRICT_INDIRECT_BRANCH_PREDICTION_ALWAYS_ON = (0x00000001UL << 16);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY2_RESTRICT_INDIRECT_BRANCH_PREDICTION_ALWAYS_OFF (0x00000002ui64 << 16)")]
        public const ulong PROCESS_CREATION_MITIGATION_POLICY2_RESTRICT_INDIRECT_BRANCH_PREDICTION_ALWAYS_OFF = (0x00000002UL << 16);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY2_RESTRICT_INDIRECT_BRANCH_PREDICTION_RESERVED (0x00000003ui64 << 16)")]
        public const ulong PROCESS_CREATION_MITIGATION_POLICY2_RESTRICT_INDIRECT_BRANCH_PREDICTION_RESERVED = (0x00000003UL << 16);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY2_ALLOW_DOWNGRADE_DYNAMIC_CODE_POLICY_MASK (0x00000003ui64 << 20)")]
        public const ulong PROCESS_CREATION_MITIGATION_POLICY2_ALLOW_DOWNGRADE_DYNAMIC_CODE_POLICY_MASK = (0x00000003UL << 20);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY2_ALLOW_DOWNGRADE_DYNAMIC_CODE_POLICY_DEFER (0x00000000ui64 << 20)")]
        public const ulong PROCESS_CREATION_MITIGATION_POLICY2_ALLOW_DOWNGRADE_DYNAMIC_CODE_POLICY_DEFER = (0x00000000UL << 20);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY2_ALLOW_DOWNGRADE_DYNAMIC_CODE_POLICY_ALWAYS_ON (0x00000001ui64 << 20)")]
        public const ulong PROCESS_CREATION_MITIGATION_POLICY2_ALLOW_DOWNGRADE_DYNAMIC_CODE_POLICY_ALWAYS_ON = (0x00000001UL << 20);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY2_ALLOW_DOWNGRADE_DYNAMIC_CODE_POLICY_ALWAYS_OFF (0x00000002ui64 << 20)")]
        public const ulong PROCESS_CREATION_MITIGATION_POLICY2_ALLOW_DOWNGRADE_DYNAMIC_CODE_POLICY_ALWAYS_OFF = (0x00000002UL << 20);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY2_ALLOW_DOWNGRADE_DYNAMIC_CODE_POLICY_RESERVED (0x00000003ui64 << 20)")]
        public const ulong PROCESS_CREATION_MITIGATION_POLICY2_ALLOW_DOWNGRADE_DYNAMIC_CODE_POLICY_RESERVED = (0x00000003UL << 20);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY2_SPECULATIVE_STORE_BYPASS_DISABLE_MASK (0x00000003ui64 << 24)")]
        public const ulong PROCESS_CREATION_MITIGATION_POLICY2_SPECULATIVE_STORE_BYPASS_DISABLE_MASK = (0x00000003UL << 24);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY2_SPECULATIVE_STORE_BYPASS_DISABLE_DEFER (0x00000000ui64 << 24)")]
        public const ulong PROCESS_CREATION_MITIGATION_POLICY2_SPECULATIVE_STORE_BYPASS_DISABLE_DEFER = (0x00000000UL << 24);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY2_SPECULATIVE_STORE_BYPASS_DISABLE_ALWAYS_ON (0x00000001ui64 << 24)")]
        public const ulong PROCESS_CREATION_MITIGATION_POLICY2_SPECULATIVE_STORE_BYPASS_DISABLE_ALWAYS_ON = (0x00000001UL << 24);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY2_SPECULATIVE_STORE_BYPASS_DISABLE_ALWAYS_OFF (0x00000002ui64 << 24)")]
        public const ulong PROCESS_CREATION_MITIGATION_POLICY2_SPECULATIVE_STORE_BYPASS_DISABLE_ALWAYS_OFF = (0x00000002UL << 24);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY2_SPECULATIVE_STORE_BYPASS_DISABLE_RESERVED (0x00000003ui64 << 24)")]
        public const ulong PROCESS_CREATION_MITIGATION_POLICY2_SPECULATIVE_STORE_BYPASS_DISABLE_RESERVED = (0x00000003UL << 24);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY2_CET_USER_SHADOW_STACKS_MASK (0x00000003ui64 << 28)")]
        public const ulong PROCESS_CREATION_MITIGATION_POLICY2_CET_USER_SHADOW_STACKS_MASK = (0x00000003UL << 28);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY2_CET_USER_SHADOW_STACKS_DEFER (0x00000000ui64 << 28)")]
        public const ulong PROCESS_CREATION_MITIGATION_POLICY2_CET_USER_SHADOW_STACKS_DEFER = (0x00000000UL << 28);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY2_CET_USER_SHADOW_STACKS_ALWAYS_ON (0x00000001ui64 << 28)")]
        public const ulong PROCESS_CREATION_MITIGATION_POLICY2_CET_USER_SHADOW_STACKS_ALWAYS_ON = (0x00000001UL << 28);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY2_CET_USER_SHADOW_STACKS_ALWAYS_OFF (0x00000002ui64 << 28)")]
        public const ulong PROCESS_CREATION_MITIGATION_POLICY2_CET_USER_SHADOW_STACKS_ALWAYS_OFF = (0x00000002UL << 28);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY2_CET_USER_SHADOW_STACKS_STRICT_MODE (0x00000003ui64 << 28)")]
        public const ulong PROCESS_CREATION_MITIGATION_POLICY2_CET_USER_SHADOW_STACKS_STRICT_MODE = (0x00000003UL << 28);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY2_USER_CET_SET_CONTEXT_IP_VALIDATION_MASK (0x00000003ui64 << 32)")]
        public const ulong PROCESS_CREATION_MITIGATION_POLICY2_USER_CET_SET_CONTEXT_IP_VALIDATION_MASK = (0x00000003UL << 32);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY2_USER_CET_SET_CONTEXT_IP_VALIDATION_DEFER (0x00000000ui64 << 32)")]
        public const ulong PROCESS_CREATION_MITIGATION_POLICY2_USER_CET_SET_CONTEXT_IP_VALIDATION_DEFER = (0x00000000UL << 32);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY2_USER_CET_SET_CONTEXT_IP_VALIDATION_ALWAYS_ON (0x00000001ui64 << 32)")]
        public const ulong PROCESS_CREATION_MITIGATION_POLICY2_USER_CET_SET_CONTEXT_IP_VALIDATION_ALWAYS_ON = (0x00000001UL << 32);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY2_USER_CET_SET_CONTEXT_IP_VALIDATION_ALWAYS_OFF (0x00000002ui64 << 32)")]
        public const ulong PROCESS_CREATION_MITIGATION_POLICY2_USER_CET_SET_CONTEXT_IP_VALIDATION_ALWAYS_OFF = (0x00000002UL << 32);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY2_USER_CET_SET_CONTEXT_IP_VALIDATION_RELAXED_MODE (0x00000003ui64 << 32)")]
        public const ulong PROCESS_CREATION_MITIGATION_POLICY2_USER_CET_SET_CONTEXT_IP_VALIDATION_RELAXED_MODE = (0x00000003UL << 32);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY2_BLOCK_NON_CET_BINARIES_MASK (0x00000003ui64 << 36)")]
        public const ulong PROCESS_CREATION_MITIGATION_POLICY2_BLOCK_NON_CET_BINARIES_MASK = (0x00000003UL << 36);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY2_BLOCK_NON_CET_BINARIES_DEFER (0x00000000ui64 << 36)")]
        public const ulong PROCESS_CREATION_MITIGATION_POLICY2_BLOCK_NON_CET_BINARIES_DEFER = (0x00000000UL << 36);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY2_BLOCK_NON_CET_BINARIES_ALWAYS_ON (0x00000001ui64 << 36)")]
        public const ulong PROCESS_CREATION_MITIGATION_POLICY2_BLOCK_NON_CET_BINARIES_ALWAYS_ON = (0x00000001UL << 36);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY2_BLOCK_NON_CET_BINARIES_ALWAYS_OFF (0x00000002ui64 << 36)")]
        public const ulong PROCESS_CREATION_MITIGATION_POLICY2_BLOCK_NON_CET_BINARIES_ALWAYS_OFF = (0x00000002UL << 36);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY2_BLOCK_NON_CET_BINARIES_NON_EHCONT (0x00000003ui64 << 36)")]
        public const ulong PROCESS_CREATION_MITIGATION_POLICY2_BLOCK_NON_CET_BINARIES_NON_EHCONT = (0x00000003UL << 36);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY2_XTENDED_CONTROL_FLOW_GUARD_MASK (0x00000003ui64 << 40)")]
        public const ulong PROCESS_CREATION_MITIGATION_POLICY2_XTENDED_CONTROL_FLOW_GUARD_MASK = (0x00000003UL << 40);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY2_XTENDED_CONTROL_FLOW_GUARD_DEFER (0x00000000ui64 << 40)")]
        public const ulong PROCESS_CREATION_MITIGATION_POLICY2_XTENDED_CONTROL_FLOW_GUARD_DEFER = (0x00000000UL << 40);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY2_XTENDED_CONTROL_FLOW_GUARD_ALWAYS_ON (0x00000001ui64 << 40)")]
        public const ulong PROCESS_CREATION_MITIGATION_POLICY2_XTENDED_CONTROL_FLOW_GUARD_ALWAYS_ON = (0x00000001UL << 40);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY2_XTENDED_CONTROL_FLOW_GUARD_ALWAYS_OFF (0x00000002ui64 << 40)")]
        public const ulong PROCESS_CREATION_MITIGATION_POLICY2_XTENDED_CONTROL_FLOW_GUARD_ALWAYS_OFF = (0x00000002UL << 40);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY2_XTENDED_CONTROL_FLOW_GUARD_RESERVED (0x00000003ui64 << 40)")]
        public const ulong PROCESS_CREATION_MITIGATION_POLICY2_XTENDED_CONTROL_FLOW_GUARD_RESERVED = (0x00000003UL << 40);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY2_CET_DYNAMIC_APIS_OUT_OF_PROC_ONLY_MASK (0x00000003ui64 << 48)")]
        public const ulong PROCESS_CREATION_MITIGATION_POLICY2_CET_DYNAMIC_APIS_OUT_OF_PROC_ONLY_MASK = (0x00000003UL << 48);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY2_CET_DYNAMIC_APIS_OUT_OF_PROC_ONLY_DEFER (0x00000000ui64 << 48)")]
        public const ulong PROCESS_CREATION_MITIGATION_POLICY2_CET_DYNAMIC_APIS_OUT_OF_PROC_ONLY_DEFER = (0x00000000UL << 48);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY2_CET_DYNAMIC_APIS_OUT_OF_PROC_ONLY_ALWAYS_ON (0x00000001ui64 << 48)")]
        public const ulong PROCESS_CREATION_MITIGATION_POLICY2_CET_DYNAMIC_APIS_OUT_OF_PROC_ONLY_ALWAYS_ON = (0x00000001UL << 48);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY2_CET_DYNAMIC_APIS_OUT_OF_PROC_ONLY_ALWAYS_OFF (0x00000002ui64 << 48)")]
        public const ulong PROCESS_CREATION_MITIGATION_POLICY2_CET_DYNAMIC_APIS_OUT_OF_PROC_ONLY_ALWAYS_OFF = (0x00000002UL << 48);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_POLICY2_CET_DYNAMIC_APIS_OUT_OF_PROC_ONLY_RESERVED (0x00000003ui64 << 48)")]
        public const ulong PROCESS_CREATION_MITIGATION_POLICY2_CET_DYNAMIC_APIS_OUT_OF_PROC_ONLY_RESERVED = (0x00000003UL << 48);

        [NativeTypeName("#define PROC_THREAD_ATTRIBUTE_JOB_LIST ProcThreadAttributeValue (ProcThreadAttributeJobList, FALSE, TRUE, FALSE)")]
        public const int PROC_THREAD_ATTRIBUTE_JOB_LIST = (((int)(ProcThreadAttributeJobList) & 0x0000FFFF) | ((0 != 0) ? 0x00010000 : 0) | ((1 != 0) ? 0x00020000 : 0) | ((0 != 0) ? 0x00040000 : 0));

        [NativeTypeName("#define PROCESS_CREATION_CHILD_PROCESS_RESTRICTED 0x01")]
        public const int PROCESS_CREATION_CHILD_PROCESS_RESTRICTED = 0x01;

        [NativeTypeName("#define PROCESS_CREATION_CHILD_PROCESS_OVERRIDE 0x02")]
        public const int PROCESS_CREATION_CHILD_PROCESS_OVERRIDE = 0x02;

        [NativeTypeName("#define PROCESS_CREATION_CHILD_PROCESS_RESTRICTED_UNLESS_SECURE 0x04")]
        public const int PROCESS_CREATION_CHILD_PROCESS_RESTRICTED_UNLESS_SECURE = 0x04;

        [NativeTypeName("#define PROC_THREAD_ATTRIBUTE_CHILD_PROCESS_POLICY ProcThreadAttributeValue (ProcThreadAttributeChildProcessPolicy, FALSE, TRUE, FALSE)")]
        public const int PROC_THREAD_ATTRIBUTE_CHILD_PROCESS_POLICY = (((int)(ProcThreadAttributeChildProcessPolicy) & 0x0000FFFF) | ((0 != 0) ? 0x00010000 : 0) | ((1 != 0) ? 0x00020000 : 0) | ((0 != 0) ? 0x00040000 : 0));

        [NativeTypeName("#define PROCESS_CREATION_ALL_APPLICATION_PACKAGES_OPT_OUT 0x01")]
        public const int PROCESS_CREATION_ALL_APPLICATION_PACKAGES_OPT_OUT = 0x01;

        [NativeTypeName("#define PROC_THREAD_ATTRIBUTE_ALL_APPLICATION_PACKAGES_POLICY ProcThreadAttributeValue (ProcThreadAttributeAllApplicationPackagesPolicy, FALSE, TRUE, FALSE)")]
        public const int PROC_THREAD_ATTRIBUTE_ALL_APPLICATION_PACKAGES_POLICY = (((int)(ProcThreadAttributeAllApplicationPackagesPolicy) & 0x0000FFFF) | ((0 != 0) ? 0x00010000 : 0) | ((1 != 0) ? 0x00020000 : 0) | ((0 != 0) ? 0x00040000 : 0));

        [NativeTypeName("#define PROC_THREAD_ATTRIBUTE_WIN32K_FILTER ProcThreadAttributeValue (ProcThreadAttributeWin32kFilter, FALSE, TRUE, FALSE)")]
        public const int PROC_THREAD_ATTRIBUTE_WIN32K_FILTER = (((int)(ProcThreadAttributeWin32kFilter) & 0x0000FFFF) | ((0 != 0) ? 0x00010000 : 0) | ((1 != 0) ? 0x00020000 : 0) | ((0 != 0) ? 0x00040000 : 0));

        [NativeTypeName("#define PROCESS_CREATION_DESKTOP_APP_BREAKAWAY_ENABLE_PROCESS_TREE 0x01")]
        public const int PROCESS_CREATION_DESKTOP_APP_BREAKAWAY_ENABLE_PROCESS_TREE = 0x01;

        [NativeTypeName("#define PROCESS_CREATION_DESKTOP_APP_BREAKAWAY_DISABLE_PROCESS_TREE 0x02")]
        public const int PROCESS_CREATION_DESKTOP_APP_BREAKAWAY_DISABLE_PROCESS_TREE = 0x02;

        [NativeTypeName("#define PROCESS_CREATION_DESKTOP_APP_BREAKAWAY_OVERRIDE 0x04")]
        public const int PROCESS_CREATION_DESKTOP_APP_BREAKAWAY_OVERRIDE = 0x04;

        [NativeTypeName("#define PROC_THREAD_ATTRIBUTE_DESKTOP_APP_POLICY ProcThreadAttributeValue (ProcThreadAttributeDesktopAppPolicy, FALSE, TRUE, FALSE)")]
        public const int PROC_THREAD_ATTRIBUTE_DESKTOP_APP_POLICY = (((int)(ProcThreadAttributeDesktopAppPolicy) & 0x0000FFFF) | ((0 != 0) ? 0x00010000 : 0) | ((1 != 0) ? 0x00020000 : 0) | ((0 != 0) ? 0x00040000 : 0));

        [NativeTypeName("#define PROC_THREAD_ATTRIBUTE_MITIGATION_AUDIT_POLICY ProcThreadAttributeValue (ProcThreadAttributeMitigationAuditPolicy, FALSE, TRUE, FALSE)")]
        public const int PROC_THREAD_ATTRIBUTE_MITIGATION_AUDIT_POLICY = (((int)(ProcThreadAttributeMitigationAuditPolicy) & 0x0000FFFF) | ((0 != 0) ? 0x00010000 : 0) | ((1 != 0) ? 0x00020000 : 0) | ((0 != 0) ? 0x00040000 : 0));

        [NativeTypeName("#define PROC_THREAD_ATTRIBUTE_COMPONENT_FILTER ProcThreadAttributeValue (ProcThreadAttributeComponentFilter, FALSE, TRUE, FALSE)")]
        public const int PROC_THREAD_ATTRIBUTE_COMPONENT_FILTER = (((int)(ProcThreadAttributeComponentFilter) & 0x0000FFFF) | ((0 != 0) ? 0x00010000 : 0) | ((1 != 0) ? 0x00020000 : 0) | ((0 != 0) ? 0x00040000 : 0));

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_AUDIT_POLICY2_CET_USER_SHADOW_STACKS_MASK (0x00000003ui64 << 28)")]
        public const ulong PROCESS_CREATION_MITIGATION_AUDIT_POLICY2_CET_USER_SHADOW_STACKS_MASK = (0x00000003UL << 28);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_AUDIT_POLICY2_CET_USER_SHADOW_STACKS_DEFER (0x00000000ui64 << 28)")]
        public const ulong PROCESS_CREATION_MITIGATION_AUDIT_POLICY2_CET_USER_SHADOW_STACKS_DEFER = (0x00000000UL << 28);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_AUDIT_POLICY2_CET_USER_SHADOW_STACKS_ALWAYS_ON (0x00000001ui64 << 28)")]
        public const ulong PROCESS_CREATION_MITIGATION_AUDIT_POLICY2_CET_USER_SHADOW_STACKS_ALWAYS_ON = (0x00000001UL << 28);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_AUDIT_POLICY2_CET_USER_SHADOW_STACKS_ALWAYS_OFF (0x00000002ui64 << 28)")]
        public const ulong PROCESS_CREATION_MITIGATION_AUDIT_POLICY2_CET_USER_SHADOW_STACKS_ALWAYS_OFF = (0x00000002UL << 28);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_AUDIT_POLICY2_CET_USER_SHADOW_STACKS_RESERVED (0x00000003ui64 << 28)")]
        public const ulong PROCESS_CREATION_MITIGATION_AUDIT_POLICY2_CET_USER_SHADOW_STACKS_RESERVED = (0x00000003UL << 28);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_AUDIT_POLICY2_USER_CET_SET_CONTEXT_IP_VALIDATION_MASK (0x00000003ui64 << 32)")]
        public const ulong PROCESS_CREATION_MITIGATION_AUDIT_POLICY2_USER_CET_SET_CONTEXT_IP_VALIDATION_MASK = (0x00000003UL << 32);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_AUDIT_POLICY2_USER_CET_SET_CONTEXT_IP_VALIDATION_DEFER (0x00000000ui64 << 32)")]
        public const ulong PROCESS_CREATION_MITIGATION_AUDIT_POLICY2_USER_CET_SET_CONTEXT_IP_VALIDATION_DEFER = (0x00000000UL << 32);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_AUDIT_POLICY2_USER_CET_SET_CONTEXT_IP_VALIDATION_ALWAYS_ON (0x00000001ui64 << 32)")]
        public const ulong PROCESS_CREATION_MITIGATION_AUDIT_POLICY2_USER_CET_SET_CONTEXT_IP_VALIDATION_ALWAYS_ON = (0x00000001UL << 32);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_AUDIT_POLICY2_USER_CET_SET_CONTEXT_IP_VALIDATION_ALWAYS_OFF (0x00000002ui64 << 32)")]
        public const ulong PROCESS_CREATION_MITIGATION_AUDIT_POLICY2_USER_CET_SET_CONTEXT_IP_VALIDATION_ALWAYS_OFF = (0x00000002UL << 32);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_AUDIT_POLICY2_USER_CET_SET_CONTEXT_IP_VALIDATION_RESERVED (0x00000003ui64 << 32)")]
        public const ulong PROCESS_CREATION_MITIGATION_AUDIT_POLICY2_USER_CET_SET_CONTEXT_IP_VALIDATION_RESERVED = (0x00000003UL << 32);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_AUDIT_POLICY2_BLOCK_NON_CET_BINARIES_MASK (0x00000003ui64 << 36)")]
        public const ulong PROCESS_CREATION_MITIGATION_AUDIT_POLICY2_BLOCK_NON_CET_BINARIES_MASK = (0x00000003UL << 36);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_AUDIT_POLICY2_BLOCK_NON_CET_BINARIES_DEFER (0x00000000ui64 << 36)")]
        public const ulong PROCESS_CREATION_MITIGATION_AUDIT_POLICY2_BLOCK_NON_CET_BINARIES_DEFER = (0x00000000UL << 36);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_AUDIT_POLICY2_BLOCK_NON_CET_BINARIES_ALWAYS_ON (0x00000001ui64 << 36)")]
        public const ulong PROCESS_CREATION_MITIGATION_AUDIT_POLICY2_BLOCK_NON_CET_BINARIES_ALWAYS_ON = (0x00000001UL << 36);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_AUDIT_POLICY2_BLOCK_NON_CET_BINARIES_ALWAYS_OFF (0x00000002ui64 << 36)")]
        public const ulong PROCESS_CREATION_MITIGATION_AUDIT_POLICY2_BLOCK_NON_CET_BINARIES_ALWAYS_OFF = (0x00000002UL << 36);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_AUDIT_POLICY2_BLOCK_NON_CET_BINARIES_RESERVED (0x00000003ui64 << 36)")]
        public const ulong PROCESS_CREATION_MITIGATION_AUDIT_POLICY2_BLOCK_NON_CET_BINARIES_RESERVED = (0x00000003UL << 36);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_AUDIT_POLICY2_XTENDED_CONTROL_FLOW_GUARD_MASK (0x00000003ui64 << 40)")]
        public const ulong PROCESS_CREATION_MITIGATION_AUDIT_POLICY2_XTENDED_CONTROL_FLOW_GUARD_MASK = (0x00000003UL << 40);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_AUDIT_POLICY2_XTENDED_CONTROL_FLOW_GUARD_DEFER (0x00000000ui64 << 40)")]
        public const ulong PROCESS_CREATION_MITIGATION_AUDIT_POLICY2_XTENDED_CONTROL_FLOW_GUARD_DEFER = (0x00000000UL << 40);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_AUDIT_POLICY2_XTENDED_CONTROL_FLOW_GUARD_ALWAYS_ON (0x00000001ui64 << 40)")]
        public const ulong PROCESS_CREATION_MITIGATION_AUDIT_POLICY2_XTENDED_CONTROL_FLOW_GUARD_ALWAYS_ON = (0x00000001UL << 40);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_AUDIT_POLICY2_XTENDED_CONTROL_FLOW_GUARD_ALWAYS_OFF (0x00000002ui64 << 40)")]
        public const ulong PROCESS_CREATION_MITIGATION_AUDIT_POLICY2_XTENDED_CONTROL_FLOW_GUARD_ALWAYS_OFF = (0x00000002UL << 40);

        [NativeTypeName("#define PROCESS_CREATION_MITIGATION_AUDIT_POLICY2_XTENDED_CONTROL_FLOW_GUARD_RESERVED (0x00000003ui64 << 40)")]
        public const ulong PROCESS_CREATION_MITIGATION_AUDIT_POLICY2_XTENDED_CONTROL_FLOW_GUARD_RESERVED = (0x00000003UL << 40);

        [NativeTypeName("#define GetFirmwareEnvironmentVariable GetFirmwareEnvironmentVariableW")]
        public static delegate*<ushort*, ushort*, void*, uint, uint> GetFirmwareEnvironmentVariable => &GetFirmwareEnvironmentVariableW;

        [NativeTypeName("#define GetFirmwareEnvironmentVariableEx GetFirmwareEnvironmentVariableExW")]
        public static delegate*<ushort*, ushort*, void*, uint, uint*, uint> GetFirmwareEnvironmentVariableEx => &GetFirmwareEnvironmentVariableExW;

        [NativeTypeName("#define SetFirmwareEnvironmentVariable SetFirmwareEnvironmentVariableW")]
        public static delegate*<ushort*, ushort*, void*, uint, int> SetFirmwareEnvironmentVariable => &SetFirmwareEnvironmentVariableW;

        [NativeTypeName("#define SetFirmwareEnvironmentVariableEx SetFirmwareEnvironmentVariableExW")]
        public static delegate*<ushort*, ushort*, void*, uint, uint, int> SetFirmwareEnvironmentVariableEx => &SetFirmwareEnvironmentVariableExW;

        [NativeTypeName("#define EnumResourceTypes EnumResourceTypesW")]
        public static delegate*<IntPtr, delegate* unmanaged<IntPtr, ushort*, nint, int>, nint, int> EnumResourceTypes => &EnumResourceTypesW;

        [NativeTypeName("#define EnumResourceLanguages EnumResourceLanguagesW")]
        public static delegate*<IntPtr, ushort*, ushort*, delegate* unmanaged<IntPtr, ushort*, ushort*, ushort, nint, int>, nint, int> EnumResourceLanguages => &EnumResourceLanguagesW;

        [NativeTypeName("#define BeginUpdateResource BeginUpdateResourceW")]
        public static delegate*<ushort*, int, IntPtr> BeginUpdateResource => &BeginUpdateResourceW;

        [NativeTypeName("#define UpdateResource UpdateResourceW")]
        public static delegate*<IntPtr, ushort*, ushort*, ushort, void*, uint, int> UpdateResource => &UpdateResourceW;

        [NativeTypeName("#define EndUpdateResource EndUpdateResourceW")]
        public static delegate*<IntPtr, int, int> EndUpdateResource => &EndUpdateResourceW;

        [NativeTypeName("#define ATOM_FLAG_GLOBAL 0x2")]
        public const int ATOM_FLAG_GLOBAL = 0x2;

        [NativeTypeName("#define GlobalAddAtom GlobalAddAtomW")]
        public static delegate*<ushort*, ushort> GlobalAddAtom => &GlobalAddAtomW;

        [NativeTypeName("#define GlobalAddAtomEx GlobalAddAtomExW")]
        public static delegate*<ushort*, uint, ushort> GlobalAddAtomEx => &GlobalAddAtomExW;

        [NativeTypeName("#define GlobalFindAtom GlobalFindAtomW")]
        public static delegate*<ushort*, ushort> GlobalFindAtom => &GlobalFindAtomW;

        [NativeTypeName("#define GlobalGetAtomName GlobalGetAtomNameW")]
        public static delegate*<ushort, ushort*, int, uint> GlobalGetAtomName => &GlobalGetAtomNameW;

        [NativeTypeName("#define AddAtom AddAtomW")]
        public static delegate*<ushort*, ushort> AddAtom => &AddAtomW;

        [NativeTypeName("#define FindAtom FindAtomW")]
        public static delegate*<ushort*, ushort> FindAtom => &FindAtomW;

        [NativeTypeName("#define GetAtomName GetAtomNameW")]
        public static delegate*<ushort, ushort*, int, uint> GetAtomName => &GetAtomNameW;

        [NativeTypeName("#define GetProfileInt GetProfileIntW")]
        public static delegate*<ushort*, ushort*, int, uint> GetProfileInt => &GetProfileIntW;

        [NativeTypeName("#define GetProfileString GetProfileStringW")]
        public static delegate*<ushort*, ushort*, ushort*, ushort*, uint, uint> GetProfileString => &GetProfileStringW;

        [NativeTypeName("#define WriteProfileString WriteProfileStringW")]
        public static delegate*<ushort*, ushort*, ushort*, int> WriteProfileString => &WriteProfileStringW;

        [NativeTypeName("#define GetProfileSection GetProfileSectionW")]
        public static delegate*<ushort*, ushort*, uint, uint> GetProfileSection => &GetProfileSectionW;

        [NativeTypeName("#define WriteProfileSection WriteProfileSectionW")]
        public static delegate*<ushort*, ushort*, int> WriteProfileSection => &WriteProfileSectionW;

        [NativeTypeName("#define GetPrivateProfileInt GetPrivateProfileIntW")]
        public static delegate*<ushort*, ushort*, int, ushort*, uint> GetPrivateProfileInt => &GetPrivateProfileIntW;

        [NativeTypeName("#define GetPrivateProfileString GetPrivateProfileStringW")]
        public static delegate*<ushort*, ushort*, ushort*, ushort*, uint, ushort*, uint> GetPrivateProfileString => &GetPrivateProfileStringW;

        [NativeTypeName("#define WritePrivateProfileString WritePrivateProfileStringW")]
        public static delegate*<ushort*, ushort*, ushort*, ushort*, int> WritePrivateProfileString => &WritePrivateProfileStringW;

        [NativeTypeName("#define GetPrivateProfileSection GetPrivateProfileSectionW")]
        public static delegate*<ushort*, ushort*, uint, ushort*, uint> GetPrivateProfileSection => &GetPrivateProfileSectionW;

        [NativeTypeName("#define WritePrivateProfileSection WritePrivateProfileSectionW")]
        public static delegate*<ushort*, ushort*, ushort*, int> WritePrivateProfileSection => &WritePrivateProfileSectionW;

        [NativeTypeName("#define GetPrivateProfileSectionNames GetPrivateProfileSectionNamesW")]
        public static delegate*<ushort*, uint, ushort*, uint> GetPrivateProfileSectionNames => &GetPrivateProfileSectionNamesW;

        [NativeTypeName("#define GetPrivateProfileStruct GetPrivateProfileStructW")]
        public static delegate*<ushort*, ushort*, void*, uint, ushort*, int> GetPrivateProfileStruct => &GetPrivateProfileStructW;

        [NativeTypeName("#define WritePrivateProfileStruct WritePrivateProfileStructW")]
        public static delegate*<ushort*, ushort*, void*, uint, ushort*, int> WritePrivateProfileStruct => &WritePrivateProfileStructW;

        [NativeTypeName("#define GET_SYSTEM_WOW64_DIRECTORY_NAME_A_A \"GetSystemWow64DirectoryA\"")]
        public static ReadOnlySpan<byte> GET_SYSTEM_WOW64_DIRECTORY_NAME_A_A => new byte[] { 0x47, 0x65, 0x74, 0x53, 0x79, 0x73, 0x74, 0x65, 0x6D, 0x57, 0x6F, 0x77, 0x36, 0x34, 0x44, 0x69, 0x72, 0x65, 0x63, 0x74, 0x6F, 0x72, 0x79, 0x41, 0x00 };

        [NativeTypeName("#define GET_SYSTEM_WOW64_DIRECTORY_NAME_A_W L\"GetSystemWow64DirectoryA\"")]
        public const string GET_SYSTEM_WOW64_DIRECTORY_NAME_A_W = "GetSystemWow64DirectoryA";

        [NativeTypeName("#define GET_SYSTEM_WOW64_DIRECTORY_NAME_A_T TEXT(\"GetSystemWow64DirectoryA\")")]
        public const string GET_SYSTEM_WOW64_DIRECTORY_NAME_A_T = "GetSystemWow64DirectoryA";

        [NativeTypeName("#define GET_SYSTEM_WOW64_DIRECTORY_NAME_W_A \"GetSystemWow64DirectoryW\"")]
        public static ReadOnlySpan<byte> GET_SYSTEM_WOW64_DIRECTORY_NAME_W_A => new byte[] { 0x47, 0x65, 0x74, 0x53, 0x79, 0x73, 0x74, 0x65, 0x6D, 0x57, 0x6F, 0x77, 0x36, 0x34, 0x44, 0x69, 0x72, 0x65, 0x63, 0x74, 0x6F, 0x72, 0x79, 0x57, 0x00 };

        [NativeTypeName("#define GET_SYSTEM_WOW64_DIRECTORY_NAME_W_W L\"GetSystemWow64DirectoryW\"")]
        public const string GET_SYSTEM_WOW64_DIRECTORY_NAME_W_W = "GetSystemWow64DirectoryW";

        [NativeTypeName("#define GET_SYSTEM_WOW64_DIRECTORY_NAME_W_T TEXT(\"GetSystemWow64DirectoryW\")")]
        public const string GET_SYSTEM_WOW64_DIRECTORY_NAME_W_T = "GetSystemWow64DirectoryW";

        [NativeTypeName("#define GET_SYSTEM_WOW64_DIRECTORY_NAME_T_A GET_SYSTEM_WOW64_DIRECTORY_NAME_W_A")]
        public static ReadOnlySpan<byte> GET_SYSTEM_WOW64_DIRECTORY_NAME_T_A => new byte[] { 0x47, 0x65, 0x74, 0x53, 0x79, 0x73, 0x74, 0x65, 0x6D, 0x57, 0x6F, 0x77, 0x36, 0x34, 0x44, 0x69, 0x72, 0x65, 0x63, 0x74, 0x6F, 0x72, 0x79, 0x57, 0x00 };

        [NativeTypeName("#define GET_SYSTEM_WOW64_DIRECTORY_NAME_T_W GET_SYSTEM_WOW64_DIRECTORY_NAME_W_W")]
        public const string GET_SYSTEM_WOW64_DIRECTORY_NAME_T_W = "GetSystemWow64DirectoryW";

        [NativeTypeName("#define GET_SYSTEM_WOW64_DIRECTORY_NAME_T_T GET_SYSTEM_WOW64_DIRECTORY_NAME_W_T")]
        public const string GET_SYSTEM_WOW64_DIRECTORY_NAME_T_T = "GetSystemWow64DirectoryW";

        [NativeTypeName("#define SetDllDirectory SetDllDirectoryW")]
        public static delegate*<ushort*, int> SetDllDirectory => &SetDllDirectoryW;

        [NativeTypeName("#define GetDllDirectory GetDllDirectoryW")]
        public static delegate*<uint, ushort*, uint> GetDllDirectory => &GetDllDirectoryW;

        [NativeTypeName("#define BASE_SEARCH_PATH_ENABLE_SAFE_SEARCHMODE 0x1")]
        public const int BASE_SEARCH_PATH_ENABLE_SAFE_SEARCHMODE = 0x1;

        [NativeTypeName("#define BASE_SEARCH_PATH_DISABLE_SAFE_SEARCHMODE 0x10000")]
        public const int BASE_SEARCH_PATH_DISABLE_SAFE_SEARCHMODE = 0x10000;

        [NativeTypeName("#define BASE_SEARCH_PATH_PERMANENT 0x8000")]
        public const int BASE_SEARCH_PATH_PERMANENT = 0x8000;

        [NativeTypeName("#define BASE_SEARCH_PATH_INVALID_FLAGS ~0x18001")]
        public const int BASE_SEARCH_PATH_INVALID_FLAGS = ~0x18001;

        [NativeTypeName("#define CreateDirectoryEx CreateDirectoryExW")]
        public static delegate*<ushort*, ushort*, SECURITY_ATTRIBUTES*, int> CreateDirectoryEx => &CreateDirectoryExW;

        [NativeTypeName("#define CreateDirectoryTransacted CreateDirectoryTransactedW")]
        public static delegate*<ushort*, ushort*, SECURITY_ATTRIBUTES*, IntPtr, int> CreateDirectoryTransacted => &CreateDirectoryTransactedW;

        [NativeTypeName("#define RemoveDirectoryTransacted RemoveDirectoryTransactedW")]
        public static delegate*<ushort*, IntPtr, int> RemoveDirectoryTransacted => &RemoveDirectoryTransactedW;

        [NativeTypeName("#define GetFullPathNameTransacted GetFullPathNameTransactedW")]
        public static delegate*<ushort*, uint, ushort*, ushort**, IntPtr, uint> GetFullPathNameTransacted => &GetFullPathNameTransactedW;

        [NativeTypeName("#define DDD_RAW_TARGET_PATH 0x00000001")]
        public const int DDD_RAW_TARGET_PATH = 0x00000001;

        [NativeTypeName("#define DDD_REMOVE_DEFINITION 0x00000002")]
        public const int DDD_REMOVE_DEFINITION = 0x00000002;

        [NativeTypeName("#define DDD_EXACT_MATCH_ON_REMOVE 0x00000004")]
        public const int DDD_EXACT_MATCH_ON_REMOVE = 0x00000004;

        [NativeTypeName("#define DDD_NO_BROADCAST_SYSTEM 0x00000008")]
        public const int DDD_NO_BROADCAST_SYSTEM = 0x00000008;

        [NativeTypeName("#define DDD_LUID_BROADCAST_DRIVE 0x00000010")]
        public const int DDD_LUID_BROADCAST_DRIVE = 0x00000010;

        [NativeTypeName("#define CreateFileTransacted CreateFileTransactedW")]
        public static delegate*<ushort*, uint, uint, SECURITY_ATTRIBUTES*, uint, uint, IntPtr, IntPtr, ushort*, void*, IntPtr> CreateFileTransacted => &CreateFileTransactedW;

        [NativeTypeName("#define SetFileAttributesTransacted SetFileAttributesTransactedW")]
        public static delegate*<ushort*, uint, IntPtr, int> SetFileAttributesTransacted => &SetFileAttributesTransactedW;

        [NativeTypeName("#define GetFileAttributesTransacted GetFileAttributesTransactedW")]
        public static delegate*<ushort*, GET_FILEEX_INFO_LEVELS, void*, IntPtr, int> GetFileAttributesTransacted => &GetFileAttributesTransactedW;

        [NativeTypeName("#define GetCompressedFileSizeTransacted GetCompressedFileSizeTransactedW")]
        public static delegate*<ushort*, uint*, IntPtr, uint> GetCompressedFileSizeTransacted => &GetCompressedFileSizeTransactedW;

        [NativeTypeName("#define DeleteFileTransacted DeleteFileTransactedW")]
        public static delegate*<ushort*, IntPtr, int> DeleteFileTransacted => &DeleteFileTransactedW;

        [NativeTypeName("#define CheckNameLegalDOS8Dot3 CheckNameLegalDOS8Dot3W")]
        public static delegate*<ushort*, sbyte*, uint, int*, int*, int> CheckNameLegalDOS8Dot3 => &CheckNameLegalDOS8Dot3W;

        [NativeTypeName("#define FindFirstFileTransacted FindFirstFileTransactedW")]
        public static delegate*<ushort*, FINDEX_INFO_LEVELS, void*, FINDEX_SEARCH_OPS, void*, uint, IntPtr, IntPtr> FindFirstFileTransacted => &FindFirstFileTransactedW;

        [NativeTypeName("#define CopyFile CopyFileW")]
        public static delegate*<ushort*, ushort*, int, int> CopyFile => &CopyFileW;

        [NativeTypeName("#define CopyFileEx CopyFileExW")]
        public static delegate*<ushort*, ushort*, delegate* unmanaged<LARGE_INTEGER, LARGE_INTEGER, LARGE_INTEGER, LARGE_INTEGER, uint, uint, IntPtr, IntPtr, void*, uint>, void*, int*, uint, int> CopyFileEx => &CopyFileExW;

        [NativeTypeName("#define CopyFileTransacted CopyFileTransactedW")]
        public static delegate*<ushort*, ushort*, delegate* unmanaged<LARGE_INTEGER, LARGE_INTEGER, LARGE_INTEGER, LARGE_INTEGER, uint, uint, IntPtr, IntPtr, void*, uint>, void*, int*, uint, IntPtr, int> CopyFileTransacted => &CopyFileTransactedW;

        [NativeTypeName("#define COPYFILE2_MESSAGE_COPY_OFFLOAD (0x00000001L)")]
        public const int COPYFILE2_MESSAGE_COPY_OFFLOAD = (0x00000001);

        [NativeTypeName("#define COPYFILE2_IO_CYCLE_SIZE_MIN 4096")]
        public const int COPYFILE2_IO_CYCLE_SIZE_MIN = 4096;

        [NativeTypeName("#define COPYFILE2_IO_CYCLE_SIZE_MAX 0x40000000")]
        public const int COPYFILE2_IO_CYCLE_SIZE_MAX = 0x40000000;

        [NativeTypeName("#define COPYFILE2_IO_RATE_MIN 512")]
        public const int COPYFILE2_IO_RATE_MIN = 512;

        [NativeTypeName("#define MoveFile MoveFileW")]
        public static delegate*<ushort*, ushort*, int> MoveFile => &MoveFileW;

        [NativeTypeName("#define MoveFileEx MoveFileExW")]
        public static delegate*<ushort*, ushort*, uint, int> MoveFileEx => &MoveFileExW;

        [NativeTypeName("#define MoveFileWithProgress MoveFileWithProgressW")]
        public static delegate*<ushort*, ushort*, delegate* unmanaged<LARGE_INTEGER, LARGE_INTEGER, LARGE_INTEGER, LARGE_INTEGER, uint, uint, IntPtr, IntPtr, void*, uint>, void*, uint, int> MoveFileWithProgress => &MoveFileWithProgressW;

        [NativeTypeName("#define MoveFileTransacted MoveFileTransactedW")]
        public static delegate*<ushort*, ushort*, delegate* unmanaged<LARGE_INTEGER, LARGE_INTEGER, LARGE_INTEGER, LARGE_INTEGER, uint, uint, IntPtr, IntPtr, void*, uint>, void*, uint, IntPtr, int> MoveFileTransacted => &MoveFileTransactedW;

        [NativeTypeName("#define MOVEFILE_REPLACE_EXISTING 0x00000001")]
        public const int MOVEFILE_REPLACE_EXISTING = 0x00000001;

        [NativeTypeName("#define MOVEFILE_COPY_ALLOWED 0x00000002")]
        public const int MOVEFILE_COPY_ALLOWED = 0x00000002;

        [NativeTypeName("#define MOVEFILE_DELAY_UNTIL_REBOOT 0x00000004")]
        public const int MOVEFILE_DELAY_UNTIL_REBOOT = 0x00000004;

        [NativeTypeName("#define MOVEFILE_WRITE_THROUGH 0x00000008")]
        public const int MOVEFILE_WRITE_THROUGH = 0x00000008;

        [NativeTypeName("#define MOVEFILE_CREATE_HARDLINK 0x00000010")]
        public const int MOVEFILE_CREATE_HARDLINK = 0x00000010;

        [NativeTypeName("#define MOVEFILE_FAIL_IF_NOT_TRACKABLE 0x00000020")]
        public const int MOVEFILE_FAIL_IF_NOT_TRACKABLE = 0x00000020;

        [NativeTypeName("#define ReplaceFile ReplaceFileW")]
        public static delegate*<ushort*, ushort*, ushort*, uint, void*, void*, int> ReplaceFile => &ReplaceFileW;

        [NativeTypeName("#define CreateHardLink CreateHardLinkW")]
        public static delegate*<ushort*, ushort*, SECURITY_ATTRIBUTES*, int> CreateHardLink => &CreateHardLinkW;

        [NativeTypeName("#define CreateHardLinkTransacted CreateHardLinkTransactedW")]
        public static delegate*<ushort*, ushort*, SECURITY_ATTRIBUTES*, IntPtr, int> CreateHardLinkTransacted => &CreateHardLinkTransactedW;

        [NativeTypeName("#define SetVolumeLabel SetVolumeLabelW")]
        public static delegate*<ushort*, ushort*, int> SetVolumeLabel => &SetVolumeLabelW;

        [NativeTypeName("#define ClearEventLog ClearEventLogW")]
        public static delegate*<IntPtr, ushort*, int> ClearEventLog => &ClearEventLogW;

        [NativeTypeName("#define BackupEventLog BackupEventLogW")]
        public static delegate*<IntPtr, ushort*, int> BackupEventLog => &BackupEventLogW;

        [NativeTypeName("#define OpenEventLog OpenEventLogW")]
        public static delegate*<ushort*, ushort*, IntPtr> OpenEventLog => &OpenEventLogW;

        [NativeTypeName("#define RegisterEventSource RegisterEventSourceW")]
        public static delegate*<ushort*, ushort*, IntPtr> RegisterEventSource => &RegisterEventSourceW;

        [NativeTypeName("#define OpenBackupEventLog OpenBackupEventLogW")]
        public static delegate*<ushort*, ushort*, IntPtr> OpenBackupEventLog => &OpenBackupEventLogW;

        [NativeTypeName("#define ReadEventLog ReadEventLogW")]
        public static delegate*<IntPtr, uint, uint, void*, uint, uint*, uint*, int> ReadEventLog => &ReadEventLogW;

        [NativeTypeName("#define ReportEvent ReportEventW")]
        public static delegate*<IntPtr, ushort, ushort, uint, void*, ushort, uint, ushort**, void*, int> ReportEvent => &ReportEventW;

        [NativeTypeName("#define EVENTLOG_FULL_INFO 0")]
        public const int EVENTLOG_FULL_INFO = 0;

        [NativeTypeName("#define OPERATION_API_VERSION 1")]
        public const int OPERATION_API_VERSION = 1;

        [NativeTypeName("#define OPERATION_START_TRACE_CURRENT_THREAD 0x1")]
        public const int OPERATION_START_TRACE_CURRENT_THREAD = 0x1;

        [NativeTypeName("#define OPERATION_END_DISCARD 0x1")]
        public const int OPERATION_END_DISCARD = 0x1;

        [NativeTypeName("#define IsBadStringPtr IsBadStringPtrW")]
        public static delegate*<ushort*, nuint, int> IsBadStringPtr => &IsBadStringPtrW;

        [NativeTypeName("#define LookupAccountSid LookupAccountSidW")]
        public static delegate*<ushort*, void*, ushort*, uint*, ushort*, uint*, SID_NAME_USE*, int> LookupAccountSid => &LookupAccountSidW;

        [NativeTypeName("#define LookupAccountName LookupAccountNameW")]
        public static delegate*<ushort*, ushort*, void*, uint*, ushort*, uint*, SID_NAME_USE*, int> LookupAccountName => &LookupAccountNameW;

        [NativeTypeName("#define LookupAccountSidLocal LookupAccountSidLocalW")]
        public static delegate*<void*, ushort*, uint*, ushort*, uint*, SID_NAME_USE*, int> LookupAccountSidLocal => &LookupAccountSidLocalW;

        [NativeTypeName("#define LookupPrivilegeValue LookupPrivilegeValueW")]
        public static delegate*<ushort*, ushort*, LUID*, int> LookupPrivilegeValue => &LookupPrivilegeValueW;

        [NativeTypeName("#define LookupPrivilegeName LookupPrivilegeNameW")]
        public static delegate*<ushort*, LUID*, ushort*, uint*, int> LookupPrivilegeName => &LookupPrivilegeNameW;

        [NativeTypeName("#define LookupPrivilegeDisplayName LookupPrivilegeDisplayNameW")]
        public static delegate*<ushort*, ushort*, ushort*, uint*, uint*, int> LookupPrivilegeDisplayName => &LookupPrivilegeDisplayNameW;

        [NativeTypeName("#define BuildCommDCB BuildCommDCBW")]
        public static delegate*<ushort*, DCB*, int> BuildCommDCB => &BuildCommDCBW;

        [NativeTypeName("#define BuildCommDCBAndTimeouts BuildCommDCBAndTimeoutsW")]
        public static delegate*<ushort*, DCB*, COMMTIMEOUTS*, int> BuildCommDCBAndTimeouts => &BuildCommDCBAndTimeoutsW;

        [NativeTypeName("#define CommConfigDialog CommConfigDialogW")]
        public static delegate*<ushort*, IntPtr, COMMCONFIG*, int> CommConfigDialog => &CommConfigDialogW;

        [NativeTypeName("#define GetDefaultCommConfig GetDefaultCommConfigW")]
        public static delegate*<ushort*, COMMCONFIG*, uint*, int> GetDefaultCommConfig => &GetDefaultCommConfigW;

        [NativeTypeName("#define SetDefaultCommConfig SetDefaultCommConfigW")]
        public static delegate*<ushort*, COMMCONFIG*, uint, int> SetDefaultCommConfig => &SetDefaultCommConfigW;

        [NativeTypeName("#define MAX_COMPUTERNAME_LENGTH 15")]
        public const int MAX_COMPUTERNAME_LENGTH = 15;

        [NativeTypeName("#define GetComputerName GetComputerNameW")]
        public static delegate*<ushort*, uint*, int> GetComputerName => &GetComputerNameW;

        [NativeTypeName("#define DnsHostnameToComputerName DnsHostnameToComputerNameW")]
        public static delegate*<ushort*, ushort*, uint*, int> DnsHostnameToComputerName => &DnsHostnameToComputerNameW;

        [NativeTypeName("#define GetUserName GetUserNameW")]
        public static delegate*<ushort*, uint*, int> GetUserName => &GetUserNameW;

        [NativeTypeName("#define LOGON32_LOGON_INTERACTIVE 2")]
        public const int LOGON32_LOGON_INTERACTIVE = 2;

        [NativeTypeName("#define LOGON32_LOGON_NETWORK 3")]
        public const int LOGON32_LOGON_NETWORK = 3;

        [NativeTypeName("#define LOGON32_LOGON_BATCH 4")]
        public const int LOGON32_LOGON_BATCH = 4;

        [NativeTypeName("#define LOGON32_LOGON_SERVICE 5")]
        public const int LOGON32_LOGON_SERVICE = 5;

        [NativeTypeName("#define LOGON32_LOGON_UNLOCK 7")]
        public const int LOGON32_LOGON_UNLOCK = 7;

        [NativeTypeName("#define LOGON32_LOGON_NETWORK_CLEARTEXT 8")]
        public const int LOGON32_LOGON_NETWORK_CLEARTEXT = 8;

        [NativeTypeName("#define LOGON32_LOGON_NEW_CREDENTIALS 9")]
        public const int LOGON32_LOGON_NEW_CREDENTIALS = 9;

        [NativeTypeName("#define LOGON32_PROVIDER_DEFAULT 0")]
        public const int LOGON32_PROVIDER_DEFAULT = 0;

        [NativeTypeName("#define LOGON32_PROVIDER_WINNT35 1")]
        public const int LOGON32_PROVIDER_WINNT35 = 1;

        [NativeTypeName("#define LOGON32_PROVIDER_WINNT40 2")]
        public const int LOGON32_PROVIDER_WINNT40 = 2;

        [NativeTypeName("#define LOGON32_PROVIDER_WINNT50 3")]
        public const int LOGON32_PROVIDER_WINNT50 = 3;

        [NativeTypeName("#define LOGON32_PROVIDER_VIRTUAL 4")]
        public const int LOGON32_PROVIDER_VIRTUAL = 4;

        [NativeTypeName("#define LogonUser LogonUserW")]
        public static delegate*<ushort*, ushort*, ushort*, uint, uint, IntPtr*, int> LogonUser => &LogonUserW;

        [NativeTypeName("#define LogonUserEx LogonUserExW")]
        public static delegate*<ushort*, ushort*, ushort*, uint, uint, IntPtr*, void**, void**, uint*, QUOTA_LIMITS*, int> LogonUserEx => &LogonUserExW;

        [NativeTypeName("#define LOGON_WITH_PROFILE 0x00000001")]
        public const int LOGON_WITH_PROFILE = 0x00000001;

        [NativeTypeName("#define LOGON_NETCREDENTIALS_ONLY 0x00000002")]
        public const int LOGON_NETCREDENTIALS_ONLY = 0x00000002;

        [NativeTypeName("#define LOGON_ZERO_PASSWORD_BUFFER 0x80000000")]
        public const uint LOGON_ZERO_PASSWORD_BUFFER = 0x80000000;

        [NativeTypeName("#define CreatePrivateNamespace CreatePrivateNamespaceW")]
        public static delegate*<SECURITY_ATTRIBUTES*, void*, ushort*, IntPtr> CreatePrivateNamespace => &CreatePrivateNamespaceW;

        [NativeTypeName("#define OpenPrivateNamespace OpenPrivateNamespaceW")]
        public static delegate*<void*, ushort*, IntPtr> OpenPrivateNamespace => &OpenPrivateNamespaceW;

        [NativeTypeName("#define CreateBoundaryDescriptor CreateBoundaryDescriptorW")]
        public static delegate*<ushort*, uint, IntPtr> CreateBoundaryDescriptor => &CreateBoundaryDescriptorW;

        [NativeTypeName("#define HW_PROFILE_GUIDLEN 39")]
        public const int HW_PROFILE_GUIDLEN = 39;

        [NativeTypeName("#define MAX_PROFILE_LEN 80")]
        public const int MAX_PROFILE_LEN = 80;

        [NativeTypeName("#define DOCKINFO_UNDOCKED (0x1)")]
        public const int DOCKINFO_UNDOCKED = (0x1);

        [NativeTypeName("#define DOCKINFO_DOCKED (0x2)")]
        public const int DOCKINFO_DOCKED = (0x2);

        [NativeTypeName("#define DOCKINFO_USER_SUPPLIED (0x4)")]
        public const int DOCKINFO_USER_SUPPLIED = (0x4);

        [NativeTypeName("#define DOCKINFO_USER_UNDOCKED (DOCKINFO_USER_SUPPLIED | DOCKINFO_UNDOCKED)")]
        public const int DOCKINFO_USER_UNDOCKED = ((0x4) | (0x1));

        [NativeTypeName("#define DOCKINFO_USER_DOCKED (DOCKINFO_USER_SUPPLIED | DOCKINFO_DOCKED)")]
        public const int DOCKINFO_USER_DOCKED = ((0x4) | (0x2));

        [NativeTypeName("#define GetCurrentHwProfile GetCurrentHwProfileW")]
        public static delegate*<HW_PROFILE_INFOW*, int> GetCurrentHwProfile => &GetCurrentHwProfileW;

        [NativeTypeName("#define VerifyVersionInfo VerifyVersionInfoW")]
        public static delegate*<OSVERSIONINFOEXW*, uint, ulong, int> VerifyVersionInfo => &VerifyVersionInfoW;

        [NativeTypeName("#define TC_NORMAL 0")]
        public const int TC_NORMAL = 0;

        [NativeTypeName("#define TC_HARDERR 1")]
        public const int TC_HARDERR = 1;

        [NativeTypeName("#define TC_GP_TRAP 2")]
        public const int TC_GP_TRAP = 2;

        [NativeTypeName("#define TC_SIGNAL 3")]
        public const int TC_SIGNAL = 3;

        [NativeTypeName("#define AC_LINE_OFFLINE 0x00")]
        public const int AC_LINE_OFFLINE = 0x00;

        [NativeTypeName("#define AC_LINE_ONLINE 0x01")]
        public const int AC_LINE_ONLINE = 0x01;

        [NativeTypeName("#define AC_LINE_BACKUP_POWER 0x02")]
        public const int AC_LINE_BACKUP_POWER = 0x02;

        [NativeTypeName("#define AC_LINE_UNKNOWN 0xFF")]
        public const int AC_LINE_UNKNOWN = 0xFF;

        [NativeTypeName("#define BATTERY_FLAG_HIGH 0x01")]
        public const int BATTERY_FLAG_HIGH = 0x01;

        [NativeTypeName("#define BATTERY_FLAG_LOW 0x02")]
        public const int BATTERY_FLAG_LOW = 0x02;

        [NativeTypeName("#define BATTERY_FLAG_CRITICAL 0x04")]
        public const int BATTERY_FLAG_CRITICAL = 0x04;

        [NativeTypeName("#define BATTERY_FLAG_CHARGING 0x08")]
        public const int BATTERY_FLAG_CHARGING = 0x08;

        [NativeTypeName("#define BATTERY_FLAG_NO_BATTERY 0x80")]
        public const int BATTERY_FLAG_NO_BATTERY = 0x80;

        [NativeTypeName("#define BATTERY_FLAG_UNKNOWN 0xFF")]
        public const int BATTERY_FLAG_UNKNOWN = 0xFF;

        [NativeTypeName("#define BATTERY_PERCENTAGE_UNKNOWN 0xFF")]
        public const int BATTERY_PERCENTAGE_UNKNOWN = 0xFF;

        [NativeTypeName("#define SYSTEM_STATUS_FLAG_POWER_SAVING_ON 0x01")]
        public const int SYSTEM_STATUS_FLAG_POWER_SAVING_ON = 0x01;

        [NativeTypeName("#define BATTERY_LIFE_UNKNOWN 0xFFFFFFFF")]
        public const uint BATTERY_LIFE_UNKNOWN = 0xFFFFFFFF;

        [NativeTypeName("#define CreateJobObject CreateJobObjectW")]
        public static delegate*<SECURITY_ATTRIBUTES*, ushort*, IntPtr> CreateJobObject => &CreateJobObjectW;

        [NativeTypeName("#define OpenJobObject OpenJobObjectW")]
        public static delegate*<uint, int, ushort*, IntPtr> OpenJobObject => &OpenJobObjectW;

        [NativeTypeName("#define FindFirstVolumeMountPoint FindFirstVolumeMountPointW")]
        public static delegate*<ushort*, ushort*, uint, IntPtr> FindFirstVolumeMountPoint => &FindFirstVolumeMountPointW;

        [NativeTypeName("#define FindNextVolumeMountPoint FindNextVolumeMountPointW")]
        public static delegate*<IntPtr, ushort*, uint, int> FindNextVolumeMountPoint => &FindNextVolumeMountPointW;

        [NativeTypeName("#define SetVolumeMountPoint SetVolumeMountPointW")]
        public static delegate*<ushort*, ushort*, int> SetVolumeMountPoint => &SetVolumeMountPointW;

        [NativeTypeName("#define ACTCTX_FLAG_PROCESSOR_ARCHITECTURE_VALID (0x00000001)")]
        public const int ACTCTX_FLAG_PROCESSOR_ARCHITECTURE_VALID = (0x00000001);

        [NativeTypeName("#define ACTCTX_FLAG_LANGID_VALID (0x00000002)")]
        public const int ACTCTX_FLAG_LANGID_VALID = (0x00000002);

        [NativeTypeName("#define ACTCTX_FLAG_ASSEMBLY_DIRECTORY_VALID (0x00000004)")]
        public const int ACTCTX_FLAG_ASSEMBLY_DIRECTORY_VALID = (0x00000004);

        [NativeTypeName("#define ACTCTX_FLAG_RESOURCE_NAME_VALID (0x00000008)")]
        public const int ACTCTX_FLAG_RESOURCE_NAME_VALID = (0x00000008);

        [NativeTypeName("#define ACTCTX_FLAG_SET_PROCESS_DEFAULT (0x00000010)")]
        public const int ACTCTX_FLAG_SET_PROCESS_DEFAULT = (0x00000010);

        [NativeTypeName("#define ACTCTX_FLAG_APPLICATION_NAME_VALID (0x00000020)")]
        public const int ACTCTX_FLAG_APPLICATION_NAME_VALID = (0x00000020);

        [NativeTypeName("#define ACTCTX_FLAG_SOURCE_IS_ASSEMBLYREF (0x00000040)")]
        public const int ACTCTX_FLAG_SOURCE_IS_ASSEMBLYREF = (0x00000040);

        [NativeTypeName("#define ACTCTX_FLAG_HMODULE_VALID (0x00000080)")]
        public const int ACTCTX_FLAG_HMODULE_VALID = (0x00000080);

        [NativeTypeName("#define CreateActCtx CreateActCtxW")]
        public static delegate*<ACTCTXW*, IntPtr> CreateActCtx => &CreateActCtxW;

        [NativeTypeName("#define DEACTIVATE_ACTCTX_FLAG_FORCE_EARLY_DEACTIVATION (0x00000001)")]
        public const int DEACTIVATE_ACTCTX_FLAG_FORCE_EARLY_DEACTIVATION = (0x00000001);

        [NativeTypeName("#define FIND_ACTCTX_SECTION_KEY_RETURN_HACTCTX (0x00000001)")]
        public const int FIND_ACTCTX_SECTION_KEY_RETURN_HACTCTX = (0x00000001);

        [NativeTypeName("#define FIND_ACTCTX_SECTION_KEY_RETURN_FLAGS (0x00000002)")]
        public const int FIND_ACTCTX_SECTION_KEY_RETURN_FLAGS = (0x00000002);

        [NativeTypeName("#define FIND_ACTCTX_SECTION_KEY_RETURN_ASSEMBLY_METADATA (0x00000004)")]
        public const int FIND_ACTCTX_SECTION_KEY_RETURN_ASSEMBLY_METADATA = (0x00000004);

        [NativeTypeName("#define FindActCtxSectionString FindActCtxSectionStringW")]
        public static delegate*<uint, Guid*, uint, ushort*, ACTCTX_SECTION_KEYED_DATA*, int> FindActCtxSectionString => &FindActCtxSectionStringW;

        [NativeTypeName("#define ACTIVATION_CONTEXT_BASIC_INFORMATION_DEFINED 1")]
        public const int ACTIVATION_CONTEXT_BASIC_INFORMATION_DEFINED = 1;

        [NativeTypeName("#define QUERY_ACTCTX_FLAG_USE_ACTIVE_ACTCTX (0x00000004)")]
        public const int QUERY_ACTCTX_FLAG_USE_ACTIVE_ACTCTX = (0x00000004);

        [NativeTypeName("#define QUERY_ACTCTX_FLAG_ACTCTX_IS_HMODULE (0x00000008)")]
        public const int QUERY_ACTCTX_FLAG_ACTCTX_IS_HMODULE = (0x00000008);

        [NativeTypeName("#define QUERY_ACTCTX_FLAG_ACTCTX_IS_ADDRESS (0x00000010)")]
        public const int QUERY_ACTCTX_FLAG_ACTCTX_IS_ADDRESS = (0x00000010);

        [NativeTypeName("#define QUERY_ACTCTX_FLAG_NO_ADDREF (0x80000000)")]
        public const uint QUERY_ACTCTX_FLAG_NO_ADDREF = (0x80000000);

        [NativeTypeName("#define RESTART_MAX_CMD_LINE 1024")]
        public const int RESTART_MAX_CMD_LINE = 1024;

        [NativeTypeName("#define RESTART_NO_CRASH 1")]
        public const int RESTART_NO_CRASH = 1;

        [NativeTypeName("#define RESTART_NO_HANG 2")]
        public const int RESTART_NO_HANG = 2;

        [NativeTypeName("#define RESTART_NO_PATCH 4")]
        public const int RESTART_NO_PATCH = 4;

        [NativeTypeName("#define RESTART_NO_REBOOT 8")]
        public const int RESTART_NO_REBOOT = 8;

        [NativeTypeName("#define RECOVERY_DEFAULT_PING_INTERVAL 5000")]
        public const int RECOVERY_DEFAULT_PING_INTERVAL = 5000;

        [NativeTypeName("#define RECOVERY_MAX_PING_INTERVAL (5 * 60 * 1000)")]
        public const int RECOVERY_MAX_PING_INTERVAL = (5 * 60 * 1000);

        [NativeTypeName("#define FILE_RENAME_FLAG_REPLACE_IF_EXISTS 0x00000001")]
        public const int FILE_RENAME_FLAG_REPLACE_IF_EXISTS = 0x00000001;

        [NativeTypeName("#define FILE_RENAME_FLAG_POSIX_SEMANTICS 0x00000002")]
        public const int FILE_RENAME_FLAG_POSIX_SEMANTICS = 0x00000002;

        [NativeTypeName("#define FILE_RENAME_FLAG_SUPPRESS_PIN_STATE_INHERITANCE 0x00000004")]
        public const int FILE_RENAME_FLAG_SUPPRESS_PIN_STATE_INHERITANCE = 0x00000004;

        [NativeTypeName("#define FILE_DISPOSITION_FLAG_DO_NOT_DELETE 0x00000000")]
        public const int FILE_DISPOSITION_FLAG_DO_NOT_DELETE = 0x00000000;

        [NativeTypeName("#define FILE_DISPOSITION_FLAG_DELETE 0x00000001")]
        public const int FILE_DISPOSITION_FLAG_DELETE = 0x00000001;

        [NativeTypeName("#define FILE_DISPOSITION_FLAG_POSIX_SEMANTICS 0x00000002")]
        public const int FILE_DISPOSITION_FLAG_POSIX_SEMANTICS = 0x00000002;

        [NativeTypeName("#define FILE_DISPOSITION_FLAG_FORCE_IMAGE_SECTION_CHECK 0x00000004")]
        public const int FILE_DISPOSITION_FLAG_FORCE_IMAGE_SECTION_CHECK = 0x00000004;

        [NativeTypeName("#define FILE_DISPOSITION_FLAG_ON_CLOSE 0x00000008")]
        public const int FILE_DISPOSITION_FLAG_ON_CLOSE = 0x00000008;

        [NativeTypeName("#define FILE_DISPOSITION_FLAG_IGNORE_READONLY_ATTRIBUTE 0x00000010")]
        public const int FILE_DISPOSITION_FLAG_IGNORE_READONLY_ATTRIBUTE = 0x00000010;

        [NativeTypeName("#define STORAGE_INFO_FLAGS_ALIGNED_DEVICE 0x00000001")]
        public const int STORAGE_INFO_FLAGS_ALIGNED_DEVICE = 0x00000001;

        [NativeTypeName("#define STORAGE_INFO_FLAGS_PARTITION_ALIGNED_ON_DEVICE 0x00000002")]
        public const int STORAGE_INFO_FLAGS_PARTITION_ALIGNED_ON_DEVICE = 0x00000002;

        [NativeTypeName("#define STORAGE_INFO_OFFSET_UNKNOWN (0xffffffff)")]
        public const uint STORAGE_INFO_OFFSET_UNKNOWN = (0xffffffff);

        [NativeTypeName("#define REMOTE_PROTOCOL_INFO_FLAG_LOOPBACK 0x00000001")]
        public const int REMOTE_PROTOCOL_INFO_FLAG_LOOPBACK = 0x00000001;

        [NativeTypeName("#define REMOTE_PROTOCOL_INFO_FLAG_OFFLINE 0x00000002")]
        public const int REMOTE_PROTOCOL_INFO_FLAG_OFFLINE = 0x00000002;

        [NativeTypeName("#define REMOTE_PROTOCOL_INFO_FLAG_PERSISTENT_HANDLE 0x00000004")]
        public const int REMOTE_PROTOCOL_INFO_FLAG_PERSISTENT_HANDLE = 0x00000004;

        [NativeTypeName("#define RPI_FLAG_SMB2_SHARECAP_TIMEWARP 0x00000002")]
        public const int RPI_FLAG_SMB2_SHARECAP_TIMEWARP = 0x00000002;

        [NativeTypeName("#define RPI_FLAG_SMB2_SHARECAP_DFS 0x00000008")]
        public const int RPI_FLAG_SMB2_SHARECAP_DFS = 0x00000008;

        [NativeTypeName("#define RPI_FLAG_SMB2_SHARECAP_CONTINUOUS_AVAILABILITY 0x00000010")]
        public const int RPI_FLAG_SMB2_SHARECAP_CONTINUOUS_AVAILABILITY = 0x00000010;

        [NativeTypeName("#define RPI_FLAG_SMB2_SHARECAP_SCALEOUT 0x00000020")]
        public const int RPI_FLAG_SMB2_SHARECAP_SCALEOUT = 0x00000020;

        [NativeTypeName("#define RPI_FLAG_SMB2_SHARECAP_CLUSTER 0x00000040")]
        public const int RPI_FLAG_SMB2_SHARECAP_CLUSTER = 0x00000040;

        [NativeTypeName("#define RPI_SMB2_FLAG_SERVERCAP_DFS 0x00000001")]
        public const int RPI_SMB2_FLAG_SERVERCAP_DFS = 0x00000001;

        [NativeTypeName("#define RPI_SMB2_FLAG_SERVERCAP_LEASING 0x00000002")]
        public const int RPI_SMB2_FLAG_SERVERCAP_LEASING = 0x00000002;

        [NativeTypeName("#define RPI_SMB2_FLAG_SERVERCAP_LARGEMTU 0x00000004")]
        public const int RPI_SMB2_FLAG_SERVERCAP_LARGEMTU = 0x00000004;

        [NativeTypeName("#define RPI_SMB2_FLAG_SERVERCAP_MULTICHANNEL 0x00000008")]
        public const int RPI_SMB2_FLAG_SERVERCAP_MULTICHANNEL = 0x00000008;

        [NativeTypeName("#define RPI_SMB2_FLAG_SERVERCAP_PERSISTENT_HANDLES 0x00000010")]
        public const int RPI_SMB2_FLAG_SERVERCAP_PERSISTENT_HANDLES = 0x00000010;

        [NativeTypeName("#define RPI_SMB2_FLAG_SERVERCAP_DIRECTORY_LEASING 0x00000020")]
        public const int RPI_SMB2_FLAG_SERVERCAP_DIRECTORY_LEASING = 0x00000020;

        [NativeTypeName("#define SYMBOLIC_LINK_FLAG_DIRECTORY (0x1)")]
        public const int SYMBOLIC_LINK_FLAG_DIRECTORY = (0x1);

        [NativeTypeName("#define SYMBOLIC_LINK_FLAG_ALLOW_UNPRIVILEGED_CREATE (0x2)")]
        public const int SYMBOLIC_LINK_FLAG_ALLOW_UNPRIVILEGED_CREATE = (0x2);

        [NativeTypeName("#define CreateSymbolicLink CreateSymbolicLinkW")]
        public static delegate*<ushort*, ushort*, uint, byte> CreateSymbolicLink => &CreateSymbolicLinkW;

        [NativeTypeName("#define CreateSymbolicLinkTransacted CreateSymbolicLinkTransactedW")]
        public static delegate*<ushort*, ushort*, uint, IntPtr, byte> CreateSymbolicLinkTransacted => &CreateSymbolicLinkTransactedW;

        [NativeTypeName("#define MICROSOFT_WINBASE_H_DEFINE_INTERLOCKED_CPLUSPLUS_OVERLOADS 0")]
        public const int MICROSOFT_WINBASE_H_DEFINE_INTERLOCKED_CPLUSPLUS_OVERLOADS = 0;
    }
}
