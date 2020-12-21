// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SpatialAudioMetadata.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("D224B233-E251-4FD0-9CA2-D5ECF9A68404")]
    [NativeTypeName("struct ISpatialAudioMetadataCopier : IUnknown")]
    public unsafe partial struct ISpatialAudioMetadataCopier
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<ISpatialAudioMetadataCopier*, Guid*, void**, int>)(lpVtbl[0]))((ISpatialAudioMetadataCopier*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ISpatialAudioMetadataCopier*, uint>)(lpVtbl[1]))((ISpatialAudioMetadataCopier*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ISpatialAudioMetadataCopier*, uint>)(lpVtbl[2]))((ISpatialAudioMetadataCopier*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Open([NativeTypeName("ISpatialAudioMetadataItems *")] ISpatialAudioMetadataItems* metadataItems)
        {
            return ((delegate* unmanaged<ISpatialAudioMetadataCopier*, ISpatialAudioMetadataItems*, int>)(lpVtbl[3]))((ISpatialAudioMetadataCopier*)Unsafe.AsPointer(ref this), metadataItems);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CopyMetadataForFrames([NativeTypeName("UINT16")] ushort copyFrameCount, SpatialAudioMetadataCopyMode copyMode, [NativeTypeName("ISpatialAudioMetadataItems *")] ISpatialAudioMetadataItems* dstMetadataItems, [NativeTypeName("UINT16 *")] ushort* itemsCopied)
        {
            return ((delegate* unmanaged<ISpatialAudioMetadataCopier*, ushort, SpatialAudioMetadataCopyMode, ISpatialAudioMetadataItems*, ushort*, int>)(lpVtbl[4]))((ISpatialAudioMetadataCopier*)Unsafe.AsPointer(ref this), copyFrameCount, copyMode, dstMetadataItems, itemsCopied);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Close()
        {
            return ((delegate* unmanaged<ISpatialAudioMetadataCopier*, int>)(lpVtbl[5]))((ISpatialAudioMetadataCopier*)Unsafe.AsPointer(ref this));
        }
    }
}
