// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("2890A410-53A7-4FB5-94EC-06D4998E3D02")]
    public unsafe partial struct ISpeechPhraseReplacement
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<ISpeechPhraseReplacement*, Guid*, void**, int>)(lpVtbl[0]))((ISpeechPhraseReplacement*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<ISpeechPhraseReplacement*, uint>)(lpVtbl[1]))((ISpeechPhraseReplacement*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<ISpeechPhraseReplacement*, uint>)(lpVtbl[2]))((ISpeechPhraseReplacement*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfoCount([NativeTypeName("UINT *")] uint* pctinfo)
        {
            return ((delegate* stdcall<ISpeechPhraseReplacement*, uint*, int>)(lpVtbl[3]))((ISpeechPhraseReplacement*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfo([NativeTypeName("UINT")] uint iTInfo, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("ITypeInfo **")] ITypeInfo** ppTInfo)
        {
            return ((delegate* stdcall<ISpeechPhraseReplacement*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((ISpeechPhraseReplacement*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, [NativeTypeName("UINT")] uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* stdcall<ISpeechPhraseReplacement*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((ISpeechPhraseReplacement*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [return: NativeTypeName("HRESULT")]
        public int Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, [NativeTypeName("DISPPARAMS *")] DISPPARAMS* pDispParams, [NativeTypeName("VARIANT *")] VARIANT* pVarResult, [NativeTypeName("EXCEPINFO *")] EXCEPINFO* pExcepInfo, [NativeTypeName("UINT *")] uint* puArgErr)
        {
            return ((delegate* stdcall<ISpeechPhraseReplacement*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((ISpeechPhraseReplacement*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_DisplayAttributes([NativeTypeName("SpeechDisplayAttributes *")] SpeechDisplayAttributes* DisplayAttributes)
        {
            return ((delegate* stdcall<ISpeechPhraseReplacement*, SpeechDisplayAttributes*, int>)(lpVtbl[7]))((ISpeechPhraseReplacement*)Unsafe.AsPointer(ref this), DisplayAttributes);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_Text([NativeTypeName("BSTR *")] ushort** Text)
        {
            return ((delegate* stdcall<ISpeechPhraseReplacement*, ushort**, int>)(lpVtbl[8]))((ISpeechPhraseReplacement*)Unsafe.AsPointer(ref this), Text);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_FirstElement([NativeTypeName("long *")] int* FirstElement)
        {
            return ((delegate* stdcall<ISpeechPhraseReplacement*, int*, int>)(lpVtbl[9]))((ISpeechPhraseReplacement*)Unsafe.AsPointer(ref this), FirstElement);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_NumberOfElements([NativeTypeName("long *")] int* NumberOfElements)
        {
            return ((delegate* stdcall<ISpeechPhraseReplacement*, int*, int>)(lpVtbl[10]))((ISpeechPhraseReplacement*)Unsafe.AsPointer(ref this), NumberOfElements);
        }
    }
}
