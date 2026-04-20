// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/memoryapi.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='NUMA_NODE_MEMORY_PERFORMANCE_LATENCY.xml' path='doc/member[@name="NUMA_NODE_MEMORY_PERFORMANCE_LATENCY"]/*' />
public partial struct NUMA_NODE_MEMORY_PERFORMANCE_LATENCY
{
    /// <include file='NUMA_NODE_MEMORY_PERFORMANCE_LATENCY.xml' path='doc/member[@name="NUMA_NODE_MEMORY_PERFORMANCE_LATENCY.Condition"]/*' />
    public NUMA_NODE_MEMORY_PERFORMANCE_MEASUREMENT_CONDITION Condition;

    /// <include file='NUMA_NODE_MEMORY_PERFORMANCE_LATENCY.xml' path='doc/member[@name="NUMA_NODE_MEMORY_PERFORMANCE_LATENCY.Latency"]/*' />
    [NativeTypeName("ULONGLONG")]
    public ulong Latency;
}
