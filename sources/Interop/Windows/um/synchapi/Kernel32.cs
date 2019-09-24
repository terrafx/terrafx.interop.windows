// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\synchapi.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using System.Security;

namespace TerraFX.Interop
{
    public static unsafe partial class Kernel32
    {
        [DllImport(DllName, BestFitMapping = false, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Unicode, EntryPoint = "CreateEventW", ExactSpelling = true, PreserveSig = true, SetLastError = true, ThrowOnUnmappableChar = false)]
        [SuppressUnmanagedCodeSecurity]
        [return: NativeTypeName("HANDLE")]
        public static extern IntPtr CreateEvent(
            [In, Optional, NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpEventAttributes,
            [In, NativeTypeName("BOOL")] int bManualReset,
            [In, NativeTypeName("BOOL")] int bInitialState,
            [In, NativeTypeName("LPCWSTR")] char* lpName = null
        );

        [DllImport(DllName, BestFitMapping = false, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Unicode, EntryPoint = "WaitForSingleObject", ExactSpelling = true, PreserveSig = true, SetLastError = true, ThrowOnUnmappableChar = false)]
        [SuppressUnmanagedCodeSecurity]
        [return: NativeTypeName("DWORD")]
        public static extern uint WaitForSingleObject(
            [In, NativeTypeName("HANDLE")] IntPtr hHandle,
            [In, NativeTypeName("DWORD")] uint dwMilliseconds
        );
    }
}
