// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/gdipluspixelformats.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    [Flags]
    public enum PaletteFlags
    {
        PaletteFlagsHasAlpha = 0x0001,
        PaletteFlagsGrayScale = 0x0002,
        PaletteFlagsHalftone = 0x0004,
    }
}
