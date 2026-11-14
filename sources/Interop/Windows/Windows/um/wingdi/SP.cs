// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class SP
{
    /// <include file='SP.xml' path='doc/member[@name="SP.SP_NOTREPORTED"]/*' />
    [NativeTypeName("#define SP_NOTREPORTED 0x4000")]
    public const int SP_NOTREPORTED = 0x4000;

    /// <include file='SP.xml' path='doc/member[@name="SP.SP_ERROR"]/*' />
    [NativeTypeName("#define SP_ERROR (-1)")]
    public const int SP_ERROR = (-1);

    /// <include file='SP.xml' path='doc/member[@name="SP.SP_APPABORT"]/*' />
    [NativeTypeName("#define SP_APPABORT (-2)")]
    public const int SP_APPABORT = (-2);

    /// <include file='SP.xml' path='doc/member[@name="SP.SP_USERABORT"]/*' />
    [NativeTypeName("#define SP_USERABORT (-3)")]
    public const int SP_USERABORT = (-3);

    /// <include file='SP.xml' path='doc/member[@name="SP.SP_OUTOFDISK"]/*' />
    [NativeTypeName("#define SP_OUTOFDISK (-4)")]
    public const int SP_OUTOFDISK = (-4);

    /// <include file='SP.xml' path='doc/member[@name="SP.SP_OUTOFMEMORY"]/*' />
    [NativeTypeName("#define SP_OUTOFMEMORY (-5)")]
    public const int SP_OUTOFMEMORY = (-5);
}
