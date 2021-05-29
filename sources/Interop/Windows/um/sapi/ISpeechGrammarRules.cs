// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("6FFA3B44-FC2D-40D1-8AFC-32911C7F1AD1")]
    [NativeTypeName("struct ISpeechGrammarRules : IDispatch")]
    public unsafe partial struct ISpeechGrammarRules
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ISpeechGrammarRules*, Guid*, void**, int>)(lpVtbl[0]))((ISpeechGrammarRules*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ISpeechGrammarRules*, uint>)(lpVtbl[1]))((ISpeechGrammarRules*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ISpeechGrammarRules*, uint>)(lpVtbl[2]))((ISpeechGrammarRules*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfoCount([NativeTypeName("UINT *")] uint* pctinfo)
        {
            return ((delegate* unmanaged<ISpeechGrammarRules*, uint*, int>)(lpVtbl[3]))((ISpeechGrammarRules*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfo([NativeTypeName("UINT")] uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<ISpeechGrammarRules*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((ISpeechGrammarRules*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, [NativeTypeName("UINT")] uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<ISpeechGrammarRules*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((ISpeechGrammarRules*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, [NativeTypeName("UINT *")] uint* puArgErr)
        {
            return ((delegate* unmanaged<ISpeechGrammarRules*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((ISpeechGrammarRules*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Count([NativeTypeName("long *")] int* Count)
        {
            return ((delegate* unmanaged<ISpeechGrammarRules*, int*, int>)(lpVtbl[7]))((ISpeechGrammarRules*)Unsafe.AsPointer(ref this), Count);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int FindRule(VARIANT RuleNameOrId, ISpeechGrammarRule** Rule)
        {
            return ((delegate* unmanaged<ISpeechGrammarRules*, VARIANT, ISpeechGrammarRule**, int>)(lpVtbl[8]))((ISpeechGrammarRules*)Unsafe.AsPointer(ref this), RuleNameOrId, Rule);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Item([NativeTypeName("long")] int Index, ISpeechGrammarRule** Rule)
        {
            return ((delegate* unmanaged<ISpeechGrammarRules*, int, ISpeechGrammarRule**, int>)(lpVtbl[9]))((ISpeechGrammarRules*)Unsafe.AsPointer(ref this), Index, Rule);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get__NewEnum(IUnknown** EnumVARIANT)
        {
            return ((delegate* unmanaged<ISpeechGrammarRules*, IUnknown**, int>)(lpVtbl[10]))((ISpeechGrammarRules*)Unsafe.AsPointer(ref this), EnumVARIANT);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Dynamic([NativeTypeName("VARIANT_BOOL *")] short* Dynamic)
        {
            return ((delegate* unmanaged<ISpeechGrammarRules*, short*, int>)(lpVtbl[11]))((ISpeechGrammarRules*)Unsafe.AsPointer(ref this), Dynamic);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Add([NativeTypeName("BSTR")] ushort* RuleName, SpeechRuleAttributes Attributes, [NativeTypeName("long")] int RuleId, ISpeechGrammarRule** Rule)
        {
            return ((delegate* unmanaged<ISpeechGrammarRules*, ushort*, SpeechRuleAttributes, int, ISpeechGrammarRule**, int>)(lpVtbl[12]))((ISpeechGrammarRules*)Unsafe.AsPointer(ref this), RuleName, Attributes, RuleId, Rule);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Commit()
        {
            return ((delegate* unmanaged<ISpeechGrammarRules*, int>)(lpVtbl[13]))((ISpeechGrammarRules*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CommitAndSave([NativeTypeName("BSTR *")] ushort** ErrorText, VARIANT* SaveStream)
        {
            return ((delegate* unmanaged<ISpeechGrammarRules*, ushort**, VARIANT*, int>)(lpVtbl[14]))((ISpeechGrammarRules*)Unsafe.AsPointer(ref this), ErrorText, SaveStream);
        }
    }
}
