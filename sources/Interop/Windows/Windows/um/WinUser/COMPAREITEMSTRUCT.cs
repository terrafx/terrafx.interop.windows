// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows
{
    public partial struct COMPAREITEMSTRUCT
    {
        public uint CtlType;

        public uint CtlID;

        public HWND hwndItem;

        public uint itemID1;

        [NativeTypeName("ULONG_PTR")]
        public nuint itemData1;

        public uint itemID2;

        [NativeTypeName("ULONG_PTR")]
        public nuint itemData2;

        [NativeTypeName("DWORD")]
        public uint dwLocaleId;
    }
}
