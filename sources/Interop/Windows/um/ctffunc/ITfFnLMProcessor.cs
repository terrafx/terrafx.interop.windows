// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ctffunc.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("7AFBF8E7-AC4B-4082-B058-890899D3A010")]
    [NativeTypeName("struct ITfFnLMProcessor : ITfFunction")]
    [NativeInheritance("ITfFunction")]
    public unsafe partial struct ITfFnLMProcessor
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ITfFnLMProcessor*, Guid*, void**, int>)(lpVtbl[0]))((ITfFnLMProcessor*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ITfFnLMProcessor*, uint>)(lpVtbl[1]))((ITfFnLMProcessor*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ITfFnLMProcessor*, uint>)(lpVtbl[2]))((ITfFnLMProcessor*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetDisplayName([NativeTypeName("BSTR *")] ushort** pbstrName)
        {
            return ((delegate* unmanaged<ITfFnLMProcessor*, ushort**, int>)(lpVtbl[3]))((ITfFnLMProcessor*)Unsafe.AsPointer(ref this), pbstrName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT QueryRange(ITfRange* pRange, ITfRange** ppNewRange, BOOL* pfAccepted)
        {
            return ((delegate* unmanaged<ITfFnLMProcessor*, ITfRange*, ITfRange**, BOOL*, int>)(lpVtbl[4]))((ITfFnLMProcessor*)Unsafe.AsPointer(ref this), pRange, ppNewRange, pfAccepted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT QueryLangID([NativeTypeName("LANGID")] ushort langid, BOOL* pfAccepted)
        {
            return ((delegate* unmanaged<ITfFnLMProcessor*, ushort, BOOL*, int>)(lpVtbl[5]))((ITfFnLMProcessor*)Unsafe.AsPointer(ref this), langid, pfAccepted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT GetReconversion(ITfRange* pRange, ITfCandidateList** ppCandList)
        {
            return ((delegate* unmanaged<ITfFnLMProcessor*, ITfRange*, ITfCandidateList**, int>)(lpVtbl[6]))((ITfFnLMProcessor*)Unsafe.AsPointer(ref this), pRange, ppCandList);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT Reconvert(ITfRange* pRange)
        {
            return ((delegate* unmanaged<ITfFnLMProcessor*, ITfRange*, int>)(lpVtbl[7]))((ITfFnLMProcessor*)Unsafe.AsPointer(ref this), pRange);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT QueryKey(BOOL fUp, WPARAM vKey, LPARAM lparamKeydata, BOOL* pfInterested)
        {
            return ((delegate* unmanaged<ITfFnLMProcessor*, BOOL, WPARAM, LPARAM, BOOL*, int>)(lpVtbl[8]))((ITfFnLMProcessor*)Unsafe.AsPointer(ref this), fUp, vKey, lparamKeydata, pfInterested);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT InvokeKey(BOOL fUp, WPARAM vKey, LPARAM lparamKeyData)
        {
            return ((delegate* unmanaged<ITfFnLMProcessor*, BOOL, WPARAM, LPARAM, int>)(lpVtbl[9]))((ITfFnLMProcessor*)Unsafe.AsPointer(ref this), fUp, vKey, lparamKeyData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT InvokeFunc(ITfContext* pic, [NativeTypeName("const GUID &")] Guid* refguidFunc)
        {
            return ((delegate* unmanaged<ITfFnLMProcessor*, ITfContext*, Guid*, int>)(lpVtbl[10]))((ITfFnLMProcessor*)Unsafe.AsPointer(ref this), pic, refguidFunc);
        }
    }
}
