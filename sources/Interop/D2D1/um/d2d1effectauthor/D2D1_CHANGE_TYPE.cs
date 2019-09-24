// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d2d1effectauthor.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    /// <summary>Indicates what has changed since the last time the effect was asked to prepare to render.</summary>
    [Flags]
    public enum D2D1_CHANGE_TYPE : uint
    {
        /// <summary>Nothing has changed.</summary>
        D2D1_CHANGE_TYPE_NONE = 0,

        /// <summary>The effect's properties have changed.</summary>
        D2D1_CHANGE_TYPE_PROPERTIES = 1,

        /// <summary>The internal context has changed and should be inspected.</summary>
        D2D1_CHANGE_TYPE_CONTEXT = 2,

        /// <summary>A new graph has been set due to a change in the input count.</summary>
        D2D1_CHANGE_TYPE_GRAPH = 3,

        D2D1_CHANGE_TYPE_FORCE_DWORD = 0xFFFFFFFF
    }
}
