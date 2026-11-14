// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsiDefs.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class PID
{
    /// <include file='PID.xml' path='doc/member[@name="PID.PID_TITLE"]/*' />
    [NativeTypeName("#define PID_TITLE 2")]
    public const int PID_TITLE = 2;

    /// <include file='PID.xml' path='doc/member[@name="PID.PID_SUBJECT"]/*' />
    [NativeTypeName("#define PID_SUBJECT 3")]
    public const int PID_SUBJECT = 3;

    /// <include file='PID.xml' path='doc/member[@name="PID.PID_AUTHOR"]/*' />
    [NativeTypeName("#define PID_AUTHOR 4")]
    public const int PID_AUTHOR = 4;

    /// <include file='PID.xml' path='doc/member[@name="PID.PID_KEYWORDS"]/*' />
    [NativeTypeName("#define PID_KEYWORDS 5")]
    public const int PID_KEYWORDS = 5;

    /// <include file='PID.xml' path='doc/member[@name="PID.PID_COMMENTS"]/*' />
    [NativeTypeName("#define PID_COMMENTS 6")]
    public const int PID_COMMENTS = 6;

    /// <include file='PID.xml' path='doc/member[@name="PID.PID_TEMPLATE"]/*' />
    [NativeTypeName("#define PID_TEMPLATE 7")]
    public const int PID_TEMPLATE = 7;

    /// <include file='PID.xml' path='doc/member[@name="PID.PID_LASTAUTHOR"]/*' />
    [NativeTypeName("#define PID_LASTAUTHOR 8")]
    public const int PID_LASTAUTHOR = 8;

    /// <include file='PID.xml' path='doc/member[@name="PID.PID_REVNUMBER"]/*' />
    [NativeTypeName("#define PID_REVNUMBER 9")]
    public const int PID_REVNUMBER = 9;

    /// <include file='PID.xml' path='doc/member[@name="PID.PID_EDITTIME"]/*' />
    [NativeTypeName("#define PID_EDITTIME 10")]
    public const int PID_EDITTIME = 10;

    /// <include file='PID.xml' path='doc/member[@name="PID.PID_LASTPRINTED"]/*' />
    [NativeTypeName("#define PID_LASTPRINTED 11")]
    public const int PID_LASTPRINTED = 11;

    /// <include file='PID.xml' path='doc/member[@name="PID.PID_CREATE_DTM"]/*' />
    [NativeTypeName("#define PID_CREATE_DTM 12")]
    public const int PID_CREATE_DTM = 12;

    /// <include file='PID.xml' path='doc/member[@name="PID.PID_LASTSAVE_DTM"]/*' />
    [NativeTypeName("#define PID_LASTSAVE_DTM 13")]
    public const int PID_LASTSAVE_DTM = 13;

    /// <include file='PID.xml' path='doc/member[@name="PID.PID_PAGECOUNT"]/*' />
    [NativeTypeName("#define PID_PAGECOUNT 14")]
    public const int PID_PAGECOUNT = 14;

    /// <include file='PID.xml' path='doc/member[@name="PID.PID_WORDCOUNT"]/*' />
    [NativeTypeName("#define PID_WORDCOUNT 15")]
    public const int PID_WORDCOUNT = 15;

    /// <include file='PID.xml' path='doc/member[@name="PID.PID_CHARCOUNT"]/*' />
    [NativeTypeName("#define PID_CHARCOUNT 16")]
    public const int PID_CHARCOUNT = 16;

    /// <include file='PID.xml' path='doc/member[@name="PID.PID_THUMBNAIL"]/*' />
    [NativeTypeName("#define PID_THUMBNAIL 17")]
    public const int PID_THUMBNAIL = 17;

    /// <include file='PID.xml' path='doc/member[@name="PID.PID_APPNAME"]/*' />
    [NativeTypeName("#define PID_APPNAME 18")]
    public const int PID_APPNAME = 18;

    /// <include file='PID.xml' path='doc/member[@name="PID.PID_MSIVERSION"]/*' />
    [NativeTypeName("#define PID_MSIVERSION PID_PAGECOUNT")]
    public const int PID_MSIVERSION = 14;

    /// <include file='PID.xml' path='doc/member[@name="PID.PID_MSISOURCE"]/*' />
    [NativeTypeName("#define PID_MSISOURCE PID_WORDCOUNT")]
    public const int PID_MSISOURCE = 15;

    /// <include file='PID.xml' path='doc/member[@name="PID.PID_MSIRESTRICT"]/*' />
    [NativeTypeName("#define PID_MSIRESTRICT PID_CHARCOUNT")]
    public const int PID_MSIRESTRICT = 16;
}
