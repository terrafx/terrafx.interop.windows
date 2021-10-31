// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/dxgi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("4AE63092-6327-4C1B-80AE-BFE12EA32B86")]
    [NativeTypeName("struct IDXGISurface1 : IDXGISurface")]
    [NativeInheritance("IDXGISurface")]
    public unsafe partial struct IDXGISurface1
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDXGISurface1*, Guid*, void**, int>)(lpVtbl[0]))((IDXGISurface1*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDXGISurface1*, uint>)(lpVtbl[1]))((IDXGISurface1*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDXGISurface1*, uint>)(lpVtbl[2]))((IDXGISurface1*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int SetPrivateData([NativeTypeName("const GUID &")] Guid* Name, [NativeTypeName("UINT")] uint DataSize, [NativeTypeName("const void *")] void* pData)
        {
            return ((delegate* unmanaged<IDXGISurface1*, Guid*, uint, void*, int>)(lpVtbl[3]))((IDXGISurface1*)Unsafe.AsPointer(ref this), Name, DataSize, pData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int SetPrivateDataInterface([NativeTypeName("const GUID &")] Guid* Name, [NativeTypeName("const IUnknown *")] IUnknown* pUnknown)
        {
            return ((delegate* unmanaged<IDXGISurface1*, Guid*, IUnknown*, int>)(lpVtbl[4]))((IDXGISurface1*)Unsafe.AsPointer(ref this), Name, pUnknown);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int GetPrivateData([NativeTypeName("const GUID &")] Guid* Name, [NativeTypeName("UINT *")] uint* pDataSize, void* pData)
        {
            return ((delegate* unmanaged<IDXGISurface1*, Guid*, uint*, void*, int>)(lpVtbl[5]))((IDXGISurface1*)Unsafe.AsPointer(ref this), Name, pDataSize, pData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int GetParent([NativeTypeName("const IID &")] Guid* riid, void** ppParent)
        {
            return ((delegate* unmanaged<IDXGISurface1*, Guid*, void**, int>)(lpVtbl[6]))((IDXGISurface1*)Unsafe.AsPointer(ref this), riid, ppParent);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int GetDevice([NativeTypeName("const IID &")] Guid* riid, void** ppDevice)
        {
            return ((delegate* unmanaged<IDXGISurface1*, Guid*, void**, int>)(lpVtbl[7]))((IDXGISurface1*)Unsafe.AsPointer(ref this), riid, ppDevice);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int GetDesc(DXGI_SURFACE_DESC* pDesc)
        {
            return ((delegate* unmanaged<IDXGISurface1*, DXGI_SURFACE_DESC*, int>)(lpVtbl[8]))((IDXGISurface1*)Unsafe.AsPointer(ref this), pDesc);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("HRESULT")]
        public int Map(DXGI_MAPPED_RECT* pLockedRect, [NativeTypeName("UINT")] uint MapFlags)
        {
            return ((delegate* unmanaged<IDXGISurface1*, DXGI_MAPPED_RECT*, uint, int>)(lpVtbl[9]))((IDXGISurface1*)Unsafe.AsPointer(ref this), pLockedRect, MapFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        [return: NativeTypeName("HRESULT")]
        public int Unmap()
        {
            return ((delegate* unmanaged<IDXGISurface1*, int>)(lpVtbl[10]))((IDXGISurface1*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        [return: NativeTypeName("HRESULT")]
        public int GetDC(BOOL Discard, [NativeTypeName("HDC *")] IntPtr* phdc)
        {
            return ((delegate* unmanaged<IDXGISurface1*, BOOL, IntPtr*, int>)(lpVtbl[11]))((IDXGISurface1*)Unsafe.AsPointer(ref this), Discard, phdc);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        [return: NativeTypeName("HRESULT")]
        public int ReleaseDC(RECT* pDirtyRect)
        {
            return ((delegate* unmanaged<IDXGISurface1*, RECT*, int>)(lpVtbl[12]))((IDXGISurface1*)Unsafe.AsPointer(ref this), pDirtyRect);
        }
    }
}
