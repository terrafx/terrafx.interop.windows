// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d2d1effectauthor.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    /// <summary>Indicates options for drawing using a pixel shader.</summary>
    [Flags]
    public enum D2D1_PIXEL_OPTIONS : uint
    {
        /// <summary>Default pixel processing.</summary>
        D2D1_PIXEL_OPTIONS_NONE = 0,

        /// <summary>Indicates that the shader samples its inputs only at exactly the same scene coordinate as the output pixel, and that it returns transparent black whenever the input pixels are also transparent black.</summary>
        D2D1_PIXEL_OPTIONS_TRIVIAL_SAMPLING = 1,

        D2D1_PIXEL_OPTIONS_FORCE_DWORD = 0xFFFFFFFF
    }
}
