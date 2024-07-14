// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.security.cryptography.certificates.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='SignatureValidationResult.xml' path='doc/member[@name="SignatureValidationResult"]/*' />
public enum SignatureValidationResult
{
    /// <include file='SignatureValidationResult.xml' path='doc/member[@name="SignatureValidationResult.SignatureValidationResult_Success"]/*' />
    SignatureValidationResult_Success = 0,

    /// <include file='SignatureValidationResult.xml' path='doc/member[@name="SignatureValidationResult.SignatureValidationResult_InvalidParameter"]/*' />
    SignatureValidationResult_InvalidParameter = 1,

    /// <include file='SignatureValidationResult.xml' path='doc/member[@name="SignatureValidationResult.SignatureValidationResult_BadMessage"]/*' />
    SignatureValidationResult_BadMessage = 2,

    /// <include file='SignatureValidationResult.xml' path='doc/member[@name="SignatureValidationResult.SignatureValidationResult_InvalidSignature"]/*' />
    SignatureValidationResult_InvalidSignature = 3,

    /// <include file='SignatureValidationResult.xml' path='doc/member[@name="SignatureValidationResult.SignatureValidationResult_OtherErrors"]/*' />
    SignatureValidationResult_OtherErrors = 4,
}
