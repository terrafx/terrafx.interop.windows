// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d2d1_3.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    /// <summary>Properties of a transformed image source.</summary>
    public struct D2D1_TRANSFORMED_IMAGE_SOURCE_PROPERTIES
    {
        /// <summary>The orientation at which the image source is drawn.</summary>
        public D2D1_ORIENTATION orientation;

        /// <summary>The horizontal scale factor at which the image source is drawn.</summary>
        [NativeTypeName("FLOAT")]
        public float scaleX;

        /// <summary>The vertical scale factor at which the image source is drawn.</summary>
        [NativeTypeName("FLOAT")]
        public float scaleY;

        /// <summary>The interpolation mode used when the image source is drawn.  This is ignored if the image source is drawn using the DrawImage method, or using an image brush.</summary>
        public D2D1_INTERPOLATION_MODE interpolationMode;

        /// <summary>Option flags.</summary>
        public D2D1_TRANSFORMED_IMAGE_SOURCE_OPTIONS options;
    }
}
