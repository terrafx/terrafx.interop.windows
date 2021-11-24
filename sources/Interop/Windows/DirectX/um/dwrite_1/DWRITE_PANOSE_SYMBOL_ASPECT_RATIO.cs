// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dwrite_1.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

public enum DWRITE_PANOSE_SYMBOL_ASPECT_RATIO
{
    DWRITE_PANOSE_SYMBOL_ASPECT_RATIO_ANY = 0,
    DWRITE_PANOSE_SYMBOL_ASPECT_RATIO_NO_FIT = 1,
    DWRITE_PANOSE_SYMBOL_ASPECT_RATIO_NO_WIDTH = 2,
    DWRITE_PANOSE_SYMBOL_ASPECT_RATIO_EXCEPTIONALLY_WIDE = 3,
    DWRITE_PANOSE_SYMBOL_ASPECT_RATIO_SUPER_WIDE = 4,
    DWRITE_PANOSE_SYMBOL_ASPECT_RATIO_VERY_WIDE = 5,
    DWRITE_PANOSE_SYMBOL_ASPECT_RATIO_WIDE = 6,
    DWRITE_PANOSE_SYMBOL_ASPECT_RATIO_NORMAL = 7,
    DWRITE_PANOSE_SYMBOL_ASPECT_RATIO_NARROW = 8,
    DWRITE_PANOSE_SYMBOL_ASPECT_RATIO_VERY_NARROW = 9,
}
