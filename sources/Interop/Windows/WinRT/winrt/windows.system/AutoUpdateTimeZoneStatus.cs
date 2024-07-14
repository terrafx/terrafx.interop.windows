// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.system.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='AutoUpdateTimeZoneStatus.xml' path='doc/member[@name="AutoUpdateTimeZoneStatus"]/*' />
public enum AutoUpdateTimeZoneStatus
{
    /// <include file='AutoUpdateTimeZoneStatus.xml' path='doc/member[@name="AutoUpdateTimeZoneStatus.AutoUpdateTimeZoneStatus_Attempted"]/*' />
    AutoUpdateTimeZoneStatus_Attempted = 0,

    /// <include file='AutoUpdateTimeZoneStatus.xml' path='doc/member[@name="AutoUpdateTimeZoneStatus.AutoUpdateTimeZoneStatus_TimedOut"]/*' />
    AutoUpdateTimeZoneStatus_TimedOut = 1,

    /// <include file='AutoUpdateTimeZoneStatus.xml' path='doc/member[@name="AutoUpdateTimeZoneStatus.AutoUpdateTimeZoneStatus_Failed"]/*' />
    AutoUpdateTimeZoneStatus_Failed = 2,
}
