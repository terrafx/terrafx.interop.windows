// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3dx12_pipeline_state_stream.h in microsoft/DirectX-Headers tag v1.618.2
// Original source is Copyright © Microsoft. Licensed under the MIT license

using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;
using static TerraFX.Interop.DirectX.D3D12_PIPELINE_STATE_SUBOBJECT_TYPE;

namespace TerraFX.Interop.DirectX;

[StructLayout(LayoutKind.Explicit)]
public struct CD3DX12_PIPELINE_STATE_STREAM_SERIALIZED_ROOT_SIGNATURE
{
    [FieldOffset(0)]
    private readonly unsafe void* _Anonymous_e__Alignment;

    [FieldOffset(0)]
    public _Anonymous_e__Struct Anonymous;

    [UnscopedRef]
    public ref D3D12_PIPELINE_STATE_SUBOBJECT_TYPE pssType => ref Anonymous.pssType;

    [UnscopedRef]
    public ref D3D12_SERIALIZED_ROOT_SIGNATURE_DESC pssInner => ref Anonymous.pssInner;

    public CD3DX12_PIPELINE_STATE_STREAM_SERIALIZED_ROOT_SIGNATURE()
    {
        pssType = D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_SERIALIZED_ROOT_SIGNATURE;
        pssInner = D3D12_SERIALIZED_ROOT_SIGNATURE_DESC.DEFAULT;
    }

    public CD3DX12_PIPELINE_STATE_STREAM_SERIALIZED_ROOT_SIGNATURE([NativeTypeName("D3D12_SERIALIZED_ROOT_SIGNATURE_DESC const &")] in D3D12_SERIALIZED_ROOT_SIGNATURE_DESC i)
    {
        pssType = D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_SERIALIZED_ROOT_SIGNATURE;
        pssInner = i;
    }

    public static implicit operator CD3DX12_PIPELINE_STATE_STREAM_SERIALIZED_ROOT_SIGNATURE(in D3D12_SERIALIZED_ROOT_SIGNATURE_DESC value) => new CD3DX12_PIPELINE_STATE_STREAM_SERIALIZED_ROOT_SIGNATURE(value);

    public static implicit operator D3D12_SERIALIZED_ROOT_SIGNATURE_DESC(in CD3DX12_PIPELINE_STATE_STREAM_SERIALIZED_ROOT_SIGNATURE value) => value.pssInner;

    public struct _Anonymous_e__Struct
    {
        public D3D12_PIPELINE_STATE_SUBOBJECT_TYPE pssType;

        public D3D12_SERIALIZED_ROOT_SIGNATURE_DESC pssInner;
    }
}
