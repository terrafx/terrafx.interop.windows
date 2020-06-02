// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct WNDCLASSW
    {
        [NativeTypeName("UINT")]
        public uint style;

        [NativeTypeName("WNDPROC")]
        public delegate* stdcall<IntPtr, uint, nuint, nint, nint> lpfnWndProc;

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
        public ushort* lpszMenuName;

        [NativeTypeName("LPCWSTR")]
        public ushort* lpszClassName;
    }
}
