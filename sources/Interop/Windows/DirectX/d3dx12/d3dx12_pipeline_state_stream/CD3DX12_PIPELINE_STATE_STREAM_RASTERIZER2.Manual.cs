// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3dx12_pipeline_state_stream.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license

using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;
using static TerraFX.Interop.DirectX.D3D12_PIPELINE_STATE_SUBOBJECT_TYPE;

namespace TerraFX.Interop.DirectX;

[StructLayout(LayoutKind.Explicit)]
public struct CD3DX12_PIPELINE_STATE_STREAM_RASTERIZER2
{
    [FieldOffset(0)]
    private readonly unsafe void* _Anonymous_e__Alignment;

    [FieldOffset(0)]
    public _Anonymous_e__Struct Anonymous;

    [UnscopedRef]
    public ref D3D12_PIPELINE_STATE_SUBOBJECT_TYPE pssType => ref Anonymous.pssType;

    [UnscopedRef]
    public ref D3D12_RASTERIZER_DESC2 pssInner => ref Anonymous.pssInner;

    public CD3DX12_PIPELINE_STATE_STREAM_RASTERIZER2()
    {
        pssType = D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_RASTERIZER2;
        pssInner = D3D12_RASTERIZER_DESC2.DEFAULT;
    }

    public CD3DX12_PIPELINE_STATE_STREAM_RASTERIZER2([NativeTypeName("D3D12_RASTERIZER_DESC2 const &")] in D3D12_RASTERIZER_DESC2 i)
    {
        pssType = D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_RASTERIZER2;
        pssInner = i;
    }

    public static implicit operator CD3DX12_PIPELINE_STATE_STREAM_RASTERIZER2(in D3D12_RASTERIZER_DESC2 value) => new CD3DX12_PIPELINE_STATE_STREAM_RASTERIZER2(value);

    public static implicit operator D3D12_RASTERIZER_DESC2(in CD3DX12_PIPELINE_STATE_STREAM_RASTERIZER2 value) => value.pssInner;

    public struct _Anonymous_e__Struct
    {
        public D3D12_PIPELINE_STATE_SUBOBJECT_TYPE pssType;

        public D3D12_RASTERIZER_DESC2 pssInner;
    }
}
