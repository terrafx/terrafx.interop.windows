// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinBase.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class LOGON32
{
    /// <include file='LOGON32.xml' path='doc/member[@name="LOGON32.LOGON32_LOGON_INTERACTIVE"]/*' />
    [NativeTypeName("#define LOGON32_LOGON_INTERACTIVE 2")]
    public const int LOGON32_LOGON_INTERACTIVE = 2;

    /// <include file='LOGON32.xml' path='doc/member[@name="LOGON32.LOGON32_LOGON_NETWORK"]/*' />
    [NativeTypeName("#define LOGON32_LOGON_NETWORK 3")]
    public const int LOGON32_LOGON_NETWORK = 3;

    /// <include file='LOGON32.xml' path='doc/member[@name="LOGON32.LOGON32_LOGON_BATCH"]/*' />
    [NativeTypeName("#define LOGON32_LOGON_BATCH 4")]
    public const int LOGON32_LOGON_BATCH = 4;

    /// <include file='LOGON32.xml' path='doc/member[@name="LOGON32.LOGON32_LOGON_SERVICE"]/*' />
    [NativeTypeName("#define LOGON32_LOGON_SERVICE 5")]
    public const int LOGON32_LOGON_SERVICE = 5;

    /// <include file='LOGON32.xml' path='doc/member[@name="LOGON32.LOGON32_LOGON_UNLOCK"]/*' />
    [NativeTypeName("#define LOGON32_LOGON_UNLOCK 7")]
    public const int LOGON32_LOGON_UNLOCK = 7;

    /// <include file='LOGON32.xml' path='doc/member[@name="LOGON32.LOGON32_LOGON_NETWORK_CLEARTEXT"]/*' />
    [NativeTypeName("#define LOGON32_LOGON_NETWORK_CLEARTEXT 8")]
    public const int LOGON32_LOGON_NETWORK_CLEARTEXT = 8;

    /// <include file='LOGON32.xml' path='doc/member[@name="LOGON32.LOGON32_LOGON_NEW_CREDENTIALS"]/*' />
    [NativeTypeName("#define LOGON32_LOGON_NEW_CREDENTIALS 9")]
    public const int LOGON32_LOGON_NEW_CREDENTIALS = 9;

    /// <include file='LOGON32.xml' path='doc/member[@name="LOGON32.LOGON32_PROVIDER_DEFAULT"]/*' />
    [NativeTypeName("#define LOGON32_PROVIDER_DEFAULT 0")]
    public const int LOGON32_PROVIDER_DEFAULT = 0;

    /// <include file='LOGON32.xml' path='doc/member[@name="LOGON32.LOGON32_PROVIDER_WINNT35"]/*' />
    [NativeTypeName("#define LOGON32_PROVIDER_WINNT35 1")]
    public const int LOGON32_PROVIDER_WINNT35 = 1;

    /// <include file='LOGON32.xml' path='doc/member[@name="LOGON32.LOGON32_PROVIDER_WINNT40"]/*' />
    [NativeTypeName("#define LOGON32_PROVIDER_WINNT40 2")]
    public const int LOGON32_PROVIDER_WINNT40 = 2;

    /// <include file='LOGON32.xml' path='doc/member[@name="LOGON32.LOGON32_PROVIDER_WINNT50"]/*' />
    [NativeTypeName("#define LOGON32_PROVIDER_WINNT50 3")]
    public const int LOGON32_PROVIDER_WINNT50 = 3;

    /// <include file='LOGON32.xml' path='doc/member[@name="LOGON32.LOGON32_PROVIDER_VIRTUAL"]/*' />
    [NativeTypeName("#define LOGON32_PROVIDER_VIRTUAL 4")]
    public const int LOGON32_PROVIDER_VIRTUAL = 4;
}
