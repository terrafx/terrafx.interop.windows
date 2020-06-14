// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("CAFD1DB1-41D1-4A06-9863-E2E81DA17A9A")]
    public unsafe partial struct ISpeechGrammarRuleStateTransition
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<ISpeechGrammarRuleStateTransition*, Guid*, void**, int>)(lpVtbl[0]))((ISpeechGrammarRuleStateTransition*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<ISpeechGrammarRuleStateTransition*, uint>)(lpVtbl[1]))((ISpeechGrammarRuleStateTransition*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<ISpeechGrammarRuleStateTransition*, uint>)(lpVtbl[2]))((ISpeechGrammarRuleStateTransition*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfoCount([NativeTypeName("UINT *")] uint* pctinfo)
        {
            return ((delegate* stdcall<ISpeechGrammarRuleStateTransition*, uint*, int>)(lpVtbl[3]))((ISpeechGrammarRuleStateTransition*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfo([NativeTypeName("UINT")] uint iTInfo, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("ITypeInfo **")] ITypeInfo** ppTInfo)
        {
            return ((delegate* stdcall<ISpeechGrammarRuleStateTransition*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((ISpeechGrammarRuleStateTransition*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, [NativeTypeName("UINT")] uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* stdcall<ISpeechGrammarRuleStateTransition*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((ISpeechGrammarRuleStateTransition*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [return: NativeTypeName("HRESULT")]
        public int Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, [NativeTypeName("DISPPARAMS *")] DISPPARAMS* pDispParams, [NativeTypeName("VARIANT *")] VARIANT* pVarResult, [NativeTypeName("EXCEPINFO *")] EXCEPINFO* pExcepInfo, [NativeTypeName("UINT *")] uint* puArgErr)
        {
            return ((delegate* stdcall<ISpeechGrammarRuleStateTransition*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((ISpeechGrammarRuleStateTransition*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_Type([NativeTypeName("SpeechGrammarRuleStateTransitionType *")] SpeechGrammarRuleStateTransitionType* Type)
        {
            return ((delegate* stdcall<ISpeechGrammarRuleStateTransition*, SpeechGrammarRuleStateTransitionType*, int>)(lpVtbl[7]))((ISpeechGrammarRuleStateTransition*)Unsafe.AsPointer(ref this), Type);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_Text([NativeTypeName("BSTR *")] ushort** Text)
        {
            return ((delegate* stdcall<ISpeechGrammarRuleStateTransition*, ushort**, int>)(lpVtbl[8]))((ISpeechGrammarRuleStateTransition*)Unsafe.AsPointer(ref this), Text);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_Rule([NativeTypeName("ISpeechGrammarRule **")] ISpeechGrammarRule** Rule)
        {
            return ((delegate* stdcall<ISpeechGrammarRuleStateTransition*, ISpeechGrammarRule**, int>)(lpVtbl[9]))((ISpeechGrammarRuleStateTransition*)Unsafe.AsPointer(ref this), Rule);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_Weight([NativeTypeName("VARIANT *")] VARIANT* Weight)
        {
            return ((delegate* stdcall<ISpeechGrammarRuleStateTransition*, VARIANT*, int>)(lpVtbl[10]))((ISpeechGrammarRuleStateTransition*)Unsafe.AsPointer(ref this), Weight);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_PropertyName([NativeTypeName("BSTR *")] ushort** PropertyName)
        {
            return ((delegate* stdcall<ISpeechGrammarRuleStateTransition*, ushort**, int>)(lpVtbl[11]))((ISpeechGrammarRuleStateTransition*)Unsafe.AsPointer(ref this), PropertyName);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_PropertyId([NativeTypeName("long *")] int* PropertyId)
        {
            return ((delegate* stdcall<ISpeechGrammarRuleStateTransition*, int*, int>)(lpVtbl[12]))((ISpeechGrammarRuleStateTransition*)Unsafe.AsPointer(ref this), PropertyId);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_PropertyValue([NativeTypeName("VARIANT *")] VARIANT* PropertyValue)
        {
            return ((delegate* stdcall<ISpeechGrammarRuleStateTransition*, VARIANT*, int>)(lpVtbl[13]))((ISpeechGrammarRuleStateTransition*)Unsafe.AsPointer(ref this), PropertyValue);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_NextState([NativeTypeName("ISpeechGrammarRuleState **")] ISpeechGrammarRuleState** NextState)
        {
            return ((delegate* stdcall<ISpeechGrammarRuleStateTransition*, ISpeechGrammarRuleState**, int>)(lpVtbl[14]))((ISpeechGrammarRuleStateTransition*)Unsafe.AsPointer(ref this), NextState);
        }
    }
}
