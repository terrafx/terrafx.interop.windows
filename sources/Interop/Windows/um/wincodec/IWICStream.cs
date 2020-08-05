// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("135FF860-22B7-4DDF-B0F6-218F4F299A43")]
    [NativeTypeName("struct IWICStream : IStream")]
    public unsafe partial struct IWICStream
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IWICStream*, Guid*, void**, int>)(lpVtbl[0]))((IWICStream*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IWICStream*, uint>)(lpVtbl[1]))((IWICStream*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IWICStream*, uint>)(lpVtbl[2]))((IWICStream*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Read([NativeTypeName("void *")] void* pv, [NativeTypeName("ULONG")] uint cb, [NativeTypeName("ULONG *")] uint* pcbRead)
        {
            return ((delegate* stdcall<IWICStream*, void*, uint, uint*, int>)(lpVtbl[3]))((IWICStream*)Unsafe.AsPointer(ref this), pv, cb, pcbRead);
        }

        [return: NativeTypeName("HRESULT")]
        public int Write([NativeTypeName("const void *")] void* pv, [NativeTypeName("ULONG")] uint cb, [NativeTypeName("ULONG *")] uint* pcbWritten)
        {
            return ((delegate* stdcall<IWICStream*, void*, uint, uint*, int>)(lpVtbl[4]))((IWICStream*)Unsafe.AsPointer(ref this), pv, cb, pcbWritten);
        }

        [return: NativeTypeName("HRESULT")]
        public int Seek(LARGE_INTEGER dlibMove, [NativeTypeName("DWORD")] uint dwOrigin, [NativeTypeName("ULARGE_INTEGER *")] ULARGE_INTEGER* plibNewPosition)
        {
            return ((delegate* stdcall<IWICStream*, LARGE_INTEGER, uint, ULARGE_INTEGER*, int>)(lpVtbl[5]))((IWICStream*)Unsafe.AsPointer(ref this), dlibMove, dwOrigin, plibNewPosition);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetSize(ULARGE_INTEGER libNewSize)
        {
            return ((delegate* stdcall<IWICStream*, ULARGE_INTEGER, int>)(lpVtbl[6]))((IWICStream*)Unsafe.AsPointer(ref this), libNewSize);
        }

        [return: NativeTypeName("HRESULT")]
        public int CopyTo([NativeTypeName("IStream *")] IStream* pstm, ULARGE_INTEGER cb, [NativeTypeName("ULARGE_INTEGER *")] ULARGE_INTEGER* pcbRead, [NativeTypeName("ULARGE_INTEGER *")] ULARGE_INTEGER* pcbWritten)
        {
            return ((delegate* stdcall<IWICStream*, IStream*, ULARGE_INTEGER, ULARGE_INTEGER*, ULARGE_INTEGER*, int>)(lpVtbl[7]))((IWICStream*)Unsafe.AsPointer(ref this), pstm, cb, pcbRead, pcbWritten);
        }

        [return: NativeTypeName("HRESULT")]
        public int Commit([NativeTypeName("DWORD")] uint grfCommitFlags)
        {
            return ((delegate* stdcall<IWICStream*, uint, int>)(lpVtbl[8]))((IWICStream*)Unsafe.AsPointer(ref this), grfCommitFlags);
        }

        [return: NativeTypeName("HRESULT")]
        public int Revert()
        {
            return ((delegate* stdcall<IWICStream*, int>)(lpVtbl[9]))((IWICStream*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int LockRegion(ULARGE_INTEGER libOffset, ULARGE_INTEGER cb, [NativeTypeName("DWORD")] uint dwLockType)
        {
            return ((delegate* stdcall<IWICStream*, ULARGE_INTEGER, ULARGE_INTEGER, uint, int>)(lpVtbl[10]))((IWICStream*)Unsafe.AsPointer(ref this), libOffset, cb, dwLockType);
        }

        [return: NativeTypeName("HRESULT")]
        public int UnlockRegion(ULARGE_INTEGER libOffset, ULARGE_INTEGER cb, [NativeTypeName("DWORD")] uint dwLockType)
        {
            return ((delegate* stdcall<IWICStream*, ULARGE_INTEGER, ULARGE_INTEGER, uint, int>)(lpVtbl[11]))((IWICStream*)Unsafe.AsPointer(ref this), libOffset, cb, dwLockType);
        }

        [return: NativeTypeName("HRESULT")]
        public int Stat([NativeTypeName("STATSTG *")] STATSTG* pstatstg, [NativeTypeName("DWORD")] uint grfStatFlag)
        {
            return ((delegate* stdcall<IWICStream*, STATSTG*, uint, int>)(lpVtbl[12]))((IWICStream*)Unsafe.AsPointer(ref this), pstatstg, grfStatFlag);
        }

        [return: NativeTypeName("HRESULT")]
        public int Clone([NativeTypeName("IStream **")] IStream** ppstm)
        {
            return ((delegate* stdcall<IWICStream*, IStream**, int>)(lpVtbl[13]))((IWICStream*)Unsafe.AsPointer(ref this), ppstm);
        }

        [return: NativeTypeName("HRESULT")]
        public int InitializeFromIStream([NativeTypeName("IStream *")] IStream* pIStream)
        {
            return ((delegate* stdcall<IWICStream*, IStream*, int>)(lpVtbl[14]))((IWICStream*)Unsafe.AsPointer(ref this), pIStream);
        }

        [return: NativeTypeName("HRESULT")]
        public int InitializeFromFilename([NativeTypeName("LPCWSTR")] ushort* wzFileName, [NativeTypeName("DWORD")] uint dwDesiredAccess)
        {
            return ((delegate* stdcall<IWICStream*, ushort*, uint, int>)(lpVtbl[15]))((IWICStream*)Unsafe.AsPointer(ref this), wzFileName, dwDesiredAccess);
        }

        [return: NativeTypeName("HRESULT")]
        public int InitializeFromMemory([NativeTypeName("WICInProcPointer")] byte* pbBuffer, [NativeTypeName("DWORD")] uint cbBufferSize)
        {
            return ((delegate* stdcall<IWICStream*, byte*, uint, int>)(lpVtbl[16]))((IWICStream*)Unsafe.AsPointer(ref this), pbBuffer, cbBufferSize);
        }

        [return: NativeTypeName("HRESULT")]
        public int InitializeFromIStreamRegion([NativeTypeName("IStream *")] IStream* pIStream, ULARGE_INTEGER ulOffset, ULARGE_INTEGER ulMaxSize)
        {
            return ((delegate* stdcall<IWICStream*, IStream*, ULARGE_INTEGER, ULARGE_INTEGER, int>)(lpVtbl[17]))((IWICStream*)Unsafe.AsPointer(ref this), pIStream, ulOffset, ulMaxSize);
        }
    }
}
