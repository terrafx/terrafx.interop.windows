// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/Uxtheme.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using static TerraFX.Interop.Windows.WINDOWTHEMEATTRIBUTETYPE;

namespace TerraFX.Interop.Windows;

public static unsafe partial class Windows
{
    public static HRESULT BufferedPaintMakeOpaque(HPAINTBUFFER hBufferedPaint, RECT* prc) => BufferedPaintSetAlpha(hBufferedPaint, prc, 255);

    public static HRESULT SetWindowThemeNonClientAttributes(HWND hwnd, uint dwMask, uint dwAttributes)
    {
        var wta = new WTA_OPTIONS {
            dwFlags = dwAttributes,
            dwMask = dwMask,
        };
        return SetWindowThemeAttribute(hwnd, WTA_NONCLIENT, (void*)&(wta), (uint)sizeof(WTA_OPTIONS));
    }
}
