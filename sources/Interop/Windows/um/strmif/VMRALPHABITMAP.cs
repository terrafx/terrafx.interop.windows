// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct VMRALPHABITMAP
    {
        [NativeTypeName("DWORD")]
        public uint dwFlags;

        public HDC hdc;

        [NativeTypeName("LPDIRECTDRAWSURFACE7")]
        public IDirectDrawSurface7* pDDS;

        public RECT rSrc;

        public NORMALIZEDRECT rDest;

        public float fAlpha;

        [NativeTypeName("COLORREF")]
        public uint clrSrcKey;
    }
}
