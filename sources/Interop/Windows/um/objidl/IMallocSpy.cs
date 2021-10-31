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
    public unsafe partial struct IMallocSpy
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
    }
}
