// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class ILD
{
    /// <include file='ILD.xml' path='doc/member[@name="ILD.ILD_NORMAL"]/*' />
    [NativeTypeName("#define ILD_NORMAL 0x00000000")]
    public const int ILD_NORMAL = 0x00000000;

    /// <include file='ILD.xml' path='doc/member[@name="ILD.ILD_TRANSPARENT"]/*' />
    [NativeTypeName("#define ILD_TRANSPARENT 0x00000001")]
    public const int ILD_TRANSPARENT = 0x00000001;

    /// <include file='ILD.xml' path='doc/member[@name="ILD.ILD_MASK"]/*' />
    [NativeTypeName("#define ILD_MASK 0x00000010")]
    public const int ILD_MASK = 0x00000010;

    /// <include file='ILD.xml' path='doc/member[@name="ILD.ILD_IMAGE"]/*' />
    [NativeTypeName("#define ILD_IMAGE 0x00000020")]
    public const int ILD_IMAGE = 0x00000020;

    /// <include file='ILD.xml' path='doc/member[@name="ILD.ILD_ROP"]/*' />
    [NativeTypeName("#define ILD_ROP 0x00000040")]
    public const int ILD_ROP = 0x00000040;

    /// <include file='ILD.xml' path='doc/member[@name="ILD.ILD_BLEND25"]/*' />
    [NativeTypeName("#define ILD_BLEND25 0x00000002")]
    public const int ILD_BLEND25 = 0x00000002;

    /// <include file='ILD.xml' path='doc/member[@name="ILD.ILD_BLEND50"]/*' />
    [NativeTypeName("#define ILD_BLEND50 0x00000004")]
    public const int ILD_BLEND50 = 0x00000004;

    /// <include file='ILD.xml' path='doc/member[@name="ILD.ILD_OVERLAYMASK"]/*' />
    [NativeTypeName("#define ILD_OVERLAYMASK 0x00000F00")]
    public const int ILD_OVERLAYMASK = 0x00000F00;

    /// <include file='ILD.xml' path='doc/member[@name="ILD.ILD_PRESERVEALPHA"]/*' />
    [NativeTypeName("#define ILD_PRESERVEALPHA 0x00001000")]
    public const int ILD_PRESERVEALPHA = 0x00001000;

    /// <include file='ILD.xml' path='doc/member[@name="ILD.ILD_SCALE"]/*' />
    [NativeTypeName("#define ILD_SCALE 0x00002000")]
    public const int ILD_SCALE = 0x00002000;

    /// <include file='ILD.xml' path='doc/member[@name="ILD.ILD_DPISCALE"]/*' />
    [NativeTypeName("#define ILD_DPISCALE 0x00004000")]
    public const int ILD_DPISCALE = 0x00004000;

    /// <include file='ILD.xml' path='doc/member[@name="ILD.ILD_ASYNC"]/*' />
    [NativeTypeName("#define ILD_ASYNC 0x00008000")]
    public const int ILD_ASYNC = 0x00008000;

    /// <include file='ILD.xml' path='doc/member[@name="ILD.ILD_SELECTED"]/*' />
    [NativeTypeName("#define ILD_SELECTED ILD_BLEND50")]
    public const int ILD_SELECTED = 0x00000004;

    /// <include file='ILD.xml' path='doc/member[@name="ILD.ILD_FOCUS"]/*' />
    [NativeTypeName("#define ILD_FOCUS ILD_BLEND25")]
    public const int ILD_FOCUS = 0x00000002;

    /// <include file='ILD.xml' path='doc/member[@name="ILD.ILD_BLEND"]/*' />
    [NativeTypeName("#define ILD_BLEND ILD_BLEND50")]
    public const int ILD_BLEND = 0x00000004;
}
