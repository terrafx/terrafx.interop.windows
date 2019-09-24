// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d2d1.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    /// <summary>Enum which describes the manner in which we render edges of non-text primitives.</summary>
    public enum D2D1_ANTIALIAS_MODE : uint
    {
        /// <summary>The edges of each primitive are antialiased sequentially.</summary>
        D2D1_ANTIALIAS_MODE_PER_PRIMITIVE = 0,

        /// <summary>Each pixel is rendered if its pixel center is contained by the geometry.</summary>
        D2D1_ANTIALIAS_MODE_ALIASED = 1,

        D2D1_ANTIALIAS_MODE_FORCE_DWORD = 0xFFFFFFFF
    }
}
