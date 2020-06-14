// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("ED2879CF-CED9-4EE6-A534-DE0191D5468D")]
    public unsafe partial struct ISpeechRecoResult
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<ISpeechRecoResult*, Guid*, void**, int>)(lpVtbl[0]))((ISpeechRecoResult*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<ISpeechRecoResult*, uint>)(lpVtbl[1]))((ISpeechRecoResult*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<ISpeechRecoResult*, uint>)(lpVtbl[2]))((ISpeechRecoResult*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfoCount([NativeTypeName("UINT *")] uint* pctinfo)
        {
            return ((delegate* stdcall<ISpeechRecoResult*, uint*, int>)(lpVtbl[3]))((ISpeechRecoResult*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfo([NativeTypeName("UINT")] uint iTInfo, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("ITypeInfo **")] ITypeInfo** ppTInfo)
        {
            return ((delegate* stdcall<ISpeechRecoResult*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((ISpeechRecoResult*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, [NativeTypeName("UINT")] uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* stdcall<ISpeechRecoResult*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((ISpeechRecoResult*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [return: NativeTypeName("HRESULT")]
        public int Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, [NativeTypeName("DISPPARAMS *")] DISPPARAMS* pDispParams, [NativeTypeName("VARIANT *")] VARIANT* pVarResult, [NativeTypeName("EXCEPINFO *")] EXCEPINFO* pExcepInfo, [NativeTypeName("UINT *")] uint* puArgErr)
        {
            return ((delegate* stdcall<ISpeechRecoResult*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((ISpeechRecoResult*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_RecoContext([NativeTypeName("ISpeechRecoContext **")] ISpeechRecoContext** RecoContext)
        {
            return ((delegate* stdcall<ISpeechRecoResult*, ISpeechRecoContext**, int>)(lpVtbl[7]))((ISpeechRecoResult*)Unsafe.AsPointer(ref this), RecoContext);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_Times([NativeTypeName("ISpeechRecoResultTimes **")] ISpeechRecoResultTimes** Times)
        {
            return ((delegate* stdcall<ISpeechRecoResult*, ISpeechRecoResultTimes**, int>)(lpVtbl[8]))((ISpeechRecoResult*)Unsafe.AsPointer(ref this), Times);
        }

        [return: NativeTypeName("HRESULT")]
        public int putref_AudioFormat([NativeTypeName("ISpeechAudioFormat *")] ISpeechAudioFormat* Format)
        {
            return ((delegate* stdcall<ISpeechRecoResult*, ISpeechAudioFormat*, int>)(lpVtbl[9]))((ISpeechRecoResult*)Unsafe.AsPointer(ref this), Format);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_AudioFormat([NativeTypeName("ISpeechAudioFormat **")] ISpeechAudioFormat** Format)
        {
            return ((delegate* stdcall<ISpeechRecoResult*, ISpeechAudioFormat**, int>)(lpVtbl[10]))((ISpeechRecoResult*)Unsafe.AsPointer(ref this), Format);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_PhraseInfo([NativeTypeName("ISpeechPhraseInfo **")] ISpeechPhraseInfo** PhraseInfo)
        {
            return ((delegate* stdcall<ISpeechRecoResult*, ISpeechPhraseInfo**, int>)(lpVtbl[11]))((ISpeechRecoResult*)Unsafe.AsPointer(ref this), PhraseInfo);
        }

        [return: NativeTypeName("HRESULT")]
        public int Alternates([NativeTypeName("long")] int RequestCount, [NativeTypeName("long")] int StartElement, [NativeTypeName("long")] int Elements, [NativeTypeName("ISpeechPhraseAlternates **")] ISpeechPhraseAlternates** Alternates)
        {
            return ((delegate* stdcall<ISpeechRecoResult*, int, int, int, ISpeechPhraseAlternates**, int>)(lpVtbl[12]))((ISpeechRecoResult*)Unsafe.AsPointer(ref this), RequestCount, StartElement, Elements, Alternates);
        }

        [return: NativeTypeName("HRESULT")]
        public int Audio([NativeTypeName("long")] int StartElement, [NativeTypeName("long")] int Elements, [NativeTypeName("ISpeechMemoryStream **")] ISpeechMemoryStream** Stream)
        {
            return ((delegate* stdcall<ISpeechRecoResult*, int, int, ISpeechMemoryStream**, int>)(lpVtbl[13]))((ISpeechRecoResult*)Unsafe.AsPointer(ref this), StartElement, Elements, Stream);
        }

        [return: NativeTypeName("HRESULT")]
        public int SpeakAudio([NativeTypeName("long")] int StartElement, [NativeTypeName("long")] int Elements, SpeechVoiceSpeakFlags Flags, [NativeTypeName("long *")] int* StreamNumber)
        {
            return ((delegate* stdcall<ISpeechRecoResult*, int, int, SpeechVoiceSpeakFlags, int*, int>)(lpVtbl[14]))((ISpeechRecoResult*)Unsafe.AsPointer(ref this), StartElement, Elements, Flags, StreamNumber);
        }

        [return: NativeTypeName("HRESULT")]
        public int SaveToMemory([NativeTypeName("VARIANT *")] VARIANT* ResultBlock)
        {
            return ((delegate* stdcall<ISpeechRecoResult*, VARIANT*, int>)(lpVtbl[15]))((ISpeechRecoResult*)Unsafe.AsPointer(ref this), ResultBlock);
        }

        [return: NativeTypeName("HRESULT")]
        public int DiscardResultInfo(SpeechDiscardType ValueTypes)
        {
            return ((delegate* stdcall<ISpeechRecoResult*, SpeechDiscardType, int>)(lpVtbl[16]))((ISpeechRecoResult*)Unsafe.AsPointer(ref this), ValueTypes);
        }
    }
}
