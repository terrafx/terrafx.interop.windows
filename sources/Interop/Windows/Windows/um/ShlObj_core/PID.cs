// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShlObj_core.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class PID
{
    /// <include file='PID.xml' path='doc/member[@name="PID.PID_IS_URL"]/*' />
    [NativeTypeName("#define PID_IS_URL 2")]
    public const int PID_IS_URL = 2;

    /// <include file='PID.xml' path='doc/member[@name="PID.PID_IS_NAME"]/*' />
    [NativeTypeName("#define PID_IS_NAME 4")]
    public const int PID_IS_NAME = 4;

    /// <include file='PID.xml' path='doc/member[@name="PID.PID_IS_WORKINGDIR"]/*' />
    [NativeTypeName("#define PID_IS_WORKINGDIR 5")]
    public const int PID_IS_WORKINGDIR = 5;

    /// <include file='PID.xml' path='doc/member[@name="PID.PID_IS_HOTKEY"]/*' />
    [NativeTypeName("#define PID_IS_HOTKEY 6")]
    public const int PID_IS_HOTKEY = 6;

    /// <include file='PID.xml' path='doc/member[@name="PID.PID_IS_SHOWCMD"]/*' />
    [NativeTypeName("#define PID_IS_SHOWCMD 7")]
    public const int PID_IS_SHOWCMD = 7;

    /// <include file='PID.xml' path='doc/member[@name="PID.PID_IS_ICONINDEX"]/*' />
    [NativeTypeName("#define PID_IS_ICONINDEX 8")]
    public const int PID_IS_ICONINDEX = 8;

    /// <include file='PID.xml' path='doc/member[@name="PID.PID_IS_ICONFILE"]/*' />
    [NativeTypeName("#define PID_IS_ICONFILE 9")]
    public const int PID_IS_ICONFILE = 9;

    /// <include file='PID.xml' path='doc/member[@name="PID.PID_IS_WHATSNEW"]/*' />
    [NativeTypeName("#define PID_IS_WHATSNEW 10")]
    public const int PID_IS_WHATSNEW = 10;

    /// <include file='PID.xml' path='doc/member[@name="PID.PID_IS_AUTHOR"]/*' />
    [NativeTypeName("#define PID_IS_AUTHOR 11")]
    public const int PID_IS_AUTHOR = 11;

    /// <include file='PID.xml' path='doc/member[@name="PID.PID_IS_DESCRIPTION"]/*' />
    [NativeTypeName("#define PID_IS_DESCRIPTION 12")]
    public const int PID_IS_DESCRIPTION = 12;

    /// <include file='PID.xml' path='doc/member[@name="PID.PID_IS_COMMENT"]/*' />
    [NativeTypeName("#define PID_IS_COMMENT 13")]
    public const int PID_IS_COMMENT = 13;

    /// <include file='PID.xml' path='doc/member[@name="PID.PID_IS_ROAMED"]/*' />
    [NativeTypeName("#define PID_IS_ROAMED 15")]
    public const int PID_IS_ROAMED = 15;

    /// <include file='PID.xml' path='doc/member[@name="PID.PID_INTSITE_WHATSNEW"]/*' />
    [NativeTypeName("#define PID_INTSITE_WHATSNEW 2")]
    public const int PID_INTSITE_WHATSNEW = 2;

    /// <include file='PID.xml' path='doc/member[@name="PID.PID_INTSITE_AUTHOR"]/*' />
    [NativeTypeName("#define PID_INTSITE_AUTHOR 3")]
    public const int PID_INTSITE_AUTHOR = 3;

    /// <include file='PID.xml' path='doc/member[@name="PID.PID_INTSITE_LASTVISIT"]/*' />
    [NativeTypeName("#define PID_INTSITE_LASTVISIT 4")]
    public const int PID_INTSITE_LASTVISIT = 4;

    /// <include file='PID.xml' path='doc/member[@name="PID.PID_INTSITE_LASTMOD"]/*' />
    [NativeTypeName("#define PID_INTSITE_LASTMOD 5")]
    public const int PID_INTSITE_LASTMOD = 5;

    /// <include file='PID.xml' path='doc/member[@name="PID.PID_INTSITE_VISITCOUNT"]/*' />
    [NativeTypeName("#define PID_INTSITE_VISITCOUNT 6")]
    public const int PID_INTSITE_VISITCOUNT = 6;

    /// <include file='PID.xml' path='doc/member[@name="PID.PID_INTSITE_DESCRIPTION"]/*' />
    [NativeTypeName("#define PID_INTSITE_DESCRIPTION 7")]
    public const int PID_INTSITE_DESCRIPTION = 7;

    /// <include file='PID.xml' path='doc/member[@name="PID.PID_INTSITE_COMMENT"]/*' />
    [NativeTypeName("#define PID_INTSITE_COMMENT 8")]
    public const int PID_INTSITE_COMMENT = 8;

    /// <include file='PID.xml' path='doc/member[@name="PID.PID_INTSITE_FLAGS"]/*' />
    [NativeTypeName("#define PID_INTSITE_FLAGS 9")]
    public const int PID_INTSITE_FLAGS = 9;

    /// <include file='PID.xml' path='doc/member[@name="PID.PID_INTSITE_CONTENTLEN"]/*' />
    [NativeTypeName("#define PID_INTSITE_CONTENTLEN 10")]
    public const int PID_INTSITE_CONTENTLEN = 10;

    /// <include file='PID.xml' path='doc/member[@name="PID.PID_INTSITE_CONTENTCODE"]/*' />
    [NativeTypeName("#define PID_INTSITE_CONTENTCODE 11")]
    public const int PID_INTSITE_CONTENTCODE = 11;

    /// <include file='PID.xml' path='doc/member[@name="PID.PID_INTSITE_RECURSE"]/*' />
    [NativeTypeName("#define PID_INTSITE_RECURSE 12")]
    public const int PID_INTSITE_RECURSE = 12;

    /// <include file='PID.xml' path='doc/member[@name="PID.PID_INTSITE_WATCH"]/*' />
    [NativeTypeName("#define PID_INTSITE_WATCH 13")]
    public const int PID_INTSITE_WATCH = 13;

    /// <include file='PID.xml' path='doc/member[@name="PID.PID_INTSITE_SUBSCRIPTION"]/*' />
    [NativeTypeName("#define PID_INTSITE_SUBSCRIPTION 14")]
    public const int PID_INTSITE_SUBSCRIPTION = 14;

    /// <include file='PID.xml' path='doc/member[@name="PID.PID_INTSITE_URL"]/*' />
    [NativeTypeName("#define PID_INTSITE_URL 15")]
    public const int PID_INTSITE_URL = 15;

    /// <include file='PID.xml' path='doc/member[@name="PID.PID_INTSITE_TITLE"]/*' />
    [NativeTypeName("#define PID_INTSITE_TITLE 16")]
    public const int PID_INTSITE_TITLE = 16;

    /// <include file='PID.xml' path='doc/member[@name="PID.PID_INTSITE_CODEPAGE"]/*' />
    [NativeTypeName("#define PID_INTSITE_CODEPAGE 18")]
    public const int PID_INTSITE_CODEPAGE = 18;

    /// <include file='PID.xml' path='doc/member[@name="PID.PID_INTSITE_TRACKING"]/*' />
    [NativeTypeName("#define PID_INTSITE_TRACKING 19")]
    public const int PID_INTSITE_TRACKING = 19;

    /// <include file='PID.xml' path='doc/member[@name="PID.PID_INTSITE_ICONINDEX"]/*' />
    [NativeTypeName("#define PID_INTSITE_ICONINDEX 20")]
    public const int PID_INTSITE_ICONINDEX = 20;

    /// <include file='PID.xml' path='doc/member[@name="PID.PID_INTSITE_ICONFILE"]/*' />
    [NativeTypeName("#define PID_INTSITE_ICONFILE 21")]
    public const int PID_INTSITE_ICONFILE = 21;

    /// <include file='PID.xml' path='doc/member[@name="PID.PID_INTSITE_ROAMED"]/*' />
    [NativeTypeName("#define PID_INTSITE_ROAMED 34")]
    public const int PID_INTSITE_ROAMED = 34;
}
