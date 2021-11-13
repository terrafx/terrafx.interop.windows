// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows
{
    public enum HTMLBorderStyle
    {
        HTMLBorderStyleNormal = 0,
        HTMLBorderStyleRaised = 0x100,
        HTMLBorderStyleSunken = 0x200,
        HTMLBorderStylecombined = 0x300,
        HTMLBorderStyleStatic = 0x20000,
        HTMLBorderStyle_Max = 2147483647,
    }
}
