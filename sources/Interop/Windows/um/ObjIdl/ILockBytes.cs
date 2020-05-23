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
        public Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(ILockBytes* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(ILockBytes* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(ILockBytes* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _ReadAt(ILockBytes* pThis, ULARGE_INTEGER ulOffset, [NativeTypeName("void *")] void* pv, [NativeTypeName("ULONG")] uint cb, [NativeTypeName("ULONG *")] uint* pcbRead);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _WriteAt(ILockBytes* pThis, ULARGE_INTEGER ulOffset, [NativeTypeName("const void *")] void* pv, [NativeTypeName("ULONG")] uint cb, [NativeTypeName("ULONG *")] uint* pcbWritten);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Flush(ILockBytes* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetSize(ILockBytes* pThis, ULARGE_INTEGER cb);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _LockRegion(ILockBytes* pThis, ULARGE_INTEGER libOffset, ULARGE_INTEGER cb, [NativeTypeName("DWORD")] uint dwLockType);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _UnlockRegion(ILockBytes* pThis, ULARGE_INTEGER libOffset, ULARGE_INTEGER cb, [NativeTypeName("DWORD")] uint dwLockType);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Stat(ILockBytes* pThis, [NativeTypeName("STATSTG *")] STATSTG* pstatstg, [NativeTypeName("DWORD")] uint grfStatFlag);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((ILockBytes*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((ILockBytes*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((ILockBytes*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int ReadAt(ULARGE_INTEGER ulOffset, [NativeTypeName("void *")] void* pv, [NativeTypeName("ULONG")] uint cb, [NativeTypeName("ULONG *")] uint* pcbRead)
        {
            return Marshal.GetDelegateForFunctionPointer<_ReadAt>(lpVtbl->ReadAt)((ILockBytes*)Unsafe.AsPointer(ref this), ulOffset, pv, cb, pcbRead);
        }

        [return: NativeTypeName("HRESULT")]
        public int WriteAt(ULARGE_INTEGER ulOffset, [NativeTypeName("const void *")] void* pv, [NativeTypeName("ULONG")] uint cb, [NativeTypeName("ULONG *")] uint* pcbWritten)
        {
            return Marshal.GetDelegateForFunctionPointer<_WriteAt>(lpVtbl->WriteAt)((ILockBytes*)Unsafe.AsPointer(ref this), ulOffset, pv, cb, pcbWritten);
        }

        [return: NativeTypeName("HRESULT")]
        public int Flush()
        {
            return Marshal.GetDelegateForFunctionPointer<_Flush>(lpVtbl->Flush)((ILockBytes*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetSize(ULARGE_INTEGER cb)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetSize>(lpVtbl->SetSize)((ILockBytes*)Unsafe.AsPointer(ref this), cb);
        }

        [return: NativeTypeName("HRESULT")]
        public int LockRegion(ULARGE_INTEGER libOffset, ULARGE_INTEGER cb, [NativeTypeName("DWORD")] uint dwLockType)
        {
            return Marshal.GetDelegateForFunctionPointer<_LockRegion>(lpVtbl->LockRegion)((ILockBytes*)Unsafe.AsPointer(ref this), libOffset, cb, dwLockType);
        }

        [return: NativeTypeName("HRESULT")]
        public int UnlockRegion(ULARGE_INTEGER libOffset, ULARGE_INTEGER cb, [NativeTypeName("DWORD")] uint dwLockType)
        {
            return Marshal.GetDelegateForFunctionPointer<_UnlockRegion>(lpVtbl->UnlockRegion)((ILockBytes*)Unsafe.AsPointer(ref this), libOffset, cb, dwLockType);
        }

        [return: NativeTypeName("HRESULT")]
        public int Stat([NativeTypeName("STATSTG *")] STATSTG* pstatstg, [NativeTypeName("DWORD")] uint grfStatFlag)
        {
            return Marshal.GetDelegateForFunctionPointer<_Stat>(lpVtbl->Stat)((ILockBytes*)Unsafe.AsPointer(ref this), pstatstg, grfStatFlag);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Release;

            [NativeTypeName("HRESULT (ULARGE_INTEGER, void *, ULONG, ULONG *) __attribute__((stdcall))")]
            public IntPtr ReadAt;

            [NativeTypeName("HRESULT (ULARGE_INTEGER, const void *, ULONG, ULONG *) __attribute__((stdcall))")]
            public IntPtr WriteAt;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public IntPtr Flush;

            [NativeTypeName("HRESULT (ULARGE_INTEGER) __attribute__((stdcall))")]
            public IntPtr SetSize;

            [NativeTypeName("HRESULT (ULARGE_INTEGER, ULARGE_INTEGER, DWORD) __attribute__((stdcall))")]
            public IntPtr LockRegion;

            [NativeTypeName("HRESULT (ULARGE_INTEGER, ULARGE_INTEGER, DWORD) __attribute__((stdcall))")]
            public IntPtr UnlockRegion;

            [NativeTypeName("HRESULT (STATSTG *, DWORD) __attribute__((stdcall))")]
            public IntPtr Stat;
        }
    }
}
