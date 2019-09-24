// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\objidlbase.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("0000000C-0000-0000-C000-000000000046")]
    public unsafe struct IStream
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(
            [In] IStream* This,
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(
            [In] IStream* This
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(
            [In] IStream* This
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Read(
            [In] IStream* This,
            [Out] void* pv,
            [In, NativeTypeName("ULONG")] uint cb,
            [Out, NativeTypeName("ULONG")] uint* pcbRead = null
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Write(
            [In] IStream* This,
            [In] void* pv,
            [In, NativeTypeName("ULONG")] uint cb,
            [Out, NativeTypeName("ULONG")] uint* pcbWritten = null
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Seek(
            [In] IStream* This,
            [In] LARGE_INTEGER dlibMove,
            [In, NativeTypeName("DWORD")] uint dwOrigin,
            [Out] ULARGE_INTEGER* plibNewPosition = null
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetSize(
            [In] IStream* This,
            [In] ULARGE_INTEGER libNewSize
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CopyTo(
            [In] IStream* This,
            [In] IStream* pstm,
            [In] ULARGE_INTEGER cb,
            [Out] ULARGE_INTEGER* pcbRead = null,
            [Out] ULARGE_INTEGER* pcbWritten = null
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Commit(
            [In] IStream* This,
            [In, NativeTypeName("DWORD")] uint grfCommitFlags
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Revert(
            [In] IStream* This
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _LockRegion(
            [In] IStream* This,
            [In] ULARGE_INTEGER libOffset,
            [In] ULARGE_INTEGER cb,
            [In, NativeTypeName("DWORD")] uint dwLockType
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _UnlockRegion(
            [In] IStream* This,
            [In] ULARGE_INTEGER libOffset,
            [In] ULARGE_INTEGER cb,
            [In, NativeTypeName("DWORD")] uint dwLockType
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Stat(
            [In] IStream* This,
            [Out] STATSTG* pstatstg,
            [In, NativeTypeName("DWORD")] uint grfStatFlag
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Clone(
            [In] IStream* This,
            [Out] IStream** ppstm = null
        );

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface(
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        )
        {
            fixed (IStream* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)(
                    This,
                    riid,
                    ppvObject
                );
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            fixed (IStream* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)(
                    This
                );
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (IStream* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)(
                    This
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int Read(
            [Out] void* pv,
            [In, NativeTypeName("ULONG")] uint cb,
            [Out, NativeTypeName("ULONG")] uint* pcbRead = null
        )
        {
            fixed (IStream* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Read>(lpVtbl->Read)(
                    This,
                    pv,
                    cb,
                    pcbRead
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int Write(
            [In] void* pv,
            [In, NativeTypeName("ULONG")] uint cb,
            [Out, NativeTypeName("ULONG")] uint* pcbWritten = null
        )
        {
            fixed (IStream* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Write>(lpVtbl->Write)(
                    This,
                    pv,
                    cb,
                    pcbWritten
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int Seek(
            [In] LARGE_INTEGER dlibMove,
            [In, NativeTypeName("DWORD")] uint dwOrigin,
            [Out] ULARGE_INTEGER* plibNewPosition = null
        )
        {
            fixed (IStream* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Seek>(lpVtbl->Seek)(
                    This,
                    dlibMove,
                    dwOrigin,
                    plibNewPosition
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetSize(
            [In] ULARGE_INTEGER libNewSize
        )
        {
            fixed (IStream* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetSize>(lpVtbl->SetSize)(
                    This,
                    libNewSize
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CopyTo(
            [In] IStream* pstm,
            [In] ULARGE_INTEGER cb,
            [Out] ULARGE_INTEGER* pcbRead = null,
            [Out] ULARGE_INTEGER* pcbWritten = null
        )
        {
            fixed (IStream* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CopyTo>(lpVtbl->CopyTo)(
                    This,
                    pstm,
                    cb,
                    pcbRead,
                    pcbWritten
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int Commit(
            [In, NativeTypeName("DWORD")] uint grfCommitFlags
        )
        {
            fixed (IStream* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Commit>(lpVtbl->Commit)(
                    This,
                    grfCommitFlags
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int Revert()
        {
            fixed (IStream* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Revert>(lpVtbl->Revert)(
                    This
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int LockRegion(
            [In] ULARGE_INTEGER libOffset,
            [In] ULARGE_INTEGER cb,
            [In, NativeTypeName("DWORD")] uint dwLockType
        )
        {
            fixed (IStream* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_LockRegion>(lpVtbl->LockRegion)(
                    This,
                    libOffset,
                    cb,
                    dwLockType
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int UnlockRegion(
            [In] ULARGE_INTEGER libOffset,
            [In] ULARGE_INTEGER cb,
            [In, NativeTypeName("DWORD")] uint dwLockType
        )
        {
            fixed (IStream* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_UnlockRegion>(lpVtbl->UnlockRegion)(
                    This,
                    libOffset,
                    cb,
                    dwLockType
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int Stat(
            [Out] STATSTG* pstatstg,
            [In, NativeTypeName("DWORD")] uint grfStatFlag
        )
        {
            fixed (IStream* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Stat>(lpVtbl->Stat)(
                    This,
                    pstatstg,
                    grfStatFlag
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int Clone(
            [Out] IStream** ppstm = null
        )
        {
            fixed (IStream* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Clone>(lpVtbl->Clone)(
                    This,
                    ppstm
                );
            }
        }

        public struct Vtbl
        {
            public IntPtr QueryInterface;

            public IntPtr AddRef;

            public IntPtr Release;

            public IntPtr Read;

            public IntPtr Write;

            public IntPtr Seek;

            public IntPtr SetSize;

            public IntPtr CopyTo;

            public IntPtr Commit;

            public IntPtr Revert;

            public IntPtr LockRegion;

            public IntPtr UnlockRegion;

            public IntPtr Stat;

            public IntPtr Clone;
        }
    }
}
