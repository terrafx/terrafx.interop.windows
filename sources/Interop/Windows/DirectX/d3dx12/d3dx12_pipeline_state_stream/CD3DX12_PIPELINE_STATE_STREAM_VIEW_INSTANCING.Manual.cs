// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3dx12_pipeline_state_stream.h in microsoft/DirectX-Headers tag v1.611.2
// Original source is Copyright © Microsoft. Licensed under the MIT license

using static TerraFX.Interop.DirectX.D3D12_PIPELINE_STATE_SUBOBJECT_TYPE;

namespace TerraFX.Interop.DirectX;

public struct CD3DX12_PIPELINE_STATE_STREAM_VIEW_INSTANCING
{
    public D3D12_PIPELINE_STATE_SUBOBJECT_TYPE pssType;

    public D3D12_VIEW_INSTANCING_DESC pssInner;

    public CD3DX12_PIPELINE_STATE_STREAM_VIEW_INSTANCING()
    {
        pssType = D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_VIEW_INSTANCING;
        pssInner = D3D12_VIEW_INSTANCING_DESC.DEFAULT;
    }

    public CD3DX12_PIPELINE_STATE_STREAM_VIEW_INSTANCING([NativeTypeName("D3D12_VIEW_INSTANCING_DESC const &")] in D3D12_VIEW_INSTANCING_DESC i)
    {
        pssType = D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_VIEW_INSTANCING;
        pssInner = i;
    }

    public static implicit operator CD3DX12_PIPELINE_STATE_STREAM_VIEW_INSTANCING(in D3D12_VIEW_INSTANCING_DESC value) => new CD3DX12_PIPELINE_STATE_STREAM_VIEW_INSTANCING(value);

    public static implicit operator D3D12_VIEW_INSTANCING_DESC(in CD3DX12_PIPELINE_STATE_STREAM_VIEW_INSTANCING value) => value.pssInner;
}
