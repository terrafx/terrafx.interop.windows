// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dinput.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

public static partial class DI8DEVTYPE
{
    /// <include file='DI8DEVTYPE.xml' path='doc/member[@name="DI8DEVTYPE.DI8DEVTYPE_DEVICE"]/*' />
    [NativeTypeName("#define DI8DEVTYPE_DEVICE 0x11")]
    public const int DI8DEVTYPE_DEVICE = 0x11;

    /// <include file='DI8DEVTYPE.xml' path='doc/member[@name="DI8DEVTYPE.DI8DEVTYPE_MOUSE"]/*' />
    [NativeTypeName("#define DI8DEVTYPE_MOUSE 0x12")]
    public const int DI8DEVTYPE_MOUSE = 0x12;

    /// <include file='DI8DEVTYPE.xml' path='doc/member[@name="DI8DEVTYPE.DI8DEVTYPE_KEYBOARD"]/*' />
    [NativeTypeName("#define DI8DEVTYPE_KEYBOARD 0x13")]
    public const int DI8DEVTYPE_KEYBOARD = 0x13;

    /// <include file='DI8DEVTYPE.xml' path='doc/member[@name="DI8DEVTYPE.DI8DEVTYPE_JOYSTICK"]/*' />
    [NativeTypeName("#define DI8DEVTYPE_JOYSTICK 0x14")]
    public const int DI8DEVTYPE_JOYSTICK = 0x14;

    /// <include file='DI8DEVTYPE.xml' path='doc/member[@name="DI8DEVTYPE.DI8DEVTYPE_GAMEPAD"]/*' />
    [NativeTypeName("#define DI8DEVTYPE_GAMEPAD 0x15")]
    public const int DI8DEVTYPE_GAMEPAD = 0x15;

    /// <include file='DI8DEVTYPE.xml' path='doc/member[@name="DI8DEVTYPE.DI8DEVTYPE_DRIVING"]/*' />
    [NativeTypeName("#define DI8DEVTYPE_DRIVING 0x16")]
    public const int DI8DEVTYPE_DRIVING = 0x16;

    /// <include file='DI8DEVTYPE.xml' path='doc/member[@name="DI8DEVTYPE.DI8DEVTYPE_FLIGHT"]/*' />
    [NativeTypeName("#define DI8DEVTYPE_FLIGHT 0x17")]
    public const int DI8DEVTYPE_FLIGHT = 0x17;

    /// <include file='DI8DEVTYPE.xml' path='doc/member[@name="DI8DEVTYPE.DI8DEVTYPE_1STPERSON"]/*' />
    [NativeTypeName("#define DI8DEVTYPE_1STPERSON 0x18")]
    public const int DI8DEVTYPE_1STPERSON = 0x18;

    /// <include file='DI8DEVTYPE.xml' path='doc/member[@name="DI8DEVTYPE.DI8DEVTYPE_DEVICECTRL"]/*' />
    [NativeTypeName("#define DI8DEVTYPE_DEVICECTRL 0x19")]
    public const int DI8DEVTYPE_DEVICECTRL = 0x19;

    /// <include file='DI8DEVTYPE.xml' path='doc/member[@name="DI8DEVTYPE.DI8DEVTYPE_SCREENPOINTER"]/*' />
    [NativeTypeName("#define DI8DEVTYPE_SCREENPOINTER 0x1A")]
    public const int DI8DEVTYPE_SCREENPOINTER = 0x1A;

    /// <include file='DI8DEVTYPE.xml' path='doc/member[@name="DI8DEVTYPE.DI8DEVTYPE_REMOTE"]/*' />
    [NativeTypeName("#define DI8DEVTYPE_REMOTE 0x1B")]
    public const int DI8DEVTYPE_REMOTE = 0x1B;

    /// <include file='DI8DEVTYPE.xml' path='doc/member[@name="DI8DEVTYPE.DI8DEVTYPE_SUPPLEMENTAL"]/*' />
    [NativeTypeName("#define DI8DEVTYPE_SUPPLEMENTAL 0x1C")]
    public const int DI8DEVTYPE_SUPPLEMENTAL = 0x1C;

    /// <include file='DI8DEVTYPE.xml' path='doc/member[@name="DI8DEVTYPE.DI8DEVTYPE_LIMITEDGAMESUBTYPE"]/*' />
    [NativeTypeName("#define DI8DEVTYPE_LIMITEDGAMESUBTYPE 1")]
    public const int DI8DEVTYPE_LIMITEDGAMESUBTYPE = 1;
}
