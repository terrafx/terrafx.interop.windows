// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct WNDCLASSEXA
    {
        [NativeTypeName("UINT")]
        public uint cbSize;

        [NativeTypeName("UINT")]
        public uint style;

        [NativeTypeName("WNDPROC")]
        public delegate* unmanaged<HWND, uint, nuint, nint, nint> lpfnWndProc;

        public int cbClsExtra;

        public int cbWndExtra;

        public HINSTANCE hInstance;

        public HICON hIcon;

        [NativeTypeName("HCURSOR")]
        public HICON hCursor;

        public HBRUSH hbrBackground;

        [NativeTypeName("LPCSTR")]
        public sbyte* lpszMenuName;

        [NativeTypeName("LPCSTR")]
        public sbyte* lpszClassName;

        public HICON hIconSm;
    }
}
