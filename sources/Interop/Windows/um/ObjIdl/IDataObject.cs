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

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IDataObject* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IDataObject* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IDataObject* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetData(IDataObject* pThis, [NativeTypeName("FORMATETC *")] FORMATETC* pformatetcIn, [NativeTypeName("STGMEDIUM *")] STGMEDIUM* pmedium);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetDataHere(IDataObject* pThis, [NativeTypeName("FORMATETC *")] FORMATETC* pformatetc, [NativeTypeName("STGMEDIUM *")] STGMEDIUM* pmedium);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryGetData(IDataObject* pThis, [NativeTypeName("FORMATETC *")] FORMATETC* pformatetc);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetCanonicalFormatEtc(IDataObject* pThis, [NativeTypeName("FORMATETC *")] FORMATETC* pformatectIn, [NativeTypeName("FORMATETC *")] FORMATETC* pformatetcOut);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetData(IDataObject* pThis, [NativeTypeName("FORMATETC *")] FORMATETC* pformatetc, [NativeTypeName("STGMEDIUM *")] STGMEDIUM* pmedium, [NativeTypeName("BOOL")] int fRelease);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _EnumFormatEtc(IDataObject* pThis, [NativeTypeName("DWORD")] uint dwDirection, [NativeTypeName("IEnumFORMATETC **")] IEnumFORMATETC** ppenumFormatEtc);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _DAdvise(IDataObject* pThis, [NativeTypeName("FORMATETC *")] FORMATETC* pformatetc, [NativeTypeName("DWORD")] uint advf, [NativeTypeName("IAdviseSink *")] IAdviseSink* pAdvSink, [NativeTypeName("DWORD *")] uint* pdwConnection);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _DUnadvise(IDataObject* pThis, [NativeTypeName("DWORD")] uint dwConnection);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _EnumDAdvise(IDataObject* pThis, [NativeTypeName("IEnumSTATDATA **")] IEnumSTATDATA** ppenumAdvise);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((IDataObject*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((IDataObject*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((IDataObject*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetData([NativeTypeName("FORMATETC *")] FORMATETC* pformatetcIn, [NativeTypeName("STGMEDIUM *")] STGMEDIUM* pmedium)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetData>(lpVtbl->GetData)((IDataObject*)Unsafe.AsPointer(ref this), pformatetcIn, pmedium);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDataHere([NativeTypeName("FORMATETC *")] FORMATETC* pformatetc, [NativeTypeName("STGMEDIUM *")] STGMEDIUM* pmedium)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetDataHere>(lpVtbl->GetDataHere)((IDataObject*)Unsafe.AsPointer(ref this), pformatetc, pmedium);
        }

        [return: NativeTypeName("HRESULT")]
        public int QueryGetData([NativeTypeName("FORMATETC *")] FORMATETC* pformatetc)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryGetData>(lpVtbl->QueryGetData)((IDataObject*)Unsafe.AsPointer(ref this), pformatetc);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetCanonicalFormatEtc([NativeTypeName("FORMATETC *")] FORMATETC* pformatectIn, [NativeTypeName("FORMATETC *")] FORMATETC* pformatetcOut)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetCanonicalFormatEtc>(lpVtbl->GetCanonicalFormatEtc)((IDataObject*)Unsafe.AsPointer(ref this), pformatectIn, pformatetcOut);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetData([NativeTypeName("FORMATETC *")] FORMATETC* pformatetc, [NativeTypeName("STGMEDIUM *")] STGMEDIUM* pmedium, [NativeTypeName("BOOL")] int fRelease)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetData>(lpVtbl->SetData)((IDataObject*)Unsafe.AsPointer(ref this), pformatetc, pmedium, fRelease);
        }

        [return: NativeTypeName("HRESULT")]
        public int EnumFormatEtc([NativeTypeName("DWORD")] uint dwDirection, [NativeTypeName("IEnumFORMATETC **")] IEnumFORMATETC** ppenumFormatEtc)
        {
            return Marshal.GetDelegateForFunctionPointer<_EnumFormatEtc>(lpVtbl->EnumFormatEtc)((IDataObject*)Unsafe.AsPointer(ref this), dwDirection, ppenumFormatEtc);
        }

        [return: NativeTypeName("HRESULT")]
        public int DAdvise([NativeTypeName("FORMATETC *")] FORMATETC* pformatetc, [NativeTypeName("DWORD")] uint advf, [NativeTypeName("IAdviseSink *")] IAdviseSink* pAdvSink, [NativeTypeName("DWORD *")] uint* pdwConnection)
        {
            return Marshal.GetDelegateForFunctionPointer<_DAdvise>(lpVtbl->DAdvise)((IDataObject*)Unsafe.AsPointer(ref this), pformatetc, advf, pAdvSink, pdwConnection);
        }

        [return: NativeTypeName("HRESULT")]
        public int DUnadvise([NativeTypeName("DWORD")] uint dwConnection)
        {
            return Marshal.GetDelegateForFunctionPointer<_DUnadvise>(lpVtbl->DUnadvise)((IDataObject*)Unsafe.AsPointer(ref this), dwConnection);
        }

        [return: NativeTypeName("HRESULT")]
        public int EnumDAdvise([NativeTypeName("IEnumSTATDATA **")] IEnumSTATDATA** ppenumAdvise)
        {
            return Marshal.GetDelegateForFunctionPointer<_EnumDAdvise>(lpVtbl->EnumDAdvise)((IDataObject*)Unsafe.AsPointer(ref this), ppenumAdvise);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Release;

            [NativeTypeName("HRESULT (FORMATETC *, STGMEDIUM *) __attribute__((stdcall))")]
            public IntPtr GetData;

            [NativeTypeName("HRESULT (FORMATETC *, STGMEDIUM *) __attribute__((stdcall))")]
            public IntPtr GetDataHere;

            [NativeTypeName("HRESULT (FORMATETC *) __attribute__((stdcall))")]
            public IntPtr QueryGetData;

            [NativeTypeName("HRESULT (FORMATETC *, FORMATETC *) __attribute__((stdcall))")]
            public IntPtr GetCanonicalFormatEtc;

            [NativeTypeName("HRESULT (FORMATETC *, STGMEDIUM *, BOOL) __attribute__((stdcall))")]
            public IntPtr SetData;

            [NativeTypeName("HRESULT (DWORD, IEnumFORMATETC **) __attribute__((stdcall))")]
            public IntPtr EnumFormatEtc;

            [NativeTypeName("HRESULT (FORMATETC *, DWORD, IAdviseSink *, DWORD *) __attribute__((stdcall))")]
            public IntPtr DAdvise;

            [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
            public IntPtr DUnadvise;

            [NativeTypeName("HRESULT (IEnumSTATDATA **) __attribute__((stdcall))")]
            public IntPtr EnumDAdvise;
        }
    }
}
