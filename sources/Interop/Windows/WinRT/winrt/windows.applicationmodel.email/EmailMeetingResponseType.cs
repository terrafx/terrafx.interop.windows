// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.email.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='EmailMeetingResponseType.xml' path='doc/member[@name="EmailMeetingResponseType"]/*' />
public enum EmailMeetingResponseType
{
    /// <include file='EmailMeetingResponseType.xml' path='doc/member[@name="EmailMeetingResponseType.EmailMeetingResponseType_Accept"]/*' />
    EmailMeetingResponseType_Accept = 0,

    /// <include file='EmailMeetingResponseType.xml' path='doc/member[@name="EmailMeetingResponseType.EmailMeetingResponseType_Decline"]/*' />
    EmailMeetingResponseType_Decline = 1,

    /// <include file='EmailMeetingResponseType.xml' path='doc/member[@name="EmailMeetingResponseType.EmailMeetingResponseType_Tentative"]/*' />
    EmailMeetingResponseType_Tentative = 2,
}
