// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d2d1effects.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    /// <summary>The enumeration of the Table Transfer effect's top level properties.</summary>
    public enum D2D1_TABLETRANSFER_PROP : uint
    {
        /// <summary>Property Name: "RedTable" Property Type: (blob)</summary>
        D2D1_TABLETRANSFER_PROP_RED_TABLE = 0,

        /// <summary>Property Name: "RedDisable" Property Type: BOOL</summary>
        D2D1_TABLETRANSFER_PROP_RED_DISABLE = 1,

        /// <summary>Property Name: "GreenTable" Property Type: (blob)</summary>
        D2D1_TABLETRANSFER_PROP_GREEN_TABLE = 2,

        /// <summary>Property Name: "GreenDisable" Property Type: BOOL</summary>
        D2D1_TABLETRANSFER_PROP_GREEN_DISABLE = 3,

        /// <summary>Property Name: "BlueTable" Property Type: (blob)</summary>
        D2D1_TABLETRANSFER_PROP_BLUE_TABLE = 4,

        /// <summary>Property Name: "BlueDisable" Property Type: BOOL</summary>
        D2D1_TABLETRANSFER_PROP_BLUE_DISABLE = 5,

        /// <summary>Property Name: "AlphaTable" Property Type: (blob)</summary>
        D2D1_TABLETRANSFER_PROP_ALPHA_TABLE = 6,

        /// <summary>Property Name: "AlphaDisable" Property Type: BOOL</summary>
        D2D1_TABLETRANSFER_PROP_ALPHA_DISABLE = 7,

        /// <summary>Property Name: "ClampOutput" Property Type: BOOL</summary>
        D2D1_TABLETRANSFER_PROP_CLAMP_OUTPUT = 8,

        D2D1_TABLETRANSFER_PROP_FORCE_DWORD = 0xFFFFFFFF
    }
}
