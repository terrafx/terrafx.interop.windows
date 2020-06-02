// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ObjIdl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("0000010A-0000-0000-C000-000000000046")]
    public unsafe partial struct IPersistStorage
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((IPersistStorage*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IPersistStorage*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IPersistStorage*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetClassID([NativeTypeName("CLSID *")] Guid* pClassID)
        {
            return lpVtbl->GetClassID((IPersistStorage*)Unsafe.AsPointer(ref this), pClassID);
        }

        [return: NativeTypeName("HRESULT")]
        public int IsDirty()
        {
            return lpVtbl->IsDirty((IPersistStorage*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int InitNew([NativeTypeName("IStorage *")] IStorage* pStg)
        {
            return lpVtbl->InitNew((IPersistStorage*)Unsafe.AsPointer(ref this), pStg);
        }

        [return: NativeTypeName("HRESULT")]
        public int Load([NativeTypeName("IStorage *")] IStorage* pStg)
        {
            return lpVtbl->Load((IPersistStorage*)Unsafe.AsPointer(ref this), pStg);
        }

        [return: NativeTypeName("HRESULT")]
        public int Save([NativeTypeName("IStorage *")] IStorage* pStgSave, [NativeTypeName("BOOL")] int fSameAsLoad)
        {
            return lpVtbl->Save((IPersistStorage*)Unsafe.AsPointer(ref this), pStgSave, fSameAsLoad);
        }

        [return: NativeTypeName("HRESULT")]
        public int SaveCompleted([NativeTypeName("IStorage *")] IStorage* pStgNew)
        {
            return lpVtbl->SaveCompleted((IPersistStorage*)Unsafe.AsPointer(ref this), pStgNew);
        }

        [return: NativeTypeName("HRESULT")]
        public int HandsOffStorage()
        {
            return lpVtbl->HandsOffStorage((IPersistStorage*)Unsafe.AsPointer(ref this));
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<IPersistStorage*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IPersistStorage*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IPersistStorage*, uint> Release;

            [NativeTypeName("HRESULT (CLSID *) __attribute__((stdcall))")]
            public delegate* stdcall<IPersistStorage*, Guid*, int> GetClassID;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* stdcall<IPersistStorage*, int> IsDirty;

            [NativeTypeName("HRESULT (IStorage *) __attribute__((stdcall))")]
            public delegate* stdcall<IPersistStorage*, IStorage*, int> InitNew;

            [NativeTypeName("HRESULT (IStorage *) __attribute__((stdcall))")]
            public delegate* stdcall<IPersistStorage*, IStorage*, int> Load;

            [NativeTypeName("HRESULT (IStorage *, BOOL) __attribute__((stdcall))")]
            public delegate* stdcall<IPersistStorage*, IStorage*, int, int> Save;

            [NativeTypeName("HRESULT (IStorage *) __attribute__((stdcall))")]
            public delegate* stdcall<IPersistStorage*, IStorage*, int> SaveCompleted;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* stdcall<IPersistStorage*, int> HandsOffStorage;
        }
    }
}
