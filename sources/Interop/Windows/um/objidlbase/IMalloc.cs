// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ObjIdlbase.h in the Windows SDK for Windows 10.0.18362.0
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

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IMalloc* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IMalloc* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IMalloc* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("void *")]
        public delegate void* _Alloc(IMalloc* pThis, [NativeTypeName("SIZE_T")] uint cb);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("void *")]
        public delegate void* _Realloc(IMalloc* pThis, [NativeTypeName("void *")] void* pv, [NativeTypeName("SIZE_T")] uint cb);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate void _Free(IMalloc* pThis, [NativeTypeName("void *")] void* pv);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("SIZE_T")]
        public delegate uint _GetSize(IMalloc* pThis, [NativeTypeName("void *")] void* pv);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate int _DidAlloc(IMalloc* pThis, [NativeTypeName("void *")] void* pv);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate void _HeapMinimize(IMalloc* pThis);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((IMalloc*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((IMalloc*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((IMalloc*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("void *")]
        public void* Alloc([NativeTypeName("SIZE_T")] uint cb)
        {
            return Marshal.GetDelegateForFunctionPointer<_Alloc>(lpVtbl->Alloc)((IMalloc*)Unsafe.AsPointer(ref this), cb);
        }

        [return: NativeTypeName("void *")]
        public void* Realloc([NativeTypeName("void *")] void* pv, [NativeTypeName("SIZE_T")] uint cb)
        {
            return Marshal.GetDelegateForFunctionPointer<_Realloc>(lpVtbl->Realloc)((IMalloc*)Unsafe.AsPointer(ref this), pv, cb);
        }

        public void Free([NativeTypeName("void *")] void* pv)
        {
            Marshal.GetDelegateForFunctionPointer<_Free>(lpVtbl->Free)((IMalloc*)Unsafe.AsPointer(ref this), pv);
        }

        [return: NativeTypeName("SIZE_T")]
        public uint GetSize([NativeTypeName("void *")] void* pv)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetSize>(lpVtbl->GetSize)((IMalloc*)Unsafe.AsPointer(ref this), pv);
        }

        public int DidAlloc([NativeTypeName("void *")] void* pv)
        {
            return Marshal.GetDelegateForFunctionPointer<_DidAlloc>(lpVtbl->DidAlloc)((IMalloc*)Unsafe.AsPointer(ref this), pv);
        }

        public void HeapMinimize()
        {
            Marshal.GetDelegateForFunctionPointer<_HeapMinimize>(lpVtbl->HeapMinimize)((IMalloc*)Unsafe.AsPointer(ref this));
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Release;

            [NativeTypeName("void *(SIZE_T) __attribute__((stdcall))")]
            public IntPtr Alloc;

            [NativeTypeName("void *(void *, SIZE_T) __attribute__((stdcall))")]
            public IntPtr Realloc;

            [NativeTypeName("void (void *) __attribute__((stdcall))")]
            public IntPtr Free;

            [NativeTypeName("SIZE_T (void *) __attribute__((stdcall))")]
            public IntPtr GetSize;

            [NativeTypeName("int (void *) __attribute__((stdcall))")]
            public IntPtr DidAlloc;

            [NativeTypeName("void () __attribute__((stdcall))")]
            public IntPtr HeapMinimize;
        }
    }
}
