// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/thumbcache.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum WTS_CONTEXTFLAGS
    {
        WTSCF_DEFAULT = 0,
        WTSCF_APPSTYLE = 0x1,
        WTSCF_SQUARE = 0x2,
        WTSCF_WIDE = 0x4,
        WTSCF_FAST = 0x8,
    }
}
