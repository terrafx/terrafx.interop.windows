// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/wtypesbase.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class APPIDREGFLAGS
{
    /// <include file='APPIDREGFLAGS.xml' path='doc/member[@name="APPIDREGFLAGS.APPIDREGFLAGS_ACTIVATE_IUSERVER_INDESKTOP"]/*' />
    [NativeTypeName("#define APPIDREGFLAGS_ACTIVATE_IUSERVER_INDESKTOP 0x1")]
    public const int APPIDREGFLAGS_ACTIVATE_IUSERVER_INDESKTOP = 0x1;

    /// <include file='APPIDREGFLAGS.xml' path='doc/member[@name="APPIDREGFLAGS.APPIDREGFLAGS_SECURE_SERVER_PROCESS_SD_AND_BIND"]/*' />
    [NativeTypeName("#define APPIDREGFLAGS_SECURE_SERVER_PROCESS_SD_AND_BIND 0x2")]
    public const int APPIDREGFLAGS_SECURE_SERVER_PROCESS_SD_AND_BIND = 0x2;

    /// <include file='APPIDREGFLAGS.xml' path='doc/member[@name="APPIDREGFLAGS.APPIDREGFLAGS_ISSUE_ACTIVATION_RPC_AT_IDENTIFY"]/*' />
    [NativeTypeName("#define APPIDREGFLAGS_ISSUE_ACTIVATION_RPC_AT_IDENTIFY 0x4")]
    public const int APPIDREGFLAGS_ISSUE_ACTIVATION_RPC_AT_IDENTIFY = 0x4;

    /// <include file='APPIDREGFLAGS.xml' path='doc/member[@name="APPIDREGFLAGS.APPIDREGFLAGS_IUSERVER_UNMODIFIED_LOGON_TOKEN"]/*' />
    [NativeTypeName("#define APPIDREGFLAGS_IUSERVER_UNMODIFIED_LOGON_TOKEN 0x8")]
    public const int APPIDREGFLAGS_IUSERVER_UNMODIFIED_LOGON_TOKEN = 0x8;

    /// <include file='APPIDREGFLAGS.xml' path='doc/member[@name="APPIDREGFLAGS.APPIDREGFLAGS_IUSERVER_SELF_SID_IN_LAUNCH_PERMISSION"]/*' />
    [NativeTypeName("#define APPIDREGFLAGS_IUSERVER_SELF_SID_IN_LAUNCH_PERMISSION 0x10")]
    public const int APPIDREGFLAGS_IUSERVER_SELF_SID_IN_LAUNCH_PERMISSION = 0x10;

    /// <include file='APPIDREGFLAGS.xml' path='doc/member[@name="APPIDREGFLAGS.APPIDREGFLAGS_IUSERVER_ACTIVATE_IN_CLIENT_SESSION_ONLY"]/*' />
    [NativeTypeName("#define APPIDREGFLAGS_IUSERVER_ACTIVATE_IN_CLIENT_SESSION_ONLY 0x20")]
    public const int APPIDREGFLAGS_IUSERVER_ACTIVATE_IN_CLIENT_SESSION_ONLY = 0x20;

    /// <include file='APPIDREGFLAGS.xml' path='doc/member[@name="APPIDREGFLAGS.APPIDREGFLAGS_RESERVED1"]/*' />
    [NativeTypeName("#define APPIDREGFLAGS_RESERVED1 0x40")]
    public const int APPIDREGFLAGS_RESERVED1 = 0x40;

    /// <include file='APPIDREGFLAGS.xml' path='doc/member[@name="APPIDREGFLAGS.APPIDREGFLAGS_RESERVED2"]/*' />
    [NativeTypeName("#define APPIDREGFLAGS_RESERVED2 0x80")]
    public const int APPIDREGFLAGS_RESERVED2 = 0x80;

    /// <include file='APPIDREGFLAGS.xml' path='doc/member[@name="APPIDREGFLAGS.APPIDREGFLAGS_RESERVED3"]/*' />
    [NativeTypeName("#define APPIDREGFLAGS_RESERVED3 0x100")]
    public const int APPIDREGFLAGS_RESERVED3 = 0x100;

    /// <include file='APPIDREGFLAGS.xml' path='doc/member[@name="APPIDREGFLAGS.APPIDREGFLAGS_RESERVED4"]/*' />
    [NativeTypeName("#define APPIDREGFLAGS_RESERVED4 0x200")]
    public const int APPIDREGFLAGS_RESERVED4 = 0x200;

    /// <include file='APPIDREGFLAGS.xml' path='doc/member[@name="APPIDREGFLAGS.APPIDREGFLAGS_RESERVED5"]/*' />
    [NativeTypeName("#define APPIDREGFLAGS_RESERVED5 0x400")]
    public const int APPIDREGFLAGS_RESERVED5 = 0x400;

    /// <include file='APPIDREGFLAGS.xml' path='doc/member[@name="APPIDREGFLAGS.APPIDREGFLAGS_AAA_NO_IMPLICIT_ACTIVATE_AS_IU"]/*' />
    [NativeTypeName("#define APPIDREGFLAGS_AAA_NO_IMPLICIT_ACTIVATE_AS_IU 0x800")]
    public const int APPIDREGFLAGS_AAA_NO_IMPLICIT_ACTIVATE_AS_IU = 0x800;

    /// <include file='APPIDREGFLAGS.xml' path='doc/member[@name="APPIDREGFLAGS.APPIDREGFLAGS_RESERVED7"]/*' />
    [NativeTypeName("#define APPIDREGFLAGS_RESERVED7 0x1000")]
    public const int APPIDREGFLAGS_RESERVED7 = 0x1000;

    /// <include file='APPIDREGFLAGS.xml' path='doc/member[@name="APPIDREGFLAGS.APPIDREGFLAGS_RESERVED8"]/*' />
    [NativeTypeName("#define APPIDREGFLAGS_RESERVED8 0x2000")]
    public const int APPIDREGFLAGS_RESERVED8 = 0x2000;

    /// <include file='APPIDREGFLAGS.xml' path='doc/member[@name="APPIDREGFLAGS.APPIDREGFLAGS_RESERVED9"]/*' />
    [NativeTypeName("#define APPIDREGFLAGS_RESERVED9 0x4000")]
    public const int APPIDREGFLAGS_RESERVED9 = 0x4000;

    /// <include file='APPIDREGFLAGS.xml' path='doc/member[@name="APPIDREGFLAGS.APPIDREGFLAGS_RESERVED10"]/*' />
    [NativeTypeName("#define APPIDREGFLAGS_RESERVED10 0x8000")]
    public const int APPIDREGFLAGS_RESERVED10 = 0x8000;
}
