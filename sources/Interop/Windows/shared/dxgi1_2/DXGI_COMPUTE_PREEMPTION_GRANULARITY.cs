// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/dxgi1_2.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum DXGI_COMPUTE_PREEMPTION_GRANULARITY
    {
        DXGI_COMPUTE_PREEMPTION_DMA_BUFFER_BOUNDARY = 0,
        DXGI_COMPUTE_PREEMPTION_DISPATCH_BOUNDARY = 1,
        DXGI_COMPUTE_PREEMPTION_THREAD_GROUP_BOUNDARY = 2,
        DXGI_COMPUTE_PREEMPTION_THREAD_BOUNDARY = 3,
        DXGI_COMPUTE_PREEMPTION_INSTRUCTION_BOUNDARY = 4,
    }
}
