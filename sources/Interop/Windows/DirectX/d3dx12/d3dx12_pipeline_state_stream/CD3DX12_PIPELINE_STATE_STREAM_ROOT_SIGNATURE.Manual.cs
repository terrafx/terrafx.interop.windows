// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3dx12_pipeline_state_stream.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license

using static TerraFX.Interop.DirectX.D3D12_PIPELINE_STATE_SUBOBJECT_TYPE;

namespace TerraFX.Interop.DirectX;

public unsafe struct CD3DX12_PIPELINE_STATE_STREAM_ROOT_SIGNATURE
{
    public D3D12_PIPELINE_STATE_SUBOBJECT_TYPE pssType;

    public ID3D12RootSignature* pssInner;

    public CD3DX12_PIPELINE_STATE_STREAM_ROOT_SIGNATURE()
    {
        pssType = D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_ROOT_SIGNATURE;
        pssInner = default;
    }

    public CD3DX12_PIPELINE_STATE_STREAM_ROOT_SIGNATURE([NativeTypeName("ID3D12RootSignature* const &")] in ID3D12RootSignature* i)
    {
        pssType = D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_ROOT_SIGNATURE;
        pssInner = i;
    }

    public static implicit operator CD3DX12_PIPELINE_STATE_STREAM_ROOT_SIGNATURE(in ID3D12RootSignature* value) => new CD3DX12_PIPELINE_STATE_STREAM_ROOT_SIGNATURE(value);

    public static implicit operator ID3D12RootSignature*(in CD3DX12_PIPELINE_STATE_STREAM_ROOT_SIGNATURE value) => value.pssInner;
}
