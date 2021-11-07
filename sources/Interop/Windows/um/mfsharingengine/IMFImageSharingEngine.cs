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
    [Guid("CFA0AE8E-7E1C-44D2-AE68-FC4C148A6354")]
    [NativeTypeName("struct IMFImageSharingEngine : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IMFImageSharingEngine : IMFImageSharingEngine.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
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
        public HRESULT SetSource(IUnknown* pStream)
        {
            return ((delegate* unmanaged<IMFImageSharingEngine*, IUnknown*, int>)(lpVtbl[3]))((IMFImageSharingEngine*)Unsafe.AsPointer(ref this), pStream);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetDevice(DEVICE_INFO* pDevice)
        {
            return ((delegate* unmanaged<IMFImageSharingEngine*, DEVICE_INFO*, int>)(lpVtbl[4]))((IMFImageSharingEngine*)Unsafe.AsPointer(ref this), pDevice);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT Shutdown()
        {
            return ((delegate* unmanaged<IMFImageSharingEngine*, int>)(lpVtbl[5]))((IMFImageSharingEngine*)Unsafe.AsPointer(ref this));
        }

        public interface Interface : IUnknown.Interface
        {
            [VtblIndex(3)]
            HRESULT SetSource(IUnknown* pStream);

            [VtblIndex(4)]
            HRESULT GetDevice(DEVICE_INFO* pDevice);

            [VtblIndex(5)]
            HRESULT Shutdown();
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFImageSharingEngine*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IMFImageSharingEngine*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IMFImageSharingEngine*, uint> Release;

            [NativeTypeName("HRESULT (IUnknown *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFImageSharingEngine*, IUnknown*, int> SetSource;

            [NativeTypeName("HRESULT (DEVICE_INFO *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFImageSharingEngine*, DEVICE_INFO*, int> GetDevice;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<IMFImageSharingEngine*, int> Shutdown;
        }
    }
}
