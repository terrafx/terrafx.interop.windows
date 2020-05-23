// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinBase.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [UnmanagedFunctionPointer(CallingConvention.Winapi)]
    [return: NativeTypeName("DWORD")]
    public unsafe delegate uint LPPROGRESS_ROUTINE(LARGE_INTEGER TotalFileSize, LARGE_INTEGER TotalBytesTransferred, LARGE_INTEGER StreamSize, LARGE_INTEGER StreamBytesTransferred, [NativeTypeName("DWORD")] uint dwStreamNumber, [NativeTypeName("DWORD")] uint dwCallbackReason, [NativeTypeName("HANDLE")] IntPtr hSourceFile, [NativeTypeName("HANDLE")] IntPtr hDestinationFile, [NativeTypeName("LPVOID")] void* lpData);
}
