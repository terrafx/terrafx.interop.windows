// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/vssym32.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows
{
    public enum GRIDCELLUPPERSTATES
    {
        MCGCU_HOT = 1,
        MCGCU_HASSTATE = 2,
        MCGCU_HASSTATEHOT = 3,
        MCGCU_SELECTED = 4,
        MCGCU_SELECTEDHOT = 5,
    }
}
