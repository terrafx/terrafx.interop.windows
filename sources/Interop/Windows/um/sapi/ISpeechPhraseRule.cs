// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("A7BFE112-A4A0-48D9-B602-C313843F6964")]
    public unsafe partial struct ISpeechPhraseRule
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<ISpeechPhraseRule*, Guid*, void**, int>)(lpVtbl[0]))((ISpeechPhraseRule*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<ISpeechPhraseRule*, uint>)(lpVtbl[1]))((ISpeechPhraseRule*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<ISpeechPhraseRule*, uint>)(lpVtbl[2]))((ISpeechPhraseRule*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfoCount([NativeTypeName("UINT *")] uint* pctinfo)
        {
            return ((delegate* stdcall<ISpeechPhraseRule*, uint*, int>)(lpVtbl[3]))((ISpeechPhraseRule*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfo([NativeTypeName("UINT")] uint iTInfo, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("ITypeInfo **")] ITypeInfo** ppTInfo)
        {
            return ((delegate* stdcall<ISpeechPhraseRule*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((ISpeechPhraseRule*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, [NativeTypeName("UINT")] uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* stdcall<ISpeechPhraseRule*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((ISpeechPhraseRule*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [return: NativeTypeName("HRESULT")]
        public int Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, [NativeTypeName("DISPPARAMS *")] DISPPARAMS* pDispParams, [NativeTypeName("VARIANT *")] VARIANT* pVarResult, [NativeTypeName("EXCEPINFO *")] EXCEPINFO* pExcepInfo, [NativeTypeName("UINT *")] uint* puArgErr)
        {
            return ((delegate* stdcall<ISpeechPhraseRule*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((ISpeechPhraseRule*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_Name([NativeTypeName("BSTR *")] ushort** Name)
        {
            return ((delegate* stdcall<ISpeechPhraseRule*, ushort**, int>)(lpVtbl[7]))((ISpeechPhraseRule*)Unsafe.AsPointer(ref this), Name);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_Id([NativeTypeName("long *")] int* Id)
        {
            return ((delegate* stdcall<ISpeechPhraseRule*, int*, int>)(lpVtbl[8]))((ISpeechPhraseRule*)Unsafe.AsPointer(ref this), Id);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_FirstElement([NativeTypeName("long *")] int* FirstElement)
        {
            return ((delegate* stdcall<ISpeechPhraseRule*, int*, int>)(lpVtbl[9]))((ISpeechPhraseRule*)Unsafe.AsPointer(ref this), FirstElement);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_NumberOfElements([NativeTypeName("long *")] int* NumberOfElements)
        {
            return ((delegate* stdcall<ISpeechPhraseRule*, int*, int>)(lpVtbl[10]))((ISpeechPhraseRule*)Unsafe.AsPointer(ref this), NumberOfElements);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_Parent([NativeTypeName("ISpeechPhraseRule **")] ISpeechPhraseRule** Parent)
        {
            return ((delegate* stdcall<ISpeechPhraseRule*, ISpeechPhraseRule**, int>)(lpVtbl[11]))((ISpeechPhraseRule*)Unsafe.AsPointer(ref this), Parent);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_Children([NativeTypeName("ISpeechPhraseRules **")] ISpeechPhraseRules** Children)
        {
            return ((delegate* stdcall<ISpeechPhraseRule*, ISpeechPhraseRules**, int>)(lpVtbl[12]))((ISpeechPhraseRule*)Unsafe.AsPointer(ref this), Children);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_Confidence([NativeTypeName("SpeechEngineConfidence *")] SpeechEngineConfidence* ActualConfidence)
        {
            return ((delegate* stdcall<ISpeechPhraseRule*, SpeechEngineConfidence*, int>)(lpVtbl[13]))((ISpeechPhraseRule*)Unsafe.AsPointer(ref this), ActualConfidence);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_EngineConfidence([NativeTypeName("float *")] float* EngineConfidence)
        {
            return ((delegate* stdcall<ISpeechPhraseRule*, float*, int>)(lpVtbl[14]))((ISpeechPhraseRule*)Unsafe.AsPointer(ref this), EngineConfidence);
        }
    }
}
