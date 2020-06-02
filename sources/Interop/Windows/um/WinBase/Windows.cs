// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinBase.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        [DllImport("kernel32", EntryPoint = "WinMain", ExactSpelling = true)]
        public static extern int WinMain([NativeTypeName("HINSTANCE")] IntPtr hInstance, [NativeTypeName("HINSTANCE")] IntPtr hPrevInstance, [NativeTypeName("LPSTR")] sbyte* lpCmdLine, int nShowCmd);

        [DllImport("kernel32", EntryPoint = "wWinMain", ExactSpelling = true)]
        public static extern int wWinMain([NativeTypeName("HINSTANCE")] IntPtr hInstance, [NativeTypeName("HINSTANCE")] IntPtr hPrevInstance, [NativeTypeName("LPWSTR")] ushort* lpCmdLine, int nShowCmd);

        [DllImport("kernel32", EntryPoint = "GlobalAlloc", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("HGLOBAL")]
        public static extern IntPtr GlobalAlloc([NativeTypeName("UINT")] uint uFlags, [NativeTypeName("SIZE_T")] nuint dwBytes);

        [DllImport("kernel32", EntryPoint = "GlobalReAlloc", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("HGLOBAL")]
        public static extern IntPtr GlobalReAlloc([NativeTypeName("HGLOBAL")] IntPtr hMem, [NativeTypeName("SIZE_T")] nuint dwBytes, [NativeTypeName("UINT")] uint uFlags);

        [DllImport("kernel32", EntryPoint = "GlobalSize", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("SIZE_T")]
        public static extern nuint GlobalSize([NativeTypeName("HGLOBAL")] IntPtr hMem);

        [DllImport("kernel32", EntryPoint = "GlobalUnlock", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GlobalUnlock([NativeTypeName("HGLOBAL")] IntPtr hMem);

        [DllImport("kernel32", EntryPoint = "GlobalLock", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("LPVOID")]
        public static extern void* GlobalLock([NativeTypeName("HGLOBAL")] IntPtr hMem);

        [DllImport("kernel32", EntryPoint = "GlobalFlags", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint GlobalFlags([NativeTypeName("HGLOBAL")] IntPtr hMem);

        [DllImport("kernel32", EntryPoint = "GlobalHandle", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("HGLOBAL")]
        public static extern IntPtr GlobalHandle([NativeTypeName("LPCVOID")] void* pMem);

        [DllImport("kernel32", EntryPoint = "GlobalFree", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("HGLOBAL")]
        public static extern IntPtr GlobalFree([NativeTypeName("HGLOBAL")] IntPtr hMem);

        [DllImport("kernel32", EntryPoint = "GlobalCompact", ExactSpelling = true)]
        [return: NativeTypeName("SIZE_T")]
        public static extern nuint GlobalCompact([NativeTypeName("DWORD")] uint dwMinFree);

        [DllImport("kernel32", EntryPoint = "GlobalFix", ExactSpelling = true)]
        public static extern void GlobalFix([NativeTypeName("HGLOBAL")] IntPtr hMem);

        [DllImport("kernel32", EntryPoint = "GlobalUnfix", ExactSpelling = true)]
        public static extern void GlobalUnfix([NativeTypeName("HGLOBAL")] IntPtr hMem);

        [DllImport("kernel32", EntryPoint = "GlobalWire", ExactSpelling = true)]
        [return: NativeTypeName("LPVOID")]
        public static extern void* GlobalWire([NativeTypeName("HGLOBAL")] IntPtr hMem);

        [DllImport("kernel32", EntryPoint = "GlobalUnWire", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GlobalUnWire([NativeTypeName("HGLOBAL")] IntPtr hMem);

        [DllImport("kernel32", EntryPoint = "GlobalMemoryStatus", ExactSpelling = true)]
        public static extern void GlobalMemoryStatus([NativeTypeName("LPMEMORYSTATUS")] MEMORYSTATUS* lpBuffer);

        [DllImport("kernel32", EntryPoint = "LocalAlloc", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("HLOCAL")]
        public static extern IntPtr LocalAlloc([NativeTypeName("UINT")] uint uFlags, [NativeTypeName("SIZE_T")] nuint uBytes);

        [DllImport("kernel32", EntryPoint = "LocalReAlloc", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("HLOCAL")]
        public static extern IntPtr LocalReAlloc([NativeTypeName("HLOCAL")] IntPtr hMem, [NativeTypeName("SIZE_T")] nuint uBytes, [NativeTypeName("UINT")] uint uFlags);

        [DllImport("kernel32", EntryPoint = "LocalLock", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("LPVOID")]
        public static extern void* LocalLock([NativeTypeName("HLOCAL")] IntPtr hMem);

        [DllImport("kernel32", EntryPoint = "LocalHandle", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("HLOCAL")]
        public static extern IntPtr LocalHandle([NativeTypeName("LPCVOID")] void* pMem);

        [DllImport("kernel32", EntryPoint = "LocalUnlock", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int LocalUnlock([NativeTypeName("HLOCAL")] IntPtr hMem);

        [DllImport("kernel32", EntryPoint = "LocalSize", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("SIZE_T")]
        public static extern nuint LocalSize([NativeTypeName("HLOCAL")] IntPtr hMem);

        [DllImport("kernel32", EntryPoint = "LocalFlags", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint LocalFlags([NativeTypeName("HLOCAL")] IntPtr hMem);

        [DllImport("kernel32", EntryPoint = "LocalFree", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("HLOCAL")]
        public static extern IntPtr LocalFree([NativeTypeName("HLOCAL")] IntPtr hMem);

        [DllImport("kernel32", EntryPoint = "LocalShrink", ExactSpelling = true)]
        [return: NativeTypeName("SIZE_T")]
        public static extern nuint LocalShrink([NativeTypeName("HLOCAL")] IntPtr hMem, [NativeTypeName("UINT")] uint cbNewSize);

        [DllImport("kernel32", EntryPoint = "LocalCompact", ExactSpelling = true)]
        [return: NativeTypeName("SIZE_T")]
        public static extern nuint LocalCompact([NativeTypeName("UINT")] uint uMinFree);

        [DllImport("kernel32", EntryPoint = "GetBinaryTypeA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetBinaryTypeA([NativeTypeName("LPCSTR")] sbyte* lpApplicationName, [NativeTypeName("LPDWORD")] uint* lpBinaryType);

        [DllImport("kernel32", EntryPoint = "GetBinaryTypeW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetBinaryTypeW([NativeTypeName("LPCWSTR")] ushort* lpApplicationName, [NativeTypeName("LPDWORD")] uint* lpBinaryType);

        [DllImport("kernel32", EntryPoint = "GetShortPathNameA", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetShortPathNameA([NativeTypeName("LPCSTR")] sbyte* lpszLongPath, [NativeTypeName("LPSTR")] sbyte* lpszShortPath, [NativeTypeName("DWORD")] uint cchBuffer);

        [DllImport("kernel32", EntryPoint = "GetLongPathNameTransactedA", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetLongPathNameTransactedA([NativeTypeName("LPCSTR")] sbyte* lpszShortPath, [NativeTypeName("LPSTR")] sbyte* lpszLongPath, [NativeTypeName("DWORD")] uint cchBuffer, [NativeTypeName("HANDLE")] IntPtr hTransaction);

        [DllImport("kernel32", EntryPoint = "GetLongPathNameTransactedW", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetLongPathNameTransactedW([NativeTypeName("LPCWSTR")] ushort* lpszShortPath, [NativeTypeName("LPWSTR")] ushort* lpszLongPath, [NativeTypeName("DWORD")] uint cchBuffer, [NativeTypeName("HANDLE")] IntPtr hTransaction);

        [DllImport("kernel32", EntryPoint = "GetProcessAffinityMask", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetProcessAffinityMask([NativeTypeName("HANDLE")] IntPtr hProcess, [NativeTypeName("PDWORD_PTR")] nuint* lpProcessAffinityMask, [NativeTypeName("PDWORD_PTR")] nuint* lpSystemAffinityMask);

        [DllImport("kernel32", EntryPoint = "SetProcessAffinityMask", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetProcessAffinityMask([NativeTypeName("HANDLE")] IntPtr hProcess, [NativeTypeName("DWORD_PTR")] nuint dwProcessAffinityMask);

        [DllImport("kernel32", EntryPoint = "GetProcessIoCounters", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetProcessIoCounters([NativeTypeName("HANDLE")] IntPtr hProcess, [NativeTypeName("PIO_COUNTERS")] IO_COUNTERS* lpIoCounters);

        [DllImport("kernel32", EntryPoint = "GetProcessWorkingSetSize", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetProcessWorkingSetSize([NativeTypeName("HANDLE")] IntPtr hProcess, [NativeTypeName("PSIZE_T")] nuint* lpMinimumWorkingSetSize, [NativeTypeName("PSIZE_T")] nuint* lpMaximumWorkingSetSize);

        [DllImport("kernel32", EntryPoint = "SetProcessWorkingSetSize", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetProcessWorkingSetSize([NativeTypeName("HANDLE")] IntPtr hProcess, [NativeTypeName("SIZE_T")] nuint dwMinimumWorkingSetSize, [NativeTypeName("SIZE_T")] nuint dwMaximumWorkingSetSize);

        [DllImport("kernel32", EntryPoint = "FatalExit", ExactSpelling = true)]
        public static extern void FatalExit(int ExitCode);

        [DllImport("kernel32", EntryPoint = "SetEnvironmentStringsA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetEnvironmentStringsA([NativeTypeName("LPCH")] sbyte* NewEnvironment);

        [DllImport("kernel32", EntryPoint = "SwitchToFiber", ExactSpelling = true)]
        public static extern void SwitchToFiber([NativeTypeName("LPVOID")] void* lpFiber);

        [DllImport("kernel32", EntryPoint = "DeleteFiber", ExactSpelling = true)]
        public static extern void DeleteFiber([NativeTypeName("LPVOID")] void* lpFiber);

        [DllImport("kernel32", EntryPoint = "ConvertFiberToThread", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ConvertFiberToThread();

        [DllImport("kernel32", EntryPoint = "CreateFiberEx", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("LPVOID")]
        public static extern void* CreateFiberEx([NativeTypeName("SIZE_T")] nuint dwStackCommitSize, [NativeTypeName("SIZE_T")] nuint dwStackReserveSize, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LPFIBER_START_ROUTINE")] delegate* stdcall<void*, void> lpStartAddress, [NativeTypeName("LPVOID")] void* lpParameter);

        [DllImport("kernel32", EntryPoint = "ConvertThreadToFiberEx", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("LPVOID")]
        public static extern void* ConvertThreadToFiberEx([NativeTypeName("LPVOID")] void* lpParameter, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("kernel32", EntryPoint = "CreateFiber", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("LPVOID")]
        public static extern void* CreateFiber([NativeTypeName("SIZE_T")] nuint dwStackSize, [NativeTypeName("LPFIBER_START_ROUTINE")] delegate* stdcall<void*, void> lpStartAddress, [NativeTypeName("LPVOID")] void* lpParameter);

        [DllImport("kernel32", EntryPoint = "ConvertThreadToFiber", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("LPVOID")]
        public static extern void* ConvertThreadToFiber([NativeTypeName("LPVOID")] void* lpParameter);

        [DllImport("kernel32", EntryPoint = "CreateUmsCompletionList", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CreateUmsCompletionList([NativeTypeName("PUMS_COMPLETION_LIST *")] void** UmsCompletionList);

        [DllImport("kernel32", EntryPoint = "DequeueUmsCompletionListItems", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int DequeueUmsCompletionListItems([NativeTypeName("PUMS_COMPLETION_LIST")] void* UmsCompletionList, [NativeTypeName("DWORD")] uint WaitTimeOut, [NativeTypeName("PUMS_CONTEXT *")] void** UmsThreadList);

        [DllImport("kernel32", EntryPoint = "GetUmsCompletionListEvent", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetUmsCompletionListEvent([NativeTypeName("PUMS_COMPLETION_LIST")] void* UmsCompletionList, [NativeTypeName("PHANDLE")] IntPtr* UmsCompletionEvent);

        [DllImport("kernel32", EntryPoint = "ExecuteUmsThread", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ExecuteUmsThread([NativeTypeName("PUMS_CONTEXT")] void* UmsThread);

        [DllImport("kernel32", EntryPoint = "UmsThreadYield", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int UmsThreadYield([NativeTypeName("PVOID")] void* SchedulerParam);

        [DllImport("kernel32", EntryPoint = "DeleteUmsCompletionList", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int DeleteUmsCompletionList([NativeTypeName("PUMS_COMPLETION_LIST")] void* UmsCompletionList);

        [DllImport("kernel32", EntryPoint = "GetCurrentUmsThread", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("PUMS_CONTEXT")]
        public static extern void* GetCurrentUmsThread();

        [DllImport("kernel32", EntryPoint = "GetNextUmsListItem", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("PUMS_CONTEXT")]
        public static extern void* GetNextUmsListItem([NativeTypeName("PUMS_CONTEXT")] void* UmsContext);

        [DllImport("kernel32", EntryPoint = "QueryUmsThreadInformation", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int QueryUmsThreadInformation([NativeTypeName("PUMS_CONTEXT")] void* UmsThread, [NativeTypeName("UMS_THREAD_INFO_CLASS")] RTL_UMS_THREAD_INFO_CLASS UmsThreadInfoClass, [NativeTypeName("PVOID")] void* UmsThreadInformation, [NativeTypeName("ULONG")] uint UmsThreadInformationLength, [NativeTypeName("PULONG")] uint* ReturnLength);

        [DllImport("kernel32", EntryPoint = "SetUmsThreadInformation", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetUmsThreadInformation([NativeTypeName("PUMS_CONTEXT")] void* UmsThread, [NativeTypeName("UMS_THREAD_INFO_CLASS")] RTL_UMS_THREAD_INFO_CLASS UmsThreadInfoClass, [NativeTypeName("PVOID")] void* UmsThreadInformation, [NativeTypeName("ULONG")] uint UmsThreadInformationLength);

        [DllImport("kernel32", EntryPoint = "DeleteUmsThreadContext", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int DeleteUmsThreadContext([NativeTypeName("PUMS_CONTEXT")] void* UmsThread);

        [DllImport("kernel32", EntryPoint = "CreateUmsThreadContext", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CreateUmsThreadContext([NativeTypeName("PUMS_CONTEXT *")] void** lpUmsThread);

        [DllImport("kernel32", EntryPoint = "EnterUmsSchedulingMode", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int EnterUmsSchedulingMode([NativeTypeName("PUMS_SCHEDULER_STARTUP_INFO")] UMS_SCHEDULER_STARTUP_INFO* SchedulerStartupInfo);

        [DllImport("kernel32", EntryPoint = "GetUmsSystemThreadInformation", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetUmsSystemThreadInformation([NativeTypeName("HANDLE")] IntPtr ThreadHandle, [NativeTypeName("PUMS_SYSTEM_THREAD_INFORMATION")] UMS_SYSTEM_THREAD_INFORMATION* SystemThreadInfo);

        [DllImport("kernel32", EntryPoint = "SetThreadAffinityMask", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("DWORD_PTR")]
        public static extern nuint SetThreadAffinityMask([NativeTypeName("HANDLE")] IntPtr hThread, [NativeTypeName("DWORD_PTR")] nuint dwThreadAffinityMask);

        [DllImport("kernel32", EntryPoint = "SetProcessDEPPolicy", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetProcessDEPPolicy([NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("kernel32", EntryPoint = "GetProcessDEPPolicy", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetProcessDEPPolicy([NativeTypeName("HANDLE")] IntPtr hProcess, [NativeTypeName("LPDWORD")] uint* lpFlags, [NativeTypeName("PBOOL")] int* lpPermanent);

        [DllImport("kernel32", EntryPoint = "RequestWakeupLatency", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int RequestWakeupLatency(LATENCY_TIME latency);

        [DllImport("kernel32", EntryPoint = "IsSystemResumeAutomatic", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int IsSystemResumeAutomatic();

        [DllImport("kernel32", EntryPoint = "GetThreadSelectorEntry", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetThreadSelectorEntry([NativeTypeName("HANDLE")] IntPtr hThread, [NativeTypeName("DWORD")] uint dwSelector, [NativeTypeName("LPLDT_ENTRY")] LDT_ENTRY* lpSelectorEntry);

        [DllImport("kernel32", EntryPoint = "SetThreadExecutionState", ExactSpelling = true)]
        [return: NativeTypeName("EXECUTION_STATE")]
        public static extern uint SetThreadExecutionState([NativeTypeName("EXECUTION_STATE")] uint esFlags);

        [DllImport("kernel32", EntryPoint = "PowerCreateRequest", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern IntPtr PowerCreateRequest([NativeTypeName("PREASON_CONTEXT")] REASON_CONTEXT* Context);

        [DllImport("kernel32", EntryPoint = "PowerSetRequest", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int PowerSetRequest([NativeTypeName("HANDLE")] IntPtr PowerRequest, POWER_REQUEST_TYPE RequestType);

        [DllImport("kernel32", EntryPoint = "PowerClearRequest", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int PowerClearRequest([NativeTypeName("HANDLE")] IntPtr PowerRequest, POWER_REQUEST_TYPE RequestType);

        [DllImport("kernel32", EntryPoint = "SetFileCompletionNotificationModes", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetFileCompletionNotificationModes([NativeTypeName("HANDLE")] IntPtr FileHandle, [NativeTypeName("UCHAR")] byte Flags);

        [DllImport("kernel32", EntryPoint = "Wow64GetThreadSelectorEntry", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int Wow64GetThreadSelectorEntry([NativeTypeName("HANDLE")] IntPtr hThread, [NativeTypeName("DWORD")] uint dwSelector, [NativeTypeName("PWOW64_LDT_ENTRY")] WOW64_LDT_ENTRY* lpSelectorEntry);

        [DllImport("kernel32", EntryPoint = "DebugSetProcessKillOnExit", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int DebugSetProcessKillOnExit([NativeTypeName("BOOL")] int KillOnExit);

        [DllImport("kernel32", EntryPoint = "DebugBreakProcess", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int DebugBreakProcess([NativeTypeName("HANDLE")] IntPtr Process);

        [DllImport("kernel32", EntryPoint = "PulseEvent", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int PulseEvent([NativeTypeName("HANDLE")] IntPtr hEvent);

        [DllImport("kernel32", EntryPoint = "GlobalDeleteAtom", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("ATOM")]
        public static extern ushort GlobalDeleteAtom([NativeTypeName("ATOM")] ushort nAtom);

        [DllImport("kernel32", EntryPoint = "InitAtomTable", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int InitAtomTable([NativeTypeName("DWORD")] uint nSize);

        [DllImport("kernel32", EntryPoint = "DeleteAtom", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("ATOM")]
        public static extern ushort DeleteAtom([NativeTypeName("ATOM")] ushort nAtom);

        [DllImport("kernel32", EntryPoint = "SetHandleCount", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint SetHandleCount([NativeTypeName("UINT")] uint uNumber);

        [DllImport("kernel32", EntryPoint = "RequestDeviceWakeup", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int RequestDeviceWakeup([NativeTypeName("HANDLE")] IntPtr hDevice);

        [DllImport("kernel32", EntryPoint = "CancelDeviceWakeupRequest", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CancelDeviceWakeupRequest([NativeTypeName("HANDLE")] IntPtr hDevice);

        [DllImport("kernel32", EntryPoint = "GetDevicePowerState", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetDevicePowerState([NativeTypeName("HANDLE")] IntPtr hDevice, [NativeTypeName("BOOL *")] int* pfOn);

        [DllImport("kernel32", EntryPoint = "SetMessageWaitingIndicator", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetMessageWaitingIndicator([NativeTypeName("HANDLE")] IntPtr hMsgIndicator, [NativeTypeName("ULONG")] uint ulMsgCount);

        [DllImport("kernel32", EntryPoint = "SetFileShortNameA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetFileShortNameA([NativeTypeName("HANDLE")] IntPtr hFile, [NativeTypeName("LPCSTR")] sbyte* lpShortName);

        [DllImport("kernel32", EntryPoint = "SetFileShortNameW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetFileShortNameW([NativeTypeName("HANDLE")] IntPtr hFile, [NativeTypeName("LPCWSTR")] ushort* lpShortName);

        [DllImport("kernel32", EntryPoint = "LoadModule", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint LoadModule([NativeTypeName("LPCSTR")] sbyte* lpModuleName, [NativeTypeName("LPVOID")] void* lpParameterBlock);

        [DllImport("kernel32", EntryPoint = "WinExec", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint WinExec([NativeTypeName("LPCSTR")] sbyte* lpCmdLine, [NativeTypeName("UINT")] uint uCmdShow);

        [DllImport("kernel32", EntryPoint = "ClearCommBreak", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ClearCommBreak([NativeTypeName("HANDLE")] IntPtr hFile);

        [DllImport("kernel32", EntryPoint = "ClearCommError", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ClearCommError([NativeTypeName("HANDLE")] IntPtr hFile, [NativeTypeName("LPDWORD")] uint* lpErrors, [NativeTypeName("LPCOMSTAT")] COMSTAT* lpStat);

        [DllImport("kernel32", EntryPoint = "SetupComm", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupComm([NativeTypeName("HANDLE")] IntPtr hFile, [NativeTypeName("DWORD")] uint dwInQueue, [NativeTypeName("DWORD")] uint dwOutQueue);

        [DllImport("kernel32", EntryPoint = "EscapeCommFunction", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int EscapeCommFunction([NativeTypeName("HANDLE")] IntPtr hFile, [NativeTypeName("DWORD")] uint dwFunc);

        [DllImport("kernel32", EntryPoint = "GetCommConfig", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetCommConfig([NativeTypeName("HANDLE")] IntPtr hCommDev, [NativeTypeName("LPCOMMCONFIG")] COMMCONFIG* lpCC, [NativeTypeName("LPDWORD")] uint* lpdwSize);

        [DllImport("kernel32", EntryPoint = "GetCommMask", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetCommMask([NativeTypeName("HANDLE")] IntPtr hFile, [NativeTypeName("LPDWORD")] uint* lpEvtMask);

        [DllImport("kernel32", EntryPoint = "GetCommProperties", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetCommProperties([NativeTypeName("HANDLE")] IntPtr hFile, [NativeTypeName("LPCOMMPROP")] COMMPROP* lpCommProp);

        [DllImport("kernel32", EntryPoint = "GetCommModemStatus", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetCommModemStatus([NativeTypeName("HANDLE")] IntPtr hFile, [NativeTypeName("LPDWORD")] uint* lpModemStat);

        [DllImport("kernel32", EntryPoint = "GetCommState", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetCommState([NativeTypeName("HANDLE")] IntPtr hFile, [NativeTypeName("LPDCB")] DCB* lpDCB);

        [DllImport("kernel32", EntryPoint = "GetCommTimeouts", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetCommTimeouts([NativeTypeName("HANDLE")] IntPtr hFile, [NativeTypeName("LPCOMMTIMEOUTS")] COMMTIMEOUTS* lpCommTimeouts);

        [DllImport("kernel32", EntryPoint = "PurgeComm", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int PurgeComm([NativeTypeName("HANDLE")] IntPtr hFile, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("kernel32", EntryPoint = "SetCommBreak", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetCommBreak([NativeTypeName("HANDLE")] IntPtr hFile);

        [DllImport("kernel32", EntryPoint = "SetCommConfig", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetCommConfig([NativeTypeName("HANDLE")] IntPtr hCommDev, [NativeTypeName("LPCOMMCONFIG")] COMMCONFIG* lpCC, [NativeTypeName("DWORD")] uint dwSize);

        [DllImport("kernel32", EntryPoint = "SetCommMask", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetCommMask([NativeTypeName("HANDLE")] IntPtr hFile, [NativeTypeName("DWORD")] uint dwEvtMask);

        [DllImport("kernel32", EntryPoint = "SetCommState", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetCommState([NativeTypeName("HANDLE")] IntPtr hFile, [NativeTypeName("LPDCB")] DCB* lpDCB);

        [DllImport("kernel32", EntryPoint = "SetCommTimeouts", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetCommTimeouts([NativeTypeName("HANDLE")] IntPtr hFile, [NativeTypeName("LPCOMMTIMEOUTS")] COMMTIMEOUTS* lpCommTimeouts);

        [DllImport("kernel32", EntryPoint = "TransmitCommChar", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int TransmitCommChar([NativeTypeName("HANDLE")] IntPtr hFile, [NativeTypeName("char")] sbyte cChar);

        [DllImport("kernel32", EntryPoint = "WaitCommEvent", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int WaitCommEvent([NativeTypeName("HANDLE")] IntPtr hFile, [NativeTypeName("LPDWORD")] uint* lpEvtMask, [NativeTypeName("LPOVERLAPPED")] OVERLAPPED* lpOverlapped);

        [DllImport("KernelBase", EntryPoint = "OpenCommPort", ExactSpelling = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern IntPtr OpenCommPort([NativeTypeName("ULONG")] uint uPortNumber, [NativeTypeName("DWORD")] uint dwDesiredAccess, [NativeTypeName("DWORD")] uint dwFlagsAndAttributes);

        [DllImport("kernelbase", EntryPoint = "GetCommPorts", ExactSpelling = true)]
        [return: NativeTypeName("ULONG")]
        public static extern uint GetCommPorts([NativeTypeName("PULONG")] uint* lpPortNumbers, [NativeTypeName("ULONG")] uint uPortNumbersCount, [NativeTypeName("PULONG")] uint* puPortNumbersFound);

        [DllImport("kernel32", EntryPoint = "SetTapePosition", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint SetTapePosition([NativeTypeName("HANDLE")] IntPtr hDevice, [NativeTypeName("DWORD")] uint dwPositionMethod, [NativeTypeName("DWORD")] uint dwPartition, [NativeTypeName("DWORD")] uint dwOffsetLow, [NativeTypeName("DWORD")] uint dwOffsetHigh, [NativeTypeName("BOOL")] int bImmediate);

        [DllImport("kernel32", EntryPoint = "GetTapePosition", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetTapePosition([NativeTypeName("HANDLE")] IntPtr hDevice, [NativeTypeName("DWORD")] uint dwPositionType, [NativeTypeName("LPDWORD")] uint* lpdwPartition, [NativeTypeName("LPDWORD")] uint* lpdwOffsetLow, [NativeTypeName("LPDWORD")] uint* lpdwOffsetHigh);

        [DllImport("kernel32", EntryPoint = "PrepareTape", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint PrepareTape([NativeTypeName("HANDLE")] IntPtr hDevice, [NativeTypeName("DWORD")] uint dwOperation, [NativeTypeName("BOOL")] int bImmediate);

        [DllImport("kernel32", EntryPoint = "EraseTape", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint EraseTape([NativeTypeName("HANDLE")] IntPtr hDevice, [NativeTypeName("DWORD")] uint dwEraseType, [NativeTypeName("BOOL")] int bImmediate);

        [DllImport("kernel32", EntryPoint = "CreateTapePartition", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint CreateTapePartition([NativeTypeName("HANDLE")] IntPtr hDevice, [NativeTypeName("DWORD")] uint dwPartitionMethod, [NativeTypeName("DWORD")] uint dwCount, [NativeTypeName("DWORD")] uint dwSize);

        [DllImport("kernel32", EntryPoint = "WriteTapemark", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint WriteTapemark([NativeTypeName("HANDLE")] IntPtr hDevice, [NativeTypeName("DWORD")] uint dwTapemarkType, [NativeTypeName("DWORD")] uint dwTapemarkCount, [NativeTypeName("BOOL")] int bImmediate);

        [DllImport("kernel32", EntryPoint = "GetTapeStatus", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetTapeStatus([NativeTypeName("HANDLE")] IntPtr hDevice);

        [DllImport("kernel32", EntryPoint = "GetTapeParameters", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetTapeParameters([NativeTypeName("HANDLE")] IntPtr hDevice, [NativeTypeName("DWORD")] uint dwOperation, [NativeTypeName("LPDWORD")] uint* lpdwSize, [NativeTypeName("LPVOID")] void* lpTapeInformation);

        [DllImport("kernel32", EntryPoint = "SetTapeParameters", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint SetTapeParameters([NativeTypeName("HANDLE")] IntPtr hDevice, [NativeTypeName("DWORD")] uint dwOperation, [NativeTypeName("LPVOID")] void* lpTapeInformation);

        [DllImport("kernel32", EntryPoint = "MulDiv", ExactSpelling = true)]
        public static extern int MulDiv(int nNumber, int nNumerator, int nDenominator);

        [DllImport("kernel32", EntryPoint = "GetSystemDEPPolicy", ExactSpelling = true)]
        public static extern DEP_SYSTEM_POLICY_TYPE GetSystemDEPPolicy();

        [DllImport("kernel32", EntryPoint = "GetSystemRegistryQuota", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetSystemRegistryQuota([NativeTypeName("PDWORD")] uint* pdwQuotaAllowed, [NativeTypeName("PDWORD")] uint* pdwQuotaUsed);

        [DllImport("kernel32", EntryPoint = "FileTimeToDosDateTime", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int FileTimeToDosDateTime([NativeTypeName("const FILETIME *")] FILETIME* lpFileTime, [NativeTypeName("LPWORD")] ushort* lpFatDate, [NativeTypeName("LPWORD")] ushort* lpFatTime);

        [DllImport("kernel32", EntryPoint = "DosDateTimeToFileTime", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int DosDateTimeToFileTime([NativeTypeName("WORD")] ushort wFatDate, [NativeTypeName("WORD")] ushort wFatTime, [NativeTypeName("LPFILETIME")] FILETIME* lpFileTime);

        [DllImport("kernel32", EntryPoint = "FormatMessageA", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint FormatMessageA([NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LPCVOID")] void* lpSource, [NativeTypeName("DWORD")] uint dwMessageId, [NativeTypeName("DWORD")] uint dwLanguageId, [NativeTypeName("LPSTR")] sbyte* lpBuffer, [NativeTypeName("DWORD")] uint nSize, [NativeTypeName("va_list *")] sbyte** Arguments);

        [DllImport("kernel32", EntryPoint = "FormatMessageW", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint FormatMessageW([NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LPCVOID")] void* lpSource, [NativeTypeName("DWORD")] uint dwMessageId, [NativeTypeName("DWORD")] uint dwLanguageId, [NativeTypeName("LPWSTR")] ushort* lpBuffer, [NativeTypeName("DWORD")] uint nSize, [NativeTypeName("va_list *")] sbyte** Arguments);

        [DllImport("kernel32", EntryPoint = "CreateMailslotA", ExactSpelling = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern IntPtr CreateMailslotA([NativeTypeName("LPCSTR")] sbyte* lpName, [NativeTypeName("DWORD")] uint nMaxMessageSize, [NativeTypeName("DWORD")] uint lReadTimeout, [NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpSecurityAttributes);

        [DllImport("kernel32", EntryPoint = "CreateMailslotW", ExactSpelling = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern IntPtr CreateMailslotW([NativeTypeName("LPCWSTR")] ushort* lpName, [NativeTypeName("DWORD")] uint nMaxMessageSize, [NativeTypeName("DWORD")] uint lReadTimeout, [NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpSecurityAttributes);

        [DllImport("kernel32", EntryPoint = "GetMailslotInfo", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetMailslotInfo([NativeTypeName("HANDLE")] IntPtr hMailslot, [NativeTypeName("LPDWORD")] uint* lpMaxMessageSize, [NativeTypeName("LPDWORD")] uint* lpNextSize, [NativeTypeName("LPDWORD")] uint* lpMessageCount, [NativeTypeName("LPDWORD")] uint* lpReadTimeout);

        [DllImport("kernel32", EntryPoint = "SetMailslotInfo", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetMailslotInfo([NativeTypeName("HANDLE")] IntPtr hMailslot, [NativeTypeName("DWORD")] uint lReadTimeout);

        [DllImport("kernel32", EntryPoint = "EncryptFileA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int EncryptFileA([NativeTypeName("LPCSTR")] sbyte* lpFileName);

        [DllImport("kernel32", EntryPoint = "EncryptFileW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int EncryptFileW([NativeTypeName("LPCWSTR")] ushort* lpFileName);

        [DllImport("kernel32", EntryPoint = "DecryptFileA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int DecryptFileA([NativeTypeName("LPCSTR")] sbyte* lpFileName, [NativeTypeName("DWORD")] uint dwReserved);

        [DllImport("kernel32", EntryPoint = "DecryptFileW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int DecryptFileW([NativeTypeName("LPCWSTR")] ushort* lpFileName, [NativeTypeName("DWORD")] uint dwReserved);

        [DllImport("kernel32", EntryPoint = "FileEncryptionStatusA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int FileEncryptionStatusA([NativeTypeName("LPCSTR")] sbyte* lpFileName, [NativeTypeName("LPDWORD")] uint* lpStatus);

        [DllImport("kernel32", EntryPoint = "FileEncryptionStatusW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int FileEncryptionStatusW([NativeTypeName("LPCWSTR")] ushort* lpFileName, [NativeTypeName("LPDWORD")] uint* lpStatus);

        [DllImport("kernel32", EntryPoint = "OpenEncryptedFileRawA", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint OpenEncryptedFileRawA([NativeTypeName("LPCSTR")] sbyte* lpFileName, [NativeTypeName("ULONG")] uint ulFlags, [NativeTypeName("PVOID *")] void** pvContext);

        [DllImport("kernel32", EntryPoint = "OpenEncryptedFileRawW", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint OpenEncryptedFileRawW([NativeTypeName("LPCWSTR")] ushort* lpFileName, [NativeTypeName("ULONG")] uint ulFlags, [NativeTypeName("PVOID *")] void** pvContext);

        [DllImport("advapi32", EntryPoint = "ReadEncryptedFileRaw", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint ReadEncryptedFileRaw([NativeTypeName("PFE_EXPORT_FUNC")] delegate* stdcall<byte*, void*, uint, uint> pfExportCallback, [NativeTypeName("PVOID")] void* pvCallbackContext, [NativeTypeName("PVOID")] void* pvContext);

        [DllImport("advapi32", EntryPoint = "WriteEncryptedFileRaw", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint WriteEncryptedFileRaw([NativeTypeName("PFE_IMPORT_FUNC")] delegate* stdcall<byte*, void*, uint*, uint> pfImportCallback, [NativeTypeName("PVOID")] void* pvCallbackContext, [NativeTypeName("PVOID")] void* pvContext);

        [DllImport("advapi32", EntryPoint = "CloseEncryptedFileRaw", ExactSpelling = true)]
        public static extern void CloseEncryptedFileRaw([NativeTypeName("PVOID")] void* pvContext);

        [DllImport("kernel32", EntryPoint = "lstrcmpA", ExactSpelling = true)]
        public static extern int lstrcmpA([NativeTypeName("LPCSTR")] sbyte* lpString1, [NativeTypeName("LPCSTR")] sbyte* lpString2);

        [DllImport("kernel32", EntryPoint = "lstrcmpW", ExactSpelling = true)]
        public static extern int lstrcmpW([NativeTypeName("LPCWSTR")] ushort* lpString1, [NativeTypeName("LPCWSTR")] ushort* lpString2);

        [DllImport("kernel32", EntryPoint = "lstrcmpiA", ExactSpelling = true)]
        public static extern int lstrcmpiA([NativeTypeName("LPCSTR")] sbyte* lpString1, [NativeTypeName("LPCSTR")] sbyte* lpString2);

        [DllImport("kernel32", EntryPoint = "lstrcmpiW", ExactSpelling = true)]
        public static extern int lstrcmpiW([NativeTypeName("LPCWSTR")] ushort* lpString1, [NativeTypeName("LPCWSTR")] ushort* lpString2);

        [DllImport("kernel32", EntryPoint = "lstrcpynA", ExactSpelling = true)]
        [return: NativeTypeName("LPSTR")]
        public static extern sbyte* lstrcpynA([NativeTypeName("LPSTR")] sbyte* lpString1, [NativeTypeName("LPCSTR")] sbyte* lpString2, int iMaxLength);

        [DllImport("kernel32", EntryPoint = "lstrcpynW", ExactSpelling = true)]
        [return: NativeTypeName("LPWSTR")]
        public static extern ushort* lstrcpynW([NativeTypeName("LPWSTR")] ushort* lpString1, [NativeTypeName("LPCWSTR")] ushort* lpString2, int iMaxLength);

        [DllImport("kernel32", EntryPoint = "lstrcpyA", ExactSpelling = true)]
        [return: NativeTypeName("LPSTR")]
        public static extern sbyte* lstrcpyA([NativeTypeName("LPSTR")] sbyte* lpString1, [NativeTypeName("LPCSTR")] sbyte* lpString2);

        [DllImport("kernel32", EntryPoint = "lstrcpyW", ExactSpelling = true)]
        [return: NativeTypeName("LPWSTR")]
        public static extern ushort* lstrcpyW([NativeTypeName("LPWSTR")] ushort* lpString1, [NativeTypeName("LPCWSTR")] ushort* lpString2);

        [DllImport("kernel32", EntryPoint = "lstrcatA", ExactSpelling = true)]
        [return: NativeTypeName("LPSTR")]
        public static extern sbyte* lstrcatA([NativeTypeName("LPSTR")] sbyte* lpString1, [NativeTypeName("LPCSTR")] sbyte* lpString2);

        [DllImport("kernel32", EntryPoint = "lstrcatW", ExactSpelling = true)]
        [return: NativeTypeName("LPWSTR")]
        public static extern ushort* lstrcatW([NativeTypeName("LPWSTR")] ushort* lpString1, [NativeTypeName("LPCWSTR")] ushort* lpString2);

        [DllImport("kernel32", EntryPoint = "lstrlenA", ExactSpelling = true)]
        public static extern int lstrlenA([NativeTypeName("LPCSTR")] sbyte* lpString);

        [DllImport("kernel32", EntryPoint = "lstrlenW", ExactSpelling = true)]
        public static extern int lstrlenW([NativeTypeName("LPCWSTR")] ushort* lpString);

        [DllImport("kernel32", EntryPoint = "OpenFile", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("HFILE")]
        public static extern int OpenFile([NativeTypeName("LPCSTR")] sbyte* lpFileName, [NativeTypeName("LPOFSTRUCT")] OFSTRUCT* lpReOpenBuff, [NativeTypeName("UINT")] uint uStyle);

        [DllImport("kernel32", EntryPoint = "_lopen", ExactSpelling = true)]
        [return: NativeTypeName("HFILE")]
        public static extern int _lopen([NativeTypeName("LPCSTR")] sbyte* lpPathName, int iReadWrite);

        [DllImport("kernel32", EntryPoint = "_lcreat", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("HFILE")]
        public static extern int _lcreat([NativeTypeName("LPCSTR")] sbyte* lpPathName, int iAttribute);

        [DllImport("kernel32", EntryPoint = "_lread", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint _lread([NativeTypeName("HFILE")] int hFile, [NativeTypeName("LPVOID")] void* lpBuffer, [NativeTypeName("UINT")] uint uBytes);

        [DllImport("kernel32", EntryPoint = "_lwrite", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint _lwrite([NativeTypeName("HFILE")] int hFile, [NativeTypeName("LPCCH")] sbyte* lpBuffer, [NativeTypeName("UINT")] uint uBytes);

        [DllImport("kernel32", EntryPoint = "_hread", ExactSpelling = true)]
        [return: NativeTypeName("long")]
        public static extern int _hread([NativeTypeName("HFILE")] int hFile, [NativeTypeName("LPVOID")] void* lpBuffer, [NativeTypeName("long")] int lBytes);

        [DllImport("kernel32", EntryPoint = "_hwrite", ExactSpelling = true)]
        [return: NativeTypeName("long")]
        public static extern int _hwrite([NativeTypeName("HFILE")] int hFile, [NativeTypeName("LPCCH")] sbyte* lpBuffer, [NativeTypeName("long")] int lBytes);

        [DllImport("kernel32", EntryPoint = "_lclose", ExactSpelling = true)]
        [return: NativeTypeName("HFILE")]
        public static extern int _lclose([NativeTypeName("HFILE")] int hFile);

        [DllImport("kernel32", EntryPoint = "_llseek", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("LONG")]
        public static extern int _llseek([NativeTypeName("HFILE")] int hFile, [NativeTypeName("LONG")] int lOffset, int iOrigin);

        [DllImport("advapi32", EntryPoint = "IsTextUnicode", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int IsTextUnicode([NativeTypeName("const void *")] void* lpv, int iSize, [NativeTypeName("LPINT")] int* lpiResult);

        [DllImport("kernel32", EntryPoint = "BackupRead", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int BackupRead([NativeTypeName("HANDLE")] IntPtr hFile, [NativeTypeName("LPBYTE")] byte* lpBuffer, [NativeTypeName("DWORD")] uint nNumberOfBytesToRead, [NativeTypeName("LPDWORD")] uint* lpNumberOfBytesRead, [NativeTypeName("BOOL")] int bAbort, [NativeTypeName("BOOL")] int bProcessSecurity, [NativeTypeName("LPVOID *")] void** lpContext);

        [DllImport("kernel32", EntryPoint = "BackupSeek", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int BackupSeek([NativeTypeName("HANDLE")] IntPtr hFile, [NativeTypeName("DWORD")] uint dwLowBytesToSeek, [NativeTypeName("DWORD")] uint dwHighBytesToSeek, [NativeTypeName("LPDWORD")] uint* lpdwLowByteSeeked, [NativeTypeName("LPDWORD")] uint* lpdwHighByteSeeked, [NativeTypeName("LPVOID *")] void** lpContext);

        [DllImport("kernel32", EntryPoint = "BackupWrite", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int BackupWrite([NativeTypeName("HANDLE")] IntPtr hFile, [NativeTypeName("LPBYTE")] byte* lpBuffer, [NativeTypeName("DWORD")] uint nNumberOfBytesToWrite, [NativeTypeName("LPDWORD")] uint* lpNumberOfBytesWritten, [NativeTypeName("BOOL")] int bAbort, [NativeTypeName("BOOL")] int bProcessSecurity, [NativeTypeName("LPVOID *")] void** lpContext);

        [DllImport("kernel32", EntryPoint = "OpenMutexA", ExactSpelling = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern IntPtr OpenMutexA([NativeTypeName("DWORD")] uint dwDesiredAccess, [NativeTypeName("BOOL")] int bInheritHandle, [NativeTypeName("LPCSTR")] sbyte* lpName);

        [DllImport("kernel32", EntryPoint = "CreateSemaphoreA", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern IntPtr CreateSemaphoreA([NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpSemaphoreAttributes, [NativeTypeName("LONG")] int lInitialCount, [NativeTypeName("LONG")] int lMaximumCount, [NativeTypeName("LPCSTR")] sbyte* lpName);

        [DllImport("kernel32", EntryPoint = "OpenSemaphoreA", ExactSpelling = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern IntPtr OpenSemaphoreA([NativeTypeName("DWORD")] uint dwDesiredAccess, [NativeTypeName("BOOL")] int bInheritHandle, [NativeTypeName("LPCSTR")] sbyte* lpName);

        [DllImport("kernel32", EntryPoint = "CreateWaitableTimerA", ExactSpelling = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern IntPtr CreateWaitableTimerA([NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpTimerAttributes, [NativeTypeName("BOOL")] int bManualReset, [NativeTypeName("LPCSTR")] sbyte* lpTimerName);

        [DllImport("kernel32", EntryPoint = "OpenWaitableTimerA", ExactSpelling = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern IntPtr OpenWaitableTimerA([NativeTypeName("DWORD")] uint dwDesiredAccess, [NativeTypeName("BOOL")] int bInheritHandle, [NativeTypeName("LPCSTR")] sbyte* lpTimerName);

        [DllImport("kernel32", EntryPoint = "CreateSemaphoreExA", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern IntPtr CreateSemaphoreExA([NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpSemaphoreAttributes, [NativeTypeName("LONG")] int lInitialCount, [NativeTypeName("LONG")] int lMaximumCount, [NativeTypeName("LPCSTR")] sbyte* lpName, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("DWORD")] uint dwDesiredAccess);

        [DllImport("kernel32", EntryPoint = "CreateWaitableTimerExA", ExactSpelling = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern IntPtr CreateWaitableTimerExA([NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpTimerAttributes, [NativeTypeName("LPCSTR")] sbyte* lpTimerName, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("DWORD")] uint dwDesiredAccess);

        [DllImport("kernel32", EntryPoint = "CreateFileMappingA", ExactSpelling = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern IntPtr CreateFileMappingA([NativeTypeName("HANDLE")] IntPtr hFile, [NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpFileMappingAttributes, [NativeTypeName("DWORD")] uint flProtect, [NativeTypeName("DWORD")] uint dwMaximumSizeHigh, [NativeTypeName("DWORD")] uint dwMaximumSizeLow, [NativeTypeName("LPCSTR")] sbyte* lpName);

        [DllImport("kernel32", EntryPoint = "CreateFileMappingNumaA", ExactSpelling = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern IntPtr CreateFileMappingNumaA([NativeTypeName("HANDLE")] IntPtr hFile, [NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpFileMappingAttributes, [NativeTypeName("DWORD")] uint flProtect, [NativeTypeName("DWORD")] uint dwMaximumSizeHigh, [NativeTypeName("DWORD")] uint dwMaximumSizeLow, [NativeTypeName("LPCSTR")] sbyte* lpName, [NativeTypeName("DWORD")] uint nndPreferred);

        [DllImport("kernel32", EntryPoint = "OpenFileMappingA", ExactSpelling = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern IntPtr OpenFileMappingA([NativeTypeName("DWORD")] uint dwDesiredAccess, [NativeTypeName("BOOL")] int bInheritHandle, [NativeTypeName("LPCSTR")] sbyte* lpName);

        [DllImport("kernel32", EntryPoint = "GetLogicalDriveStringsA", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetLogicalDriveStringsA([NativeTypeName("DWORD")] uint nBufferLength, [NativeTypeName("LPSTR")] sbyte* lpBuffer);

        [DllImport("kernel32", EntryPoint = "LoadPackagedLibrary", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("HMODULE")]
        public static extern IntPtr LoadPackagedLibrary([NativeTypeName("LPCWSTR")] ushort* lpwLibFileName, [NativeTypeName("DWORD")] uint Reserved);

        [DllImport("kernel32", EntryPoint = "QueryFullProcessImageNameA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int QueryFullProcessImageNameA([NativeTypeName("HANDLE")] IntPtr hProcess, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LPSTR")] sbyte* lpExeName, [NativeTypeName("PDWORD")] uint* lpdwSize);

        [DllImport("kernel32", EntryPoint = "QueryFullProcessImageNameW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int QueryFullProcessImageNameW([NativeTypeName("HANDLE")] IntPtr hProcess, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LPWSTR")] ushort* lpExeName, [NativeTypeName("PDWORD")] uint* lpdwSize);

        [DllImport("kernel32", EntryPoint = "GetStartupInfoA", ExactSpelling = true)]
        public static extern void GetStartupInfoA([NativeTypeName("LPSTARTUPINFOA")] STARTUPINFOA* lpStartupInfo);

        [DllImport("kernel32", EntryPoint = "GetFirmwareEnvironmentVariableA", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetFirmwareEnvironmentVariableA([NativeTypeName("LPCSTR")] sbyte* lpName, [NativeTypeName("LPCSTR")] sbyte* lpGuid, [NativeTypeName("PVOID")] void* pBuffer, [NativeTypeName("DWORD")] uint nSize);

        [DllImport("kernel32", EntryPoint = "GetFirmwareEnvironmentVariableW", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetFirmwareEnvironmentVariableW([NativeTypeName("LPCWSTR")] ushort* lpName, [NativeTypeName("LPCWSTR")] ushort* lpGuid, [NativeTypeName("PVOID")] void* pBuffer, [NativeTypeName("DWORD")] uint nSize);

        [DllImport("kernel32", EntryPoint = "GetFirmwareEnvironmentVariableExA", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetFirmwareEnvironmentVariableExA([NativeTypeName("LPCSTR")] sbyte* lpName, [NativeTypeName("LPCSTR")] sbyte* lpGuid, [NativeTypeName("PVOID")] void* pBuffer, [NativeTypeName("DWORD")] uint nSize, [NativeTypeName("PDWORD")] uint* pdwAttribubutes);

        [DllImport("kernel32", EntryPoint = "GetFirmwareEnvironmentVariableExW", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetFirmwareEnvironmentVariableExW([NativeTypeName("LPCWSTR")] ushort* lpName, [NativeTypeName("LPCWSTR")] ushort* lpGuid, [NativeTypeName("PVOID")] void* pBuffer, [NativeTypeName("DWORD")] uint nSize, [NativeTypeName("PDWORD")] uint* pdwAttribubutes);

        [DllImport("kernel32", EntryPoint = "SetFirmwareEnvironmentVariableA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetFirmwareEnvironmentVariableA([NativeTypeName("LPCSTR")] sbyte* lpName, [NativeTypeName("LPCSTR")] sbyte* lpGuid, [NativeTypeName("PVOID")] void* pValue, [NativeTypeName("DWORD")] uint nSize);

        [DllImport("kernel32", EntryPoint = "SetFirmwareEnvironmentVariableW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetFirmwareEnvironmentVariableW([NativeTypeName("LPCWSTR")] ushort* lpName, [NativeTypeName("LPCWSTR")] ushort* lpGuid, [NativeTypeName("PVOID")] void* pValue, [NativeTypeName("DWORD")] uint nSize);

        [DllImport("kernel32", EntryPoint = "SetFirmwareEnvironmentVariableExA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetFirmwareEnvironmentVariableExA([NativeTypeName("LPCSTR")] sbyte* lpName, [NativeTypeName("LPCSTR")] sbyte* lpGuid, [NativeTypeName("PVOID")] void* pValue, [NativeTypeName("DWORD")] uint nSize, [NativeTypeName("DWORD")] uint dwAttributes);

        [DllImport("kernel32", EntryPoint = "SetFirmwareEnvironmentVariableExW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetFirmwareEnvironmentVariableExW([NativeTypeName("LPCWSTR")] ushort* lpName, [NativeTypeName("LPCWSTR")] ushort* lpGuid, [NativeTypeName("PVOID")] void* pValue, [NativeTypeName("DWORD")] uint nSize, [NativeTypeName("DWORD")] uint dwAttributes);

        [DllImport("kernel32", EntryPoint = "GetFirmwareType", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetFirmwareType([NativeTypeName("PFIRMWARE_TYPE")] FIRMWARE_TYPE* FirmwareType);

        [DllImport("kernel32", EntryPoint = "IsNativeVhdBoot", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int IsNativeVhdBoot([NativeTypeName("PBOOL")] int* NativeVhdBoot);

        [DllImport("kernel32", EntryPoint = "FindResourceA", ExactSpelling = true)]
        [return: NativeTypeName("HRSRC")]
        public static extern IntPtr FindResourceA([NativeTypeName("HMODULE")] IntPtr hModule, [NativeTypeName("LPCSTR")] sbyte* lpName, [NativeTypeName("LPCSTR")] sbyte* lpType);

        [DllImport("kernel32", EntryPoint = "FindResourceExA", ExactSpelling = true)]
        [return: NativeTypeName("HRSRC")]
        public static extern IntPtr FindResourceExA([NativeTypeName("HMODULE")] IntPtr hModule, [NativeTypeName("LPCSTR")] sbyte* lpType, [NativeTypeName("LPCSTR")] sbyte* lpName, [NativeTypeName("WORD")] ushort wLanguage);

        [DllImport("kernel32", EntryPoint = "EnumResourceTypesA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int EnumResourceTypesA([NativeTypeName("HMODULE")] IntPtr hModule, [NativeTypeName("ENUMRESTYPEPROCA")] delegate* stdcall<IntPtr, sbyte*, nint, int> lpEnumFunc, [NativeTypeName("LONG_PTR")] nint lParam);

        [DllImport("kernel32", EntryPoint = "EnumResourceTypesW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int EnumResourceTypesW([NativeTypeName("HMODULE")] IntPtr hModule, [NativeTypeName("ENUMRESTYPEPROCW")] delegate* stdcall<IntPtr, ushort*, nint, int> lpEnumFunc, [NativeTypeName("LONG_PTR")] nint lParam);

        [DllImport("kernel32", EntryPoint = "EnumResourceNamesA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int EnumResourceNamesA([NativeTypeName("HMODULE")] IntPtr hModule, [NativeTypeName("LPCSTR")] sbyte* lpType, [NativeTypeName("ENUMRESNAMEPROCA")] delegate* stdcall<IntPtr, sbyte*, sbyte*, nint, int> lpEnumFunc, [NativeTypeName("LONG_PTR")] nint lParam);

        [DllImport("kernel32", EntryPoint = "EnumResourceLanguagesA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int EnumResourceLanguagesA([NativeTypeName("HMODULE")] IntPtr hModule, [NativeTypeName("LPCSTR")] sbyte* lpType, [NativeTypeName("LPCSTR")] sbyte* lpName, [NativeTypeName("ENUMRESLANGPROCA")] delegate* stdcall<IntPtr, sbyte*, sbyte*, ushort, nint, int> lpEnumFunc, [NativeTypeName("LONG_PTR")] nint lParam);

        [DllImport("kernel32", EntryPoint = "EnumResourceLanguagesW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int EnumResourceLanguagesW([NativeTypeName("HMODULE")] IntPtr hModule, [NativeTypeName("LPCWSTR")] ushort* lpType, [NativeTypeName("LPCWSTR")] ushort* lpName, [NativeTypeName("ENUMRESLANGPROCW")] delegate* stdcall<IntPtr, ushort*, ushort*, ushort, nint, int> lpEnumFunc, [NativeTypeName("LONG_PTR")] nint lParam);

        [DllImport("kernel32", EntryPoint = "BeginUpdateResourceA", ExactSpelling = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern IntPtr BeginUpdateResourceA([NativeTypeName("LPCSTR")] sbyte* pFileName, [NativeTypeName("BOOL")] int bDeleteExistingResources);

        [DllImport("kernel32", EntryPoint = "BeginUpdateResourceW", ExactSpelling = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern IntPtr BeginUpdateResourceW([NativeTypeName("LPCWSTR")] ushort* pFileName, [NativeTypeName("BOOL")] int bDeleteExistingResources);

        [DllImport("kernel32", EntryPoint = "UpdateResourceA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int UpdateResourceA([NativeTypeName("HANDLE")] IntPtr hUpdate, [NativeTypeName("LPCSTR")] sbyte* lpType, [NativeTypeName("LPCSTR")] sbyte* lpName, [NativeTypeName("WORD")] ushort wLanguage, [NativeTypeName("LPVOID")] void* lpData, [NativeTypeName("DWORD")] uint cb);

        [DllImport("kernel32", EntryPoint = "UpdateResourceW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int UpdateResourceW([NativeTypeName("HANDLE")] IntPtr hUpdate, [NativeTypeName("LPCWSTR")] ushort* lpType, [NativeTypeName("LPCWSTR")] ushort* lpName, [NativeTypeName("WORD")] ushort wLanguage, [NativeTypeName("LPVOID")] void* lpData, [NativeTypeName("DWORD")] uint cb);

        [DllImport("kernel32", EntryPoint = "EndUpdateResourceA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int EndUpdateResourceA([NativeTypeName("HANDLE")] IntPtr hUpdate, [NativeTypeName("BOOL")] int fDiscard);

        [DllImport("kernel32", EntryPoint = "EndUpdateResourceW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int EndUpdateResourceW([NativeTypeName("HANDLE")] IntPtr hUpdate, [NativeTypeName("BOOL")] int fDiscard);

        [DllImport("kernel32", EntryPoint = "GlobalAddAtomA", ExactSpelling = true)]
        [return: NativeTypeName("ATOM")]
        public static extern ushort GlobalAddAtomA([NativeTypeName("LPCSTR")] sbyte* lpString);

        [DllImport("kernel32", EntryPoint = "GlobalAddAtomW", ExactSpelling = true)]
        [return: NativeTypeName("ATOM")]
        public static extern ushort GlobalAddAtomW([NativeTypeName("LPCWSTR")] ushort* lpString);

        [DllImport("kernel32", EntryPoint = "GlobalAddAtomExA", ExactSpelling = true)]
        [return: NativeTypeName("ATOM")]
        public static extern ushort GlobalAddAtomExA([NativeTypeName("LPCSTR")] sbyte* lpString, [NativeTypeName("DWORD")] uint Flags);

        [DllImport("kernel32", EntryPoint = "GlobalAddAtomExW", ExactSpelling = true)]
        [return: NativeTypeName("ATOM")]
        public static extern ushort GlobalAddAtomExW([NativeTypeName("LPCWSTR")] ushort* lpString, [NativeTypeName("DWORD")] uint Flags);

        [DllImport("kernel32", EntryPoint = "GlobalFindAtomA", ExactSpelling = true)]
        [return: NativeTypeName("ATOM")]
        public static extern ushort GlobalFindAtomA([NativeTypeName("LPCSTR")] sbyte* lpString);

        [DllImport("kernel32", EntryPoint = "GlobalFindAtomW", ExactSpelling = true)]
        [return: NativeTypeName("ATOM")]
        public static extern ushort GlobalFindAtomW([NativeTypeName("LPCWSTR")] ushort* lpString);

        [DllImport("kernel32", EntryPoint = "GlobalGetAtomNameA", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint GlobalGetAtomNameA([NativeTypeName("ATOM")] ushort nAtom, [NativeTypeName("LPSTR")] sbyte* lpBuffer, int nSize);

        [DllImport("kernel32", EntryPoint = "GlobalGetAtomNameW", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint GlobalGetAtomNameW([NativeTypeName("ATOM")] ushort nAtom, [NativeTypeName("LPWSTR")] ushort* lpBuffer, int nSize);

        [DllImport("kernel32", EntryPoint = "AddAtomA", ExactSpelling = true)]
        [return: NativeTypeName("ATOM")]
        public static extern ushort AddAtomA([NativeTypeName("LPCSTR")] sbyte* lpString);

        [DllImport("kernel32", EntryPoint = "AddAtomW", ExactSpelling = true)]
        [return: NativeTypeName("ATOM")]
        public static extern ushort AddAtomW([NativeTypeName("LPCWSTR")] ushort* lpString);

        [DllImport("kernel32", EntryPoint = "FindAtomA", ExactSpelling = true)]
        [return: NativeTypeName("ATOM")]
        public static extern ushort FindAtomA([NativeTypeName("LPCSTR")] sbyte* lpString);

        [DllImport("kernel32", EntryPoint = "FindAtomW", ExactSpelling = true)]
        [return: NativeTypeName("ATOM")]
        public static extern ushort FindAtomW([NativeTypeName("LPCWSTR")] ushort* lpString);

        [DllImport("kernel32", EntryPoint = "GetAtomNameA", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint GetAtomNameA([NativeTypeName("ATOM")] ushort nAtom, [NativeTypeName("LPSTR")] sbyte* lpBuffer, int nSize);

        [DllImport("kernel32", EntryPoint = "GetAtomNameW", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint GetAtomNameW([NativeTypeName("ATOM")] ushort nAtom, [NativeTypeName("LPWSTR")] ushort* lpBuffer, int nSize);

        [DllImport("kernel32", EntryPoint = "GetProfileIntA", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint GetProfileIntA([NativeTypeName("LPCSTR")] sbyte* lpAppName, [NativeTypeName("LPCSTR")] sbyte* lpKeyName, [NativeTypeName("INT")] int nDefault);

        [DllImport("kernel32", EntryPoint = "GetProfileIntW", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint GetProfileIntW([NativeTypeName("LPCWSTR")] ushort* lpAppName, [NativeTypeName("LPCWSTR")] ushort* lpKeyName, [NativeTypeName("INT")] int nDefault);

        [DllImport("kernel32", EntryPoint = "GetProfileStringA", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetProfileStringA([NativeTypeName("LPCSTR")] sbyte* lpAppName, [NativeTypeName("LPCSTR")] sbyte* lpKeyName, [NativeTypeName("LPCSTR")] sbyte* lpDefault, [NativeTypeName("LPSTR")] sbyte* lpReturnedString, [NativeTypeName("DWORD")] uint nSize);

        [DllImport("kernel32", EntryPoint = "GetProfileStringW", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetProfileStringW([NativeTypeName("LPCWSTR")] ushort* lpAppName, [NativeTypeName("LPCWSTR")] ushort* lpKeyName, [NativeTypeName("LPCWSTR")] ushort* lpDefault, [NativeTypeName("LPWSTR")] ushort* lpReturnedString, [NativeTypeName("DWORD")] uint nSize);

        [DllImport("kernel32", EntryPoint = "WriteProfileStringA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int WriteProfileStringA([NativeTypeName("LPCSTR")] sbyte* lpAppName, [NativeTypeName("LPCSTR")] sbyte* lpKeyName, [NativeTypeName("LPCSTR")] sbyte* lpString);

        [DllImport("kernel32", EntryPoint = "WriteProfileStringW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int WriteProfileStringW([NativeTypeName("LPCWSTR")] ushort* lpAppName, [NativeTypeName("LPCWSTR")] ushort* lpKeyName, [NativeTypeName("LPCWSTR")] ushort* lpString);

        [DllImport("kernel32", EntryPoint = "GetProfileSectionA", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetProfileSectionA([NativeTypeName("LPCSTR")] sbyte* lpAppName, [NativeTypeName("LPSTR")] sbyte* lpReturnedString, [NativeTypeName("DWORD")] uint nSize);

        [DllImport("kernel32", EntryPoint = "GetProfileSectionW", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetProfileSectionW([NativeTypeName("LPCWSTR")] ushort* lpAppName, [NativeTypeName("LPWSTR")] ushort* lpReturnedString, [NativeTypeName("DWORD")] uint nSize);

        [DllImport("kernel32", EntryPoint = "WriteProfileSectionA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int WriteProfileSectionA([NativeTypeName("LPCSTR")] sbyte* lpAppName, [NativeTypeName("LPCSTR")] sbyte* lpString);

        [DllImport("kernel32", EntryPoint = "WriteProfileSectionW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int WriteProfileSectionW([NativeTypeName("LPCWSTR")] ushort* lpAppName, [NativeTypeName("LPCWSTR")] ushort* lpString);

        [DllImport("kernel32", EntryPoint = "GetPrivateProfileIntA", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint GetPrivateProfileIntA([NativeTypeName("LPCSTR")] sbyte* lpAppName, [NativeTypeName("LPCSTR")] sbyte* lpKeyName, [NativeTypeName("INT")] int nDefault, [NativeTypeName("LPCSTR")] sbyte* lpFileName);

        [DllImport("kernel32", EntryPoint = "GetPrivateProfileIntW", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint GetPrivateProfileIntW([NativeTypeName("LPCWSTR")] ushort* lpAppName, [NativeTypeName("LPCWSTR")] ushort* lpKeyName, [NativeTypeName("INT")] int nDefault, [NativeTypeName("LPCWSTR")] ushort* lpFileName);

        [DllImport("kernel32", EntryPoint = "GetPrivateProfileStringA", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetPrivateProfileStringA([NativeTypeName("LPCSTR")] sbyte* lpAppName, [NativeTypeName("LPCSTR")] sbyte* lpKeyName, [NativeTypeName("LPCSTR")] sbyte* lpDefault, [NativeTypeName("LPSTR")] sbyte* lpReturnedString, [NativeTypeName("DWORD")] uint nSize, [NativeTypeName("LPCSTR")] sbyte* lpFileName);

        [DllImport("kernel32", EntryPoint = "GetPrivateProfileStringW", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetPrivateProfileStringW([NativeTypeName("LPCWSTR")] ushort* lpAppName, [NativeTypeName("LPCWSTR")] ushort* lpKeyName, [NativeTypeName("LPCWSTR")] ushort* lpDefault, [NativeTypeName("LPWSTR")] ushort* lpReturnedString, [NativeTypeName("DWORD")] uint nSize, [NativeTypeName("LPCWSTR")] ushort* lpFileName);

        [DllImport("kernel32", EntryPoint = "WritePrivateProfileStringA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int WritePrivateProfileStringA([NativeTypeName("LPCSTR")] sbyte* lpAppName, [NativeTypeName("LPCSTR")] sbyte* lpKeyName, [NativeTypeName("LPCSTR")] sbyte* lpString, [NativeTypeName("LPCSTR")] sbyte* lpFileName);

        [DllImport("kernel32", EntryPoint = "WritePrivateProfileStringW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int WritePrivateProfileStringW([NativeTypeName("LPCWSTR")] ushort* lpAppName, [NativeTypeName("LPCWSTR")] ushort* lpKeyName, [NativeTypeName("LPCWSTR")] ushort* lpString, [NativeTypeName("LPCWSTR")] ushort* lpFileName);

        [DllImport("kernel32", EntryPoint = "GetPrivateProfileSectionA", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetPrivateProfileSectionA([NativeTypeName("LPCSTR")] sbyte* lpAppName, [NativeTypeName("LPSTR")] sbyte* lpReturnedString, [NativeTypeName("DWORD")] uint nSize, [NativeTypeName("LPCSTR")] sbyte* lpFileName);

        [DllImport("kernel32", EntryPoint = "GetPrivateProfileSectionW", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetPrivateProfileSectionW([NativeTypeName("LPCWSTR")] ushort* lpAppName, [NativeTypeName("LPWSTR")] ushort* lpReturnedString, [NativeTypeName("DWORD")] uint nSize, [NativeTypeName("LPCWSTR")] ushort* lpFileName);

        [DllImport("kernel32", EntryPoint = "WritePrivateProfileSectionA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int WritePrivateProfileSectionA([NativeTypeName("LPCSTR")] sbyte* lpAppName, [NativeTypeName("LPCSTR")] sbyte* lpString, [NativeTypeName("LPCSTR")] sbyte* lpFileName);

        [DllImport("kernel32", EntryPoint = "WritePrivateProfileSectionW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int WritePrivateProfileSectionW([NativeTypeName("LPCWSTR")] ushort* lpAppName, [NativeTypeName("LPCWSTR")] ushort* lpString, [NativeTypeName("LPCWSTR")] ushort* lpFileName);

        [DllImport("kernel32", EntryPoint = "GetPrivateProfileSectionNamesA", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetPrivateProfileSectionNamesA([NativeTypeName("LPSTR")] sbyte* lpszReturnBuffer, [NativeTypeName("DWORD")] uint nSize, [NativeTypeName("LPCSTR")] sbyte* lpFileName);

        [DllImport("kernel32", EntryPoint = "GetPrivateProfileSectionNamesW", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetPrivateProfileSectionNamesW([NativeTypeName("LPWSTR")] ushort* lpszReturnBuffer, [NativeTypeName("DWORD")] uint nSize, [NativeTypeName("LPCWSTR")] ushort* lpFileName);

        [DllImport("kernel32", EntryPoint = "GetPrivateProfileStructA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetPrivateProfileStructA([NativeTypeName("LPCSTR")] sbyte* lpszSection, [NativeTypeName("LPCSTR")] sbyte* lpszKey, [NativeTypeName("LPVOID")] void* lpStruct, [NativeTypeName("UINT")] uint uSizeStruct, [NativeTypeName("LPCSTR")] sbyte* szFile);

        [DllImport("kernel32", EntryPoint = "GetPrivateProfileStructW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetPrivateProfileStructW([NativeTypeName("LPCWSTR")] ushort* lpszSection, [NativeTypeName("LPCWSTR")] ushort* lpszKey, [NativeTypeName("LPVOID")] void* lpStruct, [NativeTypeName("UINT")] uint uSizeStruct, [NativeTypeName("LPCWSTR")] ushort* szFile);

        [DllImport("kernel32", EntryPoint = "WritePrivateProfileStructA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int WritePrivateProfileStructA([NativeTypeName("LPCSTR")] sbyte* lpszSection, [NativeTypeName("LPCSTR")] sbyte* lpszKey, [NativeTypeName("LPVOID")] void* lpStruct, [NativeTypeName("UINT")] uint uSizeStruct, [NativeTypeName("LPCSTR")] sbyte* szFile);

        [DllImport("kernel32", EntryPoint = "WritePrivateProfileStructW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int WritePrivateProfileStructW([NativeTypeName("LPCWSTR")] ushort* lpszSection, [NativeTypeName("LPCWSTR")] ushort* lpszKey, [NativeTypeName("LPVOID")] void* lpStruct, [NativeTypeName("UINT")] uint uSizeStruct, [NativeTypeName("LPCWSTR")] ushort* szFile);

        [DllImport("kernel32", EntryPoint = "Wow64EnableWow64FsRedirection", ExactSpelling = true)]
        [return: NativeTypeName("BOOLEAN")]
        public static extern byte Wow64EnableWow64FsRedirection([NativeTypeName("BOOLEAN")] byte Wow64FsEnableRedirection);

        [DllImport("kernel32", EntryPoint = "SetDllDirectoryA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetDllDirectoryA([NativeTypeName("LPCSTR")] sbyte* lpPathName);

        [DllImport("kernel32", EntryPoint = "SetDllDirectoryW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetDllDirectoryW([NativeTypeName("LPCWSTR")] ushort* lpPathName);

        [DllImport("kernel32", EntryPoint = "GetDllDirectoryA", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetDllDirectoryA([NativeTypeName("DWORD")] uint nBufferLength, [NativeTypeName("LPSTR")] sbyte* lpBuffer);

        [DllImport("kernel32", EntryPoint = "GetDllDirectoryW", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetDllDirectoryW([NativeTypeName("DWORD")] uint nBufferLength, [NativeTypeName("LPWSTR")] ushort* lpBuffer);

        [DllImport("kernel32", EntryPoint = "SetSearchPathMode", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetSearchPathMode([NativeTypeName("DWORD")] uint Flags);

        [DllImport("kernel32", EntryPoint = "CreateDirectoryExA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CreateDirectoryExA([NativeTypeName("LPCSTR")] sbyte* lpTemplateDirectory, [NativeTypeName("LPCSTR")] sbyte* lpNewDirectory, [NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpSecurityAttributes);

        [DllImport("kernel32", EntryPoint = "CreateDirectoryExW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CreateDirectoryExW([NativeTypeName("LPCWSTR")] ushort* lpTemplateDirectory, [NativeTypeName("LPCWSTR")] ushort* lpNewDirectory, [NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpSecurityAttributes);

        [DllImport("kernel32", EntryPoint = "CreateDirectoryTransactedA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CreateDirectoryTransactedA([NativeTypeName("LPCSTR")] sbyte* lpTemplateDirectory, [NativeTypeName("LPCSTR")] sbyte* lpNewDirectory, [NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpSecurityAttributes, [NativeTypeName("HANDLE")] IntPtr hTransaction);

        [DllImport("kernel32", EntryPoint = "CreateDirectoryTransactedW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CreateDirectoryTransactedW([NativeTypeName("LPCWSTR")] ushort* lpTemplateDirectory, [NativeTypeName("LPCWSTR")] ushort* lpNewDirectory, [NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpSecurityAttributes, [NativeTypeName("HANDLE")] IntPtr hTransaction);

        [DllImport("kernel32", EntryPoint = "RemoveDirectoryTransactedA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int RemoveDirectoryTransactedA([NativeTypeName("LPCSTR")] sbyte* lpPathName, [NativeTypeName("HANDLE")] IntPtr hTransaction);

        [DllImport("kernel32", EntryPoint = "RemoveDirectoryTransactedW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int RemoveDirectoryTransactedW([NativeTypeName("LPCWSTR")] ushort* lpPathName, [NativeTypeName("HANDLE")] IntPtr hTransaction);

        [DllImport("kernel32", EntryPoint = "GetFullPathNameTransactedA", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetFullPathNameTransactedA([NativeTypeName("LPCSTR")] sbyte* lpFileName, [NativeTypeName("DWORD")] uint nBufferLength, [NativeTypeName("LPSTR")] sbyte* lpBuffer, [NativeTypeName("LPSTR *")] sbyte** lpFilePart, [NativeTypeName("HANDLE")] IntPtr hTransaction);

        [DllImport("kernel32", EntryPoint = "GetFullPathNameTransactedW", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetFullPathNameTransactedW([NativeTypeName("LPCWSTR")] ushort* lpFileName, [NativeTypeName("DWORD")] uint nBufferLength, [NativeTypeName("LPWSTR")] ushort* lpBuffer, [NativeTypeName("LPWSTR *")] ushort** lpFilePart, [NativeTypeName("HANDLE")] IntPtr hTransaction);

        [DllImport("kernel32", EntryPoint = "DefineDosDeviceA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int DefineDosDeviceA([NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LPCSTR")] sbyte* lpDeviceName, [NativeTypeName("LPCSTR")] sbyte* lpTargetPath);

        [DllImport("kernel32", EntryPoint = "QueryDosDeviceA", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint QueryDosDeviceA([NativeTypeName("LPCSTR")] sbyte* lpDeviceName, [NativeTypeName("LPSTR")] sbyte* lpTargetPath, [NativeTypeName("DWORD")] uint ucchMax);

        [DllImport("kernel32", EntryPoint = "CreateFileTransactedA", ExactSpelling = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern IntPtr CreateFileTransactedA([NativeTypeName("LPCSTR")] sbyte* lpFileName, [NativeTypeName("DWORD")] uint dwDesiredAccess, [NativeTypeName("DWORD")] uint dwShareMode, [NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpSecurityAttributes, [NativeTypeName("DWORD")] uint dwCreationDisposition, [NativeTypeName("DWORD")] uint dwFlagsAndAttributes, [NativeTypeName("HANDLE")] IntPtr hTemplateFile, [NativeTypeName("HANDLE")] IntPtr hTransaction, [NativeTypeName("PUSHORT")] ushort* pusMiniVersion, [NativeTypeName("PVOID")] void* lpExtendedParameter);

        [DllImport("kernel32", EntryPoint = "CreateFileTransactedW", ExactSpelling = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern IntPtr CreateFileTransactedW([NativeTypeName("LPCWSTR")] ushort* lpFileName, [NativeTypeName("DWORD")] uint dwDesiredAccess, [NativeTypeName("DWORD")] uint dwShareMode, [NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpSecurityAttributes, [NativeTypeName("DWORD")] uint dwCreationDisposition, [NativeTypeName("DWORD")] uint dwFlagsAndAttributes, [NativeTypeName("HANDLE")] IntPtr hTemplateFile, [NativeTypeName("HANDLE")] IntPtr hTransaction, [NativeTypeName("PUSHORT")] ushort* pusMiniVersion, [NativeTypeName("PVOID")] void* lpExtendedParameter);

        [DllImport("kernel32", EntryPoint = "ReOpenFile", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern IntPtr ReOpenFile([NativeTypeName("HANDLE")] IntPtr hOriginalFile, [NativeTypeName("DWORD")] uint dwDesiredAccess, [NativeTypeName("DWORD")] uint dwShareMode, [NativeTypeName("DWORD")] uint dwFlagsAndAttributes);

        [DllImport("kernel32", EntryPoint = "SetFileAttributesTransactedA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetFileAttributesTransactedA([NativeTypeName("LPCSTR")] sbyte* lpFileName, [NativeTypeName("DWORD")] uint dwFileAttributes, [NativeTypeName("HANDLE")] IntPtr hTransaction);

        [DllImport("kernel32", EntryPoint = "SetFileAttributesTransactedW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetFileAttributesTransactedW([NativeTypeName("LPCWSTR")] ushort* lpFileName, [NativeTypeName("DWORD")] uint dwFileAttributes, [NativeTypeName("HANDLE")] IntPtr hTransaction);

        [DllImport("kernel32", EntryPoint = "GetFileAttributesTransactedA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetFileAttributesTransactedA([NativeTypeName("LPCSTR")] sbyte* lpFileName, GET_FILEEX_INFO_LEVELS fInfoLevelId, [NativeTypeName("LPVOID")] void* lpFileInformation, [NativeTypeName("HANDLE")] IntPtr hTransaction);

        [DllImport("kernel32", EntryPoint = "GetFileAttributesTransactedW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetFileAttributesTransactedW([NativeTypeName("LPCWSTR")] ushort* lpFileName, GET_FILEEX_INFO_LEVELS fInfoLevelId, [NativeTypeName("LPVOID")] void* lpFileInformation, [NativeTypeName("HANDLE")] IntPtr hTransaction);

        [DllImport("kernel32", EntryPoint = "GetCompressedFileSizeTransactedA", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetCompressedFileSizeTransactedA([NativeTypeName("LPCSTR")] sbyte* lpFileName, [NativeTypeName("LPDWORD")] uint* lpFileSizeHigh, [NativeTypeName("HANDLE")] IntPtr hTransaction);

        [DllImport("kernel32", EntryPoint = "GetCompressedFileSizeTransactedW", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetCompressedFileSizeTransactedW([NativeTypeName("LPCWSTR")] ushort* lpFileName, [NativeTypeName("LPDWORD")] uint* lpFileSizeHigh, [NativeTypeName("HANDLE")] IntPtr hTransaction);

        [DllImport("kernel32", EntryPoint = "DeleteFileTransactedA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int DeleteFileTransactedA([NativeTypeName("LPCSTR")] sbyte* lpFileName, [NativeTypeName("HANDLE")] IntPtr hTransaction);

        [DllImport("kernel32", EntryPoint = "DeleteFileTransactedW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int DeleteFileTransactedW([NativeTypeName("LPCWSTR")] ushort* lpFileName, [NativeTypeName("HANDLE")] IntPtr hTransaction);

        [DllImport("kernel32", EntryPoint = "CheckNameLegalDOS8Dot3A", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CheckNameLegalDOS8Dot3A([NativeTypeName("LPCSTR")] sbyte* lpName, [NativeTypeName("LPSTR")] sbyte* lpOemName, [NativeTypeName("DWORD")] uint OemNameSize, [NativeTypeName("PBOOL")] int* pbNameContainsSpaces, [NativeTypeName("PBOOL")] int* pbNameLegal);

        [DllImport("kernel32", EntryPoint = "CheckNameLegalDOS8Dot3W", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CheckNameLegalDOS8Dot3W([NativeTypeName("LPCWSTR")] ushort* lpName, [NativeTypeName("LPSTR")] sbyte* lpOemName, [NativeTypeName("DWORD")] uint OemNameSize, [NativeTypeName("PBOOL")] int* pbNameContainsSpaces, [NativeTypeName("PBOOL")] int* pbNameLegal);

        [DllImport("kernel32", EntryPoint = "FindFirstFileTransactedA", ExactSpelling = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern IntPtr FindFirstFileTransactedA([NativeTypeName("LPCSTR")] sbyte* lpFileName, FINDEX_INFO_LEVELS fInfoLevelId, [NativeTypeName("LPVOID")] void* lpFindFileData, FINDEX_SEARCH_OPS fSearchOp, [NativeTypeName("LPVOID")] void* lpSearchFilter, [NativeTypeName("DWORD")] uint dwAdditionalFlags, [NativeTypeName("HANDLE")] IntPtr hTransaction);

        [DllImport("kernel32", EntryPoint = "FindFirstFileTransactedW", ExactSpelling = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern IntPtr FindFirstFileTransactedW([NativeTypeName("LPCWSTR")] ushort* lpFileName, FINDEX_INFO_LEVELS fInfoLevelId, [NativeTypeName("LPVOID")] void* lpFindFileData, FINDEX_SEARCH_OPS fSearchOp, [NativeTypeName("LPVOID")] void* lpSearchFilter, [NativeTypeName("DWORD")] uint dwAdditionalFlags, [NativeTypeName("HANDLE")] IntPtr hTransaction);

        [DllImport("kernel32", EntryPoint = "CopyFileA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CopyFileA([NativeTypeName("LPCSTR")] sbyte* lpExistingFileName, [NativeTypeName("LPCSTR")] sbyte* lpNewFileName, [NativeTypeName("BOOL")] int bFailIfExists);

        [DllImport("kernel32", EntryPoint = "CopyFileW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CopyFileW([NativeTypeName("LPCWSTR")] ushort* lpExistingFileName, [NativeTypeName("LPCWSTR")] ushort* lpNewFileName, [NativeTypeName("BOOL")] int bFailIfExists);

        [DllImport("kernel32", EntryPoint = "CopyFileExA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CopyFileExA([NativeTypeName("LPCSTR")] sbyte* lpExistingFileName, [NativeTypeName("LPCSTR")] sbyte* lpNewFileName, [NativeTypeName("LPPROGRESS_ROUTINE")] delegate* stdcall<LARGE_INTEGER, LARGE_INTEGER, LARGE_INTEGER, LARGE_INTEGER, uint, uint, IntPtr, IntPtr, void*, uint> lpProgressRoutine, [NativeTypeName("LPVOID")] void* lpData, [NativeTypeName("LPBOOL")] int* pbCancel, [NativeTypeName("DWORD")] uint dwCopyFlags);

        [DllImport("kernel32", EntryPoint = "CopyFileExW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CopyFileExW([NativeTypeName("LPCWSTR")] ushort* lpExistingFileName, [NativeTypeName("LPCWSTR")] ushort* lpNewFileName, [NativeTypeName("LPPROGRESS_ROUTINE")] delegate* stdcall<LARGE_INTEGER, LARGE_INTEGER, LARGE_INTEGER, LARGE_INTEGER, uint, uint, IntPtr, IntPtr, void*, uint> lpProgressRoutine, [NativeTypeName("LPVOID")] void* lpData, [NativeTypeName("LPBOOL")] int* pbCancel, [NativeTypeName("DWORD")] uint dwCopyFlags);

        [DllImport("kernel32", EntryPoint = "CopyFileTransactedA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CopyFileTransactedA([NativeTypeName("LPCSTR")] sbyte* lpExistingFileName, [NativeTypeName("LPCSTR")] sbyte* lpNewFileName, [NativeTypeName("LPPROGRESS_ROUTINE")] delegate* stdcall<LARGE_INTEGER, LARGE_INTEGER, LARGE_INTEGER, LARGE_INTEGER, uint, uint, IntPtr, IntPtr, void*, uint> lpProgressRoutine, [NativeTypeName("LPVOID")] void* lpData, [NativeTypeName("LPBOOL")] int* pbCancel, [NativeTypeName("DWORD")] uint dwCopyFlags, [NativeTypeName("HANDLE")] IntPtr hTransaction);

        [DllImport("kernel32", EntryPoint = "CopyFileTransactedW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CopyFileTransactedW([NativeTypeName("LPCWSTR")] ushort* lpExistingFileName, [NativeTypeName("LPCWSTR")] ushort* lpNewFileName, [NativeTypeName("LPPROGRESS_ROUTINE")] delegate* stdcall<LARGE_INTEGER, LARGE_INTEGER, LARGE_INTEGER, LARGE_INTEGER, uint, uint, IntPtr, IntPtr, void*, uint> lpProgressRoutine, [NativeTypeName("LPVOID")] void* lpData, [NativeTypeName("LPBOOL")] int* pbCancel, [NativeTypeName("DWORD")] uint dwCopyFlags, [NativeTypeName("HANDLE")] IntPtr hTransaction);

        [DllImport("kernel32", EntryPoint = "CopyFile2", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CopyFile2([NativeTypeName("PCWSTR")] ushort* pwszExistingFileName, [NativeTypeName("PCWSTR")] ushort* pwszNewFileName, [NativeTypeName("COPYFILE2_EXTENDED_PARAMETERS *")] COPYFILE2_EXTENDED_PARAMETERS* pExtendedParameters);

        [DllImport("kernel32", EntryPoint = "MoveFileA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int MoveFileA([NativeTypeName("LPCSTR")] sbyte* lpExistingFileName, [NativeTypeName("LPCSTR")] sbyte* lpNewFileName);

        [DllImport("kernel32", EntryPoint = "MoveFileW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int MoveFileW([NativeTypeName("LPCWSTR")] ushort* lpExistingFileName, [NativeTypeName("LPCWSTR")] ushort* lpNewFileName);

        [DllImport("kernel32", EntryPoint = "MoveFileExA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int MoveFileExA([NativeTypeName("LPCSTR")] sbyte* lpExistingFileName, [NativeTypeName("LPCSTR")] sbyte* lpNewFileName, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("kernel32", EntryPoint = "MoveFileExW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int MoveFileExW([NativeTypeName("LPCWSTR")] ushort* lpExistingFileName, [NativeTypeName("LPCWSTR")] ushort* lpNewFileName, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("kernel32", EntryPoint = "MoveFileWithProgressA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int MoveFileWithProgressA([NativeTypeName("LPCSTR")] sbyte* lpExistingFileName, [NativeTypeName("LPCSTR")] sbyte* lpNewFileName, [NativeTypeName("LPPROGRESS_ROUTINE")] delegate* stdcall<LARGE_INTEGER, LARGE_INTEGER, LARGE_INTEGER, LARGE_INTEGER, uint, uint, IntPtr, IntPtr, void*, uint> lpProgressRoutine, [NativeTypeName("LPVOID")] void* lpData, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("kernel32", EntryPoint = "MoveFileWithProgressW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int MoveFileWithProgressW([NativeTypeName("LPCWSTR")] ushort* lpExistingFileName, [NativeTypeName("LPCWSTR")] ushort* lpNewFileName, [NativeTypeName("LPPROGRESS_ROUTINE")] delegate* stdcall<LARGE_INTEGER, LARGE_INTEGER, LARGE_INTEGER, LARGE_INTEGER, uint, uint, IntPtr, IntPtr, void*, uint> lpProgressRoutine, [NativeTypeName("LPVOID")] void* lpData, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("kernel32", EntryPoint = "MoveFileTransactedA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int MoveFileTransactedA([NativeTypeName("LPCSTR")] sbyte* lpExistingFileName, [NativeTypeName("LPCSTR")] sbyte* lpNewFileName, [NativeTypeName("LPPROGRESS_ROUTINE")] delegate* stdcall<LARGE_INTEGER, LARGE_INTEGER, LARGE_INTEGER, LARGE_INTEGER, uint, uint, IntPtr, IntPtr, void*, uint> lpProgressRoutine, [NativeTypeName("LPVOID")] void* lpData, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("HANDLE")] IntPtr hTransaction);

        [DllImport("kernel32", EntryPoint = "MoveFileTransactedW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int MoveFileTransactedW([NativeTypeName("LPCWSTR")] ushort* lpExistingFileName, [NativeTypeName("LPCWSTR")] ushort* lpNewFileName, [NativeTypeName("LPPROGRESS_ROUTINE")] delegate* stdcall<LARGE_INTEGER, LARGE_INTEGER, LARGE_INTEGER, LARGE_INTEGER, uint, uint, IntPtr, IntPtr, void*, uint> lpProgressRoutine, [NativeTypeName("LPVOID")] void* lpData, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("HANDLE")] IntPtr hTransaction);

        [DllImport("kernel32", EntryPoint = "ReplaceFileA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ReplaceFileA([NativeTypeName("LPCSTR")] sbyte* lpReplacedFileName, [NativeTypeName("LPCSTR")] sbyte* lpReplacementFileName, [NativeTypeName("LPCSTR")] sbyte* lpBackupFileName, [NativeTypeName("DWORD")] uint dwReplaceFlags, [NativeTypeName("LPVOID")] void* lpExclude, [NativeTypeName("LPVOID")] void* lpReserved);

        [DllImport("kernel32", EntryPoint = "ReplaceFileW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ReplaceFileW([NativeTypeName("LPCWSTR")] ushort* lpReplacedFileName, [NativeTypeName("LPCWSTR")] ushort* lpReplacementFileName, [NativeTypeName("LPCWSTR")] ushort* lpBackupFileName, [NativeTypeName("DWORD")] uint dwReplaceFlags, [NativeTypeName("LPVOID")] void* lpExclude, [NativeTypeName("LPVOID")] void* lpReserved);

        [DllImport("kernel32", EntryPoint = "CreateHardLinkA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CreateHardLinkA([NativeTypeName("LPCSTR")] sbyte* lpFileName, [NativeTypeName("LPCSTR")] sbyte* lpExistingFileName, [NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpSecurityAttributes);

        [DllImport("kernel32", EntryPoint = "CreateHardLinkW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CreateHardLinkW([NativeTypeName("LPCWSTR")] ushort* lpFileName, [NativeTypeName("LPCWSTR")] ushort* lpExistingFileName, [NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpSecurityAttributes);

        [DllImport("kernel32", EntryPoint = "CreateHardLinkTransactedA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CreateHardLinkTransactedA([NativeTypeName("LPCSTR")] sbyte* lpFileName, [NativeTypeName("LPCSTR")] sbyte* lpExistingFileName, [NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpSecurityAttributes, [NativeTypeName("HANDLE")] IntPtr hTransaction);

        [DllImport("kernel32", EntryPoint = "CreateHardLinkTransactedW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CreateHardLinkTransactedW([NativeTypeName("LPCWSTR")] ushort* lpFileName, [NativeTypeName("LPCWSTR")] ushort* lpExistingFileName, [NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpSecurityAttributes, [NativeTypeName("HANDLE")] IntPtr hTransaction);

        [DllImport("kernel32", EntryPoint = "FindFirstStreamTransactedW", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern IntPtr FindFirstStreamTransactedW([NativeTypeName("LPCWSTR")] ushort* lpFileName, STREAM_INFO_LEVELS InfoLevel, [NativeTypeName("LPVOID")] void* lpFindStreamData, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("HANDLE")] IntPtr hTransaction);

        [DllImport("kernel32", EntryPoint = "FindFirstFileNameTransactedW", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern IntPtr FindFirstFileNameTransactedW([NativeTypeName("LPCWSTR")] ushort* lpFileName, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LPDWORD")] uint* StringLength, [NativeTypeName("PWSTR")] ushort* LinkName, [NativeTypeName("HANDLE")] IntPtr hTransaction);

        [DllImport("kernel32", EntryPoint = "CreateNamedPipeA", ExactSpelling = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern IntPtr CreateNamedPipeA([NativeTypeName("LPCSTR")] sbyte* lpName, [NativeTypeName("DWORD")] uint dwOpenMode, [NativeTypeName("DWORD")] uint dwPipeMode, [NativeTypeName("DWORD")] uint nMaxInstances, [NativeTypeName("DWORD")] uint nOutBufferSize, [NativeTypeName("DWORD")] uint nInBufferSize, [NativeTypeName("DWORD")] uint nDefaultTimeOut, [NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpSecurityAttributes);

        [DllImport("kernel32", EntryPoint = "GetNamedPipeHandleStateA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetNamedPipeHandleStateA([NativeTypeName("HANDLE")] IntPtr hNamedPipe, [NativeTypeName("LPDWORD")] uint* lpState, [NativeTypeName("LPDWORD")] uint* lpCurInstances, [NativeTypeName("LPDWORD")] uint* lpMaxCollectionCount, [NativeTypeName("LPDWORD")] uint* lpCollectDataTimeout, [NativeTypeName("LPSTR")] sbyte* lpUserName, [NativeTypeName("DWORD")] uint nMaxUserNameSize);

        [DllImport("kernel32", EntryPoint = "CallNamedPipeA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CallNamedPipeA([NativeTypeName("LPCSTR")] sbyte* lpNamedPipeName, [NativeTypeName("LPVOID")] void* lpInBuffer, [NativeTypeName("DWORD")] uint nInBufferSize, [NativeTypeName("LPVOID")] void* lpOutBuffer, [NativeTypeName("DWORD")] uint nOutBufferSize, [NativeTypeName("LPDWORD")] uint* lpBytesRead, [NativeTypeName("DWORD")] uint nTimeOut);

        [DllImport("kernel32", EntryPoint = "WaitNamedPipeA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int WaitNamedPipeA([NativeTypeName("LPCSTR")] sbyte* lpNamedPipeName, [NativeTypeName("DWORD")] uint nTimeOut);

        [DllImport("kernel32", EntryPoint = "GetNamedPipeClientComputerNameA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetNamedPipeClientComputerNameA([NativeTypeName("HANDLE")] IntPtr Pipe, [NativeTypeName("LPSTR")] sbyte* ClientComputerName, [NativeTypeName("ULONG")] uint ClientComputerNameLength);

        [DllImport("kernel32", EntryPoint = "GetNamedPipeClientProcessId", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetNamedPipeClientProcessId([NativeTypeName("HANDLE")] IntPtr Pipe, [NativeTypeName("PULONG")] uint* ClientProcessId);

        [DllImport("kernel32", EntryPoint = "GetNamedPipeClientSessionId", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetNamedPipeClientSessionId([NativeTypeName("HANDLE")] IntPtr Pipe, [NativeTypeName("PULONG")] uint* ClientSessionId);

        [DllImport("kernel32", EntryPoint = "GetNamedPipeServerProcessId", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetNamedPipeServerProcessId([NativeTypeName("HANDLE")] IntPtr Pipe, [NativeTypeName("PULONG")] uint* ServerProcessId);

        [DllImport("kernel32", EntryPoint = "GetNamedPipeServerSessionId", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetNamedPipeServerSessionId([NativeTypeName("HANDLE")] IntPtr Pipe, [NativeTypeName("PULONG")] uint* ServerSessionId);

        [DllImport("kernel32", EntryPoint = "SetVolumeLabelA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetVolumeLabelA([NativeTypeName("LPCSTR")] sbyte* lpRootPathName, [NativeTypeName("LPCSTR")] sbyte* lpVolumeName);

        [DllImport("kernel32", EntryPoint = "SetVolumeLabelW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetVolumeLabelW([NativeTypeName("LPCWSTR")] ushort* lpRootPathName, [NativeTypeName("LPCWSTR")] ushort* lpVolumeName);

        [DllImport("kernel32", EntryPoint = "SetFileBandwidthReservation", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetFileBandwidthReservation([NativeTypeName("HANDLE")] IntPtr hFile, [NativeTypeName("DWORD")] uint nPeriodMilliseconds, [NativeTypeName("DWORD")] uint nBytesPerPeriod, [NativeTypeName("BOOL")] int bDiscardable, [NativeTypeName("LPDWORD")] uint* lpTransferSize, [NativeTypeName("LPDWORD")] uint* lpNumOutstandingRequests);

        [DllImport("kernel32", EntryPoint = "GetFileBandwidthReservation", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetFileBandwidthReservation([NativeTypeName("HANDLE")] IntPtr hFile, [NativeTypeName("LPDWORD")] uint* lpPeriodMilliseconds, [NativeTypeName("LPDWORD")] uint* lpBytesPerPeriod, [NativeTypeName("LPBOOL")] int* pDiscardable, [NativeTypeName("LPDWORD")] uint* lpTransferSize, [NativeTypeName("LPDWORD")] uint* lpNumOutstandingRequests);

        [DllImport("kernel32", EntryPoint = "ClearEventLogA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ClearEventLogA([NativeTypeName("HANDLE")] IntPtr hEventLog, [NativeTypeName("LPCSTR")] sbyte* lpBackupFileName);

        [DllImport("kernel32", EntryPoint = "ClearEventLogW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ClearEventLogW([NativeTypeName("HANDLE")] IntPtr hEventLog, [NativeTypeName("LPCWSTR")] ushort* lpBackupFileName);

        [DllImport("kernel32", EntryPoint = "BackupEventLogA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int BackupEventLogA([NativeTypeName("HANDLE")] IntPtr hEventLog, [NativeTypeName("LPCSTR")] sbyte* lpBackupFileName);

        [DllImport("kernel32", EntryPoint = "BackupEventLogW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int BackupEventLogW([NativeTypeName("HANDLE")] IntPtr hEventLog, [NativeTypeName("LPCWSTR")] ushort* lpBackupFileName);

        [DllImport("advapi32", EntryPoint = "CloseEventLog", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CloseEventLog([NativeTypeName("HANDLE")] IntPtr hEventLog);

        [DllImport("advapi32", EntryPoint = "DeregisterEventSource", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int DeregisterEventSource([NativeTypeName("HANDLE")] IntPtr hEventLog);

        [DllImport("advapi32", EntryPoint = "NotifyChangeEventLog", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int NotifyChangeEventLog([NativeTypeName("HANDLE")] IntPtr hEventLog, [NativeTypeName("HANDLE")] IntPtr hEvent);

        [DllImport("advapi32", EntryPoint = "GetNumberOfEventLogRecords", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetNumberOfEventLogRecords([NativeTypeName("HANDLE")] IntPtr hEventLog, [NativeTypeName("PDWORD")] uint* NumberOfRecords);

        [DllImport("advapi32", EntryPoint = "GetOldestEventLogRecord", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetOldestEventLogRecord([NativeTypeName("HANDLE")] IntPtr hEventLog, [NativeTypeName("PDWORD")] uint* OldestRecord);

        [DllImport("kernel32", EntryPoint = "OpenEventLogA", ExactSpelling = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern IntPtr OpenEventLogA([NativeTypeName("LPCSTR")] sbyte* lpUNCServerName, [NativeTypeName("LPCSTR")] sbyte* lpSourceName);

        [DllImport("kernel32", EntryPoint = "OpenEventLogW", ExactSpelling = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern IntPtr OpenEventLogW([NativeTypeName("LPCWSTR")] ushort* lpUNCServerName, [NativeTypeName("LPCWSTR")] ushort* lpSourceName);

        [DllImport("kernel32", EntryPoint = "RegisterEventSourceA", ExactSpelling = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern IntPtr RegisterEventSourceA([NativeTypeName("LPCSTR")] sbyte* lpUNCServerName, [NativeTypeName("LPCSTR")] sbyte* lpSourceName);

        [DllImport("kernel32", EntryPoint = "RegisterEventSourceW", ExactSpelling = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern IntPtr RegisterEventSourceW([NativeTypeName("LPCWSTR")] ushort* lpUNCServerName, [NativeTypeName("LPCWSTR")] ushort* lpSourceName);

        [DllImport("kernel32", EntryPoint = "OpenBackupEventLogA", ExactSpelling = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern IntPtr OpenBackupEventLogA([NativeTypeName("LPCSTR")] sbyte* lpUNCServerName, [NativeTypeName("LPCSTR")] sbyte* lpFileName);

        [DllImport("kernel32", EntryPoint = "OpenBackupEventLogW", ExactSpelling = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern IntPtr OpenBackupEventLogW([NativeTypeName("LPCWSTR")] ushort* lpUNCServerName, [NativeTypeName("LPCWSTR")] ushort* lpFileName);

        [DllImport("kernel32", EntryPoint = "ReadEventLogA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ReadEventLogA([NativeTypeName("HANDLE")] IntPtr hEventLog, [NativeTypeName("DWORD")] uint dwReadFlags, [NativeTypeName("DWORD")] uint dwRecordOffset, [NativeTypeName("LPVOID")] void* lpBuffer, [NativeTypeName("DWORD")] uint nNumberOfBytesToRead, [NativeTypeName("DWORD *")] uint* pnBytesRead, [NativeTypeName("DWORD *")] uint* pnMinNumberOfBytesNeeded);

        [DllImport("kernel32", EntryPoint = "ReadEventLogW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ReadEventLogW([NativeTypeName("HANDLE")] IntPtr hEventLog, [NativeTypeName("DWORD")] uint dwReadFlags, [NativeTypeName("DWORD")] uint dwRecordOffset, [NativeTypeName("LPVOID")] void* lpBuffer, [NativeTypeName("DWORD")] uint nNumberOfBytesToRead, [NativeTypeName("DWORD *")] uint* pnBytesRead, [NativeTypeName("DWORD *")] uint* pnMinNumberOfBytesNeeded);

        [DllImport("kernel32", EntryPoint = "ReportEventA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ReportEventA([NativeTypeName("HANDLE")] IntPtr hEventLog, [NativeTypeName("WORD")] ushort wType, [NativeTypeName("WORD")] ushort wCategory, [NativeTypeName("DWORD")] uint dwEventID, [NativeTypeName("PSID")] void* lpUserSid, [NativeTypeName("WORD")] ushort wNumStrings, [NativeTypeName("DWORD")] uint dwDataSize, [NativeTypeName("LPCSTR *")] sbyte** lpStrings, [NativeTypeName("LPVOID")] void* lpRawData);

        [DllImport("kernel32", EntryPoint = "ReportEventW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ReportEventW([NativeTypeName("HANDLE")] IntPtr hEventLog, [NativeTypeName("WORD")] ushort wType, [NativeTypeName("WORD")] ushort wCategory, [NativeTypeName("DWORD")] uint dwEventID, [NativeTypeName("PSID")] void* lpUserSid, [NativeTypeName("WORD")] ushort wNumStrings, [NativeTypeName("DWORD")] uint dwDataSize, [NativeTypeName("LPCWSTR *")] ushort** lpStrings, [NativeTypeName("LPVOID")] void* lpRawData);

        [DllImport("advapi32", EntryPoint = "GetEventLogInformation", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetEventLogInformation([NativeTypeName("HANDLE")] IntPtr hEventLog, [NativeTypeName("DWORD")] uint dwInfoLevel, [NativeTypeName("LPVOID")] void* lpBuffer, [NativeTypeName("DWORD")] uint cbBufSize, [NativeTypeName("LPDWORD")] uint* pcbBytesNeeded);

        [DllImport("advapi32", EntryPoint = "OperationStart", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int OperationStart([NativeTypeName("OPERATION_START_PARAMETERS *")] OPERATION_START_PARAMETERS* OperationStartParams);

        [DllImport("advapi32", EntryPoint = "OperationEnd", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int OperationEnd([NativeTypeName("OPERATION_END_PARAMETERS *")] OPERATION_END_PARAMETERS* OperationEndParams);

        [DllImport("kernel32", EntryPoint = "AccessCheckAndAuditAlarmA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int AccessCheckAndAuditAlarmA([NativeTypeName("LPCSTR")] sbyte* SubsystemName, [NativeTypeName("LPVOID")] void* HandleId, [NativeTypeName("LPSTR")] sbyte* ObjectTypeName, [NativeTypeName("LPSTR")] sbyte* ObjectName, [NativeTypeName("PSECURITY_DESCRIPTOR")] void* SecurityDescriptor, [NativeTypeName("DWORD")] uint DesiredAccess, [NativeTypeName("PGENERIC_MAPPING")] GENERIC_MAPPING* GenericMapping, [NativeTypeName("BOOL")] int ObjectCreation, [NativeTypeName("LPDWORD")] uint* GrantedAccess, [NativeTypeName("LPBOOL")] int* AccessStatus, [NativeTypeName("LPBOOL")] int* pfGenerateOnClose);

        [DllImport("kernel32", EntryPoint = "AccessCheckByTypeAndAuditAlarmA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int AccessCheckByTypeAndAuditAlarmA([NativeTypeName("LPCSTR")] sbyte* SubsystemName, [NativeTypeName("LPVOID")] void* HandleId, [NativeTypeName("LPCSTR")] sbyte* ObjectTypeName, [NativeTypeName("LPCSTR")] sbyte* ObjectName, [NativeTypeName("PSECURITY_DESCRIPTOR")] void* SecurityDescriptor, [NativeTypeName("PSID")] void* PrincipalSelfSid, [NativeTypeName("DWORD")] uint DesiredAccess, AUDIT_EVENT_TYPE AuditType, [NativeTypeName("DWORD")] uint Flags, [NativeTypeName("POBJECT_TYPE_LIST")] OBJECT_TYPE_LIST* ObjectTypeList, [NativeTypeName("DWORD")] uint ObjectTypeListLength, [NativeTypeName("PGENERIC_MAPPING")] GENERIC_MAPPING* GenericMapping, [NativeTypeName("BOOL")] int ObjectCreation, [NativeTypeName("LPDWORD")] uint* GrantedAccess, [NativeTypeName("LPBOOL")] int* AccessStatus, [NativeTypeName("LPBOOL")] int* pfGenerateOnClose);

        [DllImport("kernel32", EntryPoint = "AccessCheckByTypeResultListAndAuditAlarmA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int AccessCheckByTypeResultListAndAuditAlarmA([NativeTypeName("LPCSTR")] sbyte* SubsystemName, [NativeTypeName("LPVOID")] void* HandleId, [NativeTypeName("LPCSTR")] sbyte* ObjectTypeName, [NativeTypeName("LPCSTR")] sbyte* ObjectName, [NativeTypeName("PSECURITY_DESCRIPTOR")] void* SecurityDescriptor, [NativeTypeName("PSID")] void* PrincipalSelfSid, [NativeTypeName("DWORD")] uint DesiredAccess, AUDIT_EVENT_TYPE AuditType, [NativeTypeName("DWORD")] uint Flags, [NativeTypeName("POBJECT_TYPE_LIST")] OBJECT_TYPE_LIST* ObjectTypeList, [NativeTypeName("DWORD")] uint ObjectTypeListLength, [NativeTypeName("PGENERIC_MAPPING")] GENERIC_MAPPING* GenericMapping, [NativeTypeName("BOOL")] int ObjectCreation, [NativeTypeName("LPDWORD")] uint* GrantedAccess, [NativeTypeName("LPDWORD")] uint* AccessStatusList, [NativeTypeName("LPBOOL")] int* pfGenerateOnClose);

        [DllImport("kernel32", EntryPoint = "AccessCheckByTypeResultListAndAuditAlarmByHandleA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int AccessCheckByTypeResultListAndAuditAlarmByHandleA([NativeTypeName("LPCSTR")] sbyte* SubsystemName, [NativeTypeName("LPVOID")] void* HandleId, [NativeTypeName("HANDLE")] IntPtr ClientToken, [NativeTypeName("LPCSTR")] sbyte* ObjectTypeName, [NativeTypeName("LPCSTR")] sbyte* ObjectName, [NativeTypeName("PSECURITY_DESCRIPTOR")] void* SecurityDescriptor, [NativeTypeName("PSID")] void* PrincipalSelfSid, [NativeTypeName("DWORD")] uint DesiredAccess, AUDIT_EVENT_TYPE AuditType, [NativeTypeName("DWORD")] uint Flags, [NativeTypeName("POBJECT_TYPE_LIST")] OBJECT_TYPE_LIST* ObjectTypeList, [NativeTypeName("DWORD")] uint ObjectTypeListLength, [NativeTypeName("PGENERIC_MAPPING")] GENERIC_MAPPING* GenericMapping, [NativeTypeName("BOOL")] int ObjectCreation, [NativeTypeName("LPDWORD")] uint* GrantedAccess, [NativeTypeName("LPDWORD")] uint* AccessStatusList, [NativeTypeName("LPBOOL")] int* pfGenerateOnClose);

        [DllImport("kernel32", EntryPoint = "ObjectOpenAuditAlarmA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ObjectOpenAuditAlarmA([NativeTypeName("LPCSTR")] sbyte* SubsystemName, [NativeTypeName("LPVOID")] void* HandleId, [NativeTypeName("LPSTR")] sbyte* ObjectTypeName, [NativeTypeName("LPSTR")] sbyte* ObjectName, [NativeTypeName("PSECURITY_DESCRIPTOR")] void* pSecurityDescriptor, [NativeTypeName("HANDLE")] IntPtr ClientToken, [NativeTypeName("DWORD")] uint DesiredAccess, [NativeTypeName("DWORD")] uint GrantedAccess, [NativeTypeName("PPRIVILEGE_SET")] PRIVILEGE_SET* Privileges, [NativeTypeName("BOOL")] int ObjectCreation, [NativeTypeName("BOOL")] int AccessGranted, [NativeTypeName("LPBOOL")] int* GenerateOnClose);

        [DllImport("kernel32", EntryPoint = "ObjectPrivilegeAuditAlarmA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ObjectPrivilegeAuditAlarmA([NativeTypeName("LPCSTR")] sbyte* SubsystemName, [NativeTypeName("LPVOID")] void* HandleId, [NativeTypeName("HANDLE")] IntPtr ClientToken, [NativeTypeName("DWORD")] uint DesiredAccess, [NativeTypeName("PPRIVILEGE_SET")] PRIVILEGE_SET* Privileges, [NativeTypeName("BOOL")] int AccessGranted);

        [DllImport("kernel32", EntryPoint = "ObjectCloseAuditAlarmA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ObjectCloseAuditAlarmA([NativeTypeName("LPCSTR")] sbyte* SubsystemName, [NativeTypeName("LPVOID")] void* HandleId, [NativeTypeName("BOOL")] int GenerateOnClose);

        [DllImport("kernel32", EntryPoint = "ObjectDeleteAuditAlarmA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ObjectDeleteAuditAlarmA([NativeTypeName("LPCSTR")] sbyte* SubsystemName, [NativeTypeName("LPVOID")] void* HandleId, [NativeTypeName("BOOL")] int GenerateOnClose);

        [DllImport("kernel32", EntryPoint = "PrivilegedServiceAuditAlarmA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int PrivilegedServiceAuditAlarmA([NativeTypeName("LPCSTR")] sbyte* SubsystemName, [NativeTypeName("LPCSTR")] sbyte* ServiceName, [NativeTypeName("HANDLE")] IntPtr ClientToken, [NativeTypeName("PPRIVILEGE_SET")] PRIVILEGE_SET* Privileges, [NativeTypeName("BOOL")] int AccessGranted);

        [DllImport("advapi32", EntryPoint = "AddConditionalAce", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int AddConditionalAce([NativeTypeName("PACL")] ACL* pAcl, [NativeTypeName("DWORD")] uint dwAceRevision, [NativeTypeName("DWORD")] uint AceFlags, [NativeTypeName("UCHAR")] byte AceType, [NativeTypeName("DWORD")] uint AccessMask, [NativeTypeName("PSID")] void* pSid, [NativeTypeName("PWCHAR")] ushort* ConditionStr, [NativeTypeName("DWORD *")] uint* ReturnLength);

        [DllImport("kernel32", EntryPoint = "SetFileSecurityA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetFileSecurityA([NativeTypeName("LPCSTR")] sbyte* lpFileName, [NativeTypeName("SECURITY_INFORMATION")] uint SecurityInformation, [NativeTypeName("PSECURITY_DESCRIPTOR")] void* pSecurityDescriptor);

        [DllImport("kernel32", EntryPoint = "GetFileSecurityA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetFileSecurityA([NativeTypeName("LPCSTR")] sbyte* lpFileName, [NativeTypeName("SECURITY_INFORMATION")] uint RequestedInformation, [NativeTypeName("PSECURITY_DESCRIPTOR")] void* pSecurityDescriptor, [NativeTypeName("DWORD")] uint nLength, [NativeTypeName("LPDWORD")] uint* lpnLengthNeeded);

        [DllImport("kernel32", EntryPoint = "ReadDirectoryChangesW", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ReadDirectoryChangesW([NativeTypeName("HANDLE")] IntPtr hDirectory, [NativeTypeName("LPVOID")] void* lpBuffer, [NativeTypeName("DWORD")] uint nBufferLength, [NativeTypeName("BOOL")] int bWatchSubtree, [NativeTypeName("DWORD")] uint dwNotifyFilter, [NativeTypeName("LPDWORD")] uint* lpBytesReturned, [NativeTypeName("LPOVERLAPPED")] OVERLAPPED* lpOverlapped, [NativeTypeName("LPOVERLAPPED_COMPLETION_ROUTINE")] delegate* stdcall<uint, uint, OVERLAPPED*, void> lpCompletionRoutine);

        [DllImport("kernel32", EntryPoint = "ReadDirectoryChangesExW", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ReadDirectoryChangesExW([NativeTypeName("HANDLE")] IntPtr hDirectory, [NativeTypeName("LPVOID")] void* lpBuffer, [NativeTypeName("DWORD")] uint nBufferLength, [NativeTypeName("BOOL")] int bWatchSubtree, [NativeTypeName("DWORD")] uint dwNotifyFilter, [NativeTypeName("LPDWORD")] uint* lpBytesReturned, [NativeTypeName("LPOVERLAPPED")] OVERLAPPED* lpOverlapped, [NativeTypeName("LPOVERLAPPED_COMPLETION_ROUTINE")] delegate* stdcall<uint, uint, OVERLAPPED*, void> lpCompletionRoutine, READ_DIRECTORY_NOTIFY_INFORMATION_CLASS ReadDirectoryNotifyInformationClass);

        [DllImport("kernel32", EntryPoint = "MapViewOfFileExNuma", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("LPVOID")]
        public static extern void* MapViewOfFileExNuma([NativeTypeName("HANDLE")] IntPtr hFileMappingObject, [NativeTypeName("DWORD")] uint dwDesiredAccess, [NativeTypeName("DWORD")] uint dwFileOffsetHigh, [NativeTypeName("DWORD")] uint dwFileOffsetLow, [NativeTypeName("SIZE_T")] nuint dwNumberOfBytesToMap, [NativeTypeName("LPVOID")] void* lpBaseAddress, [NativeTypeName("DWORD")] uint nndPreferred);

        [DllImport("kernel32", EntryPoint = "IsBadReadPtr", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int IsBadReadPtr([NativeTypeName("const void *")] void* lp, [NativeTypeName("UINT_PTR")] nuint ucb);

        [DllImport("kernel32", EntryPoint = "IsBadWritePtr", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int IsBadWritePtr([NativeTypeName("LPVOID")] void* lp, [NativeTypeName("UINT_PTR")] nuint ucb);

        [DllImport("kernel32", EntryPoint = "IsBadHugeReadPtr", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int IsBadHugeReadPtr([NativeTypeName("const void *")] void* lp, [NativeTypeName("UINT_PTR")] nuint ucb);

        [DllImport("kernel32", EntryPoint = "IsBadHugeWritePtr", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int IsBadHugeWritePtr([NativeTypeName("LPVOID")] void* lp, [NativeTypeName("UINT_PTR")] nuint ucb);

        [DllImport("kernel32", EntryPoint = "IsBadCodePtr", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int IsBadCodePtr([NativeTypeName("FARPROC")] delegate* stdcall<int> lpfn);

        [DllImport("kernel32", EntryPoint = "IsBadStringPtrA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int IsBadStringPtrA([NativeTypeName("LPCSTR")] sbyte* lpsz, [NativeTypeName("UINT_PTR")] nuint ucchMax);

        [DllImport("kernel32", EntryPoint = "IsBadStringPtrW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int IsBadStringPtrW([NativeTypeName("LPCWSTR")] ushort* lpsz, [NativeTypeName("UINT_PTR")] nuint ucchMax);

        [DllImport("kernel32", EntryPoint = "LookupAccountSidA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int LookupAccountSidA([NativeTypeName("LPCSTR")] sbyte* lpSystemName, [NativeTypeName("PSID")] void* Sid, [NativeTypeName("LPSTR")] sbyte* Name, [NativeTypeName("LPDWORD")] uint* cchName, [NativeTypeName("LPSTR")] sbyte* ReferencedDomainName, [NativeTypeName("LPDWORD")] uint* cchReferencedDomainName, [NativeTypeName("PSID_NAME_USE")] SID_NAME_USE* peUse);

        [DllImport("kernel32", EntryPoint = "LookupAccountSidW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int LookupAccountSidW([NativeTypeName("LPCWSTR")] ushort* lpSystemName, [NativeTypeName("PSID")] void* Sid, [NativeTypeName("LPWSTR")] ushort* Name, [NativeTypeName("LPDWORD")] uint* cchName, [NativeTypeName("LPWSTR")] ushort* ReferencedDomainName, [NativeTypeName("LPDWORD")] uint* cchReferencedDomainName, [NativeTypeName("PSID_NAME_USE")] SID_NAME_USE* peUse);

        [DllImport("kernel32", EntryPoint = "LookupAccountNameA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int LookupAccountNameA([NativeTypeName("LPCSTR")] sbyte* lpSystemName, [NativeTypeName("LPCSTR")] sbyte* lpAccountName, [NativeTypeName("PSID")] void* Sid, [NativeTypeName("LPDWORD")] uint* cbSid, [NativeTypeName("LPSTR")] sbyte* ReferencedDomainName, [NativeTypeName("LPDWORD")] uint* cchReferencedDomainName, [NativeTypeName("PSID_NAME_USE")] SID_NAME_USE* peUse);

        [DllImport("kernel32", EntryPoint = "LookupAccountNameW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int LookupAccountNameW([NativeTypeName("LPCWSTR")] ushort* lpSystemName, [NativeTypeName("LPCWSTR")] ushort* lpAccountName, [NativeTypeName("PSID")] void* Sid, [NativeTypeName("LPDWORD")] uint* cbSid, [NativeTypeName("LPWSTR")] ushort* ReferencedDomainName, [NativeTypeName("LPDWORD")] uint* cchReferencedDomainName, [NativeTypeName("PSID_NAME_USE")] SID_NAME_USE* peUse);

        [DllImport("kernel32", EntryPoint = "LookupAccountNameLocalA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int LookupAccountNameLocalA([NativeTypeName("LPCSTR")] sbyte* lpAccountName, [NativeTypeName("PSID")] void* Sid, [NativeTypeName("LPDWORD")] uint* cbSid, [NativeTypeName("LPSTR")] sbyte* ReferencedDomainName, [NativeTypeName("LPDWORD")] uint* cchReferencedDomainName, [NativeTypeName("PSID_NAME_USE")] SID_NAME_USE* peUse);

        [DllImport("kernel32", EntryPoint = "LookupAccountNameLocalW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int LookupAccountNameLocalW([NativeTypeName("LPCWSTR")] ushort* lpAccountName, [NativeTypeName("PSID")] void* Sid, [NativeTypeName("LPDWORD")] uint* cbSid, [NativeTypeName("LPWSTR")] ushort* ReferencedDomainName, [NativeTypeName("LPDWORD")] uint* cchReferencedDomainName, [NativeTypeName("PSID_NAME_USE")] SID_NAME_USE* peUse);

        [DllImport("kernel32", EntryPoint = "LookupAccountSidLocalA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int LookupAccountSidLocalA([NativeTypeName("PSID")] void* Sid, [NativeTypeName("LPSTR")] sbyte* Name, [NativeTypeName("LPDWORD")] uint* cchName, [NativeTypeName("LPSTR")] sbyte* ReferencedDomainName, [NativeTypeName("LPDWORD")] uint* cchReferencedDomainName, [NativeTypeName("PSID_NAME_USE")] SID_NAME_USE* peUse);

        [DllImport("kernel32", EntryPoint = "LookupAccountSidLocalW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int LookupAccountSidLocalW([NativeTypeName("PSID")] void* Sid, [NativeTypeName("LPWSTR")] ushort* Name, [NativeTypeName("LPDWORD")] uint* cchName, [NativeTypeName("LPWSTR")] ushort* ReferencedDomainName, [NativeTypeName("LPDWORD")] uint* cchReferencedDomainName, [NativeTypeName("PSID_NAME_USE")] SID_NAME_USE* peUse);

        [DllImport("kernel32", EntryPoint = "LookupPrivilegeValueA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int LookupPrivilegeValueA([NativeTypeName("LPCSTR")] sbyte* lpSystemName, [NativeTypeName("LPCSTR")] sbyte* lpName, [NativeTypeName("PLUID")] LUID* lpLuid);

        [DllImport("kernel32", EntryPoint = "LookupPrivilegeValueW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int LookupPrivilegeValueW([NativeTypeName("LPCWSTR")] ushort* lpSystemName, [NativeTypeName("LPCWSTR")] ushort* lpName, [NativeTypeName("PLUID")] LUID* lpLuid);

        [DllImport("kernel32", EntryPoint = "LookupPrivilegeNameA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int LookupPrivilegeNameA([NativeTypeName("LPCSTR")] sbyte* lpSystemName, [NativeTypeName("PLUID")] LUID* lpLuid, [NativeTypeName("LPSTR")] sbyte* lpName, [NativeTypeName("LPDWORD")] uint* cchName);

        [DllImport("kernel32", EntryPoint = "LookupPrivilegeNameW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int LookupPrivilegeNameW([NativeTypeName("LPCWSTR")] ushort* lpSystemName, [NativeTypeName("PLUID")] LUID* lpLuid, [NativeTypeName("LPWSTR")] ushort* lpName, [NativeTypeName("LPDWORD")] uint* cchName);

        [DllImport("kernel32", EntryPoint = "LookupPrivilegeDisplayNameA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int LookupPrivilegeDisplayNameA([NativeTypeName("LPCSTR")] sbyte* lpSystemName, [NativeTypeName("LPCSTR")] sbyte* lpName, [NativeTypeName("LPSTR")] sbyte* lpDisplayName, [NativeTypeName("LPDWORD")] uint* cchDisplayName, [NativeTypeName("LPDWORD")] uint* lpLanguageId);

        [DllImport("kernel32", EntryPoint = "LookupPrivilegeDisplayNameW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int LookupPrivilegeDisplayNameW([NativeTypeName("LPCWSTR")] ushort* lpSystemName, [NativeTypeName("LPCWSTR")] ushort* lpName, [NativeTypeName("LPWSTR")] ushort* lpDisplayName, [NativeTypeName("LPDWORD")] uint* cchDisplayName, [NativeTypeName("LPDWORD")] uint* lpLanguageId);

        [DllImport("kernel32", EntryPoint = "BuildCommDCBA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int BuildCommDCBA([NativeTypeName("LPCSTR")] sbyte* lpDef, [NativeTypeName("LPDCB")] DCB* lpDCB);

        [DllImport("kernel32", EntryPoint = "BuildCommDCBW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int BuildCommDCBW([NativeTypeName("LPCWSTR")] ushort* lpDef, [NativeTypeName("LPDCB")] DCB* lpDCB);

        [DllImport("kernel32", EntryPoint = "BuildCommDCBAndTimeoutsA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int BuildCommDCBAndTimeoutsA([NativeTypeName("LPCSTR")] sbyte* lpDef, [NativeTypeName("LPDCB")] DCB* lpDCB, [NativeTypeName("LPCOMMTIMEOUTS")] COMMTIMEOUTS* lpCommTimeouts);

        [DllImport("kernel32", EntryPoint = "BuildCommDCBAndTimeoutsW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int BuildCommDCBAndTimeoutsW([NativeTypeName("LPCWSTR")] ushort* lpDef, [NativeTypeName("LPDCB")] DCB* lpDCB, [NativeTypeName("LPCOMMTIMEOUTS")] COMMTIMEOUTS* lpCommTimeouts);

        [DllImport("kernel32", EntryPoint = "CommConfigDialogA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CommConfigDialogA([NativeTypeName("LPCSTR")] sbyte* lpszName, [NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("LPCOMMCONFIG")] COMMCONFIG* lpCC);

        [DllImport("kernel32", EntryPoint = "CommConfigDialogW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CommConfigDialogW([NativeTypeName("LPCWSTR")] ushort* lpszName, [NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("LPCOMMCONFIG")] COMMCONFIG* lpCC);

        [DllImport("kernel32", EntryPoint = "GetDefaultCommConfigA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetDefaultCommConfigA([NativeTypeName("LPCSTR")] sbyte* lpszName, [NativeTypeName("LPCOMMCONFIG")] COMMCONFIG* lpCC, [NativeTypeName("LPDWORD")] uint* lpdwSize);

        [DllImport("kernel32", EntryPoint = "GetDefaultCommConfigW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetDefaultCommConfigW([NativeTypeName("LPCWSTR")] ushort* lpszName, [NativeTypeName("LPCOMMCONFIG")] COMMCONFIG* lpCC, [NativeTypeName("LPDWORD")] uint* lpdwSize);

        [DllImport("kernel32", EntryPoint = "SetDefaultCommConfigA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetDefaultCommConfigA([NativeTypeName("LPCSTR")] sbyte* lpszName, [NativeTypeName("LPCOMMCONFIG")] COMMCONFIG* lpCC, [NativeTypeName("DWORD")] uint dwSize);

        [DllImport("kernel32", EntryPoint = "SetDefaultCommConfigW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetDefaultCommConfigW([NativeTypeName("LPCWSTR")] ushort* lpszName, [NativeTypeName("LPCOMMCONFIG")] COMMCONFIG* lpCC, [NativeTypeName("DWORD")] uint dwSize);

        [DllImport("kernel32", EntryPoint = "GetComputerNameA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetComputerNameA([NativeTypeName("LPSTR")] sbyte* lpBuffer, [NativeTypeName("LPDWORD")] uint* nSize);

        [DllImport("kernel32", EntryPoint = "GetComputerNameW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetComputerNameW([NativeTypeName("LPWSTR")] ushort* lpBuffer, [NativeTypeName("LPDWORD")] uint* nSize);

        [DllImport("kernel32", EntryPoint = "DnsHostnameToComputerNameA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int DnsHostnameToComputerNameA([NativeTypeName("LPCSTR")] sbyte* Hostname, [NativeTypeName("LPSTR")] sbyte* ComputerName, [NativeTypeName("LPDWORD")] uint* nSize);

        [DllImport("kernel32", EntryPoint = "DnsHostnameToComputerNameW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int DnsHostnameToComputerNameW([NativeTypeName("LPCWSTR")] ushort* Hostname, [NativeTypeName("LPWSTR")] ushort* ComputerName, [NativeTypeName("LPDWORD")] uint* nSize);

        [DllImport("kernel32", EntryPoint = "GetUserNameA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetUserNameA([NativeTypeName("LPSTR")] sbyte* lpBuffer, [NativeTypeName("LPDWORD")] uint* pcbBuffer);

        [DllImport("kernel32", EntryPoint = "GetUserNameW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetUserNameW([NativeTypeName("LPWSTR")] ushort* lpBuffer, [NativeTypeName("LPDWORD")] uint* pcbBuffer);

        [DllImport("kernel32", EntryPoint = "LogonUserA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int LogonUserA([NativeTypeName("LPCSTR")] sbyte* lpszUsername, [NativeTypeName("LPCSTR")] sbyte* lpszDomain, [NativeTypeName("LPCSTR")] sbyte* lpszPassword, [NativeTypeName("DWORD")] uint dwLogonType, [NativeTypeName("DWORD")] uint dwLogonProvider, [NativeTypeName("PHANDLE")] IntPtr* phToken);

        [DllImport("kernel32", EntryPoint = "LogonUserW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int LogonUserW([NativeTypeName("LPCWSTR")] ushort* lpszUsername, [NativeTypeName("LPCWSTR")] ushort* lpszDomain, [NativeTypeName("LPCWSTR")] ushort* lpszPassword, [NativeTypeName("DWORD")] uint dwLogonType, [NativeTypeName("DWORD")] uint dwLogonProvider, [NativeTypeName("PHANDLE")] IntPtr* phToken);

        [DllImport("kernel32", EntryPoint = "LogonUserExA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int LogonUserExA([NativeTypeName("LPCSTR")] sbyte* lpszUsername, [NativeTypeName("LPCSTR")] sbyte* lpszDomain, [NativeTypeName("LPCSTR")] sbyte* lpszPassword, [NativeTypeName("DWORD")] uint dwLogonType, [NativeTypeName("DWORD")] uint dwLogonProvider, [NativeTypeName("PHANDLE")] IntPtr* phToken, [NativeTypeName("PSID *")] void** ppLogonSid, [NativeTypeName("PVOID *")] void** ppProfileBuffer, [NativeTypeName("LPDWORD")] uint* pdwProfileLength, [NativeTypeName("PQUOTA_LIMITS")] QUOTA_LIMITS* pQuotaLimits);

        [DllImport("kernel32", EntryPoint = "LogonUserExW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int LogonUserExW([NativeTypeName("LPCWSTR")] ushort* lpszUsername, [NativeTypeName("LPCWSTR")] ushort* lpszDomain, [NativeTypeName("LPCWSTR")] ushort* lpszPassword, [NativeTypeName("DWORD")] uint dwLogonType, [NativeTypeName("DWORD")] uint dwLogonProvider, [NativeTypeName("PHANDLE")] IntPtr* phToken, [NativeTypeName("PSID *")] void** ppLogonSid, [NativeTypeName("PVOID *")] void** ppProfileBuffer, [NativeTypeName("LPDWORD")] uint* pdwProfileLength, [NativeTypeName("PQUOTA_LIMITS")] QUOTA_LIMITS* pQuotaLimits);

        [DllImport("advapi32", EntryPoint = "CreateProcessWithLogonW", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CreateProcessWithLogonW([NativeTypeName("LPCWSTR")] ushort* lpUsername, [NativeTypeName("LPCWSTR")] ushort* lpDomain, [NativeTypeName("LPCWSTR")] ushort* lpPassword, [NativeTypeName("DWORD")] uint dwLogonFlags, [NativeTypeName("LPCWSTR")] ushort* lpApplicationName, [NativeTypeName("LPWSTR")] ushort* lpCommandLine, [NativeTypeName("DWORD")] uint dwCreationFlags, [NativeTypeName("LPVOID")] void* lpEnvironment, [NativeTypeName("LPCWSTR")] ushort* lpCurrentDirectory, [NativeTypeName("LPSTARTUPINFOW")] STARTUPINFOW* lpStartupInfo, [NativeTypeName("LPPROCESS_INFORMATION")] PROCESS_INFORMATION* lpProcessInformation);

        [DllImport("advapi32", EntryPoint = "CreateProcessWithTokenW", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CreateProcessWithTokenW([NativeTypeName("HANDLE")] IntPtr hToken, [NativeTypeName("DWORD")] uint dwLogonFlags, [NativeTypeName("LPCWSTR")] ushort* lpApplicationName, [NativeTypeName("LPWSTR")] ushort* lpCommandLine, [NativeTypeName("DWORD")] uint dwCreationFlags, [NativeTypeName("LPVOID")] void* lpEnvironment, [NativeTypeName("LPCWSTR")] ushort* lpCurrentDirectory, [NativeTypeName("LPSTARTUPINFOW")] STARTUPINFOW* lpStartupInfo, [NativeTypeName("LPPROCESS_INFORMATION")] PROCESS_INFORMATION* lpProcessInformation);

        [DllImport("kernel32", EntryPoint = "IsTokenUntrusted", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int IsTokenUntrusted([NativeTypeName("HANDLE")] IntPtr TokenHandle);

        [DllImport("kernel32", EntryPoint = "RegisterWaitForSingleObject", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int RegisterWaitForSingleObject([NativeTypeName("PHANDLE")] IntPtr* phNewWaitObject, [NativeTypeName("HANDLE")] IntPtr hObject, [NativeTypeName("WAITORTIMERCALLBACK")] delegate* stdcall<void*, byte, void> Callback, [NativeTypeName("PVOID")] void* Context, [NativeTypeName("ULONG")] uint dwMilliseconds, [NativeTypeName("ULONG")] uint dwFlags);

        [DllImport("kernel32", EntryPoint = "UnregisterWait", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int UnregisterWait([NativeTypeName("HANDLE")] IntPtr WaitHandle);

        [DllImport("kernel32", EntryPoint = "BindIoCompletionCallback", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int BindIoCompletionCallback([NativeTypeName("HANDLE")] IntPtr FileHandle, [NativeTypeName("LPOVERLAPPED_COMPLETION_ROUTINE")] delegate* stdcall<uint, uint, OVERLAPPED*, void> Function, [NativeTypeName("ULONG")] uint Flags);

        [DllImport("kernel32", EntryPoint = "SetTimerQueueTimer", ExactSpelling = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern IntPtr SetTimerQueueTimer([NativeTypeName("HANDLE")] IntPtr TimerQueue, [NativeTypeName("WAITORTIMERCALLBACK")] delegate* stdcall<void*, byte, void> Callback, [NativeTypeName("PVOID")] void* Parameter, [NativeTypeName("DWORD")] uint DueTime, [NativeTypeName("DWORD")] uint Period, [NativeTypeName("BOOL")] int PreferIo);

        [DllImport("kernel32", EntryPoint = "CancelTimerQueueTimer", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CancelTimerQueueTimer([NativeTypeName("HANDLE")] IntPtr TimerQueue, [NativeTypeName("HANDLE")] IntPtr Timer);

        [DllImport("kernel32", EntryPoint = "DeleteTimerQueue", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int DeleteTimerQueue([NativeTypeName("HANDLE")] IntPtr TimerQueue);

        [DllImport("kernel32", EntryPoint = "CreatePrivateNamespaceA", ExactSpelling = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern IntPtr CreatePrivateNamespaceA([NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpPrivateNamespaceAttributes, [NativeTypeName("LPVOID")] void* lpBoundaryDescriptor, [NativeTypeName("LPCSTR")] sbyte* lpAliasPrefix);

        [DllImport("kernel32", EntryPoint = "OpenPrivateNamespaceA", ExactSpelling = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern IntPtr OpenPrivateNamespaceA([NativeTypeName("LPVOID")] void* lpBoundaryDescriptor, [NativeTypeName("LPCSTR")] sbyte* lpAliasPrefix);

        [DllImport("kernel32", EntryPoint = "CreateBoundaryDescriptorA", ExactSpelling = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern IntPtr CreateBoundaryDescriptorA([NativeTypeName("LPCSTR")] sbyte* Name, [NativeTypeName("ULONG")] uint Flags);

        [DllImport("kernel32", EntryPoint = "AddIntegrityLabelToBoundaryDescriptor", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int AddIntegrityLabelToBoundaryDescriptor([NativeTypeName("HANDLE *")] IntPtr* BoundaryDescriptor, [NativeTypeName("PSID")] void* IntegrityLabel);

        [DllImport("kernel32", EntryPoint = "GetCurrentHwProfileA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetCurrentHwProfileA([NativeTypeName("LPHW_PROFILE_INFOA")] HW_PROFILE_INFOA* lpHwProfileInfo);

        [DllImport("kernel32", EntryPoint = "GetCurrentHwProfileW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetCurrentHwProfileW([NativeTypeName("LPHW_PROFILE_INFOW")] HW_PROFILE_INFOW* lpHwProfileInfo);

        [DllImport("kernel32", EntryPoint = "VerifyVersionInfoA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int VerifyVersionInfoA([NativeTypeName("LPOSVERSIONINFOEXA")] OSVERSIONINFOEXA* lpVersionInformation, [NativeTypeName("DWORD")] uint dwTypeMask, [NativeTypeName("DWORDLONG")] ulong dwlConditionMask);

        [DllImport("kernel32", EntryPoint = "VerifyVersionInfoW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int VerifyVersionInfoW([NativeTypeName("LPOSVERSIONINFOEXW")] OSVERSIONINFOEXW* lpVersionInformation, [NativeTypeName("DWORD")] uint dwTypeMask, [NativeTypeName("DWORDLONG")] ulong dwlConditionMask);

        [DllImport("kernel32", EntryPoint = "SetSystemPowerState", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetSystemPowerState([NativeTypeName("BOOL")] int fSuspend, [NativeTypeName("BOOL")] int fForce);

        [DllImport("kernel32", EntryPoint = "GetSystemPowerStatus", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetSystemPowerStatus([NativeTypeName("LPSYSTEM_POWER_STATUS")] SYSTEM_POWER_STATUS* lpSystemPowerStatus);

        [DllImport("kernel32", EntryPoint = "MapUserPhysicalPagesScatter", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int MapUserPhysicalPagesScatter([NativeTypeName("PVOID *")] void** VirtualAddresses, [NativeTypeName("ULONG_PTR")] nuint NumberOfPages, [NativeTypeName("PULONG_PTR")] uint* PageArray);

        [DllImport("kernel32", EntryPoint = "CreateJobObjectA", ExactSpelling = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern IntPtr CreateJobObjectA([NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpJobAttributes, [NativeTypeName("LPCSTR")] sbyte* lpName);

        [DllImport("kernel32", EntryPoint = "OpenJobObjectA", ExactSpelling = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern IntPtr OpenJobObjectA([NativeTypeName("DWORD")] uint dwDesiredAccess, [NativeTypeName("BOOL")] int bInheritHandle, [NativeTypeName("LPCSTR")] sbyte* lpName);

        [DllImport("kernel32", EntryPoint = "CreateJobSet", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CreateJobSet([NativeTypeName("ULONG")] uint NumJob, [NativeTypeName("PJOB_SET_ARRAY")] JOB_SET_ARRAY* UserJobSet, [NativeTypeName("ULONG")] uint Flags);

        [DllImport("kernel32", EntryPoint = "FindFirstVolumeA", ExactSpelling = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern IntPtr FindFirstVolumeA([NativeTypeName("LPSTR")] sbyte* lpszVolumeName, [NativeTypeName("DWORD")] uint cchBufferLength);

        [DllImport("kernel32", EntryPoint = "FindNextVolumeA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int FindNextVolumeA([NativeTypeName("HANDLE")] IntPtr hFindVolume, [NativeTypeName("LPSTR")] sbyte* lpszVolumeName, [NativeTypeName("DWORD")] uint cchBufferLength);

        [DllImport("kernel32", EntryPoint = "FindFirstVolumeMountPointA", ExactSpelling = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern IntPtr FindFirstVolumeMountPointA([NativeTypeName("LPCSTR")] sbyte* lpszRootPathName, [NativeTypeName("LPSTR")] sbyte* lpszVolumeMountPoint, [NativeTypeName("DWORD")] uint cchBufferLength);

        [DllImport("kernel32", EntryPoint = "FindFirstVolumeMountPointW", ExactSpelling = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern IntPtr FindFirstVolumeMountPointW([NativeTypeName("LPCWSTR")] ushort* lpszRootPathName, [NativeTypeName("LPWSTR")] ushort* lpszVolumeMountPoint, [NativeTypeName("DWORD")] uint cchBufferLength);

        [DllImport("kernel32", EntryPoint = "FindNextVolumeMountPointA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int FindNextVolumeMountPointA([NativeTypeName("HANDLE")] IntPtr hFindVolumeMountPoint, [NativeTypeName("LPSTR")] sbyte* lpszVolumeMountPoint, [NativeTypeName("DWORD")] uint cchBufferLength);

        [DllImport("kernel32", EntryPoint = "FindNextVolumeMountPointW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int FindNextVolumeMountPointW([NativeTypeName("HANDLE")] IntPtr hFindVolumeMountPoint, [NativeTypeName("LPWSTR")] ushort* lpszVolumeMountPoint, [NativeTypeName("DWORD")] uint cchBufferLength);

        [DllImport("kernel32", EntryPoint = "FindVolumeMountPointClose", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int FindVolumeMountPointClose([NativeTypeName("HANDLE")] IntPtr hFindVolumeMountPoint);

        [DllImport("kernel32", EntryPoint = "SetVolumeMountPointA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetVolumeMountPointA([NativeTypeName("LPCSTR")] sbyte* lpszVolumeMountPoint, [NativeTypeName("LPCSTR")] sbyte* lpszVolumeName);

        [DllImport("kernel32", EntryPoint = "SetVolumeMountPointW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetVolumeMountPointW([NativeTypeName("LPCWSTR")] ushort* lpszVolumeMountPoint, [NativeTypeName("LPCWSTR")] ushort* lpszVolumeName);

        [DllImport("kernel32", EntryPoint = "DeleteVolumeMountPointA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int DeleteVolumeMountPointA([NativeTypeName("LPCSTR")] sbyte* lpszVolumeMountPoint);

        [DllImport("kernel32", EntryPoint = "GetVolumeNameForVolumeMountPointA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetVolumeNameForVolumeMountPointA([NativeTypeName("LPCSTR")] sbyte* lpszVolumeMountPoint, [NativeTypeName("LPSTR")] sbyte* lpszVolumeName, [NativeTypeName("DWORD")] uint cchBufferLength);

        [DllImport("kernel32", EntryPoint = "GetVolumePathNameA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetVolumePathNameA([NativeTypeName("LPCSTR")] sbyte* lpszFileName, [NativeTypeName("LPSTR")] sbyte* lpszVolumePathName, [NativeTypeName("DWORD")] uint cchBufferLength);

        [DllImport("kernel32", EntryPoint = "GetVolumePathNamesForVolumeNameA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetVolumePathNamesForVolumeNameA([NativeTypeName("LPCSTR")] sbyte* lpszVolumeName, [NativeTypeName("LPCH")] sbyte* lpszVolumePathNames, [NativeTypeName("DWORD")] uint cchBufferLength, [NativeTypeName("PDWORD")] uint* lpcchReturnLength);

        [DllImport("kernel32", EntryPoint = "CreateActCtxA", ExactSpelling = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern IntPtr CreateActCtxA([NativeTypeName("PCACTCTXA")] ACTCTXA* pActCtx);

        [DllImport("kernel32", EntryPoint = "CreateActCtxW", ExactSpelling = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern IntPtr CreateActCtxW([NativeTypeName("PCACTCTXW")] ACTCTXW* pActCtx);

        [DllImport("kernel32", EntryPoint = "AddRefActCtx", ExactSpelling = true)]
        public static extern void AddRefActCtx([NativeTypeName("HANDLE")] IntPtr hActCtx);

        [DllImport("kernel32", EntryPoint = "ReleaseActCtx", ExactSpelling = true)]
        public static extern void ReleaseActCtx([NativeTypeName("HANDLE")] IntPtr hActCtx);

        [DllImport("kernel32", EntryPoint = "ZombifyActCtx", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ZombifyActCtx([NativeTypeName("HANDLE")] IntPtr hActCtx);

        [DllImport("kernel32", EntryPoint = "ActivateActCtx", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ActivateActCtx([NativeTypeName("HANDLE")] IntPtr hActCtx, [NativeTypeName("ULONG_PTR *")] nuint* lpCookie);

        [DllImport("kernel32", EntryPoint = "DeactivateActCtx", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int DeactivateActCtx([NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("ULONG_PTR")] nuint ulCookie);

        [DllImport("kernel32", EntryPoint = "GetCurrentActCtx", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetCurrentActCtx([NativeTypeName("HANDLE *")] IntPtr* lphActCtx);

        [DllImport("kernel32", EntryPoint = "FindActCtxSectionStringA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int FindActCtxSectionStringA([NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("const GUID *")] Guid* lpExtensionGuid, [NativeTypeName("ULONG")] uint ulSectionId, [NativeTypeName("LPCSTR")] sbyte* lpStringToFind, [NativeTypeName("PACTCTX_SECTION_KEYED_DATA")] ACTCTX_SECTION_KEYED_DATA* ReturnedData);

        [DllImport("kernel32", EntryPoint = "FindActCtxSectionStringW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int FindActCtxSectionStringW([NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("const GUID *")] Guid* lpExtensionGuid, [NativeTypeName("ULONG")] uint ulSectionId, [NativeTypeName("LPCWSTR")] ushort* lpStringToFind, [NativeTypeName("PACTCTX_SECTION_KEYED_DATA")] ACTCTX_SECTION_KEYED_DATA* ReturnedData);

        [DllImport("kernel32", EntryPoint = "FindActCtxSectionGuid", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int FindActCtxSectionGuid([NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("const GUID *")] Guid* lpExtensionGuid, [NativeTypeName("ULONG")] uint ulSectionId, [NativeTypeName("const GUID *")] Guid* lpGuidToFind, [NativeTypeName("PACTCTX_SECTION_KEYED_DATA")] ACTCTX_SECTION_KEYED_DATA* ReturnedData);

        [DllImport("kernel32", EntryPoint = "QueryActCtxW", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int QueryActCtxW([NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("HANDLE")] IntPtr hActCtx, [NativeTypeName("PVOID")] void* pvSubInstance, [NativeTypeName("ULONG")] uint ulInfoClass, [NativeTypeName("PVOID")] void* pvBuffer, [NativeTypeName("SIZE_T")] nuint cbBuffer, [NativeTypeName("SIZE_T *")] nuint* pcbWrittenOrRequired);

        [DllImport("kernel32", EntryPoint = "WTSGetActiveConsoleSessionId", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint WTSGetActiveConsoleSessionId();

        [DllImport("kernel32", EntryPoint = "WTSGetServiceSessionId", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint WTSGetServiceSessionId();

        [DllImport("kernel32", EntryPoint = "WTSIsServerContainer", ExactSpelling = true)]
        [return: NativeTypeName("BOOLEAN")]
        public static extern byte WTSIsServerContainer();

        [DllImport("kernel32", EntryPoint = "GetActiveProcessorGroupCount", ExactSpelling = true)]
        [return: NativeTypeName("WORD")]
        public static extern ushort GetActiveProcessorGroupCount();

        [DllImport("kernel32", EntryPoint = "GetMaximumProcessorGroupCount", ExactSpelling = true)]
        [return: NativeTypeName("WORD")]
        public static extern ushort GetMaximumProcessorGroupCount();

        [DllImport("kernel32", EntryPoint = "GetActiveProcessorCount", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetActiveProcessorCount([NativeTypeName("WORD")] ushort GroupNumber);

        [DllImport("kernel32", EntryPoint = "GetMaximumProcessorCount", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetMaximumProcessorCount([NativeTypeName("WORD")] ushort GroupNumber);

        [DllImport("kernel32", EntryPoint = "GetNumaProcessorNode", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetNumaProcessorNode([NativeTypeName("UCHAR")] byte Processor, [NativeTypeName("PUCHAR")] byte* NodeNumber);

        [DllImport("kernel32", EntryPoint = "GetNumaNodeNumberFromHandle", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetNumaNodeNumberFromHandle([NativeTypeName("HANDLE")] IntPtr hFile, [NativeTypeName("PUSHORT")] ushort* NodeNumber);

        [DllImport("kernel32", EntryPoint = "GetNumaProcessorNodeEx", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetNumaProcessorNodeEx([NativeTypeName("PPROCESSOR_NUMBER")] PROCESSOR_NUMBER* Processor, [NativeTypeName("PUSHORT")] ushort* NodeNumber);

        [DllImport("kernel32", EntryPoint = "GetNumaNodeProcessorMask", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetNumaNodeProcessorMask([NativeTypeName("UCHAR")] byte Node, [NativeTypeName("PULONGLONG")] ulong* ProcessorMask);

        [DllImport("kernel32", EntryPoint = "GetNumaAvailableMemoryNode", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetNumaAvailableMemoryNode([NativeTypeName("UCHAR")] byte Node, [NativeTypeName("PULONGLONG")] ulong* AvailableBytes);

        [DllImport("kernel32", EntryPoint = "GetNumaAvailableMemoryNodeEx", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetNumaAvailableMemoryNodeEx([NativeTypeName("USHORT")] ushort Node, [NativeTypeName("PULONGLONG")] ulong* AvailableBytes);

        [DllImport("kernel32", EntryPoint = "GetNumaProximityNode", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetNumaProximityNode([NativeTypeName("ULONG")] uint ProximityId, [NativeTypeName("PUCHAR")] byte* NodeNumber);

        [DllImport("kernel32", EntryPoint = "RegisterApplicationRecoveryCallback", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int RegisterApplicationRecoveryCallback([NativeTypeName("APPLICATION_RECOVERY_CALLBACK")] delegate* stdcall<void*, uint> pRecoveyCallback, [NativeTypeName("PVOID")] void* pvParameter, [NativeTypeName("DWORD")] uint dwPingInterval, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("kernel32", EntryPoint = "UnregisterApplicationRecoveryCallback", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int UnregisterApplicationRecoveryCallback();

        [DllImport("kernel32", EntryPoint = "RegisterApplicationRestart", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int RegisterApplicationRestart([NativeTypeName("PCWSTR")] ushort* pwzCommandline, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("kernel32", EntryPoint = "UnregisterApplicationRestart", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int UnregisterApplicationRestart();

        [DllImport("kernel32", EntryPoint = "GetApplicationRecoveryCallback", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int GetApplicationRecoveryCallback([NativeTypeName("HANDLE")] IntPtr hProcess, [NativeTypeName("APPLICATION_RECOVERY_CALLBACK *")] delegate* stdcall<void*, uint>* pRecoveryCallback, [NativeTypeName("PVOID *")] void** ppvParameter, [NativeTypeName("PDWORD")] uint* pdwPingInterval, [NativeTypeName("PDWORD")] uint* pdwFlags);

        [DllImport("kernel32", EntryPoint = "GetApplicationRestartSettings", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int GetApplicationRestartSettings([NativeTypeName("HANDLE")] IntPtr hProcess, [NativeTypeName("PWSTR")] ushort* pwzCommandline, [NativeTypeName("PDWORD")] uint* pcchSize, [NativeTypeName("PDWORD")] uint* pdwFlags);

        [DllImport("kernel32", EntryPoint = "ApplicationRecoveryInProgress", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int ApplicationRecoveryInProgress([NativeTypeName("PBOOL")] int* pbCancelled);

        [DllImport("kernel32", EntryPoint = "ApplicationRecoveryFinished", ExactSpelling = true)]
        public static extern void ApplicationRecoveryFinished([NativeTypeName("BOOL")] int bSuccess);

        [DllImport("kernel32", EntryPoint = "GetFileInformationByHandleEx", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetFileInformationByHandleEx([NativeTypeName("HANDLE")] IntPtr hFile, FILE_INFO_BY_HANDLE_CLASS FileInformationClass, [NativeTypeName("LPVOID")] void* lpFileInformation, [NativeTypeName("DWORD")] uint dwBufferSize);

        [DllImport("kernel32", EntryPoint = "OpenFileById", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern IntPtr OpenFileById([NativeTypeName("HANDLE")] IntPtr hVolumeHint, [NativeTypeName("LPFILE_ID_DESCRIPTOR")] FILE_ID_DESCRIPTOR* lpFileId, [NativeTypeName("DWORD")] uint dwDesiredAccess, [NativeTypeName("DWORD")] uint dwShareMode, [NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpSecurityAttributes, [NativeTypeName("DWORD")] uint dwFlagsAndAttributes);

        [DllImport("kernel32", EntryPoint = "CreateSymbolicLinkA", ExactSpelling = true)]
        [return: NativeTypeName("BOOLEAN")]
        public static extern byte CreateSymbolicLinkA([NativeTypeName("LPCSTR")] sbyte* lpSymlinkFileName, [NativeTypeName("LPCSTR")] sbyte* lpTargetFileName, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("kernel32", EntryPoint = "CreateSymbolicLinkW", ExactSpelling = true)]
        [return: NativeTypeName("BOOLEAN")]
        public static extern byte CreateSymbolicLinkW([NativeTypeName("LPCWSTR")] ushort* lpSymlinkFileName, [NativeTypeName("LPCWSTR")] ushort* lpTargetFileName, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("kernel32", EntryPoint = "QueryActCtxSettingsW", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int QueryActCtxSettingsW([NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("HANDLE")] IntPtr hActCtx, [NativeTypeName("PCWSTR")] ushort* settingsNameSpace, [NativeTypeName("PCWSTR")] ushort* settingName, [NativeTypeName("PWSTR")] ushort* pvBuffer, [NativeTypeName("SIZE_T")] nuint dwBuffer, [NativeTypeName("SIZE_T *")] nuint* pdwWrittenOrRequired);

        [DllImport("kernel32", EntryPoint = "CreateSymbolicLinkTransactedA", ExactSpelling = true)]
        [return: NativeTypeName("BOOLEAN")]
        public static extern byte CreateSymbolicLinkTransactedA([NativeTypeName("LPCSTR")] sbyte* lpSymlinkFileName, [NativeTypeName("LPCSTR")] sbyte* lpTargetFileName, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("HANDLE")] IntPtr hTransaction);

        [DllImport("kernel32", EntryPoint = "CreateSymbolicLinkTransactedW", ExactSpelling = true)]
        [return: NativeTypeName("BOOLEAN")]
        public static extern byte CreateSymbolicLinkTransactedW([NativeTypeName("LPCWSTR")] ushort* lpSymlinkFileName, [NativeTypeName("LPCWSTR")] ushort* lpTargetFileName, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("HANDLE")] IntPtr hTransaction);

        [DllImport("kernel32", EntryPoint = "ReplacePartitionUnit", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ReplacePartitionUnit([NativeTypeName("PWSTR")] ushort* TargetPartition, [NativeTypeName("PWSTR")] ushort* SparePartition, [NativeTypeName("ULONG")] uint Flags);

        [DllImport("kernel32", EntryPoint = "AddSecureMemoryCacheCallback", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int AddSecureMemoryCacheCallback([NativeTypeName("PSECURE_MEMORY_CACHE_CALLBACK")] delegate* stdcall<void*, nuint, byte> pfnCallBack);

        [DllImport("kernel32", EntryPoint = "RemoveSecureMemoryCacheCallback", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int RemoveSecureMemoryCacheCallback([NativeTypeName("PSECURE_MEMORY_CACHE_CALLBACK")] delegate* stdcall<void*, nuint, byte> pfnCallBack);

        [DllImport("kernel32", EntryPoint = "CopyContext", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CopyContext([NativeTypeName("PCONTEXT")] CONTEXT* Destination, [NativeTypeName("DWORD")] uint ContextFlags, [NativeTypeName("PCONTEXT")] CONTEXT* Source);

        [DllImport("kernel32", EntryPoint = "InitializeContext", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int InitializeContext([NativeTypeName("PVOID")] void* Buffer, [NativeTypeName("DWORD")] uint ContextFlags, [NativeTypeName("PCONTEXT *")] CONTEXT** Context, [NativeTypeName("PDWORD")] uint* ContextLength);

        [DllImport("kernel32", EntryPoint = "InitializeContext2", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int InitializeContext2([NativeTypeName("PVOID")] void* Buffer, [NativeTypeName("DWORD")] uint ContextFlags, [NativeTypeName("PCONTEXT *")] CONTEXT** Context, [NativeTypeName("PDWORD")] uint* ContextLength, [NativeTypeName("ULONG64")] ulong XStateCompactionMask);

        [DllImport("kernel32", EntryPoint = "GetEnabledXStateFeatures", ExactSpelling = true)]
        [return: NativeTypeName("DWORD64")]
        public static extern ulong GetEnabledXStateFeatures();

        [DllImport("kernel32", EntryPoint = "GetXStateFeaturesMask", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetXStateFeaturesMask([NativeTypeName("PCONTEXT")] CONTEXT* Context, [NativeTypeName("PDWORD64")] ulong* FeatureMask);

        [DllImport("kernel32", EntryPoint = "LocateXStateFeature", ExactSpelling = true)]
        [return: NativeTypeName("PVOID")]
        public static extern void* LocateXStateFeature([NativeTypeName("PCONTEXT")] CONTEXT* Context, [NativeTypeName("DWORD")] uint FeatureId, [NativeTypeName("PDWORD")] uint* Length);

        [DllImport("kernel32", EntryPoint = "SetXStateFeaturesMask", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetXStateFeaturesMask([NativeTypeName("PCONTEXT")] CONTEXT* Context, [NativeTypeName("DWORD64")] ulong FeatureMask);

        [DllImport("kernel32", EntryPoint = "EnableThreadProfiling", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint EnableThreadProfiling([NativeTypeName("HANDLE")] IntPtr ThreadHandle, [NativeTypeName("DWORD")] uint Flags, [NativeTypeName("DWORD64")] ulong HardwareCounters, [NativeTypeName("HANDLE *")] IntPtr* PerformanceDataHandle);

        [DllImport("kernel32", EntryPoint = "DisableThreadProfiling", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint DisableThreadProfiling([NativeTypeName("HANDLE")] IntPtr PerformanceDataHandle);

        [DllImport("kernel32", EntryPoint = "QueryThreadProfiling", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint QueryThreadProfiling([NativeTypeName("HANDLE")] IntPtr ThreadHandle, [NativeTypeName("PBOOLEAN")] byte* Enabled);

        [DllImport("kernel32", EntryPoint = "ReadThreadProfilingData", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint ReadThreadProfilingData([NativeTypeName("HANDLE")] IntPtr PerformanceDataHandle, [NativeTypeName("DWORD")] uint Flags, [NativeTypeName("PPERFORMANCE_DATA")] PERFORMANCE_DATA* PerformanceData);

        [DllImport("kernel32", EntryPoint = "RaiseCustomSystemEventTrigger", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint RaiseCustomSystemEventTrigger([NativeTypeName("PCUSTOM_SYSTEM_EVENT_TRIGGER_CONFIG")] CUSTOM_SYSTEM_EVENT_TRIGGER_CONFIG* CustomSystemEventTriggerConfig);
    }
}
