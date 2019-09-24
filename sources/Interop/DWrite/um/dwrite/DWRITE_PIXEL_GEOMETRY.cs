// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\dwrite.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    /// <summary>Represents the internal public structure of a device pixel (i.e., the physical arrangement of red, green, and blue color components) that is assumed for purposes of rendering text.</summary>
    public enum DWRITE_PIXEL_GEOMETRY
    {
        /// <summary>The red, green, and blue color components of each pixel are assumed to occupy the same point.</summary>
        DWRITE_PIXEL_GEOMETRY_FLAT,

        /// <summary>Each pixel comprises three vertical stripes, with red on the left, green in the center, and blue on the right. This is the most common pixel geometry for LCD monitors.</summary>
        DWRITE_PIXEL_GEOMETRY_RGB,

        /// <summary>Each pixel comprises three vertical stripes, with blue on the left, green in the center, and red on the right.</summary>
        DWRITE_PIXEL_GEOMETRY_BGR
    }
}
