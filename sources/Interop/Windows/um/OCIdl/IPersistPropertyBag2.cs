// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/OCIdl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("22F55881-280B-11D0-A8A9-00A0C90C2004")]
    public unsafe partial struct IPersistPropertyBag2
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((IPersistPropertyBag2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IPersistPropertyBag2*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IPersistPropertyBag2*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetClassID([NativeTypeName("CLSID *")] Guid* pClassID)
        {
            return lpVtbl->GetClassID((IPersistPropertyBag2*)Unsafe.AsPointer(ref this), pClassID);
        }

        [return: NativeTypeName("HRESULT")]
        public int InitNew()
        {
            return lpVtbl->InitNew((IPersistPropertyBag2*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Load([NativeTypeName("IPropertyBag2 *")] IPropertyBag2* pPropBag, [NativeTypeName("IErrorLog *")] IErrorLog* pErrLog)
        {
            return lpVtbl->Load((IPersistPropertyBag2*)Unsafe.AsPointer(ref this), pPropBag, pErrLog);
        }

        [return: NativeTypeName("HRESULT")]
        public int Save([NativeTypeName("IPropertyBag2 *")] IPropertyBag2* pPropBag, [NativeTypeName("BOOL")] int fClearDirty, [NativeTypeName("BOOL")] int fSaveAllProperties)
        {
            return lpVtbl->Save((IPersistPropertyBag2*)Unsafe.AsPointer(ref this), pPropBag, fClearDirty, fSaveAllProperties);
        }

        [return: NativeTypeName("HRESULT")]
        public int IsDirty()
        {
            return lpVtbl->IsDirty((IPersistPropertyBag2*)Unsafe.AsPointer(ref this));
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<IPersistPropertyBag2*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IPersistPropertyBag2*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IPersistPropertyBag2*, uint> Release;

            [NativeTypeName("HRESULT (CLSID *) __attribute__((stdcall))")]
            public delegate* stdcall<IPersistPropertyBag2*, Guid*, int> GetClassID;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* stdcall<IPersistPropertyBag2*, int> InitNew;

            [NativeTypeName("HRESULT (IPropertyBag2 *, IErrorLog *) __attribute__((stdcall))")]
            public delegate* stdcall<IPersistPropertyBag2*, IPropertyBag2*, IErrorLog*, int> Load;

            [NativeTypeName("HRESULT (IPropertyBag2 *, BOOL, BOOL) __attribute__((stdcall))")]
            public delegate* stdcall<IPersistPropertyBag2*, IPropertyBag2*, int, int, int> Save;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* stdcall<IPersistPropertyBag2*, int> IsDirty;
        }
    }
}
