// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3dx12_pipeline_state_stream.h in microsoft/DirectX-Headers tag v1.611.2
// Original source is Copyright © Microsoft. Licensed under the MIT license

using static TerraFX.Interop.DirectX.D3D12_PIPELINE_STATE_SUBOBJECT_TYPE;

namespace TerraFX.Interop.DirectX;

public struct CD3DX12_PIPELINE_STATE_STREAM_NODE_MASK
{
    public D3D12_PIPELINE_STATE_SUBOBJECT_TYPE pssType;

    public uint pssInner;

    public CD3DX12_PIPELINE_STATE_STREAM_NODE_MASK()
    {
        pssType = D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_NODE_MASK;
        pssInner = default;
    }

    public CD3DX12_PIPELINE_STATE_STREAM_NODE_MASK([NativeTypeName("uint const &")] in uint i)
    {
        pssType = D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_NODE_MASK;
        pssInner = i;
    }

    public static implicit operator CD3DX12_PIPELINE_STATE_STREAM_NODE_MASK(in uint value) => new CD3DX12_PIPELINE_STATE_STREAM_NODE_MASK(value);

    public static implicit operator uint(in CD3DX12_PIPELINE_STATE_STREAM_NODE_MASK value) => value.pssInner;
}
