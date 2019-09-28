// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\winuser.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct DRAWITEMSTRUCT
    {
        [NativeTypeName("UINT")]
        public uint CtlType;

        [NativeTypeName("UINT")]
        public uint CtlID;

        [NativeTypeName("UINT")]
        public uint itemID;

        [NativeTypeName("UINT")]
        public uint itemAction;

        [NativeTypeName("UINT")]
        public uint itemState;

        [NativeTypeName("HWND")]
        public IntPtr hwndItem;

        [NativeTypeName("HDC")]
        public IntPtr hDC;

        public RECT rcItem;

        [NativeTypeName("ULONG_PTR")]
        public UIntPtr itemData;
    }
}
