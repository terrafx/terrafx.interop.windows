// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.security.cryptography.certificates.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='CertificateChainPolicy.xml' path='doc/member[@name="CertificateChainPolicy"]/*' />
public enum CertificateChainPolicy
{
    /// <include file='CertificateChainPolicy.xml' path='doc/member[@name="CertificateChainPolicy.CertificateChainPolicy_Base"]/*' />
    CertificateChainPolicy_Base = 0,

    /// <include file='CertificateChainPolicy.xml' path='doc/member[@name="CertificateChainPolicy.CertificateChainPolicy_Ssl"]/*' />
    CertificateChainPolicy_Ssl = 1,

    /// <include file='CertificateChainPolicy.xml' path='doc/member[@name="CertificateChainPolicy.CertificateChainPolicy_NTAuthentication"]/*' />
    CertificateChainPolicy_NTAuthentication = 2,

    /// <include file='CertificateChainPolicy.xml' path='doc/member[@name="CertificateChainPolicy.CertificateChainPolicy_MicrosoftRoot"]/*' />
    CertificateChainPolicy_MicrosoftRoot = 3,
}
