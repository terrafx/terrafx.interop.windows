// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class FS
{
    /// <include file='FS.xml' path='doc/member[@name="FS.FS_LATIN1"]/*' />
    [NativeTypeName("#define FS_LATIN1 0x00000001L")]
    public const int FS_LATIN1 = 0x00000001;

    /// <include file='FS.xml' path='doc/member[@name="FS.FS_LATIN2"]/*' />
    [NativeTypeName("#define FS_LATIN2 0x00000002L")]
    public const int FS_LATIN2 = 0x00000002;

    /// <include file='FS.xml' path='doc/member[@name="FS.FS_CYRILLIC"]/*' />
    [NativeTypeName("#define FS_CYRILLIC 0x00000004L")]
    public const int FS_CYRILLIC = 0x00000004;

    /// <include file='FS.xml' path='doc/member[@name="FS.FS_GREEK"]/*' />
    [NativeTypeName("#define FS_GREEK 0x00000008L")]
    public const int FS_GREEK = 0x00000008;

    /// <include file='FS.xml' path='doc/member[@name="FS.FS_TURKISH"]/*' />
    [NativeTypeName("#define FS_TURKISH 0x00000010L")]
    public const int FS_TURKISH = 0x00000010;

    /// <include file='FS.xml' path='doc/member[@name="FS.FS_HEBREW"]/*' />
    [NativeTypeName("#define FS_HEBREW 0x00000020L")]
    public const int FS_HEBREW = 0x00000020;

    /// <include file='FS.xml' path='doc/member[@name="FS.FS_ARABIC"]/*' />
    [NativeTypeName("#define FS_ARABIC 0x00000040L")]
    public const int FS_ARABIC = 0x00000040;

    /// <include file='FS.xml' path='doc/member[@name="FS.FS_BALTIC"]/*' />
    [NativeTypeName("#define FS_BALTIC 0x00000080L")]
    public const int FS_BALTIC = 0x00000080;

    /// <include file='FS.xml' path='doc/member[@name="FS.FS_VIETNAMESE"]/*' />
    [NativeTypeName("#define FS_VIETNAMESE 0x00000100L")]
    public const int FS_VIETNAMESE = 0x00000100;

    /// <include file='FS.xml' path='doc/member[@name="FS.FS_THAI"]/*' />
    [NativeTypeName("#define FS_THAI 0x00010000L")]
    public const int FS_THAI = 0x00010000;

    /// <include file='FS.xml' path='doc/member[@name="FS.FS_JISJAPAN"]/*' />
    [NativeTypeName("#define FS_JISJAPAN 0x00020000L")]
    public const int FS_JISJAPAN = 0x00020000;

    /// <include file='FS.xml' path='doc/member[@name="FS.FS_CHINESESIMP"]/*' />
    [NativeTypeName("#define FS_CHINESESIMP 0x00040000L")]
    public const int FS_CHINESESIMP = 0x00040000;

    /// <include file='FS.xml' path='doc/member[@name="FS.FS_WANSUNG"]/*' />
    [NativeTypeName("#define FS_WANSUNG 0x00080000L")]
    public const int FS_WANSUNG = 0x00080000;

    /// <include file='FS.xml' path='doc/member[@name="FS.FS_CHINESETRAD"]/*' />
    [NativeTypeName("#define FS_CHINESETRAD 0x00100000L")]
    public const int FS_CHINESETRAD = 0x00100000;

    /// <include file='FS.xml' path='doc/member[@name="FS.FS_JOHAB"]/*' />
    [NativeTypeName("#define FS_JOHAB 0x00200000L")]
    public const int FS_JOHAB = 0x00200000;

    /// <include file='FS.xml' path='doc/member[@name="FS.FS_SYMBOL"]/*' />
    [NativeTypeName("#define FS_SYMBOL 0x80000000L")]
    public const uint FS_SYMBOL = 0x80000000;
}
