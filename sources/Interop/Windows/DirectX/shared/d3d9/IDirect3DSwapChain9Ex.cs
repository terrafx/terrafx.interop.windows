// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/d3d9.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.DirectX;

/// <include file='IDirect3DSwapChain9Ex.xml' path='doc/member[@name="IDirect3DSwapChain9Ex"]/*' />
[Guid("91886CAF-1C3D-4D2E-A0AB-3E4C7D8D3303")]
[NativeTypeName("struct IDirect3DSwapChain9Ex : IDirect3DSwapChain9")]
[NativeInheritance("IDirect3DSwapChain9")]
public unsafe partial struct IDirect3DSwapChain9Ex : IDirect3DSwapChain9Ex.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDirect3DSwapChain9Ex));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3DSwapChain9Ex*, Guid*, void**, int>)(lpVtbl[0]))((IDirect3DSwapChain9Ex*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3DSwapChain9Ex*, uint>)(lpVtbl[1]))((IDirect3DSwapChain9Ex*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3DSwapChain9Ex*, uint>)(lpVtbl[2]))((IDirect3DSwapChain9Ex*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IDirect3DSwapChain9.Present" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Present([NativeTypeName("const RECT *")] RECT* pSourceRect, [NativeTypeName("const RECT *")] RECT* pDestRect, HWND hDestWindowOverride, [NativeTypeName("const RGNDATA *")] RGNDATA* pDirtyRegion, [NativeTypeName("DWORD")] uint dwFlags)
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3DSwapChain9Ex*, RECT*, RECT*, HWND, RGNDATA*, uint, int>)(lpVtbl[3]))((IDirect3DSwapChain9Ex*)Unsafe.AsPointer(ref this), pSourceRect, pDestRect, hDestWindowOverride, pDirtyRegion, dwFlags);
    }

    /// <inheritdoc cref="IDirect3DSwapChain9.GetFrontBufferData" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetFrontBufferData(IDirect3DSurface9* pDestSurface)
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3DSwapChain9Ex*, IDirect3DSurface9*, int>)(lpVtbl[4]))((IDirect3DSwapChain9Ex*)Unsafe.AsPointer(ref this), pDestSurface);
    }

    /// <inheritdoc cref="IDirect3DSwapChain9.GetBackBuffer" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetBackBuffer(uint iBackBuffer, D3DBACKBUFFER_TYPE Type, IDirect3DSurface9** ppBackBuffer)
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3DSwapChain9Ex*, uint, D3DBACKBUFFER_TYPE, IDirect3DSurface9**, int>)(lpVtbl[5]))((IDirect3DSwapChain9Ex*)Unsafe.AsPointer(ref this), iBackBuffer, Type, ppBackBuffer);
    }

    /// <inheritdoc cref="IDirect3DSwapChain9.GetRasterStatus" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetRasterStatus(D3DRASTER_STATUS* pRasterStatus)
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3DSwapChain9Ex*, D3DRASTER_STATUS*, int>)(lpVtbl[6]))((IDirect3DSwapChain9Ex*)Unsafe.AsPointer(ref this), pRasterStatus);
    }

    /// <inheritdoc cref="IDirect3DSwapChain9.GetDisplayMode" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetDisplayMode(D3DDISPLAYMODE* pMode)
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3DSwapChain9Ex*, D3DDISPLAYMODE*, int>)(lpVtbl[7]))((IDirect3DSwapChain9Ex*)Unsafe.AsPointer(ref this), pMode);
    }

    /// <inheritdoc cref="IDirect3DSwapChain9.GetDevice" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetDevice(IDirect3DDevice9** ppDevice)
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3DSwapChain9Ex*, IDirect3DDevice9**, int>)(lpVtbl[8]))((IDirect3DSwapChain9Ex*)Unsafe.AsPointer(ref this), ppDevice);
    }

    /// <inheritdoc cref="IDirect3DSwapChain9.GetPresentParameters" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetPresentParameters(D3DPRESENT_PARAMETERS* pPresentationParameters)
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3DSwapChain9Ex*, D3DPRESENT_PARAMETERS*, int>)(lpVtbl[9]))((IDirect3DSwapChain9Ex*)Unsafe.AsPointer(ref this), pPresentationParameters);
    }

    /// <include file='IDirect3DSwapChain9Ex.xml' path='doc/member[@name="IDirect3DSwapChain9Ex.GetLastPresentCount"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetLastPresentCount(uint* pLastPresentCount)
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3DSwapChain9Ex*, uint*, int>)(lpVtbl[10]))((IDirect3DSwapChain9Ex*)Unsafe.AsPointer(ref this), pLastPresentCount);
    }

    /// <include file='IDirect3DSwapChain9Ex.xml' path='doc/member[@name="IDirect3DSwapChain9Ex.GetPresentStats"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetPresentStats(D3DPRESENTSTATS* pPresentationStatistics)
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3DSwapChain9Ex*, D3DPRESENTSTATS*, int>)(lpVtbl[11]))((IDirect3DSwapChain9Ex*)Unsafe.AsPointer(ref this), pPresentationStatistics);
    }

    /// <include file='IDirect3DSwapChain9Ex.xml' path='doc/member[@name="IDirect3DSwapChain9Ex.GetDisplayModeEx"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT GetDisplayModeEx(D3DDISPLAYMODEEX* pMode, D3DDISPLAYROTATION* pRotation)
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3DSwapChain9Ex*, D3DDISPLAYMODEEX*, D3DDISPLAYROTATION*, int>)(lpVtbl[12]))((IDirect3DSwapChain9Ex*)Unsafe.AsPointer(ref this), pMode, pRotation);
    }

    public interface Interface : IDirect3DSwapChain9.Interface
    {
        [VtblIndex(10)]
        HRESULT GetLastPresentCount(uint* pLastPresentCount);

        [VtblIndex(11)]
        HRESULT GetPresentStats(D3DPRESENTSTATS* pPresentationStatistics);

        [VtblIndex(12)]
        HRESULT GetDisplayModeEx(D3DDISPLAYMODEEX* pMode, D3DDISPLAYROTATION* pRotation);
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

        [NativeTypeName("HRESULT (UINT *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> GetLastPresentCount;

        [NativeTypeName("HRESULT (D3DPRESENTSTATS *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, D3DPRESENTSTATS*, int> GetPresentStats;

        [NativeTypeName("HRESULT (D3DDISPLAYMODEEX *, D3DDISPLAYROTATION *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, D3DDISPLAYMODEEX*, D3DDISPLAYROTATION*, int> GetDisplayModeEx;
    }
}
