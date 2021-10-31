// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("580AA49D-7E1E-4809-B8E2-57DA806104B8")]
    [NativeTypeName("struct ISpeechRecoContext : IDispatch")]
    [NativeInheritance("IDispatch")]
    public unsafe partial struct ISpeechRecoContext
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ISpeechRecoContext*, Guid*, void**, int>)(lpVtbl[0]))((ISpeechRecoContext*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ISpeechRecoContext*, uint>)(lpVtbl[1]))((ISpeechRecoContext*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ISpeechRecoContext*, uint>)(lpVtbl[2]))((ISpeechRecoContext*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetTypeInfoCount([NativeTypeName("UINT *")] uint* pctinfo)
        {
            return ((delegate* unmanaged<ISpeechRecoContext*, uint*, int>)(lpVtbl[3]))((ISpeechRecoContext*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetTypeInfo([NativeTypeName("UINT")] uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<ISpeechRecoContext*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((ISpeechRecoContext*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, [NativeTypeName("UINT")] uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<ISpeechRecoContext*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((ISpeechRecoContext*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, [NativeTypeName("UINT *")] uint* puArgErr)
        {
            return ((delegate* unmanaged<ISpeechRecoContext*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((ISpeechRecoContext*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT get_Recognizer(ISpeechRecognizer** Recognizer)
        {
            return ((delegate* unmanaged<ISpeechRecoContext*, ISpeechRecognizer**, int>)(lpVtbl[7]))((ISpeechRecoContext*)Unsafe.AsPointer(ref this), Recognizer);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT get_AudioInputInterferenceStatus(SpeechInterference* Interference)
        {
            return ((delegate* unmanaged<ISpeechRecoContext*, SpeechInterference*, int>)(lpVtbl[8]))((ISpeechRecoContext*)Unsafe.AsPointer(ref this), Interference);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT get_RequestedUIType([NativeTypeName("BSTR *")] ushort** UIType)
        {
            return ((delegate* unmanaged<ISpeechRecoContext*, ushort**, int>)(lpVtbl[9]))((ISpeechRecoContext*)Unsafe.AsPointer(ref this), UIType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT putref_Voice(ISpeechVoice* Voice)
        {
            return ((delegate* unmanaged<ISpeechRecoContext*, ISpeechVoice*, int>)(lpVtbl[10]))((ISpeechRecoContext*)Unsafe.AsPointer(ref this), Voice);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT get_Voice(ISpeechVoice** Voice)
        {
            return ((delegate* unmanaged<ISpeechRecoContext*, ISpeechVoice**, int>)(lpVtbl[11]))((ISpeechRecoContext*)Unsafe.AsPointer(ref this), Voice);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT put_AllowVoiceFormatMatchingOnNextSet([NativeTypeName("VARIANT_BOOL")] short Allow)
        {
            return ((delegate* unmanaged<ISpeechRecoContext*, short, int>)(lpVtbl[12]))((ISpeechRecoContext*)Unsafe.AsPointer(ref this), Allow);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT get_AllowVoiceFormatMatchingOnNextSet([NativeTypeName("VARIANT_BOOL *")] short* pAllow)
        {
            return ((delegate* unmanaged<ISpeechRecoContext*, short*, int>)(lpVtbl[13]))((ISpeechRecoContext*)Unsafe.AsPointer(ref this), pAllow);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HRESULT put_VoicePurgeEvent(SpeechRecoEvents EventInterest)
        {
            return ((delegate* unmanaged<ISpeechRecoContext*, SpeechRecoEvents, int>)(lpVtbl[14]))((ISpeechRecoContext*)Unsafe.AsPointer(ref this), EventInterest);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public HRESULT get_VoicePurgeEvent(SpeechRecoEvents* EventInterest)
        {
            return ((delegate* unmanaged<ISpeechRecoContext*, SpeechRecoEvents*, int>)(lpVtbl[15]))((ISpeechRecoContext*)Unsafe.AsPointer(ref this), EventInterest);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        public HRESULT put_EventInterests(SpeechRecoEvents EventInterest)
        {
            return ((delegate* unmanaged<ISpeechRecoContext*, SpeechRecoEvents, int>)(lpVtbl[16]))((ISpeechRecoContext*)Unsafe.AsPointer(ref this), EventInterest);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        public HRESULT get_EventInterests(SpeechRecoEvents* EventInterest)
        {
            return ((delegate* unmanaged<ISpeechRecoContext*, SpeechRecoEvents*, int>)(lpVtbl[17]))((ISpeechRecoContext*)Unsafe.AsPointer(ref this), EventInterest);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        public HRESULT put_CmdMaxAlternates([NativeTypeName("long")] int MaxAlternates)
        {
            return ((delegate* unmanaged<ISpeechRecoContext*, int, int>)(lpVtbl[18]))((ISpeechRecoContext*)Unsafe.AsPointer(ref this), MaxAlternates);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        public HRESULT get_CmdMaxAlternates([NativeTypeName("long *")] int* MaxAlternates)
        {
            return ((delegate* unmanaged<ISpeechRecoContext*, int*, int>)(lpVtbl[19]))((ISpeechRecoContext*)Unsafe.AsPointer(ref this), MaxAlternates);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        public HRESULT put_State(SpeechRecoContextState State)
        {
            return ((delegate* unmanaged<ISpeechRecoContext*, SpeechRecoContextState, int>)(lpVtbl[20]))((ISpeechRecoContext*)Unsafe.AsPointer(ref this), State);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        public HRESULT get_State(SpeechRecoContextState* State)
        {
            return ((delegate* unmanaged<ISpeechRecoContext*, SpeechRecoContextState*, int>)(lpVtbl[21]))((ISpeechRecoContext*)Unsafe.AsPointer(ref this), State);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(22)]
        public HRESULT put_RetainedAudio(SpeechRetainedAudioOptions Option)
        {
            return ((delegate* unmanaged<ISpeechRecoContext*, SpeechRetainedAudioOptions, int>)(lpVtbl[22]))((ISpeechRecoContext*)Unsafe.AsPointer(ref this), Option);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(23)]
        public HRESULT get_RetainedAudio(SpeechRetainedAudioOptions* Option)
        {
            return ((delegate* unmanaged<ISpeechRecoContext*, SpeechRetainedAudioOptions*, int>)(lpVtbl[23]))((ISpeechRecoContext*)Unsafe.AsPointer(ref this), Option);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(24)]
        public HRESULT putref_RetainedAudioFormat(ISpeechAudioFormat* Format)
        {
            return ((delegate* unmanaged<ISpeechRecoContext*, ISpeechAudioFormat*, int>)(lpVtbl[24]))((ISpeechRecoContext*)Unsafe.AsPointer(ref this), Format);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(25)]
        public HRESULT get_RetainedAudioFormat(ISpeechAudioFormat** Format)
        {
            return ((delegate* unmanaged<ISpeechRecoContext*, ISpeechAudioFormat**, int>)(lpVtbl[25]))((ISpeechRecoContext*)Unsafe.AsPointer(ref this), Format);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(26)]
        public HRESULT Pause()
        {
            return ((delegate* unmanaged<ISpeechRecoContext*, int>)(lpVtbl[26]))((ISpeechRecoContext*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(27)]
        public HRESULT Resume()
        {
            return ((delegate* unmanaged<ISpeechRecoContext*, int>)(lpVtbl[27]))((ISpeechRecoContext*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(28)]
        public HRESULT CreateGrammar(VARIANT GrammarId, ISpeechRecoGrammar** Grammar)
        {
            return ((delegate* unmanaged<ISpeechRecoContext*, VARIANT, ISpeechRecoGrammar**, int>)(lpVtbl[28]))((ISpeechRecoContext*)Unsafe.AsPointer(ref this), GrammarId, Grammar);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(29)]
        public HRESULT CreateResultFromMemory(VARIANT* ResultBlock, ISpeechRecoResult** Result)
        {
            return ((delegate* unmanaged<ISpeechRecoContext*, VARIANT*, ISpeechRecoResult**, int>)(lpVtbl[29]))((ISpeechRecoContext*)Unsafe.AsPointer(ref this), ResultBlock, Result);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(30)]
        public HRESULT Bookmark(SpeechBookmarkOptions Options, VARIANT StreamPos, VARIANT BookmarkId)
        {
            return ((delegate* unmanaged<ISpeechRecoContext*, SpeechBookmarkOptions, VARIANT, VARIANT, int>)(lpVtbl[30]))((ISpeechRecoContext*)Unsafe.AsPointer(ref this), Options, StreamPos, BookmarkId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(31)]
        public HRESULT SetAdaptationData([NativeTypeName("BSTR")] ushort* AdaptationString)
        {
            return ((delegate* unmanaged<ISpeechRecoContext*, ushort*, int>)(lpVtbl[31]))((ISpeechRecoContext*)Unsafe.AsPointer(ref this), AdaptationString);
        }
    }
}
