// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ObjIdl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("0000010B-0000-0000-C000-000000000046")]
    public unsafe partial struct IPersistFile
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((IPersistFile*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IPersistFile*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IPersistFile*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetClassID([NativeTypeName("CLSID *")] Guid* pClassID)
        {
            return lpVtbl->GetClassID((IPersistFile*)Unsafe.AsPointer(ref this), pClassID);
        }

        [return: NativeTypeName("HRESULT")]
        public int IsDirty()
        {
            return lpVtbl->IsDirty((IPersistFile*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Load([NativeTypeName("LPCOLESTR")] ushort* pszFileName, [NativeTypeName("DWORD")] uint dwMode)
        {
            return lpVtbl->Load((IPersistFile*)Unsafe.AsPointer(ref this), pszFileName, dwMode);
        }

        [return: NativeTypeName("HRESULT")]
        public int Save([NativeTypeName("LPCOLESTR")] ushort* pszFileName, [NativeTypeName("BOOL")] int fRemember)
        {
            return lpVtbl->Save((IPersistFile*)Unsafe.AsPointer(ref this), pszFileName, fRemember);
        }

        [return: NativeTypeName("HRESULT")]
        public int SaveCompleted([NativeTypeName("LPCOLESTR")] ushort* pszFileName)
        {
            return lpVtbl->SaveCompleted((IPersistFile*)Unsafe.AsPointer(ref this), pszFileName);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetCurFile([NativeTypeName("LPOLESTR *")] ushort** ppszFileName)
        {
            return lpVtbl->GetCurFile((IPersistFile*)Unsafe.AsPointer(ref this), ppszFileName);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<IPersistFile*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IPersistFile*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IPersistFile*, uint> Release;

            [NativeTypeName("HRESULT (CLSID *) __attribute__((stdcall))")]
            public delegate* stdcall<IPersistFile*, Guid*, int> GetClassID;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* stdcall<IPersistFile*, int> IsDirty;

            [NativeTypeName("HRESULT (LPCOLESTR, DWORD) __attribute__((stdcall))")]
            public delegate* stdcall<IPersistFile*, ushort*, uint, int> Load;

            [NativeTypeName("HRESULT (LPCOLESTR, BOOL) __attribute__((stdcall))")]
            public delegate* stdcall<IPersistFile*, ushort*, int, int> Save;

            [NativeTypeName("HRESULT (LPCOLESTR) __attribute__((stdcall))")]
            public delegate* stdcall<IPersistFile*, ushort*, int> SaveCompleted;

            [NativeTypeName("HRESULT (LPOLESTR *) __attribute__((stdcall))")]
            public delegate* stdcall<IPersistFile*, ushort**, int> GetCurFile;
        }
    }
}
