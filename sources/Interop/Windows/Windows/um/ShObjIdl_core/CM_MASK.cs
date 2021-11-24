// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop.Windows;

[Flags]
public enum CM_MASK
{
    CM_MASK_WIDTH = 0x1,
    CM_MASK_DEFAULTWIDTH = 0x2,
    CM_MASK_IDEALWIDTH = 0x4,
    CM_MASK_NAME = 0x8,
    CM_MASK_STATE = 0x10,
}
