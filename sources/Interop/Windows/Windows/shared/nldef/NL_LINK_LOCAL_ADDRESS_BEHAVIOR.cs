// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/nldef.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public enum NL_LINK_LOCAL_ADDRESS_BEHAVIOR
{
    LinkLocalAlwaysOff = 0,
    LinkLocalDelayed,
    LinkLocalAlwaysOn,
    LinkLocalUnchanged = -1,
}
