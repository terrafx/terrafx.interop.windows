// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/schannel.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class SSL
{
    /// <include file='SSL.xml' path='doc/member[@name="SSL.SSL_SESSION_RECONNECT"]/*' />
    [NativeTypeName("#define SSL_SESSION_RECONNECT 1")]
    public const int SSL_SESSION_RECONNECT = 1;

    /// <include file='SSL.xml' path='doc/member[@name="SSL.SSL_SESSION_ENABLE_RECONNECTS"]/*' />
    [NativeTypeName("#define SSL_SESSION_ENABLE_RECONNECTS 1")]
    public const int SSL_SESSION_ENABLE_RECONNECTS = 1;

    /// <include file='SSL.xml' path='doc/member[@name="SSL.SSL_SESSION_DISABLE_RECONNECTS"]/*' />
    [NativeTypeName("#define SSL_SESSION_DISABLE_RECONNECTS 2")]
    public const int SSL_SESSION_DISABLE_RECONNECTS = 2;

    /// <include file='SSL.xml' path='doc/member[@name="SSL.SSL_CRACK_CERTIFICATE_NAME"]/*' />
    [NativeTypeName("#define SSL_CRACK_CERTIFICATE_NAME TEXT(\"SslCrackCertificate\")")]
    public const string SSL_CRACK_CERTIFICATE_NAME = "SslCrackCertificate";

    /// <include file='SSL.xml' path='doc/member[@name="SSL.SSL_FREE_CERTIFICATE_NAME"]/*' />
    [NativeTypeName("#define SSL_FREE_CERTIFICATE_NAME TEXT(\"SslFreeCertificate\")")]
    public const string SSL_FREE_CERTIFICATE_NAME = "SslFreeCertificate";
}
