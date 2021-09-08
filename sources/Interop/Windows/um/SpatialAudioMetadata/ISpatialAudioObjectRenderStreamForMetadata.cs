// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SpatialAudioMetadata.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("BBC9C907-48D5-4A2E-A0C7-F7F0D67C1FB1")]
    [NativeTypeName("struct ISpatialAudioObjectRenderStreamForMetadata : ISpatialAudioObjectRenderStreamBase")]
    [NativeInheritance("ISpatialAudioObjectRenderStreamBase")]
    public unsafe partial struct ISpatialAudioObjectRenderStreamForMetadata
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ISpatialAudioObjectRenderStreamForMetadata*, Guid*, void**, int>)(lpVtbl[0]))((ISpatialAudioObjectRenderStreamForMetadata*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ISpatialAudioObjectRenderStreamForMetadata*, uint>)(lpVtbl[1]))((ISpatialAudioObjectRenderStreamForMetadata*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ISpatialAudioObjectRenderStreamForMetadata*, uint>)(lpVtbl[2]))((ISpatialAudioObjectRenderStreamForMetadata*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int GetAvailableDynamicObjectCount([NativeTypeName("UINT32 *")] uint* value)
        {
            return ((delegate* unmanaged<ISpatialAudioObjectRenderStreamForMetadata*, uint*, int>)(lpVtbl[3]))((ISpatialAudioObjectRenderStreamForMetadata*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int GetService([NativeTypeName("const IID &")] Guid* riid, void** service)
        {
            return ((delegate* unmanaged<ISpatialAudioObjectRenderStreamForMetadata*, Guid*, void**, int>)(lpVtbl[4]))((ISpatialAudioObjectRenderStreamForMetadata*)Unsafe.AsPointer(ref this), riid, service);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int Start()
        {
            return ((delegate* unmanaged<ISpatialAudioObjectRenderStreamForMetadata*, int>)(lpVtbl[5]))((ISpatialAudioObjectRenderStreamForMetadata*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int Stop()
        {
            return ((delegate* unmanaged<ISpatialAudioObjectRenderStreamForMetadata*, int>)(lpVtbl[6]))((ISpatialAudioObjectRenderStreamForMetadata*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int Reset()
        {
            return ((delegate* unmanaged<ISpatialAudioObjectRenderStreamForMetadata*, int>)(lpVtbl[7]))((ISpatialAudioObjectRenderStreamForMetadata*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int BeginUpdatingAudioObjects([NativeTypeName("UINT32 *")] uint* availableDynamicObjectCount, [NativeTypeName("UINT32 *")] uint* frameCountPerBuffer)
        {
            return ((delegate* unmanaged<ISpatialAudioObjectRenderStreamForMetadata*, uint*, uint*, int>)(lpVtbl[8]))((ISpatialAudioObjectRenderStreamForMetadata*)Unsafe.AsPointer(ref this), availableDynamicObjectCount, frameCountPerBuffer);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("HRESULT")]
        public int EndUpdatingAudioObjects()
        {
            return ((delegate* unmanaged<ISpatialAudioObjectRenderStreamForMetadata*, int>)(lpVtbl[9]))((ISpatialAudioObjectRenderStreamForMetadata*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        [return: NativeTypeName("HRESULT")]
        public int ActivateSpatialAudioObjectForMetadataCommands(AudioObjectType type, ISpatialAudioObjectForMetadataCommands** audioObject)
        {
            return ((delegate* unmanaged<ISpatialAudioObjectRenderStreamForMetadata*, AudioObjectType, ISpatialAudioObjectForMetadataCommands**, int>)(lpVtbl[10]))((ISpatialAudioObjectRenderStreamForMetadata*)Unsafe.AsPointer(ref this), type, audioObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        [return: NativeTypeName("HRESULT")]
        public int ActivateSpatialAudioObjectForMetadataItems(AudioObjectType type, ISpatialAudioObjectForMetadataItems** audioObject)
        {
            return ((delegate* unmanaged<ISpatialAudioObjectRenderStreamForMetadata*, AudioObjectType, ISpatialAudioObjectForMetadataItems**, int>)(lpVtbl[11]))((ISpatialAudioObjectRenderStreamForMetadata*)Unsafe.AsPointer(ref this), type, audioObject);
        }
    }
}
