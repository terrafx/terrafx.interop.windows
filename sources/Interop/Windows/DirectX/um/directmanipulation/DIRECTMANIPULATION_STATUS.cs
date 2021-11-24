// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/directmanipulation.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;

namespace TerraFX.Interop.DirectX;

[SupportedOSPlatform("windows8.0")]
public enum DIRECTMANIPULATION_STATUS
{
    DIRECTMANIPULATION_BUILDING = 0,
    DIRECTMANIPULATION_ENABLED = 1,
    DIRECTMANIPULATION_DISABLED = 2,
    DIRECTMANIPULATION_RUNNING = 3,
    DIRECTMANIPULATION_INERTIA = 4,
    DIRECTMANIPULATION_READY = 5,
    DIRECTMANIPULATION_SUSPENDED = 6,
}
