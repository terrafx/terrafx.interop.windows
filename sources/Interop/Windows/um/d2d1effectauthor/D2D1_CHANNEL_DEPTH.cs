// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1effectauthor.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum D2D1_CHANNEL_DEPTH : uint
    {
        D2D1_CHANNEL_DEPTH_DEFAULT = 0,
        D2D1_CHANNEL_DEPTH_1 = 1,
        D2D1_CHANNEL_DEPTH_4 = 4,
        D2D1_CHANNEL_DEPTH_FORCE_DWORD = 0xffffffff,
    }
}
