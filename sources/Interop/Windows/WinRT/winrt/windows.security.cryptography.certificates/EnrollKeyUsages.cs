// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.security.cryptography.certificates.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='EnrollKeyUsages.xml' path='doc/member[@name="EnrollKeyUsages"]/*' />
[NativeTypeName("unsigned int")]
public enum EnrollKeyUsages : uint
{
    /// <include file='EnrollKeyUsages.xml' path='doc/member[@name="EnrollKeyUsages.EnrollKeyUsages_None"]/*' />
    EnrollKeyUsages_None = 0,

    /// <include file='EnrollKeyUsages.xml' path='doc/member[@name="EnrollKeyUsages.EnrollKeyUsages_Decryption"]/*' />
    EnrollKeyUsages_Decryption = 0x1,

    /// <include file='EnrollKeyUsages.xml' path='doc/member[@name="EnrollKeyUsages.EnrollKeyUsages_Signing"]/*' />
    EnrollKeyUsages_Signing = 0x2,

    /// <include file='EnrollKeyUsages.xml' path='doc/member[@name="EnrollKeyUsages.EnrollKeyUsages_KeyAgreement"]/*' />
    EnrollKeyUsages_KeyAgreement = 0x4,

    /// <include file='EnrollKeyUsages.xml' path='doc/member[@name="EnrollKeyUsages.EnrollKeyUsages_All"]/*' />
    EnrollKeyUsages_All = 0xffffff,
}
