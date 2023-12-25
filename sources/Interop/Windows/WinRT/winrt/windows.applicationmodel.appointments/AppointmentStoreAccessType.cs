// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.appointments.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='AppointmentStoreAccessType.xml' path='doc/member[@name="AppointmentStoreAccessType"]/*' />
public enum AppointmentStoreAccessType
{
    /// <include file='AppointmentStoreAccessType.xml' path='doc/member[@name="AppointmentStoreAccessType.AppointmentStoreAccessType_AppCalendarsReadWrite"]/*' />
    AppointmentStoreAccessType_AppCalendarsReadWrite = 0,

    /// <include file='AppointmentStoreAccessType.xml' path='doc/member[@name="AppointmentStoreAccessType.AppointmentStoreAccessType_AllCalendarsReadOnly"]/*' />
    AppointmentStoreAccessType_AllCalendarsReadOnly = 1,

    /// <include file='AppointmentStoreAccessType.xml' path='doc/member[@name="AppointmentStoreAccessType.AppointmentStoreAccessType_AllCalendarsReadWrite"]/*' />
    AppointmentStoreAccessType_AllCalendarsReadWrite = 2,
}
