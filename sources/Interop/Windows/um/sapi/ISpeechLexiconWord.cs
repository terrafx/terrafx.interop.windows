// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("4E5B933C-C9BE-48ED-8842-1EE51BB1D4FF")]
    [NativeTypeName("struct ISpeechLexiconWord : IDispatch")]
    public unsafe partial struct ISpeechLexiconWord
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<ISpeechLexiconWord*, Guid*, void**, int>)(lpVtbl[0]))((ISpeechLexiconWord*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<ISpeechLexiconWord*, uint>)(lpVtbl[1]))((ISpeechLexiconWord*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<ISpeechLexiconWord*, uint>)(lpVtbl[2]))((ISpeechLexiconWord*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfoCount([NativeTypeName("UINT *")] uint* pctinfo)
        {
            return ((delegate* stdcall<ISpeechLexiconWord*, uint*, int>)(lpVtbl[3]))((ISpeechLexiconWord*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfo([NativeTypeName("UINT")] uint iTInfo, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("ITypeInfo **")] ITypeInfo** ppTInfo)
        {
            return ((delegate* stdcall<ISpeechLexiconWord*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((ISpeechLexiconWord*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, [NativeTypeName("UINT")] uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* stdcall<ISpeechLexiconWord*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((ISpeechLexiconWord*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, [NativeTypeName("DISPPARAMS *")] DISPPARAMS* pDispParams, [NativeTypeName("VARIANT *")] VARIANT* pVarResult, [NativeTypeName("EXCEPINFO *")] EXCEPINFO* pExcepInfo, [NativeTypeName("UINT *")] uint* puArgErr)
        {
            return ((delegate* stdcall<ISpeechLexiconWord*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((ISpeechLexiconWord*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_LangId([NativeTypeName("SpeechLanguageId *")] int* LangId)
        {
            return ((delegate* stdcall<ISpeechLexiconWord*, int*, int>)(lpVtbl[7]))((ISpeechLexiconWord*)Unsafe.AsPointer(ref this), LangId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Type([NativeTypeName("SpeechWordType *")] SpeechWordType* WordType)
        {
            return ((delegate* stdcall<ISpeechLexiconWord*, SpeechWordType*, int>)(lpVtbl[8]))((ISpeechLexiconWord*)Unsafe.AsPointer(ref this), WordType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Word([NativeTypeName("BSTR *")] ushort** Word)
        {
            return ((delegate* stdcall<ISpeechLexiconWord*, ushort**, int>)(lpVtbl[9]))((ISpeechLexiconWord*)Unsafe.AsPointer(ref this), Word);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Pronunciations([NativeTypeName("ISpeechLexiconPronunciations **")] ISpeechLexiconPronunciations** Pronunciations)
        {
            return ((delegate* stdcall<ISpeechLexiconWord*, ISpeechLexiconPronunciations**, int>)(lpVtbl[10]))((ISpeechLexiconWord*)Unsafe.AsPointer(ref this), Pronunciations);
        }
    }
}
