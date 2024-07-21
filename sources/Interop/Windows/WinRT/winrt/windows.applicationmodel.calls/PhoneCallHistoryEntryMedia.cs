// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.calls.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='PhoneCallHistoryEntryMedia.xml' path='doc/member[@name="PhoneCallHistoryEntryMedia"]/*' />
public enum PhoneCallHistoryEntryMedia
{
    /// <include file='PhoneCallHistoryEntryMedia.xml' path='doc/member[@name="PhoneCallHistoryEntryMedia.PhoneCallHistoryEntryMedia_Audio"]/*' />
    PhoneCallHistoryEntryMedia_Audio = 0,

    /// <include file='PhoneCallHistoryEntryMedia.xml' path='doc/member[@name="PhoneCallHistoryEntryMedia.PhoneCallHistoryEntryMedia_Video"]/*' />
    PhoneCallHistoryEntryMedia_Video = 1,
}
