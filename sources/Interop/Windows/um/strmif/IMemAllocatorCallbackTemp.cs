// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("379A0CF0-C1DE-11D2-ABF5-00A0C905F375")]
    [NativeTypeName("struct IMemAllocatorCallbackTemp : IMemAllocator")]
    public unsafe partial struct IMemAllocatorCallbackTemp
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IMemAllocatorCallbackTemp*, Guid*, void**, int>)(lpVtbl[0]))((IMemAllocatorCallbackTemp*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMemAllocatorCallbackTemp*, uint>)(lpVtbl[1]))((IMemAllocatorCallbackTemp*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMemAllocatorCallbackTemp*, uint>)(lpVtbl[2]))((IMemAllocatorCallbackTemp*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetProperties(ALLOCATOR_PROPERTIES* pRequest, ALLOCATOR_PROPERTIES* pActual)
        {
            return ((delegate* unmanaged<IMemAllocatorCallbackTemp*, ALLOCATOR_PROPERTIES*, ALLOCATOR_PROPERTIES*, int>)(lpVtbl[3]))((IMemAllocatorCallbackTemp*)Unsafe.AsPointer(ref this), pRequest, pActual);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetProperties(ALLOCATOR_PROPERTIES* pProps)
        {
            return ((delegate* unmanaged<IMemAllocatorCallbackTemp*, ALLOCATOR_PROPERTIES*, int>)(lpVtbl[4]))((IMemAllocatorCallbackTemp*)Unsafe.AsPointer(ref this), pProps);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Commit()
        {
            return ((delegate* unmanaged<IMemAllocatorCallbackTemp*, int>)(lpVtbl[5]))((IMemAllocatorCallbackTemp*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Decommit()
        {
            return ((delegate* unmanaged<IMemAllocatorCallbackTemp*, int>)(lpVtbl[6]))((IMemAllocatorCallbackTemp*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetBuffer(IMediaSample** ppBuffer, [NativeTypeName("REFERENCE_TIME *")] long* pStartTime, [NativeTypeName("REFERENCE_TIME *")] long* pEndTime, [NativeTypeName("DWORD")] uint dwFlags)
        {
            return ((delegate* unmanaged<IMemAllocatorCallbackTemp*, IMediaSample**, long*, long*, uint, int>)(lpVtbl[7]))((IMemAllocatorCallbackTemp*)Unsafe.AsPointer(ref this), ppBuffer, pStartTime, pEndTime, dwFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ReleaseBuffer(IMediaSample* pBuffer)
        {
            return ((delegate* unmanaged<IMemAllocatorCallbackTemp*, IMediaSample*, int>)(lpVtbl[8]))((IMemAllocatorCallbackTemp*)Unsafe.AsPointer(ref this), pBuffer);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetNotify(IMemAllocatorNotifyCallbackTemp* pNotify)
        {
            return ((delegate* unmanaged<IMemAllocatorCallbackTemp*, IMemAllocatorNotifyCallbackTemp*, int>)(lpVtbl[9]))((IMemAllocatorCallbackTemp*)Unsafe.AsPointer(ref this), pNotify);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetFreeCount([NativeTypeName("LONG *")] int* plBuffersFree)
        {
            return ((delegate* unmanaged<IMemAllocatorCallbackTemp*, int*, int>)(lpVtbl[10]))((IMemAllocatorCallbackTemp*)Unsafe.AsPointer(ref this), plBuffersFree);
        }
    }
}
