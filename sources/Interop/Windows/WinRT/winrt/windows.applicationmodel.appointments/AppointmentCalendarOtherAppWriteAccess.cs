// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.appointments.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='AppointmentCalendarOtherAppWriteAccess.xml' path='doc/member[@name="AppointmentCalendarOtherAppWriteAccess"]/*' />
public enum AppointmentCalendarOtherAppWriteAccess
{
    /// <include file='AppointmentCalendarOtherAppWriteAccess.xml' path='doc/member[@name="AppointmentCalendarOtherAppWriteAccess.AppointmentCalendarOtherAppWriteAccess_None"]/*' />
    AppointmentCalendarOtherAppWriteAccess_None = 0,

    /// <include file='AppointmentCalendarOtherAppWriteAccess.xml' path='doc/member[@name="AppointmentCalendarOtherAppWriteAccess.AppointmentCalendarOtherAppWriteAccess_SystemOnly"]/*' />
    AppointmentCalendarOtherAppWriteAccess_SystemOnly = 1,

    /// <include file='AppointmentCalendarOtherAppWriteAccess.xml' path='doc/member[@name="AppointmentCalendarOtherAppWriteAccess.AppointmentCalendarOtherAppWriteAccess_Limited"]/*' />
    AppointmentCalendarOtherAppWriteAccess_Limited = 2,
}
