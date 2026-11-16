// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class ICC
{
    /// <include file='ICC.xml' path='doc/member[@name="ICC.ICC_LISTVIEW_CLASSES"]/*' />
    [NativeTypeName("#define ICC_LISTVIEW_CLASSES 0x00000001")]
    public const int ICC_LISTVIEW_CLASSES = 0x00000001;

    /// <include file='ICC.xml' path='doc/member[@name="ICC.ICC_TREEVIEW_CLASSES"]/*' />
    [NativeTypeName("#define ICC_TREEVIEW_CLASSES 0x00000002")]
    public const int ICC_TREEVIEW_CLASSES = 0x00000002;

    /// <include file='ICC.xml' path='doc/member[@name="ICC.ICC_BAR_CLASSES"]/*' />
    [NativeTypeName("#define ICC_BAR_CLASSES 0x00000004")]
    public const int ICC_BAR_CLASSES = 0x00000004;

    /// <include file='ICC.xml' path='doc/member[@name="ICC.ICC_TAB_CLASSES"]/*' />
    [NativeTypeName("#define ICC_TAB_CLASSES 0x00000008")]
    public const int ICC_TAB_CLASSES = 0x00000008;

    /// <include file='ICC.xml' path='doc/member[@name="ICC.ICC_UPDOWN_CLASS"]/*' />
    [NativeTypeName("#define ICC_UPDOWN_CLASS 0x00000010")]
    public const int ICC_UPDOWN_CLASS = 0x00000010;

    /// <include file='ICC.xml' path='doc/member[@name="ICC.ICC_PROGRESS_CLASS"]/*' />
    [NativeTypeName("#define ICC_PROGRESS_CLASS 0x00000020")]
    public const int ICC_PROGRESS_CLASS = 0x00000020;

    /// <include file='ICC.xml' path='doc/member[@name="ICC.ICC_HOTKEY_CLASS"]/*' />
    [NativeTypeName("#define ICC_HOTKEY_CLASS 0x00000040")]
    public const int ICC_HOTKEY_CLASS = 0x00000040;

    /// <include file='ICC.xml' path='doc/member[@name="ICC.ICC_ANIMATE_CLASS"]/*' />
    [NativeTypeName("#define ICC_ANIMATE_CLASS 0x00000080")]
    public const int ICC_ANIMATE_CLASS = 0x00000080;

    /// <include file='ICC.xml' path='doc/member[@name="ICC.ICC_WIN95_CLASSES"]/*' />
    [NativeTypeName("#define ICC_WIN95_CLASSES 0x000000FF")]
    public const int ICC_WIN95_CLASSES = 0x000000FF;

    /// <include file='ICC.xml' path='doc/member[@name="ICC.ICC_DATE_CLASSES"]/*' />
    [NativeTypeName("#define ICC_DATE_CLASSES 0x00000100")]
    public const int ICC_DATE_CLASSES = 0x00000100;

    /// <include file='ICC.xml' path='doc/member[@name="ICC.ICC_USEREX_CLASSES"]/*' />
    [NativeTypeName("#define ICC_USEREX_CLASSES 0x00000200")]
    public const int ICC_USEREX_CLASSES = 0x00000200;

    /// <include file='ICC.xml' path='doc/member[@name="ICC.ICC_COOL_CLASSES"]/*' />
    [NativeTypeName("#define ICC_COOL_CLASSES 0x00000400")]
    public const int ICC_COOL_CLASSES = 0x00000400;

    /// <include file='ICC.xml' path='doc/member[@name="ICC.ICC_INTERNET_CLASSES"]/*' />
    [NativeTypeName("#define ICC_INTERNET_CLASSES 0x00000800")]
    public const int ICC_INTERNET_CLASSES = 0x00000800;

    /// <include file='ICC.xml' path='doc/member[@name="ICC.ICC_PAGESCROLLER_CLASS"]/*' />
    [NativeTypeName("#define ICC_PAGESCROLLER_CLASS 0x00001000")]
    public const int ICC_PAGESCROLLER_CLASS = 0x00001000;

    /// <include file='ICC.xml' path='doc/member[@name="ICC.ICC_NATIVEFNTCTL_CLASS"]/*' />
    [NativeTypeName("#define ICC_NATIVEFNTCTL_CLASS 0x00002000")]
    public const int ICC_NATIVEFNTCTL_CLASS = 0x00002000;

    /// <include file='ICC.xml' path='doc/member[@name="ICC.ICC_STANDARD_CLASSES"]/*' />
    [NativeTypeName("#define ICC_STANDARD_CLASSES 0x00004000")]
    public const int ICC_STANDARD_CLASSES = 0x00004000;

    /// <include file='ICC.xml' path='doc/member[@name="ICC.ICC_LINK_CLASS"]/*' />
    [NativeTypeName("#define ICC_LINK_CLASS 0x00008000")]
    public const int ICC_LINK_CLASS = 0x00008000;
}
