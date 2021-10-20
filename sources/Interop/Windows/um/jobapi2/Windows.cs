// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/namespaceapi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern IntPtr CreateJobObjectW([NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpJobAttributes, [NativeTypeName("LPCWSTR")] ushort* lpName);

        [DllImport("kernel32", ExactSpelling = true)]
        public static extern void FreeMemoryJobObject(void* Buffer);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern IntPtr OpenJobObjectW([NativeTypeName("DWORD")] uint dwDesiredAccess, [NativeTypeName("BOOL")] int bInheritHandle, [NativeTypeName("LPCWSTR")] ushort* lpName);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int AssignProcessToJobObject([NativeTypeName("HANDLE")] IntPtr hJob, [NativeTypeName("HANDLE")] IntPtr hProcess);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int TerminateJobObject([NativeTypeName("HANDLE")] IntPtr hJob, [NativeTypeName("UINT")] uint uExitCode);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetInformationJobObject([NativeTypeName("HANDLE")] IntPtr hJob, JOBOBJECTINFOCLASS JobObjectInformationClass, [NativeTypeName("LPVOID")] void* lpJobObjectInformation, [NativeTypeName("DWORD")] uint cbJobObjectInformationLength);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint SetIoRateControlInformationJobObject([NativeTypeName("HANDLE")] IntPtr hJob, JOBOBJECT_IO_RATE_CONTROL_INFORMATION* IoRateControlInfo);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int QueryInformationJobObject([NativeTypeName("HANDLE")] IntPtr hJob, JOBOBJECTINFOCLASS JobObjectInformationClass, [NativeTypeName("LPVOID")] void* lpJobObjectInformation, [NativeTypeName("DWORD")] uint cbJobObjectInformationLength, [NativeTypeName("LPDWORD")] uint* lpReturnLength);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint QueryIoRateControlInformationJobObject([NativeTypeName("HANDLE")] IntPtr hJob, [NativeTypeName("PCWSTR")] ushort* VolumeName, JOBOBJECT_IO_RATE_CONTROL_INFORMATION** InfoBlocks, [NativeTypeName("ULONG *")] uint* InfoBlockCount);
    }
}
