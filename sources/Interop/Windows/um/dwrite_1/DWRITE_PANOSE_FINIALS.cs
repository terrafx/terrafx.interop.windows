// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dwrite_1.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum DWRITE_PANOSE_FINIALS
    {
        DWRITE_PANOSE_FINIALS_ANY = 0,
        DWRITE_PANOSE_FINIALS_NO_FIT = 1,
        DWRITE_PANOSE_FINIALS_NONE_NO_LOOPS = 2,
        DWRITE_PANOSE_FINIALS_NONE_CLOSED_LOOPS = 3,
        DWRITE_PANOSE_FINIALS_NONE_OPEN_LOOPS = 4,
        DWRITE_PANOSE_FINIALS_SHARP_NO_LOOPS = 5,
        DWRITE_PANOSE_FINIALS_SHARP_CLOSED_LOOPS = 6,
        DWRITE_PANOSE_FINIALS_SHARP_OPEN_LOOPS = 7,
        DWRITE_PANOSE_FINIALS_TAPERED_NO_LOOPS = 8,
        DWRITE_PANOSE_FINIALS_TAPERED_CLOSED_LOOPS = 9,
        DWRITE_PANOSE_FINIALS_TAPERED_OPEN_LOOPS = 10,
        DWRITE_PANOSE_FINIALS_ROUND_NO_LOOPS = 11,
        DWRITE_PANOSE_FINIALS_ROUND_CLOSED_LOOPS = 12,
        DWRITE_PANOSE_FINIALS_ROUND_OPEN_LOOPS = 13,
    }
}
