// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/Uxtheme.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using static TerraFX.Interop.WINDOWTHEMEATTRIBUTETYPE;

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        public static int BufferedPaintMakeOpaque(HANDLE hBufferedPaint, RECT* prc) => BufferedPaintSetAlpha(hBufferedPaint, prc, 255);

        public static int SetWindowThemeNonClientAttributes(HWND hwnd, uint dwMask, uint dwAttributes)
        {
            WTA_OPTIONS wta = new WTA_OPTIONS();
            wta.dwFlags = dwAttributes;
            wta.dwMask = dwMask;
            return SetWindowThemeAttribute(hwnd, WTA_NONCLIENT, (void*)&(wta), (uint) sizeof(WTA_OPTIONS));
        }
    }
}
