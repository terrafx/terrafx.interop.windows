// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3dx12.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license

using static TerraFX.Interop.DirectX.D3D12_BARRIER_TYPE;

namespace TerraFX.Interop.DirectX;

public unsafe partial struct D3D12_BARRIER_GROUP
{
    public D3D12_BARRIER_GROUP([NativeTypeName("UINT32")] uint numBarriers, [NativeTypeName("const D3D12_BUFFER_BARRIER *")] D3D12_BUFFER_BARRIER* pBarriers)
    {
        Type = D3D12_BARRIER_TYPE_BUFFER;
        NumBarriers = numBarriers;
        Anonymous.pBufferBarriers = pBarriers;
    }

    public D3D12_BARRIER_GROUP([NativeTypeName("UINT32")] uint numBarriers, [NativeTypeName("const D3D12_TEXTURE_BARRIER *")] D3D12_TEXTURE_BARRIER* pBarriers)
    {
        Type = D3D12_BARRIER_TYPE_TEXTURE;
        NumBarriers = numBarriers;
        Anonymous.pTextureBarriers = pBarriers;
    }

    public D3D12_BARRIER_GROUP([NativeTypeName("UINT32")] uint numBarriers, [NativeTypeName("const D3D12_GLOBAL_BARRIER *")] D3D12_GLOBAL_BARRIER* pBarriers)
    {
        Type = D3D12_BARRIER_TYPE_GLOBAL;
        NumBarriers = numBarriers;
        Anonymous.pGlobalBarriers = pBarriers;
    }
}
