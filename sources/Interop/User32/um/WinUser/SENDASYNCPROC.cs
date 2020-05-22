// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [UnmanagedFunctionPointer(CallingConvention.Winapi)]
    public delegate void SENDASYNCPROC([NativeTypeName("HWND")] IntPtr param0, [NativeTypeName("UINT")] uint param1, [NativeTypeName("ULONG_PTR")] nuint param2, [NativeTypeName("LRESULT")] nint param3);
}
