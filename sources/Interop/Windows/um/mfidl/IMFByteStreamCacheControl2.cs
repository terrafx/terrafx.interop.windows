// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("71CE469C-F34B-49EA-A56B-2D2A10E51149")]
    [NativeTypeName("struct IMFByteStreamCacheControl2 : IMFByteStreamCacheControl")]
    [NativeInheritance("IMFByteStreamCacheControl")]
    public unsafe partial struct IMFByteStreamCacheControl2 : IMFByteStreamCacheControl2.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IMFByteStreamCacheControl2*, Guid*, void**, int>)(lpVtbl[0]))((IMFByteStreamCacheControl2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMFByteStreamCacheControl2*, uint>)(lpVtbl[1]))((IMFByteStreamCacheControl2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMFByteStreamCacheControl2*, uint>)(lpVtbl[2]))((IMFByteStreamCacheControl2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT StopBackgroundTransfer()
        {
            return ((delegate* unmanaged<IMFByteStreamCacheControl2*, int>)(lpVtbl[3]))((IMFByteStreamCacheControl2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetByteRanges([NativeTypeName("DWORD *")] uint* pcRanges, MF_BYTE_STREAM_CACHE_RANGE** ppRanges)
        {
            return ((delegate* unmanaged<IMFByteStreamCacheControl2*, uint*, MF_BYTE_STREAM_CACHE_RANGE**, int>)(lpVtbl[4]))((IMFByteStreamCacheControl2*)Unsafe.AsPointer(ref this), pcRanges, ppRanges);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT SetCacheLimit([NativeTypeName("QWORD")] ulong qwBytes)
        {
            return ((delegate* unmanaged<IMFByteStreamCacheControl2*, ulong, int>)(lpVtbl[5]))((IMFByteStreamCacheControl2*)Unsafe.AsPointer(ref this), qwBytes);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT IsBackgroundTransferActive(BOOL* pfActive)
        {
            return ((delegate* unmanaged<IMFByteStreamCacheControl2*, BOOL*, int>)(lpVtbl[6]))((IMFByteStreamCacheControl2*)Unsafe.AsPointer(ref this), pfActive);
        }

        public interface Interface : IMFByteStreamCacheControl.Interface
        {
            [VtblIndex(4)]
            HRESULT GetByteRanges([NativeTypeName("DWORD *")] uint* pcRanges, MF_BYTE_STREAM_CACHE_RANGE** ppRanges);

            [VtblIndex(5)]
            HRESULT SetCacheLimit([NativeTypeName("QWORD")] ulong qwBytes);

            [VtblIndex(6)]
            HRESULT IsBackgroundTransferActive(BOOL* pfActive);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFByteStreamCacheControl2*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IMFByteStreamCacheControl2*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IMFByteStreamCacheControl2*, uint> Release;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<IMFByteStreamCacheControl2*, int> StopBackgroundTransfer;

            [NativeTypeName("HRESULT (DWORD *, MF_BYTE_STREAM_CACHE_RANGE **) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFByteStreamCacheControl2*, uint*, MF_BYTE_STREAM_CACHE_RANGE**, int> GetByteRanges;

            [NativeTypeName("HRESULT (QWORD) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFByteStreamCacheControl2*, ulong, int> SetCacheLimit;

            [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFByteStreamCacheControl2*, BOOL*, int> IsBackgroundTransferActive;
        }
    }
}
