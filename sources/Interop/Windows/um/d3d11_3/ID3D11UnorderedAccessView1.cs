// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11_3.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("7B3B6153-A886-4544-AB37-6537C8500403")]
    [NativeTypeName("struct ID3D11UnorderedAccessView1 : ID3D11UnorderedAccessView")]
    public unsafe partial struct ID3D11UnorderedAccessView1
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ID3D11UnorderedAccessView1*, Guid*, void**, int>)(lpVtbl[0]))((ID3D11UnorderedAccessView1*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ID3D11UnorderedAccessView1*, uint>)(lpVtbl[1]))((ID3D11UnorderedAccessView1*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ID3D11UnorderedAccessView1*, uint>)(lpVtbl[2]))((ID3D11UnorderedAccessView1*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void GetDevice(ID3D11Device** ppDevice)
        {
            ((delegate* unmanaged<ID3D11UnorderedAccessView1*, ID3D11Device**, void>)(lpVtbl[3]))((ID3D11UnorderedAccessView1*)Unsafe.AsPointer(ref this), ppDevice);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetPrivateData([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("UINT *")] uint* pDataSize, void* pData)
        {
            return ((delegate* unmanaged<ID3D11UnorderedAccessView1*, Guid*, uint*, void*, int>)(lpVtbl[4]))((ID3D11UnorderedAccessView1*)Unsafe.AsPointer(ref this), guid, pDataSize, pData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetPrivateData([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("UINT")] uint DataSize, [NativeTypeName("const void *")] void* pData)
        {
            return ((delegate* unmanaged<ID3D11UnorderedAccessView1*, Guid*, uint, void*, int>)(lpVtbl[5]))((ID3D11UnorderedAccessView1*)Unsafe.AsPointer(ref this), guid, DataSize, pData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetPrivateDataInterface([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("const IUnknown *")] IUnknown* pData)
        {
            return ((delegate* unmanaged<ID3D11UnorderedAccessView1*, Guid*, IUnknown*, int>)(lpVtbl[6]))((ID3D11UnorderedAccessView1*)Unsafe.AsPointer(ref this), guid, pData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void GetResource(ID3D11Resource** ppResource)
        {
            ((delegate* unmanaged<ID3D11UnorderedAccessView1*, ID3D11Resource**, void>)(lpVtbl[7]))((ID3D11UnorderedAccessView1*)Unsafe.AsPointer(ref this), ppResource);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void GetDesc(D3D11_UNORDERED_ACCESS_VIEW_DESC* pDesc)
        {
            ((delegate* unmanaged<ID3D11UnorderedAccessView1*, D3D11_UNORDERED_ACCESS_VIEW_DESC*, void>)(lpVtbl[8]))((ID3D11UnorderedAccessView1*)Unsafe.AsPointer(ref this), pDesc);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void GetDesc1(D3D11_UNORDERED_ACCESS_VIEW_DESC1* pDesc1)
        {
            ((delegate* unmanaged<ID3D11UnorderedAccessView1*, D3D11_UNORDERED_ACCESS_VIEW_DESC1*, void>)(lpVtbl[9]))((ID3D11UnorderedAccessView1*)Unsafe.AsPointer(ref this), pDesc1);
        }
    }
}
