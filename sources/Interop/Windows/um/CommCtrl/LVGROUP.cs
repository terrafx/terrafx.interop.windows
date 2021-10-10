// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct LVGROUP
    {
        [NativeTypeName("UINT")]
        public uint cbSize;

        [NativeTypeName("UINT")]
        public uint mask;

        [NativeTypeName("LPWSTR")]
        public ushort* pszHeader;

        public int cchHeader;

        [NativeTypeName("LPWSTR")]
        public ushort* pszFooter;

        public int cchFooter;

        public int iGroupId;

        [NativeTypeName("UINT")]
        public uint stateMask;

        [NativeTypeName("UINT")]
        public uint state;

        [NativeTypeName("UINT")]
        public uint uAlign;

        [NativeTypeName("LPWSTR")]
        public ushort* pszSubtitle;

        [NativeTypeName("UINT")]
        public uint cchSubtitle;

        [NativeTypeName("LPWSTR")]
        public ushort* pszTask;

        [NativeTypeName("UINT")]
        public uint cchTask;

        [NativeTypeName("LPWSTR")]
        public ushort* pszDescriptionTop;

        [NativeTypeName("UINT")]
        public uint cchDescriptionTop;

        [NativeTypeName("LPWSTR")]
        public ushort* pszDescriptionBottom;

        [NativeTypeName("UINT")]
        public uint cchDescriptionBottom;

        public int iTitleImage;

        public int iExtendedImage;

        public int iFirstItem;

        [NativeTypeName("UINT")]
        public uint cItems;

        [NativeTypeName("LPWSTR")]
        public ushort* pszSubsetTitle;

        [NativeTypeName("UINT")]
        public uint cchSubsetTitle;
    }
}
