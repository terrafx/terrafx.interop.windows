// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3dx12_pipeline_state_stream.h in microsoft/DirectX-Headers tag v1.611.2
// Original source is Copyright © Microsoft. Licensed under the MIT license

using static TerraFX.Interop.DirectX.D3D12_PIPELINE_STATE_SUBOBJECT_TYPE;

namespace TerraFX.Interop.DirectX;

public struct CD3DX12_PIPELINE_STATE_STREAM_RASTERIZER
{
    public D3D12_PIPELINE_STATE_SUBOBJECT_TYPE pssType;

    public D3D12_RASTERIZER_DESC pssInner;

    public CD3DX12_PIPELINE_STATE_STREAM_RASTERIZER()
    {
        pssType = D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_RASTERIZER;
        pssInner = D3D12_RASTERIZER_DESC.DEFAULT;
    }

    public CD3DX12_PIPELINE_STATE_STREAM_RASTERIZER([NativeTypeName("D3D12_RASTERIZER_DESC const &")] in D3D12_RASTERIZER_DESC i)
    {
        pssType = D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_RASTERIZER;
        pssInner = i;
    }

    public static implicit operator CD3DX12_PIPELINE_STATE_STREAM_RASTERIZER(in D3D12_RASTERIZER_DESC value) => new CD3DX12_PIPELINE_STATE_STREAM_RASTERIZER(value);

    public static implicit operator D3D12_RASTERIZER_DESC(in CD3DX12_PIPELINE_STATE_STREAM_RASTERIZER value) => value.pssInner;
}
