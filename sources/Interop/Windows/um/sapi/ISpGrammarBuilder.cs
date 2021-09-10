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
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
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
        [return: NativeTypeName("HRESULT")]
        public int ResetGrammar([NativeTypeName("WORD")] ushort NewLanguage)
        {
            return ((delegate* unmanaged<ISpGrammarBuilder*, ushort, int>)(lpVtbl[3]))((ISpGrammarBuilder*)Unsafe.AsPointer(ref this), NewLanguage);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int GetRule([NativeTypeName("LPCWSTR")] ushort* pszRuleName, [NativeTypeName("DWORD")] uint dwRuleId, [NativeTypeName("DWORD")] uint dwAttributes, [NativeTypeName("BOOL")] int fCreateIfNotExist, [NativeTypeName("SPSTATEHANDLE *")] IntPtr* phInitialState)
        {
            return ((delegate* unmanaged<ISpGrammarBuilder*, ushort*, uint, uint, int, IntPtr*, int>)(lpVtbl[4]))((ISpGrammarBuilder*)Unsafe.AsPointer(ref this), pszRuleName, dwRuleId, dwAttributes, fCreateIfNotExist, phInitialState);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int ClearRule([NativeTypeName("SPSTATEHANDLE")] IntPtr hState)
        {
            return ((delegate* unmanaged<ISpGrammarBuilder*, IntPtr, int>)(lpVtbl[5]))((ISpGrammarBuilder*)Unsafe.AsPointer(ref this), hState);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int CreateNewState([NativeTypeName("SPSTATEHANDLE")] IntPtr hState, [NativeTypeName("SPSTATEHANDLE *")] IntPtr* phState)
        {
            return ((delegate* unmanaged<ISpGrammarBuilder*, IntPtr, IntPtr*, int>)(lpVtbl[6]))((ISpGrammarBuilder*)Unsafe.AsPointer(ref this), hState, phState);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int AddWordTransition([NativeTypeName("SPSTATEHANDLE")] IntPtr hFromState, [NativeTypeName("SPSTATEHANDLE")] IntPtr hToState, [NativeTypeName("LPCWSTR")] ushort* psz, [NativeTypeName("LPCWSTR")] ushort* pszSeparators, SPGRAMMARWORDTYPE eWordType, float Weight, [NativeTypeName("const SPPROPERTYINFO *")] SPPROPERTYINFO* pPropInfo)
        {
            return ((delegate* unmanaged<ISpGrammarBuilder*, IntPtr, IntPtr, ushort*, ushort*, SPGRAMMARWORDTYPE, float, SPPROPERTYINFO*, int>)(lpVtbl[7]))((ISpGrammarBuilder*)Unsafe.AsPointer(ref this), hFromState, hToState, psz, pszSeparators, eWordType, Weight, pPropInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int AddRuleTransition([NativeTypeName("SPSTATEHANDLE")] IntPtr hFromState, [NativeTypeName("SPSTATEHANDLE")] IntPtr hToState, [NativeTypeName("SPSTATEHANDLE")] IntPtr hRule, float Weight, [NativeTypeName("const SPPROPERTYINFO *")] SPPROPERTYINFO* pPropInfo)
        {
            return ((delegate* unmanaged<ISpGrammarBuilder*, IntPtr, IntPtr, IntPtr, float, SPPROPERTYINFO*, int>)(lpVtbl[8]))((ISpGrammarBuilder*)Unsafe.AsPointer(ref this), hFromState, hToState, hRule, Weight, pPropInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("HRESULT")]
        public int AddResource([NativeTypeName("SPSTATEHANDLE")] IntPtr hRuleState, [NativeTypeName("LPCWSTR")] ushort* pszResourceName, [NativeTypeName("LPCWSTR")] ushort* pszResourceValue)
        {
            return ((delegate* unmanaged<ISpGrammarBuilder*, IntPtr, ushort*, ushort*, int>)(lpVtbl[9]))((ISpGrammarBuilder*)Unsafe.AsPointer(ref this), hRuleState, pszResourceName, pszResourceValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        [return: NativeTypeName("HRESULT")]
        public int Commit([NativeTypeName("DWORD")] uint dwReserved)
        {
            return ((delegate* unmanaged<ISpGrammarBuilder*, uint, int>)(lpVtbl[10]))((ISpGrammarBuilder*)Unsafe.AsPointer(ref this), dwReserved);
        }
    }
}
