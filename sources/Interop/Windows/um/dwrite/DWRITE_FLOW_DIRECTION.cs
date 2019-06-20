// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\dwrite.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    /// <summary>Direction for how lines of text are placed relative to one another.</summary>
    public enum DWRITE_FLOW_DIRECTION
    {
        /// <summary>Text lines are placed from top to bottom.</summary>
        DWRITE_FLOW_DIRECTION_TOP_TO_BOTTOM = 0,

        /// <summary>Text lines are placed from bottom to top.</summary>
        DWRITE_FLOW_DIRECTION_BOTTOM_TO_TOP = 1,

        /// <summary>Text lines are placed from left to right.</summary>
        DWRITE_FLOW_DIRECTION_LEFT_TO_RIGHT = 2,

        /// <summary>Text lines are placed from right to left.</summary>
        DWRITE_FLOW_DIRECTION_RIGHT_TO_LEFT = 3,
    }
}
