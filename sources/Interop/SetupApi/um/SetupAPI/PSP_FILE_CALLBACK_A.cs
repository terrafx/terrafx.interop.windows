// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SetupAPI.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [UnmanagedFunctionPointer(CallingConvention.Winapi)]
    [return: NativeTypeName("UINT")]
    public unsafe delegate uint PSP_FILE_CALLBACK_A([NativeTypeName("PVOID")] void* Context, [NativeTypeName("UINT")] uint Notification, [NativeTypeName("UINT_PTR")] uint Param1, [NativeTypeName("UINT_PTR")] uint Param2);
}