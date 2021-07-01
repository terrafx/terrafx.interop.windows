// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("28E2495D-0F64-4AE4-A6EC-129255DC49A8")]
    [NativeTypeName("struct ID3D12ShaderCacheSession : ID3D12DeviceChild")]
    public unsafe partial struct ID3D12ShaderCacheSession
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ID3D12ShaderCacheSession*, Guid*, void**, int>)(lpVtbl[0]))((ID3D12ShaderCacheSession*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ID3D12ShaderCacheSession*, uint>)(lpVtbl[1]))((ID3D12ShaderCacheSession*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ID3D12ShaderCacheSession*, uint>)(lpVtbl[2]))((ID3D12ShaderCacheSession*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetPrivateData([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("UINT *")] uint* pDataSize, void* pData)
        {
            return ((delegate* unmanaged<ID3D12ShaderCacheSession*, Guid*, uint*, void*, int>)(lpVtbl[3]))((ID3D12ShaderCacheSession*)Unsafe.AsPointer(ref this), guid, pDataSize, pData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetPrivateData([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("UINT")] uint DataSize, [NativeTypeName("const void *")] void* pData)
        {
            return ((delegate* unmanaged<ID3D12ShaderCacheSession*, Guid*, uint, void*, int>)(lpVtbl[4]))((ID3D12ShaderCacheSession*)Unsafe.AsPointer(ref this), guid, DataSize, pData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetPrivateDataInterface([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("const IUnknown *")] IUnknown* pData)
        {
            return ((delegate* unmanaged<ID3D12ShaderCacheSession*, Guid*, IUnknown*, int>)(lpVtbl[5]))((ID3D12ShaderCacheSession*)Unsafe.AsPointer(ref this), guid, pData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetName([NativeTypeName("LPCWSTR")] ushort* Name)
        {
            return ((delegate* unmanaged<ID3D12ShaderCacheSession*, ushort*, int>)(lpVtbl[6]))((ID3D12ShaderCacheSession*)Unsafe.AsPointer(ref this), Name);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetDevice([NativeTypeName("const IID &")] Guid* riid, void** ppvDevice)
        {
            return ((delegate* unmanaged<ID3D12ShaderCacheSession*, Guid*, void**, int>)(lpVtbl[7]))((ID3D12ShaderCacheSession*)Unsafe.AsPointer(ref this), riid, ppvDevice);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int FindValue([NativeTypeName("const void *")] void* pKey, [NativeTypeName("UINT")] uint KeySize, void* pValue, [NativeTypeName("UINT *")] uint* pValueSize)
        {
            return ((delegate* unmanaged<ID3D12ShaderCacheSession*, void*, uint, void*, uint*, int>)(lpVtbl[8]))((ID3D12ShaderCacheSession*)Unsafe.AsPointer(ref this), pKey, KeySize, pValue, pValueSize);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int StoreValue([NativeTypeName("const void *")] void* pKey, [NativeTypeName("UINT")] uint KeySize, [NativeTypeName("const void *")] void* pValue, [NativeTypeName("UINT")] uint ValueSize)
        {
            return ((delegate* unmanaged<ID3D12ShaderCacheSession*, void*, uint, void*, uint, int>)(lpVtbl[9]))((ID3D12ShaderCacheSession*)Unsafe.AsPointer(ref this), pKey, KeySize, pValue, ValueSize);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void SetDeleteOnDestroy()
        {
            ((delegate* unmanaged<ID3D12ShaderCacheSession*, void>)(lpVtbl[10]))((ID3D12ShaderCacheSession*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public D3D12_SHADER_CACHE_SESSION_DESC GetDesc()
        {
            D3D12_SHADER_CACHE_SESSION_DESC result;
            return *((delegate* unmanaged<ID3D12ShaderCacheSession*, D3D12_SHADER_CACHE_SESSION_DESC*, D3D12_SHADER_CACHE_SESSION_DESC*>)(lpVtbl[11]))((ID3D12ShaderCacheSession*)Unsafe.AsPointer(ref this), &result);
        }
    }
}
