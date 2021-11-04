// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SpatialAudioMetadata.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("777D4A3B-F6FF-4A26-85DC-68D7CDEDA1D4")]
    [NativeTypeName("struct ISpatialAudioMetadataClient : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct ISpatialAudioMetadataClient
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ISpatialAudioMetadataClient*, Guid*, void**, int>)(lpVtbl[0]))((ISpatialAudioMetadataClient*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ISpatialAudioMetadataClient*, uint>)(lpVtbl[1]))((ISpatialAudioMetadataClient*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ISpatialAudioMetadataClient*, uint>)(lpVtbl[2]))((ISpatialAudioMetadataClient*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT ActivateSpatialAudioMetadataItems([NativeTypeName("UINT16")] ushort maxItemCount, [NativeTypeName("UINT16")] ushort frameCount, ISpatialAudioMetadataItemsBuffer** metadataItemsBuffer, ISpatialAudioMetadataItems** metadataItems)
        {
            return ((delegate* unmanaged<ISpatialAudioMetadataClient*, ushort, ushort, ISpatialAudioMetadataItemsBuffer**, ISpatialAudioMetadataItems**, int>)(lpVtbl[3]))((ISpatialAudioMetadataClient*)Unsafe.AsPointer(ref this), maxItemCount, frameCount, metadataItemsBuffer, metadataItems);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetSpatialAudioMetadataItemsBufferLength([NativeTypeName("UINT16")] ushort maxItemCount, [NativeTypeName("UINT32 *")] uint* bufferLength)
        {
            return ((delegate* unmanaged<ISpatialAudioMetadataClient*, ushort, uint*, int>)(lpVtbl[4]))((ISpatialAudioMetadataClient*)Unsafe.AsPointer(ref this), maxItemCount, bufferLength);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT ActivateSpatialAudioMetadataWriter(SpatialAudioMetadataWriterOverflowMode overflowMode, ISpatialAudioMetadataWriter** metadataWriter)
        {
            return ((delegate* unmanaged<ISpatialAudioMetadataClient*, SpatialAudioMetadataWriterOverflowMode, ISpatialAudioMetadataWriter**, int>)(lpVtbl[5]))((ISpatialAudioMetadataClient*)Unsafe.AsPointer(ref this), overflowMode, metadataWriter);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT ActivateSpatialAudioMetadataCopier(ISpatialAudioMetadataCopier** metadataCopier)
        {
            return ((delegate* unmanaged<ISpatialAudioMetadataClient*, ISpatialAudioMetadataCopier**, int>)(lpVtbl[6]))((ISpatialAudioMetadataClient*)Unsafe.AsPointer(ref this), metadataCopier);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT ActivateSpatialAudioMetadataReader(ISpatialAudioMetadataReader** metadataReader)
        {
            return ((delegate* unmanaged<ISpatialAudioMetadataClient*, ISpatialAudioMetadataReader**, int>)(lpVtbl[7]))((ISpatialAudioMetadataClient*)Unsafe.AsPointer(ref this), metadataReader);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpatialAudioMetadataClient*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ISpatialAudioMetadataClient*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ISpatialAudioMetadataClient*, uint> Release;

            [NativeTypeName("HRESULT (UINT16, UINT16, ISpatialAudioMetadataItemsBuffer **, ISpatialAudioMetadataItems **) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpatialAudioMetadataClient*, ushort, ushort, ISpatialAudioMetadataItemsBuffer**, ISpatialAudioMetadataItems**, int> ActivateSpatialAudioMetadataItems;

            [NativeTypeName("HRESULT (UINT16, UINT32 *) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpatialAudioMetadataClient*, ushort, uint*, int> GetSpatialAudioMetadataItemsBufferLength;

            [NativeTypeName("HRESULT (SpatialAudioMetadataWriterOverflowMode, ISpatialAudioMetadataWriter **) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpatialAudioMetadataClient*, SpatialAudioMetadataWriterOverflowMode, ISpatialAudioMetadataWriter**, int> ActivateSpatialAudioMetadataWriter;

            [NativeTypeName("HRESULT (ISpatialAudioMetadataCopier **) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpatialAudioMetadataClient*, ISpatialAudioMetadataCopier**, int> ActivateSpatialAudioMetadataCopier;

            [NativeTypeName("HRESULT (ISpatialAudioMetadataReader **) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpatialAudioMetadataClient*, ISpatialAudioMetadataReader**, int> ActivateSpatialAudioMetadataReader;
        }
    }
}
