// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/oleidl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

[Guid("0000011E-0000-0000-C000-000000000046")]
[NativeTypeName("struct IOleCache : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IOleCache : IOleCache.Interface
{
    public void** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IOleCache*, Guid*, void**, int>)(lpVtbl[0]))((IOleCache*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IOleCache*, uint>)(lpVtbl[1]))((IOleCache*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IOleCache*, uint>)(lpVtbl[2]))((IOleCache*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Cache(FORMATETC* pformatetc, [NativeTypeName("DWORD")] uint advf, [NativeTypeName("DWORD *")] uint* pdwConnection)
    {
        return ((delegate* unmanaged<IOleCache*, FORMATETC*, uint, uint*, int>)(lpVtbl[3]))((IOleCache*)Unsafe.AsPointer(ref this), pformatetc, advf, pdwConnection);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT Uncache([NativeTypeName("DWORD")] uint dwConnection)
    {
        return ((delegate* unmanaged<IOleCache*, uint, int>)(lpVtbl[4]))((IOleCache*)Unsafe.AsPointer(ref this), dwConnection);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT EnumCache(IEnumSTATDATA** ppenumSTATDATA)
    {
        return ((delegate* unmanaged<IOleCache*, IEnumSTATDATA**, int>)(lpVtbl[5]))((IOleCache*)Unsafe.AsPointer(ref this), ppenumSTATDATA);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT InitCache(IDataObject* pDataObject)
    {
        return ((delegate* unmanaged<IOleCache*, IDataObject*, int>)(lpVtbl[6]))((IOleCache*)Unsafe.AsPointer(ref this), pDataObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT SetData(FORMATETC* pformatetc, STGMEDIUM* pmedium, BOOL fRelease)
    {
        return ((delegate* unmanaged<IOleCache*, FORMATETC*, STGMEDIUM*, BOOL, int>)(lpVtbl[7]))((IOleCache*)Unsafe.AsPointer(ref this), pformatetc, pmedium, fRelease);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Cache(FORMATETC* pformatetc, [NativeTypeName("DWORD")] uint advf, [NativeTypeName("DWORD *")] uint* pdwConnection);

        [VtblIndex(4)]
        HRESULT Uncache([NativeTypeName("DWORD")] uint dwConnection);

        [VtblIndex(5)]
        HRESULT EnumCache(IEnumSTATDATA** ppenumSTATDATA);

        [VtblIndex(6)]
        HRESULT InitCache(IDataObject* pDataObject);

        [VtblIndex(7)]
        HRESULT SetData(FORMATETC* pformatetc, STGMEDIUM* pmedium, BOOL fRelease);
    }

    public partial struct Vtbl
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<IOleCache*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IOleCache*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IOleCache*, uint> Release;

        [NativeTypeName("HRESULT (FORMATETC *, DWORD, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<IOleCache*, FORMATETC*, uint, uint*, int> Cache;

        [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<IOleCache*, uint, int> Uncache;

        [NativeTypeName("HRESULT (IEnumSTATDATA **) __attribute__((stdcall))")]
        public delegate* unmanaged<IOleCache*, IEnumSTATDATA**, int> EnumCache;

        [NativeTypeName("HRESULT (IDataObject *) __attribute__((stdcall))")]
        public delegate* unmanaged<IOleCache*, IDataObject*, int> InitCache;

        [NativeTypeName("HRESULT (FORMATETC *, STGMEDIUM *, BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<IOleCache*, FORMATETC*, STGMEDIUM*, BOOL, int> SetData;
    }
}
