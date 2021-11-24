// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows;

[Guid("20BC074B-7A8D-4609-8C3B-64A0A3B5D7CE")]
[NativeTypeName("struct IMFDXGIDeviceManagerSource : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows8.1")]
public unsafe partial struct IMFDXGIDeviceManagerSource : IMFDXGIDeviceManagerSource.Interface
{
    public void** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFDXGIDeviceManagerSource*, Guid*, void**, int>)(lpVtbl[0]))((IMFDXGIDeviceManagerSource*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IMFDXGIDeviceManagerSource*, uint>)(lpVtbl[1]))((IMFDXGIDeviceManagerSource*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFDXGIDeviceManagerSource*, uint>)(lpVtbl[2]))((IMFDXGIDeviceManagerSource*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetManager(IMFDXGIDeviceManager** ppManager)
    {
        return ((delegate* unmanaged<IMFDXGIDeviceManagerSource*, IMFDXGIDeviceManager**, int>)(lpVtbl[3]))((IMFDXGIDeviceManagerSource*)Unsafe.AsPointer(ref this), ppManager);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetManager(IMFDXGIDeviceManager** ppManager);
    }

    public partial struct Vtbl
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<IMFDXGIDeviceManagerSource*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IMFDXGIDeviceManagerSource*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IMFDXGIDeviceManagerSource*, uint> Release;

        [NativeTypeName("HRESULT (IMFDXGIDeviceManager **) __attribute__((stdcall))")]
        public delegate* unmanaged<IMFDXGIDeviceManagerSource*, IMFDXGIDeviceManager**, int> GetManager;
    }
}
