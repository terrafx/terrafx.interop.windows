// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ObjIdlbase.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("0000015B-0000-0000-C000-000000000046")]
    public unsafe partial struct IGlobalOptions
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((IGlobalOptions*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IGlobalOptions*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IGlobalOptions*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Set(GLOBALOPT_PROPERTIES dwProperty, [NativeTypeName("ULONG_PTR")] nuint dwValue)
        {
            return lpVtbl->Set((IGlobalOptions*)Unsafe.AsPointer(ref this), dwProperty, dwValue);
        }

        [return: NativeTypeName("HRESULT")]
        public int Query(GLOBALOPT_PROPERTIES dwProperty, [NativeTypeName("ULONG_PTR *")] nuint* pdwValue)
        {
            return lpVtbl->Query((IGlobalOptions*)Unsafe.AsPointer(ref this), dwProperty, pdwValue);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<IGlobalOptions*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IGlobalOptions*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IGlobalOptions*, uint> Release;

            [NativeTypeName("HRESULT (GLOBALOPT_PROPERTIES, ULONG_PTR) __attribute__((stdcall))")]
            public delegate* stdcall<IGlobalOptions*, GLOBALOPT_PROPERTIES, nuint, int> Set;

            [NativeTypeName("HRESULT (GLOBALOPT_PROPERTIES, ULONG_PTR *) __attribute__((stdcall))")]
            public delegate* stdcall<IGlobalOptions*, GLOBALOPT_PROPERTIES, nuint*, int> Query;
        }
    }
}
