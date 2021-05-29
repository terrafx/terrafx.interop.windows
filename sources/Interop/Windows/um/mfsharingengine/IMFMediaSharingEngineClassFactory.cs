// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfsharingengine.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("524D2BC4-B2B1-4FE5-8FAC-FA4E4512B4E0")]
    [NativeTypeName("struct IMFMediaSharingEngineClassFactory : IUnknown")]
    public unsafe partial struct IMFMediaSharingEngineClassFactory
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IMFMediaSharingEngineClassFactory*, Guid*, void**, int>)(lpVtbl[0]))((IMFMediaSharingEngineClassFactory*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMFMediaSharingEngineClassFactory*, uint>)(lpVtbl[1]))((IMFMediaSharingEngineClassFactory*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMFMediaSharingEngineClassFactory*, uint>)(lpVtbl[2]))((IMFMediaSharingEngineClassFactory*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateInstance([NativeTypeName("DWORD")] uint dwFlags, IMFAttributes* pAttr, IMFMediaSharingEngine** ppEngine)
        {
            return ((delegate* unmanaged<IMFMediaSharingEngineClassFactory*, uint, IMFAttributes*, IMFMediaSharingEngine**, int>)(lpVtbl[3]))((IMFMediaSharingEngineClassFactory*)Unsafe.AsPointer(ref this), dwFlags, pAttr, ppEngine);
        }
    }
}
