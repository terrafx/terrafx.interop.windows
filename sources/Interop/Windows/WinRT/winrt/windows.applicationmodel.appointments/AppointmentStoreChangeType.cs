// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.appointments.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='AppointmentStoreChangeType.xml' path='doc/member[@name="AppointmentStoreChangeType"]/*' />
public enum AppointmentStoreChangeType
{
    /// <include file='AppointmentStoreChangeType.xml' path='doc/member[@name="AppointmentStoreChangeType.AppointmentStoreChangeType_AppointmentCreated"]/*' />
    AppointmentStoreChangeType_AppointmentCreated = 0,

    /// <include file='AppointmentStoreChangeType.xml' path='doc/member[@name="AppointmentStoreChangeType.AppointmentStoreChangeType_AppointmentModified"]/*' />
    AppointmentStoreChangeType_AppointmentModified = 1,

    /// <include file='AppointmentStoreChangeType.xml' path='doc/member[@name="AppointmentStoreChangeType.AppointmentStoreChangeType_AppointmentDeleted"]/*' />
    AppointmentStoreChangeType_AppointmentDeleted = 2,

    /// <include file='AppointmentStoreChangeType.xml' path='doc/member[@name="AppointmentStoreChangeType.AppointmentStoreChangeType_ChangeTrackingLost"]/*' />
    AppointmentStoreChangeType_ChangeTrackingLost = 3,

    /// <include file='AppointmentStoreChangeType.xml' path='doc/member[@name="AppointmentStoreChangeType.AppointmentStoreChangeType_CalendarCreated"]/*' />
    AppointmentStoreChangeType_CalendarCreated = 4,

    /// <include file='AppointmentStoreChangeType.xml' path='doc/member[@name="AppointmentStoreChangeType.AppointmentStoreChangeType_CalendarModified"]/*' />
    AppointmentStoreChangeType_CalendarModified = 5,

    /// <include file='AppointmentStoreChangeType.xml' path='doc/member[@name="AppointmentStoreChangeType.AppointmentStoreChangeType_CalendarDeleted"]/*' />
    AppointmentStoreChangeType_CalendarDeleted = 6,
}
