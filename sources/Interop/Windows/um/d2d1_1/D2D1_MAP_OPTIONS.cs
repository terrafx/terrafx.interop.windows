// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d2d1_1.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    /// <summary>This describes how the individual mapping operation should be performed.</summary>
    [Flags]
    public enum D2D1_MAP_OPTIONS : uint
    {
        /// <summary>The mapped pointer has undefined behavior.</summary>
        D2D1_MAP_OPTIONS_NONE = 0,

        /// <summary>The mapped pointer can be read from.</summary>
        D2D1_MAP_OPTIONS_READ = 1,

        /// <summary>The mapped pointer can be written to.</summary>
        D2D1_MAP_OPTIONS_WRITE = 2,

        /// <summary>The previous contents of the bitmap are discarded when it is mapped.</summary>
        D2D1_MAP_OPTIONS_DISCARD = 4,

        D2D1_MAP_OPTIONS_FORCE_DWORD = 0xFFFFFFFF
    }
}
