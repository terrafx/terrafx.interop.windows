// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/oleidl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("00000128-0000-0000-C000-000000000046")]
    public unsafe partial struct IOleCache2
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((IOleCache2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IOleCache2*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IOleCache2*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Cache([NativeTypeName("FORMATETC *")] FORMATETC* pformatetc, [NativeTypeName("DWORD")] uint advf, [NativeTypeName("DWORD *")] uint* pdwConnection)
        {
            return lpVtbl->Cache((IOleCache2*)Unsafe.AsPointer(ref this), pformatetc, advf, pdwConnection);
        }

        [return: NativeTypeName("HRESULT")]
        public int Uncache([NativeTypeName("DWORD")] uint dwConnection)
        {
            return lpVtbl->Uncache((IOleCache2*)Unsafe.AsPointer(ref this), dwConnection);
        }

        [return: NativeTypeName("HRESULT")]
        public int EnumCache([NativeTypeName("IEnumSTATDATA **")] IEnumSTATDATA** ppenumSTATDATA)
        {
            return lpVtbl->EnumCache((IOleCache2*)Unsafe.AsPointer(ref this), ppenumSTATDATA);
        }

        [return: NativeTypeName("HRESULT")]
        public int InitCache([NativeTypeName("IDataObject *")] IDataObject* pDataObject)
        {
            return lpVtbl->InitCache((IOleCache2*)Unsafe.AsPointer(ref this), pDataObject);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetData([NativeTypeName("FORMATETC *")] FORMATETC* pformatetc, [NativeTypeName("STGMEDIUM *")] STGMEDIUM* pmedium, [NativeTypeName("BOOL")] int fRelease)
        {
            return lpVtbl->SetData((IOleCache2*)Unsafe.AsPointer(ref this), pformatetc, pmedium, fRelease);
        }

        [return: NativeTypeName("HRESULT")]
        public int UpdateCache([NativeTypeName("LPDATAOBJECT")] IDataObject* pDataObject, [NativeTypeName("DWORD")] uint grfUpdf, [NativeTypeName("LPVOID")] void* pReserved)
        {
            return lpVtbl->UpdateCache((IOleCache2*)Unsafe.AsPointer(ref this), pDataObject, grfUpdf, pReserved);
        }

        [return: NativeTypeName("HRESULT")]
        public int DiscardCache([NativeTypeName("DWORD")] uint dwDiscardOptions)
        {
            return lpVtbl->DiscardCache((IOleCache2*)Unsafe.AsPointer(ref this), dwDiscardOptions);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<IOleCache2*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IOleCache2*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IOleCache2*, uint> Release;

            [NativeTypeName("HRESULT (FORMATETC *, DWORD, DWORD *) __attribute__((stdcall))")]
            public delegate* stdcall<IOleCache2*, FORMATETC*, uint, uint*, int> Cache;

            [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
            public delegate* stdcall<IOleCache2*, uint, int> Uncache;

            [NativeTypeName("HRESULT (IEnumSTATDATA **) __attribute__((stdcall))")]
            public delegate* stdcall<IOleCache2*, IEnumSTATDATA**, int> EnumCache;

            [NativeTypeName("HRESULT (IDataObject *) __attribute__((stdcall))")]
            public delegate* stdcall<IOleCache2*, IDataObject*, int> InitCache;

            [NativeTypeName("HRESULT (FORMATETC *, STGMEDIUM *, BOOL) __attribute__((stdcall))")]
            public delegate* stdcall<IOleCache2*, FORMATETC*, STGMEDIUM*, int, int> SetData;

            [NativeTypeName("HRESULT (LPDATAOBJECT, DWORD, LPVOID) __attribute__((stdcall))")]
            public delegate* stdcall<IOleCache2*, IDataObject*, uint, void*, int> UpdateCache;

            [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
            public delegate* stdcall<IOleCache2*, uint, int> DiscardCache;
        }
    }
}
