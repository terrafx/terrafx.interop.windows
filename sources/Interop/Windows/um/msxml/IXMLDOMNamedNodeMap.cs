// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/msxml.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("2933BF83-7B36-11D2-B20E-00C04F983E60")]
    public unsafe partial struct IXMLDOMNamedNodeMap
    {
        public Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IXMLDOMNamedNodeMap* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IXMLDOMNamedNodeMap* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IXMLDOMNamedNodeMap* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetTypeInfoCount(IXMLDOMNamedNodeMap* pThis, [NativeTypeName("UINT *")] uint* pctinfo);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetTypeInfo(IXMLDOMNamedNodeMap* pThis, [NativeTypeName("UINT")] uint iTInfo, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("ITypeInfo **")] ITypeInfo** ppTInfo);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetIDsOfNames(IXMLDOMNamedNodeMap* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, [NativeTypeName("UINT")] uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Invoke(IXMLDOMNamedNodeMap* pThis, [NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, [NativeTypeName("DISPPARAMS *")] DISPPARAMS* pDispParams, [NativeTypeName("VARIANT *")] VARIANT* pVarResult, [NativeTypeName("EXCEPINFO *")] EXCEPINFO* pExcepInfo, [NativeTypeName("UINT *")] uint* puArgErr);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _getNamedItem(IXMLDOMNamedNodeMap* pThis, [NativeTypeName("BSTR")] ushort* name, [NativeTypeName("IXMLDOMNode **")] IXMLDOMNode** namedItem);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _setNamedItem(IXMLDOMNamedNodeMap* pThis, [NativeTypeName("IXMLDOMNode *")] IXMLDOMNode* newItem, [NativeTypeName("IXMLDOMNode **")] IXMLDOMNode** nameItem);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _removeNamedItem(IXMLDOMNamedNodeMap* pThis, [NativeTypeName("BSTR")] ushort* name, [NativeTypeName("IXMLDOMNode **")] IXMLDOMNode** namedItem);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _get_item(IXMLDOMNamedNodeMap* pThis, [NativeTypeName("long")] int index, [NativeTypeName("IXMLDOMNode **")] IXMLDOMNode** listItem);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _get_length(IXMLDOMNamedNodeMap* pThis, [NativeTypeName("long *")] int* listLength);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _getQualifiedItem(IXMLDOMNamedNodeMap* pThis, [NativeTypeName("BSTR")] ushort* baseName, [NativeTypeName("BSTR")] ushort* namespaceURI, [NativeTypeName("IXMLDOMNode **")] IXMLDOMNode** qualifiedItem);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _removeQualifiedItem(IXMLDOMNamedNodeMap* pThis, [NativeTypeName("BSTR")] ushort* baseName, [NativeTypeName("BSTR")] ushort* namespaceURI, [NativeTypeName("IXMLDOMNode **")] IXMLDOMNode** qualifiedItem);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _nextNode(IXMLDOMNamedNodeMap* pThis, [NativeTypeName("IXMLDOMNode **")] IXMLDOMNode** nextItem);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _reset(IXMLDOMNamedNodeMap* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _get__newEnum(IXMLDOMNamedNodeMap* pThis, [NativeTypeName("IUnknown **")] IUnknown** ppUnk);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((IXMLDOMNamedNodeMap*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((IXMLDOMNamedNodeMap*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((IXMLDOMNamedNodeMap*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfoCount([NativeTypeName("UINT *")] uint* pctinfo)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetTypeInfoCount>(lpVtbl->GetTypeInfoCount)((IXMLDOMNamedNodeMap*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfo([NativeTypeName("UINT")] uint iTInfo, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("ITypeInfo **")] ITypeInfo** ppTInfo)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetTypeInfo>(lpVtbl->GetTypeInfo)((IXMLDOMNamedNodeMap*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, [NativeTypeName("UINT")] uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetIDsOfNames>(lpVtbl->GetIDsOfNames)((IXMLDOMNamedNodeMap*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [return: NativeTypeName("HRESULT")]
        public int Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, [NativeTypeName("DISPPARAMS *")] DISPPARAMS* pDispParams, [NativeTypeName("VARIANT *")] VARIANT* pVarResult, [NativeTypeName("EXCEPINFO *")] EXCEPINFO* pExcepInfo, [NativeTypeName("UINT *")] uint* puArgErr)
        {
            return Marshal.GetDelegateForFunctionPointer<_Invoke>(lpVtbl->Invoke)((IXMLDOMNamedNodeMap*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [return: NativeTypeName("HRESULT")]
        public int getNamedItem([NativeTypeName("BSTR")] ushort* name, [NativeTypeName("IXMLDOMNode **")] IXMLDOMNode** namedItem)
        {
            return Marshal.GetDelegateForFunctionPointer<_getNamedItem>(lpVtbl->getNamedItem)((IXMLDOMNamedNodeMap*)Unsafe.AsPointer(ref this), name, namedItem);
        }

        [return: NativeTypeName("HRESULT")]
        public int setNamedItem([NativeTypeName("IXMLDOMNode *")] IXMLDOMNode* newItem, [NativeTypeName("IXMLDOMNode **")] IXMLDOMNode** nameItem)
        {
            return Marshal.GetDelegateForFunctionPointer<_setNamedItem>(lpVtbl->setNamedItem)((IXMLDOMNamedNodeMap*)Unsafe.AsPointer(ref this), newItem, nameItem);
        }

        [return: NativeTypeName("HRESULT")]
        public int removeNamedItem([NativeTypeName("BSTR")] ushort* name, [NativeTypeName("IXMLDOMNode **")] IXMLDOMNode** namedItem)
        {
            return Marshal.GetDelegateForFunctionPointer<_removeNamedItem>(lpVtbl->removeNamedItem)((IXMLDOMNamedNodeMap*)Unsafe.AsPointer(ref this), name, namedItem);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_item([NativeTypeName("long")] int index, [NativeTypeName("IXMLDOMNode **")] IXMLDOMNode** listItem)
        {
            return Marshal.GetDelegateForFunctionPointer<_get_item>(lpVtbl->get_item)((IXMLDOMNamedNodeMap*)Unsafe.AsPointer(ref this), index, listItem);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_length([NativeTypeName("long *")] int* listLength)
        {
            return Marshal.GetDelegateForFunctionPointer<_get_length>(lpVtbl->get_length)((IXMLDOMNamedNodeMap*)Unsafe.AsPointer(ref this), listLength);
        }

        [return: NativeTypeName("HRESULT")]
        public int getQualifiedItem([NativeTypeName("BSTR")] ushort* baseName, [NativeTypeName("BSTR")] ushort* namespaceURI, [NativeTypeName("IXMLDOMNode **")] IXMLDOMNode** qualifiedItem)
        {
            return Marshal.GetDelegateForFunctionPointer<_getQualifiedItem>(lpVtbl->getQualifiedItem)((IXMLDOMNamedNodeMap*)Unsafe.AsPointer(ref this), baseName, namespaceURI, qualifiedItem);
        }

        [return: NativeTypeName("HRESULT")]
        public int removeQualifiedItem([NativeTypeName("BSTR")] ushort* baseName, [NativeTypeName("BSTR")] ushort* namespaceURI, [NativeTypeName("IXMLDOMNode **")] IXMLDOMNode** qualifiedItem)
        {
            return Marshal.GetDelegateForFunctionPointer<_removeQualifiedItem>(lpVtbl->removeQualifiedItem)((IXMLDOMNamedNodeMap*)Unsafe.AsPointer(ref this), baseName, namespaceURI, qualifiedItem);
        }

        [return: NativeTypeName("HRESULT")]
        public int nextNode([NativeTypeName("IXMLDOMNode **")] IXMLDOMNode** nextItem)
        {
            return Marshal.GetDelegateForFunctionPointer<_nextNode>(lpVtbl->nextNode)((IXMLDOMNamedNodeMap*)Unsafe.AsPointer(ref this), nextItem);
        }

        [return: NativeTypeName("HRESULT")]
        public int reset()
        {
            return Marshal.GetDelegateForFunctionPointer<_reset>(lpVtbl->reset)((IXMLDOMNamedNodeMap*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int get__newEnum([NativeTypeName("IUnknown **")] IUnknown** ppUnk)
        {
            return Marshal.GetDelegateForFunctionPointer<_get__newEnum>(lpVtbl->get__newEnum)((IXMLDOMNamedNodeMap*)Unsafe.AsPointer(ref this), ppUnk);
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

            [NativeTypeName("HRESULT (BSTR, IXMLDOMNode **) __attribute__((stdcall))")]
            public IntPtr getNamedItem;

            [NativeTypeName("HRESULT (IXMLDOMNode *, IXMLDOMNode **) __attribute__((stdcall))")]
            public IntPtr setNamedItem;

            [NativeTypeName("HRESULT (BSTR, IXMLDOMNode **) __attribute__((stdcall))")]
            public IntPtr removeNamedItem;

            [NativeTypeName("HRESULT (long, IXMLDOMNode **) __attribute__((stdcall))")]
            public IntPtr get_item;

            [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
            public IntPtr get_length;

            [NativeTypeName("HRESULT (BSTR, BSTR, IXMLDOMNode **) __attribute__((stdcall))")]
            public IntPtr getQualifiedItem;

            [NativeTypeName("HRESULT (BSTR, BSTR, IXMLDOMNode **) __attribute__((stdcall))")]
            public IntPtr removeQualifiedItem;

            [NativeTypeName("HRESULT (IXMLDOMNode **) __attribute__((stdcall))")]
            public IntPtr nextNode;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public IntPtr reset;

            [NativeTypeName("HRESULT (IUnknown **) __attribute__((stdcall))")]
            public IntPtr get__newEnum;
        }
    }
}
