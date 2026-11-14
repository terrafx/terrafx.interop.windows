// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/consoleapi3.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class CONSOLE
{
    /// <include file='CONSOLE.xml' path='doc/member[@name="CONSOLE.CONSOLE_NO_SELECTION"]/*' />
    [NativeTypeName("#define CONSOLE_NO_SELECTION 0x0000")]
    public const int CONSOLE_NO_SELECTION = 0x0000;

    /// <include file='CONSOLE.xml' path='doc/member[@name="CONSOLE.CONSOLE_SELECTION_IN_PROGRESS"]/*' />
    [NativeTypeName("#define CONSOLE_SELECTION_IN_PROGRESS 0x0001")]
    public const int CONSOLE_SELECTION_IN_PROGRESS = 0x0001;

    /// <include file='CONSOLE.xml' path='doc/member[@name="CONSOLE.CONSOLE_SELECTION_NOT_EMPTY"]/*' />
    [NativeTypeName("#define CONSOLE_SELECTION_NOT_EMPTY 0x0002")]
    public const int CONSOLE_SELECTION_NOT_EMPTY = 0x0002;

    /// <include file='CONSOLE.xml' path='doc/member[@name="CONSOLE.CONSOLE_MOUSE_SELECTION"]/*' />
    [NativeTypeName("#define CONSOLE_MOUSE_SELECTION 0x0004")]
    public const int CONSOLE_MOUSE_SELECTION = 0x0004;

    /// <include file='CONSOLE.xml' path='doc/member[@name="CONSOLE.CONSOLE_MOUSE_DOWN"]/*' />
    [NativeTypeName("#define CONSOLE_MOUSE_DOWN 0x0008")]
    public const int CONSOLE_MOUSE_DOWN = 0x0008;

    /// <include file='CONSOLE.xml' path='doc/member[@name="CONSOLE.CONSOLE_FULLSCREEN"]/*' />
    [NativeTypeName("#define CONSOLE_FULLSCREEN 1")]
    public const int CONSOLE_FULLSCREEN = 1;

    /// <include file='CONSOLE.xml' path='doc/member[@name="CONSOLE.CONSOLE_FULLSCREEN_HARDWARE"]/*' />
    [NativeTypeName("#define CONSOLE_FULLSCREEN_HARDWARE 2")]
    public const int CONSOLE_FULLSCREEN_HARDWARE = 2;

    /// <include file='CONSOLE.xml' path='doc/member[@name="CONSOLE.CONSOLE_FULLSCREEN_MODE"]/*' />
    [NativeTypeName("#define CONSOLE_FULLSCREEN_MODE 1")]
    public const int CONSOLE_FULLSCREEN_MODE = 1;

    /// <include file='CONSOLE.xml' path='doc/member[@name="CONSOLE.CONSOLE_WINDOWED_MODE"]/*' />
    [NativeTypeName("#define CONSOLE_WINDOWED_MODE 2")]
    public const int CONSOLE_WINDOWED_MODE = 2;
}
