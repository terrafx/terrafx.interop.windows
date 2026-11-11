// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/coml2api.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class STGM
{
    /// <include file='STGM.xml' path='doc/member[@name="STGM.STGM_DIRECT"]/*' />
    [NativeTypeName("#define STGM_DIRECT 0x00000000L")]
    public const int STGM_DIRECT = 0x00000000;

    /// <include file='STGM.xml' path='doc/member[@name="STGM.STGM_TRANSACTED"]/*' />
    [NativeTypeName("#define STGM_TRANSACTED 0x00010000L")]
    public const int STGM_TRANSACTED = 0x00010000;

    /// <include file='STGM.xml' path='doc/member[@name="STGM.STGM_SIMPLE"]/*' />
    [NativeTypeName("#define STGM_SIMPLE 0x08000000L")]
    public const int STGM_SIMPLE = 0x08000000;

    /// <include file='STGM.xml' path='doc/member[@name="STGM.STGM_READ"]/*' />
    [NativeTypeName("#define STGM_READ 0x00000000L")]
    public const int STGM_READ = 0x00000000;

    /// <include file='STGM.xml' path='doc/member[@name="STGM.STGM_WRITE"]/*' />
    [NativeTypeName("#define STGM_WRITE 0x00000001L")]
    public const int STGM_WRITE = 0x00000001;

    /// <include file='STGM.xml' path='doc/member[@name="STGM.STGM_READWRITE"]/*' />
    [NativeTypeName("#define STGM_READWRITE 0x00000002L")]
    public const int STGM_READWRITE = 0x00000002;

    /// <include file='STGM.xml' path='doc/member[@name="STGM.STGM_SHARE_DENY_NONE"]/*' />
    [NativeTypeName("#define STGM_SHARE_DENY_NONE 0x00000040L")]
    public const int STGM_SHARE_DENY_NONE = 0x00000040;

    /// <include file='STGM.xml' path='doc/member[@name="STGM.STGM_SHARE_DENY_READ"]/*' />
    [NativeTypeName("#define STGM_SHARE_DENY_READ 0x00000030L")]
    public const int STGM_SHARE_DENY_READ = 0x00000030;

    /// <include file='STGM.xml' path='doc/member[@name="STGM.STGM_SHARE_DENY_WRITE"]/*' />
    [NativeTypeName("#define STGM_SHARE_DENY_WRITE 0x00000020L")]
    public const int STGM_SHARE_DENY_WRITE = 0x00000020;

    /// <include file='STGM.xml' path='doc/member[@name="STGM.STGM_SHARE_EXCLUSIVE"]/*' />
    [NativeTypeName("#define STGM_SHARE_EXCLUSIVE 0x00000010L")]
    public const int STGM_SHARE_EXCLUSIVE = 0x00000010;

    /// <include file='STGM.xml' path='doc/member[@name="STGM.STGM_PRIORITY"]/*' />
    [NativeTypeName("#define STGM_PRIORITY 0x00040000L")]
    public const int STGM_PRIORITY = 0x00040000;

    /// <include file='STGM.xml' path='doc/member[@name="STGM.STGM_DELETEONRELEASE"]/*' />
    [NativeTypeName("#define STGM_DELETEONRELEASE 0x04000000L")]
    public const int STGM_DELETEONRELEASE = 0x04000000;

    /// <include file='STGM.xml' path='doc/member[@name="STGM.STGM_NOSCRATCH"]/*' />
    [NativeTypeName("#define STGM_NOSCRATCH 0x00100000L")]
    public const int STGM_NOSCRATCH = 0x00100000;

    /// <include file='STGM.xml' path='doc/member[@name="STGM.STGM_CREATE"]/*' />
    [NativeTypeName("#define STGM_CREATE 0x00001000L")]
    public const int STGM_CREATE = 0x00001000;

    /// <include file='STGM.xml' path='doc/member[@name="STGM.STGM_CONVERT"]/*' />
    [NativeTypeName("#define STGM_CONVERT 0x00020000L")]
    public const int STGM_CONVERT = 0x00020000;

    /// <include file='STGM.xml' path='doc/member[@name="STGM.STGM_FAILIFTHERE"]/*' />
    [NativeTypeName("#define STGM_FAILIFTHERE 0x00000000L")]
    public const int STGM_FAILIFTHERE = 0x00000000;

    /// <include file='STGM.xml' path='doc/member[@name="STGM.STGM_NOSNAPSHOT"]/*' />
    [NativeTypeName("#define STGM_NOSNAPSHOT 0x00200000L")]
    public const int STGM_NOSNAPSHOT = 0x00200000;

    /// <include file='STGM.xml' path='doc/member[@name="STGM.STGM_DIRECT_SWMR"]/*' />
    [NativeTypeName("#define STGM_DIRECT_SWMR 0x00400000L")]
    public const int STGM_DIRECT_SWMR = 0x00400000;
}
