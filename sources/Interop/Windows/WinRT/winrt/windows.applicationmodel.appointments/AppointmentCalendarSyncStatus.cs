// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.appointments.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='AppointmentCalendarSyncStatus.xml' path='doc/member[@name="AppointmentCalendarSyncStatus"]/*' />
public enum AppointmentCalendarSyncStatus
{
    /// <include file='AppointmentCalendarSyncStatus.xml' path='doc/member[@name="AppointmentCalendarSyncStatus.AppointmentCalendarSyncStatus_Idle"]/*' />
    AppointmentCalendarSyncStatus_Idle = 0,

    /// <include file='AppointmentCalendarSyncStatus.xml' path='doc/member[@name="AppointmentCalendarSyncStatus.AppointmentCalendarSyncStatus_Syncing"]/*' />
    AppointmentCalendarSyncStatus_Syncing = 1,

    /// <include file='AppointmentCalendarSyncStatus.xml' path='doc/member[@name="AppointmentCalendarSyncStatus.AppointmentCalendarSyncStatus_UpToDate"]/*' />
    AppointmentCalendarSyncStatus_UpToDate = 2,

    /// <include file='AppointmentCalendarSyncStatus.xml' path='doc/member[@name="AppointmentCalendarSyncStatus.AppointmentCalendarSyncStatus_AuthenticationError"]/*' />
    AppointmentCalendarSyncStatus_AuthenticationError = 3,

    /// <include file='AppointmentCalendarSyncStatus.xml' path='doc/member[@name="AppointmentCalendarSyncStatus.AppointmentCalendarSyncStatus_PolicyError"]/*' />
    AppointmentCalendarSyncStatus_PolicyError = 4,

    /// <include file='AppointmentCalendarSyncStatus.xml' path='doc/member[@name="AppointmentCalendarSyncStatus.AppointmentCalendarSyncStatus_UnknownError"]/*' />
    AppointmentCalendarSyncStatus_UnknownError = 5,

    /// <include file='AppointmentCalendarSyncStatus.xml' path='doc/member[@name="AppointmentCalendarSyncStatus.AppointmentCalendarSyncStatus_ManualAccountRemovalRequired"]/*' />
    AppointmentCalendarSyncStatus_ManualAccountRemovalRequired = 6,
}
