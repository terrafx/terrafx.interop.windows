// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfsharingengine.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace TerraFX.Interop
{
    [SupportedOSPlatform("windows8.0")]
    [Guid("524D2BC4-B2B1-4FE5-8FAC-FA4E4512B4E0")]
    [NativeTypeName("struct IMFMediaSharingEngineClassFactory : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IMFMediaSharingEngineClassFactory : IMFMediaSharingEngineClassFactory.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IMFMediaSharingEngineClassFactory*, Guid*, void**, int>)(lpVtbl[0]))((IMFMediaSharingEngineClassFactory*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMFMediaSharingEngineClassFactory*, uint>)(lpVtbl[1]))((IMFMediaSharingEngineClassFactory*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMFMediaSharingEngineClassFactory*, uint>)(lpVtbl[2]))((IMFMediaSharingEngineClassFactory*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT CreateInstance([NativeTypeName("DWORD")] uint dwFlags, IMFAttributes* pAttr, IMFMediaSharingEngine** ppEngine)
        {
            return ((delegate* unmanaged<IMFMediaSharingEngineClassFactory*, uint, IMFAttributes*, IMFMediaSharingEngine**, int>)(lpVtbl[3]))((IMFMediaSharingEngineClassFactory*)Unsafe.AsPointer(ref this), dwFlags, pAttr, ppEngine);
        }

        public interface Interface : IUnknown.Interface
        {
            [VtblIndex(3)]
            HRESULT CreateInstance([NativeTypeName("DWORD")] uint dwFlags, IMFAttributes* pAttr, IMFMediaSharingEngine** ppEngine);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFMediaSharingEngineClassFactory*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IMFMediaSharingEngineClassFactory*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IMFMediaSharingEngineClassFactory*, uint> Release;

            [NativeTypeName("HRESULT (DWORD, IMFAttributes *, IMFMediaSharingEngine **) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFMediaSharingEngineClassFactory*, uint, IMFAttributes*, IMFMediaSharingEngine**, int> CreateInstance;
        }
    }
}
