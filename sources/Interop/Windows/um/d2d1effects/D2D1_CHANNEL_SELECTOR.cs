// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1effects.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum D2D1_CHANNEL_SELECTOR : uint
    {
        D2D1_CHANNEL_SELECTOR_R = 0,
        D2D1_CHANNEL_SELECTOR_G = 1,
        D2D1_CHANNEL_SELECTOR_B = 2,
        D2D1_CHANNEL_SELECTOR_A = 3,
        D2D1_CHANNEL_SELECTOR_FORCE_DWORD = 0xffffffff,
    }
}
