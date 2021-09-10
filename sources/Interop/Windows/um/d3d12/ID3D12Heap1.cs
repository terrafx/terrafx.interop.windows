// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("572F7389-2168-49E3-9693-D6DF5871BF6D")]
    [NativeTypeName("struct ID3D12Heap1 : ID3D12Heap")]
    [NativeInheritance("ID3D12Heap")]
    public unsafe partial struct ID3D12Heap1
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ID3D12Heap1*, Guid*, void**, int>)(lpVtbl[0]))((ID3D12Heap1*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ID3D12Heap1*, uint>)(lpVtbl[1]))((ID3D12Heap1*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ID3D12Heap1*, uint>)(lpVtbl[2]))((ID3D12Heap1*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int GetPrivateData([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("UINT *")] uint* pDataSize, void* pData)
        {
            return ((delegate* unmanaged<ID3D12Heap1*, Guid*, uint*, void*, int>)(lpVtbl[3]))((ID3D12Heap1*)Unsafe.AsPointer(ref this), guid, pDataSize, pData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int SetPrivateData([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("UINT")] uint DataSize, [NativeTypeName("const void *")] void* pData)
        {
            return ((delegate* unmanaged<ID3D12Heap1*, Guid*, uint, void*, int>)(lpVtbl[4]))((ID3D12Heap1*)Unsafe.AsPointer(ref this), guid, DataSize, pData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int SetPrivateDataInterface([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("const IUnknown *")] IUnknown* pData)
        {
            return ((delegate* unmanaged<ID3D12Heap1*, Guid*, IUnknown*, int>)(lpVtbl[5]))((ID3D12Heap1*)Unsafe.AsPointer(ref this), guid, pData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int SetName([NativeTypeName("LPCWSTR")] ushort* Name)
        {
            return ((delegate* unmanaged<ID3D12Heap1*, ushort*, int>)(lpVtbl[6]))((ID3D12Heap1*)Unsafe.AsPointer(ref this), Name);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int GetDevice([NativeTypeName("const IID &")] Guid* riid, void** ppvDevice)
        {
            return ((delegate* unmanaged<ID3D12Heap1*, Guid*, void**, int>)(lpVtbl[7]))((ID3D12Heap1*)Unsafe.AsPointer(ref this), riid, ppvDevice);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public D3D12_HEAP_DESC GetDesc()
        {
            D3D12_HEAP_DESC result;
            return *((delegate* unmanaged<ID3D12Heap1*, D3D12_HEAP_DESC*, D3D12_HEAP_DESC*>)(lpVtbl[8]))((ID3D12Heap1*)Unsafe.AsPointer(ref this), &result);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("HRESULT")]
        public int GetProtectedResourceSession([NativeTypeName("const IID &")] Guid* riid, void** ppProtectedSession)
        {
            return ((delegate* unmanaged<ID3D12Heap1*, Guid*, void**, int>)(lpVtbl[9]))((ID3D12Heap1*)Unsafe.AsPointer(ref this), riid, ppProtectedSession);
        }
    }
}
