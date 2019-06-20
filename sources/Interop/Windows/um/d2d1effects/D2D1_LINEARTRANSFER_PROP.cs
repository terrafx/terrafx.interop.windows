// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d2d1effects.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    /// <summary>The enumeration of the Linear Transfer effect's top level properties.</summary>
    public enum D2D1_LINEARTRANSFER_PROP : uint
    {
        /// <summary>Property Name: "RedYIntercept" Property Type: FLOAT</summary>
        D2D1_LINEARTRANSFER_PROP_RED_Y_INTERCEPT = 0,

        /// <summary>Property Name: "RedSlope" Property Type: FLOAT</summary>
        D2D1_LINEARTRANSFER_PROP_RED_SLOPE = 1,

        /// <summary>Property Name: "RedDisable" Property Type: BOOL</summary>
        D2D1_LINEARTRANSFER_PROP_RED_DISABLE = 2,

        /// <summary>Property Name: "GreenYIntercept" Property Type: FLOAT</summary>
        D2D1_LINEARTRANSFER_PROP_GREEN_Y_INTERCEPT = 3,

        /// <summary>Property Name: "GreenSlope" Property Type: FLOAT</summary>
        D2D1_LINEARTRANSFER_PROP_GREEN_SLOPE = 4,

        /// <summary>Property Name: "GreenDisable" Property Type: BOOL</summary>
        D2D1_LINEARTRANSFER_PROP_GREEN_DISABLE = 5,

        /// <summary>Property Name: "BlueYIntercept" Property Type: FLOAT</summary>
        D2D1_LINEARTRANSFER_PROP_BLUE_Y_INTERCEPT = 6,

        /// <summary>Property Name: "BlueSlope" Property Type: FLOAT</summary>
        D2D1_LINEARTRANSFER_PROP_BLUE_SLOPE = 7,

        /// <summary>Property Name: "BlueDisable" Property Type: BOOL</summary>
        D2D1_LINEARTRANSFER_PROP_BLUE_DISABLE = 8,

        /// <summary>Property Name: "AlphaYIntercept" Property Type: FLOAT</summary>
        D2D1_LINEARTRANSFER_PROP_ALPHA_Y_INTERCEPT = 9,

        /// <summary>Property Name: "AlphaSlope" Property Type: FLOAT</summary>
        D2D1_LINEARTRANSFER_PROP_ALPHA_SLOPE = 10,

        /// <summary>Property Name: "AlphaDisable" Property Type: BOOL</summary>
        D2D1_LINEARTRANSFER_PROP_ALPHA_DISABLE = 11,

        /// <summary>Property Name: "ClampOutput" Property Type: BOOL</summary>
        D2D1_LINEARTRANSFER_PROP_CLAMP_OUTPUT = 12,

        D2D1_LINEARTRANSFER_PROP_FORCE_DWORD = 0xFFFFFFFF
    }
}
