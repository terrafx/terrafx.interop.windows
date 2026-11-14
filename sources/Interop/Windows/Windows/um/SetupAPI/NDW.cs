// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SetupAPI.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class NDW
{
    /// <include file='NDW.xml' path='doc/member[@name="NDW.NDW_INSTALLFLAG_DIDFACTDEFS"]/*' />
    [NativeTypeName("#define NDW_INSTALLFLAG_DIDFACTDEFS 0x00000001")]
    public const int NDW_INSTALLFLAG_DIDFACTDEFS = 0x00000001;

    /// <include file='NDW.xml' path='doc/member[@name="NDW.NDW_INSTALLFLAG_HARDWAREALLREADYIN"]/*' />
    [NativeTypeName("#define NDW_INSTALLFLAG_HARDWAREALLREADYIN 0x00000002")]
    public const int NDW_INSTALLFLAG_HARDWAREALLREADYIN = 0x00000002;

    /// <include file='NDW.xml' path='doc/member[@name="NDW.NDW_INSTALLFLAG_NEEDRESTART"]/*' />
    [NativeTypeName("#define NDW_INSTALLFLAG_NEEDRESTART DI_NEEDRESTART")]
    public const int NDW_INSTALLFLAG_NEEDRESTART = 0x00000080;

    /// <include file='NDW.xml' path='doc/member[@name="NDW.NDW_INSTALLFLAG_NEEDREBOOT"]/*' />
    [NativeTypeName("#define NDW_INSTALLFLAG_NEEDREBOOT DI_NEEDREBOOT")]
    public const int NDW_INSTALLFLAG_NEEDREBOOT = 0x00000100;

    /// <include file='NDW.xml' path='doc/member[@name="NDW.NDW_INSTALLFLAG_NEEDSHUTDOWN"]/*' />
    [NativeTypeName("#define NDW_INSTALLFLAG_NEEDSHUTDOWN 0x00000200")]
    public const int NDW_INSTALLFLAG_NEEDSHUTDOWN = 0x00000200;

    /// <include file='NDW.xml' path='doc/member[@name="NDW.NDW_INSTALLFLAG_EXPRESSINTRO"]/*' />
    [NativeTypeName("#define NDW_INSTALLFLAG_EXPRESSINTRO 0x00000400")]
    public const int NDW_INSTALLFLAG_EXPRESSINTRO = 0x00000400;

    /// <include file='NDW.xml' path='doc/member[@name="NDW.NDW_INSTALLFLAG_SKIPISDEVINSTALLED"]/*' />
    [NativeTypeName("#define NDW_INSTALLFLAG_SKIPISDEVINSTALLED 0x00000800")]
    public const int NDW_INSTALLFLAG_SKIPISDEVINSTALLED = 0x00000800;

    /// <include file='NDW.xml' path='doc/member[@name="NDW.NDW_INSTALLFLAG_NODETECTEDDEVS"]/*' />
    [NativeTypeName("#define NDW_INSTALLFLAG_NODETECTEDDEVS 0x00001000")]
    public const int NDW_INSTALLFLAG_NODETECTEDDEVS = 0x00001000;

    /// <include file='NDW.xml' path='doc/member[@name="NDW.NDW_INSTALLFLAG_INSTALLSPECIFIC"]/*' />
    [NativeTypeName("#define NDW_INSTALLFLAG_INSTALLSPECIFIC 0x00002000")]
    public const int NDW_INSTALLFLAG_INSTALLSPECIFIC = 0x00002000;

    /// <include file='NDW.xml' path='doc/member[@name="NDW.NDW_INSTALLFLAG_SKIPCLASSLIST"]/*' />
    [NativeTypeName("#define NDW_INSTALLFLAG_SKIPCLASSLIST 0x00004000")]
    public const int NDW_INSTALLFLAG_SKIPCLASSLIST = 0x00004000;

    /// <include file='NDW.xml' path='doc/member[@name="NDW.NDW_INSTALLFLAG_CI_PICKED_OEM"]/*' />
    [NativeTypeName("#define NDW_INSTALLFLAG_CI_PICKED_OEM 0x00008000")]
    public const int NDW_INSTALLFLAG_CI_PICKED_OEM = 0x00008000;

    /// <include file='NDW.xml' path='doc/member[@name="NDW.NDW_INSTALLFLAG_PCMCIAMODE"]/*' />
    [NativeTypeName("#define NDW_INSTALLFLAG_PCMCIAMODE 0x00010000")]
    public const int NDW_INSTALLFLAG_PCMCIAMODE = 0x00010000;

    /// <include file='NDW.xml' path='doc/member[@name="NDW.NDW_INSTALLFLAG_PCMCIADEVICE"]/*' />
    [NativeTypeName("#define NDW_INSTALLFLAG_PCMCIADEVICE 0x00020000")]
    public const int NDW_INSTALLFLAG_PCMCIADEVICE = 0x00020000;

    /// <include file='NDW.xml' path='doc/member[@name="NDW.NDW_INSTALLFLAG_USERCANCEL"]/*' />
    [NativeTypeName("#define NDW_INSTALLFLAG_USERCANCEL 0x00040000")]
    public const int NDW_INSTALLFLAG_USERCANCEL = 0x00040000;

    /// <include file='NDW.xml' path='doc/member[@name="NDW.NDW_INSTALLFLAG_KNOWNCLASS"]/*' />
    [NativeTypeName("#define NDW_INSTALLFLAG_KNOWNCLASS 0x00080000")]
    public const int NDW_INSTALLFLAG_KNOWNCLASS = 0x00080000;
}
