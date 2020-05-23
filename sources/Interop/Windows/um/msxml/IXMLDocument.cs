// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/msxml.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("F52E2B61-18A1-11D1-B105-00805F49916B")]
    public unsafe partial struct IXMLDocument
    {
        public Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IXMLDocument* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IXMLDocument* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IXMLDocument* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetTypeInfoCount(IXMLDocument* pThis, [NativeTypeName("UINT *")] uint* pctinfo);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetTypeInfo(IXMLDocument* pThis, [NativeTypeName("UINT")] uint iTInfo, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("ITypeInfo **")] ITypeInfo** ppTInfo);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetIDsOfNames(IXMLDocument* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, [NativeTypeName("UINT")] uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Invoke(IXMLDocument* pThis, [NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, [NativeTypeName("DISPPARAMS *")] DISPPARAMS* pDispParams, [NativeTypeName("VARIANT *")] VARIANT* pVarResult, [NativeTypeName("EXCEPINFO *")] EXCEPINFO* pExcepInfo, [NativeTypeName("UINT *")] uint* puArgErr);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _get_root(IXMLDocument* pThis, [NativeTypeName("IXMLElement **")] IXMLElement** p);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _get_fileSize(IXMLDocument* pThis, [NativeTypeName("BSTR *")] ushort** p);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _get_fileModifiedDate(IXMLDocument* pThis, [NativeTypeName("BSTR *")] ushort** p);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _get_fileUpdatedDate(IXMLDocument* pThis, [NativeTypeName("BSTR *")] ushort** p);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _get_URL(IXMLDocument* pThis, [NativeTypeName("BSTR *")] ushort** p);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _put_URL(IXMLDocument* pThis, [NativeTypeName("BSTR")] ushort* p);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _get_mimeType(IXMLDocument* pThis, [NativeTypeName("BSTR *")] ushort** p);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _get_readyState(IXMLDocument* pThis, [NativeTypeName("long *")] int* pl);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _get_charset(IXMLDocument* pThis, [NativeTypeName("BSTR *")] ushort** p);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _put_charset(IXMLDocument* pThis, [NativeTypeName("BSTR")] ushort* p);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _get_version(IXMLDocument* pThis, [NativeTypeName("BSTR *")] ushort** p);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _get_doctype(IXMLDocument* pThis, [NativeTypeName("BSTR *")] ushort** p);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _get_dtdURL(IXMLDocument* pThis, [NativeTypeName("BSTR *")] ushort** p);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _createElement(IXMLDocument* pThis, VARIANT vType, VARIANT var1, [NativeTypeName("IXMLElement **")] IXMLElement** ppElem);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((IXMLDocument*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((IXMLDocument*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((IXMLDocument*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfoCount([NativeTypeName("UINT *")] uint* pctinfo)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetTypeInfoCount>(lpVtbl->GetTypeInfoCount)((IXMLDocument*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfo([NativeTypeName("UINT")] uint iTInfo, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("ITypeInfo **")] ITypeInfo** ppTInfo)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetTypeInfo>(lpVtbl->GetTypeInfo)((IXMLDocument*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, [NativeTypeName("UINT")] uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetIDsOfNames>(lpVtbl->GetIDsOfNames)((IXMLDocument*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [return: NativeTypeName("HRESULT")]
        public int Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, [NativeTypeName("DISPPARAMS *")] DISPPARAMS* pDispParams, [NativeTypeName("VARIANT *")] VARIANT* pVarResult, [NativeTypeName("EXCEPINFO *")] EXCEPINFO* pExcepInfo, [NativeTypeName("UINT *")] uint* puArgErr)
        {
            return Marshal.GetDelegateForFunctionPointer<_Invoke>(lpVtbl->Invoke)((IXMLDocument*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_root([NativeTypeName("IXMLElement **")] IXMLElement** p)
        {
            return Marshal.GetDelegateForFunctionPointer<_get_root>(lpVtbl->get_root)((IXMLDocument*)Unsafe.AsPointer(ref this), p);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_fileSize([NativeTypeName("BSTR *")] ushort** p)
        {
            return Marshal.GetDelegateForFunctionPointer<_get_fileSize>(lpVtbl->get_fileSize)((IXMLDocument*)Unsafe.AsPointer(ref this), p);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_fileModifiedDate([NativeTypeName("BSTR *")] ushort** p)
        {
            return Marshal.GetDelegateForFunctionPointer<_get_fileModifiedDate>(lpVtbl->get_fileModifiedDate)((IXMLDocument*)Unsafe.AsPointer(ref this), p);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_fileUpdatedDate([NativeTypeName("BSTR *")] ushort** p)
        {
            return Marshal.GetDelegateForFunctionPointer<_get_fileUpdatedDate>(lpVtbl->get_fileUpdatedDate)((IXMLDocument*)Unsafe.AsPointer(ref this), p);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_URL([NativeTypeName("BSTR *")] ushort** p)
        {
            return Marshal.GetDelegateForFunctionPointer<_get_URL>(lpVtbl->get_URL)((IXMLDocument*)Unsafe.AsPointer(ref this), p);
        }

        [return: NativeTypeName("HRESULT")]
        public int put_URL([NativeTypeName("BSTR")] ushort* p)
        {
            return Marshal.GetDelegateForFunctionPointer<_put_URL>(lpVtbl->put_URL)((IXMLDocument*)Unsafe.AsPointer(ref this), p);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_mimeType([NativeTypeName("BSTR *")] ushort** p)
        {
            return Marshal.GetDelegateForFunctionPointer<_get_mimeType>(lpVtbl->get_mimeType)((IXMLDocument*)Unsafe.AsPointer(ref this), p);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_readyState([NativeTypeName("long *")] int* pl)
        {
            return Marshal.GetDelegateForFunctionPointer<_get_readyState>(lpVtbl->get_readyState)((IXMLDocument*)Unsafe.AsPointer(ref this), pl);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_charset([NativeTypeName("BSTR *")] ushort** p)
        {
            return Marshal.GetDelegateForFunctionPointer<_get_charset>(lpVtbl->get_charset)((IXMLDocument*)Unsafe.AsPointer(ref this), p);
        }

        [return: NativeTypeName("HRESULT")]
        public int put_charset([NativeTypeName("BSTR")] ushort* p)
        {
            return Marshal.GetDelegateForFunctionPointer<_put_charset>(lpVtbl->put_charset)((IXMLDocument*)Unsafe.AsPointer(ref this), p);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_version([NativeTypeName("BSTR *")] ushort** p)
        {
            return Marshal.GetDelegateForFunctionPointer<_get_version>(lpVtbl->get_version)((IXMLDocument*)Unsafe.AsPointer(ref this), p);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_doctype([NativeTypeName("BSTR *")] ushort** p)
        {
            return Marshal.GetDelegateForFunctionPointer<_get_doctype>(lpVtbl->get_doctype)((IXMLDocument*)Unsafe.AsPointer(ref this), p);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_dtdURL([NativeTypeName("BSTR *")] ushort** p)
        {
            return Marshal.GetDelegateForFunctionPointer<_get_dtdURL>(lpVtbl->get_dtdURL)((IXMLDocument*)Unsafe.AsPointer(ref this), p);
        }

        [return: NativeTypeName("HRESULT")]
        public int createElement(VARIANT vType, VARIANT var1, [NativeTypeName("IXMLElement **")] IXMLElement** ppElem)
        {
            return Marshal.GetDelegateForFunctionPointer<_createElement>(lpVtbl->createElement)((IXMLDocument*)Unsafe.AsPointer(ref this), vType, var1, ppElem);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Release;

            [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
            public IntPtr GetTypeInfoCount;

            [NativeTypeName("HRESULT (UINT, LCID, ITypeInfo **) __attribute__((stdcall))")]
            public IntPtr GetTypeInfo;

            [NativeTypeName("HRESULT (const IID &, LPOLESTR *, UINT, LCID, DISPID *) __attribute__((stdcall))")]
            public IntPtr GetIDsOfNames;

            [NativeTypeName("HRESULT (DISPID, const IID &, LCID, WORD, DISPPARAMS *, VARIANT *, EXCEPINFO *, UINT *) __attribute__((stdcall))")]
            public IntPtr Invoke;

            [NativeTypeName("HRESULT (IXMLElement **) __attribute__((stdcall))")]
            public IntPtr get_root;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public IntPtr get_fileSize;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public IntPtr get_fileModifiedDate;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public IntPtr get_fileUpdatedDate;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public IntPtr get_URL;

            [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
            public IntPtr put_URL;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public IntPtr get_mimeType;

            [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
            public IntPtr get_readyState;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public IntPtr get_charset;

            [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
            public IntPtr put_charset;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public IntPtr get_version;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public IntPtr get_doctype;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public IntPtr get_dtdURL;

            [NativeTypeName("HRESULT (VARIANT, VARIANT, IXMLElement **) __attribute__((stdcall))")]
            public IntPtr createElement;
        }
    }
}
