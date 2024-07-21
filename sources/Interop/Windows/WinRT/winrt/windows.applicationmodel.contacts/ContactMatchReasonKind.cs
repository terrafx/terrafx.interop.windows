// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.contacts.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='ContactMatchReasonKind.xml' path='doc/member[@name="ContactMatchReasonKind"]/*' />
public enum ContactMatchReasonKind
{
    /// <include file='ContactMatchReasonKind.xml' path='doc/member[@name="ContactMatchReasonKind.ContactMatchReasonKind_Name"]/*' />
    ContactMatchReasonKind_Name = 0,

    /// <include file='ContactMatchReasonKind.xml' path='doc/member[@name="ContactMatchReasonKind.ContactMatchReasonKind_EmailAddress"]/*' />
    ContactMatchReasonKind_EmailAddress = 1,

    /// <include file='ContactMatchReasonKind.xml' path='doc/member[@name="ContactMatchReasonKind.ContactMatchReasonKind_PhoneNumber"]/*' />
    ContactMatchReasonKind_PhoneNumber = 2,

    /// <include file='ContactMatchReasonKind.xml' path='doc/member[@name="ContactMatchReasonKind.ContactMatchReasonKind_JobInfo"]/*' />
    ContactMatchReasonKind_JobInfo = 3,

    /// <include file='ContactMatchReasonKind.xml' path='doc/member[@name="ContactMatchReasonKind.ContactMatchReasonKind_YomiName"]/*' />
    ContactMatchReasonKind_YomiName = 4,

    /// <include file='ContactMatchReasonKind.xml' path='doc/member[@name="ContactMatchReasonKind.ContactMatchReasonKind_Other"]/*' />
    ContactMatchReasonKind_Other = 5,
}
