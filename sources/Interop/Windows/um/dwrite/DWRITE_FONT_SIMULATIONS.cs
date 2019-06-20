// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\dwrite.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    /// <summary>Specifies algorithmic style simulations to be applied to the font face. Bold and oblique simulations can be combined via bitwise OR operation.</summary>
    [Flags]
    public enum DWRITE_FONT_SIMULATIONS
    {
        /// <summary>No simulations are performed.</summary>
        DWRITE_FONT_SIMULATIONS_NONE = 0x0000,

        /// <summary>Algorithmic emboldening is performed.</summary>
        DWRITE_FONT_SIMULATIONS_BOLD = 0x0001,

        /// <summary>Algorithmic italicization is performed.</summary>
        DWRITE_FONT_SIMULATIONS_OBLIQUE = 0x0002
    }
}
