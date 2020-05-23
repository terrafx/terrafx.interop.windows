// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public partial struct MENUBARINFO
    {
        [NativeTypeName("DWORD")]
        public uint cbSize;

        public RECT rcBar;

        [NativeTypeName("HMENU")]
        public IntPtr hMenu;

        [NativeTypeName("HWND")]
        public IntPtr hwndMenu;

        internal int _bitfield;

        [NativeTypeName("BOOL : 1")]
        public int fBarFocused
        {
            get
            {
                return _bitfield & 0x1;
            }

            set
            {
                _bitfield = (_bitfield & ~0x1) | (value & 0x1);
            }
        }

        [NativeTypeName("BOOL : 1")]
        public int fFocused
        {
            get
            {
                return (_bitfield >> 1) & 0x1;
            }

            set
            {
                _bitfield = (_bitfield & ~(0x1 << 1)) | ((value & 0x1) << 1);
            }
        }
    }
}
