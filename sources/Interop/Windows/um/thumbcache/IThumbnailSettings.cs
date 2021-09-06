// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/thumbcache.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("F4376F00-BEF5-4D45-80F3-1E023BBF1209")]
    [NativeTypeName("struct IThumbnailSettings : IUnknown")]
    public unsafe partial struct IThumbnailSettings
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IThumbnailSettings*, Guid*, void**, int>)(lpVtbl[0]))((IThumbnailSettings*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IThumbnailSettings*, uint>)(lpVtbl[1]))((IThumbnailSettings*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IThumbnailSettings*, uint>)(lpVtbl[2]))((IThumbnailSettings*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetContext(WTS_CONTEXTFLAGS dwContext)
        {
            return ((delegate* unmanaged<IThumbnailSettings*, WTS_CONTEXTFLAGS, int>)(lpVtbl[3]))((IThumbnailSettings*)Unsafe.AsPointer(ref this), dwContext);
        }
    }
}
