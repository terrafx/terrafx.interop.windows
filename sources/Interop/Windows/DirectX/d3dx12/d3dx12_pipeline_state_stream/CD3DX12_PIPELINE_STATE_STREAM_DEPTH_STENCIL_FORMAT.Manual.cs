// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3dx12_pipeline_state_stream.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license

using static TerraFX.Interop.DirectX.D3D12_PIPELINE_STATE_SUBOBJECT_TYPE;

namespace TerraFX.Interop.DirectX;

public struct CD3DX12_PIPELINE_STATE_STREAM_DEPTH_STENCIL_FORMAT
{
    public D3D12_PIPELINE_STATE_SUBOBJECT_TYPE pssType;

    public DXGI_FORMAT pssInner;

    public CD3DX12_PIPELINE_STATE_STREAM_DEPTH_STENCIL_FORMAT()
    {
        pssType = D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_DEPTH_STENCIL_FORMAT;
        pssInner = default;
    }

    public CD3DX12_PIPELINE_STATE_STREAM_DEPTH_STENCIL_FORMAT([NativeTypeName("DXGI_FORMAT const &")] in DXGI_FORMAT i)
    {
        pssType = D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_DEPTH_STENCIL_FORMAT;
        pssInner = i;
    }

    public static implicit operator CD3DX12_PIPELINE_STATE_STREAM_DEPTH_STENCIL_FORMAT(in DXGI_FORMAT value) => new CD3DX12_PIPELINE_STATE_STREAM_DEPTH_STENCIL_FORMAT(value);

    public static implicit operator DXGI_FORMAT(in CD3DX12_PIPELINE_STATE_STREAM_DEPTH_STENCIL_FORMAT value) => value.pssInner;
}
