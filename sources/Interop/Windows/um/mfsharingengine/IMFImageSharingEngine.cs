// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfsharingengine.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("CFA0AE8E-7E1C-44D2-AE68-FC4C148A6354")]
    [NativeTypeName("struct IMFImageSharingEngine : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IMFImageSharingEngine
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IMFImageSharingEngine*, Guid*, void**, int>)(lpVtbl[0]))((IMFImageSharingEngine*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMFImageSharingEngine*, uint>)(lpVtbl[1]))((IMFImageSharingEngine*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMFImageSharingEngine*, uint>)(lpVtbl[2]))((IMFImageSharingEngine*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int SetSource(IUnknown* pStream)
        {
            return ((delegate* unmanaged<IMFImageSharingEngine*, IUnknown*, int>)(lpVtbl[3]))((IMFImageSharingEngine*)Unsafe.AsPointer(ref this), pStream);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int GetDevice(DEVICE_INFO* pDevice)
        {
            return ((delegate* unmanaged<IMFImageSharingEngine*, DEVICE_INFO*, int>)(lpVtbl[4]))((IMFImageSharingEngine*)Unsafe.AsPointer(ref this), pDevice);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int Shutdown()
        {
            return ((delegate* unmanaged<IMFImageSharingEngine*, int>)(lpVtbl[5]))((IMFImageSharingEngine*)Unsafe.AsPointer(ref this));
        }
    }
}
