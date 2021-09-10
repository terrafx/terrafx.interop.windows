// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.SpeechGrammarWordType;

namespace TerraFX.Interop
{
    [Guid("D4286F2C-EE67-45AE-B928-28D695362EDA")]
    [NativeTypeName("struct ISpeechGrammarRuleState : IDispatch")]
    [NativeInheritance("IDispatch")]
    public unsafe partial struct ISpeechGrammarRuleState
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ISpeechGrammarRuleState*, Guid*, void**, int>)(lpVtbl[0]))((ISpeechGrammarRuleState*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ISpeechGrammarRuleState*, uint>)(lpVtbl[1]))((ISpeechGrammarRuleState*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ISpeechGrammarRuleState*, uint>)(lpVtbl[2]))((ISpeechGrammarRuleState*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfoCount([NativeTypeName("UINT *")] uint* pctinfo)
        {
            return ((delegate* unmanaged<ISpeechGrammarRuleState*, uint*, int>)(lpVtbl[3]))((ISpeechGrammarRuleState*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfo([NativeTypeName("UINT")] uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<ISpeechGrammarRuleState*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((ISpeechGrammarRuleState*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, [NativeTypeName("UINT")] uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<ISpeechGrammarRuleState*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((ISpeechGrammarRuleState*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, [NativeTypeName("UINT *")] uint* puArgErr)
        {
            return ((delegate* unmanaged<ISpeechGrammarRuleState*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((ISpeechGrammarRuleState*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int get_Rule(ISpeechGrammarRule** Rule)
        {
            return ((delegate* unmanaged<ISpeechGrammarRuleState*, ISpeechGrammarRule**, int>)(lpVtbl[7]))((ISpeechGrammarRuleState*)Unsafe.AsPointer(ref this), Rule);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int get_Transitions(ISpeechGrammarRuleStateTransitions** Transitions)
        {
            return ((delegate* unmanaged<ISpeechGrammarRuleState*, ISpeechGrammarRuleStateTransitions**, int>)(lpVtbl[8]))((ISpeechGrammarRuleState*)Unsafe.AsPointer(ref this), Transitions);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("HRESULT")]
        public int AddWordTransition(ISpeechGrammarRuleState* DestState, [NativeTypeName("const BSTR")] ushort* Words, [NativeTypeName("const BSTR")] ushort* Separators = null, SpeechGrammarWordType Type = SGLexical, [NativeTypeName("const BSTR")] ushort* PropertyName = null, [NativeTypeName("long")] int PropertyId = 0, VARIANT* PropertyValue = null, float Weight = 1)
        {
            return ((delegate* unmanaged<ISpeechGrammarRuleState*, ISpeechGrammarRuleState*, ushort*, ushort*, SpeechGrammarWordType, ushort*, int, VARIANT*, float, int>)(lpVtbl[9]))((ISpeechGrammarRuleState*)Unsafe.AsPointer(ref this), DestState, Words, Separators, Type, PropertyName, PropertyId, PropertyValue, Weight);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        [return: NativeTypeName("HRESULT")]
        public int AddRuleTransition(ISpeechGrammarRuleState* DestinationState, ISpeechGrammarRule* Rule, [NativeTypeName("const BSTR")] ushort* PropertyName = null, [NativeTypeName("long")] int PropertyId = 0, VARIANT* PropertyValue = null, float Weight = 1)
        {
            return ((delegate* unmanaged<ISpeechGrammarRuleState*, ISpeechGrammarRuleState*, ISpeechGrammarRule*, ushort*, int, VARIANT*, float, int>)(lpVtbl[10]))((ISpeechGrammarRuleState*)Unsafe.AsPointer(ref this), DestinationState, Rule, PropertyName, PropertyId, PropertyValue, Weight);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        [return: NativeTypeName("HRESULT")]
        public int AddSpecialTransition(ISpeechGrammarRuleState* DestinationState, SpeechSpecialTransitionType Type, [NativeTypeName("const BSTR")] ushort* PropertyName = null, [NativeTypeName("long")] int PropertyId = 0, VARIANT* PropertyValue = null, float Weight = 1)
        {
            return ((delegate* unmanaged<ISpeechGrammarRuleState*, ISpeechGrammarRuleState*, SpeechSpecialTransitionType, ushort*, int, VARIANT*, float, int>)(lpVtbl[11]))((ISpeechGrammarRuleState*)Unsafe.AsPointer(ref this), DestinationState, Type, PropertyName, PropertyId, PropertyValue, Weight);
        }
    }
}
