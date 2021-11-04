// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("BEAD311C-52FF-437F-9464-6B21054CA73D")]
    [NativeTypeName("struct ISpRecoContext2 : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct ISpRecoContext2 : ISpRecoContext2.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ISpRecoContext2*, Guid*, void**, int>)(lpVtbl[0]))((ISpRecoContext2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ISpRecoContext2*, uint>)(lpVtbl[1]))((ISpRecoContext2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ISpRecoContext2*, uint>)(lpVtbl[2]))((ISpRecoContext2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT SetGrammarOptions([NativeTypeName("DWORD")] uint eGrammarOptions)
        {
            return ((delegate* unmanaged<ISpRecoContext2*, uint, int>)(lpVtbl[3]))((ISpRecoContext2*)Unsafe.AsPointer(ref this), eGrammarOptions);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetGrammarOptions([NativeTypeName("DWORD *")] uint* peGrammarOptions)
        {
            return ((delegate* unmanaged<ISpRecoContext2*, uint*, int>)(lpVtbl[4]))((ISpRecoContext2*)Unsafe.AsPointer(ref this), peGrammarOptions);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT SetAdaptationData2([NativeTypeName("LPCWSTR")] ushort* pAdaptationData, [NativeTypeName("const ULONG")] uint cch, [NativeTypeName("LPCWSTR")] ushort* pTopicName, [NativeTypeName("DWORD")] uint eAdaptationSettings, SPADAPTATIONRELEVANCE eRelevance)
        {
            return ((delegate* unmanaged<ISpRecoContext2*, ushort*, uint, ushort*, uint, SPADAPTATIONRELEVANCE, int>)(lpVtbl[5]))((ISpRecoContext2*)Unsafe.AsPointer(ref this), pAdaptationData, cch, pTopicName, eAdaptationSettings, eRelevance);
        }

        public interface Interface : IUnknown.Interface
        {
            [VtblIndex(3)]
            HRESULT SetGrammarOptions([NativeTypeName("DWORD")] uint eGrammarOptions);

            [VtblIndex(4)]
            HRESULT GetGrammarOptions([NativeTypeName("DWORD *")] uint* peGrammarOptions);

            [VtblIndex(5)]
            HRESULT SetAdaptationData2([NativeTypeName("LPCWSTR")] ushort* pAdaptationData, [NativeTypeName("const ULONG")] uint cch, [NativeTypeName("LPCWSTR")] ushort* pTopicName, [NativeTypeName("DWORD")] uint eAdaptationSettings, SPADAPTATIONRELEVANCE eRelevance);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpRecoContext2*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ISpRecoContext2*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ISpRecoContext2*, uint> Release;

            [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpRecoContext2*, uint, int> SetGrammarOptions;

            [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpRecoContext2*, uint*, int> GetGrammarOptions;

            [NativeTypeName("HRESULT (LPCWSTR, const ULONG, LPCWSTR, DWORD, SPADAPTATIONRELEVANCE) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpRecoContext2*, ushort*, uint, ushort*, uint, SPADAPTATIONRELEVANCE, int> SetAdaptationData2;
        }
    }
}
