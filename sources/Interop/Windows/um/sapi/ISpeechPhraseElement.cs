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

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ISpeechPhraseElement*, Guid*, void**, int>)(lpVtbl[0]))((ISpeechPhraseElement*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ISpeechPhraseElement*, uint>)(lpVtbl[1]))((ISpeechPhraseElement*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ISpeechPhraseElement*, uint>)(lpVtbl[2]))((ISpeechPhraseElement*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfoCount([NativeTypeName("UINT *")] uint* pctinfo)
        {
            return ((delegate* unmanaged<ISpeechPhraseElement*, uint*, int>)(lpVtbl[3]))((ISpeechPhraseElement*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfo([NativeTypeName("UINT")] uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<ISpeechPhraseElement*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((ISpeechPhraseElement*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, [NativeTypeName("UINT")] uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<ISpeechPhraseElement*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((ISpeechPhraseElement*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, [NativeTypeName("UINT *")] uint* puArgErr)
        {
            return ((delegate* unmanaged<ISpeechPhraseElement*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((ISpeechPhraseElement*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_AudioTimeOffset([NativeTypeName("long *")] int* AudioTimeOffset)
        {
            return ((delegate* unmanaged<ISpeechPhraseElement*, int*, int>)(lpVtbl[7]))((ISpeechPhraseElement*)Unsafe.AsPointer(ref this), AudioTimeOffset);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_AudioSizeTime([NativeTypeName("long *")] int* AudioSizeTime)
        {
            return ((delegate* unmanaged<ISpeechPhraseElement*, int*, int>)(lpVtbl[8]))((ISpeechPhraseElement*)Unsafe.AsPointer(ref this), AudioSizeTime);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_AudioStreamOffset([NativeTypeName("long *")] int* AudioStreamOffset)
        {
            return ((delegate* unmanaged<ISpeechPhraseElement*, int*, int>)(lpVtbl[9]))((ISpeechPhraseElement*)Unsafe.AsPointer(ref this), AudioStreamOffset);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_AudioSizeBytes([NativeTypeName("long *")] int* AudioSizeBytes)
        {
            return ((delegate* unmanaged<ISpeechPhraseElement*, int*, int>)(lpVtbl[10]))((ISpeechPhraseElement*)Unsafe.AsPointer(ref this), AudioSizeBytes);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_RetainedStreamOffset([NativeTypeName("long *")] int* RetainedStreamOffset)
        {
            return ((delegate* unmanaged<ISpeechPhraseElement*, int*, int>)(lpVtbl[11]))((ISpeechPhraseElement*)Unsafe.AsPointer(ref this), RetainedStreamOffset);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_RetainedSizeBytes([NativeTypeName("long *")] int* RetainedSizeBytes)
        {
            return ((delegate* unmanaged<ISpeechPhraseElement*, int*, int>)(lpVtbl[12]))((ISpeechPhraseElement*)Unsafe.AsPointer(ref this), RetainedSizeBytes);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_DisplayText([NativeTypeName("BSTR *")] ushort** DisplayText)
        {
            return ((delegate* unmanaged<ISpeechPhraseElement*, ushort**, int>)(lpVtbl[13]))((ISpeechPhraseElement*)Unsafe.AsPointer(ref this), DisplayText);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_LexicalForm([NativeTypeName("BSTR *")] ushort** LexicalForm)
        {
            return ((delegate* unmanaged<ISpeechPhraseElement*, ushort**, int>)(lpVtbl[14]))((ISpeechPhraseElement*)Unsafe.AsPointer(ref this), LexicalForm);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Pronunciation(VARIANT* Pronunciation)
        {
            return ((delegate* unmanaged<ISpeechPhraseElement*, VARIANT*, int>)(lpVtbl[15]))((ISpeechPhraseElement*)Unsafe.AsPointer(ref this), Pronunciation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_DisplayAttributes(SpeechDisplayAttributes* DisplayAttributes)
        {
            return ((delegate* unmanaged<ISpeechPhraseElement*, SpeechDisplayAttributes*, int>)(lpVtbl[16]))((ISpeechPhraseElement*)Unsafe.AsPointer(ref this), DisplayAttributes);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_RequiredConfidence(SpeechEngineConfidence* RequiredConfidence)
        {
            return ((delegate* unmanaged<ISpeechPhraseElement*, SpeechEngineConfidence*, int>)(lpVtbl[17]))((ISpeechPhraseElement*)Unsafe.AsPointer(ref this), RequiredConfidence);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_ActualConfidence(SpeechEngineConfidence* ActualConfidence)
        {
            return ((delegate* unmanaged<ISpeechPhraseElement*, SpeechEngineConfidence*, int>)(lpVtbl[18]))((ISpeechPhraseElement*)Unsafe.AsPointer(ref this), ActualConfidence);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_EngineConfidence(float* EngineConfidence)
        {
            return ((delegate* unmanaged<ISpeechPhraseElement*, float*, int>)(lpVtbl[19]))((ISpeechPhraseElement*)Unsafe.AsPointer(ref this), EngineConfidence);
        }
    }
}
