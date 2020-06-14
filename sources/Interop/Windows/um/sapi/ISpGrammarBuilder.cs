// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("8137828F-591A-4A42-BE58-49EA7EBAAC68")]
    public unsafe partial struct ISpGrammarBuilder
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<ISpGrammarBuilder*, Guid*, void**, int>)(lpVtbl[0]))((ISpGrammarBuilder*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<ISpGrammarBuilder*, uint>)(lpVtbl[1]))((ISpGrammarBuilder*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<ISpGrammarBuilder*, uint>)(lpVtbl[2]))((ISpGrammarBuilder*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int ResetGrammar([NativeTypeName("WORD")] ushort NewLanguage)
        {
            return ((delegate* stdcall<ISpGrammarBuilder*, ushort, int>)(lpVtbl[3]))((ISpGrammarBuilder*)Unsafe.AsPointer(ref this), NewLanguage);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetRule([NativeTypeName("LPCWSTR")] ushort* pszRuleName, [NativeTypeName("DWORD")] uint dwRuleId, [NativeTypeName("DWORD")] uint dwAttributes, [NativeTypeName("BOOL")] int fCreateIfNotExist, [NativeTypeName("SPSTATEHANDLE *")] SPSTATEHANDLE__** phInitialState)
        {
            return ((delegate* stdcall<ISpGrammarBuilder*, ushort*, uint, uint, int, SPSTATEHANDLE__**, int>)(lpVtbl[4]))((ISpGrammarBuilder*)Unsafe.AsPointer(ref this), pszRuleName, dwRuleId, dwAttributes, fCreateIfNotExist, phInitialState);
        }

        [return: NativeTypeName("HRESULT")]
        public int ClearRule([NativeTypeName("SPSTATEHANDLE")] SPSTATEHANDLE__* hState)
        {
            return ((delegate* stdcall<ISpGrammarBuilder*, SPSTATEHANDLE__*, int>)(lpVtbl[5]))((ISpGrammarBuilder*)Unsafe.AsPointer(ref this), hState);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateNewState([NativeTypeName("SPSTATEHANDLE")] SPSTATEHANDLE__* hState, [NativeTypeName("SPSTATEHANDLE *")] SPSTATEHANDLE__** phState)
        {
            return ((delegate* stdcall<ISpGrammarBuilder*, SPSTATEHANDLE__*, SPSTATEHANDLE__**, int>)(lpVtbl[6]))((ISpGrammarBuilder*)Unsafe.AsPointer(ref this), hState, phState);
        }

        [return: NativeTypeName("HRESULT")]
        public int AddWordTransition([NativeTypeName("SPSTATEHANDLE")] SPSTATEHANDLE__* hFromState, [NativeTypeName("SPSTATEHANDLE")] SPSTATEHANDLE__* hToState, [NativeTypeName("LPCWSTR")] ushort* psz, [NativeTypeName("LPCWSTR")] ushort* pszSeparators, SPGRAMMARWORDTYPE eWordType, float Weight, [NativeTypeName("const SPPROPERTYINFO *")] SPPROPERTYINFO* pPropInfo)
        {
            return ((delegate* stdcall<ISpGrammarBuilder*, SPSTATEHANDLE__*, SPSTATEHANDLE__*, ushort*, ushort*, SPGRAMMARWORDTYPE, float, SPPROPERTYINFO*, int>)(lpVtbl[7]))((ISpGrammarBuilder*)Unsafe.AsPointer(ref this), hFromState, hToState, psz, pszSeparators, eWordType, Weight, pPropInfo);
        }

        [return: NativeTypeName("HRESULT")]
        public int AddRuleTransition([NativeTypeName("SPSTATEHANDLE")] SPSTATEHANDLE__* hFromState, [NativeTypeName("SPSTATEHANDLE")] SPSTATEHANDLE__* hToState, [NativeTypeName("SPSTATEHANDLE")] SPSTATEHANDLE__* hRule, float Weight, [NativeTypeName("const SPPROPERTYINFO *")] SPPROPERTYINFO* pPropInfo)
        {
            return ((delegate* stdcall<ISpGrammarBuilder*, SPSTATEHANDLE__*, SPSTATEHANDLE__*, SPSTATEHANDLE__*, float, SPPROPERTYINFO*, int>)(lpVtbl[8]))((ISpGrammarBuilder*)Unsafe.AsPointer(ref this), hFromState, hToState, hRule, Weight, pPropInfo);
        }

        [return: NativeTypeName("HRESULT")]
        public int AddResource([NativeTypeName("SPSTATEHANDLE")] SPSTATEHANDLE__* hRuleState, [NativeTypeName("LPCWSTR")] ushort* pszResourceName, [NativeTypeName("LPCWSTR")] ushort* pszResourceValue)
        {
            return ((delegate* stdcall<ISpGrammarBuilder*, SPSTATEHANDLE__*, ushort*, ushort*, int>)(lpVtbl[9]))((ISpGrammarBuilder*)Unsafe.AsPointer(ref this), hRuleState, pszResourceName, pszResourceValue);
        }

        [return: NativeTypeName("HRESULT")]
        public int Commit([NativeTypeName("DWORD")] uint dwReserved)
        {
            return ((delegate* stdcall<ISpGrammarBuilder*, uint, int>)(lpVtbl[10]))((ISpGrammarBuilder*)Unsafe.AsPointer(ref this), dwReserved);
        }
    }
}
