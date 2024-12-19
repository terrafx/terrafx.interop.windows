// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/http.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='HTTP_REQUEST_AUTH_TYPE.xml' path='doc/member[@name="HTTP_REQUEST_AUTH_TYPE"]/*' />
public enum HTTP_REQUEST_AUTH_TYPE
{
    /// <include file='HTTP_REQUEST_AUTH_TYPE.xml' path='doc/member[@name="HTTP_REQUEST_AUTH_TYPE.HttpRequestAuthTypeNone"]/*' />
    HttpRequestAuthTypeNone = 0,

    /// <include file='HTTP_REQUEST_AUTH_TYPE.xml' path='doc/member[@name="HTTP_REQUEST_AUTH_TYPE.HttpRequestAuthTypeBasic"]/*' />
    HttpRequestAuthTypeBasic,

    /// <include file='HTTP_REQUEST_AUTH_TYPE.xml' path='doc/member[@name="HTTP_REQUEST_AUTH_TYPE.HttpRequestAuthTypeDigest"]/*' />
    HttpRequestAuthTypeDigest,

    /// <include file='HTTP_REQUEST_AUTH_TYPE.xml' path='doc/member[@name="HTTP_REQUEST_AUTH_TYPE.HttpRequestAuthTypeNTLM"]/*' />
    HttpRequestAuthTypeNTLM,

    /// <include file='HTTP_REQUEST_AUTH_TYPE.xml' path='doc/member[@name="HTTP_REQUEST_AUTH_TYPE.HttpRequestAuthTypeNegotiate"]/*' />
    HttpRequestAuthTypeNegotiate,

    /// <include file='HTTP_REQUEST_AUTH_TYPE.xml' path='doc/member[@name="HTTP_REQUEST_AUTH_TYPE.HttpRequestAuthTypeKerberos"]/*' />
    HttpRequestAuthTypeKerberos,
}
