// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/InteractionContext.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows;

[SupportedOSPlatform("windows8.0")]
public enum INERTIA_PARAMETER
{
    INERTIA_PARAMETER_TRANSLATION_DECELERATION = 0x00000001,
    INERTIA_PARAMETER_TRANSLATION_DISPLACEMENT = 0x00000002,
    INERTIA_PARAMETER_ROTATION_DECELERATION = 0x00000003,
    INERTIA_PARAMETER_ROTATION_ANGLE = 0x00000004,
    INERTIA_PARAMETER_EXPANSION_DECELERATION = 0x00000005,
    INERTIA_PARAMETER_EXPANSION_EXPANSION = 0x00000006,
    INERTIA_PARAMETER_MAX = unchecked((int)(0xffffffff)),
}
