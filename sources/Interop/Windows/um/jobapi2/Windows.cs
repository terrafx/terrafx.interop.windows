// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/namespaceapi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        [DllImport("Kernel32", EntryPoint = "CreateJobObjectW", ExactSpelling = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern IntPtr CreateJobObjectW([NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpJobAttributes, [NativeTypeName("LPCWSTR")] ushort* lpName);

        [DllImport("Kernel32", EntryPoint = "FreeMemoryJobObject", ExactSpelling = true)]
        public static extern void FreeMemoryJobObject([NativeTypeName("void *")] void* Buffer);

        [DllImport("Kernel32", EntryPoint = "OpenJobObjectW", ExactSpelling = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern IntPtr OpenJobObjectW([NativeTypeName("DWORD")] uint dwDesiredAccess, [NativeTypeName("BOOL")] int bInheritHandle, [NativeTypeName("LPCWSTR")] ushort* lpName);

        [DllImport("Kernel32", EntryPoint = "AssignProcessToJobObject", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int AssignProcessToJobObject([NativeTypeName("HANDLE")] IntPtr hJob, [NativeTypeName("HANDLE")] IntPtr hProcess);

        [DllImport("Kernel32", EntryPoint = "TerminateJobObject", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int TerminateJobObject([NativeTypeName("HANDLE")] IntPtr hJob, [NativeTypeName("UINT")] uint uExitCode);

        [DllImport("Kernel32", EntryPoint = "SetInformationJobObject", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetInformationJobObject([NativeTypeName("HANDLE")] IntPtr hJob, JOBOBJECTINFOCLASS JobObjectInformationClass, [NativeTypeName("LPVOID")] void* lpJobObjectInformation, [NativeTypeName("DWORD")] uint cbJobObjectInformationLength);

        [DllImport("Kernel32", EntryPoint = "SetIoRateControlInformationJobObject", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint SetIoRateControlInformationJobObject([NativeTypeName("HANDLE")] IntPtr hJob, [NativeTypeName("JOBOBJECT_IO_RATE_CONTROL_INFORMATION *")] JOBOBJECT_IO_RATE_CONTROL_INFORMATION* IoRateControlInfo);

        [DllImport("Kernel32", EntryPoint = "QueryInformationJobObject", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int QueryInformationJobObject([NativeTypeName("HANDLE")] IntPtr hJob, JOBOBJECTINFOCLASS JobObjectInformationClass, [NativeTypeName("LPVOID")] void* lpJobObjectInformation, [NativeTypeName("DWORD")] uint cbJobObjectInformationLength, [NativeTypeName("LPDWORD")] uint* lpReturnLength);

        [DllImport("Kernel32", EntryPoint = "QueryIoRateControlInformationJobObject", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint QueryIoRateControlInformationJobObject([NativeTypeName("HANDLE")] IntPtr hJob, [NativeTypeName("PCWSTR")] ushort* VolumeName, [NativeTypeName("JOBOBJECT_IO_RATE_CONTROL_INFORMATION **")] JOBOBJECT_IO_RATE_CONTROL_INFORMATION** InfoBlocks, [NativeTypeName("ULONG *")] uint* InfoBlockCount);
    }
}
