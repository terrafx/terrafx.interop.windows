// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d2d1.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    /// <summary>Describes the antialiasing mode used for drawing text.</summary>
    public enum D2D1_TEXT_ANTIALIAS_MODE : uint
    {
        /// <summary>Render text using the current system setting.</summary>
        D2D1_TEXT_ANTIALIAS_MODE_DEFAULT = 0,

        /// <summary>Render text using ClearType.</summary>
        D2D1_TEXT_ANTIALIAS_MODE_CLEARTYPE = 1,

        /// <summary>Render text using gray-scale.</summary>
        D2D1_TEXT_ANTIALIAS_MODE_GRAYSCALE = 2,

        /// <summary>Render text aliased.</summary>
        D2D1_TEXT_ANTIALIAS_MODE_ALIASED = 3,

        D2D1_TEXT_ANTIALIAS_MODE_FORCE_DWORD = 0xFFFFFFFF
    }
}
