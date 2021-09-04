// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct LVITEMW
    {
        [NativeTypeName("UINT")]
        public uint mask;

        public int iItem;

        public int iSubItem;

        [NativeTypeName("UINT")]
        public uint state;

        [NativeTypeName("UINT")]
        public uint stateMask;

        [NativeTypeName("LPWSTR")]
        public ushort* pszText;

        public int cchTextMax;

        public int iImage;

        [NativeTypeName("LPARAM")]
        public nint lParam;

        public int iIndent;

        public int iGroupId;

        [NativeTypeName("UINT")]
        public uint cColumns;

        [NativeTypeName("PUINT")]
        public uint* puColumns;

        public int* piColFmt;

        public int iGroup;
    }
}
