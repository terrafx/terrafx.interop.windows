// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d2d1_1.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    /// <summary>The creation properties for a ID2D1PrintControl object.</summary>
    public struct D2D1_PRINT_CONTROL_PROPERTIES
    {
        #region Fields
        public D2D1_PRINT_FONT_SUBSET_MODE fontSubset;

        /// <summary>DPI for rasterization of all unsupported D2D commands or options, defaults to 150.0</summary>
        [NativeTypeName("FLOAT")]
        public float rasterDPI;

        /// <summary>Color space for vector graphics in XPS package</summary>
        public D2D1_COLOR_SPACE colorSpace;
        #endregion
    }
}
