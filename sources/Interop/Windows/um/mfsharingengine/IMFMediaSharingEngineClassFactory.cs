// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfsharingengine.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("524D2BC4-B2B1-4FE5-8FAC-FA4E4512B4E0")]
    public unsafe partial struct IMFMediaSharingEngineClassFactory
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IMFMediaSharingEngineClassFactory*, Guid*, void**, int>)(lpVtbl[0]))((IMFMediaSharingEngineClassFactory*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IMFMediaSharingEngineClassFactory*, uint>)(lpVtbl[1]))((IMFMediaSharingEngineClassFactory*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IMFMediaSharingEngineClassFactory*, uint>)(lpVtbl[2]))((IMFMediaSharingEngineClassFactory*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateInstance([NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("IMFAttributes *")] IMFAttributes* pAttr, [NativeTypeName("IMFMediaSharingEngine **")] IMFMediaSharingEngine** ppEngine)
        {
            return ((delegate* stdcall<IMFMediaSharingEngineClassFactory*, uint, IMFAttributes*, IMFMediaSharingEngine**, int>)(lpVtbl[3]))((IMFMediaSharingEngineClassFactory*)Unsafe.AsPointer(ref this), dwFlags, pAttr, ppEngine);
        }
    }
}
