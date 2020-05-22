// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/processthreadsapi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Advapi32
    {
        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "QueueUserAPC", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint QueueUserAPC([NativeTypeName("PAPCFUNC")] IntPtr pfnAPC, [NativeTypeName("HANDLE")] IntPtr hThread, [NativeTypeName("ULONG_PTR")] nuint dwData);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetProcessTimes", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetProcessTimes([NativeTypeName("HANDLE")] IntPtr hProcess, [NativeTypeName("LPFILETIME")] FILETIME* lpCreationTime, [NativeTypeName("LPFILETIME")] FILETIME* lpExitTime, [NativeTypeName("LPFILETIME")] FILETIME* lpKernelTime, [NativeTypeName("LPFILETIME")] FILETIME* lpUserTime);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetCurrentProcess", ExactSpelling = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern IntPtr GetCurrentProcess();

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetCurrentProcessId", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetCurrentProcessId();

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "ExitProcess", ExactSpelling = true)]
        public static extern void ExitProcess([NativeTypeName("UINT")] uint uExitCode);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "TerminateProcess", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int TerminateProcess([NativeTypeName("HANDLE")] IntPtr hProcess, [NativeTypeName("UINT")] uint uExitCode);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetExitCodeProcess", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetExitCodeProcess([NativeTypeName("HANDLE")] IntPtr hProcess, [NativeTypeName("LPDWORD")] uint* lpExitCode);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SwitchToThread", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SwitchToThread();

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CreateThread", ExactSpelling = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern IntPtr CreateThread([NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpThreadAttributes, [NativeTypeName("SIZE_T")] nuint dwStackSize, [NativeTypeName("LPTHREAD_START_ROUTINE")] IntPtr lpStartAddress, [NativeTypeName("LPVOID")] void* lpParameter, [NativeTypeName("DWORD")] uint dwCreationFlags, [NativeTypeName("LPDWORD")] uint* lpThreadId);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CreateRemoteThread", ExactSpelling = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern IntPtr CreateRemoteThread([NativeTypeName("HANDLE")] IntPtr hProcess, [NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpThreadAttributes, [NativeTypeName("SIZE_T")] nuint dwStackSize, [NativeTypeName("LPTHREAD_START_ROUTINE")] IntPtr lpStartAddress, [NativeTypeName("LPVOID")] void* lpParameter, [NativeTypeName("DWORD")] uint dwCreationFlags, [NativeTypeName("LPDWORD")] uint* lpThreadId);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetCurrentThread", ExactSpelling = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern IntPtr GetCurrentThread();

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetCurrentThreadId", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetCurrentThreadId();

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "OpenThread", ExactSpelling = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern IntPtr OpenThread([NativeTypeName("DWORD")] uint dwDesiredAccess, [NativeTypeName("BOOL")] int bInheritHandle, [NativeTypeName("DWORD")] uint dwThreadId);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetThreadPriority", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetThreadPriority([NativeTypeName("HANDLE")] IntPtr hThread, int nPriority);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetThreadPriorityBoost", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetThreadPriorityBoost([NativeTypeName("HANDLE")] IntPtr hThread, [NativeTypeName("BOOL")] int bDisablePriorityBoost);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetThreadPriorityBoost", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetThreadPriorityBoost([NativeTypeName("HANDLE")] IntPtr hThread, [NativeTypeName("PBOOL")] int* pDisablePriorityBoost);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetThreadPriority", ExactSpelling = true)]
        public static extern int GetThreadPriority([NativeTypeName("HANDLE")] IntPtr hThread);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "ExitThread", ExactSpelling = true)]
        public static extern void ExitThread([NativeTypeName("DWORD")] uint dwExitCode);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "TerminateThread", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int TerminateThread([NativeTypeName("HANDLE")] IntPtr hThread, [NativeTypeName("DWORD")] uint dwExitCode);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetExitCodeThread", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetExitCodeThread([NativeTypeName("HANDLE")] IntPtr hThread, [NativeTypeName("LPDWORD")] uint* lpExitCode);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SuspendThread", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint SuspendThread([NativeTypeName("HANDLE")] IntPtr hThread);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "ResumeThread", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint ResumeThread([NativeTypeName("HANDLE")] IntPtr hThread);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "TlsAlloc", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint TlsAlloc();

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "TlsGetValue", ExactSpelling = true)]
        [return: NativeTypeName("LPVOID")]
        public static extern void* TlsGetValue([NativeTypeName("DWORD")] uint dwTlsIndex);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "TlsSetValue", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int TlsSetValue([NativeTypeName("DWORD")] uint dwTlsIndex, [NativeTypeName("LPVOID")] void* lpTlsValue);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "TlsFree", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int TlsFree([NativeTypeName("DWORD")] uint dwTlsIndex);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CreateProcessA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CreateProcessA([NativeTypeName("LPCSTR")] sbyte* lpApplicationName, [NativeTypeName("LPSTR")] sbyte* lpCommandLine, [NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpProcessAttributes, [NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpThreadAttributes, [NativeTypeName("BOOL")] int bInheritHandles, [NativeTypeName("DWORD")] uint dwCreationFlags, [NativeTypeName("LPVOID")] void* lpEnvironment, [NativeTypeName("LPCSTR")] sbyte* lpCurrentDirectory, [NativeTypeName("LPSTARTUPINFOA")] STARTUPINFOA* lpStartupInfo, [NativeTypeName("LPPROCESS_INFORMATION")] PROCESS_INFORMATION* lpProcessInformation);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CreateProcessW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CreateProcessW([NativeTypeName("LPCWSTR")] ushort* lpApplicationName, [NativeTypeName("LPWSTR")] ushort* lpCommandLine, [NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpProcessAttributes, [NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpThreadAttributes, [NativeTypeName("BOOL")] int bInheritHandles, [NativeTypeName("DWORD")] uint dwCreationFlags, [NativeTypeName("LPVOID")] void* lpEnvironment, [NativeTypeName("LPCWSTR")] ushort* lpCurrentDirectory, [NativeTypeName("LPSTARTUPINFOW")] STARTUPINFOW* lpStartupInfo, [NativeTypeName("LPPROCESS_INFORMATION")] PROCESS_INFORMATION* lpProcessInformation);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetProcessShutdownParameters", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetProcessShutdownParameters([NativeTypeName("DWORD")] uint dwLevel, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetProcessVersion", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetProcessVersion([NativeTypeName("DWORD")] uint ProcessId);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetStartupInfoW", ExactSpelling = true)]
        public static extern void GetStartupInfoW([NativeTypeName("LPSTARTUPINFOW")] STARTUPINFOW* lpStartupInfo);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CreateProcessAsUserW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CreateProcessAsUserW([NativeTypeName("HANDLE")] IntPtr hToken, [NativeTypeName("LPCWSTR")] ushort* lpApplicationName, [NativeTypeName("LPWSTR")] ushort* lpCommandLine, [NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpProcessAttributes, [NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpThreadAttributes, [NativeTypeName("BOOL")] int bInheritHandles, [NativeTypeName("DWORD")] uint dwCreationFlags, [NativeTypeName("LPVOID")] void* lpEnvironment, [NativeTypeName("LPCWSTR")] ushort* lpCurrentDirectory, [NativeTypeName("LPSTARTUPINFOW")] STARTUPINFOW* lpStartupInfo, [NativeTypeName("LPPROCESS_INFORMATION")] PROCESS_INFORMATION* lpProcessInformation);

        [return: NativeTypeName("HANDLE")]
        public static IntPtr GetCurrentProcessToken()
        {
            return (IntPtr)(int)-4;
        }

        [return: NativeTypeName("HANDLE")]
        public static IntPtr GetCurrentThreadToken()
        {
            return (IntPtr)(int)-5;
        }

        [return: NativeTypeName("HANDLE")]
        public static IntPtr GetCurrentThreadEffectiveToken()
        {
            return (IntPtr)(int)-6;
        }

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetThreadToken", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetThreadToken([NativeTypeName("PHANDLE")] IntPtr* Thread, [NativeTypeName("HANDLE")] IntPtr Token);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "OpenProcessToken", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int OpenProcessToken([NativeTypeName("HANDLE")] IntPtr ProcessHandle, [NativeTypeName("DWORD")] uint DesiredAccess, [NativeTypeName("PHANDLE")] IntPtr* TokenHandle);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "OpenThreadToken", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int OpenThreadToken([NativeTypeName("HANDLE")] IntPtr ThreadHandle, [NativeTypeName("DWORD")] uint DesiredAccess, [NativeTypeName("BOOL")] int OpenAsSelf, [NativeTypeName("PHANDLE")] IntPtr* TokenHandle);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetPriorityClass", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetPriorityClass([NativeTypeName("HANDLE")] IntPtr hProcess, [NativeTypeName("DWORD")] uint dwPriorityClass);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetPriorityClass", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetPriorityClass([NativeTypeName("HANDLE")] IntPtr hProcess);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetThreadStackGuarantee", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetThreadStackGuarantee([NativeTypeName("PULONG")] uint* StackSizeInBytes);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "ProcessIdToSessionId", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ProcessIdToSessionId([NativeTypeName("DWORD")] uint dwProcessId, [NativeTypeName("DWORD *")] uint* pSessionId);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetProcessId", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetProcessId([NativeTypeName("HANDLE")] IntPtr Process);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetThreadId", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetThreadId([NativeTypeName("HANDLE")] IntPtr Thread);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "FlushProcessWriteBuffers", ExactSpelling = true)]
        public static extern void FlushProcessWriteBuffers();

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetProcessIdOfThread", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetProcessIdOfThread([NativeTypeName("HANDLE")] IntPtr Thread);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "InitializeProcThreadAttributeList", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int InitializeProcThreadAttributeList([NativeTypeName("LPPROC_THREAD_ATTRIBUTE_LIST")] PROC_THREAD_ATTRIBUTE_LIST* lpAttributeList, [NativeTypeName("DWORD")] uint dwAttributeCount, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("PSIZE_T")] nuint* lpSize);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "DeleteProcThreadAttributeList", ExactSpelling = true)]
        public static extern void DeleteProcThreadAttributeList([NativeTypeName("LPPROC_THREAD_ATTRIBUTE_LIST")] PROC_THREAD_ATTRIBUTE_LIST* lpAttributeList);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetProcessAffinityUpdateMode", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetProcessAffinityUpdateMode([NativeTypeName("HANDLE")] IntPtr hProcess, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "QueryProcessAffinityUpdateMode", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int QueryProcessAffinityUpdateMode([NativeTypeName("HANDLE")] IntPtr hProcess, [NativeTypeName("LPDWORD")] uint* lpdwFlags);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "UpdateProcThreadAttribute", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int UpdateProcThreadAttribute([NativeTypeName("LPPROC_THREAD_ATTRIBUTE_LIST")] PROC_THREAD_ATTRIBUTE_LIST* lpAttributeList, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("DWORD_PTR")] nuint Attribute, [NativeTypeName("PVOID")] void* lpValue, [NativeTypeName("SIZE_T")] nuint cbSize, [NativeTypeName("PVOID")] void* lpPreviousValue, [NativeTypeName("PSIZE_T")] nuint* lpReturnSize);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CreateRemoteThreadEx", ExactSpelling = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern IntPtr CreateRemoteThreadEx([NativeTypeName("HANDLE")] IntPtr hProcess, [NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpThreadAttributes, [NativeTypeName("SIZE_T")] nuint dwStackSize, [NativeTypeName("LPTHREAD_START_ROUTINE")] IntPtr lpStartAddress, [NativeTypeName("LPVOID")] void* lpParameter, [NativeTypeName("DWORD")] uint dwCreationFlags, [NativeTypeName("LPPROC_THREAD_ATTRIBUTE_LIST")] PROC_THREAD_ATTRIBUTE_LIST* lpAttributeList, [NativeTypeName("LPDWORD")] uint* lpThreadId);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetCurrentThreadStackLimits", ExactSpelling = true)]
        public static extern void GetCurrentThreadStackLimits([NativeTypeName("PULONG_PTR")] uint* LowLimit, [NativeTypeName("PULONG_PTR")] uint* HighLimit);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetThreadContext", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetThreadContext([NativeTypeName("HANDLE")] IntPtr hThread, [NativeTypeName("LPCONTEXT")] CONTEXT* lpContext);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetProcessMitigationPolicy", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetProcessMitigationPolicy([NativeTypeName("HANDLE")] IntPtr hProcess, PROCESS_MITIGATION_POLICY MitigationPolicy, [NativeTypeName("PVOID")] void* lpBuffer, [NativeTypeName("SIZE_T")] nuint dwLength);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetThreadContext", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetThreadContext([NativeTypeName("HANDLE")] IntPtr hThread, [NativeTypeName("const CONTEXT *")] CONTEXT* lpContext);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetProcessMitigationPolicy", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetProcessMitigationPolicy(PROCESS_MITIGATION_POLICY MitigationPolicy, [NativeTypeName("PVOID")] void* lpBuffer, [NativeTypeName("SIZE_T")] nuint dwLength);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "FlushInstructionCache", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int FlushInstructionCache([NativeTypeName("HANDLE")] IntPtr hProcess, [NativeTypeName("LPCVOID")] void* lpBaseAddress, [NativeTypeName("SIZE_T")] nuint dwSize);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetThreadTimes", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetThreadTimes([NativeTypeName("HANDLE")] IntPtr hThread, [NativeTypeName("LPFILETIME")] FILETIME* lpCreationTime, [NativeTypeName("LPFILETIME")] FILETIME* lpExitTime, [NativeTypeName("LPFILETIME")] FILETIME* lpKernelTime, [NativeTypeName("LPFILETIME")] FILETIME* lpUserTime);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "OpenProcess", ExactSpelling = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern IntPtr OpenProcess([NativeTypeName("DWORD")] uint dwDesiredAccess, [NativeTypeName("BOOL")] int bInheritHandle, [NativeTypeName("DWORD")] uint dwProcessId);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "IsProcessorFeaturePresent", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int IsProcessorFeaturePresent([NativeTypeName("DWORD")] uint ProcessorFeature);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetProcessHandleCount", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetProcessHandleCount([NativeTypeName("HANDLE")] IntPtr hProcess, [NativeTypeName("PDWORD")] uint* pdwHandleCount);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetCurrentProcessorNumber", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetCurrentProcessorNumber();

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetThreadIdealProcessorEx", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetThreadIdealProcessorEx([NativeTypeName("HANDLE")] IntPtr hThread, [NativeTypeName("PPROCESSOR_NUMBER")] PROCESSOR_NUMBER* lpIdealProcessor, [NativeTypeName("PPROCESSOR_NUMBER")] PROCESSOR_NUMBER* lpPreviousIdealProcessor);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetThreadIdealProcessorEx", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetThreadIdealProcessorEx([NativeTypeName("HANDLE")] IntPtr hThread, [NativeTypeName("PPROCESSOR_NUMBER")] PROCESSOR_NUMBER* lpIdealProcessor);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetCurrentProcessorNumberEx", ExactSpelling = true)]
        public static extern void GetCurrentProcessorNumberEx([NativeTypeName("PPROCESSOR_NUMBER")] PROCESSOR_NUMBER* ProcNumber);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetProcessPriorityBoost", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetProcessPriorityBoost([NativeTypeName("HANDLE")] IntPtr hProcess, [NativeTypeName("PBOOL")] int* pDisablePriorityBoost);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetProcessPriorityBoost", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetProcessPriorityBoost([NativeTypeName("HANDLE")] IntPtr hProcess, [NativeTypeName("BOOL")] int bDisablePriorityBoost);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetThreadIOPendingFlag", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetThreadIOPendingFlag([NativeTypeName("HANDLE")] IntPtr hThread, [NativeTypeName("PBOOL")] int* lpIOIsPending);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetSystemTimes", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetSystemTimes([NativeTypeName("PFILETIME")] FILETIME* lpIdleTime, [NativeTypeName("PFILETIME")] FILETIME* lpKernelTime, [NativeTypeName("PFILETIME")] FILETIME* lpUserTime);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetThreadInformation", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetThreadInformation([NativeTypeName("HANDLE")] IntPtr hThread, THREAD_INFORMATION_CLASS ThreadInformationClass, [NativeTypeName("LPVOID")] void* ThreadInformation, [NativeTypeName("DWORD")] uint ThreadInformationSize);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetThreadInformation", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetThreadInformation([NativeTypeName("HANDLE")] IntPtr hThread, THREAD_INFORMATION_CLASS ThreadInformationClass, [NativeTypeName("LPVOID")] void* ThreadInformation, [NativeTypeName("DWORD")] uint ThreadInformationSize);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "IsProcessCritical", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int IsProcessCritical([NativeTypeName("HANDLE")] IntPtr hProcess, [NativeTypeName("PBOOL")] int* Critical);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetProtectedPolicy", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetProtectedPolicy([NativeTypeName("LPCGUID")] Guid* PolicyGuid, [NativeTypeName("ULONG_PTR")] nuint PolicyValue, [NativeTypeName("PULONG_PTR")] uint* OldPolicyValue);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "QueryProtectedPolicy", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int QueryProtectedPolicy([NativeTypeName("LPCGUID")] Guid* PolicyGuid, [NativeTypeName("PULONG_PTR")] uint* PolicyValue);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetThreadIdealProcessor", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint SetThreadIdealProcessor([NativeTypeName("HANDLE")] IntPtr hThread, [NativeTypeName("DWORD")] uint dwIdealProcessor);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetProcessInformation", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetProcessInformation([NativeTypeName("HANDLE")] IntPtr hProcess, PROCESS_INFORMATION_CLASS ProcessInformationClass, [NativeTypeName("LPVOID")] void* ProcessInformation, [NativeTypeName("DWORD")] uint ProcessInformationSize);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetProcessInformation", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetProcessInformation([NativeTypeName("HANDLE")] IntPtr hProcess, PROCESS_INFORMATION_CLASS ProcessInformationClass, [NativeTypeName("LPVOID")] void* ProcessInformation, [NativeTypeName("DWORD")] uint ProcessInformationSize);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetSystemCpuSetInformation", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetSystemCpuSetInformation([NativeTypeName("PSYSTEM_CPU_SET_INFORMATION")] SYSTEM_CPU_SET_INFORMATION* Information, [NativeTypeName("ULONG")] uint BufferLength, [NativeTypeName("PULONG")] uint* ReturnedLength, [NativeTypeName("HANDLE")] IntPtr Process, [NativeTypeName("ULONG")] uint Flags);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetProcessDefaultCpuSets", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetProcessDefaultCpuSets([NativeTypeName("HANDLE")] IntPtr Process, [NativeTypeName("PULONG")] uint* CpuSetIds, [NativeTypeName("ULONG")] uint CpuSetIdCount, [NativeTypeName("PULONG")] uint* RequiredIdCount);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetProcessDefaultCpuSets", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetProcessDefaultCpuSets([NativeTypeName("HANDLE")] IntPtr Process, [NativeTypeName("const ULONG *")] uint* CpuSetIds, [NativeTypeName("ULONG")] uint CpuSetIdCount);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetThreadSelectedCpuSets", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetThreadSelectedCpuSets([NativeTypeName("HANDLE")] IntPtr Thread, [NativeTypeName("PULONG")] uint* CpuSetIds, [NativeTypeName("ULONG")] uint CpuSetIdCount, [NativeTypeName("PULONG")] uint* RequiredIdCount);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetThreadSelectedCpuSets", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetThreadSelectedCpuSets([NativeTypeName("HANDLE")] IntPtr Thread, [NativeTypeName("const ULONG *")] uint* CpuSetIds, [NativeTypeName("ULONG")] uint CpuSetIdCount);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CreateProcessAsUserA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CreateProcessAsUserA([NativeTypeName("HANDLE")] IntPtr hToken, [NativeTypeName("LPCSTR")] sbyte* lpApplicationName, [NativeTypeName("LPSTR")] sbyte* lpCommandLine, [NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpProcessAttributes, [NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpThreadAttributes, [NativeTypeName("BOOL")] int bInheritHandles, [NativeTypeName("DWORD")] uint dwCreationFlags, [NativeTypeName("LPVOID")] void* lpEnvironment, [NativeTypeName("LPCSTR")] sbyte* lpCurrentDirectory, [NativeTypeName("LPSTARTUPINFOA")] STARTUPINFOA* lpStartupInfo, [NativeTypeName("LPPROCESS_INFORMATION")] PROCESS_INFORMATION* lpProcessInformation);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetProcessShutdownParameters", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetProcessShutdownParameters([NativeTypeName("LPDWORD")] uint* lpdwLevel, [NativeTypeName("LPDWORD")] uint* lpdwFlags);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetThreadDescription", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int SetThreadDescription([NativeTypeName("HANDLE")] IntPtr hThread, [NativeTypeName("PCWSTR")] ushort* lpThreadDescription);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetThreadDescription", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int GetThreadDescription([NativeTypeName("HANDLE")] IntPtr hThread, [NativeTypeName("PWSTR *")] ushort** ppszThreadDescription);
    }
}
