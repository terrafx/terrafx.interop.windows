// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='HEAP_MEMORY_USAGE_ENTRY.xml' path='doc/member[@name="HEAP_MEMORY_USAGE_ENTRY"]/*' />
public unsafe partial struct HEAP_MEMORY_USAGE_ENTRY
{
    /// <include file='HEAP_MEMORY_USAGE_ENTRY.xml' path='doc/member[@name="HEAP_MEMORY_USAGE_ENTRY.HeapHandle"]/*' />
    [NativeTypeName("PVOID")]
    public void* HeapHandle;

    /// <include file='HEAP_MEMORY_USAGE_ENTRY.xml' path='doc/member[@name="HEAP_MEMORY_USAGE_ENTRY.TotalCommittedBytes"]/*' />
    [NativeTypeName("SIZE_T")]
    public nuint TotalCommittedBytes;

    /// <include file='HEAP_MEMORY_USAGE_ENTRY.xml' path='doc/member[@name="HEAP_MEMORY_USAGE_ENTRY.TotalReservedBytes"]/*' />
    [NativeTypeName("SIZE_T")]
    public nuint TotalReservedBytes;
}
