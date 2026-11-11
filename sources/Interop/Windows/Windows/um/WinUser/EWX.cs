// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class EWX
{
    /// <include file='EWX.xml' path='doc/member[@name="EWX.EWX_LOGOFF"]/*' />
    [NativeTypeName("#define EWX_LOGOFF 0x00000000")]
    public const int EWX_LOGOFF = 0x00000000;

    /// <include file='EWX.xml' path='doc/member[@name="EWX.EWX_SHUTDOWN"]/*' />
    [NativeTypeName("#define EWX_SHUTDOWN 0x00000001")]
    public const int EWX_SHUTDOWN = 0x00000001;

    /// <include file='EWX.xml' path='doc/member[@name="EWX.EWX_REBOOT"]/*' />
    [NativeTypeName("#define EWX_REBOOT 0x00000002")]
    public const int EWX_REBOOT = 0x00000002;

    /// <include file='EWX.xml' path='doc/member[@name="EWX.EWX_FORCE"]/*' />
    [NativeTypeName("#define EWX_FORCE 0x00000004")]
    public const int EWX_FORCE = 0x00000004;

    /// <include file='EWX.xml' path='doc/member[@name="EWX.EWX_POWEROFF"]/*' />
    [NativeTypeName("#define EWX_POWEROFF 0x00000008")]
    public const int EWX_POWEROFF = 0x00000008;

    /// <include file='EWX.xml' path='doc/member[@name="EWX.EWX_FORCEIFHUNG"]/*' />
    [NativeTypeName("#define EWX_FORCEIFHUNG 0x00000010")]
    public const int EWX_FORCEIFHUNG = 0x00000010;

    /// <include file='EWX.xml' path='doc/member[@name="EWX.EWX_QUICKRESOLVE"]/*' />
    [NativeTypeName("#define EWX_QUICKRESOLVE 0x00000020")]
    public const int EWX_QUICKRESOLVE = 0x00000020;

    /// <include file='EWX.xml' path='doc/member[@name="EWX.EWX_RESTARTAPPS"]/*' />
    [NativeTypeName("#define EWX_RESTARTAPPS 0x00000040")]
    public const int EWX_RESTARTAPPS = 0x00000040;

    /// <include file='EWX.xml' path='doc/member[@name="EWX.EWX_HYBRID_SHUTDOWN"]/*' />
    [NativeTypeName("#define EWX_HYBRID_SHUTDOWN 0x00400000")]
    public const int EWX_HYBRID_SHUTDOWN = 0x00400000;

    /// <include file='EWX.xml' path='doc/member[@name="EWX.EWX_BOOTOPTIONS"]/*' />
    [NativeTypeName("#define EWX_BOOTOPTIONS 0x01000000")]
    public const int EWX_BOOTOPTIONS = 0x01000000;

    /// <include file='EWX.xml' path='doc/member[@name="EWX.EWX_ARSO"]/*' />
    [NativeTypeName("#define EWX_ARSO 0x04000000")]
    public const int EWX_ARSO = 0x04000000;

    /// <include file='EWX.xml' path='doc/member[@name="EWX.EWX_CHECK_SAFE_FOR_SERVER"]/*' />
    [NativeTypeName("#define EWX_CHECK_SAFE_FOR_SERVER 0x08000000")]
    public const int EWX_CHECK_SAFE_FOR_SERVER = 0x08000000;

    /// <include file='EWX.xml' path='doc/member[@name="EWX.EWX_SYSTEM_INITIATED"]/*' />
    [NativeTypeName("#define EWX_SYSTEM_INITIATED 0x10000000")]
    public const int EWX_SYSTEM_INITIATED = 0x10000000;
}
