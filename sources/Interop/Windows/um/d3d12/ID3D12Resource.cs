// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("696442BE-A72E-4059-BC79-5B5C98040FAD")]
    [NativeTypeName("struct ID3D12Resource : ID3D12Pageable")]
    public unsafe partial struct ID3D12Resource
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ID3D12Resource*, Guid*, void**, int>)(lpVtbl[0]))((ID3D12Resource*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ID3D12Resource*, uint>)(lpVtbl[1]))((ID3D12Resource*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ID3D12Resource*, uint>)(lpVtbl[2]))((ID3D12Resource*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetPrivateData([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("UINT *")] uint* pDataSize, void* pData)
        {
            return ((delegate* unmanaged<ID3D12Resource*, Guid*, uint*, void*, int>)(lpVtbl[3]))((ID3D12Resource*)Unsafe.AsPointer(ref this), guid, pDataSize, pData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetPrivateData([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("UINT")] uint DataSize, [NativeTypeName("const void *")] void* pData)
        {
            return ((delegate* unmanaged<ID3D12Resource*, Guid*, uint, void*, int>)(lpVtbl[4]))((ID3D12Resource*)Unsafe.AsPointer(ref this), guid, DataSize, pData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetPrivateDataInterface([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("const IUnknown *")] IUnknown* pData)
        {
            return ((delegate* unmanaged<ID3D12Resource*, Guid*, IUnknown*, int>)(lpVtbl[5]))((ID3D12Resource*)Unsafe.AsPointer(ref this), guid, pData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetName([NativeTypeName("LPCWSTR")] ushort* Name)
        {
            return ((delegate* unmanaged<ID3D12Resource*, ushort*, int>)(lpVtbl[6]))((ID3D12Resource*)Unsafe.AsPointer(ref this), Name);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetDevice([NativeTypeName("const IID &")] Guid* riid, void** ppvDevice)
        {
            return ((delegate* unmanaged<ID3D12Resource*, Guid*, void**, int>)(lpVtbl[7]))((ID3D12Resource*)Unsafe.AsPointer(ref this), riid, ppvDevice);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Map([NativeTypeName("UINT")] uint Subresource, [NativeTypeName("const D3D12_RANGE *")] D3D12_RANGE* pReadRange, void** ppData)
        {
            return ((delegate* unmanaged<ID3D12Resource*, uint, D3D12_RANGE*, void**, int>)(lpVtbl[8]))((ID3D12Resource*)Unsafe.AsPointer(ref this), Subresource, pReadRange, ppData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Unmap([NativeTypeName("UINT")] uint Subresource, [NativeTypeName("const D3D12_RANGE *")] D3D12_RANGE* pWrittenRange)
        {
            ((delegate* unmanaged<ID3D12Resource*, uint, D3D12_RANGE*, void>)(lpVtbl[9]))((ID3D12Resource*)Unsafe.AsPointer(ref this), Subresource, pWrittenRange);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public D3D12_RESOURCE_DESC GetDesc()
        {
            D3D12_RESOURCE_DESC result;
            return *((delegate* unmanaged<ID3D12Resource*, D3D12_RESOURCE_DESC*, D3D12_RESOURCE_DESC*>)(lpVtbl[10]))((ID3D12Resource*)Unsafe.AsPointer(ref this), &result);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("D3D12_GPU_VIRTUAL_ADDRESS")]
        public ulong GetGPUVirtualAddress()
        {
            return ((delegate* unmanaged<ID3D12Resource*, ulong>)(lpVtbl[11]))((ID3D12Resource*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int WriteToSubresource([NativeTypeName("UINT")] uint DstSubresource, [NativeTypeName("const D3D12_BOX *")] D3D12_BOX* pDstBox, [NativeTypeName("const void *")] void* pSrcData, [NativeTypeName("UINT")] uint SrcRowPitch, [NativeTypeName("UINT")] uint SrcDepthPitch)
        {
            return ((delegate* unmanaged<ID3D12Resource*, uint, D3D12_BOX*, void*, uint, uint, int>)(lpVtbl[12]))((ID3D12Resource*)Unsafe.AsPointer(ref this), DstSubresource, pDstBox, pSrcData, SrcRowPitch, SrcDepthPitch);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ReadFromSubresource(void* pDstData, [NativeTypeName("UINT")] uint DstRowPitch, [NativeTypeName("UINT")] uint DstDepthPitch, [NativeTypeName("UINT")] uint SrcSubresource, [NativeTypeName("const D3D12_BOX *")] D3D12_BOX* pSrcBox)
        {
            return ((delegate* unmanaged<ID3D12Resource*, void*, uint, uint, uint, D3D12_BOX*, int>)(lpVtbl[13]))((ID3D12Resource*)Unsafe.AsPointer(ref this), pDstData, DstRowPitch, DstDepthPitch, SrcSubresource, pSrcBox);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetHeapProperties(D3D12_HEAP_PROPERTIES* pHeapProperties, D3D12_HEAP_FLAGS* pHeapFlags)
        {
            return ((delegate* unmanaged<ID3D12Resource*, D3D12_HEAP_PROPERTIES*, D3D12_HEAP_FLAGS*, int>)(lpVtbl[14]))((ID3D12Resource*)Unsafe.AsPointer(ref this), pHeapProperties, pHeapFlags);
        }
    }
}
