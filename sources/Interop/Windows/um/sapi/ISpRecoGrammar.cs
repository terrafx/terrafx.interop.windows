// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("2177DB29-7F45-47D0-8554-067E91C80502")]
    [NativeTypeName("struct ISpRecoGrammar : ISpGrammarBuilder")]
    [NativeInheritance("ISpGrammarBuilder")]
    public unsafe partial struct ISpRecoGrammar
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ISpRecoGrammar*, Guid*, void**, int>)(lpVtbl[0]))((ISpRecoGrammar*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ISpRecoGrammar*, uint>)(lpVtbl[1]))((ISpRecoGrammar*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ISpRecoGrammar*, uint>)(lpVtbl[2]))((ISpRecoGrammar*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int ResetGrammar([NativeTypeName("WORD")] ushort NewLanguage)
        {
            return ((delegate* unmanaged<ISpRecoGrammar*, ushort, int>)(lpVtbl[3]))((ISpRecoGrammar*)Unsafe.AsPointer(ref this), NewLanguage);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int GetRule([NativeTypeName("LPCWSTR")] ushort* pszRuleName, [NativeTypeName("DWORD")] uint dwRuleId, [NativeTypeName("DWORD")] uint dwAttributes, [NativeTypeName("BOOL")] int fCreateIfNotExist, [NativeTypeName("SPSTATEHANDLE *")] IntPtr* phInitialState)
        {
            return ((delegate* unmanaged<ISpRecoGrammar*, ushort*, uint, uint, int, IntPtr*, int>)(lpVtbl[4]))((ISpRecoGrammar*)Unsafe.AsPointer(ref this), pszRuleName, dwRuleId, dwAttributes, fCreateIfNotExist, phInitialState);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int ClearRule([NativeTypeName("SPSTATEHANDLE")] IntPtr hState)
        {
            return ((delegate* unmanaged<ISpRecoGrammar*, IntPtr, int>)(lpVtbl[5]))((ISpRecoGrammar*)Unsafe.AsPointer(ref this), hState);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int CreateNewState([NativeTypeName("SPSTATEHANDLE")] IntPtr hState, [NativeTypeName("SPSTATEHANDLE *")] IntPtr* phState)
        {
            return ((delegate* unmanaged<ISpRecoGrammar*, IntPtr, IntPtr*, int>)(lpVtbl[6]))((ISpRecoGrammar*)Unsafe.AsPointer(ref this), hState, phState);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int AddWordTransition([NativeTypeName("SPSTATEHANDLE")] IntPtr hFromState, [NativeTypeName("SPSTATEHANDLE")] IntPtr hToState, [NativeTypeName("LPCWSTR")] ushort* psz, [NativeTypeName("LPCWSTR")] ushort* pszSeparators, SPGRAMMARWORDTYPE eWordType, float Weight, [NativeTypeName("const SPPROPERTYINFO *")] SPPROPERTYINFO* pPropInfo)
        {
            return ((delegate* unmanaged<ISpRecoGrammar*, IntPtr, IntPtr, ushort*, ushort*, SPGRAMMARWORDTYPE, float, SPPROPERTYINFO*, int>)(lpVtbl[7]))((ISpRecoGrammar*)Unsafe.AsPointer(ref this), hFromState, hToState, psz, pszSeparators, eWordType, Weight, pPropInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int AddRuleTransition([NativeTypeName("SPSTATEHANDLE")] IntPtr hFromState, [NativeTypeName("SPSTATEHANDLE")] IntPtr hToState, [NativeTypeName("SPSTATEHANDLE")] IntPtr hRule, float Weight, [NativeTypeName("const SPPROPERTYINFO *")] SPPROPERTYINFO* pPropInfo)
        {
            return ((delegate* unmanaged<ISpRecoGrammar*, IntPtr, IntPtr, IntPtr, float, SPPROPERTYINFO*, int>)(lpVtbl[8]))((ISpRecoGrammar*)Unsafe.AsPointer(ref this), hFromState, hToState, hRule, Weight, pPropInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("HRESULT")]
        public int AddResource([NativeTypeName("SPSTATEHANDLE")] IntPtr hRuleState, [NativeTypeName("LPCWSTR")] ushort* pszResourceName, [NativeTypeName("LPCWSTR")] ushort* pszResourceValue)
        {
            return ((delegate* unmanaged<ISpRecoGrammar*, IntPtr, ushort*, ushort*, int>)(lpVtbl[9]))((ISpRecoGrammar*)Unsafe.AsPointer(ref this), hRuleState, pszResourceName, pszResourceValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        [return: NativeTypeName("HRESULT")]
        public int Commit([NativeTypeName("DWORD")] uint dwReserved)
        {
            return ((delegate* unmanaged<ISpRecoGrammar*, uint, int>)(lpVtbl[10]))((ISpRecoGrammar*)Unsafe.AsPointer(ref this), dwReserved);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        [return: NativeTypeName("HRESULT")]
        public int GetGrammarId([NativeTypeName("ULONGLONG *")] ulong* pullGrammarId)
        {
            return ((delegate* unmanaged<ISpRecoGrammar*, ulong*, int>)(lpVtbl[11]))((ISpRecoGrammar*)Unsafe.AsPointer(ref this), pullGrammarId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        [return: NativeTypeName("HRESULT")]
        public int GetRecoContext(ISpRecoContext** ppRecoCtxt)
        {
            return ((delegate* unmanaged<ISpRecoGrammar*, ISpRecoContext**, int>)(lpVtbl[12]))((ISpRecoGrammar*)Unsafe.AsPointer(ref this), ppRecoCtxt);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        [return: NativeTypeName("HRESULT")]
        public int LoadCmdFromFile([NativeTypeName("LPCWSTR")] ushort* pszFileName, SPLOADOPTIONS Options)
        {
            return ((delegate* unmanaged<ISpRecoGrammar*, ushort*, SPLOADOPTIONS, int>)(lpVtbl[13]))((ISpRecoGrammar*)Unsafe.AsPointer(ref this), pszFileName, Options);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        [return: NativeTypeName("HRESULT")]
        public int LoadCmdFromObject([NativeTypeName("const IID &")] Guid* rcid, [NativeTypeName("LPCWSTR")] ushort* pszGrammarName, SPLOADOPTIONS Options)
        {
            return ((delegate* unmanaged<ISpRecoGrammar*, Guid*, ushort*, SPLOADOPTIONS, int>)(lpVtbl[14]))((ISpRecoGrammar*)Unsafe.AsPointer(ref this), rcid, pszGrammarName, Options);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        [return: NativeTypeName("HRESULT")]
        public int LoadCmdFromResource([NativeTypeName("HMODULE")] IntPtr hModule, [NativeTypeName("LPCWSTR")] ushort* pszResourceName, [NativeTypeName("LPCWSTR")] ushort* pszResourceType, [NativeTypeName("WORD")] ushort wLanguage, SPLOADOPTIONS Options)
        {
            return ((delegate* unmanaged<ISpRecoGrammar*, IntPtr, ushort*, ushort*, ushort, SPLOADOPTIONS, int>)(lpVtbl[15]))((ISpRecoGrammar*)Unsafe.AsPointer(ref this), hModule, pszResourceName, pszResourceType, wLanguage, Options);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        [return: NativeTypeName("HRESULT")]
        public int LoadCmdFromMemory([NativeTypeName("const SPBINARYGRAMMAR *")] SPBINARYGRAMMAR* pGrammar, SPLOADOPTIONS Options)
        {
            return ((delegate* unmanaged<ISpRecoGrammar*, SPBINARYGRAMMAR*, SPLOADOPTIONS, int>)(lpVtbl[16]))((ISpRecoGrammar*)Unsafe.AsPointer(ref this), pGrammar, Options);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        [return: NativeTypeName("HRESULT")]
        public int LoadCmdFromProprietaryGrammar([NativeTypeName("const GUID &")] Guid* rguidParam, [NativeTypeName("LPCWSTR")] ushort* pszStringParam, [NativeTypeName("const void *")] void* pvDataPrarm, [NativeTypeName("ULONG")] uint cbDataSize, SPLOADOPTIONS Options)
        {
            return ((delegate* unmanaged<ISpRecoGrammar*, Guid*, ushort*, void*, uint, SPLOADOPTIONS, int>)(lpVtbl[17]))((ISpRecoGrammar*)Unsafe.AsPointer(ref this), rguidParam, pszStringParam, pvDataPrarm, cbDataSize, Options);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        [return: NativeTypeName("HRESULT")]
        public int SetRuleState([NativeTypeName("LPCWSTR")] ushort* pszName, void* pReserved, SPRULESTATE NewState)
        {
            return ((delegate* unmanaged<ISpRecoGrammar*, ushort*, void*, SPRULESTATE, int>)(lpVtbl[18]))((ISpRecoGrammar*)Unsafe.AsPointer(ref this), pszName, pReserved, NewState);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        [return: NativeTypeName("HRESULT")]
        public int SetRuleIdState([NativeTypeName("ULONG")] uint ulRuleId, SPRULESTATE NewState)
        {
            return ((delegate* unmanaged<ISpRecoGrammar*, uint, SPRULESTATE, int>)(lpVtbl[19]))((ISpRecoGrammar*)Unsafe.AsPointer(ref this), ulRuleId, NewState);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        [return: NativeTypeName("HRESULT")]
        public int LoadDictation([NativeTypeName("LPCWSTR")] ushort* pszTopicName, SPLOADOPTIONS Options)
        {
            return ((delegate* unmanaged<ISpRecoGrammar*, ushort*, SPLOADOPTIONS, int>)(lpVtbl[20]))((ISpRecoGrammar*)Unsafe.AsPointer(ref this), pszTopicName, Options);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        [return: NativeTypeName("HRESULT")]
        public int UnloadDictation()
        {
            return ((delegate* unmanaged<ISpRecoGrammar*, int>)(lpVtbl[21]))((ISpRecoGrammar*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(22)]
        [return: NativeTypeName("HRESULT")]
        public int SetDictationState(SPRULESTATE NewState)
        {
            return ((delegate* unmanaged<ISpRecoGrammar*, SPRULESTATE, int>)(lpVtbl[22]))((ISpRecoGrammar*)Unsafe.AsPointer(ref this), NewState);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(23)]
        [return: NativeTypeName("HRESULT")]
        public int SetWordSequenceData([NativeTypeName("const WCHAR *")] ushort* pText, [NativeTypeName("ULONG")] uint cchText, [NativeTypeName("const SPTEXTSELECTIONINFO *")] SPTEXTSELECTIONINFO* pInfo)
        {
            return ((delegate* unmanaged<ISpRecoGrammar*, ushort*, uint, SPTEXTSELECTIONINFO*, int>)(lpVtbl[23]))((ISpRecoGrammar*)Unsafe.AsPointer(ref this), pText, cchText, pInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(24)]
        [return: NativeTypeName("HRESULT")]
        public int SetTextSelection([NativeTypeName("const SPTEXTSELECTIONINFO *")] SPTEXTSELECTIONINFO* pInfo)
        {
            return ((delegate* unmanaged<ISpRecoGrammar*, SPTEXTSELECTIONINFO*, int>)(lpVtbl[24]))((ISpRecoGrammar*)Unsafe.AsPointer(ref this), pInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(25)]
        [return: NativeTypeName("HRESULT")]
        public int IsPronounceable([NativeTypeName("LPCWSTR")] ushort* pszWord, SPWORDPRONOUNCEABLE* pWordPronounceable)
        {
            return ((delegate* unmanaged<ISpRecoGrammar*, ushort*, SPWORDPRONOUNCEABLE*, int>)(lpVtbl[25]))((ISpRecoGrammar*)Unsafe.AsPointer(ref this), pszWord, pWordPronounceable);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(26)]
        [return: NativeTypeName("HRESULT")]
        public int SetGrammarState(SPGRAMMARSTATE eGrammarState)
        {
            return ((delegate* unmanaged<ISpRecoGrammar*, SPGRAMMARSTATE, int>)(lpVtbl[26]))((ISpRecoGrammar*)Unsafe.AsPointer(ref this), eGrammarState);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(27)]
        [return: NativeTypeName("HRESULT")]
        public int SaveCmd(IStream* pStream, [NativeTypeName("LPWSTR *")] ushort** ppszCoMemErrorText)
        {
            return ((delegate* unmanaged<ISpRecoGrammar*, IStream*, ushort**, int>)(lpVtbl[27]))((ISpRecoGrammar*)Unsafe.AsPointer(ref this), pStream, ppszCoMemErrorText);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(28)]
        [return: NativeTypeName("HRESULT")]
        public int GetGrammarState(SPGRAMMARSTATE* peGrammarState)
        {
            return ((delegate* unmanaged<ISpRecoGrammar*, SPGRAMMARSTATE*, int>)(lpVtbl[28]))((ISpRecoGrammar*)Unsafe.AsPointer(ref this), peGrammarState);
        }
    }
}
