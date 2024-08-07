// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.calls.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='PhoneCallHistorySourceIdKind.xml' path='doc/member[@name="PhoneCallHistorySourceIdKind"]/*' />
public enum PhoneCallHistorySourceIdKind
{
    /// <include file='PhoneCallHistorySourceIdKind.xml' path='doc/member[@name="PhoneCallHistorySourceIdKind.PhoneCallHistorySourceIdKind_CellularPhoneLineId"]/*' />
    PhoneCallHistorySourceIdKind_CellularPhoneLineId = 0,

    /// <include file='PhoneCallHistorySourceIdKind.xml' path='doc/member[@name="PhoneCallHistorySourceIdKind.PhoneCallHistorySourceIdKind_PackageFamilyName"]/*' />
    PhoneCallHistorySourceIdKind_PackageFamilyName = 1,
}
