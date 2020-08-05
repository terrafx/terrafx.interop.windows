// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SpatialAudioClient.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("BAB5F473-B423-477B-85F5-B5A332A04153")]
    [NativeTypeName("struct ISpatialAudioObjectRenderStream : ISpatialAudioObjectRenderStreamBase")]
    public unsafe partial struct ISpatialAudioObjectRenderStream
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<ISpatialAudioObjectRenderStream*, Guid*, void**, int>)(lpVtbl[0]))((ISpatialAudioObjectRenderStream*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<ISpatialAudioObjectRenderStream*, uint>)(lpVtbl[1]))((ISpatialAudioObjectRenderStream*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<ISpatialAudioObjectRenderStream*, uint>)(lpVtbl[2]))((ISpatialAudioObjectRenderStream*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetAvailableDynamicObjectCount([NativeTypeName("UINT32 *")] uint* value)
        {
            return ((delegate* stdcall<ISpatialAudioObjectRenderStream*, uint*, int>)(lpVtbl[3]))((ISpatialAudioObjectRenderStream*)Unsafe.AsPointer(ref this), value);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetService([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** service)
        {
            return ((delegate* stdcall<ISpatialAudioObjectRenderStream*, Guid*, void**, int>)(lpVtbl[4]))((ISpatialAudioObjectRenderStream*)Unsafe.AsPointer(ref this), riid, service);
        }

        [return: NativeTypeName("HRESULT")]
        public int Start()
        {
            return ((delegate* stdcall<ISpatialAudioObjectRenderStream*, int>)(lpVtbl[5]))((ISpatialAudioObjectRenderStream*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Stop()
        {
            return ((delegate* stdcall<ISpatialAudioObjectRenderStream*, int>)(lpVtbl[6]))((ISpatialAudioObjectRenderStream*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Reset()
        {
            return ((delegate* stdcall<ISpatialAudioObjectRenderStream*, int>)(lpVtbl[7]))((ISpatialAudioObjectRenderStream*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int BeginUpdatingAudioObjects([NativeTypeName("UINT32 *")] uint* availableDynamicObjectCount, [NativeTypeName("UINT32 *")] uint* frameCountPerBuffer)
        {
            return ((delegate* stdcall<ISpatialAudioObjectRenderStream*, uint*, uint*, int>)(lpVtbl[8]))((ISpatialAudioObjectRenderStream*)Unsafe.AsPointer(ref this), availableDynamicObjectCount, frameCountPerBuffer);
        }

        [return: NativeTypeName("HRESULT")]
        public int EndUpdatingAudioObjects()
        {
            return ((delegate* stdcall<ISpatialAudioObjectRenderStream*, int>)(lpVtbl[9]))((ISpatialAudioObjectRenderStream*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int ActivateSpatialAudioObject(AudioObjectType type, [NativeTypeName("ISpatialAudioObject **")] ISpatialAudioObject** audioObject)
        {
            return ((delegate* stdcall<ISpatialAudioObjectRenderStream*, AudioObjectType, ISpatialAudioObject**, int>)(lpVtbl[10]))((ISpatialAudioObjectRenderStream*)Unsafe.AsPointer(ref this), type, audioObject);
        }
    }
}
