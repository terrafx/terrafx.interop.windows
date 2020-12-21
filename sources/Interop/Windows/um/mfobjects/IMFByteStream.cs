// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfobjects.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("AD4C1B00-4BF7-422F-9175-756693D9130D")]
    [NativeTypeName("struct IMFByteStream : IUnknown")]
    public unsafe partial struct IMFByteStream
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IMFByteStream*, Guid*, void**, int>)(lpVtbl[0]))((IMFByteStream*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMFByteStream*, uint>)(lpVtbl[1]))((IMFByteStream*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMFByteStream*, uint>)(lpVtbl[2]))((IMFByteStream*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetCapabilities([NativeTypeName("DWORD *")] uint* pdwCapabilities)
        {
            return ((delegate* unmanaged<IMFByteStream*, uint*, int>)(lpVtbl[3]))((IMFByteStream*)Unsafe.AsPointer(ref this), pdwCapabilities);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetLength([NativeTypeName("QWORD *")] ulong* pqwLength)
        {
            return ((delegate* unmanaged<IMFByteStream*, ulong*, int>)(lpVtbl[4]))((IMFByteStream*)Unsafe.AsPointer(ref this), pqwLength);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetLength([NativeTypeName("QWORD")] ulong qwLength)
        {
            return ((delegate* unmanaged<IMFByteStream*, ulong, int>)(lpVtbl[5]))((IMFByteStream*)Unsafe.AsPointer(ref this), qwLength);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetCurrentPosition([NativeTypeName("QWORD *")] ulong* pqwPosition)
        {
            return ((delegate* unmanaged<IMFByteStream*, ulong*, int>)(lpVtbl[6]))((IMFByteStream*)Unsafe.AsPointer(ref this), pqwPosition);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetCurrentPosition([NativeTypeName("QWORD")] ulong qwPosition)
        {
            return ((delegate* unmanaged<IMFByteStream*, ulong, int>)(lpVtbl[7]))((IMFByteStream*)Unsafe.AsPointer(ref this), qwPosition);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int IsEndOfStream([NativeTypeName("BOOL *")] int* pfEndOfStream)
        {
            return ((delegate* unmanaged<IMFByteStream*, int*, int>)(lpVtbl[8]))((IMFByteStream*)Unsafe.AsPointer(ref this), pfEndOfStream);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Read([NativeTypeName("BYTE *")] byte* pb, [NativeTypeName("ULONG")] uint cb, [NativeTypeName("ULONG *")] uint* pcbRead)
        {
            return ((delegate* unmanaged<IMFByteStream*, byte*, uint, uint*, int>)(lpVtbl[9]))((IMFByteStream*)Unsafe.AsPointer(ref this), pb, cb, pcbRead);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int BeginRead([NativeTypeName("BYTE *")] byte* pb, [NativeTypeName("ULONG")] uint cb, [NativeTypeName("IMFAsyncCallback *")] IMFAsyncCallback* pCallback, [NativeTypeName("IUnknown *")] IUnknown* punkState)
        {
            return ((delegate* unmanaged<IMFByteStream*, byte*, uint, IMFAsyncCallback*, IUnknown*, int>)(lpVtbl[10]))((IMFByteStream*)Unsafe.AsPointer(ref this), pb, cb, pCallback, punkState);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int EndRead([NativeTypeName("IMFAsyncResult *")] IMFAsyncResult* pResult, [NativeTypeName("ULONG *")] uint* pcbRead)
        {
            return ((delegate* unmanaged<IMFByteStream*, IMFAsyncResult*, uint*, int>)(lpVtbl[11]))((IMFByteStream*)Unsafe.AsPointer(ref this), pResult, pcbRead);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Write([NativeTypeName("const BYTE *")] byte* pb, [NativeTypeName("ULONG")] uint cb, [NativeTypeName("ULONG *")] uint* pcbWritten)
        {
            return ((delegate* unmanaged<IMFByteStream*, byte*, uint, uint*, int>)(lpVtbl[12]))((IMFByteStream*)Unsafe.AsPointer(ref this), pb, cb, pcbWritten);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int BeginWrite([NativeTypeName("const BYTE *")] byte* pb, [NativeTypeName("ULONG")] uint cb, [NativeTypeName("IMFAsyncCallback *")] IMFAsyncCallback* pCallback, [NativeTypeName("IUnknown *")] IUnknown* punkState)
        {
            return ((delegate* unmanaged<IMFByteStream*, byte*, uint, IMFAsyncCallback*, IUnknown*, int>)(lpVtbl[13]))((IMFByteStream*)Unsafe.AsPointer(ref this), pb, cb, pCallback, punkState);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int EndWrite([NativeTypeName("IMFAsyncResult *")] IMFAsyncResult* pResult, [NativeTypeName("ULONG *")] uint* pcbWritten)
        {
            return ((delegate* unmanaged<IMFByteStream*, IMFAsyncResult*, uint*, int>)(lpVtbl[14]))((IMFByteStream*)Unsafe.AsPointer(ref this), pResult, pcbWritten);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Seek(MFBYTESTREAM_SEEK_ORIGIN SeekOrigin, [NativeTypeName("LONGLONG")] long llSeekOffset, [NativeTypeName("DWORD")] uint dwSeekFlags, [NativeTypeName("QWORD *")] ulong* pqwCurrentPosition)
        {
            return ((delegate* unmanaged<IMFByteStream*, MFBYTESTREAM_SEEK_ORIGIN, long, uint, ulong*, int>)(lpVtbl[15]))((IMFByteStream*)Unsafe.AsPointer(ref this), SeekOrigin, llSeekOffset, dwSeekFlags, pqwCurrentPosition);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Flush()
        {
            return ((delegate* unmanaged<IMFByteStream*, int>)(lpVtbl[16]))((IMFByteStream*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Close()
        {
            return ((delegate* unmanaged<IMFByteStream*, int>)(lpVtbl[17]))((IMFByteStream*)Unsafe.AsPointer(ref this));
        }
    }
}
