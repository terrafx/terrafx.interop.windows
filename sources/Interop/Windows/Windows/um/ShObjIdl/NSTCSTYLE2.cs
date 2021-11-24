// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public enum NSTCSTYLE2
{
    NSTCS2_DEFAULT = 0,
    NSTCS2_INTERRUPTNOTIFICATIONS = 0x1,
    NSTCS2_SHOWNULLSPACEMENU = 0x2,
    NSTCS2_DISPLAYPADDING = 0x4,
    NSTCS2_DISPLAYPINNEDONLY = 0x8,
    NTSCS2_NOSINGLETONAUTOEXPAND = 0x10,
    NTSCS2_NEVERINSERTNONENUMERATED = 0x20,
}
