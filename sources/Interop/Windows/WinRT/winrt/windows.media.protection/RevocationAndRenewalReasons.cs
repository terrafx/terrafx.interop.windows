// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.protection.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='RevocationAndRenewalReasons.xml' path='doc/member[@name="RevocationAndRenewalReasons"]/*' />
[NativeTypeName("unsigned int")]
public enum RevocationAndRenewalReasons : uint
{
    /// <include file='RevocationAndRenewalReasons.xml' path='doc/member[@name="RevocationAndRenewalReasons.RevocationAndRenewalReasons_UserModeComponentLoad"]/*' />
    RevocationAndRenewalReasons_UserModeComponentLoad = 0x1,

    /// <include file='RevocationAndRenewalReasons.xml' path='doc/member[@name="RevocationAndRenewalReasons.RevocationAndRenewalReasons_KernelModeComponentLoad"]/*' />
    RevocationAndRenewalReasons_KernelModeComponentLoad = 0x2,

    /// <include file='RevocationAndRenewalReasons.xml' path='doc/member[@name="RevocationAndRenewalReasons.RevocationAndRenewalReasons_AppComponent"]/*' />
    RevocationAndRenewalReasons_AppComponent = 0x4,

    /// <include file='RevocationAndRenewalReasons.xml' path='doc/member[@name="RevocationAndRenewalReasons.RevocationAndRenewalReasons_GlobalRevocationListLoadFailed"]/*' />
    RevocationAndRenewalReasons_GlobalRevocationListLoadFailed = 0x10,

    /// <include file='RevocationAndRenewalReasons.xml' path='doc/member[@name="RevocationAndRenewalReasons.RevocationAndRenewalReasons_InvalidGlobalRevocationListSignature"]/*' />
    RevocationAndRenewalReasons_InvalidGlobalRevocationListSignature = 0x20,

    /// <include file='RevocationAndRenewalReasons.xml' path='doc/member[@name="RevocationAndRenewalReasons.RevocationAndRenewalReasons_GlobalRevocationListAbsent"]/*' />
    RevocationAndRenewalReasons_GlobalRevocationListAbsent = 0x1000,

    /// <include file='RevocationAndRenewalReasons.xml' path='doc/member[@name="RevocationAndRenewalReasons.RevocationAndRenewalReasons_ComponentRevoked"]/*' />
    RevocationAndRenewalReasons_ComponentRevoked = 0x2000,

    /// <include file='RevocationAndRenewalReasons.xml' path='doc/member[@name="RevocationAndRenewalReasons.RevocationAndRenewalReasons_InvalidComponentCertificateExtendedKeyUse"]/*' />
    RevocationAndRenewalReasons_InvalidComponentCertificateExtendedKeyUse = 0x4000,

    /// <include file='RevocationAndRenewalReasons.xml' path='doc/member[@name="RevocationAndRenewalReasons.RevocationAndRenewalReasons_ComponentCertificateRevoked"]/*' />
    RevocationAndRenewalReasons_ComponentCertificateRevoked = 0x8000,

    /// <include file='RevocationAndRenewalReasons.xml' path='doc/member[@name="RevocationAndRenewalReasons.RevocationAndRenewalReasons_InvalidComponentCertificateRoot"]/*' />
    RevocationAndRenewalReasons_InvalidComponentCertificateRoot = 0x10000,

    /// <include file='RevocationAndRenewalReasons.xml' path='doc/member[@name="RevocationAndRenewalReasons.RevocationAndRenewalReasons_ComponentHighSecurityCertificateRevoked"]/*' />
    RevocationAndRenewalReasons_ComponentHighSecurityCertificateRevoked = 0x20000,

    /// <include file='RevocationAndRenewalReasons.xml' path='doc/member[@name="RevocationAndRenewalReasons.RevocationAndRenewalReasons_ComponentLowSecurityCertificateRevoked"]/*' />
    RevocationAndRenewalReasons_ComponentLowSecurityCertificateRevoked = 0x40000,

    /// <include file='RevocationAndRenewalReasons.xml' path='doc/member[@name="RevocationAndRenewalReasons.RevocationAndRenewalReasons_BootDriverVerificationFailed"]/*' />
    RevocationAndRenewalReasons_BootDriverVerificationFailed = 0x100000,

    /// <include file='RevocationAndRenewalReasons.xml' path='doc/member[@name="RevocationAndRenewalReasons.RevocationAndRenewalReasons_ComponentSignedWithTestCertificate"]/*' />
    RevocationAndRenewalReasons_ComponentSignedWithTestCertificate = 0x1000000,

    /// <include file='RevocationAndRenewalReasons.xml' path='doc/member[@name="RevocationAndRenewalReasons.RevocationAndRenewalReasons_EncryptionFailure"]/*' />
    RevocationAndRenewalReasons_EncryptionFailure = 0x10000000,
}
