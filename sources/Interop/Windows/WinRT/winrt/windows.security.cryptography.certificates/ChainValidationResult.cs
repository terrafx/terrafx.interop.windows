// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.security.cryptography.certificates.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='ChainValidationResult.xml' path='doc/member[@name="ChainValidationResult"]/*' />
public enum ChainValidationResult
{
    /// <include file='ChainValidationResult.xml' path='doc/member[@name="ChainValidationResult.ChainValidationResult_Success"]/*' />
    ChainValidationResult_Success = 0,

    /// <include file='ChainValidationResult.xml' path='doc/member[@name="ChainValidationResult.ChainValidationResult_Untrusted"]/*' />
    ChainValidationResult_Untrusted = 1,

    /// <include file='ChainValidationResult.xml' path='doc/member[@name="ChainValidationResult.ChainValidationResult_Revoked"]/*' />
    ChainValidationResult_Revoked = 2,

    /// <include file='ChainValidationResult.xml' path='doc/member[@name="ChainValidationResult.ChainValidationResult_Expired"]/*' />
    ChainValidationResult_Expired = 3,

    /// <include file='ChainValidationResult.xml' path='doc/member[@name="ChainValidationResult.ChainValidationResult_IncompleteChain"]/*' />
    ChainValidationResult_IncompleteChain = 4,

    /// <include file='ChainValidationResult.xml' path='doc/member[@name="ChainValidationResult.ChainValidationResult_InvalidSignature"]/*' />
    ChainValidationResult_InvalidSignature = 5,

    /// <include file='ChainValidationResult.xml' path='doc/member[@name="ChainValidationResult.ChainValidationResult_WrongUsage"]/*' />
    ChainValidationResult_WrongUsage = 6,

    /// <include file='ChainValidationResult.xml' path='doc/member[@name="ChainValidationResult.ChainValidationResult_InvalidName"]/*' />
    ChainValidationResult_InvalidName = 7,

    /// <include file='ChainValidationResult.xml' path='doc/member[@name="ChainValidationResult.ChainValidationResult_InvalidCertificateAuthorityPolicy"]/*' />
    ChainValidationResult_InvalidCertificateAuthorityPolicy = 8,

    /// <include file='ChainValidationResult.xml' path='doc/member[@name="ChainValidationResult.ChainValidationResult_BasicConstraintsError"]/*' />
    ChainValidationResult_BasicConstraintsError = 9,

    /// <include file='ChainValidationResult.xml' path='doc/member[@name="ChainValidationResult.ChainValidationResult_UnknownCriticalExtension"]/*' />
    ChainValidationResult_UnknownCriticalExtension = 10,

    /// <include file='ChainValidationResult.xml' path='doc/member[@name="ChainValidationResult.ChainValidationResult_RevocationInformationMissing"]/*' />
    ChainValidationResult_RevocationInformationMissing = 11,

    /// <include file='ChainValidationResult.xml' path='doc/member[@name="ChainValidationResult.ChainValidationResult_RevocationFailure"]/*' />
    ChainValidationResult_RevocationFailure = 12,

    /// <include file='ChainValidationResult.xml' path='doc/member[@name="ChainValidationResult.ChainValidationResult_OtherErrors"]/*' />
    ChainValidationResult_OtherErrors = 13,
}
