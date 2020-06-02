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
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((IXMLDOMDocument*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IXMLDOMDocument*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IXMLDOMDocument*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfoCount([NativeTypeName("UINT *")] uint* pctinfo)
        {
            return lpVtbl->GetTypeInfoCount((IXMLDOMDocument*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfo([NativeTypeName("UINT")] uint iTInfo, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("ITypeInfo **")] ITypeInfo** ppTInfo)
        {
            return lpVtbl->GetTypeInfo((IXMLDOMDocument*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, [NativeTypeName("UINT")] uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return lpVtbl->GetIDsOfNames((IXMLDOMDocument*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [return: NativeTypeName("HRESULT")]
        public int Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, [NativeTypeName("DISPPARAMS *")] DISPPARAMS* pDispParams, [NativeTypeName("VARIANT *")] VARIANT* pVarResult, [NativeTypeName("EXCEPINFO *")] EXCEPINFO* pExcepInfo, [NativeTypeName("UINT *")] uint* puArgErr)
        {
            return lpVtbl->Invoke((IXMLDOMDocument*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_nodeName([NativeTypeName("BSTR *")] ushort** name)
        {
            return lpVtbl->get_nodeName((IXMLDOMDocument*)Unsafe.AsPointer(ref this), name);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_nodeValue([NativeTypeName("VARIANT *")] VARIANT* value)
        {
            return lpVtbl->get_nodeValue((IXMLDOMDocument*)Unsafe.AsPointer(ref this), value);
        }

        [return: NativeTypeName("HRESULT")]
        public int put_nodeValue(VARIANT value)
        {
            return lpVtbl->put_nodeValue((IXMLDOMDocument*)Unsafe.AsPointer(ref this), value);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_nodeType([NativeTypeName("DOMNodeType *")] DOMNodeType* type)
        {
            return lpVtbl->get_nodeType((IXMLDOMDocument*)Unsafe.AsPointer(ref this), type);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_parentNode([NativeTypeName("IXMLDOMNode **")] IXMLDOMNode** parent)
        {
            return lpVtbl->get_parentNode((IXMLDOMDocument*)Unsafe.AsPointer(ref this), parent);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_childNodes([NativeTypeName("IXMLDOMNodeList **")] IXMLDOMNodeList** childList)
        {
            return lpVtbl->get_childNodes((IXMLDOMDocument*)Unsafe.AsPointer(ref this), childList);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_firstChild([NativeTypeName("IXMLDOMNode **")] IXMLDOMNode** firstChild)
        {
            return lpVtbl->get_firstChild((IXMLDOMDocument*)Unsafe.AsPointer(ref this), firstChild);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_lastChild([NativeTypeName("IXMLDOMNode **")] IXMLDOMNode** lastChild)
        {
            return lpVtbl->get_lastChild((IXMLDOMDocument*)Unsafe.AsPointer(ref this), lastChild);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_previousSibling([NativeTypeName("IXMLDOMNode **")] IXMLDOMNode** previousSibling)
        {
            return lpVtbl->get_previousSibling((IXMLDOMDocument*)Unsafe.AsPointer(ref this), previousSibling);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_nextSibling([NativeTypeName("IXMLDOMNode **")] IXMLDOMNode** nextSibling)
        {
            return lpVtbl->get_nextSibling((IXMLDOMDocument*)Unsafe.AsPointer(ref this), nextSibling);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_attributes([NativeTypeName("IXMLDOMNamedNodeMap **")] IXMLDOMNamedNodeMap** attributeMap)
        {
            return lpVtbl->get_attributes((IXMLDOMDocument*)Unsafe.AsPointer(ref this), attributeMap);
        }

        [return: NativeTypeName("HRESULT")]
        public int insertBefore([NativeTypeName("IXMLDOMNode *")] IXMLDOMNode* newChild, VARIANT refChild, [NativeTypeName("IXMLDOMNode **")] IXMLDOMNode** outNewChild)
        {
            return lpVtbl->insertBefore((IXMLDOMDocument*)Unsafe.AsPointer(ref this), newChild, refChild, outNewChild);
        }

        [return: NativeTypeName("HRESULT")]
        public int replaceChild([NativeTypeName("IXMLDOMNode *")] IXMLDOMNode* newChild, [NativeTypeName("IXMLDOMNode *")] IXMLDOMNode* oldChild, [NativeTypeName("IXMLDOMNode **")] IXMLDOMNode** outOldChild)
        {
            return lpVtbl->replaceChild((IXMLDOMDocument*)Unsafe.AsPointer(ref this), newChild, oldChild, outOldChild);
        }

        [return: NativeTypeName("HRESULT")]
        public int removeChild([NativeTypeName("IXMLDOMNode *")] IXMLDOMNode* childNode, [NativeTypeName("IXMLDOMNode **")] IXMLDOMNode** oldChild)
        {
            return lpVtbl->removeChild((IXMLDOMDocument*)Unsafe.AsPointer(ref this), childNode, oldChild);
        }

        [return: NativeTypeName("HRESULT")]
        public int appendChild([NativeTypeName("IXMLDOMNode *")] IXMLDOMNode* newChild, [NativeTypeName("IXMLDOMNode **")] IXMLDOMNode** outNewChild)
        {
            return lpVtbl->appendChild((IXMLDOMDocument*)Unsafe.AsPointer(ref this), newChild, outNewChild);
        }

        [return: NativeTypeName("HRESULT")]
        public int hasChildNodes([NativeTypeName("VARIANT_BOOL *")] short* hasChild)
        {
            return lpVtbl->hasChildNodes((IXMLDOMDocument*)Unsafe.AsPointer(ref this), hasChild);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_ownerDocument([NativeTypeName("IXMLDOMDocument **")] IXMLDOMDocument** XMLDOMDocument)
        {
            return lpVtbl->get_ownerDocument((IXMLDOMDocument*)Unsafe.AsPointer(ref this), XMLDOMDocument);
        }

        [return: NativeTypeName("HRESULT")]
        public int cloneNode([NativeTypeName("VARIANT_BOOL")] short deep, [NativeTypeName("IXMLDOMNode **")] IXMLDOMNode** cloneRoot)
        {
            return lpVtbl->cloneNode((IXMLDOMDocument*)Unsafe.AsPointer(ref this), deep, cloneRoot);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_nodeTypeString([NativeTypeName("BSTR *")] ushort** nodeType)
        {
            return lpVtbl->get_nodeTypeString((IXMLDOMDocument*)Unsafe.AsPointer(ref this), nodeType);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_text([NativeTypeName("BSTR *")] ushort** text)
        {
            return lpVtbl->get_text((IXMLDOMDocument*)Unsafe.AsPointer(ref this), text);
        }

        [return: NativeTypeName("HRESULT")]
        public int put_text([NativeTypeName("BSTR")] ushort* text)
        {
            return lpVtbl->put_text((IXMLDOMDocument*)Unsafe.AsPointer(ref this), text);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_specified([NativeTypeName("VARIANT_BOOL *")] short* isSpecified)
        {
            return lpVtbl->get_specified((IXMLDOMDocument*)Unsafe.AsPointer(ref this), isSpecified);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_definition([NativeTypeName("IXMLDOMNode **")] IXMLDOMNode** definitionNode)
        {
            return lpVtbl->get_definition((IXMLDOMDocument*)Unsafe.AsPointer(ref this), definitionNode);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_nodeTypedValue([NativeTypeName("VARIANT *")] VARIANT* typedValue)
        {
            return lpVtbl->get_nodeTypedValue((IXMLDOMDocument*)Unsafe.AsPointer(ref this), typedValue);
        }

        [return: NativeTypeName("HRESULT")]
        public int put_nodeTypedValue(VARIANT typedValue)
        {
            return lpVtbl->put_nodeTypedValue((IXMLDOMDocument*)Unsafe.AsPointer(ref this), typedValue);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_dataType([NativeTypeName("VARIANT *")] VARIANT* dataTypeName)
        {
            return lpVtbl->get_dataType((IXMLDOMDocument*)Unsafe.AsPointer(ref this), dataTypeName);
        }

        [return: NativeTypeName("HRESULT")]
        public int put_dataType([NativeTypeName("BSTR")] ushort* dataTypeName)
        {
            return lpVtbl->put_dataType((IXMLDOMDocument*)Unsafe.AsPointer(ref this), dataTypeName);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_xml([NativeTypeName("BSTR *")] ushort** xmlString)
        {
            return lpVtbl->get_xml((IXMLDOMDocument*)Unsafe.AsPointer(ref this), xmlString);
        }

        [return: NativeTypeName("HRESULT")]
        public int transformNode([NativeTypeName("IXMLDOMNode *")] IXMLDOMNode* stylesheet, [NativeTypeName("BSTR *")] ushort** xmlString)
        {
            return lpVtbl->transformNode((IXMLDOMDocument*)Unsafe.AsPointer(ref this), stylesheet, xmlString);
        }

        [return: NativeTypeName("HRESULT")]
        public int selectNodes([NativeTypeName("BSTR")] ushort* queryString, [NativeTypeName("IXMLDOMNodeList **")] IXMLDOMNodeList** resultList)
        {
            return lpVtbl->selectNodes((IXMLDOMDocument*)Unsafe.AsPointer(ref this), queryString, resultList);
        }

        [return: NativeTypeName("HRESULT")]
        public int selectSingleNode([NativeTypeName("BSTR")] ushort* queryString, [NativeTypeName("IXMLDOMNode **")] IXMLDOMNode** resultNode)
        {
            return lpVtbl->selectSingleNode((IXMLDOMDocument*)Unsafe.AsPointer(ref this), queryString, resultNode);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_parsed([NativeTypeName("VARIANT_BOOL *")] short* isParsed)
        {
            return lpVtbl->get_parsed((IXMLDOMDocument*)Unsafe.AsPointer(ref this), isParsed);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_namespaceURI([NativeTypeName("BSTR *")] ushort** namespaceURI)
        {
            return lpVtbl->get_namespaceURI((IXMLDOMDocument*)Unsafe.AsPointer(ref this), namespaceURI);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_prefix([NativeTypeName("BSTR *")] ushort** prefixString)
        {
            return lpVtbl->get_prefix((IXMLDOMDocument*)Unsafe.AsPointer(ref this), prefixString);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_baseName([NativeTypeName("BSTR *")] ushort** nameString)
        {
            return lpVtbl->get_baseName((IXMLDOMDocument*)Unsafe.AsPointer(ref this), nameString);
        }

        [return: NativeTypeName("HRESULT")]
        public int transformNodeToObject([NativeTypeName("IXMLDOMNode *")] IXMLDOMNode* stylesheet, VARIANT outputObject)
        {
            return lpVtbl->transformNodeToObject((IXMLDOMDocument*)Unsafe.AsPointer(ref this), stylesheet, outputObject);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_doctype([NativeTypeName("IXMLDOMDocumentType **")] IXMLDOMDocumentType** documentType)
        {
            return lpVtbl->get_doctype((IXMLDOMDocument*)Unsafe.AsPointer(ref this), documentType);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_implementation([NativeTypeName("IXMLDOMImplementation **")] IXMLDOMImplementation** impl)
        {
            return lpVtbl->get_implementation((IXMLDOMDocument*)Unsafe.AsPointer(ref this), impl);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_documentElement([NativeTypeName("IXMLDOMElement **")] IXMLDOMElement** DOMElement)
        {
            return lpVtbl->get_documentElement((IXMLDOMDocument*)Unsafe.AsPointer(ref this), DOMElement);
        }

        [return: NativeTypeName("HRESULT")]
        public int putref_documentElement([NativeTypeName("IXMLDOMElement *")] IXMLDOMElement* DOMElement)
        {
            return lpVtbl->putref_documentElement((IXMLDOMDocument*)Unsafe.AsPointer(ref this), DOMElement);
        }

        [return: NativeTypeName("HRESULT")]
        public int createElement([NativeTypeName("BSTR")] ushort* tagName, [NativeTypeName("IXMLDOMElement **")] IXMLDOMElement** element)
        {
            return lpVtbl->createElement((IXMLDOMDocument*)Unsafe.AsPointer(ref this), tagName, element);
        }

        [return: NativeTypeName("HRESULT")]
        public int createDocumentFragment([NativeTypeName("IXMLDOMDocumentFragment **")] IXMLDOMDocumentFragment** docFrag)
        {
            return lpVtbl->createDocumentFragment((IXMLDOMDocument*)Unsafe.AsPointer(ref this), docFrag);
        }

        [return: NativeTypeName("HRESULT")]
        public int createTextNode([NativeTypeName("BSTR")] ushort* data, [NativeTypeName("IXMLDOMText **")] IXMLDOMText** text)
        {
            return lpVtbl->createTextNode((IXMLDOMDocument*)Unsafe.AsPointer(ref this), data, text);
        }

        [return: NativeTypeName("HRESULT")]
        public int createComment([NativeTypeName("BSTR")] ushort* data, [NativeTypeName("IXMLDOMComment **")] IXMLDOMComment** comment)
        {
            return lpVtbl->createComment((IXMLDOMDocument*)Unsafe.AsPointer(ref this), data, comment);
        }

        [return: NativeTypeName("HRESULT")]
        public int createCDATASection([NativeTypeName("BSTR")] ushort* data, [NativeTypeName("IXMLDOMCDATASection **")] IXMLDOMCDATASection** cdata)
        {
            return lpVtbl->createCDATASection((IXMLDOMDocument*)Unsafe.AsPointer(ref this), data, cdata);
        }

        [return: NativeTypeName("HRESULT")]
        public int createProcessingInstruction([NativeTypeName("BSTR")] ushort* target, [NativeTypeName("BSTR")] ushort* data, [NativeTypeName("IXMLDOMProcessingInstruction **")] IXMLDOMProcessingInstruction** pi)
        {
            return lpVtbl->createProcessingInstruction((IXMLDOMDocument*)Unsafe.AsPointer(ref this), target, data, pi);
        }

        [return: NativeTypeName("HRESULT")]
        public int createAttribute([NativeTypeName("BSTR")] ushort* name, [NativeTypeName("IXMLDOMAttribute **")] IXMLDOMAttribute** attribute)
        {
            return lpVtbl->createAttribute((IXMLDOMDocument*)Unsafe.AsPointer(ref this), name, attribute);
        }

        [return: NativeTypeName("HRESULT")]
        public int createEntityReference([NativeTypeName("BSTR")] ushort* name, [NativeTypeName("IXMLDOMEntityReference **")] IXMLDOMEntityReference** entityRef)
        {
            return lpVtbl->createEntityReference((IXMLDOMDocument*)Unsafe.AsPointer(ref this), name, entityRef);
        }

        [return: NativeTypeName("HRESULT")]
        public int getElementsByTagName([NativeTypeName("BSTR")] ushort* tagName, [NativeTypeName("IXMLDOMNodeList **")] IXMLDOMNodeList** resultList)
        {
            return lpVtbl->getElementsByTagName((IXMLDOMDocument*)Unsafe.AsPointer(ref this), tagName, resultList);
        }

        [return: NativeTypeName("HRESULT")]
        public int createNode(VARIANT Type, [NativeTypeName("BSTR")] ushort* name, [NativeTypeName("BSTR")] ushort* namespaceURI, [NativeTypeName("IXMLDOMNode **")] IXMLDOMNode** node)
        {
            return lpVtbl->createNode((IXMLDOMDocument*)Unsafe.AsPointer(ref this), Type, name, namespaceURI, node);
        }

        [return: NativeTypeName("HRESULT")]
        public int nodeFromID([NativeTypeName("BSTR")] ushort* idString, [NativeTypeName("IXMLDOMNode **")] IXMLDOMNode** node)
        {
            return lpVtbl->nodeFromID((IXMLDOMDocument*)Unsafe.AsPointer(ref this), idString, node);
        }

        [return: NativeTypeName("HRESULT")]
        public int load(VARIANT xmlSource, [NativeTypeName("VARIANT_BOOL *")] short* isSuccessful)
        {
            return lpVtbl->load((IXMLDOMDocument*)Unsafe.AsPointer(ref this), xmlSource, isSuccessful);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_readyState([NativeTypeName("long *")] int* value)
        {
            return lpVtbl->get_readyState((IXMLDOMDocument*)Unsafe.AsPointer(ref this), value);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_parseError([NativeTypeName("IXMLDOMParseError **")] IXMLDOMParseError** errorObj)
        {
            return lpVtbl->get_parseError((IXMLDOMDocument*)Unsafe.AsPointer(ref this), errorObj);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_url([NativeTypeName("BSTR *")] ushort** urlString)
        {
            return lpVtbl->get_url((IXMLDOMDocument*)Unsafe.AsPointer(ref this), urlString);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_async([NativeTypeName("VARIANT_BOOL *")] short* isAsync)
        {
            return lpVtbl->get_async((IXMLDOMDocument*)Unsafe.AsPointer(ref this), isAsync);
        }

        [return: NativeTypeName("HRESULT")]
        public int put_async([NativeTypeName("VARIANT_BOOL")] short isAsync)
        {
            return lpVtbl->put_async((IXMLDOMDocument*)Unsafe.AsPointer(ref this), isAsync);
        }

        [return: NativeTypeName("HRESULT")]
        public int abort()
        {
            return lpVtbl->abort((IXMLDOMDocument*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int loadXML([NativeTypeName("BSTR")] ushort* bstrXML, [NativeTypeName("VARIANT_BOOL *")] short* isSuccessful)
        {
            return lpVtbl->loadXML((IXMLDOMDocument*)Unsafe.AsPointer(ref this), bstrXML, isSuccessful);
        }

        [return: NativeTypeName("HRESULT")]
        public int save(VARIANT destination)
        {
            return lpVtbl->save((IXMLDOMDocument*)Unsafe.AsPointer(ref this), destination);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_validateOnParse([NativeTypeName("VARIANT_BOOL *")] short* isValidating)
        {
            return lpVtbl->get_validateOnParse((IXMLDOMDocument*)Unsafe.AsPointer(ref this), isValidating);
        }

        [return: NativeTypeName("HRESULT")]
        public int put_validateOnParse([NativeTypeName("VARIANT_BOOL")] short isValidating)
        {
            return lpVtbl->put_validateOnParse((IXMLDOMDocument*)Unsafe.AsPointer(ref this), isValidating);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_resolveExternals([NativeTypeName("VARIANT_BOOL *")] short* isResolving)
        {
            return lpVtbl->get_resolveExternals((IXMLDOMDocument*)Unsafe.AsPointer(ref this), isResolving);
        }

        [return: NativeTypeName("HRESULT")]
        public int put_resolveExternals([NativeTypeName("VARIANT_BOOL")] short isResolving)
        {
            return lpVtbl->put_resolveExternals((IXMLDOMDocument*)Unsafe.AsPointer(ref this), isResolving);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_preserveWhiteSpace([NativeTypeName("VARIANT_BOOL *")] short* isPreserving)
        {
            return lpVtbl->get_preserveWhiteSpace((IXMLDOMDocument*)Unsafe.AsPointer(ref this), isPreserving);
        }

        [return: NativeTypeName("HRESULT")]
        public int put_preserveWhiteSpace([NativeTypeName("VARIANT_BOOL")] short isPreserving)
        {
            return lpVtbl->put_preserveWhiteSpace((IXMLDOMDocument*)Unsafe.AsPointer(ref this), isPreserving);
        }

        [return: NativeTypeName("HRESULT")]
        public int put_onreadystatechange(VARIANT readystatechangeSink)
        {
            return lpVtbl->put_onreadystatechange((IXMLDOMDocument*)Unsafe.AsPointer(ref this), readystatechangeSink);
        }

        [return: NativeTypeName("HRESULT")]
        public int put_ondataavailable(VARIANT ondataavailableSink)
        {
            return lpVtbl->put_ondataavailable((IXMLDOMDocument*)Unsafe.AsPointer(ref this), ondataavailableSink);
        }

        [return: NativeTypeName("HRESULT")]
        public int put_ontransformnode(VARIANT ontransformnodeSink)
        {
            return lpVtbl->put_ontransformnode((IXMLDOMDocument*)Unsafe.AsPointer(ref this), ontransformnodeSink);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<IXMLDOMDocument*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IXMLDOMDocument*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IXMLDOMDocument*, uint> Release;

            [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
            public delegate* stdcall<IXMLDOMDocument*, uint*, int> GetTypeInfoCount;

            [NativeTypeName("HRESULT (UINT, LCID, ITypeInfo **) __attribute__((stdcall))")]
            public delegate* stdcall<IXMLDOMDocument*, uint, uint, ITypeInfo**, int> GetTypeInfo;

            [NativeTypeName("HRESULT (const IID &, LPOLESTR *, UINT, LCID, DISPID *) __attribute__((stdcall))")]
            public delegate* stdcall<IXMLDOMDocument*, Guid*, ushort**, uint, uint, int*, int> GetIDsOfNames;

            [NativeTypeName("HRESULT (DISPID, const IID &, LCID, WORD, DISPPARAMS *, VARIANT *, EXCEPINFO *, UINT *) __attribute__((stdcall))")]
            public delegate* stdcall<IXMLDOMDocument*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int> Invoke;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* stdcall<IXMLDOMDocument*, ushort**, int> get_nodeName;

            [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
            public delegate* stdcall<IXMLDOMDocument*, VARIANT*, int> get_nodeValue;

            [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
            public delegate* stdcall<IXMLDOMDocument*, VARIANT, int> put_nodeValue;

            [NativeTypeName("HRESULT (DOMNodeType *) __attribute__((stdcall))")]
            public delegate* stdcall<IXMLDOMDocument*, DOMNodeType*, int> get_nodeType;

            [NativeTypeName("HRESULT (IXMLDOMNode **) __attribute__((stdcall))")]
            public delegate* stdcall<IXMLDOMDocument*, IXMLDOMNode**, int> get_parentNode;

            [NativeTypeName("HRESULT (IXMLDOMNodeList **) __attribute__((stdcall))")]
            public delegate* stdcall<IXMLDOMDocument*, IXMLDOMNodeList**, int> get_childNodes;

            [NativeTypeName("HRESULT (IXMLDOMNode **) __attribute__((stdcall))")]
            public delegate* stdcall<IXMLDOMDocument*, IXMLDOMNode**, int> get_firstChild;

            [NativeTypeName("HRESULT (IXMLDOMNode **) __attribute__((stdcall))")]
            public delegate* stdcall<IXMLDOMDocument*, IXMLDOMNode**, int> get_lastChild;

            [NativeTypeName("HRESULT (IXMLDOMNode **) __attribute__((stdcall))")]
            public delegate* stdcall<IXMLDOMDocument*, IXMLDOMNode**, int> get_previousSibling;

            [NativeTypeName("HRESULT (IXMLDOMNode **) __attribute__((stdcall))")]
            public delegate* stdcall<IXMLDOMDocument*, IXMLDOMNode**, int> get_nextSibling;

            [NativeTypeName("HRESULT (IXMLDOMNamedNodeMap **) __attribute__((stdcall))")]
            public delegate* stdcall<IXMLDOMDocument*, IXMLDOMNamedNodeMap**, int> get_attributes;

            [NativeTypeName("HRESULT (IXMLDOMNode *, VARIANT, IXMLDOMNode **) __attribute__((stdcall))")]
            public delegate* stdcall<IXMLDOMDocument*, IXMLDOMNode*, VARIANT, IXMLDOMNode**, int> insertBefore;

            [NativeTypeName("HRESULT (IXMLDOMNode *, IXMLDOMNode *, IXMLDOMNode **) __attribute__((stdcall))")]
            public delegate* stdcall<IXMLDOMDocument*, IXMLDOMNode*, IXMLDOMNode*, IXMLDOMNode**, int> replaceChild;

            [NativeTypeName("HRESULT (IXMLDOMNode *, IXMLDOMNode **) __attribute__((stdcall))")]
            public delegate* stdcall<IXMLDOMDocument*, IXMLDOMNode*, IXMLDOMNode**, int> removeChild;

            [NativeTypeName("HRESULT (IXMLDOMNode *, IXMLDOMNode **) __attribute__((stdcall))")]
            public delegate* stdcall<IXMLDOMDocument*, IXMLDOMNode*, IXMLDOMNode**, int> appendChild;

            [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
            public delegate* stdcall<IXMLDOMDocument*, short*, int> hasChildNodes;

            [NativeTypeName("HRESULT (IXMLDOMDocument **) __attribute__((stdcall))")]
            public delegate* stdcall<IXMLDOMDocument*, IXMLDOMDocument**, int> get_ownerDocument;

            [NativeTypeName("HRESULT (VARIANT_BOOL, IXMLDOMNode **) __attribute__((stdcall))")]
            public delegate* stdcall<IXMLDOMDocument*, short, IXMLDOMNode**, int> cloneNode;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* stdcall<IXMLDOMDocument*, ushort**, int> get_nodeTypeString;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* stdcall<IXMLDOMDocument*, ushort**, int> get_text;

            [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
            public delegate* stdcall<IXMLDOMDocument*, ushort*, int> put_text;

            [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
            public delegate* stdcall<IXMLDOMDocument*, short*, int> get_specified;

            [NativeTypeName("HRESULT (IXMLDOMNode **) __attribute__((stdcall))")]
            public delegate* stdcall<IXMLDOMDocument*, IXMLDOMNode**, int> get_definition;

            [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
            public delegate* stdcall<IXMLDOMDocument*, VARIANT*, int> get_nodeTypedValue;

            [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
            public delegate* stdcall<IXMLDOMDocument*, VARIANT, int> put_nodeTypedValue;

            [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
            public delegate* stdcall<IXMLDOMDocument*, VARIANT*, int> get_dataType;

            [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
            public delegate* stdcall<IXMLDOMDocument*, ushort*, int> put_dataType;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* stdcall<IXMLDOMDocument*, ushort**, int> get_xml;

            [NativeTypeName("HRESULT (IXMLDOMNode *, BSTR *) __attribute__((stdcall))")]
            public delegate* stdcall<IXMLDOMDocument*, IXMLDOMNode*, ushort**, int> transformNode;

            [NativeTypeName("HRESULT (BSTR, IXMLDOMNodeList **) __attribute__((stdcall))")]
            public delegate* stdcall<IXMLDOMDocument*, ushort*, IXMLDOMNodeList**, int> selectNodes;

            [NativeTypeName("HRESULT (BSTR, IXMLDOMNode **) __attribute__((stdcall))")]
            public delegate* stdcall<IXMLDOMDocument*, ushort*, IXMLDOMNode**, int> selectSingleNode;

            [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
            public delegate* stdcall<IXMLDOMDocument*, short*, int> get_parsed;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* stdcall<IXMLDOMDocument*, ushort**, int> get_namespaceURI;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* stdcall<IXMLDOMDocument*, ushort**, int> get_prefix;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* stdcall<IXMLDOMDocument*, ushort**, int> get_baseName;

            [NativeTypeName("HRESULT (IXMLDOMNode *, VARIANT) __attribute__((stdcall))")]
            public delegate* stdcall<IXMLDOMDocument*, IXMLDOMNode*, VARIANT, int> transformNodeToObject;

            [NativeTypeName("HRESULT (IXMLDOMDocumentType **) __attribute__((stdcall))")]
            public delegate* stdcall<IXMLDOMDocument*, IXMLDOMDocumentType**, int> get_doctype;

            [NativeTypeName("HRESULT (IXMLDOMImplementation **) __attribute__((stdcall))")]
            public delegate* stdcall<IXMLDOMDocument*, IXMLDOMImplementation**, int> get_implementation;

            [NativeTypeName("HRESULT (IXMLDOMElement **) __attribute__((stdcall))")]
            public delegate* stdcall<IXMLDOMDocument*, IXMLDOMElement**, int> get_documentElement;

            [NativeTypeName("HRESULT (IXMLDOMElement *) __attribute__((stdcall))")]
            public delegate* stdcall<IXMLDOMDocument*, IXMLDOMElement*, int> putref_documentElement;

            [NativeTypeName("HRESULT (BSTR, IXMLDOMElement **) __attribute__((stdcall))")]
            public delegate* stdcall<IXMLDOMDocument*, ushort*, IXMLDOMElement**, int> createElement;

            [NativeTypeName("HRESULT (IXMLDOMDocumentFragment **) __attribute__((stdcall))")]
            public delegate* stdcall<IXMLDOMDocument*, IXMLDOMDocumentFragment**, int> createDocumentFragment;

            [NativeTypeName("HRESULT (BSTR, IXMLDOMText **) __attribute__((stdcall))")]
            public delegate* stdcall<IXMLDOMDocument*, ushort*, IXMLDOMText**, int> createTextNode;

            [NativeTypeName("HRESULT (BSTR, IXMLDOMComment **) __attribute__((stdcall))")]
            public delegate* stdcall<IXMLDOMDocument*, ushort*, IXMLDOMComment**, int> createComment;

            [NativeTypeName("HRESULT (BSTR, IXMLDOMCDATASection **) __attribute__((stdcall))")]
            public delegate* stdcall<IXMLDOMDocument*, ushort*, IXMLDOMCDATASection**, int> createCDATASection;

            [NativeTypeName("HRESULT (BSTR, BSTR, IXMLDOMProcessingInstruction **) __attribute__((stdcall))")]
            public delegate* stdcall<IXMLDOMDocument*, ushort*, ushort*, IXMLDOMProcessingInstruction**, int> createProcessingInstruction;

            [NativeTypeName("HRESULT (BSTR, IXMLDOMAttribute **) __attribute__((stdcall))")]
            public delegate* stdcall<IXMLDOMDocument*, ushort*, IXMLDOMAttribute**, int> createAttribute;

            [NativeTypeName("HRESULT (BSTR, IXMLDOMEntityReference **) __attribute__((stdcall))")]
            public delegate* stdcall<IXMLDOMDocument*, ushort*, IXMLDOMEntityReference**, int> createEntityReference;

            [NativeTypeName("HRESULT (BSTR, IXMLDOMNodeList **) __attribute__((stdcall))")]
            public delegate* stdcall<IXMLDOMDocument*, ushort*, IXMLDOMNodeList**, int> getElementsByTagName;

            [NativeTypeName("HRESULT (VARIANT, BSTR, BSTR, IXMLDOMNode **) __attribute__((stdcall))")]
            public delegate* stdcall<IXMLDOMDocument*, VARIANT, ushort*, ushort*, IXMLDOMNode**, int> createNode;

            [NativeTypeName("HRESULT (BSTR, IXMLDOMNode **) __attribute__((stdcall))")]
            public delegate* stdcall<IXMLDOMDocument*, ushort*, IXMLDOMNode**, int> nodeFromID;

            [NativeTypeName("HRESULT (VARIANT, VARIANT_BOOL *) __attribute__((stdcall))")]
            public delegate* stdcall<IXMLDOMDocument*, VARIANT, short*, int> load;

            [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
            public delegate* stdcall<IXMLDOMDocument*, int*, int> get_readyState;

            [NativeTypeName("HRESULT (IXMLDOMParseError **) __attribute__((stdcall))")]
            public delegate* stdcall<IXMLDOMDocument*, IXMLDOMParseError**, int> get_parseError;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* stdcall<IXMLDOMDocument*, ushort**, int> get_url;

            [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
            public delegate* stdcall<IXMLDOMDocument*, short*, int> get_async;

            [NativeTypeName("HRESULT (VARIANT_BOOL) __attribute__((stdcall))")]
            public delegate* stdcall<IXMLDOMDocument*, short, int> put_async;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* stdcall<IXMLDOMDocument*, int> abort;

            [NativeTypeName("HRESULT (BSTR, VARIANT_BOOL *) __attribute__((stdcall))")]
            public delegate* stdcall<IXMLDOMDocument*, ushort*, short*, int> loadXML;

            [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
            public delegate* stdcall<IXMLDOMDocument*, VARIANT, int> save;

            [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
            public delegate* stdcall<IXMLDOMDocument*, short*, int> get_validateOnParse;

            [NativeTypeName("HRESULT (VARIANT_BOOL) __attribute__((stdcall))")]
            public delegate* stdcall<IXMLDOMDocument*, short, int> put_validateOnParse;

            [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
            public delegate* stdcall<IXMLDOMDocument*, short*, int> get_resolveExternals;

            [NativeTypeName("HRESULT (VARIANT_BOOL) __attribute__((stdcall))")]
            public delegate* stdcall<IXMLDOMDocument*, short, int> put_resolveExternals;

            [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
            public delegate* stdcall<IXMLDOMDocument*, short*, int> get_preserveWhiteSpace;

            [NativeTypeName("HRESULT (VARIANT_BOOL) __attribute__((stdcall))")]
            public delegate* stdcall<IXMLDOMDocument*, short, int> put_preserveWhiteSpace;

            [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
            public delegate* stdcall<IXMLDOMDocument*, VARIANT, int> put_onreadystatechange;

            [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
            public delegate* stdcall<IXMLDOMDocument*, VARIANT, int> put_ondataavailable;

            [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
            public delegate* stdcall<IXMLDOMDocument*, VARIANT, int> put_ontransformnode;
        }
    }
}
