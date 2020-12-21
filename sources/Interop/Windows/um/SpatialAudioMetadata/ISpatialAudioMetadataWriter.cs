// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SpatialAudioMetadata.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("1B17CA01-2955-444D-A430-537DC589A844")]
    [NativeTypeName("struct ISpatialAudioMetadataWriter : IUnknown")]
    public unsafe partial struct ISpatialAudioMetadataWriter
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<ISpatialAudioMetadataWriter*, Guid*, void**, int>)(lpVtbl[0]))((ISpatialAudioMetadataWriter*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<ISpatialAudioMetadataWriter*, uint>)(lpVtbl[1]))((ISpatialAudioMetadataWriter*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<ISpatialAudioMetadataWriter*, uint>)(lpVtbl[2]))((ISpatialAudioMetadataWriter*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Open([NativeTypeName("ISpatialAudioMetadataItems *")] ISpatialAudioMetadataItems* metadataItems)
        {
            return ((delegate* unmanaged[Stdcall]<ISpatialAudioMetadataWriter*, ISpatialAudioMetadataItems*, int>)(lpVtbl[3]))((ISpatialAudioMetadataWriter*)Unsafe.AsPointer(ref this), metadataItems);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int WriteNextItem([NativeTypeName("UINT16")] ushort frameOffset)
        {
            return ((delegate* unmanaged[Stdcall]<ISpatialAudioMetadataWriter*, ushort, int>)(lpVtbl[4]))((ISpatialAudioMetadataWriter*)Unsafe.AsPointer(ref this), frameOffset);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int WriteNextItemCommand([NativeTypeName("BYTE")] byte commandID, [NativeTypeName("const void *")] void* valueBuffer, [NativeTypeName("UINT32")] uint valueBufferLength)
        {
            return ((delegate* unmanaged[Stdcall]<ISpatialAudioMetadataWriter*, byte, void*, uint, int>)(lpVtbl[5]))((ISpatialAudioMetadataWriter*)Unsafe.AsPointer(ref this), commandID, valueBuffer, valueBufferLength);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Close()
        {
            return ((delegate* unmanaged[Stdcall]<ISpatialAudioMetadataWriter*, int>)(lpVtbl[6]))((ISpatialAudioMetadataWriter*)Unsafe.AsPointer(ref this));
        }
    }
}
