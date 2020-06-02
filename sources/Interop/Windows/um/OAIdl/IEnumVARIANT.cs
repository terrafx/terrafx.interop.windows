// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/OAIdl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("00020404-0000-0000-C000-000000000046")]
    public unsafe partial struct IEnumVARIANT
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((IEnumVARIANT*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IEnumVARIANT*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IEnumVARIANT*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Next([NativeTypeName("ULONG")] uint celt, [NativeTypeName("VARIANT *")] VARIANT* rgVar, [NativeTypeName("ULONG *")] uint* pCeltFetched)
        {
            return lpVtbl->Next((IEnumVARIANT*)Unsafe.AsPointer(ref this), celt, rgVar, pCeltFetched);
        }

        [return: NativeTypeName("HRESULT")]
        public int Skip([NativeTypeName("ULONG")] uint celt)
        {
            return lpVtbl->Skip((IEnumVARIANT*)Unsafe.AsPointer(ref this), celt);
        }

        [return: NativeTypeName("HRESULT")]
        public int Reset()
        {
            return lpVtbl->Reset((IEnumVARIANT*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Clone([NativeTypeName("IEnumVARIANT **")] IEnumVARIANT** ppEnum)
        {
            return lpVtbl->Clone((IEnumVARIANT*)Unsafe.AsPointer(ref this), ppEnum);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<IEnumVARIANT*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IEnumVARIANT*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IEnumVARIANT*, uint> Release;

            [NativeTypeName("HRESULT (ULONG, VARIANT *, ULONG *) __attribute__((stdcall))")]
            public delegate* stdcall<IEnumVARIANT*, uint, VARIANT*, uint*, int> Next;

            [NativeTypeName("HRESULT (ULONG) __attribute__((stdcall))")]
            public delegate* stdcall<IEnumVARIANT*, uint, int> Skip;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* stdcall<IEnumVARIANT*, int> Reset;

            [NativeTypeName("HRESULT (IEnumVARIANT **) __attribute__((stdcall))")]
            public delegate* stdcall<IEnumVARIANT*, IEnumVARIANT**, int> Clone;
        }
    }
}
