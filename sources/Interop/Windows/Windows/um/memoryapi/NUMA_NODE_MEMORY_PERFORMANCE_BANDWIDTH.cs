// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/memoryapi.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='NUMA_NODE_MEMORY_PERFORMANCE_BANDWIDTH.xml' path='doc/member[@name="NUMA_NODE_MEMORY_PERFORMANCE_BANDWIDTH"]/*' />
public partial struct NUMA_NODE_MEMORY_PERFORMANCE_BANDWIDTH
{
    /// <include file='NUMA_NODE_MEMORY_PERFORMANCE_BANDWIDTH.xml' path='doc/member[@name="NUMA_NODE_MEMORY_PERFORMANCE_BANDWIDTH.Condition"]/*' />
    public NUMA_NODE_MEMORY_PERFORMANCE_MEASUREMENT_CONDITION Condition;

    /// <include file='NUMA_NODE_MEMORY_PERFORMANCE_BANDWIDTH.xml' path='doc/member[@name="NUMA_NODE_MEMORY_PERFORMANCE_BANDWIDTH.Bandwidth"]/*' />
    [NativeTypeName("ULONGLONG")]
    public ulong Bandwidth;
}
