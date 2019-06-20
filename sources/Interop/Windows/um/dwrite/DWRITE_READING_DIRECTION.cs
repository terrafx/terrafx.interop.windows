// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\dwrite.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    /// <summary>Direction for how reading progresses.</summary>
    public enum DWRITE_READING_DIRECTION
    {
        /// <summary>Reading progresses from left to right.</summary>
        DWRITE_READING_DIRECTION_LEFT_TO_RIGHT = 0,

        /// <summary>Reading progresses from right to left.</summary>
        DWRITE_READING_DIRECTION_RIGHT_TO_LEFT = 1,

        /// <summary>Reading progresses from top to bottom.</summary>
        DWRITE_READING_DIRECTION_TOP_TO_BOTTOM = 2,

        /// <summary>Reading progresses from bottom to top.</summary>
        DWRITE_READING_DIRECTION_BOTTOM_TO_TOP = 3,
    }
}
