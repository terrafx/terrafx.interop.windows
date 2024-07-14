// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3dx12_pipeline_state_stream.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license

using static TerraFX.Interop.DirectX.D3D12_PIPELINE_STATE_SUBOBJECT_TYPE;

namespace TerraFX.Interop.DirectX;

public struct CD3DX12_PIPELINE_STATE_STREAM_STREAM_OUTPUT
{
    public D3D12_PIPELINE_STATE_SUBOBJECT_TYPE pssType;

    public D3D12_STREAM_OUTPUT_DESC pssInner;

    public CD3DX12_PIPELINE_STATE_STREAM_STREAM_OUTPUT()
    {
        pssType = D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_STREAM_OUTPUT;
        pssInner = default;
    }

    public CD3DX12_PIPELINE_STATE_STREAM_STREAM_OUTPUT([NativeTypeName("D3D12_STREAM_OUTPUT_DESC const &")] in D3D12_STREAM_OUTPUT_DESC i)
    {
        pssType = D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_STREAM_OUTPUT;
        pssInner = i;
    }

    public static implicit operator CD3DX12_PIPELINE_STATE_STREAM_STREAM_OUTPUT(in D3D12_STREAM_OUTPUT_DESC value) => new CD3DX12_PIPELINE_STATE_STREAM_STREAM_OUTPUT(value);

    public static implicit operator D3D12_STREAM_OUTPUT_DESC(in CD3DX12_PIPELINE_STATE_STREAM_STREAM_OUTPUT value) => value.pssInner;
}
