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
    public unsafe partial struct ISpRecoContext2
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ISpRecoContext2*, Guid*, void**, int>)(lpVtbl[0]))((ISpRecoContext2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ISpRecoContext2*, uint>)(lpVtbl[1]))((ISpRecoContext2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ISpRecoContext2*, uint>)(lpVtbl[2]))((ISpRecoContext2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetGrammarOptions([NativeTypeName("DWORD")] uint eGrammarOptions)
        {
            return ((delegate* unmanaged<ISpRecoContext2*, uint, int>)(lpVtbl[3]))((ISpRecoContext2*)Unsafe.AsPointer(ref this), eGrammarOptions);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetGrammarOptions([NativeTypeName("DWORD *")] uint* peGrammarOptions)
        {
            return ((delegate* unmanaged<ISpRecoContext2*, uint*, int>)(lpVtbl[4]))((ISpRecoContext2*)Unsafe.AsPointer(ref this), peGrammarOptions);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetAdaptationData2([NativeTypeName("LPCWSTR")] ushort* pAdaptationData, [NativeTypeName("const ULONG")] uint cch, [NativeTypeName("LPCWSTR")] ushort* pTopicName, [NativeTypeName("DWORD")] uint eAdaptationSettings, SPADAPTATIONRELEVANCE eRelevance)
        {
            return ((delegate* unmanaged<ISpRecoContext2*, ushort*, uint, ushort*, uint, SPADAPTATIONRELEVANCE, int>)(lpVtbl[5]))((ISpRecoContext2*)Unsafe.AsPointer(ref this), pAdaptationData, cch, pTopicName, eAdaptationSettings, eRelevance);
        }
    }
}
