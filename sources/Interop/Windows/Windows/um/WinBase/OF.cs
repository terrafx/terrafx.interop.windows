// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinBase.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class OF
{
    /// <include file='OF.xml' path='doc/member[@name="OF.OF_READ"]/*' />
    [NativeTypeName("#define OF_READ 0x00000000")]
    public const int OF_READ = 0x00000000;

    /// <include file='OF.xml' path='doc/member[@name="OF.OF_WRITE"]/*' />
    [NativeTypeName("#define OF_WRITE 0x00000001")]
    public const int OF_WRITE = 0x00000001;

    /// <include file='OF.xml' path='doc/member[@name="OF.OF_READWRITE"]/*' />
    [NativeTypeName("#define OF_READWRITE 0x00000002")]
    public const int OF_READWRITE = 0x00000002;

    /// <include file='OF.xml' path='doc/member[@name="OF.OF_SHARE_COMPAT"]/*' />
    [NativeTypeName("#define OF_SHARE_COMPAT 0x00000000")]
    public const int OF_SHARE_COMPAT = 0x00000000;

    /// <include file='OF.xml' path='doc/member[@name="OF.OF_SHARE_EXCLUSIVE"]/*' />
    [NativeTypeName("#define OF_SHARE_EXCLUSIVE 0x00000010")]
    public const int OF_SHARE_EXCLUSIVE = 0x00000010;

    /// <include file='OF.xml' path='doc/member[@name="OF.OF_SHARE_DENY_WRITE"]/*' />
    [NativeTypeName("#define OF_SHARE_DENY_WRITE 0x00000020")]
    public const int OF_SHARE_DENY_WRITE = 0x00000020;

    /// <include file='OF.xml' path='doc/member[@name="OF.OF_SHARE_DENY_READ"]/*' />
    [NativeTypeName("#define OF_SHARE_DENY_READ 0x00000030")]
    public const int OF_SHARE_DENY_READ = 0x00000030;

    /// <include file='OF.xml' path='doc/member[@name="OF.OF_SHARE_DENY_NONE"]/*' />
    [NativeTypeName("#define OF_SHARE_DENY_NONE 0x00000040")]
    public const int OF_SHARE_DENY_NONE = 0x00000040;

    /// <include file='OF.xml' path='doc/member[@name="OF.OF_PARSE"]/*' />
    [NativeTypeName("#define OF_PARSE 0x00000100")]
    public const int OF_PARSE = 0x00000100;

    /// <include file='OF.xml' path='doc/member[@name="OF.OF_DELETE"]/*' />
    [NativeTypeName("#define OF_DELETE 0x00000200")]
    public const int OF_DELETE = 0x00000200;

    /// <include file='OF.xml' path='doc/member[@name="OF.OF_VERIFY"]/*' />
    [NativeTypeName("#define OF_VERIFY 0x00000400")]
    public const int OF_VERIFY = 0x00000400;

    /// <include file='OF.xml' path='doc/member[@name="OF.OF_CANCEL"]/*' />
    [NativeTypeName("#define OF_CANCEL 0x00000800")]
    public const int OF_CANCEL = 0x00000800;

    /// <include file='OF.xml' path='doc/member[@name="OF.OF_CREATE"]/*' />
    [NativeTypeName("#define OF_CREATE 0x00001000")]
    public const int OF_CREATE = 0x00001000;

    /// <include file='OF.xml' path='doc/member[@name="OF.OF_PROMPT"]/*' />
    [NativeTypeName("#define OF_PROMPT 0x00002000")]
    public const int OF_PROMPT = 0x00002000;

    /// <include file='OF.xml' path='doc/member[@name="OF.OF_EXIST"]/*' />
    [NativeTypeName("#define OF_EXIST 0x00004000")]
    public const int OF_EXIST = 0x00004000;

    /// <include file='OF.xml' path='doc/member[@name="OF.OF_REOPEN"]/*' />
    [NativeTypeName("#define OF_REOPEN 0x00008000")]
    public const int OF_REOPEN = 0x00008000;
}
