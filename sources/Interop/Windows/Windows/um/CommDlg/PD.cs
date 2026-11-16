// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/CommDlg.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class PD
{
    /// <include file='PD.xml' path='doc/member[@name="PD.PD_ALLPAGES"]/*' />
    [NativeTypeName("#define PD_ALLPAGES 0x00000000")]
    public const int PD_ALLPAGES = 0x00000000;

    /// <include file='PD.xml' path='doc/member[@name="PD.PD_SELECTION"]/*' />
    [NativeTypeName("#define PD_SELECTION 0x00000001")]
    public const int PD_SELECTION = 0x00000001;

    /// <include file='PD.xml' path='doc/member[@name="PD.PD_PAGENUMS"]/*' />
    [NativeTypeName("#define PD_PAGENUMS 0x00000002")]
    public const int PD_PAGENUMS = 0x00000002;

    /// <include file='PD.xml' path='doc/member[@name="PD.PD_NOSELECTION"]/*' />
    [NativeTypeName("#define PD_NOSELECTION 0x00000004")]
    public const int PD_NOSELECTION = 0x00000004;

    /// <include file='PD.xml' path='doc/member[@name="PD.PD_NOPAGENUMS"]/*' />
    [NativeTypeName("#define PD_NOPAGENUMS 0x00000008")]
    public const int PD_NOPAGENUMS = 0x00000008;

    /// <include file='PD.xml' path='doc/member[@name="PD.PD_COLLATE"]/*' />
    [NativeTypeName("#define PD_COLLATE 0x00000010")]
    public const int PD_COLLATE = 0x00000010;

    /// <include file='PD.xml' path='doc/member[@name="PD.PD_PRINTTOFILE"]/*' />
    [NativeTypeName("#define PD_PRINTTOFILE 0x00000020")]
    public const int PD_PRINTTOFILE = 0x00000020;

    /// <include file='PD.xml' path='doc/member[@name="PD.PD_PRINTSETUP"]/*' />
    [NativeTypeName("#define PD_PRINTSETUP 0x00000040")]
    public const int PD_PRINTSETUP = 0x00000040;

    /// <include file='PD.xml' path='doc/member[@name="PD.PD_NOWARNING"]/*' />
    [NativeTypeName("#define PD_NOWARNING 0x00000080")]
    public const int PD_NOWARNING = 0x00000080;

    /// <include file='PD.xml' path='doc/member[@name="PD.PD_RETURNDC"]/*' />
    [NativeTypeName("#define PD_RETURNDC 0x00000100")]
    public const int PD_RETURNDC = 0x00000100;

    /// <include file='PD.xml' path='doc/member[@name="PD.PD_RETURNIC"]/*' />
    [NativeTypeName("#define PD_RETURNIC 0x00000200")]
    public const int PD_RETURNIC = 0x00000200;

    /// <include file='PD.xml' path='doc/member[@name="PD.PD_RETURNDEFAULT"]/*' />
    [NativeTypeName("#define PD_RETURNDEFAULT 0x00000400")]
    public const int PD_RETURNDEFAULT = 0x00000400;

    /// <include file='PD.xml' path='doc/member[@name="PD.PD_SHOWHELP"]/*' />
    [NativeTypeName("#define PD_SHOWHELP 0x00000800")]
    public const int PD_SHOWHELP = 0x00000800;

    /// <include file='PD.xml' path='doc/member[@name="PD.PD_ENABLEPRINTHOOK"]/*' />
    [NativeTypeName("#define PD_ENABLEPRINTHOOK 0x00001000")]
    public const int PD_ENABLEPRINTHOOK = 0x00001000;

    /// <include file='PD.xml' path='doc/member[@name="PD.PD_ENABLESETUPHOOK"]/*' />
    [NativeTypeName("#define PD_ENABLESETUPHOOK 0x00002000")]
    public const int PD_ENABLESETUPHOOK = 0x00002000;

    /// <include file='PD.xml' path='doc/member[@name="PD.PD_ENABLEPRINTTEMPLATE"]/*' />
    [NativeTypeName("#define PD_ENABLEPRINTTEMPLATE 0x00004000")]
    public const int PD_ENABLEPRINTTEMPLATE = 0x00004000;

    /// <include file='PD.xml' path='doc/member[@name="PD.PD_ENABLESETUPTEMPLATE"]/*' />
    [NativeTypeName("#define PD_ENABLESETUPTEMPLATE 0x00008000")]
    public const int PD_ENABLESETUPTEMPLATE = 0x00008000;

    /// <include file='PD.xml' path='doc/member[@name="PD.PD_ENABLEPRINTTEMPLATEHANDLE"]/*' />
    [NativeTypeName("#define PD_ENABLEPRINTTEMPLATEHANDLE 0x00010000")]
    public const int PD_ENABLEPRINTTEMPLATEHANDLE = 0x00010000;

    /// <include file='PD.xml' path='doc/member[@name="PD.PD_ENABLESETUPTEMPLATEHANDLE"]/*' />
    [NativeTypeName("#define PD_ENABLESETUPTEMPLATEHANDLE 0x00020000")]
    public const int PD_ENABLESETUPTEMPLATEHANDLE = 0x00020000;

    /// <include file='PD.xml' path='doc/member[@name="PD.PD_USEDEVMODECOPIES"]/*' />
    [NativeTypeName("#define PD_USEDEVMODECOPIES 0x00040000")]
    public const int PD_USEDEVMODECOPIES = 0x00040000;

    /// <include file='PD.xml' path='doc/member[@name="PD.PD_USEDEVMODECOPIESANDCOLLATE"]/*' />
    [NativeTypeName("#define PD_USEDEVMODECOPIESANDCOLLATE 0x00040000")]
    public const int PD_USEDEVMODECOPIESANDCOLLATE = 0x00040000;

    /// <include file='PD.xml' path='doc/member[@name="PD.PD_DISABLEPRINTTOFILE"]/*' />
    [NativeTypeName("#define PD_DISABLEPRINTTOFILE 0x00080000")]
    public const int PD_DISABLEPRINTTOFILE = 0x00080000;

    /// <include file='PD.xml' path='doc/member[@name="PD.PD_HIDEPRINTTOFILE"]/*' />
    [NativeTypeName("#define PD_HIDEPRINTTOFILE 0x00100000")]
    public const int PD_HIDEPRINTTOFILE = 0x00100000;

    /// <include file='PD.xml' path='doc/member[@name="PD.PD_NONETWORKBUTTON"]/*' />
    [NativeTypeName("#define PD_NONETWORKBUTTON 0x00200000")]
    public const int PD_NONETWORKBUTTON = 0x00200000;

    /// <include file='PD.xml' path='doc/member[@name="PD.PD_CURRENTPAGE"]/*' />
    [NativeTypeName("#define PD_CURRENTPAGE 0x00400000")]
    public const int PD_CURRENTPAGE = 0x00400000;

    /// <include file='PD.xml' path='doc/member[@name="PD.PD_NOCURRENTPAGE"]/*' />
    [NativeTypeName("#define PD_NOCURRENTPAGE 0x00800000")]
    public const int PD_NOCURRENTPAGE = 0x00800000;

    /// <include file='PD.xml' path='doc/member[@name="PD.PD_EXCLUSIONFLAGS"]/*' />
    [NativeTypeName("#define PD_EXCLUSIONFLAGS 0x01000000")]
    public const int PD_EXCLUSIONFLAGS = 0x01000000;

    /// <include file='PD.xml' path='doc/member[@name="PD.PD_USELARGETEMPLATE"]/*' />
    [NativeTypeName("#define PD_USELARGETEMPLATE 0x10000000")]
    public const int PD_USELARGETEMPLATE = 0x10000000;

    /// <include file='PD.xml' path='doc/member[@name="PD.PD_EXCL_COPIESANDCOLLATE"]/*' />
    [NativeTypeName("#define PD_EXCL_COPIESANDCOLLATE (DM_COPIES | DM_COLLATE)")]
    public const int PD_EXCL_COPIESANDCOLLATE = (0x00000100 | 0x00008000);

    /// <include file='PD.xml' path='doc/member[@name="PD.PD_RESULT_CANCEL"]/*' />
    [NativeTypeName("#define PD_RESULT_CANCEL 0")]
    public const int PD_RESULT_CANCEL = 0;

    /// <include file='PD.xml' path='doc/member[@name="PD.PD_RESULT_PRINT"]/*' />
    [NativeTypeName("#define PD_RESULT_PRINT 1")]
    public const int PD_RESULT_PRINT = 1;

    /// <include file='PD.xml' path='doc/member[@name="PD.PD_RESULT_APPLY"]/*' />
    [NativeTypeName("#define PD_RESULT_APPLY 2")]
    public const int PD_RESULT_APPLY = 2;
}
