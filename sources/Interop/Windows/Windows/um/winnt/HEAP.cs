// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class HEAP
{
    /// <include file='HEAP.xml' path='doc/member[@name="HEAP.HEAP_MAKE_TAG_FLAGS"]/*' />
    [return: NativeTypeName("DWORD")]
    public static uint HEAP_MAKE_TAG_FLAGS([NativeTypeName("DWORD")] uint TagBase, [NativeTypeName("DWORD")] uint Tag)
    {
        return ((uint)((TagBase) + ((Tag) << 18)));
    }

    /// <include file='HEAP.xml' path='doc/member[@name="HEAP.HEAP_NO_SERIALIZE"]/*' />
    [NativeTypeName("#define HEAP_NO_SERIALIZE 0x00000001")]
    public const int HEAP_NO_SERIALIZE = 0x00000001;

    /// <include file='HEAP.xml' path='doc/member[@name="HEAP.HEAP_GROWABLE"]/*' />
    [NativeTypeName("#define HEAP_GROWABLE 0x00000002")]
    public const int HEAP_GROWABLE = 0x00000002;

    /// <include file='HEAP.xml' path='doc/member[@name="HEAP.HEAP_GENERATE_EXCEPTIONS"]/*' />
    [NativeTypeName("#define HEAP_GENERATE_EXCEPTIONS 0x00000004")]
    public const int HEAP_GENERATE_EXCEPTIONS = 0x00000004;

    /// <include file='HEAP.xml' path='doc/member[@name="HEAP.HEAP_ZERO_MEMORY"]/*' />
    [NativeTypeName("#define HEAP_ZERO_MEMORY 0x00000008")]
    public const int HEAP_ZERO_MEMORY = 0x00000008;

    /// <include file='HEAP.xml' path='doc/member[@name="HEAP.HEAP_REALLOC_IN_PLACE_ONLY"]/*' />
    [NativeTypeName("#define HEAP_REALLOC_IN_PLACE_ONLY 0x00000010")]
    public const int HEAP_REALLOC_IN_PLACE_ONLY = 0x00000010;

    /// <include file='HEAP.xml' path='doc/member[@name="HEAP.HEAP_TAIL_CHECKING_ENABLED"]/*' />
    [NativeTypeName("#define HEAP_TAIL_CHECKING_ENABLED 0x00000020")]
    public const int HEAP_TAIL_CHECKING_ENABLED = 0x00000020;

    /// <include file='HEAP.xml' path='doc/member[@name="HEAP.HEAP_FREE_CHECKING_ENABLED"]/*' />
    [NativeTypeName("#define HEAP_FREE_CHECKING_ENABLED 0x00000040")]
    public const int HEAP_FREE_CHECKING_ENABLED = 0x00000040;

    /// <include file='HEAP.xml' path='doc/member[@name="HEAP.HEAP_DISABLE_COALESCE_ON_FREE"]/*' />
    [NativeTypeName("#define HEAP_DISABLE_COALESCE_ON_FREE 0x00000080")]
    public const int HEAP_DISABLE_COALESCE_ON_FREE = 0x00000080;

    /// <include file='HEAP.xml' path='doc/member[@name="HEAP.HEAP_CREATE_ALIGN_16"]/*' />
    [NativeTypeName("#define HEAP_CREATE_ALIGN_16 0x00010000")]
    public const int HEAP_CREATE_ALIGN_16 = 0x00010000;

    /// <include file='HEAP.xml' path='doc/member[@name="HEAP.HEAP_CREATE_ENABLE_TRACING"]/*' />
    [NativeTypeName("#define HEAP_CREATE_ENABLE_TRACING 0x00020000")]
    public const int HEAP_CREATE_ENABLE_TRACING = 0x00020000;

    /// <include file='HEAP.xml' path='doc/member[@name="HEAP.HEAP_CREATE_ENABLE_EXECUTE"]/*' />
    [NativeTypeName("#define HEAP_CREATE_ENABLE_EXECUTE 0x00040000")]
    public const int HEAP_CREATE_ENABLE_EXECUTE = 0x00040000;

    /// <include file='HEAP.xml' path='doc/member[@name="HEAP.HEAP_MAXIMUM_TAG"]/*' />
    [NativeTypeName("#define HEAP_MAXIMUM_TAG 0x0FFF")]
    public const int HEAP_MAXIMUM_TAG = 0x0FFF;

    /// <include file='HEAP.xml' path='doc/member[@name="HEAP.HEAP_PSEUDO_TAG_FLAG"]/*' />
    [NativeTypeName("#define HEAP_PSEUDO_TAG_FLAG 0x8000")]
    public const int HEAP_PSEUDO_TAG_FLAG = 0x8000;

    /// <include file='HEAP.xml' path='doc/member[@name="HEAP.HEAP_TAG_SHIFT"]/*' />
    [NativeTypeName("#define HEAP_TAG_SHIFT 18")]
    public const int HEAP_TAG_SHIFT = 18;

    /// <include file='HEAP.xml' path='doc/member[@name="HEAP.HEAP_CREATE_SEGMENT_HEAP"]/*' />
    [NativeTypeName("#define HEAP_CREATE_SEGMENT_HEAP 0x00000100")]
    public const int HEAP_CREATE_SEGMENT_HEAP = 0x00000100;

    /// <include file='HEAP.xml' path='doc/member[@name="HEAP.HEAP_CREATE_HARDENED"]/*' />
    [NativeTypeName("#define HEAP_CREATE_HARDENED 0x00000200")]
    public const int HEAP_CREATE_HARDENED = 0x00000200;

    /// <include file='HEAP.xml' path='doc/member[@name="HEAP.HEAP_OPTIMIZE_RESOURCES_CURRENT_VERSION"]/*' />
    [NativeTypeName("#define HEAP_OPTIMIZE_RESOURCES_CURRENT_VERSION 1")]
    public const int HEAP_OPTIMIZE_RESOURCES_CURRENT_VERSION = 1;

    /// <include file='HEAP.xml' path='doc/member[@name="HEAP.HEAP_MEMORY_USAGE_INFO_CURRENT_VERSION"]/*' />
    [NativeTypeName("#define HEAP_MEMORY_USAGE_INFO_CURRENT_VERSION 0x1")]
    public const int HEAP_MEMORY_USAGE_INFO_CURRENT_VERSION = 0x1;
}
