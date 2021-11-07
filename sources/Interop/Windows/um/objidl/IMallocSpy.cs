// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/objidl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("0000001D-0000-0000-C000-000000000046")]
    [NativeTypeName("struct IMallocSpy : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IMallocSpy : IMallocSpy.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IMallocSpy*, Guid*, void**, int>)(lpVtbl[0]))((IMallocSpy*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMallocSpy*, uint>)(lpVtbl[1]))((IMallocSpy*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMallocSpy*, uint>)(lpVtbl[2]))((IMallocSpy*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("SIZE_T")]
        public nuint PreAlloc([NativeTypeName("SIZE_T")] nuint cbRequest)
        {
            return ((delegate* unmanaged<IMallocSpy*, nuint, nuint>)(lpVtbl[3]))((IMallocSpy*)Unsafe.AsPointer(ref this), cbRequest);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public void* PostAlloc(void* pActual)
        {
            return ((delegate* unmanaged<IMallocSpy*, void*, void*>)(lpVtbl[4]))((IMallocSpy*)Unsafe.AsPointer(ref this), pActual);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public void* PreFree(void* pRequest, BOOL fSpyed)
        {
            return ((delegate* unmanaged<IMallocSpy*, void*, BOOL, void*>)(lpVtbl[5]))((IMallocSpy*)Unsafe.AsPointer(ref this), pRequest, fSpyed);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public void PostFree(BOOL fSpyed)
        {
            ((delegate* unmanaged<IMallocSpy*, BOOL, void>)(lpVtbl[6]))((IMallocSpy*)Unsafe.AsPointer(ref this), fSpyed);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("SIZE_T")]
        public nuint PreRealloc(void* pRequest, [NativeTypeName("SIZE_T")] nuint cbRequest, void** ppNewRequest, BOOL fSpyed)
        {
            return ((delegate* unmanaged<IMallocSpy*, void*, nuint, void**, BOOL, nuint>)(lpVtbl[7]))((IMallocSpy*)Unsafe.AsPointer(ref this), pRequest, cbRequest, ppNewRequest, fSpyed);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public void* PostRealloc(void* pActual, BOOL fSpyed)
        {
            return ((delegate* unmanaged<IMallocSpy*, void*, BOOL, void*>)(lpVtbl[8]))((IMallocSpy*)Unsafe.AsPointer(ref this), pActual, fSpyed);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public void* PreGetSize(void* pRequest, BOOL fSpyed)
        {
            return ((delegate* unmanaged<IMallocSpy*, void*, BOOL, void*>)(lpVtbl[9]))((IMallocSpy*)Unsafe.AsPointer(ref this), pRequest, fSpyed);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        [return: NativeTypeName("SIZE_T")]
        public nuint PostGetSize([NativeTypeName("SIZE_T")] nuint cbActual, BOOL fSpyed)
        {
            return ((delegate* unmanaged<IMallocSpy*, nuint, BOOL, nuint>)(lpVtbl[10]))((IMallocSpy*)Unsafe.AsPointer(ref this), cbActual, fSpyed);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public void* PreDidAlloc(void* pRequest, BOOL fSpyed)
        {
            return ((delegate* unmanaged<IMallocSpy*, void*, BOOL, void*>)(lpVtbl[11]))((IMallocSpy*)Unsafe.AsPointer(ref this), pRequest, fSpyed);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public int PostDidAlloc(void* pRequest, BOOL fSpyed, int fActual)
        {
            return ((delegate* unmanaged<IMallocSpy*, void*, BOOL, int, int>)(lpVtbl[12]))((IMallocSpy*)Unsafe.AsPointer(ref this), pRequest, fSpyed, fActual);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public void PreHeapMinimize()
        {
            ((delegate* unmanaged<IMallocSpy*, void>)(lpVtbl[13]))((IMallocSpy*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public void PostHeapMinimize()
        {
            ((delegate* unmanaged<IMallocSpy*, void>)(lpVtbl[14]))((IMallocSpy*)Unsafe.AsPointer(ref this));
        }

        public interface Interface : IUnknown.Interface
        {
            [VtblIndex(3)]
            [return: NativeTypeName("SIZE_T")]
            nuint PreAlloc([NativeTypeName("SIZE_T")] nuint cbRequest);

            [VtblIndex(4)]
            void* PostAlloc(void* pActual);

            [VtblIndex(5)]
            void* PreFree(void* pRequest, BOOL fSpyed);

            [VtblIndex(6)]
            void PostFree(BOOL fSpyed);

            [VtblIndex(7)]
            [return: NativeTypeName("SIZE_T")]
            nuint PreRealloc(void* pRequest, [NativeTypeName("SIZE_T")] nuint cbRequest, void** ppNewRequest, BOOL fSpyed);

            [VtblIndex(8)]
            void* PostRealloc(void* pActual, BOOL fSpyed);

            [VtblIndex(9)]
            void* PreGetSize(void* pRequest, BOOL fSpyed);

            [VtblIndex(10)]
            [return: NativeTypeName("SIZE_T")]
            nuint PostGetSize([NativeTypeName("SIZE_T")] nuint cbActual, BOOL fSpyed);

            [VtblIndex(11)]
            void* PreDidAlloc(void* pRequest, BOOL fSpyed);

            [VtblIndex(12)]
            int PostDidAlloc(void* pRequest, BOOL fSpyed, int fActual);

            [VtblIndex(13)]
            void PreHeapMinimize();

            [VtblIndex(14)]
            void PostHeapMinimize();
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IMallocSpy*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IMallocSpy*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IMallocSpy*, uint> Release;

            [NativeTypeName("SIZE_T (SIZE_T) __attribute__((stdcall))")]
            public delegate* unmanaged<IMallocSpy*, nuint, nuint> PreAlloc;

            [NativeTypeName("void *(void *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMallocSpy*, void*, void*> PostAlloc;

            [NativeTypeName("void *(void *, BOOL) __attribute__((stdcall))")]
            public delegate* unmanaged<IMallocSpy*, void*, BOOL, void*> PreFree;

            [NativeTypeName("void (BOOL) __attribute__((stdcall))")]
            public delegate* unmanaged<IMallocSpy*, BOOL, void> PostFree;

            [NativeTypeName("SIZE_T (void *, SIZE_T, void **, BOOL) __attribute__((stdcall))")]
            public delegate* unmanaged<IMallocSpy*, void*, nuint, void**, BOOL, nuint> PreRealloc;

            [NativeTypeName("void *(void *, BOOL) __attribute__((stdcall))")]
            public delegate* unmanaged<IMallocSpy*, void*, BOOL, void*> PostRealloc;

            [NativeTypeName("void *(void *, BOOL) __attribute__((stdcall))")]
            public delegate* unmanaged<IMallocSpy*, void*, BOOL, void*> PreGetSize;

            [NativeTypeName("SIZE_T (SIZE_T, BOOL) __attribute__((stdcall))")]
            public delegate* unmanaged<IMallocSpy*, nuint, BOOL, nuint> PostGetSize;

            [NativeTypeName("void *(void *, BOOL) __attribute__((stdcall))")]
            public delegate* unmanaged<IMallocSpy*, void*, BOOL, void*> PreDidAlloc;

            [NativeTypeName("int (void *, BOOL, int) __attribute__((stdcall))")]
            public delegate* unmanaged<IMallocSpy*, void*, BOOL, int, int> PostDidAlloc;

            [NativeTypeName("void () __attribute__((stdcall))")]
            public delegate* unmanaged<IMallocSpy*, void> PreHeapMinimize;

            [NativeTypeName("void () __attribute__((stdcall))")]
            public delegate* unmanaged<IMallocSpy*, void> PostHeapMinimize;
        }
    }
}
