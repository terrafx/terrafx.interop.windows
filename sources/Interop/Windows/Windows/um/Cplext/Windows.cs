// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/Cplext.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class Windows
{
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CPLPAGE_MOUSE_BUTTONS"]/*' />
    [NativeTypeName("#define CPLPAGE_MOUSE_BUTTONS 1")]
    public const int CPLPAGE_MOUSE_BUTTONS = 1;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CPLPAGE_MOUSE_PTRMOTION"]/*' />
    [NativeTypeName("#define CPLPAGE_MOUSE_PTRMOTION 2")]
    public const int CPLPAGE_MOUSE_PTRMOTION = 2;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CPLPAGE_MOUSE_WHEEL"]/*' />
    [NativeTypeName("#define CPLPAGE_MOUSE_WHEEL 3")]
    public const int CPLPAGE_MOUSE_WHEEL = 3;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CPLPAGE_KEYBOARD_SPEED"]/*' />
    [NativeTypeName("#define CPLPAGE_KEYBOARD_SPEED 1")]
    public const int CPLPAGE_KEYBOARD_SPEED = 1;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CPLPAGE_DISPLAY_BACKGROUND"]/*' />
    [NativeTypeName("#define CPLPAGE_DISPLAY_BACKGROUND 1")]
    public const int CPLPAGE_DISPLAY_BACKGROUND = 1;
}
