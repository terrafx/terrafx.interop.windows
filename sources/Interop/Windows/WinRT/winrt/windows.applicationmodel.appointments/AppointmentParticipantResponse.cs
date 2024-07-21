// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.appointments.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='AppointmentParticipantResponse.xml' path='doc/member[@name="AppointmentParticipantResponse"]/*' />
public enum AppointmentParticipantResponse
{
    /// <include file='AppointmentParticipantResponse.xml' path='doc/member[@name="AppointmentParticipantResponse.AppointmentParticipantResponse_None"]/*' />
    AppointmentParticipantResponse_None = 0,

    /// <include file='AppointmentParticipantResponse.xml' path='doc/member[@name="AppointmentParticipantResponse.AppointmentParticipantResponse_Tentative"]/*' />
    AppointmentParticipantResponse_Tentative = 1,

    /// <include file='AppointmentParticipantResponse.xml' path='doc/member[@name="AppointmentParticipantResponse.AppointmentParticipantResponse_Accepted"]/*' />
    AppointmentParticipantResponse_Accepted = 2,

    /// <include file='AppointmentParticipantResponse.xml' path='doc/member[@name="AppointmentParticipantResponse.AppointmentParticipantResponse_Declined"]/*' />
    AppointmentParticipantResponse_Declined = 3,

    /// <include file='AppointmentParticipantResponse.xml' path='doc/member[@name="AppointmentParticipantResponse.AppointmentParticipantResponse_Unknown"]/*' />
    AppointmentParticipantResponse_Unknown = 4,
}
