// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public enum POWER_PLATFORM_ROLE
{
    PlatformRoleUnspecified = 0,
    PlatformRoleDesktop,
    PlatformRoleMobile,
    PlatformRoleWorkstation,
    PlatformRoleEnterpriseServer,
    PlatformRoleSOHOServer,
    PlatformRoleAppliancePC,
    PlatformRolePerformanceServer,
    PlatformRoleSlate,
    PlatformRoleMaximum,
}
