// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3dx12_pipeline_state_stream.h in microsoft/DirectX-Headers tag v1.611.2
// Original source is Copyright © Microsoft. Licensed under the MIT license

using static TerraFX.Interop.DirectX.D3D12_PIPELINE_STATE_SUBOBJECT_TYPE;

namespace TerraFX.Interop.DirectX;

public struct CD3DX12_PIPELINE_STATE_STREAM_DEPTH_STENCIL1
{
    public D3D12_PIPELINE_STATE_SUBOBJECT_TYPE pssType;

    public D3D12_DEPTH_STENCIL_DESC1 pssInner;

    public CD3DX12_PIPELINE_STATE_STREAM_DEPTH_STENCIL1()
    {
        pssType = D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_DEPTH_STENCIL1;
        pssInner = D3D12_DEPTH_STENCIL_DESC1.DEFAULT;
    }

    public CD3DX12_PIPELINE_STATE_STREAM_DEPTH_STENCIL1([NativeTypeName("D3D12_DEPTH_STENCIL_DESC1 const &")] in D3D12_DEPTH_STENCIL_DESC1 i)
    {
        pssType = D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_DEPTH_STENCIL1;
        pssInner = i;
    }

    public static implicit operator CD3DX12_PIPELINE_STATE_STREAM_DEPTH_STENCIL1(in D3D12_DEPTH_STENCIL_DESC1 value) => new CD3DX12_PIPELINE_STATE_STREAM_DEPTH_STENCIL1(value);

    public static implicit operator D3D12_DEPTH_STENCIL_DESC1(in CD3DX12_PIPELINE_STATE_STREAM_DEPTH_STENCIL1 value) => value.pssInner;
}
