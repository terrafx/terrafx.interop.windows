// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class Windows
{
    public const int MAX_ZONE_PATH = 260;

    public const int MAX_ZONE_DESCRIPTION = 200;

    public static uint GetUrlPolicyPermissions(uint dw)
        => dw & (uint)URLPOLICY.URLPOLICY_MASK_PERMISSIONS;

    public static uint SetUrlPolicyPermissions(ref uint dw, uint dw2)
        => dw = (dw & ~(uint)URLPOLICY.URLPOLICY_MASK_PERMISSIONS) | dw2;
}
