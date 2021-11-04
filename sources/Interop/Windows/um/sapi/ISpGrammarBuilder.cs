// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("8137828F-591A-4A42-BE58-49EA7EBAAC68")]
    [NativeTypeName("struct ISpGrammarBuilder : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct ISpGrammarBuilder
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ISpGrammarBuilder*, Guid*, void**, int>)(lpVtbl[0]))((ISpGrammarBuilder*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ISpGrammarBuilder*, uint>)(lpVtbl[1]))((ISpGrammarBuilder*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ISpGrammarBuilder*, uint>)(lpVtbl[2]))((ISpGrammarBuilder*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT ResetGrammar([NativeTypeName("WORD")] ushort NewLanguage)
        {
            return ((delegate* unmanaged<ISpGrammarBuilder*, ushort, int>)(lpVtbl[3]))((ISpGrammarBuilder*)Unsafe.AsPointer(ref this), NewLanguage);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetRule([NativeTypeName("LPCWSTR")] ushort* pszRuleName, [NativeTypeName("DWORD")] uint dwRuleId, [NativeTypeName("DWORD")] uint dwAttributes, BOOL fCreateIfNotExist, SPSTATEHANDLE* phInitialState)
        {
            return ((delegate* unmanaged<ISpGrammarBuilder*, ushort*, uint, uint, BOOL, SPSTATEHANDLE*, int>)(lpVtbl[4]))((ISpGrammarBuilder*)Unsafe.AsPointer(ref this), pszRuleName, dwRuleId, dwAttributes, fCreateIfNotExist, phInitialState);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT ClearRule(SPSTATEHANDLE hState)
        {
            return ((delegate* unmanaged<ISpGrammarBuilder*, SPSTATEHANDLE, int>)(lpVtbl[5]))((ISpGrammarBuilder*)Unsafe.AsPointer(ref this), hState);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT CreateNewState(SPSTATEHANDLE hState, SPSTATEHANDLE* phState)
        {
            return ((delegate* unmanaged<ISpGrammarBuilder*, SPSTATEHANDLE, SPSTATEHANDLE*, int>)(lpVtbl[6]))((ISpGrammarBuilder*)Unsafe.AsPointer(ref this), hState, phState);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT AddWordTransition(SPSTATEHANDLE hFromState, SPSTATEHANDLE hToState, [NativeTypeName("LPCWSTR")] ushort* psz, [NativeTypeName("LPCWSTR")] ushort* pszSeparators, SPGRAMMARWORDTYPE eWordType, float Weight, [NativeTypeName("const SPPROPERTYINFO *")] SPPROPERTYINFO* pPropInfo)
        {
            return ((delegate* unmanaged<ISpGrammarBuilder*, SPSTATEHANDLE, SPSTATEHANDLE, ushort*, ushort*, SPGRAMMARWORDTYPE, float, SPPROPERTYINFO*, int>)(lpVtbl[7]))((ISpGrammarBuilder*)Unsafe.AsPointer(ref this), hFromState, hToState, psz, pszSeparators, eWordType, Weight, pPropInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT AddRuleTransition(SPSTATEHANDLE hFromState, SPSTATEHANDLE hToState, SPSTATEHANDLE hRule, float Weight, [NativeTypeName("const SPPROPERTYINFO *")] SPPROPERTYINFO* pPropInfo)
        {
            return ((delegate* unmanaged<ISpGrammarBuilder*, SPSTATEHANDLE, SPSTATEHANDLE, SPSTATEHANDLE, float, SPPROPERTYINFO*, int>)(lpVtbl[8]))((ISpGrammarBuilder*)Unsafe.AsPointer(ref this), hFromState, hToState, hRule, Weight, pPropInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT AddResource(SPSTATEHANDLE hRuleState, [NativeTypeName("LPCWSTR")] ushort* pszResourceName, [NativeTypeName("LPCWSTR")] ushort* pszResourceValue)
        {
            return ((delegate* unmanaged<ISpGrammarBuilder*, SPSTATEHANDLE, ushort*, ushort*, int>)(lpVtbl[9]))((ISpGrammarBuilder*)Unsafe.AsPointer(ref this), hRuleState, pszResourceName, pszResourceValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT Commit([NativeTypeName("DWORD")] uint dwReserved)
        {
            return ((delegate* unmanaged<ISpGrammarBuilder*, uint, int>)(lpVtbl[10]))((ISpGrammarBuilder*)Unsafe.AsPointer(ref this), dwReserved);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpGrammarBuilder*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ISpGrammarBuilder*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ISpGrammarBuilder*, uint> Release;

            [NativeTypeName("HRESULT (WORD) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpGrammarBuilder*, ushort, int> ResetGrammar;

            [NativeTypeName("HRESULT (LPCWSTR, DWORD, DWORD, BOOL, SPSTATEHANDLE *) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpGrammarBuilder*, ushort*, uint, uint, BOOL, SPSTATEHANDLE*, int> GetRule;

            [NativeTypeName("HRESULT (SPSTATEHANDLE) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpGrammarBuilder*, SPSTATEHANDLE, int> ClearRule;

            [NativeTypeName("HRESULT (SPSTATEHANDLE, SPSTATEHANDLE *) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpGrammarBuilder*, SPSTATEHANDLE, SPSTATEHANDLE*, int> CreateNewState;

            [NativeTypeName("HRESULT (SPSTATEHANDLE, SPSTATEHANDLE, LPCWSTR, LPCWSTR, SPGRAMMARWORDTYPE, float, const SPPROPERTYINFO *) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpGrammarBuilder*, SPSTATEHANDLE, SPSTATEHANDLE, ushort*, ushort*, SPGRAMMARWORDTYPE, float, SPPROPERTYINFO*, int> AddWordTransition;

            [NativeTypeName("HRESULT (SPSTATEHANDLE, SPSTATEHANDLE, SPSTATEHANDLE, float, const SPPROPERTYINFO *) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpGrammarBuilder*, SPSTATEHANDLE, SPSTATEHANDLE, SPSTATEHANDLE, float, SPPROPERTYINFO*, int> AddRuleTransition;

            [NativeTypeName("HRESULT (SPSTATEHANDLE, LPCWSTR, LPCWSTR) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpGrammarBuilder*, SPSTATEHANDLE, ushort*, ushort*, int> AddResource;

            [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpGrammarBuilder*, uint, int> Commit;
        }
    }
}
