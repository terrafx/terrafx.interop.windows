// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("379A0CF0-C1DE-11D2-ABF5-00A0C905F375")]
    [NativeTypeName("struct IMemAllocatorCallbackTemp : IMemAllocator")]
    [NativeInheritance("IMemAllocator")]
    public unsafe partial struct IMemAllocatorCallbackTemp
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IMemAllocatorCallbackTemp*, Guid*, void**, int>)(lpVtbl[0]))((IMemAllocatorCallbackTemp*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMemAllocatorCallbackTemp*, uint>)(lpVtbl[1]))((IMemAllocatorCallbackTemp*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMemAllocatorCallbackTemp*, uint>)(lpVtbl[2]))((IMemAllocatorCallbackTemp*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT SetProperties(ALLOCATOR_PROPERTIES* pRequest, ALLOCATOR_PROPERTIES* pActual)
        {
            return ((delegate* unmanaged<IMemAllocatorCallbackTemp*, ALLOCATOR_PROPERTIES*, ALLOCATOR_PROPERTIES*, int>)(lpVtbl[3]))((IMemAllocatorCallbackTemp*)Unsafe.AsPointer(ref this), pRequest, pActual);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetProperties(ALLOCATOR_PROPERTIES* pProps)
        {
            return ((delegate* unmanaged<IMemAllocatorCallbackTemp*, ALLOCATOR_PROPERTIES*, int>)(lpVtbl[4]))((IMemAllocatorCallbackTemp*)Unsafe.AsPointer(ref this), pProps);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT Commit()
        {
            return ((delegate* unmanaged<IMemAllocatorCallbackTemp*, int>)(lpVtbl[5]))((IMemAllocatorCallbackTemp*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT Decommit()
        {
            return ((delegate* unmanaged<IMemAllocatorCallbackTemp*, int>)(lpVtbl[6]))((IMemAllocatorCallbackTemp*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT GetBuffer(IMediaSample** ppBuffer, [NativeTypeName("REFERENCE_TIME *")] long* pStartTime, [NativeTypeName("REFERENCE_TIME *")] long* pEndTime, [NativeTypeName("DWORD")] uint dwFlags)
        {
            return ((delegate* unmanaged<IMemAllocatorCallbackTemp*, IMediaSample**, long*, long*, uint, int>)(lpVtbl[7]))((IMemAllocatorCallbackTemp*)Unsafe.AsPointer(ref this), ppBuffer, pStartTime, pEndTime, dwFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT ReleaseBuffer(IMediaSample* pBuffer)
        {
            return ((delegate* unmanaged<IMemAllocatorCallbackTemp*, IMediaSample*, int>)(lpVtbl[8]))((IMemAllocatorCallbackTemp*)Unsafe.AsPointer(ref this), pBuffer);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT SetNotify(IMemAllocatorNotifyCallbackTemp* pNotify)
        {
            return ((delegate* unmanaged<IMemAllocatorCallbackTemp*, IMemAllocatorNotifyCallbackTemp*, int>)(lpVtbl[9]))((IMemAllocatorCallbackTemp*)Unsafe.AsPointer(ref this), pNotify);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT GetFreeCount([NativeTypeName("LONG *")] int* plBuffersFree)
        {
            return ((delegate* unmanaged<IMemAllocatorCallbackTemp*, int*, int>)(lpVtbl[10]))((IMemAllocatorCallbackTemp*)Unsafe.AsPointer(ref this), plBuffersFree);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IMemAllocatorCallbackTemp*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IMemAllocatorCallbackTemp*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IMemAllocatorCallbackTemp*, uint> Release;

            [NativeTypeName("HRESULT (ALLOCATOR_PROPERTIES *, ALLOCATOR_PROPERTIES *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMemAllocatorCallbackTemp*, ALLOCATOR_PROPERTIES*, ALLOCATOR_PROPERTIES*, int> SetProperties;

            [NativeTypeName("HRESULT (ALLOCATOR_PROPERTIES *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMemAllocatorCallbackTemp*, ALLOCATOR_PROPERTIES*, int> GetProperties;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<IMemAllocatorCallbackTemp*, int> Commit;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<IMemAllocatorCallbackTemp*, int> Decommit;

            [NativeTypeName("HRESULT (IMediaSample **, REFERENCE_TIME *, REFERENCE_TIME *, DWORD) __attribute__((stdcall))")]
            public delegate* unmanaged<IMemAllocatorCallbackTemp*, IMediaSample**, long*, long*, uint, int> GetBuffer;

            [NativeTypeName("HRESULT (IMediaSample *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMemAllocatorCallbackTemp*, IMediaSample*, int> ReleaseBuffer;

            [NativeTypeName("HRESULT (IMemAllocatorNotifyCallbackTemp *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMemAllocatorCallbackTemp*, IMemAllocatorNotifyCallbackTemp*, int> SetNotify;

            [NativeTypeName("HRESULT (LONG *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMemAllocatorCallbackTemp*, int*, int> GetFreeCount;
        }
    }
}
