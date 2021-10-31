// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfsharingengine.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("1FC55727-A7FB-4FC8-83AE-8AF024990AF1")]
    [NativeTypeName("struct IMFImageSharingEngineClassFactory : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IMFImageSharingEngineClassFactory
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IMFImageSharingEngineClassFactory*, Guid*, void**, int>)(lpVtbl[0]))((IMFImageSharingEngineClassFactory*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMFImageSharingEngineClassFactory*, uint>)(lpVtbl[1]))((IMFImageSharingEngineClassFactory*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMFImageSharingEngineClassFactory*, uint>)(lpVtbl[2]))((IMFImageSharingEngineClassFactory*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT CreateInstanceFromUDN([NativeTypeName("BSTR")] ushort* pUniqueDeviceName, IMFImageSharingEngine** ppEngine)
        {
            return ((delegate* unmanaged<IMFImageSharingEngineClassFactory*, ushort*, IMFImageSharingEngine**, int>)(lpVtbl[3]))((IMFImageSharingEngineClassFactory*)Unsafe.AsPointer(ref this), pUniqueDeviceName, ppEngine);
        }
    }
}
