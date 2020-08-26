// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfsharingengine.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("1FC55727-A7FB-4FC8-83AE-8AF024990AF1")]
    [NativeTypeName("struct IMFImageSharingEngineClassFactory : IUnknown")]
    public unsafe partial struct IMFImageSharingEngineClassFactory
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IMFImageSharingEngineClassFactory*, Guid*, void**, int>)(lpVtbl[0]))((IMFImageSharingEngineClassFactory*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IMFImageSharingEngineClassFactory*, uint>)(lpVtbl[1]))((IMFImageSharingEngineClassFactory*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IMFImageSharingEngineClassFactory*, uint>)(lpVtbl[2]))((IMFImageSharingEngineClassFactory*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateInstanceFromUDN([NativeTypeName("BSTR")] ushort* pUniqueDeviceName, [NativeTypeName("IMFImageSharingEngine **")] IMFImageSharingEngine** ppEngine)
        {
            return ((delegate* stdcall<IMFImageSharingEngineClassFactory*, ushort*, IMFImageSharingEngine**, int>)(lpVtbl[3]))((IMFImageSharingEngineClassFactory*)Unsafe.AsPointer(ref this), pUniqueDeviceName, ppEngine);
        }
    }
}
