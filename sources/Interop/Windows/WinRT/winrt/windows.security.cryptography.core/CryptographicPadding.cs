// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.security.cryptography.core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='CryptographicPadding.xml' path='doc/member[@name="CryptographicPadding"]/*' />
public enum CryptographicPadding
{
    /// <include file='CryptographicPadding.xml' path='doc/member[@name="CryptographicPadding.CryptographicPadding_None"]/*' />
    CryptographicPadding_None = 0,

    /// <include file='CryptographicPadding.xml' path='doc/member[@name="CryptographicPadding.CryptographicPadding_RsaOaep"]/*' />
    CryptographicPadding_RsaOaep = 1,

    /// <include file='CryptographicPadding.xml' path='doc/member[@name="CryptographicPadding.CryptographicPadding_RsaPkcs1V15"]/*' />
    CryptographicPadding_RsaPkcs1V15 = 2,

    /// <include file='CryptographicPadding.xml' path='doc/member[@name="CryptographicPadding.CryptographicPadding_RsaPss"]/*' />
    CryptographicPadding_RsaPss = 3,
}
