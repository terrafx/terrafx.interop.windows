// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.appointments.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='AppointmentParticipantRole.xml' path='doc/member[@name="AppointmentParticipantRole"]/*' />
public enum AppointmentParticipantRole
{
    /// <include file='AppointmentParticipantRole.xml' path='doc/member[@name="AppointmentParticipantRole.AppointmentParticipantRole_RequiredAttendee"]/*' />
    AppointmentParticipantRole_RequiredAttendee = 0,

    /// <include file='AppointmentParticipantRole.xml' path='doc/member[@name="AppointmentParticipantRole.AppointmentParticipantRole_OptionalAttendee"]/*' />
    AppointmentParticipantRole_OptionalAttendee = 1,

    /// <include file='AppointmentParticipantRole.xml' path='doc/member[@name="AppointmentParticipantRole.AppointmentParticipantRole_Resource"]/*' />
    AppointmentParticipantRole_Resource = 2,
}
