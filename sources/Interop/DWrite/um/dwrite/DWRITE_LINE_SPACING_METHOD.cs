// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\dwrite.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    /// <summary>The method used for line spacing in layout.</summary>
    public enum DWRITE_LINE_SPACING_METHOD
    {
        /// <summary>Line spacing depends solely on the content, growing to accommodate the size of fonts and inline objects.</summary>
        DWRITE_LINE_SPACING_METHOD_DEFAULT,

        /// <summary>Lines are explicitly set to uniform spacing, regardless of contained font sizes.
        /// This can be useful to avoid the uneven appearance that can occur from font fallback.</summary>
        DWRITE_LINE_SPACING_METHOD_UNIFORM,

        /// <summary>Line spacing and baseline distances are proportional to the computed values based on the content, the size of the fonts and inline objects.</summary>
        DWRITE_LINE_SPACING_METHOD_PROPORTIONAL
    }
}
