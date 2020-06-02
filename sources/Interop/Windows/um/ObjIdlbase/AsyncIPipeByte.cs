// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ObjIdlbase.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("DB2F3ACB-2F86-11D1-8E04-00C04FB9989A")]
    public unsafe partial struct AsyncIPipeByte
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((AsyncIPipeByte*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((AsyncIPipeByte*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((AsyncIPipeByte*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Begin_Pull([NativeTypeName("ULONG")] uint cRequest)
        {
            return lpVtbl->Begin_Pull((AsyncIPipeByte*)Unsafe.AsPointer(ref this), cRequest);
        }

        [return: NativeTypeName("HRESULT")]
        public int Finish_Pull([NativeTypeName("BYTE *")] byte* buf, [NativeTypeName("ULONG *")] uint* pcReturned)
        {
            return lpVtbl->Finish_Pull((AsyncIPipeByte*)Unsafe.AsPointer(ref this), buf, pcReturned);
        }

        [return: NativeTypeName("HRESULT")]
        public int Begin_Push([NativeTypeName("BYTE *")] byte* buf, [NativeTypeName("ULONG")] uint cSent)
        {
            return lpVtbl->Begin_Push((AsyncIPipeByte*)Unsafe.AsPointer(ref this), buf, cSent);
        }

        [return: NativeTypeName("HRESULT")]
        public int Finish_Push()
        {
            return lpVtbl->Finish_Push((AsyncIPipeByte*)Unsafe.AsPointer(ref this));
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<AsyncIPipeByte*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<AsyncIPipeByte*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<AsyncIPipeByte*, uint> Release;

            [NativeTypeName("HRESULT (ULONG) __attribute__((stdcall))")]
            public delegate* stdcall<AsyncIPipeByte*, uint, int> Begin_Pull;

            [NativeTypeName("HRESULT (BYTE *, ULONG *) __attribute__((stdcall))")]
            public delegate* stdcall<AsyncIPipeByte*, byte*, uint*, int> Finish_Pull;

            [NativeTypeName("HRESULT (BYTE *, ULONG) __attribute__((stdcall))")]
            public delegate* stdcall<AsyncIPipeByte*, byte*, uint, int> Begin_Push;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* stdcall<AsyncIPipeByte*, int> Finish_Push;
        }
    }
}
