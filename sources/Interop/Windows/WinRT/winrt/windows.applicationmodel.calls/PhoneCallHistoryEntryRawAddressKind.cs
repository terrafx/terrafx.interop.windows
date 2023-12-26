// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.calls.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='PhoneCallHistoryEntryRawAddressKind.xml' path='doc/member[@name="PhoneCallHistoryEntryRawAddressKind"]/*' />
public enum PhoneCallHistoryEntryRawAddressKind
{
    /// <include file='PhoneCallHistoryEntryRawAddressKind.xml' path='doc/member[@name="PhoneCallHistoryEntryRawAddressKind.PhoneCallHistoryEntryRawAddressKind_PhoneNumber"]/*' />
    PhoneCallHistoryEntryRawAddressKind_PhoneNumber = 0,

    /// <include file='PhoneCallHistoryEntryRawAddressKind.xml' path='doc/member[@name="PhoneCallHistoryEntryRawAddressKind.PhoneCallHistoryEntryRawAddressKind_Custom"]/*' />
    PhoneCallHistoryEntryRawAddressKind_Custom = 1,
}
