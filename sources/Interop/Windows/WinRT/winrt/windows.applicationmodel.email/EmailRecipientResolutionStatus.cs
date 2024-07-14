// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.email.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='EmailRecipientResolutionStatus.xml' path='doc/member[@name="EmailRecipientResolutionStatus"]/*' />
public enum EmailRecipientResolutionStatus
{
    /// <include file='EmailRecipientResolutionStatus.xml' path='doc/member[@name="EmailRecipientResolutionStatus.EmailRecipientResolutionStatus_Success"]/*' />
    EmailRecipientResolutionStatus_Success = 0,

    /// <include file='EmailRecipientResolutionStatus.xml' path='doc/member[@name="EmailRecipientResolutionStatus.EmailRecipientResolutionStatus_RecipientNotFound"]/*' />
    EmailRecipientResolutionStatus_RecipientNotFound = 1,

    /// <include file='EmailRecipientResolutionStatus.xml' path='doc/member[@name="EmailRecipientResolutionStatus.EmailRecipientResolutionStatus_AmbiguousRecipient"]/*' />
    EmailRecipientResolutionStatus_AmbiguousRecipient = 2,

    /// <include file='EmailRecipientResolutionStatus.xml' path='doc/member[@name="EmailRecipientResolutionStatus.EmailRecipientResolutionStatus_NoCertificate"]/*' />
    EmailRecipientResolutionStatus_NoCertificate = 3,

    /// <include file='EmailRecipientResolutionStatus.xml' path='doc/member[@name="EmailRecipientResolutionStatus.EmailRecipientResolutionStatus_CertificateRequestLimitReached"]/*' />
    EmailRecipientResolutionStatus_CertificateRequestLimitReached = 4,

    /// <include file='EmailRecipientResolutionStatus.xml' path='doc/member[@name="EmailRecipientResolutionStatus.EmailRecipientResolutionStatus_CannotResolveDistributionList"]/*' />
    EmailRecipientResolutionStatus_CannotResolveDistributionList = 5,

    /// <include file='EmailRecipientResolutionStatus.xml' path='doc/member[@name="EmailRecipientResolutionStatus.EmailRecipientResolutionStatus_ServerError"]/*' />
    EmailRecipientResolutionStatus_ServerError = 6,

    /// <include file='EmailRecipientResolutionStatus.xml' path='doc/member[@name="EmailRecipientResolutionStatus.EmailRecipientResolutionStatus_UnknownFailure"]/*' />
    EmailRecipientResolutionStatus_UnknownFailure = 7,
}
