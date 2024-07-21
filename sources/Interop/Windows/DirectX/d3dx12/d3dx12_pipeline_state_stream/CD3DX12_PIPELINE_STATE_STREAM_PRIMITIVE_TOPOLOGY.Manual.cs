// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3dx12_pipeline_state_stream.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license

using static TerraFX.Interop.DirectX.D3D12_PIPELINE_STATE_SUBOBJECT_TYPE;

namespace TerraFX.Interop.DirectX;

public struct CD3DX12_PIPELINE_STATE_STREAM_PRIMITIVE_TOPOLOGY
{
    public D3D12_PIPELINE_STATE_SUBOBJECT_TYPE pssType;

    public D3D12_PRIMITIVE_TOPOLOGY_TYPE pssInner;

    public CD3DX12_PIPELINE_STATE_STREAM_PRIMITIVE_TOPOLOGY()
    {
        pssType = D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_PRIMITIVE_TOPOLOGY;
        pssInner = default;
    }

    public CD3DX12_PIPELINE_STATE_STREAM_PRIMITIVE_TOPOLOGY([NativeTypeName("D3D12_PRIMITIVE_TOPOLOGY_TYPE const &")] in D3D12_PRIMITIVE_TOPOLOGY_TYPE i)
    {
        pssType = D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_PRIMITIVE_TOPOLOGY;
        pssInner = i;
    }

    public static implicit operator CD3DX12_PIPELINE_STATE_STREAM_PRIMITIVE_TOPOLOGY(in D3D12_PRIMITIVE_TOPOLOGY_TYPE value) => new CD3DX12_PIPELINE_STATE_STREAM_PRIMITIVE_TOPOLOGY(value);

    public static implicit operator D3D12_PRIMITIVE_TOPOLOGY_TYPE(in CD3DX12_PIPELINE_STATE_STREAM_PRIMITIVE_TOPOLOGY value) => value.pssInner;
}
