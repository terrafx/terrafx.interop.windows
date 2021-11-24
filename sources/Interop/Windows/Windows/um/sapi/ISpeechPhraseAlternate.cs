// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

[Guid("27864A2A-2B9F-4CB8-92D3-0D2722FD1E73")]
[NativeTypeName("struct ISpeechPhraseAlternate : IDispatch")]
[NativeInheritance("IDispatch")]
public unsafe partial struct ISpeechPhraseAlternate : ISpeechPhraseAlternate.Interface
{
    public void** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ISpeechPhraseAlternate*, Guid*, void**, int>)(lpVtbl[0]))((ISpeechPhraseAlternate*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ISpeechPhraseAlternate*, uint>)(lpVtbl[1]))((ISpeechPhraseAlternate*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISpeechPhraseAlternate*, uint>)(lpVtbl[2]))((ISpeechPhraseAlternate*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<ISpeechPhraseAlternate*, uint*, int>)(lpVtbl[3]))((ISpeechPhraseAlternate*)Unsafe.AsPointer(ref this), pctinfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
    {
        return ((delegate* unmanaged<ISpeechPhraseAlternate*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((ISpeechPhraseAlternate*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
    {
        return ((delegate* unmanaged<ISpeechPhraseAlternate*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((ISpeechPhraseAlternate*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
    {
        return ((delegate* unmanaged<ISpeechPhraseAlternate*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((ISpeechPhraseAlternate*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_RecoResult(ISpeechRecoResult** RecoResult)
    {
        return ((delegate* unmanaged<ISpeechPhraseAlternate*, ISpeechRecoResult**, int>)(lpVtbl[7]))((ISpeechPhraseAlternate*)Unsafe.AsPointer(ref this), RecoResult);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_StartElementInResult([NativeTypeName("long *")] int* StartElement)
    {
        return ((delegate* unmanaged<ISpeechPhraseAlternate*, int*, int>)(lpVtbl[8]))((ISpeechPhraseAlternate*)Unsafe.AsPointer(ref this), StartElement);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_NumberOfElementsInResult([NativeTypeName("long *")] int* NumberOfElements)
    {
        return ((delegate* unmanaged<ISpeechPhraseAlternate*, int*, int>)(lpVtbl[9]))((ISpeechPhraseAlternate*)Unsafe.AsPointer(ref this), NumberOfElements);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_PhraseInfo(ISpeechPhraseInfo** PhraseInfo)
    {
        return ((delegate* unmanaged<ISpeechPhraseAlternate*, ISpeechPhraseInfo**, int>)(lpVtbl[10]))((ISpeechPhraseAlternate*)Unsafe.AsPointer(ref this), PhraseInfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT Commit()
    {
        return ((delegate* unmanaged<ISpeechPhraseAlternate*, int>)(lpVtbl[11]))((ISpeechPhraseAlternate*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IDispatch.Interface
    {
        [VtblIndex(7)]
        HRESULT get_RecoResult(ISpeechRecoResult** RecoResult);

        [VtblIndex(8)]
        HRESULT get_StartElementInResult([NativeTypeName("long *")] int* StartElement);

        [VtblIndex(9)]
        HRESULT get_NumberOfElementsInResult([NativeTypeName("long *")] int* NumberOfElements);

        [VtblIndex(10)]
        HRESULT get_PhraseInfo(ISpeechPhraseInfo** PhraseInfo);

        [VtblIndex(11)]
        HRESULT Commit();
    }

    public partial struct Vtbl
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<ISpeechPhraseAlternate*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<ISpeechPhraseAlternate*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<ISpeechPhraseAlternate*, uint> Release;

        [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<ISpeechPhraseAlternate*, uint*, int> GetTypeInfoCount;

        [NativeTypeName("HRESULT (UINT, LCID, ITypeInfo **) __attribute__((stdcall))")]
        public delegate* unmanaged<ISpeechPhraseAlternate*, uint, uint, ITypeInfo**, int> GetTypeInfo;

        [NativeTypeName("HRESULT (const IID &, LPOLESTR *, UINT, LCID, DISPID *) __attribute__((stdcall))")]
        public delegate* unmanaged<ISpeechPhraseAlternate*, Guid*, ushort**, uint, uint, int*, int> GetIDsOfNames;

        [NativeTypeName("HRESULT (DISPID, const IID &, LCID, WORD, DISPPARAMS *, VARIANT *, EXCEPINFO *, UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<ISpeechPhraseAlternate*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int> Invoke;

        [NativeTypeName("HRESULT (ISpeechRecoResult **) __attribute__((stdcall))")]
        public delegate* unmanaged<ISpeechPhraseAlternate*, ISpeechRecoResult**, int> get_RecoResult;

        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<ISpeechPhraseAlternate*, int*, int> get_StartElementInResult;

        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<ISpeechPhraseAlternate*, int*, int> get_NumberOfElementsInResult;

        [NativeTypeName("HRESULT (ISpeechPhraseInfo **) __attribute__((stdcall))")]
        public delegate* unmanaged<ISpeechPhraseAlternate*, ISpeechPhraseInfo**, int> get_PhraseInfo;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<ISpeechPhraseAlternate*, int> Commit;
    }
}
