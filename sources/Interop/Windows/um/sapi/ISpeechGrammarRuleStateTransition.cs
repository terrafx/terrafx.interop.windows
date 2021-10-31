// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("CAFD1DB1-41D1-4A06-9863-E2E81DA17A9A")]
    [NativeTypeName("struct ISpeechGrammarRuleStateTransition : IDispatch")]
    [NativeInheritance("IDispatch")]
    public unsafe partial struct ISpeechGrammarRuleStateTransition
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ISpeechGrammarRuleStateTransition*, Guid*, void**, int>)(lpVtbl[0]))((ISpeechGrammarRuleStateTransition*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ISpeechGrammarRuleStateTransition*, uint>)(lpVtbl[1]))((ISpeechGrammarRuleStateTransition*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ISpeechGrammarRuleStateTransition*, uint>)(lpVtbl[2]))((ISpeechGrammarRuleStateTransition*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetTypeInfoCount([NativeTypeName("UINT *")] uint* pctinfo)
        {
            return ((delegate* unmanaged<ISpeechGrammarRuleStateTransition*, uint*, int>)(lpVtbl[3]))((ISpeechGrammarRuleStateTransition*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetTypeInfo([NativeTypeName("UINT")] uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<ISpeechGrammarRuleStateTransition*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((ISpeechGrammarRuleStateTransition*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, [NativeTypeName("UINT")] uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<ISpeechGrammarRuleStateTransition*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((ISpeechGrammarRuleStateTransition*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, [NativeTypeName("UINT *")] uint* puArgErr)
        {
            return ((delegate* unmanaged<ISpeechGrammarRuleStateTransition*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((ISpeechGrammarRuleStateTransition*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT get_Type(SpeechGrammarRuleStateTransitionType* Type)
        {
            return ((delegate* unmanaged<ISpeechGrammarRuleStateTransition*, SpeechGrammarRuleStateTransitionType*, int>)(lpVtbl[7]))((ISpeechGrammarRuleStateTransition*)Unsafe.AsPointer(ref this), Type);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT get_Text([NativeTypeName("BSTR *")] ushort** Text)
        {
            return ((delegate* unmanaged<ISpeechGrammarRuleStateTransition*, ushort**, int>)(lpVtbl[8]))((ISpeechGrammarRuleStateTransition*)Unsafe.AsPointer(ref this), Text);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT get_Rule(ISpeechGrammarRule** Rule)
        {
            return ((delegate* unmanaged<ISpeechGrammarRuleStateTransition*, ISpeechGrammarRule**, int>)(lpVtbl[9]))((ISpeechGrammarRuleStateTransition*)Unsafe.AsPointer(ref this), Rule);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT get_Weight(VARIANT* Weight)
        {
            return ((delegate* unmanaged<ISpeechGrammarRuleStateTransition*, VARIANT*, int>)(lpVtbl[10]))((ISpeechGrammarRuleStateTransition*)Unsafe.AsPointer(ref this), Weight);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT get_PropertyName([NativeTypeName("BSTR *")] ushort** PropertyName)
        {
            return ((delegate* unmanaged<ISpeechGrammarRuleStateTransition*, ushort**, int>)(lpVtbl[11]))((ISpeechGrammarRuleStateTransition*)Unsafe.AsPointer(ref this), PropertyName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT get_PropertyId([NativeTypeName("long *")] int* PropertyId)
        {
            return ((delegate* unmanaged<ISpeechGrammarRuleStateTransition*, int*, int>)(lpVtbl[12]))((ISpeechGrammarRuleStateTransition*)Unsafe.AsPointer(ref this), PropertyId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT get_PropertyValue(VARIANT* PropertyValue)
        {
            return ((delegate* unmanaged<ISpeechGrammarRuleStateTransition*, VARIANT*, int>)(lpVtbl[13]))((ISpeechGrammarRuleStateTransition*)Unsafe.AsPointer(ref this), PropertyValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HRESULT get_NextState(ISpeechGrammarRuleState** NextState)
        {
            return ((delegate* unmanaged<ISpeechGrammarRuleStateTransition*, ISpeechGrammarRuleState**, int>)(lpVtbl[14]))((ISpeechGrammarRuleStateTransition*)Unsafe.AsPointer(ref this), NextState);
        }
    }
}
