// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum CompressionCaps
    {
        CompressionCaps_CanQuality = 0x1,
        CompressionCaps_CanCrunch = 0x2,
        CompressionCaps_CanKeyFrame = 0x4,
        CompressionCaps_CanBFrame = 0x8,
        CompressionCaps_CanWindow = 0x10,
    }
}
