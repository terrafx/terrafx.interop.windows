// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MSAAText.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

[Guid("E2CD4A63-2B72-4D48-B739-95E4765195BA")]
[NativeTypeName("struct IAccStore : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IAccStore : IAccStore.Interface
{
    public void** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IAccStore*, Guid*, void**, int>)(lpVtbl[0]))((IAccStore*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IAccStore*, uint>)(lpVtbl[1]))((IAccStore*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAccStore*, uint>)(lpVtbl[2]))((IAccStore*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Register([NativeTypeName("const IID &")] Guid* riid, IUnknown* punk)
    {
        return ((delegate* unmanaged<IAccStore*, Guid*, IUnknown*, int>)(lpVtbl[3]))((IAccStore*)Unsafe.AsPointer(ref this), riid, punk);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT Unregister(IUnknown* punk)
    {
        return ((delegate* unmanaged<IAccStore*, IUnknown*, int>)(lpVtbl[4]))((IAccStore*)Unsafe.AsPointer(ref this), punk);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetDocuments(IEnumUnknown** enumUnknown)
    {
        return ((delegate* unmanaged<IAccStore*, IEnumUnknown**, int>)(lpVtbl[5]))((IAccStore*)Unsafe.AsPointer(ref this), enumUnknown);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT LookupByHWND(HWND hWnd, [NativeTypeName("const IID &")] Guid* riid, IUnknown** ppunk)
    {
        return ((delegate* unmanaged<IAccStore*, HWND, Guid*, IUnknown**, int>)(lpVtbl[6]))((IAccStore*)Unsafe.AsPointer(ref this), hWnd, riid, ppunk);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT LookupByPoint(POINT pt, [NativeTypeName("const IID &")] Guid* riid, IUnknown** ppunk)
    {
        return ((delegate* unmanaged<IAccStore*, POINT, Guid*, IUnknown**, int>)(lpVtbl[7]))((IAccStore*)Unsafe.AsPointer(ref this), pt, riid, ppunk);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT OnDocumentFocus(IUnknown* punk)
    {
        return ((delegate* unmanaged<IAccStore*, IUnknown*, int>)(lpVtbl[8]))((IAccStore*)Unsafe.AsPointer(ref this), punk);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetFocused([NativeTypeName("const IID &")] Guid* riid, IUnknown** ppunk)
    {
        return ((delegate* unmanaged<IAccStore*, Guid*, IUnknown**, int>)(lpVtbl[9]))((IAccStore*)Unsafe.AsPointer(ref this), riid, ppunk);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Register([NativeTypeName("const IID &")] Guid* riid, IUnknown* punk);

        [VtblIndex(4)]
        HRESULT Unregister(IUnknown* punk);

        [VtblIndex(5)]
        HRESULT GetDocuments(IEnumUnknown** enumUnknown);

        [VtblIndex(6)]
        HRESULT LookupByHWND(HWND hWnd, [NativeTypeName("const IID &")] Guid* riid, IUnknown** ppunk);

        [VtblIndex(7)]
        HRESULT LookupByPoint(POINT pt, [NativeTypeName("const IID &")] Guid* riid, IUnknown** ppunk);

        [VtblIndex(8)]
        HRESULT OnDocumentFocus(IUnknown* punk);

        [VtblIndex(9)]
        HRESULT GetFocused([NativeTypeName("const IID &")] Guid* riid, IUnknown** ppunk);
    }

    public partial struct Vtbl
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<IAccStore*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IAccStore*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IAccStore*, uint> Release;

        [NativeTypeName("HRESULT (const IID &, IUnknown *) __attribute__((stdcall))")]
        public delegate* unmanaged<IAccStore*, Guid*, IUnknown*, int> Register;

        [NativeTypeName("HRESULT (IUnknown *) __attribute__((stdcall))")]
        public delegate* unmanaged<IAccStore*, IUnknown*, int> Unregister;

        [NativeTypeName("HRESULT (IEnumUnknown **) __attribute__((stdcall))")]
        public delegate* unmanaged<IAccStore*, IEnumUnknown**, int> GetDocuments;

        [NativeTypeName("HRESULT (HWND, const IID &, IUnknown **) __attribute__((stdcall))")]
        public delegate* unmanaged<IAccStore*, HWND, Guid*, IUnknown**, int> LookupByHWND;

        [NativeTypeName("HRESULT (POINT, const IID &, IUnknown **) __attribute__((stdcall))")]
        public delegate* unmanaged<IAccStore*, POINT, Guid*, IUnknown**, int> LookupByPoint;

        [NativeTypeName("HRESULT (IUnknown *) __attribute__((stdcall))")]
        public delegate* unmanaged<IAccStore*, IUnknown*, int> OnDocumentFocus;

        [NativeTypeName("HRESULT (const IID &, IUnknown **) __attribute__((stdcall))")]
        public delegate* unmanaged<IAccStore*, Guid*, IUnknown**, int> GetFocused;
    }
}
