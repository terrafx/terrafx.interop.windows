// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/Msi.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class INSTALLPROPERTY
{
    /// <include file='INSTALLPROPERTY.xml' path='doc/member[@name="INSTALLPROPERTY.INSTALLPROPERTY_PACKAGENAME"]/*' />
    [NativeTypeName("#define INSTALLPROPERTY_PACKAGENAME __TEXT(\"PackageName\")")]
    public const string INSTALLPROPERTY_PACKAGENAME = "PackageName";

    /// <include file='INSTALLPROPERTY.xml' path='doc/member[@name="INSTALLPROPERTY.INSTALLPROPERTY_TRANSFORMS"]/*' />
    [NativeTypeName("#define INSTALLPROPERTY_TRANSFORMS __TEXT(\"Transforms\")")]
    public const string INSTALLPROPERTY_TRANSFORMS = "Transforms";

    /// <include file='INSTALLPROPERTY.xml' path='doc/member[@name="INSTALLPROPERTY.INSTALLPROPERTY_LANGUAGE"]/*' />
    [NativeTypeName("#define INSTALLPROPERTY_LANGUAGE __TEXT(\"Language\")")]
    public const string INSTALLPROPERTY_LANGUAGE = "Language";

    /// <include file='INSTALLPROPERTY.xml' path='doc/member[@name="INSTALLPROPERTY.INSTALLPROPERTY_PRODUCTNAME"]/*' />
    [NativeTypeName("#define INSTALLPROPERTY_PRODUCTNAME __TEXT(\"ProductName\")")]
    public const string INSTALLPROPERTY_PRODUCTNAME = "ProductName";

    /// <include file='INSTALLPROPERTY.xml' path='doc/member[@name="INSTALLPROPERTY.INSTALLPROPERTY_ASSIGNMENTTYPE"]/*' />
    [NativeTypeName("#define INSTALLPROPERTY_ASSIGNMENTTYPE __TEXT(\"AssignmentType\")")]
    public const string INSTALLPROPERTY_ASSIGNMENTTYPE = "AssignmentType";

    /// <include file='INSTALLPROPERTY.xml' path='doc/member[@name="INSTALLPROPERTY.INSTALLPROPERTY_INSTANCETYPE"]/*' />
    [NativeTypeName("#define INSTALLPROPERTY_INSTANCETYPE __TEXT(\"InstanceType\")")]
    public const string INSTALLPROPERTY_INSTANCETYPE = "InstanceType";

    /// <include file='INSTALLPROPERTY.xml' path='doc/member[@name="INSTALLPROPERTY.INSTALLPROPERTY_AUTHORIZED_LUA_APP"]/*' />
    [NativeTypeName("#define INSTALLPROPERTY_AUTHORIZED_LUA_APP __TEXT(\"AuthorizedLUAApp\")")]
    public const string INSTALLPROPERTY_AUTHORIZED_LUA_APP = "AuthorizedLUAApp";

    /// <include file='INSTALLPROPERTY.xml' path='doc/member[@name="INSTALLPROPERTY.INSTALLPROPERTY_PACKAGECODE"]/*' />
    [NativeTypeName("#define INSTALLPROPERTY_PACKAGECODE __TEXT(\"PackageCode\")")]
    public const string INSTALLPROPERTY_PACKAGECODE = "PackageCode";

    /// <include file='INSTALLPROPERTY.xml' path='doc/member[@name="INSTALLPROPERTY.INSTALLPROPERTY_VERSION"]/*' />
    [NativeTypeName("#define INSTALLPROPERTY_VERSION __TEXT(\"Version\")")]
    public const string INSTALLPROPERTY_VERSION = "Version";

    /// <include file='INSTALLPROPERTY.xml' path='doc/member[@name="INSTALLPROPERTY.INSTALLPROPERTY_PRODUCTICON"]/*' />
    [NativeTypeName("#define INSTALLPROPERTY_PRODUCTICON __TEXT(\"ProductIcon\")")]
    public const string INSTALLPROPERTY_PRODUCTICON = "ProductIcon";

    /// <include file='INSTALLPROPERTY.xml' path='doc/member[@name="INSTALLPROPERTY.INSTALLPROPERTY_INSTALLEDPRODUCTNAME"]/*' />
    [NativeTypeName("#define INSTALLPROPERTY_INSTALLEDPRODUCTNAME __TEXT(\"InstalledProductName\")")]
    public const string INSTALLPROPERTY_INSTALLEDPRODUCTNAME = "InstalledProductName";

    /// <include file='INSTALLPROPERTY.xml' path='doc/member[@name="INSTALLPROPERTY.INSTALLPROPERTY_VERSIONSTRING"]/*' />
    [NativeTypeName("#define INSTALLPROPERTY_VERSIONSTRING __TEXT(\"VersionString\")")]
    public const string INSTALLPROPERTY_VERSIONSTRING = "VersionString";

    /// <include file='INSTALLPROPERTY.xml' path='doc/member[@name="INSTALLPROPERTY.INSTALLPROPERTY_HELPLINK"]/*' />
    [NativeTypeName("#define INSTALLPROPERTY_HELPLINK __TEXT(\"HelpLink\")")]
    public const string INSTALLPROPERTY_HELPLINK = "HelpLink";

    /// <include file='INSTALLPROPERTY.xml' path='doc/member[@name="INSTALLPROPERTY.INSTALLPROPERTY_HELPTELEPHONE"]/*' />
    [NativeTypeName("#define INSTALLPROPERTY_HELPTELEPHONE __TEXT(\"HelpTelephone\")")]
    public const string INSTALLPROPERTY_HELPTELEPHONE = "HelpTelephone";

    /// <include file='INSTALLPROPERTY.xml' path='doc/member[@name="INSTALLPROPERTY.INSTALLPROPERTY_INSTALLLOCATION"]/*' />
    [NativeTypeName("#define INSTALLPROPERTY_INSTALLLOCATION __TEXT(\"InstallLocation\")")]
    public const string INSTALLPROPERTY_INSTALLLOCATION = "InstallLocation";

    /// <include file='INSTALLPROPERTY.xml' path='doc/member[@name="INSTALLPROPERTY.INSTALLPROPERTY_INSTALLSOURCE"]/*' />
    [NativeTypeName("#define INSTALLPROPERTY_INSTALLSOURCE __TEXT(\"InstallSource\")")]
    public const string INSTALLPROPERTY_INSTALLSOURCE = "InstallSource";

    /// <include file='INSTALLPROPERTY.xml' path='doc/member[@name="INSTALLPROPERTY.INSTALLPROPERTY_INSTALLDATE"]/*' />
    [NativeTypeName("#define INSTALLPROPERTY_INSTALLDATE __TEXT(\"InstallDate\")")]
    public const string INSTALLPROPERTY_INSTALLDATE = "InstallDate";

    /// <include file='INSTALLPROPERTY.xml' path='doc/member[@name="INSTALLPROPERTY.INSTALLPROPERTY_PUBLISHER"]/*' />
    [NativeTypeName("#define INSTALLPROPERTY_PUBLISHER __TEXT(\"Publisher\")")]
    public const string INSTALLPROPERTY_PUBLISHER = "Publisher";

    /// <include file='INSTALLPROPERTY.xml' path='doc/member[@name="INSTALLPROPERTY.INSTALLPROPERTY_LOCALPACKAGE"]/*' />
    [NativeTypeName("#define INSTALLPROPERTY_LOCALPACKAGE __TEXT(\"LocalPackage\")")]
    public const string INSTALLPROPERTY_LOCALPACKAGE = "LocalPackage";

    /// <include file='INSTALLPROPERTY.xml' path='doc/member[@name="INSTALLPROPERTY.INSTALLPROPERTY_URLINFOABOUT"]/*' />
    [NativeTypeName("#define INSTALLPROPERTY_URLINFOABOUT __TEXT(\"URLInfoAbout\")")]
    public const string INSTALLPROPERTY_URLINFOABOUT = "URLInfoAbout";

    /// <include file='INSTALLPROPERTY.xml' path='doc/member[@name="INSTALLPROPERTY.INSTALLPROPERTY_URLUPDATEINFO"]/*' />
    [NativeTypeName("#define INSTALLPROPERTY_URLUPDATEINFO __TEXT(\"URLUpdateInfo\")")]
    public const string INSTALLPROPERTY_URLUPDATEINFO = "URLUpdateInfo";

    /// <include file='INSTALLPROPERTY.xml' path='doc/member[@name="INSTALLPROPERTY.INSTALLPROPERTY_VERSIONMINOR"]/*' />
    [NativeTypeName("#define INSTALLPROPERTY_VERSIONMINOR __TEXT(\"VersionMinor\")")]
    public const string INSTALLPROPERTY_VERSIONMINOR = "VersionMinor";

    /// <include file='INSTALLPROPERTY.xml' path='doc/member[@name="INSTALLPROPERTY.INSTALLPROPERTY_VERSIONMAJOR"]/*' />
    [NativeTypeName("#define INSTALLPROPERTY_VERSIONMAJOR __TEXT(\"VersionMajor\")")]
    public const string INSTALLPROPERTY_VERSIONMAJOR = "VersionMajor";

    /// <include file='INSTALLPROPERTY.xml' path='doc/member[@name="INSTALLPROPERTY.INSTALLPROPERTY_PRODUCTID"]/*' />
    [NativeTypeName("#define INSTALLPROPERTY_PRODUCTID __TEXT(\"ProductID\")")]
    public const string INSTALLPROPERTY_PRODUCTID = "ProductID";

    /// <include file='INSTALLPROPERTY.xml' path='doc/member[@name="INSTALLPROPERTY.INSTALLPROPERTY_REGCOMPANY"]/*' />
    [NativeTypeName("#define INSTALLPROPERTY_REGCOMPANY __TEXT(\"RegCompany\")")]
    public const string INSTALLPROPERTY_REGCOMPANY = "RegCompany";

    /// <include file='INSTALLPROPERTY.xml' path='doc/member[@name="INSTALLPROPERTY.INSTALLPROPERTY_REGOWNER"]/*' />
    [NativeTypeName("#define INSTALLPROPERTY_REGOWNER __TEXT(\"RegOwner\")")]
    public const string INSTALLPROPERTY_REGOWNER = "RegOwner";

    /// <include file='INSTALLPROPERTY.xml' path='doc/member[@name="INSTALLPROPERTY.INSTALLPROPERTY_INSTALLEDLANGUAGE"]/*' />
    [NativeTypeName("#define INSTALLPROPERTY_INSTALLEDLANGUAGE __TEXT(\"InstalledLanguage\")")]
    public const string INSTALLPROPERTY_INSTALLEDLANGUAGE = "InstalledLanguage";

    /// <include file='INSTALLPROPERTY.xml' path='doc/member[@name="INSTALLPROPERTY.INSTALLPROPERTY_UNINSTALLABLE"]/*' />
    [NativeTypeName("#define INSTALLPROPERTY_UNINSTALLABLE __TEXT(\"Uninstallable\")")]
    public const string INSTALLPROPERTY_UNINSTALLABLE = "Uninstallable";

    /// <include file='INSTALLPROPERTY.xml' path='doc/member[@name="INSTALLPROPERTY.INSTALLPROPERTY_PRODUCTSTATE"]/*' />
    [NativeTypeName("#define INSTALLPROPERTY_PRODUCTSTATE __TEXT(\"State\")")]
    public const string INSTALLPROPERTY_PRODUCTSTATE = "State";

    /// <include file='INSTALLPROPERTY.xml' path='doc/member[@name="INSTALLPROPERTY.INSTALLPROPERTY_PATCHSTATE"]/*' />
    [NativeTypeName("#define INSTALLPROPERTY_PATCHSTATE __TEXT(\"State\")")]
    public const string INSTALLPROPERTY_PATCHSTATE = "State";

    /// <include file='INSTALLPROPERTY.xml' path='doc/member[@name="INSTALLPROPERTY.INSTALLPROPERTY_PATCHTYPE"]/*' />
    [NativeTypeName("#define INSTALLPROPERTY_PATCHTYPE __TEXT(\"PatchType\")")]
    public const string INSTALLPROPERTY_PATCHTYPE = "PatchType";

    /// <include file='INSTALLPROPERTY.xml' path='doc/member[@name="INSTALLPROPERTY.INSTALLPROPERTY_LUAENABLED"]/*' />
    [NativeTypeName("#define INSTALLPROPERTY_LUAENABLED __TEXT(\"LUAEnabled\")")]
    public const string INSTALLPROPERTY_LUAENABLED = "LUAEnabled";

    /// <include file='INSTALLPROPERTY.xml' path='doc/member[@name="INSTALLPROPERTY.INSTALLPROPERTY_DISPLAYNAME"]/*' />
    [NativeTypeName("#define INSTALLPROPERTY_DISPLAYNAME __TEXT(\"DisplayName\")")]
    public const string INSTALLPROPERTY_DISPLAYNAME = "DisplayName";

    /// <include file='INSTALLPROPERTY.xml' path='doc/member[@name="INSTALLPROPERTY.INSTALLPROPERTY_MOREINFOURL"]/*' />
    [NativeTypeName("#define INSTALLPROPERTY_MOREINFOURL __TEXT(\"MoreInfoURL\")")]
    public const string INSTALLPROPERTY_MOREINFOURL = "MoreInfoURL";

    /// <include file='INSTALLPROPERTY.xml' path='doc/member[@name="INSTALLPROPERTY.INSTALLPROPERTY_LASTUSEDSOURCE"]/*' />
    [NativeTypeName("#define INSTALLPROPERTY_LASTUSEDSOURCE __TEXT(\"LastUsedSource\")")]
    public const string INSTALLPROPERTY_LASTUSEDSOURCE = "LastUsedSource";

    /// <include file='INSTALLPROPERTY.xml' path='doc/member[@name="INSTALLPROPERTY.INSTALLPROPERTY_LASTUSEDTYPE"]/*' />
    [NativeTypeName("#define INSTALLPROPERTY_LASTUSEDTYPE __TEXT(\"LastUsedType\")")]
    public const string INSTALLPROPERTY_LASTUSEDTYPE = "LastUsedType";

    /// <include file='INSTALLPROPERTY.xml' path='doc/member[@name="INSTALLPROPERTY.INSTALLPROPERTY_MEDIAPACKAGEPATH"]/*' />
    [NativeTypeName("#define INSTALLPROPERTY_MEDIAPACKAGEPATH __TEXT(\"MediaPackagePath\")")]
    public const string INSTALLPROPERTY_MEDIAPACKAGEPATH = "MediaPackagePath";

    /// <include file='INSTALLPROPERTY.xml' path='doc/member[@name="INSTALLPROPERTY.INSTALLPROPERTY_DISKPROMPT"]/*' />
    [NativeTypeName("#define INSTALLPROPERTY_DISKPROMPT __TEXT(\"DiskPrompt\")")]
    public const string INSTALLPROPERTY_DISKPROMPT = "DiskPrompt";
}
