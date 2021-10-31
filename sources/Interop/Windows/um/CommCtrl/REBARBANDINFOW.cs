// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct REBARBANDINFOW
    {
        public uint cbSize;

        public uint fMask;

        public uint fStyle;

        [NativeTypeName("COLORREF")]
        public uint clrFore;

        [NativeTypeName("COLORREF")]
        public uint clrBack;

        [NativeTypeName("LPWSTR")]
        public ushort* lpText;

        public uint cch;

        public int iImage;

        public HWND hwndChild;

        public uint cxMinChild;

        public uint cyMinChild;

        public uint cx;

        public HBITMAP hbmBack;

        public uint wID;

        public uint cyChild;

        public uint cyMaxChild;

        public uint cyIntegral;

        public uint cxIdeal;

        [NativeTypeName("LPARAM")]
        public nint lParam;

        public uint cxHeader;

        public RECT rcChevronLocation;

        public uint uChevronState;
    }
}
