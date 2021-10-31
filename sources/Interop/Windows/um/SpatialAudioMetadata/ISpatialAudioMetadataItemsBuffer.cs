// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SpatialAudioMetadata.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("42640A16-E1BD-42D9-9FF6-031AB71A2DBA")]
    [NativeTypeName("struct ISpatialAudioMetadataItemsBuffer : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct ISpatialAudioMetadataItemsBuffer
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ISpatialAudioMetadataItemsBuffer*, Guid*, void**, int>)(lpVtbl[0]))((ISpatialAudioMetadataItemsBuffer*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ISpatialAudioMetadataItemsBuffer*, uint>)(lpVtbl[1]))((ISpatialAudioMetadataItemsBuffer*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ISpatialAudioMetadataItemsBuffer*, uint>)(lpVtbl[2]))((ISpatialAudioMetadataItemsBuffer*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT AttachToBuffer([NativeTypeName("BYTE *")] byte* buffer, [NativeTypeName("UINT32")] uint bufferLength)
        {
            return ((delegate* unmanaged<ISpatialAudioMetadataItemsBuffer*, byte*, uint, int>)(lpVtbl[3]))((ISpatialAudioMetadataItemsBuffer*)Unsafe.AsPointer(ref this), buffer, bufferLength);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT AttachToPopulatedBuffer([NativeTypeName("BYTE *")] byte* buffer, [NativeTypeName("UINT32")] uint bufferLength)
        {
            return ((delegate* unmanaged<ISpatialAudioMetadataItemsBuffer*, byte*, uint, int>)(lpVtbl[4]))((ISpatialAudioMetadataItemsBuffer*)Unsafe.AsPointer(ref this), buffer, bufferLength);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT DetachBuffer()
        {
            return ((delegate* unmanaged<ISpatialAudioMetadataItemsBuffer*, int>)(lpVtbl[5]))((ISpatialAudioMetadataItemsBuffer*)Unsafe.AsPointer(ref this));
        }
    }
}
