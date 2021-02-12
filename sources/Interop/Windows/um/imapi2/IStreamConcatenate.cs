// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/imapi2.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("27354146-7F64-5B0F-8F00-5D77AFBE261E")]
    [NativeTypeName("struct IStreamConcatenate : IStream")]
    public unsafe partial struct IStreamConcatenate
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IStreamConcatenate*, Guid*, void**, int>)(lpVtbl[0]))((IStreamConcatenate*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IStreamConcatenate*, uint>)(lpVtbl[1]))((IStreamConcatenate*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IStreamConcatenate*, uint>)(lpVtbl[2]))((IStreamConcatenate*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Read([NativeTypeName("void *")] void* pv, [NativeTypeName("ULONG")] uint cb, [NativeTypeName("ULONG *")] uint* pcbRead)
        {
            return ((delegate* unmanaged<IStreamConcatenate*, void*, uint, uint*, int>)(lpVtbl[3]))((IStreamConcatenate*)Unsafe.AsPointer(ref this), pv, cb, pcbRead);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Write([NativeTypeName("const void *")] void* pv, [NativeTypeName("ULONG")] uint cb, [NativeTypeName("ULONG *")] uint* pcbWritten)
        {
            return ((delegate* unmanaged<IStreamConcatenate*, void*, uint, uint*, int>)(lpVtbl[4]))((IStreamConcatenate*)Unsafe.AsPointer(ref this), pv, cb, pcbWritten);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Seek(LARGE_INTEGER dlibMove, [NativeTypeName("DWORD")] uint dwOrigin, [NativeTypeName("ULARGE_INTEGER *")] ULARGE_INTEGER* plibNewPosition)
        {
            return ((delegate* unmanaged<IStreamConcatenate*, LARGE_INTEGER, uint, ULARGE_INTEGER*, int>)(lpVtbl[5]))((IStreamConcatenate*)Unsafe.AsPointer(ref this), dlibMove, dwOrigin, plibNewPosition);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetSize(ULARGE_INTEGER libNewSize)
        {
            return ((delegate* unmanaged<IStreamConcatenate*, ULARGE_INTEGER, int>)(lpVtbl[6]))((IStreamConcatenate*)Unsafe.AsPointer(ref this), libNewSize);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CopyTo([NativeTypeName("IStream *")] IStream* pstm, ULARGE_INTEGER cb, [NativeTypeName("ULARGE_INTEGER *")] ULARGE_INTEGER* pcbRead, [NativeTypeName("ULARGE_INTEGER *")] ULARGE_INTEGER* pcbWritten)
        {
            return ((delegate* unmanaged<IStreamConcatenate*, IStream*, ULARGE_INTEGER, ULARGE_INTEGER*, ULARGE_INTEGER*, int>)(lpVtbl[7]))((IStreamConcatenate*)Unsafe.AsPointer(ref this), pstm, cb, pcbRead, pcbWritten);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Commit([NativeTypeName("DWORD")] uint grfCommitFlags)
        {
            return ((delegate* unmanaged<IStreamConcatenate*, uint, int>)(lpVtbl[8]))((IStreamConcatenate*)Unsafe.AsPointer(ref this), grfCommitFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Revert()
        {
            return ((delegate* unmanaged<IStreamConcatenate*, int>)(lpVtbl[9]))((IStreamConcatenate*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int LockRegion(ULARGE_INTEGER libOffset, ULARGE_INTEGER cb, [NativeTypeName("DWORD")] uint dwLockType)
        {
            return ((delegate* unmanaged<IStreamConcatenate*, ULARGE_INTEGER, ULARGE_INTEGER, uint, int>)(lpVtbl[10]))((IStreamConcatenate*)Unsafe.AsPointer(ref this), libOffset, cb, dwLockType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int UnlockRegion(ULARGE_INTEGER libOffset, ULARGE_INTEGER cb, [NativeTypeName("DWORD")] uint dwLockType)
        {
            return ((delegate* unmanaged<IStreamConcatenate*, ULARGE_INTEGER, ULARGE_INTEGER, uint, int>)(lpVtbl[11]))((IStreamConcatenate*)Unsafe.AsPointer(ref this), libOffset, cb, dwLockType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Stat([NativeTypeName("STATSTG *")] STATSTG* pstatstg, [NativeTypeName("DWORD")] uint grfStatFlag)
        {
            return ((delegate* unmanaged<IStreamConcatenate*, STATSTG*, uint, int>)(lpVtbl[12]))((IStreamConcatenate*)Unsafe.AsPointer(ref this), pstatstg, grfStatFlag);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Clone([NativeTypeName("IStream **")] IStream** ppstm)
        {
            return ((delegate* unmanaged<IStreamConcatenate*, IStream**, int>)(lpVtbl[13]))((IStreamConcatenate*)Unsafe.AsPointer(ref this), ppstm);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Initialize([NativeTypeName("IStream *")] IStream* stream1, [NativeTypeName("IStream *")] IStream* stream2)
        {
            return ((delegate* unmanaged<IStreamConcatenate*, IStream*, IStream*, int>)(lpVtbl[14]))((IStreamConcatenate*)Unsafe.AsPointer(ref this), stream1, stream2);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Initialize2([NativeTypeName("IStream **")] IStream** streams, [NativeTypeName("ULONG")] uint streamCount)
        {
            return ((delegate* unmanaged<IStreamConcatenate*, IStream**, uint, int>)(lpVtbl[15]))((IStreamConcatenate*)Unsafe.AsPointer(ref this), streams, streamCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Append([NativeTypeName("IStream *")] IStream* stream)
        {
            return ((delegate* unmanaged<IStreamConcatenate*, IStream*, int>)(lpVtbl[16]))((IStreamConcatenate*)Unsafe.AsPointer(ref this), stream);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Append2([NativeTypeName("IStream **")] IStream** streams, [NativeTypeName("ULONG")] uint streamCount)
        {
            return ((delegate* unmanaged<IStreamConcatenate*, IStream**, uint, int>)(lpVtbl[17]))((IStreamConcatenate*)Unsafe.AsPointer(ref this), streams, streamCount);
        }
    }
}
