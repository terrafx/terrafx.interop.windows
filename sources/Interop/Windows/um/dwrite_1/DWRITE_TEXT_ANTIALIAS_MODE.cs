// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\dwrite_1.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    /// <summary>Represents the type of antialiasing to use for text when the rendering mode calls for antialiasing.</summary>
    public enum DWRITE_TEXT_ANTIALIAS_MODE
    {
        /// <summary>ClearType antialiasing computes coverage independently for the red, green, and blue color elements of each pixel. This allows for more detail than conventional antialiasing. However, because there is no one alpha value for each pixel, ClearType is not suitable rendering text onto a transparent intermediate bitmap.</summary>
        DWRITE_TEXT_ANTIALIAS_MODE_CLEARTYPE,

        /// <summary>Grayscale antialiasing computes one coverage value for each pixel. Because the alpha value of each pixel is well-defined, text can be rendered onto a transparent bitmap, which can then be composited with other content. Note that grayscale rendering with IDWriteBitmapRenderTarget1 uses premultiplied alpha.</summary>
        DWRITE_TEXT_ANTIALIAS_MODE_GRAYSCALE
    }
}
