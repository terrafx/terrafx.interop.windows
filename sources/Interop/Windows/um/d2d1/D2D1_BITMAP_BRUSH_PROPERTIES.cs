// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d2d1.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using TerraFX.Utilities;

namespace TerraFX.Interop
{
    /// <summary>Describes the extend modes and the interpolation mode of an ID2D1BitmapBrush.</summary>
    [Unmanaged]
    public struct D2D1_BITMAP_BRUSH_PROPERTIES
    {
        #region Fields
        public D2D1_EXTEND_MODE extendModeX;

        public D2D1_EXTEND_MODE extendModeY;

        public D2D1_BITMAP_INTERPOLATION_MODE interpolationMode;
        #endregion
    }
}
