// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/vssym32.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum TRAILINGGRIDCELLSTATES
    {
        MCTGC_HOT = 1,
        MCTGC_HASSTATE = 2,
        MCTGC_HASSTATEHOT = 3,
        MCTGC_TODAY = 4,
        MCTGC_TODAYSELECTED = 5,
        MCTGC_SELECTED = 6,
        MCTGC_SELECTEDHOT = 7,
    }
}
