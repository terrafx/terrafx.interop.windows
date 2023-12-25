// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.sensors.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='ActivityType.xml' path='doc/member[@name="ActivityType"]/*' />
public enum ActivityType
{
    /// <include file='ActivityType.xml' path='doc/member[@name="ActivityType.ActivityType_Unknown"]/*' />
    ActivityType_Unknown = 0,

    /// <include file='ActivityType.xml' path='doc/member[@name="ActivityType.ActivityType_Idle"]/*' />
    ActivityType_Idle = 1,

    /// <include file='ActivityType.xml' path='doc/member[@name="ActivityType.ActivityType_Stationary"]/*' />
    ActivityType_Stationary = 2,

    /// <include file='ActivityType.xml' path='doc/member[@name="ActivityType.ActivityType_Fidgeting"]/*' />
    ActivityType_Fidgeting = 3,

    /// <include file='ActivityType.xml' path='doc/member[@name="ActivityType.ActivityType_Walking"]/*' />
    ActivityType_Walking = 4,

    /// <include file='ActivityType.xml' path='doc/member[@name="ActivityType.ActivityType_Running"]/*' />
    ActivityType_Running = 5,

    /// <include file='ActivityType.xml' path='doc/member[@name="ActivityType.ActivityType_InVehicle"]/*' />
    ActivityType_InVehicle = 6,

    /// <include file='ActivityType.xml' path='doc/member[@name="ActivityType.ActivityType_Biking"]/*' />
    ActivityType_Biking = 7,
}
