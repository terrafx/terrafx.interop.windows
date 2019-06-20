// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d2d1_3.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using TerraFX.Utilities;

namespace TerraFX.Interop
{
    /// <summary>Simple description of a color space.</summary>
    [Unmanaged]
    public struct D2D1_SIMPLE_COLOR_PROFILE
    {
        #region Fields
        /// <summary>The XY coordinates of the red primary in CIEXYZ space.</summary>
        [NativeTypeName("D2D1_POINT_2F")]
        public D2D_POINT_2F redPrimary;

        /// <summary>The XY coordinates of the green primary in CIEXYZ space.</summary>
        [NativeTypeName("D2D1_POINT_2F")]
        public D2D_POINT_2F greenPrimary;

        /// <summary>The XY coordinates of the blue primary in CIEXYZ space.</summary>
        [NativeTypeName("D2D1_POINT_2F")]
        public D2D_POINT_2F bluePrimary;

        /// <summary>The X/Z tristimulus values for the whitepoint, normalized for relative luminance.</summary>
        [NativeTypeName("D2D1_POINT_2F")]
        public D2D_POINT_2F whitePointXZ;

        /// <summary>The gamma encoding to use for this color space.</summary>
        public D2D1_GAMMA1 gamma;
        #endregion
    }
}
