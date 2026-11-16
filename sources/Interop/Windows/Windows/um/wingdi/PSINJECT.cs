// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class PSINJECT
{
    /// <include file='PSINJECT.xml' path='doc/member[@name="PSINJECT.PSINJECT_BEGINSTREAM"]/*' />
    [NativeTypeName("#define PSINJECT_BEGINSTREAM 1")]
    public const int PSINJECT_BEGINSTREAM = 1;

    /// <include file='PSINJECT.xml' path='doc/member[@name="PSINJECT.PSINJECT_PSADOBE"]/*' />
    [NativeTypeName("#define PSINJECT_PSADOBE 2")]
    public const int PSINJECT_PSADOBE = 2;

    /// <include file='PSINJECT.xml' path='doc/member[@name="PSINJECT.PSINJECT_PAGESATEND"]/*' />
    [NativeTypeName("#define PSINJECT_PAGESATEND 3")]
    public const int PSINJECT_PAGESATEND = 3;

    /// <include file='PSINJECT.xml' path='doc/member[@name="PSINJECT.PSINJECT_PAGES"]/*' />
    [NativeTypeName("#define PSINJECT_PAGES 4")]
    public const int PSINJECT_PAGES = 4;

    /// <include file='PSINJECT.xml' path='doc/member[@name="PSINJECT.PSINJECT_DOCNEEDEDRES"]/*' />
    [NativeTypeName("#define PSINJECT_DOCNEEDEDRES 5")]
    public const int PSINJECT_DOCNEEDEDRES = 5;

    /// <include file='PSINJECT.xml' path='doc/member[@name="PSINJECT.PSINJECT_DOCSUPPLIEDRES"]/*' />
    [NativeTypeName("#define PSINJECT_DOCSUPPLIEDRES 6")]
    public const int PSINJECT_DOCSUPPLIEDRES = 6;

    /// <include file='PSINJECT.xml' path='doc/member[@name="PSINJECT.PSINJECT_PAGEORDER"]/*' />
    [NativeTypeName("#define PSINJECT_PAGEORDER 7")]
    public const int PSINJECT_PAGEORDER = 7;

    /// <include file='PSINJECT.xml' path='doc/member[@name="PSINJECT.PSINJECT_ORIENTATION"]/*' />
    [NativeTypeName("#define PSINJECT_ORIENTATION 8")]
    public const int PSINJECT_ORIENTATION = 8;

    /// <include file='PSINJECT.xml' path='doc/member[@name="PSINJECT.PSINJECT_BOUNDINGBOX"]/*' />
    [NativeTypeName("#define PSINJECT_BOUNDINGBOX 9")]
    public const int PSINJECT_BOUNDINGBOX = 9;

    /// <include file='PSINJECT.xml' path='doc/member[@name="PSINJECT.PSINJECT_DOCUMENTPROCESSCOLORS"]/*' />
    [NativeTypeName("#define PSINJECT_DOCUMENTPROCESSCOLORS 10")]
    public const int PSINJECT_DOCUMENTPROCESSCOLORS = 10;

    /// <include file='PSINJECT.xml' path='doc/member[@name="PSINJECT.PSINJECT_COMMENTS"]/*' />
    [NativeTypeName("#define PSINJECT_COMMENTS 11")]
    public const int PSINJECT_COMMENTS = 11;

    /// <include file='PSINJECT.xml' path='doc/member[@name="PSINJECT.PSINJECT_BEGINDEFAULTS"]/*' />
    [NativeTypeName("#define PSINJECT_BEGINDEFAULTS 12")]
    public const int PSINJECT_BEGINDEFAULTS = 12;

    /// <include file='PSINJECT.xml' path='doc/member[@name="PSINJECT.PSINJECT_ENDDEFAULTS"]/*' />
    [NativeTypeName("#define PSINJECT_ENDDEFAULTS 13")]
    public const int PSINJECT_ENDDEFAULTS = 13;

    /// <include file='PSINJECT.xml' path='doc/member[@name="PSINJECT.PSINJECT_BEGINPROLOG"]/*' />
    [NativeTypeName("#define PSINJECT_BEGINPROLOG 14")]
    public const int PSINJECT_BEGINPROLOG = 14;

    /// <include file='PSINJECT.xml' path='doc/member[@name="PSINJECT.PSINJECT_ENDPROLOG"]/*' />
    [NativeTypeName("#define PSINJECT_ENDPROLOG 15")]
    public const int PSINJECT_ENDPROLOG = 15;

    /// <include file='PSINJECT.xml' path='doc/member[@name="PSINJECT.PSINJECT_BEGINSETUP"]/*' />
    [NativeTypeName("#define PSINJECT_BEGINSETUP 16")]
    public const int PSINJECT_BEGINSETUP = 16;

    /// <include file='PSINJECT.xml' path='doc/member[@name="PSINJECT.PSINJECT_ENDSETUP"]/*' />
    [NativeTypeName("#define PSINJECT_ENDSETUP 17")]
    public const int PSINJECT_ENDSETUP = 17;

    /// <include file='PSINJECT.xml' path='doc/member[@name="PSINJECT.PSINJECT_TRAILER"]/*' />
    [NativeTypeName("#define PSINJECT_TRAILER 18")]
    public const int PSINJECT_TRAILER = 18;

    /// <include file='PSINJECT.xml' path='doc/member[@name="PSINJECT.PSINJECT_EOF"]/*' />
    [NativeTypeName("#define PSINJECT_EOF 19")]
    public const int PSINJECT_EOF = 19;

    /// <include file='PSINJECT.xml' path='doc/member[@name="PSINJECT.PSINJECT_ENDSTREAM"]/*' />
    [NativeTypeName("#define PSINJECT_ENDSTREAM 20")]
    public const int PSINJECT_ENDSTREAM = 20;

    /// <include file='PSINJECT.xml' path='doc/member[@name="PSINJECT.PSINJECT_DOCUMENTPROCESSCOLORSATEND"]/*' />
    [NativeTypeName("#define PSINJECT_DOCUMENTPROCESSCOLORSATEND 21")]
    public const int PSINJECT_DOCUMENTPROCESSCOLORSATEND = 21;

    /// <include file='PSINJECT.xml' path='doc/member[@name="PSINJECT.PSINJECT_PAGENUMBER"]/*' />
    [NativeTypeName("#define PSINJECT_PAGENUMBER 100")]
    public const int PSINJECT_PAGENUMBER = 100;

    /// <include file='PSINJECT.xml' path='doc/member[@name="PSINJECT.PSINJECT_BEGINPAGESETUP"]/*' />
    [NativeTypeName("#define PSINJECT_BEGINPAGESETUP 101")]
    public const int PSINJECT_BEGINPAGESETUP = 101;

    /// <include file='PSINJECT.xml' path='doc/member[@name="PSINJECT.PSINJECT_ENDPAGESETUP"]/*' />
    [NativeTypeName("#define PSINJECT_ENDPAGESETUP 102")]
    public const int PSINJECT_ENDPAGESETUP = 102;

    /// <include file='PSINJECT.xml' path='doc/member[@name="PSINJECT.PSINJECT_PAGETRAILER"]/*' />
    [NativeTypeName("#define PSINJECT_PAGETRAILER 103")]
    public const int PSINJECT_PAGETRAILER = 103;

    /// <include file='PSINJECT.xml' path='doc/member[@name="PSINJECT.PSINJECT_PLATECOLOR"]/*' />
    [NativeTypeName("#define PSINJECT_PLATECOLOR 104")]
    public const int PSINJECT_PLATECOLOR = 104;

    /// <include file='PSINJECT.xml' path='doc/member[@name="PSINJECT.PSINJECT_SHOWPAGE"]/*' />
    [NativeTypeName("#define PSINJECT_SHOWPAGE 105")]
    public const int PSINJECT_SHOWPAGE = 105;

    /// <include file='PSINJECT.xml' path='doc/member[@name="PSINJECT.PSINJECT_PAGEBBOX"]/*' />
    [NativeTypeName("#define PSINJECT_PAGEBBOX 106")]
    public const int PSINJECT_PAGEBBOX = 106;

    /// <include file='PSINJECT.xml' path='doc/member[@name="PSINJECT.PSINJECT_ENDPAGECOMMENTS"]/*' />
    [NativeTypeName("#define PSINJECT_ENDPAGECOMMENTS 107")]
    public const int PSINJECT_ENDPAGECOMMENTS = 107;

    /// <include file='PSINJECT.xml' path='doc/member[@name="PSINJECT.PSINJECT_VMSAVE"]/*' />
    [NativeTypeName("#define PSINJECT_VMSAVE 200")]
    public const int PSINJECT_VMSAVE = 200;

    /// <include file='PSINJECT.xml' path='doc/member[@name="PSINJECT.PSINJECT_VMRESTORE"]/*' />
    [NativeTypeName("#define PSINJECT_VMRESTORE 201")]
    public const int PSINJECT_VMRESTORE = 201;

    /// <include file='PSINJECT.xml' path='doc/member[@name="PSINJECT.PSINJECT_DLFONT"]/*' />
    [NativeTypeName("#define PSINJECT_DLFONT 0xdddddddd")]
    public const uint PSINJECT_DLFONT = 0xdddddddd;
}
