// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.appointments.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='AppointmentRecurrenceUnit.xml' path='doc/member[@name="AppointmentRecurrenceUnit"]/*' />
public enum AppointmentRecurrenceUnit
{
    /// <include file='AppointmentRecurrenceUnit.xml' path='doc/member[@name="AppointmentRecurrenceUnit.AppointmentRecurrenceUnit_Daily"]/*' />
    AppointmentRecurrenceUnit_Daily = 0,

    /// <include file='AppointmentRecurrenceUnit.xml' path='doc/member[@name="AppointmentRecurrenceUnit.AppointmentRecurrenceUnit_Weekly"]/*' />
    AppointmentRecurrenceUnit_Weekly = 1,

    /// <include file='AppointmentRecurrenceUnit.xml' path='doc/member[@name="AppointmentRecurrenceUnit.AppointmentRecurrenceUnit_Monthly"]/*' />
    AppointmentRecurrenceUnit_Monthly = 2,

    /// <include file='AppointmentRecurrenceUnit.xml' path='doc/member[@name="AppointmentRecurrenceUnit.AppointmentRecurrenceUnit_MonthlyOnDay"]/*' />
    AppointmentRecurrenceUnit_MonthlyOnDay = 3,

    /// <include file='AppointmentRecurrenceUnit.xml' path='doc/member[@name="AppointmentRecurrenceUnit.AppointmentRecurrenceUnit_Yearly"]/*' />
    AppointmentRecurrenceUnit_Yearly = 4,

    /// <include file='AppointmentRecurrenceUnit.xml' path='doc/member[@name="AppointmentRecurrenceUnit.AppointmentRecurrenceUnit_YearlyOnDay"]/*' />
    AppointmentRecurrenceUnit_YearlyOnDay = 5,
}
