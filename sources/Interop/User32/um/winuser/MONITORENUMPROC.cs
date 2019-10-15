// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\winuser.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("BOOL")]
    public unsafe delegate int MONITORENUMPROC([NativeTypeName("HMONITOR")] IntPtr param0, [NativeTypeName("HDC")] IntPtr param1, [NativeTypeName("LPRECT")] RECT* param2, [NativeTypeName("LPARAM")] IntPtr param3);
}