// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/oleidl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("00000104-0000-0000-C000-000000000046")]
    public unsafe partial struct IEnumOLEVERB
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((IEnumOLEVERB*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IEnumOLEVERB*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IEnumOLEVERB*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Next([NativeTypeName("ULONG")] uint celt, [NativeTypeName("LPOLEVERB")] OLEVERB* rgelt, [NativeTypeName("ULONG *")] uint* pceltFetched)
        {
            return lpVtbl->Next((IEnumOLEVERB*)Unsafe.AsPointer(ref this), celt, rgelt, pceltFetched);
        }

        [return: NativeTypeName("HRESULT")]
        public int Skip([NativeTypeName("ULONG")] uint celt)
        {
            return lpVtbl->Skip((IEnumOLEVERB*)Unsafe.AsPointer(ref this), celt);
        }

        [return: NativeTypeName("HRESULT")]
        public int Reset()
        {
            return lpVtbl->Reset((IEnumOLEVERB*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Clone([NativeTypeName("IEnumOLEVERB **")] IEnumOLEVERB** ppenum)
        {
            return lpVtbl->Clone((IEnumOLEVERB*)Unsafe.AsPointer(ref this), ppenum);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<IEnumOLEVERB*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IEnumOLEVERB*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IEnumOLEVERB*, uint> Release;

            [NativeTypeName("HRESULT (ULONG, LPOLEVERB, ULONG *) __attribute__((stdcall))")]
            public delegate* stdcall<IEnumOLEVERB*, uint, OLEVERB*, uint*, int> Next;

            [NativeTypeName("HRESULT (ULONG) __attribute__((stdcall))")]
            public delegate* stdcall<IEnumOLEVERB*, uint, int> Skip;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* stdcall<IEnumOLEVERB*, int> Reset;

            [NativeTypeName("HRESULT (IEnumOLEVERB **) __attribute__((stdcall))")]
            public delegate* stdcall<IEnumOLEVERB*, IEnumOLEVERB**, int> Clone;
        }
    }
}
