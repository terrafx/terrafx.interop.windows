// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11sdklayers.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("79CF2233-7536-4948-9D36-1E4692DC5760")]
    [NativeTypeName("struct ID3D11Debug : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct ID3D11Debug
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ID3D11Debug*, Guid*, void**, int>)(lpVtbl[0]))((ID3D11Debug*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ID3D11Debug*, uint>)(lpVtbl[1]))((ID3D11Debug*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ID3D11Debug*, uint>)(lpVtbl[2]))((ID3D11Debug*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT SetFeatureMask([NativeTypeName("UINT")] uint Mask)
        {
            return ((delegate* unmanaged<ID3D11Debug*, uint, int>)(lpVtbl[3]))((ID3D11Debug*)Unsafe.AsPointer(ref this), Mask);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("UINT")]
        public uint GetFeatureMask()
        {
            return ((delegate* unmanaged<ID3D11Debug*, uint>)(lpVtbl[4]))((ID3D11Debug*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT SetPresentPerRenderOpDelay([NativeTypeName("UINT")] uint Milliseconds)
        {
            return ((delegate* unmanaged<ID3D11Debug*, uint, int>)(lpVtbl[5]))((ID3D11Debug*)Unsafe.AsPointer(ref this), Milliseconds);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("UINT")]
        public uint GetPresentPerRenderOpDelay()
        {
            return ((delegate* unmanaged<ID3D11Debug*, uint>)(lpVtbl[6]))((ID3D11Debug*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT SetSwapChain(IDXGISwapChain* pSwapChain)
        {
            return ((delegate* unmanaged<ID3D11Debug*, IDXGISwapChain*, int>)(lpVtbl[7]))((ID3D11Debug*)Unsafe.AsPointer(ref this), pSwapChain);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT GetSwapChain(IDXGISwapChain** ppSwapChain)
        {
            return ((delegate* unmanaged<ID3D11Debug*, IDXGISwapChain**, int>)(lpVtbl[8]))((ID3D11Debug*)Unsafe.AsPointer(ref this), ppSwapChain);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT ValidateContext(ID3D11DeviceContext* pContext)
        {
            return ((delegate* unmanaged<ID3D11Debug*, ID3D11DeviceContext*, int>)(lpVtbl[9]))((ID3D11Debug*)Unsafe.AsPointer(ref this), pContext);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT ReportLiveDeviceObjects(D3D11_RLDO_FLAGS Flags)
        {
            return ((delegate* unmanaged<ID3D11Debug*, D3D11_RLDO_FLAGS, int>)(lpVtbl[10]))((ID3D11Debug*)Unsafe.AsPointer(ref this), Flags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT ValidateContextForDispatch(ID3D11DeviceContext* pContext)
        {
            return ((delegate* unmanaged<ID3D11Debug*, ID3D11DeviceContext*, int>)(lpVtbl[11]))((ID3D11Debug*)Unsafe.AsPointer(ref this), pContext);
        }
    }
}
