// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/OCIdl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("B3E7C340-EF97-11CE-9BC9-00AA00608E01")]
    public unsafe partial struct IEnumOleUndoUnits
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((IEnumOleUndoUnits*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IEnumOleUndoUnits*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IEnumOleUndoUnits*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Next([NativeTypeName("ULONG")] uint cElt, [NativeTypeName("IOleUndoUnit **")] IOleUndoUnit** rgElt, [NativeTypeName("ULONG *")] uint* pcEltFetched)
        {
            return lpVtbl->Next((IEnumOleUndoUnits*)Unsafe.AsPointer(ref this), cElt, rgElt, pcEltFetched);
        }

        [return: NativeTypeName("HRESULT")]
        public int Skip([NativeTypeName("ULONG")] uint cElt)
        {
            return lpVtbl->Skip((IEnumOleUndoUnits*)Unsafe.AsPointer(ref this), cElt);
        }

        [return: NativeTypeName("HRESULT")]
        public int Reset()
        {
            return lpVtbl->Reset((IEnumOleUndoUnits*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Clone([NativeTypeName("IEnumOleUndoUnits **")] IEnumOleUndoUnits** ppEnum)
        {
            return lpVtbl->Clone((IEnumOleUndoUnits*)Unsafe.AsPointer(ref this), ppEnum);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<IEnumOleUndoUnits*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IEnumOleUndoUnits*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IEnumOleUndoUnits*, uint> Release;

            [NativeTypeName("HRESULT (ULONG, IOleUndoUnit **, ULONG *) __attribute__((stdcall))")]
            public delegate* stdcall<IEnumOleUndoUnits*, uint, IOleUndoUnit**, uint*, int> Next;

            [NativeTypeName("HRESULT (ULONG) __attribute__((stdcall))")]
            public delegate* stdcall<IEnumOleUndoUnits*, uint, int> Skip;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* stdcall<IEnumOleUndoUnits*, int> Reset;

            [NativeTypeName("HRESULT (IEnumOleUndoUnits **) __attribute__((stdcall))")]
            public delegate* stdcall<IEnumOleUndoUnits*, IEnumOleUndoUnits**, int> Clone;
        }
    }
}
