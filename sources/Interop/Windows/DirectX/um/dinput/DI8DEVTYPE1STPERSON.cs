// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dinput.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

public static partial class DI8DEVTYPE1STPERSON
{
    /// <include file='DI8DEVTYPE1STPERSON.xml' path='doc/member[@name="DI8DEVTYPE1STPERSON.DI8DEVTYPE1STPERSON_LIMITED"]/*' />
    [NativeTypeName("#define DI8DEVTYPE1STPERSON_LIMITED DI8DEVTYPE_LIMITEDGAMESUBTYPE")]
    public const int DI8DEVTYPE1STPERSON_LIMITED = 1;

    /// <include file='DI8DEVTYPE1STPERSON.xml' path='doc/member[@name="DI8DEVTYPE1STPERSON.DI8DEVTYPE1STPERSON_UNKNOWN"]/*' />
    [NativeTypeName("#define DI8DEVTYPE1STPERSON_UNKNOWN 2")]
    public const int DI8DEVTYPE1STPERSON_UNKNOWN = 2;

    /// <include file='DI8DEVTYPE1STPERSON.xml' path='doc/member[@name="DI8DEVTYPE1STPERSON.DI8DEVTYPE1STPERSON_SIXDOF"]/*' />
    [NativeTypeName("#define DI8DEVTYPE1STPERSON_SIXDOF 3")]
    public const int DI8DEVTYPE1STPERSON_SIXDOF = 3;

    /// <include file='DI8DEVTYPE1STPERSON.xml' path='doc/member[@name="DI8DEVTYPE1STPERSON.DI8DEVTYPE1STPERSON_SHOOTER"]/*' />
    [NativeTypeName("#define DI8DEVTYPE1STPERSON_SHOOTER 4")]
    public const int DI8DEVTYPE1STPERSON_SHOOTER = 4;
}
