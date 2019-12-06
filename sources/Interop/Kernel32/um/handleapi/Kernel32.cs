// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/handleapi.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Kernel32
    {
        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CloseHandle", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CloseHandle([NativeTypeName("HANDLE")] IntPtr hObject);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "DuplicateHandle", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int DuplicateHandle([NativeTypeName("HANDLE")] IntPtr hSourceProcessHandle, [NativeTypeName("HANDLE")] IntPtr hSourceHandle, [NativeTypeName("HANDLE")] IntPtr hTargetProcessHandle, [NativeTypeName("LPHANDLE")] IntPtr* lpTargetHandle, [NativeTypeName("DWORD")] uint dwDesiredAccess, [NativeTypeName("BOOL")] int bInheritHandle, [NativeTypeName("DWORD")] uint dwOptions);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CompareObjectHandles", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CompareObjectHandles([NativeTypeName("HANDLE")] IntPtr hFirstObjectHandle, [NativeTypeName("HANDLE")] IntPtr hSecondObjectHandle);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetHandleInformation", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetHandleInformation([NativeTypeName("HANDLE")] IntPtr hObject, [NativeTypeName("LPDWORD")] uint* lpdwFlags);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetHandleInformation", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetHandleInformation([NativeTypeName("HANDLE")] IntPtr hObject, [NativeTypeName("DWORD")] uint dwMask, [NativeTypeName("DWORD")] uint dwFlags);
    }
}
