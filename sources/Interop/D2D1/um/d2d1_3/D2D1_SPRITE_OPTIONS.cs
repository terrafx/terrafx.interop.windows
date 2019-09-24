// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d2d1_3.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    [Flags]
    public enum D2D1_SPRITE_OPTIONS : uint
    {
        /// <summary>Use default sprite rendering behavior.</summary>
        D2D1_SPRITE_OPTIONS_NONE = 0,

        /// <summary>Bitmap interpolation will be clamped to the sprite's source rectangle.</summary>
        D2D1_SPRITE_OPTIONS_CLAMP_TO_SOURCE_RECTANGLE = 1,

        D2D1_SPRITE_OPTIONS_FORCE_DWORD = 0xFFFFFFFF
    }
}
