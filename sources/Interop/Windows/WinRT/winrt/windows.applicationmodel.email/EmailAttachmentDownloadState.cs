// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.email.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='EmailAttachmentDownloadState.xml' path='doc/member[@name="EmailAttachmentDownloadState"]/*' />
public enum EmailAttachmentDownloadState
{
    /// <include file='EmailAttachmentDownloadState.xml' path='doc/member[@name="EmailAttachmentDownloadState.EmailAttachmentDownloadState_NotDownloaded"]/*' />
    EmailAttachmentDownloadState_NotDownloaded = 0,

    /// <include file='EmailAttachmentDownloadState.xml' path='doc/member[@name="EmailAttachmentDownloadState.EmailAttachmentDownloadState_Downloading"]/*' />
    EmailAttachmentDownloadState_Downloading = 1,

    /// <include file='EmailAttachmentDownloadState.xml' path='doc/member[@name="EmailAttachmentDownloadState.EmailAttachmentDownloadState_Downloaded"]/*' />
    EmailAttachmentDownloadState_Downloaded = 2,

    /// <include file='EmailAttachmentDownloadState.xml' path='doc/member[@name="EmailAttachmentDownloadState.EmailAttachmentDownloadState_Failed"]/*' />
    EmailAttachmentDownloadState_Failed = 3,
}
