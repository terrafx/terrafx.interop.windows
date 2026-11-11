// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winhttp.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class INTERNET
{
    /// <include file='INTERNET.xml' path='doc/member[@name="INTERNET.INTERNET_DEFAULT_PORT"]/*' />
    [NativeTypeName("#define INTERNET_DEFAULT_PORT 0")]
    public const int INTERNET_DEFAULT_PORT = 0;

    /// <include file='INTERNET.xml' path='doc/member[@name="INTERNET.INTERNET_DEFAULT_HTTP_PORT"]/*' />
    [NativeTypeName("#define INTERNET_DEFAULT_HTTP_PORT 80")]
    public const int INTERNET_DEFAULT_HTTP_PORT = 80;

    /// <include file='INTERNET.xml' path='doc/member[@name="INTERNET.INTERNET_DEFAULT_HTTPS_PORT"]/*' />
    [NativeTypeName("#define INTERNET_DEFAULT_HTTPS_PORT 443")]
    public const int INTERNET_DEFAULT_HTTPS_PORT = 443;

    /// <include file='INTERNET.xml' path='doc/member[@name="INTERNET.INTERNET_SCHEME_HTTP"]/*' />
    [NativeTypeName("#define INTERNET_SCHEME_HTTP (1)")]
    public const int INTERNET_SCHEME_HTTP = (1);

    /// <include file='INTERNET.xml' path='doc/member[@name="INTERNET.INTERNET_SCHEME_HTTPS"]/*' />
    [NativeTypeName("#define INTERNET_SCHEME_HTTPS (2)")]
    public const int INTERNET_SCHEME_HTTPS = (2);

    /// <include file='INTERNET.xml' path='doc/member[@name="INTERNET.INTERNET_SCHEME_FTP"]/*' />
    [NativeTypeName("#define INTERNET_SCHEME_FTP (3)")]
    public const int INTERNET_SCHEME_FTP = (3);

    /// <include file='INTERNET.xml' path='doc/member[@name="INTERNET.INTERNET_SCHEME_SOCKS"]/*' />
    [NativeTypeName("#define INTERNET_SCHEME_SOCKS (4)")]
    public const int INTERNET_SCHEME_SOCKS = (4);
}
