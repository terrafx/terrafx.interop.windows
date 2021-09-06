// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct TOOLINFOA
    {
        [NativeTypeName("UINT")]
        public uint cbSize;

        [NativeTypeName("UINT")]
        public uint uFlags;

        [NativeTypeName("HWND")]
        public IntPtr hwnd;

        [NativeTypeName("UINT_PTR")]
        public nuint uId;

        public RECT rect;

        [NativeTypeName("HINSTANCE")]
        public IntPtr hinst;

        [NativeTypeName("LPSTR")]
        public sbyte* lpszText;

        [NativeTypeName("LPARAM")]
        public nint lParam;

        public void* lpReserved;
    }
}
