// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dxgidebug.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using TerraFX.Interop.Windows;

namespace TerraFX.Interop.DirectX;

[SupportedOSPlatform("windows8.0")]
[Guid("119E7452-DE9E-40FE-8806-88F90C12B441")]
[NativeTypeName("struct IDXGIDebug : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IDXGIDebug : IDXGIDebug.Interface
{
    public void** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDXGIDebug*, Guid*, void**, int>)(lpVtbl[0]))((IDXGIDebug*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDXGIDebug*, uint>)(lpVtbl[1]))((IDXGIDebug*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDXGIDebug*, uint>)(lpVtbl[2]))((IDXGIDebug*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT ReportLiveObjects(Guid apiid, DXGI_DEBUG_RLO_FLAGS flags)
    {
        return ((delegate* unmanaged<IDXGIDebug*, Guid, DXGI_DEBUG_RLO_FLAGS, int>)(lpVtbl[3]))((IDXGIDebug*)Unsafe.AsPointer(ref this), apiid, flags);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT ReportLiveObjects(Guid apiid, DXGI_DEBUG_RLO_FLAGS flags);
    }

    public partial struct Vtbl
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<IDXGIDebug*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IDXGIDebug*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IDXGIDebug*, uint> Release;

        [NativeTypeName("HRESULT (GUID, DXGI_DEBUG_RLO_FLAGS) __attribute__((stdcall))")]
        public delegate* unmanaged<IDXGIDebug*, Guid, DXGI_DEBUG_RLO_FLAGS, int> ReportLiveObjects;
    }
}
