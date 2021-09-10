// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ctffunc.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("4CEA93C0-0A58-11D3-8DF0-00105A2799B5")]
    [NativeTypeName("struct ITfFnReconversion : ITfFunction")]
    [NativeInheritance("ITfFunction")]
    public unsafe partial struct ITfFnReconversion
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ITfFnReconversion*, Guid*, void**, int>)(lpVtbl[0]))((ITfFnReconversion*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ITfFnReconversion*, uint>)(lpVtbl[1]))((ITfFnReconversion*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ITfFnReconversion*, uint>)(lpVtbl[2]))((ITfFnReconversion*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int GetDisplayName([NativeTypeName("BSTR *")] ushort** pbstrName)
        {
            return ((delegate* unmanaged<ITfFnReconversion*, ushort**, int>)(lpVtbl[3]))((ITfFnReconversion*)Unsafe.AsPointer(ref this), pbstrName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int QueryRange(ITfRange* pRange, ITfRange** ppNewRange, [NativeTypeName("BOOL *")] int* pfConvertable)
        {
            return ((delegate* unmanaged<ITfFnReconversion*, ITfRange*, ITfRange**, int*, int>)(lpVtbl[4]))((ITfFnReconversion*)Unsafe.AsPointer(ref this), pRange, ppNewRange, pfConvertable);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int GetReconversion(ITfRange* pRange, ITfCandidateList** ppCandList)
        {
            return ((delegate* unmanaged<ITfFnReconversion*, ITfRange*, ITfCandidateList**, int>)(lpVtbl[5]))((ITfFnReconversion*)Unsafe.AsPointer(ref this), pRange, ppCandList);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int Reconvert(ITfRange* pRange)
        {
            return ((delegate* unmanaged<ITfFnReconversion*, ITfRange*, int>)(lpVtbl[6]))((ITfFnReconversion*)Unsafe.AsPointer(ref this), pRange);
        }
    }
}
