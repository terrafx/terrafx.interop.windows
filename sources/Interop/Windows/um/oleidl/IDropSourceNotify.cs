// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/oleidl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("0000012B-0000-0000-C000-000000000046")]
    public unsafe partial struct IDropSourceNotify
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((IDropSourceNotify*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IDropSourceNotify*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IDropSourceNotify*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int DragEnterTarget([NativeTypeName("HWND")] IntPtr hwndTarget)
        {
            return lpVtbl->DragEnterTarget((IDropSourceNotify*)Unsafe.AsPointer(ref this), hwndTarget);
        }

        [return: NativeTypeName("HRESULT")]
        public int DragLeaveTarget()
        {
            return lpVtbl->DragLeaveTarget((IDropSourceNotify*)Unsafe.AsPointer(ref this));
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<IDropSourceNotify*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IDropSourceNotify*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IDropSourceNotify*, uint> Release;

            [NativeTypeName("HRESULT (HWND) __attribute__((stdcall))")]
            public delegate* stdcall<IDropSourceNotify*, IntPtr, int> DragEnterTarget;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* stdcall<IDropSourceNotify*, int> DragLeaveTarget;
        }
    }
}
