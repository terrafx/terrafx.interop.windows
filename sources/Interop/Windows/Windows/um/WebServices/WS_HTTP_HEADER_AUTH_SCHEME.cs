// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class WS_HTTP_HEADER_AUTH_SCHEME
{
    /// <include file='WS_HTTP_HEADER_AUTH_SCHEME.xml' path='doc/member[@name="WS_HTTP_HEADER_AUTH_SCHEME.WS_HTTP_HEADER_AUTH_SCHEME_NONE"]/*' />
    public const int WS_HTTP_HEADER_AUTH_SCHEME_NONE = 0x1;
    /// <include file='WS_HTTP_HEADER_AUTH_SCHEME.xml' path='doc/member[@name="WS_HTTP_HEADER_AUTH_SCHEME.WS_HTTP_HEADER_AUTH_SCHEME_BASIC"]/*' />
    public const int WS_HTTP_HEADER_AUTH_SCHEME_BASIC = 0x2;
    /// <include file='WS_HTTP_HEADER_AUTH_SCHEME.xml' path='doc/member[@name="WS_HTTP_HEADER_AUTH_SCHEME.WS_HTTP_HEADER_AUTH_SCHEME_DIGEST"]/*' />
    public const int WS_HTTP_HEADER_AUTH_SCHEME_DIGEST = 0x4;
    /// <include file='WS_HTTP_HEADER_AUTH_SCHEME.xml' path='doc/member[@name="WS_HTTP_HEADER_AUTH_SCHEME.WS_HTTP_HEADER_AUTH_SCHEME_NTLM"]/*' />
    public const int WS_HTTP_HEADER_AUTH_SCHEME_NTLM = 0x8;
    /// <include file='WS_HTTP_HEADER_AUTH_SCHEME.xml' path='doc/member[@name="WS_HTTP_HEADER_AUTH_SCHEME.WS_HTTP_HEADER_AUTH_SCHEME_NEGOTIATE"]/*' />
    public const int WS_HTTP_HEADER_AUTH_SCHEME_NEGOTIATE = 0x10;
    /// <include file='WS_HTTP_HEADER_AUTH_SCHEME.xml' path='doc/member[@name="WS_HTTP_HEADER_AUTH_SCHEME.WS_HTTP_HEADER_AUTH_SCHEME_PASSPORT"]/*' />
    public const int WS_HTTP_HEADER_AUTH_SCHEME_PASSPORT = 0x20;
}
