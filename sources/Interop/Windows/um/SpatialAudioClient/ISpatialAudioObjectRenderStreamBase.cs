// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SpatialAudioClient.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("FEAAF403-C1D8-450D-AA05-E0CCEE7502A8")]
    [NativeTypeName("struct ISpatialAudioObjectRenderStreamBase : IUnknown")]
    public unsafe partial struct ISpatialAudioObjectRenderStreamBase
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ISpatialAudioObjectRenderStreamBase*, Guid*, void**, int>)(lpVtbl[0]))((ISpatialAudioObjectRenderStreamBase*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ISpatialAudioObjectRenderStreamBase*, uint>)(lpVtbl[1]))((ISpatialAudioObjectRenderStreamBase*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ISpatialAudioObjectRenderStreamBase*, uint>)(lpVtbl[2]))((ISpatialAudioObjectRenderStreamBase*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetAvailableDynamicObjectCount([NativeTypeName("UINT32 *")] uint* value)
        {
            return ((delegate* unmanaged<ISpatialAudioObjectRenderStreamBase*, uint*, int>)(lpVtbl[3]))((ISpatialAudioObjectRenderStreamBase*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetService([NativeTypeName("const IID &")] Guid* riid, void** service)
        {
            return ((delegate* unmanaged<ISpatialAudioObjectRenderStreamBase*, Guid*, void**, int>)(lpVtbl[4]))((ISpatialAudioObjectRenderStreamBase*)Unsafe.AsPointer(ref this), riid, service);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Start()
        {
            return ((delegate* unmanaged<ISpatialAudioObjectRenderStreamBase*, int>)(lpVtbl[5]))((ISpatialAudioObjectRenderStreamBase*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Stop()
        {
            return ((delegate* unmanaged<ISpatialAudioObjectRenderStreamBase*, int>)(lpVtbl[6]))((ISpatialAudioObjectRenderStreamBase*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Reset()
        {
            return ((delegate* unmanaged<ISpatialAudioObjectRenderStreamBase*, int>)(lpVtbl[7]))((ISpatialAudioObjectRenderStreamBase*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int BeginUpdatingAudioObjects([NativeTypeName("UINT32 *")] uint* availableDynamicObjectCount, [NativeTypeName("UINT32 *")] uint* frameCountPerBuffer)
        {
            return ((delegate* unmanaged<ISpatialAudioObjectRenderStreamBase*, uint*, uint*, int>)(lpVtbl[8]))((ISpatialAudioObjectRenderStreamBase*)Unsafe.AsPointer(ref this), availableDynamicObjectCount, frameCountPerBuffer);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int EndUpdatingAudioObjects()
        {
            return ((delegate* unmanaged<ISpatialAudioObjectRenderStreamBase*, int>)(lpVtbl[9]))((ISpatialAudioObjectRenderStreamBase*)Unsafe.AsPointer(ref this));
        }
    }
}
