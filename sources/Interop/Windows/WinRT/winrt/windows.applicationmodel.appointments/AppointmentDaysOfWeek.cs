// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.appointments.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='AppointmentDaysOfWeek.xml' path='doc/member[@name="AppointmentDaysOfWeek"]/*' />
[NativeTypeName("unsigned int")]
public enum AppointmentDaysOfWeek : uint
{
    /// <include file='AppointmentDaysOfWeek.xml' path='doc/member[@name="AppointmentDaysOfWeek.AppointmentDaysOfWeek_None"]/*' />
    AppointmentDaysOfWeek_None = 0,

    /// <include file='AppointmentDaysOfWeek.xml' path='doc/member[@name="AppointmentDaysOfWeek.AppointmentDaysOfWeek_Sunday"]/*' />
    AppointmentDaysOfWeek_Sunday = 0x1,

    /// <include file='AppointmentDaysOfWeek.xml' path='doc/member[@name="AppointmentDaysOfWeek.AppointmentDaysOfWeek_Monday"]/*' />
    AppointmentDaysOfWeek_Monday = 0x2,

    /// <include file='AppointmentDaysOfWeek.xml' path='doc/member[@name="AppointmentDaysOfWeek.AppointmentDaysOfWeek_Tuesday"]/*' />
    AppointmentDaysOfWeek_Tuesday = 0x4,

    /// <include file='AppointmentDaysOfWeek.xml' path='doc/member[@name="AppointmentDaysOfWeek.AppointmentDaysOfWeek_Wednesday"]/*' />
    AppointmentDaysOfWeek_Wednesday = 0x8,

    /// <include file='AppointmentDaysOfWeek.xml' path='doc/member[@name="AppointmentDaysOfWeek.AppointmentDaysOfWeek_Thursday"]/*' />
    AppointmentDaysOfWeek_Thursday = 0x10,

    /// <include file='AppointmentDaysOfWeek.xml' path='doc/member[@name="AppointmentDaysOfWeek.AppointmentDaysOfWeek_Friday"]/*' />
    AppointmentDaysOfWeek_Friday = 0x20,

    /// <include file='AppointmentDaysOfWeek.xml' path='doc/member[@name="AppointmentDaysOfWeek.AppointmentDaysOfWeek_Saturday"]/*' />
    AppointmentDaysOfWeek_Saturday = 0x40,
}
