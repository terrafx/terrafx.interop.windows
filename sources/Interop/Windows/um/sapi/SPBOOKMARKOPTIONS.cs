// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum SPBOOKMARKOPTIONS
    {
        SPBO_NONE = 0,
        SPBO_PAUSE = (1 << 0),
        SPBO_AHEAD = (1 << 1),
        SPBO_TIME_UNITS = (1 << 2),
    }
}
