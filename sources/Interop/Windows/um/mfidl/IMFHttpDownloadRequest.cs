// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("F779FDDF-26E7-4270-8A8B-B983D1859DE0")]
    [NativeTypeName("struct IMFHttpDownloadRequest : IUnknown")]
    public unsafe partial struct IMFHttpDownloadRequest
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IMFHttpDownloadRequest*, Guid*, void**, int>)(lpVtbl[0]))((IMFHttpDownloadRequest*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IMFHttpDownloadRequest*, uint>)(lpVtbl[1]))((IMFHttpDownloadRequest*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IMFHttpDownloadRequest*, uint>)(lpVtbl[2]))((IMFHttpDownloadRequest*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int AddHeader([NativeTypeName("LPCWSTR")] ushort* szHeader)
        {
            return ((delegate* stdcall<IMFHttpDownloadRequest*, ushort*, int>)(lpVtbl[3]))((IMFHttpDownloadRequest*)Unsafe.AsPointer(ref this), szHeader);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int BeginSendRequest([NativeTypeName("const BYTE *")] byte* pbPayload, [NativeTypeName("ULONG")] uint cbPayload, [NativeTypeName("IMFAsyncCallback *")] IMFAsyncCallback* pCallback, [NativeTypeName("IUnknown *")] IUnknown* punkState)
        {
            return ((delegate* stdcall<IMFHttpDownloadRequest*, byte*, uint, IMFAsyncCallback*, IUnknown*, int>)(lpVtbl[4]))((IMFHttpDownloadRequest*)Unsafe.AsPointer(ref this), pbPayload, cbPayload, pCallback, punkState);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int EndSendRequest([NativeTypeName("IMFAsyncResult *")] IMFAsyncResult* pResult)
        {
            return ((delegate* stdcall<IMFHttpDownloadRequest*, IMFAsyncResult*, int>)(lpVtbl[5]))((IMFHttpDownloadRequest*)Unsafe.AsPointer(ref this), pResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int BeginReceiveResponse([NativeTypeName("IMFAsyncCallback *")] IMFAsyncCallback* pCallback, [NativeTypeName("IUnknown *")] IUnknown* punkState)
        {
            return ((delegate* stdcall<IMFHttpDownloadRequest*, IMFAsyncCallback*, IUnknown*, int>)(lpVtbl[6]))((IMFHttpDownloadRequest*)Unsafe.AsPointer(ref this), pCallback, punkState);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int EndReceiveResponse([NativeTypeName("IMFAsyncResult *")] IMFAsyncResult* pResult)
        {
            return ((delegate* stdcall<IMFHttpDownloadRequest*, IMFAsyncResult*, int>)(lpVtbl[7]))((IMFHttpDownloadRequest*)Unsafe.AsPointer(ref this), pResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int BeginReadPayload([NativeTypeName("BYTE *")] byte* pb, [NativeTypeName("ULONG")] uint cb, [NativeTypeName("IMFAsyncCallback *")] IMFAsyncCallback* pCallback, [NativeTypeName("IUnknown *")] IUnknown* punkState)
        {
            return ((delegate* stdcall<IMFHttpDownloadRequest*, byte*, uint, IMFAsyncCallback*, IUnknown*, int>)(lpVtbl[8]))((IMFHttpDownloadRequest*)Unsafe.AsPointer(ref this), pb, cb, pCallback, punkState);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int EndReadPayload([NativeTypeName("IMFAsyncResult *")] IMFAsyncResult* pResult, [NativeTypeName("QWORD *")] ulong* pqwOffset, [NativeTypeName("ULONG *")] uint* pcbRead)
        {
            return ((delegate* stdcall<IMFHttpDownloadRequest*, IMFAsyncResult*, ulong*, uint*, int>)(lpVtbl[9]))((IMFHttpDownloadRequest*)Unsafe.AsPointer(ref this), pResult, pqwOffset, pcbRead);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryHeader([NativeTypeName("LPCWSTR")] ushort* szHeaderName, [NativeTypeName("DWORD")] uint dwIndex, [NativeTypeName("LPWSTR *")] ushort** ppszHeaderValue)
        {
            return ((delegate* stdcall<IMFHttpDownloadRequest*, ushort*, uint, ushort**, int>)(lpVtbl[10]))((IMFHttpDownloadRequest*)Unsafe.AsPointer(ref this), szHeaderName, dwIndex, ppszHeaderValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetURL([NativeTypeName("LPWSTR *")] ushort** ppszURL)
        {
            return ((delegate* stdcall<IMFHttpDownloadRequest*, ushort**, int>)(lpVtbl[11]))((IMFHttpDownloadRequest*)Unsafe.AsPointer(ref this), ppszURL);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int HasNullSourceOrigin([NativeTypeName("BOOL *")] int* pfNullSourceOrigin)
        {
            return ((delegate* stdcall<IMFHttpDownloadRequest*, int*, int>)(lpVtbl[12]))((IMFHttpDownloadRequest*)Unsafe.AsPointer(ref this), pfNullSourceOrigin);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTimeSeekResult([NativeTypeName("QWORD *")] ulong* pqwStartTime, [NativeTypeName("QWORD *")] ulong* pqwStopTime, [NativeTypeName("QWORD *")] ulong* pqwDuration)
        {
            return ((delegate* stdcall<IMFHttpDownloadRequest*, ulong*, ulong*, ulong*, int>)(lpVtbl[13]))((IMFHttpDownloadRequest*)Unsafe.AsPointer(ref this), pqwStartTime, pqwStopTime, pqwDuration);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetHttpStatus([NativeTypeName("DWORD *")] uint* pdwHttpStatus)
        {
            return ((delegate* stdcall<IMFHttpDownloadRequest*, uint*, int>)(lpVtbl[14]))((IMFHttpDownloadRequest*)Unsafe.AsPointer(ref this), pdwHttpStatus);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetAtEndOfPayload([NativeTypeName("BOOL *")] int* pfAtEndOfPayload)
        {
            return ((delegate* stdcall<IMFHttpDownloadRequest*, int*, int>)(lpVtbl[15]))((IMFHttpDownloadRequest*)Unsafe.AsPointer(ref this), pfAtEndOfPayload);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTotalLength([NativeTypeName("QWORD *")] ulong* pqwTotalLength)
        {
            return ((delegate* stdcall<IMFHttpDownloadRequest*, ulong*, int>)(lpVtbl[16]))((IMFHttpDownloadRequest*)Unsafe.AsPointer(ref this), pqwTotalLength);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRangeEndOffset([NativeTypeName("QWORD *")] ulong* pqwRangeEnd)
        {
            return ((delegate* stdcall<IMFHttpDownloadRequest*, ulong*, int>)(lpVtbl[17]))((IMFHttpDownloadRequest*)Unsafe.AsPointer(ref this), pqwRangeEnd);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Close()
        {
            return ((delegate* stdcall<IMFHttpDownloadRequest*, int>)(lpVtbl[18]))((IMFHttpDownloadRequest*)Unsafe.AsPointer(ref this));
        }
    }
}
