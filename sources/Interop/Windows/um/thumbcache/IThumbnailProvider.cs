// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/thumbcache.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("E357FCCD-A995-4576-B01F-234630154E96")]
    [NativeTypeName("struct IThumbnailProvider : IUnknown")]
    public unsafe partial struct IThumbnailProvider
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IThumbnailProvider*, Guid*, void**, int>)(lpVtbl[0]))((IThumbnailProvider*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IThumbnailProvider*, uint>)(lpVtbl[1]))((IThumbnailProvider*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IThumbnailProvider*, uint>)(lpVtbl[2]))((IThumbnailProvider*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetThumbnail([NativeTypeName("UINT")] uint cx, [NativeTypeName("HBITMAP *")] IntPtr* phbmp, WTS_ALPHATYPE* pdwAlpha)
        {
            return ((delegate* unmanaged<IThumbnailProvider*, uint, IntPtr*, WTS_ALPHATYPE*, int>)(lpVtbl[3]))((IThumbnailProvider*)Unsafe.AsPointer(ref this), cx, phbmp, pdwAlpha);
        }
    }
}
