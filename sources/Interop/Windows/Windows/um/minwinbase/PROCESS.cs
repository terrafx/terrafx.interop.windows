// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/minwinbase.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class PROCESS
{
    /// <include file='PROCESS.xml' path='doc/member[@name="PROCESS.PROCESS_HEAP_REGION"]/*' />
    [NativeTypeName("#define PROCESS_HEAP_REGION 0x0001")]
    public const int PROCESS_HEAP_REGION = 0x0001;

    /// <include file='PROCESS.xml' path='doc/member[@name="PROCESS.PROCESS_HEAP_UNCOMMITTED_RANGE"]/*' />
    [NativeTypeName("#define PROCESS_HEAP_UNCOMMITTED_RANGE 0x0002")]
    public const int PROCESS_HEAP_UNCOMMITTED_RANGE = 0x0002;

    /// <include file='PROCESS.xml' path='doc/member[@name="PROCESS.PROCESS_HEAP_ENTRY_BUSY"]/*' />
    [NativeTypeName("#define PROCESS_HEAP_ENTRY_BUSY 0x0004")]
    public const int PROCESS_HEAP_ENTRY_BUSY = 0x0004;

    /// <include file='PROCESS.xml' path='doc/member[@name="PROCESS.PROCESS_HEAP_SEG_ALLOC"]/*' />
    [NativeTypeName("#define PROCESS_HEAP_SEG_ALLOC 0x0008")]
    public const int PROCESS_HEAP_SEG_ALLOC = 0x0008;

    /// <include file='PROCESS.xml' path='doc/member[@name="PROCESS.PROCESS_HEAP_ENTRY_MOVEABLE"]/*' />
    [NativeTypeName("#define PROCESS_HEAP_ENTRY_MOVEABLE 0x0010")]
    public const int PROCESS_HEAP_ENTRY_MOVEABLE = 0x0010;

    /// <include file='PROCESS.xml' path='doc/member[@name="PROCESS.PROCESS_HEAP_ENTRY_DDESHARE"]/*' />
    [NativeTypeName("#define PROCESS_HEAP_ENTRY_DDESHARE 0x0020")]
    public const int PROCESS_HEAP_ENTRY_DDESHARE = 0x0020;
}
