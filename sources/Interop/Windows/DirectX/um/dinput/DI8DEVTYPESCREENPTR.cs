// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dinput.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

public static partial class DI8DEVTYPESCREENPTR
{
    /// <include file='DI8DEVTYPESCREENPTR.xml' path='doc/member[@name="DI8DEVTYPESCREENPTR.DI8DEVTYPESCREENPTR_UNKNOWN"]/*' />
    [NativeTypeName("#define DI8DEVTYPESCREENPTR_UNKNOWN 2")]
    public const int DI8DEVTYPESCREENPTR_UNKNOWN = 2;

    /// <include file='DI8DEVTYPESCREENPTR.xml' path='doc/member[@name="DI8DEVTYPESCREENPTR.DI8DEVTYPESCREENPTR_LIGHTGUN"]/*' />
    [NativeTypeName("#define DI8DEVTYPESCREENPTR_LIGHTGUN 3")]
    public const int DI8DEVTYPESCREENPTR_LIGHTGUN = 3;

    /// <include file='DI8DEVTYPESCREENPTR.xml' path='doc/member[@name="DI8DEVTYPESCREENPTR.DI8DEVTYPESCREENPTR_LIGHTPEN"]/*' />
    [NativeTypeName("#define DI8DEVTYPESCREENPTR_LIGHTPEN 4")]
    public const int DI8DEVTYPESCREENPTR_LIGHTPEN = 4;

    /// <include file='DI8DEVTYPESCREENPTR.xml' path='doc/member[@name="DI8DEVTYPESCREENPTR.DI8DEVTYPESCREENPTR_TOUCH"]/*' />
    [NativeTypeName("#define DI8DEVTYPESCREENPTR_TOUCH 5")]
    public const int DI8DEVTYPESCREENPTR_TOUCH = 5;
}
