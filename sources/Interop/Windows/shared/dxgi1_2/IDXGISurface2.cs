// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/dxgi1_2.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("ABA496DD-B617-4CB8-A866-BC44D7EB1FA2")]
    [NativeTypeName("struct IDXGISurface2 : IDXGISurface1")]
    [NativeInheritance("IDXGISurface1")]
    public unsafe partial struct IDXGISurface2
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDXGISurface2*, Guid*, void**, int>)(lpVtbl[0]))((IDXGISurface2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDXGISurface2*, uint>)(lpVtbl[1]))((IDXGISurface2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDXGISurface2*, uint>)(lpVtbl[2]))((IDXGISurface2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int SetPrivateData([NativeTypeName("const GUID &")] Guid* Name, [NativeTypeName("UINT")] uint DataSize, [NativeTypeName("const void *")] void* pData)
        {
            return ((delegate* unmanaged<IDXGISurface2*, Guid*, uint, void*, int>)(lpVtbl[3]))((IDXGISurface2*)Unsafe.AsPointer(ref this), Name, DataSize, pData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int SetPrivateDataInterface([NativeTypeName("const GUID &")] Guid* Name, [NativeTypeName("const IUnknown *")] IUnknown* pUnknown)
        {
            return ((delegate* unmanaged<IDXGISurface2*, Guid*, IUnknown*, int>)(lpVtbl[4]))((IDXGISurface2*)Unsafe.AsPointer(ref this), Name, pUnknown);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int GetPrivateData([NativeTypeName("const GUID &")] Guid* Name, [NativeTypeName("UINT *")] uint* pDataSize, void* pData)
        {
            return ((delegate* unmanaged<IDXGISurface2*, Guid*, uint*, void*, int>)(lpVtbl[5]))((IDXGISurface2*)Unsafe.AsPointer(ref this), Name, pDataSize, pData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int GetParent([NativeTypeName("const IID &")] Guid* riid, void** ppParent)
        {
            return ((delegate* unmanaged<IDXGISurface2*, Guid*, void**, int>)(lpVtbl[6]))((IDXGISurface2*)Unsafe.AsPointer(ref this), riid, ppParent);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int GetDevice([NativeTypeName("const IID &")] Guid* riid, void** ppDevice)
        {
            return ((delegate* unmanaged<IDXGISurface2*, Guid*, void**, int>)(lpVtbl[7]))((IDXGISurface2*)Unsafe.AsPointer(ref this), riid, ppDevice);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int GetDesc(DXGI_SURFACE_DESC* pDesc)
        {
            return ((delegate* unmanaged<IDXGISurface2*, DXGI_SURFACE_DESC*, int>)(lpVtbl[8]))((IDXGISurface2*)Unsafe.AsPointer(ref this), pDesc);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("HRESULT")]
        public int Map(DXGI_MAPPED_RECT* pLockedRect, [NativeTypeName("UINT")] uint MapFlags)
        {
            return ((delegate* unmanaged<IDXGISurface2*, DXGI_MAPPED_RECT*, uint, int>)(lpVtbl[9]))((IDXGISurface2*)Unsafe.AsPointer(ref this), pLockedRect, MapFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        [return: NativeTypeName("HRESULT")]
        public int Unmap()
        {
            return ((delegate* unmanaged<IDXGISurface2*, int>)(lpVtbl[10]))((IDXGISurface2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        [return: NativeTypeName("HRESULT")]
        public int GetDC([NativeTypeName("BOOL")] int Discard, [NativeTypeName("HDC *")] IntPtr* phdc)
        {
            return ((delegate* unmanaged<IDXGISurface2*, int, IntPtr*, int>)(lpVtbl[11]))((IDXGISurface2*)Unsafe.AsPointer(ref this), Discard, phdc);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        [return: NativeTypeName("HRESULT")]
        public int ReleaseDC(RECT* pDirtyRect)
        {
            return ((delegate* unmanaged<IDXGISurface2*, RECT*, int>)(lpVtbl[12]))((IDXGISurface2*)Unsafe.AsPointer(ref this), pDirtyRect);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        [return: NativeTypeName("HRESULT")]
        public int GetResource([NativeTypeName("const IID &")] Guid* riid, void** ppParentResource, [NativeTypeName("UINT *")] uint* pSubresourceIndex)
        {
            return ((delegate* unmanaged<IDXGISurface2*, Guid*, void**, uint*, int>)(lpVtbl[13]))((IDXGISurface2*)Unsafe.AsPointer(ref this), riid, ppParentResource, pSubresourceIndex);
        }
    }
}
