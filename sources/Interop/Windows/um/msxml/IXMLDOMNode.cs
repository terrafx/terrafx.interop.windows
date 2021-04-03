// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/msxml.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("2933BF80-7B36-11D2-B20E-00C04F983E60")]
    [NativeTypeName("struct IXMLDOMNode : IDispatch")]
    public unsafe partial struct IXMLDOMNode
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IXMLDOMNode*, Guid*, void**, int>)(lpVtbl[0]))((IXMLDOMNode*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IXMLDOMNode*, uint>)(lpVtbl[1]))((IXMLDOMNode*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IXMLDOMNode*, uint>)(lpVtbl[2]))((IXMLDOMNode*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfoCount([NativeTypeName("UINT *")] uint* pctinfo)
        {
            return ((delegate* unmanaged<IXMLDOMNode*, uint*, int>)(lpVtbl[3]))((IXMLDOMNode*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfo([NativeTypeName("UINT")] uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<IXMLDOMNode*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IXMLDOMNode*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, [NativeTypeName("UINT")] uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<IXMLDOMNode*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IXMLDOMNode*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, [NativeTypeName("UINT *")] uint* puArgErr)
        {
            return ((delegate* unmanaged<IXMLDOMNode*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IXMLDOMNode*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_nodeName([NativeTypeName("BSTR *")] ushort** name)
        {
            return ((delegate* unmanaged<IXMLDOMNode*, ushort**, int>)(lpVtbl[7]))((IXMLDOMNode*)Unsafe.AsPointer(ref this), name);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_nodeValue(VARIANT* value)
        {
            return ((delegate* unmanaged<IXMLDOMNode*, VARIANT*, int>)(lpVtbl[8]))((IXMLDOMNode*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_nodeValue(VARIANT value)
        {
            return ((delegate* unmanaged<IXMLDOMNode*, VARIANT, int>)(lpVtbl[9]))((IXMLDOMNode*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_nodeType(DOMNodeType* type)
        {
            return ((delegate* unmanaged<IXMLDOMNode*, DOMNodeType*, int>)(lpVtbl[10]))((IXMLDOMNode*)Unsafe.AsPointer(ref this), type);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_parentNode(IXMLDOMNode** parent)
        {
            return ((delegate* unmanaged<IXMLDOMNode*, IXMLDOMNode**, int>)(lpVtbl[11]))((IXMLDOMNode*)Unsafe.AsPointer(ref this), parent);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_childNodes(IXMLDOMNodeList** childList)
        {
            return ((delegate* unmanaged<IXMLDOMNode*, IXMLDOMNodeList**, int>)(lpVtbl[12]))((IXMLDOMNode*)Unsafe.AsPointer(ref this), childList);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_firstChild(IXMLDOMNode** firstChild)
        {
            return ((delegate* unmanaged<IXMLDOMNode*, IXMLDOMNode**, int>)(lpVtbl[13]))((IXMLDOMNode*)Unsafe.AsPointer(ref this), firstChild);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_lastChild(IXMLDOMNode** lastChild)
        {
            return ((delegate* unmanaged<IXMLDOMNode*, IXMLDOMNode**, int>)(lpVtbl[14]))((IXMLDOMNode*)Unsafe.AsPointer(ref this), lastChild);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_previousSibling(IXMLDOMNode** previousSibling)
        {
            return ((delegate* unmanaged<IXMLDOMNode*, IXMLDOMNode**, int>)(lpVtbl[15]))((IXMLDOMNode*)Unsafe.AsPointer(ref this), previousSibling);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_nextSibling(IXMLDOMNode** nextSibling)
        {
            return ((delegate* unmanaged<IXMLDOMNode*, IXMLDOMNode**, int>)(lpVtbl[16]))((IXMLDOMNode*)Unsafe.AsPointer(ref this), nextSibling);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_attributes(IXMLDOMNamedNodeMap** attributeMap)
        {
            return ((delegate* unmanaged<IXMLDOMNode*, IXMLDOMNamedNodeMap**, int>)(lpVtbl[17]))((IXMLDOMNode*)Unsafe.AsPointer(ref this), attributeMap);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int insertBefore(IXMLDOMNode* newChild, VARIANT refChild, IXMLDOMNode** outNewChild)
        {
            return ((delegate* unmanaged<IXMLDOMNode*, IXMLDOMNode*, VARIANT, IXMLDOMNode**, int>)(lpVtbl[18]))((IXMLDOMNode*)Unsafe.AsPointer(ref this), newChild, refChild, outNewChild);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int replaceChild(IXMLDOMNode* newChild, IXMLDOMNode* oldChild, IXMLDOMNode** outOldChild)
        {
            return ((delegate* unmanaged<IXMLDOMNode*, IXMLDOMNode*, IXMLDOMNode*, IXMLDOMNode**, int>)(lpVtbl[19]))((IXMLDOMNode*)Unsafe.AsPointer(ref this), newChild, oldChild, outOldChild);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int removeChild(IXMLDOMNode* childNode, IXMLDOMNode** oldChild)
        {
            return ((delegate* unmanaged<IXMLDOMNode*, IXMLDOMNode*, IXMLDOMNode**, int>)(lpVtbl[20]))((IXMLDOMNode*)Unsafe.AsPointer(ref this), childNode, oldChild);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int appendChild(IXMLDOMNode* newChild, IXMLDOMNode** outNewChild)
        {
            return ((delegate* unmanaged<IXMLDOMNode*, IXMLDOMNode*, IXMLDOMNode**, int>)(lpVtbl[21]))((IXMLDOMNode*)Unsafe.AsPointer(ref this), newChild, outNewChild);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int hasChildNodes([NativeTypeName("VARIANT_BOOL *")] short* hasChild)
        {
            return ((delegate* unmanaged<IXMLDOMNode*, short*, int>)(lpVtbl[22]))((IXMLDOMNode*)Unsafe.AsPointer(ref this), hasChild);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_ownerDocument(IXMLDOMDocument** XMLDOMDocument)
        {
            return ((delegate* unmanaged<IXMLDOMNode*, IXMLDOMDocument**, int>)(lpVtbl[23]))((IXMLDOMNode*)Unsafe.AsPointer(ref this), XMLDOMDocument);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int cloneNode([NativeTypeName("VARIANT_BOOL")] short deep, IXMLDOMNode** cloneRoot)
        {
            return ((delegate* unmanaged<IXMLDOMNode*, short, IXMLDOMNode**, int>)(lpVtbl[24]))((IXMLDOMNode*)Unsafe.AsPointer(ref this), deep, cloneRoot);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_nodeTypeString([NativeTypeName("BSTR *")] ushort** nodeType)
        {
            return ((delegate* unmanaged<IXMLDOMNode*, ushort**, int>)(lpVtbl[25]))((IXMLDOMNode*)Unsafe.AsPointer(ref this), nodeType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_text([NativeTypeName("BSTR *")] ushort** text)
        {
            return ((delegate* unmanaged<IXMLDOMNode*, ushort**, int>)(lpVtbl[26]))((IXMLDOMNode*)Unsafe.AsPointer(ref this), text);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_text([NativeTypeName("BSTR")] ushort* text)
        {
            return ((delegate* unmanaged<IXMLDOMNode*, ushort*, int>)(lpVtbl[27]))((IXMLDOMNode*)Unsafe.AsPointer(ref this), text);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_specified([NativeTypeName("VARIANT_BOOL *")] short* isSpecified)
        {
            return ((delegate* unmanaged<IXMLDOMNode*, short*, int>)(lpVtbl[28]))((IXMLDOMNode*)Unsafe.AsPointer(ref this), isSpecified);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_definition(IXMLDOMNode** definitionNode)
        {
            return ((delegate* unmanaged<IXMLDOMNode*, IXMLDOMNode**, int>)(lpVtbl[29]))((IXMLDOMNode*)Unsafe.AsPointer(ref this), definitionNode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_nodeTypedValue(VARIANT* typedValue)
        {
            return ((delegate* unmanaged<IXMLDOMNode*, VARIANT*, int>)(lpVtbl[30]))((IXMLDOMNode*)Unsafe.AsPointer(ref this), typedValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_nodeTypedValue(VARIANT typedValue)
        {
            return ((delegate* unmanaged<IXMLDOMNode*, VARIANT, int>)(lpVtbl[31]))((IXMLDOMNode*)Unsafe.AsPointer(ref this), typedValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_dataType(VARIANT* dataTypeName)
        {
            return ((delegate* unmanaged<IXMLDOMNode*, VARIANT*, int>)(lpVtbl[32]))((IXMLDOMNode*)Unsafe.AsPointer(ref this), dataTypeName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_dataType([NativeTypeName("BSTR")] ushort* dataTypeName)
        {
            return ((delegate* unmanaged<IXMLDOMNode*, ushort*, int>)(lpVtbl[33]))((IXMLDOMNode*)Unsafe.AsPointer(ref this), dataTypeName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_xml([NativeTypeName("BSTR *")] ushort** xmlString)
        {
            return ((delegate* unmanaged<IXMLDOMNode*, ushort**, int>)(lpVtbl[34]))((IXMLDOMNode*)Unsafe.AsPointer(ref this), xmlString);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int transformNode(IXMLDOMNode* stylesheet, [NativeTypeName("BSTR *")] ushort** xmlString)
        {
            return ((delegate* unmanaged<IXMLDOMNode*, IXMLDOMNode*, ushort**, int>)(lpVtbl[35]))((IXMLDOMNode*)Unsafe.AsPointer(ref this), stylesheet, xmlString);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int selectNodes([NativeTypeName("BSTR")] ushort* queryString, IXMLDOMNodeList** resultList)
        {
            return ((delegate* unmanaged<IXMLDOMNode*, ushort*, IXMLDOMNodeList**, int>)(lpVtbl[36]))((IXMLDOMNode*)Unsafe.AsPointer(ref this), queryString, resultList);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int selectSingleNode([NativeTypeName("BSTR")] ushort* queryString, IXMLDOMNode** resultNode)
        {
            return ((delegate* unmanaged<IXMLDOMNode*, ushort*, IXMLDOMNode**, int>)(lpVtbl[37]))((IXMLDOMNode*)Unsafe.AsPointer(ref this), queryString, resultNode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_parsed([NativeTypeName("VARIANT_BOOL *")] short* isParsed)
        {
            return ((delegate* unmanaged<IXMLDOMNode*, short*, int>)(lpVtbl[38]))((IXMLDOMNode*)Unsafe.AsPointer(ref this), isParsed);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_namespaceURI([NativeTypeName("BSTR *")] ushort** namespaceURI)
        {
            return ((delegate* unmanaged<IXMLDOMNode*, ushort**, int>)(lpVtbl[39]))((IXMLDOMNode*)Unsafe.AsPointer(ref this), namespaceURI);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_prefix([NativeTypeName("BSTR *")] ushort** prefixString)
        {
            return ((delegate* unmanaged<IXMLDOMNode*, ushort**, int>)(lpVtbl[40]))((IXMLDOMNode*)Unsafe.AsPointer(ref this), prefixString);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_baseName([NativeTypeName("BSTR *")] ushort** nameString)
        {
            return ((delegate* unmanaged<IXMLDOMNode*, ushort**, int>)(lpVtbl[41]))((IXMLDOMNode*)Unsafe.AsPointer(ref this), nameString);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int transformNodeToObject(IXMLDOMNode* stylesheet, VARIANT outputObject)
        {
            return ((delegate* unmanaged<IXMLDOMNode*, IXMLDOMNode*, VARIANT, int>)(lpVtbl[42]))((IXMLDOMNode*)Unsafe.AsPointer(ref this), stylesheet, outputObject);
        }
    }
}
