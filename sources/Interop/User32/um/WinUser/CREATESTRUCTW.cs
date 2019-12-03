// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct CREATESTRUCTW
    {
        [NativeTypeName("LPVOID")]
        public void* lpCreateParams;

        [NativeTypeName("HINSTANCE")]
        public IntPtr hInstance;

        [NativeTypeName("HMENU")]
        public IntPtr hMenu;

        [NativeTypeName("HWND")]
        public IntPtr hwndParent;

        public int cy;

        public int cx;

        public int y;

        public int x;

        [NativeTypeName("LONG")]
        public int style;

        [NativeTypeName("LPCWSTR")]
        public ushort* lpszName;

        [NativeTypeName("LPCWSTR")]
        public ushort* lpszClass;

        [NativeTypeName("DWORD")]
        public uint dwExStyle;
    }
}
