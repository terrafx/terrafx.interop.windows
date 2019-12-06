// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1effects.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    [NativeTypeName("int")]
    public enum D2D1_BORDER_EDGE_MODE : uint
    {
        D2D1_BORDER_EDGE_MODE_CLAMP = 0,
        D2D1_BORDER_EDGE_MODE_WRAP = 1,
        D2D1_BORDER_EDGE_MODE_MIRROR = 2,
        D2D1_BORDER_EDGE_MODE_FORCE_DWORD = 0xffffffff,
    }
}
