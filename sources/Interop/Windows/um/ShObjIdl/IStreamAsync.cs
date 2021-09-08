// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("FE0B6665-E0CA-49B9-A178-2B5CB48D92A5")]
    [NativeTypeName("struct IStreamAsync : IStream")]
    [NativeInheritance("IStream")]
    public unsafe partial struct IStreamAsync
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IStreamAsync*, Guid*, void**, int>)(lpVtbl[0]))((IStreamAsync*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IStreamAsync*, uint>)(lpVtbl[1]))((IStreamAsync*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IStreamAsync*, uint>)(lpVtbl[2]))((IStreamAsync*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int Read(void* pv, [NativeTypeName("ULONG")] uint cb, [NativeTypeName("ULONG *")] uint* pcbRead)
        {
            return ((delegate* unmanaged<IStreamAsync*, void*, uint, uint*, int>)(lpVtbl[3]))((IStreamAsync*)Unsafe.AsPointer(ref this), pv, cb, pcbRead);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int Write([NativeTypeName("const void *")] void* pv, [NativeTypeName("ULONG")] uint cb, [NativeTypeName("ULONG *")] uint* pcbWritten)
        {
            return ((delegate* unmanaged<IStreamAsync*, void*, uint, uint*, int>)(lpVtbl[4]))((IStreamAsync*)Unsafe.AsPointer(ref this), pv, cb, pcbWritten);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int Seek(LARGE_INTEGER dlibMove, [NativeTypeName("DWORD")] uint dwOrigin, ULARGE_INTEGER* plibNewPosition)
        {
            return ((delegate* unmanaged<IStreamAsync*, LARGE_INTEGER, uint, ULARGE_INTEGER*, int>)(lpVtbl[5]))((IStreamAsync*)Unsafe.AsPointer(ref this), dlibMove, dwOrigin, plibNewPosition);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int SetSize(ULARGE_INTEGER libNewSize)
        {
            return ((delegate* unmanaged<IStreamAsync*, ULARGE_INTEGER, int>)(lpVtbl[6]))((IStreamAsync*)Unsafe.AsPointer(ref this), libNewSize);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int CopyTo(IStream* pstm, ULARGE_INTEGER cb, ULARGE_INTEGER* pcbRead, ULARGE_INTEGER* pcbWritten)
        {
            return ((delegate* unmanaged<IStreamAsync*, IStream*, ULARGE_INTEGER, ULARGE_INTEGER*, ULARGE_INTEGER*, int>)(lpVtbl[7]))((IStreamAsync*)Unsafe.AsPointer(ref this), pstm, cb, pcbRead, pcbWritten);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int Commit([NativeTypeName("DWORD")] uint grfCommitFlags)
        {
            return ((delegate* unmanaged<IStreamAsync*, uint, int>)(lpVtbl[8]))((IStreamAsync*)Unsafe.AsPointer(ref this), grfCommitFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("HRESULT")]
        public int Revert()
        {
            return ((delegate* unmanaged<IStreamAsync*, int>)(lpVtbl[9]))((IStreamAsync*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        [return: NativeTypeName("HRESULT")]
        public int LockRegion(ULARGE_INTEGER libOffset, ULARGE_INTEGER cb, [NativeTypeName("DWORD")] uint dwLockType)
        {
            return ((delegate* unmanaged<IStreamAsync*, ULARGE_INTEGER, ULARGE_INTEGER, uint, int>)(lpVtbl[10]))((IStreamAsync*)Unsafe.AsPointer(ref this), libOffset, cb, dwLockType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        [return: NativeTypeName("HRESULT")]
        public int UnlockRegion(ULARGE_INTEGER libOffset, ULARGE_INTEGER cb, [NativeTypeName("DWORD")] uint dwLockType)
        {
            return ((delegate* unmanaged<IStreamAsync*, ULARGE_INTEGER, ULARGE_INTEGER, uint, int>)(lpVtbl[11]))((IStreamAsync*)Unsafe.AsPointer(ref this), libOffset, cb, dwLockType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        [return: NativeTypeName("HRESULT")]
        public int Stat(STATSTG* pstatstg, [NativeTypeName("DWORD")] uint grfStatFlag)
        {
            return ((delegate* unmanaged<IStreamAsync*, STATSTG*, uint, int>)(lpVtbl[12]))((IStreamAsync*)Unsafe.AsPointer(ref this), pstatstg, grfStatFlag);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        [return: NativeTypeName("HRESULT")]
        public int Clone(IStream** ppstm)
        {
            return ((delegate* unmanaged<IStreamAsync*, IStream**, int>)(lpVtbl[13]))((IStreamAsync*)Unsafe.AsPointer(ref this), ppstm);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        [return: NativeTypeName("HRESULT")]
        public int ReadAsync(void* pv, [NativeTypeName("DWORD")] uint cb, [NativeTypeName("LPDWORD")] uint* pcbRead, [NativeTypeName("LPOVERLAPPED")] OVERLAPPED* lpOverlapped)
        {
            return ((delegate* unmanaged<IStreamAsync*, void*, uint, uint*, OVERLAPPED*, int>)(lpVtbl[14]))((IStreamAsync*)Unsafe.AsPointer(ref this), pv, cb, pcbRead, lpOverlapped);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        [return: NativeTypeName("HRESULT")]
        public int WriteAsync([NativeTypeName("const void *")] void* lpBuffer, [NativeTypeName("DWORD")] uint cb, [NativeTypeName("LPDWORD")] uint* pcbWritten, [NativeTypeName("LPOVERLAPPED")] OVERLAPPED* lpOverlapped)
        {
            return ((delegate* unmanaged<IStreamAsync*, void*, uint, uint*, OVERLAPPED*, int>)(lpVtbl[15]))((IStreamAsync*)Unsafe.AsPointer(ref this), lpBuffer, cb, pcbWritten, lpOverlapped);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        [return: NativeTypeName("HRESULT")]
        public int OverlappedResult([NativeTypeName("LPOVERLAPPED")] OVERLAPPED* lpOverlapped, [NativeTypeName("LPDWORD")] uint* lpNumberOfBytesTransferred, [NativeTypeName("BOOL")] int bWait)
        {
            return ((delegate* unmanaged<IStreamAsync*, OVERLAPPED*, uint*, int, int>)(lpVtbl[16]))((IStreamAsync*)Unsafe.AsPointer(ref this), lpOverlapped, lpNumberOfBytesTransferred, bWait);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        [return: NativeTypeName("HRESULT")]
        public int CancelIo()
        {
            return ((delegate* unmanaged<IStreamAsync*, int>)(lpVtbl[17]))((IStreamAsync*)Unsafe.AsPointer(ref this));
        }
    }
}
