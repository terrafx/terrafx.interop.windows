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

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IXMLDOMDocument* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IXMLDOMDocument* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IXMLDOMDocument* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetTypeInfoCount(IXMLDOMDocument* pThis, [NativeTypeName("UINT *")] uint* pctinfo);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetTypeInfo(IXMLDOMDocument* pThis, [NativeTypeName("UINT")] uint iTInfo, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("ITypeInfo **")] ITypeInfo** ppTInfo);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetIDsOfNames(IXMLDOMDocument* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, [NativeTypeName("UINT")] uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Invoke(IXMLDOMDocument* pThis, [NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, [NativeTypeName("DISPPARAMS *")] DISPPARAMS* pDispParams, [NativeTypeName("VARIANT *")] VARIANT* pVarResult, [NativeTypeName("EXCEPINFO *")] EXCEPINFO* pExcepInfo, [NativeTypeName("UINT *")] uint* puArgErr);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _get_nodeName(IXMLDOMDocument* pThis, [NativeTypeName("BSTR *")] ushort** name);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _get_nodeValue(IXMLDOMDocument* pThis, [NativeTypeName("VARIANT *")] VARIANT* value);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _put_nodeValue(IXMLDOMDocument* pThis, VARIANT value);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _get_nodeType(IXMLDOMDocument* pThis, [NativeTypeName("DOMNodeType *")] DOMNodeType* type);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _get_parentNode(IXMLDOMDocument* pThis, [NativeTypeName("IXMLDOMNode **")] IXMLDOMNode** parent);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _get_childNodes(IXMLDOMDocument* pThis, [NativeTypeName("IXMLDOMNodeList **")] IXMLDOMNodeList** childList);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _get_firstChild(IXMLDOMDocument* pThis, [NativeTypeName("IXMLDOMNode **")] IXMLDOMNode** firstChild);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _get_lastChild(IXMLDOMDocument* pThis, [NativeTypeName("IXMLDOMNode **")] IXMLDOMNode** lastChild);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _get_previousSibling(IXMLDOMDocument* pThis, [NativeTypeName("IXMLDOMNode **")] IXMLDOMNode** previousSibling);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _get_nextSibling(IXMLDOMDocument* pThis, [NativeTypeName("IXMLDOMNode **")] IXMLDOMNode** nextSibling);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _get_attributes(IXMLDOMDocument* pThis, [NativeTypeName("IXMLDOMNamedNodeMap **")] IXMLDOMNamedNodeMap** attributeMap);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _insertBefore(IXMLDOMDocument* pThis, [NativeTypeName("IXMLDOMNode *")] IXMLDOMNode* newChild, VARIANT refChild, [NativeTypeName("IXMLDOMNode **")] IXMLDOMNode** outNewChild);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _replaceChild(IXMLDOMDocument* pThis, [NativeTypeName("IXMLDOMNode *")] IXMLDOMNode* newChild, [NativeTypeName("IXMLDOMNode *")] IXMLDOMNode* oldChild, [NativeTypeName("IXMLDOMNode **")] IXMLDOMNode** outOldChild);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _removeChild(IXMLDOMDocument* pThis, [NativeTypeName("IXMLDOMNode *")] IXMLDOMNode* childNode, [NativeTypeName("IXMLDOMNode **")] IXMLDOMNode** oldChild);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _appendChild(IXMLDOMDocument* pThis, [NativeTypeName("IXMLDOMNode *")] IXMLDOMNode* newChild, [NativeTypeName("IXMLDOMNode **")] IXMLDOMNode** outNewChild);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _hasChildNodes(IXMLDOMDocument* pThis, [NativeTypeName("VARIANT_BOOL *")] short* hasChild);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _get_ownerDocument(IXMLDOMDocument* pThis, [NativeTypeName("IXMLDOMDocument **")] IXMLDOMDocument** XMLDOMDocument);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _cloneNode(IXMLDOMDocument* pThis, [NativeTypeName("VARIANT_BOOL")] short deep, [NativeTypeName("IXMLDOMNode **")] IXMLDOMNode** cloneRoot);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _get_nodeTypeString(IXMLDOMDocument* pThis, [NativeTypeName("BSTR *")] ushort** nodeType);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _get_text(IXMLDOMDocument* pThis, [NativeTypeName("BSTR *")] ushort** text);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _put_text(IXMLDOMDocument* pThis, [NativeTypeName("BSTR")] ushort* text);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _get_specified(IXMLDOMDocument* pThis, [NativeTypeName("VARIANT_BOOL *")] short* isSpecified);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _get_definition(IXMLDOMDocument* pThis, [NativeTypeName("IXMLDOMNode **")] IXMLDOMNode** definitionNode);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _get_nodeTypedValue(IXMLDOMDocument* pThis, [NativeTypeName("VARIANT *")] VARIANT* typedValue);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _put_nodeTypedValue(IXMLDOMDocument* pThis, VARIANT typedValue);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _get_dataType(IXMLDOMDocument* pThis, [NativeTypeName("VARIANT *")] VARIANT* dataTypeName);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _put_dataType(IXMLDOMDocument* pThis, [NativeTypeName("BSTR")] ushort* dataTypeName);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _get_xml(IXMLDOMDocument* pThis, [NativeTypeName("BSTR *")] ushort** xmlString);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _transformNode(IXMLDOMDocument* pThis, [NativeTypeName("IXMLDOMNode *")] IXMLDOMNode* stylesheet, [NativeTypeName("BSTR *")] ushort** xmlString);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _selectNodes(IXMLDOMDocument* pThis, [NativeTypeName("BSTR")] ushort* queryString, [NativeTypeName("IXMLDOMNodeList **")] IXMLDOMNodeList** resultList);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _selectSingleNode(IXMLDOMDocument* pThis, [NativeTypeName("BSTR")] ushort* queryString, [NativeTypeName("IXMLDOMNode **")] IXMLDOMNode** resultNode);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _get_parsed(IXMLDOMDocument* pThis, [NativeTypeName("VARIANT_BOOL *")] short* isParsed);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _get_namespaceURI(IXMLDOMDocument* pThis, [NativeTypeName("BSTR *")] ushort** namespaceURI);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _get_prefix(IXMLDOMDocument* pThis, [NativeTypeName("BSTR *")] ushort** prefixString);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _get_baseName(IXMLDOMDocument* pThis, [NativeTypeName("BSTR *")] ushort** nameString);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _transformNodeToObject(IXMLDOMDocument* pThis, [NativeTypeName("IXMLDOMNode *")] IXMLDOMNode* stylesheet, VARIANT outputObject);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _get_doctype(IXMLDOMDocument* pThis, [NativeTypeName("IXMLDOMDocumentType **")] IXMLDOMDocumentType** documentType);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _get_implementation(IXMLDOMDocument* pThis, [NativeTypeName("IXMLDOMImplementation **")] IXMLDOMImplementation** impl);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _get_documentElement(IXMLDOMDocument* pThis, [NativeTypeName("IXMLDOMElement **")] IXMLDOMElement** DOMElement);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _putref_documentElement(IXMLDOMDocument* pThis, [NativeTypeName("IXMLDOMElement *")] IXMLDOMElement* DOMElement);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _createElement(IXMLDOMDocument* pThis, [NativeTypeName("BSTR")] ushort* tagName, [NativeTypeName("IXMLDOMElement **")] IXMLDOMElement** element);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _createDocumentFragment(IXMLDOMDocument* pThis, [NativeTypeName("IXMLDOMDocumentFragment **")] IXMLDOMDocumentFragment** docFrag);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _createTextNode(IXMLDOMDocument* pThis, [NativeTypeName("BSTR")] ushort* data, [NativeTypeName("IXMLDOMText **")] IXMLDOMText** text);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _createComment(IXMLDOMDocument* pThis, [NativeTypeName("BSTR")] ushort* data, [NativeTypeName("IXMLDOMComment **")] IXMLDOMComment** comment);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _createCDATASection(IXMLDOMDocument* pThis, [NativeTypeName("BSTR")] ushort* data, [NativeTypeName("IXMLDOMCDATASection **")] IXMLDOMCDATASection** cdata);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _createProcessingInstruction(IXMLDOMDocument* pThis, [NativeTypeName("BSTR")] ushort* target, [NativeTypeName("BSTR")] ushort* data, [NativeTypeName("IXMLDOMProcessingInstruction **")] IXMLDOMProcessingInstruction** pi);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _createAttribute(IXMLDOMDocument* pThis, [NativeTypeName("BSTR")] ushort* name, [NativeTypeName("IXMLDOMAttribute **")] IXMLDOMAttribute** attribute);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _createEntityReference(IXMLDOMDocument* pThis, [NativeTypeName("BSTR")] ushort* name, [NativeTypeName("IXMLDOMEntityReference **")] IXMLDOMEntityReference** entityRef);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _getElementsByTagName(IXMLDOMDocument* pThis, [NativeTypeName("BSTR")] ushort* tagName, [NativeTypeName("IXMLDOMNodeList **")] IXMLDOMNodeList** resultList);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _createNode(IXMLDOMDocument* pThis, VARIANT Type, [NativeTypeName("BSTR")] ushort* name, [NativeTypeName("BSTR")] ushort* namespaceURI, [NativeTypeName("IXMLDOMNode **")] IXMLDOMNode** node);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _nodeFromID(IXMLDOMDocument* pThis, [NativeTypeName("BSTR")] ushort* idString, [NativeTypeName("IXMLDOMNode **")] IXMLDOMNode** node);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _load(IXMLDOMDocument* pThis, VARIANT xmlSource, [NativeTypeName("VARIANT_BOOL *")] short* isSuccessful);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _get_readyState(IXMLDOMDocument* pThis, [NativeTypeName("long *")] int* value);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _get_parseError(IXMLDOMDocument* pThis, [NativeTypeName("IXMLDOMParseError **")] IXMLDOMParseError** errorObj);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _get_url(IXMLDOMDocument* pThis, [NativeTypeName("BSTR *")] ushort** urlString);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _get_async(IXMLDOMDocument* pThis, [NativeTypeName("VARIANT_BOOL *")] short* isAsync);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _put_async(IXMLDOMDocument* pThis, [NativeTypeName("VARIANT_BOOL")] short isAsync);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _abort(IXMLDOMDocument* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _loadXML(IXMLDOMDocument* pThis, [NativeTypeName("BSTR")] ushort* bstrXML, [NativeTypeName("VARIANT_BOOL *")] short* isSuccessful);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _save(IXMLDOMDocument* pThis, VARIANT destination);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _get_validateOnParse(IXMLDOMDocument* pThis, [NativeTypeName("VARIANT_BOOL *")] short* isValidating);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _put_validateOnParse(IXMLDOMDocument* pThis, [NativeTypeName("VARIANT_BOOL")] short isValidating);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _get_resolveExternals(IXMLDOMDocument* pThis, [NativeTypeName("VARIANT_BOOL *")] short* isResolving);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _put_resolveExternals(IXMLDOMDocument* pThis, [NativeTypeName("VARIANT_BOOL")] short isResolving);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _get_preserveWhiteSpace(IXMLDOMDocument* pThis, [NativeTypeName("VARIANT_BOOL *")] short* isPreserving);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _put_preserveWhiteSpace(IXMLDOMDocument* pThis, [NativeTypeName("VARIANT_BOOL")] short isPreserving);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _put_onreadystatechange(IXMLDOMDocument* pThis, VARIANT readystatechangeSink);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _put_ondataavailable(IXMLDOMDocument* pThis, VARIANT ondataavailableSink);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _put_ontransformnode(IXMLDOMDocument* pThis, VARIANT ontransformnodeSink);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((IXMLDOMDocument*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((IXMLDOMDocument*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((IXMLDOMDocument*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfoCount([NativeTypeName("UINT *")] uint* pctinfo)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetTypeInfoCount>(lpVtbl->GetTypeInfoCount)((IXMLDOMDocument*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfo([NativeTypeName("UINT")] uint iTInfo, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("ITypeInfo **")] ITypeInfo** ppTInfo)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetTypeInfo>(lpVtbl->GetTypeInfo)((IXMLDOMDocument*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, [NativeTypeName("UINT")] uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetIDsOfNames>(lpVtbl->GetIDsOfNames)((IXMLDOMDocument*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [return: NativeTypeName("HRESULT")]
        public int Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, [NativeTypeName("DISPPARAMS *")] DISPPARAMS* pDispParams, [NativeTypeName("VARIANT *")] VARIANT* pVarResult, [NativeTypeName("EXCEPINFO *")] EXCEPINFO* pExcepInfo, [NativeTypeName("UINT *")] uint* puArgErr)
        {
            return Marshal.GetDelegateForFunctionPointer<_Invoke>(lpVtbl->Invoke)((IXMLDOMDocument*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_nodeName([NativeTypeName("BSTR *")] ushort** name)
        {
            return Marshal.GetDelegateForFunctionPointer<_get_nodeName>(lpVtbl->get_nodeName)((IXMLDOMDocument*)Unsafe.AsPointer(ref this), name);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_nodeValue([NativeTypeName("VARIANT *")] VARIANT* value)
        {
            return Marshal.GetDelegateForFunctionPointer<_get_nodeValue>(lpVtbl->get_nodeValue)((IXMLDOMDocument*)Unsafe.AsPointer(ref this), value);
        }

        [return: NativeTypeName("HRESULT")]
        public int put_nodeValue(VARIANT value)
        {
            return Marshal.GetDelegateForFunctionPointer<_put_nodeValue>(lpVtbl->put_nodeValue)((IXMLDOMDocument*)Unsafe.AsPointer(ref this), value);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_nodeType([NativeTypeName("DOMNodeType *")] DOMNodeType* type)
        {
            return Marshal.GetDelegateForFunctionPointer<_get_nodeType>(lpVtbl->get_nodeType)((IXMLDOMDocument*)Unsafe.AsPointer(ref this), type);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_parentNode([NativeTypeName("IXMLDOMNode **")] IXMLDOMNode** parent)
        {
            return Marshal.GetDelegateForFunctionPointer<_get_parentNode>(lpVtbl->get_parentNode)((IXMLDOMDocument*)Unsafe.AsPointer(ref this), parent);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_childNodes([NativeTypeName("IXMLDOMNodeList **")] IXMLDOMNodeList** childList)
        {
            return Marshal.GetDelegateForFunctionPointer<_get_childNodes>(lpVtbl->get_childNodes)((IXMLDOMDocument*)Unsafe.AsPointer(ref this), childList);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_firstChild([NativeTypeName("IXMLDOMNode **")] IXMLDOMNode** firstChild)
        {
            return Marshal.GetDelegateForFunctionPointer<_get_firstChild>(lpVtbl->get_firstChild)((IXMLDOMDocument*)Unsafe.AsPointer(ref this), firstChild);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_lastChild([NativeTypeName("IXMLDOMNode **")] IXMLDOMNode** lastChild)
        {
            return Marshal.GetDelegateForFunctionPointer<_get_lastChild>(lpVtbl->get_lastChild)((IXMLDOMDocument*)Unsafe.AsPointer(ref this), lastChild);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_previousSibling([NativeTypeName("IXMLDOMNode **")] IXMLDOMNode** previousSibling)
        {
            return Marshal.GetDelegateForFunctionPointer<_get_previousSibling>(lpVtbl->get_previousSibling)((IXMLDOMDocument*)Unsafe.AsPointer(ref this), previousSibling);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_nextSibling([NativeTypeName("IXMLDOMNode **")] IXMLDOMNode** nextSibling)
        {
            return Marshal.GetDelegateForFunctionPointer<_get_nextSibling>(lpVtbl->get_nextSibling)((IXMLDOMDocument*)Unsafe.AsPointer(ref this), nextSibling);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_attributes([NativeTypeName("IXMLDOMNamedNodeMap **")] IXMLDOMNamedNodeMap** attributeMap)
        {
            return Marshal.GetDelegateForFunctionPointer<_get_attributes>(lpVtbl->get_attributes)((IXMLDOMDocument*)Unsafe.AsPointer(ref this), attributeMap);
        }

        [return: NativeTypeName("HRESULT")]
        public int insertBefore([NativeTypeName("IXMLDOMNode *")] IXMLDOMNode* newChild, VARIANT refChild, [NativeTypeName("IXMLDOMNode **")] IXMLDOMNode** outNewChild)
        {
            return Marshal.GetDelegateForFunctionPointer<_insertBefore>(lpVtbl->insertBefore)((IXMLDOMDocument*)Unsafe.AsPointer(ref this), newChild, refChild, outNewChild);
        }

        [return: NativeTypeName("HRESULT")]
        public int replaceChild([NativeTypeName("IXMLDOMNode *")] IXMLDOMNode* newChild, [NativeTypeName("IXMLDOMNode *")] IXMLDOMNode* oldChild, [NativeTypeName("IXMLDOMNode **")] IXMLDOMNode** outOldChild)
        {
            return Marshal.GetDelegateForFunctionPointer<_replaceChild>(lpVtbl->replaceChild)((IXMLDOMDocument*)Unsafe.AsPointer(ref this), newChild, oldChild, outOldChild);
        }

        [return: NativeTypeName("HRESULT")]
        public int removeChild([NativeTypeName("IXMLDOMNode *")] IXMLDOMNode* childNode, [NativeTypeName("IXMLDOMNode **")] IXMLDOMNode** oldChild)
        {
            return Marshal.GetDelegateForFunctionPointer<_removeChild>(lpVtbl->removeChild)((IXMLDOMDocument*)Unsafe.AsPointer(ref this), childNode, oldChild);
        }

        [return: NativeTypeName("HRESULT")]
        public int appendChild([NativeTypeName("IXMLDOMNode *")] IXMLDOMNode* newChild, [NativeTypeName("IXMLDOMNode **")] IXMLDOMNode** outNewChild)
        {
            return Marshal.GetDelegateForFunctionPointer<_appendChild>(lpVtbl->appendChild)((IXMLDOMDocument*)Unsafe.AsPointer(ref this), newChild, outNewChild);
        }

        [return: NativeTypeName("HRESULT")]
        public int hasChildNodes([NativeTypeName("VARIANT_BOOL *")] short* hasChild)
        {
            return Marshal.GetDelegateForFunctionPointer<_hasChildNodes>(lpVtbl->hasChildNodes)((IXMLDOMDocument*)Unsafe.AsPointer(ref this), hasChild);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_ownerDocument([NativeTypeName("IXMLDOMDocument **")] IXMLDOMDocument** XMLDOMDocument)
        {
            return Marshal.GetDelegateForFunctionPointer<_get_ownerDocument>(lpVtbl->get_ownerDocument)((IXMLDOMDocument*)Unsafe.AsPointer(ref this), XMLDOMDocument);
        }

        [return: NativeTypeName("HRESULT")]
        public int cloneNode([NativeTypeName("VARIANT_BOOL")] short deep, [NativeTypeName("IXMLDOMNode **")] IXMLDOMNode** cloneRoot)
        {
            return Marshal.GetDelegateForFunctionPointer<_cloneNode>(lpVtbl->cloneNode)((IXMLDOMDocument*)Unsafe.AsPointer(ref this), deep, cloneRoot);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_nodeTypeString([NativeTypeName("BSTR *")] ushort** nodeType)
        {
            return Marshal.GetDelegateForFunctionPointer<_get_nodeTypeString>(lpVtbl->get_nodeTypeString)((IXMLDOMDocument*)Unsafe.AsPointer(ref this), nodeType);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_text([NativeTypeName("BSTR *")] ushort** text)
        {
            return Marshal.GetDelegateForFunctionPointer<_get_text>(lpVtbl->get_text)((IXMLDOMDocument*)Unsafe.AsPointer(ref this), text);
        }

        [return: NativeTypeName("HRESULT")]
        public int put_text([NativeTypeName("BSTR")] ushort* text)
        {
            return Marshal.GetDelegateForFunctionPointer<_put_text>(lpVtbl->put_text)((IXMLDOMDocument*)Unsafe.AsPointer(ref this), text);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_specified([NativeTypeName("VARIANT_BOOL *")] short* isSpecified)
        {
            return Marshal.GetDelegateForFunctionPointer<_get_specified>(lpVtbl->get_specified)((IXMLDOMDocument*)Unsafe.AsPointer(ref this), isSpecified);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_definition([NativeTypeName("IXMLDOMNode **")] IXMLDOMNode** definitionNode)
        {
            return Marshal.GetDelegateForFunctionPointer<_get_definition>(lpVtbl->get_definition)((IXMLDOMDocument*)Unsafe.AsPointer(ref this), definitionNode);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_nodeTypedValue([NativeTypeName("VARIANT *")] VARIANT* typedValue)
        {
            return Marshal.GetDelegateForFunctionPointer<_get_nodeTypedValue>(lpVtbl->get_nodeTypedValue)((IXMLDOMDocument*)Unsafe.AsPointer(ref this), typedValue);
        }

        [return: NativeTypeName("HRESULT")]
        public int put_nodeTypedValue(VARIANT typedValue)
        {
            return Marshal.GetDelegateForFunctionPointer<_put_nodeTypedValue>(lpVtbl->put_nodeTypedValue)((IXMLDOMDocument*)Unsafe.AsPointer(ref this), typedValue);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_dataType([NativeTypeName("VARIANT *")] VARIANT* dataTypeName)
        {
            return Marshal.GetDelegateForFunctionPointer<_get_dataType>(lpVtbl->get_dataType)((IXMLDOMDocument*)Unsafe.AsPointer(ref this), dataTypeName);
        }

        [return: NativeTypeName("HRESULT")]
        public int put_dataType([NativeTypeName("BSTR")] ushort* dataTypeName)
        {
            return Marshal.GetDelegateForFunctionPointer<_put_dataType>(lpVtbl->put_dataType)((IXMLDOMDocument*)Unsafe.AsPointer(ref this), dataTypeName);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_xml([NativeTypeName("BSTR *")] ushort** xmlString)
        {
            return Marshal.GetDelegateForFunctionPointer<_get_xml>(lpVtbl->get_xml)((IXMLDOMDocument*)Unsafe.AsPointer(ref this), xmlString);
        }

        [return: NativeTypeName("HRESULT")]
        public int transformNode([NativeTypeName("IXMLDOMNode *")] IXMLDOMNode* stylesheet, [NativeTypeName("BSTR *")] ushort** xmlString)
        {
            return Marshal.GetDelegateForFunctionPointer<_transformNode>(lpVtbl->transformNode)((IXMLDOMDocument*)Unsafe.AsPointer(ref this), stylesheet, xmlString);
        }

        [return: NativeTypeName("HRESULT")]
        public int selectNodes([NativeTypeName("BSTR")] ushort* queryString, [NativeTypeName("IXMLDOMNodeList **")] IXMLDOMNodeList** resultList)
        {
            return Marshal.GetDelegateForFunctionPointer<_selectNodes>(lpVtbl->selectNodes)((IXMLDOMDocument*)Unsafe.AsPointer(ref this), queryString, resultList);
        }

        [return: NativeTypeName("HRESULT")]
        public int selectSingleNode([NativeTypeName("BSTR")] ushort* queryString, [NativeTypeName("IXMLDOMNode **")] IXMLDOMNode** resultNode)
        {
            return Marshal.GetDelegateForFunctionPointer<_selectSingleNode>(lpVtbl->selectSingleNode)((IXMLDOMDocument*)Unsafe.AsPointer(ref this), queryString, resultNode);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_parsed([NativeTypeName("VARIANT_BOOL *")] short* isParsed)
        {
            return Marshal.GetDelegateForFunctionPointer<_get_parsed>(lpVtbl->get_parsed)((IXMLDOMDocument*)Unsafe.AsPointer(ref this), isParsed);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_namespaceURI([NativeTypeName("BSTR *")] ushort** namespaceURI)
        {
            return Marshal.GetDelegateForFunctionPointer<_get_namespaceURI>(lpVtbl->get_namespaceURI)((IXMLDOMDocument*)Unsafe.AsPointer(ref this), namespaceURI);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_prefix([NativeTypeName("BSTR *")] ushort** prefixString)
        {
            return Marshal.GetDelegateForFunctionPointer<_get_prefix>(lpVtbl->get_prefix)((IXMLDOMDocument*)Unsafe.AsPointer(ref this), prefixString);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_baseName([NativeTypeName("BSTR *")] ushort** nameString)
        {
            return Marshal.GetDelegateForFunctionPointer<_get_baseName>(lpVtbl->get_baseName)((IXMLDOMDocument*)Unsafe.AsPointer(ref this), nameString);
        }

        [return: NativeTypeName("HRESULT")]
        public int transformNodeToObject([NativeTypeName("IXMLDOMNode *")] IXMLDOMNode* stylesheet, VARIANT outputObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_transformNodeToObject>(lpVtbl->transformNodeToObject)((IXMLDOMDocument*)Unsafe.AsPointer(ref this), stylesheet, outputObject);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_doctype([NativeTypeName("IXMLDOMDocumentType **")] IXMLDOMDocumentType** documentType)
        {
            return Marshal.GetDelegateForFunctionPointer<_get_doctype>(lpVtbl->get_doctype)((IXMLDOMDocument*)Unsafe.AsPointer(ref this), documentType);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_implementation([NativeTypeName("IXMLDOMImplementation **")] IXMLDOMImplementation** impl)
        {
            return Marshal.GetDelegateForFunctionPointer<_get_implementation>(lpVtbl->get_implementation)((IXMLDOMDocument*)Unsafe.AsPointer(ref this), impl);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_documentElement([NativeTypeName("IXMLDOMElement **")] IXMLDOMElement** DOMElement)
        {
            return Marshal.GetDelegateForFunctionPointer<_get_documentElement>(lpVtbl->get_documentElement)((IXMLDOMDocument*)Unsafe.AsPointer(ref this), DOMElement);
        }

        [return: NativeTypeName("HRESULT")]
        public int putref_documentElement([NativeTypeName("IXMLDOMElement *")] IXMLDOMElement* DOMElement)
        {
            return Marshal.GetDelegateForFunctionPointer<_putref_documentElement>(lpVtbl->putref_documentElement)((IXMLDOMDocument*)Unsafe.AsPointer(ref this), DOMElement);
        }

        [return: NativeTypeName("HRESULT")]
        public int createElement([NativeTypeName("BSTR")] ushort* tagName, [NativeTypeName("IXMLDOMElement **")] IXMLDOMElement** element)
        {
            return Marshal.GetDelegateForFunctionPointer<_createElement>(lpVtbl->createElement)((IXMLDOMDocument*)Unsafe.AsPointer(ref this), tagName, element);
        }

        [return: NativeTypeName("HRESULT")]
        public int createDocumentFragment([NativeTypeName("IXMLDOMDocumentFragment **")] IXMLDOMDocumentFragment** docFrag)
        {
            return Marshal.GetDelegateForFunctionPointer<_createDocumentFragment>(lpVtbl->createDocumentFragment)((IXMLDOMDocument*)Unsafe.AsPointer(ref this), docFrag);
        }

        [return: NativeTypeName("HRESULT")]
        public int createTextNode([NativeTypeName("BSTR")] ushort* data, [NativeTypeName("IXMLDOMText **")] IXMLDOMText** text)
        {
            return Marshal.GetDelegateForFunctionPointer<_createTextNode>(lpVtbl->createTextNode)((IXMLDOMDocument*)Unsafe.AsPointer(ref this), data, text);
        }

        [return: NativeTypeName("HRESULT")]
        public int createComment([NativeTypeName("BSTR")] ushort* data, [NativeTypeName("IXMLDOMComment **")] IXMLDOMComment** comment)
        {
            return Marshal.GetDelegateForFunctionPointer<_createComment>(lpVtbl->createComment)((IXMLDOMDocument*)Unsafe.AsPointer(ref this), data, comment);
        }

        [return: NativeTypeName("HRESULT")]
        public int createCDATASection([NativeTypeName("BSTR")] ushort* data, [NativeTypeName("IXMLDOMCDATASection **")] IXMLDOMCDATASection** cdata)
        {
            return Marshal.GetDelegateForFunctionPointer<_createCDATASection>(lpVtbl->createCDATASection)((IXMLDOMDocument*)Unsafe.AsPointer(ref this), data, cdata);
        }

        [return: NativeTypeName("HRESULT")]
        public int createProcessingInstruction([NativeTypeName("BSTR")] ushort* target, [NativeTypeName("BSTR")] ushort* data, [NativeTypeName("IXMLDOMProcessingInstruction **")] IXMLDOMProcessingInstruction** pi)
        {
            return Marshal.GetDelegateForFunctionPointer<_createProcessingInstruction>(lpVtbl->createProcessingInstruction)((IXMLDOMDocument*)Unsafe.AsPointer(ref this), target, data, pi);
        }

        [return: NativeTypeName("HRESULT")]
        public int createAttribute([NativeTypeName("BSTR")] ushort* name, [NativeTypeName("IXMLDOMAttribute **")] IXMLDOMAttribute** attribute)
        {
            return Marshal.GetDelegateForFunctionPointer<_createAttribute>(lpVtbl->createAttribute)((IXMLDOMDocument*)Unsafe.AsPointer(ref this), name, attribute);
        }

        [return: NativeTypeName("HRESULT")]
        public int createEntityReference([NativeTypeName("BSTR")] ushort* name, [NativeTypeName("IXMLDOMEntityReference **")] IXMLDOMEntityReference** entityRef)
        {
            return Marshal.GetDelegateForFunctionPointer<_createEntityReference>(lpVtbl->createEntityReference)((IXMLDOMDocument*)Unsafe.AsPointer(ref this), name, entityRef);
        }

        [return: NativeTypeName("HRESULT")]
        public int getElementsByTagName([NativeTypeName("BSTR")] ushort* tagName, [NativeTypeName("IXMLDOMNodeList **")] IXMLDOMNodeList** resultList)
        {
            return Marshal.GetDelegateForFunctionPointer<_getElementsByTagName>(lpVtbl->getElementsByTagName)((IXMLDOMDocument*)Unsafe.AsPointer(ref this), tagName, resultList);
        }

        [return: NativeTypeName("HRESULT")]
        public int createNode(VARIANT Type, [NativeTypeName("BSTR")] ushort* name, [NativeTypeName("BSTR")] ushort* namespaceURI, [NativeTypeName("IXMLDOMNode **")] IXMLDOMNode** node)
        {
            return Marshal.GetDelegateForFunctionPointer<_createNode>(lpVtbl->createNode)((IXMLDOMDocument*)Unsafe.AsPointer(ref this), Type, name, namespaceURI, node);
        }

        [return: NativeTypeName("HRESULT")]
        public int nodeFromID([NativeTypeName("BSTR")] ushort* idString, [NativeTypeName("IXMLDOMNode **")] IXMLDOMNode** node)
        {
            return Marshal.GetDelegateForFunctionPointer<_nodeFromID>(lpVtbl->nodeFromID)((IXMLDOMDocument*)Unsafe.AsPointer(ref this), idString, node);
        }

        [return: NativeTypeName("HRESULT")]
        public int load(VARIANT xmlSource, [NativeTypeName("VARIANT_BOOL *")] short* isSuccessful)
        {
            return Marshal.GetDelegateForFunctionPointer<_load>(lpVtbl->load)((IXMLDOMDocument*)Unsafe.AsPointer(ref this), xmlSource, isSuccessful);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_readyState([NativeTypeName("long *")] int* value)
        {
            return Marshal.GetDelegateForFunctionPointer<_get_readyState>(lpVtbl->get_readyState)((IXMLDOMDocument*)Unsafe.AsPointer(ref this), value);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_parseError([NativeTypeName("IXMLDOMParseError **")] IXMLDOMParseError** errorObj)
        {
            return Marshal.GetDelegateForFunctionPointer<_get_parseError>(lpVtbl->get_parseError)((IXMLDOMDocument*)Unsafe.AsPointer(ref this), errorObj);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_url([NativeTypeName("BSTR *")] ushort** urlString)
        {
            return Marshal.GetDelegateForFunctionPointer<_get_url>(lpVtbl->get_url)((IXMLDOMDocument*)Unsafe.AsPointer(ref this), urlString);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_async([NativeTypeName("VARIANT_BOOL *")] short* isAsync)
        {
            return Marshal.GetDelegateForFunctionPointer<_get_async>(lpVtbl->get_async)((IXMLDOMDocument*)Unsafe.AsPointer(ref this), isAsync);
        }

        [return: NativeTypeName("HRESULT")]
        public int put_async([NativeTypeName("VARIANT_BOOL")] short isAsync)
        {
            return Marshal.GetDelegateForFunctionPointer<_put_async>(lpVtbl->put_async)((IXMLDOMDocument*)Unsafe.AsPointer(ref this), isAsync);
        }

        [return: NativeTypeName("HRESULT")]
        public int abort()
        {
            return Marshal.GetDelegateForFunctionPointer<_abort>(lpVtbl->abort)((IXMLDOMDocument*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int loadXML([NativeTypeName("BSTR")] ushort* bstrXML, [NativeTypeName("VARIANT_BOOL *")] short* isSuccessful)
        {
            return Marshal.GetDelegateForFunctionPointer<_loadXML>(lpVtbl->loadXML)((IXMLDOMDocument*)Unsafe.AsPointer(ref this), bstrXML, isSuccessful);
        }

        [return: NativeTypeName("HRESULT")]
        public int save(VARIANT destination)
        {
            return Marshal.GetDelegateForFunctionPointer<_save>(lpVtbl->save)((IXMLDOMDocument*)Unsafe.AsPointer(ref this), destination);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_validateOnParse([NativeTypeName("VARIANT_BOOL *")] short* isValidating)
        {
            return Marshal.GetDelegateForFunctionPointer<_get_validateOnParse>(lpVtbl->get_validateOnParse)((IXMLDOMDocument*)Unsafe.AsPointer(ref this), isValidating);
        }

        [return: NativeTypeName("HRESULT")]
        public int put_validateOnParse([NativeTypeName("VARIANT_BOOL")] short isValidating)
        {
            return Marshal.GetDelegateForFunctionPointer<_put_validateOnParse>(lpVtbl->put_validateOnParse)((IXMLDOMDocument*)Unsafe.AsPointer(ref this), isValidating);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_resolveExternals([NativeTypeName("VARIANT_BOOL *")] short* isResolving)
        {
            return Marshal.GetDelegateForFunctionPointer<_get_resolveExternals>(lpVtbl->get_resolveExternals)((IXMLDOMDocument*)Unsafe.AsPointer(ref this), isResolving);
        }

        [return: NativeTypeName("HRESULT")]
        public int put_resolveExternals([NativeTypeName("VARIANT_BOOL")] short isResolving)
        {
            return Marshal.GetDelegateForFunctionPointer<_put_resolveExternals>(lpVtbl->put_resolveExternals)((IXMLDOMDocument*)Unsafe.AsPointer(ref this), isResolving);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_preserveWhiteSpace([NativeTypeName("VARIANT_BOOL *")] short* isPreserving)
        {
            return Marshal.GetDelegateForFunctionPointer<_get_preserveWhiteSpace>(lpVtbl->get_preserveWhiteSpace)((IXMLDOMDocument*)Unsafe.AsPointer(ref this), isPreserving);
        }

        [return: NativeTypeName("HRESULT")]
        public int put_preserveWhiteSpace([NativeTypeName("VARIANT_BOOL")] short isPreserving)
        {
            return Marshal.GetDelegateForFunctionPointer<_put_preserveWhiteSpace>(lpVtbl->put_preserveWhiteSpace)((IXMLDOMDocument*)Unsafe.AsPointer(ref this), isPreserving);
        }

        [return: NativeTypeName("HRESULT")]
        public int put_onreadystatechange(VARIANT readystatechangeSink)
        {
            return Marshal.GetDelegateForFunctionPointer<_put_onreadystatechange>(lpVtbl->put_onreadystatechange)((IXMLDOMDocument*)Unsafe.AsPointer(ref this), readystatechangeSink);
        }

        [return: NativeTypeName("HRESULT")]
        public int put_ondataavailable(VARIANT ondataavailableSink)
        {
            return Marshal.GetDelegateForFunctionPointer<_put_ondataavailable>(lpVtbl->put_ondataavailable)((IXMLDOMDocument*)Unsafe.AsPointer(ref this), ondataavailableSink);
        }

        [return: NativeTypeName("HRESULT")]
        public int put_ontransformnode(VARIANT ontransformnodeSink)
        {
            return Marshal.GetDelegateForFunctionPointer<_put_ontransformnode>(lpVtbl->put_ontransformnode)((IXMLDOMDocument*)Unsafe.AsPointer(ref this), ontransformnodeSink);
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

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public IntPtr get_nodeName;

            [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
            public IntPtr get_nodeValue;

            [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
            public IntPtr put_nodeValue;

            [NativeTypeName("HRESULT (DOMNodeType *) __attribute__((stdcall))")]
            public IntPtr get_nodeType;

            [NativeTypeName("HRESULT (IXMLDOMNode **) __attribute__((stdcall))")]
            public IntPtr get_parentNode;

            [NativeTypeName("HRESULT (IXMLDOMNodeList **) __attribute__((stdcall))")]
            public IntPtr get_childNodes;

            [NativeTypeName("HRESULT (IXMLDOMNode **) __attribute__((stdcall))")]
            public IntPtr get_firstChild;

            [NativeTypeName("HRESULT (IXMLDOMNode **) __attribute__((stdcall))")]
            public IntPtr get_lastChild;

            [NativeTypeName("HRESULT (IXMLDOMNode **) __attribute__((stdcall))")]
            public IntPtr get_previousSibling;

            [NativeTypeName("HRESULT (IXMLDOMNode **) __attribute__((stdcall))")]
            public IntPtr get_nextSibling;

            [NativeTypeName("HRESULT (IXMLDOMNamedNodeMap **) __attribute__((stdcall))")]
            public IntPtr get_attributes;

            [NativeTypeName("HRESULT (IXMLDOMNode *, VARIANT, IXMLDOMNode **) __attribute__((stdcall))")]
            public IntPtr insertBefore;

            [NativeTypeName("HRESULT (IXMLDOMNode *, IXMLDOMNode *, IXMLDOMNode **) __attribute__((stdcall))")]
            public IntPtr replaceChild;

            [NativeTypeName("HRESULT (IXMLDOMNode *, IXMLDOMNode **) __attribute__((stdcall))")]
            public IntPtr removeChild;

            [NativeTypeName("HRESULT (IXMLDOMNode *, IXMLDOMNode **) __attribute__((stdcall))")]
            public IntPtr appendChild;

            [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
            public IntPtr hasChildNodes;

            [NativeTypeName("HRESULT (IXMLDOMDocument **) __attribute__((stdcall))")]
            public IntPtr get_ownerDocument;

            [NativeTypeName("HRESULT (VARIANT_BOOL, IXMLDOMNode **) __attribute__((stdcall))")]
            public IntPtr cloneNode;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public IntPtr get_nodeTypeString;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public IntPtr get_text;

            [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
            public IntPtr put_text;

            [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
            public IntPtr get_specified;

            [NativeTypeName("HRESULT (IXMLDOMNode **) __attribute__((stdcall))")]
            public IntPtr get_definition;

            [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
            public IntPtr get_nodeTypedValue;

            [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
            public IntPtr put_nodeTypedValue;

            [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
            public IntPtr get_dataType;

            [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
            public IntPtr put_dataType;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public IntPtr get_xml;

            [NativeTypeName("HRESULT (IXMLDOMNode *, BSTR *) __attribute__((stdcall))")]
            public IntPtr transformNode;

            [NativeTypeName("HRESULT (BSTR, IXMLDOMNodeList **) __attribute__((stdcall))")]
            public IntPtr selectNodes;

            [NativeTypeName("HRESULT (BSTR, IXMLDOMNode **) __attribute__((stdcall))")]
            public IntPtr selectSingleNode;

            [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
            public IntPtr get_parsed;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public IntPtr get_namespaceURI;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public IntPtr get_prefix;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public IntPtr get_baseName;

            [NativeTypeName("HRESULT (IXMLDOMNode *, VARIANT) __attribute__((stdcall))")]
            public IntPtr transformNodeToObject;

            [NativeTypeName("HRESULT (IXMLDOMDocumentType **) __attribute__((stdcall))")]
            public IntPtr get_doctype;

            [NativeTypeName("HRESULT (IXMLDOMImplementation **) __attribute__((stdcall))")]
            public IntPtr get_implementation;

            [NativeTypeName("HRESULT (IXMLDOMElement **) __attribute__((stdcall))")]
            public IntPtr get_documentElement;

            [NativeTypeName("HRESULT (IXMLDOMElement *) __attribute__((stdcall))")]
            public IntPtr putref_documentElement;

            [NativeTypeName("HRESULT (BSTR, IXMLDOMElement **) __attribute__((stdcall))")]
            public IntPtr createElement;

            [NativeTypeName("HRESULT (IXMLDOMDocumentFragment **) __attribute__((stdcall))")]
            public IntPtr createDocumentFragment;

            [NativeTypeName("HRESULT (BSTR, IXMLDOMText **) __attribute__((stdcall))")]
            public IntPtr createTextNode;

            [NativeTypeName("HRESULT (BSTR, IXMLDOMComment **) __attribute__((stdcall))")]
            public IntPtr createComment;

            [NativeTypeName("HRESULT (BSTR, IXMLDOMCDATASection **) __attribute__((stdcall))")]
            public IntPtr createCDATASection;

            [NativeTypeName("HRESULT (BSTR, BSTR, IXMLDOMProcessingInstruction **) __attribute__((stdcall))")]
            public IntPtr createProcessingInstruction;

            [NativeTypeName("HRESULT (BSTR, IXMLDOMAttribute **) __attribute__((stdcall))")]
            public IntPtr createAttribute;

            [NativeTypeName("HRESULT (BSTR, IXMLDOMEntityReference **) __attribute__((stdcall))")]
            public IntPtr createEntityReference;

            [NativeTypeName("HRESULT (BSTR, IXMLDOMNodeList **) __attribute__((stdcall))")]
            public IntPtr getElementsByTagName;

            [NativeTypeName("HRESULT (VARIANT, BSTR, BSTR, IXMLDOMNode **) __attribute__((stdcall))")]
            public IntPtr createNode;

            [NativeTypeName("HRESULT (BSTR, IXMLDOMNode **) __attribute__((stdcall))")]
            public IntPtr nodeFromID;

            [NativeTypeName("HRESULT (VARIANT, VARIANT_BOOL *) __attribute__((stdcall))")]
            public IntPtr load;

            [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
            public IntPtr get_readyState;

            [NativeTypeName("HRESULT (IXMLDOMParseError **) __attribute__((stdcall))")]
            public IntPtr get_parseError;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public IntPtr get_url;

            [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
            public IntPtr get_async;

            [NativeTypeName("HRESULT (VARIANT_BOOL) __attribute__((stdcall))")]
            public IntPtr put_async;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public IntPtr abort;

            [NativeTypeName("HRESULT (BSTR, VARIANT_BOOL *) __attribute__((stdcall))")]
            public IntPtr loadXML;

            [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
            public IntPtr save;

            [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
            public IntPtr get_validateOnParse;

            [NativeTypeName("HRESULT (VARIANT_BOOL) __attribute__((stdcall))")]
            public IntPtr put_validateOnParse;

            [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
            public IntPtr get_resolveExternals;

            [NativeTypeName("HRESULT (VARIANT_BOOL) __attribute__((stdcall))")]
            public IntPtr put_resolveExternals;

            [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
            public IntPtr get_preserveWhiteSpace;

            [NativeTypeName("HRESULT (VARIANT_BOOL) __attribute__((stdcall))")]
            public IntPtr put_preserveWhiteSpace;

            [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
            public IntPtr put_onreadystatechange;

            [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
            public IntPtr put_ondataavailable;

            [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
            public IntPtr put_ontransformnode;
        }
    }
}
