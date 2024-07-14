// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3dx12_pipeline_state_stream.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license

using static TerraFX.Interop.DirectX.D3D12_PIPELINE_STATE_SUBOBJECT_TYPE;

namespace TerraFX.Interop.DirectX;

public struct CD3DX12_PIPELINE_STATE_STREAM_MS
{
    public D3D12_PIPELINE_STATE_SUBOBJECT_TYPE pssType;

    public D3D12_SHADER_BYTECODE pssInner;

    public CD3DX12_PIPELINE_STATE_STREAM_MS()
    {
        pssType = D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_MS;
        pssInner = default;
    }

    public CD3DX12_PIPELINE_STATE_STREAM_MS([NativeTypeName("D3D12_SHADER_BYTECODE const &")] in D3D12_SHADER_BYTECODE i)
    {
        pssType = D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_MS;
        pssInner = i;
    }

    public static implicit operator CD3DX12_PIPELINE_STATE_STREAM_MS(in D3D12_SHADER_BYTECODE value) => new CD3DX12_PIPELINE_STATE_STREAM_MS(value);

    public static implicit operator D3D12_SHADER_BYTECODE(in CD3DX12_PIPELINE_STATE_STREAM_MS value) => value.pssInner;
}
