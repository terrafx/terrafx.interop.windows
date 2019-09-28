// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\winuser.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct COMBOBOXINFO
    {
        [NativeTypeName("DWORD")]
        public uint cbSize;

        public RECT rcItem;

        public RECT rcButton;

        [NativeTypeName("DWORD")]
        public uint stateButton;

        [NativeTypeName("HWND")]
        public IntPtr hwndCombo;

        [NativeTypeName("HWND")]
        public IntPtr hwndItem;

        [NativeTypeName("HWND")]
        public IntPtr hwndList;
    }
}
