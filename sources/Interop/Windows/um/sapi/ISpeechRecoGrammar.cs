// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.SpeechLoadOption;

namespace TerraFX.Interop
{
    [Guid("B6D6F79F-2158-4E50-B5BC-9A9CCD852A09")]
    [NativeTypeName("struct ISpeechRecoGrammar : IDispatch")]
    [NativeInheritance("IDispatch")]
    public unsafe partial struct ISpeechRecoGrammar
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ISpeechRecoGrammar*, Guid*, void**, int>)(lpVtbl[0]))((ISpeechRecoGrammar*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ISpeechRecoGrammar*, uint>)(lpVtbl[1]))((ISpeechRecoGrammar*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ISpeechRecoGrammar*, uint>)(lpVtbl[2]))((ISpeechRecoGrammar*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetTypeInfoCount(uint* pctinfo)
        {
            return ((delegate* unmanaged<ISpeechRecoGrammar*, uint*, int>)(lpVtbl[3]))((ISpeechRecoGrammar*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<ISpeechRecoGrammar*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((ISpeechRecoGrammar*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<ISpeechRecoGrammar*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((ISpeechRecoGrammar*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
        {
            return ((delegate* unmanaged<ISpeechRecoGrammar*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((ISpeechRecoGrammar*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT get_Id(VARIANT* Id)
        {
            return ((delegate* unmanaged<ISpeechRecoGrammar*, VARIANT*, int>)(lpVtbl[7]))((ISpeechRecoGrammar*)Unsafe.AsPointer(ref this), Id);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT get_RecoContext(ISpeechRecoContext** RecoContext)
        {
            return ((delegate* unmanaged<ISpeechRecoGrammar*, ISpeechRecoContext**, int>)(lpVtbl[8]))((ISpeechRecoGrammar*)Unsafe.AsPointer(ref this), RecoContext);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT put_State(SpeechGrammarState State)
        {
            return ((delegate* unmanaged<ISpeechRecoGrammar*, SpeechGrammarState, int>)(lpVtbl[9]))((ISpeechRecoGrammar*)Unsafe.AsPointer(ref this), State);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT get_State(SpeechGrammarState* State)
        {
            return ((delegate* unmanaged<ISpeechRecoGrammar*, SpeechGrammarState*, int>)(lpVtbl[10]))((ISpeechRecoGrammar*)Unsafe.AsPointer(ref this), State);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT get_Rules(ISpeechGrammarRules** Rules)
        {
            return ((delegate* unmanaged<ISpeechRecoGrammar*, ISpeechGrammarRules**, int>)(lpVtbl[11]))((ISpeechRecoGrammar*)Unsafe.AsPointer(ref this), Rules);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT Reset([NativeTypeName("SpeechLanguageId")] int NewLanguage = 0)
        {
            return ((delegate* unmanaged<ISpeechRecoGrammar*, int, int>)(lpVtbl[12]))((ISpeechRecoGrammar*)Unsafe.AsPointer(ref this), NewLanguage);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT CmdLoadFromFile([NativeTypeName("const BSTR")] ushort* FileName, SpeechLoadOption LoadOption = SLOStatic)
        {
            return ((delegate* unmanaged<ISpeechRecoGrammar*, ushort*, SpeechLoadOption, int>)(lpVtbl[13]))((ISpeechRecoGrammar*)Unsafe.AsPointer(ref this), FileName, LoadOption);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HRESULT CmdLoadFromObject([NativeTypeName("const BSTR")] ushort* ClassId, [NativeTypeName("const BSTR")] ushort* GrammarName, SpeechLoadOption LoadOption = SLOStatic)
        {
            return ((delegate* unmanaged<ISpeechRecoGrammar*, ushort*, ushort*, SpeechLoadOption, int>)(lpVtbl[14]))((ISpeechRecoGrammar*)Unsafe.AsPointer(ref this), ClassId, GrammarName, LoadOption);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public HRESULT CmdLoadFromResource([NativeTypeName("long")] int hModule, VARIANT ResourceName, VARIANT ResourceType, [NativeTypeName("SpeechLanguageId")] int LanguageId, SpeechLoadOption LoadOption = SLOStatic)
        {
            return ((delegate* unmanaged<ISpeechRecoGrammar*, int, VARIANT, VARIANT, int, SpeechLoadOption, int>)(lpVtbl[15]))((ISpeechRecoGrammar*)Unsafe.AsPointer(ref this), hModule, ResourceName, ResourceType, LanguageId, LoadOption);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        public HRESULT CmdLoadFromMemory(VARIANT GrammarData, SpeechLoadOption LoadOption = SLOStatic)
        {
            return ((delegate* unmanaged<ISpeechRecoGrammar*, VARIANT, SpeechLoadOption, int>)(lpVtbl[16]))((ISpeechRecoGrammar*)Unsafe.AsPointer(ref this), GrammarData, LoadOption);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        public HRESULT CmdLoadFromProprietaryGrammar([NativeTypeName("const BSTR")] ushort* ProprietaryGuid, [NativeTypeName("const BSTR")] ushort* ProprietaryString, VARIANT ProprietaryData, SpeechLoadOption LoadOption = SLOStatic)
        {
            return ((delegate* unmanaged<ISpeechRecoGrammar*, ushort*, ushort*, VARIANT, SpeechLoadOption, int>)(lpVtbl[17]))((ISpeechRecoGrammar*)Unsafe.AsPointer(ref this), ProprietaryGuid, ProprietaryString, ProprietaryData, LoadOption);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        public HRESULT CmdSetRuleState([NativeTypeName("const BSTR")] ushort* Name, SpeechRuleState State)
        {
            return ((delegate* unmanaged<ISpeechRecoGrammar*, ushort*, SpeechRuleState, int>)(lpVtbl[18]))((ISpeechRecoGrammar*)Unsafe.AsPointer(ref this), Name, State);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        public HRESULT CmdSetRuleIdState([NativeTypeName("long")] int RuleId, SpeechRuleState State)
        {
            return ((delegate* unmanaged<ISpeechRecoGrammar*, int, SpeechRuleState, int>)(lpVtbl[19]))((ISpeechRecoGrammar*)Unsafe.AsPointer(ref this), RuleId, State);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        public HRESULT DictationLoad([NativeTypeName("const BSTR")] ushort* TopicName = null, SpeechLoadOption LoadOption = SLOStatic)
        {
            return ((delegate* unmanaged<ISpeechRecoGrammar*, ushort*, SpeechLoadOption, int>)(lpVtbl[20]))((ISpeechRecoGrammar*)Unsafe.AsPointer(ref this), TopicName, LoadOption);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        public HRESULT DictationUnload()
        {
            return ((delegate* unmanaged<ISpeechRecoGrammar*, int>)(lpVtbl[21]))((ISpeechRecoGrammar*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(22)]
        public HRESULT DictationSetState(SpeechRuleState State)
        {
            return ((delegate* unmanaged<ISpeechRecoGrammar*, SpeechRuleState, int>)(lpVtbl[22]))((ISpeechRecoGrammar*)Unsafe.AsPointer(ref this), State);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(23)]
        public HRESULT SetWordSequenceData([NativeTypeName("const BSTR")] ushort* Text, [NativeTypeName("long")] int TextLength, ISpeechTextSelectionInformation* Info)
        {
            return ((delegate* unmanaged<ISpeechRecoGrammar*, ushort*, int, ISpeechTextSelectionInformation*, int>)(lpVtbl[23]))((ISpeechRecoGrammar*)Unsafe.AsPointer(ref this), Text, TextLength, Info);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(24)]
        public HRESULT SetTextSelection(ISpeechTextSelectionInformation* Info)
        {
            return ((delegate* unmanaged<ISpeechRecoGrammar*, ISpeechTextSelectionInformation*, int>)(lpVtbl[24]))((ISpeechRecoGrammar*)Unsafe.AsPointer(ref this), Info);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(25)]
        public HRESULT IsPronounceable([NativeTypeName("const BSTR")] ushort* Word, SpeechWordPronounceable* WordPronounceable)
        {
            return ((delegate* unmanaged<ISpeechRecoGrammar*, ushort*, SpeechWordPronounceable*, int>)(lpVtbl[25]))((ISpeechRecoGrammar*)Unsafe.AsPointer(ref this), Word, WordPronounceable);
        }
    }
}
