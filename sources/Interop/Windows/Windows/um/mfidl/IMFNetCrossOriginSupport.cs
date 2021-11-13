// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows
{
    [SupportedOSPlatform("windows10.0")]
    [Guid("BC2B7D44-A72D-49D5-8376-1480DEE58B22")]
    [NativeTypeName("struct IMFNetCrossOriginSupport : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IMFNetCrossOriginSupport : IMFNetCrossOriginSupport.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IMFNetCrossOriginSupport*, Guid*, void**, int>)(lpVtbl[0]))((IMFNetCrossOriginSupport*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMFNetCrossOriginSupport*, uint>)(lpVtbl[1]))((IMFNetCrossOriginSupport*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMFNetCrossOriginSupport*, uint>)(lpVtbl[2]))((IMFNetCrossOriginSupport*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetCrossOriginPolicy(MF_CROSS_ORIGIN_POLICY* pPolicy)
        {
            return ((delegate* unmanaged<IMFNetCrossOriginSupport*, MF_CROSS_ORIGIN_POLICY*, int>)(lpVtbl[3]))((IMFNetCrossOriginSupport*)Unsafe.AsPointer(ref this), pPolicy);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetSourceOrigin([NativeTypeName("LPWSTR *")] ushort** wszSourceOrigin)
        {
            return ((delegate* unmanaged<IMFNetCrossOriginSupport*, ushort**, int>)(lpVtbl[4]))((IMFNetCrossOriginSupport*)Unsafe.AsPointer(ref this), wszSourceOrigin);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT IsSameOrigin([NativeTypeName("LPCWSTR")] ushort* wszURL, BOOL* pfIsSameOrigin)
        {
            return ((delegate* unmanaged<IMFNetCrossOriginSupport*, ushort*, BOOL*, int>)(lpVtbl[5]))((IMFNetCrossOriginSupport*)Unsafe.AsPointer(ref this), wszURL, pfIsSameOrigin);
        }

        public interface Interface : IUnknown.Interface
        {
            [VtblIndex(3)]
            HRESULT GetCrossOriginPolicy(MF_CROSS_ORIGIN_POLICY* pPolicy);

            [VtblIndex(4)]
            HRESULT GetSourceOrigin([NativeTypeName("LPWSTR *")] ushort** wszSourceOrigin);

            [VtblIndex(5)]
            HRESULT IsSameOrigin([NativeTypeName("LPCWSTR")] ushort* wszURL, BOOL* pfIsSameOrigin);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFNetCrossOriginSupport*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IMFNetCrossOriginSupport*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IMFNetCrossOriginSupport*, uint> Release;

            [NativeTypeName("HRESULT (MF_CROSS_ORIGIN_POLICY *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFNetCrossOriginSupport*, MF_CROSS_ORIGIN_POLICY*, int> GetCrossOriginPolicy;

            [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFNetCrossOriginSupport*, ushort**, int> GetSourceOrigin;

            [NativeTypeName("HRESULT (LPCWSTR, BOOL *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFNetCrossOriginSupport*, ushort*, BOOL*, int> IsSameOrigin;
        }
    }
}
