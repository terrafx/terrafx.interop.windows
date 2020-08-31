// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SpatialAudioHrtf.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("E08DEEF9-5363-406E-9FDC-080EE247BBE0")]
    [NativeTypeName("struct ISpatialAudioObjectRenderStreamForHrtf : ISpatialAudioObjectRenderStreamBase")]
    public unsafe partial struct ISpatialAudioObjectRenderStreamForHrtf
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<ISpatialAudioObjectRenderStreamForHrtf*, Guid*, void**, int>)(lpVtbl[0]))((ISpatialAudioObjectRenderStreamForHrtf*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<ISpatialAudioObjectRenderStreamForHrtf*, uint>)(lpVtbl[1]))((ISpatialAudioObjectRenderStreamForHrtf*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<ISpatialAudioObjectRenderStreamForHrtf*, uint>)(lpVtbl[2]))((ISpatialAudioObjectRenderStreamForHrtf*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetAvailableDynamicObjectCount([NativeTypeName("UINT32 *")] uint* value)
        {
            return ((delegate* stdcall<ISpatialAudioObjectRenderStreamForHrtf*, uint*, int>)(lpVtbl[3]))((ISpatialAudioObjectRenderStreamForHrtf*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetService([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** service)
        {
            return ((delegate* stdcall<ISpatialAudioObjectRenderStreamForHrtf*, Guid*, void**, int>)(lpVtbl[4]))((ISpatialAudioObjectRenderStreamForHrtf*)Unsafe.AsPointer(ref this), riid, service);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Start()
        {
            return ((delegate* stdcall<ISpatialAudioObjectRenderStreamForHrtf*, int>)(lpVtbl[5]))((ISpatialAudioObjectRenderStreamForHrtf*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Stop()
        {
            return ((delegate* stdcall<ISpatialAudioObjectRenderStreamForHrtf*, int>)(lpVtbl[6]))((ISpatialAudioObjectRenderStreamForHrtf*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Reset()
        {
            return ((delegate* stdcall<ISpatialAudioObjectRenderStreamForHrtf*, int>)(lpVtbl[7]))((ISpatialAudioObjectRenderStreamForHrtf*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int BeginUpdatingAudioObjects([NativeTypeName("UINT32 *")] uint* availableDynamicObjectCount, [NativeTypeName("UINT32 *")] uint* frameCountPerBuffer)
        {
            return ((delegate* stdcall<ISpatialAudioObjectRenderStreamForHrtf*, uint*, uint*, int>)(lpVtbl[8]))((ISpatialAudioObjectRenderStreamForHrtf*)Unsafe.AsPointer(ref this), availableDynamicObjectCount, frameCountPerBuffer);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int EndUpdatingAudioObjects()
        {
            return ((delegate* stdcall<ISpatialAudioObjectRenderStreamForHrtf*, int>)(lpVtbl[9]))((ISpatialAudioObjectRenderStreamForHrtf*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ActivateSpatialAudioObjectForHrtf(AudioObjectType type, [NativeTypeName("ISpatialAudioObjectForHrtf **")] ISpatialAudioObjectForHrtf** audioObject)
        {
            return ((delegate* stdcall<ISpatialAudioObjectRenderStreamForHrtf*, AudioObjectType, ISpatialAudioObjectForHrtf**, int>)(lpVtbl[10]))((ISpatialAudioObjectRenderStreamForHrtf*)Unsafe.AsPointer(ref this), type, audioObject);
        }
    }
}
