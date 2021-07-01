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
    public unsafe partial struct ITfFnLMProcessor
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ITfFnLMProcessor*, Guid*, void**, int>)(lpVtbl[0]))((ITfFnLMProcessor*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ITfFnLMProcessor*, uint>)(lpVtbl[1]))((ITfFnLMProcessor*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ITfFnLMProcessor*, uint>)(lpVtbl[2]))((ITfFnLMProcessor*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetDisplayName([NativeTypeName("BSTR *")] ushort** pbstrName)
        {
            return ((delegate* unmanaged<ITfFnLMProcessor*, ushort**, int>)(lpVtbl[3]))((ITfFnLMProcessor*)Unsafe.AsPointer(ref this), pbstrName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryRange(ITfRange* pRange, ITfRange** ppNewRange, [NativeTypeName("BOOL *")] int* pfAccepted)
        {
            return ((delegate* unmanaged<ITfFnLMProcessor*, ITfRange*, ITfRange**, int*, int>)(lpVtbl[4]))((ITfFnLMProcessor*)Unsafe.AsPointer(ref this), pRange, ppNewRange, pfAccepted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryLangID([NativeTypeName("LANGID")] ushort langid, [NativeTypeName("BOOL *")] int* pfAccepted)
        {
            return ((delegate* unmanaged<ITfFnLMProcessor*, ushort, int*, int>)(lpVtbl[5]))((ITfFnLMProcessor*)Unsafe.AsPointer(ref this), langid, pfAccepted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetReconversion(ITfRange* pRange, ITfCandidateList** ppCandList)
        {
            return ((delegate* unmanaged<ITfFnLMProcessor*, ITfRange*, ITfCandidateList**, int>)(lpVtbl[6]))((ITfFnLMProcessor*)Unsafe.AsPointer(ref this), pRange, ppCandList);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Reconvert(ITfRange* pRange)
        {
            return ((delegate* unmanaged<ITfFnLMProcessor*, ITfRange*, int>)(lpVtbl[7]))((ITfFnLMProcessor*)Unsafe.AsPointer(ref this), pRange);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryKey([NativeTypeName("BOOL")] int fUp, [NativeTypeName("WPARAM")] nuint vKey, [NativeTypeName("LPARAM")] nint lparamKeydata, [NativeTypeName("BOOL *")] int* pfInterested)
        {
            return ((delegate* unmanaged<ITfFnLMProcessor*, int, nuint, nint, int*, int>)(lpVtbl[8]))((ITfFnLMProcessor*)Unsafe.AsPointer(ref this), fUp, vKey, lparamKeydata, pfInterested);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int InvokeKey([NativeTypeName("BOOL")] int fUp, [NativeTypeName("WPARAM")] nuint vKey, [NativeTypeName("LPARAM")] nint lparamKeyData)
        {
            return ((delegate* unmanaged<ITfFnLMProcessor*, int, nuint, nint, int>)(lpVtbl[9]))((ITfFnLMProcessor*)Unsafe.AsPointer(ref this), fUp, vKey, lparamKeyData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int InvokeFunc(ITfContext* pic, [NativeTypeName("const GUID &")] Guid* refguidFunc)
        {
            return ((delegate* unmanaged<ITfFnLMProcessor*, ITfContext*, Guid*, int>)(lpVtbl[10]))((ITfFnLMProcessor*)Unsafe.AsPointer(ref this), pic, refguidFunc);
        }
    }
}
