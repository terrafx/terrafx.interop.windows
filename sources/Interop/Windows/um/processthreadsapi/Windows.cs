// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/processthreadsapi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint QueueUserAPC([NativeTypeName("PAPCFUNC")] delegate* unmanaged<nuint, void> pfnAPC, [NativeTypeName("HANDLE")] IntPtr hThread, [NativeTypeName("ULONG_PTR")] nuint dwData);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetProcessTimes([NativeTypeName("HANDLE")] IntPtr hProcess, [NativeTypeName("LPFILETIME")] FILETIME* lpCreationTime, [NativeTypeName("LPFILETIME")] FILETIME* lpExitTime, [NativeTypeName("LPFILETIME")] FILETIME* lpKernelTime, [NativeTypeName("LPFILETIME")] FILETIME* lpUserTime);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern IntPtr GetCurrentProcess();

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetCurrentProcessId();

        [DllImport("kernel32", ExactSpelling = true)]
        public static extern void ExitProcess([NativeTypeName("UINT")] uint uExitCode);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int TerminateProcess([NativeTypeName("HANDLE")] IntPtr hProcess, [NativeTypeName("UINT")] uint uExitCode);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetExitCodeProcess([NativeTypeName("HANDLE")] IntPtr hProcess, [NativeTypeName("LPDWORD")] uint* lpExitCode);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SwitchToThread();

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern IntPtr CreateThread([NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpThreadAttributes, [NativeTypeName("SIZE_T")] nuint dwStackSize, [NativeTypeName("LPTHREAD_START_ROUTINE")] delegate* unmanaged<void*, uint> lpStartAddress, [NativeTypeName("LPVOID")] void* lpParameter, [NativeTypeName("DWORD")] uint dwCreationFlags, [NativeTypeName("LPDWORD")] uint* lpThreadId);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern IntPtr CreateRemoteThread([NativeTypeName("HANDLE")] IntPtr hProcess, [NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpThreadAttributes, [NativeTypeName("SIZE_T")] nuint dwStackSize, [NativeTypeName("LPTHREAD_START_ROUTINE")] delegate* unmanaged<void*, uint> lpStartAddress, [NativeTypeName("LPVOID")] void* lpParameter, [NativeTypeName("DWORD")] uint dwCreationFlags, [NativeTypeName("LPDWORD")] uint* lpThreadId);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern IntPtr GetCurrentThread();

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetCurrentThreadId();

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern IntPtr OpenThread([NativeTypeName("DWORD")] uint dwDesiredAccess, [NativeTypeName("BOOL")] int bInheritHandle, [NativeTypeName("DWORD")] uint dwThreadId);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetThreadPriority([NativeTypeName("HANDLE")] IntPtr hThread, int nPriority);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetThreadPriorityBoost([NativeTypeName("HANDLE")] IntPtr hThread, [NativeTypeName("BOOL")] int bDisablePriorityBoost);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetThreadPriorityBoost([NativeTypeName("HANDLE")] IntPtr hThread, [NativeTypeName("PBOOL")] int* pDisablePriorityBoost);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        public static extern int GetThreadPriority([NativeTypeName("HANDLE")] IntPtr hThread);

        [DllImport("kernel32", ExactSpelling = true)]
        public static extern void ExitThread([NativeTypeName("DWORD")] uint dwExitCode);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int TerminateThread([NativeTypeName("HANDLE")] IntPtr hThread, [NativeTypeName("DWORD")] uint dwExitCode);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetExitCodeThread([NativeTypeName("HANDLE")] IntPtr hThread, [NativeTypeName("LPDWORD")] uint* lpExitCode);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint SuspendThread([NativeTypeName("HANDLE")] IntPtr hThread);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint ResumeThread([NativeTypeName("HANDLE")] IntPtr hThread);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint TlsAlloc();

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("LPVOID")]
        public static extern void* TlsGetValue([NativeTypeName("DWORD")] uint dwTlsIndex);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int TlsSetValue([NativeTypeName("DWORD")] uint dwTlsIndex, [NativeTypeName("LPVOID")] void* lpTlsValue);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int TlsFree([NativeTypeName("DWORD")] uint dwTlsIndex);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CreateProcessA([NativeTypeName("LPCSTR")] sbyte* lpApplicationName, [NativeTypeName("LPSTR")] sbyte* lpCommandLine, [NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpProcessAttributes, [NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpThreadAttributes, [NativeTypeName("BOOL")] int bInheritHandles, [NativeTypeName("DWORD")] uint dwCreationFlags, [NativeTypeName("LPVOID")] void* lpEnvironment, [NativeTypeName("LPCSTR")] sbyte* lpCurrentDirectory, [NativeTypeName("LPSTARTUPINFOA")] STARTUPINFOA* lpStartupInfo, [NativeTypeName("LPPROCESS_INFORMATION")] PROCESS_INFORMATION* lpProcessInformation);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CreateProcessW([NativeTypeName("LPCWSTR")] ushort* lpApplicationName, [NativeTypeName("LPWSTR")] ushort* lpCommandLine, [NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpProcessAttributes, [NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpThreadAttributes, [NativeTypeName("BOOL")] int bInheritHandles, [NativeTypeName("DWORD")] uint dwCreationFlags, [NativeTypeName("LPVOID")] void* lpEnvironment, [NativeTypeName("LPCWSTR")] ushort* lpCurrentDirectory, [NativeTypeName("LPSTARTUPINFOW")] STARTUPINFOW* lpStartupInfo, [NativeTypeName("LPPROCESS_INFORMATION")] PROCESS_INFORMATION* lpProcessInformation);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetProcessShutdownParameters([NativeTypeName("DWORD")] uint dwLevel, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetProcessVersion([NativeTypeName("DWORD")] uint ProcessId);

        [DllImport("kernel32", ExactSpelling = true)]
        public static extern void GetStartupInfoW([NativeTypeName("LPSTARTUPINFOW")] STARTUPINFOW* lpStartupInfo);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CreateProcessAsUserW([NativeTypeName("HANDLE")] IntPtr hToken, [NativeTypeName("LPCWSTR")] ushort* lpApplicationName, [NativeTypeName("LPWSTR")] ushort* lpCommandLine, [NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpProcessAttributes, [NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpThreadAttributes, [NativeTypeName("BOOL")] int bInheritHandles, [NativeTypeName("DWORD")] uint dwCreationFlags, [NativeTypeName("LPVOID")] void* lpEnvironment, [NativeTypeName("LPCWSTR")] ushort* lpCurrentDirectory, [NativeTypeName("LPSTARTUPINFOW")] STARTUPINFOW* lpStartupInfo, [NativeTypeName("LPPROCESS_INFORMATION")] PROCESS_INFORMATION* lpProcessInformation);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetThreadToken([NativeTypeName("PHANDLE")] IntPtr* Thread, [NativeTypeName("HANDLE")] IntPtr Token);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int OpenProcessToken([NativeTypeName("HANDLE")] IntPtr ProcessHandle, [NativeTypeName("DWORD")] uint DesiredAccess, [NativeTypeName("PHANDLE")] IntPtr* TokenHandle);

        [DllImport("advapi32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int OpenThreadToken([NativeTypeName("HANDLE")] IntPtr ThreadHandle, [NativeTypeName("DWORD")] uint DesiredAccess, [NativeTypeName("BOOL")] int OpenAsSelf, [NativeTypeName("PHANDLE")] IntPtr* TokenHandle);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetPriorityClass([NativeTypeName("HANDLE")] IntPtr hProcess, [NativeTypeName("DWORD")] uint dwPriorityClass);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetPriorityClass([NativeTypeName("HANDLE")] IntPtr hProcess);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetThreadStackGuarantee([NativeTypeName("PULONG")] uint* StackSizeInBytes);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ProcessIdToSessionId([NativeTypeName("DWORD")] uint dwProcessId, [NativeTypeName("DWORD *")] uint* pSessionId);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetProcessId([NativeTypeName("HANDLE")] IntPtr Process);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetThreadId([NativeTypeName("HANDLE")] IntPtr Thread);

        [DllImport("kernel32", ExactSpelling = true)]
        public static extern void FlushProcessWriteBuffers();

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetProcessIdOfThread([NativeTypeName("HANDLE")] IntPtr Thread);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int InitializeProcThreadAttributeList([NativeTypeName("LPPROC_THREAD_ATTRIBUTE_LIST")] IntPtr lpAttributeList, [NativeTypeName("DWORD")] uint dwAttributeCount, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("PSIZE_T")] nuint* lpSize);

        [DllImport("kernel32", ExactSpelling = true)]
        public static extern void DeleteProcThreadAttributeList([NativeTypeName("LPPROC_THREAD_ATTRIBUTE_LIST")] IntPtr lpAttributeList);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int UpdateProcThreadAttribute([NativeTypeName("LPPROC_THREAD_ATTRIBUTE_LIST")] IntPtr lpAttributeList, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("DWORD_PTR")] nuint Attribute, [NativeTypeName("PVOID")] void* lpValue, [NativeTypeName("SIZE_T")] nuint cbSize, [NativeTypeName("PVOID")] void* lpPreviousValue, [NativeTypeName("PSIZE_T")] nuint* lpReturnSize);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetProcessDynamicEHContinuationTargets([NativeTypeName("HANDLE")] IntPtr Process, [NativeTypeName("USHORT")] ushort NumberOfTargets, [NativeTypeName("PPROCESS_DYNAMIC_EH_CONTINUATION_TARGET")] PROCESS_DYNAMIC_EH_CONTINUATION_TARGET* Targets);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetProcessDynamicEnforcedCetCompatibleRanges([NativeTypeName("HANDLE")] IntPtr Process, [NativeTypeName("USHORT")] ushort NumberOfRanges, [NativeTypeName("PPROCESS_DYNAMIC_ENFORCED_ADDRESS_RANGE")] PROCESS_DYNAMIC_ENFORCED_ADDRESS_RANGE* Ranges);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetProcessAffinityUpdateMode([NativeTypeName("HANDLE")] IntPtr hProcess, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int QueryProcessAffinityUpdateMode([NativeTypeName("HANDLE")] IntPtr hProcess, [NativeTypeName("LPDWORD")] uint* lpdwFlags);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern IntPtr CreateRemoteThreadEx([NativeTypeName("HANDLE")] IntPtr hProcess, [NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpThreadAttributes, [NativeTypeName("SIZE_T")] nuint dwStackSize, [NativeTypeName("LPTHREAD_START_ROUTINE")] delegate* unmanaged<void*, uint> lpStartAddress, [NativeTypeName("LPVOID")] void* lpParameter, [NativeTypeName("DWORD")] uint dwCreationFlags, [NativeTypeName("LPPROC_THREAD_ATTRIBUTE_LIST")] IntPtr lpAttributeList, [NativeTypeName("LPDWORD")] uint* lpThreadId);

        [DllImport("kernel32", ExactSpelling = true)]
        public static extern void GetCurrentThreadStackLimits([NativeTypeName("PULONG_PTR")] uint* LowLimit, [NativeTypeName("PULONG_PTR")] uint* HighLimit);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetThreadContext([NativeTypeName("HANDLE")] IntPtr hThread, [NativeTypeName("LPCONTEXT")] CONTEXT* lpContext);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetProcessMitigationPolicy([NativeTypeName("HANDLE")] IntPtr hProcess, PROCESS_MITIGATION_POLICY MitigationPolicy, [NativeTypeName("PVOID")] void* lpBuffer, [NativeTypeName("SIZE_T")] nuint dwLength);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetThreadContext([NativeTypeName("HANDLE")] IntPtr hThread, [NativeTypeName("const CONTEXT *")] CONTEXT* lpContext);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetProcessMitigationPolicy(PROCESS_MITIGATION_POLICY MitigationPolicy, [NativeTypeName("PVOID")] void* lpBuffer, [NativeTypeName("SIZE_T")] nuint dwLength);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int FlushInstructionCache([NativeTypeName("HANDLE")] IntPtr hProcess, [NativeTypeName("LPCVOID")] void* lpBaseAddress, [NativeTypeName("SIZE_T")] nuint dwSize);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetThreadTimes([NativeTypeName("HANDLE")] IntPtr hThread, [NativeTypeName("LPFILETIME")] FILETIME* lpCreationTime, [NativeTypeName("LPFILETIME")] FILETIME* lpExitTime, [NativeTypeName("LPFILETIME")] FILETIME* lpKernelTime, [NativeTypeName("LPFILETIME")] FILETIME* lpUserTime);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern IntPtr OpenProcess([NativeTypeName("DWORD")] uint dwDesiredAccess, [NativeTypeName("BOOL")] int bInheritHandle, [NativeTypeName("DWORD")] uint dwProcessId);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int IsProcessorFeaturePresent([NativeTypeName("DWORD")] uint ProcessorFeature);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetProcessHandleCount([NativeTypeName("HANDLE")] IntPtr hProcess, [NativeTypeName("PDWORD")] uint* pdwHandleCount);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetCurrentProcessorNumber();

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetThreadIdealProcessorEx([NativeTypeName("HANDLE")] IntPtr hThread, [NativeTypeName("PPROCESSOR_NUMBER")] PROCESSOR_NUMBER* lpIdealProcessor, [NativeTypeName("PPROCESSOR_NUMBER")] PROCESSOR_NUMBER* lpPreviousIdealProcessor);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetThreadIdealProcessorEx([NativeTypeName("HANDLE")] IntPtr hThread, [NativeTypeName("PPROCESSOR_NUMBER")] PROCESSOR_NUMBER* lpIdealProcessor);

        [DllImport("kernel32", ExactSpelling = true)]
        public static extern void GetCurrentProcessorNumberEx([NativeTypeName("PPROCESSOR_NUMBER")] PROCESSOR_NUMBER* ProcNumber);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetProcessPriorityBoost([NativeTypeName("HANDLE")] IntPtr hProcess, [NativeTypeName("PBOOL")] int* pDisablePriorityBoost);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetProcessPriorityBoost([NativeTypeName("HANDLE")] IntPtr hProcess, [NativeTypeName("BOOL")] int bDisablePriorityBoost);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetThreadIOPendingFlag([NativeTypeName("HANDLE")] IntPtr hThread, [NativeTypeName("PBOOL")] int* lpIOIsPending);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetSystemTimes([NativeTypeName("PFILETIME")] FILETIME* lpIdleTime, [NativeTypeName("PFILETIME")] FILETIME* lpKernelTime, [NativeTypeName("PFILETIME")] FILETIME* lpUserTime);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetThreadInformation([NativeTypeName("HANDLE")] IntPtr hThread, THREAD_INFORMATION_CLASS ThreadInformationClass, [NativeTypeName("LPVOID")] void* ThreadInformation, [NativeTypeName("DWORD")] uint ThreadInformationSize);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetThreadInformation([NativeTypeName("HANDLE")] IntPtr hThread, THREAD_INFORMATION_CLASS ThreadInformationClass, [NativeTypeName("LPVOID")] void* ThreadInformation, [NativeTypeName("DWORD")] uint ThreadInformationSize);

        [DllImport("ntdll", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int IsProcessCritical([NativeTypeName("HANDLE")] IntPtr hProcess, [NativeTypeName("PBOOL")] int* Critical);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetProtectedPolicy([NativeTypeName("LPCGUID")] Guid* PolicyGuid, [NativeTypeName("ULONG_PTR")] nuint PolicyValue, [NativeTypeName("PULONG_PTR")] uint* OldPolicyValue);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int QueryProtectedPolicy([NativeTypeName("LPCGUID")] Guid* PolicyGuid, [NativeTypeName("PULONG_PTR")] uint* PolicyValue);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint SetThreadIdealProcessor([NativeTypeName("HANDLE")] IntPtr hThread, [NativeTypeName("DWORD")] uint dwIdealProcessor);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetProcessInformation([NativeTypeName("HANDLE")] IntPtr hProcess, PROCESS_INFORMATION_CLASS ProcessInformationClass, [NativeTypeName("LPVOID")] void* ProcessInformation, [NativeTypeName("DWORD")] uint ProcessInformationSize);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetProcessInformation([NativeTypeName("HANDLE")] IntPtr hProcess, PROCESS_INFORMATION_CLASS ProcessInformationClass, [NativeTypeName("LPVOID")] void* ProcessInformation, [NativeTypeName("DWORD")] uint ProcessInformationSize);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetSystemCpuSetInformation([NativeTypeName("PSYSTEM_CPU_SET_INFORMATION")] SYSTEM_CPU_SET_INFORMATION* Information, [NativeTypeName("ULONG")] uint BufferLength, [NativeTypeName("PULONG")] uint* ReturnedLength, [NativeTypeName("HANDLE")] IntPtr Process, [NativeTypeName("ULONG")] uint Flags);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetProcessDefaultCpuSets([NativeTypeName("HANDLE")] IntPtr Process, [NativeTypeName("PULONG")] uint* CpuSetIds, [NativeTypeName("ULONG")] uint CpuSetIdCount, [NativeTypeName("PULONG")] uint* RequiredIdCount);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetProcessDefaultCpuSets([NativeTypeName("HANDLE")] IntPtr Process, [NativeTypeName("const ULONG *")] uint* CpuSetIds, [NativeTypeName("ULONG")] uint CpuSetIdCount);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetThreadSelectedCpuSets([NativeTypeName("HANDLE")] IntPtr Thread, [NativeTypeName("PULONG")] uint* CpuSetIds, [NativeTypeName("ULONG")] uint CpuSetIdCount, [NativeTypeName("PULONG")] uint* RequiredIdCount);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetThreadSelectedCpuSets([NativeTypeName("HANDLE")] IntPtr Thread, [NativeTypeName("const ULONG *")] uint* CpuSetIds, [NativeTypeName("ULONG")] uint CpuSetIdCount);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CreateProcessAsUserA([NativeTypeName("HANDLE")] IntPtr hToken, [NativeTypeName("LPCSTR")] sbyte* lpApplicationName, [NativeTypeName("LPSTR")] sbyte* lpCommandLine, [NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpProcessAttributes, [NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpThreadAttributes, [NativeTypeName("BOOL")] int bInheritHandles, [NativeTypeName("DWORD")] uint dwCreationFlags, [NativeTypeName("LPVOID")] void* lpEnvironment, [NativeTypeName("LPCSTR")] sbyte* lpCurrentDirectory, [NativeTypeName("LPSTARTUPINFOA")] STARTUPINFOA* lpStartupInfo, [NativeTypeName("LPPROCESS_INFORMATION")] PROCESS_INFORMATION* lpProcessInformation);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetProcessShutdownParameters([NativeTypeName("LPDWORD")] uint* lpdwLevel, [NativeTypeName("LPDWORD")] uint* lpdwFlags);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int SetThreadDescription([NativeTypeName("HANDLE")] IntPtr hThread, [NativeTypeName("PCWSTR")] ushort* lpThreadDescription);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int GetThreadDescription([NativeTypeName("HANDLE")] IntPtr hThread, [NativeTypeName("PWSTR *")] ushort** ppszThreadDescription);

        [NativeTypeName("#define TLS_OUT_OF_INDEXES ((DWORD)0xFFFFFFFF)")]
        public const uint TLS_OUT_OF_INDEXES = ((uint)(0xFFFFFFFF));

        [NativeTypeName("#define CreateProcess CreateProcessW")]
        public static readonly delegate*<ushort*, ushort*, SECURITY_ATTRIBUTES*, SECURITY_ATTRIBUTES*, int, uint, void*, ushort*, STARTUPINFOW*, PROCESS_INFORMATION*, int> CreateProcess = &CreateProcessW;

        [NativeTypeName("#define GetStartupInfo GetStartupInfoW")]
        public static readonly delegate*<STARTUPINFOW*, void> GetStartupInfo = &GetStartupInfoW;

        [NativeTypeName("#define CreateProcessAsUser CreateProcessAsUserW")]
        public static readonly delegate*<IntPtr, ushort*, ushort*, SECURITY_ATTRIBUTES*, SECURITY_ATTRIBUTES*, int, uint, void*, ushort*, STARTUPINFOW*, PROCESS_INFORMATION*, int> CreateProcessAsUser = &CreateProcessAsUserW;

        [NativeTypeName("#define PROC_THREAD_ATTRIBUTE_REPLACE_VALUE 0x00000001")]
        public const int PROC_THREAD_ATTRIBUTE_REPLACE_VALUE = 0x00000001;

        [NativeTypeName("#define PROCESS_AFFINITY_ENABLE_AUTO_UPDATE 0x00000001UL")]
        public const uint PROCESS_AFFINITY_ENABLE_AUTO_UPDATE = 0x00000001U;

        [NativeTypeName("#define THREAD_POWER_THROTTLING_CURRENT_VERSION 1")]
        public const int THREAD_POWER_THROTTLING_CURRENT_VERSION = 1;

        [NativeTypeName("#define THREAD_POWER_THROTTLING_EXECUTION_SPEED 0x1")]
        public const int THREAD_POWER_THROTTLING_EXECUTION_SPEED = 0x1;

        [NativeTypeName("#define THREAD_POWER_THROTTLING_VALID_FLAGS (THREAD_POWER_THROTTLING_EXECUTION_SPEED)")]
        public const int THREAD_POWER_THROTTLING_VALID_FLAGS = (0x1);

        [NativeTypeName("#define PME_CURRENT_VERSION 1")]
        public const int PME_CURRENT_VERSION = 1;

        [NativeTypeName("#define PME_FAILFAST_ON_COMMIT_FAIL_DISABLE 0x0")]
        public const int PME_FAILFAST_ON_COMMIT_FAIL_DISABLE = 0x0;

        [NativeTypeName("#define PME_FAILFAST_ON_COMMIT_FAIL_ENABLE 0x1")]
        public const int PME_FAILFAST_ON_COMMIT_FAIL_ENABLE = 0x1;

        [NativeTypeName("#define PROCESS_POWER_THROTTLING_CURRENT_VERSION 1")]
        public const int PROCESS_POWER_THROTTLING_CURRENT_VERSION = 1;

        [NativeTypeName("#define PROCESS_POWER_THROTTLING_EXECUTION_SPEED 0x1")]
        public const int PROCESS_POWER_THROTTLING_EXECUTION_SPEED = 0x1;

        [NativeTypeName("#define PROCESS_POWER_THROTTLING_VALID_FLAGS (PROCESS_POWER_THROTTLING_EXECUTION_SPEED)")]
        public const int PROCESS_POWER_THROTTLING_VALID_FLAGS = (0x1);

        [NativeTypeName("#define PROCESS_LEAP_SECOND_INFO_FLAG_ENABLE_SIXTY_SECOND 0x1")]
        public const int PROCESS_LEAP_SECOND_INFO_FLAG_ENABLE_SIXTY_SECOND = 0x1;

        [NativeTypeName("#define PROCESS_LEAP_SECOND_INFO_VALID_FLAGS (PROCESS_LEAP_SECOND_INFO_FLAG_ENABLE_SIXTY_SECOND)")]
        public const int PROCESS_LEAP_SECOND_INFO_VALID_FLAGS = (0x1);
    }
}
