// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class DT
{
    /// <include file='DT.xml' path='doc/member[@name="DT.DT_TOP"]/*' />
    [NativeTypeName("#define DT_TOP 0x00000000")]
    public const int DT_TOP = 0x00000000;

    /// <include file='DT.xml' path='doc/member[@name="DT.DT_LEFT"]/*' />
    [NativeTypeName("#define DT_LEFT 0x00000000")]
    public const int DT_LEFT = 0x00000000;

    /// <include file='DT.xml' path='doc/member[@name="DT.DT_CENTER"]/*' />
    [NativeTypeName("#define DT_CENTER 0x00000001")]
    public const int DT_CENTER = 0x00000001;

    /// <include file='DT.xml' path='doc/member[@name="DT.DT_RIGHT"]/*' />
    [NativeTypeName("#define DT_RIGHT 0x00000002")]
    public const int DT_RIGHT = 0x00000002;

    /// <include file='DT.xml' path='doc/member[@name="DT.DT_VCENTER"]/*' />
    [NativeTypeName("#define DT_VCENTER 0x00000004")]
    public const int DT_VCENTER = 0x00000004;

    /// <include file='DT.xml' path='doc/member[@name="DT.DT_BOTTOM"]/*' />
    [NativeTypeName("#define DT_BOTTOM 0x00000008")]
    public const int DT_BOTTOM = 0x00000008;

    /// <include file='DT.xml' path='doc/member[@name="DT.DT_WORDBREAK"]/*' />
    [NativeTypeName("#define DT_WORDBREAK 0x00000010")]
    public const int DT_WORDBREAK = 0x00000010;

    /// <include file='DT.xml' path='doc/member[@name="DT.DT_SINGLELINE"]/*' />
    [NativeTypeName("#define DT_SINGLELINE 0x00000020")]
    public const int DT_SINGLELINE = 0x00000020;

    /// <include file='DT.xml' path='doc/member[@name="DT.DT_EXPANDTABS"]/*' />
    [NativeTypeName("#define DT_EXPANDTABS 0x00000040")]
    public const int DT_EXPANDTABS = 0x00000040;

    /// <include file='DT.xml' path='doc/member[@name="DT.DT_TABSTOP"]/*' />
    [NativeTypeName("#define DT_TABSTOP 0x00000080")]
    public const int DT_TABSTOP = 0x00000080;

    /// <include file='DT.xml' path='doc/member[@name="DT.DT_NOCLIP"]/*' />
    [NativeTypeName("#define DT_NOCLIP 0x00000100")]
    public const int DT_NOCLIP = 0x00000100;

    /// <include file='DT.xml' path='doc/member[@name="DT.DT_EXTERNALLEADING"]/*' />
    [NativeTypeName("#define DT_EXTERNALLEADING 0x00000200")]
    public const int DT_EXTERNALLEADING = 0x00000200;

    /// <include file='DT.xml' path='doc/member[@name="DT.DT_CALCRECT"]/*' />
    [NativeTypeName("#define DT_CALCRECT 0x00000400")]
    public const int DT_CALCRECT = 0x00000400;

    /// <include file='DT.xml' path='doc/member[@name="DT.DT_NOPREFIX"]/*' />
    [NativeTypeName("#define DT_NOPREFIX 0x00000800")]
    public const int DT_NOPREFIX = 0x00000800;

    /// <include file='DT.xml' path='doc/member[@name="DT.DT_INTERNAL"]/*' />
    [NativeTypeName("#define DT_INTERNAL 0x00001000")]
    public const int DT_INTERNAL = 0x00001000;

    /// <include file='DT.xml' path='doc/member[@name="DT.DT_EDITCONTROL"]/*' />
    [NativeTypeName("#define DT_EDITCONTROL 0x00002000")]
    public const int DT_EDITCONTROL = 0x00002000;

    /// <include file='DT.xml' path='doc/member[@name="DT.DT_PATH_ELLIPSIS"]/*' />
    [NativeTypeName("#define DT_PATH_ELLIPSIS 0x00004000")]
    public const int DT_PATH_ELLIPSIS = 0x00004000;

    /// <include file='DT.xml' path='doc/member[@name="DT.DT_END_ELLIPSIS"]/*' />
    [NativeTypeName("#define DT_END_ELLIPSIS 0x00008000")]
    public const int DT_END_ELLIPSIS = 0x00008000;

    /// <include file='DT.xml' path='doc/member[@name="DT.DT_MODIFYSTRING"]/*' />
    [NativeTypeName("#define DT_MODIFYSTRING 0x00010000")]
    public const int DT_MODIFYSTRING = 0x00010000;

    /// <include file='DT.xml' path='doc/member[@name="DT.DT_RTLREADING"]/*' />
    [NativeTypeName("#define DT_RTLREADING 0x00020000")]
    public const int DT_RTLREADING = 0x00020000;

    /// <include file='DT.xml' path='doc/member[@name="DT.DT_WORD_ELLIPSIS"]/*' />
    [NativeTypeName("#define DT_WORD_ELLIPSIS 0x00040000")]
    public const int DT_WORD_ELLIPSIS = 0x00040000;

    /// <include file='DT.xml' path='doc/member[@name="DT.DT_NOFULLWIDTHCHARBREAK"]/*' />
    [NativeTypeName("#define DT_NOFULLWIDTHCHARBREAK 0x00080000")]
    public const int DT_NOFULLWIDTHCHARBREAK = 0x00080000;

    /// <include file='DT.xml' path='doc/member[@name="DT.DT_HIDEPREFIX"]/*' />
    [NativeTypeName("#define DT_HIDEPREFIX 0x00100000")]
    public const int DT_HIDEPREFIX = 0x00100000;

    /// <include file='DT.xml' path='doc/member[@name="DT.DT_PREFIXONLY"]/*' />
    [NativeTypeName("#define DT_PREFIXONLY 0x00200000")]
    public const int DT_PREFIXONLY = 0x00200000;
}
