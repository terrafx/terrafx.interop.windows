// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("79EAC9C9-BAF9-11CE-8C82-00AA004BA90B")]
    public unsafe partial struct IPersistMoniker
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((IPersistMoniker*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IPersistMoniker*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IPersistMoniker*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetClassID([NativeTypeName("CLSID *")] Guid* pClassID)
        {
            return lpVtbl->GetClassID((IPersistMoniker*)Unsafe.AsPointer(ref this), pClassID);
        }

        [return: NativeTypeName("HRESULT")]
        public int IsDirty()
        {
            return lpVtbl->IsDirty((IPersistMoniker*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Load([NativeTypeName("BOOL")] int fFullyAvailable, [NativeTypeName("IMoniker *")] IMoniker* pimkName, [NativeTypeName("LPBC")] IBindCtx* pibc, [NativeTypeName("DWORD")] uint grfMode)
        {
            return lpVtbl->Load((IPersistMoniker*)Unsafe.AsPointer(ref this), fFullyAvailable, pimkName, pibc, grfMode);
        }

        [return: NativeTypeName("HRESULT")]
        public int Save([NativeTypeName("IMoniker *")] IMoniker* pimkName, [NativeTypeName("LPBC")] IBindCtx* pbc, [NativeTypeName("BOOL")] int fRemember)
        {
            return lpVtbl->Save((IPersistMoniker*)Unsafe.AsPointer(ref this), pimkName, pbc, fRemember);
        }

        [return: NativeTypeName("HRESULT")]
        public int SaveCompleted([NativeTypeName("IMoniker *")] IMoniker* pimkName, [NativeTypeName("LPBC")] IBindCtx* pibc)
        {
            return lpVtbl->SaveCompleted((IPersistMoniker*)Unsafe.AsPointer(ref this), pimkName, pibc);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetCurMoniker([NativeTypeName("IMoniker **")] IMoniker** ppimkName)
        {
            return lpVtbl->GetCurMoniker((IPersistMoniker*)Unsafe.AsPointer(ref this), ppimkName);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<IPersistMoniker*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IPersistMoniker*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IPersistMoniker*, uint> Release;

            [NativeTypeName("HRESULT (CLSID *) __attribute__((stdcall))")]
            public delegate* stdcall<IPersistMoniker*, Guid*, int> GetClassID;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* stdcall<IPersistMoniker*, int> IsDirty;

            [NativeTypeName("HRESULT (BOOL, IMoniker *, LPBC, DWORD) __attribute__((stdcall))")]
            public delegate* stdcall<IPersistMoniker*, int, IMoniker*, IBindCtx*, uint, int> Load;

            [NativeTypeName("HRESULT (IMoniker *, LPBC, BOOL) __attribute__((stdcall))")]
            public delegate* stdcall<IPersistMoniker*, IMoniker*, IBindCtx*, int, int> Save;

            [NativeTypeName("HRESULT (IMoniker *, LPBC) __attribute__((stdcall))")]
            public delegate* stdcall<IPersistMoniker*, IMoniker*, IBindCtx*, int> SaveCompleted;

            [NativeTypeName("HRESULT (IMoniker **) __attribute__((stdcall))")]
            public delegate* stdcall<IPersistMoniker*, IMoniker**, int> GetCurMoniker;
        }
    }
}
