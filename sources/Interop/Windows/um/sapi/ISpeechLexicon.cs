// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.SpeechPartOfSpeech;

namespace TerraFX.Interop
{
    [Guid("3DA7627A-C7AE-4B23-8708-638C50362C25")]
    [NativeTypeName("struct ISpeechLexicon : IDispatch")]
    public unsafe partial struct ISpeechLexicon
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<ISpeechLexicon*, Guid*, void**, int>)(lpVtbl[0]))((ISpeechLexicon*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<ISpeechLexicon*, uint>)(lpVtbl[1]))((ISpeechLexicon*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<ISpeechLexicon*, uint>)(lpVtbl[2]))((ISpeechLexicon*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfoCount([NativeTypeName("UINT *")] uint* pctinfo)
        {
            return ((delegate* stdcall<ISpeechLexicon*, uint*, int>)(lpVtbl[3]))((ISpeechLexicon*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfo([NativeTypeName("UINT")] uint iTInfo, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("ITypeInfo **")] ITypeInfo** ppTInfo)
        {
            return ((delegate* stdcall<ISpeechLexicon*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((ISpeechLexicon*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, [NativeTypeName("UINT")] uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* stdcall<ISpeechLexicon*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((ISpeechLexicon*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [return: NativeTypeName("HRESULT")]
        public int Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, [NativeTypeName("DISPPARAMS *")] DISPPARAMS* pDispParams, [NativeTypeName("VARIANT *")] VARIANT* pVarResult, [NativeTypeName("EXCEPINFO *")] EXCEPINFO* pExcepInfo, [NativeTypeName("UINT *")] uint* puArgErr)
        {
            return ((delegate* stdcall<ISpeechLexicon*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((ISpeechLexicon*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_GenerationId([NativeTypeName("long *")] int* GenerationId)
        {
            return ((delegate* stdcall<ISpeechLexicon*, int*, int>)(lpVtbl[7]))((ISpeechLexicon*)Unsafe.AsPointer(ref this), GenerationId);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetWords(SpeechLexiconType Flags, [NativeTypeName("long *")] int* GenerationID, [NativeTypeName("ISpeechLexiconWords **")] ISpeechLexiconWords** Words)
        {
            return ((delegate* stdcall<ISpeechLexicon*, SpeechLexiconType, int*, ISpeechLexiconWords**, int>)(lpVtbl[8]))((ISpeechLexicon*)Unsafe.AsPointer(ref this), Flags, GenerationID, Words);
        }

        [return: NativeTypeName("HRESULT")]
        public int AddPronunciation([NativeTypeName("BSTR")] ushort* bstrWord, [NativeTypeName("SpeechLanguageId")] int LangId, SpeechPartOfSpeech PartOfSpeech = SPSUnknown, [NativeTypeName("BSTR")] ushort* bstrPronunciation = null)
        {
            return ((delegate* stdcall<ISpeechLexicon*, ushort*, int, SpeechPartOfSpeech, ushort*, int>)(lpVtbl[9]))((ISpeechLexicon*)Unsafe.AsPointer(ref this), bstrWord, LangId, PartOfSpeech, bstrPronunciation);
        }

        [return: NativeTypeName("HRESULT")]
        public int AddPronunciationByPhoneIds([NativeTypeName("BSTR")] ushort* bstrWord, [NativeTypeName("SpeechLanguageId")] int LangId, SpeechPartOfSpeech PartOfSpeech = SPSUnknown, [NativeTypeName("VARIANT *")] VARIANT* PhoneIds = null)
        {
            return ((delegate* stdcall<ISpeechLexicon*, ushort*, int, SpeechPartOfSpeech, VARIANT*, int>)(lpVtbl[10]))((ISpeechLexicon*)Unsafe.AsPointer(ref this), bstrWord, LangId, PartOfSpeech, PhoneIds);
        }

        [return: NativeTypeName("HRESULT")]
        public int RemovePronunciation([NativeTypeName("BSTR")] ushort* bstrWord, [NativeTypeName("SpeechLanguageId")] int LangId, SpeechPartOfSpeech PartOfSpeech = SPSUnknown, [NativeTypeName("BSTR")] ushort* bstrPronunciation = null)
        {
            return ((delegate* stdcall<ISpeechLexicon*, ushort*, int, SpeechPartOfSpeech, ushort*, int>)(lpVtbl[11]))((ISpeechLexicon*)Unsafe.AsPointer(ref this), bstrWord, LangId, PartOfSpeech, bstrPronunciation);
        }

        [return: NativeTypeName("HRESULT")]
        public int RemovePronunciationByPhoneIds([NativeTypeName("BSTR")] ushort* bstrWord, [NativeTypeName("SpeechLanguageId")] int LangId, SpeechPartOfSpeech PartOfSpeech = SPSUnknown, [NativeTypeName("VARIANT *")] VARIANT* PhoneIds = null)
        {
            return ((delegate* stdcall<ISpeechLexicon*, ushort*, int, SpeechPartOfSpeech, VARIANT*, int>)(lpVtbl[12]))((ISpeechLexicon*)Unsafe.AsPointer(ref this), bstrWord, LangId, PartOfSpeech, PhoneIds);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPronunciations([NativeTypeName("BSTR")] ushort* bstrWord, [NativeTypeName("SpeechLanguageId")] int LangId, SpeechLexiconType TypeFlags, [NativeTypeName("ISpeechLexiconPronunciations **")] ISpeechLexiconPronunciations** ppPronunciations)
        {
            return ((delegate* stdcall<ISpeechLexicon*, ushort*, int, SpeechLexiconType, ISpeechLexiconPronunciations**, int>)(lpVtbl[13]))((ISpeechLexicon*)Unsafe.AsPointer(ref this), bstrWord, LangId, TypeFlags, ppPronunciations);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetGenerationChange([NativeTypeName("long *")] int* GenerationID, [NativeTypeName("ISpeechLexiconWords **")] ISpeechLexiconWords** ppWords)
        {
            return ((delegate* stdcall<ISpeechLexicon*, int*, ISpeechLexiconWords**, int>)(lpVtbl[14]))((ISpeechLexicon*)Unsafe.AsPointer(ref this), GenerationID, ppWords);
        }
    }
}
