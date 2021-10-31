// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("95252C5D-9E43-4F4A-9899-48EE73352F9F")]
    [NativeTypeName("struct ISpeechLexiconPronunciation : IDispatch")]
    [NativeInheritance("IDispatch")]
    public unsafe partial struct ISpeechLexiconPronunciation
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ISpeechLexiconPronunciation*, Guid*, void**, int>)(lpVtbl[0]))((ISpeechLexiconPronunciation*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ISpeechLexiconPronunciation*, uint>)(lpVtbl[1]))((ISpeechLexiconPronunciation*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ISpeechLexiconPronunciation*, uint>)(lpVtbl[2]))((ISpeechLexiconPronunciation*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetTypeInfoCount([NativeTypeName("UINT *")] uint* pctinfo)
        {
            return ((delegate* unmanaged<ISpeechLexiconPronunciation*, uint*, int>)(lpVtbl[3]))((ISpeechLexiconPronunciation*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetTypeInfo([NativeTypeName("UINT")] uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<ISpeechLexiconPronunciation*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((ISpeechLexiconPronunciation*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, [NativeTypeName("UINT")] uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<ISpeechLexiconPronunciation*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((ISpeechLexiconPronunciation*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, [NativeTypeName("UINT *")] uint* puArgErr)
        {
            return ((delegate* unmanaged<ISpeechLexiconPronunciation*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((ISpeechLexiconPronunciation*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT get_Type(SpeechLexiconType* LexiconType)
        {
            return ((delegate* unmanaged<ISpeechLexiconPronunciation*, SpeechLexiconType*, int>)(lpVtbl[7]))((ISpeechLexiconPronunciation*)Unsafe.AsPointer(ref this), LexiconType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT get_LangId([NativeTypeName("SpeechLanguageId *")] int* LangId)
        {
            return ((delegate* unmanaged<ISpeechLexiconPronunciation*, int*, int>)(lpVtbl[8]))((ISpeechLexiconPronunciation*)Unsafe.AsPointer(ref this), LangId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT get_PartOfSpeech(SpeechPartOfSpeech* PartOfSpeech)
        {
            return ((delegate* unmanaged<ISpeechLexiconPronunciation*, SpeechPartOfSpeech*, int>)(lpVtbl[9]))((ISpeechLexiconPronunciation*)Unsafe.AsPointer(ref this), PartOfSpeech);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT get_PhoneIds(VARIANT* PhoneIds)
        {
            return ((delegate* unmanaged<ISpeechLexiconPronunciation*, VARIANT*, int>)(lpVtbl[10]))((ISpeechLexiconPronunciation*)Unsafe.AsPointer(ref this), PhoneIds);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT get_Symbolic([NativeTypeName("BSTR *")] ushort** Symbolic)
        {
            return ((delegate* unmanaged<ISpeechLexiconPronunciation*, ushort**, int>)(lpVtbl[11]))((ISpeechLexiconPronunciation*)Unsafe.AsPointer(ref this), Symbolic);
        }
    }
}
