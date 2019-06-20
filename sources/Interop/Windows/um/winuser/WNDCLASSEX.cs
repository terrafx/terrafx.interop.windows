// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\winuser.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using TerraFX.Utilities;

namespace TerraFX.Interop
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    [Unmanaged]
    public unsafe struct WNDCLASSEX
    {
        #region Fields
        [NativeTypeName("UINT")]
        public uint cbSize;

        [NativeTypeName("UINT")]
        public uint style;

        [NativeTypeName("WNDPROC")]
        public IntPtr lpfnWndProc;

        public int cbClsExtra;

        public int cbWndExtra;

        [NativeTypeName("HINSTANCE")]
        public IntPtr hInstance;

        [NativeTypeName("HICON")]
        public IntPtr hIcon;

        [NativeTypeName("HCURSOR")]
        public IntPtr hCursor;

        [NativeTypeName("HBRUSH")]
        public IntPtr hbrBackground;

        [NativeTypeName("LPCWSTR")]
        public char* lpszMenuName;

        [NativeTypeName("LPCWSTR")]
        public char* lpszClassName;

        [NativeTypeName("HICON")]
        public IntPtr hIconSm;
        #endregion
    }
}
