// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.calls.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='PhoneCallHistoryEntryQueryDesiredMedia.xml' path='doc/member[@name="PhoneCallHistoryEntryQueryDesiredMedia"]/*' />
[NativeTypeName("unsigned int")]
public enum PhoneCallHistoryEntryQueryDesiredMedia : uint
{
    /// <include file='PhoneCallHistoryEntryQueryDesiredMedia.xml' path='doc/member[@name="PhoneCallHistoryEntryQueryDesiredMedia.PhoneCallHistoryEntryQueryDesiredMedia_None"]/*' />
    PhoneCallHistoryEntryQueryDesiredMedia_None = 0,

    /// <include file='PhoneCallHistoryEntryQueryDesiredMedia.xml' path='doc/member[@name="PhoneCallHistoryEntryQueryDesiredMedia.PhoneCallHistoryEntryQueryDesiredMedia_Audio"]/*' />
    PhoneCallHistoryEntryQueryDesiredMedia_Audio = 0x1,

    /// <include file='PhoneCallHistoryEntryQueryDesiredMedia.xml' path='doc/member[@name="PhoneCallHistoryEntryQueryDesiredMedia.PhoneCallHistoryEntryQueryDesiredMedia_Video"]/*' />
    PhoneCallHistoryEntryQueryDesiredMedia_Video = 0x2,

    /// <include file='PhoneCallHistoryEntryQueryDesiredMedia.xml' path='doc/member[@name="PhoneCallHistoryEntryQueryDesiredMedia.PhoneCallHistoryEntryQueryDesiredMedia_All"]/*' />
    PhoneCallHistoryEntryQueryDesiredMedia_All = 0xffffffff,
}
