// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.system.power.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='BatteryStatus.xml' path='doc/member[@name="BatteryStatus"]/*' />
public enum BatteryStatus
{
    /// <include file='BatteryStatus.xml' path='doc/member[@name="BatteryStatus.BatteryStatus_NotPresent"]/*' />
    BatteryStatus_NotPresent = 0,

    /// <include file='BatteryStatus.xml' path='doc/member[@name="BatteryStatus.BatteryStatus_Discharging"]/*' />
    BatteryStatus_Discharging = 1,

    /// <include file='BatteryStatus.xml' path='doc/member[@name="BatteryStatus.BatteryStatus_Idle"]/*' />
    BatteryStatus_Idle = 2,

    /// <include file='BatteryStatus.xml' path='doc/member[@name="BatteryStatus.BatteryStatus_Charging"]/*' />
    BatteryStatus_Charging = 3,
}
