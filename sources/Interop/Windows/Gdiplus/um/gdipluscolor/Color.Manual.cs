// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/gdipluscolor.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using TerraFX.Interop.Windows;

namespace TerraFX.Interop.Gdiplus;

public partial struct Color
{
    public COLORREF ToCOLORREF()
    {
        return (COLORREF)(GetRed() | (GetGreen() << 8) | (GetBlue() << 16));
    }
}
