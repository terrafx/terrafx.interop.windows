// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct UPDATELAYEREDWINDOWINFO
    {
        [NativeTypeName("DWORD")]
        public uint cbSize;

        [NativeTypeName("HDC")]
        public IntPtr hdcDst;

        [NativeTypeName("const POINT *")]
        public POINT* pptDst;

        [NativeTypeName("const SIZE *")]
        public SIZE* psize;

        [NativeTypeName("HDC")]
        public IntPtr hdcSrc;

        [NativeTypeName("const POINT *")]
        public POINT* pptSrc;

        [NativeTypeName("COLORREF")]
        public uint crKey;

        [NativeTypeName("const BLENDFUNCTION *")]
        public BLENDFUNCTION* pblend;

        [NativeTypeName("DWORD")]
        public uint dwFlags;

        [NativeTypeName("const RECT *")]
        public RECT* prcDirty;
    }
}
