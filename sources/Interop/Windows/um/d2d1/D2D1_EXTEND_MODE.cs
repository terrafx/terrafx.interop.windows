// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d2d1.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    /// <summary>Enum which describes how to sample from a source outside its base tile.</summary>
    public enum D2D1_EXTEND_MODE : uint
    {
        /// <summary>Extend the edges of the source out by clamping sample points outside the source to the edges.</summary>
        D2D1_EXTEND_MODE_CLAMP = 0,

        /// <summary>The base tile is drawn untransformed and the remainder are filled by repeating the base tile.</summary>
        D2D1_EXTEND_MODE_WRAP = 1,

        /// <summary>The same as wrap, but alternate tiles are flipped  The base tile is drawn untransformed.</summary>
        D2D1_EXTEND_MODE_MIRROR = 2,

        D2D1_EXTEND_MODE_FORCE_DWORD = 0xFFFFFFFF
    }
}
