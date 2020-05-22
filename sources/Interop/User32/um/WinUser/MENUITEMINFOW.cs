// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct MENUITEMINFOW
    {
        [NativeTypeName("UINT")]
        public uint cbSize;

        [NativeTypeName("UINT")]
        public uint fMask;

        [NativeTypeName("UINT")]
        public uint fType;

        [NativeTypeName("UINT")]
        public uint fState;

        [NativeTypeName("UINT")]
        public uint wID;

        [NativeTypeName("HMENU")]
        public IntPtr hSubMenu;

        [NativeTypeName("HBITMAP")]
        public IntPtr hbmpChecked;

        [NativeTypeName("HBITMAP")]
        public IntPtr hbmpUnchecked;

        [NativeTypeName("ULONG_PTR")]
        public nuint dwItemData;

        [NativeTypeName("LPWSTR")]
        public ushort* dwTypeData;

        [NativeTypeName("UINT")]
        public uint cch;

        [NativeTypeName("HBITMAP")]
        public IntPtr hbmpItem;
    }
}
