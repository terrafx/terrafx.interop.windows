// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct LVCOLUMNW
    {
        public uint mask;

        public int fmt;

        public int cx;

        [NativeTypeName("LPWSTR")]
        public ushort* pszText;

        public int cchTextMax;

        public int iSubItem;

        public int iImage;

        public int iOrder;

        public int cxMin;

        public int cxDefault;

        public int cxIdeal;
    }
}
