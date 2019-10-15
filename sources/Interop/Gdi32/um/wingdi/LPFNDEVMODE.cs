// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [UnmanagedFunctionPointer(CallingConvention.Winapi)]
    [return: NativeTypeName("UINT")]
    public unsafe delegate uint LPFNDEVMODE([NativeTypeName("HWND")] IntPtr param0, [NativeTypeName("HMODULE")] IntPtr param1, [NativeTypeName("LPDEVMODE")] DEVMODEA* param2, [NativeTypeName("LPSTR")] sbyte* param3, [NativeTypeName("LPSTR")] sbyte* param4, [NativeTypeName("LPDEVMODE")] DEVMODEA* param5, [NativeTypeName("LPSTR")] sbyte* param6, [NativeTypeName("UINT")] uint param7);
}
