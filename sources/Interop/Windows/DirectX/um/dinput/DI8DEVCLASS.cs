// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dinput.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

public static partial class DI8DEVCLASS
{
    /// <include file='DI8DEVCLASS.xml' path='doc/member[@name="DI8DEVCLASS.DI8DEVCLASS_ALL"]/*' />
    [NativeTypeName("#define DI8DEVCLASS_ALL 0")]
    public const int DI8DEVCLASS_ALL = 0;

    /// <include file='DI8DEVCLASS.xml' path='doc/member[@name="DI8DEVCLASS.DI8DEVCLASS_DEVICE"]/*' />
    [NativeTypeName("#define DI8DEVCLASS_DEVICE 1")]
    public const int DI8DEVCLASS_DEVICE = 1;

    /// <include file='DI8DEVCLASS.xml' path='doc/member[@name="DI8DEVCLASS.DI8DEVCLASS_POINTER"]/*' />
    [NativeTypeName("#define DI8DEVCLASS_POINTER 2")]
    public const int DI8DEVCLASS_POINTER = 2;

    /// <include file='DI8DEVCLASS.xml' path='doc/member[@name="DI8DEVCLASS.DI8DEVCLASS_KEYBOARD"]/*' />
    [NativeTypeName("#define DI8DEVCLASS_KEYBOARD 3")]
    public const int DI8DEVCLASS_KEYBOARD = 3;

    /// <include file='DI8DEVCLASS.xml' path='doc/member[@name="DI8DEVCLASS.DI8DEVCLASS_GAMECTRL"]/*' />
    [NativeTypeName("#define DI8DEVCLASS_GAMECTRL 4")]
    public const int DI8DEVCLASS_GAMECTRL = 4;
}
