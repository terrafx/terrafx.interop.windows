// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d2d1_3.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    /// <summary>Specifies how to render gradient mesh edges.</summary>
    public enum D2D1_PATCH_EDGE_MODE : uint
    {
        /// <summary>Render this edge aliased.</summary>
        D2D1_PATCH_EDGE_MODE_ALIASED = 0,

        /// <summary>Render this edge antialiased.</summary>
        D2D1_PATCH_EDGE_MODE_ANTIALIASED = 1,

        /// <summary>Render this edge aliased and inflated out slightly.</summary>
        D2D1_PATCH_EDGE_MODE_ALIASED_INFLATED = 2,

        D2D1_PATCH_EDGE_MODE_FORCE_DWORD = 0xFFFFFFFF
    }
}
