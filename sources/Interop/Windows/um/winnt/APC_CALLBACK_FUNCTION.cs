// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [UnmanagedFunctionPointer(CallingConvention.Winapi)]
    public unsafe delegate void APC_CALLBACK_FUNCTION([NativeTypeName("DWORD")] uint param0, [NativeTypeName("PVOID")] void* param1, [NativeTypeName("PVOID")] void* param2);
}
