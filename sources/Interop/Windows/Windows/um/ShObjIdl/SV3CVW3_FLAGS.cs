// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop.Windows;

[Flags]
public enum SV3CVW3_FLAGS
{
    SV3CVW3_DEFAULT = 0,
    SV3CVW3_NONINTERACTIVE = 0x1,
    SV3CVW3_FORCEVIEWMODE = 0x2,
    SV3CVW3_FORCEFOLDERFLAGS = 0x4,
}
