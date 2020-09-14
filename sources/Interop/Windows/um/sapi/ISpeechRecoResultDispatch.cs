// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("6D60EB64-ACED-40A6-BBF3-4E557F71DEE2")]
    [NativeTypeName("struct ISpeechRecoResultDispatch : IDispatch")]
    public unsafe partial struct ISpeechRecoResultDispatch
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<ISpeechRecoResultDispatch*, Guid*, void**, int>)(lpVtbl[0]))((ISpeechRecoResultDispatch*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ISpeechRecoResultDispatch*, uint>)(lpVtbl[1]))((ISpeechRecoResultDispatch*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ISpeechRecoResultDispatch*, uint>)(lpVtbl[2]))((ISpeechRecoResultDispatch*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfoCount([NativeTypeName("UINT *")] uint* pctinfo)
        {
            return ((delegate* unmanaged<ISpeechRecoResultDispatch*, uint*, int>)(lpVtbl[3]))((ISpeechRecoResultDispatch*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfo([NativeTypeName("UINT")] uint iTInfo, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("ITypeInfo **")] ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<ISpeechRecoResultDispatch*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((ISpeechRecoResultDispatch*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, [NativeTypeName("UINT")] uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<ISpeechRecoResultDispatch*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((ISpeechRecoResultDispatch*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, [NativeTypeName("DISPPARAMS *")] DISPPARAMS* pDispParams, [NativeTypeName("VARIANT *")] VARIANT* pVarResult, [NativeTypeName("EXCEPINFO *")] EXCEPINFO* pExcepInfo, [NativeTypeName("UINT *")] uint* puArgErr)
        {
            return ((delegate* unmanaged<ISpeechRecoResultDispatch*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((ISpeechRecoResultDispatch*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_RecoContext([NativeTypeName("ISpeechRecoContext **")] ISpeechRecoContext** RecoContext)
        {
            return ((delegate* unmanaged<ISpeechRecoResultDispatch*, ISpeechRecoContext**, int>)(lpVtbl[7]))((ISpeechRecoResultDispatch*)Unsafe.AsPointer(ref this), RecoContext);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Times([NativeTypeName("ISpeechRecoResultTimes **")] ISpeechRecoResultTimes** Times)
        {
            return ((delegate* unmanaged<ISpeechRecoResultDispatch*, ISpeechRecoResultTimes**, int>)(lpVtbl[8]))((ISpeechRecoResultDispatch*)Unsafe.AsPointer(ref this), Times);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int putref_AudioFormat([NativeTypeName("ISpeechAudioFormat *")] ISpeechAudioFormat* Format)
        {
            return ((delegate* unmanaged<ISpeechRecoResultDispatch*, ISpeechAudioFormat*, int>)(lpVtbl[9]))((ISpeechRecoResultDispatch*)Unsafe.AsPointer(ref this), Format);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_AudioFormat([NativeTypeName("ISpeechAudioFormat **")] ISpeechAudioFormat** Format)
        {
            return ((delegate* unmanaged<ISpeechRecoResultDispatch*, ISpeechAudioFormat**, int>)(lpVtbl[10]))((ISpeechRecoResultDispatch*)Unsafe.AsPointer(ref this), Format);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_PhraseInfo([NativeTypeName("ISpeechPhraseInfo **")] ISpeechPhraseInfo** PhraseInfo)
        {
            return ((delegate* unmanaged<ISpeechRecoResultDispatch*, ISpeechPhraseInfo**, int>)(lpVtbl[11]))((ISpeechRecoResultDispatch*)Unsafe.AsPointer(ref this), PhraseInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Alternates([NativeTypeName("long")] int RequestCount, [NativeTypeName("long")] int StartElement, [NativeTypeName("long")] int Elements, [NativeTypeName("ISpeechPhraseAlternates **")] ISpeechPhraseAlternates** Alternates)
        {
            return ((delegate* unmanaged<ISpeechRecoResultDispatch*, int, int, int, ISpeechPhraseAlternates**, int>)(lpVtbl[12]))((ISpeechRecoResultDispatch*)Unsafe.AsPointer(ref this), RequestCount, StartElement, Elements, Alternates);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Audio([NativeTypeName("long")] int StartElement, [NativeTypeName("long")] int Elements, [NativeTypeName("ISpeechMemoryStream **")] ISpeechMemoryStream** Stream)
        {
            return ((delegate* unmanaged<ISpeechRecoResultDispatch*, int, int, ISpeechMemoryStream**, int>)(lpVtbl[13]))((ISpeechRecoResultDispatch*)Unsafe.AsPointer(ref this), StartElement, Elements, Stream);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SpeakAudio([NativeTypeName("long")] int StartElement, [NativeTypeName("long")] int Elements, SpeechVoiceSpeakFlags Flags, [NativeTypeName("long *")] int* StreamNumber)
        {
            return ((delegate* unmanaged<ISpeechRecoResultDispatch*, int, int, SpeechVoiceSpeakFlags, int*, int>)(lpVtbl[14]))((ISpeechRecoResultDispatch*)Unsafe.AsPointer(ref this), StartElement, Elements, Flags, StreamNumber);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SaveToMemory([NativeTypeName("VARIANT *")] VARIANT* ResultBlock)
        {
            return ((delegate* unmanaged<ISpeechRecoResultDispatch*, VARIANT*, int>)(lpVtbl[15]))((ISpeechRecoResultDispatch*)Unsafe.AsPointer(ref this), ResultBlock);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int DiscardResultInfo(SpeechDiscardType ValueTypes)
        {
            return ((delegate* unmanaged<ISpeechRecoResultDispatch*, SpeechDiscardType, int>)(lpVtbl[16]))((ISpeechRecoResultDispatch*)Unsafe.AsPointer(ref this), ValueTypes);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetXMLResult(SPXMLRESULTOPTIONS Options, [NativeTypeName("BSTR *")] ushort** pResult)
        {
            return ((delegate* unmanaged<ISpeechRecoResultDispatch*, SPXMLRESULTOPTIONS, ushort**, int>)(lpVtbl[17]))((ISpeechRecoResultDispatch*)Unsafe.AsPointer(ref this), Options, pResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetXMLErrorInfo([NativeTypeName("long *")] int* LineNumber, [NativeTypeName("BSTR *")] ushort** ScriptLine, [NativeTypeName("BSTR *")] ushort** Source, [NativeTypeName("BSTR *")] ushort** Description, [NativeTypeName("HRESULT *")] int* ResultCode, [NativeTypeName("VARIANT_BOOL *")] short* IsError)
        {
            return ((delegate* unmanaged<ISpeechRecoResultDispatch*, int*, ushort**, ushort**, ushort**, int*, short*, int>)(lpVtbl[18]))((ISpeechRecoResultDispatch*)Unsafe.AsPointer(ref this), LineNumber, ScriptLine, Source, Description, ResultCode, IsError);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetTextFeedback([NativeTypeName("BSTR")] ushort* Feedback, [NativeTypeName("VARIANT_BOOL")] short WasSuccessful)
        {
            return ((delegate* unmanaged<ISpeechRecoResultDispatch*, ushort*, short, int>)(lpVtbl[19]))((ISpeechRecoResultDispatch*)Unsafe.AsPointer(ref this), Feedback, WasSuccessful);
        }
    }
}
