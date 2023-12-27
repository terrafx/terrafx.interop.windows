// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.email.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='EmailCertificateValidationStatus.xml' path='doc/member[@name="EmailCertificateValidationStatus"]/*' />
public enum EmailCertificateValidationStatus
{
    /// <include file='EmailCertificateValidationStatus.xml' path='doc/member[@name="EmailCertificateValidationStatus.EmailCertificateValidationStatus_Success"]/*' />
    EmailCertificateValidationStatus_Success = 0,

    /// <include file='EmailCertificateValidationStatus.xml' path='doc/member[@name="EmailCertificateValidationStatus.EmailCertificateValidationStatus_NoMatch"]/*' />
    EmailCertificateValidationStatus_NoMatch = 1,

    /// <include file='EmailCertificateValidationStatus.xml' path='doc/member[@name="EmailCertificateValidationStatus.EmailCertificateValidationStatus_InvalidUsage"]/*' />
    EmailCertificateValidationStatus_InvalidUsage = 2,

    /// <include file='EmailCertificateValidationStatus.xml' path='doc/member[@name="EmailCertificateValidationStatus.EmailCertificateValidationStatus_InvalidCertificate"]/*' />
    EmailCertificateValidationStatus_InvalidCertificate = 3,

    /// <include file='EmailCertificateValidationStatus.xml' path='doc/member[@name="EmailCertificateValidationStatus.EmailCertificateValidationStatus_Revoked"]/*' />
    EmailCertificateValidationStatus_Revoked = 4,

    /// <include file='EmailCertificateValidationStatus.xml' path='doc/member[@name="EmailCertificateValidationStatus.EmailCertificateValidationStatus_ChainRevoked"]/*' />
    EmailCertificateValidationStatus_ChainRevoked = 5,

    /// <include file='EmailCertificateValidationStatus.xml' path='doc/member[@name="EmailCertificateValidationStatus.EmailCertificateValidationStatus_RevocationServerFailure"]/*' />
    EmailCertificateValidationStatus_RevocationServerFailure = 6,

    /// <include file='EmailCertificateValidationStatus.xml' path='doc/member[@name="EmailCertificateValidationStatus.EmailCertificateValidationStatus_Expired"]/*' />
    EmailCertificateValidationStatus_Expired = 7,

    /// <include file='EmailCertificateValidationStatus.xml' path='doc/member[@name="EmailCertificateValidationStatus.EmailCertificateValidationStatus_Untrusted"]/*' />
    EmailCertificateValidationStatus_Untrusted = 8,

    /// <include file='EmailCertificateValidationStatus.xml' path='doc/member[@name="EmailCertificateValidationStatus.EmailCertificateValidationStatus_ServerError"]/*' />
    EmailCertificateValidationStatus_ServerError = 9,

    /// <include file='EmailCertificateValidationStatus.xml' path='doc/member[@name="EmailCertificateValidationStatus.EmailCertificateValidationStatus_UnknownFailure"]/*' />
    EmailCertificateValidationStatus_UnknownFailure = 10,
}
