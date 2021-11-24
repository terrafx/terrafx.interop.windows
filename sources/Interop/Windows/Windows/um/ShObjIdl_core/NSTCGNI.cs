// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public enum NSTCGNI
{
    NSTCGNI_NEXT = 0,
    NSTCGNI_NEXTVISIBLE = 1,
    NSTCGNI_PREV = 2,
    NSTCGNI_PREVVISIBLE = 3,
    NSTCGNI_PARENT = 4,
    NSTCGNI_CHILD = 5,
    NSTCGNI_FIRSTVISIBLE = 6,
    NSTCGNI_LASTVISIBLE = 7,
}
