// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/d3d9.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.DirectX;

/// <include file='IDirect3D9Ex.xml' path='doc/member[@name="IDirect3D9Ex"]/*' />
[Guid("02177241-69FC-400C-8FF1-93A44DF6861D")]
[NativeTypeName("struct IDirect3D9Ex : IDirect3D9")]
[NativeInheritance("IDirect3D9")]
public unsafe partial struct IDirect3D9Ex : IDirect3D9Ex.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IDirect3D9Ex);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3D9Ex*, Guid*, void**, int>)(lpVtbl[0]))((IDirect3D9Ex*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3D9Ex*, uint>)(lpVtbl[1]))((IDirect3D9Ex*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3D9Ex*, uint>)(lpVtbl[2]))((IDirect3D9Ex*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IDirect3D9.RegisterSoftwareDevice" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT RegisterSoftwareDevice(void* pInitializeFunction)
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3D9Ex*, void*, int>)(lpVtbl[3]))((IDirect3D9Ex*)Unsafe.AsPointer(ref this), pInitializeFunction);
    }

    /// <inheritdoc cref="IDirect3D9.GetAdapterCount" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public uint GetAdapterCount()
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3D9Ex*, uint>)(lpVtbl[4]))((IDirect3D9Ex*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IDirect3D9.GetAdapterIdentifier" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetAdapterIdentifier(uint Adapter, [NativeTypeName("DWORD")] uint Flags, D3DADAPTER_IDENTIFIER9* pIdentifier)
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3D9Ex*, uint, uint, D3DADAPTER_IDENTIFIER9*, int>)(lpVtbl[5]))((IDirect3D9Ex*)Unsafe.AsPointer(ref this), Adapter, Flags, pIdentifier);
    }

    /// <inheritdoc cref="IDirect3D9.GetAdapterModeCount" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public uint GetAdapterModeCount(uint Adapter, D3DFORMAT Format)
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3D9Ex*, uint, D3DFORMAT, uint>)(lpVtbl[6]))((IDirect3D9Ex*)Unsafe.AsPointer(ref this), Adapter, Format);
    }

    /// <inheritdoc cref="IDirect3D9.EnumAdapterModes" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT EnumAdapterModes(uint Adapter, D3DFORMAT Format, uint Mode, D3DDISPLAYMODE* pMode)
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3D9Ex*, uint, D3DFORMAT, uint, D3DDISPLAYMODE*, int>)(lpVtbl[7]))((IDirect3D9Ex*)Unsafe.AsPointer(ref this), Adapter, Format, Mode, pMode);
    }

    /// <inheritdoc cref="IDirect3D9.GetAdapterDisplayMode" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetAdapterDisplayMode(uint Adapter, D3DDISPLAYMODE* pMode)
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3D9Ex*, uint, D3DDISPLAYMODE*, int>)(lpVtbl[8]))((IDirect3D9Ex*)Unsafe.AsPointer(ref this), Adapter, pMode);
    }

    /// <inheritdoc cref="IDirect3D9.CheckDeviceType" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT CheckDeviceType(uint Adapter, D3DDEVTYPE DevType, D3DFORMAT AdapterFormat, D3DFORMAT BackBufferFormat, BOOL bWindowed)
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3D9Ex*, uint, D3DDEVTYPE, D3DFORMAT, D3DFORMAT, BOOL, int>)(lpVtbl[9]))((IDirect3D9Ex*)Unsafe.AsPointer(ref this), Adapter, DevType, AdapterFormat, BackBufferFormat, bWindowed);
    }

    /// <inheritdoc cref="IDirect3D9.CheckDeviceFormat" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT CheckDeviceFormat(uint Adapter, D3DDEVTYPE DeviceType, D3DFORMAT AdapterFormat, [NativeTypeName("DWORD")] uint Usage, D3DRESOURCETYPE RType, D3DFORMAT CheckFormat)
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3D9Ex*, uint, D3DDEVTYPE, D3DFORMAT, uint, D3DRESOURCETYPE, D3DFORMAT, int>)(lpVtbl[10]))((IDirect3D9Ex*)Unsafe.AsPointer(ref this), Adapter, DeviceType, AdapterFormat, Usage, RType, CheckFormat);
    }

    /// <inheritdoc cref="IDirect3D9.CheckDeviceMultiSampleType" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT CheckDeviceMultiSampleType(uint Adapter, D3DDEVTYPE DeviceType, D3DFORMAT SurfaceFormat, BOOL Windowed, D3DMULTISAMPLE_TYPE MultiSampleType, [NativeTypeName("DWORD *")] uint* pQualityLevels)
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3D9Ex*, uint, D3DDEVTYPE, D3DFORMAT, BOOL, D3DMULTISAMPLE_TYPE, uint*, int>)(lpVtbl[11]))((IDirect3D9Ex*)Unsafe.AsPointer(ref this), Adapter, DeviceType, SurfaceFormat, Windowed, MultiSampleType, pQualityLevels);
    }

    /// <inheritdoc cref="IDirect3D9.CheckDepthStencilMatch" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT CheckDepthStencilMatch(uint Adapter, D3DDEVTYPE DeviceType, D3DFORMAT AdapterFormat, D3DFORMAT RenderTargetFormat, D3DFORMAT DepthStencilFormat)
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3D9Ex*, uint, D3DDEVTYPE, D3DFORMAT, D3DFORMAT, D3DFORMAT, int>)(lpVtbl[12]))((IDirect3D9Ex*)Unsafe.AsPointer(ref this), Adapter, DeviceType, AdapterFormat, RenderTargetFormat, DepthStencilFormat);
    }

    /// <inheritdoc cref="IDirect3D9.CheckDeviceFormatConversion" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT CheckDeviceFormatConversion(uint Adapter, D3DDEVTYPE DeviceType, D3DFORMAT SourceFormat, D3DFORMAT TargetFormat)
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3D9Ex*, uint, D3DDEVTYPE, D3DFORMAT, D3DFORMAT, int>)(lpVtbl[13]))((IDirect3D9Ex*)Unsafe.AsPointer(ref this), Adapter, DeviceType, SourceFormat, TargetFormat);
    }

    /// <inheritdoc cref="IDirect3D9.GetDeviceCaps" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT GetDeviceCaps(uint Adapter, D3DDEVTYPE DeviceType, D3DCAPS9* pCaps)
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3D9Ex*, uint, D3DDEVTYPE, D3DCAPS9*, int>)(lpVtbl[14]))((IDirect3D9Ex*)Unsafe.AsPointer(ref this), Adapter, DeviceType, pCaps);
    }

    /// <inheritdoc cref="IDirect3D9.GetAdapterMonitor" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HMONITOR GetAdapterMonitor(uint Adapter)
    {
        return ((HMONITOR)(((delegate* unmanaged[MemberFunction]<IDirect3D9Ex*, uint, void*>)(lpVtbl[15]))((IDirect3D9Ex*)Unsafe.AsPointer(ref this), Adapter)));
    }

    /// <inheritdoc cref="IDirect3D9.CreateDevice" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT CreateDevice(uint Adapter, D3DDEVTYPE DeviceType, HWND hFocusWindow, [NativeTypeName("DWORD")] uint BehaviorFlags, D3DPRESENT_PARAMETERS* pPresentationParameters, IDirect3DDevice9** ppReturnedDeviceInterface)
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3D9Ex*, uint, D3DDEVTYPE, HWND, uint, D3DPRESENT_PARAMETERS*, IDirect3DDevice9**, int>)(lpVtbl[16]))((IDirect3D9Ex*)Unsafe.AsPointer(ref this), Adapter, DeviceType, hFocusWindow, BehaviorFlags, pPresentationParameters, ppReturnedDeviceInterface);
    }

    /// <include file='IDirect3D9Ex.xml' path='doc/member[@name="IDirect3D9Ex.GetAdapterModeCountEx"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public uint GetAdapterModeCountEx(uint Adapter, [NativeTypeName("const D3DDISPLAYMODEFILTER *")] D3DDISPLAYMODEFILTER* pFilter)
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3D9Ex*, uint, D3DDISPLAYMODEFILTER*, uint>)(lpVtbl[17]))((IDirect3D9Ex*)Unsafe.AsPointer(ref this), Adapter, pFilter);
    }

    /// <include file='IDirect3D9Ex.xml' path='doc/member[@name="IDirect3D9Ex.EnumAdapterModesEx"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT EnumAdapterModesEx(uint Adapter, [NativeTypeName("const D3DDISPLAYMODEFILTER *")] D3DDISPLAYMODEFILTER* pFilter, uint Mode, D3DDISPLAYMODEEX* pMode)
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3D9Ex*, uint, D3DDISPLAYMODEFILTER*, uint, D3DDISPLAYMODEEX*, int>)(lpVtbl[18]))((IDirect3D9Ex*)Unsafe.AsPointer(ref this), Adapter, pFilter, Mode, pMode);
    }

    /// <include file='IDirect3D9Ex.xml' path='doc/member[@name="IDirect3D9Ex.GetAdapterDisplayModeEx"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT GetAdapterDisplayModeEx(uint Adapter, D3DDISPLAYMODEEX* pMode, D3DDISPLAYROTATION* pRotation)
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3D9Ex*, uint, D3DDISPLAYMODEEX*, D3DDISPLAYROTATION*, int>)(lpVtbl[19]))((IDirect3D9Ex*)Unsafe.AsPointer(ref this), Adapter, pMode, pRotation);
    }

    /// <include file='IDirect3D9Ex.xml' path='doc/member[@name="IDirect3D9Ex.CreateDeviceEx"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT CreateDeviceEx(uint Adapter, D3DDEVTYPE DeviceType, HWND hFocusWindow, [NativeTypeName("DWORD")] uint BehaviorFlags, D3DPRESENT_PARAMETERS* pPresentationParameters, D3DDISPLAYMODEEX* pFullscreenDisplayMode, IDirect3DDevice9Ex** ppReturnedDeviceInterface)
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3D9Ex*, uint, D3DDEVTYPE, HWND, uint, D3DPRESENT_PARAMETERS*, D3DDISPLAYMODEEX*, IDirect3DDevice9Ex**, int>)(lpVtbl[20]))((IDirect3D9Ex*)Unsafe.AsPointer(ref this), Adapter, DeviceType, hFocusWindow, BehaviorFlags, pPresentationParameters, pFullscreenDisplayMode, ppReturnedDeviceInterface);
    }

    /// <include file='IDirect3D9Ex.xml' path='doc/member[@name="IDirect3D9Ex.GetAdapterLUID"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT GetAdapterLUID(uint Adapter, LUID* pLUID)
    {
        return ((delegate* unmanaged[MemberFunction]<IDirect3D9Ex*, uint, LUID*, int>)(lpVtbl[21]))((IDirect3D9Ex*)Unsafe.AsPointer(ref this), Adapter, pLUID);
    }

    public interface Interface : IDirect3D9.Interface
    {
        [VtblIndex(17)]
        uint GetAdapterModeCountEx(uint Adapter, [NativeTypeName("const D3DDISPLAYMODEFILTER *")] D3DDISPLAYMODEFILTER* pFilter);

        [VtblIndex(18)]
        HRESULT EnumAdapterModesEx(uint Adapter, [NativeTypeName("const D3DDISPLAYMODEFILTER *")] D3DDISPLAYMODEFILTER* pFilter, uint Mode, D3DDISPLAYMODEEX* pMode);

        [VtblIndex(19)]
        HRESULT GetAdapterDisplayModeEx(uint Adapter, D3DDISPLAYMODEEX* pMode, D3DDISPLAYROTATION* pRotation);

        [VtblIndex(20)]
        HRESULT CreateDeviceEx(uint Adapter, D3DDEVTYPE DeviceType, HWND hFocusWindow, [NativeTypeName("DWORD")] uint BehaviorFlags, D3DPRESENT_PARAMETERS* pPresentationParameters, D3DDISPLAYMODEEX* pFullscreenDisplayMode, IDirect3DDevice9Ex** ppReturnedDeviceInterface);

        [VtblIndex(21)]
        HRESULT GetAdapterLUID(uint Adapter, LUID* pLUID);
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

        [NativeTypeName("HRESULT (void *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, void*, int> RegisterSoftwareDevice;

        [NativeTypeName("UINT () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint> GetAdapterCount;

        [NativeTypeName("HRESULT (UINT, DWORD, D3DADAPTER_IDENTIFIER9 *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, uint, D3DADAPTER_IDENTIFIER9*, int> GetAdapterIdentifier;

        [NativeTypeName("UINT (UINT, D3DFORMAT) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, D3DFORMAT, uint> GetAdapterModeCount;

        [NativeTypeName("HRESULT (UINT, D3DFORMAT, UINT, D3DDISPLAYMODE *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, D3DFORMAT, uint, D3DDISPLAYMODE*, int> EnumAdapterModes;

        [NativeTypeName("HRESULT (UINT, D3DDISPLAYMODE *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, D3DDISPLAYMODE*, int> GetAdapterDisplayMode;

        [NativeTypeName("HRESULT (UINT, D3DDEVTYPE, D3DFORMAT, D3DFORMAT, BOOL) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, D3DDEVTYPE, D3DFORMAT, D3DFORMAT, BOOL, int> CheckDeviceType;

        [NativeTypeName("HRESULT (UINT, D3DDEVTYPE, D3DFORMAT, DWORD, D3DRESOURCETYPE, D3DFORMAT) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, D3DDEVTYPE, D3DFORMAT, uint, D3DRESOURCETYPE, D3DFORMAT, int> CheckDeviceFormat;

        [NativeTypeName("HRESULT (UINT, D3DDEVTYPE, D3DFORMAT, BOOL, D3DMULTISAMPLE_TYPE, DWORD *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, D3DDEVTYPE, D3DFORMAT, BOOL, D3DMULTISAMPLE_TYPE, uint*, int> CheckDeviceMultiSampleType;

        [NativeTypeName("HRESULT (UINT, D3DDEVTYPE, D3DFORMAT, D3DFORMAT, D3DFORMAT) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, D3DDEVTYPE, D3DFORMAT, D3DFORMAT, D3DFORMAT, int> CheckDepthStencilMatch;

        [NativeTypeName("HRESULT (UINT, D3DDEVTYPE, D3DFORMAT, D3DFORMAT) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, D3DDEVTYPE, D3DFORMAT, D3DFORMAT, int> CheckDeviceFormatConversion;

        [NativeTypeName("HRESULT (UINT, D3DDEVTYPE, D3DCAPS9 *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, D3DDEVTYPE, D3DCAPS9*, int> GetDeviceCaps;

        [NativeTypeName("HMONITOR (UINT) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, void*> GetAdapterMonitor;

        [NativeTypeName("HRESULT (UINT, D3DDEVTYPE, HWND, DWORD, D3DPRESENT_PARAMETERS *, IDirect3DDevice9 **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, D3DDEVTYPE, HWND, uint, D3DPRESENT_PARAMETERS*, IDirect3DDevice9**, int> CreateDevice;

        [NativeTypeName("UINT (UINT, const D3DDISPLAYMODEFILTER *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, D3DDISPLAYMODEFILTER*, uint> GetAdapterModeCountEx;

        [NativeTypeName("HRESULT (UINT, const D3DDISPLAYMODEFILTER *, UINT, D3DDISPLAYMODEEX *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, D3DDISPLAYMODEFILTER*, uint, D3DDISPLAYMODEEX*, int> EnumAdapterModesEx;

        [NativeTypeName("HRESULT (UINT, D3DDISPLAYMODEEX *, D3DDISPLAYROTATION *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, D3DDISPLAYMODEEX*, D3DDISPLAYROTATION*, int> GetAdapterDisplayModeEx;

        [NativeTypeName("HRESULT (UINT, D3DDEVTYPE, HWND, DWORD, D3DPRESENT_PARAMETERS *, D3DDISPLAYMODEEX *, IDirect3DDevice9Ex **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, D3DDEVTYPE, HWND, uint, D3DPRESENT_PARAMETERS*, D3DDISPLAYMODEEX*, IDirect3DDevice9Ex**, int> CreateDeviceEx;

        [NativeTypeName("HRESULT (UINT, LUID *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, LUID*, int> GetAdapterLUID;
    }
}
