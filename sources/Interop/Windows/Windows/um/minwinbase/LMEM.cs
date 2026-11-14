// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/minwinbase.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class LMEM
{
    /// <include file='LMEM.xml' path='doc/member[@name="LMEM.LMEM_FIXED"]/*' />
    [NativeTypeName("#define LMEM_FIXED 0x0000")]
    public const int LMEM_FIXED = 0x0000;

    /// <include file='LMEM.xml' path='doc/member[@name="LMEM.LMEM_MOVEABLE"]/*' />
    [NativeTypeName("#define LMEM_MOVEABLE 0x0002")]
    public const int LMEM_MOVEABLE = 0x0002;

    /// <include file='LMEM.xml' path='doc/member[@name="LMEM.LMEM_NOCOMPACT"]/*' />
    [NativeTypeName("#define LMEM_NOCOMPACT 0x0010")]
    public const int LMEM_NOCOMPACT = 0x0010;

    /// <include file='LMEM.xml' path='doc/member[@name="LMEM.LMEM_NODISCARD"]/*' />
    [NativeTypeName("#define LMEM_NODISCARD 0x0020")]
    public const int LMEM_NODISCARD = 0x0020;

    /// <include file='LMEM.xml' path='doc/member[@name="LMEM.LMEM_ZEROINIT"]/*' />
    [NativeTypeName("#define LMEM_ZEROINIT 0x0040")]
    public const int LMEM_ZEROINIT = 0x0040;

    /// <include file='LMEM.xml' path='doc/member[@name="LMEM.LMEM_MODIFY"]/*' />
    [NativeTypeName("#define LMEM_MODIFY 0x0080")]
    public const int LMEM_MODIFY = 0x0080;

    /// <include file='LMEM.xml' path='doc/member[@name="LMEM.LMEM_DISCARDABLE"]/*' />
    [NativeTypeName("#define LMEM_DISCARDABLE 0x0F00")]
    public const int LMEM_DISCARDABLE = 0x0F00;

    /// <include file='LMEM.xml' path='doc/member[@name="LMEM.LMEM_VALID_FLAGS"]/*' />
    [NativeTypeName("#define LMEM_VALID_FLAGS 0x0F72")]
    public const int LMEM_VALID_FLAGS = 0x0F72;

    /// <include file='LMEM.xml' path='doc/member[@name="LMEM.LMEM_INVALID_HANDLE"]/*' />
    [NativeTypeName("#define LMEM_INVALID_HANDLE 0x8000")]
    public const int LMEM_INVALID_HANDLE = 0x8000;

    /// <include file='LMEM.xml' path='doc/member[@name="LMEM.LMEM_DISCARDED"]/*' />
    [NativeTypeName("#define LMEM_DISCARDED 0x4000")]
    public const int LMEM_DISCARDED = 0x4000;

    /// <include file='LMEM.xml' path='doc/member[@name="LMEM.LMEM_LOCKCOUNT"]/*' />
    [NativeTypeName("#define LMEM_LOCKCOUNT 0x00FF")]
    public const int LMEM_LOCKCOUNT = 0x00FF;
}
