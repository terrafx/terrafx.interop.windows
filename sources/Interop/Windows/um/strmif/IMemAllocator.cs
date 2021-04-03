// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("56A8689C-0AD4-11CE-B03A-0020AF0BA770")]
    [NativeTypeName("struct IMemAllocator : IUnknown")]
    public unsafe partial struct IMemAllocator
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IMemAllocator*, Guid*, void**, int>)(lpVtbl[0]))((IMemAllocator*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMemAllocator*, uint>)(lpVtbl[1]))((IMemAllocator*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMemAllocator*, uint>)(lpVtbl[2]))((IMemAllocator*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetProperties(ALLOCATOR_PROPERTIES* pRequest, ALLOCATOR_PROPERTIES* pActual)
        {
            return ((delegate* unmanaged<IMemAllocator*, ALLOCATOR_PROPERTIES*, ALLOCATOR_PROPERTIES*, int>)(lpVtbl[3]))((IMemAllocator*)Unsafe.AsPointer(ref this), pRequest, pActual);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetProperties(ALLOCATOR_PROPERTIES* pProps)
        {
            return ((delegate* unmanaged<IMemAllocator*, ALLOCATOR_PROPERTIES*, int>)(lpVtbl[4]))((IMemAllocator*)Unsafe.AsPointer(ref this), pProps);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Commit()
        {
            return ((delegate* unmanaged<IMemAllocator*, int>)(lpVtbl[5]))((IMemAllocator*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Decommit()
        {
            return ((delegate* unmanaged<IMemAllocator*, int>)(lpVtbl[6]))((IMemAllocator*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetBuffer(IMediaSample** ppBuffer, [NativeTypeName("REFERENCE_TIME *")] long* pStartTime, [NativeTypeName("REFERENCE_TIME *")] long* pEndTime, [NativeTypeName("DWORD")] uint dwFlags)
        {
            return ((delegate* unmanaged<IMemAllocator*, IMediaSample**, long*, long*, uint, int>)(lpVtbl[7]))((IMemAllocator*)Unsafe.AsPointer(ref this), ppBuffer, pStartTime, pEndTime, dwFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ReleaseBuffer(IMediaSample* pBuffer)
        {
            return ((delegate* unmanaged<IMemAllocator*, IMediaSample*, int>)(lpVtbl[8]))((IMemAllocator*)Unsafe.AsPointer(ref this), pBuffer);
        }
    }
}
