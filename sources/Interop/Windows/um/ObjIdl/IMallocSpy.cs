// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ObjIdl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("0000001D-0000-0000-C000-000000000046")]
    public unsafe partial struct IMallocSpy
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((IMallocSpy*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IMallocSpy*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IMallocSpy*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("SIZE_T")]
        public nuint PreAlloc([NativeTypeName("SIZE_T")] nuint cbRequest)
        {
            return lpVtbl->PreAlloc((IMallocSpy*)Unsafe.AsPointer(ref this), cbRequest);
        }

        [return: NativeTypeName("void *")]
        public void* PostAlloc([NativeTypeName("void *")] void* pActual)
        {
            return lpVtbl->PostAlloc((IMallocSpy*)Unsafe.AsPointer(ref this), pActual);
        }

        [return: NativeTypeName("void *")]
        public void* PreFree([NativeTypeName("void *")] void* pRequest, [NativeTypeName("BOOL")] int fSpyed)
        {
            return lpVtbl->PreFree((IMallocSpy*)Unsafe.AsPointer(ref this), pRequest, fSpyed);
        }

        public void PostFree([NativeTypeName("BOOL")] int fSpyed)
        {
            lpVtbl->PostFree((IMallocSpy*)Unsafe.AsPointer(ref this), fSpyed);
        }

        [return: NativeTypeName("SIZE_T")]
        public nuint PreRealloc([NativeTypeName("void *")] void* pRequest, [NativeTypeName("SIZE_T")] nuint cbRequest, [NativeTypeName("void **")] void** ppNewRequest, [NativeTypeName("BOOL")] int fSpyed)
        {
            return lpVtbl->PreRealloc((IMallocSpy*)Unsafe.AsPointer(ref this), pRequest, cbRequest, ppNewRequest, fSpyed);
        }

        [return: NativeTypeName("void *")]
        public void* PostRealloc([NativeTypeName("void *")] void* pActual, [NativeTypeName("BOOL")] int fSpyed)
        {
            return lpVtbl->PostRealloc((IMallocSpy*)Unsafe.AsPointer(ref this), pActual, fSpyed);
        }

        [return: NativeTypeName("void *")]
        public void* PreGetSize([NativeTypeName("void *")] void* pRequest, [NativeTypeName("BOOL")] int fSpyed)
        {
            return lpVtbl->PreGetSize((IMallocSpy*)Unsafe.AsPointer(ref this), pRequest, fSpyed);
        }

        [return: NativeTypeName("SIZE_T")]
        public nuint PostGetSize([NativeTypeName("SIZE_T")] nuint cbActual, [NativeTypeName("BOOL")] int fSpyed)
        {
            return lpVtbl->PostGetSize((IMallocSpy*)Unsafe.AsPointer(ref this), cbActual, fSpyed);
        }

        [return: NativeTypeName("void *")]
        public void* PreDidAlloc([NativeTypeName("void *")] void* pRequest, [NativeTypeName("BOOL")] int fSpyed)
        {
            return lpVtbl->PreDidAlloc((IMallocSpy*)Unsafe.AsPointer(ref this), pRequest, fSpyed);
        }

        public int PostDidAlloc([NativeTypeName("void *")] void* pRequest, [NativeTypeName("BOOL")] int fSpyed, int fActual)
        {
            return lpVtbl->PostDidAlloc((IMallocSpy*)Unsafe.AsPointer(ref this), pRequest, fSpyed, fActual);
        }

        public void PreHeapMinimize()
        {
            lpVtbl->PreHeapMinimize((IMallocSpy*)Unsafe.AsPointer(ref this));
        }

        public void PostHeapMinimize()
        {
            lpVtbl->PostHeapMinimize((IMallocSpy*)Unsafe.AsPointer(ref this));
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<IMallocSpy*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IMallocSpy*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IMallocSpy*, uint> Release;

            [NativeTypeName("SIZE_T (SIZE_T) __attribute__((stdcall))")]
            public delegate* stdcall<IMallocSpy*, nuint, nuint> PreAlloc;

            [NativeTypeName("void *(void *) __attribute__((stdcall))")]
            public delegate* stdcall<IMallocSpy*, void*, void*> PostAlloc;

            [NativeTypeName("void *(void *, BOOL) __attribute__((stdcall))")]
            public delegate* stdcall<IMallocSpy*, void*, int, void*> PreFree;

            [NativeTypeName("void (BOOL) __attribute__((stdcall))")]
            public delegate* stdcall<IMallocSpy*, int, void> PostFree;

            [NativeTypeName("SIZE_T (void *, SIZE_T, void **, BOOL) __attribute__((stdcall))")]
            public delegate* stdcall<IMallocSpy*, void*, nuint, void**, int, nuint> PreRealloc;

            [NativeTypeName("void *(void *, BOOL) __attribute__((stdcall))")]
            public delegate* stdcall<IMallocSpy*, void*, int, void*> PostRealloc;

            [NativeTypeName("void *(void *, BOOL) __attribute__((stdcall))")]
            public delegate* stdcall<IMallocSpy*, void*, int, void*> PreGetSize;

            [NativeTypeName("SIZE_T (SIZE_T, BOOL) __attribute__((stdcall))")]
            public delegate* stdcall<IMallocSpy*, nuint, int, nuint> PostGetSize;

            [NativeTypeName("void *(void *, BOOL) __attribute__((stdcall))")]
            public delegate* stdcall<IMallocSpy*, void*, int, void*> PreDidAlloc;

            [NativeTypeName("int (void *, BOOL, int) __attribute__((stdcall))")]
            public delegate* stdcall<IMallocSpy*, void*, int, int, int> PostDidAlloc;

            [NativeTypeName("void () __attribute__((stdcall))")]
            public delegate* stdcall<IMallocSpy*, void> PreHeapMinimize;

            [NativeTypeName("void () __attribute__((stdcall))")]
            public delegate* stdcall<IMallocSpy*, void> PostHeapMinimize;
        }
    }
}
