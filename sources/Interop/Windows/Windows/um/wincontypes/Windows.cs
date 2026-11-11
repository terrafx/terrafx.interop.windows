// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincontypes.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class Windows
{
    /// <include file='Windows.xml' path='doc/member[@name="Windows.RIGHT_ALT_PRESSED"]/*' />
    [NativeTypeName("#define RIGHT_ALT_PRESSED 0x0001")]
    public const int RIGHT_ALT_PRESSED = 0x0001;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LEFT_ALT_PRESSED"]/*' />
    [NativeTypeName("#define LEFT_ALT_PRESSED 0x0002")]
    public const int LEFT_ALT_PRESSED = 0x0002;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RIGHT_CTRL_PRESSED"]/*' />
    [NativeTypeName("#define RIGHT_CTRL_PRESSED 0x0004")]
    public const int RIGHT_CTRL_PRESSED = 0x0004;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LEFT_CTRL_PRESSED"]/*' />
    [NativeTypeName("#define LEFT_CTRL_PRESSED 0x0008")]
    public const int LEFT_CTRL_PRESSED = 0x0008;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHIFT_PRESSED"]/*' />
    [NativeTypeName("#define SHIFT_PRESSED 0x0010")]
    public const int SHIFT_PRESSED = 0x0010;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.NUMLOCK_ON"]/*' />
    [NativeTypeName("#define NUMLOCK_ON 0x0020")]
    public const int NUMLOCK_ON = 0x0020;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SCROLLLOCK_ON"]/*' />
    [NativeTypeName("#define SCROLLLOCK_ON 0x0040")]
    public const int SCROLLLOCK_ON = 0x0040;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CAPSLOCK_ON"]/*' />
    [NativeTypeName("#define CAPSLOCK_ON 0x0080")]
    public const int CAPSLOCK_ON = 0x0080;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ENHANCED_KEY"]/*' />
    [NativeTypeName("#define ENHANCED_KEY 0x0100")]
    public const int ENHANCED_KEY = 0x0100;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.NLS_DBCSCHAR"]/*' />
    [NativeTypeName("#define NLS_DBCSCHAR 0x00010000")]
    public const int NLS_DBCSCHAR = 0x00010000;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.NLS_ALPHANUMERIC"]/*' />
    [NativeTypeName("#define NLS_ALPHANUMERIC 0x00000000")]
    public const int NLS_ALPHANUMERIC = 0x00000000;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.NLS_KATAKANA"]/*' />
    [NativeTypeName("#define NLS_KATAKANA 0x00020000")]
    public const int NLS_KATAKANA = 0x00020000;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.NLS_HIRAGANA"]/*' />
    [NativeTypeName("#define NLS_HIRAGANA 0x00040000")]
    public const int NLS_HIRAGANA = 0x00040000;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.NLS_ROMAN"]/*' />
    [NativeTypeName("#define NLS_ROMAN 0x00400000")]
    public const int NLS_ROMAN = 0x00400000;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.NLS_IME_CONVERSION"]/*' />
    [NativeTypeName("#define NLS_IME_CONVERSION 0x00800000")]
    public const int NLS_IME_CONVERSION = 0x00800000;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ALTNUMPAD_BIT"]/*' />
    [NativeTypeName("#define ALTNUMPAD_BIT 0x04000000")]
    public const int ALTNUMPAD_BIT = 0x04000000;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.NLS_IME_DISABLE"]/*' />
    [NativeTypeName("#define NLS_IME_DISABLE 0x20000000")]
    public const int NLS_IME_DISABLE = 0x20000000;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.FROM_LEFT_1ST_BUTTON_PRESSED"]/*' />
    [NativeTypeName("#define FROM_LEFT_1ST_BUTTON_PRESSED 0x0001")]
    public const int FROM_LEFT_1ST_BUTTON_PRESSED = 0x0001;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RIGHTMOST_BUTTON_PRESSED"]/*' />
    [NativeTypeName("#define RIGHTMOST_BUTTON_PRESSED 0x0002")]
    public const int RIGHTMOST_BUTTON_PRESSED = 0x0002;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.FROM_LEFT_2ND_BUTTON_PRESSED"]/*' />
    [NativeTypeName("#define FROM_LEFT_2ND_BUTTON_PRESSED 0x0004")]
    public const int FROM_LEFT_2ND_BUTTON_PRESSED = 0x0004;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.FROM_LEFT_3RD_BUTTON_PRESSED"]/*' />
    [NativeTypeName("#define FROM_LEFT_3RD_BUTTON_PRESSED 0x0008")]
    public const int FROM_LEFT_3RD_BUTTON_PRESSED = 0x0008;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.FROM_LEFT_4TH_BUTTON_PRESSED"]/*' />
    [NativeTypeName("#define FROM_LEFT_4TH_BUTTON_PRESSED 0x0010")]
    public const int FROM_LEFT_4TH_BUTTON_PRESSED = 0x0010;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.MOUSE_MOVED"]/*' />
    [NativeTypeName("#define MOUSE_MOVED 0x0001")]
    public const int MOUSE_MOVED = 0x0001;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DOUBLE_CLICK"]/*' />
    [NativeTypeName("#define DOUBLE_CLICK 0x0002")]
    public const int DOUBLE_CLICK = 0x0002;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.MOUSE_WHEELED"]/*' />
    [NativeTypeName("#define MOUSE_WHEELED 0x0004")]
    public const int MOUSE_WHEELED = 0x0004;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.MOUSE_HWHEELED"]/*' />
    [NativeTypeName("#define MOUSE_HWHEELED 0x0008")]
    public const int MOUSE_HWHEELED = 0x0008;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.MOUSE_EVENT"]/*' />
    [NativeTypeName("#define MOUSE_EVENT 0x0002")]
    public const int MOUSE_EVENT = 0x0002;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WINDOW_BUFFER_SIZE_EVENT"]/*' />
    [NativeTypeName("#define WINDOW_BUFFER_SIZE_EVENT 0x0004")]
    public const int WINDOW_BUFFER_SIZE_EVENT = 0x0004;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.MENU_EVENT"]/*' />
    [NativeTypeName("#define MENU_EVENT 0x0008")]
    public const int MENU_EVENT = 0x0008;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.FOCUS_EVENT"]/*' />
    [NativeTypeName("#define FOCUS_EVENT 0x0010")]
    public const int FOCUS_EVENT = 0x0010;
}
