// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SpatialAudioHrtf.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("E08DEEF9-5363-406E-9FDC-080EE247BBE0")]
    [NativeTypeName("struct ISpatialAudioObjectRenderStreamForHrtf : ISpatialAudioObjectRenderStreamBase")]
    [NativeInheritance("ISpatialAudioObjectRenderStreamBase")]
    public unsafe partial struct ISpatialAudioObjectRenderStreamForHrtf
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ISpatialAudioObjectRenderStreamForHrtf*, Guid*, void**, int>)(lpVtbl[0]))((ISpatialAudioObjectRenderStreamForHrtf*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ISpatialAudioObjectRenderStreamForHrtf*, uint>)(lpVtbl[1]))((ISpatialAudioObjectRenderStreamForHrtf*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ISpatialAudioObjectRenderStreamForHrtf*, uint>)(lpVtbl[2]))((ISpatialAudioObjectRenderStreamForHrtf*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int GetAvailableDynamicObjectCount([NativeTypeName("UINT32 *")] uint* value)
        {
            return ((delegate* unmanaged<ISpatialAudioObjectRenderStreamForHrtf*, uint*, int>)(lpVtbl[3]))((ISpatialAudioObjectRenderStreamForHrtf*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int GetService([NativeTypeName("const IID &")] Guid* riid, void** service)
        {
            return ((delegate* unmanaged<ISpatialAudioObjectRenderStreamForHrtf*, Guid*, void**, int>)(lpVtbl[4]))((ISpatialAudioObjectRenderStreamForHrtf*)Unsafe.AsPointer(ref this), riid, service);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int Start()
        {
            return ((delegate* unmanaged<ISpatialAudioObjectRenderStreamForHrtf*, int>)(lpVtbl[5]))((ISpatialAudioObjectRenderStreamForHrtf*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int Stop()
        {
            return ((delegate* unmanaged<ISpatialAudioObjectRenderStreamForHrtf*, int>)(lpVtbl[6]))((ISpatialAudioObjectRenderStreamForHrtf*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int Reset()
        {
            return ((delegate* unmanaged<ISpatialAudioObjectRenderStreamForHrtf*, int>)(lpVtbl[7]))((ISpatialAudioObjectRenderStreamForHrtf*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int BeginUpdatingAudioObjects([NativeTypeName("UINT32 *")] uint* availableDynamicObjectCount, [NativeTypeName("UINT32 *")] uint* frameCountPerBuffer)
        {
            return ((delegate* unmanaged<ISpatialAudioObjectRenderStreamForHrtf*, uint*, uint*, int>)(lpVtbl[8]))((ISpatialAudioObjectRenderStreamForHrtf*)Unsafe.AsPointer(ref this), availableDynamicObjectCount, frameCountPerBuffer);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("HRESULT")]
        public int EndUpdatingAudioObjects()
        {
            return ((delegate* unmanaged<ISpatialAudioObjectRenderStreamForHrtf*, int>)(lpVtbl[9]))((ISpatialAudioObjectRenderStreamForHrtf*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        [return: NativeTypeName("HRESULT")]
        public int ActivateSpatialAudioObjectForHrtf(AudioObjectType type, ISpatialAudioObjectForHrtf** audioObject)
        {
            return ((delegate* unmanaged<ISpatialAudioObjectRenderStreamForHrtf*, AudioObjectType, ISpatialAudioObjectForHrtf**, int>)(lpVtbl[10]))((ISpatialAudioObjectRenderStreamForHrtf*)Unsafe.AsPointer(ref this), type, audioObject);
        }
    }
}
