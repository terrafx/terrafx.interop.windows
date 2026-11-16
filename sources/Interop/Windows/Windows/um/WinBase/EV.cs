// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinBase.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class EV
{
    /// <include file='EV.xml' path='doc/member[@name="EV.EV_RXCHAR"]/*' />
    [NativeTypeName("#define EV_RXCHAR 0x0001")]
    public const int EV_RXCHAR = 0x0001;

    /// <include file='EV.xml' path='doc/member[@name="EV.EV_RXFLAG"]/*' />
    [NativeTypeName("#define EV_RXFLAG 0x0002")]
    public const int EV_RXFLAG = 0x0002;

    /// <include file='EV.xml' path='doc/member[@name="EV.EV_TXEMPTY"]/*' />
    [NativeTypeName("#define EV_TXEMPTY 0x0004")]
    public const int EV_TXEMPTY = 0x0004;

    /// <include file='EV.xml' path='doc/member[@name="EV.EV_CTS"]/*' />
    [NativeTypeName("#define EV_CTS 0x0008")]
    public const int EV_CTS = 0x0008;

    /// <include file='EV.xml' path='doc/member[@name="EV.EV_DSR"]/*' />
    [NativeTypeName("#define EV_DSR 0x0010")]
    public const int EV_DSR = 0x0010;

    /// <include file='EV.xml' path='doc/member[@name="EV.EV_RLSD"]/*' />
    [NativeTypeName("#define EV_RLSD 0x0020")]
    public const int EV_RLSD = 0x0020;

    /// <include file='EV.xml' path='doc/member[@name="EV.EV_BREAK"]/*' />
    [NativeTypeName("#define EV_BREAK 0x0040")]
    public const int EV_BREAK = 0x0040;

    /// <include file='EV.xml' path='doc/member[@name="EV.EV_ERR"]/*' />
    [NativeTypeName("#define EV_ERR 0x0080")]
    public const int EV_ERR = 0x0080;

    /// <include file='EV.xml' path='doc/member[@name="EV.EV_RING"]/*' />
    [NativeTypeName("#define EV_RING 0x0100")]
    public const int EV_RING = 0x0100;

    /// <include file='EV.xml' path='doc/member[@name="EV.EV_PERR"]/*' />
    [NativeTypeName("#define EV_PERR 0x0200")]
    public const int EV_PERR = 0x0200;

    /// <include file='EV.xml' path='doc/member[@name="EV.EV_RX80FULL"]/*' />
    [NativeTypeName("#define EV_RX80FULL 0x0400")]
    public const int EV_RX80FULL = 0x0400;

    /// <include file='EV.xml' path='doc/member[@name="EV.EV_EVENT1"]/*' />
    [NativeTypeName("#define EV_EVENT1 0x0800")]
    public const int EV_EVENT1 = 0x0800;

    /// <include file='EV.xml' path='doc/member[@name="EV.EV_EVENT2"]/*' />
    [NativeTypeName("#define EV_EVENT2 0x1000")]
    public const int EV_EVENT2 = 0x1000;
}
