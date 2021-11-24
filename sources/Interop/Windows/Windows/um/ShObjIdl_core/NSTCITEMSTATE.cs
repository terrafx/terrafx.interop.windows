// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop.Windows;

[Flags]
public enum NSTCITEMSTATE
{
    NSTCIS_NONE = 0,
    NSTCIS_SELECTED = 0x1,
    NSTCIS_EXPANDED = 0x2,
    NSTCIS_BOLD = 0x4,
    NSTCIS_DISABLED = 0x8,
    NSTCIS_SELECTEDNOEXPAND = 0x10,
}
