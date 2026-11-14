// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class IEIFLAG
{
    /// <include file='IEIFLAG.xml' path='doc/member[@name="IEIFLAG.IEIFLAG_ASYNC"]/*' />
    [NativeTypeName("#define IEIFLAG_ASYNC 0x0001")]
    public const int IEIFLAG_ASYNC = 0x0001;

    /// <include file='IEIFLAG.xml' path='doc/member[@name="IEIFLAG.IEIFLAG_CACHE"]/*' />
    [NativeTypeName("#define IEIFLAG_CACHE 0x0002")]
    public const int IEIFLAG_CACHE = 0x0002;

    /// <include file='IEIFLAG.xml' path='doc/member[@name="IEIFLAG.IEIFLAG_ASPECT"]/*' />
    [NativeTypeName("#define IEIFLAG_ASPECT 0x0004")]
    public const int IEIFLAG_ASPECT = 0x0004;

    /// <include file='IEIFLAG.xml' path='doc/member[@name="IEIFLAG.IEIFLAG_OFFLINE"]/*' />
    [NativeTypeName("#define IEIFLAG_OFFLINE 0x0008")]
    public const int IEIFLAG_OFFLINE = 0x0008;

    /// <include file='IEIFLAG.xml' path='doc/member[@name="IEIFLAG.IEIFLAG_GLEAM"]/*' />
    [NativeTypeName("#define IEIFLAG_GLEAM 0x0010")]
    public const int IEIFLAG_GLEAM = 0x0010;

    /// <include file='IEIFLAG.xml' path='doc/member[@name="IEIFLAG.IEIFLAG_SCREEN"]/*' />
    [NativeTypeName("#define IEIFLAG_SCREEN 0x0020")]
    public const int IEIFLAG_SCREEN = 0x0020;

    /// <include file='IEIFLAG.xml' path='doc/member[@name="IEIFLAG.IEIFLAG_ORIGSIZE"]/*' />
    [NativeTypeName("#define IEIFLAG_ORIGSIZE 0x0040")]
    public const int IEIFLAG_ORIGSIZE = 0x0040;

    /// <include file='IEIFLAG.xml' path='doc/member[@name="IEIFLAG.IEIFLAG_NOSTAMP"]/*' />
    [NativeTypeName("#define IEIFLAG_NOSTAMP 0x0080")]
    public const int IEIFLAG_NOSTAMP = 0x0080;

    /// <include file='IEIFLAG.xml' path='doc/member[@name="IEIFLAG.IEIFLAG_NOBORDER"]/*' />
    [NativeTypeName("#define IEIFLAG_NOBORDER 0x0100")]
    public const int IEIFLAG_NOBORDER = 0x0100;

    /// <include file='IEIFLAG.xml' path='doc/member[@name="IEIFLAG.IEIFLAG_QUALITY"]/*' />
    [NativeTypeName("#define IEIFLAG_QUALITY 0x0200")]
    public const int IEIFLAG_QUALITY = 0x0200;

    /// <include file='IEIFLAG.xml' path='doc/member[@name="IEIFLAG.IEIFLAG_REFRESH"]/*' />
    [NativeTypeName("#define IEIFLAG_REFRESH 0x0400")]
    public const int IEIFLAG_REFRESH = 0x0400;
}
