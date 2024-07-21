// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.security.cryptography.core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='CryptographicPublicKeyBlobType.xml' path='doc/member[@name="CryptographicPublicKeyBlobType"]/*' />
public enum CryptographicPublicKeyBlobType
{
    /// <include file='CryptographicPublicKeyBlobType.xml' path='doc/member[@name="CryptographicPublicKeyBlobType.CryptographicPublicKeyBlobType_X509SubjectPublicKeyInfo"]/*' />
    CryptographicPublicKeyBlobType_X509SubjectPublicKeyInfo = 0,

    /// <include file='CryptographicPublicKeyBlobType.xml' path='doc/member[@name="CryptographicPublicKeyBlobType.CryptographicPublicKeyBlobType_Pkcs1RsaPublicKey"]/*' />
    CryptographicPublicKeyBlobType_Pkcs1RsaPublicKey = 1,

    /// <include file='CryptographicPublicKeyBlobType.xml' path='doc/member[@name="CryptographicPublicKeyBlobType.CryptographicPublicKeyBlobType_BCryptPublicKey"]/*' />
    CryptographicPublicKeyBlobType_BCryptPublicKey = 2,

    /// <include file='CryptographicPublicKeyBlobType.xml' path='doc/member[@name="CryptographicPublicKeyBlobType.CryptographicPublicKeyBlobType_Capi1PublicKey"]/*' />
    CryptographicPublicKeyBlobType_Capi1PublicKey = 3,

    /// <include file='CryptographicPublicKeyBlobType.xml' path='doc/member[@name="CryptographicPublicKeyBlobType.CryptographicPublicKeyBlobType_BCryptEccFullPublicKey"]/*' />
    CryptographicPublicKeyBlobType_BCryptEccFullPublicKey = 4,
}
