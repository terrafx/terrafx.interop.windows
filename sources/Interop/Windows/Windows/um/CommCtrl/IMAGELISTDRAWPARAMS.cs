// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows
{
    public partial struct IMAGELISTDRAWPARAMS
    {
        [NativeTypeName("DWORD")]
        public uint cbSize;

        public HIMAGELIST himl;

        public int i;

        public HDC hdcDst;

        public int x;

        public int y;

        public int cx;

        public int cy;

        public int xBitmap;

        public int yBitmap;

        public COLORREF rgbBk;

        public COLORREF rgbFg;

        public uint fStyle;

        [NativeTypeName("DWORD")]
        public uint dwRop;

        [NativeTypeName("DWORD")]
        public uint fState;

        [NativeTypeName("DWORD")]
        public uint Frame;

        public COLORREF crEffect;
    }
}
