// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class MAXIMUM
{
    /// <include file='MAXIMUM.xml' path='doc/member[@name="MAXIMUM.MAXIMUM_WAIT_OBJECTS"]/*' />
    [NativeTypeName("#define MAXIMUM_WAIT_OBJECTS 64")]
    public const int MAXIMUM_WAIT_OBJECTS = 64;

    /// <include file='MAXIMUM.xml' path='doc/member[@name="MAXIMUM.MAXIMUM_SUSPEND_COUNT"]/*' />
    [NativeTypeName("#define MAXIMUM_SUSPEND_COUNT MAXCHAR")]
    public const int MAXIMUM_SUSPEND_COUNT = 0x7f;

    /// <include file='MAXIMUM.xml' path='doc/member[@name="MAXIMUM.MAXIMUM_ALLOWED"]/*' />
    [NativeTypeName("#define MAXIMUM_ALLOWED (0x02000000L)")]
    public const int MAXIMUM_ALLOWED = (0x02000000);

    /// <include file='MAXIMUM.xml' path='doc/member[@name="MAXIMUM.MAXIMUM_XSTATE_FEATURES"]/*' />
    [NativeTypeName("#define MAXIMUM_XSTATE_FEATURES (64)")]
    public const int MAXIMUM_XSTATE_FEATURES = (64);

    /// <include file='MAXIMUM.xml' path='doc/member[@name="MAXIMUM.MAXIMUM_REPARSE_DATA_BUFFER_SIZE"]/*' />
    [NativeTypeName("#define MAXIMUM_REPARSE_DATA_BUFFER_SIZE ( 16 * 1024 )")]
    public const int MAXIMUM_REPARSE_DATA_BUFFER_SIZE = (16 * 1024);
}
