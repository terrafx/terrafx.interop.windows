// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class TVIF
{
    /// <include file='TVIF.xml' path='doc/member[@name="TVIF.TVIF_TEXT"]/*' />
    [NativeTypeName("#define TVIF_TEXT 0x0001")]
    public const int TVIF_TEXT = 0x0001;

    /// <include file='TVIF.xml' path='doc/member[@name="TVIF.TVIF_IMAGE"]/*' />
    [NativeTypeName("#define TVIF_IMAGE 0x0002")]
    public const int TVIF_IMAGE = 0x0002;

    /// <include file='TVIF.xml' path='doc/member[@name="TVIF.TVIF_PARAM"]/*' />
    [NativeTypeName("#define TVIF_PARAM 0x0004")]
    public const int TVIF_PARAM = 0x0004;

    /// <include file='TVIF.xml' path='doc/member[@name="TVIF.TVIF_STATE"]/*' />
    [NativeTypeName("#define TVIF_STATE 0x0008")]
    public const int TVIF_STATE = 0x0008;

    /// <include file='TVIF.xml' path='doc/member[@name="TVIF.TVIF_HANDLE"]/*' />
    [NativeTypeName("#define TVIF_HANDLE 0x0010")]
    public const int TVIF_HANDLE = 0x0010;

    /// <include file='TVIF.xml' path='doc/member[@name="TVIF.TVIF_SELECTEDIMAGE"]/*' />
    [NativeTypeName("#define TVIF_SELECTEDIMAGE 0x0020")]
    public const int TVIF_SELECTEDIMAGE = 0x0020;

    /// <include file='TVIF.xml' path='doc/member[@name="TVIF.TVIF_CHILDREN"]/*' />
    [NativeTypeName("#define TVIF_CHILDREN 0x0040")]
    public const int TVIF_CHILDREN = 0x0040;

    /// <include file='TVIF.xml' path='doc/member[@name="TVIF.TVIF_INTEGRAL"]/*' />
    [NativeTypeName("#define TVIF_INTEGRAL 0x0080")]
    public const int TVIF_INTEGRAL = 0x0080;

    /// <include file='TVIF.xml' path='doc/member[@name="TVIF.TVIF_STATEEX"]/*' />
    [NativeTypeName("#define TVIF_STATEEX 0x0100")]
    public const int TVIF_STATEEX = 0x0100;

    /// <include file='TVIF.xml' path='doc/member[@name="TVIF.TVIF_EXPANDEDIMAGE"]/*' />
    [NativeTypeName("#define TVIF_EXPANDEDIMAGE 0x0200")]
    public const int TVIF_EXPANDEDIMAGE = 0x0200;

    /// <include file='TVIF.xml' path='doc/member[@name="TVIF.TVIF_DI_SETITEM"]/*' />
    [NativeTypeName("#define TVIF_DI_SETITEM 0x1000")]
    public const int TVIF_DI_SETITEM = 0x1000;
}
