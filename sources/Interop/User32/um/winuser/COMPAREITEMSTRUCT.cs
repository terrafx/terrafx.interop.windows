// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\winuser.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct COMPAREITEMSTRUCT
    {
        [NativeTypeName("UINT")]
        public uint CtlType;

        [NativeTypeName("UINT")]
        public uint CtlID;

        [NativeTypeName("HWND")]
        public IntPtr hwndItem;

        [NativeTypeName("UINT")]
        public uint itemID1;

        [NativeTypeName("ULONG_PTR")]
        public UIntPtr itemData1;

        [NativeTypeName("UINT")]
        public uint itemID2;

        [NativeTypeName("ULONG_PTR")]
        public UIntPtr itemData2;

        [NativeTypeName("DWORD")]
        public uint dwLocaleId;
    }
}
