// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/http.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='HTTP_SERVER_AUTHENTICATION_BASIC_PARAMS.xml' path='doc/member[@name="HTTP_SERVER_AUTHENTICATION_BASIC_PARAMS"]/*' />
public unsafe partial struct HTTP_SERVER_AUTHENTICATION_BASIC_PARAMS
{
    /// <include file='HTTP_SERVER_AUTHENTICATION_BASIC_PARAMS.xml' path='doc/member[@name="HTTP_SERVER_AUTHENTICATION_BASIC_PARAMS.RealmLength"]/*' />
    public ushort RealmLength;

    /// <include file='HTTP_SERVER_AUTHENTICATION_BASIC_PARAMS.xml' path='doc/member[@name="HTTP_SERVER_AUTHENTICATION_BASIC_PARAMS.Realm"]/*' />
    [NativeTypeName("PWSTR")]
    public char* Realm;
}
