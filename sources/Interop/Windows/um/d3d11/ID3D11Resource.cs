// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("DC8E63F3-D12B-4952-B47B-5E45026A862D")]
    [NativeTypeName("struct ID3D11Resource : ID3D11DeviceChild")]
    public unsafe partial struct ID3D11Resource
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<ID3D11Resource*, Guid*, void**, int>)(lpVtbl[0]))((ID3D11Resource*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<ID3D11Resource*, uint>)(lpVtbl[1]))((ID3D11Resource*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<ID3D11Resource*, uint>)(lpVtbl[2]))((ID3D11Resource*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void GetDevice([NativeTypeName("ID3D11Device **")] ID3D11Device** ppDevice)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11Resource*, ID3D11Device**, void>)(lpVtbl[3]))((ID3D11Resource*)Unsafe.AsPointer(ref this), ppDevice);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetPrivateData([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("UINT *")] uint* pDataSize, [NativeTypeName("void *")] void* pData)
        {
            return ((delegate* unmanaged[Stdcall]<ID3D11Resource*, Guid*, uint*, void*, int>)(lpVtbl[4]))((ID3D11Resource*)Unsafe.AsPointer(ref this), guid, pDataSize, pData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetPrivateData([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("UINT")] uint DataSize, [NativeTypeName("const void *")] void* pData)
        {
            return ((delegate* unmanaged[Stdcall]<ID3D11Resource*, Guid*, uint, void*, int>)(lpVtbl[5]))((ID3D11Resource*)Unsafe.AsPointer(ref this), guid, DataSize, pData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetPrivateDataInterface([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("const IUnknown *")] IUnknown* pData)
        {
            return ((delegate* unmanaged[Stdcall]<ID3D11Resource*, Guid*, IUnknown*, int>)(lpVtbl[6]))((ID3D11Resource*)Unsafe.AsPointer(ref this), guid, pData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void GetType([NativeTypeName("D3D11_RESOURCE_DIMENSION *")] D3D11_RESOURCE_DIMENSION* pResourceDimension)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11Resource*, D3D11_RESOURCE_DIMENSION*, void>)(lpVtbl[7]))((ID3D11Resource*)Unsafe.AsPointer(ref this), pResourceDimension);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void SetEvictionPriority([NativeTypeName("UINT")] uint EvictionPriority)
        {
            ((delegate* unmanaged[Stdcall]<ID3D11Resource*, uint, void>)(lpVtbl[8]))((ID3D11Resource*)Unsafe.AsPointer(ref this), EvictionPriority);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("UINT")]
        public uint GetEvictionPriority()
        {
            return ((delegate* unmanaged[Stdcall]<ID3D11Resource*, uint>)(lpVtbl[9]))((ID3D11Resource*)Unsafe.AsPointer(ref this));
        }
    }
}
