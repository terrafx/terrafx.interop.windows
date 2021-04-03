// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("EABCE657-75BC-44A2-AA7F-C56476742963")]
    [NativeTypeName("struct ISpeechGrammarRuleStateTransitions : IDispatch")]
    public unsafe partial struct ISpeechGrammarRuleStateTransitions
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ISpeechGrammarRuleStateTransitions*, Guid*, void**, int>)(lpVtbl[0]))((ISpeechGrammarRuleStateTransitions*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ISpeechGrammarRuleStateTransitions*, uint>)(lpVtbl[1]))((ISpeechGrammarRuleStateTransitions*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ISpeechGrammarRuleStateTransitions*, uint>)(lpVtbl[2]))((ISpeechGrammarRuleStateTransitions*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfoCount([NativeTypeName("UINT *")] uint* pctinfo)
        {
            return ((delegate* unmanaged<ISpeechGrammarRuleStateTransitions*, uint*, int>)(lpVtbl[3]))((ISpeechGrammarRuleStateTransitions*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfo([NativeTypeName("UINT")] uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<ISpeechGrammarRuleStateTransitions*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((ISpeechGrammarRuleStateTransitions*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, [NativeTypeName("UINT")] uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<ISpeechGrammarRuleStateTransitions*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((ISpeechGrammarRuleStateTransitions*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, [NativeTypeName("UINT *")] uint* puArgErr)
        {
            return ((delegate* unmanaged<ISpeechGrammarRuleStateTransitions*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((ISpeechGrammarRuleStateTransitions*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Count([NativeTypeName("long *")] int* Count)
        {
            return ((delegate* unmanaged<ISpeechGrammarRuleStateTransitions*, int*, int>)(lpVtbl[7]))((ISpeechGrammarRuleStateTransitions*)Unsafe.AsPointer(ref this), Count);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Item([NativeTypeName("long")] int Index, ISpeechGrammarRuleStateTransition** Transition)
        {
            return ((delegate* unmanaged<ISpeechGrammarRuleStateTransitions*, int, ISpeechGrammarRuleStateTransition**, int>)(lpVtbl[8]))((ISpeechGrammarRuleStateTransitions*)Unsafe.AsPointer(ref this), Index, Transition);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get__NewEnum(IUnknown** EnumVARIANT)
        {
            return ((delegate* unmanaged<ISpeechGrammarRuleStateTransitions*, IUnknown**, int>)(lpVtbl[9]))((ISpeechGrammarRuleStateTransitions*)Unsafe.AsPointer(ref this), EnumVARIANT);
        }
    }
}
