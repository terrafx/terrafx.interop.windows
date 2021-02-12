// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("4A9A62D3-27D4-403D-91E9-89F540E55534")]
    [NativeTypeName("struct IPinConnection : IUnknown")]
    public unsafe partial struct IPinConnection
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IPinConnection*, Guid*, void**, int>)(lpVtbl[0]))((IPinConnection*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IPinConnection*, uint>)(lpVtbl[1]))((IPinConnection*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IPinConnection*, uint>)(lpVtbl[2]))((IPinConnection*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int DynamicQueryAccept([NativeTypeName("const AM_MEDIA_TYPE *")] AM_MEDIA_TYPE* pmt)
        {
            return ((delegate* unmanaged<IPinConnection*, AM_MEDIA_TYPE*, int>)(lpVtbl[3]))((IPinConnection*)Unsafe.AsPointer(ref this), pmt);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int NotifyEndOfStream([NativeTypeName("HANDLE")] IntPtr hNotifyEvent)
        {
            return ((delegate* unmanaged<IPinConnection*, IntPtr, int>)(lpVtbl[4]))((IPinConnection*)Unsafe.AsPointer(ref this), hNotifyEvent);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int IsEndPin()
        {
            return ((delegate* unmanaged<IPinConnection*, int>)(lpVtbl[5]))((IPinConnection*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int DynamicDisconnect()
        {
            return ((delegate* unmanaged<IPinConnection*, int>)(lpVtbl[6]))((IPinConnection*)Unsafe.AsPointer(ref this));
        }
    }
}
