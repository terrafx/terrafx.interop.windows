// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1effects.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

public enum D2D1_DISCRETETRANSFER_PROP : uint
{
    D2D1_DISCRETETRANSFER_PROP_RED_TABLE = 0,
    D2D1_DISCRETETRANSFER_PROP_RED_DISABLE = 1,
    D2D1_DISCRETETRANSFER_PROP_GREEN_TABLE = 2,
    D2D1_DISCRETETRANSFER_PROP_GREEN_DISABLE = 3,
    D2D1_DISCRETETRANSFER_PROP_BLUE_TABLE = 4,
    D2D1_DISCRETETRANSFER_PROP_BLUE_DISABLE = 5,
    D2D1_DISCRETETRANSFER_PROP_ALPHA_TABLE = 6,
    D2D1_DISCRETETRANSFER_PROP_ALPHA_DISABLE = 7,
    D2D1_DISCRETETRANSFER_PROP_CLAMP_OUTPUT = 8,
    D2D1_DISCRETETRANSFER_PROP_FORCE_DWORD = 0xffffffff,
}
