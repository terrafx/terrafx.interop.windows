// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfobjects.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows;

[Guid("E7174CFA-1C9E-48B1-8866-626226BFC258")]
[NativeTypeName("struct IMFDXGIBuffer : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows8.0")]
public unsafe partial struct IMFDXGIBuffer : IMFDXGIBuffer.Interface
{
    public void** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFDXGIBuffer*, Guid*, void**, int>)(lpVtbl[0]))((IMFDXGIBuffer*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IMFDXGIBuffer*, uint>)(lpVtbl[1]))((IMFDXGIBuffer*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFDXGIBuffer*, uint>)(lpVtbl[2]))((IMFDXGIBuffer*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetResource([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPVOID *")] void** ppvObject)
    {
        return ((delegate* unmanaged<IMFDXGIBuffer*, Guid*, void**, int>)(lpVtbl[3]))((IMFDXGIBuffer*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetSubresourceIndex(uint* puSubresource)
    {
        return ((delegate* unmanaged<IMFDXGIBuffer*, uint*, int>)(lpVtbl[4]))((IMFDXGIBuffer*)Unsafe.AsPointer(ref this), puSubresource);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetUnknown([NativeTypeName("const IID &")] Guid* guid, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPVOID *")] void** ppvObject)
    {
        return ((delegate* unmanaged<IMFDXGIBuffer*, Guid*, Guid*, void**, int>)(lpVtbl[5]))((IMFDXGIBuffer*)Unsafe.AsPointer(ref this), guid, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SetUnknown([NativeTypeName("const IID &")] Guid* guid, IUnknown* pUnkData)
    {
        return ((delegate* unmanaged<IMFDXGIBuffer*, Guid*, IUnknown*, int>)(lpVtbl[6]))((IMFDXGIBuffer*)Unsafe.AsPointer(ref this), guid, pUnkData);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetResource([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPVOID *")] void** ppvObject);

        [VtblIndex(4)]
        HRESULT GetSubresourceIndex(uint* puSubresource);

        [VtblIndex(5)]
        HRESULT GetUnknown([NativeTypeName("const IID &")] Guid* guid, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPVOID *")] void** ppvObject);

        [VtblIndex(6)]
        HRESULT SetUnknown([NativeTypeName("const IID &")] Guid* guid, IUnknown* pUnkData);
    }

    public partial struct Vtbl
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<IMFDXGIBuffer*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IMFDXGIBuffer*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IMFDXGIBuffer*, uint> Release;

        [NativeTypeName("HRESULT (const IID &, LPVOID *) __attribute__((stdcall))")]
        public delegate* unmanaged<IMFDXGIBuffer*, Guid*, void**, int> GetResource;

        [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<IMFDXGIBuffer*, uint*, int> GetSubresourceIndex;

        [NativeTypeName("HRESULT (const IID &, const IID &, LPVOID *) __attribute__((stdcall))")]
        public delegate* unmanaged<IMFDXGIBuffer*, Guid*, Guid*, void**, int> GetUnknown;

        [NativeTypeName("HRESULT (const IID &, IUnknown *) __attribute__((stdcall))")]
        public delegate* unmanaged<IMFDXGIBuffer*, Guid*, IUnknown*, int> SetUnknown;
    }
}
