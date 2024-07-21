// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.email.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='EmailMessageDownloadState.xml' path='doc/member[@name="EmailMessageDownloadState"]/*' />
public enum EmailMessageDownloadState
{
    /// <include file='EmailMessageDownloadState.xml' path='doc/member[@name="EmailMessageDownloadState.EmailMessageDownloadState_PartiallyDownloaded"]/*' />
    EmailMessageDownloadState_PartiallyDownloaded = 0,

    /// <include file='EmailMessageDownloadState.xml' path='doc/member[@name="EmailMessageDownloadState.EmailMessageDownloadState_Downloading"]/*' />
    EmailMessageDownloadState_Downloading = 1,

    /// <include file='EmailMessageDownloadState.xml' path='doc/member[@name="EmailMessageDownloadState.EmailMessageDownloadState_Downloaded"]/*' />
    EmailMessageDownloadState_Downloaded = 2,

    /// <include file='EmailMessageDownloadState.xml' path='doc/member[@name="EmailMessageDownloadState.EmailMessageDownloadState_Failed"]/*' />
    EmailMessageDownloadState_Failed = 3,
}
