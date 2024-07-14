// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3dx12_pipeline_state_stream.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license

using static TerraFX.Interop.DirectX.D3D12_PIPELINE_STATE_SUBOBJECT_TYPE;

namespace TerraFX.Interop.DirectX;

public struct CD3DX12_PIPELINE_STATE_STREAM_VS
{
    public D3D12_PIPELINE_STATE_SUBOBJECT_TYPE pssType;

    public D3D12_SHADER_BYTECODE pssInner;

    public CD3DX12_PIPELINE_STATE_STREAM_VS()
    {
        pssType = D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_VS;
        pssInner = default;
    }

    public CD3DX12_PIPELINE_STATE_STREAM_VS([NativeTypeName("D3D12_SHADER_BYTECODE const &")] in D3D12_SHADER_BYTECODE i)
    {
        pssType = D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_VS;
        pssInner = i;
    }

    public static implicit operator CD3DX12_PIPELINE_STATE_STREAM_VS(in D3D12_SHADER_BYTECODE value) => new CD3DX12_PIPELINE_STATE_STREAM_VS(value);

    public static implicit operator D3D12_SHADER_BYTECODE(in CD3DX12_PIPELINE_STATE_STREAM_VS value) => value.pssInner;
}
