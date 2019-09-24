// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\dwrite_3.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    /// <summary>Specify whether DWRITE_FONT_METRICS::lineGap value should be part of the line metrics. </summary>
    public enum DWRITE_FONT_LINE_GAP_USAGE
    {
        /// <summary>The usage of the font line gap depends on the method used for text layout.</summary>
        DWRITE_FONT_LINE_GAP_USAGE_DEFAULT,

        /// <summary>The font line gap is excluded from line spacing</summary>
        DWRITE_FONT_LINE_GAP_USAGE_DISABLED,

        /// <summary>The font line gap is included in line spacing</summary>
        DWRITE_FONT_LINE_GAP_USAGE_ENABLED
    }
}
