// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("27864A2A-2B9F-4CB8-92D3-0D2722FD1E73")]
    [NativeTypeName("struct ISpeechPhraseAlternate : IDispatch")]
    public unsafe partial struct ISpeechPhraseAlternate
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<ISpeechPhraseAlternate*, Guid*, void**, int>)(lpVtbl[0]))((ISpeechPhraseAlternate*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<ISpeechPhraseAlternate*, uint>)(lpVtbl[1]))((ISpeechPhraseAlternate*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<ISpeechPhraseAlternate*, uint>)(lpVtbl[2]))((ISpeechPhraseAlternate*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfoCount([NativeTypeName("UINT *")] uint* pctinfo)
        {
            return ((delegate* stdcall<ISpeechPhraseAlternate*, uint*, int>)(lpVtbl[3]))((ISpeechPhraseAlternate*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfo([NativeTypeName("UINT")] uint iTInfo, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("ITypeInfo **")] ITypeInfo** ppTInfo)
        {
            return ((delegate* stdcall<ISpeechPhraseAlternate*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((ISpeechPhraseAlternate*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, [NativeTypeName("UINT")] uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* stdcall<ISpeechPhraseAlternate*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((ISpeechPhraseAlternate*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, [NativeTypeName("DISPPARAMS *")] DISPPARAMS* pDispParams, [NativeTypeName("VARIANT *")] VARIANT* pVarResult, [NativeTypeName("EXCEPINFO *")] EXCEPINFO* pExcepInfo, [NativeTypeName("UINT *")] uint* puArgErr)
        {
            return ((delegate* stdcall<ISpeechPhraseAlternate*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((ISpeechPhraseAlternate*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_RecoResult([NativeTypeName("ISpeechRecoResult **")] ISpeechRecoResult** RecoResult)
        {
            return ((delegate* stdcall<ISpeechPhraseAlternate*, ISpeechRecoResult**, int>)(lpVtbl[7]))((ISpeechPhraseAlternate*)Unsafe.AsPointer(ref this), RecoResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_StartElementInResult([NativeTypeName("long *")] int* StartElement)
        {
            return ((delegate* stdcall<ISpeechPhraseAlternate*, int*, int>)(lpVtbl[8]))((ISpeechPhraseAlternate*)Unsafe.AsPointer(ref this), StartElement);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_NumberOfElementsInResult([NativeTypeName("long *")] int* NumberOfElements)
        {
            return ((delegate* stdcall<ISpeechPhraseAlternate*, int*, int>)(lpVtbl[9]))((ISpeechPhraseAlternate*)Unsafe.AsPointer(ref this), NumberOfElements);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_PhraseInfo([NativeTypeName("ISpeechPhraseInfo **")] ISpeechPhraseInfo** PhraseInfo)
        {
            return ((delegate* stdcall<ISpeechPhraseAlternate*, ISpeechPhraseInfo**, int>)(lpVtbl[10]))((ISpeechPhraseAlternate*)Unsafe.AsPointer(ref this), PhraseInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Commit()
        {
            return ((delegate* stdcall<ISpeechPhraseAlternate*, int>)(lpVtbl[11]))((ISpeechPhraseAlternate*)Unsafe.AsPointer(ref this));
        }
    }
}
