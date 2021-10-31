// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SpatialAudioMetadata.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("1B17CA01-2955-444D-A430-537DC589A844")]
    [NativeTypeName("struct ISpatialAudioMetadataWriter : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct ISpatialAudioMetadataWriter
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ISpatialAudioMetadataWriter*, Guid*, void**, int>)(lpVtbl[0]))((ISpatialAudioMetadataWriter*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ISpatialAudioMetadataWriter*, uint>)(lpVtbl[1]))((ISpatialAudioMetadataWriter*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ISpatialAudioMetadataWriter*, uint>)(lpVtbl[2]))((ISpatialAudioMetadataWriter*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT Open(ISpatialAudioMetadataItems* metadataItems)
        {
            return ((delegate* unmanaged<ISpatialAudioMetadataWriter*, ISpatialAudioMetadataItems*, int>)(lpVtbl[3]))((ISpatialAudioMetadataWriter*)Unsafe.AsPointer(ref this), metadataItems);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT WriteNextItem([NativeTypeName("UINT16")] ushort frameOffset)
        {
            return ((delegate* unmanaged<ISpatialAudioMetadataWriter*, ushort, int>)(lpVtbl[4]))((ISpatialAudioMetadataWriter*)Unsafe.AsPointer(ref this), frameOffset);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT WriteNextItemCommand([NativeTypeName("BYTE")] byte commandID, [NativeTypeName("const void *")] void* valueBuffer, [NativeTypeName("UINT32")] uint valueBufferLength)
        {
            return ((delegate* unmanaged<ISpatialAudioMetadataWriter*, byte, void*, uint, int>)(lpVtbl[5]))((ISpatialAudioMetadataWriter*)Unsafe.AsPointer(ref this), commandID, valueBuffer, valueBufferLength);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT Close()
        {
            return ((delegate* unmanaged<ISpatialAudioMetadataWriter*, int>)(lpVtbl[6]))((ISpatialAudioMetadataWriter*)Unsafe.AsPointer(ref this));
        }
    }
}
