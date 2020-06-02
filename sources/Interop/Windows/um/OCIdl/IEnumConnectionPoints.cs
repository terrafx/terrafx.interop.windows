// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/OCIdl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("B196B285-BAB4-101A-B69C-00AA00341D07")]
    public unsafe partial struct IEnumConnectionPoints
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((IEnumConnectionPoints*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IEnumConnectionPoints*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IEnumConnectionPoints*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Next([NativeTypeName("ULONG")] uint cConnections, [NativeTypeName("LPCONNECTIONPOINT *")] IConnectionPoint** ppCP, [NativeTypeName("ULONG *")] uint* pcFetched)
        {
            return lpVtbl->Next((IEnumConnectionPoints*)Unsafe.AsPointer(ref this), cConnections, ppCP, pcFetched);
        }

        [return: NativeTypeName("HRESULT")]
        public int Skip([NativeTypeName("ULONG")] uint cConnections)
        {
            return lpVtbl->Skip((IEnumConnectionPoints*)Unsafe.AsPointer(ref this), cConnections);
        }

        [return: NativeTypeName("HRESULT")]
        public int Reset()
        {
            return lpVtbl->Reset((IEnumConnectionPoints*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Clone([NativeTypeName("IEnumConnectionPoints **")] IEnumConnectionPoints** ppEnum)
        {
            return lpVtbl->Clone((IEnumConnectionPoints*)Unsafe.AsPointer(ref this), ppEnum);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<IEnumConnectionPoints*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IEnumConnectionPoints*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IEnumConnectionPoints*, uint> Release;

            [NativeTypeName("HRESULT (ULONG, LPCONNECTIONPOINT *, ULONG *) __attribute__((stdcall))")]
            public delegate* stdcall<IEnumConnectionPoints*, uint, IConnectionPoint**, uint*, int> Next;

            [NativeTypeName("HRESULT (ULONG) __attribute__((stdcall))")]
            public delegate* stdcall<IEnumConnectionPoints*, uint, int> Skip;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* stdcall<IEnumConnectionPoints*, int> Reset;

            [NativeTypeName("HRESULT (IEnumConnectionPoints **) __attribute__((stdcall))")]
            public delegate* stdcall<IEnumConnectionPoints*, IEnumConnectionPoints**, int> Clone;
        }
    }
}
