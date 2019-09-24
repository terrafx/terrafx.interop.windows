// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\dwrite_1.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    /// <summary>Monospace vs proportional. Present for families: 3-script, 5-symbol</summary>
    public enum DWRITE_PANOSE_SPACING
    {
        DWRITE_PANOSE_SPACING_ANY = 0,

        DWRITE_PANOSE_SPACING_NO_FIT = 1,

        DWRITE_PANOSE_SPACING_PROPORTIONAL_SPACED = 2,

        DWRITE_PANOSE_SPACING_MONOSPACED = 3
    }
}
