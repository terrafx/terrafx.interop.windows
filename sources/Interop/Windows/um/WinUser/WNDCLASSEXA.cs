// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct WNDCLASSEXA
    {
        [NativeTypeName("UINT")]
        public uint cbSize;

        [NativeTypeName("UINT")]
        public uint style;

        [NativeTypeName("WNDPROC")]
        public delegate* unmanaged<IntPtr, uint, nuint, nint, nint> lpfnWndProc;

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

        [NativeTypeName("LPCSTR")]
        public sbyte* lpszMenuName;

        [NativeTypeName("LPCSTR")]
        public sbyte* lpszClassName;

        [NativeTypeName("HICON")]
        public IntPtr hIconSm;
    }
}
