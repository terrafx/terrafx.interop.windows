// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SpatialAudioClient.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("BBF8E066-AAAA-49BE-9A4D-FD2A858EA27F")]
    [NativeTypeName("struct ISpatialAudioClient : IUnknown")]
    public unsafe partial struct ISpatialAudioClient
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ISpatialAudioClient*, Guid*, void**, int>)(lpVtbl[0]))((ISpatialAudioClient*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ISpatialAudioClient*, uint>)(lpVtbl[1]))((ISpatialAudioClient*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ISpatialAudioClient*, uint>)(lpVtbl[2]))((ISpatialAudioClient*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetStaticObjectPosition(AudioObjectType type, float* x, float* y, float* z)
        {
            return ((delegate* unmanaged<ISpatialAudioClient*, AudioObjectType, float*, float*, float*, int>)(lpVtbl[3]))((ISpatialAudioClient*)Unsafe.AsPointer(ref this), type, x, y, z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetNativeStaticObjectTypeMask(AudioObjectType* mask)
        {
            return ((delegate* unmanaged<ISpatialAudioClient*, AudioObjectType*, int>)(lpVtbl[4]))((ISpatialAudioClient*)Unsafe.AsPointer(ref this), mask);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetMaxDynamicObjectCount([NativeTypeName("UINT32 *")] uint* value)
        {
            return ((delegate* unmanaged<ISpatialAudioClient*, uint*, int>)(lpVtbl[5]))((ISpatialAudioClient*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetSupportedAudioObjectFormatEnumerator(IAudioFormatEnumerator** enumerator)
        {
            return ((delegate* unmanaged<ISpatialAudioClient*, IAudioFormatEnumerator**, int>)(lpVtbl[6]))((ISpatialAudioClient*)Unsafe.AsPointer(ref this), enumerator);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetMaxFrameCount([NativeTypeName("const WAVEFORMATEX *")] WAVEFORMATEX* objectFormat, [NativeTypeName("UINT32 *")] uint* frameCountPerBuffer)
        {
            return ((delegate* unmanaged<ISpatialAudioClient*, WAVEFORMATEX*, uint*, int>)(lpVtbl[7]))((ISpatialAudioClient*)Unsafe.AsPointer(ref this), objectFormat, frameCountPerBuffer);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int IsAudioObjectFormatSupported([NativeTypeName("const WAVEFORMATEX *")] WAVEFORMATEX* objectFormat)
        {
            return ((delegate* unmanaged<ISpatialAudioClient*, WAVEFORMATEX*, int>)(lpVtbl[8]))((ISpatialAudioClient*)Unsafe.AsPointer(ref this), objectFormat);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int IsSpatialAudioStreamAvailable([NativeTypeName("const IID &")] Guid* streamUuid, [NativeTypeName("const PROPVARIANT *")] PROPVARIANT* auxiliaryInfo)
        {
            return ((delegate* unmanaged<ISpatialAudioClient*, Guid*, PROPVARIANT*, int>)(lpVtbl[9]))((ISpatialAudioClient*)Unsafe.AsPointer(ref this), streamUuid, auxiliaryInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ActivateSpatialAudioStream([NativeTypeName("const PROPVARIANT *")] PROPVARIANT* activationParams, [NativeTypeName("const IID &")] Guid* riid, void** stream)
        {
            return ((delegate* unmanaged<ISpatialAudioClient*, PROPVARIANT*, Guid*, void**, int>)(lpVtbl[10]))((ISpatialAudioClient*)Unsafe.AsPointer(ref this), activationParams, riid, stream);
        }
    }
}
