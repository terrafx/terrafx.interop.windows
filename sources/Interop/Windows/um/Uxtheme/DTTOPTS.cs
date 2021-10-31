// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/Uxtheme.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct DTTOPTS
    {
        [NativeTypeName("DWORD")]
        public uint dwSize;

        [NativeTypeName("DWORD")]
        public uint dwFlags;

        [NativeTypeName("COLORREF")]
        public uint crText;

        [NativeTypeName("COLORREF")]
        public uint crBorder;

        [NativeTypeName("COLORREF")]
        public uint crShadow;

        public int iTextShadowType;

        public POINT ptShadowOffset;

        public int iBorderSize;

        public int iFontPropId;

        public int iColorPropId;

        public int iStateId;

        public BOOL fApplyOverlay;

        public int iGlowSize;

        [NativeTypeName("DTT_CALLBACK_PROC")]
        public delegate* unmanaged<HDC, ushort*, int, RECT*, uint, nint, int> pfnDrawTextCallback;

        [NativeTypeName("LPARAM")]
        public nint lParam;
    }
}
