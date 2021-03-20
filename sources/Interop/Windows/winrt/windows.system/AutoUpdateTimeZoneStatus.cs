// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.system.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum AutoUpdateTimeZoneStatus
    {
        AutoUpdateTimeZoneStatus_Attempted = 0,
        AutoUpdateTimeZoneStatus_TimedOut = 1,
        AutoUpdateTimeZoneStatus_Failed = 2,
    }
}
