// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SpatialAudioMetadata.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("BCD7C78F-3098-4F22-B547-A2F25A381269")]
    [NativeTypeName("struct ISpatialAudioMetadataItems : IUnknown")]
    public unsafe partial struct ISpatialAudioMetadataItems
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ISpatialAudioMetadataItems*, Guid*, void**, int>)(lpVtbl[0]))((ISpatialAudioMetadataItems*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ISpatialAudioMetadataItems*, uint>)(lpVtbl[1]))((ISpatialAudioMetadataItems*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ISpatialAudioMetadataItems*, uint>)(lpVtbl[2]))((ISpatialAudioMetadataItems*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetFrameCount([NativeTypeName("UINT16 *")] ushort* frameCount)
        {
            return ((delegate* unmanaged<ISpatialAudioMetadataItems*, ushort*, int>)(lpVtbl[3]))((ISpatialAudioMetadataItems*)Unsafe.AsPointer(ref this), frameCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetItemCount([NativeTypeName("UINT16 *")] ushort* itemCount)
        {
            return ((delegate* unmanaged<ISpatialAudioMetadataItems*, ushort*, int>)(lpVtbl[4]))((ISpatialAudioMetadataItems*)Unsafe.AsPointer(ref this), itemCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetMaxItemCount([NativeTypeName("UINT16 *")] ushort* maxItemCount)
        {
            return ((delegate* unmanaged<ISpatialAudioMetadataItems*, ushort*, int>)(lpVtbl[5]))((ISpatialAudioMetadataItems*)Unsafe.AsPointer(ref this), maxItemCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetMaxValueBufferLength([NativeTypeName("UINT32 *")] uint* maxValueBufferLength)
        {
            return ((delegate* unmanaged<ISpatialAudioMetadataItems*, uint*, int>)(lpVtbl[6]))((ISpatialAudioMetadataItems*)Unsafe.AsPointer(ref this), maxValueBufferLength);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetInfo(SpatialAudioMetadataItemsInfo* info)
        {
            return ((delegate* unmanaged<ISpatialAudioMetadataItems*, SpatialAudioMetadataItemsInfo*, int>)(lpVtbl[7]))((ISpatialAudioMetadataItems*)Unsafe.AsPointer(ref this), info);
        }
    }
}
