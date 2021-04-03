// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ctffunc.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("87A2AD8F-F27B-4920-8501-67602280175D")]
    [NativeTypeName("struct ITfFnSearchCandidateProvider : ITfFunction")]
    public unsafe partial struct ITfFnSearchCandidateProvider
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ITfFnSearchCandidateProvider*, Guid*, void**, int>)(lpVtbl[0]))((ITfFnSearchCandidateProvider*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ITfFnSearchCandidateProvider*, uint>)(lpVtbl[1]))((ITfFnSearchCandidateProvider*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ITfFnSearchCandidateProvider*, uint>)(lpVtbl[2]))((ITfFnSearchCandidateProvider*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetDisplayName([NativeTypeName("BSTR *")] ushort** pbstrName)
        {
            return ((delegate* unmanaged<ITfFnSearchCandidateProvider*, ushort**, int>)(lpVtbl[3]))((ITfFnSearchCandidateProvider*)Unsafe.AsPointer(ref this), pbstrName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetSearchCandidates([NativeTypeName("BSTR")] ushort* bstrQuery, [NativeTypeName("BSTR")] ushort* bstrApplicationId, ITfCandidateList** pplist)
        {
            return ((delegate* unmanaged<ITfFnSearchCandidateProvider*, ushort*, ushort*, ITfCandidateList**, int>)(lpVtbl[4]))((ITfFnSearchCandidateProvider*)Unsafe.AsPointer(ref this), bstrQuery, bstrApplicationId, pplist);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetResult([NativeTypeName("BSTR")] ushort* bstrQuery, [NativeTypeName("BSTR")] ushort* bstrApplicationID, [NativeTypeName("BSTR")] ushort* bstrResult)
        {
            return ((delegate* unmanaged<ITfFnSearchCandidateProvider*, ushort*, ushort*, ushort*, int>)(lpVtbl[5]))((ITfFnSearchCandidateProvider*)Unsafe.AsPointer(ref this), bstrQuery, bstrApplicationID, bstrResult);
        }
    }
}
