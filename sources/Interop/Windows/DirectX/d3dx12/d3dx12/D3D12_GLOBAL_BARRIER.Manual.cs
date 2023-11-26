// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3dx12.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace TerraFX.Interop.DirectX;

public unsafe partial struct D3D12_GLOBAL_BARRIER
{
    public D3D12_GLOBAL_BARRIER(D3D12_BARRIER_SYNC syncBefore, D3D12_BARRIER_SYNC syncAfter, D3D12_BARRIER_ACCESS accessBefore, D3D12_BARRIER_ACCESS accessAfter)
    {
        SyncBefore = syncBefore;
        SyncAfter = syncAfter;
        AccessBefore = accessBefore;
        AccessAfter = accessAfter;
    }
}
