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

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IMallocSpy* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IMallocSpy* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IMallocSpy* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("SIZE_T")]
        public delegate nuint _PreAlloc(IMallocSpy* pThis, [NativeTypeName("SIZE_T")] nuint cbRequest);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("void *")]
        public delegate void* _PostAlloc(IMallocSpy* pThis, [NativeTypeName("void *")] void* pActual);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("void *")]
        public delegate void* _PreFree(IMallocSpy* pThis, [NativeTypeName("void *")] void* pRequest, [NativeTypeName("BOOL")] int fSpyed);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate void _PostFree(IMallocSpy* pThis, [NativeTypeName("BOOL")] int fSpyed);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("SIZE_T")]
        public delegate nuint _PreRealloc(IMallocSpy* pThis, [NativeTypeName("void *")] void* pRequest, [NativeTypeName("SIZE_T")] nuint cbRequest, [NativeTypeName("void **")] void** ppNewRequest, [NativeTypeName("BOOL")] int fSpyed);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("void *")]
        public delegate void* _PostRealloc(IMallocSpy* pThis, [NativeTypeName("void *")] void* pActual, [NativeTypeName("BOOL")] int fSpyed);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("void *")]
        public delegate void* _PreGetSize(IMallocSpy* pThis, [NativeTypeName("void *")] void* pRequest, [NativeTypeName("BOOL")] int fSpyed);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("SIZE_T")]
        public delegate nuint _PostGetSize(IMallocSpy* pThis, [NativeTypeName("SIZE_T")] nuint cbActual, [NativeTypeName("BOOL")] int fSpyed);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("void *")]
        public delegate void* _PreDidAlloc(IMallocSpy* pThis, [NativeTypeName("void *")] void* pRequest, [NativeTypeName("BOOL")] int fSpyed);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate int _PostDidAlloc(IMallocSpy* pThis, [NativeTypeName("void *")] void* pRequest, [NativeTypeName("BOOL")] int fSpyed, int fActual);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate void _PreHeapMinimize(IMallocSpy* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate void _PostHeapMinimize(IMallocSpy* pThis);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((IMallocSpy*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((IMallocSpy*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((IMallocSpy*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("SIZE_T")]
        public nuint PreAlloc([NativeTypeName("SIZE_T")] nuint cbRequest)
        {
            return Marshal.GetDelegateForFunctionPointer<_PreAlloc>(lpVtbl->PreAlloc)((IMallocSpy*)Unsafe.AsPointer(ref this), cbRequest);
        }

        [return: NativeTypeName("void *")]
        public void* PostAlloc([NativeTypeName("void *")] void* pActual)
        {
            return Marshal.GetDelegateForFunctionPointer<_PostAlloc>(lpVtbl->PostAlloc)((IMallocSpy*)Unsafe.AsPointer(ref this), pActual);
        }

        [return: NativeTypeName("void *")]
        public void* PreFree([NativeTypeName("void *")] void* pRequest, [NativeTypeName("BOOL")] int fSpyed)
        {
            return Marshal.GetDelegateForFunctionPointer<_PreFree>(lpVtbl->PreFree)((IMallocSpy*)Unsafe.AsPointer(ref this), pRequest, fSpyed);
        }

        public void PostFree([NativeTypeName("BOOL")] int fSpyed)
        {
            Marshal.GetDelegateForFunctionPointer<_PostFree>(lpVtbl->PostFree)((IMallocSpy*)Unsafe.AsPointer(ref this), fSpyed);
        }

        [return: NativeTypeName("SIZE_T")]
        public nuint PreRealloc([NativeTypeName("void *")] void* pRequest, [NativeTypeName("SIZE_T")] nuint cbRequest, [NativeTypeName("void **")] void** ppNewRequest, [NativeTypeName("BOOL")] int fSpyed)
        {
            return Marshal.GetDelegateForFunctionPointer<_PreRealloc>(lpVtbl->PreRealloc)((IMallocSpy*)Unsafe.AsPointer(ref this), pRequest, cbRequest, ppNewRequest, fSpyed);
        }

        [return: NativeTypeName("void *")]
        public void* PostRealloc([NativeTypeName("void *")] void* pActual, [NativeTypeName("BOOL")] int fSpyed)
        {
            return Marshal.GetDelegateForFunctionPointer<_PostRealloc>(lpVtbl->PostRealloc)((IMallocSpy*)Unsafe.AsPointer(ref this), pActual, fSpyed);
        }

        [return: NativeTypeName("void *")]
        public void* PreGetSize([NativeTypeName("void *")] void* pRequest, [NativeTypeName("BOOL")] int fSpyed)
        {
            return Marshal.GetDelegateForFunctionPointer<_PreGetSize>(lpVtbl->PreGetSize)((IMallocSpy*)Unsafe.AsPointer(ref this), pRequest, fSpyed);
        }

        [return: NativeTypeName("SIZE_T")]
        public nuint PostGetSize([NativeTypeName("SIZE_T")] nuint cbActual, [NativeTypeName("BOOL")] int fSpyed)
        {
            return Marshal.GetDelegateForFunctionPointer<_PostGetSize>(lpVtbl->PostGetSize)((IMallocSpy*)Unsafe.AsPointer(ref this), cbActual, fSpyed);
        }

        [return: NativeTypeName("void *")]
        public void* PreDidAlloc([NativeTypeName("void *")] void* pRequest, [NativeTypeName("BOOL")] int fSpyed)
        {
            return Marshal.GetDelegateForFunctionPointer<_PreDidAlloc>(lpVtbl->PreDidAlloc)((IMallocSpy*)Unsafe.AsPointer(ref this), pRequest, fSpyed);
        }

        public int PostDidAlloc([NativeTypeName("void *")] void* pRequest, [NativeTypeName("BOOL")] int fSpyed, int fActual)
        {
            return Marshal.GetDelegateForFunctionPointer<_PostDidAlloc>(lpVtbl->PostDidAlloc)((IMallocSpy*)Unsafe.AsPointer(ref this), pRequest, fSpyed, fActual);
        }

        public void PreHeapMinimize()
        {
            Marshal.GetDelegateForFunctionPointer<_PreHeapMinimize>(lpVtbl->PreHeapMinimize)((IMallocSpy*)Unsafe.AsPointer(ref this));
        }

        public void PostHeapMinimize()
        {
            Marshal.GetDelegateForFunctionPointer<_PostHeapMinimize>(lpVtbl->PostHeapMinimize)((IMallocSpy*)Unsafe.AsPointer(ref this));
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Release;

            [NativeTypeName("SIZE_T (SIZE_T) __attribute__((stdcall))")]
            public IntPtr PreAlloc;

            [NativeTypeName("void *(void *) __attribute__((stdcall))")]
            public IntPtr PostAlloc;

            [NativeTypeName("void *(void *, BOOL) __attribute__((stdcall))")]
            public IntPtr PreFree;

            [NativeTypeName("void (BOOL) __attribute__((stdcall))")]
            public IntPtr PostFree;

            [NativeTypeName("SIZE_T (void *, SIZE_T, void **, BOOL) __attribute__((stdcall))")]
            public IntPtr PreRealloc;

            [NativeTypeName("void *(void *, BOOL) __attribute__((stdcall))")]
            public IntPtr PostRealloc;

            [NativeTypeName("void *(void *, BOOL) __attribute__((stdcall))")]
            public IntPtr PreGetSize;

            [NativeTypeName("SIZE_T (SIZE_T, BOOL) __attribute__((stdcall))")]
            public IntPtr PostGetSize;

            [NativeTypeName("void *(void *, BOOL) __attribute__((stdcall))")]
            public IntPtr PreDidAlloc;

            [NativeTypeName("int (void *, BOOL, int) __attribute__((stdcall))")]
            public IntPtr PostDidAlloc;

            [NativeTypeName("void () __attribute__((stdcall))")]
            public IntPtr PreHeapMinimize;

            [NativeTypeName("void () __attribute__((stdcall))")]
            public IntPtr PostHeapMinimize;
        }
    }
}
