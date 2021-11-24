// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public enum ASSOCIATIONLEVEL
{
    AL_MACHINE = 0,
    AL_EFFECTIVE = (AL_MACHINE + 1),
    AL_USER = (AL_EFFECTIVE + 1),
}
