// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/handleapi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL CloseHandle([NativeTypeName("HANDLE")] IntPtr hObject);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL DuplicateHandle([NativeTypeName("HANDLE")] IntPtr hSourceProcessHandle, [NativeTypeName("HANDLE")] IntPtr hSourceHandle, [NativeTypeName("HANDLE")] IntPtr hTargetProcessHandle, [NativeTypeName("LPHANDLE")] IntPtr* lpTargetHandle, [NativeTypeName("DWORD")] uint dwDesiredAccess, BOOL bInheritHandle, [NativeTypeName("DWORD")] uint dwOptions);

        [DllImport("kernelbase", ExactSpelling = true)]
        public static extern BOOL CompareObjectHandles([NativeTypeName("HANDLE")] IntPtr hFirstObjectHandle, [NativeTypeName("HANDLE")] IntPtr hSecondObjectHandle);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL GetHandleInformation([NativeTypeName("HANDLE")] IntPtr hObject, [NativeTypeName("LPDWORD")] uint* lpdwFlags);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL SetHandleInformation([NativeTypeName("HANDLE")] IntPtr hObject, [NativeTypeName("DWORD")] uint dwMask, [NativeTypeName("DWORD")] uint dwFlags);

        [NativeTypeName("#define INVALID_HANDLE_VALUE ((HANDLE)(LONG_PTR)-1)")]
        public static IntPtr INVALID_HANDLE_VALUE => ((nint)((nint)(-1)));
    }
}
