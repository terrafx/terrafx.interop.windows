// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1effects.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum D2D1_LINEARTRANSFER_PROP : uint
    {
        D2D1_LINEARTRANSFER_PROP_RED_Y_INTERCEPT = 0,
        D2D1_LINEARTRANSFER_PROP_RED_SLOPE = 1,
        D2D1_LINEARTRANSFER_PROP_RED_DISABLE = 2,
        D2D1_LINEARTRANSFER_PROP_GREEN_Y_INTERCEPT = 3,
        D2D1_LINEARTRANSFER_PROP_GREEN_SLOPE = 4,
        D2D1_LINEARTRANSFER_PROP_GREEN_DISABLE = 5,
        D2D1_LINEARTRANSFER_PROP_BLUE_Y_INTERCEPT = 6,
        D2D1_LINEARTRANSFER_PROP_BLUE_SLOPE = 7,
        D2D1_LINEARTRANSFER_PROP_BLUE_DISABLE = 8,
        D2D1_LINEARTRANSFER_PROP_ALPHA_Y_INTERCEPT = 9,
        D2D1_LINEARTRANSFER_PROP_ALPHA_SLOPE = 10,
        D2D1_LINEARTRANSFER_PROP_ALPHA_DISABLE = 11,
        D2D1_LINEARTRANSFER_PROP_CLAMP_OUTPUT = 12,
        D2D1_LINEARTRANSFER_PROP_FORCE_DWORD = 0xffffffff,
    }
}
