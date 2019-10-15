// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dwrite_1.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum DWRITE_PANOSE_CHARACTER_RANGES
    {
        DWRITE_PANOSE_CHARACTER_RANGES_ANY = 0,
        DWRITE_PANOSE_CHARACTER_RANGES_NO_FIT = 1,
        DWRITE_PANOSE_CHARACTER_RANGES_EXTENDED_COLLECTION = 2,
        DWRITE_PANOSE_CHARACTER_RANGES_LITERALS = 3,
        DWRITE_PANOSE_CHARACTER_RANGES_NO_LOWER_CASE = 4,
        DWRITE_PANOSE_CHARACTER_RANGES_SMALL_CAPS = 5,
    }
}
