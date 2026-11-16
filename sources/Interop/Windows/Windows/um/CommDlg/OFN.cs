// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/CommDlg.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class OFN
{
    /// <include file='OFN.xml' path='doc/member[@name="OFN.OFN_READONLY"]/*' />
    [NativeTypeName("#define OFN_READONLY 0x00000001")]
    public const int OFN_READONLY = 0x00000001;

    /// <include file='OFN.xml' path='doc/member[@name="OFN.OFN_OVERWRITEPROMPT"]/*' />
    [NativeTypeName("#define OFN_OVERWRITEPROMPT 0x00000002")]
    public const int OFN_OVERWRITEPROMPT = 0x00000002;

    /// <include file='OFN.xml' path='doc/member[@name="OFN.OFN_HIDEREADONLY"]/*' />
    [NativeTypeName("#define OFN_HIDEREADONLY 0x00000004")]
    public const int OFN_HIDEREADONLY = 0x00000004;

    /// <include file='OFN.xml' path='doc/member[@name="OFN.OFN_NOCHANGEDIR"]/*' />
    [NativeTypeName("#define OFN_NOCHANGEDIR 0x00000008")]
    public const int OFN_NOCHANGEDIR = 0x00000008;

    /// <include file='OFN.xml' path='doc/member[@name="OFN.OFN_SHOWHELP"]/*' />
    [NativeTypeName("#define OFN_SHOWHELP 0x00000010")]
    public const int OFN_SHOWHELP = 0x00000010;

    /// <include file='OFN.xml' path='doc/member[@name="OFN.OFN_ENABLEHOOK"]/*' />
    [NativeTypeName("#define OFN_ENABLEHOOK 0x00000020")]
    public const int OFN_ENABLEHOOK = 0x00000020;

    /// <include file='OFN.xml' path='doc/member[@name="OFN.OFN_ENABLETEMPLATE"]/*' />
    [NativeTypeName("#define OFN_ENABLETEMPLATE 0x00000040")]
    public const int OFN_ENABLETEMPLATE = 0x00000040;

    /// <include file='OFN.xml' path='doc/member[@name="OFN.OFN_ENABLETEMPLATEHANDLE"]/*' />
    [NativeTypeName("#define OFN_ENABLETEMPLATEHANDLE 0x00000080")]
    public const int OFN_ENABLETEMPLATEHANDLE = 0x00000080;

    /// <include file='OFN.xml' path='doc/member[@name="OFN.OFN_NOVALIDATE"]/*' />
    [NativeTypeName("#define OFN_NOVALIDATE 0x00000100")]
    public const int OFN_NOVALIDATE = 0x00000100;

    /// <include file='OFN.xml' path='doc/member[@name="OFN.OFN_ALLOWMULTISELECT"]/*' />
    [NativeTypeName("#define OFN_ALLOWMULTISELECT 0x00000200")]
    public const int OFN_ALLOWMULTISELECT = 0x00000200;

    /// <include file='OFN.xml' path='doc/member[@name="OFN.OFN_EXTENSIONDIFFERENT"]/*' />
    [NativeTypeName("#define OFN_EXTENSIONDIFFERENT 0x00000400")]
    public const int OFN_EXTENSIONDIFFERENT = 0x00000400;

    /// <include file='OFN.xml' path='doc/member[@name="OFN.OFN_PATHMUSTEXIST"]/*' />
    [NativeTypeName("#define OFN_PATHMUSTEXIST 0x00000800")]
    public const int OFN_PATHMUSTEXIST = 0x00000800;

    /// <include file='OFN.xml' path='doc/member[@name="OFN.OFN_FILEMUSTEXIST"]/*' />
    [NativeTypeName("#define OFN_FILEMUSTEXIST 0x00001000")]
    public const int OFN_FILEMUSTEXIST = 0x00001000;

    /// <include file='OFN.xml' path='doc/member[@name="OFN.OFN_CREATEPROMPT"]/*' />
    [NativeTypeName("#define OFN_CREATEPROMPT 0x00002000")]
    public const int OFN_CREATEPROMPT = 0x00002000;

    /// <include file='OFN.xml' path='doc/member[@name="OFN.OFN_SHAREAWARE"]/*' />
    [NativeTypeName("#define OFN_SHAREAWARE 0x00004000")]
    public const int OFN_SHAREAWARE = 0x00004000;

    /// <include file='OFN.xml' path='doc/member[@name="OFN.OFN_NOREADONLYRETURN"]/*' />
    [NativeTypeName("#define OFN_NOREADONLYRETURN 0x00008000")]
    public const int OFN_NOREADONLYRETURN = 0x00008000;

    /// <include file='OFN.xml' path='doc/member[@name="OFN.OFN_NOTESTFILECREATE"]/*' />
    [NativeTypeName("#define OFN_NOTESTFILECREATE 0x00010000")]
    public const int OFN_NOTESTFILECREATE = 0x00010000;

    /// <include file='OFN.xml' path='doc/member[@name="OFN.OFN_NONETWORKBUTTON"]/*' />
    [NativeTypeName("#define OFN_NONETWORKBUTTON 0x00020000")]
    public const int OFN_NONETWORKBUTTON = 0x00020000;

    /// <include file='OFN.xml' path='doc/member[@name="OFN.OFN_NOLONGNAMES"]/*' />
    [NativeTypeName("#define OFN_NOLONGNAMES 0x00040000")]
    public const int OFN_NOLONGNAMES = 0x00040000;

    /// <include file='OFN.xml' path='doc/member[@name="OFN.OFN_EXPLORER"]/*' />
    [NativeTypeName("#define OFN_EXPLORER 0x00080000")]
    public const int OFN_EXPLORER = 0x00080000;

    /// <include file='OFN.xml' path='doc/member[@name="OFN.OFN_NODEREFERENCELINKS"]/*' />
    [NativeTypeName("#define OFN_NODEREFERENCELINKS 0x00100000")]
    public const int OFN_NODEREFERENCELINKS = 0x00100000;

    /// <include file='OFN.xml' path='doc/member[@name="OFN.OFN_LONGNAMES"]/*' />
    [NativeTypeName("#define OFN_LONGNAMES 0x00200000")]
    public const int OFN_LONGNAMES = 0x00200000;

    /// <include file='OFN.xml' path='doc/member[@name="OFN.OFN_ENABLEINCLUDENOTIFY"]/*' />
    [NativeTypeName("#define OFN_ENABLEINCLUDENOTIFY 0x00400000")]
    public const int OFN_ENABLEINCLUDENOTIFY = 0x00400000;

    /// <include file='OFN.xml' path='doc/member[@name="OFN.OFN_ENABLESIZING"]/*' />
    [NativeTypeName("#define OFN_ENABLESIZING 0x00800000")]
    public const int OFN_ENABLESIZING = 0x00800000;

    /// <include file='OFN.xml' path='doc/member[@name="OFN.OFN_DONTADDTORECENT"]/*' />
    [NativeTypeName("#define OFN_DONTADDTORECENT 0x02000000")]
    public const int OFN_DONTADDTORECENT = 0x02000000;

    /// <include file='OFN.xml' path='doc/member[@name="OFN.OFN_FORCESHOWHIDDEN"]/*' />
    [NativeTypeName("#define OFN_FORCESHOWHIDDEN 0x10000000")]
    public const int OFN_FORCESHOWHIDDEN = 0x10000000;

    /// <include file='OFN.xml' path='doc/member[@name="OFN.OFN_EX_NOPLACESBAR"]/*' />
    [NativeTypeName("#define OFN_EX_NOPLACESBAR 0x00000001")]
    public const int OFN_EX_NOPLACESBAR = 0x00000001;

    /// <include file='OFN.xml' path='doc/member[@name="OFN.OFN_SHAREFALLTHROUGH"]/*' />
    [NativeTypeName("#define OFN_SHAREFALLTHROUGH 2")]
    public const int OFN_SHAREFALLTHROUGH = 2;

    /// <include file='OFN.xml' path='doc/member[@name="OFN.OFN_SHARENOWARN"]/*' />
    [NativeTypeName("#define OFN_SHARENOWARN 1")]
    public const int OFN_SHARENOWARN = 1;

    /// <include file='OFN.xml' path='doc/member[@name="OFN.OFN_SHAREWARN"]/*' />
    [NativeTypeName("#define OFN_SHAREWARN 0")]
    public const int OFN_SHAREWARN = 0;
}
