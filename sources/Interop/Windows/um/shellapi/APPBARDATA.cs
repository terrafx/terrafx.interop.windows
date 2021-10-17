// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/shellapi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public partial struct APPBARDATA
    {
        [NativeTypeName("DWORD")]
        public uint cbSize;

        [NativeTypeName("HWND")]
        public IntPtr hWnd;

        [NativeTypeName("UINT")]
        public uint uCallbackMessage;

        [NativeTypeName("UINT")]
        public uint uEdge;

        public RECT rc;

        [NativeTypeName("LPARAM")]
        public nint lParam;
    }
}
