// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShlObj_core.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class SFVM
{
    /// <include file='SFVM.xml' path='doc/member[@name="SFVM.SFVM_MERGEMENU"]/*' />
    [NativeTypeName("#define SFVM_MERGEMENU 1")]
    public const int SFVM_MERGEMENU = 1;

    /// <include file='SFVM.xml' path='doc/member[@name="SFVM.SFVM_INVOKECOMMAND"]/*' />
    [NativeTypeName("#define SFVM_INVOKECOMMAND 2")]
    public const int SFVM_INVOKECOMMAND = 2;

    /// <include file='SFVM.xml' path='doc/member[@name="SFVM.SFVM_GETHELPTEXT"]/*' />
    [NativeTypeName("#define SFVM_GETHELPTEXT 3")]
    public const int SFVM_GETHELPTEXT = 3;

    /// <include file='SFVM.xml' path='doc/member[@name="SFVM.SFVM_GETTOOLTIPTEXT"]/*' />
    [NativeTypeName("#define SFVM_GETTOOLTIPTEXT 4")]
    public const int SFVM_GETTOOLTIPTEXT = 4;

    /// <include file='SFVM.xml' path='doc/member[@name="SFVM.SFVM_GETBUTTONINFO"]/*' />
    [NativeTypeName("#define SFVM_GETBUTTONINFO 5")]
    public const int SFVM_GETBUTTONINFO = 5;

    /// <include file='SFVM.xml' path='doc/member[@name="SFVM.SFVM_GETBUTTONS"]/*' />
    [NativeTypeName("#define SFVM_GETBUTTONS 6")]
    public const int SFVM_GETBUTTONS = 6;

    /// <include file='SFVM.xml' path='doc/member[@name="SFVM.SFVM_INITMENUPOPUP"]/*' />
    [NativeTypeName("#define SFVM_INITMENUPOPUP 7")]
    public const int SFVM_INITMENUPOPUP = 7;

    /// <include file='SFVM.xml' path='doc/member[@name="SFVM.SFVM_FSNOTIFY"]/*' />
    [NativeTypeName("#define SFVM_FSNOTIFY 14")]
    public const int SFVM_FSNOTIFY = 14;

    /// <include file='SFVM.xml' path='doc/member[@name="SFVM.SFVM_WINDOWCREATED"]/*' />
    [NativeTypeName("#define SFVM_WINDOWCREATED 15")]
    public const int SFVM_WINDOWCREATED = 15;

    /// <include file='SFVM.xml' path='doc/member[@name="SFVM.SFVM_GETDETAILSOF"]/*' />
    [NativeTypeName("#define SFVM_GETDETAILSOF 23")]
    public const int SFVM_GETDETAILSOF = 23;

    /// <include file='SFVM.xml' path='doc/member[@name="SFVM.SFVM_COLUMNCLICK"]/*' />
    [NativeTypeName("#define SFVM_COLUMNCLICK 24")]
    public const int SFVM_COLUMNCLICK = 24;

    /// <include file='SFVM.xml' path='doc/member[@name="SFVM.SFVM_QUERYFSNOTIFY"]/*' />
    [NativeTypeName("#define SFVM_QUERYFSNOTIFY 25")]
    public const int SFVM_QUERYFSNOTIFY = 25;

    /// <include file='SFVM.xml' path='doc/member[@name="SFVM.SFVM_DEFITEMCOUNT"]/*' />
    [NativeTypeName("#define SFVM_DEFITEMCOUNT 26")]
    public const int SFVM_DEFITEMCOUNT = 26;

    /// <include file='SFVM.xml' path='doc/member[@name="SFVM.SFVM_DEFVIEWMODE"]/*' />
    [NativeTypeName("#define SFVM_DEFVIEWMODE 27")]
    public const int SFVM_DEFVIEWMODE = 27;

    /// <include file='SFVM.xml' path='doc/member[@name="SFVM.SFVM_UNMERGEMENU"]/*' />
    [NativeTypeName("#define SFVM_UNMERGEMENU 28")]
    public const int SFVM_UNMERGEMENU = 28;

    /// <include file='SFVM.xml' path='doc/member[@name="SFVM.SFVM_UPDATESTATUSBAR"]/*' />
    [NativeTypeName("#define SFVM_UPDATESTATUSBAR 31")]
    public const int SFVM_UPDATESTATUSBAR = 31;

    /// <include file='SFVM.xml' path='doc/member[@name="SFVM.SFVM_BACKGROUNDENUM"]/*' />
    [NativeTypeName("#define SFVM_BACKGROUNDENUM 32")]
    public const int SFVM_BACKGROUNDENUM = 32;

    /// <include file='SFVM.xml' path='doc/member[@name="SFVM.SFVM_DIDDRAGDROP"]/*' />
    [NativeTypeName("#define SFVM_DIDDRAGDROP 36")]
    public const int SFVM_DIDDRAGDROP = 36;

    /// <include file='SFVM.xml' path='doc/member[@name="SFVM.SFVM_SETISFV"]/*' />
    [NativeTypeName("#define SFVM_SETISFV 39")]
    public const int SFVM_SETISFV = 39;

    /// <include file='SFVM.xml' path='doc/member[@name="SFVM.SFVM_THISIDLIST"]/*' />
    [NativeTypeName("#define SFVM_THISIDLIST 41")]
    public const int SFVM_THISIDLIST = 41;

    /// <include file='SFVM.xml' path='doc/member[@name="SFVM.SFVM_ADDPROPERTYPAGES"]/*' />
    [NativeTypeName("#define SFVM_ADDPROPERTYPAGES 47")]
    public const int SFVM_ADDPROPERTYPAGES = 47;

    /// <include file='SFVM.xml' path='doc/member[@name="SFVM.SFVM_BACKGROUNDENUMDONE"]/*' />
    [NativeTypeName("#define SFVM_BACKGROUNDENUMDONE 48")]
    public const int SFVM_BACKGROUNDENUMDONE = 48;

    /// <include file='SFVM.xml' path='doc/member[@name="SFVM.SFVM_GETNOTIFY"]/*' />
    [NativeTypeName("#define SFVM_GETNOTIFY 49")]
    public const int SFVM_GETNOTIFY = 49;

    /// <include file='SFVM.xml' path='doc/member[@name="SFVM.SFVM_GETSORTDEFAULTS"]/*' />
    [NativeTypeName("#define SFVM_GETSORTDEFAULTS 53")]
    public const int SFVM_GETSORTDEFAULTS = 53;

    /// <include file='SFVM.xml' path='doc/member[@name="SFVM.SFVM_SIZE"]/*' />
    [NativeTypeName("#define SFVM_SIZE 57")]
    public const int SFVM_SIZE = 57;

    /// <include file='SFVM.xml' path='doc/member[@name="SFVM.SFVM_GETZONE"]/*' />
    [NativeTypeName("#define SFVM_GETZONE 58")]
    public const int SFVM_GETZONE = 58;

    /// <include file='SFVM.xml' path='doc/member[@name="SFVM.SFVM_GETPANE"]/*' />
    [NativeTypeName("#define SFVM_GETPANE 59")]
    public const int SFVM_GETPANE = 59;

    /// <include file='SFVM.xml' path='doc/member[@name="SFVM.SFVM_GETHELPTOPIC"]/*' />
    [NativeTypeName("#define SFVM_GETHELPTOPIC 63")]
    public const int SFVM_GETHELPTOPIC = 63;

    /// <include file='SFVM.xml' path='doc/member[@name="SFVM.SFVM_GETANIMATION"]/*' />
    [NativeTypeName("#define SFVM_GETANIMATION 68")]
    public const int SFVM_GETANIMATION = 68;
}
