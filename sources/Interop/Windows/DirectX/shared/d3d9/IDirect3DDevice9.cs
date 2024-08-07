// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/d3d9.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.DirectX;

/// <include file='IDirect3DDevice9.xml' path='doc/member[@name="IDirect3DDevice9"]/*' />
[Guid("D0223B96-BF7A-43FD-92BD-A43B0D82B9EB")]
[NativeTypeName("struct IDirect3DDevice9 : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IDirect3DDevice9 : IDirect3DDevice9.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDirect3DDevice9));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3DDevice9*, Guid*, void**, int>)(lpVtbl[0]))((IDirect3DDevice9*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3DDevice9*, uint>)(lpVtbl[1]))((IDirect3DDevice9*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3DDevice9*, uint>)(lpVtbl[2]))((IDirect3DDevice9*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDirect3DDevice9.xml' path='doc/member[@name="IDirect3DDevice9.TestCooperativeLevel"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT TestCooperativeLevel()
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3DDevice9*, int>)(lpVtbl[3]))((IDirect3DDevice9*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDirect3DDevice9.xml' path='doc/member[@name="IDirect3DDevice9.GetAvailableTextureMem"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public uint GetAvailableTextureMem()
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3DDevice9*, uint>)(lpVtbl[4]))((IDirect3DDevice9*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDirect3DDevice9.xml' path='doc/member[@name="IDirect3DDevice9.EvictManagedResources"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT EvictManagedResources()
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3DDevice9*, int>)(lpVtbl[5]))((IDirect3DDevice9*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDirect3DDevice9.xml' path='doc/member[@name="IDirect3DDevice9.GetDirect3D"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetDirect3D(IDirect3D9** ppD3D9)
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3DDevice9*, IDirect3D9**, int>)(lpVtbl[6]))((IDirect3DDevice9*)Unsafe.AsPointer(ref this), ppD3D9);
    }

    /// <include file='IDirect3DDevice9.xml' path='doc/member[@name="IDirect3DDevice9.GetDeviceCaps"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetDeviceCaps(D3DCAPS9* pCaps)
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3DDevice9*, D3DCAPS9*, int>)(lpVtbl[7]))((IDirect3DDevice9*)Unsafe.AsPointer(ref this), pCaps);
    }

    /// <include file='IDirect3DDevice9.xml' path='doc/member[@name="IDirect3DDevice9.GetDisplayMode"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetDisplayMode(uint iSwapChain, D3DDISPLAYMODE* pMode)
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3DDevice9*, uint, D3DDISPLAYMODE*, int>)(lpVtbl[8]))((IDirect3DDevice9*)Unsafe.AsPointer(ref this), iSwapChain, pMode);
    }

    /// <include file='IDirect3DDevice9.xml' path='doc/member[@name="IDirect3DDevice9.GetCreationParameters"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetCreationParameters(D3DDEVICE_CREATION_PARAMETERS* pParameters)
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3DDevice9*, D3DDEVICE_CREATION_PARAMETERS*, int>)(lpVtbl[9]))((IDirect3DDevice9*)Unsafe.AsPointer(ref this), pParameters);
    }

    /// <include file='IDirect3DDevice9.xml' path='doc/member[@name="IDirect3DDevice9.SetCursorProperties"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT SetCursorProperties(uint XHotSpot, uint YHotSpot, IDirect3DSurface9* pCursorBitmap)
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3DDevice9*, uint, uint, IDirect3DSurface9*, int>)(lpVtbl[10]))((IDirect3DDevice9*)Unsafe.AsPointer(ref this), XHotSpot, YHotSpot, pCursorBitmap);
    }

    /// <include file='IDirect3DDevice9.xml' path='doc/member[@name="IDirect3DDevice9.SetCursorPosition"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public void SetCursorPosition(int X, int Y, [NativeTypeName("DWORD")] uint Flags)
    {
        ((delegate* unmanaged[MemberFunction]<IDirect3DDevice9*, int, int, uint, void>)(lpVtbl[11]))((IDirect3DDevice9*)Unsafe.AsPointer(ref this), X, Y, Flags);
    }

    /// <include file='IDirect3DDevice9.xml' path='doc/member[@name="IDirect3DDevice9.ShowCursor"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public BOOL ShowCursor(BOOL bShow)
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3DDevice9*, BOOL, int>)(lpVtbl[12]))((IDirect3DDevice9*)Unsafe.AsPointer(ref this), bShow);
    }

    /// <include file='IDirect3DDevice9.xml' path='doc/member[@name="IDirect3DDevice9.CreateAdditionalSwapChain"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT CreateAdditionalSwapChain(D3DPRESENT_PARAMETERS* pPresentationParameters, IDirect3DSwapChain9** pSwapChain)
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3DDevice9*, D3DPRESENT_PARAMETERS*, IDirect3DSwapChain9**, int>)(lpVtbl[13]))((IDirect3DDevice9*)Unsafe.AsPointer(ref this), pPresentationParameters, pSwapChain);
    }

    /// <include file='IDirect3DDevice9.xml' path='doc/member[@name="IDirect3DDevice9.GetSwapChain"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT GetSwapChain(uint iSwapChain, IDirect3DSwapChain9** pSwapChain)
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3DDevice9*, uint, IDirect3DSwapChain9**, int>)(lpVtbl[14]))((IDirect3DDevice9*)Unsafe.AsPointer(ref this), iSwapChain, pSwapChain);
    }

    /// <include file='IDirect3DDevice9.xml' path='doc/member[@name="IDirect3DDevice9.GetNumberOfSwapChains"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public uint GetNumberOfSwapChains()
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3DDevice9*, uint>)(lpVtbl[15]))((IDirect3DDevice9*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDirect3DDevice9.xml' path='doc/member[@name="IDirect3DDevice9.Reset"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT Reset(D3DPRESENT_PARAMETERS* pPresentationParameters)
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3DDevice9*, D3DPRESENT_PARAMETERS*, int>)(lpVtbl[16]))((IDirect3DDevice9*)Unsafe.AsPointer(ref this), pPresentationParameters);
    }

    /// <include file='IDirect3DDevice9.xml' path='doc/member[@name="IDirect3DDevice9.Present"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT Present([NativeTypeName("const RECT *")] RECT* pSourceRect, [NativeTypeName("const RECT *")] RECT* pDestRect, HWND hDestWindowOverride, [NativeTypeName("const RGNDATA *")] RGNDATA* pDirtyRegion)
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3DDevice9*, RECT*, RECT*, HWND, RGNDATA*, int>)(lpVtbl[17]))((IDirect3DDevice9*)Unsafe.AsPointer(ref this), pSourceRect, pDestRect, hDestWindowOverride, pDirtyRegion);
    }

    /// <include file='IDirect3DDevice9.xml' path='doc/member[@name="IDirect3DDevice9.GetBackBuffer"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT GetBackBuffer(uint iSwapChain, uint iBackBuffer, D3DBACKBUFFER_TYPE Type, IDirect3DSurface9** ppBackBuffer)
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3DDevice9*, uint, uint, D3DBACKBUFFER_TYPE, IDirect3DSurface9**, int>)(lpVtbl[18]))((IDirect3DDevice9*)Unsafe.AsPointer(ref this), iSwapChain, iBackBuffer, Type, ppBackBuffer);
    }

    /// <include file='IDirect3DDevice9.xml' path='doc/member[@name="IDirect3DDevice9.GetRasterStatus"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT GetRasterStatus(uint iSwapChain, D3DRASTER_STATUS* pRasterStatus)
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3DDevice9*, uint, D3DRASTER_STATUS*, int>)(lpVtbl[19]))((IDirect3DDevice9*)Unsafe.AsPointer(ref this), iSwapChain, pRasterStatus);
    }

    /// <include file='IDirect3DDevice9.xml' path='doc/member[@name="IDirect3DDevice9.SetDialogBoxMode"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT SetDialogBoxMode(BOOL bEnableDialogs)
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3DDevice9*, BOOL, int>)(lpVtbl[20]))((IDirect3DDevice9*)Unsafe.AsPointer(ref this), bEnableDialogs);
    }

    /// <include file='IDirect3DDevice9.xml' path='doc/member[@name="IDirect3DDevice9.SetGammaRamp"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public void SetGammaRamp(uint iSwapChain, [NativeTypeName("DWORD")] uint Flags, [NativeTypeName("const D3DGAMMARAMP *")] D3DGAMMARAMP* pRamp)
    {
        ((delegate* unmanaged[MemberFunction]<IDirect3DDevice9*, uint, uint, D3DGAMMARAMP*, void>)(lpVtbl[21]))((IDirect3DDevice9*)Unsafe.AsPointer(ref this), iSwapChain, Flags, pRamp);
    }

    /// <include file='IDirect3DDevice9.xml' path='doc/member[@name="IDirect3DDevice9.GetGammaRamp"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public void GetGammaRamp(uint iSwapChain, D3DGAMMARAMP* pRamp)
    {
        ((delegate* unmanaged[MemberFunction]<IDirect3DDevice9*, uint, D3DGAMMARAMP*, void>)(lpVtbl[22]))((IDirect3DDevice9*)Unsafe.AsPointer(ref this), iSwapChain, pRamp);
    }

    /// <include file='IDirect3DDevice9.xml' path='doc/member[@name="IDirect3DDevice9.CreateTexture"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT CreateTexture(uint Width, uint Height, uint Levels, [NativeTypeName("DWORD")] uint Usage, D3DFORMAT Format, D3DPOOL Pool, IDirect3DTexture9** ppTexture, HANDLE* pSharedHandle)
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3DDevice9*, uint, uint, uint, uint, D3DFORMAT, D3DPOOL, IDirect3DTexture9**, HANDLE*, int>)(lpVtbl[23]))((IDirect3DDevice9*)Unsafe.AsPointer(ref this), Width, Height, Levels, Usage, Format, Pool, ppTexture, pSharedHandle);
    }

    /// <include file='IDirect3DDevice9.xml' path='doc/member[@name="IDirect3DDevice9.CreateVolumeTexture"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT CreateVolumeTexture(uint Width, uint Height, uint Depth, uint Levels, [NativeTypeName("DWORD")] uint Usage, D3DFORMAT Format, D3DPOOL Pool, IDirect3DVolumeTexture9** ppVolumeTexture, HANDLE* pSharedHandle)
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3DDevice9*, uint, uint, uint, uint, uint, D3DFORMAT, D3DPOOL, IDirect3DVolumeTexture9**, HANDLE*, int>)(lpVtbl[24]))((IDirect3DDevice9*)Unsafe.AsPointer(ref this), Width, Height, Depth, Levels, Usage, Format, Pool, ppVolumeTexture, pSharedHandle);
    }

    /// <include file='IDirect3DDevice9.xml' path='doc/member[@name="IDirect3DDevice9.CreateCubeTexture"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT CreateCubeTexture(uint EdgeLength, uint Levels, [NativeTypeName("DWORD")] uint Usage, D3DFORMAT Format, D3DPOOL Pool, IDirect3DCubeTexture9** ppCubeTexture, HANDLE* pSharedHandle)
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3DDevice9*, uint, uint, uint, D3DFORMAT, D3DPOOL, IDirect3DCubeTexture9**, HANDLE*, int>)(lpVtbl[25]))((IDirect3DDevice9*)Unsafe.AsPointer(ref this), EdgeLength, Levels, Usage, Format, Pool, ppCubeTexture, pSharedHandle);
    }

    /// <include file='IDirect3DDevice9.xml' path='doc/member[@name="IDirect3DDevice9.CreateVertexBuffer"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT CreateVertexBuffer(uint Length, [NativeTypeName("DWORD")] uint Usage, [NativeTypeName("DWORD")] uint FVF, D3DPOOL Pool, IDirect3DVertexBuffer9** ppVertexBuffer, HANDLE* pSharedHandle)
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3DDevice9*, uint, uint, uint, D3DPOOL, IDirect3DVertexBuffer9**, HANDLE*, int>)(lpVtbl[26]))((IDirect3DDevice9*)Unsafe.AsPointer(ref this), Length, Usage, FVF, Pool, ppVertexBuffer, pSharedHandle);
    }

    /// <include file='IDirect3DDevice9.xml' path='doc/member[@name="IDirect3DDevice9.CreateIndexBuffer"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT CreateIndexBuffer(uint Length, [NativeTypeName("DWORD")] uint Usage, D3DFORMAT Format, D3DPOOL Pool, IDirect3DIndexBuffer9** ppIndexBuffer, HANDLE* pSharedHandle)
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3DDevice9*, uint, uint, D3DFORMAT, D3DPOOL, IDirect3DIndexBuffer9**, HANDLE*, int>)(lpVtbl[27]))((IDirect3DDevice9*)Unsafe.AsPointer(ref this), Length, Usage, Format, Pool, ppIndexBuffer, pSharedHandle);
    }

    /// <include file='IDirect3DDevice9.xml' path='doc/member[@name="IDirect3DDevice9.CreateRenderTarget"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT CreateRenderTarget(uint Width, uint Height, D3DFORMAT Format, D3DMULTISAMPLE_TYPE MultiSample, [NativeTypeName("DWORD")] uint MultisampleQuality, BOOL Lockable, IDirect3DSurface9** ppSurface, HANDLE* pSharedHandle)
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3DDevice9*, uint, uint, D3DFORMAT, D3DMULTISAMPLE_TYPE, uint, BOOL, IDirect3DSurface9**, HANDLE*, int>)(lpVtbl[28]))((IDirect3DDevice9*)Unsafe.AsPointer(ref this), Width, Height, Format, MultiSample, MultisampleQuality, Lockable, ppSurface, pSharedHandle);
    }

    /// <include file='IDirect3DDevice9.xml' path='doc/member[@name="IDirect3DDevice9.CreateDepthStencilSurface"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HRESULT CreateDepthStencilSurface(uint Width, uint Height, D3DFORMAT Format, D3DMULTISAMPLE_TYPE MultiSample, [NativeTypeName("DWORD")] uint MultisampleQuality, BOOL Discard, IDirect3DSurface9** ppSurface, HANDLE* pSharedHandle)
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3DDevice9*, uint, uint, D3DFORMAT, D3DMULTISAMPLE_TYPE, uint, BOOL, IDirect3DSurface9**, HANDLE*, int>)(lpVtbl[29]))((IDirect3DDevice9*)Unsafe.AsPointer(ref this), Width, Height, Format, MultiSample, MultisampleQuality, Discard, ppSurface, pSharedHandle);
    }

    /// <include file='IDirect3DDevice9.xml' path='doc/member[@name="IDirect3DDevice9.UpdateSurface"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    public HRESULT UpdateSurface(IDirect3DSurface9* pSourceSurface, [NativeTypeName("const RECT *")] RECT* pSourceRect, IDirect3DSurface9* pDestinationSurface, [NativeTypeName("const POINT *")] POINT* pDestPoint)
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3DDevice9*, IDirect3DSurface9*, RECT*, IDirect3DSurface9*, POINT*, int>)(lpVtbl[30]))((IDirect3DDevice9*)Unsafe.AsPointer(ref this), pSourceSurface, pSourceRect, pDestinationSurface, pDestPoint);
    }

    /// <include file='IDirect3DDevice9.xml' path='doc/member[@name="IDirect3DDevice9.UpdateTexture"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(31)]
    public HRESULT UpdateTexture(IDirect3DBaseTexture9* pSourceTexture, IDirect3DBaseTexture9* pDestinationTexture)
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3DDevice9*, IDirect3DBaseTexture9*, IDirect3DBaseTexture9*, int>)(lpVtbl[31]))((IDirect3DDevice9*)Unsafe.AsPointer(ref this), pSourceTexture, pDestinationTexture);
    }

    /// <include file='IDirect3DDevice9.xml' path='doc/member[@name="IDirect3DDevice9.GetRenderTargetData"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(32)]
    public HRESULT GetRenderTargetData(IDirect3DSurface9* pRenderTarget, IDirect3DSurface9* pDestSurface)
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3DDevice9*, IDirect3DSurface9*, IDirect3DSurface9*, int>)(lpVtbl[32]))((IDirect3DDevice9*)Unsafe.AsPointer(ref this), pRenderTarget, pDestSurface);
    }

    /// <include file='IDirect3DDevice9.xml' path='doc/member[@name="IDirect3DDevice9.GetFrontBufferData"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(33)]
    public HRESULT GetFrontBufferData(uint iSwapChain, IDirect3DSurface9* pDestSurface)
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3DDevice9*, uint, IDirect3DSurface9*, int>)(lpVtbl[33]))((IDirect3DDevice9*)Unsafe.AsPointer(ref this), iSwapChain, pDestSurface);
    }

    /// <include file='IDirect3DDevice9.xml' path='doc/member[@name="IDirect3DDevice9.StretchRect"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(34)]
    public HRESULT StretchRect(IDirect3DSurface9* pSourceSurface, [NativeTypeName("const RECT *")] RECT* pSourceRect, IDirect3DSurface9* pDestSurface, [NativeTypeName("const RECT *")] RECT* pDestRect, D3DTEXTUREFILTERTYPE Filter)
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3DDevice9*, IDirect3DSurface9*, RECT*, IDirect3DSurface9*, RECT*, D3DTEXTUREFILTERTYPE, int>)(lpVtbl[34]))((IDirect3DDevice9*)Unsafe.AsPointer(ref this), pSourceSurface, pSourceRect, pDestSurface, pDestRect, Filter);
    }

    /// <include file='IDirect3DDevice9.xml' path='doc/member[@name="IDirect3DDevice9.ColorFill"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(35)]
    public HRESULT ColorFill(IDirect3DSurface9* pSurface, [NativeTypeName("const RECT *")] RECT* pRect, [NativeTypeName("D3DCOLOR")] uint color)
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3DDevice9*, IDirect3DSurface9*, RECT*, uint, int>)(lpVtbl[35]))((IDirect3DDevice9*)Unsafe.AsPointer(ref this), pSurface, pRect, color);
    }

    /// <include file='IDirect3DDevice9.xml' path='doc/member[@name="IDirect3DDevice9.CreateOffscreenPlainSurface"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(36)]
    public HRESULT CreateOffscreenPlainSurface(uint Width, uint Height, D3DFORMAT Format, D3DPOOL Pool, IDirect3DSurface9** ppSurface, HANDLE* pSharedHandle)
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3DDevice9*, uint, uint, D3DFORMAT, D3DPOOL, IDirect3DSurface9**, HANDLE*, int>)(lpVtbl[36]))((IDirect3DDevice9*)Unsafe.AsPointer(ref this), Width, Height, Format, Pool, ppSurface, pSharedHandle);
    }

    /// <include file='IDirect3DDevice9.xml' path='doc/member[@name="IDirect3DDevice9.SetRenderTarget"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(37)]
    public HRESULT SetRenderTarget([NativeTypeName("DWORD")] uint RenderTargetIndex, IDirect3DSurface9* pRenderTarget)
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3DDevice9*, uint, IDirect3DSurface9*, int>)(lpVtbl[37]))((IDirect3DDevice9*)Unsafe.AsPointer(ref this), RenderTargetIndex, pRenderTarget);
    }

    /// <include file='IDirect3DDevice9.xml' path='doc/member[@name="IDirect3DDevice9.GetRenderTarget"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(38)]
    public HRESULT GetRenderTarget([NativeTypeName("DWORD")] uint RenderTargetIndex, IDirect3DSurface9** ppRenderTarget)
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3DDevice9*, uint, IDirect3DSurface9**, int>)(lpVtbl[38]))((IDirect3DDevice9*)Unsafe.AsPointer(ref this), RenderTargetIndex, ppRenderTarget);
    }

    /// <include file='IDirect3DDevice9.xml' path='doc/member[@name="IDirect3DDevice9.SetDepthStencilSurface"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(39)]
    public HRESULT SetDepthStencilSurface(IDirect3DSurface9* pNewZStencil)
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3DDevice9*, IDirect3DSurface9*, int>)(lpVtbl[39]))((IDirect3DDevice9*)Unsafe.AsPointer(ref this), pNewZStencil);
    }

    /// <include file='IDirect3DDevice9.xml' path='doc/member[@name="IDirect3DDevice9.GetDepthStencilSurface"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(40)]
    public HRESULT GetDepthStencilSurface(IDirect3DSurface9** ppZStencilSurface)
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3DDevice9*, IDirect3DSurface9**, int>)(lpVtbl[40]))((IDirect3DDevice9*)Unsafe.AsPointer(ref this), ppZStencilSurface);
    }

    /// <include file='IDirect3DDevice9.xml' path='doc/member[@name="IDirect3DDevice9.BeginScene"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(41)]
    public HRESULT BeginScene()
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3DDevice9*, int>)(lpVtbl[41]))((IDirect3DDevice9*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDirect3DDevice9.xml' path='doc/member[@name="IDirect3DDevice9.EndScene"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(42)]
    public HRESULT EndScene()
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3DDevice9*, int>)(lpVtbl[42]))((IDirect3DDevice9*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDirect3DDevice9.xml' path='doc/member[@name="IDirect3DDevice9.Clear"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(43)]
    public HRESULT Clear([NativeTypeName("DWORD")] uint Count, [NativeTypeName("const D3DRECT *")] D3DRECT* pRects, [NativeTypeName("DWORD")] uint Flags, [NativeTypeName("D3DCOLOR")] uint Color, float Z, [NativeTypeName("DWORD")] uint Stencil)
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3DDevice9*, uint, D3DRECT*, uint, uint, float, uint, int>)(lpVtbl[43]))((IDirect3DDevice9*)Unsafe.AsPointer(ref this), Count, pRects, Flags, Color, Z, Stencil);
    }

    /// <include file='IDirect3DDevice9.xml' path='doc/member[@name="IDirect3DDevice9.SetTransform"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(44)]
    public HRESULT SetTransform(D3DTRANSFORMSTATETYPE State, [NativeTypeName("const D3DMATRIX *")] D2D_MATRIX_4X4_F* pMatrix)
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3DDevice9*, D3DTRANSFORMSTATETYPE, D2D_MATRIX_4X4_F*, int>)(lpVtbl[44]))((IDirect3DDevice9*)Unsafe.AsPointer(ref this), State, pMatrix);
    }

    /// <include file='IDirect3DDevice9.xml' path='doc/member[@name="IDirect3DDevice9.GetTransform"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(45)]
    public HRESULT GetTransform(D3DTRANSFORMSTATETYPE State, [NativeTypeName("D3DMATRIX *")] D2D_MATRIX_4X4_F* pMatrix)
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3DDevice9*, D3DTRANSFORMSTATETYPE, D2D_MATRIX_4X4_F*, int>)(lpVtbl[45]))((IDirect3DDevice9*)Unsafe.AsPointer(ref this), State, pMatrix);
    }

    /// <include file='IDirect3DDevice9.xml' path='doc/member[@name="IDirect3DDevice9.MultiplyTransform"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(46)]
    public HRESULT MultiplyTransform(D3DTRANSFORMSTATETYPE param0, [NativeTypeName("const D3DMATRIX *")] D2D_MATRIX_4X4_F* param1)
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3DDevice9*, D3DTRANSFORMSTATETYPE, D2D_MATRIX_4X4_F*, int>)(lpVtbl[46]))((IDirect3DDevice9*)Unsafe.AsPointer(ref this), param0, param1);
    }

    /// <include file='IDirect3DDevice9.xml' path='doc/member[@name="IDirect3DDevice9.SetViewport"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(47)]
    public HRESULT SetViewport([NativeTypeName("const D3DVIEWPORT9 *")] D3DVIEWPORT9* pViewport)
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3DDevice9*, D3DVIEWPORT9*, int>)(lpVtbl[47]))((IDirect3DDevice9*)Unsafe.AsPointer(ref this), pViewport);
    }

    /// <include file='IDirect3DDevice9.xml' path='doc/member[@name="IDirect3DDevice9.GetViewport"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(48)]
    public HRESULT GetViewport(D3DVIEWPORT9* pViewport)
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3DDevice9*, D3DVIEWPORT9*, int>)(lpVtbl[48]))((IDirect3DDevice9*)Unsafe.AsPointer(ref this), pViewport);
    }

    /// <include file='IDirect3DDevice9.xml' path='doc/member[@name="IDirect3DDevice9.SetMaterial"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(49)]
    public HRESULT SetMaterial([NativeTypeName("const D3DMATERIAL9 *")] D3DMATERIAL9* pMaterial)
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3DDevice9*, D3DMATERIAL9*, int>)(lpVtbl[49]))((IDirect3DDevice9*)Unsafe.AsPointer(ref this), pMaterial);
    }

    /// <include file='IDirect3DDevice9.xml' path='doc/member[@name="IDirect3DDevice9.GetMaterial"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(50)]
    public HRESULT GetMaterial(D3DMATERIAL9* pMaterial)
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3DDevice9*, D3DMATERIAL9*, int>)(lpVtbl[50]))((IDirect3DDevice9*)Unsafe.AsPointer(ref this), pMaterial);
    }

    /// <include file='IDirect3DDevice9.xml' path='doc/member[@name="IDirect3DDevice9.SetLight"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(51)]
    public HRESULT SetLight([NativeTypeName("DWORD")] uint Index, [NativeTypeName("const D3DLIGHT9 *")] D3DLIGHT9* param1)
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3DDevice9*, uint, D3DLIGHT9*, int>)(lpVtbl[51]))((IDirect3DDevice9*)Unsafe.AsPointer(ref this), Index, param1);
    }

    /// <include file='IDirect3DDevice9.xml' path='doc/member[@name="IDirect3DDevice9.GetLight"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(52)]
    public HRESULT GetLight([NativeTypeName("DWORD")] uint Index, D3DLIGHT9* param1)
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3DDevice9*, uint, D3DLIGHT9*, int>)(lpVtbl[52]))((IDirect3DDevice9*)Unsafe.AsPointer(ref this), Index, param1);
    }

    /// <include file='IDirect3DDevice9.xml' path='doc/member[@name="IDirect3DDevice9.LightEnable"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(53)]
    public HRESULT LightEnable([NativeTypeName("DWORD")] uint Index, BOOL Enable)
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3DDevice9*, uint, BOOL, int>)(lpVtbl[53]))((IDirect3DDevice9*)Unsafe.AsPointer(ref this), Index, Enable);
    }

    /// <include file='IDirect3DDevice9.xml' path='doc/member[@name="IDirect3DDevice9.GetLightEnable"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(54)]
    public HRESULT GetLightEnable([NativeTypeName("DWORD")] uint Index, BOOL* pEnable)
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3DDevice9*, uint, BOOL*, int>)(lpVtbl[54]))((IDirect3DDevice9*)Unsafe.AsPointer(ref this), Index, pEnable);
    }

    /// <include file='IDirect3DDevice9.xml' path='doc/member[@name="IDirect3DDevice9.SetClipPlane"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(55)]
    public HRESULT SetClipPlane([NativeTypeName("DWORD")] uint Index, [NativeTypeName("const float *")] float* pPlane)
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3DDevice9*, uint, float*, int>)(lpVtbl[55]))((IDirect3DDevice9*)Unsafe.AsPointer(ref this), Index, pPlane);
    }

    /// <include file='IDirect3DDevice9.xml' path='doc/member[@name="IDirect3DDevice9.GetClipPlane"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(56)]
    public HRESULT GetClipPlane([NativeTypeName("DWORD")] uint Index, float* pPlane)
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3DDevice9*, uint, float*, int>)(lpVtbl[56]))((IDirect3DDevice9*)Unsafe.AsPointer(ref this), Index, pPlane);
    }

    /// <include file='IDirect3DDevice9.xml' path='doc/member[@name="IDirect3DDevice9.SetRenderState"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(57)]
    public HRESULT SetRenderState(D3DRENDERSTATETYPE State, [NativeTypeName("DWORD")] uint Value)
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3DDevice9*, D3DRENDERSTATETYPE, uint, int>)(lpVtbl[57]))((IDirect3DDevice9*)Unsafe.AsPointer(ref this), State, Value);
    }

    /// <include file='IDirect3DDevice9.xml' path='doc/member[@name="IDirect3DDevice9.GetRenderState"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(58)]
    public HRESULT GetRenderState(D3DRENDERSTATETYPE State, [NativeTypeName("DWORD *")] uint* pValue)
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3DDevice9*, D3DRENDERSTATETYPE, uint*, int>)(lpVtbl[58]))((IDirect3DDevice9*)Unsafe.AsPointer(ref this), State, pValue);
    }

    /// <include file='IDirect3DDevice9.xml' path='doc/member[@name="IDirect3DDevice9.CreateStateBlock"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(59)]
    public HRESULT CreateStateBlock(D3DSTATEBLOCKTYPE Type, IDirect3DStateBlock9** ppSB)
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3DDevice9*, D3DSTATEBLOCKTYPE, IDirect3DStateBlock9**, int>)(lpVtbl[59]))((IDirect3DDevice9*)Unsafe.AsPointer(ref this), Type, ppSB);
    }

    /// <include file='IDirect3DDevice9.xml' path='doc/member[@name="IDirect3DDevice9.BeginStateBlock"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(60)]
    public HRESULT BeginStateBlock()
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3DDevice9*, int>)(lpVtbl[60]))((IDirect3DDevice9*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDirect3DDevice9.xml' path='doc/member[@name="IDirect3DDevice9.EndStateBlock"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(61)]
    public HRESULT EndStateBlock(IDirect3DStateBlock9** ppSB)
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3DDevice9*, IDirect3DStateBlock9**, int>)(lpVtbl[61]))((IDirect3DDevice9*)Unsafe.AsPointer(ref this), ppSB);
    }

    /// <include file='IDirect3DDevice9.xml' path='doc/member[@name="IDirect3DDevice9.SetClipStatus"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(62)]
    public HRESULT SetClipStatus([NativeTypeName("const D3DCLIPSTATUS9 *")] D3DCLIPSTATUS9* pClipStatus)
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3DDevice9*, D3DCLIPSTATUS9*, int>)(lpVtbl[62]))((IDirect3DDevice9*)Unsafe.AsPointer(ref this), pClipStatus);
    }

    /// <include file='IDirect3DDevice9.xml' path='doc/member[@name="IDirect3DDevice9.GetClipStatus"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(63)]
    public HRESULT GetClipStatus(D3DCLIPSTATUS9* pClipStatus)
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3DDevice9*, D3DCLIPSTATUS9*, int>)(lpVtbl[63]))((IDirect3DDevice9*)Unsafe.AsPointer(ref this), pClipStatus);
    }

    /// <include file='IDirect3DDevice9.xml' path='doc/member[@name="IDirect3DDevice9.GetTexture"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(64)]
    public HRESULT GetTexture([NativeTypeName("DWORD")] uint Stage, IDirect3DBaseTexture9** ppTexture)
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3DDevice9*, uint, IDirect3DBaseTexture9**, int>)(lpVtbl[64]))((IDirect3DDevice9*)Unsafe.AsPointer(ref this), Stage, ppTexture);
    }

    /// <include file='IDirect3DDevice9.xml' path='doc/member[@name="IDirect3DDevice9.SetTexture"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(65)]
    public HRESULT SetTexture([NativeTypeName("DWORD")] uint Stage, IDirect3DBaseTexture9* pTexture)
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3DDevice9*, uint, IDirect3DBaseTexture9*, int>)(lpVtbl[65]))((IDirect3DDevice9*)Unsafe.AsPointer(ref this), Stage, pTexture);
    }

    /// <include file='IDirect3DDevice9.xml' path='doc/member[@name="IDirect3DDevice9.GetTextureStageState"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(66)]
    public HRESULT GetTextureStageState([NativeTypeName("DWORD")] uint Stage, D3DTEXTURESTAGESTATETYPE Type, [NativeTypeName("DWORD *")] uint* pValue)
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3DDevice9*, uint, D3DTEXTURESTAGESTATETYPE, uint*, int>)(lpVtbl[66]))((IDirect3DDevice9*)Unsafe.AsPointer(ref this), Stage, Type, pValue);
    }

    /// <include file='IDirect3DDevice9.xml' path='doc/member[@name="IDirect3DDevice9.SetTextureStageState"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(67)]
    public HRESULT SetTextureStageState([NativeTypeName("DWORD")] uint Stage, D3DTEXTURESTAGESTATETYPE Type, [NativeTypeName("DWORD")] uint Value)
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3DDevice9*, uint, D3DTEXTURESTAGESTATETYPE, uint, int>)(lpVtbl[67]))((IDirect3DDevice9*)Unsafe.AsPointer(ref this), Stage, Type, Value);
    }

    /// <include file='IDirect3DDevice9.xml' path='doc/member[@name="IDirect3DDevice9.GetSamplerState"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(68)]
    public HRESULT GetSamplerState([NativeTypeName("DWORD")] uint Sampler, D3DSAMPLERSTATETYPE Type, [NativeTypeName("DWORD *")] uint* pValue)
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3DDevice9*, uint, D3DSAMPLERSTATETYPE, uint*, int>)(lpVtbl[68]))((IDirect3DDevice9*)Unsafe.AsPointer(ref this), Sampler, Type, pValue);
    }

    /// <include file='IDirect3DDevice9.xml' path='doc/member[@name="IDirect3DDevice9.SetSamplerState"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(69)]
    public HRESULT SetSamplerState([NativeTypeName("DWORD")] uint Sampler, D3DSAMPLERSTATETYPE Type, [NativeTypeName("DWORD")] uint Value)
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3DDevice9*, uint, D3DSAMPLERSTATETYPE, uint, int>)(lpVtbl[69]))((IDirect3DDevice9*)Unsafe.AsPointer(ref this), Sampler, Type, Value);
    }

    /// <include file='IDirect3DDevice9.xml' path='doc/member[@name="IDirect3DDevice9.ValidateDevice"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(70)]
    public HRESULT ValidateDevice([NativeTypeName("DWORD *")] uint* pNumPasses)
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3DDevice9*, uint*, int>)(lpVtbl[70]))((IDirect3DDevice9*)Unsafe.AsPointer(ref this), pNumPasses);
    }

    /// <include file='IDirect3DDevice9.xml' path='doc/member[@name="IDirect3DDevice9.SetPaletteEntries"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(71)]
    public HRESULT SetPaletteEntries(uint PaletteNumber, [NativeTypeName("const PALETTEENTRY *")] PALETTEENTRY* pEntries)
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3DDevice9*, uint, PALETTEENTRY*, int>)(lpVtbl[71]))((IDirect3DDevice9*)Unsafe.AsPointer(ref this), PaletteNumber, pEntries);
    }

    /// <include file='IDirect3DDevice9.xml' path='doc/member[@name="IDirect3DDevice9.GetPaletteEntries"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(72)]
    public HRESULT GetPaletteEntries(uint PaletteNumber, PALETTEENTRY* pEntries)
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3DDevice9*, uint, PALETTEENTRY*, int>)(lpVtbl[72]))((IDirect3DDevice9*)Unsafe.AsPointer(ref this), PaletteNumber, pEntries);
    }

    /// <include file='IDirect3DDevice9.xml' path='doc/member[@name="IDirect3DDevice9.SetCurrentTexturePalette"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(73)]
    public HRESULT SetCurrentTexturePalette(uint PaletteNumber)
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3DDevice9*, uint, int>)(lpVtbl[73]))((IDirect3DDevice9*)Unsafe.AsPointer(ref this), PaletteNumber);
    }

    /// <include file='IDirect3DDevice9.xml' path='doc/member[@name="IDirect3DDevice9.GetCurrentTexturePalette"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(74)]
    public HRESULT GetCurrentTexturePalette(uint* PaletteNumber)
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3DDevice9*, uint*, int>)(lpVtbl[74]))((IDirect3DDevice9*)Unsafe.AsPointer(ref this), PaletteNumber);
    }

    /// <include file='IDirect3DDevice9.xml' path='doc/member[@name="IDirect3DDevice9.SetScissorRect"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(75)]
    public HRESULT SetScissorRect([NativeTypeName("const RECT *")] RECT* pRect)
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3DDevice9*, RECT*, int>)(lpVtbl[75]))((IDirect3DDevice9*)Unsafe.AsPointer(ref this), pRect);
    }

    /// <include file='IDirect3DDevice9.xml' path='doc/member[@name="IDirect3DDevice9.GetScissorRect"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(76)]
    public HRESULT GetScissorRect(RECT* pRect)
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3DDevice9*, RECT*, int>)(lpVtbl[76]))((IDirect3DDevice9*)Unsafe.AsPointer(ref this), pRect);
    }

    /// <include file='IDirect3DDevice9.xml' path='doc/member[@name="IDirect3DDevice9.SetSoftwareVertexProcessing"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(77)]
    public HRESULT SetSoftwareVertexProcessing(BOOL bSoftware)
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3DDevice9*, BOOL, int>)(lpVtbl[77]))((IDirect3DDevice9*)Unsafe.AsPointer(ref this), bSoftware);
    }

    /// <include file='IDirect3DDevice9.xml' path='doc/member[@name="IDirect3DDevice9.GetSoftwareVertexProcessing"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(78)]
    public BOOL GetSoftwareVertexProcessing()
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3DDevice9*, int>)(lpVtbl[78]))((IDirect3DDevice9*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDirect3DDevice9.xml' path='doc/member[@name="IDirect3DDevice9.SetNPatchMode"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(79)]
    public HRESULT SetNPatchMode(float nSegments)
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3DDevice9*, float, int>)(lpVtbl[79]))((IDirect3DDevice9*)Unsafe.AsPointer(ref this), nSegments);
    }

    /// <include file='IDirect3DDevice9.xml' path='doc/member[@name="IDirect3DDevice9.GetNPatchMode"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(80)]
    public float GetNPatchMode()
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3DDevice9*, float>)(lpVtbl[80]))((IDirect3DDevice9*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDirect3DDevice9.xml' path='doc/member[@name="IDirect3DDevice9.DrawPrimitive"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(81)]
    public HRESULT DrawPrimitive(D3DPRIMITIVETYPE PrimitiveType, uint StartVertex, uint PrimitiveCount)
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3DDevice9*, D3DPRIMITIVETYPE, uint, uint, int>)(lpVtbl[81]))((IDirect3DDevice9*)Unsafe.AsPointer(ref this), PrimitiveType, StartVertex, PrimitiveCount);
    }

    /// <include file='IDirect3DDevice9.xml' path='doc/member[@name="IDirect3DDevice9.DrawIndexedPrimitive"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(82)]
    public HRESULT DrawIndexedPrimitive(D3DPRIMITIVETYPE param0, int BaseVertexIndex, uint MinVertexIndex, uint NumVertices, uint startIndex, uint primCount)
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3DDevice9*, D3DPRIMITIVETYPE, int, uint, uint, uint, uint, int>)(lpVtbl[82]))((IDirect3DDevice9*)Unsafe.AsPointer(ref this), param0, BaseVertexIndex, MinVertexIndex, NumVertices, startIndex, primCount);
    }

    /// <include file='IDirect3DDevice9.xml' path='doc/member[@name="IDirect3DDevice9.DrawPrimitiveUP"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(83)]
    public HRESULT DrawPrimitiveUP(D3DPRIMITIVETYPE PrimitiveType, uint PrimitiveCount, [NativeTypeName("const void *")] void* pVertexStreamZeroData, uint VertexStreamZeroStride)
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3DDevice9*, D3DPRIMITIVETYPE, uint, void*, uint, int>)(lpVtbl[83]))((IDirect3DDevice9*)Unsafe.AsPointer(ref this), PrimitiveType, PrimitiveCount, pVertexStreamZeroData, VertexStreamZeroStride);
    }

    /// <include file='IDirect3DDevice9.xml' path='doc/member[@name="IDirect3DDevice9.DrawIndexedPrimitiveUP"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(84)]
    public HRESULT DrawIndexedPrimitiveUP(D3DPRIMITIVETYPE PrimitiveType, uint MinVertexIndex, uint NumVertices, uint PrimitiveCount, [NativeTypeName("const void *")] void* pIndexData, D3DFORMAT IndexDataFormat, [NativeTypeName("const void *")] void* pVertexStreamZeroData, uint VertexStreamZeroStride)
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3DDevice9*, D3DPRIMITIVETYPE, uint, uint, uint, void*, D3DFORMAT, void*, uint, int>)(lpVtbl[84]))((IDirect3DDevice9*)Unsafe.AsPointer(ref this), PrimitiveType, MinVertexIndex, NumVertices, PrimitiveCount, pIndexData, IndexDataFormat, pVertexStreamZeroData, VertexStreamZeroStride);
    }

    /// <include file='IDirect3DDevice9.xml' path='doc/member[@name="IDirect3DDevice9.ProcessVertices"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(85)]
    public HRESULT ProcessVertices(uint SrcStartIndex, uint DestIndex, uint VertexCount, IDirect3DVertexBuffer9* pDestBuffer, IDirect3DVertexDeclaration9* pVertexDecl, [NativeTypeName("DWORD")] uint Flags)
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3DDevice9*, uint, uint, uint, IDirect3DVertexBuffer9*, IDirect3DVertexDeclaration9*, uint, int>)(lpVtbl[85]))((IDirect3DDevice9*)Unsafe.AsPointer(ref this), SrcStartIndex, DestIndex, VertexCount, pDestBuffer, pVertexDecl, Flags);
    }

    /// <include file='IDirect3DDevice9.xml' path='doc/member[@name="IDirect3DDevice9.CreateVertexDeclaration"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(86)]
    public HRESULT CreateVertexDeclaration([NativeTypeName("const D3DVERTEXELEMENT9 *")] D3DVERTEXELEMENT9* pVertexElements, IDirect3DVertexDeclaration9** ppDecl)
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3DDevice9*, D3DVERTEXELEMENT9*, IDirect3DVertexDeclaration9**, int>)(lpVtbl[86]))((IDirect3DDevice9*)Unsafe.AsPointer(ref this), pVertexElements, ppDecl);
    }

    /// <include file='IDirect3DDevice9.xml' path='doc/member[@name="IDirect3DDevice9.SetVertexDeclaration"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(87)]
    public HRESULT SetVertexDeclaration(IDirect3DVertexDeclaration9* pDecl)
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3DDevice9*, IDirect3DVertexDeclaration9*, int>)(lpVtbl[87]))((IDirect3DDevice9*)Unsafe.AsPointer(ref this), pDecl);
    }

    /// <include file='IDirect3DDevice9.xml' path='doc/member[@name="IDirect3DDevice9.GetVertexDeclaration"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(88)]
    public HRESULT GetVertexDeclaration(IDirect3DVertexDeclaration9** ppDecl)
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3DDevice9*, IDirect3DVertexDeclaration9**, int>)(lpVtbl[88]))((IDirect3DDevice9*)Unsafe.AsPointer(ref this), ppDecl);
    }

    /// <include file='IDirect3DDevice9.xml' path='doc/member[@name="IDirect3DDevice9.SetFVF"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(89)]
    public HRESULT SetFVF([NativeTypeName("DWORD")] uint FVF)
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3DDevice9*, uint, int>)(lpVtbl[89]))((IDirect3DDevice9*)Unsafe.AsPointer(ref this), FVF);
    }

    /// <include file='IDirect3DDevice9.xml' path='doc/member[@name="IDirect3DDevice9.GetFVF"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(90)]
    public HRESULT GetFVF([NativeTypeName("DWORD *")] uint* pFVF)
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3DDevice9*, uint*, int>)(lpVtbl[90]))((IDirect3DDevice9*)Unsafe.AsPointer(ref this), pFVF);
    }

    /// <include file='IDirect3DDevice9.xml' path='doc/member[@name="IDirect3DDevice9.CreateVertexShader"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(91)]
    public HRESULT CreateVertexShader([NativeTypeName("const DWORD *")] uint* pFunction, IDirect3DVertexShader9** ppShader)
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3DDevice9*, uint*, IDirect3DVertexShader9**, int>)(lpVtbl[91]))((IDirect3DDevice9*)Unsafe.AsPointer(ref this), pFunction, ppShader);
    }

    /// <include file='IDirect3DDevice9.xml' path='doc/member[@name="IDirect3DDevice9.SetVertexShader"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(92)]
    public HRESULT SetVertexShader(IDirect3DVertexShader9* pShader)
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3DDevice9*, IDirect3DVertexShader9*, int>)(lpVtbl[92]))((IDirect3DDevice9*)Unsafe.AsPointer(ref this), pShader);
    }

    /// <include file='IDirect3DDevice9.xml' path='doc/member[@name="IDirect3DDevice9.GetVertexShader"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(93)]
    public HRESULT GetVertexShader(IDirect3DVertexShader9** ppShader)
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3DDevice9*, IDirect3DVertexShader9**, int>)(lpVtbl[93]))((IDirect3DDevice9*)Unsafe.AsPointer(ref this), ppShader);
    }

    /// <include file='IDirect3DDevice9.xml' path='doc/member[@name="IDirect3DDevice9.SetVertexShaderConstantF"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(94)]
    public HRESULT SetVertexShaderConstantF(uint StartRegister, [NativeTypeName("const float *")] float* pConstantData, uint Vector4fCount)
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3DDevice9*, uint, float*, uint, int>)(lpVtbl[94]))((IDirect3DDevice9*)Unsafe.AsPointer(ref this), StartRegister, pConstantData, Vector4fCount);
    }

    /// <include file='IDirect3DDevice9.xml' path='doc/member[@name="IDirect3DDevice9.GetVertexShaderConstantF"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(95)]
    public HRESULT GetVertexShaderConstantF(uint StartRegister, float* pConstantData, uint Vector4fCount)
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3DDevice9*, uint, float*, uint, int>)(lpVtbl[95]))((IDirect3DDevice9*)Unsafe.AsPointer(ref this), StartRegister, pConstantData, Vector4fCount);
    }

    /// <include file='IDirect3DDevice9.xml' path='doc/member[@name="IDirect3DDevice9.SetVertexShaderConstantI"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(96)]
    public HRESULT SetVertexShaderConstantI(uint StartRegister, [NativeTypeName("const int *")] int* pConstantData, uint Vector4iCount)
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3DDevice9*, uint, int*, uint, int>)(lpVtbl[96]))((IDirect3DDevice9*)Unsafe.AsPointer(ref this), StartRegister, pConstantData, Vector4iCount);
    }

    /// <include file='IDirect3DDevice9.xml' path='doc/member[@name="IDirect3DDevice9.GetVertexShaderConstantI"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(97)]
    public HRESULT GetVertexShaderConstantI(uint StartRegister, int* pConstantData, uint Vector4iCount)
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3DDevice9*, uint, int*, uint, int>)(lpVtbl[97]))((IDirect3DDevice9*)Unsafe.AsPointer(ref this), StartRegister, pConstantData, Vector4iCount);
    }

    /// <include file='IDirect3DDevice9.xml' path='doc/member[@name="IDirect3DDevice9.SetVertexShaderConstantB"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(98)]
    public HRESULT SetVertexShaderConstantB(uint StartRegister, [NativeTypeName("const BOOL *")] BOOL* pConstantData, uint BoolCount)
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3DDevice9*, uint, BOOL*, uint, int>)(lpVtbl[98]))((IDirect3DDevice9*)Unsafe.AsPointer(ref this), StartRegister, pConstantData, BoolCount);
    }

    /// <include file='IDirect3DDevice9.xml' path='doc/member[@name="IDirect3DDevice9.GetVertexShaderConstantB"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(99)]
    public HRESULT GetVertexShaderConstantB(uint StartRegister, BOOL* pConstantData, uint BoolCount)
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3DDevice9*, uint, BOOL*, uint, int>)(lpVtbl[99]))((IDirect3DDevice9*)Unsafe.AsPointer(ref this), StartRegister, pConstantData, BoolCount);
    }

    /// <include file='IDirect3DDevice9.xml' path='doc/member[@name="IDirect3DDevice9.SetStreamSource"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(100)]
    public HRESULT SetStreamSource(uint StreamNumber, IDirect3DVertexBuffer9* pStreamData, uint OffsetInBytes, uint Stride)
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3DDevice9*, uint, IDirect3DVertexBuffer9*, uint, uint, int>)(lpVtbl[100]))((IDirect3DDevice9*)Unsafe.AsPointer(ref this), StreamNumber, pStreamData, OffsetInBytes, Stride);
    }

    /// <include file='IDirect3DDevice9.xml' path='doc/member[@name="IDirect3DDevice9.GetStreamSource"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(101)]
    public HRESULT GetStreamSource(uint StreamNumber, IDirect3DVertexBuffer9** ppStreamData, uint* pOffsetInBytes, uint* pStride)
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3DDevice9*, uint, IDirect3DVertexBuffer9**, uint*, uint*, int>)(lpVtbl[101]))((IDirect3DDevice9*)Unsafe.AsPointer(ref this), StreamNumber, ppStreamData, pOffsetInBytes, pStride);
    }

    /// <include file='IDirect3DDevice9.xml' path='doc/member[@name="IDirect3DDevice9.SetStreamSourceFreq"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(102)]
    public HRESULT SetStreamSourceFreq(uint StreamNumber, uint Setting)
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3DDevice9*, uint, uint, int>)(lpVtbl[102]))((IDirect3DDevice9*)Unsafe.AsPointer(ref this), StreamNumber, Setting);
    }

    /// <include file='IDirect3DDevice9.xml' path='doc/member[@name="IDirect3DDevice9.GetStreamSourceFreq"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(103)]
    public HRESULT GetStreamSourceFreq(uint StreamNumber, uint* pSetting)
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3DDevice9*, uint, uint*, int>)(lpVtbl[103]))((IDirect3DDevice9*)Unsafe.AsPointer(ref this), StreamNumber, pSetting);
    }

    /// <include file='IDirect3DDevice9.xml' path='doc/member[@name="IDirect3DDevice9.SetIndices"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(104)]
    public HRESULT SetIndices(IDirect3DIndexBuffer9* pIndexData)
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3DDevice9*, IDirect3DIndexBuffer9*, int>)(lpVtbl[104]))((IDirect3DDevice9*)Unsafe.AsPointer(ref this), pIndexData);
    }

    /// <include file='IDirect3DDevice9.xml' path='doc/member[@name="IDirect3DDevice9.GetIndices"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(105)]
    public HRESULT GetIndices(IDirect3DIndexBuffer9** ppIndexData)
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3DDevice9*, IDirect3DIndexBuffer9**, int>)(lpVtbl[105]))((IDirect3DDevice9*)Unsafe.AsPointer(ref this), ppIndexData);
    }

    /// <include file='IDirect3DDevice9.xml' path='doc/member[@name="IDirect3DDevice9.CreatePixelShader"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(106)]
    public HRESULT CreatePixelShader([NativeTypeName("const DWORD *")] uint* pFunction, IDirect3DPixelShader9** ppShader)
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3DDevice9*, uint*, IDirect3DPixelShader9**, int>)(lpVtbl[106]))((IDirect3DDevice9*)Unsafe.AsPointer(ref this), pFunction, ppShader);
    }

    /// <include file='IDirect3DDevice9.xml' path='doc/member[@name="IDirect3DDevice9.SetPixelShader"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(107)]
    public HRESULT SetPixelShader(IDirect3DPixelShader9* pShader)
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3DDevice9*, IDirect3DPixelShader9*, int>)(lpVtbl[107]))((IDirect3DDevice9*)Unsafe.AsPointer(ref this), pShader);
    }

    /// <include file='IDirect3DDevice9.xml' path='doc/member[@name="IDirect3DDevice9.GetPixelShader"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(108)]
    public HRESULT GetPixelShader(IDirect3DPixelShader9** ppShader)
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3DDevice9*, IDirect3DPixelShader9**, int>)(lpVtbl[108]))((IDirect3DDevice9*)Unsafe.AsPointer(ref this), ppShader);
    }

    /// <include file='IDirect3DDevice9.xml' path='doc/member[@name="IDirect3DDevice9.SetPixelShaderConstantF"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(109)]
    public HRESULT SetPixelShaderConstantF(uint StartRegister, [NativeTypeName("const float *")] float* pConstantData, uint Vector4fCount)
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3DDevice9*, uint, float*, uint, int>)(lpVtbl[109]))((IDirect3DDevice9*)Unsafe.AsPointer(ref this), StartRegister, pConstantData, Vector4fCount);
    }

    /// <include file='IDirect3DDevice9.xml' path='doc/member[@name="IDirect3DDevice9.GetPixelShaderConstantF"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(110)]
    public HRESULT GetPixelShaderConstantF(uint StartRegister, float* pConstantData, uint Vector4fCount)
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3DDevice9*, uint, float*, uint, int>)(lpVtbl[110]))((IDirect3DDevice9*)Unsafe.AsPointer(ref this), StartRegister, pConstantData, Vector4fCount);
    }

    /// <include file='IDirect3DDevice9.xml' path='doc/member[@name="IDirect3DDevice9.SetPixelShaderConstantI"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(111)]
    public HRESULT SetPixelShaderConstantI(uint StartRegister, [NativeTypeName("const int *")] int* pConstantData, uint Vector4iCount)
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3DDevice9*, uint, int*, uint, int>)(lpVtbl[111]))((IDirect3DDevice9*)Unsafe.AsPointer(ref this), StartRegister, pConstantData, Vector4iCount);
    }

    /// <include file='IDirect3DDevice9.xml' path='doc/member[@name="IDirect3DDevice9.GetPixelShaderConstantI"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(112)]
    public HRESULT GetPixelShaderConstantI(uint StartRegister, int* pConstantData, uint Vector4iCount)
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3DDevice9*, uint, int*, uint, int>)(lpVtbl[112]))((IDirect3DDevice9*)Unsafe.AsPointer(ref this), StartRegister, pConstantData, Vector4iCount);
    }

    /// <include file='IDirect3DDevice9.xml' path='doc/member[@name="IDirect3DDevice9.SetPixelShaderConstantB"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(113)]
    public HRESULT SetPixelShaderConstantB(uint StartRegister, [NativeTypeName("const BOOL *")] BOOL* pConstantData, uint BoolCount)
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3DDevice9*, uint, BOOL*, uint, int>)(lpVtbl[113]))((IDirect3DDevice9*)Unsafe.AsPointer(ref this), StartRegister, pConstantData, BoolCount);
    }

    /// <include file='IDirect3DDevice9.xml' path='doc/member[@name="IDirect3DDevice9.GetPixelShaderConstantB"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(114)]
    public HRESULT GetPixelShaderConstantB(uint StartRegister, BOOL* pConstantData, uint BoolCount)
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3DDevice9*, uint, BOOL*, uint, int>)(lpVtbl[114]))((IDirect3DDevice9*)Unsafe.AsPointer(ref this), StartRegister, pConstantData, BoolCount);
    }

    /// <include file='IDirect3DDevice9.xml' path='doc/member[@name="IDirect3DDevice9.DrawRectPatch"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(115)]
    public HRESULT DrawRectPatch(uint Handle, [NativeTypeName("const float *")] float* pNumSegs, [NativeTypeName("const D3DRECTPATCH_INFO *")] D3DRECTPATCH_INFO* pRectPatchInfo)
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3DDevice9*, uint, float*, D3DRECTPATCH_INFO*, int>)(lpVtbl[115]))((IDirect3DDevice9*)Unsafe.AsPointer(ref this), Handle, pNumSegs, pRectPatchInfo);
    }

    /// <include file='IDirect3DDevice9.xml' path='doc/member[@name="IDirect3DDevice9.DrawTriPatch"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(116)]
    public HRESULT DrawTriPatch(uint Handle, [NativeTypeName("const float *")] float* pNumSegs, [NativeTypeName("const D3DTRIPATCH_INFO *")] D3DTRIPATCH_INFO* pTriPatchInfo)
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3DDevice9*, uint, float*, D3DTRIPATCH_INFO*, int>)(lpVtbl[116]))((IDirect3DDevice9*)Unsafe.AsPointer(ref this), Handle, pNumSegs, pTriPatchInfo);
    }

    /// <include file='IDirect3DDevice9.xml' path='doc/member[@name="IDirect3DDevice9.DeletePatch"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(117)]
    public HRESULT DeletePatch(uint Handle)
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3DDevice9*, uint, int>)(lpVtbl[117]))((IDirect3DDevice9*)Unsafe.AsPointer(ref this), Handle);
    }

    /// <include file='IDirect3DDevice9.xml' path='doc/member[@name="IDirect3DDevice9.CreateQuery"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(118)]
    public HRESULT CreateQuery(D3DQUERYTYPE Type, IDirect3DQuery9** ppQuery)
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3DDevice9*, D3DQUERYTYPE, IDirect3DQuery9**, int>)(lpVtbl[118]))((IDirect3DDevice9*)Unsafe.AsPointer(ref this), Type, ppQuery);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT TestCooperativeLevel();

        [VtblIndex(4)]
        uint GetAvailableTextureMem();

        [VtblIndex(5)]
        HRESULT EvictManagedResources();

        [VtblIndex(6)]
        HRESULT GetDirect3D(IDirect3D9** ppD3D9);

        [VtblIndex(7)]
        HRESULT GetDeviceCaps(D3DCAPS9* pCaps);

        [VtblIndex(8)]
        HRESULT GetDisplayMode(uint iSwapChain, D3DDISPLAYMODE* pMode);

        [VtblIndex(9)]
        HRESULT GetCreationParameters(D3DDEVICE_CREATION_PARAMETERS* pParameters);

        [VtblIndex(10)]
        HRESULT SetCursorProperties(uint XHotSpot, uint YHotSpot, IDirect3DSurface9* pCursorBitmap);

        [VtblIndex(11)]
        void SetCursorPosition(int X, int Y, [NativeTypeName("DWORD")] uint Flags);

        [VtblIndex(12)]
        BOOL ShowCursor(BOOL bShow);

        [VtblIndex(13)]
        HRESULT CreateAdditionalSwapChain(D3DPRESENT_PARAMETERS* pPresentationParameters, IDirect3DSwapChain9** pSwapChain);

        [VtblIndex(14)]
        HRESULT GetSwapChain(uint iSwapChain, IDirect3DSwapChain9** pSwapChain);

        [VtblIndex(15)]
        uint GetNumberOfSwapChains();

        [VtblIndex(16)]
        HRESULT Reset(D3DPRESENT_PARAMETERS* pPresentationParameters);

        [VtblIndex(17)]
        HRESULT Present([NativeTypeName("const RECT *")] RECT* pSourceRect, [NativeTypeName("const RECT *")] RECT* pDestRect, HWND hDestWindowOverride, [NativeTypeName("const RGNDATA *")] RGNDATA* pDirtyRegion);

        [VtblIndex(18)]
        HRESULT GetBackBuffer(uint iSwapChain, uint iBackBuffer, D3DBACKBUFFER_TYPE Type, IDirect3DSurface9** ppBackBuffer);

        [VtblIndex(19)]
        HRESULT GetRasterStatus(uint iSwapChain, D3DRASTER_STATUS* pRasterStatus);

        [VtblIndex(20)]
        HRESULT SetDialogBoxMode(BOOL bEnableDialogs);

        [VtblIndex(21)]
        void SetGammaRamp(uint iSwapChain, [NativeTypeName("DWORD")] uint Flags, [NativeTypeName("const D3DGAMMARAMP *")] D3DGAMMARAMP* pRamp);

        [VtblIndex(22)]
        void GetGammaRamp(uint iSwapChain, D3DGAMMARAMP* pRamp);

        [VtblIndex(23)]
        HRESULT CreateTexture(uint Width, uint Height, uint Levels, [NativeTypeName("DWORD")] uint Usage, D3DFORMAT Format, D3DPOOL Pool, IDirect3DTexture9** ppTexture, HANDLE* pSharedHandle);

        [VtblIndex(24)]
        HRESULT CreateVolumeTexture(uint Width, uint Height, uint Depth, uint Levels, [NativeTypeName("DWORD")] uint Usage, D3DFORMAT Format, D3DPOOL Pool, IDirect3DVolumeTexture9** ppVolumeTexture, HANDLE* pSharedHandle);

        [VtblIndex(25)]
        HRESULT CreateCubeTexture(uint EdgeLength, uint Levels, [NativeTypeName("DWORD")] uint Usage, D3DFORMAT Format, D3DPOOL Pool, IDirect3DCubeTexture9** ppCubeTexture, HANDLE* pSharedHandle);

        [VtblIndex(26)]
        HRESULT CreateVertexBuffer(uint Length, [NativeTypeName("DWORD")] uint Usage, [NativeTypeName("DWORD")] uint FVF, D3DPOOL Pool, IDirect3DVertexBuffer9** ppVertexBuffer, HANDLE* pSharedHandle);

        [VtblIndex(27)]
        HRESULT CreateIndexBuffer(uint Length, [NativeTypeName("DWORD")] uint Usage, D3DFORMAT Format, D3DPOOL Pool, IDirect3DIndexBuffer9** ppIndexBuffer, HANDLE* pSharedHandle);

        [VtblIndex(28)]
        HRESULT CreateRenderTarget(uint Width, uint Height, D3DFORMAT Format, D3DMULTISAMPLE_TYPE MultiSample, [NativeTypeName("DWORD")] uint MultisampleQuality, BOOL Lockable, IDirect3DSurface9** ppSurface, HANDLE* pSharedHandle);

        [VtblIndex(29)]
        HRESULT CreateDepthStencilSurface(uint Width, uint Height, D3DFORMAT Format, D3DMULTISAMPLE_TYPE MultiSample, [NativeTypeName("DWORD")] uint MultisampleQuality, BOOL Discard, IDirect3DSurface9** ppSurface, HANDLE* pSharedHandle);

        [VtblIndex(30)]
        HRESULT UpdateSurface(IDirect3DSurface9* pSourceSurface, [NativeTypeName("const RECT *")] RECT* pSourceRect, IDirect3DSurface9* pDestinationSurface, [NativeTypeName("const POINT *")] POINT* pDestPoint);

        [VtblIndex(31)]
        HRESULT UpdateTexture(IDirect3DBaseTexture9* pSourceTexture, IDirect3DBaseTexture9* pDestinationTexture);

        [VtblIndex(32)]
        HRESULT GetRenderTargetData(IDirect3DSurface9* pRenderTarget, IDirect3DSurface9* pDestSurface);

        [VtblIndex(33)]
        HRESULT GetFrontBufferData(uint iSwapChain, IDirect3DSurface9* pDestSurface);

        [VtblIndex(34)]
        HRESULT StretchRect(IDirect3DSurface9* pSourceSurface, [NativeTypeName("const RECT *")] RECT* pSourceRect, IDirect3DSurface9* pDestSurface, [NativeTypeName("const RECT *")] RECT* pDestRect, D3DTEXTUREFILTERTYPE Filter);

        [VtblIndex(35)]
        HRESULT ColorFill(IDirect3DSurface9* pSurface, [NativeTypeName("const RECT *")] RECT* pRect, [NativeTypeName("D3DCOLOR")] uint color);

        [VtblIndex(36)]
        HRESULT CreateOffscreenPlainSurface(uint Width, uint Height, D3DFORMAT Format, D3DPOOL Pool, IDirect3DSurface9** ppSurface, HANDLE* pSharedHandle);

        [VtblIndex(37)]
        HRESULT SetRenderTarget([NativeTypeName("DWORD")] uint RenderTargetIndex, IDirect3DSurface9* pRenderTarget);

        [VtblIndex(38)]
        HRESULT GetRenderTarget([NativeTypeName("DWORD")] uint RenderTargetIndex, IDirect3DSurface9** ppRenderTarget);

        [VtblIndex(39)]
        HRESULT SetDepthStencilSurface(IDirect3DSurface9* pNewZStencil);

        [VtblIndex(40)]
        HRESULT GetDepthStencilSurface(IDirect3DSurface9** ppZStencilSurface);

        [VtblIndex(41)]
        HRESULT BeginScene();

        [VtblIndex(42)]
        HRESULT EndScene();

        [VtblIndex(43)]
        HRESULT Clear([NativeTypeName("DWORD")] uint Count, [NativeTypeName("const D3DRECT *")] D3DRECT* pRects, [NativeTypeName("DWORD")] uint Flags, [NativeTypeName("D3DCOLOR")] uint Color, float Z, [NativeTypeName("DWORD")] uint Stencil);

        [VtblIndex(44)]
        HRESULT SetTransform(D3DTRANSFORMSTATETYPE State, [NativeTypeName("const D3DMATRIX *")] D2D_MATRIX_4X4_F* pMatrix);

        [VtblIndex(45)]
        HRESULT GetTransform(D3DTRANSFORMSTATETYPE State, [NativeTypeName("D3DMATRIX *")] D2D_MATRIX_4X4_F* pMatrix);

        [VtblIndex(46)]
        HRESULT MultiplyTransform(D3DTRANSFORMSTATETYPE param0, [NativeTypeName("const D3DMATRIX *")] D2D_MATRIX_4X4_F* param1);

        [VtblIndex(47)]
        HRESULT SetViewport([NativeTypeName("const D3DVIEWPORT9 *")] D3DVIEWPORT9* pViewport);

        [VtblIndex(48)]
        HRESULT GetViewport(D3DVIEWPORT9* pViewport);

        [VtblIndex(49)]
        HRESULT SetMaterial([NativeTypeName("const D3DMATERIAL9 *")] D3DMATERIAL9* pMaterial);

        [VtblIndex(50)]
        HRESULT GetMaterial(D3DMATERIAL9* pMaterial);

        [VtblIndex(51)]
        HRESULT SetLight([NativeTypeName("DWORD")] uint Index, [NativeTypeName("const D3DLIGHT9 *")] D3DLIGHT9* param1);

        [VtblIndex(52)]
        HRESULT GetLight([NativeTypeName("DWORD")] uint Index, D3DLIGHT9* param1);

        [VtblIndex(53)]
        HRESULT LightEnable([NativeTypeName("DWORD")] uint Index, BOOL Enable);

        [VtblIndex(54)]
        HRESULT GetLightEnable([NativeTypeName("DWORD")] uint Index, BOOL* pEnable);

        [VtblIndex(55)]
        HRESULT SetClipPlane([NativeTypeName("DWORD")] uint Index, [NativeTypeName("const float *")] float* pPlane);

        [VtblIndex(56)]
        HRESULT GetClipPlane([NativeTypeName("DWORD")] uint Index, float* pPlane);

        [VtblIndex(57)]
        HRESULT SetRenderState(D3DRENDERSTATETYPE State, [NativeTypeName("DWORD")] uint Value);

        [VtblIndex(58)]
        HRESULT GetRenderState(D3DRENDERSTATETYPE State, [NativeTypeName("DWORD *")] uint* pValue);

        [VtblIndex(59)]
        HRESULT CreateStateBlock(D3DSTATEBLOCKTYPE Type, IDirect3DStateBlock9** ppSB);

        [VtblIndex(60)]
        HRESULT BeginStateBlock();

        [VtblIndex(61)]
        HRESULT EndStateBlock(IDirect3DStateBlock9** ppSB);

        [VtblIndex(62)]
        HRESULT SetClipStatus([NativeTypeName("const D3DCLIPSTATUS9 *")] D3DCLIPSTATUS9* pClipStatus);

        [VtblIndex(63)]
        HRESULT GetClipStatus(D3DCLIPSTATUS9* pClipStatus);

        [VtblIndex(64)]
        HRESULT GetTexture([NativeTypeName("DWORD")] uint Stage, IDirect3DBaseTexture9** ppTexture);

        [VtblIndex(65)]
        HRESULT SetTexture([NativeTypeName("DWORD")] uint Stage, IDirect3DBaseTexture9* pTexture);

        [VtblIndex(66)]
        HRESULT GetTextureStageState([NativeTypeName("DWORD")] uint Stage, D3DTEXTURESTAGESTATETYPE Type, [NativeTypeName("DWORD *")] uint* pValue);

        [VtblIndex(67)]
        HRESULT SetTextureStageState([NativeTypeName("DWORD")] uint Stage, D3DTEXTURESTAGESTATETYPE Type, [NativeTypeName("DWORD")] uint Value);

        [VtblIndex(68)]
        HRESULT GetSamplerState([NativeTypeName("DWORD")] uint Sampler, D3DSAMPLERSTATETYPE Type, [NativeTypeName("DWORD *")] uint* pValue);

        [VtblIndex(69)]
        HRESULT SetSamplerState([NativeTypeName("DWORD")] uint Sampler, D3DSAMPLERSTATETYPE Type, [NativeTypeName("DWORD")] uint Value);

        [VtblIndex(70)]
        HRESULT ValidateDevice([NativeTypeName("DWORD *")] uint* pNumPasses);

        [VtblIndex(71)]
        HRESULT SetPaletteEntries(uint PaletteNumber, [NativeTypeName("const PALETTEENTRY *")] PALETTEENTRY* pEntries);

        [VtblIndex(72)]
        HRESULT GetPaletteEntries(uint PaletteNumber, PALETTEENTRY* pEntries);

        [VtblIndex(73)]
        HRESULT SetCurrentTexturePalette(uint PaletteNumber);

        [VtblIndex(74)]
        HRESULT GetCurrentTexturePalette(uint* PaletteNumber);

        [VtblIndex(75)]
        HRESULT SetScissorRect([NativeTypeName("const RECT *")] RECT* pRect);

        [VtblIndex(76)]
        HRESULT GetScissorRect(RECT* pRect);

        [VtblIndex(77)]
        HRESULT SetSoftwareVertexProcessing(BOOL bSoftware);

        [VtblIndex(78)]
        BOOL GetSoftwareVertexProcessing();

        [VtblIndex(79)]
        HRESULT SetNPatchMode(float nSegments);

        [VtblIndex(80)]
        float GetNPatchMode();

        [VtblIndex(81)]
        HRESULT DrawPrimitive(D3DPRIMITIVETYPE PrimitiveType, uint StartVertex, uint PrimitiveCount);

        [VtblIndex(82)]
        HRESULT DrawIndexedPrimitive(D3DPRIMITIVETYPE param0, int BaseVertexIndex, uint MinVertexIndex, uint NumVertices, uint startIndex, uint primCount);

        [VtblIndex(83)]
        HRESULT DrawPrimitiveUP(D3DPRIMITIVETYPE PrimitiveType, uint PrimitiveCount, [NativeTypeName("const void *")] void* pVertexStreamZeroData, uint VertexStreamZeroStride);

        [VtblIndex(84)]
        HRESULT DrawIndexedPrimitiveUP(D3DPRIMITIVETYPE PrimitiveType, uint MinVertexIndex, uint NumVertices, uint PrimitiveCount, [NativeTypeName("const void *")] void* pIndexData, D3DFORMAT IndexDataFormat, [NativeTypeName("const void *")] void* pVertexStreamZeroData, uint VertexStreamZeroStride);

        [VtblIndex(85)]
        HRESULT ProcessVertices(uint SrcStartIndex, uint DestIndex, uint VertexCount, IDirect3DVertexBuffer9* pDestBuffer, IDirect3DVertexDeclaration9* pVertexDecl, [NativeTypeName("DWORD")] uint Flags);

        [VtblIndex(86)]
        HRESULT CreateVertexDeclaration([NativeTypeName("const D3DVERTEXELEMENT9 *")] D3DVERTEXELEMENT9* pVertexElements, IDirect3DVertexDeclaration9** ppDecl);

        [VtblIndex(87)]
        HRESULT SetVertexDeclaration(IDirect3DVertexDeclaration9* pDecl);

        [VtblIndex(88)]
        HRESULT GetVertexDeclaration(IDirect3DVertexDeclaration9** ppDecl);

        [VtblIndex(89)]
        HRESULT SetFVF([NativeTypeName("DWORD")] uint FVF);

        [VtblIndex(90)]
        HRESULT GetFVF([NativeTypeName("DWORD *")] uint* pFVF);

        [VtblIndex(91)]
        HRESULT CreateVertexShader([NativeTypeName("const DWORD *")] uint* pFunction, IDirect3DVertexShader9** ppShader);

        [VtblIndex(92)]
        HRESULT SetVertexShader(IDirect3DVertexShader9* pShader);

        [VtblIndex(93)]
        HRESULT GetVertexShader(IDirect3DVertexShader9** ppShader);

        [VtblIndex(94)]
        HRESULT SetVertexShaderConstantF(uint StartRegister, [NativeTypeName("const float *")] float* pConstantData, uint Vector4fCount);

        [VtblIndex(95)]
        HRESULT GetVertexShaderConstantF(uint StartRegister, float* pConstantData, uint Vector4fCount);

        [VtblIndex(96)]
        HRESULT SetVertexShaderConstantI(uint StartRegister, [NativeTypeName("const int *")] int* pConstantData, uint Vector4iCount);

        [VtblIndex(97)]
        HRESULT GetVertexShaderConstantI(uint StartRegister, int* pConstantData, uint Vector4iCount);

        [VtblIndex(98)]
        HRESULT SetVertexShaderConstantB(uint StartRegister, [NativeTypeName("const BOOL *")] BOOL* pConstantData, uint BoolCount);

        [VtblIndex(99)]
        HRESULT GetVertexShaderConstantB(uint StartRegister, BOOL* pConstantData, uint BoolCount);

        [VtblIndex(100)]
        HRESULT SetStreamSource(uint StreamNumber, IDirect3DVertexBuffer9* pStreamData, uint OffsetInBytes, uint Stride);

        [VtblIndex(101)]
        HRESULT GetStreamSource(uint StreamNumber, IDirect3DVertexBuffer9** ppStreamData, uint* pOffsetInBytes, uint* pStride);

        [VtblIndex(102)]
        HRESULT SetStreamSourceFreq(uint StreamNumber, uint Setting);

        [VtblIndex(103)]
        HRESULT GetStreamSourceFreq(uint StreamNumber, uint* pSetting);

        [VtblIndex(104)]
        HRESULT SetIndices(IDirect3DIndexBuffer9* pIndexData);

        [VtblIndex(105)]
        HRESULT GetIndices(IDirect3DIndexBuffer9** ppIndexData);

        [VtblIndex(106)]
        HRESULT CreatePixelShader([NativeTypeName("const DWORD *")] uint* pFunction, IDirect3DPixelShader9** ppShader);

        [VtblIndex(107)]
        HRESULT SetPixelShader(IDirect3DPixelShader9* pShader);

        [VtblIndex(108)]
        HRESULT GetPixelShader(IDirect3DPixelShader9** ppShader);

        [VtblIndex(109)]
        HRESULT SetPixelShaderConstantF(uint StartRegister, [NativeTypeName("const float *")] float* pConstantData, uint Vector4fCount);

        [VtblIndex(110)]
        HRESULT GetPixelShaderConstantF(uint StartRegister, float* pConstantData, uint Vector4fCount);

        [VtblIndex(111)]
        HRESULT SetPixelShaderConstantI(uint StartRegister, [NativeTypeName("const int *")] int* pConstantData, uint Vector4iCount);

        [VtblIndex(112)]
        HRESULT GetPixelShaderConstantI(uint StartRegister, int* pConstantData, uint Vector4iCount);

        [VtblIndex(113)]
        HRESULT SetPixelShaderConstantB(uint StartRegister, [NativeTypeName("const BOOL *")] BOOL* pConstantData, uint BoolCount);

        [VtblIndex(114)]
        HRESULT GetPixelShaderConstantB(uint StartRegister, BOOL* pConstantData, uint BoolCount);

        [VtblIndex(115)]
        HRESULT DrawRectPatch(uint Handle, [NativeTypeName("const float *")] float* pNumSegs, [NativeTypeName("const D3DRECTPATCH_INFO *")] D3DRECTPATCH_INFO* pRectPatchInfo);

        [VtblIndex(116)]
        HRESULT DrawTriPatch(uint Handle, [NativeTypeName("const float *")] float* pNumSegs, [NativeTypeName("const D3DTRIPATCH_INFO *")] D3DTRIPATCH_INFO* pTriPatchInfo);

        [VtblIndex(117)]
        HRESULT DeletePatch(uint Handle);

        [VtblIndex(118)]
        HRESULT CreateQuery(D3DQUERYTYPE Type, IDirect3DQuery9** ppQuery);
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

        [NativeTypeName("HRESULT () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> TestCooperativeLevel;

        [NativeTypeName("UINT () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint> GetAvailableTextureMem;

        [NativeTypeName("HRESULT () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> EvictManagedResources;

        [NativeTypeName("HRESULT (IDirect3D9 **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IDirect3D9**, int> GetDirect3D;

        [NativeTypeName("HRESULT (D3DCAPS9 *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, D3DCAPS9*, int> GetDeviceCaps;

        [NativeTypeName("HRESULT (UINT, D3DDISPLAYMODE *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, D3DDISPLAYMODE*, int> GetDisplayMode;

        [NativeTypeName("HRESULT (D3DDEVICE_CREATION_PARAMETERS *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, D3DDEVICE_CREATION_PARAMETERS*, int> GetCreationParameters;

        [NativeTypeName("HRESULT (UINT, UINT, IDirect3DSurface9 *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, uint, IDirect3DSurface9*, int> SetCursorProperties;

        [NativeTypeName("void (int, int, DWORD) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int, int, uint, void> SetCursorPosition;

        [NativeTypeName("BOOL (BOOL) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, BOOL, int> ShowCursor;

        [NativeTypeName("HRESULT (D3DPRESENT_PARAMETERS *, IDirect3DSwapChain9 **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, D3DPRESENT_PARAMETERS*, IDirect3DSwapChain9**, int> CreateAdditionalSwapChain;

        [NativeTypeName("HRESULT (UINT, IDirect3DSwapChain9 **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, IDirect3DSwapChain9**, int> GetSwapChain;

        [NativeTypeName("UINT () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint> GetNumberOfSwapChains;

        [NativeTypeName("HRESULT (D3DPRESENT_PARAMETERS *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, D3DPRESENT_PARAMETERS*, int> Reset;

        [NativeTypeName("HRESULT (const RECT *, const RECT *, HWND, const RGNDATA *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, RECT*, RECT*, HWND, RGNDATA*, int> Present;

        [NativeTypeName("HRESULT (UINT, UINT, D3DBACKBUFFER_TYPE, IDirect3DSurface9 **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, uint, D3DBACKBUFFER_TYPE, IDirect3DSurface9**, int> GetBackBuffer;

        [NativeTypeName("HRESULT (UINT, D3DRASTER_STATUS *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, D3DRASTER_STATUS*, int> GetRasterStatus;

        [NativeTypeName("HRESULT (BOOL) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, BOOL, int> SetDialogBoxMode;

        [NativeTypeName("void (UINT, DWORD, const D3DGAMMARAMP *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, uint, D3DGAMMARAMP*, void> SetGammaRamp;

        [NativeTypeName("void (UINT, D3DGAMMARAMP *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, D3DGAMMARAMP*, void> GetGammaRamp;

        [NativeTypeName("HRESULT (UINT, UINT, UINT, DWORD, D3DFORMAT, D3DPOOL, IDirect3DTexture9 **, HANDLE *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, uint, uint, uint, D3DFORMAT, D3DPOOL, IDirect3DTexture9**, HANDLE*, int> CreateTexture;

        [NativeTypeName("HRESULT (UINT, UINT, UINT, UINT, DWORD, D3DFORMAT, D3DPOOL, IDirect3DVolumeTexture9 **, HANDLE *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, uint, uint, uint, uint, D3DFORMAT, D3DPOOL, IDirect3DVolumeTexture9**, HANDLE*, int> CreateVolumeTexture;

        [NativeTypeName("HRESULT (UINT, UINT, DWORD, D3DFORMAT, D3DPOOL, IDirect3DCubeTexture9 **, HANDLE *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, uint, uint, D3DFORMAT, D3DPOOL, IDirect3DCubeTexture9**, HANDLE*, int> CreateCubeTexture;

        [NativeTypeName("HRESULT (UINT, DWORD, DWORD, D3DPOOL, IDirect3DVertexBuffer9 **, HANDLE *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, uint, uint, D3DPOOL, IDirect3DVertexBuffer9**, HANDLE*, int> CreateVertexBuffer;

        [NativeTypeName("HRESULT (UINT, DWORD, D3DFORMAT, D3DPOOL, IDirect3DIndexBuffer9 **, HANDLE *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, uint, D3DFORMAT, D3DPOOL, IDirect3DIndexBuffer9**, HANDLE*, int> CreateIndexBuffer;

        [NativeTypeName("HRESULT (UINT, UINT, D3DFORMAT, D3DMULTISAMPLE_TYPE, DWORD, BOOL, IDirect3DSurface9 **, HANDLE *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, uint, D3DFORMAT, D3DMULTISAMPLE_TYPE, uint, BOOL, IDirect3DSurface9**, HANDLE*, int> CreateRenderTarget;

        [NativeTypeName("HRESULT (UINT, UINT, D3DFORMAT, D3DMULTISAMPLE_TYPE, DWORD, BOOL, IDirect3DSurface9 **, HANDLE *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, uint, D3DFORMAT, D3DMULTISAMPLE_TYPE, uint, BOOL, IDirect3DSurface9**, HANDLE*, int> CreateDepthStencilSurface;

        [NativeTypeName("HRESULT (IDirect3DSurface9 *, const RECT *, IDirect3DSurface9 *, const POINT *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IDirect3DSurface9*, RECT*, IDirect3DSurface9*, POINT*, int> UpdateSurface;

        [NativeTypeName("HRESULT (IDirect3DBaseTexture9 *, IDirect3DBaseTexture9 *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IDirect3DBaseTexture9*, IDirect3DBaseTexture9*, int> UpdateTexture;

        [NativeTypeName("HRESULT (IDirect3DSurface9 *, IDirect3DSurface9 *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IDirect3DSurface9*, IDirect3DSurface9*, int> GetRenderTargetData;

        [NativeTypeName("HRESULT (UINT, IDirect3DSurface9 *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, IDirect3DSurface9*, int> GetFrontBufferData;

        [NativeTypeName("HRESULT (IDirect3DSurface9 *, const RECT *, IDirect3DSurface9 *, const RECT *, D3DTEXTUREFILTERTYPE) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IDirect3DSurface9*, RECT*, IDirect3DSurface9*, RECT*, D3DTEXTUREFILTERTYPE, int> StretchRect;

        [NativeTypeName("HRESULT (IDirect3DSurface9 *, const RECT *, D3DCOLOR) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IDirect3DSurface9*, RECT*, uint, int> ColorFill;

        [NativeTypeName("HRESULT (UINT, UINT, D3DFORMAT, D3DPOOL, IDirect3DSurface9 **, HANDLE *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, uint, D3DFORMAT, D3DPOOL, IDirect3DSurface9**, HANDLE*, int> CreateOffscreenPlainSurface;

        [NativeTypeName("HRESULT (DWORD, IDirect3DSurface9 *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, IDirect3DSurface9*, int> SetRenderTarget;

        [NativeTypeName("HRESULT (DWORD, IDirect3DSurface9 **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, IDirect3DSurface9**, int> GetRenderTarget;

        [NativeTypeName("HRESULT (IDirect3DSurface9 *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IDirect3DSurface9*, int> SetDepthStencilSurface;

        [NativeTypeName("HRESULT (IDirect3DSurface9 **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IDirect3DSurface9**, int> GetDepthStencilSurface;

        [NativeTypeName("HRESULT () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> BeginScene;

        [NativeTypeName("HRESULT () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> EndScene;

        [NativeTypeName("HRESULT (DWORD, const D3DRECT *, DWORD, D3DCOLOR, float, DWORD) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, D3DRECT*, uint, uint, float, uint, int> Clear;

        [NativeTypeName("HRESULT (D3DTRANSFORMSTATETYPE, const D3DMATRIX *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, D3DTRANSFORMSTATETYPE, D2D_MATRIX_4X4_F*, int> SetTransform;

        [NativeTypeName("HRESULT (D3DTRANSFORMSTATETYPE, D3DMATRIX *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, D3DTRANSFORMSTATETYPE, D2D_MATRIX_4X4_F*, int> GetTransform;

        [NativeTypeName("HRESULT (D3DTRANSFORMSTATETYPE, const D3DMATRIX *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, D3DTRANSFORMSTATETYPE, D2D_MATRIX_4X4_F*, int> MultiplyTransform;

        [NativeTypeName("HRESULT (const D3DVIEWPORT9 *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, D3DVIEWPORT9*, int> SetViewport;

        [NativeTypeName("HRESULT (D3DVIEWPORT9 *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, D3DVIEWPORT9*, int> GetViewport;

        [NativeTypeName("HRESULT (const D3DMATERIAL9 *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, D3DMATERIAL9*, int> SetMaterial;

        [NativeTypeName("HRESULT (D3DMATERIAL9 *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, D3DMATERIAL9*, int> GetMaterial;

        [NativeTypeName("HRESULT (DWORD, const D3DLIGHT9 *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, D3DLIGHT9*, int> SetLight;

        [NativeTypeName("HRESULT (DWORD, D3DLIGHT9 *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, D3DLIGHT9*, int> GetLight;

        [NativeTypeName("HRESULT (DWORD, BOOL) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, BOOL, int> LightEnable;

        [NativeTypeName("HRESULT (DWORD, BOOL *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, BOOL*, int> GetLightEnable;

        [NativeTypeName("HRESULT (DWORD, const float *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, float*, int> SetClipPlane;

        [NativeTypeName("HRESULT (DWORD, float *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, float*, int> GetClipPlane;

        [NativeTypeName("HRESULT (D3DRENDERSTATETYPE, DWORD) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, D3DRENDERSTATETYPE, uint, int> SetRenderState;

        [NativeTypeName("HRESULT (D3DRENDERSTATETYPE, DWORD *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, D3DRENDERSTATETYPE, uint*, int> GetRenderState;

        [NativeTypeName("HRESULT (D3DSTATEBLOCKTYPE, IDirect3DStateBlock9 **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, D3DSTATEBLOCKTYPE, IDirect3DStateBlock9**, int> CreateStateBlock;

        [NativeTypeName("HRESULT () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> BeginStateBlock;

        [NativeTypeName("HRESULT (IDirect3DStateBlock9 **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IDirect3DStateBlock9**, int> EndStateBlock;

        [NativeTypeName("HRESULT (const D3DCLIPSTATUS9 *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, D3DCLIPSTATUS9*, int> SetClipStatus;

        [NativeTypeName("HRESULT (D3DCLIPSTATUS9 *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, D3DCLIPSTATUS9*, int> GetClipStatus;

        [NativeTypeName("HRESULT (DWORD, IDirect3DBaseTexture9 **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, IDirect3DBaseTexture9**, int> GetTexture;

        [NativeTypeName("HRESULT (DWORD, IDirect3DBaseTexture9 *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, IDirect3DBaseTexture9*, int> SetTexture;

        [NativeTypeName("HRESULT (DWORD, D3DTEXTURESTAGESTATETYPE, DWORD *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, D3DTEXTURESTAGESTATETYPE, uint*, int> GetTextureStageState;

        [NativeTypeName("HRESULT (DWORD, D3DTEXTURESTAGESTATETYPE, DWORD) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, D3DTEXTURESTAGESTATETYPE, uint, int> SetTextureStageState;

        [NativeTypeName("HRESULT (DWORD, D3DSAMPLERSTATETYPE, DWORD *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, D3DSAMPLERSTATETYPE, uint*, int> GetSamplerState;

        [NativeTypeName("HRESULT (DWORD, D3DSAMPLERSTATETYPE, DWORD) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, D3DSAMPLERSTATETYPE, uint, int> SetSamplerState;

        [NativeTypeName("HRESULT (DWORD *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> ValidateDevice;

        [NativeTypeName("HRESULT (UINT, const PALETTEENTRY *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, PALETTEENTRY*, int> SetPaletteEntries;

        [NativeTypeName("HRESULT (UINT, PALETTEENTRY *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, PALETTEENTRY*, int> GetPaletteEntries;

        [NativeTypeName("HRESULT (UINT) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, int> SetCurrentTexturePalette;

        [NativeTypeName("HRESULT (UINT *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> GetCurrentTexturePalette;

        [NativeTypeName("HRESULT (const RECT *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, RECT*, int> SetScissorRect;

        [NativeTypeName("HRESULT (RECT *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, RECT*, int> GetScissorRect;

        [NativeTypeName("HRESULT (BOOL) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, BOOL, int> SetSoftwareVertexProcessing;

        [NativeTypeName("BOOL () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> GetSoftwareVertexProcessing;

        [NativeTypeName("HRESULT (float) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, float, int> SetNPatchMode;

        [NativeTypeName("float () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, float> GetNPatchMode;

        [NativeTypeName("HRESULT (D3DPRIMITIVETYPE, UINT, UINT) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, D3DPRIMITIVETYPE, uint, uint, int> DrawPrimitive;

        [NativeTypeName("HRESULT (D3DPRIMITIVETYPE, INT, UINT, UINT, UINT, UINT) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, D3DPRIMITIVETYPE, int, uint, uint, uint, uint, int> DrawIndexedPrimitive;

        [NativeTypeName("HRESULT (D3DPRIMITIVETYPE, UINT, const void *, UINT) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, D3DPRIMITIVETYPE, uint, void*, uint, int> DrawPrimitiveUP;

        [NativeTypeName("HRESULT (D3DPRIMITIVETYPE, UINT, UINT, UINT, const void *, D3DFORMAT, const void *, UINT) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, D3DPRIMITIVETYPE, uint, uint, uint, void*, D3DFORMAT, void*, uint, int> DrawIndexedPrimitiveUP;

        [NativeTypeName("HRESULT (UINT, UINT, UINT, IDirect3DVertexBuffer9 *, IDirect3DVertexDeclaration9 *, DWORD) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, uint, uint, IDirect3DVertexBuffer9*, IDirect3DVertexDeclaration9*, uint, int> ProcessVertices;

        [NativeTypeName("HRESULT (const D3DVERTEXELEMENT9 *, IDirect3DVertexDeclaration9 **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, D3DVERTEXELEMENT9*, IDirect3DVertexDeclaration9**, int> CreateVertexDeclaration;

        [NativeTypeName("HRESULT (IDirect3DVertexDeclaration9 *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IDirect3DVertexDeclaration9*, int> SetVertexDeclaration;

        [NativeTypeName("HRESULT (IDirect3DVertexDeclaration9 **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IDirect3DVertexDeclaration9**, int> GetVertexDeclaration;

        [NativeTypeName("HRESULT (DWORD) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, int> SetFVF;

        [NativeTypeName("HRESULT (DWORD *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> GetFVF;

        [NativeTypeName("HRESULT (const DWORD *, IDirect3DVertexShader9 **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, IDirect3DVertexShader9**, int> CreateVertexShader;

        [NativeTypeName("HRESULT (IDirect3DVertexShader9 *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IDirect3DVertexShader9*, int> SetVertexShader;

        [NativeTypeName("HRESULT (IDirect3DVertexShader9 **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IDirect3DVertexShader9**, int> GetVertexShader;

        [NativeTypeName("HRESULT (UINT, const float *, UINT) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, float*, uint, int> SetVertexShaderConstantF;

        [NativeTypeName("HRESULT (UINT, float *, UINT) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, float*, uint, int> GetVertexShaderConstantF;

        [NativeTypeName("HRESULT (UINT, const int *, UINT) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, int*, uint, int> SetVertexShaderConstantI;

        [NativeTypeName("HRESULT (UINT, int *, UINT) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, int*, uint, int> GetVertexShaderConstantI;

        [NativeTypeName("HRESULT (UINT, const BOOL *, UINT) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, BOOL*, uint, int> SetVertexShaderConstantB;

        [NativeTypeName("HRESULT (UINT, BOOL *, UINT) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, BOOL*, uint, int> GetVertexShaderConstantB;

        [NativeTypeName("HRESULT (UINT, IDirect3DVertexBuffer9 *, UINT, UINT) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, IDirect3DVertexBuffer9*, uint, uint, int> SetStreamSource;

        [NativeTypeName("HRESULT (UINT, IDirect3DVertexBuffer9 **, UINT *, UINT *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, IDirect3DVertexBuffer9**, uint*, uint*, int> GetStreamSource;

        [NativeTypeName("HRESULT (UINT, UINT) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, uint, int> SetStreamSourceFreq;

        [NativeTypeName("HRESULT (UINT, UINT *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, uint*, int> GetStreamSourceFreq;

        [NativeTypeName("HRESULT (IDirect3DIndexBuffer9 *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IDirect3DIndexBuffer9*, int> SetIndices;

        [NativeTypeName("HRESULT (IDirect3DIndexBuffer9 **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IDirect3DIndexBuffer9**, int> GetIndices;

        [NativeTypeName("HRESULT (const DWORD *, IDirect3DPixelShader9 **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, IDirect3DPixelShader9**, int> CreatePixelShader;

        [NativeTypeName("HRESULT (IDirect3DPixelShader9 *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IDirect3DPixelShader9*, int> SetPixelShader;

        [NativeTypeName("HRESULT (IDirect3DPixelShader9 **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IDirect3DPixelShader9**, int> GetPixelShader;

        [NativeTypeName("HRESULT (UINT, const float *, UINT) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, float*, uint, int> SetPixelShaderConstantF;

        [NativeTypeName("HRESULT (UINT, float *, UINT) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, float*, uint, int> GetPixelShaderConstantF;

        [NativeTypeName("HRESULT (UINT, const int *, UINT) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, int*, uint, int> SetPixelShaderConstantI;

        [NativeTypeName("HRESULT (UINT, int *, UINT) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, int*, uint, int> GetPixelShaderConstantI;

        [NativeTypeName("HRESULT (UINT, const BOOL *, UINT) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, BOOL*, uint, int> SetPixelShaderConstantB;

        [NativeTypeName("HRESULT (UINT, BOOL *, UINT) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, BOOL*, uint, int> GetPixelShaderConstantB;

        [NativeTypeName("HRESULT (UINT, const float *, const D3DRECTPATCH_INFO *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, float*, D3DRECTPATCH_INFO*, int> DrawRectPatch;

        [NativeTypeName("HRESULT (UINT, const float *, const D3DTRIPATCH_INFO *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, float*, D3DTRIPATCH_INFO*, int> DrawTriPatch;

        [NativeTypeName("HRESULT (UINT) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, int> DeletePatch;

        [NativeTypeName("HRESULT (D3DQUERYTYPE, IDirect3DQuery9 **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, D3DQUERYTYPE, IDirect3DQuery9**, int> CreateQuery;
    }
}
