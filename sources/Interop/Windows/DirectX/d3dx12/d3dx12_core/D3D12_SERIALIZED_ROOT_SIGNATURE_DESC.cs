// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3dx12_core.h in microsoft/DirectX-Headers tag v1.618.5
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_SERIALIZED_ROOT_SIGNATURE_DESC.xml' path='doc/member[@name="D3D12_SERIALIZED_ROOT_SIGNATURE_DESC"]/*' />
[NativeTypeName("struct CD3DX12_SERIALIZED_ROOT_SIGNATURE_DESC : D3D12_SERIALIZED_ROOT_SIGNATURE_DESC")]
[NativeInheritance("D3D12_SERIALIZED_ROOT_SIGNATURE_DESC")]
public unsafe partial struct D3D12_SERIALIZED_ROOT_SIGNATURE_DESC
{
    public D3D12_SERIALIZED_ROOT_SIGNATURE_DESC([NativeTypeName("const void *")] void* pData, [NativeTypeName("SIZE_T")] nuint size)
    {
        pSerializedBlob = pData;
        SerializedBlobSizeInBytes = size;
    }
}
