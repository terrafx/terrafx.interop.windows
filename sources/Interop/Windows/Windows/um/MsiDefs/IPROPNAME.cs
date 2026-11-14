// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsiDefs.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class IPROPNAME
{
    /// <include file='IPROPNAME.xml' path='doc/member[@name="IPROPNAME.IPROPNAME_PRODUCTNAME"]/*' />
    [NativeTypeName("#define IPROPNAME_PRODUCTNAME TEXT(\"ProductName\")")]
    public const string IPROPNAME_PRODUCTNAME = "ProductName";

    /// <include file='IPROPNAME.xml' path='doc/member[@name="IPROPNAME.IPROPNAME_PRODUCTCODE"]/*' />
    [NativeTypeName("#define IPROPNAME_PRODUCTCODE TEXT(\"ProductCode\")")]
    public const string IPROPNAME_PRODUCTCODE = "ProductCode";

    /// <include file='IPROPNAME.xml' path='doc/member[@name="IPROPNAME.IPROPNAME_PRODUCTVERSION"]/*' />
    [NativeTypeName("#define IPROPNAME_PRODUCTVERSION TEXT(\"ProductVersion\")")]
    public const string IPROPNAME_PRODUCTVERSION = "ProductVersion";

    /// <include file='IPROPNAME.xml' path='doc/member[@name="IPROPNAME.IPROPNAME_INSTALLLANGUAGE"]/*' />
    [NativeTypeName("#define IPROPNAME_INSTALLLANGUAGE TEXT(\"ProductLanguage\")")]
    public const string IPROPNAME_INSTALLLANGUAGE = "ProductLanguage";

    /// <include file='IPROPNAME.xml' path='doc/member[@name="IPROPNAME.IPROPNAME_MANUFACTURER"]/*' />
    [NativeTypeName("#define IPROPNAME_MANUFACTURER TEXT(\"Manufacturer\")")]
    public const string IPROPNAME_MANUFACTURER = "Manufacturer";

    /// <include file='IPROPNAME.xml' path='doc/member[@name="IPROPNAME.IPROPNAME_UPGRADECODE"]/*' />
    [NativeTypeName("#define IPROPNAME_UPGRADECODE TEXT(\"UpgradeCode\")")]
    public const string IPROPNAME_UPGRADECODE = "UpgradeCode";

    /// <include file='IPROPNAME.xml' path='doc/member[@name="IPROPNAME.IPROPNAME_PIDTEMPLATE"]/*' />
    [NativeTypeName("#define IPROPNAME_PIDTEMPLATE TEXT(\"PIDTemplate\")")]
    public const string IPROPNAME_PIDTEMPLATE = "PIDTemplate";

    /// <include file='IPROPNAME.xml' path='doc/member[@name="IPROPNAME.IPROPNAME_DISKPROMPT"]/*' />
    [NativeTypeName("#define IPROPNAME_DISKPROMPT TEXT(\"DiskPrompt\")")]
    public const string IPROPNAME_DISKPROMPT = "DiskPrompt";

    /// <include file='IPROPNAME.xml' path='doc/member[@name="IPROPNAME.IPROPNAME_LEFTUNIT"]/*' />
    [NativeTypeName("#define IPROPNAME_LEFTUNIT TEXT(\"LeftUnit\")")]
    public const string IPROPNAME_LEFTUNIT = "LeftUnit";

    /// <include file='IPROPNAME.xml' path='doc/member[@name="IPROPNAME.IPROPNAME_ADMIN_PROPERTIES"]/*' />
    [NativeTypeName("#define IPROPNAME_ADMIN_PROPERTIES TEXT(\"AdminProperties\")")]
    public const string IPROPNAME_ADMIN_PROPERTIES = "AdminProperties";

    /// <include file='IPROPNAME.xml' path='doc/member[@name="IPROPNAME.IPROPNAME_DEFAULTUIFONT"]/*' />
    [NativeTypeName("#define IPROPNAME_DEFAULTUIFONT TEXT(\"DefaultUIFont\")")]
    public const string IPROPNAME_DEFAULTUIFONT = "DefaultUIFont";

    /// <include file='IPROPNAME.xml' path='doc/member[@name="IPROPNAME.IPROPNAME_ALLOWEDPROPERTIES"]/*' />
    [NativeTypeName("#define IPROPNAME_ALLOWEDPROPERTIES TEXT(\"SecureCustomProperties\")")]
    public const string IPROPNAME_ALLOWEDPROPERTIES = "SecureCustomProperties";

    /// <include file='IPROPNAME.xml' path='doc/member[@name="IPROPNAME.IPROPNAME_ENABLEUSERCONTROL"]/*' />
    [NativeTypeName("#define IPROPNAME_ENABLEUSERCONTROL TEXT(\"EnableUserControl\")")]
    public const string IPROPNAME_ENABLEUSERCONTROL = "EnableUserControl";

    /// <include file='IPROPNAME.xml' path='doc/member[@name="IPROPNAME.IPROPNAME_HIDDEN_PROPERTIES"]/*' />
    [NativeTypeName("#define IPROPNAME_HIDDEN_PROPERTIES TEXT(\"MsiHiddenProperties\")")]
    public const string IPROPNAME_HIDDEN_PROPERTIES = "MsiHiddenProperties";

    /// <include file='IPROPNAME.xml' path='doc/member[@name="IPROPNAME.IPROPNAME_USERNAME"]/*' />
    [NativeTypeName("#define IPROPNAME_USERNAME TEXT(\"USERNAME\")")]
    public const string IPROPNAME_USERNAME = "USERNAME";

    /// <include file='IPROPNAME.xml' path='doc/member[@name="IPROPNAME.IPROPNAME_COMPANYNAME"]/*' />
    [NativeTypeName("#define IPROPNAME_COMPANYNAME TEXT(\"COMPANYNAME\")")]
    public const string IPROPNAME_COMPANYNAME = "COMPANYNAME";

    /// <include file='IPROPNAME.xml' path='doc/member[@name="IPROPNAME.IPROPNAME_PIDKEY"]/*' />
    [NativeTypeName("#define IPROPNAME_PIDKEY TEXT(\"PIDKEY\")")]
    public const string IPROPNAME_PIDKEY = "PIDKEY";

    /// <include file='IPROPNAME.xml' path='doc/member[@name="IPROPNAME.IPROPNAME_PATCH"]/*' />
    [NativeTypeName("#define IPROPNAME_PATCH TEXT(\"PATCH\")")]
    public const string IPROPNAME_PATCH = "PATCH";

    /// <include file='IPROPNAME.xml' path='doc/member[@name="IPROPNAME.IPROPNAME_MSIPATCHREMOVE"]/*' />
    [NativeTypeName("#define IPROPNAME_MSIPATCHREMOVE TEXT(\"MSIPATCHREMOVE\")")]
    public const string IPROPNAME_MSIPATCHREMOVE = "MSIPATCHREMOVE";

    /// <include file='IPROPNAME.xml' path='doc/member[@name="IPROPNAME.IPROPNAME_TARGETDIR"]/*' />
    [NativeTypeName("#define IPROPNAME_TARGETDIR TEXT(\"TARGETDIR\")")]
    public const string IPROPNAME_TARGETDIR = "TARGETDIR";

    /// <include file='IPROPNAME.xml' path='doc/member[@name="IPROPNAME.IPROPNAME_ACTION"]/*' />
    [NativeTypeName("#define IPROPNAME_ACTION TEXT(\"ACTION\")")]
    public const string IPROPNAME_ACTION = "ACTION";

    /// <include file='IPROPNAME.xml' path='doc/member[@name="IPROPNAME.IPROPNAME_LIMITUI"]/*' />
    [NativeTypeName("#define IPROPNAME_LIMITUI TEXT(\"LIMITUI\")")]
    public const string IPROPNAME_LIMITUI = "LIMITUI";

    /// <include file='IPROPNAME.xml' path='doc/member[@name="IPROPNAME.IPROPNAME_LOGACTION"]/*' />
    [NativeTypeName("#define IPROPNAME_LOGACTION TEXT(\"LOGACTION\")")]
    public const string IPROPNAME_LOGACTION = "LOGACTION";

    /// <include file='IPROPNAME.xml' path='doc/member[@name="IPROPNAME.IPROPNAME_ALLUSERS"]/*' />
    [NativeTypeName("#define IPROPNAME_ALLUSERS TEXT(\"ALLUSERS\")")]
    public const string IPROPNAME_ALLUSERS = "ALLUSERS";

    /// <include file='IPROPNAME.xml' path='doc/member[@name="IPROPNAME.IPROPNAME_INSTALLLEVEL"]/*' />
    [NativeTypeName("#define IPROPNAME_INSTALLLEVEL TEXT(\"INSTALLLEVEL\")")]
    public const string IPROPNAME_INSTALLLEVEL = "INSTALLLEVEL";

    /// <include file='IPROPNAME.xml' path='doc/member[@name="IPROPNAME.IPROPNAME_REBOOT"]/*' />
    [NativeTypeName("#define IPROPNAME_REBOOT TEXT(\"REBOOT\")")]
    public const string IPROPNAME_REBOOT = "REBOOT";

    /// <include file='IPROPNAME.xml' path='doc/member[@name="IPROPNAME.IPROPNAME_REBOOTPROMPT"]/*' />
    [NativeTypeName("#define IPROPNAME_REBOOTPROMPT TEXT(\"REBOOTPROMPT\")")]
    public const string IPROPNAME_REBOOTPROMPT = "REBOOTPROMPT";

    /// <include file='IPROPNAME.xml' path='doc/member[@name="IPROPNAME.IPROPNAME_EXECUTEMODE"]/*' />
    [NativeTypeName("#define IPROPNAME_EXECUTEMODE TEXT(\"EXECUTEMODE\")")]
    public const string IPROPNAME_EXECUTEMODE = "EXECUTEMODE";

    /// <include file='IPROPNAME.xml' path='doc/member[@name="IPROPNAME.IPROPNAME_EXECUTEACTION"]/*' />
    [NativeTypeName("#define IPROPNAME_EXECUTEACTION TEXT(\"EXECUTEACTION\")")]
    public const string IPROPNAME_EXECUTEACTION = "EXECUTEACTION";

    /// <include file='IPROPNAME.xml' path='doc/member[@name="IPROPNAME.IPROPNAME_SOURCELIST"]/*' />
    [NativeTypeName("#define IPROPNAME_SOURCELIST TEXT(\"SOURCELIST\")")]
    public const string IPROPNAME_SOURCELIST = "SOURCELIST";

    /// <include file='IPROPNAME.xml' path='doc/member[@name="IPROPNAME.IPROPNAME_ROOTDRIVE"]/*' />
    [NativeTypeName("#define IPROPNAME_ROOTDRIVE TEXT(\"ROOTDRIVE\")")]
    public const string IPROPNAME_ROOTDRIVE = "ROOTDRIVE";

    /// <include file='IPROPNAME.xml' path='doc/member[@name="IPROPNAME.IPROPNAME_TRANSFORMS"]/*' />
    [NativeTypeName("#define IPROPNAME_TRANSFORMS TEXT(\"TRANSFORMS\")")]
    public const string IPROPNAME_TRANSFORMS = "TRANSFORMS";

    /// <include file='IPROPNAME.xml' path='doc/member[@name="IPROPNAME.IPROPNAME_TRANSFORMSATSOURCE"]/*' />
    [NativeTypeName("#define IPROPNAME_TRANSFORMSATSOURCE TEXT(\"TRANSFORMSATSOURCE\")")]
    public const string IPROPNAME_TRANSFORMSATSOURCE = "TRANSFORMSATSOURCE";

    /// <include file='IPROPNAME.xml' path='doc/member[@name="IPROPNAME.IPROPNAME_TRANSFORMSSECURE"]/*' />
    [NativeTypeName("#define IPROPNAME_TRANSFORMSSECURE TEXT(\"TRANSFORMSSECURE\")")]
    public const string IPROPNAME_TRANSFORMSSECURE = "TRANSFORMSSECURE";

    /// <include file='IPROPNAME.xml' path='doc/member[@name="IPROPNAME.IPROPNAME_SEQUENCE"]/*' />
    [NativeTypeName("#define IPROPNAME_SEQUENCE TEXT(\"SEQUENCE\")")]
    public const string IPROPNAME_SEQUENCE = "SEQUENCE";

    /// <include file='IPROPNAME.xml' path='doc/member[@name="IPROPNAME.IPROPNAME_SHORTFILENAMES"]/*' />
    [NativeTypeName("#define IPROPNAME_SHORTFILENAMES TEXT(\"SHORTFILENAMES\")")]
    public const string IPROPNAME_SHORTFILENAMES = "SHORTFILENAMES";

    /// <include file='IPROPNAME.xml' path='doc/member[@name="IPROPNAME.IPROPNAME_PRIMARYFOLDER"]/*' />
    [NativeTypeName("#define IPROPNAME_PRIMARYFOLDER TEXT(\"PRIMARYFOLDER\")")]
    public const string IPROPNAME_PRIMARYFOLDER = "PRIMARYFOLDER";

    /// <include file='IPROPNAME.xml' path='doc/member[@name="IPROPNAME.IPROPNAME_AFTERREBOOT"]/*' />
    [NativeTypeName("#define IPROPNAME_AFTERREBOOT TEXT(\"AFTERREBOOT\")")]
    public const string IPROPNAME_AFTERREBOOT = "AFTERREBOOT";

    /// <include file='IPROPNAME.xml' path='doc/member[@name="IPROPNAME.IPROPNAME_NOCOMPANYNAME"]/*' />
    [NativeTypeName("#define IPROPNAME_NOCOMPANYNAME TEXT(\"NOCOMPANYNAME\")")]
    public const string IPROPNAME_NOCOMPANYNAME = "NOCOMPANYNAME";

    /// <include file='IPROPNAME.xml' path='doc/member[@name="IPROPNAME.IPROPNAME_NOUSERNAME"]/*' />
    [NativeTypeName("#define IPROPNAME_NOUSERNAME TEXT(\"NOUSERNAME\")")]
    public const string IPROPNAME_NOUSERNAME = "NOUSERNAME";

    /// <include file='IPROPNAME.xml' path='doc/member[@name="IPROPNAME.IPROPNAME_DISABLEROLLBACK"]/*' />
    [NativeTypeName("#define IPROPNAME_DISABLEROLLBACK TEXT(\"DISABLEROLLBACK\")")]
    public const string IPROPNAME_DISABLEROLLBACK = "DISABLEROLLBACK";

    /// <include file='IPROPNAME.xml' path='doc/member[@name="IPROPNAME.IPROPNAME_AVAILABLEFREEREG"]/*' />
    [NativeTypeName("#define IPROPNAME_AVAILABLEFREEREG TEXT(\"AVAILABLEFREEREG\")")]
    public const string IPROPNAME_AVAILABLEFREEREG = "AVAILABLEFREEREG";

    /// <include file='IPROPNAME.xml' path='doc/member[@name="IPROPNAME.IPROPNAME_DISABLEADVTSHORTCUTS"]/*' />
    [NativeTypeName("#define IPROPNAME_DISABLEADVTSHORTCUTS TEXT(\"DISABLEADVTSHORTCUTS\")")]
    public const string IPROPNAME_DISABLEADVTSHORTCUTS = "DISABLEADVTSHORTCUTS";

    /// <include file='IPROPNAME.xml' path='doc/member[@name="IPROPNAME.IPROPNAME_PATCHNEWPACKAGECODE"]/*' />
    [NativeTypeName("#define IPROPNAME_PATCHNEWPACKAGECODE TEXT(\"PATCHNEWPACKAGECODE\")")]
    public const string IPROPNAME_PATCHNEWPACKAGECODE = "PATCHNEWPACKAGECODE";

    /// <include file='IPROPNAME.xml' path='doc/member[@name="IPROPNAME.IPROPNAME_PATCHNEWSUMMARYSUBJECT"]/*' />
    [NativeTypeName("#define IPROPNAME_PATCHNEWSUMMARYSUBJECT TEXT(\"PATCHNEWSUMMARYSUBJECT\")")]
    public const string IPROPNAME_PATCHNEWSUMMARYSUBJECT = "PATCHNEWSUMMARYSUBJECT";

    /// <include file='IPROPNAME.xml' path='doc/member[@name="IPROPNAME.IPROPNAME_PATCHNEWSUMMARYCOMMENTS"]/*' />
    [NativeTypeName("#define IPROPNAME_PATCHNEWSUMMARYCOMMENTS TEXT(\"PATCHNEWSUMMARYCOMMENTS\")")]
    public const string IPROPNAME_PATCHNEWSUMMARYCOMMENTS = "PATCHNEWSUMMARYCOMMENTS";

    /// <include file='IPROPNAME.xml' path='doc/member[@name="IPROPNAME.IPROPNAME_PRODUCTLANGUAGE"]/*' />
    [NativeTypeName("#define IPROPNAME_PRODUCTLANGUAGE TEXT(\"PRODUCTLANGUAGE\")")]
    public const string IPROPNAME_PRODUCTLANGUAGE = "PRODUCTLANGUAGE";

    /// <include file='IPROPNAME.xml' path='doc/member[@name="IPROPNAME.IPROPNAME_CHECKCRCS"]/*' />
    [NativeTypeName("#define IPROPNAME_CHECKCRCS TEXT(\"MSICHECKCRCS\")")]
    public const string IPROPNAME_CHECKCRCS = "MSICHECKCRCS";

    /// <include file='IPROPNAME.xml' path='doc/member[@name="IPROPNAME.IPROPNAME_MSINODISABLEMEDIA"]/*' />
    [NativeTypeName("#define IPROPNAME_MSINODISABLEMEDIA TEXT(\"MSINODISABLEMEDIA\")")]
    public const string IPROPNAME_MSINODISABLEMEDIA = "MSINODISABLEMEDIA";

    /// <include file='IPROPNAME.xml' path='doc/member[@name="IPROPNAME.IPROPNAME_CARRYINGNDP"]/*' />
    [NativeTypeName("#define IPROPNAME_CARRYINGNDP TEXT(\"CARRYINGNDP\")")]
    public const string IPROPNAME_CARRYINGNDP = "CARRYINGNDP";

    /// <include file='IPROPNAME.xml' path='doc/member[@name="IPROPNAME.IPROPNAME_ENFORCE_UPGRADE_COMPONENT_RULES"]/*' />
    [NativeTypeName("#define IPROPNAME_ENFORCE_UPGRADE_COMPONENT_RULES TEXT(\"MSIENFORCEUPGRADECOMPONENTRULES\")")]
    public const string IPROPNAME_ENFORCE_UPGRADE_COMPONENT_RULES = "MSIENFORCEUPGRADECOMPONENTRULES";

    /// <include file='IPROPNAME.xml' path='doc/member[@name="IPROPNAME.IPROPNAME_MSINEWINSTANCE"]/*' />
    [NativeTypeName("#define IPROPNAME_MSINEWINSTANCE TEXT(\"MSINEWINSTANCE\")")]
    public const string IPROPNAME_MSINEWINSTANCE = "MSINEWINSTANCE";

    /// <include file='IPROPNAME.xml' path='doc/member[@name="IPROPNAME.IPROPNAME_MSIINSTANCEGUID"]/*' />
    [NativeTypeName("#define IPROPNAME_MSIINSTANCEGUID TEXT(\"MSIINSTANCEGUID\")")]
    public const string IPROPNAME_MSIINSTANCEGUID = "MSIINSTANCEGUID";

    /// <include file='IPROPNAME.xml' path='doc/member[@name="IPROPNAME.IPROPNAME_MSIPACKAGEDOWNLOADLOCALCOPY"]/*' />
    [NativeTypeName("#define IPROPNAME_MSIPACKAGEDOWNLOADLOCALCOPY TEXT(\"MSIPACKAGEDOWNLOADLOCALCOPY\")")]
    public const string IPROPNAME_MSIPACKAGEDOWNLOADLOCALCOPY = "MSIPACKAGEDOWNLOADLOCALCOPY";

    /// <include file='IPROPNAME.xml' path='doc/member[@name="IPROPNAME.IPROPNAME_MSIPATCHDOWNLOADLOCALCOPY"]/*' />
    [NativeTypeName("#define IPROPNAME_MSIPATCHDOWNLOADLOCALCOPY TEXT(\"MSIPATCHDOWNLOADLOCALCOPY\")")]
    public const string IPROPNAME_MSIPATCHDOWNLOADLOCALCOPY = "MSIPATCHDOWNLOADLOCALCOPY";

    /// <include file='IPROPNAME.xml' path='doc/member[@name="IPROPNAME.IPROPNAME_MSIDISABLELUAPATCHING"]/*' />
    [NativeTypeName("#define IPROPNAME_MSIDISABLELUAPATCHING TEXT(\"MSIDISABLELUAPATCHING\")")]
    public const string IPROPNAME_MSIDISABLELUAPATCHING = "MSIDISABLELUAPATCHING";

    /// <include file='IPROPNAME.xml' path='doc/member[@name="IPROPNAME.IPROPNAME_MSILOGGINGMODE"]/*' />
    [NativeTypeName("#define IPROPNAME_MSILOGGINGMODE TEXT(\"MsiLogging\")")]
    public const string IPROPNAME_MSILOGGINGMODE = "MsiLogging";

    /// <include file='IPROPNAME.xml' path='doc/member[@name="IPROPNAME.IPROPNAME_MSILOGFILELOCATION"]/*' />
    [NativeTypeName("#define IPROPNAME_MSILOGFILELOCATION TEXT(\"MsiLogFileLocation\")")]
    public const string IPROPNAME_MSILOGFILELOCATION = "MsiLogFileLocation";

    /// <include file='IPROPNAME.xml' path='doc/member[@name="IPROPNAME.IPROPNAME_MSI_RM_CONTROL"]/*' />
    [NativeTypeName("#define IPROPNAME_MSI_RM_CONTROL TEXT(\"MSIRESTARTMANAGERCONTROL\")")]
    public const string IPROPNAME_MSI_RM_CONTROL = "MSIRESTARTMANAGERCONTROL";

    /// <include file='IPROPNAME.xml' path='doc/member[@name="IPROPNAME.IPROPNAME_MSI_RM_SESSION_KEY"]/*' />
    [NativeTypeName("#define IPROPNAME_MSI_RM_SESSION_KEY TEXT(\"MsiRestartManagerSessionKey\")")]
    public const string IPROPNAME_MSI_RM_SESSION_KEY = "MsiRestartManagerSessionKey";

    /// <include file='IPROPNAME.xml' path='doc/member[@name="IPROPNAME.IPROPNAME_MSI_REBOOT_PENDING"]/*' />
    [NativeTypeName("#define IPROPNAME_MSI_REBOOT_PENDING TEXT(\"MsiSystemRebootPending\")")]
    public const string IPROPNAME_MSI_REBOOT_PENDING = "MsiSystemRebootPending";

    /// <include file='IPROPNAME.xml' path='doc/member[@name="IPROPNAME.IPROPNAME_MSI_RM_SHUTDOWN"]/*' />
    [NativeTypeName("#define IPROPNAME_MSI_RM_SHUTDOWN TEXT(\"MSIRMSHUTDOWN\")")]
    public const string IPROPNAME_MSI_RM_SHUTDOWN = "MSIRMSHUTDOWN";

    /// <include file='IPROPNAME.xml' path='doc/member[@name="IPROPNAME.IPROPNAME_MSI_RM_DISABLE_RESTART"]/*' />
    [NativeTypeName("#define IPROPNAME_MSI_RM_DISABLE_RESTART TEXT(\"MSIDISABLERMRESTART\")")]
    public const string IPROPNAME_MSI_RM_DISABLE_RESTART = "MSIDISABLERMRESTART";

    /// <include file='IPROPNAME.xml' path='doc/member[@name="IPROPNAME.IPROPNAME_MSI_UAC_DEPLOYMENT_COMPLIANT"]/*' />
    [NativeTypeName("#define IPROPNAME_MSI_UAC_DEPLOYMENT_COMPLIANT TEXT(\"MSIDEPLOYMENTCOMPLIANT\")")]
    public const string IPROPNAME_MSI_UAC_DEPLOYMENT_COMPLIANT = "MSIDEPLOYMENTCOMPLIANT";

    /// <include file='IPROPNAME.xml' path='doc/member[@name="IPROPNAME.IPROPNAME_MSI_USE_REAL_ADMIN_DETECTION"]/*' />
    [NativeTypeName("#define IPROPNAME_MSI_USE_REAL_ADMIN_DETECTION TEXT(\"MSIUSEREALADMINDETECTION\")")]
    public const string IPROPNAME_MSI_USE_REAL_ADMIN_DETECTION = "MSIUSEREALADMINDETECTION";

    /// <include file='IPROPNAME.xml' path='doc/member[@name="IPROPNAME.IPROPNAME_MSI_UNINSTALL_SUPERSEDED_COMPONENTS"]/*' />
    [NativeTypeName("#define IPROPNAME_MSI_UNINSTALL_SUPERSEDED_COMPONENTS TEXT(\"MSIUNINSTALLSUPERSEDEDCOMPONENTS\")")]
    public const string IPROPNAME_MSI_UNINSTALL_SUPERSEDED_COMPONENTS = "MSIUNINSTALLSUPERSEDEDCOMPONENTS";

    /// <include file='IPROPNAME.xml' path='doc/member[@name="IPROPNAME.IPROPNAME_MSIDISABLEEEUI"]/*' />
    [NativeTypeName("#define IPROPNAME_MSIDISABLEEEUI TEXT(\"MSIDISABLEEEUI\")")]
    public const string IPROPNAME_MSIDISABLEEEUI = "MSIDISABLEEEUI";

    /// <include file='IPROPNAME.xml' path='doc/member[@name="IPROPNAME.IPROPNAME_MSI_FASTINSTALL"]/*' />
    [NativeTypeName("#define IPROPNAME_MSI_FASTINSTALL TEXT(\"MSIFASTINSTALL\")")]
    public const string IPROPNAME_MSI_FASTINSTALL = "MSIFASTINSTALL";

    /// <include file='IPROPNAME.xml' path='doc/member[@name="IPROPNAME.IPROPNAME_INSTALLPERUSER"]/*' />
    [NativeTypeName("#define IPROPNAME_INSTALLPERUSER TEXT(\"MSIINSTALLPERUSER\")")]
    public const string IPROPNAME_INSTALLPERUSER = "MSIINSTALLPERUSER";

    /// <include file='IPROPNAME.xml' path='doc/member[@name="IPROPNAME.IPROPNAME_INTERNALINSTALLEDPERUSER"]/*' />
    [NativeTypeName("#define IPROPNAME_INTERNALINSTALLEDPERUSER TEXT(\"MSIINTERNALINSTALLEDPERUSER\")")]
    public const string IPROPNAME_INTERNALINSTALLEDPERUSER = "MSIINTERNALINSTALLEDPERUSER";

    /// <include file='IPROPNAME.xml' path='doc/member[@name="IPROPNAME.IPROPNAME_ARPAUTHORIZEDCDFPREFIX"]/*' />
    [NativeTypeName("#define IPROPNAME_ARPAUTHORIZEDCDFPREFIX TEXT(\"ARPAUTHORIZEDCDFPREFIX\")")]
    public const string IPROPNAME_ARPAUTHORIZEDCDFPREFIX = "ARPAUTHORIZEDCDFPREFIX";

    /// <include file='IPROPNAME.xml' path='doc/member[@name="IPROPNAME.IPROPNAME_ARPCOMMENTS"]/*' />
    [NativeTypeName("#define IPROPNAME_ARPCOMMENTS TEXT(\"ARPCOMMENTS\")")]
    public const string IPROPNAME_ARPCOMMENTS = "ARPCOMMENTS";

    /// <include file='IPROPNAME.xml' path='doc/member[@name="IPROPNAME.IPROPNAME_ARPCONTACT"]/*' />
    [NativeTypeName("#define IPROPNAME_ARPCONTACT TEXT(\"ARPCONTACT\")")]
    public const string IPROPNAME_ARPCONTACT = "ARPCONTACT";

    /// <include file='IPROPNAME.xml' path='doc/member[@name="IPROPNAME.IPROPNAME_ARPHELPLINK"]/*' />
    [NativeTypeName("#define IPROPNAME_ARPHELPLINK TEXT(\"ARPHELPLINK\")")]
    public const string IPROPNAME_ARPHELPLINK = "ARPHELPLINK";

    /// <include file='IPROPNAME.xml' path='doc/member[@name="IPROPNAME.IPROPNAME_ARPHELPTELEPHONE"]/*' />
    [NativeTypeName("#define IPROPNAME_ARPHELPTELEPHONE TEXT(\"ARPHELPTELEPHONE\")")]
    public const string IPROPNAME_ARPHELPTELEPHONE = "ARPHELPTELEPHONE";

    /// <include file='IPROPNAME.xml' path='doc/member[@name="IPROPNAME.IPROPNAME_ARPINSTALLLOCATION"]/*' />
    [NativeTypeName("#define IPROPNAME_ARPINSTALLLOCATION TEXT(\"ARPINSTALLLOCATION\")")]
    public const string IPROPNAME_ARPINSTALLLOCATION = "ARPINSTALLLOCATION";

    /// <include file='IPROPNAME.xml' path='doc/member[@name="IPROPNAME.IPROPNAME_ARPNOMODIFY"]/*' />
    [NativeTypeName("#define IPROPNAME_ARPNOMODIFY TEXT(\"ARPNOMODIFY\")")]
    public const string IPROPNAME_ARPNOMODIFY = "ARPNOMODIFY";

    /// <include file='IPROPNAME.xml' path='doc/member[@name="IPROPNAME.IPROPNAME_ARPNOREMOVE"]/*' />
    [NativeTypeName("#define IPROPNAME_ARPNOREMOVE TEXT(\"ARPNOREMOVE\")")]
    public const string IPROPNAME_ARPNOREMOVE = "ARPNOREMOVE";

    /// <include file='IPROPNAME.xml' path='doc/member[@name="IPROPNAME.IPROPNAME_ARPNOREPAIR"]/*' />
    [NativeTypeName("#define IPROPNAME_ARPNOREPAIR TEXT(\"ARPNOREPAIR\")")]
    public const string IPROPNAME_ARPNOREPAIR = "ARPNOREPAIR";

    /// <include file='IPROPNAME.xml' path='doc/member[@name="IPROPNAME.IPROPNAME_ARPREADME"]/*' />
    [NativeTypeName("#define IPROPNAME_ARPREADME TEXT(\"ARPREADME\")")]
    public const string IPROPNAME_ARPREADME = "ARPREADME";

    /// <include file='IPROPNAME.xml' path='doc/member[@name="IPROPNAME.IPROPNAME_ARPSIZE"]/*' />
    [NativeTypeName("#define IPROPNAME_ARPSIZE TEXT(\"ARPSIZE\")")]
    public const string IPROPNAME_ARPSIZE = "ARPSIZE";

    /// <include file='IPROPNAME.xml' path='doc/member[@name="IPROPNAME.IPROPNAME_ARPSYSTEMCOMPONENT"]/*' />
    [NativeTypeName("#define IPROPNAME_ARPSYSTEMCOMPONENT TEXT(\"ARPSYSTEMCOMPONENT\")")]
    public const string IPROPNAME_ARPSYSTEMCOMPONENT = "ARPSYSTEMCOMPONENT";

    /// <include file='IPROPNAME.xml' path='doc/member[@name="IPROPNAME.IPROPNAME_ARPURLINFOABOUT"]/*' />
    [NativeTypeName("#define IPROPNAME_ARPURLINFOABOUT TEXT(\"ARPURLINFOABOUT\")")]
    public const string IPROPNAME_ARPURLINFOABOUT = "ARPURLINFOABOUT";

    /// <include file='IPROPNAME.xml' path='doc/member[@name="IPROPNAME.IPROPNAME_ARPURLUPDATEINFO"]/*' />
    [NativeTypeName("#define IPROPNAME_ARPURLUPDATEINFO TEXT(\"ARPURLUPDATEINFO\")")]
    public const string IPROPNAME_ARPURLUPDATEINFO = "ARPURLUPDATEINFO";

    /// <include file='IPROPNAME.xml' path='doc/member[@name="IPROPNAME.IPROPNAME_ARPPRODUCTICON"]/*' />
    [NativeTypeName("#define IPROPNAME_ARPPRODUCTICON TEXT(\"ARPPRODUCTICON\")")]
    public const string IPROPNAME_ARPPRODUCTICON = "ARPPRODUCTICON";

    /// <include file='IPROPNAME.xml' path='doc/member[@name="IPROPNAME.IPROPNAME_ARPSETTINGSIDENTIFIER"]/*' />
    [NativeTypeName("#define IPROPNAME_ARPSETTINGSIDENTIFIER TEXT(\"MSIARPSETTINGSIDENTIFIER\")")]
    public const string IPROPNAME_ARPSETTINGSIDENTIFIER = "MSIARPSETTINGSIDENTIFIER";

    /// <include file='IPROPNAME.xml' path='doc/member[@name="IPROPNAME.IPROPNAME_ARPSHIMFLAGS"]/*' />
    [NativeTypeName("#define IPROPNAME_ARPSHIMFLAGS TEXT(\"SHIMFLAGS\")")]
    public const string IPROPNAME_ARPSHIMFLAGS = "SHIMFLAGS";

    /// <include file='IPROPNAME.xml' path='doc/member[@name="IPROPNAME.IPROPNAME_ARPSHIMVERSIONNT"]/*' />
    [NativeTypeName("#define IPROPNAME_ARPSHIMVERSIONNT TEXT(\"SHIMVERSIONNT\")")]
    public const string IPROPNAME_ARPSHIMVERSIONNT = "SHIMVERSIONNT";

    /// <include file='IPROPNAME.xml' path='doc/member[@name="IPROPNAME.IPROPNAME_ARPSHIMSERVICEPACKLEVEL"]/*' />
    [NativeTypeName("#define IPROPNAME_ARPSHIMSERVICEPACKLEVEL TEXT(\"SHIMSERVICEPACKLEVEL\")")]
    public const string IPROPNAME_ARPSHIMSERVICEPACKLEVEL = "SHIMSERVICEPACKLEVEL";

    /// <include file='IPROPNAME.xml' path='doc/member[@name="IPROPNAME.IPROPNAME_INSTALLED"]/*' />
    [NativeTypeName("#define IPROPNAME_INSTALLED TEXT(\"Installed\")")]
    public const string IPROPNAME_INSTALLED = "Installed";

    /// <include file='IPROPNAME.xml' path='doc/member[@name="IPROPNAME.IPROPNAME_PRODUCTSTATE"]/*' />
    [NativeTypeName("#define IPROPNAME_PRODUCTSTATE TEXT(\"ProductState\")")]
    public const string IPROPNAME_PRODUCTSTATE = "ProductState";

    /// <include file='IPROPNAME.xml' path='doc/member[@name="IPROPNAME.IPROPNAME_PRESELECTED"]/*' />
    [NativeTypeName("#define IPROPNAME_PRESELECTED TEXT(\"Preselected\")")]
    public const string IPROPNAME_PRESELECTED = "Preselected";

    /// <include file='IPROPNAME.xml' path='doc/member[@name="IPROPNAME.IPROPNAME_RESUME"]/*' />
    [NativeTypeName("#define IPROPNAME_RESUME TEXT(\"RESUME\")")]
    public const string IPROPNAME_RESUME = "RESUME";

    /// <include file='IPROPNAME.xml' path='doc/member[@name="IPROPNAME.IPROPNAME_UPDATESTARTED"]/*' />
    [NativeTypeName("#define IPROPNAME_UPDATESTARTED TEXT(\"UpdateStarted\")")]
    public const string IPROPNAME_UPDATESTARTED = "UpdateStarted";

    /// <include file='IPROPNAME.xml' path='doc/member[@name="IPROPNAME.IPROPNAME_PRODUCTID"]/*' />
    [NativeTypeName("#define IPROPNAME_PRODUCTID TEXT(\"ProductID\")")]
    public const string IPROPNAME_PRODUCTID = "ProductID";

    /// <include file='IPROPNAME.xml' path='doc/member[@name="IPROPNAME.IPROPNAME_OUTOFDISKSPACE"]/*' />
    [NativeTypeName("#define IPROPNAME_OUTOFDISKSPACE TEXT(\"OutOfDiskSpace\")")]
    public const string IPROPNAME_OUTOFDISKSPACE = "OutOfDiskSpace";

    /// <include file='IPROPNAME.xml' path='doc/member[@name="IPROPNAME.IPROPNAME_OUTOFNORBDISKSPACE"]/*' />
    [NativeTypeName("#define IPROPNAME_OUTOFNORBDISKSPACE TEXT(\"OutOfNoRbDiskSpace\")")]
    public const string IPROPNAME_OUTOFNORBDISKSPACE = "OutOfNoRbDiskSpace";

    /// <include file='IPROPNAME.xml' path='doc/member[@name="IPROPNAME.IPROPNAME_COSTINGCOMPLETE"]/*' />
    [NativeTypeName("#define IPROPNAME_COSTINGCOMPLETE TEXT(\"CostingComplete\")")]
    public const string IPROPNAME_COSTINGCOMPLETE = "CostingComplete";

    /// <include file='IPROPNAME.xml' path='doc/member[@name="IPROPNAME.IPROPNAME_SOURCEDIR"]/*' />
    [NativeTypeName("#define IPROPNAME_SOURCEDIR TEXT(\"SourceDir\")")]
    public const string IPROPNAME_SOURCEDIR = "SourceDir";

    /// <include file='IPROPNAME.xml' path='doc/member[@name="IPROPNAME.IPROPNAME_REPLACEDINUSEFILES"]/*' />
    [NativeTypeName("#define IPROPNAME_REPLACEDINUSEFILES TEXT(\"ReplacedInUseFiles\")")]
    public const string IPROPNAME_REPLACEDINUSEFILES = "ReplacedInUseFiles";

    /// <include file='IPROPNAME.xml' path='doc/member[@name="IPROPNAME.IPROPNAME_PRIMARYFOLDER_PATH"]/*' />
    [NativeTypeName("#define IPROPNAME_PRIMARYFOLDER_PATH TEXT(\"PrimaryVolumePath\")")]
    public const string IPROPNAME_PRIMARYFOLDER_PATH = "PrimaryVolumePath";

    /// <include file='IPROPNAME.xml' path='doc/member[@name="IPROPNAME.IPROPNAME_PRIMARYFOLDER_SPACEAVAILABLE"]/*' />
    [NativeTypeName("#define IPROPNAME_PRIMARYFOLDER_SPACEAVAILABLE TEXT(\"PrimaryVolumeSpaceAvailable\")")]
    public const string IPROPNAME_PRIMARYFOLDER_SPACEAVAILABLE = "PrimaryVolumeSpaceAvailable";

    /// <include file='IPROPNAME.xml' path='doc/member[@name="IPROPNAME.IPROPNAME_PRIMARYFOLDER_SPACEREQUIRED"]/*' />
    [NativeTypeName("#define IPROPNAME_PRIMARYFOLDER_SPACEREQUIRED TEXT(\"PrimaryVolumeSpaceRequired\")")]
    public const string IPROPNAME_PRIMARYFOLDER_SPACEREQUIRED = "PrimaryVolumeSpaceRequired";

    /// <include file='IPROPNAME.xml' path='doc/member[@name="IPROPNAME.IPROPNAME_PRIMARYFOLDER_SPACEREMAINING"]/*' />
    [NativeTypeName("#define IPROPNAME_PRIMARYFOLDER_SPACEREMAINING TEXT(\"PrimaryVolumeSpaceRemaining\")")]
    public const string IPROPNAME_PRIMARYFOLDER_SPACEREMAINING = "PrimaryVolumeSpaceRemaining";

    /// <include file='IPROPNAME.xml' path='doc/member[@name="IPROPNAME.IPROPNAME_ISADMINPACKAGE"]/*' />
    [NativeTypeName("#define IPROPNAME_ISADMINPACKAGE TEXT(\"IsAdminPackage\")")]
    public const string IPROPNAME_ISADMINPACKAGE = "IsAdminPackage";

    /// <include file='IPROPNAME.xml' path='doc/member[@name="IPROPNAME.IPROPNAME_ROLLBACKDISABLED"]/*' />
    [NativeTypeName("#define IPROPNAME_ROLLBACKDISABLED TEXT(\"RollbackDisabled\")")]
    public const string IPROPNAME_ROLLBACKDISABLED = "RollbackDisabled";

    /// <include file='IPROPNAME.xml' path='doc/member[@name="IPROPNAME.IPROPNAME_RESTRICTEDUSERCONTROL"]/*' />
    [NativeTypeName("#define IPROPNAME_RESTRICTEDUSERCONTROL TEXT(\"RestrictedUserControl\")")]
    public const string IPROPNAME_RESTRICTEDUSERCONTROL = "RestrictedUserControl";

    /// <include file='IPROPNAME.xml' path='doc/member[@name="IPROPNAME.IPROPNAME_SOURCERESONLY"]/*' />
    [NativeTypeName("#define IPROPNAME_SOURCERESONLY TEXT(\"MsiUISourceResOnly\")")]
    public const string IPROPNAME_SOURCERESONLY = "MsiUISourceResOnly";

    /// <include file='IPROPNAME.xml' path='doc/member[@name="IPROPNAME.IPROPNAME_HIDECANCEL"]/*' />
    [NativeTypeName("#define IPROPNAME_HIDECANCEL TEXT(\"MsiUIHideCancel\")")]
    public const string IPROPNAME_HIDECANCEL = "MsiUIHideCancel";

    /// <include file='IPROPNAME.xml' path='doc/member[@name="IPROPNAME.IPROPNAME_PROGRESSONLY"]/*' />
    [NativeTypeName("#define IPROPNAME_PROGRESSONLY TEXT(\"MsiUIProgressOnly\")")]
    public const string IPROPNAME_PROGRESSONLY = "MsiUIProgressOnly";

    /// <include file='IPROPNAME.xml' path='doc/member[@name="IPROPNAME.IPROPNAME_UACONLY"]/*' />
    [NativeTypeName("#define IPROPNAME_UACONLY TEXT(\"MsiUIUACOnly\")")]
    public const string IPROPNAME_UACONLY = "MsiUIUACOnly";

    /// <include file='IPROPNAME.xml' path='doc/member[@name="IPROPNAME.IPROPNAME_TIME"]/*' />
    [NativeTypeName("#define IPROPNAME_TIME TEXT(\"Time\")")]
    public const string IPROPNAME_TIME = "Time";

    /// <include file='IPROPNAME.xml' path='doc/member[@name="IPROPNAME.IPROPNAME_DATE"]/*' />
    [NativeTypeName("#define IPROPNAME_DATE TEXT(\"Date\")")]
    public const string IPROPNAME_DATE = "Date";

    /// <include file='IPROPNAME.xml' path='doc/member[@name="IPROPNAME.IPROPNAME_DATETIME"]/*' />
    [NativeTypeName("#define IPROPNAME_DATETIME TEXT(\"DateTime\")")]
    public const string IPROPNAME_DATETIME = "DateTime";

    /// <include file='IPROPNAME.xml' path='doc/member[@name="IPROPNAME.IPROPNAME_ARM"]/*' />
    [NativeTypeName("#define IPROPNAME_ARM TEXT(\"Arm\")")]
    public const string IPROPNAME_ARM = "Arm";

    /// <include file='IPROPNAME.xml' path='doc/member[@name="IPROPNAME.IPROPNAME_ARM64"]/*' />
    [NativeTypeName("#define IPROPNAME_ARM64 TEXT(\"Arm64\")")]
    public const string IPROPNAME_ARM64 = "Arm64";

    /// <include file='IPROPNAME.xml' path='doc/member[@name="IPROPNAME.IPROPNAME_INTEL"]/*' />
    [NativeTypeName("#define IPROPNAME_INTEL TEXT(\"Intel\")")]
    public const string IPROPNAME_INTEL = "Intel";

    /// <include file='IPROPNAME.xml' path='doc/member[@name="IPROPNAME.IPROPNAME_TEMPLATE_AMD64"]/*' />
    [NativeTypeName("#define IPROPNAME_TEMPLATE_AMD64 TEXT(\"AMD64\")")]
    public const string IPROPNAME_TEMPLATE_AMD64 = "AMD64";

    /// <include file='IPROPNAME.xml' path='doc/member[@name="IPROPNAME.IPROPNAME_TEMPLATE_X64"]/*' />
    [NativeTypeName("#define IPROPNAME_TEMPLATE_X64 TEXT(\"x64\")")]
    public const string IPROPNAME_TEMPLATE_X64 = "x64";

    /// <include file='IPROPNAME.xml' path='doc/member[@name="IPROPNAME.IPROPNAME_MSIAMD64"]/*' />
    [NativeTypeName("#define IPROPNAME_MSIAMD64 TEXT(\"MsiAMD64\")")]
    public const string IPROPNAME_MSIAMD64 = "MsiAMD64";

    /// <include file='IPROPNAME.xml' path='doc/member[@name="IPROPNAME.IPROPNAME_MSIX64"]/*' />
    [NativeTypeName("#define IPROPNAME_MSIX64 TEXT(\"Msix64\")")]
    public const string IPROPNAME_MSIX64 = "Msix64";

    /// <include file='IPROPNAME.xml' path='doc/member[@name="IPROPNAME.IPROPNAME_INTEL64"]/*' />
    [NativeTypeName("#define IPROPNAME_INTEL64 TEXT(\"Intel64\")")]
    public const string IPROPNAME_INTEL64 = "Intel64";

    /// <include file='IPROPNAME.xml' path='doc/member[@name="IPROPNAME.IPROPNAME_TEXTHEIGHT"]/*' />
    [NativeTypeName("#define IPROPNAME_TEXTHEIGHT TEXT(\"TextHeight\")")]
    public const string IPROPNAME_TEXTHEIGHT = "TextHeight";

    /// <include file='IPROPNAME.xml' path='doc/member[@name="IPROPNAME.IPROPNAME_TEXTINTERNALLEADING"]/*' />
    [NativeTypeName("#define IPROPNAME_TEXTINTERNALLEADING TEXT(\"TextInternalLeading\")")]
    public const string IPROPNAME_TEXTINTERNALLEADING = "TextInternalLeading";

    /// <include file='IPROPNAME.xml' path='doc/member[@name="IPROPNAME.IPROPNAME_SCREENX"]/*' />
    [NativeTypeName("#define IPROPNAME_SCREENX TEXT(\"ScreenX\")")]
    public const string IPROPNAME_SCREENX = "ScreenX";

    /// <include file='IPROPNAME.xml' path='doc/member[@name="IPROPNAME.IPROPNAME_SCREENY"]/*' />
    [NativeTypeName("#define IPROPNAME_SCREENY TEXT(\"ScreenY\")")]
    public const string IPROPNAME_SCREENY = "ScreenY";

    /// <include file='IPROPNAME.xml' path='doc/member[@name="IPROPNAME.IPROPNAME_CAPTIONHEIGHT"]/*' />
    [NativeTypeName("#define IPROPNAME_CAPTIONHEIGHT TEXT(\"CaptionHeight\")")]
    public const string IPROPNAME_CAPTIONHEIGHT = "CaptionHeight";

    /// <include file='IPROPNAME.xml' path='doc/member[@name="IPROPNAME.IPROPNAME_BORDERTOP"]/*' />
    [NativeTypeName("#define IPROPNAME_BORDERTOP TEXT(\"BorderTop\")")]
    public const string IPROPNAME_BORDERTOP = "BorderTop";

    /// <include file='IPROPNAME.xml' path='doc/member[@name="IPROPNAME.IPROPNAME_BORDERSIDE"]/*' />
    [NativeTypeName("#define IPROPNAME_BORDERSIDE TEXT(\"BorderSide\")")]
    public const string IPROPNAME_BORDERSIDE = "BorderSide";

    /// <include file='IPROPNAME.xml' path='doc/member[@name="IPROPNAME.IPROPNAME_COLORBITS"]/*' />
    [NativeTypeName("#define IPROPNAME_COLORBITS TEXT(\"ColorBits\")")]
    public const string IPROPNAME_COLORBITS = "ColorBits";

    /// <include file='IPROPNAME.xml' path='doc/member[@name="IPROPNAME.IPROPNAME_PHYSICALMEMORY"]/*' />
    [NativeTypeName("#define IPROPNAME_PHYSICALMEMORY TEXT(\"PhysicalMemory\")")]
    public const string IPROPNAME_PHYSICALMEMORY = "PhysicalMemory";

    /// <include file='IPROPNAME.xml' path='doc/member[@name="IPROPNAME.IPROPNAME_VIRTUALMEMORY"]/*' />
    [NativeTypeName("#define IPROPNAME_VIRTUALMEMORY TEXT(\"VirtualMemory\")")]
    public const string IPROPNAME_VIRTUALMEMORY = "VirtualMemory";

    /// <include file='IPROPNAME.xml' path='doc/member[@name="IPROPNAME.IPROPNAME_TEXTHEIGHT_CORRECTION"]/*' />
    [NativeTypeName("#define IPROPNAME_TEXTHEIGHT_CORRECTION TEXT(\"TextHeightCorrection\")")]
    public const string IPROPNAME_TEXTHEIGHT_CORRECTION = "TextHeightCorrection";

    /// <include file='IPROPNAME.xml' path='doc/member[@name="IPROPNAME.IPROPNAME_MSITABLETPC"]/*' />
    [NativeTypeName("#define IPROPNAME_MSITABLETPC TEXT(\"MsiTabletPC\")")]
    public const string IPROPNAME_MSITABLETPC = "MsiTabletPC";

    /// <include file='IPROPNAME.xml' path='doc/member[@name="IPROPNAME.IPROPNAME_VERSIONNT"]/*' />
    [NativeTypeName("#define IPROPNAME_VERSIONNT TEXT(\"VersionNT\")")]
    public const string IPROPNAME_VERSIONNT = "VersionNT";

    /// <include file='IPROPNAME.xml' path='doc/member[@name="IPROPNAME.IPROPNAME_VERSION9X"]/*' />
    [NativeTypeName("#define IPROPNAME_VERSION9X TEXT(\"Version9X\")")]
    public const string IPROPNAME_VERSION9X = "Version9X";

    /// <include file='IPROPNAME.xml' path='doc/member[@name="IPROPNAME.IPROPNAME_VERSIONNT64"]/*' />
    [NativeTypeName("#define IPROPNAME_VERSIONNT64 TEXT(\"VersionNT64\")")]
    public const string IPROPNAME_VERSIONNT64 = "VersionNT64";

    /// <include file='IPROPNAME.xml' path='doc/member[@name="IPROPNAME.IPROPNAME_WINDOWSBUILD"]/*' />
    [NativeTypeName("#define IPROPNAME_WINDOWSBUILD TEXT(\"WindowsBuild\")")]
    public const string IPROPNAME_WINDOWSBUILD = "WindowsBuild";

    /// <include file='IPROPNAME.xml' path='doc/member[@name="IPROPNAME.IPROPNAME_SERVICEPACKLEVEL"]/*' />
    [NativeTypeName("#define IPROPNAME_SERVICEPACKLEVEL TEXT(\"ServicePackLevel\")")]
    public const string IPROPNAME_SERVICEPACKLEVEL = "ServicePackLevel";

    /// <include file='IPROPNAME.xml' path='doc/member[@name="IPROPNAME.IPROPNAME_SERVICEPACKLEVELMINOR"]/*' />
    [NativeTypeName("#define IPROPNAME_SERVICEPACKLEVELMINOR TEXT(\"ServicePackLevelMinor\")")]
    public const string IPROPNAME_SERVICEPACKLEVELMINOR = "ServicePackLevelMinor";

    /// <include file='IPROPNAME.xml' path='doc/member[@name="IPROPNAME.IPROPNAME_SHAREDWINDOWS"]/*' />
    [NativeTypeName("#define IPROPNAME_SHAREDWINDOWS TEXT(\"SharedWindows\")")]
    public const string IPROPNAME_SHAREDWINDOWS = "SharedWindows";

    /// <include file='IPROPNAME.xml' path='doc/member[@name="IPROPNAME.IPROPNAME_COMPUTERNAME"]/*' />
    [NativeTypeName("#define IPROPNAME_COMPUTERNAME TEXT(\"ComputerName\")")]
    public const string IPROPNAME_COMPUTERNAME = "ComputerName";

    /// <include file='IPROPNAME.xml' path='doc/member[@name="IPROPNAME.IPROPNAME_SHELLADVTSUPPORT"]/*' />
    [NativeTypeName("#define IPROPNAME_SHELLADVTSUPPORT TEXT(\"ShellAdvtSupport\")")]
    public const string IPROPNAME_SHELLADVTSUPPORT = "ShellAdvtSupport";

    /// <include file='IPROPNAME.xml' path='doc/member[@name="IPROPNAME.IPROPNAME_OLEADVTSUPPORT"]/*' />
    [NativeTypeName("#define IPROPNAME_OLEADVTSUPPORT TEXT(\"OLEAdvtSupport\")")]
    public const string IPROPNAME_OLEADVTSUPPORT = "OLEAdvtSupport";

    /// <include file='IPROPNAME.xml' path='doc/member[@name="IPROPNAME.IPROPNAME_SYSTEMLANGUAGEID"]/*' />
    [NativeTypeName("#define IPROPNAME_SYSTEMLANGUAGEID TEXT(\"SystemLanguageID\")")]
    public const string IPROPNAME_SYSTEMLANGUAGEID = "SystemLanguageID";

    /// <include file='IPROPNAME.xml' path='doc/member[@name="IPROPNAME.IPROPNAME_TTCSUPPORT"]/*' />
    [NativeTypeName("#define IPROPNAME_TTCSUPPORT TEXT(\"TTCSupport\")")]
    public const string IPROPNAME_TTCSUPPORT = "TTCSupport";

    /// <include file='IPROPNAME.xml' path='doc/member[@name="IPROPNAME.IPROPNAME_TERMSERVER"]/*' />
    [NativeTypeName("#define IPROPNAME_TERMSERVER TEXT(\"TerminalServer\")")]
    public const string IPROPNAME_TERMSERVER = "TerminalServer";

    /// <include file='IPROPNAME.xml' path='doc/member[@name="IPROPNAME.IPROPNAME_REMOTEADMINTS"]/*' />
    [NativeTypeName("#define IPROPNAME_REMOTEADMINTS TEXT(\"RemoteAdminTS\")")]
    public const string IPROPNAME_REMOTEADMINTS = "RemoteAdminTS";

    /// <include file='IPROPNAME.xml' path='doc/member[@name="IPROPNAME.IPROPNAME_REDIRECTEDDLLSUPPORT"]/*' />
    [NativeTypeName("#define IPROPNAME_REDIRECTEDDLLSUPPORT TEXT(\"RedirectedDllSupport\")")]
    public const string IPROPNAME_REDIRECTEDDLLSUPPORT = "RedirectedDllSupport";

    /// <include file='IPROPNAME.xml' path='doc/member[@name="IPROPNAME.IPROPNAME_NTPRODUCTTYPE"]/*' />
    [NativeTypeName("#define IPROPNAME_NTPRODUCTTYPE TEXT(\"MsiNTProductType\")")]
    public const string IPROPNAME_NTPRODUCTTYPE = "MsiNTProductType";

    /// <include file='IPROPNAME.xml' path='doc/member[@name="IPROPNAME.IPROPNAME_NTSUITEBACKOFFICE"]/*' />
    [NativeTypeName("#define IPROPNAME_NTSUITEBACKOFFICE TEXT(\"MsiNTSuiteBackOffice\")")]
    public const string IPROPNAME_NTSUITEBACKOFFICE = "MsiNTSuiteBackOffice";

    /// <include file='IPROPNAME.xml' path='doc/member[@name="IPROPNAME.IPROPNAME_NTSUITEDATACENTER"]/*' />
    [NativeTypeName("#define IPROPNAME_NTSUITEDATACENTER TEXT(\"MsiNTSuiteDataCenter\")")]
    public const string IPROPNAME_NTSUITEDATACENTER = "MsiNTSuiteDataCenter";

    /// <include file='IPROPNAME.xml' path='doc/member[@name="IPROPNAME.IPROPNAME_NTSUITEENTERPRISE"]/*' />
    [NativeTypeName("#define IPROPNAME_NTSUITEENTERPRISE TEXT(\"MsiNTSuiteEnterprise\")")]
    public const string IPROPNAME_NTSUITEENTERPRISE = "MsiNTSuiteEnterprise";

    /// <include file='IPROPNAME.xml' path='doc/member[@name="IPROPNAME.IPROPNAME_NTSUITESMALLBUSINESS"]/*' />
    [NativeTypeName("#define IPROPNAME_NTSUITESMALLBUSINESS TEXT(\"MsiNTSuiteSmallBusiness\")")]
    public const string IPROPNAME_NTSUITESMALLBUSINESS = "MsiNTSuiteSmallBusiness";

    /// <include file='IPROPNAME.xml' path='doc/member[@name="IPROPNAME.IPROPNAME_NTSUITESMALLBUSINESSRESTRICTED"]/*' />
    [NativeTypeName("#define IPROPNAME_NTSUITESMALLBUSINESSRESTRICTED TEXT(\"MsiNTSuiteSmallBusinessRestricted\")")]
    public const string IPROPNAME_NTSUITESMALLBUSINESSRESTRICTED = "MsiNTSuiteSmallBusinessRestricted";

    /// <include file='IPROPNAME.xml' path='doc/member[@name="IPROPNAME.IPROPNAME_NTSUITEPERSONAL"]/*' />
    [NativeTypeName("#define IPROPNAME_NTSUITEPERSONAL TEXT(\"MsiNTSuitePersonal\")")]
    public const string IPROPNAME_NTSUITEPERSONAL = "MsiNTSuitePersonal";

    /// <include file='IPROPNAME.xml' path='doc/member[@name="IPROPNAME.IPROPNAME_NTSUITEWEBSERVER"]/*' />
    [NativeTypeName("#define IPROPNAME_NTSUITEWEBSERVER TEXT(\"MsiNTSuiteWebServer\")")]
    public const string IPROPNAME_NTSUITEWEBSERVER = "MsiNTSuiteWebServer";

    /// <include file='IPROPNAME.xml' path='doc/member[@name="IPROPNAME.IPROPNAME_NETASSEMBLYSUPPORT"]/*' />
    [NativeTypeName("#define IPROPNAME_NETASSEMBLYSUPPORT TEXT(\"MsiNetAssemblySupport\")")]
    public const string IPROPNAME_NETASSEMBLYSUPPORT = "MsiNetAssemblySupport";

    /// <include file='IPROPNAME.xml' path='doc/member[@name="IPROPNAME.IPROPNAME_WIN32ASSEMBLYSUPPORT"]/*' />
    [NativeTypeName("#define IPROPNAME_WIN32ASSEMBLYSUPPORT TEXT(\"MsiWin32AssemblySupport\")")]
    public const string IPROPNAME_WIN32ASSEMBLYSUPPORT = "MsiWin32AssemblySupport";

    /// <include file='IPROPNAME.xml' path='doc/member[@name="IPROPNAME.IPROPNAME_LOGONUSER"]/*' />
    [NativeTypeName("#define IPROPNAME_LOGONUSER TEXT(\"LogonUser\")")]
    public const string IPROPNAME_LOGONUSER = "LogonUser";

    /// <include file='IPROPNAME.xml' path='doc/member[@name="IPROPNAME.IPROPNAME_USERSID"]/*' />
    [NativeTypeName("#define IPROPNAME_USERSID TEXT(\"UserSID\")")]
    public const string IPROPNAME_USERSID = "UserSID";

    /// <include file='IPROPNAME.xml' path='doc/member[@name="IPROPNAME.IPROPNAME_ADMINUSER"]/*' />
    [NativeTypeName("#define IPROPNAME_ADMINUSER TEXT(\"AdminUser\")")]
    public const string IPROPNAME_ADMINUSER = "AdminUser";

    /// <include file='IPROPNAME.xml' path='doc/member[@name="IPROPNAME.IPROPNAME_USERLANGUAGEID"]/*' />
    [NativeTypeName("#define IPROPNAME_USERLANGUAGEID TEXT(\"UserLanguageID\")")]
    public const string IPROPNAME_USERLANGUAGEID = "UserLanguageID";

    /// <include file='IPROPNAME.xml' path='doc/member[@name="IPROPNAME.IPROPNAME_PRIVILEGED"]/*' />
    [NativeTypeName("#define IPROPNAME_PRIVILEGED TEXT(\"Privileged\")")]
    public const string IPROPNAME_PRIVILEGED = "Privileged";

    /// <include file='IPROPNAME.xml' path='doc/member[@name="IPROPNAME.IPROPNAME_RUNNINGELEVATED"]/*' />
    [NativeTypeName("#define IPROPNAME_RUNNINGELEVATED TEXT(\"MsiRunningElevated\")")]
    public const string IPROPNAME_RUNNINGELEVATED = "MsiRunningElevated";

    /// <include file='IPROPNAME.xml' path='doc/member[@name="IPROPNAME.IPROPNAME_TRUEADMINUSER"]/*' />
    [NativeTypeName("#define IPROPNAME_TRUEADMINUSER TEXT(\"MsiTrueAdminUser\")")]
    public const string IPROPNAME_TRUEADMINUSER = "MsiTrueAdminUser";

    /// <include file='IPROPNAME.xml' path='doc/member[@name="IPROPNAME.IPROPNAME_WINDOWS_FOLDER"]/*' />
    [NativeTypeName("#define IPROPNAME_WINDOWS_FOLDER TEXT(\"WindowsFolder\")")]
    public const string IPROPNAME_WINDOWS_FOLDER = "WindowsFolder";

    /// <include file='IPROPNAME.xml' path='doc/member[@name="IPROPNAME.IPROPNAME_SYSTEM_FOLDER"]/*' />
    [NativeTypeName("#define IPROPNAME_SYSTEM_FOLDER TEXT(\"SystemFolder\")")]
    public const string IPROPNAME_SYSTEM_FOLDER = "SystemFolder";

    /// <include file='IPROPNAME.xml' path='doc/member[@name="IPROPNAME.IPROPNAME_SYSTEM16_FOLDER"]/*' />
    [NativeTypeName("#define IPROPNAME_SYSTEM16_FOLDER TEXT(\"System16Folder\")")]
    public const string IPROPNAME_SYSTEM16_FOLDER = "System16Folder";

    /// <include file='IPROPNAME.xml' path='doc/member[@name="IPROPNAME.IPROPNAME_WINDOWS_VOLUME"]/*' />
    [NativeTypeName("#define IPROPNAME_WINDOWS_VOLUME TEXT(\"WindowsVolume\")")]
    public const string IPROPNAME_WINDOWS_VOLUME = "WindowsVolume";

    /// <include file='IPROPNAME.xml' path='doc/member[@name="IPROPNAME.IPROPNAME_TEMP_FOLDER"]/*' />
    [NativeTypeName("#define IPROPNAME_TEMP_FOLDER TEXT(\"TempFolder\")")]
    public const string IPROPNAME_TEMP_FOLDER = "TempFolder";

    /// <include file='IPROPNAME.xml' path='doc/member[@name="IPROPNAME.IPROPNAME_PROGRAMFILES_FOLDER"]/*' />
    [NativeTypeName("#define IPROPNAME_PROGRAMFILES_FOLDER TEXT(\"ProgramFilesFolder\")")]
    public const string IPROPNAME_PROGRAMFILES_FOLDER = "ProgramFilesFolder";

    /// <include file='IPROPNAME.xml' path='doc/member[@name="IPROPNAME.IPROPNAME_COMMONFILES_FOLDER"]/*' />
    [NativeTypeName("#define IPROPNAME_COMMONFILES_FOLDER TEXT(\"CommonFilesFolder\")")]
    public const string IPROPNAME_COMMONFILES_FOLDER = "CommonFilesFolder";

    /// <include file='IPROPNAME.xml' path='doc/member[@name="IPROPNAME.IPROPNAME_SYSTEM64_FOLDER"]/*' />
    [NativeTypeName("#define IPROPNAME_SYSTEM64_FOLDER TEXT(\"System64Folder\")")]
    public const string IPROPNAME_SYSTEM64_FOLDER = "System64Folder";

    /// <include file='IPROPNAME.xml' path='doc/member[@name="IPROPNAME.IPROPNAME_PROGRAMFILES64_FOLDER"]/*' />
    [NativeTypeName("#define IPROPNAME_PROGRAMFILES64_FOLDER TEXT(\"ProgramFiles64Folder\")")]
    public const string IPROPNAME_PROGRAMFILES64_FOLDER = "ProgramFiles64Folder";

    /// <include file='IPROPNAME.xml' path='doc/member[@name="IPROPNAME.IPROPNAME_COMMONFILES64_FOLDER"]/*' />
    [NativeTypeName("#define IPROPNAME_COMMONFILES64_FOLDER TEXT(\"CommonFiles64Folder\")")]
    public const string IPROPNAME_COMMONFILES64_FOLDER = "CommonFiles64Folder";

    /// <include file='IPROPNAME.xml' path='doc/member[@name="IPROPNAME.IPROPNAME_STARTMENU_FOLDER"]/*' />
    [NativeTypeName("#define IPROPNAME_STARTMENU_FOLDER TEXT(\"StartMenuFolder\")")]
    public const string IPROPNAME_STARTMENU_FOLDER = "StartMenuFolder";

    /// <include file='IPROPNAME.xml' path='doc/member[@name="IPROPNAME.IPROPNAME_PROGRAMMENU_FOLDER"]/*' />
    [NativeTypeName("#define IPROPNAME_PROGRAMMENU_FOLDER TEXT(\"ProgramMenuFolder\")")]
    public const string IPROPNAME_PROGRAMMENU_FOLDER = "ProgramMenuFolder";

    /// <include file='IPROPNAME.xml' path='doc/member[@name="IPROPNAME.IPROPNAME_STARTUP_FOLDER"]/*' />
    [NativeTypeName("#define IPROPNAME_STARTUP_FOLDER TEXT(\"StartupFolder\")")]
    public const string IPROPNAME_STARTUP_FOLDER = "StartupFolder";

    /// <include file='IPROPNAME.xml' path='doc/member[@name="IPROPNAME.IPROPNAME_NETHOOD_FOLDER"]/*' />
    [NativeTypeName("#define IPROPNAME_NETHOOD_FOLDER TEXT(\"NetHoodFolder\")")]
    public const string IPROPNAME_NETHOOD_FOLDER = "NetHoodFolder";

    /// <include file='IPROPNAME.xml' path='doc/member[@name="IPROPNAME.IPROPNAME_PERSONAL_FOLDER"]/*' />
    [NativeTypeName("#define IPROPNAME_PERSONAL_FOLDER TEXT(\"PersonalFolder\")")]
    public const string IPROPNAME_PERSONAL_FOLDER = "PersonalFolder";

    /// <include file='IPROPNAME.xml' path='doc/member[@name="IPROPNAME.IPROPNAME_SENDTO_FOLDER"]/*' />
    [NativeTypeName("#define IPROPNAME_SENDTO_FOLDER TEXT(\"SendToFolder\")")]
    public const string IPROPNAME_SENDTO_FOLDER = "SendToFolder";

    /// <include file='IPROPNAME.xml' path='doc/member[@name="IPROPNAME.IPROPNAME_DESKTOP_FOLDER"]/*' />
    [NativeTypeName("#define IPROPNAME_DESKTOP_FOLDER TEXT(\"DesktopFolder\")")]
    public const string IPROPNAME_DESKTOP_FOLDER = "DesktopFolder";

    /// <include file='IPROPNAME.xml' path='doc/member[@name="IPROPNAME.IPROPNAME_TEMPLATE_FOLDER"]/*' />
    [NativeTypeName("#define IPROPNAME_TEMPLATE_FOLDER TEXT(\"TemplateFolder\")")]
    public const string IPROPNAME_TEMPLATE_FOLDER = "TemplateFolder";

    /// <include file='IPROPNAME.xml' path='doc/member[@name="IPROPNAME.IPROPNAME_FONTS_FOLDER"]/*' />
    [NativeTypeName("#define IPROPNAME_FONTS_FOLDER TEXT(\"FontsFolder\")")]
    public const string IPROPNAME_FONTS_FOLDER = "FontsFolder";

    /// <include file='IPROPNAME.xml' path='doc/member[@name="IPROPNAME.IPROPNAME_FAVORITES_FOLDER"]/*' />
    [NativeTypeName("#define IPROPNAME_FAVORITES_FOLDER TEXT(\"FavoritesFolder\")")]
    public const string IPROPNAME_FAVORITES_FOLDER = "FavoritesFolder";

    /// <include file='IPROPNAME.xml' path='doc/member[@name="IPROPNAME.IPROPNAME_RECENT_FOLDER"]/*' />
    [NativeTypeName("#define IPROPNAME_RECENT_FOLDER TEXT(\"RecentFolder\")")]
    public const string IPROPNAME_RECENT_FOLDER = "RecentFolder";

    /// <include file='IPROPNAME.xml' path='doc/member[@name="IPROPNAME.IPROPNAME_APPDATA_FOLDER"]/*' />
    [NativeTypeName("#define IPROPNAME_APPDATA_FOLDER TEXT(\"AppDataFolder\")")]
    public const string IPROPNAME_APPDATA_FOLDER = "AppDataFolder";

    /// <include file='IPROPNAME.xml' path='doc/member[@name="IPROPNAME.IPROPNAME_PRINTHOOD_FOLDER"]/*' />
    [NativeTypeName("#define IPROPNAME_PRINTHOOD_FOLDER TEXT(\"PrintHoodFolder\")")]
    public const string IPROPNAME_PRINTHOOD_FOLDER = "PrintHoodFolder";

    /// <include file='IPROPNAME.xml' path='doc/member[@name="IPROPNAME.IPROPNAME_ADMINTOOLS_FOLDER"]/*' />
    [NativeTypeName("#define IPROPNAME_ADMINTOOLS_FOLDER TEXT(\"AdminToolsFolder\")")]
    public const string IPROPNAME_ADMINTOOLS_FOLDER = "AdminToolsFolder";

    /// <include file='IPROPNAME.xml' path='doc/member[@name="IPROPNAME.IPROPNAME_COMMONAPPDATA_FOLDER"]/*' />
    [NativeTypeName("#define IPROPNAME_COMMONAPPDATA_FOLDER TEXT(\"CommonAppDataFolder\")")]
    public const string IPROPNAME_COMMONAPPDATA_FOLDER = "CommonAppDataFolder";

    /// <include file='IPROPNAME.xml' path='doc/member[@name="IPROPNAME.IPROPNAME_LOCALAPPDATA_FOLDER"]/*' />
    [NativeTypeName("#define IPROPNAME_LOCALAPPDATA_FOLDER TEXT(\"LocalAppDataFolder\")")]
    public const string IPROPNAME_LOCALAPPDATA_FOLDER = "LocalAppDataFolder";

    /// <include file='IPROPNAME.xml' path='doc/member[@name="IPROPNAME.IPROPNAME_MYPICTURES_FOLDER"]/*' />
    [NativeTypeName("#define IPROPNAME_MYPICTURES_FOLDER TEXT(\"MyPicturesFolder\")")]
    public const string IPROPNAME_MYPICTURES_FOLDER = "MyPicturesFolder";

    /// <include file='IPROPNAME.xml' path='doc/member[@name="IPROPNAME.IPROPNAME_FEATUREADDLOCAL"]/*' />
    [NativeTypeName("#define IPROPNAME_FEATUREADDLOCAL TEXT(\"ADDLOCAL\")")]
    public const string IPROPNAME_FEATUREADDLOCAL = "ADDLOCAL";

    /// <include file='IPROPNAME.xml' path='doc/member[@name="IPROPNAME.IPROPNAME_FEATUREADDSOURCE"]/*' />
    [NativeTypeName("#define IPROPNAME_FEATUREADDSOURCE TEXT(\"ADDSOURCE\")")]
    public const string IPROPNAME_FEATUREADDSOURCE = "ADDSOURCE";

    /// <include file='IPROPNAME.xml' path='doc/member[@name="IPROPNAME.IPROPNAME_FEATUREADDDEFAULT"]/*' />
    [NativeTypeName("#define IPROPNAME_FEATUREADDDEFAULT TEXT(\"ADDDEFAULT\")")]
    public const string IPROPNAME_FEATUREADDDEFAULT = "ADDDEFAULT";

    /// <include file='IPROPNAME.xml' path='doc/member[@name="IPROPNAME.IPROPNAME_FEATUREREMOVE"]/*' />
    [NativeTypeName("#define IPROPNAME_FEATUREREMOVE TEXT(\"REMOVE\")")]
    public const string IPROPNAME_FEATUREREMOVE = "REMOVE";

    /// <include file='IPROPNAME.xml' path='doc/member[@name="IPROPNAME.IPROPNAME_FEATUREADVERTISE"]/*' />
    [NativeTypeName("#define IPROPNAME_FEATUREADVERTISE TEXT(\"ADVERTISE\")")]
    public const string IPROPNAME_FEATUREADVERTISE = "ADVERTISE";

    /// <include file='IPROPNAME.xml' path='doc/member[@name="IPROPNAME.IPROPNAME_COMPONENTADDLOCAL"]/*' />
    [NativeTypeName("#define IPROPNAME_COMPONENTADDLOCAL TEXT(\"COMPADDLOCAL\")")]
    public const string IPROPNAME_COMPONENTADDLOCAL = "COMPADDLOCAL";

    /// <include file='IPROPNAME.xml' path='doc/member[@name="IPROPNAME.IPROPNAME_COMPONENTADDSOURCE"]/*' />
    [NativeTypeName("#define IPROPNAME_COMPONENTADDSOURCE TEXT(\"COMPADDSOURCE\")")]
    public const string IPROPNAME_COMPONENTADDSOURCE = "COMPADDSOURCE";

    /// <include file='IPROPNAME.xml' path='doc/member[@name="IPROPNAME.IPROPNAME_COMPONENTADDDEFAULT"]/*' />
    [NativeTypeName("#define IPROPNAME_COMPONENTADDDEFAULT TEXT(\"COMPADDDEFAULT\")")]
    public const string IPROPNAME_COMPONENTADDDEFAULT = "COMPADDDEFAULT";

    /// <include file='IPROPNAME.xml' path='doc/member[@name="IPROPNAME.IPROPNAME_FILEADDLOCAL"]/*' />
    [NativeTypeName("#define IPROPNAME_FILEADDLOCAL TEXT(\"FILEADDLOCAL\")")]
    public const string IPROPNAME_FILEADDLOCAL = "FILEADDLOCAL";

    /// <include file='IPROPNAME.xml' path='doc/member[@name="IPROPNAME.IPROPNAME_FILEADDSOURCE"]/*' />
    [NativeTypeName("#define IPROPNAME_FILEADDSOURCE TEXT(\"FILEADDSOURCE\")")]
    public const string IPROPNAME_FILEADDSOURCE = "FILEADDSOURCE";

    /// <include file='IPROPNAME.xml' path='doc/member[@name="IPROPNAME.IPROPNAME_FILEADDDEFAULT"]/*' />
    [NativeTypeName("#define IPROPNAME_FILEADDDEFAULT TEXT(\"FILEADDDEFAULT\")")]
    public const string IPROPNAME_FILEADDDEFAULT = "FILEADDDEFAULT";

    /// <include file='IPROPNAME.xml' path='doc/member[@name="IPROPNAME.IPROPNAME_REINSTALL"]/*' />
    [NativeTypeName("#define IPROPNAME_REINSTALL TEXT(\"REINSTALL\")")]
    public const string IPROPNAME_REINSTALL = "REINSTALL";

    /// <include file='IPROPNAME.xml' path='doc/member[@name="IPROPNAME.IPROPNAME_REINSTALLMODE"]/*' />
    [NativeTypeName("#define IPROPNAME_REINSTALLMODE TEXT(\"REINSTALLMODE\")")]
    public const string IPROPNAME_REINSTALLMODE = "REINSTALLMODE";

    /// <include file='IPROPNAME.xml' path='doc/member[@name="IPROPNAME.IPROPNAME_PROMPTROLLBACKCOST"]/*' />
    [NativeTypeName("#define IPROPNAME_PROMPTROLLBACKCOST TEXT(\"PROMPTROLLBACKCOST\")")]
    public const string IPROPNAME_PROMPTROLLBACKCOST = "PROMPTROLLBACKCOST";

    /// <include file='IPROPNAME.xml' path='doc/member[@name="IPROPNAME.IPROPNAME_CUSTOMACTIONDATA"]/*' />
    [NativeTypeName("#define IPROPNAME_CUSTOMACTIONDATA TEXT(\"CustomActionData\")")]
    public const string IPROPNAME_CUSTOMACTIONDATA = "CustomActionData";
}
