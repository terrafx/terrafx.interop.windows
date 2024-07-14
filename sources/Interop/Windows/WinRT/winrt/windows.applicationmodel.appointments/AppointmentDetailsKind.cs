// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.appointments.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='AppointmentDetailsKind.xml' path='doc/member[@name="AppointmentDetailsKind"]/*' />
public enum AppointmentDetailsKind
{
    /// <include file='AppointmentDetailsKind.xml' path='doc/member[@name="AppointmentDetailsKind.AppointmentDetailsKind_PlainText"]/*' />
    AppointmentDetailsKind_PlainText = 0,

    /// <include file='AppointmentDetailsKind.xml' path='doc/member[@name="AppointmentDetailsKind.AppointmentDetailsKind_Html"]/*' />
    AppointmentDetailsKind_Html = 1,
}
