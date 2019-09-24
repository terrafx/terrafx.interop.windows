// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\winuser.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [UnmanagedFunctionPointer(CallingConvention.Winapi)]
    [return: NativeTypeName("LRESULT")]
    public /* static */ unsafe delegate IntPtr WNDPROC(
        [In, NativeTypeName("HWND")] IntPtr hWnd,
        [In, NativeTypeName("UINT")] uint Msg,
        [In, NativeTypeName("WPARAM")] UIntPtr wParam,
        [In, NativeTypeName("LPARAM")] IntPtr lParam
    );
}
