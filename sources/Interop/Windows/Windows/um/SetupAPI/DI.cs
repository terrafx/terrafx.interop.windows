// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SetupAPI.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class DI
{
    /// <include file='DI.xml' path='doc/member[@name="DI.DI_SHOWOEM"]/*' />
    [NativeTypeName("#define DI_SHOWOEM 0x00000001L")]
    public const int DI_SHOWOEM = 0x00000001;

    /// <include file='DI.xml' path='doc/member[@name="DI.DI_SHOWCOMPAT"]/*' />
    [NativeTypeName("#define DI_SHOWCOMPAT 0x00000002L")]
    public const int DI_SHOWCOMPAT = 0x00000002;

    /// <include file='DI.xml' path='doc/member[@name="DI.DI_SHOWCLASS"]/*' />
    [NativeTypeName("#define DI_SHOWCLASS 0x00000004L")]
    public const int DI_SHOWCLASS = 0x00000004;

    /// <include file='DI.xml' path='doc/member[@name="DI.DI_SHOWALL"]/*' />
    [NativeTypeName("#define DI_SHOWALL 0x00000007L")]
    public const int DI_SHOWALL = 0x00000007;

    /// <include file='DI.xml' path='doc/member[@name="DI.DI_NOVCP"]/*' />
    [NativeTypeName("#define DI_NOVCP 0x00000008L")]
    public const int DI_NOVCP = 0x00000008;

    /// <include file='DI.xml' path='doc/member[@name="DI.DI_DIDCOMPAT"]/*' />
    [NativeTypeName("#define DI_DIDCOMPAT 0x00000010L")]
    public const int DI_DIDCOMPAT = 0x00000010;

    /// <include file='DI.xml' path='doc/member[@name="DI.DI_DIDCLASS"]/*' />
    [NativeTypeName("#define DI_DIDCLASS 0x00000020L")]
    public const int DI_DIDCLASS = 0x00000020;

    /// <include file='DI.xml' path='doc/member[@name="DI.DI_AUTOASSIGNRES"]/*' />
    [NativeTypeName("#define DI_AUTOASSIGNRES 0x00000040L")]
    public const int DI_AUTOASSIGNRES = 0x00000040;

    /// <include file='DI.xml' path='doc/member[@name="DI.DI_NEEDRESTART"]/*' />
    [NativeTypeName("#define DI_NEEDRESTART 0x00000080L")]
    public const int DI_NEEDRESTART = 0x00000080;

    /// <include file='DI.xml' path='doc/member[@name="DI.DI_NEEDREBOOT"]/*' />
    [NativeTypeName("#define DI_NEEDREBOOT 0x00000100L")]
    public const int DI_NEEDREBOOT = 0x00000100;

    /// <include file='DI.xml' path='doc/member[@name="DI.DI_NOBROWSE"]/*' />
    [NativeTypeName("#define DI_NOBROWSE 0x00000200L")]
    public const int DI_NOBROWSE = 0x00000200;

    /// <include file='DI.xml' path='doc/member[@name="DI.DI_MULTMFGS"]/*' />
    [NativeTypeName("#define DI_MULTMFGS 0x00000400L")]
    public const int DI_MULTMFGS = 0x00000400;

    /// <include file='DI.xml' path='doc/member[@name="DI.DI_DISABLED"]/*' />
    [NativeTypeName("#define DI_DISABLED 0x00000800L")]
    public const int DI_DISABLED = 0x00000800;

    /// <include file='DI.xml' path='doc/member[@name="DI.DI_GENERALPAGE_ADDED"]/*' />
    [NativeTypeName("#define DI_GENERALPAGE_ADDED 0x00001000L")]
    public const int DI_GENERALPAGE_ADDED = 0x00001000;

    /// <include file='DI.xml' path='doc/member[@name="DI.DI_RESOURCEPAGE_ADDED"]/*' />
    [NativeTypeName("#define DI_RESOURCEPAGE_ADDED 0x00002000L")]
    public const int DI_RESOURCEPAGE_ADDED = 0x00002000;

    /// <include file='DI.xml' path='doc/member[@name="DI.DI_PROPERTIES_CHANGE"]/*' />
    [NativeTypeName("#define DI_PROPERTIES_CHANGE 0x00004000L")]
    public const int DI_PROPERTIES_CHANGE = 0x00004000;

    /// <include file='DI.xml' path='doc/member[@name="DI.DI_INF_IS_SORTED"]/*' />
    [NativeTypeName("#define DI_INF_IS_SORTED 0x00008000L")]
    public const int DI_INF_IS_SORTED = 0x00008000;

    /// <include file='DI.xml' path='doc/member[@name="DI.DI_ENUMSINGLEINF"]/*' />
    [NativeTypeName("#define DI_ENUMSINGLEINF 0x00010000L")]
    public const int DI_ENUMSINGLEINF = 0x00010000;

    /// <include file='DI.xml' path='doc/member[@name="DI.DI_DONOTCALLCONFIGMG"]/*' />
    [NativeTypeName("#define DI_DONOTCALLCONFIGMG 0x00020000L")]
    public const int DI_DONOTCALLCONFIGMG = 0x00020000;

    /// <include file='DI.xml' path='doc/member[@name="DI.DI_INSTALLDISABLED"]/*' />
    [NativeTypeName("#define DI_INSTALLDISABLED 0x00040000L")]
    public const int DI_INSTALLDISABLED = 0x00040000;

    /// <include file='DI.xml' path='doc/member[@name="DI.DI_COMPAT_FROM_CLASS"]/*' />
    [NativeTypeName("#define DI_COMPAT_FROM_CLASS 0x00080000L")]
    public const int DI_COMPAT_FROM_CLASS = 0x00080000;

    /// <include file='DI.xml' path='doc/member[@name="DI.DI_CLASSINSTALLPARAMS"]/*' />
    [NativeTypeName("#define DI_CLASSINSTALLPARAMS 0x00100000L")]
    public const int DI_CLASSINSTALLPARAMS = 0x00100000;

    /// <include file='DI.xml' path='doc/member[@name="DI.DI_NODI_DEFAULTACTION"]/*' />
    [NativeTypeName("#define DI_NODI_DEFAULTACTION 0x00200000L")]
    public const int DI_NODI_DEFAULTACTION = 0x00200000;

    /// <include file='DI.xml' path='doc/member[@name="DI.DI_QUIETINSTALL"]/*' />
    [NativeTypeName("#define DI_QUIETINSTALL 0x00800000L")]
    public const int DI_QUIETINSTALL = 0x00800000;

    /// <include file='DI.xml' path='doc/member[@name="DI.DI_NOFILECOPY"]/*' />
    [NativeTypeName("#define DI_NOFILECOPY 0x01000000L")]
    public const int DI_NOFILECOPY = 0x01000000;

    /// <include file='DI.xml' path='doc/member[@name="DI.DI_FORCECOPY"]/*' />
    [NativeTypeName("#define DI_FORCECOPY 0x02000000L")]
    public const int DI_FORCECOPY = 0x02000000;

    /// <include file='DI.xml' path='doc/member[@name="DI.DI_DRIVERPAGE_ADDED"]/*' />
    [NativeTypeName("#define DI_DRIVERPAGE_ADDED 0x04000000L")]
    public const int DI_DRIVERPAGE_ADDED = 0x04000000;

    /// <include file='DI.xml' path='doc/member[@name="DI.DI_USECI_SELECTSTRINGS"]/*' />
    [NativeTypeName("#define DI_USECI_SELECTSTRINGS 0x08000000L")]
    public const int DI_USECI_SELECTSTRINGS = 0x08000000;

    /// <include file='DI.xml' path='doc/member[@name="DI.DI_OVERRIDE_INFFLAGS"]/*' />
    [NativeTypeName("#define DI_OVERRIDE_INFFLAGS 0x10000000L")]
    public const int DI_OVERRIDE_INFFLAGS = 0x10000000;

    /// <include file='DI.xml' path='doc/member[@name="DI.DI_PROPS_NOCHANGEUSAGE"]/*' />
    [NativeTypeName("#define DI_PROPS_NOCHANGEUSAGE 0x20000000L")]
    public const int DI_PROPS_NOCHANGEUSAGE = 0x20000000;

    /// <include file='DI.xml' path='doc/member[@name="DI.DI_NOSELECTICONS"]/*' />
    [NativeTypeName("#define DI_NOSELECTICONS 0x40000000L")]
    public const int DI_NOSELECTICONS = 0x40000000;

    /// <include file='DI.xml' path='doc/member[@name="DI.DI_NOWRITE_IDS"]/*' />
    [NativeTypeName("#define DI_NOWRITE_IDS 0x80000000L")]
    public const uint DI_NOWRITE_IDS = 0x80000000;

    /// <include file='DI.xml' path='doc/member[@name="DI.DI_FLAGSEX_RESERVED2"]/*' />
    [NativeTypeName("#define DI_FLAGSEX_RESERVED2 0x00000001L")]
    public const int DI_FLAGSEX_RESERVED2 = 0x00000001;

    /// <include file='DI.xml' path='doc/member[@name="DI.DI_FLAGSEX_RESERVED3"]/*' />
    [NativeTypeName("#define DI_FLAGSEX_RESERVED3 0x00000002L")]
    public const int DI_FLAGSEX_RESERVED3 = 0x00000002;

    /// <include file='DI.xml' path='doc/member[@name="DI.DI_FLAGSEX_CI_FAILED"]/*' />
    [NativeTypeName("#define DI_FLAGSEX_CI_FAILED 0x00000004L")]
    public const int DI_FLAGSEX_CI_FAILED = 0x00000004;

    /// <include file='DI.xml' path='doc/member[@name="DI.DI_FLAGSEX_FINISHINSTALL_ACTION"]/*' />
    [NativeTypeName("#define DI_FLAGSEX_FINISHINSTALL_ACTION 0x00000008L")]
    public const int DI_FLAGSEX_FINISHINSTALL_ACTION = 0x00000008;

    /// <include file='DI.xml' path='doc/member[@name="DI.DI_FLAGSEX_DIDINFOLIST"]/*' />
    [NativeTypeName("#define DI_FLAGSEX_DIDINFOLIST 0x00000010L")]
    public const int DI_FLAGSEX_DIDINFOLIST = 0x00000010;

    /// <include file='DI.xml' path='doc/member[@name="DI.DI_FLAGSEX_DIDCOMPATINFO"]/*' />
    [NativeTypeName("#define DI_FLAGSEX_DIDCOMPATINFO 0x00000020L")]
    public const int DI_FLAGSEX_DIDCOMPATINFO = 0x00000020;

    /// <include file='DI.xml' path='doc/member[@name="DI.DI_FLAGSEX_FILTERCLASSES"]/*' />
    [NativeTypeName("#define DI_FLAGSEX_FILTERCLASSES 0x00000040L")]
    public const int DI_FLAGSEX_FILTERCLASSES = 0x00000040;

    /// <include file='DI.xml' path='doc/member[@name="DI.DI_FLAGSEX_SETFAILEDINSTALL"]/*' />
    [NativeTypeName("#define DI_FLAGSEX_SETFAILEDINSTALL 0x00000080L")]
    public const int DI_FLAGSEX_SETFAILEDINSTALL = 0x00000080;

    /// <include file='DI.xml' path='doc/member[@name="DI.DI_FLAGSEX_DEVICECHANGE"]/*' />
    [NativeTypeName("#define DI_FLAGSEX_DEVICECHANGE 0x00000100L")]
    public const int DI_FLAGSEX_DEVICECHANGE = 0x00000100;

    /// <include file='DI.xml' path='doc/member[@name="DI.DI_FLAGSEX_ALWAYSWRITEIDS"]/*' />
    [NativeTypeName("#define DI_FLAGSEX_ALWAYSWRITEIDS 0x00000200L")]
    public const int DI_FLAGSEX_ALWAYSWRITEIDS = 0x00000200;

    /// <include file='DI.xml' path='doc/member[@name="DI.DI_FLAGSEX_PROPCHANGE_PENDING"]/*' />
    [NativeTypeName("#define DI_FLAGSEX_PROPCHANGE_PENDING 0x00000400L")]
    public const int DI_FLAGSEX_PROPCHANGE_PENDING = 0x00000400;

    /// <include file='DI.xml' path='doc/member[@name="DI.DI_FLAGSEX_ALLOWEXCLUDEDDRVS"]/*' />
    [NativeTypeName("#define DI_FLAGSEX_ALLOWEXCLUDEDDRVS 0x00000800L")]
    public const int DI_FLAGSEX_ALLOWEXCLUDEDDRVS = 0x00000800;

    /// <include file='DI.xml' path='doc/member[@name="DI.DI_FLAGSEX_NOUIONQUERYREMOVE"]/*' />
    [NativeTypeName("#define DI_FLAGSEX_NOUIONQUERYREMOVE 0x00001000L")]
    public const int DI_FLAGSEX_NOUIONQUERYREMOVE = 0x00001000;

    /// <include file='DI.xml' path='doc/member[@name="DI.DI_FLAGSEX_USECLASSFORCOMPAT"]/*' />
    [NativeTypeName("#define DI_FLAGSEX_USECLASSFORCOMPAT 0x00002000L")]
    public const int DI_FLAGSEX_USECLASSFORCOMPAT = 0x00002000;

    /// <include file='DI.xml' path='doc/member[@name="DI.DI_FLAGSEX_RESERVED4"]/*' />
    [NativeTypeName("#define DI_FLAGSEX_RESERVED4 0x00004000L")]
    public const int DI_FLAGSEX_RESERVED4 = 0x00004000;

    /// <include file='DI.xml' path='doc/member[@name="DI.DI_FLAGSEX_NO_DRVREG_MODIFY"]/*' />
    [NativeTypeName("#define DI_FLAGSEX_NO_DRVREG_MODIFY 0x00008000L")]
    public const int DI_FLAGSEX_NO_DRVREG_MODIFY = 0x00008000;

    /// <include file='DI.xml' path='doc/member[@name="DI.DI_FLAGSEX_IN_SYSTEM_SETUP"]/*' />
    [NativeTypeName("#define DI_FLAGSEX_IN_SYSTEM_SETUP 0x00010000L")]
    public const int DI_FLAGSEX_IN_SYSTEM_SETUP = 0x00010000;

    /// <include file='DI.xml' path='doc/member[@name="DI.DI_FLAGSEX_INET_DRIVER"]/*' />
    [NativeTypeName("#define DI_FLAGSEX_INET_DRIVER 0x00020000L")]
    public const int DI_FLAGSEX_INET_DRIVER = 0x00020000;

    /// <include file='DI.xml' path='doc/member[@name="DI.DI_FLAGSEX_APPENDDRIVERLIST"]/*' />
    [NativeTypeName("#define DI_FLAGSEX_APPENDDRIVERLIST 0x00040000L")]
    public const int DI_FLAGSEX_APPENDDRIVERLIST = 0x00040000;

    /// <include file='DI.xml' path='doc/member[@name="DI.DI_FLAGSEX_PREINSTALLBACKUP"]/*' />
    [NativeTypeName("#define DI_FLAGSEX_PREINSTALLBACKUP 0x00080000L")]
    public const int DI_FLAGSEX_PREINSTALLBACKUP = 0x00080000;

    /// <include file='DI.xml' path='doc/member[@name="DI.DI_FLAGSEX_BACKUPONREPLACE"]/*' />
    [NativeTypeName("#define DI_FLAGSEX_BACKUPONREPLACE 0x00100000L")]
    public const int DI_FLAGSEX_BACKUPONREPLACE = 0x00100000;

    /// <include file='DI.xml' path='doc/member[@name="DI.DI_FLAGSEX_DRIVERLIST_FROM_URL"]/*' />
    [NativeTypeName("#define DI_FLAGSEX_DRIVERLIST_FROM_URL 0x00200000L")]
    public const int DI_FLAGSEX_DRIVERLIST_FROM_URL = 0x00200000;

    /// <include file='DI.xml' path='doc/member[@name="DI.DI_FLAGSEX_RESERVED1"]/*' />
    [NativeTypeName("#define DI_FLAGSEX_RESERVED1 0x00400000L")]
    public const int DI_FLAGSEX_RESERVED1 = 0x00400000;

    /// <include file='DI.xml' path='doc/member[@name="DI.DI_FLAGSEX_EXCLUDE_OLD_INET_DRIVERS"]/*' />
    [NativeTypeName("#define DI_FLAGSEX_EXCLUDE_OLD_INET_DRIVERS 0x00800000L")]
    public const int DI_FLAGSEX_EXCLUDE_OLD_INET_DRIVERS = 0x00800000;

    /// <include file='DI.xml' path='doc/member[@name="DI.DI_FLAGSEX_POWERPAGE_ADDED"]/*' />
    [NativeTypeName("#define DI_FLAGSEX_POWERPAGE_ADDED 0x01000000L")]
    public const int DI_FLAGSEX_POWERPAGE_ADDED = 0x01000000;

    /// <include file='DI.xml' path='doc/member[@name="DI.DI_FLAGSEX_FILTERSIMILARDRIVERS"]/*' />
    [NativeTypeName("#define DI_FLAGSEX_FILTERSIMILARDRIVERS 0x02000000L")]
    public const int DI_FLAGSEX_FILTERSIMILARDRIVERS = 0x02000000;

    /// <include file='DI.xml' path='doc/member[@name="DI.DI_FLAGSEX_INSTALLEDDRIVER"]/*' />
    [NativeTypeName("#define DI_FLAGSEX_INSTALLEDDRIVER 0x04000000L")]
    public const int DI_FLAGSEX_INSTALLEDDRIVER = 0x04000000;

    /// <include file='DI.xml' path='doc/member[@name="DI.DI_FLAGSEX_NO_CLASSLIST_NODE_MERGE"]/*' />
    [NativeTypeName("#define DI_FLAGSEX_NO_CLASSLIST_NODE_MERGE 0x08000000L")]
    public const int DI_FLAGSEX_NO_CLASSLIST_NODE_MERGE = 0x08000000;

    /// <include file='DI.xml' path='doc/member[@name="DI.DI_FLAGSEX_ALTPLATFORM_DRVSEARCH"]/*' />
    [NativeTypeName("#define DI_FLAGSEX_ALTPLATFORM_DRVSEARCH 0x10000000L")]
    public const int DI_FLAGSEX_ALTPLATFORM_DRVSEARCH = 0x10000000;

    /// <include file='DI.xml' path='doc/member[@name="DI.DI_FLAGSEX_RESTART_DEVICE_ONLY"]/*' />
    [NativeTypeName("#define DI_FLAGSEX_RESTART_DEVICE_ONLY 0x20000000L")]
    public const int DI_FLAGSEX_RESTART_DEVICE_ONLY = 0x20000000;

    /// <include file='DI.xml' path='doc/member[@name="DI.DI_FLAGSEX_RECURSIVESEARCH"]/*' />
    [NativeTypeName("#define DI_FLAGSEX_RECURSIVESEARCH 0x40000000L")]
    public const int DI_FLAGSEX_RECURSIVESEARCH = 0x40000000;

    /// <include file='DI.xml' path='doc/member[@name="DI.DI_FLAGSEX_SEARCH_PUBLISHED_INFS"]/*' />
    [NativeTypeName("#define DI_FLAGSEX_SEARCH_PUBLISHED_INFS 0x80000000L")]
    public const uint DI_FLAGSEX_SEARCH_PUBLISHED_INFS = 0x80000000;

    /// <include file='DI.xml' path='doc/member[@name="DI.DI_REMOVEDEVICE_GLOBAL"]/*' />
    [NativeTypeName("#define DI_REMOVEDEVICE_GLOBAL 0x00000001")]
    public const int DI_REMOVEDEVICE_GLOBAL = 0x00000001;

    /// <include file='DI.xml' path='doc/member[@name="DI.DI_REMOVEDEVICE_CONFIGSPECIFIC"]/*' />
    [NativeTypeName("#define DI_REMOVEDEVICE_CONFIGSPECIFIC 0x00000002")]
    public const int DI_REMOVEDEVICE_CONFIGSPECIFIC = 0x00000002;

    /// <include file='DI.xml' path='doc/member[@name="DI.DI_UNREMOVEDEVICE_CONFIGSPECIFIC"]/*' />
    [NativeTypeName("#define DI_UNREMOVEDEVICE_CONFIGSPECIFIC 0x00000002")]
    public const int DI_UNREMOVEDEVICE_CONFIGSPECIFIC = 0x00000002;
}
