// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum sandboxAllow
    {
        sandboxAllowScripts = 0,
        sandboxAllowSameOrigin = 1,
        sandboxAllowTopNavigation = 2,
        sandboxAllowForms = 3,
        sandboxAllowPopups = 4,
        sandboxAllow_Max = 2147483647,
    }
}
