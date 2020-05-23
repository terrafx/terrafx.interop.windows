// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public partial struct GUITHREADINFO
    {
        [NativeTypeName("DWORD")]
        public uint cbSize;

        [NativeTypeName("DWORD")]
        public uint flags;

        [NativeTypeName("HWND")]
        public IntPtr hwndActive;

        [NativeTypeName("HWND")]
        public IntPtr hwndFocus;

        [NativeTypeName("HWND")]
        public IntPtr hwndCapture;

        [NativeTypeName("HWND")]
        public IntPtr hwndMenuOwner;

        [NativeTypeName("HWND")]
        public IntPtr hwndMoveSize;

        [NativeTypeName("HWND")]
        public IntPtr hwndCaret;

        public RECT rcCaret;
    }
}
