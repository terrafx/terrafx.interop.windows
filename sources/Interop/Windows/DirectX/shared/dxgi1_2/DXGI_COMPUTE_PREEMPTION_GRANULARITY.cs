// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/dxgi1_2.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

/// <include file='DXGI_COMPUTE_PREEMPTION_GRANULARITY.xml' path='doc/member[@name="DXGI_COMPUTE_PREEMPTION_GRANULARITY"]/*' />
public enum DXGI_COMPUTE_PREEMPTION_GRANULARITY
{
    /// <include file='DXGI_COMPUTE_PREEMPTION_GRANULARITY.xml' path='doc/member[@name="DXGI_COMPUTE_PREEMPTION_GRANULARITY.DXGI_COMPUTE_PREEMPTION_DMA_BUFFER_BOUNDARY"]/*' />
    DXGI_COMPUTE_PREEMPTION_DMA_BUFFER_BOUNDARY = 0,

    /// <include file='DXGI_COMPUTE_PREEMPTION_GRANULARITY.xml' path='doc/member[@name="DXGI_COMPUTE_PREEMPTION_GRANULARITY.DXGI_COMPUTE_PREEMPTION_DISPATCH_BOUNDARY"]/*' />
    DXGI_COMPUTE_PREEMPTION_DISPATCH_BOUNDARY = 1,

    /// <include file='DXGI_COMPUTE_PREEMPTION_GRANULARITY.xml' path='doc/member[@name="DXGI_COMPUTE_PREEMPTION_GRANULARITY.DXGI_COMPUTE_PREEMPTION_THREAD_GROUP_BOUNDARY"]/*' />
    DXGI_COMPUTE_PREEMPTION_THREAD_GROUP_BOUNDARY = 2,

    /// <include file='DXGI_COMPUTE_PREEMPTION_GRANULARITY.xml' path='doc/member[@name="DXGI_COMPUTE_PREEMPTION_GRANULARITY.DXGI_COMPUTE_PREEMPTION_THREAD_BOUNDARY"]/*' />
    DXGI_COMPUTE_PREEMPTION_THREAD_BOUNDARY = 3,

    /// <include file='DXGI_COMPUTE_PREEMPTION_GRANULARITY.xml' path='doc/member[@name="DXGI_COMPUTE_PREEMPTION_GRANULARITY.DXGI_COMPUTE_PREEMPTION_INSTRUCTION_BOUNDARY"]/*' />
    DXGI_COMPUTE_PREEMPTION_INSTRUCTION_BOUNDARY = 4,
}
