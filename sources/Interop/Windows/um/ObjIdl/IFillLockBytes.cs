// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ObjIdl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("99CAF010-415E-11CF-8814-00AA00B569F5")]
    public unsafe partial struct IFillLockBytes
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((IFillLockBytes*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IFillLockBytes*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IFillLockBytes*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int FillAppend([NativeTypeName("const void *")] void* pv, [NativeTypeName("ULONG")] uint cb, [NativeTypeName("ULONG *")] uint* pcbWritten)
        {
            return lpVtbl->FillAppend((IFillLockBytes*)Unsafe.AsPointer(ref this), pv, cb, pcbWritten);
        }

        [return: NativeTypeName("HRESULT")]
        public int FillAt(ULARGE_INTEGER ulOffset, [NativeTypeName("const void *")] void* pv, [NativeTypeName("ULONG")] uint cb, [NativeTypeName("ULONG *")] uint* pcbWritten)
        {
            return lpVtbl->FillAt((IFillLockBytes*)Unsafe.AsPointer(ref this), ulOffset, pv, cb, pcbWritten);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetFillSize(ULARGE_INTEGER ulSize)
        {
            return lpVtbl->SetFillSize((IFillLockBytes*)Unsafe.AsPointer(ref this), ulSize);
        }

        [return: NativeTypeName("HRESULT")]
        public int Terminate([NativeTypeName("BOOL")] int bCanceled)
        {
            return lpVtbl->Terminate((IFillLockBytes*)Unsafe.AsPointer(ref this), bCanceled);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<IFillLockBytes*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IFillLockBytes*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IFillLockBytes*, uint> Release;

            [NativeTypeName("HRESULT (const void *, ULONG, ULONG *) __attribute__((stdcall))")]
            public delegate* stdcall<IFillLockBytes*, void*, uint, uint*, int> FillAppend;

            [NativeTypeName("HRESULT (ULARGE_INTEGER, const void *, ULONG, ULONG *) __attribute__((stdcall))")]
            public delegate* stdcall<IFillLockBytes*, ULARGE_INTEGER, void*, uint, uint*, int> FillAt;

            [NativeTypeName("HRESULT (ULARGE_INTEGER) __attribute__((stdcall))")]
            public delegate* stdcall<IFillLockBytes*, ULARGE_INTEGER, int> SetFillSize;

            [NativeTypeName("HRESULT (BOOL) __attribute__((stdcall))")]
            public delegate* stdcall<IFillLockBytes*, int, int> Terminate;
        }
    }
}
