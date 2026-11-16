// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class WT
{
    /// <include file='WT.xml' path='doc/member[@name="WT.WT_EXECUTEDEFAULT"]/*' />
    [NativeTypeName("#define WT_EXECUTEDEFAULT 0x00000000")]
    public const int WT_EXECUTEDEFAULT = 0x00000000;

    /// <include file='WT.xml' path='doc/member[@name="WT.WT_EXECUTEINIOTHREAD"]/*' />
    [NativeTypeName("#define WT_EXECUTEINIOTHREAD 0x00000001")]
    public const int WT_EXECUTEINIOTHREAD = 0x00000001;

    /// <include file='WT.xml' path='doc/member[@name="WT.WT_EXECUTEINUITHREAD"]/*' />
    [NativeTypeName("#define WT_EXECUTEINUITHREAD 0x00000002")]
    public const int WT_EXECUTEINUITHREAD = 0x00000002;

    /// <include file='WT.xml' path='doc/member[@name="WT.WT_EXECUTEINWAITTHREAD"]/*' />
    [NativeTypeName("#define WT_EXECUTEINWAITTHREAD 0x00000004")]
    public const int WT_EXECUTEINWAITTHREAD = 0x00000004;

    /// <include file='WT.xml' path='doc/member[@name="WT.WT_EXECUTEONLYONCE"]/*' />
    [NativeTypeName("#define WT_EXECUTEONLYONCE 0x00000008")]
    public const int WT_EXECUTEONLYONCE = 0x00000008;

    /// <include file='WT.xml' path='doc/member[@name="WT.WT_EXECUTEINTIMERTHREAD"]/*' />
    [NativeTypeName("#define WT_EXECUTEINTIMERTHREAD 0x00000020")]
    public const int WT_EXECUTEINTIMERTHREAD = 0x00000020;

    /// <include file='WT.xml' path='doc/member[@name="WT.WT_EXECUTELONGFUNCTION"]/*' />
    [NativeTypeName("#define WT_EXECUTELONGFUNCTION 0x00000010")]
    public const int WT_EXECUTELONGFUNCTION = 0x00000010;

    /// <include file='WT.xml' path='doc/member[@name="WT.WT_EXECUTEINPERSISTENTIOTHREAD"]/*' />
    [NativeTypeName("#define WT_EXECUTEINPERSISTENTIOTHREAD 0x00000040")]
    public const int WT_EXECUTEINPERSISTENTIOTHREAD = 0x00000040;

    /// <include file='WT.xml' path='doc/member[@name="WT.WT_EXECUTEINPERSISTENTTHREAD"]/*' />
    [NativeTypeName("#define WT_EXECUTEINPERSISTENTTHREAD 0x00000080")]
    public const int WT_EXECUTEINPERSISTENTTHREAD = 0x00000080;

    /// <include file='WT.xml' path='doc/member[@name="WT.WT_TRANSFER_IMPERSONATION"]/*' />
    [NativeTypeName("#define WT_TRANSFER_IMPERSONATION 0x00000100")]
    public const int WT_TRANSFER_IMPERSONATION = 0x00000100;

    /// <include file='WT.xml' path='doc/member[@name="WT.WT_EXECUTEINLONGTHREAD"]/*' />
    [NativeTypeName("#define WT_EXECUTEINLONGTHREAD 0x00000010")]
    public const int WT_EXECUTEINLONGTHREAD = 0x00000010;

    /// <include file='WT.xml' path='doc/member[@name="WT.WT_EXECUTEDELETEWAIT"]/*' />
    [NativeTypeName("#define WT_EXECUTEDELETEWAIT 0x00000008")]
    public const int WT_EXECUTEDELETEWAIT = 0x00000008;
}
