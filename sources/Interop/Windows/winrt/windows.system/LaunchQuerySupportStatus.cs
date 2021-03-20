// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.system.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum LaunchQuerySupportStatus
    {
        LaunchQuerySupportStatus_Available = 0,
        LaunchQuerySupportStatus_AppNotInstalled = 1,
        LaunchQuerySupportStatus_AppUnavailable = 2,
        LaunchQuerySupportStatus_NotSupported = 3,
        LaunchQuerySupportStatus_Unknown = 4,
    }
}
