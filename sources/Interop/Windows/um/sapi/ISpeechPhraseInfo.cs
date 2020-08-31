// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("961559CF-4E67-4662-8BF0-D93F1FCD61B3")]
    [NativeTypeName("struct ISpeechPhraseInfo : IDispatch")]
    public unsafe partial struct ISpeechPhraseInfo
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<ISpeechPhraseInfo*, Guid*, void**, int>)(lpVtbl[0]))((ISpeechPhraseInfo*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<ISpeechPhraseInfo*, uint>)(lpVtbl[1]))((ISpeechPhraseInfo*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<ISpeechPhraseInfo*, uint>)(lpVtbl[2]))((ISpeechPhraseInfo*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfoCount([NativeTypeName("UINT *")] uint* pctinfo)
        {
            return ((delegate* stdcall<ISpeechPhraseInfo*, uint*, int>)(lpVtbl[3]))((ISpeechPhraseInfo*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfo([NativeTypeName("UINT")] uint iTInfo, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("ITypeInfo **")] ITypeInfo** ppTInfo)
        {
            return ((delegate* stdcall<ISpeechPhraseInfo*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((ISpeechPhraseInfo*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, [NativeTypeName("UINT")] uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* stdcall<ISpeechPhraseInfo*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((ISpeechPhraseInfo*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, [NativeTypeName("DISPPARAMS *")] DISPPARAMS* pDispParams, [NativeTypeName("VARIANT *")] VARIANT* pVarResult, [NativeTypeName("EXCEPINFO *")] EXCEPINFO* pExcepInfo, [NativeTypeName("UINT *")] uint* puArgErr)
        {
            return ((delegate* stdcall<ISpeechPhraseInfo*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((ISpeechPhraseInfo*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_LanguageId([NativeTypeName("long *")] int* LanguageId)
        {
            return ((delegate* stdcall<ISpeechPhraseInfo*, int*, int>)(lpVtbl[7]))((ISpeechPhraseInfo*)Unsafe.AsPointer(ref this), LanguageId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_GrammarId([NativeTypeName("VARIANT *")] VARIANT* GrammarId)
        {
            return ((delegate* stdcall<ISpeechPhraseInfo*, VARIANT*, int>)(lpVtbl[8]))((ISpeechPhraseInfo*)Unsafe.AsPointer(ref this), GrammarId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_StartTime([NativeTypeName("VARIANT *")] VARIANT* StartTime)
        {
            return ((delegate* stdcall<ISpeechPhraseInfo*, VARIANT*, int>)(lpVtbl[9]))((ISpeechPhraseInfo*)Unsafe.AsPointer(ref this), StartTime);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_AudioStreamPosition([NativeTypeName("VARIANT *")] VARIANT* AudioStreamPosition)
        {
            return ((delegate* stdcall<ISpeechPhraseInfo*, VARIANT*, int>)(lpVtbl[10]))((ISpeechPhraseInfo*)Unsafe.AsPointer(ref this), AudioStreamPosition);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_AudioSizeBytes([NativeTypeName("long *")] int* pAudioSizeBytes)
        {
            return ((delegate* stdcall<ISpeechPhraseInfo*, int*, int>)(lpVtbl[11]))((ISpeechPhraseInfo*)Unsafe.AsPointer(ref this), pAudioSizeBytes);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_RetainedSizeBytes([NativeTypeName("long *")] int* RetainedSizeBytes)
        {
            return ((delegate* stdcall<ISpeechPhraseInfo*, int*, int>)(lpVtbl[12]))((ISpeechPhraseInfo*)Unsafe.AsPointer(ref this), RetainedSizeBytes);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_AudioSizeTime([NativeTypeName("long *")] int* AudioSizeTime)
        {
            return ((delegate* stdcall<ISpeechPhraseInfo*, int*, int>)(lpVtbl[13]))((ISpeechPhraseInfo*)Unsafe.AsPointer(ref this), AudioSizeTime);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Rule([NativeTypeName("ISpeechPhraseRule **")] ISpeechPhraseRule** Rule)
        {
            return ((delegate* stdcall<ISpeechPhraseInfo*, ISpeechPhraseRule**, int>)(lpVtbl[14]))((ISpeechPhraseInfo*)Unsafe.AsPointer(ref this), Rule);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Properties([NativeTypeName("ISpeechPhraseProperties **")] ISpeechPhraseProperties** Properties)
        {
            return ((delegate* stdcall<ISpeechPhraseInfo*, ISpeechPhraseProperties**, int>)(lpVtbl[15]))((ISpeechPhraseInfo*)Unsafe.AsPointer(ref this), Properties);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Elements([NativeTypeName("ISpeechPhraseElements **")] ISpeechPhraseElements** Elements)
        {
            return ((delegate* stdcall<ISpeechPhraseInfo*, ISpeechPhraseElements**, int>)(lpVtbl[16]))((ISpeechPhraseInfo*)Unsafe.AsPointer(ref this), Elements);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Replacements([NativeTypeName("ISpeechPhraseReplacements **")] ISpeechPhraseReplacements** Replacements)
        {
            return ((delegate* stdcall<ISpeechPhraseInfo*, ISpeechPhraseReplacements**, int>)(lpVtbl[17]))((ISpeechPhraseInfo*)Unsafe.AsPointer(ref this), Replacements);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_EngineId([NativeTypeName("BSTR *")] ushort** EngineIdGuid)
        {
            return ((delegate* stdcall<ISpeechPhraseInfo*, ushort**, int>)(lpVtbl[18]))((ISpeechPhraseInfo*)Unsafe.AsPointer(ref this), EngineIdGuid);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_EnginePrivateData([NativeTypeName("VARIANT *")] VARIANT* PrivateData)
        {
            return ((delegate* stdcall<ISpeechPhraseInfo*, VARIANT*, int>)(lpVtbl[19]))((ISpeechPhraseInfo*)Unsafe.AsPointer(ref this), PrivateData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SaveToMemory([NativeTypeName("VARIANT *")] VARIANT* PhraseBlock)
        {
            return ((delegate* stdcall<ISpeechPhraseInfo*, VARIANT*, int>)(lpVtbl[20]))((ISpeechPhraseInfo*)Unsafe.AsPointer(ref this), PhraseBlock);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetText([NativeTypeName("long")] int StartElement, [NativeTypeName("long")] int Elements, [NativeTypeName("VARIANT_BOOL")] short UseReplacements, [NativeTypeName("BSTR *")] ushort** Text)
        {
            return ((delegate* stdcall<ISpeechPhraseInfo*, int, int, short, ushort**, int>)(lpVtbl[21]))((ISpeechPhraseInfo*)Unsafe.AsPointer(ref this), StartElement, Elements, UseReplacements, Text);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetDisplayAttributes([NativeTypeName("long")] int StartElement, [NativeTypeName("long")] int Elements, [NativeTypeName("VARIANT_BOOL")] short UseReplacements, [NativeTypeName("SpeechDisplayAttributes *")] SpeechDisplayAttributes* DisplayAttributes)
        {
            return ((delegate* stdcall<ISpeechPhraseInfo*, int, int, short, SpeechDisplayAttributes*, int>)(lpVtbl[22]))((ISpeechPhraseInfo*)Unsafe.AsPointer(ref this), StartElement, Elements, UseReplacements, DisplayAttributes);
        }
    }
}
