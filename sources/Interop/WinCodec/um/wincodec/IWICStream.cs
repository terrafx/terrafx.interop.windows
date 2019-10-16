// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public unsafe partial struct IWICStream
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IWICStream* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IWICStream* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IWICStream* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Read(IWICStream* pThis, [NativeTypeName("void *")] void* pv, [NativeTypeName("ULONG")] uint cb, [NativeTypeName("ULONG *")] uint* pcbRead);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Write(IWICStream* pThis, [NativeTypeName("const void *")] void* pv, [NativeTypeName("ULONG")] uint cb, [NativeTypeName("ULONG *")] uint* pcbWritten);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Seek(IWICStream* pThis, LARGE_INTEGER dlibMove, [NativeTypeName("DWORD")] uint dwOrigin, [NativeTypeName("ULARGE_INTEGER *")] ULARGE_INTEGER* plibNewPosition);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetSize(IWICStream* pThis, ULARGE_INTEGER libNewSize);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CopyTo(IWICStream* pThis, [NativeTypeName("IStream *")] IStream* pstm, ULARGE_INTEGER cb, [NativeTypeName("ULARGE_INTEGER *")] ULARGE_INTEGER* pcbRead, [NativeTypeName("ULARGE_INTEGER *")] ULARGE_INTEGER* pcbWritten);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Commit(IWICStream* pThis, [NativeTypeName("DWORD")] uint grfCommitFlags);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Revert(IWICStream* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _LockRegion(IWICStream* pThis, ULARGE_INTEGER libOffset, ULARGE_INTEGER cb, [NativeTypeName("DWORD")] uint dwLockType);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _UnlockRegion(IWICStream* pThis, ULARGE_INTEGER libOffset, ULARGE_INTEGER cb, [NativeTypeName("DWORD")] uint dwLockType);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Stat(IWICStream* pThis, [NativeTypeName("STATSTG *")] STATSTG* pstatstg, [NativeTypeName("DWORD")] uint grfStatFlag);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Clone(IWICStream* pThis, [NativeTypeName("IStream **")] IStream** ppstm);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _InitializeFromIStream(IWICStream* pThis, [NativeTypeName("IStream *")] IStream* pIStream);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _InitializeFromFilename(IWICStream* pThis, [NativeTypeName("LPCWSTR")] ushort* wzFileName, [NativeTypeName("DWORD")] uint dwDesiredAccess);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _InitializeFromMemory(IWICStream* pThis, [NativeTypeName("WICInProcPointer")] byte* pbBuffer, [NativeTypeName("DWORD")] uint cbBufferSize);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _InitializeFromIStreamRegion(IWICStream* pThis, [NativeTypeName("IStream *")] IStream* pIStream, ULARGE_INTEGER ulOffset, ULARGE_INTEGER ulMaxSize);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((IWICStream*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((IWICStream*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((IWICStream*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Read([NativeTypeName("void *")] void* pv, [NativeTypeName("ULONG")] uint cb, [NativeTypeName("ULONG *")] uint* pcbRead)
        {
            return Marshal.GetDelegateForFunctionPointer<_Read>(lpVtbl->Read)((IWICStream*)Unsafe.AsPointer(ref this), pv, cb, pcbRead);
        }

        [return: NativeTypeName("HRESULT")]
        public int Write([NativeTypeName("const void *")] void* pv, [NativeTypeName("ULONG")] uint cb, [NativeTypeName("ULONG *")] uint* pcbWritten)
        {
            return Marshal.GetDelegateForFunctionPointer<_Write>(lpVtbl->Write)((IWICStream*)Unsafe.AsPointer(ref this), pv, cb, pcbWritten);
        }

        [return: NativeTypeName("HRESULT")]
        public int Seek(LARGE_INTEGER dlibMove, [NativeTypeName("DWORD")] uint dwOrigin, [NativeTypeName("ULARGE_INTEGER *")] ULARGE_INTEGER* plibNewPosition)
        {
            return Marshal.GetDelegateForFunctionPointer<_Seek>(lpVtbl->Seek)((IWICStream*)Unsafe.AsPointer(ref this), dlibMove, dwOrigin, plibNewPosition);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetSize(ULARGE_INTEGER libNewSize)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetSize>(lpVtbl->SetSize)((IWICStream*)Unsafe.AsPointer(ref this), libNewSize);
        }

        [return: NativeTypeName("HRESULT")]
        public int CopyTo([NativeTypeName("IStream *")] IStream* pstm, ULARGE_INTEGER cb, [NativeTypeName("ULARGE_INTEGER *")] ULARGE_INTEGER* pcbRead, [NativeTypeName("ULARGE_INTEGER *")] ULARGE_INTEGER* pcbWritten)
        {
            return Marshal.GetDelegateForFunctionPointer<_CopyTo>(lpVtbl->CopyTo)((IWICStream*)Unsafe.AsPointer(ref this), pstm, cb, pcbRead, pcbWritten);
        }

        [return: NativeTypeName("HRESULT")]
        public int Commit([NativeTypeName("DWORD")] uint grfCommitFlags)
        {
            return Marshal.GetDelegateForFunctionPointer<_Commit>(lpVtbl->Commit)((IWICStream*)Unsafe.AsPointer(ref this), grfCommitFlags);
        }

        [return: NativeTypeName("HRESULT")]
        public int Revert()
        {
            return Marshal.GetDelegateForFunctionPointer<_Revert>(lpVtbl->Revert)((IWICStream*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int LockRegion(ULARGE_INTEGER libOffset, ULARGE_INTEGER cb, [NativeTypeName("DWORD")] uint dwLockType)
        {
            return Marshal.GetDelegateForFunctionPointer<_LockRegion>(lpVtbl->LockRegion)((IWICStream*)Unsafe.AsPointer(ref this), libOffset, cb, dwLockType);
        }

        [return: NativeTypeName("HRESULT")]
        public int UnlockRegion(ULARGE_INTEGER libOffset, ULARGE_INTEGER cb, [NativeTypeName("DWORD")] uint dwLockType)
        {
            return Marshal.GetDelegateForFunctionPointer<_UnlockRegion>(lpVtbl->UnlockRegion)((IWICStream*)Unsafe.AsPointer(ref this), libOffset, cb, dwLockType);
        }

        [return: NativeTypeName("HRESULT")]
        public int Stat([NativeTypeName("STATSTG *")] STATSTG* pstatstg, [NativeTypeName("DWORD")] uint grfStatFlag)
        {
            return Marshal.GetDelegateForFunctionPointer<_Stat>(lpVtbl->Stat)((IWICStream*)Unsafe.AsPointer(ref this), pstatstg, grfStatFlag);
        }

        [return: NativeTypeName("HRESULT")]
        public int Clone([NativeTypeName("IStream **")] IStream** ppstm)
        {
            return Marshal.GetDelegateForFunctionPointer<_Clone>(lpVtbl->Clone)((IWICStream*)Unsafe.AsPointer(ref this), ppstm);
        }

        [return: NativeTypeName("HRESULT")]
        public int InitializeFromIStream([NativeTypeName("IStream *")] IStream* pIStream)
        {
            return Marshal.GetDelegateForFunctionPointer<_InitializeFromIStream>(lpVtbl->InitializeFromIStream)((IWICStream*)Unsafe.AsPointer(ref this), pIStream);
        }

        [return: NativeTypeName("HRESULT")]
        public int InitializeFromFilename([NativeTypeName("LPCWSTR")] ushort* wzFileName, [NativeTypeName("DWORD")] uint dwDesiredAccess)
        {
            return Marshal.GetDelegateForFunctionPointer<_InitializeFromFilename>(lpVtbl->InitializeFromFilename)((IWICStream*)Unsafe.AsPointer(ref this), wzFileName, dwDesiredAccess);
        }

        [return: NativeTypeName("HRESULT")]
        public int InitializeFromMemory([NativeTypeName("WICInProcPointer")] byte* pbBuffer, [NativeTypeName("DWORD")] uint cbBufferSize)
        {
            return Marshal.GetDelegateForFunctionPointer<_InitializeFromMemory>(lpVtbl->InitializeFromMemory)((IWICStream*)Unsafe.AsPointer(ref this), pbBuffer, cbBufferSize);
        }

        [return: NativeTypeName("HRESULT")]
        public int InitializeFromIStreamRegion([NativeTypeName("IStream *")] IStream* pIStream, ULARGE_INTEGER ulOffset, ULARGE_INTEGER ulMaxSize)
        {
            return Marshal.GetDelegateForFunctionPointer<_InitializeFromIStreamRegion>(lpVtbl->InitializeFromIStreamRegion)((IWICStream*)Unsafe.AsPointer(ref this), pIStream, ulOffset, ulMaxSize);
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

            [NativeTypeName("HRESULT (IStream *) __attribute__((stdcall))")]
            public IntPtr InitializeFromIStream;

            [NativeTypeName("HRESULT (LPCWSTR, DWORD) __attribute__((stdcall))")]
            public IntPtr InitializeFromFilename;

            [NativeTypeName("HRESULT (WICInProcPointer, DWORD) __attribute__((stdcall))")]
            public IntPtr InitializeFromMemory;

            [NativeTypeName("HRESULT (IStream *, ULARGE_INTEGER, ULARGE_INTEGER) __attribute__((stdcall))")]
            public IntPtr InitializeFromIStreamRegion;
        }
    }
}
