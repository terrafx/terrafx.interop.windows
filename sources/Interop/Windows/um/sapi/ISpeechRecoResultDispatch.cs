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
    public unsafe partial struct ISpeechRecoResultDispatch
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
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
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfoCount([NativeTypeName("UINT *")] uint* pctinfo)
        {
            return ((delegate* unmanaged<ISpeechRecoResultDispatch*, uint*, int>)(lpVtbl[3]))((ISpeechRecoResultDispatch*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfo([NativeTypeName("UINT")] uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<ISpeechRecoResultDispatch*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((ISpeechRecoResultDispatch*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, [NativeTypeName("UINT")] uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<ISpeechRecoResultDispatch*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((ISpeechRecoResultDispatch*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, [NativeTypeName("UINT *")] uint* puArgErr)
        {
            return ((delegate* unmanaged<ISpeechRecoResultDispatch*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((ISpeechRecoResultDispatch*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int get_RecoContext(ISpeechRecoContext** RecoContext)
        {
            return ((delegate* unmanaged<ISpeechRecoResultDispatch*, ISpeechRecoContext**, int>)(lpVtbl[7]))((ISpeechRecoResultDispatch*)Unsafe.AsPointer(ref this), RecoContext);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int get_Times(ISpeechRecoResultTimes** Times)
        {
            return ((delegate* unmanaged<ISpeechRecoResultDispatch*, ISpeechRecoResultTimes**, int>)(lpVtbl[8]))((ISpeechRecoResultDispatch*)Unsafe.AsPointer(ref this), Times);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("HRESULT")]
        public int putref_AudioFormat(ISpeechAudioFormat* Format)
        {
            return ((delegate* unmanaged<ISpeechRecoResultDispatch*, ISpeechAudioFormat*, int>)(lpVtbl[9]))((ISpeechRecoResultDispatch*)Unsafe.AsPointer(ref this), Format);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        [return: NativeTypeName("HRESULT")]
        public int get_AudioFormat(ISpeechAudioFormat** Format)
        {
            return ((delegate* unmanaged<ISpeechRecoResultDispatch*, ISpeechAudioFormat**, int>)(lpVtbl[10]))((ISpeechRecoResultDispatch*)Unsafe.AsPointer(ref this), Format);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        [return: NativeTypeName("HRESULT")]
        public int get_PhraseInfo(ISpeechPhraseInfo** PhraseInfo)
        {
            return ((delegate* unmanaged<ISpeechRecoResultDispatch*, ISpeechPhraseInfo**, int>)(lpVtbl[11]))((ISpeechRecoResultDispatch*)Unsafe.AsPointer(ref this), PhraseInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        [return: NativeTypeName("HRESULT")]
        public int Alternates([NativeTypeName("long")] int RequestCount, [NativeTypeName("long")] int StartElement, [NativeTypeName("long")] int Elements, ISpeechPhraseAlternates** Alternates)
        {
            return ((delegate* unmanaged<ISpeechRecoResultDispatch*, int, int, int, ISpeechPhraseAlternates**, int>)(lpVtbl[12]))((ISpeechRecoResultDispatch*)Unsafe.AsPointer(ref this), RequestCount, StartElement, Elements, Alternates);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        [return: NativeTypeName("HRESULT")]
        public int Audio([NativeTypeName("long")] int StartElement, [NativeTypeName("long")] int Elements, ISpeechMemoryStream** Stream)
        {
            return ((delegate* unmanaged<ISpeechRecoResultDispatch*, int, int, ISpeechMemoryStream**, int>)(lpVtbl[13]))((ISpeechRecoResultDispatch*)Unsafe.AsPointer(ref this), StartElement, Elements, Stream);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        [return: NativeTypeName("HRESULT")]
        public int SpeakAudio([NativeTypeName("long")] int StartElement, [NativeTypeName("long")] int Elements, SpeechVoiceSpeakFlags Flags, [NativeTypeName("long *")] int* StreamNumber)
        {
            return ((delegate* unmanaged<ISpeechRecoResultDispatch*, int, int, SpeechVoiceSpeakFlags, int*, int>)(lpVtbl[14]))((ISpeechRecoResultDispatch*)Unsafe.AsPointer(ref this), StartElement, Elements, Flags, StreamNumber);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        [return: NativeTypeName("HRESULT")]
        public int SaveToMemory(VARIANT* ResultBlock)
        {
            return ((delegate* unmanaged<ISpeechRecoResultDispatch*, VARIANT*, int>)(lpVtbl[15]))((ISpeechRecoResultDispatch*)Unsafe.AsPointer(ref this), ResultBlock);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        [return: NativeTypeName("HRESULT")]
        public int DiscardResultInfo(SpeechDiscardType ValueTypes)
        {
            return ((delegate* unmanaged<ISpeechRecoResultDispatch*, SpeechDiscardType, int>)(lpVtbl[16]))((ISpeechRecoResultDispatch*)Unsafe.AsPointer(ref this), ValueTypes);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        [return: NativeTypeName("HRESULT")]
        public int GetXMLResult(SPXMLRESULTOPTIONS Options, [NativeTypeName("BSTR *")] ushort** pResult)
        {
            return ((delegate* unmanaged<ISpeechRecoResultDispatch*, SPXMLRESULTOPTIONS, ushort**, int>)(lpVtbl[17]))((ISpeechRecoResultDispatch*)Unsafe.AsPointer(ref this), Options, pResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        [return: NativeTypeName("HRESULT")]
        public int GetXMLErrorInfo([NativeTypeName("long *")] int* LineNumber, [NativeTypeName("BSTR *")] ushort** ScriptLine, [NativeTypeName("BSTR *")] ushort** Source, [NativeTypeName("BSTR *")] ushort** Description, [NativeTypeName("HRESULT *")] int* ResultCode, [NativeTypeName("VARIANT_BOOL *")] short* IsError)
        {
            return ((delegate* unmanaged<ISpeechRecoResultDispatch*, int*, ushort**, ushort**, ushort**, int*, short*, int>)(lpVtbl[18]))((ISpeechRecoResultDispatch*)Unsafe.AsPointer(ref this), LineNumber, ScriptLine, Source, Description, ResultCode, IsError);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        [return: NativeTypeName("HRESULT")]
        public int SetTextFeedback([NativeTypeName("BSTR")] ushort* Feedback, [NativeTypeName("VARIANT_BOOL")] short WasSuccessful)
        {
            return ((delegate* unmanaged<ISpeechRecoResultDispatch*, ushort*, short, int>)(lpVtbl[19]))((ISpeechRecoResultDispatch*)Unsafe.AsPointer(ref this), Feedback, WasSuccessful);
        }
    }
}
