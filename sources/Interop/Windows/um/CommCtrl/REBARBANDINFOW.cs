// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct REBARBANDINFOW
    {
        [NativeTypeName("UINT")]
        public uint cbSize;

        [NativeTypeName("UINT")]
        public uint fMask;

        [NativeTypeName("UINT")]
        public uint fStyle;

        [NativeTypeName("COLORREF")]
        public uint clrFore;

        [NativeTypeName("COLORREF")]
        public uint clrBack;

        [NativeTypeName("LPWSTR")]
        public ushort* lpText;

        [NativeTypeName("UINT")]
        public uint cch;

        public int iImage;

        public HWND hwndChild;

        [NativeTypeName("UINT")]
        public uint cxMinChild;

        [NativeTypeName("UINT")]
        public uint cyMinChild;

        [NativeTypeName("UINT")]
        public uint cx;

        public HBITMAP hbmBack;

        [NativeTypeName("UINT")]
        public uint wID;

        [NativeTypeName("UINT")]
        public uint cyChild;

        [NativeTypeName("UINT")]
        public uint cyMaxChild;

        [NativeTypeName("UINT")]
        public uint cyIntegral;

        [NativeTypeName("UINT")]
        public uint cxIdeal;

        [NativeTypeName("LPARAM")]
        public nint lParam;

        [NativeTypeName("UINT")]
        public uint cxHeader;

        public RECT rcChevronLocation;

        [NativeTypeName("UINT")]
        public uint uChevronState;
    }
}
