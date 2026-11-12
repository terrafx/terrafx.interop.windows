// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;
using static TerraFX.Interop.DirectX.D3D12_PIPELINE_STATE_SUBOBJECT_TYPE;

namespace TerraFX.Interop.DirectX;

[StructLayout(LayoutKind.Explicit)]
public unsafe struct CD3DX12_PIPELINE_STATE_STREAM_PSDB
{
    [FieldOffset(0)]
    private readonly void* _Anonymous_e__Alignment;

    [FieldOffset(0)]
    public _Anonymous_e__Struct Anonymous;

    [UnscopedRef]
    public ref D3D12_PIPELINE_STATE_SUBOBJECT_TYPE pssType => ref Anonymous.pssType;

    [UnscopedRef]
    public ref D3D12_SHADER_CACHE_SESSION_SUBOBJECT_DESC pssInner => ref Anonymous.pssInner;

    public CD3DX12_PIPELINE_STATE_STREAM_PSDB()
    {
        pssType = D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_PSDB;
        pssInner = default;
    }

    public CD3DX12_PIPELINE_STATE_STREAM_PSDB([NativeTypeName("D3D12_SHADER_CACHE_SESSION_SUBOBJECT_DESC const &")] in D3D12_SHADER_CACHE_SESSION_SUBOBJECT_DESC value)
    {
        pssType = D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_PSDB;
        pssInner = value;
    }

    public static implicit operator CD3DX12_PIPELINE_STATE_STREAM_PSDB(in D3D12_SHADER_CACHE_SESSION_SUBOBJECT_DESC value) => new CD3DX12_PIPELINE_STATE_STREAM_PSDB(value);

    public static implicit operator D3D12_SHADER_CACHE_SESSION_SUBOBJECT_DESC(in CD3DX12_PIPELINE_STATE_STREAM_PSDB value) => value.pssInner;

    public struct _Anonymous_e__Struct
    {
        public D3D12_PIPELINE_STATE_SUBOBJECT_TYPE pssType;

        public D3D12_SHADER_CACHE_SESSION_SUBOBJECT_DESC pssInner;
    }
}
