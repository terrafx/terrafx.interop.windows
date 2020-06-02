// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ObjIdlbase.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("00000002-0000-0000-C000-000000000046")]
    public unsafe partial struct IMalloc
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((IMalloc*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IMalloc*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IMalloc*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("void *")]
        public void* Alloc([NativeTypeName("SIZE_T")] nuint cb)
        {
            return lpVtbl->Alloc((IMalloc*)Unsafe.AsPointer(ref this), cb);
        }

        [return: NativeTypeName("void *")]
        public void* Realloc([NativeTypeName("void *")] void* pv, [NativeTypeName("SIZE_T")] nuint cb)
        {
            return lpVtbl->Realloc((IMalloc*)Unsafe.AsPointer(ref this), pv, cb);
        }

        public void Free([NativeTypeName("void *")] void* pv)
        {
            lpVtbl->Free((IMalloc*)Unsafe.AsPointer(ref this), pv);
        }

        [return: NativeTypeName("SIZE_T")]
        public nuint GetSize([NativeTypeName("void *")] void* pv)
        {
            return lpVtbl->GetSize((IMalloc*)Unsafe.AsPointer(ref this), pv);
        }

        public int DidAlloc([NativeTypeName("void *")] void* pv)
        {
            return lpVtbl->DidAlloc((IMalloc*)Unsafe.AsPointer(ref this), pv);
        }

        public void HeapMinimize()
        {
            lpVtbl->HeapMinimize((IMalloc*)Unsafe.AsPointer(ref this));
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<IMalloc*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IMalloc*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IMalloc*, uint> Release;

            [NativeTypeName("void *(SIZE_T) __attribute__((stdcall))")]
            public delegate* stdcall<IMalloc*, nuint, void*> Alloc;

            [NativeTypeName("void *(void *, SIZE_T) __attribute__((stdcall))")]
            public delegate* stdcall<IMalloc*, void*, nuint, void*> Realloc;

            [NativeTypeName("void (void *) __attribute__((stdcall))")]
            public delegate* stdcall<IMalloc*, void*, void> Free;

            [NativeTypeName("SIZE_T (void *) __attribute__((stdcall))")]
            public delegate* stdcall<IMalloc*, void*, nuint> GetSize;

            [NativeTypeName("int (void *) __attribute__((stdcall))")]
            public delegate* stdcall<IMalloc*, void*, int> DidAlloc;

            [NativeTypeName("void () __attribute__((stdcall))")]
            public delegate* stdcall<IMalloc*, void> HeapMinimize;
        }
    }
}
