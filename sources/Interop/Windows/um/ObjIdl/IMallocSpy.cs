// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ObjIdl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("0000001D-0000-0000-C000-000000000046")]
    [NativeTypeName("struct IMallocSpy : IUnknown")]
    public unsafe partial struct IMallocSpy
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<IMallocSpy*, Guid*, void**, int>)(lpVtbl[0]))((IMallocSpy*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<IMallocSpy*, uint>)(lpVtbl[1]))((IMallocSpy*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<IMallocSpy*, uint>)(lpVtbl[2]))((IMallocSpy*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("SIZE_T")]
        public nuint PreAlloc([NativeTypeName("SIZE_T")] nuint cbRequest)
        {
            return ((delegate* unmanaged[Stdcall]<IMallocSpy*, nuint, nuint>)(lpVtbl[3]))((IMallocSpy*)Unsafe.AsPointer(ref this), cbRequest);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("void *")]
        public void* PostAlloc([NativeTypeName("void *")] void* pActual)
        {
            return ((delegate* unmanaged[Stdcall]<IMallocSpy*, void*, void*>)(lpVtbl[4]))((IMallocSpy*)Unsafe.AsPointer(ref this), pActual);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("void *")]
        public void* PreFree([NativeTypeName("void *")] void* pRequest, [NativeTypeName("BOOL")] int fSpyed)
        {
            return ((delegate* unmanaged[Stdcall]<IMallocSpy*, void*, int, void*>)(lpVtbl[5]))((IMallocSpy*)Unsafe.AsPointer(ref this), pRequest, fSpyed);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void PostFree([NativeTypeName("BOOL")] int fSpyed)
        {
            ((delegate* unmanaged[Stdcall]<IMallocSpy*, int, void>)(lpVtbl[6]))((IMallocSpy*)Unsafe.AsPointer(ref this), fSpyed);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("SIZE_T")]
        public nuint PreRealloc([NativeTypeName("void *")] void* pRequest, [NativeTypeName("SIZE_T")] nuint cbRequest, [NativeTypeName("void **")] void** ppNewRequest, [NativeTypeName("BOOL")] int fSpyed)
        {
            return ((delegate* unmanaged[Stdcall]<IMallocSpy*, void*, nuint, void**, int, nuint>)(lpVtbl[7]))((IMallocSpy*)Unsafe.AsPointer(ref this), pRequest, cbRequest, ppNewRequest, fSpyed);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("void *")]
        public void* PostRealloc([NativeTypeName("void *")] void* pActual, [NativeTypeName("BOOL")] int fSpyed)
        {
            return ((delegate* unmanaged[Stdcall]<IMallocSpy*, void*, int, void*>)(lpVtbl[8]))((IMallocSpy*)Unsafe.AsPointer(ref this), pActual, fSpyed);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("void *")]
        public void* PreGetSize([NativeTypeName("void *")] void* pRequest, [NativeTypeName("BOOL")] int fSpyed)
        {
            return ((delegate* unmanaged[Stdcall]<IMallocSpy*, void*, int, void*>)(lpVtbl[9]))((IMallocSpy*)Unsafe.AsPointer(ref this), pRequest, fSpyed);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("SIZE_T")]
        public nuint PostGetSize([NativeTypeName("SIZE_T")] nuint cbActual, [NativeTypeName("BOOL")] int fSpyed)
        {
            return ((delegate* unmanaged[Stdcall]<IMallocSpy*, nuint, int, nuint>)(lpVtbl[10]))((IMallocSpy*)Unsafe.AsPointer(ref this), cbActual, fSpyed);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("void *")]
        public void* PreDidAlloc([NativeTypeName("void *")] void* pRequest, [NativeTypeName("BOOL")] int fSpyed)
        {
            return ((delegate* unmanaged[Stdcall]<IMallocSpy*, void*, int, void*>)(lpVtbl[11]))((IMallocSpy*)Unsafe.AsPointer(ref this), pRequest, fSpyed);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int PostDidAlloc([NativeTypeName("void *")] void* pRequest, [NativeTypeName("BOOL")] int fSpyed, int fActual)
        {
            return ((delegate* unmanaged[Stdcall]<IMallocSpy*, void*, int, int, int>)(lpVtbl[12]))((IMallocSpy*)Unsafe.AsPointer(ref this), pRequest, fSpyed, fActual);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void PreHeapMinimize()
        {
            ((delegate* unmanaged[Stdcall]<IMallocSpy*, void>)(lpVtbl[13]))((IMallocSpy*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void PostHeapMinimize()
        {
            ((delegate* unmanaged[Stdcall]<IMallocSpy*, void>)(lpVtbl[14]))((IMallocSpy*)Unsafe.AsPointer(ref this));
        }
    }
}
