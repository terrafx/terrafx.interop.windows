// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("95252C5D-9E43-4F4A-9899-48EE73352F9F")]
    [NativeTypeName("struct ISpeechLexiconPronunciation : IDispatch")]
    public unsafe partial struct ISpeechLexiconPronunciation
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<ISpeechLexiconPronunciation*, Guid*, void**, int>)(lpVtbl[0]))((ISpeechLexiconPronunciation*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<ISpeechLexiconPronunciation*, uint>)(lpVtbl[1]))((ISpeechLexiconPronunciation*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<ISpeechLexiconPronunciation*, uint>)(lpVtbl[2]))((ISpeechLexiconPronunciation*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfoCount([NativeTypeName("UINT *")] uint* pctinfo)
        {
            return ((delegate* stdcall<ISpeechLexiconPronunciation*, uint*, int>)(lpVtbl[3]))((ISpeechLexiconPronunciation*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfo([NativeTypeName("UINT")] uint iTInfo, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("ITypeInfo **")] ITypeInfo** ppTInfo)
        {
            return ((delegate* stdcall<ISpeechLexiconPronunciation*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((ISpeechLexiconPronunciation*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, [NativeTypeName("UINT")] uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* stdcall<ISpeechLexiconPronunciation*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((ISpeechLexiconPronunciation*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, [NativeTypeName("DISPPARAMS *")] DISPPARAMS* pDispParams, [NativeTypeName("VARIANT *")] VARIANT* pVarResult, [NativeTypeName("EXCEPINFO *")] EXCEPINFO* pExcepInfo, [NativeTypeName("UINT *")] uint* puArgErr)
        {
            return ((delegate* stdcall<ISpeechLexiconPronunciation*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((ISpeechLexiconPronunciation*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Type([NativeTypeName("SpeechLexiconType *")] SpeechLexiconType* LexiconType)
        {
            return ((delegate* stdcall<ISpeechLexiconPronunciation*, SpeechLexiconType*, int>)(lpVtbl[7]))((ISpeechLexiconPronunciation*)Unsafe.AsPointer(ref this), LexiconType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_LangId([NativeTypeName("SpeechLanguageId *")] int* LangId)
        {
            return ((delegate* stdcall<ISpeechLexiconPronunciation*, int*, int>)(lpVtbl[8]))((ISpeechLexiconPronunciation*)Unsafe.AsPointer(ref this), LangId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_PartOfSpeech([NativeTypeName("SpeechPartOfSpeech *")] SpeechPartOfSpeech* PartOfSpeech)
        {
            return ((delegate* stdcall<ISpeechLexiconPronunciation*, SpeechPartOfSpeech*, int>)(lpVtbl[9]))((ISpeechLexiconPronunciation*)Unsafe.AsPointer(ref this), PartOfSpeech);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_PhoneIds([NativeTypeName("VARIANT *")] VARIANT* PhoneIds)
        {
            return ((delegate* stdcall<ISpeechLexiconPronunciation*, VARIANT*, int>)(lpVtbl[10]))((ISpeechLexiconPronunciation*)Unsafe.AsPointer(ref this), PhoneIds);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Symbolic([NativeTypeName("BSTR *")] ushort** Symbolic)
        {
            return ((delegate* stdcall<ISpeechLexiconPronunciation*, ushort**, int>)(lpVtbl[11]))((ISpeechLexiconPronunciation*)Unsafe.AsPointer(ref this), Symbolic);
        }
    }
}
