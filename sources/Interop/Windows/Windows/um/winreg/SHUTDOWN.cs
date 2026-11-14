// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winreg.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class SHUTDOWN
{
    /// <include file='SHUTDOWN.xml' path='doc/member[@name="SHUTDOWN.SHUTDOWN_FORCE_OTHERS"]/*' />
    [NativeTypeName("#define SHUTDOWN_FORCE_OTHERS 0x00000001")]
    public const int SHUTDOWN_FORCE_OTHERS = 0x00000001;

    /// <include file='SHUTDOWN.xml' path='doc/member[@name="SHUTDOWN.SHUTDOWN_FORCE_SELF"]/*' />
    [NativeTypeName("#define SHUTDOWN_FORCE_SELF 0x00000002")]
    public const int SHUTDOWN_FORCE_SELF = 0x00000002;

    /// <include file='SHUTDOWN.xml' path='doc/member[@name="SHUTDOWN.SHUTDOWN_RESTART"]/*' />
    [NativeTypeName("#define SHUTDOWN_RESTART 0x00000004")]
    public const int SHUTDOWN_RESTART = 0x00000004;

    /// <include file='SHUTDOWN.xml' path='doc/member[@name="SHUTDOWN.SHUTDOWN_POWEROFF"]/*' />
    [NativeTypeName("#define SHUTDOWN_POWEROFF 0x00000008")]
    public const int SHUTDOWN_POWEROFF = 0x00000008;

    /// <include file='SHUTDOWN.xml' path='doc/member[@name="SHUTDOWN.SHUTDOWN_NOREBOOT"]/*' />
    [NativeTypeName("#define SHUTDOWN_NOREBOOT 0x00000010")]
    public const int SHUTDOWN_NOREBOOT = 0x00000010;

    /// <include file='SHUTDOWN.xml' path='doc/member[@name="SHUTDOWN.SHUTDOWN_GRACE_OVERRIDE"]/*' />
    [NativeTypeName("#define SHUTDOWN_GRACE_OVERRIDE 0x00000020")]
    public const int SHUTDOWN_GRACE_OVERRIDE = 0x00000020;

    /// <include file='SHUTDOWN.xml' path='doc/member[@name="SHUTDOWN.SHUTDOWN_INSTALL_UPDATES"]/*' />
    [NativeTypeName("#define SHUTDOWN_INSTALL_UPDATES 0x00000040")]
    public const int SHUTDOWN_INSTALL_UPDATES = 0x00000040;

    /// <include file='SHUTDOWN.xml' path='doc/member[@name="SHUTDOWN.SHUTDOWN_RESTARTAPPS"]/*' />
    [NativeTypeName("#define SHUTDOWN_RESTARTAPPS 0x00000080")]
    public const int SHUTDOWN_RESTARTAPPS = 0x00000080;

    /// <include file='SHUTDOWN.xml' path='doc/member[@name="SHUTDOWN.SHUTDOWN_SKIP_SVC_PRESHUTDOWN"]/*' />
    [NativeTypeName("#define SHUTDOWN_SKIP_SVC_PRESHUTDOWN 0x00000100")]
    public const int SHUTDOWN_SKIP_SVC_PRESHUTDOWN = 0x00000100;

    /// <include file='SHUTDOWN.xml' path='doc/member[@name="SHUTDOWN.SHUTDOWN_HYBRID"]/*' />
    [NativeTypeName("#define SHUTDOWN_HYBRID 0x00000200")]
    public const int SHUTDOWN_HYBRID = 0x00000200;

    /// <include file='SHUTDOWN.xml' path='doc/member[@name="SHUTDOWN.SHUTDOWN_RESTART_BOOTOPTIONS"]/*' />
    [NativeTypeName("#define SHUTDOWN_RESTART_BOOTOPTIONS 0x00000400")]
    public const int SHUTDOWN_RESTART_BOOTOPTIONS = 0x00000400;

    /// <include file='SHUTDOWN.xml' path='doc/member[@name="SHUTDOWN.SHUTDOWN_SOFT_REBOOT"]/*' />
    [NativeTypeName("#define SHUTDOWN_SOFT_REBOOT 0x00000800")]
    public const int SHUTDOWN_SOFT_REBOOT = 0x00000800;

    /// <include file='SHUTDOWN.xml' path='doc/member[@name="SHUTDOWN.SHUTDOWN_MOBILE_UI"]/*' />
    [NativeTypeName("#define SHUTDOWN_MOBILE_UI 0x00001000")]
    public const int SHUTDOWN_MOBILE_UI = 0x00001000;

    /// <include file='SHUTDOWN.xml' path='doc/member[@name="SHUTDOWN.SHUTDOWN_ARSO"]/*' />
    [NativeTypeName("#define SHUTDOWN_ARSO 0x00002000")]
    public const int SHUTDOWN_ARSO = 0x00002000;

    /// <include file='SHUTDOWN.xml' path='doc/member[@name="SHUTDOWN.SHUTDOWN_CHECK_SAFE_FOR_SERVER"]/*' />
    [NativeTypeName("#define SHUTDOWN_CHECK_SAFE_FOR_SERVER 0x00004000")]
    public const int SHUTDOWN_CHECK_SAFE_FOR_SERVER = 0x00004000;

    /// <include file='SHUTDOWN.xml' path='doc/member[@name="SHUTDOWN.SHUTDOWN_VAIL_CONTAINER"]/*' />
    [NativeTypeName("#define SHUTDOWN_VAIL_CONTAINER 0x00008000")]
    public const int SHUTDOWN_VAIL_CONTAINER = 0x00008000;

    /// <include file='SHUTDOWN.xml' path='doc/member[@name="SHUTDOWN.SHUTDOWN_SYSTEM_INITIATED"]/*' />
    [NativeTypeName("#define SHUTDOWN_SYSTEM_INITIATED 0x00010000")]
    public const int SHUTDOWN_SYSTEM_INITIATED = 0x00010000;

    /// <include file='SHUTDOWN.xml' path='doc/member[@name="SHUTDOWN.SHUTDOWN_UPDATE_POWEROFF"]/*' />
    [NativeTypeName("#define SHUTDOWN_UPDATE_POWEROFF 0x00020000")]
    public const int SHUTDOWN_UPDATE_POWEROFF = 0x00020000;
}
