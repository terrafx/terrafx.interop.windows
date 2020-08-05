// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("E6176F96-E373-4801-B223-3B62C068C0B4")]
    [NativeTypeName("struct ISpeechPhraseElement : IDispatch")]
    public unsafe partial struct ISpeechPhraseElement
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<ISpeechPhraseElement*, Guid*, void**, int>)(lpVtbl[0]))((ISpeechPhraseElement*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<ISpeechPhraseElement*, uint>)(lpVtbl[1]))((ISpeechPhraseElement*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<ISpeechPhraseElement*, uint>)(lpVtbl[2]))((ISpeechPhraseElement*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfoCount([NativeTypeName("UINT *")] uint* pctinfo)
        {
            return ((delegate* stdcall<ISpeechPhraseElement*, uint*, int>)(lpVtbl[3]))((ISpeechPhraseElement*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfo([NativeTypeName("UINT")] uint iTInfo, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("ITypeInfo **")] ITypeInfo** ppTInfo)
        {
            return ((delegate* stdcall<ISpeechPhraseElement*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((ISpeechPhraseElement*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, [NativeTypeName("UINT")] uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* stdcall<ISpeechPhraseElement*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((ISpeechPhraseElement*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [return: NativeTypeName("HRESULT")]
        public int Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, [NativeTypeName("DISPPARAMS *")] DISPPARAMS* pDispParams, [NativeTypeName("VARIANT *")] VARIANT* pVarResult, [NativeTypeName("EXCEPINFO *")] EXCEPINFO* pExcepInfo, [NativeTypeName("UINT *")] uint* puArgErr)
        {
            return ((delegate* stdcall<ISpeechPhraseElement*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((ISpeechPhraseElement*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_AudioTimeOffset([NativeTypeName("long *")] int* AudioTimeOffset)
        {
            return ((delegate* stdcall<ISpeechPhraseElement*, int*, int>)(lpVtbl[7]))((ISpeechPhraseElement*)Unsafe.AsPointer(ref this), AudioTimeOffset);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_AudioSizeTime([NativeTypeName("long *")] int* AudioSizeTime)
        {
            return ((delegate* stdcall<ISpeechPhraseElement*, int*, int>)(lpVtbl[8]))((ISpeechPhraseElement*)Unsafe.AsPointer(ref this), AudioSizeTime);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_AudioStreamOffset([NativeTypeName("long *")] int* AudioStreamOffset)
        {
            return ((delegate* stdcall<ISpeechPhraseElement*, int*, int>)(lpVtbl[9]))((ISpeechPhraseElement*)Unsafe.AsPointer(ref this), AudioStreamOffset);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_AudioSizeBytes([NativeTypeName("long *")] int* AudioSizeBytes)
        {
            return ((delegate* stdcall<ISpeechPhraseElement*, int*, int>)(lpVtbl[10]))((ISpeechPhraseElement*)Unsafe.AsPointer(ref this), AudioSizeBytes);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_RetainedStreamOffset([NativeTypeName("long *")] int* RetainedStreamOffset)
        {
            return ((delegate* stdcall<ISpeechPhraseElement*, int*, int>)(lpVtbl[11]))((ISpeechPhraseElement*)Unsafe.AsPointer(ref this), RetainedStreamOffset);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_RetainedSizeBytes([NativeTypeName("long *")] int* RetainedSizeBytes)
        {
            return ((delegate* stdcall<ISpeechPhraseElement*, int*, int>)(lpVtbl[12]))((ISpeechPhraseElement*)Unsafe.AsPointer(ref this), RetainedSizeBytes);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_DisplayText([NativeTypeName("BSTR *")] ushort** DisplayText)
        {
            return ((delegate* stdcall<ISpeechPhraseElement*, ushort**, int>)(lpVtbl[13]))((ISpeechPhraseElement*)Unsafe.AsPointer(ref this), DisplayText);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_LexicalForm([NativeTypeName("BSTR *")] ushort** LexicalForm)
        {
            return ((delegate* stdcall<ISpeechPhraseElement*, ushort**, int>)(lpVtbl[14]))((ISpeechPhraseElement*)Unsafe.AsPointer(ref this), LexicalForm);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_Pronunciation([NativeTypeName("VARIANT *")] VARIANT* Pronunciation)
        {
            return ((delegate* stdcall<ISpeechPhraseElement*, VARIANT*, int>)(lpVtbl[15]))((ISpeechPhraseElement*)Unsafe.AsPointer(ref this), Pronunciation);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_DisplayAttributes([NativeTypeName("SpeechDisplayAttributes *")] SpeechDisplayAttributes* DisplayAttributes)
        {
            return ((delegate* stdcall<ISpeechPhraseElement*, SpeechDisplayAttributes*, int>)(lpVtbl[16]))((ISpeechPhraseElement*)Unsafe.AsPointer(ref this), DisplayAttributes);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_RequiredConfidence([NativeTypeName("SpeechEngineConfidence *")] SpeechEngineConfidence* RequiredConfidence)
        {
            return ((delegate* stdcall<ISpeechPhraseElement*, SpeechEngineConfidence*, int>)(lpVtbl[17]))((ISpeechPhraseElement*)Unsafe.AsPointer(ref this), RequiredConfidence);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_ActualConfidence([NativeTypeName("SpeechEngineConfidence *")] SpeechEngineConfidence* ActualConfidence)
        {
            return ((delegate* stdcall<ISpeechPhraseElement*, SpeechEngineConfidence*, int>)(lpVtbl[18]))((ISpeechPhraseElement*)Unsafe.AsPointer(ref this), ActualConfidence);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_EngineConfidence([NativeTypeName("float *")] float* EngineConfidence)
        {
            return ((delegate* stdcall<ISpeechPhraseElement*, float*, int>)(lpVtbl[19]))((ISpeechPhraseElement*)Unsafe.AsPointer(ref this), EngineConfidence);
        }
    }
}
