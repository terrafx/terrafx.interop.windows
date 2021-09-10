// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SpatialAudioClient.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("BAB5F473-B423-477B-85F5-B5A332A04153")]
    [NativeTypeName("struct ISpatialAudioObjectRenderStream : ISpatialAudioObjectRenderStreamBase")]
    [NativeInheritance("ISpatialAudioObjectRenderStreamBase")]
    public unsafe partial struct ISpatialAudioObjectRenderStream
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ISpatialAudioObjectRenderStream*, Guid*, void**, int>)(lpVtbl[0]))((ISpatialAudioObjectRenderStream*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ISpatialAudioObjectRenderStream*, uint>)(lpVtbl[1]))((ISpatialAudioObjectRenderStream*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ISpatialAudioObjectRenderStream*, uint>)(lpVtbl[2]))((ISpatialAudioObjectRenderStream*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int GetAvailableDynamicObjectCount([NativeTypeName("UINT32 *")] uint* value)
        {
            return ((delegate* unmanaged<ISpatialAudioObjectRenderStream*, uint*, int>)(lpVtbl[3]))((ISpatialAudioObjectRenderStream*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int GetService([NativeTypeName("const IID &")] Guid* riid, void** service)
        {
            return ((delegate* unmanaged<ISpatialAudioObjectRenderStream*, Guid*, void**, int>)(lpVtbl[4]))((ISpatialAudioObjectRenderStream*)Unsafe.AsPointer(ref this), riid, service);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int Start()
        {
            return ((delegate* unmanaged<ISpatialAudioObjectRenderStream*, int>)(lpVtbl[5]))((ISpatialAudioObjectRenderStream*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int Stop()
        {
            return ((delegate* unmanaged<ISpatialAudioObjectRenderStream*, int>)(lpVtbl[6]))((ISpatialAudioObjectRenderStream*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int Reset()
        {
            return ((delegate* unmanaged<ISpatialAudioObjectRenderStream*, int>)(lpVtbl[7]))((ISpatialAudioObjectRenderStream*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int BeginUpdatingAudioObjects([NativeTypeName("UINT32 *")] uint* availableDynamicObjectCount, [NativeTypeName("UINT32 *")] uint* frameCountPerBuffer)
        {
            return ((delegate* unmanaged<ISpatialAudioObjectRenderStream*, uint*, uint*, int>)(lpVtbl[8]))((ISpatialAudioObjectRenderStream*)Unsafe.AsPointer(ref this), availableDynamicObjectCount, frameCountPerBuffer);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("HRESULT")]
        public int EndUpdatingAudioObjects()
        {
            return ((delegate* unmanaged<ISpatialAudioObjectRenderStream*, int>)(lpVtbl[9]))((ISpatialAudioObjectRenderStream*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        [return: NativeTypeName("HRESULT")]
        public int ActivateSpatialAudioObject(AudioObjectType type, ISpatialAudioObject** audioObject)
        {
            return ((delegate* unmanaged<ISpatialAudioObjectRenderStream*, AudioObjectType, ISpatialAudioObject**, int>)(lpVtbl[10]))((ISpatialAudioObjectRenderStream*)Unsafe.AsPointer(ref this), type, audioObject);
        }
    }
}
