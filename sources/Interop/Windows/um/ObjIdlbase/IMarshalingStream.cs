// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ObjIdlbase.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("D8F2F5E6-6102-4863-9F26-389A4676EFDE")]
    public unsafe partial struct IMarshalingStream
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IMarshalingStream*, Guid*, void**, int>)(lpVtbl[0]))((IMarshalingStream*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IMarshalingStream*, uint>)(lpVtbl[1]))((IMarshalingStream*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IMarshalingStream*, uint>)(lpVtbl[2]))((IMarshalingStream*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Read([NativeTypeName("void *")] void* pv, [NativeTypeName("ULONG")] uint cb, [NativeTypeName("ULONG *")] uint* pcbRead)
        {
            return ((delegate* stdcall<IMarshalingStream*, void*, uint, uint*, int>)(lpVtbl[3]))((IMarshalingStream*)Unsafe.AsPointer(ref this), pv, cb, pcbRead);
        }

        [return: NativeTypeName("HRESULT")]
        public int Write([NativeTypeName("const void *")] void* pv, [NativeTypeName("ULONG")] uint cb, [NativeTypeName("ULONG *")] uint* pcbWritten)
        {
            return ((delegate* stdcall<IMarshalingStream*, void*, uint, uint*, int>)(lpVtbl[4]))((IMarshalingStream*)Unsafe.AsPointer(ref this), pv, cb, pcbWritten);
        }

        [return: NativeTypeName("HRESULT")]
        public int Seek(LARGE_INTEGER dlibMove, [NativeTypeName("DWORD")] uint dwOrigin, [NativeTypeName("ULARGE_INTEGER *")] ULARGE_INTEGER* plibNewPosition)
        {
            return ((delegate* stdcall<IMarshalingStream*, LARGE_INTEGER, uint, ULARGE_INTEGER*, int>)(lpVtbl[5]))((IMarshalingStream*)Unsafe.AsPointer(ref this), dlibMove, dwOrigin, plibNewPosition);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetSize(ULARGE_INTEGER libNewSize)
        {
            return ((delegate* stdcall<IMarshalingStream*, ULARGE_INTEGER, int>)(lpVtbl[6]))((IMarshalingStream*)Unsafe.AsPointer(ref this), libNewSize);
        }

        [return: NativeTypeName("HRESULT")]
        public int CopyTo([NativeTypeName("IStream *")] IStream* pstm, ULARGE_INTEGER cb, [NativeTypeName("ULARGE_INTEGER *")] ULARGE_INTEGER* pcbRead, [NativeTypeName("ULARGE_INTEGER *")] ULARGE_INTEGER* pcbWritten)
        {
            return ((delegate* stdcall<IMarshalingStream*, IStream*, ULARGE_INTEGER, ULARGE_INTEGER*, ULARGE_INTEGER*, int>)(lpVtbl[7]))((IMarshalingStream*)Unsafe.AsPointer(ref this), pstm, cb, pcbRead, pcbWritten);
        }

        [return: NativeTypeName("HRESULT")]
        public int Commit([NativeTypeName("DWORD")] uint grfCommitFlags)
        {
            return ((delegate* stdcall<IMarshalingStream*, uint, int>)(lpVtbl[8]))((IMarshalingStream*)Unsafe.AsPointer(ref this), grfCommitFlags);
        }

        [return: NativeTypeName("HRESULT")]
        public int Revert()
        {
            return ((delegate* stdcall<IMarshalingStream*, int>)(lpVtbl[9]))((IMarshalingStream*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int LockRegion(ULARGE_INTEGER libOffset, ULARGE_INTEGER cb, [NativeTypeName("DWORD")] uint dwLockType)
        {
            return ((delegate* stdcall<IMarshalingStream*, ULARGE_INTEGER, ULARGE_INTEGER, uint, int>)(lpVtbl[10]))((IMarshalingStream*)Unsafe.AsPointer(ref this), libOffset, cb, dwLockType);
        }

        [return: NativeTypeName("HRESULT")]
        public int UnlockRegion(ULARGE_INTEGER libOffset, ULARGE_INTEGER cb, [NativeTypeName("DWORD")] uint dwLockType)
        {
            return ((delegate* stdcall<IMarshalingStream*, ULARGE_INTEGER, ULARGE_INTEGER, uint, int>)(lpVtbl[11]))((IMarshalingStream*)Unsafe.AsPointer(ref this), libOffset, cb, dwLockType);
        }

        [return: NativeTypeName("HRESULT")]
        public int Stat([NativeTypeName("STATSTG *")] STATSTG* pstatstg, [NativeTypeName("DWORD")] uint grfStatFlag)
        {
            return ((delegate* stdcall<IMarshalingStream*, STATSTG*, uint, int>)(lpVtbl[12]))((IMarshalingStream*)Unsafe.AsPointer(ref this), pstatstg, grfStatFlag);
        }

        [return: NativeTypeName("HRESULT")]
        public int Clone([NativeTypeName("IStream **")] IStream** ppstm)
        {
            return ((delegate* stdcall<IMarshalingStream*, IStream**, int>)(lpVtbl[13]))((IMarshalingStream*)Unsafe.AsPointer(ref this), ppstm);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetMarshalingContextAttribute(CO_MARSHALING_CONTEXT_ATTRIBUTES attribute, [NativeTypeName("ULONG_PTR *")] nuint* pAttributeValue)
        {
            return ((delegate* stdcall<IMarshalingStream*, CO_MARSHALING_CONTEXT_ATTRIBUTES, nuint*, int>)(lpVtbl[14]))((IMarshalingStream*)Unsafe.AsPointer(ref this), attribute, pAttributeValue);
        }
    }
}
