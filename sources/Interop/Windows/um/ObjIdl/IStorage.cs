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

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((IStorage*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IStorage*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IStorage*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateStream([NativeTypeName("const OLECHAR *")] ushort* pwcsName, [NativeTypeName("DWORD")] uint grfMode, [NativeTypeName("DWORD")] uint reserved1, [NativeTypeName("DWORD")] uint reserved2, [NativeTypeName("IStream **")] IStream** ppstm)
        {
            return lpVtbl->CreateStream((IStorage*)Unsafe.AsPointer(ref this), pwcsName, grfMode, reserved1, reserved2, ppstm);
        }

        [return: NativeTypeName("HRESULT")]
        public int OpenStream([NativeTypeName("const OLECHAR *")] ushort* pwcsName, [NativeTypeName("void *")] void* reserved1, [NativeTypeName("DWORD")] uint grfMode, [NativeTypeName("DWORD")] uint reserved2, [NativeTypeName("IStream **")] IStream** ppstm)
        {
            return lpVtbl->OpenStream((IStorage*)Unsafe.AsPointer(ref this), pwcsName, reserved1, grfMode, reserved2, ppstm);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateStorage([NativeTypeName("const OLECHAR *")] ushort* pwcsName, [NativeTypeName("DWORD")] uint grfMode, [NativeTypeName("DWORD")] uint reserved1, [NativeTypeName("DWORD")] uint reserved2, [NativeTypeName("IStorage **")] IStorage** ppstg)
        {
            return lpVtbl->CreateStorage((IStorage*)Unsafe.AsPointer(ref this), pwcsName, grfMode, reserved1, reserved2, ppstg);
        }

        [return: NativeTypeName("HRESULT")]
        public int OpenStorage([NativeTypeName("const OLECHAR *")] ushort* pwcsName, [NativeTypeName("IStorage *")] IStorage* pstgPriority, [NativeTypeName("DWORD")] uint grfMode, [NativeTypeName("SNB")] ushort** snbExclude, [NativeTypeName("DWORD")] uint reserved, [NativeTypeName("IStorage **")] IStorage** ppstg)
        {
            return lpVtbl->OpenStorage((IStorage*)Unsafe.AsPointer(ref this), pwcsName, pstgPriority, grfMode, snbExclude, reserved, ppstg);
        }

        [return: NativeTypeName("HRESULT")]
        public int CopyTo([NativeTypeName("DWORD")] uint ciidExclude, [NativeTypeName("const IID *")] Guid* rgiidExclude, [NativeTypeName("SNB")] ushort** snbExclude, [NativeTypeName("IStorage *")] IStorage* pstgDest)
        {
            return lpVtbl->CopyTo((IStorage*)Unsafe.AsPointer(ref this), ciidExclude, rgiidExclude, snbExclude, pstgDest);
        }

        [return: NativeTypeName("HRESULT")]
        public int MoveElementTo([NativeTypeName("const OLECHAR *")] ushort* pwcsName, [NativeTypeName("IStorage *")] IStorage* pstgDest, [NativeTypeName("const OLECHAR *")] ushort* pwcsNewName, [NativeTypeName("DWORD")] uint grfFlags)
        {
            return lpVtbl->MoveElementTo((IStorage*)Unsafe.AsPointer(ref this), pwcsName, pstgDest, pwcsNewName, grfFlags);
        }

        [return: NativeTypeName("HRESULT")]
        public int Commit([NativeTypeName("DWORD")] uint grfCommitFlags)
        {
            return lpVtbl->Commit((IStorage*)Unsafe.AsPointer(ref this), grfCommitFlags);
        }

        [return: NativeTypeName("HRESULT")]
        public int Revert()
        {
            return lpVtbl->Revert((IStorage*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int EnumElements([NativeTypeName("DWORD")] uint reserved1, [NativeTypeName("void *")] void* reserved2, [NativeTypeName("DWORD")] uint reserved3, [NativeTypeName("IEnumSTATSTG **")] IEnumSTATSTG** ppenum)
        {
            return lpVtbl->EnumElements((IStorage*)Unsafe.AsPointer(ref this), reserved1, reserved2, reserved3, ppenum);
        }

        [return: NativeTypeName("HRESULT")]
        public int DestroyElement([NativeTypeName("const OLECHAR *")] ushort* pwcsName)
        {
            return lpVtbl->DestroyElement((IStorage*)Unsafe.AsPointer(ref this), pwcsName);
        }

        [return: NativeTypeName("HRESULT")]
        public int RenameElement([NativeTypeName("const OLECHAR *")] ushort* pwcsOldName, [NativeTypeName("const OLECHAR *")] ushort* pwcsNewName)
        {
            return lpVtbl->RenameElement((IStorage*)Unsafe.AsPointer(ref this), pwcsOldName, pwcsNewName);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetElementTimes([NativeTypeName("const OLECHAR *")] ushort* pwcsName, [NativeTypeName("const FILETIME *")] FILETIME* pctime, [NativeTypeName("const FILETIME *")] FILETIME* patime, [NativeTypeName("const FILETIME *")] FILETIME* pmtime)
        {
            return lpVtbl->SetElementTimes((IStorage*)Unsafe.AsPointer(ref this), pwcsName, pctime, patime, pmtime);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetClass([NativeTypeName("const IID &")] Guid* clsid)
        {
            return lpVtbl->SetClass((IStorage*)Unsafe.AsPointer(ref this), clsid);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetStateBits([NativeTypeName("DWORD")] uint grfStateBits, [NativeTypeName("DWORD")] uint grfMask)
        {
            return lpVtbl->SetStateBits((IStorage*)Unsafe.AsPointer(ref this), grfStateBits, grfMask);
        }

        [return: NativeTypeName("HRESULT")]
        public int Stat([NativeTypeName("STATSTG *")] STATSTG* pstatstg, [NativeTypeName("DWORD")] uint grfStatFlag)
        {
            return lpVtbl->Stat((IStorage*)Unsafe.AsPointer(ref this), pstatstg, grfStatFlag);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<IStorage*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IStorage*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IStorage*, uint> Release;

            [NativeTypeName("HRESULT (const OLECHAR *, DWORD, DWORD, DWORD, IStream **) __attribute__((stdcall))")]
            public delegate* stdcall<IStorage*, ushort*, uint, uint, uint, IStream**, int> CreateStream;

            [NativeTypeName("HRESULT (const OLECHAR *, void *, DWORD, DWORD, IStream **) __attribute__((stdcall))")]
            public delegate* stdcall<IStorage*, ushort*, void*, uint, uint, IStream**, int> OpenStream;

            [NativeTypeName("HRESULT (const OLECHAR *, DWORD, DWORD, DWORD, IStorage **) __attribute__((stdcall))")]
            public delegate* stdcall<IStorage*, ushort*, uint, uint, uint, IStorage**, int> CreateStorage;

            [NativeTypeName("HRESULT (const OLECHAR *, IStorage *, DWORD, SNB, DWORD, IStorage **) __attribute__((stdcall))")]
            public delegate* stdcall<IStorage*, ushort*, IStorage*, uint, ushort**, uint, IStorage**, int> OpenStorage;

            [NativeTypeName("HRESULT (DWORD, const IID *, SNB, IStorage *) __attribute__((stdcall))")]
            public delegate* stdcall<IStorage*, uint, Guid*, ushort**, IStorage*, int> CopyTo;

            [NativeTypeName("HRESULT (const OLECHAR *, IStorage *, const OLECHAR *, DWORD) __attribute__((stdcall))")]
            public delegate* stdcall<IStorage*, ushort*, IStorage*, ushort*, uint, int> MoveElementTo;

            [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
            public delegate* stdcall<IStorage*, uint, int> Commit;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* stdcall<IStorage*, int> Revert;

            [NativeTypeName("HRESULT (DWORD, void *, DWORD, IEnumSTATSTG **) __attribute__((stdcall))")]
            public delegate* stdcall<IStorage*, uint, void*, uint, IEnumSTATSTG**, int> EnumElements;

            [NativeTypeName("HRESULT (const OLECHAR *) __attribute__((stdcall))")]
            public delegate* stdcall<IStorage*, ushort*, int> DestroyElement;

            [NativeTypeName("HRESULT (const OLECHAR *, const OLECHAR *) __attribute__((stdcall))")]
            public delegate* stdcall<IStorage*, ushort*, ushort*, int> RenameElement;

            [NativeTypeName("HRESULT (const OLECHAR *, const FILETIME *, const FILETIME *, const FILETIME *) __attribute__((stdcall))")]
            public delegate* stdcall<IStorage*, ushort*, FILETIME*, FILETIME*, FILETIME*, int> SetElementTimes;

            [NativeTypeName("HRESULT (const IID &) __attribute__((stdcall))")]
            public delegate* stdcall<IStorage*, Guid*, int> SetClass;

            [NativeTypeName("HRESULT (DWORD, DWORD) __attribute__((stdcall))")]
            public delegate* stdcall<IStorage*, uint, uint, int> SetStateBits;

            [NativeTypeName("HRESULT (STATSTG *, DWORD) __attribute__((stdcall))")]
            public delegate* stdcall<IStorage*, STATSTG*, uint, int> Stat;
        }
    }
}
