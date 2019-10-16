// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winuser.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct MENUBARINFO
    {
        [NativeTypeName("DWORD")]
        public uint cbSize;

        public RECT rcBar;

        [NativeTypeName("HMENU")]
        public IntPtr hMenu;

        [NativeTypeName("HWND")]
        public IntPtr hwndMenu;

        [NativeTypeName("BOOL")]
        public int fBarFocused;

        [NativeTypeName("BOOL")]
        public int fFocused;
    }
}
