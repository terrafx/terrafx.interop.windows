// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ObjIdl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("0000000B-0000-0000-C000-000000000046")]
    public unsafe partial struct IStorage
    {
        public Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IStorage* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IStorage* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IStorage* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateStream(IStorage* pThis, [NativeTypeName("const OLECHAR *")] ushort* pwcsName, [NativeTypeName("DWORD")] uint grfMode, [NativeTypeName("DWORD")] uint reserved1, [NativeTypeName("DWORD")] uint reserved2, [NativeTypeName("IStream **")] IStream** ppstm);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _OpenStream(IStorage* pThis, [NativeTypeName("const OLECHAR *")] ushort* pwcsName, [NativeTypeName("void *")] void* reserved1, [NativeTypeName("DWORD")] uint grfMode, [NativeTypeName("DWORD")] uint reserved2, [NativeTypeName("IStream **")] IStream** ppstm);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateStorage(IStorage* pThis, [NativeTypeName("const OLECHAR *")] ushort* pwcsName, [NativeTypeName("DWORD")] uint grfMode, [NativeTypeName("DWORD")] uint reserved1, [NativeTypeName("DWORD")] uint reserved2, [NativeTypeName("IStorage **")] IStorage** ppstg);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _OpenStorage(IStorage* pThis, [NativeTypeName("const OLECHAR *")] ushort* pwcsName, [NativeTypeName("IStorage *")] IStorage* pstgPriority, [NativeTypeName("DWORD")] uint grfMode, [NativeTypeName("SNB")] ushort** snbExclude, [NativeTypeName("DWORD")] uint reserved, [NativeTypeName("IStorage **")] IStorage** ppstg);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CopyTo(IStorage* pThis, [NativeTypeName("DWORD")] uint ciidExclude, [NativeTypeName("const IID *")] Guid* rgiidExclude, [NativeTypeName("SNB")] ushort** snbExclude, [NativeTypeName("IStorage *")] IStorage* pstgDest);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _MoveElementTo(IStorage* pThis, [NativeTypeName("const OLECHAR *")] ushort* pwcsName, [NativeTypeName("IStorage *")] IStorage* pstgDest, [NativeTypeName("const OLECHAR *")] ushort* pwcsNewName, [NativeTypeName("DWORD")] uint grfFlags);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Commit(IStorage* pThis, [NativeTypeName("DWORD")] uint grfCommitFlags);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Revert(IStorage* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _EnumElements(IStorage* pThis, [NativeTypeName("DWORD")] uint reserved1, [NativeTypeName("void *")] void* reserved2, [NativeTypeName("DWORD")] uint reserved3, [NativeTypeName("IEnumSTATSTG **")] IEnumSTATSTG** ppenum);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _DestroyElement(IStorage* pThis, [NativeTypeName("const OLECHAR *")] ushort* pwcsName);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _RenameElement(IStorage* pThis, [NativeTypeName("const OLECHAR *")] ushort* pwcsOldName, [NativeTypeName("const OLECHAR *")] ushort* pwcsNewName);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetElementTimes(IStorage* pThis, [NativeTypeName("const OLECHAR *")] ushort* pwcsName, [NativeTypeName("const FILETIME *")] FILETIME* pctime, [NativeTypeName("const FILETIME *")] FILETIME* patime, [NativeTypeName("const FILETIME *")] FILETIME* pmtime);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetClass(IStorage* pThis, [NativeTypeName("const IID &")] Guid* clsid);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetStateBits(IStorage* pThis, [NativeTypeName("DWORD")] uint grfStateBits, [NativeTypeName("DWORD")] uint grfMask);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Stat(IStorage* pThis, [NativeTypeName("STATSTG *")] STATSTG* pstatstg, [NativeTypeName("DWORD")] uint grfStatFlag);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((IStorage*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((IStorage*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((IStorage*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateStream([NativeTypeName("const OLECHAR *")] ushort* pwcsName, [NativeTypeName("DWORD")] uint grfMode, [NativeTypeName("DWORD")] uint reserved1, [NativeTypeName("DWORD")] uint reserved2, [NativeTypeName("IStream **")] IStream** ppstm)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateStream>(lpVtbl->CreateStream)((IStorage*)Unsafe.AsPointer(ref this), pwcsName, grfMode, reserved1, reserved2, ppstm);
        }

        [return: NativeTypeName("HRESULT")]
        public int OpenStream([NativeTypeName("const OLECHAR *")] ushort* pwcsName, [NativeTypeName("void *")] void* reserved1, [NativeTypeName("DWORD")] uint grfMode, [NativeTypeName("DWORD")] uint reserved2, [NativeTypeName("IStream **")] IStream** ppstm)
        {
            return Marshal.GetDelegateForFunctionPointer<_OpenStream>(lpVtbl->OpenStream)((IStorage*)Unsafe.AsPointer(ref this), pwcsName, reserved1, grfMode, reserved2, ppstm);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateStorage([NativeTypeName("const OLECHAR *")] ushort* pwcsName, [NativeTypeName("DWORD")] uint grfMode, [NativeTypeName("DWORD")] uint reserved1, [NativeTypeName("DWORD")] uint reserved2, [NativeTypeName("IStorage **")] IStorage** ppstg)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateStorage>(lpVtbl->CreateStorage)((IStorage*)Unsafe.AsPointer(ref this), pwcsName, grfMode, reserved1, reserved2, ppstg);
        }

        [return: NativeTypeName("HRESULT")]
        public int OpenStorage([NativeTypeName("const OLECHAR *")] ushort* pwcsName, [NativeTypeName("IStorage *")] IStorage* pstgPriority, [NativeTypeName("DWORD")] uint grfMode, [NativeTypeName("SNB")] ushort** snbExclude, [NativeTypeName("DWORD")] uint reserved, [NativeTypeName("IStorage **")] IStorage** ppstg)
        {
            return Marshal.GetDelegateForFunctionPointer<_OpenStorage>(lpVtbl->OpenStorage)((IStorage*)Unsafe.AsPointer(ref this), pwcsName, pstgPriority, grfMode, snbExclude, reserved, ppstg);
        }

        [return: NativeTypeName("HRESULT")]
        public int CopyTo([NativeTypeName("DWORD")] uint ciidExclude, [NativeTypeName("const IID *")] Guid* rgiidExclude, [NativeTypeName("SNB")] ushort** snbExclude, [NativeTypeName("IStorage *")] IStorage* pstgDest)
        {
            return Marshal.GetDelegateForFunctionPointer<_CopyTo>(lpVtbl->CopyTo)((IStorage*)Unsafe.AsPointer(ref this), ciidExclude, rgiidExclude, snbExclude, pstgDest);
        }

        [return: NativeTypeName("HRESULT")]
        public int MoveElementTo([NativeTypeName("const OLECHAR *")] ushort* pwcsName, [NativeTypeName("IStorage *")] IStorage* pstgDest, [NativeTypeName("const OLECHAR *")] ushort* pwcsNewName, [NativeTypeName("DWORD")] uint grfFlags)
        {
            return Marshal.GetDelegateForFunctionPointer<_MoveElementTo>(lpVtbl->MoveElementTo)((IStorage*)Unsafe.AsPointer(ref this), pwcsName, pstgDest, pwcsNewName, grfFlags);
        }

        [return: NativeTypeName("HRESULT")]
        public int Commit([NativeTypeName("DWORD")] uint grfCommitFlags)
        {
            return Marshal.GetDelegateForFunctionPointer<_Commit>(lpVtbl->Commit)((IStorage*)Unsafe.AsPointer(ref this), grfCommitFlags);
        }

        [return: NativeTypeName("HRESULT")]
        public int Revert()
        {
            return Marshal.GetDelegateForFunctionPointer<_Revert>(lpVtbl->Revert)((IStorage*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int EnumElements([NativeTypeName("DWORD")] uint reserved1, [NativeTypeName("void *")] void* reserved2, [NativeTypeName("DWORD")] uint reserved3, [NativeTypeName("IEnumSTATSTG **")] IEnumSTATSTG** ppenum)
        {
            return Marshal.GetDelegateForFunctionPointer<_EnumElements>(lpVtbl->EnumElements)((IStorage*)Unsafe.AsPointer(ref this), reserved1, reserved2, reserved3, ppenum);
        }

        [return: NativeTypeName("HRESULT")]
        public int DestroyElement([NativeTypeName("const OLECHAR *")] ushort* pwcsName)
        {
            return Marshal.GetDelegateForFunctionPointer<_DestroyElement>(lpVtbl->DestroyElement)((IStorage*)Unsafe.AsPointer(ref this), pwcsName);
        }

        [return: NativeTypeName("HRESULT")]
        public int RenameElement([NativeTypeName("const OLECHAR *")] ushort* pwcsOldName, [NativeTypeName("const OLECHAR *")] ushort* pwcsNewName)
        {
            return Marshal.GetDelegateForFunctionPointer<_RenameElement>(lpVtbl->RenameElement)((IStorage*)Unsafe.AsPointer(ref this), pwcsOldName, pwcsNewName);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetElementTimes([NativeTypeName("const OLECHAR *")] ushort* pwcsName, [NativeTypeName("const FILETIME *")] FILETIME* pctime, [NativeTypeName("const FILETIME *")] FILETIME* patime, [NativeTypeName("const FILETIME *")] FILETIME* pmtime)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetElementTimes>(lpVtbl->SetElementTimes)((IStorage*)Unsafe.AsPointer(ref this), pwcsName, pctime, patime, pmtime);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetClass([NativeTypeName("const IID &")] Guid* clsid)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetClass>(lpVtbl->SetClass)((IStorage*)Unsafe.AsPointer(ref this), clsid);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetStateBits([NativeTypeName("DWORD")] uint grfStateBits, [NativeTypeName("DWORD")] uint grfMask)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetStateBits>(lpVtbl->SetStateBits)((IStorage*)Unsafe.AsPointer(ref this), grfStateBits, grfMask);
        }

        [return: NativeTypeName("HRESULT")]
        public int Stat([NativeTypeName("STATSTG *")] STATSTG* pstatstg, [NativeTypeName("DWORD")] uint grfStatFlag)
        {
            return Marshal.GetDelegateForFunctionPointer<_Stat>(lpVtbl->Stat)((IStorage*)Unsafe.AsPointer(ref this), pstatstg, grfStatFlag);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Release;

            [NativeTypeName("HRESULT (const OLECHAR *, DWORD, DWORD, DWORD, IStream **) __attribute__((stdcall))")]
            public IntPtr CreateStream;

            [NativeTypeName("HRESULT (const OLECHAR *, void *, DWORD, DWORD, IStream **) __attribute__((stdcall))")]
            public IntPtr OpenStream;

            [NativeTypeName("HRESULT (const OLECHAR *, DWORD, DWORD, DWORD, IStorage **) __attribute__((stdcall))")]
            public IntPtr CreateStorage;

            [NativeTypeName("HRESULT (const OLECHAR *, IStorage *, DWORD, SNB, DWORD, IStorage **) __attribute__((stdcall))")]
            public IntPtr OpenStorage;

            [NativeTypeName("HRESULT (DWORD, const IID *, SNB, IStorage *) __attribute__((stdcall))")]
            public IntPtr CopyTo;

            [NativeTypeName("HRESULT (const OLECHAR *, IStorage *, const OLECHAR *, DWORD) __attribute__((stdcall))")]
            public IntPtr MoveElementTo;

            [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
            public IntPtr Commit;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public IntPtr Revert;

            [NativeTypeName("HRESULT (DWORD, void *, DWORD, IEnumSTATSTG **) __attribute__((stdcall))")]
            public IntPtr EnumElements;

            [NativeTypeName("HRESULT (const OLECHAR *) __attribute__((stdcall))")]
            public IntPtr DestroyElement;

            [NativeTypeName("HRESULT (const OLECHAR *, const OLECHAR *) __attribute__((stdcall))")]
            public IntPtr RenameElement;

            [NativeTypeName("HRESULT (const OLECHAR *, const FILETIME *, const FILETIME *, const FILETIME *) __attribute__((stdcall))")]
            public IntPtr SetElementTimes;

            [NativeTypeName("HRESULT (const IID &) __attribute__((stdcall))")]
            public IntPtr SetClass;

            [NativeTypeName("HRESULT (DWORD, DWORD) __attribute__((stdcall))")]
            public IntPtr SetStateBits;

            [NativeTypeName("HRESULT (STATSTG *, DWORD) __attribute__((stdcall))")]
            public IntPtr Stat;
        }
    }
}
