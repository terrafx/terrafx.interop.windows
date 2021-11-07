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
    [Guid("BCD7C78F-3098-4F22-B547-A2F25A381269")]
    [NativeTypeName("struct ISpatialAudioMetadataItems : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct ISpatialAudioMetadataItems : ISpatialAudioMetadataItems.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ISpatialAudioMetadataItems*, Guid*, void**, int>)(lpVtbl[0]))((ISpatialAudioMetadataItems*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ISpatialAudioMetadataItems*, uint>)(lpVtbl[1]))((ISpatialAudioMetadataItems*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ISpatialAudioMetadataItems*, uint>)(lpVtbl[2]))((ISpatialAudioMetadataItems*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetFrameCount([NativeTypeName("UINT16 *")] ushort* frameCount)
        {
            return ((delegate* unmanaged<ISpatialAudioMetadataItems*, ushort*, int>)(lpVtbl[3]))((ISpatialAudioMetadataItems*)Unsafe.AsPointer(ref this), frameCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetItemCount([NativeTypeName("UINT16 *")] ushort* itemCount)
        {
            return ((delegate* unmanaged<ISpatialAudioMetadataItems*, ushort*, int>)(lpVtbl[4]))((ISpatialAudioMetadataItems*)Unsafe.AsPointer(ref this), itemCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetMaxItemCount([NativeTypeName("UINT16 *")] ushort* maxItemCount)
        {
            return ((delegate* unmanaged<ISpatialAudioMetadataItems*, ushort*, int>)(lpVtbl[5]))((ISpatialAudioMetadataItems*)Unsafe.AsPointer(ref this), maxItemCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT GetMaxValueBufferLength([NativeTypeName("UINT32 *")] uint* maxValueBufferLength)
        {
            return ((delegate* unmanaged<ISpatialAudioMetadataItems*, uint*, int>)(lpVtbl[6]))((ISpatialAudioMetadataItems*)Unsafe.AsPointer(ref this), maxValueBufferLength);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT GetInfo(SpatialAudioMetadataItemsInfo* info)
        {
            return ((delegate* unmanaged<ISpatialAudioMetadataItems*, SpatialAudioMetadataItemsInfo*, int>)(lpVtbl[7]))((ISpatialAudioMetadataItems*)Unsafe.AsPointer(ref this), info);
        }

        public interface Interface : IUnknown.Interface
        {
            [VtblIndex(3)]
            HRESULT GetFrameCount([NativeTypeName("UINT16 *")] ushort* frameCount);

            [VtblIndex(4)]
            HRESULT GetItemCount([NativeTypeName("UINT16 *")] ushort* itemCount);

            [VtblIndex(5)]
            HRESULT GetMaxItemCount([NativeTypeName("UINT16 *")] ushort* maxItemCount);

            [VtblIndex(6)]
            HRESULT GetMaxValueBufferLength([NativeTypeName("UINT32 *")] uint* maxValueBufferLength);

            [VtblIndex(7)]
            HRESULT GetInfo(SpatialAudioMetadataItemsInfo* info);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpatialAudioMetadataItems*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ISpatialAudioMetadataItems*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ISpatialAudioMetadataItems*, uint> Release;

            [NativeTypeName("HRESULT (UINT16 *) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpatialAudioMetadataItems*, ushort*, int> GetFrameCount;

            [NativeTypeName("HRESULT (UINT16 *) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpatialAudioMetadataItems*, ushort*, int> GetItemCount;

            [NativeTypeName("HRESULT (UINT16 *) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpatialAudioMetadataItems*, ushort*, int> GetMaxItemCount;

            [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpatialAudioMetadataItems*, uint*, int> GetMaxValueBufferLength;

            [NativeTypeName("HRESULT (SpatialAudioMetadataItemsInfo *) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpatialAudioMetadataItems*, SpatialAudioMetadataItemsInfo*, int> GetInfo;
        }
    }
}
