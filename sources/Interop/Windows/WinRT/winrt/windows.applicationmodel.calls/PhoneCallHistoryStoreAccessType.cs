// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.calls.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='PhoneCallHistoryStoreAccessType.xml' path='doc/member[@name="PhoneCallHistoryStoreAccessType"]/*' />
public enum PhoneCallHistoryStoreAccessType
{
    /// <include file='PhoneCallHistoryStoreAccessType.xml' path='doc/member[@name="PhoneCallHistoryStoreAccessType.PhoneCallHistoryStoreAccessType_AppEntriesReadWrite"]/*' />
    PhoneCallHistoryStoreAccessType_AppEntriesReadWrite = 0,

    /// <include file='PhoneCallHistoryStoreAccessType.xml' path='doc/member[@name="PhoneCallHistoryStoreAccessType.PhoneCallHistoryStoreAccessType_AllEntriesLimitedReadWrite"]/*' />
    PhoneCallHistoryStoreAccessType_AllEntriesLimitedReadWrite = 1,

    /// <include file='PhoneCallHistoryStoreAccessType.xml' path='doc/member[@name="PhoneCallHistoryStoreAccessType.PhoneCallHistoryStoreAccessType_AllEntriesReadWrite"]/*' />
    PhoneCallHistoryStoreAccessType_AllEntriesReadWrite = 2,
}
