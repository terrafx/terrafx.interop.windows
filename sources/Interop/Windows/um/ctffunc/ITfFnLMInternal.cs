// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ctffunc.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("04B825B1-AC9A-4F7B-B5AD-C7168F1EE445")]
    [NativeTypeName("struct ITfFnLMInternal : ITfFnLMProcessor")]
    public unsafe partial struct ITfFnLMInternal
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ITfFnLMInternal*, Guid*, void**, int>)(lpVtbl[0]))((ITfFnLMInternal*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ITfFnLMInternal*, uint>)(lpVtbl[1]))((ITfFnLMInternal*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ITfFnLMInternal*, uint>)(lpVtbl[2]))((ITfFnLMInternal*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetDisplayName([NativeTypeName("BSTR *")] ushort** pbstrName)
        {
            return ((delegate* unmanaged<ITfFnLMInternal*, ushort**, int>)(lpVtbl[3]))((ITfFnLMInternal*)Unsafe.AsPointer(ref this), pbstrName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryRange(ITfRange* pRange, ITfRange** ppNewRange, [NativeTypeName("BOOL *")] int* pfAccepted)
        {
            return ((delegate* unmanaged<ITfFnLMInternal*, ITfRange*, ITfRange**, int*, int>)(lpVtbl[4]))((ITfFnLMInternal*)Unsafe.AsPointer(ref this), pRange, ppNewRange, pfAccepted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryLangID([NativeTypeName("LANGID")] ushort langid, [NativeTypeName("BOOL *")] int* pfAccepted)
        {
            return ((delegate* unmanaged<ITfFnLMInternal*, ushort, int*, int>)(lpVtbl[5]))((ITfFnLMInternal*)Unsafe.AsPointer(ref this), langid, pfAccepted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetReconversion(ITfRange* pRange, ITfCandidateList** ppCandList)
        {
            return ((delegate* unmanaged<ITfFnLMInternal*, ITfRange*, ITfCandidateList**, int>)(lpVtbl[6]))((ITfFnLMInternal*)Unsafe.AsPointer(ref this), pRange, ppCandList);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Reconvert(ITfRange* pRange)
        {
            return ((delegate* unmanaged<ITfFnLMInternal*, ITfRange*, int>)(lpVtbl[7]))((ITfFnLMInternal*)Unsafe.AsPointer(ref this), pRange);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryKey([NativeTypeName("BOOL")] int fUp, [NativeTypeName("WPARAM")] nuint vKey, [NativeTypeName("LPARAM")] nint lparamKeydata, [NativeTypeName("BOOL *")] int* pfInterested)
        {
            return ((delegate* unmanaged<ITfFnLMInternal*, int, nuint, nint, int*, int>)(lpVtbl[8]))((ITfFnLMInternal*)Unsafe.AsPointer(ref this), fUp, vKey, lparamKeydata, pfInterested);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int InvokeKey([NativeTypeName("BOOL")] int fUp, [NativeTypeName("WPARAM")] nuint vKey, [NativeTypeName("LPARAM")] nint lparamKeyData)
        {
            return ((delegate* unmanaged<ITfFnLMInternal*, int, nuint, nint, int>)(lpVtbl[9]))((ITfFnLMInternal*)Unsafe.AsPointer(ref this), fUp, vKey, lparamKeyData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int InvokeFunc(ITfContext* pic, [NativeTypeName("const GUID &")] Guid* refguidFunc)
        {
            return ((delegate* unmanaged<ITfFnLMInternal*, ITfContext*, Guid*, int>)(lpVtbl[10]))((ITfFnLMInternal*)Unsafe.AsPointer(ref this), pic, refguidFunc);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ProcessLattice(ITfRange* pRange)
        {
            return ((delegate* unmanaged<ITfFnLMInternal*, ITfRange*, int>)(lpVtbl[11]))((ITfFnLMInternal*)Unsafe.AsPointer(ref this), pRange);
        }
    }
}
