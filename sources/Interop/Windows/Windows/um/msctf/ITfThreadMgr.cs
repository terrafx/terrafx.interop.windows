// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/msctf.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

[Guid("AA80E801-2021-11D2-93E0-0060B067B86E")]
[NativeTypeName("struct ITfThreadMgr : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ITfThreadMgr : ITfThreadMgr.Interface
{
    public void** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ITfThreadMgr*, Guid*, void**, int>)(lpVtbl[0]))((ITfThreadMgr*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ITfThreadMgr*, uint>)(lpVtbl[1]))((ITfThreadMgr*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ITfThreadMgr*, uint>)(lpVtbl[2]))((ITfThreadMgr*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Activate([NativeTypeName("TfClientId *")] uint* ptid)
    {
        return ((delegate* unmanaged<ITfThreadMgr*, uint*, int>)(lpVtbl[3]))((ITfThreadMgr*)Unsafe.AsPointer(ref this), ptid);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT Deactivate()
    {
        return ((delegate* unmanaged<ITfThreadMgr*, int>)(lpVtbl[4]))((ITfThreadMgr*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT CreateDocumentMgr(ITfDocumentMgr** ppdim)
    {
        return ((delegate* unmanaged<ITfThreadMgr*, ITfDocumentMgr**, int>)(lpVtbl[5]))((ITfThreadMgr*)Unsafe.AsPointer(ref this), ppdim);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT EnumDocumentMgrs(IEnumTfDocumentMgrs** ppEnum)
    {
        return ((delegate* unmanaged<ITfThreadMgr*, IEnumTfDocumentMgrs**, int>)(lpVtbl[6]))((ITfThreadMgr*)Unsafe.AsPointer(ref this), ppEnum);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetFocus(ITfDocumentMgr** ppdimFocus)
    {
        return ((delegate* unmanaged<ITfThreadMgr*, ITfDocumentMgr**, int>)(lpVtbl[7]))((ITfThreadMgr*)Unsafe.AsPointer(ref this), ppdimFocus);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT SetFocus(ITfDocumentMgr* pdimFocus)
    {
        return ((delegate* unmanaged<ITfThreadMgr*, ITfDocumentMgr*, int>)(lpVtbl[8]))((ITfThreadMgr*)Unsafe.AsPointer(ref this), pdimFocus);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT AssociateFocus(HWND hwnd, ITfDocumentMgr* pdimNew, ITfDocumentMgr** ppdimPrev)
    {
        return ((delegate* unmanaged<ITfThreadMgr*, HWND, ITfDocumentMgr*, ITfDocumentMgr**, int>)(lpVtbl[9]))((ITfThreadMgr*)Unsafe.AsPointer(ref this), hwnd, pdimNew, ppdimPrev);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT IsThreadFocus(BOOL* pfThreadFocus)
    {
        return ((delegate* unmanaged<ITfThreadMgr*, BOOL*, int>)(lpVtbl[10]))((ITfThreadMgr*)Unsafe.AsPointer(ref this), pfThreadFocus);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetFunctionProvider([NativeTypeName("const IID &")] Guid* clsid, ITfFunctionProvider** ppFuncProv)
    {
        return ((delegate* unmanaged<ITfThreadMgr*, Guid*, ITfFunctionProvider**, int>)(lpVtbl[11]))((ITfThreadMgr*)Unsafe.AsPointer(ref this), clsid, ppFuncProv);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT EnumFunctionProviders(IEnumTfFunctionProviders** ppEnum)
    {
        return ((delegate* unmanaged<ITfThreadMgr*, IEnumTfFunctionProviders**, int>)(lpVtbl[12]))((ITfThreadMgr*)Unsafe.AsPointer(ref this), ppEnum);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT GetGlobalCompartment(ITfCompartmentMgr** ppCompMgr)
    {
        return ((delegate* unmanaged<ITfThreadMgr*, ITfCompartmentMgr**, int>)(lpVtbl[13]))((ITfThreadMgr*)Unsafe.AsPointer(ref this), ppCompMgr);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Activate([NativeTypeName("TfClientId *")] uint* ptid);

        [VtblIndex(4)]
        HRESULT Deactivate();

        [VtblIndex(5)]
        HRESULT CreateDocumentMgr(ITfDocumentMgr** ppdim);

        [VtblIndex(6)]
        HRESULT EnumDocumentMgrs(IEnumTfDocumentMgrs** ppEnum);

        [VtblIndex(7)]
        HRESULT GetFocus(ITfDocumentMgr** ppdimFocus);

        [VtblIndex(8)]
        HRESULT SetFocus(ITfDocumentMgr* pdimFocus);

        [VtblIndex(9)]
        HRESULT AssociateFocus(HWND hwnd, ITfDocumentMgr* pdimNew, ITfDocumentMgr** ppdimPrev);

        [VtblIndex(10)]
        HRESULT IsThreadFocus(BOOL* pfThreadFocus);

        [VtblIndex(11)]
        HRESULT GetFunctionProvider([NativeTypeName("const IID &")] Guid* clsid, ITfFunctionProvider** ppFuncProv);

        [VtblIndex(12)]
        HRESULT EnumFunctionProviders(IEnumTfFunctionProviders** ppEnum);

        [VtblIndex(13)]
        HRESULT GetGlobalCompartment(ITfCompartmentMgr** ppCompMgr);
    }

    public partial struct Vtbl
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<ITfThreadMgr*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<ITfThreadMgr*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<ITfThreadMgr*, uint> Release;

        [NativeTypeName("HRESULT (TfClientId *) __attribute__((stdcall))")]
        public delegate* unmanaged<ITfThreadMgr*, uint*, int> Activate;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<ITfThreadMgr*, int> Deactivate;

        [NativeTypeName("HRESULT (ITfDocumentMgr **) __attribute__((stdcall))")]
        public delegate* unmanaged<ITfThreadMgr*, ITfDocumentMgr**, int> CreateDocumentMgr;

        [NativeTypeName("HRESULT (IEnumTfDocumentMgrs **) __attribute__((stdcall))")]
        public delegate* unmanaged<ITfThreadMgr*, IEnumTfDocumentMgrs**, int> EnumDocumentMgrs;

        [NativeTypeName("HRESULT (ITfDocumentMgr **) __attribute__((stdcall))")]
        public delegate* unmanaged<ITfThreadMgr*, ITfDocumentMgr**, int> GetFocus;

        [NativeTypeName("HRESULT (ITfDocumentMgr *) __attribute__((stdcall))")]
        public delegate* unmanaged<ITfThreadMgr*, ITfDocumentMgr*, int> SetFocus;

        [NativeTypeName("HRESULT (HWND, ITfDocumentMgr *, ITfDocumentMgr **) __attribute__((stdcall))")]
        public delegate* unmanaged<ITfThreadMgr*, HWND, ITfDocumentMgr*, ITfDocumentMgr**, int> AssociateFocus;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<ITfThreadMgr*, BOOL*, int> IsThreadFocus;

        [NativeTypeName("HRESULT (const IID &, ITfFunctionProvider **) __attribute__((stdcall))")]
        public delegate* unmanaged<ITfThreadMgr*, Guid*, ITfFunctionProvider**, int> GetFunctionProvider;

        [NativeTypeName("HRESULT (IEnumTfFunctionProviders **) __attribute__((stdcall))")]
        public delegate* unmanaged<ITfThreadMgr*, IEnumTfFunctionProviders**, int> EnumFunctionProviders;

        [NativeTypeName("HRESULT (ITfCompartmentMgr **) __attribute__((stdcall))")]
        public delegate* unmanaged<ITfThreadMgr*, ITfCompartmentMgr**, int> GetGlobalCompartment;
    }
}
