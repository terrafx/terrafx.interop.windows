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
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IMalloc*, Guid*, void**, int>)(lpVtbl[0]))((IMalloc*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IMalloc*, uint>)(lpVtbl[1]))((IMalloc*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IMalloc*, uint>)(lpVtbl[2]))((IMalloc*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("void *")]
        public void* Alloc([NativeTypeName("SIZE_T")] nuint cb)
        {
            return ((delegate* stdcall<IMalloc*, nuint, void*>)(lpVtbl[3]))((IMalloc*)Unsafe.AsPointer(ref this), cb);
        }

        [return: NativeTypeName("void *")]
        public void* Realloc([NativeTypeName("void *")] void* pv, [NativeTypeName("SIZE_T")] nuint cb)
        {
            return ((delegate* stdcall<IMalloc*, void*, nuint, void*>)(lpVtbl[4]))((IMalloc*)Unsafe.AsPointer(ref this), pv, cb);
        }

        public void Free([NativeTypeName("void *")] void* pv)
        {
            ((delegate* stdcall<IMalloc*, void*, void>)(lpVtbl[5]))((IMalloc*)Unsafe.AsPointer(ref this), pv);
        }

        [return: NativeTypeName("SIZE_T")]
        public nuint GetSize([NativeTypeName("void *")] void* pv)
        {
            return ((delegate* stdcall<IMalloc*, void*, nuint>)(lpVtbl[6]))((IMalloc*)Unsafe.AsPointer(ref this), pv);
        }

        public int DidAlloc([NativeTypeName("void *")] void* pv)
        {
            return ((delegate* stdcall<IMalloc*, void*, int>)(lpVtbl[7]))((IMalloc*)Unsafe.AsPointer(ref this), pv);
        }

        public void HeapMinimize()
        {
            ((delegate* stdcall<IMalloc*, void>)(lpVtbl[8]))((IMalloc*)Unsafe.AsPointer(ref this));
        }
    }
}
