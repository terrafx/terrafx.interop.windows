// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.appointments.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='AppointmentBusyStatus.xml' path='doc/member[@name="AppointmentBusyStatus"]/*' />
public enum AppointmentBusyStatus
{
    /// <include file='AppointmentBusyStatus.xml' path='doc/member[@name="AppointmentBusyStatus.AppointmentBusyStatus_Busy"]/*' />
    AppointmentBusyStatus_Busy = 0,

    /// <include file='AppointmentBusyStatus.xml' path='doc/member[@name="AppointmentBusyStatus.AppointmentBusyStatus_Tentative"]/*' />
    AppointmentBusyStatus_Tentative = 1,

    /// <include file='AppointmentBusyStatus.xml' path='doc/member[@name="AppointmentBusyStatus.AppointmentBusyStatus_Free"]/*' />
    AppointmentBusyStatus_Free = 2,

    /// <include file='AppointmentBusyStatus.xml' path='doc/member[@name="AppointmentBusyStatus.AppointmentBusyStatus_OutOfOffice"]/*' />
    AppointmentBusyStatus_OutOfOffice = 3,

    /// <include file='AppointmentBusyStatus.xml' path='doc/member[@name="AppointmentBusyStatus.AppointmentBusyStatus_WorkingElsewhere"]/*' />
    AppointmentBusyStatus_WorkingElsewhere = 4,
}
