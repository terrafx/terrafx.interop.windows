// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1_3.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum D2D1_PATCH_EDGE_MODE : uint
    {
        D2D1_PATCH_EDGE_MODE_ALIASED = 0,
        D2D1_PATCH_EDGE_MODE_ANTIALIASED = 1,
        D2D1_PATCH_EDGE_MODE_ALIASED_INFLATED = 2,
        D2D1_PATCH_EDGE_MODE_FORCE_DWORD = 0xffffffff,
    }
}
