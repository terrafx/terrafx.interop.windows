// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dinput.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

public static partial class DI8DEVTYPEMOUSE
{
    /// <include file='DI8DEVTYPEMOUSE.xml' path='doc/member[@name="DI8DEVTYPEMOUSE.DI8DEVTYPEMOUSE_UNKNOWN"]/*' />
    [NativeTypeName("#define DI8DEVTYPEMOUSE_UNKNOWN 1")]
    public const int DI8DEVTYPEMOUSE_UNKNOWN = 1;

    /// <include file='DI8DEVTYPEMOUSE.xml' path='doc/member[@name="DI8DEVTYPEMOUSE.DI8DEVTYPEMOUSE_TRADITIONAL"]/*' />
    [NativeTypeName("#define DI8DEVTYPEMOUSE_TRADITIONAL 2")]
    public const int DI8DEVTYPEMOUSE_TRADITIONAL = 2;

    /// <include file='DI8DEVTYPEMOUSE.xml' path='doc/member[@name="DI8DEVTYPEMOUSE.DI8DEVTYPEMOUSE_FINGERSTICK"]/*' />
    [NativeTypeName("#define DI8DEVTYPEMOUSE_FINGERSTICK 3")]
    public const int DI8DEVTYPEMOUSE_FINGERSTICK = 3;

    /// <include file='DI8DEVTYPEMOUSE.xml' path='doc/member[@name="DI8DEVTYPEMOUSE.DI8DEVTYPEMOUSE_TOUCHPAD"]/*' />
    [NativeTypeName("#define DI8DEVTYPEMOUSE_TOUCHPAD 4")]
    public const int DI8DEVTYPEMOUSE_TOUCHPAD = 4;

    /// <include file='DI8DEVTYPEMOUSE.xml' path='doc/member[@name="DI8DEVTYPEMOUSE.DI8DEVTYPEMOUSE_TRACKBALL"]/*' />
    [NativeTypeName("#define DI8DEVTYPEMOUSE_TRACKBALL 5")]
    public const int DI8DEVTYPEMOUSE_TRACKBALL = 5;

    /// <include file='DI8DEVTYPEMOUSE.xml' path='doc/member[@name="DI8DEVTYPEMOUSE.DI8DEVTYPEMOUSE_ABSOLUTE"]/*' />
    [NativeTypeName("#define DI8DEVTYPEMOUSE_ABSOLUTE 6")]
    public const int DI8DEVTYPEMOUSE_ABSOLUTE = 6;
}
