// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3dx12_pipeline_state_stream.h in microsoft/DirectX-Headers tag v1.611.2
// Original source is Copyright © Microsoft. Licensed under the MIT license

using static TerraFX.Interop.DirectX.D3D12_PIPELINE_STATE_SUBOBJECT_TYPE;

namespace TerraFX.Interop.DirectX;

public struct CD3DX12_PIPELINE_STATE_STREAM_SAMPLE_DESC
{
    public D3D12_PIPELINE_STATE_SUBOBJECT_TYPE pssType;

    public DXGI_SAMPLE_DESC pssInner;

    public CD3DX12_PIPELINE_STATE_STREAM_SAMPLE_DESC()
    {
        pssType = D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_SAMPLE_DESC;
        pssInner = new DXGI_SAMPLE_DESC(1, 0);
    }

    public CD3DX12_PIPELINE_STATE_STREAM_SAMPLE_DESC([NativeTypeName("DXGI_SAMPLE_DESC const &")] in DXGI_SAMPLE_DESC i)
    {
        pssType = D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_SAMPLE_DESC;
        pssInner = i;
    }

    public static implicit operator CD3DX12_PIPELINE_STATE_STREAM_SAMPLE_DESC(in DXGI_SAMPLE_DESC value) => new CD3DX12_PIPELINE_STATE_STREAM_SAMPLE_DESC(value);

    public static implicit operator DXGI_SAMPLE_DESC(in CD3DX12_PIPELINE_STATE_STREAM_SAMPLE_DESC value) => value.pssInner;
}
