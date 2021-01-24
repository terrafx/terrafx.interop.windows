// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d10.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("9B7E4C05-342C-4106-A19F-4F2704F689F0")]
    [NativeTypeName("struct ID3D10Texture3D : ID3D10Resource")]
    public unsafe partial struct ID3D10Texture3D
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<ID3D10Texture3D*, Guid*, void**, int>)(lpVtbl[0]))((ID3D10Texture3D*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ID3D10Texture3D*, uint>)(lpVtbl[1]))((ID3D10Texture3D*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ID3D10Texture3D*, uint>)(lpVtbl[2]))((ID3D10Texture3D*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void GetDevice([NativeTypeName("ID3D10Device **")] ID3D10Device** ppDevice)
        {
            ((delegate* unmanaged<ID3D10Texture3D*, ID3D10Device**, void>)(lpVtbl[3]))((ID3D10Texture3D*)Unsafe.AsPointer(ref this), ppDevice);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetPrivateData([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("UINT *")] uint* pDataSize, [NativeTypeName("void *")] void* pData)
        {
            return ((delegate* unmanaged<ID3D10Texture3D*, Guid*, uint*, void*, int>)(lpVtbl[4]))((ID3D10Texture3D*)Unsafe.AsPointer(ref this), guid, pDataSize, pData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetPrivateData([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("UINT")] uint DataSize, [NativeTypeName("const void *")] void* pData)
        {
            return ((delegate* unmanaged<ID3D10Texture3D*, Guid*, uint, void*, int>)(lpVtbl[5]))((ID3D10Texture3D*)Unsafe.AsPointer(ref this), guid, DataSize, pData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetPrivateDataInterface([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("const IUnknown *")] IUnknown* pData)
        {
            return ((delegate* unmanaged<ID3D10Texture3D*, Guid*, IUnknown*, int>)(lpVtbl[6]))((ID3D10Texture3D*)Unsafe.AsPointer(ref this), guid, pData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void GetType([NativeTypeName("D3D10_RESOURCE_DIMENSION *")] D3D10_RESOURCE_DIMENSION* rType)
        {
            ((delegate* unmanaged<ID3D10Texture3D*, D3D10_RESOURCE_DIMENSION*, void>)(lpVtbl[7]))((ID3D10Texture3D*)Unsafe.AsPointer(ref this), rType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void SetEvictionPriority([NativeTypeName("UINT")] uint EvictionPriority)
        {
            ((delegate* unmanaged<ID3D10Texture3D*, uint, void>)(lpVtbl[8]))((ID3D10Texture3D*)Unsafe.AsPointer(ref this), EvictionPriority);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("UINT")]
        public uint GetEvictionPriority()
        {
            return ((delegate* unmanaged<ID3D10Texture3D*, uint>)(lpVtbl[9]))((ID3D10Texture3D*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Map([NativeTypeName("UINT")] uint Subresource, D3D10_MAP MapType, [NativeTypeName("UINT")] uint MapFlags, [NativeTypeName("D3D10_MAPPED_TEXTURE3D *")] D3D10_MAPPED_TEXTURE3D* pMappedTex3D)
        {
            return ((delegate* unmanaged<ID3D10Texture3D*, uint, D3D10_MAP, uint, D3D10_MAPPED_TEXTURE3D*, int>)(lpVtbl[10]))((ID3D10Texture3D*)Unsafe.AsPointer(ref this), Subresource, MapType, MapFlags, pMappedTex3D);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Unmap([NativeTypeName("UINT")] uint Subresource)
        {
            ((delegate* unmanaged<ID3D10Texture3D*, uint, void>)(lpVtbl[11]))((ID3D10Texture3D*)Unsafe.AsPointer(ref this), Subresource);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void GetDesc([NativeTypeName("D3D10_TEXTURE3D_DESC *")] D3D10_TEXTURE3D_DESC* pDesc)
        {
            ((delegate* unmanaged<ID3D10Texture3D*, D3D10_TEXTURE3D_DESC*, void>)(lpVtbl[12]))((ID3D10Texture3D*)Unsafe.AsPointer(ref this), pDesc);
        }
    }
}
