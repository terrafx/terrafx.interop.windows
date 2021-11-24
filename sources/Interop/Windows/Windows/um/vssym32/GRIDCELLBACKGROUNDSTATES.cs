// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/vssym32.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public enum GRIDCELLBACKGROUNDSTATES
{
    MCGCB_SELECTED = 1,
    MCGCB_HOT = 2,
    MCGCB_SELECTEDHOT = 3,
    MCGCB_SELECTEDNOTFOCUSED = 4,
    MCGCB_TODAY = 5,
    MCGCB_TODAYSELECTED = 6,
}
