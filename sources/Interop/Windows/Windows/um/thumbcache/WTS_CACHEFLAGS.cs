// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/thumbcache.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public enum WTS_CACHEFLAGS
{
    WTS_DEFAULT = 0,
    WTS_LOWQUALITY = 0x1,
    WTS_CACHED = 0x2,
}
