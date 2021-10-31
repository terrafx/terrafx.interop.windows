// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct LVITEMA
    {
        public uint mask;

        public int iItem;

        public int iSubItem;

        public uint state;

        public uint stateMask;

        [NativeTypeName("LPSTR")]
        public sbyte* pszText;

        public int cchTextMax;

        public int iImage;

        [NativeTypeName("LPARAM")]
        public nint lParam;

        public int iIndent;

        public int iGroupId;

        public uint cColumns;

        [NativeTypeName("PUINT")]
        public uint* puColumns;

        public int* piColFmt;

        public int iGroup;
    }
}
