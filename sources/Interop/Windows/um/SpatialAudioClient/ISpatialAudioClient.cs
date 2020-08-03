// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SpatialAudioClient.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("BBF8E066-AAAA-49BE-9A4D-FD2A858EA27F")]
    public unsafe partial struct ISpatialAudioClient
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<ISpatialAudioClient*, Guid*, void**, int>)(lpVtbl[0]))((ISpatialAudioClient*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<ISpatialAudioClient*, uint>)(lpVtbl[1]))((ISpatialAudioClient*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<ISpatialAudioClient*, uint>)(lpVtbl[2]))((ISpatialAudioClient*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetStaticObjectPosition(AudioObjectType type, [NativeTypeName("float *")] float* x, [NativeTypeName("float *")] float* y, [NativeTypeName("float *")] float* z)
        {
            return ((delegate* stdcall<ISpatialAudioClient*, AudioObjectType, float*, float*, float*, int>)(lpVtbl[3]))((ISpatialAudioClient*)Unsafe.AsPointer(ref this), type, x, y, z);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetNativeStaticObjectTypeMask([NativeTypeName("AudioObjectType *")] AudioObjectType* mask)
        {
            return ((delegate* stdcall<ISpatialAudioClient*, AudioObjectType*, int>)(lpVtbl[4]))((ISpatialAudioClient*)Unsafe.AsPointer(ref this), mask);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetMaxDynamicObjectCount([NativeTypeName("UINT32 *")] uint* value)
        {
            return ((delegate* stdcall<ISpatialAudioClient*, uint*, int>)(lpVtbl[5]))((ISpatialAudioClient*)Unsafe.AsPointer(ref this), value);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetSupportedAudioObjectFormatEnumerator([NativeTypeName("IAudioFormatEnumerator **")] IAudioFormatEnumerator** enumerator)
        {
            return ((delegate* stdcall<ISpatialAudioClient*, IAudioFormatEnumerator**, int>)(lpVtbl[6]))((ISpatialAudioClient*)Unsafe.AsPointer(ref this), enumerator);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetMaxFrameCount([NativeTypeName("const WAVEFORMATEX *")] WAVEFORMATEX* objectFormat, [NativeTypeName("UINT32 *")] uint* frameCountPerBuffer)
        {
            return ((delegate* stdcall<ISpatialAudioClient*, WAVEFORMATEX*, uint*, int>)(lpVtbl[7]))((ISpatialAudioClient*)Unsafe.AsPointer(ref this), objectFormat, frameCountPerBuffer);
        }

        [return: NativeTypeName("HRESULT")]
        public int IsAudioObjectFormatSupported([NativeTypeName("const WAVEFORMATEX *")] WAVEFORMATEX* objectFormat)
        {
            return ((delegate* stdcall<ISpatialAudioClient*, WAVEFORMATEX*, int>)(lpVtbl[8]))((ISpatialAudioClient*)Unsafe.AsPointer(ref this), objectFormat);
        }

        [return: NativeTypeName("HRESULT")]
        public int IsSpatialAudioStreamAvailable([NativeTypeName("const IID &")] Guid* streamUuid, [NativeTypeName("const PROPVARIANT *")] PROPVARIANT* auxiliaryInfo)
        {
            return ((delegate* stdcall<ISpatialAudioClient*, Guid*, PROPVARIANT*, int>)(lpVtbl[9]))((ISpatialAudioClient*)Unsafe.AsPointer(ref this), streamUuid, auxiliaryInfo);
        }

        [return: NativeTypeName("HRESULT")]
        public int ActivateSpatialAudioStream([NativeTypeName("const PROPVARIANT *")] PROPVARIANT* activationParams, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** stream)
        {
            return ((delegate* stdcall<ISpatialAudioClient*, PROPVARIANT*, Guid*, void**, int>)(lpVtbl[10]))((ISpatialAudioClient*)Unsafe.AsPointer(ref this), activationParams, riid, stream);
        }
    }
}
