// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/OAIdl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("00020406-0000-0000-C000-000000000046")]
    public unsafe partial struct ICreateTypeLib
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((ICreateTypeLib*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((ICreateTypeLib*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((ICreateTypeLib*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateTypeInfo([NativeTypeName("LPOLESTR")] ushort* szName, TYPEKIND tkind, [NativeTypeName("ICreateTypeInfo **")] ICreateTypeInfo** ppCTInfo)
        {
            return lpVtbl->CreateTypeInfo((ICreateTypeLib*)Unsafe.AsPointer(ref this), szName, tkind, ppCTInfo);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetName([NativeTypeName("LPOLESTR")] ushort* szName)
        {
            return lpVtbl->SetName((ICreateTypeLib*)Unsafe.AsPointer(ref this), szName);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetVersion([NativeTypeName("WORD")] ushort wMajorVerNum, [NativeTypeName("WORD")] ushort wMinorVerNum)
        {
            return lpVtbl->SetVersion((ICreateTypeLib*)Unsafe.AsPointer(ref this), wMajorVerNum, wMinorVerNum);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetGuid([NativeTypeName("const GUID &")] Guid* guid)
        {
            return lpVtbl->SetGuid((ICreateTypeLib*)Unsafe.AsPointer(ref this), guid);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetDocString([NativeTypeName("LPOLESTR")] ushort* szDoc)
        {
            return lpVtbl->SetDocString((ICreateTypeLib*)Unsafe.AsPointer(ref this), szDoc);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetHelpFileName([NativeTypeName("LPOLESTR")] ushort* szHelpFileName)
        {
            return lpVtbl->SetHelpFileName((ICreateTypeLib*)Unsafe.AsPointer(ref this), szHelpFileName);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetHelpContext([NativeTypeName("DWORD")] uint dwHelpContext)
        {
            return lpVtbl->SetHelpContext((ICreateTypeLib*)Unsafe.AsPointer(ref this), dwHelpContext);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetLcid([NativeTypeName("LCID")] uint lcid)
        {
            return lpVtbl->SetLcid((ICreateTypeLib*)Unsafe.AsPointer(ref this), lcid);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetLibFlags([NativeTypeName("UINT")] uint uLibFlags)
        {
            return lpVtbl->SetLibFlags((ICreateTypeLib*)Unsafe.AsPointer(ref this), uLibFlags);
        }

        [return: NativeTypeName("HRESULT")]
        public int SaveAllChanges()
        {
            return lpVtbl->SaveAllChanges((ICreateTypeLib*)Unsafe.AsPointer(ref this));
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<ICreateTypeLib*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<ICreateTypeLib*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<ICreateTypeLib*, uint> Release;

            [NativeTypeName("HRESULT (LPOLESTR, TYPEKIND, ICreateTypeInfo **) __attribute__((stdcall))")]
            public delegate* stdcall<ICreateTypeLib*, ushort*, TYPEKIND, ICreateTypeInfo**, int> CreateTypeInfo;

            [NativeTypeName("HRESULT (LPOLESTR) __attribute__((stdcall))")]
            public delegate* stdcall<ICreateTypeLib*, ushort*, int> SetName;

            [NativeTypeName("HRESULT (WORD, WORD) __attribute__((stdcall))")]
            public delegate* stdcall<ICreateTypeLib*, ushort, ushort, int> SetVersion;

            [NativeTypeName("HRESULT (const GUID &) __attribute__((stdcall))")]
            public delegate* stdcall<ICreateTypeLib*, Guid*, int> SetGuid;

            [NativeTypeName("HRESULT (LPOLESTR) __attribute__((stdcall))")]
            public delegate* stdcall<ICreateTypeLib*, ushort*, int> SetDocString;

            [NativeTypeName("HRESULT (LPOLESTR) __attribute__((stdcall))")]
            public delegate* stdcall<ICreateTypeLib*, ushort*, int> SetHelpFileName;

            [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
            public delegate* stdcall<ICreateTypeLib*, uint, int> SetHelpContext;

            [NativeTypeName("HRESULT (LCID) __attribute__((stdcall))")]
            public delegate* stdcall<ICreateTypeLib*, uint, int> SetLcid;

            [NativeTypeName("HRESULT (UINT) __attribute__((stdcall))")]
            public delegate* stdcall<ICreateTypeLib*, uint, int> SetLibFlags;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* stdcall<ICreateTypeLib*, int> SaveAllChanges;
        }
    }
}
