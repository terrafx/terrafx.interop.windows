// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/msxml.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("3EFAA425-272F-11D2-836F-0000F87A7782")]
    [NativeTypeName("struct IXTLRuntime : IXMLDOMNode")]
    public unsafe partial struct IXTLRuntime
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IXTLRuntime*, Guid*, void**, int>)(lpVtbl[0]))((IXTLRuntime*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IXTLRuntime*, uint>)(lpVtbl[1]))((IXTLRuntime*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IXTLRuntime*, uint>)(lpVtbl[2]))((IXTLRuntime*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfoCount([NativeTypeName("UINT *")] uint* pctinfo)
        {
            return ((delegate* unmanaged<IXTLRuntime*, uint*, int>)(lpVtbl[3]))((IXTLRuntime*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfo([NativeTypeName("UINT")] uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<IXTLRuntime*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IXTLRuntime*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, [NativeTypeName("UINT")] uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<IXTLRuntime*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IXTLRuntime*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, [NativeTypeName("UINT *")] uint* puArgErr)
        {
            return ((delegate* unmanaged<IXTLRuntime*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IXTLRuntime*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_nodeName([NativeTypeName("BSTR *")] ushort** name)
        {
            return ((delegate* unmanaged<IXTLRuntime*, ushort**, int>)(lpVtbl[7]))((IXTLRuntime*)Unsafe.AsPointer(ref this), name);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_nodeValue(VARIANT* value)
        {
            return ((delegate* unmanaged<IXTLRuntime*, VARIANT*, int>)(lpVtbl[8]))((IXTLRuntime*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_nodeValue(VARIANT value)
        {
            return ((delegate* unmanaged<IXTLRuntime*, VARIANT, int>)(lpVtbl[9]))((IXTLRuntime*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_nodeType(DOMNodeType* type)
        {
            return ((delegate* unmanaged<IXTLRuntime*, DOMNodeType*, int>)(lpVtbl[10]))((IXTLRuntime*)Unsafe.AsPointer(ref this), type);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_parentNode(IXMLDOMNode** parent)
        {
            return ((delegate* unmanaged<IXTLRuntime*, IXMLDOMNode**, int>)(lpVtbl[11]))((IXTLRuntime*)Unsafe.AsPointer(ref this), parent);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_childNodes(IXMLDOMNodeList** childList)
        {
            return ((delegate* unmanaged<IXTLRuntime*, IXMLDOMNodeList**, int>)(lpVtbl[12]))((IXTLRuntime*)Unsafe.AsPointer(ref this), childList);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_firstChild(IXMLDOMNode** firstChild)
        {
            return ((delegate* unmanaged<IXTLRuntime*, IXMLDOMNode**, int>)(lpVtbl[13]))((IXTLRuntime*)Unsafe.AsPointer(ref this), firstChild);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_lastChild(IXMLDOMNode** lastChild)
        {
            return ((delegate* unmanaged<IXTLRuntime*, IXMLDOMNode**, int>)(lpVtbl[14]))((IXTLRuntime*)Unsafe.AsPointer(ref this), lastChild);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_previousSibling(IXMLDOMNode** previousSibling)
        {
            return ((delegate* unmanaged<IXTLRuntime*, IXMLDOMNode**, int>)(lpVtbl[15]))((IXTLRuntime*)Unsafe.AsPointer(ref this), previousSibling);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_nextSibling(IXMLDOMNode** nextSibling)
        {
            return ((delegate* unmanaged<IXTLRuntime*, IXMLDOMNode**, int>)(lpVtbl[16]))((IXTLRuntime*)Unsafe.AsPointer(ref this), nextSibling);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_attributes(IXMLDOMNamedNodeMap** attributeMap)
        {
            return ((delegate* unmanaged<IXTLRuntime*, IXMLDOMNamedNodeMap**, int>)(lpVtbl[17]))((IXTLRuntime*)Unsafe.AsPointer(ref this), attributeMap);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int insertBefore(IXMLDOMNode* newChild, VARIANT refChild, IXMLDOMNode** outNewChild)
        {
            return ((delegate* unmanaged<IXTLRuntime*, IXMLDOMNode*, VARIANT, IXMLDOMNode**, int>)(lpVtbl[18]))((IXTLRuntime*)Unsafe.AsPointer(ref this), newChild, refChild, outNewChild);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int replaceChild(IXMLDOMNode* newChild, IXMLDOMNode* oldChild, IXMLDOMNode** outOldChild)
        {
            return ((delegate* unmanaged<IXTLRuntime*, IXMLDOMNode*, IXMLDOMNode*, IXMLDOMNode**, int>)(lpVtbl[19]))((IXTLRuntime*)Unsafe.AsPointer(ref this), newChild, oldChild, outOldChild);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int removeChild(IXMLDOMNode* childNode, IXMLDOMNode** oldChild)
        {
            return ((delegate* unmanaged<IXTLRuntime*, IXMLDOMNode*, IXMLDOMNode**, int>)(lpVtbl[20]))((IXTLRuntime*)Unsafe.AsPointer(ref this), childNode, oldChild);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int appendChild(IXMLDOMNode* newChild, IXMLDOMNode** outNewChild)
        {
            return ((delegate* unmanaged<IXTLRuntime*, IXMLDOMNode*, IXMLDOMNode**, int>)(lpVtbl[21]))((IXTLRuntime*)Unsafe.AsPointer(ref this), newChild, outNewChild);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int hasChildNodes([NativeTypeName("VARIANT_BOOL *")] short* hasChild)
        {
            return ((delegate* unmanaged<IXTLRuntime*, short*, int>)(lpVtbl[22]))((IXTLRuntime*)Unsafe.AsPointer(ref this), hasChild);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_ownerDocument(IXMLDOMDocument** XMLDOMDocument)
        {
            return ((delegate* unmanaged<IXTLRuntime*, IXMLDOMDocument**, int>)(lpVtbl[23]))((IXTLRuntime*)Unsafe.AsPointer(ref this), XMLDOMDocument);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int cloneNode([NativeTypeName("VARIANT_BOOL")] short deep, IXMLDOMNode** cloneRoot)
        {
            return ((delegate* unmanaged<IXTLRuntime*, short, IXMLDOMNode**, int>)(lpVtbl[24]))((IXTLRuntime*)Unsafe.AsPointer(ref this), deep, cloneRoot);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_nodeTypeString([NativeTypeName("BSTR *")] ushort** nodeType)
        {
            return ((delegate* unmanaged<IXTLRuntime*, ushort**, int>)(lpVtbl[25]))((IXTLRuntime*)Unsafe.AsPointer(ref this), nodeType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_text([NativeTypeName("BSTR *")] ushort** text)
        {
            return ((delegate* unmanaged<IXTLRuntime*, ushort**, int>)(lpVtbl[26]))((IXTLRuntime*)Unsafe.AsPointer(ref this), text);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_text([NativeTypeName("BSTR")] ushort* text)
        {
            return ((delegate* unmanaged<IXTLRuntime*, ushort*, int>)(lpVtbl[27]))((IXTLRuntime*)Unsafe.AsPointer(ref this), text);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_specified([NativeTypeName("VARIANT_BOOL *")] short* isSpecified)
        {
            return ((delegate* unmanaged<IXTLRuntime*, short*, int>)(lpVtbl[28]))((IXTLRuntime*)Unsafe.AsPointer(ref this), isSpecified);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_definition(IXMLDOMNode** definitionNode)
        {
            return ((delegate* unmanaged<IXTLRuntime*, IXMLDOMNode**, int>)(lpVtbl[29]))((IXTLRuntime*)Unsafe.AsPointer(ref this), definitionNode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_nodeTypedValue(VARIANT* typedValue)
        {
            return ((delegate* unmanaged<IXTLRuntime*, VARIANT*, int>)(lpVtbl[30]))((IXTLRuntime*)Unsafe.AsPointer(ref this), typedValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_nodeTypedValue(VARIANT typedValue)
        {
            return ((delegate* unmanaged<IXTLRuntime*, VARIANT, int>)(lpVtbl[31]))((IXTLRuntime*)Unsafe.AsPointer(ref this), typedValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_dataType(VARIANT* dataTypeName)
        {
            return ((delegate* unmanaged<IXTLRuntime*, VARIANT*, int>)(lpVtbl[32]))((IXTLRuntime*)Unsafe.AsPointer(ref this), dataTypeName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_dataType([NativeTypeName("BSTR")] ushort* dataTypeName)
        {
            return ((delegate* unmanaged<IXTLRuntime*, ushort*, int>)(lpVtbl[33]))((IXTLRuntime*)Unsafe.AsPointer(ref this), dataTypeName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_xml([NativeTypeName("BSTR *")] ushort** xmlString)
        {
            return ((delegate* unmanaged<IXTLRuntime*, ushort**, int>)(lpVtbl[34]))((IXTLRuntime*)Unsafe.AsPointer(ref this), xmlString);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int transformNode(IXMLDOMNode* stylesheet, [NativeTypeName("BSTR *")] ushort** xmlString)
        {
            return ((delegate* unmanaged<IXTLRuntime*, IXMLDOMNode*, ushort**, int>)(lpVtbl[35]))((IXTLRuntime*)Unsafe.AsPointer(ref this), stylesheet, xmlString);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int selectNodes([NativeTypeName("BSTR")] ushort* queryString, IXMLDOMNodeList** resultList)
        {
            return ((delegate* unmanaged<IXTLRuntime*, ushort*, IXMLDOMNodeList**, int>)(lpVtbl[36]))((IXTLRuntime*)Unsafe.AsPointer(ref this), queryString, resultList);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int selectSingleNode([NativeTypeName("BSTR")] ushort* queryString, IXMLDOMNode** resultNode)
        {
            return ((delegate* unmanaged<IXTLRuntime*, ushort*, IXMLDOMNode**, int>)(lpVtbl[37]))((IXTLRuntime*)Unsafe.AsPointer(ref this), queryString, resultNode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_parsed([NativeTypeName("VARIANT_BOOL *")] short* isParsed)
        {
            return ((delegate* unmanaged<IXTLRuntime*, short*, int>)(lpVtbl[38]))((IXTLRuntime*)Unsafe.AsPointer(ref this), isParsed);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_namespaceURI([NativeTypeName("BSTR *")] ushort** namespaceURI)
        {
            return ((delegate* unmanaged<IXTLRuntime*, ushort**, int>)(lpVtbl[39]))((IXTLRuntime*)Unsafe.AsPointer(ref this), namespaceURI);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_prefix([NativeTypeName("BSTR *")] ushort** prefixString)
        {
            return ((delegate* unmanaged<IXTLRuntime*, ushort**, int>)(lpVtbl[40]))((IXTLRuntime*)Unsafe.AsPointer(ref this), prefixString);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_baseName([NativeTypeName("BSTR *")] ushort** nameString)
        {
            return ((delegate* unmanaged<IXTLRuntime*, ushort**, int>)(lpVtbl[41]))((IXTLRuntime*)Unsafe.AsPointer(ref this), nameString);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int transformNodeToObject(IXMLDOMNode* stylesheet, VARIANT outputObject)
        {
            return ((delegate* unmanaged<IXTLRuntime*, IXMLDOMNode*, VARIANT, int>)(lpVtbl[42]))((IXTLRuntime*)Unsafe.AsPointer(ref this), stylesheet, outputObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int uniqueID(IXMLDOMNode* pNode, [NativeTypeName("long *")] int* pID)
        {
            return ((delegate* unmanaged<IXTLRuntime*, IXMLDOMNode*, int*, int>)(lpVtbl[43]))((IXTLRuntime*)Unsafe.AsPointer(ref this), pNode, pID);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int depth(IXMLDOMNode* pNode, [NativeTypeName("long *")] int* pDepth)
        {
            return ((delegate* unmanaged<IXTLRuntime*, IXMLDOMNode*, int*, int>)(lpVtbl[44]))((IXTLRuntime*)Unsafe.AsPointer(ref this), pNode, pDepth);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int childNumber(IXMLDOMNode* pNode, [NativeTypeName("long *")] int* pNumber)
        {
            return ((delegate* unmanaged<IXTLRuntime*, IXMLDOMNode*, int*, int>)(lpVtbl[45]))((IXTLRuntime*)Unsafe.AsPointer(ref this), pNode, pNumber);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ancestorChildNumber([NativeTypeName("BSTR")] ushort* bstrNodeName, IXMLDOMNode* pNode, [NativeTypeName("long *")] int* pNumber)
        {
            return ((delegate* unmanaged<IXTLRuntime*, ushort*, IXMLDOMNode*, int*, int>)(lpVtbl[46]))((IXTLRuntime*)Unsafe.AsPointer(ref this), bstrNodeName, pNode, pNumber);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int absoluteChildNumber(IXMLDOMNode* pNode, [NativeTypeName("long *")] int* pNumber)
        {
            return ((delegate* unmanaged<IXTLRuntime*, IXMLDOMNode*, int*, int>)(lpVtbl[47]))((IXTLRuntime*)Unsafe.AsPointer(ref this), pNode, pNumber);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int formatIndex([NativeTypeName("long")] int lIndex, [NativeTypeName("BSTR")] ushort* bstrFormat, [NativeTypeName("BSTR *")] ushort** pbstrFormattedString)
        {
            return ((delegate* unmanaged<IXTLRuntime*, int, ushort*, ushort**, int>)(lpVtbl[48]))((IXTLRuntime*)Unsafe.AsPointer(ref this), lIndex, bstrFormat, pbstrFormattedString);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int formatNumber(double dblNumber, [NativeTypeName("BSTR")] ushort* bstrFormat, [NativeTypeName("BSTR *")] ushort** pbstrFormattedString)
        {
            return ((delegate* unmanaged<IXTLRuntime*, double, ushort*, ushort**, int>)(lpVtbl[49]))((IXTLRuntime*)Unsafe.AsPointer(ref this), dblNumber, bstrFormat, pbstrFormattedString);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int formatDate(VARIANT varDate, [NativeTypeName("BSTR")] ushort* bstrFormat, VARIANT varDestLocale, [NativeTypeName("BSTR *")] ushort** pbstrFormattedString)
        {
            return ((delegate* unmanaged<IXTLRuntime*, VARIANT, ushort*, VARIANT, ushort**, int>)(lpVtbl[50]))((IXTLRuntime*)Unsafe.AsPointer(ref this), varDate, bstrFormat, varDestLocale, pbstrFormattedString);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int formatTime(VARIANT varTime, [NativeTypeName("BSTR")] ushort* bstrFormat, VARIANT varDestLocale, [NativeTypeName("BSTR *")] ushort** pbstrFormattedString)
        {
            return ((delegate* unmanaged<IXTLRuntime*, VARIANT, ushort*, VARIANT, ushort**, int>)(lpVtbl[51]))((IXTLRuntime*)Unsafe.AsPointer(ref this), varTime, bstrFormat, varDestLocale, pbstrFormattedString);
        }
    }
}
