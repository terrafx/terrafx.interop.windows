// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class CF
{
    /// <include file='CF.xml' path='doc/member[@name="CF.CF_TEXT"]/*' />
    [NativeTypeName("#define CF_TEXT 1")]
    public const int CF_TEXT = 1;

    /// <include file='CF.xml' path='doc/member[@name="CF.CF_BITMAP"]/*' />
    [NativeTypeName("#define CF_BITMAP 2")]
    public const int CF_BITMAP = 2;

    /// <include file='CF.xml' path='doc/member[@name="CF.CF_METAFILEPICT"]/*' />
    [NativeTypeName("#define CF_METAFILEPICT 3")]
    public const int CF_METAFILEPICT = 3;

    /// <include file='CF.xml' path='doc/member[@name="CF.CF_SYLK"]/*' />
    [NativeTypeName("#define CF_SYLK 4")]
    public const int CF_SYLK = 4;

    /// <include file='CF.xml' path='doc/member[@name="CF.CF_DIF"]/*' />
    [NativeTypeName("#define CF_DIF 5")]
    public const int CF_DIF = 5;

    /// <include file='CF.xml' path='doc/member[@name="CF.CF_TIFF"]/*' />
    [NativeTypeName("#define CF_TIFF 6")]
    public const int CF_TIFF = 6;

    /// <include file='CF.xml' path='doc/member[@name="CF.CF_OEMTEXT"]/*' />
    [NativeTypeName("#define CF_OEMTEXT 7")]
    public const int CF_OEMTEXT = 7;

    /// <include file='CF.xml' path='doc/member[@name="CF.CF_DIB"]/*' />
    [NativeTypeName("#define CF_DIB 8")]
    public const int CF_DIB = 8;

    /// <include file='CF.xml' path='doc/member[@name="CF.CF_PALETTE"]/*' />
    [NativeTypeName("#define CF_PALETTE 9")]
    public const int CF_PALETTE = 9;

    /// <include file='CF.xml' path='doc/member[@name="CF.CF_PENDATA"]/*' />
    [NativeTypeName("#define CF_PENDATA 10")]
    public const int CF_PENDATA = 10;

    /// <include file='CF.xml' path='doc/member[@name="CF.CF_RIFF"]/*' />
    [NativeTypeName("#define CF_RIFF 11")]
    public const int CF_RIFF = 11;

    /// <include file='CF.xml' path='doc/member[@name="CF.CF_WAVE"]/*' />
    [NativeTypeName("#define CF_WAVE 12")]
    public const int CF_WAVE = 12;

    /// <include file='CF.xml' path='doc/member[@name="CF.CF_UNICODETEXT"]/*' />
    [NativeTypeName("#define CF_UNICODETEXT 13")]
    public const int CF_UNICODETEXT = 13;

    /// <include file='CF.xml' path='doc/member[@name="CF.CF_ENHMETAFILE"]/*' />
    [NativeTypeName("#define CF_ENHMETAFILE 14")]
    public const int CF_ENHMETAFILE = 14;

    /// <include file='CF.xml' path='doc/member[@name="CF.CF_HDROP"]/*' />
    [NativeTypeName("#define CF_HDROP 15")]
    public const int CF_HDROP = 15;

    /// <include file='CF.xml' path='doc/member[@name="CF.CF_LOCALE"]/*' />
    [NativeTypeName("#define CF_LOCALE 16")]
    public const int CF_LOCALE = 16;

    /// <include file='CF.xml' path='doc/member[@name="CF.CF_DIBV5"]/*' />
    [NativeTypeName("#define CF_DIBV5 17")]
    public const int CF_DIBV5 = 17;

    /// <include file='CF.xml' path='doc/member[@name="CF.CF_MAX"]/*' />
    [NativeTypeName("#define CF_MAX 18")]
    public const int CF_MAX = 18;

    /// <include file='CF.xml' path='doc/member[@name="CF.CF_OWNERDISPLAY"]/*' />
    [NativeTypeName("#define CF_OWNERDISPLAY 0x0080")]
    public const int CF_OWNERDISPLAY = 0x0080;

    /// <include file='CF.xml' path='doc/member[@name="CF.CF_DSPTEXT"]/*' />
    [NativeTypeName("#define CF_DSPTEXT 0x0081")]
    public const int CF_DSPTEXT = 0x0081;

    /// <include file='CF.xml' path='doc/member[@name="CF.CF_DSPBITMAP"]/*' />
    [NativeTypeName("#define CF_DSPBITMAP 0x0082")]
    public const int CF_DSPBITMAP = 0x0082;

    /// <include file='CF.xml' path='doc/member[@name="CF.CF_DSPMETAFILEPICT"]/*' />
    [NativeTypeName("#define CF_DSPMETAFILEPICT 0x0083")]
    public const int CF_DSPMETAFILEPICT = 0x0083;

    /// <include file='CF.xml' path='doc/member[@name="CF.CF_DSPENHMETAFILE"]/*' />
    [NativeTypeName("#define CF_DSPENHMETAFILE 0x008E")]
    public const int CF_DSPENHMETAFILE = 0x008E;

    /// <include file='CF.xml' path='doc/member[@name="CF.CF_PRIVATEFIRST"]/*' />
    [NativeTypeName("#define CF_PRIVATEFIRST 0x0200")]
    public const int CF_PRIVATEFIRST = 0x0200;

    /// <include file='CF.xml' path='doc/member[@name="CF.CF_PRIVATELAST"]/*' />
    [NativeTypeName("#define CF_PRIVATELAST 0x02FF")]
    public const int CF_PRIVATELAST = 0x02FF;

    /// <include file='CF.xml' path='doc/member[@name="CF.CF_GDIOBJFIRST"]/*' />
    [NativeTypeName("#define CF_GDIOBJFIRST 0x0300")]
    public const int CF_GDIOBJFIRST = 0x0300;

    /// <include file='CF.xml' path='doc/member[@name="CF.CF_GDIOBJLAST"]/*' />
    [NativeTypeName("#define CF_GDIOBJLAST 0x03FF")]
    public const int CF_GDIOBJLAST = 0x03FF;
}
