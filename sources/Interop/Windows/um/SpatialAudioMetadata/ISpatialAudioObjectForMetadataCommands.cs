// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SpatialAudioMetadata.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("0DF2C94B-F5F9-472D-AF6B-C46E0AC9CD05")]
    [NativeTypeName("struct ISpatialAudioObjectForMetadataCommands : ISpatialAudioObjectBase")]
    public unsafe partial struct ISpatialAudioObjectForMetadataCommands
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<ISpatialAudioObjectForMetadataCommands*, Guid*, void**, int>)(lpVtbl[0]))((ISpatialAudioObjectForMetadataCommands*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ISpatialAudioObjectForMetadataCommands*, uint>)(lpVtbl[1]))((ISpatialAudioObjectForMetadataCommands*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ISpatialAudioObjectForMetadataCommands*, uint>)(lpVtbl[2]))((ISpatialAudioObjectForMetadataCommands*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetBuffer([NativeTypeName("BYTE **")] byte** buffer, [NativeTypeName("UINT32 *")] uint* bufferLength)
        {
            return ((delegate* unmanaged<ISpatialAudioObjectForMetadataCommands*, byte**, uint*, int>)(lpVtbl[3]))((ISpatialAudioObjectForMetadataCommands*)Unsafe.AsPointer(ref this), buffer, bufferLength);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetEndOfStream([NativeTypeName("UINT32")] uint frameCount)
        {
            return ((delegate* unmanaged<ISpatialAudioObjectForMetadataCommands*, uint, int>)(lpVtbl[4]))((ISpatialAudioObjectForMetadataCommands*)Unsafe.AsPointer(ref this), frameCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int IsActive([NativeTypeName("BOOL *")] int* isActive)
        {
            return ((delegate* unmanaged<ISpatialAudioObjectForMetadataCommands*, int*, int>)(lpVtbl[5]))((ISpatialAudioObjectForMetadataCommands*)Unsafe.AsPointer(ref this), isActive);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetAudioObjectType([NativeTypeName("AudioObjectType *")] AudioObjectType* audioObjectType)
        {
            return ((delegate* unmanaged<ISpatialAudioObjectForMetadataCommands*, AudioObjectType*, int>)(lpVtbl[6]))((ISpatialAudioObjectForMetadataCommands*)Unsafe.AsPointer(ref this), audioObjectType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int WriteNextMetadataCommand([NativeTypeName("BYTE")] byte commandID, [NativeTypeName("void *")] void* valueBuffer, [NativeTypeName("UINT32")] uint valueBufferLength)
        {
            return ((delegate* unmanaged<ISpatialAudioObjectForMetadataCommands*, byte, void*, uint, int>)(lpVtbl[7]))((ISpatialAudioObjectForMetadataCommands*)Unsafe.AsPointer(ref this), commandID, valueBuffer, valueBufferLength);
        }
    }
}
