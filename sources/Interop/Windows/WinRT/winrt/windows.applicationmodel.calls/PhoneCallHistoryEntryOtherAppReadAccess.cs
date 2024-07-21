// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.calls.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='PhoneCallHistoryEntryOtherAppReadAccess.xml' path='doc/member[@name="PhoneCallHistoryEntryOtherAppReadAccess"]/*' />
public enum PhoneCallHistoryEntryOtherAppReadAccess
{
    /// <include file='PhoneCallHistoryEntryOtherAppReadAccess.xml' path='doc/member[@name="PhoneCallHistoryEntryOtherAppReadAccess.PhoneCallHistoryEntryOtherAppReadAccess_Full"]/*' />
    PhoneCallHistoryEntryOtherAppReadAccess_Full = 0,

    /// <include file='PhoneCallHistoryEntryOtherAppReadAccess.xml' path='doc/member[@name="PhoneCallHistoryEntryOtherAppReadAccess.PhoneCallHistoryEntryOtherAppReadAccess_SystemOnly"]/*' />
    PhoneCallHistoryEntryOtherAppReadAccess_SystemOnly = 1,
}
