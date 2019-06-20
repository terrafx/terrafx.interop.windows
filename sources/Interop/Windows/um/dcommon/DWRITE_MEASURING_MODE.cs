// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\dcommon.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    /// <summary>The measuring method used for text layout.</summary>
    public enum DWRITE_MEASURING_MODE
    {
        /// <summary>Text is measured using glyph ideal metrics whose values are independent to the current display resolution.</summary>
        DWRITE_MEASURING_MODE_NATURAL,

        /// <summary>Text is measured using glyph display compatible metrics whose values tuned for the current display resolution.</summary>
        DWRITE_MEASURING_MODE_GDI_CLASSIC,

        /// <summary>Text is measured using the same glyph display metrics as text measured by GDI using a font created with CLEARTYPE_NATURAL_QUALITY.</summary>
        DWRITE_MEASURING_MODE_GDI_NATURAL
    }
}
