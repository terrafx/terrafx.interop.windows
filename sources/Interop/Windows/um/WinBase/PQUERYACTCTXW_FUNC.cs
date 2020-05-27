// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinBase.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [UnmanagedFunctionPointer(CallingConvention.Winapi)]
    [return: NativeTypeName("BOOL")]
    public unsafe delegate int PQUERYACTCTXW_FUNC([NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("HANDLE")] IntPtr hActCtx, [NativeTypeName("PVOID")] void* pvSubInstance, [NativeTypeName("ULONG")] uint ulInfoClass, [NativeTypeName("PVOID")] void* pvBuffer, [NativeTypeName("SIZE_T")] nuint cbBuffer, [NativeTypeName("SIZE_T *")] nuint* pcbWrittenOrRequired);
}
