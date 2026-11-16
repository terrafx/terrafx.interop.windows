// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class OBJID
{
    /// <include file='OBJID.xml' path='doc/member[@name="OBJID.OBJID_WINDOW"]/*' />
    [NativeTypeName("#define OBJID_WINDOW ((LONG)0x00000000)")]
    public const int OBJID_WINDOW = ((int)(0x00000000));

    /// <include file='OBJID.xml' path='doc/member[@name="OBJID.OBJID_SYSMENU"]/*' />
    [NativeTypeName("#define OBJID_SYSMENU ((LONG)0xFFFFFFFF)")]
    public const int OBJID_SYSMENU = unchecked((int)(0xFFFFFFFF));

    /// <include file='OBJID.xml' path='doc/member[@name="OBJID.OBJID_TITLEBAR"]/*' />
    [NativeTypeName("#define OBJID_TITLEBAR ((LONG)0xFFFFFFFE)")]
    public const int OBJID_TITLEBAR = unchecked((int)(0xFFFFFFFE));

    /// <include file='OBJID.xml' path='doc/member[@name="OBJID.OBJID_MENU"]/*' />
    [NativeTypeName("#define OBJID_MENU ((LONG)0xFFFFFFFD)")]
    public const int OBJID_MENU = unchecked((int)(0xFFFFFFFD));

    /// <include file='OBJID.xml' path='doc/member[@name="OBJID.OBJID_CLIENT"]/*' />
    [NativeTypeName("#define OBJID_CLIENT ((LONG)0xFFFFFFFC)")]
    public const int OBJID_CLIENT = unchecked((int)(0xFFFFFFFC));

    /// <include file='OBJID.xml' path='doc/member[@name="OBJID.OBJID_VSCROLL"]/*' />
    [NativeTypeName("#define OBJID_VSCROLL ((LONG)0xFFFFFFFB)")]
    public const int OBJID_VSCROLL = unchecked((int)(0xFFFFFFFB));

    /// <include file='OBJID.xml' path='doc/member[@name="OBJID.OBJID_HSCROLL"]/*' />
    [NativeTypeName("#define OBJID_HSCROLL ((LONG)0xFFFFFFFA)")]
    public const int OBJID_HSCROLL = unchecked((int)(0xFFFFFFFA));

    /// <include file='OBJID.xml' path='doc/member[@name="OBJID.OBJID_SIZEGRIP"]/*' />
    [NativeTypeName("#define OBJID_SIZEGRIP ((LONG)0xFFFFFFF9)")]
    public const int OBJID_SIZEGRIP = unchecked((int)(0xFFFFFFF9));

    /// <include file='OBJID.xml' path='doc/member[@name="OBJID.OBJID_CARET"]/*' />
    [NativeTypeName("#define OBJID_CARET ((LONG)0xFFFFFFF8)")]
    public const int OBJID_CARET = unchecked((int)(0xFFFFFFF8));

    /// <include file='OBJID.xml' path='doc/member[@name="OBJID.OBJID_CURSOR"]/*' />
    [NativeTypeName("#define OBJID_CURSOR ((LONG)0xFFFFFFF7)")]
    public const int OBJID_CURSOR = unchecked((int)(0xFFFFFFF7));

    /// <include file='OBJID.xml' path='doc/member[@name="OBJID.OBJID_ALERT"]/*' />
    [NativeTypeName("#define OBJID_ALERT ((LONG)0xFFFFFFF6)")]
    public const int OBJID_ALERT = unchecked((int)(0xFFFFFFF6));

    /// <include file='OBJID.xml' path='doc/member[@name="OBJID.OBJID_SOUND"]/*' />
    [NativeTypeName("#define OBJID_SOUND ((LONG)0xFFFFFFF5)")]
    public const int OBJID_SOUND = unchecked((int)(0xFFFFFFF5));

    /// <include file='OBJID.xml' path='doc/member[@name="OBJID.OBJID_QUERYCLASSNAMEIDX"]/*' />
    [NativeTypeName("#define OBJID_QUERYCLASSNAMEIDX ((LONG)0xFFFFFFF4)")]
    public const int OBJID_QUERYCLASSNAMEIDX = unchecked((int)(0xFFFFFFF4));

    /// <include file='OBJID.xml' path='doc/member[@name="OBJID.OBJID_NATIVEOM"]/*' />
    [NativeTypeName("#define OBJID_NATIVEOM ((LONG)0xFFFFFFF0)")]
    public const int OBJID_NATIVEOM = unchecked((int)(0xFFFFFFF0));
}
