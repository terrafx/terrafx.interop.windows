// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1effectauthor.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum D2D1_VERTEX_USAGE : uint
    {
        D2D1_VERTEX_USAGE_STATIC = 0,
        D2D1_VERTEX_USAGE_DYNAMIC = 1,
        D2D1_VERTEX_USAGE_FORCE_DWORD = 0xffffffff,
    }
}
