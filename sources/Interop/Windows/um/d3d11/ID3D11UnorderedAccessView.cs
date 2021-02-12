// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("28ACF509-7F5C-48F6-8611-F316010A6380")]
    [NativeTypeName("struct ID3D11UnorderedAccessView : ID3D11View")]
    public unsafe partial struct ID3D11UnorderedAccessView
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<ID3D11UnorderedAccessView*, Guid*, void**, int>)(lpVtbl[0]))((ID3D11UnorderedAccessView*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ID3D11UnorderedAccessView*, uint>)(lpVtbl[1]))((ID3D11UnorderedAccessView*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ID3D11UnorderedAccessView*, uint>)(lpVtbl[2]))((ID3D11UnorderedAccessView*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void GetDevice([NativeTypeName("ID3D11Device **")] ID3D11Device** ppDevice)
        {
            ((delegate* unmanaged<ID3D11UnorderedAccessView*, ID3D11Device**, void>)(lpVtbl[3]))((ID3D11UnorderedAccessView*)Unsafe.AsPointer(ref this), ppDevice);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetPrivateData([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("UINT *")] uint* pDataSize, [NativeTypeName("void *")] void* pData)
        {
            return ((delegate* unmanaged<ID3D11UnorderedAccessView*, Guid*, uint*, void*, int>)(lpVtbl[4]))((ID3D11UnorderedAccessView*)Unsafe.AsPointer(ref this), guid, pDataSize, pData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetPrivateData([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("UINT")] uint DataSize, [NativeTypeName("const void *")] void* pData)
        {
            return ((delegate* unmanaged<ID3D11UnorderedAccessView*, Guid*, uint, void*, int>)(lpVtbl[5]))((ID3D11UnorderedAccessView*)Unsafe.AsPointer(ref this), guid, DataSize, pData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetPrivateDataInterface([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("const IUnknown *")] IUnknown* pData)
        {
            return ((delegate* unmanaged<ID3D11UnorderedAccessView*, Guid*, IUnknown*, int>)(lpVtbl[6]))((ID3D11UnorderedAccessView*)Unsafe.AsPointer(ref this), guid, pData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void GetResource([NativeTypeName("ID3D11Resource **")] ID3D11Resource** ppResource)
        {
            ((delegate* unmanaged<ID3D11UnorderedAccessView*, ID3D11Resource**, void>)(lpVtbl[7]))((ID3D11UnorderedAccessView*)Unsafe.AsPointer(ref this), ppResource);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void GetDesc([NativeTypeName("D3D11_UNORDERED_ACCESS_VIEW_DESC *")] D3D11_UNORDERED_ACCESS_VIEW_DESC* pDesc)
        {
            ((delegate* unmanaged<ID3D11UnorderedAccessView*, D3D11_UNORDERED_ACCESS_VIEW_DESC*, void>)(lpVtbl[8]))((ID3D11UnorderedAccessView*)Unsafe.AsPointer(ref this), pDesc);
        }
    }
}
