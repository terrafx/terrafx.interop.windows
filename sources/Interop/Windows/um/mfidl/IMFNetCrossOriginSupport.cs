// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("BC2B7D44-A72D-49D5-8376-1480DEE58B22")]
    [NativeTypeName("struct IMFNetCrossOriginSupport : IUnknown")]
    public unsafe partial struct IMFNetCrossOriginSupport
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IMFNetCrossOriginSupport*, Guid*, void**, int>)(lpVtbl[0]))((IMFNetCrossOriginSupport*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMFNetCrossOriginSupport*, uint>)(lpVtbl[1]))((IMFNetCrossOriginSupport*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMFNetCrossOriginSupport*, uint>)(lpVtbl[2]))((IMFNetCrossOriginSupport*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetCrossOriginPolicy(MF_CROSS_ORIGIN_POLICY* pPolicy)
        {
            return ((delegate* unmanaged<IMFNetCrossOriginSupport*, MF_CROSS_ORIGIN_POLICY*, int>)(lpVtbl[3]))((IMFNetCrossOriginSupport*)Unsafe.AsPointer(ref this), pPolicy);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetSourceOrigin([NativeTypeName("LPWSTR *")] ushort** wszSourceOrigin)
        {
            return ((delegate* unmanaged<IMFNetCrossOriginSupport*, ushort**, int>)(lpVtbl[4]))((IMFNetCrossOriginSupport*)Unsafe.AsPointer(ref this), wszSourceOrigin);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int IsSameOrigin([NativeTypeName("LPCWSTR")] ushort* wszURL, [NativeTypeName("BOOL *")] int* pfIsSameOrigin)
        {
            return ((delegate* unmanaged<IMFNetCrossOriginSupport*, ushort*, int*, int>)(lpVtbl[5]))((IMFNetCrossOriginSupport*)Unsafe.AsPointer(ref this), wszURL, pfIsSameOrigin);
        }
    }
}
