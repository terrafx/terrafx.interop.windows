// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/Shlwapi.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class SRRF
{
    /// <include file='SRRF.xml' path='doc/member[@name="SRRF.SRRF_RT_REG_NONE"]/*' />
    [NativeTypeName("#define SRRF_RT_REG_NONE 0x00000001")]
    public const int SRRF_RT_REG_NONE = 0x00000001;

    /// <include file='SRRF.xml' path='doc/member[@name="SRRF.SRRF_RT_REG_SZ"]/*' />
    [NativeTypeName("#define SRRF_RT_REG_SZ 0x00000002")]
    public const int SRRF_RT_REG_SZ = 0x00000002;

    /// <include file='SRRF.xml' path='doc/member[@name="SRRF.SRRF_RT_REG_EXPAND_SZ"]/*' />
    [NativeTypeName("#define SRRF_RT_REG_EXPAND_SZ 0x00000004")]
    public const int SRRF_RT_REG_EXPAND_SZ = 0x00000004;

    /// <include file='SRRF.xml' path='doc/member[@name="SRRF.SRRF_RT_REG_BINARY"]/*' />
    [NativeTypeName("#define SRRF_RT_REG_BINARY 0x00000008")]
    public const int SRRF_RT_REG_BINARY = 0x00000008;

    /// <include file='SRRF.xml' path='doc/member[@name="SRRF.SRRF_RT_REG_DWORD"]/*' />
    [NativeTypeName("#define SRRF_RT_REG_DWORD 0x00000010")]
    public const int SRRF_RT_REG_DWORD = 0x00000010;

    /// <include file='SRRF.xml' path='doc/member[@name="SRRF.SRRF_RT_REG_MULTI_SZ"]/*' />
    [NativeTypeName("#define SRRF_RT_REG_MULTI_SZ 0x00000020")]
    public const int SRRF_RT_REG_MULTI_SZ = 0x00000020;

    /// <include file='SRRF.xml' path='doc/member[@name="SRRF.SRRF_RT_REG_QWORD"]/*' />
    [NativeTypeName("#define SRRF_RT_REG_QWORD 0x00000040")]
    public const int SRRF_RT_REG_QWORD = 0x00000040;

    /// <include file='SRRF.xml' path='doc/member[@name="SRRF.SRRF_RT_DWORD"]/*' />
    [NativeTypeName("#define SRRF_RT_DWORD (SRRF_RT_REG_BINARY | SRRF_RT_REG_DWORD)")]
    public const int SRRF_RT_DWORD = (0x00000008 | 0x00000010);

    /// <include file='SRRF.xml' path='doc/member[@name="SRRF.SRRF_RT_QWORD"]/*' />
    [NativeTypeName("#define SRRF_RT_QWORD (SRRF_RT_REG_BINARY | SRRF_RT_REG_QWORD)")]
    public const int SRRF_RT_QWORD = (0x00000008 | 0x00000040);

    /// <include file='SRRF.xml' path='doc/member[@name="SRRF.SRRF_RT_ANY"]/*' />
    [NativeTypeName("#define SRRF_RT_ANY 0x0000ffff")]
    public const int SRRF_RT_ANY = 0x0000ffff;

    /// <include file='SRRF.xml' path='doc/member[@name="SRRF.SRRF_RM_ANY"]/*' />
    [NativeTypeName("#define SRRF_RM_ANY 0x00000000")]
    public const int SRRF_RM_ANY = 0x00000000;

    /// <include file='SRRF.xml' path='doc/member[@name="SRRF.SRRF_RM_NORMAL"]/*' />
    [NativeTypeName("#define SRRF_RM_NORMAL 0x00010000")]
    public const int SRRF_RM_NORMAL = 0x00010000;

    /// <include file='SRRF.xml' path='doc/member[@name="SRRF.SRRF_RM_SAFE"]/*' />
    [NativeTypeName("#define SRRF_RM_SAFE 0x00020000")]
    public const int SRRF_RM_SAFE = 0x00020000;

    /// <include file='SRRF.xml' path='doc/member[@name="SRRF.SRRF_RM_SAFENETWORK"]/*' />
    [NativeTypeName("#define SRRF_RM_SAFENETWORK 0x00040000")]
    public const int SRRF_RM_SAFENETWORK = 0x00040000;

    /// <include file='SRRF.xml' path='doc/member[@name="SRRF.SRRF_NOEXPAND"]/*' />
    [NativeTypeName("#define SRRF_NOEXPAND 0x10000000")]
    public const int SRRF_NOEXPAND = 0x10000000;

    /// <include file='SRRF.xml' path='doc/member[@name="SRRF.SRRF_ZEROONFAILURE"]/*' />
    [NativeTypeName("#define SRRF_ZEROONFAILURE 0x20000000")]
    public const int SRRF_ZEROONFAILURE = 0x20000000;

    /// <include file='SRRF.xml' path='doc/member[@name="SRRF.SRRF_NOVIRT"]/*' />
    [NativeTypeName("#define SRRF_NOVIRT 0x40000000")]
    public const int SRRF_NOVIRT = 0x40000000;
}
