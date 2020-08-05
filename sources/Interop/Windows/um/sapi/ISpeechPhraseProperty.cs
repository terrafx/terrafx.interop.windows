// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("CE563D48-961E-4732-A2E1-378A42B430BE")]
    [NativeTypeName("struct ISpeechPhraseProperty : IDispatch")]
    public unsafe partial struct ISpeechPhraseProperty
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<ISpeechPhraseProperty*, Guid*, void**, int>)(lpVtbl[0]))((ISpeechPhraseProperty*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<ISpeechPhraseProperty*, uint>)(lpVtbl[1]))((ISpeechPhraseProperty*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<ISpeechPhraseProperty*, uint>)(lpVtbl[2]))((ISpeechPhraseProperty*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfoCount([NativeTypeName("UINT *")] uint* pctinfo)
        {
            return ((delegate* stdcall<ISpeechPhraseProperty*, uint*, int>)(lpVtbl[3]))((ISpeechPhraseProperty*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfo([NativeTypeName("UINT")] uint iTInfo, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("ITypeInfo **")] ITypeInfo** ppTInfo)
        {
            return ((delegate* stdcall<ISpeechPhraseProperty*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((ISpeechPhraseProperty*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, [NativeTypeName("UINT")] uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* stdcall<ISpeechPhraseProperty*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((ISpeechPhraseProperty*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [return: NativeTypeName("HRESULT")]
        public int Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, [NativeTypeName("DISPPARAMS *")] DISPPARAMS* pDispParams, [NativeTypeName("VARIANT *")] VARIANT* pVarResult, [NativeTypeName("EXCEPINFO *")] EXCEPINFO* pExcepInfo, [NativeTypeName("UINT *")] uint* puArgErr)
        {
            return ((delegate* stdcall<ISpeechPhraseProperty*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((ISpeechPhraseProperty*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_Name([NativeTypeName("BSTR *")] ushort** Name)
        {
            return ((delegate* stdcall<ISpeechPhraseProperty*, ushort**, int>)(lpVtbl[7]))((ISpeechPhraseProperty*)Unsafe.AsPointer(ref this), Name);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_Id([NativeTypeName("long *")] int* Id)
        {
            return ((delegate* stdcall<ISpeechPhraseProperty*, int*, int>)(lpVtbl[8]))((ISpeechPhraseProperty*)Unsafe.AsPointer(ref this), Id);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_Value([NativeTypeName("VARIANT *")] VARIANT* Value)
        {
            return ((delegate* stdcall<ISpeechPhraseProperty*, VARIANT*, int>)(lpVtbl[9]))((ISpeechPhraseProperty*)Unsafe.AsPointer(ref this), Value);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_FirstElement([NativeTypeName("long *")] int* FirstElement)
        {
            return ((delegate* stdcall<ISpeechPhraseProperty*, int*, int>)(lpVtbl[10]))((ISpeechPhraseProperty*)Unsafe.AsPointer(ref this), FirstElement);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_NumberOfElements([NativeTypeName("long *")] int* NumberOfElements)
        {
            return ((delegate* stdcall<ISpeechPhraseProperty*, int*, int>)(lpVtbl[11]))((ISpeechPhraseProperty*)Unsafe.AsPointer(ref this), NumberOfElements);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_EngineConfidence([NativeTypeName("float *")] float* Confidence)
        {
            return ((delegate* stdcall<ISpeechPhraseProperty*, float*, int>)(lpVtbl[12]))((ISpeechPhraseProperty*)Unsafe.AsPointer(ref this), Confidence);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_Confidence([NativeTypeName("SpeechEngineConfidence *")] SpeechEngineConfidence* Confidence)
        {
            return ((delegate* stdcall<ISpeechPhraseProperty*, SpeechEngineConfidence*, int>)(lpVtbl[13]))((ISpeechPhraseProperty*)Unsafe.AsPointer(ref this), Confidence);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_Parent([NativeTypeName("ISpeechPhraseProperty **")] ISpeechPhraseProperty** ParentProperty)
        {
            return ((delegate* stdcall<ISpeechPhraseProperty*, ISpeechPhraseProperty**, int>)(lpVtbl[14]))((ISpeechPhraseProperty*)Unsafe.AsPointer(ref this), ParentProperty);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_Children([NativeTypeName("ISpeechPhraseProperties **")] ISpeechPhraseProperties** Children)
        {
            return ((delegate* stdcall<ISpeechPhraseProperty*, ISpeechPhraseProperties**, int>)(lpVtbl[15]))((ISpeechPhraseProperty*)Unsafe.AsPointer(ref this), Children);
        }
    }
}
