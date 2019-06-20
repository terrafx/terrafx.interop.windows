// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d2d1effects.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    /// <summary>The enumeration of the Bitmap Source effect's top level properties.</summary>
    public enum D2D1_BITMAPSOURCE_PROP : uint
    {
        /// <summary>Property Name: "WicBitmapSource" Property Type: IUnknown *</summary>
        D2D1_BITMAPSOURCE_PROP_WIC_BITMAP_SOURCE = 0,

        /// <summary>Property Name: "Scale" Property Type: D2D1_VECTOR_2F</summary>
        D2D1_BITMAPSOURCE_PROP_SCALE = 1,

        /// <summary>Property Name: "InterpolationMode" Property Type: D2D1_BITMAPSOURCE_INTERPOLATION_MODE</summary>
        D2D1_BITMAPSOURCE_PROP_INTERPOLATION_MODE = 2,

        /// <summary>Property Name: "EnableDPICorrection" Property Type: BOOL</summary>
        D2D1_BITMAPSOURCE_PROP_ENABLE_DPI_CORRECTION = 3,

        /// <summary>Property Name: "AlphaMode" Property Type: D2D1_BITMAPSOURCE_ALPHA_MODE</summary>
        D2D1_BITMAPSOURCE_PROP_ALPHA_MODE = 4,

        /// <summary>Property Name: "Orientation" Property Type: D2D1_BITMAPSOURCE_ORIENTATION</summary>
        D2D1_BITMAPSOURCE_PROP_ORIENTATION = 5,

        D2D1_BITMAPSOURCE_PROP_FORCE_DWORD = 0xFFFFFFFF
    }
}
