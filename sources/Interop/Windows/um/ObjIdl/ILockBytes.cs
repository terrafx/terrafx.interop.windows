// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ObjIdl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("0000000A-0000-0000-C000-000000000046")]
    public unsafe partial struct ILockBytes
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<ILockBytes*, Guid*, void**, int>)(lpVtbl[0]))((ILockBytes*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<ILockBytes*, uint>)(lpVtbl[1]))((ILockBytes*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<ILockBytes*, uint>)(lpVtbl[2]))((ILockBytes*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int ReadAt(ULARGE_INTEGER ulOffset, [NativeTypeName("void *")] void* pv, [NativeTypeName("ULONG")] uint cb, [NativeTypeName("ULONG *")] uint* pcbRead)
        {
            return ((delegate* stdcall<ILockBytes*, ULARGE_INTEGER, void*, uint, uint*, int>)(lpVtbl[3]))((ILockBytes*)Unsafe.AsPointer(ref this), ulOffset, pv, cb, pcbRead);
        }

        [return: NativeTypeName("HRESULT")]
        public int WriteAt(ULARGE_INTEGER ulOffset, [NativeTypeName("const void *")] void* pv, [NativeTypeName("ULONG")] uint cb, [NativeTypeName("ULONG *")] uint* pcbWritten)
        {
            return ((delegate* stdcall<ILockBytes*, ULARGE_INTEGER, void*, uint, uint*, int>)(lpVtbl[4]))((ILockBytes*)Unsafe.AsPointer(ref this), ulOffset, pv, cb, pcbWritten);
        }

        [return: NativeTypeName("HRESULT")]
        public int Flush()
        {
            return ((delegate* stdcall<ILockBytes*, int>)(lpVtbl[5]))((ILockBytes*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetSize(ULARGE_INTEGER cb)
        {
            return ((delegate* stdcall<ILockBytes*, ULARGE_INTEGER, int>)(lpVtbl[6]))((ILockBytes*)Unsafe.AsPointer(ref this), cb);
        }

        [return: NativeTypeName("HRESULT")]
        public int LockRegion(ULARGE_INTEGER libOffset, ULARGE_INTEGER cb, [NativeTypeName("DWORD")] uint dwLockType)
        {
            return ((delegate* stdcall<ILockBytes*, ULARGE_INTEGER, ULARGE_INTEGER, uint, int>)(lpVtbl[7]))((ILockBytes*)Unsafe.AsPointer(ref this), libOffset, cb, dwLockType);
        }

        [return: NativeTypeName("HRESULT")]
        public int UnlockRegion(ULARGE_INTEGER libOffset, ULARGE_INTEGER cb, [NativeTypeName("DWORD")] uint dwLockType)
        {
            return ((delegate* stdcall<ILockBytes*, ULARGE_INTEGER, ULARGE_INTEGER, uint, int>)(lpVtbl[8]))((ILockBytes*)Unsafe.AsPointer(ref this), libOffset, cb, dwLockType);
        }

        [return: NativeTypeName("HRESULT")]
        public int Stat([NativeTypeName("STATSTG *")] STATSTG* pstatstg, [NativeTypeName("DWORD")] uint grfStatFlag)
        {
            return ((delegate* stdcall<ILockBytes*, STATSTG*, uint, int>)(lpVtbl[9]))((ILockBytes*)Unsafe.AsPointer(ref this), pstatstg, grfStatFlag);
        }
    }
}
