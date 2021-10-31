// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("F779FDDF-26E7-4270-8A8B-B983D1859DE0")]
    [NativeTypeName("struct IMFHttpDownloadRequest : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IMFHttpDownloadRequest
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IMFHttpDownloadRequest*, Guid*, void**, int>)(lpVtbl[0]))((IMFHttpDownloadRequest*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMFHttpDownloadRequest*, uint>)(lpVtbl[1]))((IMFHttpDownloadRequest*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMFHttpDownloadRequest*, uint>)(lpVtbl[2]))((IMFHttpDownloadRequest*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT AddHeader([NativeTypeName("LPCWSTR")] ushort* szHeader)
        {
            return ((delegate* unmanaged<IMFHttpDownloadRequest*, ushort*, int>)(lpVtbl[3]))((IMFHttpDownloadRequest*)Unsafe.AsPointer(ref this), szHeader);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT BeginSendRequest([NativeTypeName("const BYTE *")] byte* pbPayload, [NativeTypeName("ULONG")] uint cbPayload, IMFAsyncCallback* pCallback, IUnknown* punkState)
        {
            return ((delegate* unmanaged<IMFHttpDownloadRequest*, byte*, uint, IMFAsyncCallback*, IUnknown*, int>)(lpVtbl[4]))((IMFHttpDownloadRequest*)Unsafe.AsPointer(ref this), pbPayload, cbPayload, pCallback, punkState);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT EndSendRequest(IMFAsyncResult* pResult)
        {
            return ((delegate* unmanaged<IMFHttpDownloadRequest*, IMFAsyncResult*, int>)(lpVtbl[5]))((IMFHttpDownloadRequest*)Unsafe.AsPointer(ref this), pResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT BeginReceiveResponse(IMFAsyncCallback* pCallback, IUnknown* punkState)
        {
            return ((delegate* unmanaged<IMFHttpDownloadRequest*, IMFAsyncCallback*, IUnknown*, int>)(lpVtbl[6]))((IMFHttpDownloadRequest*)Unsafe.AsPointer(ref this), pCallback, punkState);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT EndReceiveResponse(IMFAsyncResult* pResult)
        {
            return ((delegate* unmanaged<IMFHttpDownloadRequest*, IMFAsyncResult*, int>)(lpVtbl[7]))((IMFHttpDownloadRequest*)Unsafe.AsPointer(ref this), pResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT BeginReadPayload([NativeTypeName("BYTE *")] byte* pb, [NativeTypeName("ULONG")] uint cb, IMFAsyncCallback* pCallback, IUnknown* punkState)
        {
            return ((delegate* unmanaged<IMFHttpDownloadRequest*, byte*, uint, IMFAsyncCallback*, IUnknown*, int>)(lpVtbl[8]))((IMFHttpDownloadRequest*)Unsafe.AsPointer(ref this), pb, cb, pCallback, punkState);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT EndReadPayload(IMFAsyncResult* pResult, [NativeTypeName("QWORD *")] ulong* pqwOffset, [NativeTypeName("ULONG *")] uint* pcbRead)
        {
            return ((delegate* unmanaged<IMFHttpDownloadRequest*, IMFAsyncResult*, ulong*, uint*, int>)(lpVtbl[9]))((IMFHttpDownloadRequest*)Unsafe.AsPointer(ref this), pResult, pqwOffset, pcbRead);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT QueryHeader([NativeTypeName("LPCWSTR")] ushort* szHeaderName, [NativeTypeName("DWORD")] uint dwIndex, [NativeTypeName("LPWSTR *")] ushort** ppszHeaderValue)
        {
            return ((delegate* unmanaged<IMFHttpDownloadRequest*, ushort*, uint, ushort**, int>)(lpVtbl[10]))((IMFHttpDownloadRequest*)Unsafe.AsPointer(ref this), szHeaderName, dwIndex, ppszHeaderValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT GetURL([NativeTypeName("LPWSTR *")] ushort** ppszURL)
        {
            return ((delegate* unmanaged<IMFHttpDownloadRequest*, ushort**, int>)(lpVtbl[11]))((IMFHttpDownloadRequest*)Unsafe.AsPointer(ref this), ppszURL);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT HasNullSourceOrigin(BOOL* pfNullSourceOrigin)
        {
            return ((delegate* unmanaged<IMFHttpDownloadRequest*, BOOL*, int>)(lpVtbl[12]))((IMFHttpDownloadRequest*)Unsafe.AsPointer(ref this), pfNullSourceOrigin);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT GetTimeSeekResult([NativeTypeName("QWORD *")] ulong* pqwStartTime, [NativeTypeName("QWORD *")] ulong* pqwStopTime, [NativeTypeName("QWORD *")] ulong* pqwDuration)
        {
            return ((delegate* unmanaged<IMFHttpDownloadRequest*, ulong*, ulong*, ulong*, int>)(lpVtbl[13]))((IMFHttpDownloadRequest*)Unsafe.AsPointer(ref this), pqwStartTime, pqwStopTime, pqwDuration);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HRESULT GetHttpStatus([NativeTypeName("DWORD *")] uint* pdwHttpStatus)
        {
            return ((delegate* unmanaged<IMFHttpDownloadRequest*, uint*, int>)(lpVtbl[14]))((IMFHttpDownloadRequest*)Unsafe.AsPointer(ref this), pdwHttpStatus);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public HRESULT GetAtEndOfPayload(BOOL* pfAtEndOfPayload)
        {
            return ((delegate* unmanaged<IMFHttpDownloadRequest*, BOOL*, int>)(lpVtbl[15]))((IMFHttpDownloadRequest*)Unsafe.AsPointer(ref this), pfAtEndOfPayload);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        public HRESULT GetTotalLength([NativeTypeName("QWORD *")] ulong* pqwTotalLength)
        {
            return ((delegate* unmanaged<IMFHttpDownloadRequest*, ulong*, int>)(lpVtbl[16]))((IMFHttpDownloadRequest*)Unsafe.AsPointer(ref this), pqwTotalLength);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        public HRESULT GetRangeEndOffset([NativeTypeName("QWORD *")] ulong* pqwRangeEnd)
        {
            return ((delegate* unmanaged<IMFHttpDownloadRequest*, ulong*, int>)(lpVtbl[17]))((IMFHttpDownloadRequest*)Unsafe.AsPointer(ref this), pqwRangeEnd);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        public HRESULT Close()
        {
            return ((delegate* unmanaged<IMFHttpDownloadRequest*, int>)(lpVtbl[18]))((IMFHttpDownloadRequest*)Unsafe.AsPointer(ref this));
        }
    }
}
