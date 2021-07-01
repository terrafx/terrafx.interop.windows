// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ctffunc.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("EA163CE2-7A65-4506-82A3-C528215DA64E")]
    [NativeTypeName("struct ITfFnGetLinguisticAlternates : ITfFunction")]
    public unsafe partial struct ITfFnGetLinguisticAlternates
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ITfFnGetLinguisticAlternates*, Guid*, void**, int>)(lpVtbl[0]))((ITfFnGetLinguisticAlternates*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ITfFnGetLinguisticAlternates*, uint>)(lpVtbl[1]))((ITfFnGetLinguisticAlternates*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ITfFnGetLinguisticAlternates*, uint>)(lpVtbl[2]))((ITfFnGetLinguisticAlternates*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetDisplayName([NativeTypeName("BSTR *")] ushort** pbstrName)
        {
            return ((delegate* unmanaged<ITfFnGetLinguisticAlternates*, ushort**, int>)(lpVtbl[3]))((ITfFnGetLinguisticAlternates*)Unsafe.AsPointer(ref this), pbstrName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetAlternates(ITfRange* pRange, ITfCandidateList** ppCandidateList)
        {
            return ((delegate* unmanaged<ITfFnGetLinguisticAlternates*, ITfRange*, ITfCandidateList**, int>)(lpVtbl[4]))((ITfFnGetLinguisticAlternates*)Unsafe.AsPointer(ref this), pRange, ppCandidateList);
        }
    }
}
