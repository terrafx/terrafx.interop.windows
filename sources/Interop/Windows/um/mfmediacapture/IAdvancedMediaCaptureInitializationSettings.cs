// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfmediacapture.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("3DE21209-8BA6-4F2A-A577-2819B56FF14D")]
    [NativeTypeName("struct IAdvancedMediaCaptureInitializationSettings : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IAdvancedMediaCaptureInitializationSettings
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IAdvancedMediaCaptureInitializationSettings*, Guid*, void**, int>)(lpVtbl[0]))((IAdvancedMediaCaptureInitializationSettings*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IAdvancedMediaCaptureInitializationSettings*, uint>)(lpVtbl[1]))((IAdvancedMediaCaptureInitializationSettings*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IAdvancedMediaCaptureInitializationSettings*, uint>)(lpVtbl[2]))((IAdvancedMediaCaptureInitializationSettings*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT SetDirectxDeviceManager(IMFDXGIDeviceManager* value)
        {
            return ((delegate* unmanaged<IAdvancedMediaCaptureInitializationSettings*, IMFDXGIDeviceManager*, int>)(lpVtbl[3]))((IAdvancedMediaCaptureInitializationSettings*)Unsafe.AsPointer(ref this), value);
        }
    }
}
