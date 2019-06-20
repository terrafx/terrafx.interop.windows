// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d2d1effectauthor.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    /// <summary>Describes how a vertex buffer is to be managed.</summary>
    public enum D2D1_VERTEX_USAGE : uint
    {
        /// <summary>The vertex buffer content do not change frequently from frame to frame.</summary>
        D2D1_VERTEX_USAGE_STATIC = 0,

        /// <summary>The vertex buffer is intended to be updated frequently.</summary>
        D2D1_VERTEX_USAGE_DYNAMIC = 1,

        D2D1_VERTEX_USAGE_FORCE_DWORD = 0xFFFFFFFF
    }
}
