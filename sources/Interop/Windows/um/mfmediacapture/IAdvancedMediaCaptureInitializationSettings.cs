// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfmediacapture.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("3DE21209-8BA6-4F2A-A577-2819B56FF14D")]
    public unsafe partial struct IAdvancedMediaCaptureInitializationSettings
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IAdvancedMediaCaptureInitializationSettings*, Guid*, void**, int>)(lpVtbl[0]))((IAdvancedMediaCaptureInitializationSettings*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IAdvancedMediaCaptureInitializationSettings*, uint>)(lpVtbl[1]))((IAdvancedMediaCaptureInitializationSettings*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IAdvancedMediaCaptureInitializationSettings*, uint>)(lpVtbl[2]))((IAdvancedMediaCaptureInitializationSettings*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetDirectxDeviceManager([NativeTypeName("IMFDXGIDeviceManager *")] IMFDXGIDeviceManager* value)
        {
            return ((delegate* stdcall<IAdvancedMediaCaptureInitializationSettings*, IMFDXGIDeviceManager*, int>)(lpVtbl[3]))((IAdvancedMediaCaptureInitializationSettings*)Unsafe.AsPointer(ref this), value);
        }
    }
}
