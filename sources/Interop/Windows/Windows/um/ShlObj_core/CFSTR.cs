// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShlObj_core.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class CFSTR
{
    /// <include file='CFSTR.xml' path='doc/member[@name="CFSTR.CFSTR_SHELLIDLIST"]/*' />
    [NativeTypeName("#define CFSTR_SHELLIDLIST TEXT(\"Shell IDList Array\")")]
    public const string CFSTR_SHELLIDLIST = "Shell IDList Array";

    /// <include file='CFSTR.xml' path='doc/member[@name="CFSTR.CFSTR_SHELLIDLISTOFFSET"]/*' />
    [NativeTypeName("#define CFSTR_SHELLIDLISTOFFSET TEXT(\"Shell Object Offsets\")")]
    public const string CFSTR_SHELLIDLISTOFFSET = "Shell Object Offsets";

    /// <include file='CFSTR.xml' path='doc/member[@name="CFSTR.CFSTR_NETRESOURCES"]/*' />
    [NativeTypeName("#define CFSTR_NETRESOURCES TEXT(\"Net Resource\")")]
    public const string CFSTR_NETRESOURCES = "Net Resource";

    /// <include file='CFSTR.xml' path='doc/member[@name="CFSTR.CFSTR_FILEDESCRIPTORA"]/*' />
    [NativeTypeName("#define CFSTR_FILEDESCRIPTORA TEXT(\"FileGroupDescriptor\")")]
    public const string CFSTR_FILEDESCRIPTORA = "FileGroupDescriptor";

    /// <include file='CFSTR.xml' path='doc/member[@name="CFSTR.CFSTR_FILEDESCRIPTORW"]/*' />
    [NativeTypeName("#define CFSTR_FILEDESCRIPTORW TEXT(\"FileGroupDescriptorW\")")]
    public const string CFSTR_FILEDESCRIPTORW = "FileGroupDescriptorW";

    /// <include file='CFSTR.xml' path='doc/member[@name="CFSTR.CFSTR_FILECONTENTS"]/*' />
    [NativeTypeName("#define CFSTR_FILECONTENTS TEXT(\"FileContents\")")]
    public const string CFSTR_FILECONTENTS = "FileContents";

    /// <include file='CFSTR.xml' path='doc/member[@name="CFSTR.CFSTR_FILENAMEA"]/*' />
    [NativeTypeName("#define CFSTR_FILENAMEA TEXT(\"FileName\")")]
    public const string CFSTR_FILENAMEA = "FileName";

    /// <include file='CFSTR.xml' path='doc/member[@name="CFSTR.CFSTR_FILENAMEW"]/*' />
    [NativeTypeName("#define CFSTR_FILENAMEW TEXT(\"FileNameW\")")]
    public const string CFSTR_FILENAMEW = "FileNameW";

    /// <include file='CFSTR.xml' path='doc/member[@name="CFSTR.CFSTR_PRINTERGROUP"]/*' />
    [NativeTypeName("#define CFSTR_PRINTERGROUP TEXT(\"PrinterFriendlyName\")")]
    public const string CFSTR_PRINTERGROUP = "PrinterFriendlyName";

    /// <include file='CFSTR.xml' path='doc/member[@name="CFSTR.CFSTR_FILENAMEMAPA"]/*' />
    [NativeTypeName("#define CFSTR_FILENAMEMAPA TEXT(\"FileNameMap\")")]
    public const string CFSTR_FILENAMEMAPA = "FileNameMap";

    /// <include file='CFSTR.xml' path='doc/member[@name="CFSTR.CFSTR_FILENAMEMAPW"]/*' />
    [NativeTypeName("#define CFSTR_FILENAMEMAPW TEXT(\"FileNameMapW\")")]
    public const string CFSTR_FILENAMEMAPW = "FileNameMapW";

    /// <include file='CFSTR.xml' path='doc/member[@name="CFSTR.CFSTR_SHELLURL"]/*' />
    [NativeTypeName("#define CFSTR_SHELLURL TEXT(\"UniformResourceLocator\")")]
    public const string CFSTR_SHELLURL = "UniformResourceLocator";

    /// <include file='CFSTR.xml' path='doc/member[@name="CFSTR.CFSTR_INETURLA"]/*' />
    [NativeTypeName("#define CFSTR_INETURLA CFSTR_SHELLURL")]
    public const string CFSTR_INETURLA = "UniformResourceLocator";

    /// <include file='CFSTR.xml' path='doc/member[@name="CFSTR.CFSTR_INETURLW"]/*' />
    [NativeTypeName("#define CFSTR_INETURLW TEXT(\"UniformResourceLocatorW\")")]
    public const string CFSTR_INETURLW = "UniformResourceLocatorW";

    /// <include file='CFSTR.xml' path='doc/member[@name="CFSTR.CFSTR_PREFERREDDROPEFFECT"]/*' />
    [NativeTypeName("#define CFSTR_PREFERREDDROPEFFECT TEXT(\"Preferred DropEffect\")")]
    public const string CFSTR_PREFERREDDROPEFFECT = "Preferred DropEffect";

    /// <include file='CFSTR.xml' path='doc/member[@name="CFSTR.CFSTR_PERFORMEDDROPEFFECT"]/*' />
    [NativeTypeName("#define CFSTR_PERFORMEDDROPEFFECT TEXT(\"Performed DropEffect\")")]
    public const string CFSTR_PERFORMEDDROPEFFECT = "Performed DropEffect";

    /// <include file='CFSTR.xml' path='doc/member[@name="CFSTR.CFSTR_PASTESUCCEEDED"]/*' />
    [NativeTypeName("#define CFSTR_PASTESUCCEEDED TEXT(\"Paste Succeeded\")")]
    public const string CFSTR_PASTESUCCEEDED = "Paste Succeeded";

    /// <include file='CFSTR.xml' path='doc/member[@name="CFSTR.CFSTR_INDRAGLOOP"]/*' />
    [NativeTypeName("#define CFSTR_INDRAGLOOP TEXT(\"InShellDragLoop\")")]
    public const string CFSTR_INDRAGLOOP = "InShellDragLoop";

    /// <include file='CFSTR.xml' path='doc/member[@name="CFSTR.CFSTR_MOUNTEDVOLUME"]/*' />
    [NativeTypeName("#define CFSTR_MOUNTEDVOLUME TEXT(\"MountedVolume\")")]
    public const string CFSTR_MOUNTEDVOLUME = "MountedVolume";

    /// <include file='CFSTR.xml' path='doc/member[@name="CFSTR.CFSTR_PERSISTEDDATAOBJECT"]/*' />
    [NativeTypeName("#define CFSTR_PERSISTEDDATAOBJECT TEXT(\"PersistedDataObject\")")]
    public const string CFSTR_PERSISTEDDATAOBJECT = "PersistedDataObject";

    /// <include file='CFSTR.xml' path='doc/member[@name="CFSTR.CFSTR_TARGETCLSID"]/*' />
    [NativeTypeName("#define CFSTR_TARGETCLSID TEXT(\"TargetCLSID\")")]
    public const string CFSTR_TARGETCLSID = "TargetCLSID";

    /// <include file='CFSTR.xml' path='doc/member[@name="CFSTR.CFSTR_LOGICALPERFORMEDDROPEFFECT"]/*' />
    [NativeTypeName("#define CFSTR_LOGICALPERFORMEDDROPEFFECT TEXT(\"Logical Performed DropEffect\")")]
    public const string CFSTR_LOGICALPERFORMEDDROPEFFECT = "Logical Performed DropEffect";

    /// <include file='CFSTR.xml' path='doc/member[@name="CFSTR.CFSTR_AUTOPLAY_SHELLIDLISTS"]/*' />
    [NativeTypeName("#define CFSTR_AUTOPLAY_SHELLIDLISTS TEXT(\"Autoplay Enumerated IDList Array\")")]
    public const string CFSTR_AUTOPLAY_SHELLIDLISTS = "Autoplay Enumerated IDList Array";

    /// <include file='CFSTR.xml' path='doc/member[@name="CFSTR.CFSTR_UNTRUSTEDDRAGDROP"]/*' />
    [NativeTypeName("#define CFSTR_UNTRUSTEDDRAGDROP TEXT(\"UntrustedDragDrop\")")]
    public const string CFSTR_UNTRUSTEDDRAGDROP = "UntrustedDragDrop";

    /// <include file='CFSTR.xml' path='doc/member[@name="CFSTR.CFSTR_FILE_ATTRIBUTES_ARRAY"]/*' />
    [NativeTypeName("#define CFSTR_FILE_ATTRIBUTES_ARRAY TEXT(\"File Attributes Array\")")]
    public const string CFSTR_FILE_ATTRIBUTES_ARRAY = "File Attributes Array";

    /// <include file='CFSTR.xml' path='doc/member[@name="CFSTR.CFSTR_INVOKECOMMAND_DROPPARAM"]/*' />
    [NativeTypeName("#define CFSTR_INVOKECOMMAND_DROPPARAM TEXT(\"InvokeCommand DropParam\")")]
    public const string CFSTR_INVOKECOMMAND_DROPPARAM = "InvokeCommand DropParam";

    /// <include file='CFSTR.xml' path='doc/member[@name="CFSTR.CFSTR_SHELLDROPHANDLER"]/*' />
    [NativeTypeName("#define CFSTR_SHELLDROPHANDLER TEXT(\"DropHandlerCLSID\")")]
    public const string CFSTR_SHELLDROPHANDLER = "DropHandlerCLSID";

    /// <include file='CFSTR.xml' path='doc/member[@name="CFSTR.CFSTR_DROPDESCRIPTION"]/*' />
    [NativeTypeName("#define CFSTR_DROPDESCRIPTION TEXT(\"DropDescription\")")]
    public const string CFSTR_DROPDESCRIPTION = "DropDescription";

    /// <include file='CFSTR.xml' path='doc/member[@name="CFSTR.CFSTR_ZONEIDENTIFIER"]/*' />
    [NativeTypeName("#define CFSTR_ZONEIDENTIFIER TEXT(\"ZoneIdentifier\")")]
    public const string CFSTR_ZONEIDENTIFIER = "ZoneIdentifier";

    /// <include file='CFSTR.xml' path='doc/member[@name="CFSTR.CFSTR_FILEDESCRIPTOR"]/*' />
    [NativeTypeName("#define CFSTR_FILEDESCRIPTOR CFSTR_FILEDESCRIPTORW")]
    public const string CFSTR_FILEDESCRIPTOR = "FileGroupDescriptorW";

    /// <include file='CFSTR.xml' path='doc/member[@name="CFSTR.CFSTR_FILENAME"]/*' />
    [NativeTypeName("#define CFSTR_FILENAME CFSTR_FILENAMEW")]
    public const string CFSTR_FILENAME = "FileNameW";

    /// <include file='CFSTR.xml' path='doc/member[@name="CFSTR.CFSTR_FILENAMEMAP"]/*' />
    [NativeTypeName("#define CFSTR_FILENAMEMAP CFSTR_FILENAMEMAPW")]
    public const string CFSTR_FILENAMEMAP = "FileNameMapW";

    /// <include file='CFSTR.xml' path='doc/member[@name="CFSTR.CFSTR_INETURL"]/*' />
    [NativeTypeName("#define CFSTR_INETURL CFSTR_INETURLW")]
    public const string CFSTR_INETURL = "UniformResourceLocatorW";
}
