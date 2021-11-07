// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SpatialAudioMetadata.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace TerraFX.Interop
{
    [SupportedOSPlatform("windows10.0.15063.0")]
    [Guid("D224B233-E251-4FD0-9CA2-D5ECF9A68404")]
    [NativeTypeName("struct ISpatialAudioMetadataCopier : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct ISpatialAudioMetadataCopier : ISpatialAudioMetadataCopier.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ISpatialAudioMetadataCopier*, Guid*, void**, int>)(lpVtbl[0]))((ISpatialAudioMetadataCopier*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ISpatialAudioMetadataCopier*, uint>)(lpVtbl[1]))((ISpatialAudioMetadataCopier*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ISpatialAudioMetadataCopier*, uint>)(lpVtbl[2]))((ISpatialAudioMetadataCopier*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT Open(ISpatialAudioMetadataItems* metadataItems)
        {
            return ((delegate* unmanaged<ISpatialAudioMetadataCopier*, ISpatialAudioMetadataItems*, int>)(lpVtbl[3]))((ISpatialAudioMetadataCopier*)Unsafe.AsPointer(ref this), metadataItems);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT CopyMetadataForFrames([NativeTypeName("UINT16")] ushort copyFrameCount, SpatialAudioMetadataCopyMode copyMode, ISpatialAudioMetadataItems* dstMetadataItems, [NativeTypeName("UINT16 *")] ushort* itemsCopied)
        {
            return ((delegate* unmanaged<ISpatialAudioMetadataCopier*, ushort, SpatialAudioMetadataCopyMode, ISpatialAudioMetadataItems*, ushort*, int>)(lpVtbl[4]))((ISpatialAudioMetadataCopier*)Unsafe.AsPointer(ref this), copyFrameCount, copyMode, dstMetadataItems, itemsCopied);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT Close()
        {
            return ((delegate* unmanaged<ISpatialAudioMetadataCopier*, int>)(lpVtbl[5]))((ISpatialAudioMetadataCopier*)Unsafe.AsPointer(ref this));
        }

        public interface Interface : IUnknown.Interface
        {
            [VtblIndex(3)]
            HRESULT Open(ISpatialAudioMetadataItems* metadataItems);

            [VtblIndex(4)]
            HRESULT CopyMetadataForFrames([NativeTypeName("UINT16")] ushort copyFrameCount, SpatialAudioMetadataCopyMode copyMode, ISpatialAudioMetadataItems* dstMetadataItems, [NativeTypeName("UINT16 *")] ushort* itemsCopied);

            [VtblIndex(5)]
            HRESULT Close();
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpatialAudioMetadataCopier*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ISpatialAudioMetadataCopier*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ISpatialAudioMetadataCopier*, uint> Release;

            [NativeTypeName("HRESULT (ISpatialAudioMetadataItems *) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpatialAudioMetadataCopier*, ISpatialAudioMetadataItems*, int> Open;

            [NativeTypeName("HRESULT (UINT16, SpatialAudioMetadataCopyMode, ISpatialAudioMetadataItems *, UINT16 *) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpatialAudioMetadataCopier*, ushort, SpatialAudioMetadataCopyMode, ISpatialAudioMetadataItems*, ushort*, int> CopyMetadataForFrames;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<ISpatialAudioMetadataCopier*, int> Close;
        }
    }
}
