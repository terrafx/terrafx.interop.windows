// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.appointments.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='AppointmentCalendarOtherAppReadAccess.xml' path='doc/member[@name="AppointmentCalendarOtherAppReadAccess"]/*' />
public enum AppointmentCalendarOtherAppReadAccess
{
    /// <include file='AppointmentCalendarOtherAppReadAccess.xml' path='doc/member[@name="AppointmentCalendarOtherAppReadAccess.AppointmentCalendarOtherAppReadAccess_SystemOnly"]/*' />
    AppointmentCalendarOtherAppReadAccess_SystemOnly = 0,

    /// <include file='AppointmentCalendarOtherAppReadAccess.xml' path='doc/member[@name="AppointmentCalendarOtherAppReadAccess.AppointmentCalendarOtherAppReadAccess_Limited"]/*' />
    AppointmentCalendarOtherAppReadAccess_Limited = 1,

    /// <include file='AppointmentCalendarOtherAppReadAccess.xml' path='doc/member[@name="AppointmentCalendarOtherAppReadAccess.AppointmentCalendarOtherAppReadAccess_Full"]/*' />
    AppointmentCalendarOtherAppReadAccess_Full = 2,

    /// <include file='AppointmentCalendarOtherAppReadAccess.xml' path='doc/member[@name="AppointmentCalendarOtherAppReadAccess.AppointmentCalendarOtherAppReadAccess_None"]/*' />
    AppointmentCalendarOtherAppReadAccess_None = 3,
}
