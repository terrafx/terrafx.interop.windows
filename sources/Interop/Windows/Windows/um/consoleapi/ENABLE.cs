// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/consoleapi.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class ENABLE
{
    /// <include file='ENABLE.xml' path='doc/member[@name="ENABLE.ENABLE_PROCESSED_INPUT"]/*' />
    [NativeTypeName("#define ENABLE_PROCESSED_INPUT 0x0001")]
    public const int ENABLE_PROCESSED_INPUT = 0x0001;

    /// <include file='ENABLE.xml' path='doc/member[@name="ENABLE.ENABLE_LINE_INPUT"]/*' />
    [NativeTypeName("#define ENABLE_LINE_INPUT 0x0002")]
    public const int ENABLE_LINE_INPUT = 0x0002;

    /// <include file='ENABLE.xml' path='doc/member[@name="ENABLE.ENABLE_ECHO_INPUT"]/*' />
    [NativeTypeName("#define ENABLE_ECHO_INPUT 0x0004")]
    public const int ENABLE_ECHO_INPUT = 0x0004;

    /// <include file='ENABLE.xml' path='doc/member[@name="ENABLE.ENABLE_WINDOW_INPUT"]/*' />
    [NativeTypeName("#define ENABLE_WINDOW_INPUT 0x0008")]
    public const int ENABLE_WINDOW_INPUT = 0x0008;

    /// <include file='ENABLE.xml' path='doc/member[@name="ENABLE.ENABLE_MOUSE_INPUT"]/*' />
    [NativeTypeName("#define ENABLE_MOUSE_INPUT 0x0010")]
    public const int ENABLE_MOUSE_INPUT = 0x0010;

    /// <include file='ENABLE.xml' path='doc/member[@name="ENABLE.ENABLE_INSERT_MODE"]/*' />
    [NativeTypeName("#define ENABLE_INSERT_MODE 0x0020")]
    public const int ENABLE_INSERT_MODE = 0x0020;

    /// <include file='ENABLE.xml' path='doc/member[@name="ENABLE.ENABLE_QUICK_EDIT_MODE"]/*' />
    [NativeTypeName("#define ENABLE_QUICK_EDIT_MODE 0x0040")]
    public const int ENABLE_QUICK_EDIT_MODE = 0x0040;

    /// <include file='ENABLE.xml' path='doc/member[@name="ENABLE.ENABLE_EXTENDED_FLAGS"]/*' />
    [NativeTypeName("#define ENABLE_EXTENDED_FLAGS 0x0080")]
    public const int ENABLE_EXTENDED_FLAGS = 0x0080;

    /// <include file='ENABLE.xml' path='doc/member[@name="ENABLE.ENABLE_AUTO_POSITION"]/*' />
    [NativeTypeName("#define ENABLE_AUTO_POSITION 0x0100")]
    public const int ENABLE_AUTO_POSITION = 0x0100;

    /// <include file='ENABLE.xml' path='doc/member[@name="ENABLE.ENABLE_VIRTUAL_TERMINAL_INPUT"]/*' />
    [NativeTypeName("#define ENABLE_VIRTUAL_TERMINAL_INPUT 0x0200")]
    public const int ENABLE_VIRTUAL_TERMINAL_INPUT = 0x0200;

    /// <include file='ENABLE.xml' path='doc/member[@name="ENABLE.ENABLE_PROCESSED_OUTPUT"]/*' />
    [NativeTypeName("#define ENABLE_PROCESSED_OUTPUT 0x0001")]
    public const int ENABLE_PROCESSED_OUTPUT = 0x0001;

    /// <include file='ENABLE.xml' path='doc/member[@name="ENABLE.ENABLE_WRAP_AT_EOL_OUTPUT"]/*' />
    [NativeTypeName("#define ENABLE_WRAP_AT_EOL_OUTPUT 0x0002")]
    public const int ENABLE_WRAP_AT_EOL_OUTPUT = 0x0002;

    /// <include file='ENABLE.xml' path='doc/member[@name="ENABLE.ENABLE_VIRTUAL_TERMINAL_PROCESSING"]/*' />
    [NativeTypeName("#define ENABLE_VIRTUAL_TERMINAL_PROCESSING 0x0004")]
    public const int ENABLE_VIRTUAL_TERMINAL_PROCESSING = 0x0004;

    /// <include file='ENABLE.xml' path='doc/member[@name="ENABLE.ENABLE_LVB_GRID_WORLDWIDE"]/*' />
    [NativeTypeName("#define ENABLE_LVB_GRID_WORLDWIDE 0x0010")]
    public const int ENABLE_LVB_GRID_WORLDWIDE = 0x0010;
}
