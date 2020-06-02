// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ObjIdlbase.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("00000144-0000-0000-C000-000000000046")]
    public unsafe partial struct IRpcOptions
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((IRpcOptions*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IRpcOptions*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IRpcOptions*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Set([NativeTypeName("IUnknown *")] IUnknown* pPrx, RPCOPT_PROPERTIES dwProperty, [NativeTypeName("ULONG_PTR")] nuint dwValue)
        {
            return lpVtbl->Set((IRpcOptions*)Unsafe.AsPointer(ref this), pPrx, dwProperty, dwValue);
        }

        [return: NativeTypeName("HRESULT")]
        public int Query([NativeTypeName("IUnknown *")] IUnknown* pPrx, RPCOPT_PROPERTIES dwProperty, [NativeTypeName("ULONG_PTR *")] nuint* pdwValue)
        {
            return lpVtbl->Query((IRpcOptions*)Unsafe.AsPointer(ref this), pPrx, dwProperty, pdwValue);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<IRpcOptions*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IRpcOptions*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IRpcOptions*, uint> Release;

            [NativeTypeName("HRESULT (IUnknown *, RPCOPT_PROPERTIES, ULONG_PTR) __attribute__((stdcall))")]
            public delegate* stdcall<IRpcOptions*, IUnknown*, RPCOPT_PROPERTIES, nuint, int> Set;

            [NativeTypeName("HRESULT (IUnknown *, RPCOPT_PROPERTIES, ULONG_PTR *) __attribute__((stdcall))")]
            public delegate* stdcall<IRpcOptions*, IUnknown*, RPCOPT_PROPERTIES, nuint*, int> Query;
        }
    }
}
