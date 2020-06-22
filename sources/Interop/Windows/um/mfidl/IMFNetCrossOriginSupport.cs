// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("BC2B7D44-A72D-49D5-8376-1480DEE58B22")]
    public unsafe partial struct IMFNetCrossOriginSupport
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IMFNetCrossOriginSupport*, Guid*, void**, int>)(lpVtbl[0]))((IMFNetCrossOriginSupport*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IMFNetCrossOriginSupport*, uint>)(lpVtbl[1]))((IMFNetCrossOriginSupport*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IMFNetCrossOriginSupport*, uint>)(lpVtbl[2]))((IMFNetCrossOriginSupport*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetCrossOriginPolicy([NativeTypeName("MF_CROSS_ORIGIN_POLICY *")] MF_CROSS_ORIGIN_POLICY* pPolicy)
        {
            return ((delegate* stdcall<IMFNetCrossOriginSupport*, MF_CROSS_ORIGIN_POLICY*, int>)(lpVtbl[3]))((IMFNetCrossOriginSupport*)Unsafe.AsPointer(ref this), pPolicy);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetSourceOrigin([NativeTypeName("LPWSTR *")] ushort** wszSourceOrigin)
        {
            return ((delegate* stdcall<IMFNetCrossOriginSupport*, ushort**, int>)(lpVtbl[4]))((IMFNetCrossOriginSupport*)Unsafe.AsPointer(ref this), wszSourceOrigin);
        }

        [return: NativeTypeName("HRESULT")]
        public int IsSameOrigin([NativeTypeName("LPCWSTR")] ushort* wszURL, [NativeTypeName("BOOL *")] int* pfIsSameOrigin)
        {
            return ((delegate* stdcall<IMFNetCrossOriginSupport*, ushort*, int*, int>)(lpVtbl[5]))((IMFNetCrossOriginSupport*)Unsafe.AsPointer(ref this), wszURL, pfIsSameOrigin);
        }
    }
}
