// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/msxml.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("2933BF81-7B36-11D2-B20E-00C04F983E60")]
    public unsafe partial struct IXMLDOMDocument
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IXMLDOMDocument*, Guid*, void**, int>)(lpVtbl[0]))((IXMLDOMDocument*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IXMLDOMDocument*, uint>)(lpVtbl[1]))((IXMLDOMDocument*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IXMLDOMDocument*, uint>)(lpVtbl[2]))((IXMLDOMDocument*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfoCount([NativeTypeName("UINT *")] uint* pctinfo)
        {
            return ((delegate* stdcall<IXMLDOMDocument*, uint*, int>)(lpVtbl[3]))((IXMLDOMDocument*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfo([NativeTypeName("UINT")] uint iTInfo, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("ITypeInfo **")] ITypeInfo** ppTInfo)
        {
            return ((delegate* stdcall<IXMLDOMDocument*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IXMLDOMDocument*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, [NativeTypeName("UINT")] uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* stdcall<IXMLDOMDocument*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IXMLDOMDocument*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [return: NativeTypeName("HRESULT")]
        public int Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, [NativeTypeName("DISPPARAMS *")] DISPPARAMS* pDispParams, [NativeTypeName("VARIANT *")] VARIANT* pVarResult, [NativeTypeName("EXCEPINFO *")] EXCEPINFO* pExcepInfo, [NativeTypeName("UINT *")] uint* puArgErr)
        {
            return ((delegate* stdcall<IXMLDOMDocument*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IXMLDOMDocument*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_nodeName([NativeTypeName("BSTR *")] ushort** name)
        {
            return ((delegate* stdcall<IXMLDOMDocument*, ushort**, int>)(lpVtbl[7]))((IXMLDOMDocument*)Unsafe.AsPointer(ref this), name);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_nodeValue([NativeTypeName("VARIANT *")] VARIANT* value)
        {
            return ((delegate* stdcall<IXMLDOMDocument*, VARIANT*, int>)(lpVtbl[8]))((IXMLDOMDocument*)Unsafe.AsPointer(ref this), value);
        }

        [return: NativeTypeName("HRESULT")]
        public int put_nodeValue(VARIANT value)
        {
            return ((delegate* stdcall<IXMLDOMDocument*, VARIANT, int>)(lpVtbl[9]))((IXMLDOMDocument*)Unsafe.AsPointer(ref this), value);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_nodeType([NativeTypeName("DOMNodeType *")] DOMNodeType* type)
        {
            return ((delegate* stdcall<IXMLDOMDocument*, DOMNodeType*, int>)(lpVtbl[10]))((IXMLDOMDocument*)Unsafe.AsPointer(ref this), type);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_parentNode([NativeTypeName("IXMLDOMNode **")] IXMLDOMNode** parent)
        {
            return ((delegate* stdcall<IXMLDOMDocument*, IXMLDOMNode**, int>)(lpVtbl[11]))((IXMLDOMDocument*)Unsafe.AsPointer(ref this), parent);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_childNodes([NativeTypeName("IXMLDOMNodeList **")] IXMLDOMNodeList** childList)
        {
            return ((delegate* stdcall<IXMLDOMDocument*, IXMLDOMNodeList**, int>)(lpVtbl[12]))((IXMLDOMDocument*)Unsafe.AsPointer(ref this), childList);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_firstChild([NativeTypeName("IXMLDOMNode **")] IXMLDOMNode** firstChild)
        {
            return ((delegate* stdcall<IXMLDOMDocument*, IXMLDOMNode**, int>)(lpVtbl[13]))((IXMLDOMDocument*)Unsafe.AsPointer(ref this), firstChild);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_lastChild([NativeTypeName("IXMLDOMNode **")] IXMLDOMNode** lastChild)
        {
            return ((delegate* stdcall<IXMLDOMDocument*, IXMLDOMNode**, int>)(lpVtbl[14]))((IXMLDOMDocument*)Unsafe.AsPointer(ref this), lastChild);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_previousSibling([NativeTypeName("IXMLDOMNode **")] IXMLDOMNode** previousSibling)
        {
            return ((delegate* stdcall<IXMLDOMDocument*, IXMLDOMNode**, int>)(lpVtbl[15]))((IXMLDOMDocument*)Unsafe.AsPointer(ref this), previousSibling);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_nextSibling([NativeTypeName("IXMLDOMNode **")] IXMLDOMNode** nextSibling)
        {
            return ((delegate* stdcall<IXMLDOMDocument*, IXMLDOMNode**, int>)(lpVtbl[16]))((IXMLDOMDocument*)Unsafe.AsPointer(ref this), nextSibling);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_attributes([NativeTypeName("IXMLDOMNamedNodeMap **")] IXMLDOMNamedNodeMap** attributeMap)
        {
            return ((delegate* stdcall<IXMLDOMDocument*, IXMLDOMNamedNodeMap**, int>)(lpVtbl[17]))((IXMLDOMDocument*)Unsafe.AsPointer(ref this), attributeMap);
        }

        [return: NativeTypeName("HRESULT")]
        public int insertBefore([NativeTypeName("IXMLDOMNode *")] IXMLDOMNode* newChild, VARIANT refChild, [NativeTypeName("IXMLDOMNode **")] IXMLDOMNode** outNewChild)
        {
            return ((delegate* stdcall<IXMLDOMDocument*, IXMLDOMNode*, VARIANT, IXMLDOMNode**, int>)(lpVtbl[18]))((IXMLDOMDocument*)Unsafe.AsPointer(ref this), newChild, refChild, outNewChild);
        }

        [return: NativeTypeName("HRESULT")]
        public int replaceChild([NativeTypeName("IXMLDOMNode *")] IXMLDOMNode* newChild, [NativeTypeName("IXMLDOMNode *")] IXMLDOMNode* oldChild, [NativeTypeName("IXMLDOMNode **")] IXMLDOMNode** outOldChild)
        {
            return ((delegate* stdcall<IXMLDOMDocument*, IXMLDOMNode*, IXMLDOMNode*, IXMLDOMNode**, int>)(lpVtbl[19]))((IXMLDOMDocument*)Unsafe.AsPointer(ref this), newChild, oldChild, outOldChild);
        }

        [return: NativeTypeName("HRESULT")]
        public int removeChild([NativeTypeName("IXMLDOMNode *")] IXMLDOMNode* childNode, [NativeTypeName("IXMLDOMNode **")] IXMLDOMNode** oldChild)
        {
            return ((delegate* stdcall<IXMLDOMDocument*, IXMLDOMNode*, IXMLDOMNode**, int>)(lpVtbl[20]))((IXMLDOMDocument*)Unsafe.AsPointer(ref this), childNode, oldChild);
        }

        [return: NativeTypeName("HRESULT")]
        public int appendChild([NativeTypeName("IXMLDOMNode *")] IXMLDOMNode* newChild, [NativeTypeName("IXMLDOMNode **")] IXMLDOMNode** outNewChild)
        {
            return ((delegate* stdcall<IXMLDOMDocument*, IXMLDOMNode*, IXMLDOMNode**, int>)(lpVtbl[21]))((IXMLDOMDocument*)Unsafe.AsPointer(ref this), newChild, outNewChild);
        }

        [return: NativeTypeName("HRESULT")]
        public int hasChildNodes([NativeTypeName("VARIANT_BOOL *")] short* hasChild)
        {
            return ((delegate* stdcall<IXMLDOMDocument*, short*, int>)(lpVtbl[22]))((IXMLDOMDocument*)Unsafe.AsPointer(ref this), hasChild);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_ownerDocument([NativeTypeName("IXMLDOMDocument **")] IXMLDOMDocument** XMLDOMDocument)
        {
            return ((delegate* stdcall<IXMLDOMDocument*, IXMLDOMDocument**, int>)(lpVtbl[23]))((IXMLDOMDocument*)Unsafe.AsPointer(ref this), XMLDOMDocument);
        }

        [return: NativeTypeName("HRESULT")]
        public int cloneNode([NativeTypeName("VARIANT_BOOL")] short deep, [NativeTypeName("IXMLDOMNode **")] IXMLDOMNode** cloneRoot)
        {
            return ((delegate* stdcall<IXMLDOMDocument*, short, IXMLDOMNode**, int>)(lpVtbl[24]))((IXMLDOMDocument*)Unsafe.AsPointer(ref this), deep, cloneRoot);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_nodeTypeString([NativeTypeName("BSTR *")] ushort** nodeType)
        {
            return ((delegate* stdcall<IXMLDOMDocument*, ushort**, int>)(lpVtbl[25]))((IXMLDOMDocument*)Unsafe.AsPointer(ref this), nodeType);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_text([NativeTypeName("BSTR *")] ushort** text)
        {
            return ((delegate* stdcall<IXMLDOMDocument*, ushort**, int>)(lpVtbl[26]))((IXMLDOMDocument*)Unsafe.AsPointer(ref this), text);
        }

        [return: NativeTypeName("HRESULT")]
        public int put_text([NativeTypeName("BSTR")] ushort* text)
        {
            return ((delegate* stdcall<IXMLDOMDocument*, ushort*, int>)(lpVtbl[27]))((IXMLDOMDocument*)Unsafe.AsPointer(ref this), text);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_specified([NativeTypeName("VARIANT_BOOL *")] short* isSpecified)
        {
            return ((delegate* stdcall<IXMLDOMDocument*, short*, int>)(lpVtbl[28]))((IXMLDOMDocument*)Unsafe.AsPointer(ref this), isSpecified);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_definition([NativeTypeName("IXMLDOMNode **")] IXMLDOMNode** definitionNode)
        {
            return ((delegate* stdcall<IXMLDOMDocument*, IXMLDOMNode**, int>)(lpVtbl[29]))((IXMLDOMDocument*)Unsafe.AsPointer(ref this), definitionNode);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_nodeTypedValue([NativeTypeName("VARIANT *")] VARIANT* typedValue)
        {
            return ((delegate* stdcall<IXMLDOMDocument*, VARIANT*, int>)(lpVtbl[30]))((IXMLDOMDocument*)Unsafe.AsPointer(ref this), typedValue);
        }

        [return: NativeTypeName("HRESULT")]
        public int put_nodeTypedValue(VARIANT typedValue)
        {
            return ((delegate* stdcall<IXMLDOMDocument*, VARIANT, int>)(lpVtbl[31]))((IXMLDOMDocument*)Unsafe.AsPointer(ref this), typedValue);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_dataType([NativeTypeName("VARIANT *")] VARIANT* dataTypeName)
        {
            return ((delegate* stdcall<IXMLDOMDocument*, VARIANT*, int>)(lpVtbl[32]))((IXMLDOMDocument*)Unsafe.AsPointer(ref this), dataTypeName);
        }

        [return: NativeTypeName("HRESULT")]
        public int put_dataType([NativeTypeName("BSTR")] ushort* dataTypeName)
        {
            return ((delegate* stdcall<IXMLDOMDocument*, ushort*, int>)(lpVtbl[33]))((IXMLDOMDocument*)Unsafe.AsPointer(ref this), dataTypeName);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_xml([NativeTypeName("BSTR *")] ushort** xmlString)
        {
            return ((delegate* stdcall<IXMLDOMDocument*, ushort**, int>)(lpVtbl[34]))((IXMLDOMDocument*)Unsafe.AsPointer(ref this), xmlString);
        }

        [return: NativeTypeName("HRESULT")]
        public int transformNode([NativeTypeName("IXMLDOMNode *")] IXMLDOMNode* stylesheet, [NativeTypeName("BSTR *")] ushort** xmlString)
        {
            return ((delegate* stdcall<IXMLDOMDocument*, IXMLDOMNode*, ushort**, int>)(lpVtbl[35]))((IXMLDOMDocument*)Unsafe.AsPointer(ref this), stylesheet, xmlString);
        }

        [return: NativeTypeName("HRESULT")]
        public int selectNodes([NativeTypeName("BSTR")] ushort* queryString, [NativeTypeName("IXMLDOMNodeList **")] IXMLDOMNodeList** resultList)
        {
            return ((delegate* stdcall<IXMLDOMDocument*, ushort*, IXMLDOMNodeList**, int>)(lpVtbl[36]))((IXMLDOMDocument*)Unsafe.AsPointer(ref this), queryString, resultList);
        }

        [return: NativeTypeName("HRESULT")]
        public int selectSingleNode([NativeTypeName("BSTR")] ushort* queryString, [NativeTypeName("IXMLDOMNode **")] IXMLDOMNode** resultNode)
        {
            return ((delegate* stdcall<IXMLDOMDocument*, ushort*, IXMLDOMNode**, int>)(lpVtbl[37]))((IXMLDOMDocument*)Unsafe.AsPointer(ref this), queryString, resultNode);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_parsed([NativeTypeName("VARIANT_BOOL *")] short* isParsed)
        {
            return ((delegate* stdcall<IXMLDOMDocument*, short*, int>)(lpVtbl[38]))((IXMLDOMDocument*)Unsafe.AsPointer(ref this), isParsed);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_namespaceURI([NativeTypeName("BSTR *")] ushort** namespaceURI)
        {
            return ((delegate* stdcall<IXMLDOMDocument*, ushort**, int>)(lpVtbl[39]))((IXMLDOMDocument*)Unsafe.AsPointer(ref this), namespaceURI);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_prefix([NativeTypeName("BSTR *")] ushort** prefixString)
        {
            return ((delegate* stdcall<IXMLDOMDocument*, ushort**, int>)(lpVtbl[40]))((IXMLDOMDocument*)Unsafe.AsPointer(ref this), prefixString);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_baseName([NativeTypeName("BSTR *")] ushort** nameString)
        {
            return ((delegate* stdcall<IXMLDOMDocument*, ushort**, int>)(lpVtbl[41]))((IXMLDOMDocument*)Unsafe.AsPointer(ref this), nameString);
        }

        [return: NativeTypeName("HRESULT")]
        public int transformNodeToObject([NativeTypeName("IXMLDOMNode *")] IXMLDOMNode* stylesheet, VARIANT outputObject)
        {
            return ((delegate* stdcall<IXMLDOMDocument*, IXMLDOMNode*, VARIANT, int>)(lpVtbl[42]))((IXMLDOMDocument*)Unsafe.AsPointer(ref this), stylesheet, outputObject);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_doctype([NativeTypeName("IXMLDOMDocumentType **")] IXMLDOMDocumentType** documentType)
        {
            return ((delegate* stdcall<IXMLDOMDocument*, IXMLDOMDocumentType**, int>)(lpVtbl[43]))((IXMLDOMDocument*)Unsafe.AsPointer(ref this), documentType);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_implementation([NativeTypeName("IXMLDOMImplementation **")] IXMLDOMImplementation** impl)
        {
            return ((delegate* stdcall<IXMLDOMDocument*, IXMLDOMImplementation**, int>)(lpVtbl[44]))((IXMLDOMDocument*)Unsafe.AsPointer(ref this), impl);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_documentElement([NativeTypeName("IXMLDOMElement **")] IXMLDOMElement** DOMElement)
        {
            return ((delegate* stdcall<IXMLDOMDocument*, IXMLDOMElement**, int>)(lpVtbl[45]))((IXMLDOMDocument*)Unsafe.AsPointer(ref this), DOMElement);
        }

        [return: NativeTypeName("HRESULT")]
        public int putref_documentElement([NativeTypeName("IXMLDOMElement *")] IXMLDOMElement* DOMElement)
        {
            return ((delegate* stdcall<IXMLDOMDocument*, IXMLDOMElement*, int>)(lpVtbl[46]))((IXMLDOMDocument*)Unsafe.AsPointer(ref this), DOMElement);
        }

        [return: NativeTypeName("HRESULT")]
        public int createElement([NativeTypeName("BSTR")] ushort* tagName, [NativeTypeName("IXMLDOMElement **")] IXMLDOMElement** element)
        {
            return ((delegate* stdcall<IXMLDOMDocument*, ushort*, IXMLDOMElement**, int>)(lpVtbl[47]))((IXMLDOMDocument*)Unsafe.AsPointer(ref this), tagName, element);
        }

        [return: NativeTypeName("HRESULT")]
        public int createDocumentFragment([NativeTypeName("IXMLDOMDocumentFragment **")] IXMLDOMDocumentFragment** docFrag)
        {
            return ((delegate* stdcall<IXMLDOMDocument*, IXMLDOMDocumentFragment**, int>)(lpVtbl[48]))((IXMLDOMDocument*)Unsafe.AsPointer(ref this), docFrag);
        }

        [return: NativeTypeName("HRESULT")]
        public int createTextNode([NativeTypeName("BSTR")] ushort* data, [NativeTypeName("IXMLDOMText **")] IXMLDOMText** text)
        {
            return ((delegate* stdcall<IXMLDOMDocument*, ushort*, IXMLDOMText**, int>)(lpVtbl[49]))((IXMLDOMDocument*)Unsafe.AsPointer(ref this), data, text);
        }

        [return: NativeTypeName("HRESULT")]
        public int createComment([NativeTypeName("BSTR")] ushort* data, [NativeTypeName("IXMLDOMComment **")] IXMLDOMComment** comment)
        {
            return ((delegate* stdcall<IXMLDOMDocument*, ushort*, IXMLDOMComment**, int>)(lpVtbl[50]))((IXMLDOMDocument*)Unsafe.AsPointer(ref this), data, comment);
        }

        [return: NativeTypeName("HRESULT")]
        public int createCDATASection([NativeTypeName("BSTR")] ushort* data, [NativeTypeName("IXMLDOMCDATASection **")] IXMLDOMCDATASection** cdata)
        {
            return ((delegate* stdcall<IXMLDOMDocument*, ushort*, IXMLDOMCDATASection**, int>)(lpVtbl[51]))((IXMLDOMDocument*)Unsafe.AsPointer(ref this), data, cdata);
        }

        [return: NativeTypeName("HRESULT")]
        public int createProcessingInstruction([NativeTypeName("BSTR")] ushort* target, [NativeTypeName("BSTR")] ushort* data, [NativeTypeName("IXMLDOMProcessingInstruction **")] IXMLDOMProcessingInstruction** pi)
        {
            return ((delegate* stdcall<IXMLDOMDocument*, ushort*, ushort*, IXMLDOMProcessingInstruction**, int>)(lpVtbl[52]))((IXMLDOMDocument*)Unsafe.AsPointer(ref this), target, data, pi);
        }

        [return: NativeTypeName("HRESULT")]
        public int createAttribute([NativeTypeName("BSTR")] ushort* name, [NativeTypeName("IXMLDOMAttribute **")] IXMLDOMAttribute** attribute)
        {
            return ((delegate* stdcall<IXMLDOMDocument*, ushort*, IXMLDOMAttribute**, int>)(lpVtbl[53]))((IXMLDOMDocument*)Unsafe.AsPointer(ref this), name, attribute);
        }

        [return: NativeTypeName("HRESULT")]
        public int createEntityReference([NativeTypeName("BSTR")] ushort* name, [NativeTypeName("IXMLDOMEntityReference **")] IXMLDOMEntityReference** entityRef)
        {
            return ((delegate* stdcall<IXMLDOMDocument*, ushort*, IXMLDOMEntityReference**, int>)(lpVtbl[54]))((IXMLDOMDocument*)Unsafe.AsPointer(ref this), name, entityRef);
        }

        [return: NativeTypeName("HRESULT")]
        public int getElementsByTagName([NativeTypeName("BSTR")] ushort* tagName, [NativeTypeName("IXMLDOMNodeList **")] IXMLDOMNodeList** resultList)
        {
            return ((delegate* stdcall<IXMLDOMDocument*, ushort*, IXMLDOMNodeList**, int>)(lpVtbl[55]))((IXMLDOMDocument*)Unsafe.AsPointer(ref this), tagName, resultList);
        }

        [return: NativeTypeName("HRESULT")]
        public int createNode(VARIANT Type, [NativeTypeName("BSTR")] ushort* name, [NativeTypeName("BSTR")] ushort* namespaceURI, [NativeTypeName("IXMLDOMNode **")] IXMLDOMNode** node)
        {
            return ((delegate* stdcall<IXMLDOMDocument*, VARIANT, ushort*, ushort*, IXMLDOMNode**, int>)(lpVtbl[56]))((IXMLDOMDocument*)Unsafe.AsPointer(ref this), Type, name, namespaceURI, node);
        }

        [return: NativeTypeName("HRESULT")]
        public int nodeFromID([NativeTypeName("BSTR")] ushort* idString, [NativeTypeName("IXMLDOMNode **")] IXMLDOMNode** node)
        {
            return ((delegate* stdcall<IXMLDOMDocument*, ushort*, IXMLDOMNode**, int>)(lpVtbl[57]))((IXMLDOMDocument*)Unsafe.AsPointer(ref this), idString, node);
        }

        [return: NativeTypeName("HRESULT")]
        public int load(VARIANT xmlSource, [NativeTypeName("VARIANT_BOOL *")] short* isSuccessful)
        {
            return ((delegate* stdcall<IXMLDOMDocument*, VARIANT, short*, int>)(lpVtbl[58]))((IXMLDOMDocument*)Unsafe.AsPointer(ref this), xmlSource, isSuccessful);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_readyState([NativeTypeName("long *")] int* value)
        {
            return ((delegate* stdcall<IXMLDOMDocument*, int*, int>)(lpVtbl[59]))((IXMLDOMDocument*)Unsafe.AsPointer(ref this), value);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_parseError([NativeTypeName("IXMLDOMParseError **")] IXMLDOMParseError** errorObj)
        {
            return ((delegate* stdcall<IXMLDOMDocument*, IXMLDOMParseError**, int>)(lpVtbl[60]))((IXMLDOMDocument*)Unsafe.AsPointer(ref this), errorObj);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_url([NativeTypeName("BSTR *")] ushort** urlString)
        {
            return ((delegate* stdcall<IXMLDOMDocument*, ushort**, int>)(lpVtbl[61]))((IXMLDOMDocument*)Unsafe.AsPointer(ref this), urlString);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_async([NativeTypeName("VARIANT_BOOL *")] short* isAsync)
        {
            return ((delegate* stdcall<IXMLDOMDocument*, short*, int>)(lpVtbl[62]))((IXMLDOMDocument*)Unsafe.AsPointer(ref this), isAsync);
        }

        [return: NativeTypeName("HRESULT")]
        public int put_async([NativeTypeName("VARIANT_BOOL")] short isAsync)
        {
            return ((delegate* stdcall<IXMLDOMDocument*, short, int>)(lpVtbl[63]))((IXMLDOMDocument*)Unsafe.AsPointer(ref this), isAsync);
        }

        [return: NativeTypeName("HRESULT")]
        public int abort()
        {
            return ((delegate* stdcall<IXMLDOMDocument*, int>)(lpVtbl[64]))((IXMLDOMDocument*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int loadXML([NativeTypeName("BSTR")] ushort* bstrXML, [NativeTypeName("VARIANT_BOOL *")] short* isSuccessful)
        {
            return ((delegate* stdcall<IXMLDOMDocument*, ushort*, short*, int>)(lpVtbl[65]))((IXMLDOMDocument*)Unsafe.AsPointer(ref this), bstrXML, isSuccessful);
        }

        [return: NativeTypeName("HRESULT")]
        public int save(VARIANT destination)
        {
            return ((delegate* stdcall<IXMLDOMDocument*, VARIANT, int>)(lpVtbl[66]))((IXMLDOMDocument*)Unsafe.AsPointer(ref this), destination);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_validateOnParse([NativeTypeName("VARIANT_BOOL *")] short* isValidating)
        {
            return ((delegate* stdcall<IXMLDOMDocument*, short*, int>)(lpVtbl[67]))((IXMLDOMDocument*)Unsafe.AsPointer(ref this), isValidating);
        }

        [return: NativeTypeName("HRESULT")]
        public int put_validateOnParse([NativeTypeName("VARIANT_BOOL")] short isValidating)
        {
            return ((delegate* stdcall<IXMLDOMDocument*, short, int>)(lpVtbl[68]))((IXMLDOMDocument*)Unsafe.AsPointer(ref this), isValidating);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_resolveExternals([NativeTypeName("VARIANT_BOOL *")] short* isResolving)
        {
            return ((delegate* stdcall<IXMLDOMDocument*, short*, int>)(lpVtbl[69]))((IXMLDOMDocument*)Unsafe.AsPointer(ref this), isResolving);
        }

        [return: NativeTypeName("HRESULT")]
        public int put_resolveExternals([NativeTypeName("VARIANT_BOOL")] short isResolving)
        {
            return ((delegate* stdcall<IXMLDOMDocument*, short, int>)(lpVtbl[70]))((IXMLDOMDocument*)Unsafe.AsPointer(ref this), isResolving);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_preserveWhiteSpace([NativeTypeName("VARIANT_BOOL *")] short* isPreserving)
        {
            return ((delegate* stdcall<IXMLDOMDocument*, short*, int>)(lpVtbl[71]))((IXMLDOMDocument*)Unsafe.AsPointer(ref this), isPreserving);
        }

        [return: NativeTypeName("HRESULT")]
        public int put_preserveWhiteSpace([NativeTypeName("VARIANT_BOOL")] short isPreserving)
        {
            return ((delegate* stdcall<IXMLDOMDocument*, short, int>)(lpVtbl[72]))((IXMLDOMDocument*)Unsafe.AsPointer(ref this), isPreserving);
        }

        [return: NativeTypeName("HRESULT")]
        public int put_onreadystatechange(VARIANT readystatechangeSink)
        {
            return ((delegate* stdcall<IXMLDOMDocument*, VARIANT, int>)(lpVtbl[73]))((IXMLDOMDocument*)Unsafe.AsPointer(ref this), readystatechangeSink);
        }

        [return: NativeTypeName("HRESULT")]
        public int put_ondataavailable(VARIANT ondataavailableSink)
        {
            return ((delegate* stdcall<IXMLDOMDocument*, VARIANT, int>)(lpVtbl[74]))((IXMLDOMDocument*)Unsafe.AsPointer(ref this), ondataavailableSink);
        }

        [return: NativeTypeName("HRESULT")]
        public int put_ontransformnode(VARIANT ontransformnodeSink)
        {
            return ((delegate* stdcall<IXMLDOMDocument*, VARIANT, int>)(lpVtbl[75]))((IXMLDOMDocument*)Unsafe.AsPointer(ref this), ontransformnodeSink);
        }
    }
}
