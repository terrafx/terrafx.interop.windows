// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinBase.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class CE
{
    /// <include file='CE.xml' path='doc/member[@name="CE.CE_RXOVER"]/*' />
    [NativeTypeName("#define CE_RXOVER 0x0001")]
    public const int CE_RXOVER = 0x0001;

    /// <include file='CE.xml' path='doc/member[@name="CE.CE_OVERRUN"]/*' />
    [NativeTypeName("#define CE_OVERRUN 0x0002")]
    public const int CE_OVERRUN = 0x0002;

    /// <include file='CE.xml' path='doc/member[@name="CE.CE_RXPARITY"]/*' />
    [NativeTypeName("#define CE_RXPARITY 0x0004")]
    public const int CE_RXPARITY = 0x0004;

    /// <include file='CE.xml' path='doc/member[@name="CE.CE_FRAME"]/*' />
    [NativeTypeName("#define CE_FRAME 0x0008")]
    public const int CE_FRAME = 0x0008;

    /// <include file='CE.xml' path='doc/member[@name="CE.CE_BREAK"]/*' />
    [NativeTypeName("#define CE_BREAK 0x0010")]
    public const int CE_BREAK = 0x0010;

    /// <include file='CE.xml' path='doc/member[@name="CE.CE_TXFULL"]/*' />
    [NativeTypeName("#define CE_TXFULL 0x0100")]
    public const int CE_TXFULL = 0x0100;

    /// <include file='CE.xml' path='doc/member[@name="CE.CE_PTO"]/*' />
    [NativeTypeName("#define CE_PTO 0x0200")]
    public const int CE_PTO = 0x0200;

    /// <include file='CE.xml' path='doc/member[@name="CE.CE_IOE"]/*' />
    [NativeTypeName("#define CE_IOE 0x0400")]
    public const int CE_IOE = 0x0400;

    /// <include file='CE.xml' path='doc/member[@name="CE.CE_DNS"]/*' />
    [NativeTypeName("#define CE_DNS 0x0800")]
    public const int CE_DNS = 0x0800;

    /// <include file='CE.xml' path='doc/member[@name="CE.CE_OOP"]/*' />
    [NativeTypeName("#define CE_OOP 0x1000")]
    public const int CE_OOP = 0x1000;

    /// <include file='CE.xml' path='doc/member[@name="CE.CE_MODE"]/*' />
    [NativeTypeName("#define CE_MODE 0x8000")]
    public const int CE_MODE = 0x8000;
}
