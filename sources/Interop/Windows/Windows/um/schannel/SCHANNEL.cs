// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/schannel.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop.Windows;

public static partial class SCHANNEL
{
    /// <include file='SCHANNEL.xml' path='doc/member[@name="SCHANNEL.SCHANNEL_NAME_A"]/*' />
    [NativeTypeName("#define SCHANNEL_NAME_A \"Schannel\"")]
    public static ReadOnlySpan<byte> SCHANNEL_NAME_A => "Schannel"u8;

    /// <include file='SCHANNEL.xml' path='doc/member[@name="SCHANNEL.SCHANNEL_NAME_W"]/*' />
    [NativeTypeName("#define SCHANNEL_NAME_W L\"Schannel\"")]
    public const string SCHANNEL_NAME_W = "Schannel";

    /// <include file='SCHANNEL.xml' path='doc/member[@name="SCHANNEL.SCHANNEL_NAME"]/*' />
    [NativeTypeName("#define SCHANNEL_NAME SCHANNEL_NAME_W")]
    public const string SCHANNEL_NAME = "Schannel";

    /// <include file='SCHANNEL.xml' path='doc/member[@name="SCHANNEL.SCHANNEL_CRED_VERSION"]/*' />
    [NativeTypeName("#define SCHANNEL_CRED_VERSION 0x00000004")]
    public const int SCHANNEL_CRED_VERSION = 0x00000004;

    /// <include file='SCHANNEL.xml' path='doc/member[@name="SCHANNEL.SCHANNEL_RENEGOTIATE"]/*' />
    [NativeTypeName("#define SCHANNEL_RENEGOTIATE 0")]
    public const int SCHANNEL_RENEGOTIATE = 0;

    /// <include file='SCHANNEL.xml' path='doc/member[@name="SCHANNEL.SCHANNEL_SHUTDOWN"]/*' />
    [NativeTypeName("#define SCHANNEL_SHUTDOWN 1")]
    public const int SCHANNEL_SHUTDOWN = 1;

    /// <include file='SCHANNEL.xml' path='doc/member[@name="SCHANNEL.SCHANNEL_ALERT"]/*' />
    [NativeTypeName("#define SCHANNEL_ALERT 2")]
    public const int SCHANNEL_ALERT = 2;

    /// <include file='SCHANNEL.xml' path='doc/member[@name="SCHANNEL.SCHANNEL_SESSION"]/*' />
    [NativeTypeName("#define SCHANNEL_SESSION 3")]
    public const int SCHANNEL_SESSION = 3;

    /// <include file='SCHANNEL.xml' path='doc/member[@name="SCHANNEL.SCHANNEL_SECRET_TYPE_CAPI"]/*' />
    [NativeTypeName("#define SCHANNEL_SECRET_TYPE_CAPI 0x00000001")]
    public const int SCHANNEL_SECRET_TYPE_CAPI = 0x00000001;

    /// <include file='SCHANNEL.xml' path='doc/member[@name="SCHANNEL.SCHANNEL_SECRET_PRIVKEY"]/*' />
    [NativeTypeName("#define SCHANNEL_SECRET_PRIVKEY 0x00000002")]
    public const int SCHANNEL_SECRET_PRIVKEY = 0x00000002;
}
