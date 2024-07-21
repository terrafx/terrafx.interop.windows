// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.appointments.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='FindAppointmentCalendarsOptions.xml' path='doc/member[@name="FindAppointmentCalendarsOptions"]/*' />
[NativeTypeName("unsigned int")]
public enum FindAppointmentCalendarsOptions : uint
{
    /// <include file='FindAppointmentCalendarsOptions.xml' path='doc/member[@name="FindAppointmentCalendarsOptions.FindAppointmentCalendarsOptions_None"]/*' />
    FindAppointmentCalendarsOptions_None = 0,

    /// <include file='FindAppointmentCalendarsOptions.xml' path='doc/member[@name="FindAppointmentCalendarsOptions.FindAppointmentCalendarsOptions_IncludeHidden"]/*' />
    FindAppointmentCalendarsOptions_IncludeHidden = 0x1,
}
