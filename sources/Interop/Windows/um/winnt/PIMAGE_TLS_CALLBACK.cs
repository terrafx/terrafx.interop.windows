// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [UnmanagedFunctionPointer(CallingConvention.Winapi)]
    public unsafe delegate void PIMAGE_TLS_CALLBACK([NativeTypeName("PVOID")] void* DllHandle, [NativeTypeName("DWORD")] uint Reason, [NativeTypeName("PVOID")] void* Reserved);
}
