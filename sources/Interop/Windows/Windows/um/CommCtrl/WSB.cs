// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class WSB
{
    /// <include file='WSB.xml' path='doc/member[@name="WSB.WSB_PROP_CYVSCROLL"]/*' />
    [NativeTypeName("#define WSB_PROP_CYVSCROLL 0x00000001L")]
    public const int WSB_PROP_CYVSCROLL = 0x00000001;

    /// <include file='WSB.xml' path='doc/member[@name="WSB.WSB_PROP_CXHSCROLL"]/*' />
    [NativeTypeName("#define WSB_PROP_CXHSCROLL 0x00000002L")]
    public const int WSB_PROP_CXHSCROLL = 0x00000002;

    /// <include file='WSB.xml' path='doc/member[@name="WSB.WSB_PROP_CYHSCROLL"]/*' />
    [NativeTypeName("#define WSB_PROP_CYHSCROLL 0x00000004L")]
    public const int WSB_PROP_CYHSCROLL = 0x00000004;

    /// <include file='WSB.xml' path='doc/member[@name="WSB.WSB_PROP_CXVSCROLL"]/*' />
    [NativeTypeName("#define WSB_PROP_CXVSCROLL 0x00000008L")]
    public const int WSB_PROP_CXVSCROLL = 0x00000008;

    /// <include file='WSB.xml' path='doc/member[@name="WSB.WSB_PROP_CXHTHUMB"]/*' />
    [NativeTypeName("#define WSB_PROP_CXHTHUMB 0x00000010L")]
    public const int WSB_PROP_CXHTHUMB = 0x00000010;

    /// <include file='WSB.xml' path='doc/member[@name="WSB.WSB_PROP_CYVTHUMB"]/*' />
    [NativeTypeName("#define WSB_PROP_CYVTHUMB 0x00000020L")]
    public const int WSB_PROP_CYVTHUMB = 0x00000020;

    /// <include file='WSB.xml' path='doc/member[@name="WSB.WSB_PROP_VBKGCOLOR"]/*' />
    [NativeTypeName("#define WSB_PROP_VBKGCOLOR 0x00000040L")]
    public const int WSB_PROP_VBKGCOLOR = 0x00000040;

    /// <include file='WSB.xml' path='doc/member[@name="WSB.WSB_PROP_HBKGCOLOR"]/*' />
    [NativeTypeName("#define WSB_PROP_HBKGCOLOR 0x00000080L")]
    public const int WSB_PROP_HBKGCOLOR = 0x00000080;

    /// <include file='WSB.xml' path='doc/member[@name="WSB.WSB_PROP_VSTYLE"]/*' />
    [NativeTypeName("#define WSB_PROP_VSTYLE 0x00000100L")]
    public const int WSB_PROP_VSTYLE = 0x00000100;

    /// <include file='WSB.xml' path='doc/member[@name="WSB.WSB_PROP_HSTYLE"]/*' />
    [NativeTypeName("#define WSB_PROP_HSTYLE 0x00000200L")]
    public const int WSB_PROP_HSTYLE = 0x00000200;

    /// <include file='WSB.xml' path='doc/member[@name="WSB.WSB_PROP_WINSTYLE"]/*' />
    [NativeTypeName("#define WSB_PROP_WINSTYLE 0x00000400L")]
    public const int WSB_PROP_WINSTYLE = 0x00000400;

    /// <include file='WSB.xml' path='doc/member[@name="WSB.WSB_PROP_PALETTE"]/*' />
    [NativeTypeName("#define WSB_PROP_PALETTE 0x00000800L")]
    public const int WSB_PROP_PALETTE = 0x00000800;

    /// <include file='WSB.xml' path='doc/member[@name="WSB.WSB_PROP_MASK"]/*' />
    [NativeTypeName("#define WSB_PROP_MASK 0x00000FFFL")]
    public const int WSB_PROP_MASK = 0x00000FFF;
}
