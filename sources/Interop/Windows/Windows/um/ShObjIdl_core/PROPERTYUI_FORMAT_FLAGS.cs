// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop.Windows;

[Flags]
public enum PROPERTYUI_FORMAT_FLAGS
{
    PUIFFDF_DEFAULT = 0,
    PUIFFDF_RIGHTTOLEFT = 0x1,
    PUIFFDF_SHORTFORMAT = 0x2,
    PUIFFDF_NOTIME = 0x4,
    PUIFFDF_FRIENDLYDATE = 0x8,
}
