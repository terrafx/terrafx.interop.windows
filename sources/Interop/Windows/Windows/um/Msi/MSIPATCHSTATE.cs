// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/Msi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public enum MSIPATCHSTATE
{
    MSIPATCHSTATE_INVALID = 0,
    MSIPATCHSTATE_APPLIED = 1,
    MSIPATCHSTATE_SUPERSEDED = 2,
    MSIPATCHSTATE_OBSOLETED = 4,
    MSIPATCHSTATE_REGISTERED = 8,
    MSIPATCHSTATE_ALL = (MSIPATCHSTATE_APPLIED | MSIPATCHSTATE_SUPERSEDED | MSIPATCHSTATE_OBSOLETED | MSIPATCHSTATE_REGISTERED),
}
