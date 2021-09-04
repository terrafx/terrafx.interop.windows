// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/thumbnailstreamcache.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("90E11430-9569-41D8-AE75-6D4D2AE7CCA0")]
    [NativeTypeName("struct IThumbnailStreamCache : IUnknown")]
    public unsafe partial struct IThumbnailStreamCache
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IThumbnailStreamCache*, Guid*, void**, int>)(lpVtbl[0]))((IThumbnailStreamCache*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IThumbnailStreamCache*, uint>)(lpVtbl[1]))((IThumbnailStreamCache*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IThumbnailStreamCache*, uint>)(lpVtbl[2]))((IThumbnailStreamCache*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetThumbnailStream([NativeTypeName("LPCWSTR")] ushort* path, [NativeTypeName("ULONGLONG")] ulong cacheId, ThumbnailStreamCacheOptions options, [NativeTypeName("UINT")] uint requestedThumbnailSize, SIZE* thumbnailSize, IStream** thumbnailStream)
        {
            return ((delegate* unmanaged<IThumbnailStreamCache*, ushort*, ulong, ThumbnailStreamCacheOptions, uint, SIZE*, IStream**, int>)(lpVtbl[3]))((IThumbnailStreamCache*)Unsafe.AsPointer(ref this), path, cacheId, options, requestedThumbnailSize, thumbnailSize, thumbnailStream);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetThumbnailStream([NativeTypeName("LPCWSTR")] ushort* path, [NativeTypeName("ULONGLONG")] ulong cacheId, SIZE thumbnailSize, IStream* thumbnailStream)
        {
            return ((delegate* unmanaged<IThumbnailStreamCache*, ushort*, ulong, SIZE, IStream*, int>)(lpVtbl[4]))((IThumbnailStreamCache*)Unsafe.AsPointer(ref this), path, cacheId, thumbnailSize, thumbnailStream);
        }
    }
}
