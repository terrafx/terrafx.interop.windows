// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ObjIdlbase.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("DB2F3ACE-2F86-11D1-8E04-00C04FB9989A")]
    public unsafe partial struct IPipeDouble
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((IPipeDouble*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IPipeDouble*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IPipeDouble*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Pull([NativeTypeName("DOUBLE *")] double* buf, [NativeTypeName("ULONG")] uint cRequest, [NativeTypeName("ULONG *")] uint* pcReturned)
        {
            return lpVtbl->Pull((IPipeDouble*)Unsafe.AsPointer(ref this), buf, cRequest, pcReturned);
        }

        [return: NativeTypeName("HRESULT")]
        public int Push([NativeTypeName("DOUBLE *")] double* buf, [NativeTypeName("ULONG")] uint cSent)
        {
            return lpVtbl->Push((IPipeDouble*)Unsafe.AsPointer(ref this), buf, cSent);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<IPipeDouble*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IPipeDouble*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IPipeDouble*, uint> Release;

            [NativeTypeName("HRESULT (DOUBLE *, ULONG, ULONG *) __attribute__((stdcall))")]
            public delegate* stdcall<IPipeDouble*, double*, uint, uint*, int> Pull;

            [NativeTypeName("HRESULT (DOUBLE *, ULONG) __attribute__((stdcall))")]
            public delegate* stdcall<IPipeDouble*, double*, uint, int> Push;
        }
    }
}
