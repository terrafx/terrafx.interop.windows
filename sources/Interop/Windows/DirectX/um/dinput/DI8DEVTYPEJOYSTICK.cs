// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dinput.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

public static partial class DI8DEVTYPEJOYSTICK
{
    /// <include file='DI8DEVTYPEJOYSTICK.xml' path='doc/member[@name="DI8DEVTYPEJOYSTICK.DI8DEVTYPEJOYSTICK_LIMITED"]/*' />
    [NativeTypeName("#define DI8DEVTYPEJOYSTICK_LIMITED DI8DEVTYPE_LIMITEDGAMESUBTYPE")]
    public const int DI8DEVTYPEJOYSTICK_LIMITED = 1;

    /// <include file='DI8DEVTYPEJOYSTICK.xml' path='doc/member[@name="DI8DEVTYPEJOYSTICK.DI8DEVTYPEJOYSTICK_STANDARD"]/*' />
    [NativeTypeName("#define DI8DEVTYPEJOYSTICK_STANDARD 2")]
    public const int DI8DEVTYPEJOYSTICK_STANDARD = 2;
}
