// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/objidl.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("0000000B-0000-0000-C000-000000000046")]
    public unsafe partial struct IStorage
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IStorage* This, [NativeTypeName("REFIID")] Guid* riid, void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IStorage* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IStorage* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateStream(IStorage* This, [NativeTypeName("OLECHAR")] ushort* pwcsName, [NativeTypeName("DWORD")] uint grfMode, [NativeTypeName("DWORD")] uint reserved1, [NativeTypeName("DWORD")] uint reserved2, IStream** ppstm = null);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _OpenStream(IStorage* This, [NativeTypeName("OLECHAR")] ushort* pwcsName, void* reserved1, [NativeTypeName("DWORD")] uint grfMode, [NativeTypeName("DWORD")] uint reserved2, IStream** ppstm);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateStorage(IStorage* This, [NativeTypeName("OLECHAR")] ushort* pwcsName, [NativeTypeName("DWORD")] uint grfMode, [NativeTypeName("DWORD")] uint reserved1, [NativeTypeName("DWORD")] uint reserved2, IStorage** ppstg = null);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _OpenStorage(IStorage* This, [Optional, NativeTypeName("OLECHAR")] ushort* pwcsName, [Optional] IStorage* pstgPriority, [NativeTypeName("DWORD")] uint grfMode, [Optional, NativeTypeName("SNB")] ushort** snbExclude, [NativeTypeName("DWORD")] uint reserved, IStorage** ppstg = null);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CopyTo(IStorage* This, [NativeTypeName("IID")] Guid* ciidExclude, [Optional] Guid* rgiidExclude, [Optional, NativeTypeName("SNB")] ushort** snbExclude, IStorage* pstgDest);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _MoveElementTo(IStorage* This, [NativeTypeName("OLECHAR")] ushort* pwcsName, [Optional] IStorage* pstgDest, [NativeTypeName("OLECHAR")] ushort* pwcsNewName, [NativeTypeName("DWORD")] uint grfFlags);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Commit(IStorage* This, [NativeTypeName("DWORD")] uint grfCommitFlags);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Revert(IStorage* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _EnumElements(IStorage* This, [NativeTypeName("DWORD")] uint reserved1, void* reserved2, [NativeTypeName("DWORD")] uint reserved3, IEnumSTATSTG** ppenum);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _DestroyElement(IStorage* This, [NativeTypeName("OLECHAR")] ushort* pwcsName);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _RenameElement(IStorage* This, [NativeTypeName("OLECHAR")] ushort* pwcsOldName, [NativeTypeName("OLECHAR")] ushort* pwcsNewName);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetElementTimes(IStorage* This, [NativeTypeName("OLECHAR")] ushort* pwcsName = null, FILETIME* pctime = null, FILETIME* patime = null, FILETIME* pmtime = null);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetClass(IStorage* This, [NativeTypeName("REFCLSID")] Guid* clsid);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetStateBits(IStorage* This, [NativeTypeName("DWORD")] uint grfStateBits, [NativeTypeName("DWORD")] uint grfMask);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Stat(IStorage* This, STATSTG* pstatstg, [NativeTypeName("DWORD")] uint grfStatFlag);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("REFIID")] Guid* riid, void** ppvObject)
        {
            fixed (IStorage* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)(This, riid, ppvObject);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            fixed (IStorage* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)(This);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (IStorage* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)(This);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateStream([NativeTypeName("OLECHAR")] ushort* pwcsName, [NativeTypeName("DWORD")] uint grfMode, [NativeTypeName("DWORD")] uint reserved1, [NativeTypeName("DWORD")] uint reserved2, IStream** ppstm = null)
        {
            fixed (IStorage* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateStream>(lpVtbl->CreateStream)(This, pwcsName, grfMode, reserved1, reserved2, ppstm);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int OpenStream([NativeTypeName("OLECHAR")] ushort* pwcsName, void* reserved1, [NativeTypeName("DWORD")] uint grfMode, [NativeTypeName("DWORD")] uint reserved2, IStream** ppstm)
        {
            fixed (IStorage* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_OpenStream>(lpVtbl->OpenStream)(This, pwcsName, reserved1, grfMode, reserved2, ppstm);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateStorage([NativeTypeName("OLECHAR")] ushort* pwcsName, [NativeTypeName("DWORD")] uint grfMode, [NativeTypeName("DWORD")] uint reserved1, [NativeTypeName("DWORD")] uint reserved2, IStorage** ppstg = null)
        {
            fixed (IStorage* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateStorage>(lpVtbl->CreateStorage)(This, pwcsName, grfMode, reserved1, reserved2, ppstg);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int OpenStorage([Optional, NativeTypeName("OLECHAR")] ushort* pwcsName, [Optional] IStorage* pstgPriority, [NativeTypeName("DWORD")] uint grfMode, [Optional, NativeTypeName("SNB")] ushort** snbExclude, [NativeTypeName("DWORD")] uint reserved, IStorage** ppstg = null)
        {
            fixed (IStorage* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_OpenStorage>(lpVtbl->OpenStorage)(This, pwcsName, pstgPriority, grfMode, snbExclude, reserved, ppstg);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CopyTo([NativeTypeName("IID")] Guid* ciidExclude, [Optional] Guid* rgiidExclude, [Optional, NativeTypeName("SNB")] ushort** snbExclude, IStorage* pstgDest)
        {
            fixed (IStorage* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CopyTo>(lpVtbl->CopyTo)(This, ciidExclude, rgiidExclude, snbExclude, pstgDest);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int MoveElementTo([NativeTypeName("OLECHAR")] ushort* pwcsName, [Optional] IStorage* pstgDest, [NativeTypeName("OLECHAR")] ushort* pwcsNewName, [NativeTypeName("DWORD")] uint grfFlags)
        {
            fixed (IStorage* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_MoveElementTo>(lpVtbl->MoveElementTo)(This, pwcsName, pstgDest, pwcsNewName, grfFlags);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int Commit([NativeTypeName("DWORD")] uint grfCommitFlags)
        {
            fixed (IStorage* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Commit>(lpVtbl->Commit)(This, grfCommitFlags);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int Revert()
        {
            fixed (IStorage* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Revert>(lpVtbl->Revert)(This);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int EnumElements([NativeTypeName("DWORD")] uint reserved1, void* reserved2, [NativeTypeName("DWORD")] uint reserved3, IEnumSTATSTG** ppenum)
        {
            fixed (IStorage* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_EnumElements>(lpVtbl->EnumElements)(This, reserved1, reserved2, reserved3, ppenum);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int DestroyElement([NativeTypeName("OLECHAR")] ushort* pwcsName)
        {
            fixed (IStorage* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_DestroyElement>(lpVtbl->DestroyElement)(This, pwcsName);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int RenameElement([NativeTypeName("OLECHAR")] ushort* pwcsOldName, [NativeTypeName("OLECHAR")] ushort* pwcsNewName)
        {
            fixed (IStorage* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_RenameElement>(lpVtbl->RenameElement)(This, pwcsOldName, pwcsNewName);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetElementTimes([NativeTypeName("OLECHAR")] ushort* pwcsName = null, FILETIME* pctime = null, FILETIME* patime = null, FILETIME* pmtime = null)
        {
            fixed (IStorage* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetElementTimes>(lpVtbl->SetElementTimes)(This, pwcsName, pctime, patime, pmtime);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetClass([NativeTypeName("REFCLSID")] Guid* clsid)
        {
            fixed (IStorage* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetClass>(lpVtbl->SetClass)(This, clsid);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetStateBits([NativeTypeName("DWORD")] uint grfStateBits, [NativeTypeName("DWORD")] uint grfMask)
        {
            fixed (IStorage* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetStateBits>(lpVtbl->SetStateBits)(This, grfStateBits, grfMask);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int Stat(STATSTG* pstatstg, [NativeTypeName("DWORD")] uint grfStatFlag)
        {
            fixed (IStorage* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Stat>(lpVtbl->Stat)(This, pstatstg, grfStatFlag);
            }
        }

        public partial struct Vtbl
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
