// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class HCBT
{
    /// <include file='HCBT.xml' path='doc/member[@name="HCBT.HCBT_MOVESIZE"]/*' />
    [NativeTypeName("#define HCBT_MOVESIZE 0")]
    public const int HCBT_MOVESIZE = 0;

    /// <include file='HCBT.xml' path='doc/member[@name="HCBT.HCBT_MINMAX"]/*' />
    [NativeTypeName("#define HCBT_MINMAX 1")]
    public const int HCBT_MINMAX = 1;

    /// <include file='HCBT.xml' path='doc/member[@name="HCBT.HCBT_QS"]/*' />
    [NativeTypeName("#define HCBT_QS 2")]
    public const int HCBT_QS = 2;

    /// <include file='HCBT.xml' path='doc/member[@name="HCBT.HCBT_CREATEWND"]/*' />
    [NativeTypeName("#define HCBT_CREATEWND 3")]
    public const int HCBT_CREATEWND = 3;

    /// <include file='HCBT.xml' path='doc/member[@name="HCBT.HCBT_DESTROYWND"]/*' />
    [NativeTypeName("#define HCBT_DESTROYWND 4")]
    public const int HCBT_DESTROYWND = 4;

    /// <include file='HCBT.xml' path='doc/member[@name="HCBT.HCBT_ACTIVATE"]/*' />
    [NativeTypeName("#define HCBT_ACTIVATE 5")]
    public const int HCBT_ACTIVATE = 5;

    /// <include file='HCBT.xml' path='doc/member[@name="HCBT.HCBT_CLICKSKIPPED"]/*' />
    [NativeTypeName("#define HCBT_CLICKSKIPPED 6")]
    public const int HCBT_CLICKSKIPPED = 6;

    /// <include file='HCBT.xml' path='doc/member[@name="HCBT.HCBT_KEYSKIPPED"]/*' />
    [NativeTypeName("#define HCBT_KEYSKIPPED 7")]
    public const int HCBT_KEYSKIPPED = 7;

    /// <include file='HCBT.xml' path='doc/member[@name="HCBT.HCBT_SYSCOMMAND"]/*' />
    [NativeTypeName("#define HCBT_SYSCOMMAND 8")]
    public const int HCBT_SYSCOMMAND = 8;

    /// <include file='HCBT.xml' path='doc/member[@name="HCBT.HCBT_SETFOCUS"]/*' />
    [NativeTypeName("#define HCBT_SETFOCUS 9")]
    public const int HCBT_SETFOCUS = 9;
}
