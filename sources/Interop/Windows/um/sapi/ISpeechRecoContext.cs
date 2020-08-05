// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("580AA49D-7E1E-4809-B8E2-57DA806104B8")]
    [NativeTypeName("struct ISpeechRecoContext : IDispatch")]
    public unsafe partial struct ISpeechRecoContext
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<ISpeechRecoContext*, Guid*, void**, int>)(lpVtbl[0]))((ISpeechRecoContext*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<ISpeechRecoContext*, uint>)(lpVtbl[1]))((ISpeechRecoContext*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<ISpeechRecoContext*, uint>)(lpVtbl[2]))((ISpeechRecoContext*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfoCount([NativeTypeName("UINT *")] uint* pctinfo)
        {
            return ((delegate* stdcall<ISpeechRecoContext*, uint*, int>)(lpVtbl[3]))((ISpeechRecoContext*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfo([NativeTypeName("UINT")] uint iTInfo, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("ITypeInfo **")] ITypeInfo** ppTInfo)
        {
            return ((delegate* stdcall<ISpeechRecoContext*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((ISpeechRecoContext*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, [NativeTypeName("UINT")] uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* stdcall<ISpeechRecoContext*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((ISpeechRecoContext*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [return: NativeTypeName("HRESULT")]
        public int Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, [NativeTypeName("DISPPARAMS *")] DISPPARAMS* pDispParams, [NativeTypeName("VARIANT *")] VARIANT* pVarResult, [NativeTypeName("EXCEPINFO *")] EXCEPINFO* pExcepInfo, [NativeTypeName("UINT *")] uint* puArgErr)
        {
            return ((delegate* stdcall<ISpeechRecoContext*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((ISpeechRecoContext*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_Recognizer([NativeTypeName("ISpeechRecognizer **")] ISpeechRecognizer** Recognizer)
        {
            return ((delegate* stdcall<ISpeechRecoContext*, ISpeechRecognizer**, int>)(lpVtbl[7]))((ISpeechRecoContext*)Unsafe.AsPointer(ref this), Recognizer);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_AudioInputInterferenceStatus([NativeTypeName("SpeechInterference *")] SpeechInterference* Interference)
        {
            return ((delegate* stdcall<ISpeechRecoContext*, SpeechInterference*, int>)(lpVtbl[8]))((ISpeechRecoContext*)Unsafe.AsPointer(ref this), Interference);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_RequestedUIType([NativeTypeName("BSTR *")] ushort** UIType)
        {
            return ((delegate* stdcall<ISpeechRecoContext*, ushort**, int>)(lpVtbl[9]))((ISpeechRecoContext*)Unsafe.AsPointer(ref this), UIType);
        }

        [return: NativeTypeName("HRESULT")]
        public int putref_Voice([NativeTypeName("ISpeechVoice *")] ISpeechVoice* Voice)
        {
            return ((delegate* stdcall<ISpeechRecoContext*, ISpeechVoice*, int>)(lpVtbl[10]))((ISpeechRecoContext*)Unsafe.AsPointer(ref this), Voice);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_Voice([NativeTypeName("ISpeechVoice **")] ISpeechVoice** Voice)
        {
            return ((delegate* stdcall<ISpeechRecoContext*, ISpeechVoice**, int>)(lpVtbl[11]))((ISpeechRecoContext*)Unsafe.AsPointer(ref this), Voice);
        }

        [return: NativeTypeName("HRESULT")]
        public int put_AllowVoiceFormatMatchingOnNextSet([NativeTypeName("VARIANT_BOOL")] short Allow)
        {
            return ((delegate* stdcall<ISpeechRecoContext*, short, int>)(lpVtbl[12]))((ISpeechRecoContext*)Unsafe.AsPointer(ref this), Allow);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_AllowVoiceFormatMatchingOnNextSet([NativeTypeName("VARIANT_BOOL *")] short* pAllow)
        {
            return ((delegate* stdcall<ISpeechRecoContext*, short*, int>)(lpVtbl[13]))((ISpeechRecoContext*)Unsafe.AsPointer(ref this), pAllow);
        }

        [return: NativeTypeName("HRESULT")]
        public int put_VoicePurgeEvent(SpeechRecoEvents EventInterest)
        {
            return ((delegate* stdcall<ISpeechRecoContext*, SpeechRecoEvents, int>)(lpVtbl[14]))((ISpeechRecoContext*)Unsafe.AsPointer(ref this), EventInterest);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_VoicePurgeEvent([NativeTypeName("SpeechRecoEvents *")] SpeechRecoEvents* EventInterest)
        {
            return ((delegate* stdcall<ISpeechRecoContext*, SpeechRecoEvents*, int>)(lpVtbl[15]))((ISpeechRecoContext*)Unsafe.AsPointer(ref this), EventInterest);
        }

        [return: NativeTypeName("HRESULT")]
        public int put_EventInterests(SpeechRecoEvents EventInterest)
        {
            return ((delegate* stdcall<ISpeechRecoContext*, SpeechRecoEvents, int>)(lpVtbl[16]))((ISpeechRecoContext*)Unsafe.AsPointer(ref this), EventInterest);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_EventInterests([NativeTypeName("SpeechRecoEvents *")] SpeechRecoEvents* EventInterest)
        {
            return ((delegate* stdcall<ISpeechRecoContext*, SpeechRecoEvents*, int>)(lpVtbl[17]))((ISpeechRecoContext*)Unsafe.AsPointer(ref this), EventInterest);
        }

        [return: NativeTypeName("HRESULT")]
        public int put_CmdMaxAlternates([NativeTypeName("long")] int MaxAlternates)
        {
            return ((delegate* stdcall<ISpeechRecoContext*, int, int>)(lpVtbl[18]))((ISpeechRecoContext*)Unsafe.AsPointer(ref this), MaxAlternates);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_CmdMaxAlternates([NativeTypeName("long *")] int* MaxAlternates)
        {
            return ((delegate* stdcall<ISpeechRecoContext*, int*, int>)(lpVtbl[19]))((ISpeechRecoContext*)Unsafe.AsPointer(ref this), MaxAlternates);
        }

        [return: NativeTypeName("HRESULT")]
        public int put_State(SpeechRecoContextState State)
        {
            return ((delegate* stdcall<ISpeechRecoContext*, SpeechRecoContextState, int>)(lpVtbl[20]))((ISpeechRecoContext*)Unsafe.AsPointer(ref this), State);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_State([NativeTypeName("SpeechRecoContextState *")] SpeechRecoContextState* State)
        {
            return ((delegate* stdcall<ISpeechRecoContext*, SpeechRecoContextState*, int>)(lpVtbl[21]))((ISpeechRecoContext*)Unsafe.AsPointer(ref this), State);
        }

        [return: NativeTypeName("HRESULT")]
        public int put_RetainedAudio(SpeechRetainedAudioOptions Option)
        {
            return ((delegate* stdcall<ISpeechRecoContext*, SpeechRetainedAudioOptions, int>)(lpVtbl[22]))((ISpeechRecoContext*)Unsafe.AsPointer(ref this), Option);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_RetainedAudio([NativeTypeName("SpeechRetainedAudioOptions *")] SpeechRetainedAudioOptions* Option)
        {
            return ((delegate* stdcall<ISpeechRecoContext*, SpeechRetainedAudioOptions*, int>)(lpVtbl[23]))((ISpeechRecoContext*)Unsafe.AsPointer(ref this), Option);
        }

        [return: NativeTypeName("HRESULT")]
        public int putref_RetainedAudioFormat([NativeTypeName("ISpeechAudioFormat *")] ISpeechAudioFormat* Format)
        {
            return ((delegate* stdcall<ISpeechRecoContext*, ISpeechAudioFormat*, int>)(lpVtbl[24]))((ISpeechRecoContext*)Unsafe.AsPointer(ref this), Format);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_RetainedAudioFormat([NativeTypeName("ISpeechAudioFormat **")] ISpeechAudioFormat** Format)
        {
            return ((delegate* stdcall<ISpeechRecoContext*, ISpeechAudioFormat**, int>)(lpVtbl[25]))((ISpeechRecoContext*)Unsafe.AsPointer(ref this), Format);
        }

        [return: NativeTypeName("HRESULT")]
        public int Pause()
        {
            return ((delegate* stdcall<ISpeechRecoContext*, int>)(lpVtbl[26]))((ISpeechRecoContext*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Resume()
        {
            return ((delegate* stdcall<ISpeechRecoContext*, int>)(lpVtbl[27]))((ISpeechRecoContext*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateGrammar(VARIANT GrammarId, [NativeTypeName("ISpeechRecoGrammar **")] ISpeechRecoGrammar** Grammar)
        {
            return ((delegate* stdcall<ISpeechRecoContext*, VARIANT, ISpeechRecoGrammar**, int>)(lpVtbl[28]))((ISpeechRecoContext*)Unsafe.AsPointer(ref this), GrammarId, Grammar);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateResultFromMemory([NativeTypeName("VARIANT *")] VARIANT* ResultBlock, [NativeTypeName("ISpeechRecoResult **")] ISpeechRecoResult** Result)
        {
            return ((delegate* stdcall<ISpeechRecoContext*, VARIANT*, ISpeechRecoResult**, int>)(lpVtbl[29]))((ISpeechRecoContext*)Unsafe.AsPointer(ref this), ResultBlock, Result);
        }

        [return: NativeTypeName("HRESULT")]
        public int Bookmark(SpeechBookmarkOptions Options, VARIANT StreamPos, VARIANT BookmarkId)
        {
            return ((delegate* stdcall<ISpeechRecoContext*, SpeechBookmarkOptions, VARIANT, VARIANT, int>)(lpVtbl[30]))((ISpeechRecoContext*)Unsafe.AsPointer(ref this), Options, StreamPos, BookmarkId);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetAdaptationData([NativeTypeName("BSTR")] ushort* AdaptationString)
        {
            return ((delegate* stdcall<ISpeechRecoContext*, ushort*, int>)(lpVtbl[31]))((ISpeechRecoContext*)Unsafe.AsPointer(ref this), AdaptationString);
        }
    }
}
