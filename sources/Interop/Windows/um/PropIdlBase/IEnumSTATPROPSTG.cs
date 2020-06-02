// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/PropIdlBase.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("00000139-0000-0000-C000-000000000046")]
    public unsafe partial struct IEnumSTATPROPSTG
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((IEnumSTATPROPSTG*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IEnumSTATPROPSTG*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IEnumSTATPROPSTG*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Next([NativeTypeName("ULONG")] uint celt, [NativeTypeName("STATPROPSTG *")] STATPROPSTG* rgelt, [NativeTypeName("ULONG *")] uint* pceltFetched)
        {
            return lpVtbl->Next((IEnumSTATPROPSTG*)Unsafe.AsPointer(ref this), celt, rgelt, pceltFetched);
        }

        [return: NativeTypeName("HRESULT")]
        public int Skip([NativeTypeName("ULONG")] uint celt)
        {
            return lpVtbl->Skip((IEnumSTATPROPSTG*)Unsafe.AsPointer(ref this), celt);
        }

        [return: NativeTypeName("HRESULT")]
        public int Reset()
        {
            return lpVtbl->Reset((IEnumSTATPROPSTG*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Clone([NativeTypeName("IEnumSTATPROPSTG **")] IEnumSTATPROPSTG** ppenum)
        {
            return lpVtbl->Clone((IEnumSTATPROPSTG*)Unsafe.AsPointer(ref this), ppenum);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<IEnumSTATPROPSTG*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IEnumSTATPROPSTG*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IEnumSTATPROPSTG*, uint> Release;

            [NativeTypeName("HRESULT (ULONG, STATPROPSTG *, ULONG *) __attribute__((stdcall))")]
            public delegate* stdcall<IEnumSTATPROPSTG*, uint, STATPROPSTG*, uint*, int> Next;

            [NativeTypeName("HRESULT (ULONG) __attribute__((stdcall))")]
            public delegate* stdcall<IEnumSTATPROPSTG*, uint, int> Skip;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* stdcall<IEnumSTATPROPSTG*, int> Reset;

            [NativeTypeName("HRESULT (IEnumSTATPROPSTG **) __attribute__((stdcall))")]
            public delegate* stdcall<IEnumSTATPROPSTG*, IEnumSTATPROPSTG**, int> Clone;
        }
    }
}
