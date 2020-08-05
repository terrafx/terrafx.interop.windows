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

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IXTLRuntime*, Guid*, void**, int>)(lpVtbl[0]))((IXTLRuntime*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IXTLRuntime*, uint>)(lpVtbl[1]))((IXTLRuntime*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IXTLRuntime*, uint>)(lpVtbl[2]))((IXTLRuntime*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfoCount([NativeTypeName("UINT *")] uint* pctinfo)
        {
            return ((delegate* stdcall<IXTLRuntime*, uint*, int>)(lpVtbl[3]))((IXTLRuntime*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfo([NativeTypeName("UINT")] uint iTInfo, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("ITypeInfo **")] ITypeInfo** ppTInfo)
        {
            return ((delegate* stdcall<IXTLRuntime*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IXTLRuntime*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, [NativeTypeName("UINT")] uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* stdcall<IXTLRuntime*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IXTLRuntime*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [return: NativeTypeName("HRESULT")]
        public int Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, [NativeTypeName("DISPPARAMS *")] DISPPARAMS* pDispParams, [NativeTypeName("VARIANT *")] VARIANT* pVarResult, [NativeTypeName("EXCEPINFO *")] EXCEPINFO* pExcepInfo, [NativeTypeName("UINT *")] uint* puArgErr)
        {
            return ((delegate* stdcall<IXTLRuntime*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IXTLRuntime*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_nodeName([NativeTypeName("BSTR *")] ushort** name)
        {
            return ((delegate* stdcall<IXTLRuntime*, ushort**, int>)(lpVtbl[7]))((IXTLRuntime*)Unsafe.AsPointer(ref this), name);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_nodeValue([NativeTypeName("VARIANT *")] VARIANT* value)
        {
            return ((delegate* stdcall<IXTLRuntime*, VARIANT*, int>)(lpVtbl[8]))((IXTLRuntime*)Unsafe.AsPointer(ref this), value);
        }

        [return: NativeTypeName("HRESULT")]
        public int put_nodeValue(VARIANT value)
        {
            return ((delegate* stdcall<IXTLRuntime*, VARIANT, int>)(lpVtbl[9]))((IXTLRuntime*)Unsafe.AsPointer(ref this), value);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_nodeType([NativeTypeName("DOMNodeType *")] DOMNodeType* type)
        {
            return ((delegate* stdcall<IXTLRuntime*, DOMNodeType*, int>)(lpVtbl[10]))((IXTLRuntime*)Unsafe.AsPointer(ref this), type);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_parentNode([NativeTypeName("IXMLDOMNode **")] IXMLDOMNode** parent)
        {
            return ((delegate* stdcall<IXTLRuntime*, IXMLDOMNode**, int>)(lpVtbl[11]))((IXTLRuntime*)Unsafe.AsPointer(ref this), parent);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_childNodes([NativeTypeName("IXMLDOMNodeList **")] IXMLDOMNodeList** childList)
        {
            return ((delegate* stdcall<IXTLRuntime*, IXMLDOMNodeList**, int>)(lpVtbl[12]))((IXTLRuntime*)Unsafe.AsPointer(ref this), childList);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_firstChild([NativeTypeName("IXMLDOMNode **")] IXMLDOMNode** firstChild)
        {
            return ((delegate* stdcall<IXTLRuntime*, IXMLDOMNode**, int>)(lpVtbl[13]))((IXTLRuntime*)Unsafe.AsPointer(ref this), firstChild);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_lastChild([NativeTypeName("IXMLDOMNode **")] IXMLDOMNode** lastChild)
        {
            return ((delegate* stdcall<IXTLRuntime*, IXMLDOMNode**, int>)(lpVtbl[14]))((IXTLRuntime*)Unsafe.AsPointer(ref this), lastChild);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_previousSibling([NativeTypeName("IXMLDOMNode **")] IXMLDOMNode** previousSibling)
        {
            return ((delegate* stdcall<IXTLRuntime*, IXMLDOMNode**, int>)(lpVtbl[15]))((IXTLRuntime*)Unsafe.AsPointer(ref this), previousSibling);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_nextSibling([NativeTypeName("IXMLDOMNode **")] IXMLDOMNode** nextSibling)
        {
            return ((delegate* stdcall<IXTLRuntime*, IXMLDOMNode**, int>)(lpVtbl[16]))((IXTLRuntime*)Unsafe.AsPointer(ref this), nextSibling);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_attributes([NativeTypeName("IXMLDOMNamedNodeMap **")] IXMLDOMNamedNodeMap** attributeMap)
        {
            return ((delegate* stdcall<IXTLRuntime*, IXMLDOMNamedNodeMap**, int>)(lpVtbl[17]))((IXTLRuntime*)Unsafe.AsPointer(ref this), attributeMap);
        }

        [return: NativeTypeName("HRESULT")]
        public int insertBefore([NativeTypeName("IXMLDOMNode *")] IXMLDOMNode* newChild, VARIANT refChild, [NativeTypeName("IXMLDOMNode **")] IXMLDOMNode** outNewChild)
        {
            return ((delegate* stdcall<IXTLRuntime*, IXMLDOMNode*, VARIANT, IXMLDOMNode**, int>)(lpVtbl[18]))((IXTLRuntime*)Unsafe.AsPointer(ref this), newChild, refChild, outNewChild);
        }

        [return: NativeTypeName("HRESULT")]
        public int replaceChild([NativeTypeName("IXMLDOMNode *")] IXMLDOMNode* newChild, [NativeTypeName("IXMLDOMNode *")] IXMLDOMNode* oldChild, [NativeTypeName("IXMLDOMNode **")] IXMLDOMNode** outOldChild)
        {
            return ((delegate* stdcall<IXTLRuntime*, IXMLDOMNode*, IXMLDOMNode*, IXMLDOMNode**, int>)(lpVtbl[19]))((IXTLRuntime*)Unsafe.AsPointer(ref this), newChild, oldChild, outOldChild);
        }

        [return: NativeTypeName("HRESULT")]
        public int removeChild([NativeTypeName("IXMLDOMNode *")] IXMLDOMNode* childNode, [NativeTypeName("IXMLDOMNode **")] IXMLDOMNode** oldChild)
        {
            return ((delegate* stdcall<IXTLRuntime*, IXMLDOMNode*, IXMLDOMNode**, int>)(lpVtbl[20]))((IXTLRuntime*)Unsafe.AsPointer(ref this), childNode, oldChild);
        }

        [return: NativeTypeName("HRESULT")]
        public int appendChild([NativeTypeName("IXMLDOMNode *")] IXMLDOMNode* newChild, [NativeTypeName("IXMLDOMNode **")] IXMLDOMNode** outNewChild)
        {
            return ((delegate* stdcall<IXTLRuntime*, IXMLDOMNode*, IXMLDOMNode**, int>)(lpVtbl[21]))((IXTLRuntime*)Unsafe.AsPointer(ref this), newChild, outNewChild);
        }

        [return: NativeTypeName("HRESULT")]
        public int hasChildNodes([NativeTypeName("VARIANT_BOOL *")] short* hasChild)
        {
            return ((delegate* stdcall<IXTLRuntime*, short*, int>)(lpVtbl[22]))((IXTLRuntime*)Unsafe.AsPointer(ref this), hasChild);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_ownerDocument([NativeTypeName("IXMLDOMDocument **")] IXMLDOMDocument** XMLDOMDocument)
        {
            return ((delegate* stdcall<IXTLRuntime*, IXMLDOMDocument**, int>)(lpVtbl[23]))((IXTLRuntime*)Unsafe.AsPointer(ref this), XMLDOMDocument);
        }

        [return: NativeTypeName("HRESULT")]
        public int cloneNode([NativeTypeName("VARIANT_BOOL")] short deep, [NativeTypeName("IXMLDOMNode **")] IXMLDOMNode** cloneRoot)
        {
            return ((delegate* stdcall<IXTLRuntime*, short, IXMLDOMNode**, int>)(lpVtbl[24]))((IXTLRuntime*)Unsafe.AsPointer(ref this), deep, cloneRoot);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_nodeTypeString([NativeTypeName("BSTR *")] ushort** nodeType)
        {
            return ((delegate* stdcall<IXTLRuntime*, ushort**, int>)(lpVtbl[25]))((IXTLRuntime*)Unsafe.AsPointer(ref this), nodeType);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_text([NativeTypeName("BSTR *")] ushort** text)
        {
            return ((delegate* stdcall<IXTLRuntime*, ushort**, int>)(lpVtbl[26]))((IXTLRuntime*)Unsafe.AsPointer(ref this), text);
        }

        [return: NativeTypeName("HRESULT")]
        public int put_text([NativeTypeName("BSTR")] ushort* text)
        {
            return ((delegate* stdcall<IXTLRuntime*, ushort*, int>)(lpVtbl[27]))((IXTLRuntime*)Unsafe.AsPointer(ref this), text);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_specified([NativeTypeName("VARIANT_BOOL *")] short* isSpecified)
        {
            return ((delegate* stdcall<IXTLRuntime*, short*, int>)(lpVtbl[28]))((IXTLRuntime*)Unsafe.AsPointer(ref this), isSpecified);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_definition([NativeTypeName("IXMLDOMNode **")] IXMLDOMNode** definitionNode)
        {
            return ((delegate* stdcall<IXTLRuntime*, IXMLDOMNode**, int>)(lpVtbl[29]))((IXTLRuntime*)Unsafe.AsPointer(ref this), definitionNode);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_nodeTypedValue([NativeTypeName("VARIANT *")] VARIANT* typedValue)
        {
            return ((delegate* stdcall<IXTLRuntime*, VARIANT*, int>)(lpVtbl[30]))((IXTLRuntime*)Unsafe.AsPointer(ref this), typedValue);
        }

        [return: NativeTypeName("HRESULT")]
        public int put_nodeTypedValue(VARIANT typedValue)
        {
            return ((delegate* stdcall<IXTLRuntime*, VARIANT, int>)(lpVtbl[31]))((IXTLRuntime*)Unsafe.AsPointer(ref this), typedValue);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_dataType([NativeTypeName("VARIANT *")] VARIANT* dataTypeName)
        {
            return ((delegate* stdcall<IXTLRuntime*, VARIANT*, int>)(lpVtbl[32]))((IXTLRuntime*)Unsafe.AsPointer(ref this), dataTypeName);
        }

        [return: NativeTypeName("HRESULT")]
        public int put_dataType([NativeTypeName("BSTR")] ushort* dataTypeName)
        {
            return ((delegate* stdcall<IXTLRuntime*, ushort*, int>)(lpVtbl[33]))((IXTLRuntime*)Unsafe.AsPointer(ref this), dataTypeName);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_xml([NativeTypeName("BSTR *")] ushort** xmlString)
        {
            return ((delegate* stdcall<IXTLRuntime*, ushort**, int>)(lpVtbl[34]))((IXTLRuntime*)Unsafe.AsPointer(ref this), xmlString);
        }

        [return: NativeTypeName("HRESULT")]
        public int transformNode([NativeTypeName("IXMLDOMNode *")] IXMLDOMNode* stylesheet, [NativeTypeName("BSTR *")] ushort** xmlString)
        {
            return ((delegate* stdcall<IXTLRuntime*, IXMLDOMNode*, ushort**, int>)(lpVtbl[35]))((IXTLRuntime*)Unsafe.AsPointer(ref this), stylesheet, xmlString);
        }

        [return: NativeTypeName("HRESULT")]
        public int selectNodes([NativeTypeName("BSTR")] ushort* queryString, [NativeTypeName("IXMLDOMNodeList **")] IXMLDOMNodeList** resultList)
        {
            return ((delegate* stdcall<IXTLRuntime*, ushort*, IXMLDOMNodeList**, int>)(lpVtbl[36]))((IXTLRuntime*)Unsafe.AsPointer(ref this), queryString, resultList);
        }

        [return: NativeTypeName("HRESULT")]
        public int selectSingleNode([NativeTypeName("BSTR")] ushort* queryString, [NativeTypeName("IXMLDOMNode **")] IXMLDOMNode** resultNode)
        {
            return ((delegate* stdcall<IXTLRuntime*, ushort*, IXMLDOMNode**, int>)(lpVtbl[37]))((IXTLRuntime*)Unsafe.AsPointer(ref this), queryString, resultNode);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_parsed([NativeTypeName("VARIANT_BOOL *")] short* isParsed)
        {
            return ((delegate* stdcall<IXTLRuntime*, short*, int>)(lpVtbl[38]))((IXTLRuntime*)Unsafe.AsPointer(ref this), isParsed);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_namespaceURI([NativeTypeName("BSTR *")] ushort** namespaceURI)
        {
            return ((delegate* stdcall<IXTLRuntime*, ushort**, int>)(lpVtbl[39]))((IXTLRuntime*)Unsafe.AsPointer(ref this), namespaceURI);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_prefix([NativeTypeName("BSTR *")] ushort** prefixString)
        {
            return ((delegate* stdcall<IXTLRuntime*, ushort**, int>)(lpVtbl[40]))((IXTLRuntime*)Unsafe.AsPointer(ref this), prefixString);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_baseName([NativeTypeName("BSTR *")] ushort** nameString)
        {
            return ((delegate* stdcall<IXTLRuntime*, ushort**, int>)(lpVtbl[41]))((IXTLRuntime*)Unsafe.AsPointer(ref this), nameString);
        }

        [return: NativeTypeName("HRESULT")]
        public int transformNodeToObject([NativeTypeName("IXMLDOMNode *")] IXMLDOMNode* stylesheet, VARIANT outputObject)
        {
            return ((delegate* stdcall<IXTLRuntime*, IXMLDOMNode*, VARIANT, int>)(lpVtbl[42]))((IXTLRuntime*)Unsafe.AsPointer(ref this), stylesheet, outputObject);
        }

        [return: NativeTypeName("HRESULT")]
        public int uniqueID([NativeTypeName("IXMLDOMNode *")] IXMLDOMNode* pNode, [NativeTypeName("long *")] int* pID)
        {
            return ((delegate* stdcall<IXTLRuntime*, IXMLDOMNode*, int*, int>)(lpVtbl[43]))((IXTLRuntime*)Unsafe.AsPointer(ref this), pNode, pID);
        }

        [return: NativeTypeName("HRESULT")]
        public int depth([NativeTypeName("IXMLDOMNode *")] IXMLDOMNode* pNode, [NativeTypeName("long *")] int* pDepth)
        {
            return ((delegate* stdcall<IXTLRuntime*, IXMLDOMNode*, int*, int>)(lpVtbl[44]))((IXTLRuntime*)Unsafe.AsPointer(ref this), pNode, pDepth);
        }

        [return: NativeTypeName("HRESULT")]
        public int childNumber([NativeTypeName("IXMLDOMNode *")] IXMLDOMNode* pNode, [NativeTypeName("long *")] int* pNumber)
        {
            return ((delegate* stdcall<IXTLRuntime*, IXMLDOMNode*, int*, int>)(lpVtbl[45]))((IXTLRuntime*)Unsafe.AsPointer(ref this), pNode, pNumber);
        }

        [return: NativeTypeName("HRESULT")]
        public int ancestorChildNumber([NativeTypeName("BSTR")] ushort* bstrNodeName, [NativeTypeName("IXMLDOMNode *")] IXMLDOMNode* pNode, [NativeTypeName("long *")] int* pNumber)
        {
            return ((delegate* stdcall<IXTLRuntime*, ushort*, IXMLDOMNode*, int*, int>)(lpVtbl[46]))((IXTLRuntime*)Unsafe.AsPointer(ref this), bstrNodeName, pNode, pNumber);
        }

        [return: NativeTypeName("HRESULT")]
        public int absoluteChildNumber([NativeTypeName("IXMLDOMNode *")] IXMLDOMNode* pNode, [NativeTypeName("long *")] int* pNumber)
        {
            return ((delegate* stdcall<IXTLRuntime*, IXMLDOMNode*, int*, int>)(lpVtbl[47]))((IXTLRuntime*)Unsafe.AsPointer(ref this), pNode, pNumber);
        }

        [return: NativeTypeName("HRESULT")]
        public int formatIndex([NativeTypeName("long")] int lIndex, [NativeTypeName("BSTR")] ushort* bstrFormat, [NativeTypeName("BSTR *")] ushort** pbstrFormattedString)
        {
            return ((delegate* stdcall<IXTLRuntime*, int, ushort*, ushort**, int>)(lpVtbl[48]))((IXTLRuntime*)Unsafe.AsPointer(ref this), lIndex, bstrFormat, pbstrFormattedString);
        }

        [return: NativeTypeName("HRESULT")]
        public int formatNumber(double dblNumber, [NativeTypeName("BSTR")] ushort* bstrFormat, [NativeTypeName("BSTR *")] ushort** pbstrFormattedString)
        {
            return ((delegate* stdcall<IXTLRuntime*, double, ushort*, ushort**, int>)(lpVtbl[49]))((IXTLRuntime*)Unsafe.AsPointer(ref this), dblNumber, bstrFormat, pbstrFormattedString);
        }

        [return: NativeTypeName("HRESULT")]
        public int formatDate(VARIANT varDate, [NativeTypeName("BSTR")] ushort* bstrFormat, VARIANT varDestLocale, [NativeTypeName("BSTR *")] ushort** pbstrFormattedString)
        {
            return ((delegate* stdcall<IXTLRuntime*, VARIANT, ushort*, VARIANT, ushort**, int>)(lpVtbl[50]))((IXTLRuntime*)Unsafe.AsPointer(ref this), varDate, bstrFormat, varDestLocale, pbstrFormattedString);
        }

        [return: NativeTypeName("HRESULT")]
        public int formatTime(VARIANT varTime, [NativeTypeName("BSTR")] ushort* bstrFormat, VARIANT varDestLocale, [NativeTypeName("BSTR *")] ushort** pbstrFormattedString)
        {
            return ((delegate* stdcall<IXTLRuntime*, VARIANT, ushort*, VARIANT, ushort**, int>)(lpVtbl[51]))((IXTLRuntime*)Unsafe.AsPointer(ref this), varTime, bstrFormat, varDestLocale, pbstrFormattedString);
        }
    }
}
