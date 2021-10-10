// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct LVGROUPMETRICS
    {
        [NativeTypeName("UINT")]
        public uint cbSize;

        [NativeTypeName("UINT")]
        public uint mask;

        [NativeTypeName("UINT")]
        public uint Left;

        [NativeTypeName("UINT")]
        public uint Top;

        [NativeTypeName("UINT")]
        public uint Right;

        [NativeTypeName("UINT")]
        public uint Bottom;

        [NativeTypeName("COLORREF")]
        public uint crLeft;

        [NativeTypeName("COLORREF")]
        public uint crTop;

        [NativeTypeName("COLORREF")]
        public uint crRight;

        [NativeTypeName("COLORREF")]
        public uint crBottom;

        [NativeTypeName("COLORREF")]
        public uint crHeader;

        [NativeTypeName("COLORREF")]
        public uint crFooter;
    }
}
