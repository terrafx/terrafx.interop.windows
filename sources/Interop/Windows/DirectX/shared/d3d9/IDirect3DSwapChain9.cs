// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/d3d9.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.DirectX;

/// <include file='IDirect3DSwapChain9.xml' path='doc/member[@name="IDirect3DSwapChain9"]/*' />
[Guid("794950F2-ADFC-458A-905E-10A10B0B503B")]
[NativeTypeName("struct IDirect3DSwapChain9 : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IDirect3DSwapChain9 : IDirect3DSwapChain9.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IDirect3DSwapChain9);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3DSwapChain9*, Guid*, void**, int>)(lpVtbl[0]))((IDirect3DSwapChain9*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3DSwapChain9*, uint>)(lpVtbl[1]))((IDirect3DSwapChain9*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3DSwapChain9*, uint>)(lpVtbl[2]))((IDirect3DSwapChain9*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDirect3DSwapChain9.xml' path='doc/member[@name="IDirect3DSwapChain9.Present"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Present([NativeTypeName("const RECT *")] RECT* pSourceRect, [NativeTypeName("const RECT *")] RECT* pDestRect, HWND hDestWindowOverride, [NativeTypeName("const RGNDATA *")] RGNDATA* pDirtyRegion, [NativeTypeName("DWORD")] uint dwFlags)
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3DSwapChain9*, RECT*, RECT*, HWND, RGNDATA*, uint, int>)(lpVtbl[3]))((IDirect3DSwapChain9*)Unsafe.AsPointer(ref this), pSourceRect, pDestRect, hDestWindowOverride, pDirtyRegion, dwFlags);
    }

    /// <include file='IDirect3DSwapChain9.xml' path='doc/member[@name="IDirect3DSwapChain9.GetFrontBufferData"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetFrontBufferData(IDirect3DSurface9* pDestSurface)
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3DSwapChain9*, IDirect3DSurface9*, int>)(lpVtbl[4]))((IDirect3DSwapChain9*)Unsafe.AsPointer(ref this), pDestSurface);
    }

    /// <include file='IDirect3DSwapChain9.xml' path='doc/member[@name="IDirect3DSwapChain9.GetBackBuffer"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetBackBuffer(uint iBackBuffer, D3DBACKBUFFER_TYPE Type, IDirect3DSurface9** ppBackBuffer)
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3DSwapChain9*, uint, D3DBACKBUFFER_TYPE, IDirect3DSurface9**, int>)(lpVtbl[5]))((IDirect3DSwapChain9*)Unsafe.AsPointer(ref this), iBackBuffer, Type, ppBackBuffer);
    }

    /// <include file='IDirect3DSwapChain9.xml' path='doc/member[@name="IDirect3DSwapChain9.GetRasterStatus"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetRasterStatus(D3DRASTER_STATUS* pRasterStatus)
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3DSwapChain9*, D3DRASTER_STATUS*, int>)(lpVtbl[6]))((IDirect3DSwapChain9*)Unsafe.AsPointer(ref this), pRasterStatus);
    }

    /// <include file='IDirect3DSwapChain9.xml' path='doc/member[@name="IDirect3DSwapChain9.GetDisplayMode"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetDisplayMode(D3DDISPLAYMODE* pMode)
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3DSwapChain9*, D3DDISPLAYMODE*, int>)(lpVtbl[7]))((IDirect3DSwapChain9*)Unsafe.AsPointer(ref this), pMode);
    }

    /// <include file='IDirect3DSwapChain9.xml' path='doc/member[@name="IDirect3DSwapChain9.GetDevice"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetDevice(IDirect3DDevice9** ppDevice)
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3DSwapChain9*, IDirect3DDevice9**, int>)(lpVtbl[8]))((IDirect3DSwapChain9*)Unsafe.AsPointer(ref this), ppDevice);
    }

    /// <include file='IDirect3DSwapChain9.xml' path='doc/member[@name="IDirect3DSwapChain9.GetPresentParameters"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetPresentParameters(D3DPRESENT_PARAMETERS* pPresentationParameters)
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3DSwapChain9*, D3DPRESENT_PARAMETERS*, int>)(lpVtbl[9]))((IDirect3DSwapChain9*)Unsafe.AsPointer(ref this), pPresentationParameters);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Present([NativeTypeName("const RECT *")] RECT* pSourceRect, [NativeTypeName("const RECT *")] RECT* pDestRect, HWND hDestWindowOverride, [NativeTypeName("const RGNDATA *")] RGNDATA* pDirtyRegion, [NativeTypeName("DWORD")] uint dwFlags);

        [VtblIndex(4)]
        HRESULT GetFrontBufferData(IDirect3DSurface9* pDestSurface);

        [VtblIndex(5)]
        HRESULT GetBackBuffer(uint iBackBuffer, D3DBACKBUFFER_TYPE Type, IDirect3DSurface9** ppBackBuffer);

        [VtblIndex(6)]
        HRESULT GetRasterStatus(D3DRASTER_STATUS* pRasterStatus);

        [VtblIndex(7)]
        HRESULT GetDisplayMode(D3DDISPLAYMODE* pMode);

        [VtblIndex(8)]
        HRESULT GetDevice(IDirect3DDevice9** ppDevice);

        [VtblIndex(9)]
        HRESULT GetPresentParameters(D3DPRESENT_PARAMETERS* pPresentationParameters);
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint> Release;

        [NativeTypeName("HRESULT (const RECT *, const RECT *, HWND, const RGNDATA *, DWORD) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, RECT*, RECT*, HWND, RGNDATA*, uint, int> Present;

        [NativeTypeName("HRESULT (IDirect3DSurface9 *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IDirect3DSurface9*, int> GetFrontBufferData;

        [NativeTypeName("HRESULT (UINT, D3DBACKBUFFER_TYPE, IDirect3DSurface9 **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, D3DBACKBUFFER_TYPE, IDirect3DSurface9**, int> GetBackBuffer;

        [NativeTypeName("HRESULT (D3DRASTER_STATUS *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, D3DRASTER_STATUS*, int> GetRasterStatus;

        [NativeTypeName("HRESULT (D3DDISPLAYMODE *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, D3DDISPLAYMODE*, int> GetDisplayMode;

        [NativeTypeName("HRESULT (IDirect3DDevice9 **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IDirect3DDevice9**, int> GetDevice;

        [NativeTypeName("HRESULT (D3DPRESENT_PARAMETERS *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, D3DPRESENT_PARAMETERS*, int> GetPresentParameters;
    }
}
