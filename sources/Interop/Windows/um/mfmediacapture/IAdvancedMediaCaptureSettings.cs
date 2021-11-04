// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfmediacapture.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("24E0485F-A33E-4AA1-B564-6019B1D14F65")]
    [NativeTypeName("struct IAdvancedMediaCaptureSettings : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IAdvancedMediaCaptureSettings
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IAdvancedMediaCaptureSettings*, Guid*, void**, int>)(lpVtbl[0]))((IAdvancedMediaCaptureSettings*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IAdvancedMediaCaptureSettings*, uint>)(lpVtbl[1]))((IAdvancedMediaCaptureSettings*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IAdvancedMediaCaptureSettings*, uint>)(lpVtbl[2]))((IAdvancedMediaCaptureSettings*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetDirectxDeviceManager(IMFDXGIDeviceManager** value)
        {
            return ((delegate* unmanaged<IAdvancedMediaCaptureSettings*, IMFDXGIDeviceManager**, int>)(lpVtbl[3]))((IAdvancedMediaCaptureSettings*)Unsafe.AsPointer(ref this), value);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IAdvancedMediaCaptureSettings*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IAdvancedMediaCaptureSettings*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IAdvancedMediaCaptureSettings*, uint> Release;

            [NativeTypeName("HRESULT (IMFDXGIDeviceManager **) __attribute__((stdcall))")]
            public delegate* unmanaged<IAdvancedMediaCaptureSettings*, IMFDXGIDeviceManager**, int> GetDirectxDeviceManager;
        }
    }
}
