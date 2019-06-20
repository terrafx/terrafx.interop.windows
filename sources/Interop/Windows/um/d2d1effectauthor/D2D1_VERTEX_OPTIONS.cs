// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d2d1effectauthor.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    /// <summary>Indicates options for drawing custom vertices set by transforms.</summary>
    [Flags]
    public enum D2D1_VERTEX_OPTIONS : uint
    {
        /// <summary>Default vertex processing.</summary>
        D2D1_VERTEX_OPTIONS_NONE = 0,

        /// <summary>Indicates that the output rectangle does not need to be cleared before drawing custom vertices. This must only be used by transforms whose custom vertices completely cover their output rectangle.</summary>
        D2D1_VERTEX_OPTIONS_DO_NOT_CLEAR = 1,

        /// <summary>Causes a depth buffer to be used while drawing custom vertices. This impacts drawing behavior when primitives overlap one another.</summary>
        D2D1_VERTEX_OPTIONS_USE_DEPTH_BUFFER = 2,

        /// <summary>Indicates that custom vertices do not form primitives which overlap one another.</summary>
        D2D1_VERTEX_OPTIONS_ASSUME_NO_OVERLAP = 4,

        D2D1_VERTEX_OPTIONS_FORCE_DWORD = 0xFFFFFFFF
    }
}
