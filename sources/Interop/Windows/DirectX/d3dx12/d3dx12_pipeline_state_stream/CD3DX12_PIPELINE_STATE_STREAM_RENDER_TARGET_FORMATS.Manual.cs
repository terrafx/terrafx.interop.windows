// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3dx12_pipeline_state_stream.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license

using static TerraFX.Interop.DirectX.D3D12_PIPELINE_STATE_SUBOBJECT_TYPE;

namespace TerraFX.Interop.DirectX;

public struct CD3DX12_PIPELINE_STATE_STREAM_RENDER_TARGET_FORMATS
{
    public D3D12_PIPELINE_STATE_SUBOBJECT_TYPE pssType;

    public D3D12_RT_FORMAT_ARRAY pssInner;

    public CD3DX12_PIPELINE_STATE_STREAM_RENDER_TARGET_FORMATS()
    {
        pssType = D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_RENDER_TARGET_FORMATS;
        pssInner = default;
    }

    public CD3DX12_PIPELINE_STATE_STREAM_RENDER_TARGET_FORMATS([NativeTypeName("D3D12_RT_FORMAT_ARRAY const &")] in D3D12_RT_FORMAT_ARRAY i)
    {
        pssType = D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_RENDER_TARGET_FORMATS;
        pssInner = i;
    }

    public static implicit operator CD3DX12_PIPELINE_STATE_STREAM_RENDER_TARGET_FORMATS(in D3D12_RT_FORMAT_ARRAY value) => new CD3DX12_PIPELINE_STATE_STREAM_RENDER_TARGET_FORMATS(value);

    public static implicit operator D3D12_RT_FORMAT_ARRAY(in CD3DX12_PIPELINE_STATE_STREAM_RENDER_TARGET_FORMATS value) => value.pssInner;
}
