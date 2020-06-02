// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ObjIdlbase.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("000001CF-0000-0000-C000-000000000046")]
    public unsafe partial struct IMarshal2
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((IMarshal2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IMarshal2*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IMarshal2*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetUnmarshalClass([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void *")] void* pv, [NativeTypeName("DWORD")] uint dwDestContext, [NativeTypeName("void *")] void* pvDestContext, [NativeTypeName("DWORD")] uint mshlflags, [NativeTypeName("CLSID *")] Guid* pCid)
        {
            return lpVtbl->GetUnmarshalClass((IMarshal2*)Unsafe.AsPointer(ref this), riid, pv, dwDestContext, pvDestContext, mshlflags, pCid);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetMarshalSizeMax([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void *")] void* pv, [NativeTypeName("DWORD")] uint dwDestContext, [NativeTypeName("void *")] void* pvDestContext, [NativeTypeName("DWORD")] uint mshlflags, [NativeTypeName("DWORD *")] uint* pSize)
        {
            return lpVtbl->GetMarshalSizeMax((IMarshal2*)Unsafe.AsPointer(ref this), riid, pv, dwDestContext, pvDestContext, mshlflags, pSize);
        }

        [return: NativeTypeName("HRESULT")]
        public int MarshalInterface([NativeTypeName("IStream *")] IStream* pStm, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void *")] void* pv, [NativeTypeName("DWORD")] uint dwDestContext, [NativeTypeName("void *")] void* pvDestContext, [NativeTypeName("DWORD")] uint mshlflags)
        {
            return lpVtbl->MarshalInterface((IMarshal2*)Unsafe.AsPointer(ref this), pStm, riid, pv, dwDestContext, pvDestContext, mshlflags);
        }

        [return: NativeTypeName("HRESULT")]
        public int UnmarshalInterface([NativeTypeName("IStream *")] IStream* pStm, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppv)
        {
            return lpVtbl->UnmarshalInterface((IMarshal2*)Unsafe.AsPointer(ref this), pStm, riid, ppv);
        }

        [return: NativeTypeName("HRESULT")]
        public int ReleaseMarshalData([NativeTypeName("IStream *")] IStream* pStm)
        {
            return lpVtbl->ReleaseMarshalData((IMarshal2*)Unsafe.AsPointer(ref this), pStm);
        }

        [return: NativeTypeName("HRESULT")]
        public int DisconnectObject([NativeTypeName("DWORD")] uint dwReserved)
        {
            return lpVtbl->DisconnectObject((IMarshal2*)Unsafe.AsPointer(ref this), dwReserved);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<IMarshal2*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IMarshal2*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IMarshal2*, uint> Release;

            [NativeTypeName("HRESULT (const IID &, void *, DWORD, void *, DWORD, CLSID *) __attribute__((stdcall))")]
            public delegate* stdcall<IMarshal2*, Guid*, void*, uint, void*, uint, Guid*, int> GetUnmarshalClass;

            [NativeTypeName("HRESULT (const IID &, void *, DWORD, void *, DWORD, DWORD *) __attribute__((stdcall))")]
            public delegate* stdcall<IMarshal2*, Guid*, void*, uint, void*, uint, uint*, int> GetMarshalSizeMax;

            [NativeTypeName("HRESULT (IStream *, const IID &, void *, DWORD, void *, DWORD) __attribute__((stdcall))")]
            public delegate* stdcall<IMarshal2*, IStream*, Guid*, void*, uint, void*, uint, int> MarshalInterface;

            [NativeTypeName("HRESULT (IStream *, const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<IMarshal2*, IStream*, Guid*, void**, int> UnmarshalInterface;

            [NativeTypeName("HRESULT (IStream *) __attribute__((stdcall))")]
            public delegate* stdcall<IMarshal2*, IStream*, int> ReleaseMarshalData;

            [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
            public delegate* stdcall<IMarshal2*, uint, int> DisconnectObject;
        }
    }
}
