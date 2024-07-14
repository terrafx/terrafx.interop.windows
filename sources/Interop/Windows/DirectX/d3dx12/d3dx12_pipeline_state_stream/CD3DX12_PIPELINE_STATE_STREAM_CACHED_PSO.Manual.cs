// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3dx12_pipeline_state_stream.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license

using static TerraFX.Interop.DirectX.D3D12_PIPELINE_STATE_SUBOBJECT_TYPE;

namespace TerraFX.Interop.DirectX;

public struct CD3DX12_PIPELINE_STATE_STREAM_CACHED_PSO
{
    public D3D12_PIPELINE_STATE_SUBOBJECT_TYPE pssType;

    public D3D12_CACHED_PIPELINE_STATE pssInner;

    public CD3DX12_PIPELINE_STATE_STREAM_CACHED_PSO()
    {
        pssType = D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_CACHED_PSO;
        pssInner = default;
    }

    public CD3DX12_PIPELINE_STATE_STREAM_CACHED_PSO([NativeTypeName("D3D12_CACHED_PIPELINE_STATE const &")] in D3D12_CACHED_PIPELINE_STATE i)
    {
        pssType = D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_CACHED_PSO;
        pssInner = i;
    }

    public static implicit operator CD3DX12_PIPELINE_STATE_STREAM_CACHED_PSO(in D3D12_CACHED_PIPELINE_STATE value) => new CD3DX12_PIPELINE_STATE_STREAM_CACHED_PSO(value);

    public static implicit operator D3D12_CACHED_PIPELINE_STATE(in CD3DX12_PIPELINE_STATE_STREAM_CACHED_PSO value) => value.pssInner;
}
