// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfmediacapture.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("24E0485F-A33E-4AA1-B564-6019B1D14F65")]
    public unsafe partial struct IAdvancedMediaCaptureSettings
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IAdvancedMediaCaptureSettings*, Guid*, void**, int>)(lpVtbl[0]))((IAdvancedMediaCaptureSettings*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IAdvancedMediaCaptureSettings*, uint>)(lpVtbl[1]))((IAdvancedMediaCaptureSettings*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IAdvancedMediaCaptureSettings*, uint>)(lpVtbl[2]))((IAdvancedMediaCaptureSettings*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDirectxDeviceManager([NativeTypeName("IMFDXGIDeviceManager **")] IMFDXGIDeviceManager** value)
        {
            return ((delegate* stdcall<IAdvancedMediaCaptureSettings*, IMFDXGIDeviceManager**, int>)(lpVtbl[3]))((IAdvancedMediaCaptureSettings*)Unsafe.AsPointer(ref this), value);
        }
    }
}
