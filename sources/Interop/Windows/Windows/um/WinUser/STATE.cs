// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class STATE
{
    /// <include file='STATE.xml' path='doc/member[@name="STATE.STATE_SYSTEM_UNAVAILABLE"]/*' />
    [NativeTypeName("#define STATE_SYSTEM_UNAVAILABLE 0x00000001")]
    public const int STATE_SYSTEM_UNAVAILABLE = 0x00000001;

    /// <include file='STATE.xml' path='doc/member[@name="STATE.STATE_SYSTEM_SELECTED"]/*' />
    [NativeTypeName("#define STATE_SYSTEM_SELECTED 0x00000002")]
    public const int STATE_SYSTEM_SELECTED = 0x00000002;

    /// <include file='STATE.xml' path='doc/member[@name="STATE.STATE_SYSTEM_FOCUSED"]/*' />
    [NativeTypeName("#define STATE_SYSTEM_FOCUSED 0x00000004")]
    public const int STATE_SYSTEM_FOCUSED = 0x00000004;

    /// <include file='STATE.xml' path='doc/member[@name="STATE.STATE_SYSTEM_PRESSED"]/*' />
    [NativeTypeName("#define STATE_SYSTEM_PRESSED 0x00000008")]
    public const int STATE_SYSTEM_PRESSED = 0x00000008;

    /// <include file='STATE.xml' path='doc/member[@name="STATE.STATE_SYSTEM_CHECKED"]/*' />
    [NativeTypeName("#define STATE_SYSTEM_CHECKED 0x00000010")]
    public const int STATE_SYSTEM_CHECKED = 0x00000010;

    /// <include file='STATE.xml' path='doc/member[@name="STATE.STATE_SYSTEM_MIXED"]/*' />
    [NativeTypeName("#define STATE_SYSTEM_MIXED 0x00000020")]
    public const int STATE_SYSTEM_MIXED = 0x00000020;

    /// <include file='STATE.xml' path='doc/member[@name="STATE.STATE_SYSTEM_INDETERMINATE"]/*' />
    [NativeTypeName("#define STATE_SYSTEM_INDETERMINATE STATE_SYSTEM_MIXED")]
    public const int STATE_SYSTEM_INDETERMINATE = 0x00000020;

    /// <include file='STATE.xml' path='doc/member[@name="STATE.STATE_SYSTEM_READONLY"]/*' />
    [NativeTypeName("#define STATE_SYSTEM_READONLY 0x00000040")]
    public const int STATE_SYSTEM_READONLY = 0x00000040;

    /// <include file='STATE.xml' path='doc/member[@name="STATE.STATE_SYSTEM_HOTTRACKED"]/*' />
    [NativeTypeName("#define STATE_SYSTEM_HOTTRACKED 0x00000080")]
    public const int STATE_SYSTEM_HOTTRACKED = 0x00000080;

    /// <include file='STATE.xml' path='doc/member[@name="STATE.STATE_SYSTEM_DEFAULT"]/*' />
    [NativeTypeName("#define STATE_SYSTEM_DEFAULT 0x00000100")]
    public const int STATE_SYSTEM_DEFAULT = 0x00000100;

    /// <include file='STATE.xml' path='doc/member[@name="STATE.STATE_SYSTEM_EXPANDED"]/*' />
    [NativeTypeName("#define STATE_SYSTEM_EXPANDED 0x00000200")]
    public const int STATE_SYSTEM_EXPANDED = 0x00000200;

    /// <include file='STATE.xml' path='doc/member[@name="STATE.STATE_SYSTEM_COLLAPSED"]/*' />
    [NativeTypeName("#define STATE_SYSTEM_COLLAPSED 0x00000400")]
    public const int STATE_SYSTEM_COLLAPSED = 0x00000400;

    /// <include file='STATE.xml' path='doc/member[@name="STATE.STATE_SYSTEM_BUSY"]/*' />
    [NativeTypeName("#define STATE_SYSTEM_BUSY 0x00000800")]
    public const int STATE_SYSTEM_BUSY = 0x00000800;

    /// <include file='STATE.xml' path='doc/member[@name="STATE.STATE_SYSTEM_FLOATING"]/*' />
    [NativeTypeName("#define STATE_SYSTEM_FLOATING 0x00001000")]
    public const int STATE_SYSTEM_FLOATING = 0x00001000;

    /// <include file='STATE.xml' path='doc/member[@name="STATE.STATE_SYSTEM_MARQUEED"]/*' />
    [NativeTypeName("#define STATE_SYSTEM_MARQUEED 0x00002000")]
    public const int STATE_SYSTEM_MARQUEED = 0x00002000;

    /// <include file='STATE.xml' path='doc/member[@name="STATE.STATE_SYSTEM_ANIMATED"]/*' />
    [NativeTypeName("#define STATE_SYSTEM_ANIMATED 0x00004000")]
    public const int STATE_SYSTEM_ANIMATED = 0x00004000;

    /// <include file='STATE.xml' path='doc/member[@name="STATE.STATE_SYSTEM_INVISIBLE"]/*' />
    [NativeTypeName("#define STATE_SYSTEM_INVISIBLE 0x00008000")]
    public const int STATE_SYSTEM_INVISIBLE = 0x00008000;

    /// <include file='STATE.xml' path='doc/member[@name="STATE.STATE_SYSTEM_OFFSCREEN"]/*' />
    [NativeTypeName("#define STATE_SYSTEM_OFFSCREEN 0x00010000")]
    public const int STATE_SYSTEM_OFFSCREEN = 0x00010000;

    /// <include file='STATE.xml' path='doc/member[@name="STATE.STATE_SYSTEM_SIZEABLE"]/*' />
    [NativeTypeName("#define STATE_SYSTEM_SIZEABLE 0x00020000")]
    public const int STATE_SYSTEM_SIZEABLE = 0x00020000;

    /// <include file='STATE.xml' path='doc/member[@name="STATE.STATE_SYSTEM_MOVEABLE"]/*' />
    [NativeTypeName("#define STATE_SYSTEM_MOVEABLE 0x00040000")]
    public const int STATE_SYSTEM_MOVEABLE = 0x00040000;

    /// <include file='STATE.xml' path='doc/member[@name="STATE.STATE_SYSTEM_SELFVOICING"]/*' />
    [NativeTypeName("#define STATE_SYSTEM_SELFVOICING 0x00080000")]
    public const int STATE_SYSTEM_SELFVOICING = 0x00080000;

    /// <include file='STATE.xml' path='doc/member[@name="STATE.STATE_SYSTEM_FOCUSABLE"]/*' />
    [NativeTypeName("#define STATE_SYSTEM_FOCUSABLE 0x00100000")]
    public const int STATE_SYSTEM_FOCUSABLE = 0x00100000;

    /// <include file='STATE.xml' path='doc/member[@name="STATE.STATE_SYSTEM_SELECTABLE"]/*' />
    [NativeTypeName("#define STATE_SYSTEM_SELECTABLE 0x00200000")]
    public const int STATE_SYSTEM_SELECTABLE = 0x00200000;

    /// <include file='STATE.xml' path='doc/member[@name="STATE.STATE_SYSTEM_LINKED"]/*' />
    [NativeTypeName("#define STATE_SYSTEM_LINKED 0x00400000")]
    public const int STATE_SYSTEM_LINKED = 0x00400000;

    /// <include file='STATE.xml' path='doc/member[@name="STATE.STATE_SYSTEM_TRAVERSED"]/*' />
    [NativeTypeName("#define STATE_SYSTEM_TRAVERSED 0x00800000")]
    public const int STATE_SYSTEM_TRAVERSED = 0x00800000;

    /// <include file='STATE.xml' path='doc/member[@name="STATE.STATE_SYSTEM_MULTISELECTABLE"]/*' />
    [NativeTypeName("#define STATE_SYSTEM_MULTISELECTABLE 0x01000000")]
    public const int STATE_SYSTEM_MULTISELECTABLE = 0x01000000;

    /// <include file='STATE.xml' path='doc/member[@name="STATE.STATE_SYSTEM_EXTSELECTABLE"]/*' />
    [NativeTypeName("#define STATE_SYSTEM_EXTSELECTABLE 0x02000000")]
    public const int STATE_SYSTEM_EXTSELECTABLE = 0x02000000;

    /// <include file='STATE.xml' path='doc/member[@name="STATE.STATE_SYSTEM_ALERT_LOW"]/*' />
    [NativeTypeName("#define STATE_SYSTEM_ALERT_LOW 0x04000000")]
    public const int STATE_SYSTEM_ALERT_LOW = 0x04000000;

    /// <include file='STATE.xml' path='doc/member[@name="STATE.STATE_SYSTEM_ALERT_MEDIUM"]/*' />
    [NativeTypeName("#define STATE_SYSTEM_ALERT_MEDIUM 0x08000000")]
    public const int STATE_SYSTEM_ALERT_MEDIUM = 0x08000000;

    /// <include file='STATE.xml' path='doc/member[@name="STATE.STATE_SYSTEM_ALERT_HIGH"]/*' />
    [NativeTypeName("#define STATE_SYSTEM_ALERT_HIGH 0x10000000")]
    public const int STATE_SYSTEM_ALERT_HIGH = 0x10000000;

    /// <include file='STATE.xml' path='doc/member[@name="STATE.STATE_SYSTEM_PROTECTED"]/*' />
    [NativeTypeName("#define STATE_SYSTEM_PROTECTED 0x20000000")]
    public const int STATE_SYSTEM_PROTECTED = 0x20000000;

    /// <include file='STATE.xml' path='doc/member[@name="STATE.STATE_SYSTEM_VALID"]/*' />
    [NativeTypeName("#define STATE_SYSTEM_VALID 0x3FFFFFFF")]
    public const int STATE_SYSTEM_VALID = 0x3FFFFFFF;
}
