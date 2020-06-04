// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11_3.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("51218251-1E33-4617-9CCB-4D3A4367E7BB")]
    public unsafe partial struct ID3D11Texture2D1
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<ID3D11Texture2D1*, Guid*, void**, int>)(lpVtbl[0]))((ID3D11Texture2D1*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<ID3D11Texture2D1*, uint>)(lpVtbl[1]))((ID3D11Texture2D1*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<ID3D11Texture2D1*, uint>)(lpVtbl[2]))((ID3D11Texture2D1*)Unsafe.AsPointer(ref this));
        }

        public void GetDevice([NativeTypeName("ID3D11Device **")] ID3D11Device** ppDevice)
        {
            ((delegate* stdcall<ID3D11Texture2D1*, ID3D11Device**, void>)(lpVtbl[3]))((ID3D11Texture2D1*)Unsafe.AsPointer(ref this), ppDevice);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPrivateData([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("UINT *")] uint* pDataSize, [NativeTypeName("void *")] void* pData)
        {
            return ((delegate* stdcall<ID3D11Texture2D1*, Guid*, uint*, void*, int>)(lpVtbl[4]))((ID3D11Texture2D1*)Unsafe.AsPointer(ref this), guid, pDataSize, pData);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPrivateData([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("UINT")] uint DataSize, [NativeTypeName("const void *")] void* pData)
        {
            return ((delegate* stdcall<ID3D11Texture2D1*, Guid*, uint, void*, int>)(lpVtbl[5]))((ID3D11Texture2D1*)Unsafe.AsPointer(ref this), guid, DataSize, pData);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPrivateDataInterface([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("const IUnknown *")] IUnknown* pData)
        {
            return ((delegate* stdcall<ID3D11Texture2D1*, Guid*, IUnknown*, int>)(lpVtbl[6]))((ID3D11Texture2D1*)Unsafe.AsPointer(ref this), guid, pData);
        }

        public void GetType([NativeTypeName("D3D11_RESOURCE_DIMENSION *")] D3D11_RESOURCE_DIMENSION* pResourceDimension)
        {
            ((delegate* stdcall<ID3D11Texture2D1*, D3D11_RESOURCE_DIMENSION*, void>)(lpVtbl[7]))((ID3D11Texture2D1*)Unsafe.AsPointer(ref this), pResourceDimension);
        }

        public void SetEvictionPriority([NativeTypeName("UINT")] uint EvictionPriority)
        {
            ((delegate* stdcall<ID3D11Texture2D1*, uint, void>)(lpVtbl[8]))((ID3D11Texture2D1*)Unsafe.AsPointer(ref this), EvictionPriority);
        }

        [return: NativeTypeName("UINT")]
        public uint GetEvictionPriority()
        {
            return ((delegate* stdcall<ID3D11Texture2D1*, uint>)(lpVtbl[9]))((ID3D11Texture2D1*)Unsafe.AsPointer(ref this));
        }

        public void GetDesc([NativeTypeName("D3D11_TEXTURE2D_DESC *")] D3D11_TEXTURE2D_DESC* pDesc)
        {
            ((delegate* stdcall<ID3D11Texture2D1*, D3D11_TEXTURE2D_DESC*, void>)(lpVtbl[10]))((ID3D11Texture2D1*)Unsafe.AsPointer(ref this), pDesc);
        }

        public void GetDesc1([NativeTypeName("D3D11_TEXTURE2D_DESC1 *")] D3D11_TEXTURE2D_DESC1* pDesc)
        {
            ((delegate* stdcall<ID3D11Texture2D1*, D3D11_TEXTURE2D_DESC1*, void>)(lpVtbl[11]))((ID3D11Texture2D1*)Unsafe.AsPointer(ref this), pDesc);
        }
    }
}
