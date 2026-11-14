// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dinput.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

public static partial class DI8DEVTYPEDRIVING
{
    /// <include file='DI8DEVTYPEDRIVING.xml' path='doc/member[@name="DI8DEVTYPEDRIVING.DI8DEVTYPEDRIVING_LIMITED"]/*' />
    [NativeTypeName("#define DI8DEVTYPEDRIVING_LIMITED DI8DEVTYPE_LIMITEDGAMESUBTYPE")]
    public const int DI8DEVTYPEDRIVING_LIMITED = 1;

    /// <include file='DI8DEVTYPEDRIVING.xml' path='doc/member[@name="DI8DEVTYPEDRIVING.DI8DEVTYPEDRIVING_COMBINEDPEDALS"]/*' />
    [NativeTypeName("#define DI8DEVTYPEDRIVING_COMBINEDPEDALS 2")]
    public const int DI8DEVTYPEDRIVING_COMBINEDPEDALS = 2;

    /// <include file='DI8DEVTYPEDRIVING.xml' path='doc/member[@name="DI8DEVTYPEDRIVING.DI8DEVTYPEDRIVING_DUALPEDALS"]/*' />
    [NativeTypeName("#define DI8DEVTYPEDRIVING_DUALPEDALS 3")]
    public const int DI8DEVTYPEDRIVING_DUALPEDALS = 3;

    /// <include file='DI8DEVTYPEDRIVING.xml' path='doc/member[@name="DI8DEVTYPEDRIVING.DI8DEVTYPEDRIVING_THREEPEDALS"]/*' />
    [NativeTypeName("#define DI8DEVTYPEDRIVING_THREEPEDALS 4")]
    public const int DI8DEVTYPEDRIVING_THREEPEDALS = 4;

    /// <include file='DI8DEVTYPEDRIVING.xml' path='doc/member[@name="DI8DEVTYPEDRIVING.DI8DEVTYPEDRIVING_HANDHELD"]/*' />
    [NativeTypeName("#define DI8DEVTYPEDRIVING_HANDHELD 5")]
    public const int DI8DEVTYPEDRIVING_HANDHELD = 5;
}
