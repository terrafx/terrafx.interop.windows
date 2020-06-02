// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ObjIdl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("0000010e-0000-0000-C000-000000000046")]
    public unsafe partial struct IDataObject
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((IDataObject*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IDataObject*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IDataObject*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetData([NativeTypeName("FORMATETC *")] FORMATETC* pformatetcIn, [NativeTypeName("STGMEDIUM *")] STGMEDIUM* pmedium)
        {
            return lpVtbl->GetData((IDataObject*)Unsafe.AsPointer(ref this), pformatetcIn, pmedium);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDataHere([NativeTypeName("FORMATETC *")] FORMATETC* pformatetc, [NativeTypeName("STGMEDIUM *")] STGMEDIUM* pmedium)
        {
            return lpVtbl->GetDataHere((IDataObject*)Unsafe.AsPointer(ref this), pformatetc, pmedium);
        }

        [return: NativeTypeName("HRESULT")]
        public int QueryGetData([NativeTypeName("FORMATETC *")] FORMATETC* pformatetc)
        {
            return lpVtbl->QueryGetData((IDataObject*)Unsafe.AsPointer(ref this), pformatetc);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetCanonicalFormatEtc([NativeTypeName("FORMATETC *")] FORMATETC* pformatectIn, [NativeTypeName("FORMATETC *")] FORMATETC* pformatetcOut)
        {
            return lpVtbl->GetCanonicalFormatEtc((IDataObject*)Unsafe.AsPointer(ref this), pformatectIn, pformatetcOut);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetData([NativeTypeName("FORMATETC *")] FORMATETC* pformatetc, [NativeTypeName("STGMEDIUM *")] STGMEDIUM* pmedium, [NativeTypeName("BOOL")] int fRelease)
        {
            return lpVtbl->SetData((IDataObject*)Unsafe.AsPointer(ref this), pformatetc, pmedium, fRelease);
        }

        [return: NativeTypeName("HRESULT")]
        public int EnumFormatEtc([NativeTypeName("DWORD")] uint dwDirection, [NativeTypeName("IEnumFORMATETC **")] IEnumFORMATETC** ppenumFormatEtc)
        {
            return lpVtbl->EnumFormatEtc((IDataObject*)Unsafe.AsPointer(ref this), dwDirection, ppenumFormatEtc);
        }

        [return: NativeTypeName("HRESULT")]
        public int DAdvise([NativeTypeName("FORMATETC *")] FORMATETC* pformatetc, [NativeTypeName("DWORD")] uint advf, [NativeTypeName("IAdviseSink *")] IAdviseSink* pAdvSink, [NativeTypeName("DWORD *")] uint* pdwConnection)
        {
            return lpVtbl->DAdvise((IDataObject*)Unsafe.AsPointer(ref this), pformatetc, advf, pAdvSink, pdwConnection);
        }

        [return: NativeTypeName("HRESULT")]
        public int DUnadvise([NativeTypeName("DWORD")] uint dwConnection)
        {
            return lpVtbl->DUnadvise((IDataObject*)Unsafe.AsPointer(ref this), dwConnection);
        }

        [return: NativeTypeName("HRESULT")]
        public int EnumDAdvise([NativeTypeName("IEnumSTATDATA **")] IEnumSTATDATA** ppenumAdvise)
        {
            return lpVtbl->EnumDAdvise((IDataObject*)Unsafe.AsPointer(ref this), ppenumAdvise);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<IDataObject*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IDataObject*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IDataObject*, uint> Release;

            [NativeTypeName("HRESULT (FORMATETC *, STGMEDIUM *) __attribute__((stdcall))")]
            public delegate* stdcall<IDataObject*, FORMATETC*, STGMEDIUM*, int> GetData;

            [NativeTypeName("HRESULT (FORMATETC *, STGMEDIUM *) __attribute__((stdcall))")]
            public delegate* stdcall<IDataObject*, FORMATETC*, STGMEDIUM*, int> GetDataHere;

            [NativeTypeName("HRESULT (FORMATETC *) __attribute__((stdcall))")]
            public delegate* stdcall<IDataObject*, FORMATETC*, int> QueryGetData;

            [NativeTypeName("HRESULT (FORMATETC *, FORMATETC *) __attribute__((stdcall))")]
            public delegate* stdcall<IDataObject*, FORMATETC*, FORMATETC*, int> GetCanonicalFormatEtc;

            [NativeTypeName("HRESULT (FORMATETC *, STGMEDIUM *, BOOL) __attribute__((stdcall))")]
            public delegate* stdcall<IDataObject*, FORMATETC*, STGMEDIUM*, int, int> SetData;

            [NativeTypeName("HRESULT (DWORD, IEnumFORMATETC **) __attribute__((stdcall))")]
            public delegate* stdcall<IDataObject*, uint, IEnumFORMATETC**, int> EnumFormatEtc;

            [NativeTypeName("HRESULT (FORMATETC *, DWORD, IAdviseSink *, DWORD *) __attribute__((stdcall))")]
            public delegate* stdcall<IDataObject*, FORMATETC*, uint, IAdviseSink*, uint*, int> DAdvise;

            [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
            public delegate* stdcall<IDataObject*, uint, int> DUnadvise;

            [NativeTypeName("HRESULT (IEnumSTATDATA **) __attribute__((stdcall))")]
            public delegate* stdcall<IDataObject*, IEnumSTATDATA**, int> EnumDAdvise;
        }
    }
}
