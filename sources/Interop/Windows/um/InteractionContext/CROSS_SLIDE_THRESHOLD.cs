// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/InteractionContext.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;

namespace TerraFX.Interop
{
    [SupportedOSPlatform("windows8.0")]
    public enum CROSS_SLIDE_THRESHOLD
    {
        CROSS_SLIDE_THRESHOLD_SELECT_START = 0x00000000,
        CROSS_SLIDE_THRESHOLD_SPEED_BUMP_START = 0x00000001,
        CROSS_SLIDE_THRESHOLD_SPEED_BUMP_END = 0x00000002,
        CROSS_SLIDE_THRESHOLD_REARRANGE_START = 0x00000003,
        CROSS_SLIDE_THRESHOLD_COUNT = 0x00000004,
        CROSS_SLIDE_THRESHOLD_MAX = unchecked((int)(0xffffffff)),
    }
}
