// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("6D60EB64-ACED-40A6-BBF3-4E557F71DEE2")]
    [NativeTypeName("struct ISpeechRecoResultDispatch : IDispatch")]
    [NativeInheritance("IDispatch")]
    public unsafe partial struct ISpeechRecoResultDispatch : ISpeechRecoResultDispatch.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ISpeechRecoResultDispatch*, Guid*, void**, int>)(lpVtbl[0]))((ISpeechRecoResultDispatch*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ISpeechRecoResultDispatch*, uint>)(lpVtbl[1]))((ISpeechRecoResultDispatch*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ISpeechRecoResultDispatch*, uint>)(lpVtbl[2]))((ISpeechRecoResultDispatch*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetTypeInfoCount(uint* pctinfo)
        {
            return ((delegate* unmanaged<ISpeechRecoResultDispatch*, uint*, int>)(lpVtbl[3]))((ISpeechRecoResultDispatch*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<ISpeechRecoResultDispatch*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((ISpeechRecoResultDispatch*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<ISpeechRecoResultDispatch*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((ISpeechRecoResultDispatch*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
        {
            return ((delegate* unmanaged<ISpeechRecoResultDispatch*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((ISpeechRecoResultDispatch*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT get_RecoContext(ISpeechRecoContext** RecoContext)
        {
            return ((delegate* unmanaged<ISpeechRecoResultDispatch*, ISpeechRecoContext**, int>)(lpVtbl[7]))((ISpeechRecoResultDispatch*)Unsafe.AsPointer(ref this), RecoContext);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT get_Times(ISpeechRecoResultTimes** Times)
        {
            return ((delegate* unmanaged<ISpeechRecoResultDispatch*, ISpeechRecoResultTimes**, int>)(lpVtbl[8]))((ISpeechRecoResultDispatch*)Unsafe.AsPointer(ref this), Times);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT putref_AudioFormat(ISpeechAudioFormat* Format)
        {
            return ((delegate* unmanaged<ISpeechRecoResultDispatch*, ISpeechAudioFormat*, int>)(lpVtbl[9]))((ISpeechRecoResultDispatch*)Unsafe.AsPointer(ref this), Format);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT get_AudioFormat(ISpeechAudioFormat** Format)
        {
            return ((delegate* unmanaged<ISpeechRecoResultDispatch*, ISpeechAudioFormat**, int>)(lpVtbl[10]))((ISpeechRecoResultDispatch*)Unsafe.AsPointer(ref this), Format);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT get_PhraseInfo(ISpeechPhraseInfo** PhraseInfo)
        {
            return ((delegate* unmanaged<ISpeechRecoResultDispatch*, ISpeechPhraseInfo**, int>)(lpVtbl[11]))((ISpeechRecoResultDispatch*)Unsafe.AsPointer(ref this), PhraseInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT Alternates([NativeTypeName("long")] int RequestCount, [NativeTypeName("long")] int StartElement, [NativeTypeName("long")] int Elements, ISpeechPhraseAlternates** Alternates)
        {
            return ((delegate* unmanaged<ISpeechRecoResultDispatch*, int, int, int, ISpeechPhraseAlternates**, int>)(lpVtbl[12]))((ISpeechRecoResultDispatch*)Unsafe.AsPointer(ref this), RequestCount, StartElement, Elements, Alternates);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT Audio([NativeTypeName("long")] int StartElement, [NativeTypeName("long")] int Elements, ISpeechMemoryStream** Stream)
        {
            return ((delegate* unmanaged<ISpeechRecoResultDispatch*, int, int, ISpeechMemoryStream**, int>)(lpVtbl[13]))((ISpeechRecoResultDispatch*)Unsafe.AsPointer(ref this), StartElement, Elements, Stream);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HRESULT SpeakAudio([NativeTypeName("long")] int StartElement, [NativeTypeName("long")] int Elements, SpeechVoiceSpeakFlags Flags, [NativeTypeName("long *")] int* StreamNumber)
        {
            return ((delegate* unmanaged<ISpeechRecoResultDispatch*, int, int, SpeechVoiceSpeakFlags, int*, int>)(lpVtbl[14]))((ISpeechRecoResultDispatch*)Unsafe.AsPointer(ref this), StartElement, Elements, Flags, StreamNumber);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public HRESULT SaveToMemory(VARIANT* ResultBlock)
        {
            return ((delegate* unmanaged<ISpeechRecoResultDispatch*, VARIANT*, int>)(lpVtbl[15]))((ISpeechRecoResultDispatch*)Unsafe.AsPointer(ref this), ResultBlock);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        public HRESULT DiscardResultInfo(SpeechDiscardType ValueTypes)
        {
            return ((delegate* unmanaged<ISpeechRecoResultDispatch*, SpeechDiscardType, int>)(lpVtbl[16]))((ISpeechRecoResultDispatch*)Unsafe.AsPointer(ref this), ValueTypes);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        public HRESULT GetXMLResult(SPXMLRESULTOPTIONS Options, [NativeTypeName("BSTR *")] ushort** pResult)
        {
            return ((delegate* unmanaged<ISpeechRecoResultDispatch*, SPXMLRESULTOPTIONS, ushort**, int>)(lpVtbl[17]))((ISpeechRecoResultDispatch*)Unsafe.AsPointer(ref this), Options, pResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        public HRESULT GetXMLErrorInfo([NativeTypeName("long *")] int* LineNumber, [NativeTypeName("BSTR *")] ushort** ScriptLine, [NativeTypeName("BSTR *")] ushort** Source, [NativeTypeName("BSTR *")] ushort** Description, HRESULT* ResultCode, [NativeTypeName("VARIANT_BOOL *")] short* IsError)
        {
            return ((delegate* unmanaged<ISpeechRecoResultDispatch*, int*, ushort**, ushort**, ushort**, HRESULT*, short*, int>)(lpVtbl[18]))((ISpeechRecoResultDispatch*)Unsafe.AsPointer(ref this), LineNumber, ScriptLine, Source, Description, ResultCode, IsError);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        public HRESULT SetTextFeedback([NativeTypeName("BSTR")] ushort* Feedback, [NativeTypeName("VARIANT_BOOL")] short WasSuccessful)
        {
            return ((delegate* unmanaged<ISpeechRecoResultDispatch*, ushort*, short, int>)(lpVtbl[19]))((ISpeechRecoResultDispatch*)Unsafe.AsPointer(ref this), Feedback, WasSuccessful);
        }

        public interface Interface : IDispatch.Interface
        {
            [VtblIndex(7)]
            HRESULT get_RecoContext(ISpeechRecoContext** RecoContext);

            [VtblIndex(8)]
            HRESULT get_Times(ISpeechRecoResultTimes** Times);

            [VtblIndex(9)]
            HRESULT putref_AudioFormat(ISpeechAudioFormat* Format);

            [VtblIndex(10)]
            HRESULT get_AudioFormat(ISpeechAudioFormat** Format);

            [VtblIndex(11)]
            HRESULT get_PhraseInfo(ISpeechPhraseInfo** PhraseInfo);

            [VtblIndex(12)]
            HRESULT Alternates([NativeTypeName("long")] int RequestCount, [NativeTypeName("long")] int StartElement, [NativeTypeName("long")] int Elements, ISpeechPhraseAlternates** Alternates);

            [VtblIndex(13)]
            HRESULT Audio([NativeTypeName("long")] int StartElement, [NativeTypeName("long")] int Elements, ISpeechMemoryStream** Stream);

            [VtblIndex(14)]
            HRESULT SpeakAudio([NativeTypeName("long")] int StartElement, [NativeTypeName("long")] int Elements, SpeechVoiceSpeakFlags Flags, [NativeTypeName("long *")] int* StreamNumber);

            [VtblIndex(15)]
            HRESULT SaveToMemory(VARIANT* ResultBlock);

            [VtblIndex(16)]
            HRESULT DiscardResultInfo(SpeechDiscardType ValueTypes);

            [VtblIndex(17)]
            HRESULT GetXMLResult(SPXMLRESULTOPTIONS Options, [NativeTypeName("BSTR *")] ushort** pResult);

            [VtblIndex(18)]
            HRESULT GetXMLErrorInfo([NativeTypeName("long *")] int* LineNumber, [NativeTypeName("BSTR *")] ushort** ScriptLine, [NativeTypeName("BSTR *")] ushort** Source, [NativeTypeName("BSTR *")] ushort** Description, HRESULT* ResultCode, [NativeTypeName("VARIANT_BOOL *")] short* IsError);

            [VtblIndex(19)]
            HRESULT SetTextFeedback([NativeTypeName("BSTR")] ushort* Feedback, [NativeTypeName("VARIANT_BOOL")] short WasSuccessful);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpeechRecoResultDispatch*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ISpeechRecoResultDispatch*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ISpeechRecoResultDispatch*, uint> Release;

            [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpeechRecoResultDispatch*, uint*, int> GetTypeInfoCount;

            [NativeTypeName("HRESULT (UINT, LCID, ITypeInfo **) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpeechRecoResultDispatch*, uint, uint, ITypeInfo**, int> GetTypeInfo;

            [NativeTypeName("HRESULT (const IID &, LPOLESTR *, UINT, LCID, DISPID *) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpeechRecoResultDispatch*, Guid*, ushort**, uint, uint, int*, int> GetIDsOfNames;

            [NativeTypeName("HRESULT (DISPID, const IID &, LCID, WORD, DISPPARAMS *, VARIANT *, EXCEPINFO *, UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpeechRecoResultDispatch*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int> Invoke;

            [NativeTypeName("HRESULT (ISpeechRecoContext **) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpeechRecoResultDispatch*, ISpeechRecoContext**, int> get_RecoContext;

            [NativeTypeName("HRESULT (ISpeechRecoResultTimes **) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpeechRecoResultDispatch*, ISpeechRecoResultTimes**, int> get_Times;

            [NativeTypeName("HRESULT (ISpeechAudioFormat *) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpeechRecoResultDispatch*, ISpeechAudioFormat*, int> putref_AudioFormat;

            [NativeTypeName("HRESULT (ISpeechAudioFormat **) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpeechRecoResultDispatch*, ISpeechAudioFormat**, int> get_AudioFormat;

            [NativeTypeName("HRESULT (ISpeechPhraseInfo **) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpeechRecoResultDispatch*, ISpeechPhraseInfo**, int> get_PhraseInfo;

            [NativeTypeName("HRESULT (long, long, long, ISpeechPhraseAlternates **) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpeechRecoResultDispatch*, int, int, int, ISpeechPhraseAlternates**, int> Alternates;

            [NativeTypeName("HRESULT (long, long, ISpeechMemoryStream **) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpeechRecoResultDispatch*, int, int, ISpeechMemoryStream**, int> Audio;

            [NativeTypeName("HRESULT (long, long, SpeechVoiceSpeakFlags, long *) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpeechRecoResultDispatch*, int, int, SpeechVoiceSpeakFlags, int*, int> SpeakAudio;

            [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpeechRecoResultDispatch*, VARIANT*, int> SaveToMemory;

            [NativeTypeName("HRESULT (SpeechDiscardType) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpeechRecoResultDispatch*, SpeechDiscardType, int> DiscardResultInfo;

            [NativeTypeName("HRESULT (SPXMLRESULTOPTIONS, BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpeechRecoResultDispatch*, SPXMLRESULTOPTIONS, ushort**, int> GetXMLResult;

            [NativeTypeName("HRESULT (long *, BSTR *, BSTR *, BSTR *, HRESULT *, VARIANT_BOOL *) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpeechRecoResultDispatch*, int*, ushort**, ushort**, ushort**, HRESULT*, short*, int> GetXMLErrorInfo;

            [NativeTypeName("HRESULT (BSTR, VARIANT_BOOL) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpeechRecoResultDispatch*, ushort*, short, int> SetTextFeedback;
        }
    }
}
