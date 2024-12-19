// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/http.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='HTTP_SERVER_AUTHENTICATION_DIGEST_PARAMS.xml' path='doc/member[@name="HTTP_SERVER_AUTHENTICATION_DIGEST_PARAMS"]/*' />
public unsafe partial struct HTTP_SERVER_AUTHENTICATION_DIGEST_PARAMS
{
    /// <include file='HTTP_SERVER_AUTHENTICATION_DIGEST_PARAMS.xml' path='doc/member[@name="HTTP_SERVER_AUTHENTICATION_DIGEST_PARAMS.DomainNameLength"]/*' />
    public ushort DomainNameLength;

    /// <include file='HTTP_SERVER_AUTHENTICATION_DIGEST_PARAMS.xml' path='doc/member[@name="HTTP_SERVER_AUTHENTICATION_DIGEST_PARAMS.DomainName"]/*' />
    [NativeTypeName("PWSTR")]
    public char* DomainName;

    /// <include file='HTTP_SERVER_AUTHENTICATION_DIGEST_PARAMS.xml' path='doc/member[@name="HTTP_SERVER_AUTHENTICATION_DIGEST_PARAMS.RealmLength"]/*' />
    public ushort RealmLength;

    /// <include file='HTTP_SERVER_AUTHENTICATION_DIGEST_PARAMS.xml' path='doc/member[@name="HTTP_SERVER_AUTHENTICATION_DIGEST_PARAMS.Realm"]/*' />
    [NativeTypeName("PWSTR")]
    public char* Realm;
}
