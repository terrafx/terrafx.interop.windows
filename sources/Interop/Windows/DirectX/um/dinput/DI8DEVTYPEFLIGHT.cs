// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dinput.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

public static partial class DI8DEVTYPEFLIGHT
{
    /// <include file='DI8DEVTYPEFLIGHT.xml' path='doc/member[@name="DI8DEVTYPEFLIGHT.DI8DEVTYPEFLIGHT_LIMITED"]/*' />
    [NativeTypeName("#define DI8DEVTYPEFLIGHT_LIMITED DI8DEVTYPE_LIMITEDGAMESUBTYPE")]
    public const int DI8DEVTYPEFLIGHT_LIMITED = 1;

    /// <include file='DI8DEVTYPEFLIGHT.xml' path='doc/member[@name="DI8DEVTYPEFLIGHT.DI8DEVTYPEFLIGHT_STICK"]/*' />
    [NativeTypeName("#define DI8DEVTYPEFLIGHT_STICK 2")]
    public const int DI8DEVTYPEFLIGHT_STICK = 2;

    /// <include file='DI8DEVTYPEFLIGHT.xml' path='doc/member[@name="DI8DEVTYPEFLIGHT.DI8DEVTYPEFLIGHT_YOKE"]/*' />
    [NativeTypeName("#define DI8DEVTYPEFLIGHT_YOKE 3")]
    public const int DI8DEVTYPEFLIGHT_YOKE = 3;

    /// <include file='DI8DEVTYPEFLIGHT.xml' path='doc/member[@name="DI8DEVTYPEFLIGHT.DI8DEVTYPEFLIGHT_RC"]/*' />
    [NativeTypeName("#define DI8DEVTYPEFLIGHT_RC 4")]
    public const int DI8DEVTYPEFLIGHT_RC = 4;
}
