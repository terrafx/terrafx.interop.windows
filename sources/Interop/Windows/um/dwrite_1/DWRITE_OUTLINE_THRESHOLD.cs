// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\dwrite_1.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    /// <summary>Specifies the policy used by GetRecommendedRenderingMode to determine whether to render glyphs in outline mode. Glyphs are rendered in outline mode by default at large sizes for performance reasons, but how large (i.e., the outline threshold) depends on the quality of outline rendering. If the graphics system renders anti- aliased outlines then a relatively low threshold is used, but if the graphics system renders aliased outlines then a much higher threshold is used.</summary>
    public enum DWRITE_OUTLINE_THRESHOLD
    {
        DWRITE_OUTLINE_THRESHOLD_ANTIALIASED,

        DWRITE_OUTLINE_THRESHOLD_ALIASED
    }
}
