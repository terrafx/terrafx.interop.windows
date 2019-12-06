// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/libloaderapi.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("BOOL")]
    public unsafe delegate int PGET_MODULE_HANDLE_EXA([NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LPCSTR")] sbyte* lpModuleName, [NativeTypeName("HMODULE *")] IntPtr* phModule);
}
