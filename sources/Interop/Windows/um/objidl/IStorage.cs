// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\objidl.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("0000000B-0000-0000-C000-000000000046")]
    public unsafe struct IStorage
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _QueryInterface(
            [In] IStorage* This,
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public /* static */ delegate uint _AddRef(
            [In] IStorage* This
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public /* static */ delegate uint _Release(
            [In] IStorage* This
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _CreateStream(
            [In] IStorage* This,
            [In, NativeTypeName("OLECHAR")] char* pwcsName,
            [In, NativeTypeName("DWORD")] uint grfMode,
            [In, NativeTypeName("DWORD")] uint reserved1,
            [In, NativeTypeName("DWORD")] uint reserved2,
            [Out] IStream** ppstm = null
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _OpenStream(
            [In] IStorage* This,
            [In, NativeTypeName("OLECHAR")] char* pwcsName,
            [In] void* reserved1,
            [In, NativeTypeName("DWORD")] uint grfMode,
            [In, NativeTypeName("DWORD")] uint reserved2,
            [Out] IStream** ppstm
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _CreateStorage(
            [In] IStorage* This,
            [In, NativeTypeName("OLECHAR")] char* pwcsName,
            [In, NativeTypeName("DWORD")] uint grfMode,
            [In, NativeTypeName("DWORD")] uint reserved1,
            [In, NativeTypeName("DWORD")] uint reserved2,
            [Out] IStorage** ppstg = null
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _OpenStorage(
            [In] IStorage* This,
            [In, Optional, NativeTypeName("OLECHAR")] char* pwcsName,
            [In, Optional] IStorage* pstgPriority,
            [In, NativeTypeName("DWORD")] uint grfMode,
            [In, Optional, NativeTypeName("SNB")] char** snbExclude,
            [In, NativeTypeName("DWORD")] uint reserved,
            [Out] IStorage** ppstg = null
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _CopyTo(
            [In] IStorage* This,
            [In, NativeTypeName("IID")] Guid* ciidExclude,
            [In, Optional] Guid* rgiidExclude,
            [In, Optional, NativeTypeName("SNB")] char** snbExclude,
            [In] IStorage* pstgDest
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _MoveElementTo(
            [In] IStorage* This,
            [In, NativeTypeName("OLECHAR")] char* pwcsName,
            [In, Optional] IStorage* pstgDest,
            [In, NativeTypeName("OLECHAR")] char* pwcsNewName,
            [In, NativeTypeName("DWORD")] uint grfFlags
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _Commit(
            [In] IStorage* This,
            [In, NativeTypeName("DWORD")] uint grfCommitFlags
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _Revert(
            [In] IStorage* This
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _EnumElements(
            [In] IStorage* This,
            [In, NativeTypeName("DWORD")] uint reserved1,
            [In] void* reserved2,
            [In, NativeTypeName("DWORD")] uint reserved3,
            [Out] IEnumSTATSTG** ppenum
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _DestroyElement(
            [In] IStorage* This,
            [In, NativeTypeName("OLECHAR")] char* pwcsName
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _RenameElement(
            [In] IStorage* This,
            [In, NativeTypeName("OLECHAR")] char* pwcsOldName,
            [In, NativeTypeName("OLECHAR")] char* pwcsNewName
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _SetElementTimes(
            [In] IStorage* This,
            [In, NativeTypeName("OLECHAR")] char* pwcsName = null,
            [In] FILETIME* pctime = null,
            [In] FILETIME* patime = null,
            [In] FILETIME* pmtime = null
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _SetClass(
            [In] IStorage* This,
            [In, NativeTypeName("REFCLSID")] Guid* clsid
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _SetStateBits(
            [In] IStorage* This,
            [In, NativeTypeName("DWORD")] uint grfStateBits,
            [In, NativeTypeName("DWORD")] uint grfMask
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _Stat(
            [In] IStorage* This,
            [Out] STATSTG* pstatstg,
            [In, NativeTypeName("DWORD")] uint grfStatFlag
        );

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface(
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        )
        {
            fixed (IStorage* This = &this)
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
            fixed (IStorage* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)(
                    This
                );
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (IStorage* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)(
                    This
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateStream(
            [In, NativeTypeName("OLECHAR")] char* pwcsName,
            [In, NativeTypeName("DWORD")] uint grfMode,
            [In, NativeTypeName("DWORD")] uint reserved1,
            [In, NativeTypeName("DWORD")] uint reserved2,
            [Out] IStream** ppstm = null
        )
        {
            fixed (IStorage* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateStream>(lpVtbl->CreateStream)(
                    This,
                    pwcsName,
                    grfMode,
                    reserved1,
                    reserved2,
                    ppstm
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int OpenStream(
            [In, NativeTypeName("OLECHAR")] char* pwcsName,
            [In] void* reserved1,
            [In, NativeTypeName("DWORD")] uint grfMode,
            [In, NativeTypeName("DWORD")] uint reserved2,
            [Out] IStream** ppstm
        )
        {
            fixed (IStorage* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_OpenStream>(lpVtbl->OpenStream)(
                    This,
                    pwcsName,
                    reserved1,
                    grfMode,
                    reserved2,
                    ppstm
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateStorage(
            [In, NativeTypeName("OLECHAR")] char* pwcsName,
            [In, NativeTypeName("DWORD")] uint grfMode,
            [In, NativeTypeName("DWORD")] uint reserved1,
            [In, NativeTypeName("DWORD")] uint reserved2,
            [Out] IStorage** ppstg = null
        )
        {
            fixed (IStorage* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateStorage>(lpVtbl->CreateStorage)(
                    This,
                    pwcsName,
                    grfMode,
                    reserved1,
                    reserved2,
                    ppstg
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int OpenStorage(
            [In, Optional, NativeTypeName("OLECHAR")] char* pwcsName,
            [In, Optional] IStorage* pstgPriority,
            [In, NativeTypeName("DWORD")] uint grfMode,
            [In, Optional, NativeTypeName("SNB")] char** snbExclude,
            [In, NativeTypeName("DWORD")] uint reserved,
            [Out] IStorage** ppstg = null
        )
        {
            fixed (IStorage* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_OpenStorage>(lpVtbl->OpenStorage)(
                    This,
                    pwcsName,
                    pstgPriority,
                    grfMode,
                    snbExclude,
                    reserved,
                    ppstg
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CopyTo(
            [In, NativeTypeName("IID")] Guid* ciidExclude,
            [In, Optional] Guid* rgiidExclude,
            [In, Optional, NativeTypeName("SNB")] char** snbExclude,
            [In] IStorage* pstgDest
        )
        {
            fixed (IStorage* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CopyTo>(lpVtbl->CopyTo)(
                    This,
                    ciidExclude,
                    rgiidExclude,
                    snbExclude,
                    pstgDest
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int MoveElementTo(
            [In, NativeTypeName("OLECHAR")] char* pwcsName,
            [In, Optional] IStorage* pstgDest,
            [In, NativeTypeName("OLECHAR")] char* pwcsNewName,
            [In, NativeTypeName("DWORD")] uint grfFlags
        )
        {
            fixed (IStorage* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_MoveElementTo>(lpVtbl->MoveElementTo)(
                    This,
                    pwcsName,
                    pstgDest,
                    pwcsNewName,
                    grfFlags
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int Commit(
            [In, NativeTypeName("DWORD")] uint grfCommitFlags
        )
        {
            fixed (IStorage* This = &this)
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
            fixed (IStorage* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Revert>(lpVtbl->Revert)(
                    This
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int EnumElements(
            [In, NativeTypeName("DWORD")] uint reserved1,
            [In] void* reserved2,
            [In, NativeTypeName("DWORD")] uint reserved3,
            [Out] IEnumSTATSTG** ppenum
        )
        {
            fixed (IStorage* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_EnumElements>(lpVtbl->EnumElements)(
                    This,
                    reserved1,
                    reserved2,
                    reserved3,
                    ppenum
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int DestroyElement(
            [In, NativeTypeName("OLECHAR")] char* pwcsName
        )
        {
            fixed (IStorage* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_DestroyElement>(lpVtbl->DestroyElement)(
                    This,
                    pwcsName
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int RenameElement(
            [In, NativeTypeName("OLECHAR")] char* pwcsOldName,
            [In, NativeTypeName("OLECHAR")] char* pwcsNewName
        )
        {
            fixed (IStorage* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_RenameElement>(lpVtbl->RenameElement)(
                    This,
                    pwcsOldName,
                    pwcsNewName
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetElementTimes(
            [In, NativeTypeName("OLECHAR")] char* pwcsName = null,
            [In] FILETIME* pctime = null,
            [In] FILETIME* patime = null,
            [In] FILETIME* pmtime = null
        )
        {
            fixed (IStorage* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetElementTimes>(lpVtbl->SetElementTimes)(
                    This,
                    pwcsName,
                    pctime,
                    patime,
                    pmtime
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetClass(
            [In, NativeTypeName("REFCLSID")] Guid* clsid
        )
        {
            fixed (IStorage* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetClass>(lpVtbl->SetClass)(
                    This,
                    clsid
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetStateBits(
            [In, NativeTypeName("DWORD")] uint grfStateBits,
            [In, NativeTypeName("DWORD")] uint grfMask
        )
        {
            fixed (IStorage* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetStateBits>(lpVtbl->SetStateBits)(
                    This,
                    grfStateBits,
                    grfMask
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int Stat(
            [Out] STATSTG* pstatstg,
            [In, NativeTypeName("DWORD")] uint grfStatFlag
        )
        {
            fixed (IStorage* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Stat>(lpVtbl->Stat)(
                    This,
                    pstatstg,
                    grfStatFlag
                );
            }
        }

        public struct Vtbl
        {
            public IntPtr QueryInterface;

            public IntPtr AddRef;

            public IntPtr Release;

            public IntPtr CreateStream;

            public IntPtr OpenStream;

            public IntPtr CreateStorage;

            public IntPtr OpenStorage;

            public IntPtr CopyTo;

            public IntPtr MoveElementTo;

            public IntPtr Commit;

            public IntPtr Revert;

            public IntPtr EnumElements;

            public IntPtr DestroyElement;

            public IntPtr RenameElement;

            public IntPtr SetElementTimes;

            public IntPtr SetClass;

            public IntPtr SetStateBits;

            public IntPtr Stat;
        }
    }
}
