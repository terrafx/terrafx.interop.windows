// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/CommDlg.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class FR
{
    /// <include file='FR.xml' path='doc/member[@name="FR.FR_DOWN"]/*' />
    [NativeTypeName("#define FR_DOWN 0x00000001")]
    public const int FR_DOWN = 0x00000001;

    /// <include file='FR.xml' path='doc/member[@name="FR.FR_WHOLEWORD"]/*' />
    [NativeTypeName("#define FR_WHOLEWORD 0x00000002")]
    public const int FR_WHOLEWORD = 0x00000002;

    /// <include file='FR.xml' path='doc/member[@name="FR.FR_MATCHCASE"]/*' />
    [NativeTypeName("#define FR_MATCHCASE 0x00000004")]
    public const int FR_MATCHCASE = 0x00000004;

    /// <include file='FR.xml' path='doc/member[@name="FR.FR_FINDNEXT"]/*' />
    [NativeTypeName("#define FR_FINDNEXT 0x00000008")]
    public const int FR_FINDNEXT = 0x00000008;

    /// <include file='FR.xml' path='doc/member[@name="FR.FR_REPLACE"]/*' />
    [NativeTypeName("#define FR_REPLACE 0x00000010")]
    public const int FR_REPLACE = 0x00000010;

    /// <include file='FR.xml' path='doc/member[@name="FR.FR_REPLACEALL"]/*' />
    [NativeTypeName("#define FR_REPLACEALL 0x00000020")]
    public const int FR_REPLACEALL = 0x00000020;

    /// <include file='FR.xml' path='doc/member[@name="FR.FR_DIALOGTERM"]/*' />
    [NativeTypeName("#define FR_DIALOGTERM 0x00000040")]
    public const int FR_DIALOGTERM = 0x00000040;

    /// <include file='FR.xml' path='doc/member[@name="FR.FR_SHOWHELP"]/*' />
    [NativeTypeName("#define FR_SHOWHELP 0x00000080")]
    public const int FR_SHOWHELP = 0x00000080;

    /// <include file='FR.xml' path='doc/member[@name="FR.FR_ENABLEHOOK"]/*' />
    [NativeTypeName("#define FR_ENABLEHOOK 0x00000100")]
    public const int FR_ENABLEHOOK = 0x00000100;

    /// <include file='FR.xml' path='doc/member[@name="FR.FR_ENABLETEMPLATE"]/*' />
    [NativeTypeName("#define FR_ENABLETEMPLATE 0x00000200")]
    public const int FR_ENABLETEMPLATE = 0x00000200;

    /// <include file='FR.xml' path='doc/member[@name="FR.FR_NOUPDOWN"]/*' />
    [NativeTypeName("#define FR_NOUPDOWN 0x00000400")]
    public const int FR_NOUPDOWN = 0x00000400;

    /// <include file='FR.xml' path='doc/member[@name="FR.FR_NOMATCHCASE"]/*' />
    [NativeTypeName("#define FR_NOMATCHCASE 0x00000800")]
    public const int FR_NOMATCHCASE = 0x00000800;

    /// <include file='FR.xml' path='doc/member[@name="FR.FR_NOWHOLEWORD"]/*' />
    [NativeTypeName("#define FR_NOWHOLEWORD 0x00001000")]
    public const int FR_NOWHOLEWORD = 0x00001000;

    /// <include file='FR.xml' path='doc/member[@name="FR.FR_ENABLETEMPLATEHANDLE"]/*' />
    [NativeTypeName("#define FR_ENABLETEMPLATEHANDLE 0x00002000")]
    public const int FR_ENABLETEMPLATEHANDLE = 0x00002000;

    /// <include file='FR.xml' path='doc/member[@name="FR.FR_HIDEUPDOWN"]/*' />
    [NativeTypeName("#define FR_HIDEUPDOWN 0x00004000")]
    public const int FR_HIDEUPDOWN = 0x00004000;

    /// <include file='FR.xml' path='doc/member[@name="FR.FR_HIDEMATCHCASE"]/*' />
    [NativeTypeName("#define FR_HIDEMATCHCASE 0x00008000")]
    public const int FR_HIDEMATCHCASE = 0x00008000;

    /// <include file='FR.xml' path='doc/member[@name="FR.FR_HIDEWHOLEWORD"]/*' />
    [NativeTypeName("#define FR_HIDEWHOLEWORD 0x00010000")]
    public const int FR_HIDEWHOLEWORD = 0x00010000;

    /// <include file='FR.xml' path='doc/member[@name="FR.FR_RAW"]/*' />
    [NativeTypeName("#define FR_RAW 0x00020000")]
    public const int FR_RAW = 0x00020000;

    /// <include file='FR.xml' path='doc/member[@name="FR.FR_SHOWWRAPAROUND"]/*' />
    [NativeTypeName("#define FR_SHOWWRAPAROUND 0x00040000")]
    public const int FR_SHOWWRAPAROUND = 0x00040000;

    /// <include file='FR.xml' path='doc/member[@name="FR.FR_NOWRAPAROUND"]/*' />
    [NativeTypeName("#define FR_NOWRAPAROUND 0x00080000")]
    public const int FR_NOWRAPAROUND = 0x00080000;

    /// <include file='FR.xml' path='doc/member[@name="FR.FR_WRAPAROUND"]/*' />
    [NativeTypeName("#define FR_WRAPAROUND 0x00100000")]
    public const int FR_WRAPAROUND = 0x00100000;

    /// <include file='FR.xml' path='doc/member[@name="FR.FR_MATCHDIAC"]/*' />
    [NativeTypeName("#define FR_MATCHDIAC 0x20000000")]
    public const int FR_MATCHDIAC = 0x20000000;

    /// <include file='FR.xml' path='doc/member[@name="FR.FR_MATCHKASHIDA"]/*' />
    [NativeTypeName("#define FR_MATCHKASHIDA 0x40000000")]
    public const int FR_MATCHKASHIDA = 0x40000000;

    /// <include file='FR.xml' path='doc/member[@name="FR.FR_MATCHALEFHAMZA"]/*' />
    [NativeTypeName("#define FR_MATCHALEFHAMZA 0x80000000")]
    public const uint FR_MATCHALEFHAMZA = 0x80000000;
}
