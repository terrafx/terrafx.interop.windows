// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ObjIdlbase.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("0000000C-0000-0000-C000-000000000046")]
    public unsafe partial struct IStream
    {
        public Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IStream* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IStream* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IStream* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Read(IStream* pThis, [NativeTypeName("void *")] void* pv, [NativeTypeName("ULONG")] uint cb, [NativeTypeName("ULONG *")] uint* pcbRead);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Write(IStream* pThis, [NativeTypeName("const void *")] void* pv, [NativeTypeName("ULONG")] uint cb, [NativeTypeName("ULONG *")] uint* pcbWritten);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Seek(IStream* pThis, LARGE_INTEGER dlibMove, [NativeTypeName("DWORD")] uint dwOrigin, [NativeTypeName("ULARGE_INTEGER *")] ULARGE_INTEGER* plibNewPosition);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetSize(IStream* pThis, ULARGE_INTEGER libNewSize);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CopyTo(IStream* pThis, [NativeTypeName("IStream *")] IStream* pstm, ULARGE_INTEGER cb, [NativeTypeName("ULARGE_INTEGER *")] ULARGE_INTEGER* pcbRead, [NativeTypeName("ULARGE_INTEGER *")] ULARGE_INTEGER* pcbWritten);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Commit(IStream* pThis, [NativeTypeName("DWORD")] uint grfCommitFlags);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Revert(IStream* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _LockRegion(IStream* pThis, ULARGE_INTEGER libOffset, ULARGE_INTEGER cb, [NativeTypeName("DWORD")] uint dwLockType);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _UnlockRegion(IStream* pThis, ULARGE_INTEGER libOffset, ULARGE_INTEGER cb, [NativeTypeName("DWORD")] uint dwLockType);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Stat(IStream* pThis, [NativeTypeName("STATSTG *")] STATSTG* pstatstg, [NativeTypeName("DWORD")] uint grfStatFlag);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Clone(IStream* pThis, [NativeTypeName("IStream **")] IStream** ppstm);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((IStream*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((IStream*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((IStream*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Read([NativeTypeName("void *")] void* pv, [NativeTypeName("ULONG")] uint cb, [NativeTypeName("ULONG *")] uint* pcbRead)
        {
            return Marshal.GetDelegateForFunctionPointer<_Read>(lpVtbl->Read)((IStream*)Unsafe.AsPointer(ref this), pv, cb, pcbRead);
        }

        [return: NativeTypeName("HRESULT")]
        public int Write([NativeTypeName("const void *")] void* pv, [NativeTypeName("ULONG")] uint cb, [NativeTypeName("ULONG *")] uint* pcbWritten)
        {
            return Marshal.GetDelegateForFunctionPointer<_Write>(lpVtbl->Write)((IStream*)Unsafe.AsPointer(ref this), pv, cb, pcbWritten);
        }

        [return: NativeTypeName("HRESULT")]
        public int Seek(LARGE_INTEGER dlibMove, [NativeTypeName("DWORD")] uint dwOrigin, [NativeTypeName("ULARGE_INTEGER *")] ULARGE_INTEGER* plibNewPosition)
        {
            return Marshal.GetDelegateForFunctionPointer<_Seek>(lpVtbl->Seek)((IStream*)Unsafe.AsPointer(ref this), dlibMove, dwOrigin, plibNewPosition);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetSize(ULARGE_INTEGER libNewSize)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetSize>(lpVtbl->SetSize)((IStream*)Unsafe.AsPointer(ref this), libNewSize);
        }

        [return: NativeTypeName("HRESULT")]
        public int CopyTo([NativeTypeName("IStream *")] IStream* pstm, ULARGE_INTEGER cb, [NativeTypeName("ULARGE_INTEGER *")] ULARGE_INTEGER* pcbRead, [NativeTypeName("ULARGE_INTEGER *")] ULARGE_INTEGER* pcbWritten)
        {
            return Marshal.GetDelegateForFunctionPointer<_CopyTo>(lpVtbl->CopyTo)((IStream*)Unsafe.AsPointer(ref this), pstm, cb, pcbRead, pcbWritten);
        }

        [return: NativeTypeName("HRESULT")]
        public int Commit([NativeTypeName("DWORD")] uint grfCommitFlags)
        {
            return Marshal.GetDelegateForFunctionPointer<_Commit>(lpVtbl->Commit)((IStream*)Unsafe.AsPointer(ref this), grfCommitFlags);
        }

        [return: NativeTypeName("HRESULT")]
        public int Revert()
        {
            return Marshal.GetDelegateForFunctionPointer<_Revert>(lpVtbl->Revert)((IStream*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int LockRegion(ULARGE_INTEGER libOffset, ULARGE_INTEGER cb, [NativeTypeName("DWORD")] uint dwLockType)
        {
            return Marshal.GetDelegateForFunctionPointer<_LockRegion>(lpVtbl->LockRegion)((IStream*)Unsafe.AsPointer(ref this), libOffset, cb, dwLockType);
        }

        [return: NativeTypeName("HRESULT")]
        public int UnlockRegion(ULARGE_INTEGER libOffset, ULARGE_INTEGER cb, [NativeTypeName("DWORD")] uint dwLockType)
        {
            return Marshal.GetDelegateForFunctionPointer<_UnlockRegion>(lpVtbl->UnlockRegion)((IStream*)Unsafe.AsPointer(ref this), libOffset, cb, dwLockType);
        }

        [return: NativeTypeName("HRESULT")]
        public int Stat([NativeTypeName("STATSTG *")] STATSTG* pstatstg, [NativeTypeName("DWORD")] uint grfStatFlag)
        {
            return Marshal.GetDelegateForFunctionPointer<_Stat>(lpVtbl->Stat)((IStream*)Unsafe.AsPointer(ref this), pstatstg, grfStatFlag);
        }

        [return: NativeTypeName("HRESULT")]
        public int Clone([NativeTypeName("IStream **")] IStream** ppstm)
        {
            return Marshal.GetDelegateForFunctionPointer<_Clone>(lpVtbl->Clone)((IStream*)Unsafe.AsPointer(ref this), ppstm);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Release;

            [NativeTypeName("HRESULT (void *, ULONG, ULONG *) __attribute__((stdcall))")]
            public IntPtr Read;

            [NativeTypeName("HRESULT (const void *, ULONG, ULONG *) __attribute__((stdcall))")]
            public IntPtr Write;

            [NativeTypeName("HRESULT (LARGE_INTEGER, DWORD, ULARGE_INTEGER *) __attribute__((stdcall))")]
            public IntPtr Seek;

            [NativeTypeName("HRESULT (ULARGE_INTEGER) __attribute__((stdcall))")]
            public IntPtr SetSize;

            [NativeTypeName("HRESULT (IStream *, ULARGE_INTEGER, ULARGE_INTEGER *, ULARGE_INTEGER *) __attribute__((stdcall))")]
            public IntPtr CopyTo;

            [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
            public IntPtr Commit;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public IntPtr Revert;

            [NativeTypeName("HRESULT (ULARGE_INTEGER, ULARGE_INTEGER, DWORD) __attribute__((stdcall))")]
            public IntPtr LockRegion;

            [NativeTypeName("HRESULT (ULARGE_INTEGER, ULARGE_INTEGER, DWORD) __attribute__((stdcall))")]
            public IntPtr UnlockRegion;

            [NativeTypeName("HRESULT (STATSTG *, DWORD) __attribute__((stdcall))")]
            public IntPtr Stat;

            [NativeTypeName("HRESULT (IStream **) __attribute__((stdcall))")]
            public IntPtr Clone;
        }
    }
}
