// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/msxml.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("2933BF85-7B36-11D2-B20E-00C04F983E60")]
    [NativeTypeName("struct IXMLDOMAttribute : IXMLDOMNode")]
    [NativeInheritance("IXMLDOMNode")]
    public unsafe partial struct IXMLDOMAttribute : IXMLDOMAttribute.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IXMLDOMAttribute*, Guid*, void**, int>)(lpVtbl[0]))((IXMLDOMAttribute*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IXMLDOMAttribute*, uint>)(lpVtbl[1]))((IXMLDOMAttribute*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IXMLDOMAttribute*, uint>)(lpVtbl[2]))((IXMLDOMAttribute*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetTypeInfoCount(uint* pctinfo)
        {
            return ((delegate* unmanaged<IXMLDOMAttribute*, uint*, int>)(lpVtbl[3]))((IXMLDOMAttribute*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<IXMLDOMAttribute*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IXMLDOMAttribute*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<IXMLDOMAttribute*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IXMLDOMAttribute*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
        {
            return ((delegate* unmanaged<IXMLDOMAttribute*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IXMLDOMAttribute*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT get_nodeName([NativeTypeName("BSTR *")] ushort** name)
        {
            return ((delegate* unmanaged<IXMLDOMAttribute*, ushort**, int>)(lpVtbl[7]))((IXMLDOMAttribute*)Unsafe.AsPointer(ref this), name);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT get_nodeValue(VARIANT* value)
        {
            return ((delegate* unmanaged<IXMLDOMAttribute*, VARIANT*, int>)(lpVtbl[8]))((IXMLDOMAttribute*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT put_nodeValue(VARIANT value)
        {
            return ((delegate* unmanaged<IXMLDOMAttribute*, VARIANT, int>)(lpVtbl[9]))((IXMLDOMAttribute*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT get_nodeType(DOMNodeType* type)
        {
            return ((delegate* unmanaged<IXMLDOMAttribute*, DOMNodeType*, int>)(lpVtbl[10]))((IXMLDOMAttribute*)Unsafe.AsPointer(ref this), type);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT get_parentNode(IXMLDOMNode** parent)
        {
            return ((delegate* unmanaged<IXMLDOMAttribute*, IXMLDOMNode**, int>)(lpVtbl[11]))((IXMLDOMAttribute*)Unsafe.AsPointer(ref this), parent);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT get_childNodes(IXMLDOMNodeList** childList)
        {
            return ((delegate* unmanaged<IXMLDOMAttribute*, IXMLDOMNodeList**, int>)(lpVtbl[12]))((IXMLDOMAttribute*)Unsafe.AsPointer(ref this), childList);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT get_firstChild(IXMLDOMNode** firstChild)
        {
            return ((delegate* unmanaged<IXMLDOMAttribute*, IXMLDOMNode**, int>)(lpVtbl[13]))((IXMLDOMAttribute*)Unsafe.AsPointer(ref this), firstChild);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HRESULT get_lastChild(IXMLDOMNode** lastChild)
        {
            return ((delegate* unmanaged<IXMLDOMAttribute*, IXMLDOMNode**, int>)(lpVtbl[14]))((IXMLDOMAttribute*)Unsafe.AsPointer(ref this), lastChild);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public HRESULT get_previousSibling(IXMLDOMNode** previousSibling)
        {
            return ((delegate* unmanaged<IXMLDOMAttribute*, IXMLDOMNode**, int>)(lpVtbl[15]))((IXMLDOMAttribute*)Unsafe.AsPointer(ref this), previousSibling);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        public HRESULT get_nextSibling(IXMLDOMNode** nextSibling)
        {
            return ((delegate* unmanaged<IXMLDOMAttribute*, IXMLDOMNode**, int>)(lpVtbl[16]))((IXMLDOMAttribute*)Unsafe.AsPointer(ref this), nextSibling);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        public HRESULT get_attributes(IXMLDOMNamedNodeMap** attributeMap)
        {
            return ((delegate* unmanaged<IXMLDOMAttribute*, IXMLDOMNamedNodeMap**, int>)(lpVtbl[17]))((IXMLDOMAttribute*)Unsafe.AsPointer(ref this), attributeMap);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        public HRESULT insertBefore(IXMLDOMNode* newChild, VARIANT refChild, IXMLDOMNode** outNewChild)
        {
            return ((delegate* unmanaged<IXMLDOMAttribute*, IXMLDOMNode*, VARIANT, IXMLDOMNode**, int>)(lpVtbl[18]))((IXMLDOMAttribute*)Unsafe.AsPointer(ref this), newChild, refChild, outNewChild);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        public HRESULT replaceChild(IXMLDOMNode* newChild, IXMLDOMNode* oldChild, IXMLDOMNode** outOldChild)
        {
            return ((delegate* unmanaged<IXMLDOMAttribute*, IXMLDOMNode*, IXMLDOMNode*, IXMLDOMNode**, int>)(lpVtbl[19]))((IXMLDOMAttribute*)Unsafe.AsPointer(ref this), newChild, oldChild, outOldChild);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        public HRESULT removeChild(IXMLDOMNode* childNode, IXMLDOMNode** oldChild)
        {
            return ((delegate* unmanaged<IXMLDOMAttribute*, IXMLDOMNode*, IXMLDOMNode**, int>)(lpVtbl[20]))((IXMLDOMAttribute*)Unsafe.AsPointer(ref this), childNode, oldChild);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        public HRESULT appendChild(IXMLDOMNode* newChild, IXMLDOMNode** outNewChild)
        {
            return ((delegate* unmanaged<IXMLDOMAttribute*, IXMLDOMNode*, IXMLDOMNode**, int>)(lpVtbl[21]))((IXMLDOMAttribute*)Unsafe.AsPointer(ref this), newChild, outNewChild);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(22)]
        public HRESULT hasChildNodes([NativeTypeName("VARIANT_BOOL *")] short* hasChild)
        {
            return ((delegate* unmanaged<IXMLDOMAttribute*, short*, int>)(lpVtbl[22]))((IXMLDOMAttribute*)Unsafe.AsPointer(ref this), hasChild);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(23)]
        public HRESULT get_ownerDocument(IXMLDOMDocument** XMLDOMDocument)
        {
            return ((delegate* unmanaged<IXMLDOMAttribute*, IXMLDOMDocument**, int>)(lpVtbl[23]))((IXMLDOMAttribute*)Unsafe.AsPointer(ref this), XMLDOMDocument);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(24)]
        public HRESULT cloneNode([NativeTypeName("VARIANT_BOOL")] short deep, IXMLDOMNode** cloneRoot)
        {
            return ((delegate* unmanaged<IXMLDOMAttribute*, short, IXMLDOMNode**, int>)(lpVtbl[24]))((IXMLDOMAttribute*)Unsafe.AsPointer(ref this), deep, cloneRoot);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(25)]
        public HRESULT get_nodeTypeString([NativeTypeName("BSTR *")] ushort** nodeType)
        {
            return ((delegate* unmanaged<IXMLDOMAttribute*, ushort**, int>)(lpVtbl[25]))((IXMLDOMAttribute*)Unsafe.AsPointer(ref this), nodeType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(26)]
        public HRESULT get_text([NativeTypeName("BSTR *")] ushort** text)
        {
            return ((delegate* unmanaged<IXMLDOMAttribute*, ushort**, int>)(lpVtbl[26]))((IXMLDOMAttribute*)Unsafe.AsPointer(ref this), text);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(27)]
        public HRESULT put_text([NativeTypeName("BSTR")] ushort* text)
        {
            return ((delegate* unmanaged<IXMLDOMAttribute*, ushort*, int>)(lpVtbl[27]))((IXMLDOMAttribute*)Unsafe.AsPointer(ref this), text);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(28)]
        public HRESULT get_specified([NativeTypeName("VARIANT_BOOL *")] short* isSpecified)
        {
            return ((delegate* unmanaged<IXMLDOMAttribute*, short*, int>)(lpVtbl[28]))((IXMLDOMAttribute*)Unsafe.AsPointer(ref this), isSpecified);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(29)]
        public HRESULT get_definition(IXMLDOMNode** definitionNode)
        {
            return ((delegate* unmanaged<IXMLDOMAttribute*, IXMLDOMNode**, int>)(lpVtbl[29]))((IXMLDOMAttribute*)Unsafe.AsPointer(ref this), definitionNode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(30)]
        public HRESULT get_nodeTypedValue(VARIANT* typedValue)
        {
            return ((delegate* unmanaged<IXMLDOMAttribute*, VARIANT*, int>)(lpVtbl[30]))((IXMLDOMAttribute*)Unsafe.AsPointer(ref this), typedValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(31)]
        public HRESULT put_nodeTypedValue(VARIANT typedValue)
        {
            return ((delegate* unmanaged<IXMLDOMAttribute*, VARIANT, int>)(lpVtbl[31]))((IXMLDOMAttribute*)Unsafe.AsPointer(ref this), typedValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(32)]
        public HRESULT get_dataType(VARIANT* dataTypeName)
        {
            return ((delegate* unmanaged<IXMLDOMAttribute*, VARIANT*, int>)(lpVtbl[32]))((IXMLDOMAttribute*)Unsafe.AsPointer(ref this), dataTypeName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(33)]
        public HRESULT put_dataType([NativeTypeName("BSTR")] ushort* dataTypeName)
        {
            return ((delegate* unmanaged<IXMLDOMAttribute*, ushort*, int>)(lpVtbl[33]))((IXMLDOMAttribute*)Unsafe.AsPointer(ref this), dataTypeName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(34)]
        public HRESULT get_xml([NativeTypeName("BSTR *")] ushort** xmlString)
        {
            return ((delegate* unmanaged<IXMLDOMAttribute*, ushort**, int>)(lpVtbl[34]))((IXMLDOMAttribute*)Unsafe.AsPointer(ref this), xmlString);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(35)]
        public HRESULT transformNode(IXMLDOMNode* stylesheet, [NativeTypeName("BSTR *")] ushort** xmlString)
        {
            return ((delegate* unmanaged<IXMLDOMAttribute*, IXMLDOMNode*, ushort**, int>)(lpVtbl[35]))((IXMLDOMAttribute*)Unsafe.AsPointer(ref this), stylesheet, xmlString);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(36)]
        public HRESULT selectNodes([NativeTypeName("BSTR")] ushort* queryString, IXMLDOMNodeList** resultList)
        {
            return ((delegate* unmanaged<IXMLDOMAttribute*, ushort*, IXMLDOMNodeList**, int>)(lpVtbl[36]))((IXMLDOMAttribute*)Unsafe.AsPointer(ref this), queryString, resultList);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(37)]
        public HRESULT selectSingleNode([NativeTypeName("BSTR")] ushort* queryString, IXMLDOMNode** resultNode)
        {
            return ((delegate* unmanaged<IXMLDOMAttribute*, ushort*, IXMLDOMNode**, int>)(lpVtbl[37]))((IXMLDOMAttribute*)Unsafe.AsPointer(ref this), queryString, resultNode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(38)]
        public HRESULT get_parsed([NativeTypeName("VARIANT_BOOL *")] short* isParsed)
        {
            return ((delegate* unmanaged<IXMLDOMAttribute*, short*, int>)(lpVtbl[38]))((IXMLDOMAttribute*)Unsafe.AsPointer(ref this), isParsed);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(39)]
        public HRESULT get_namespaceURI([NativeTypeName("BSTR *")] ushort** namespaceURI)
        {
            return ((delegate* unmanaged<IXMLDOMAttribute*, ushort**, int>)(lpVtbl[39]))((IXMLDOMAttribute*)Unsafe.AsPointer(ref this), namespaceURI);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(40)]
        public HRESULT get_prefix([NativeTypeName("BSTR *")] ushort** prefixString)
        {
            return ((delegate* unmanaged<IXMLDOMAttribute*, ushort**, int>)(lpVtbl[40]))((IXMLDOMAttribute*)Unsafe.AsPointer(ref this), prefixString);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(41)]
        public HRESULT get_baseName([NativeTypeName("BSTR *")] ushort** nameString)
        {
            return ((delegate* unmanaged<IXMLDOMAttribute*, ushort**, int>)(lpVtbl[41]))((IXMLDOMAttribute*)Unsafe.AsPointer(ref this), nameString);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(42)]
        public HRESULT transformNodeToObject(IXMLDOMNode* stylesheet, VARIANT outputObject)
        {
            return ((delegate* unmanaged<IXMLDOMAttribute*, IXMLDOMNode*, VARIANT, int>)(lpVtbl[42]))((IXMLDOMAttribute*)Unsafe.AsPointer(ref this), stylesheet, outputObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(43)]
        public HRESULT get_name([NativeTypeName("BSTR *")] ushort** attributeName)
        {
            return ((delegate* unmanaged<IXMLDOMAttribute*, ushort**, int>)(lpVtbl[43]))((IXMLDOMAttribute*)Unsafe.AsPointer(ref this), attributeName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(44)]
        public HRESULT get_value(VARIANT* attributeValue)
        {
            return ((delegate* unmanaged<IXMLDOMAttribute*, VARIANT*, int>)(lpVtbl[44]))((IXMLDOMAttribute*)Unsafe.AsPointer(ref this), attributeValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(45)]
        public HRESULT put_value(VARIANT attributeValue)
        {
            return ((delegate* unmanaged<IXMLDOMAttribute*, VARIANT, int>)(lpVtbl[45]))((IXMLDOMAttribute*)Unsafe.AsPointer(ref this), attributeValue);
        }

        public interface Interface : IXMLDOMNode.Interface
        {
            [VtblIndex(43)]
            HRESULT get_name([NativeTypeName("BSTR *")] ushort** attributeName);

            [VtblIndex(44)]
            HRESULT get_value(VARIANT* attributeValue);

            [VtblIndex(45)]
            HRESULT put_value(VARIANT attributeValue);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IXMLDOMAttribute*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IXMLDOMAttribute*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IXMLDOMAttribute*, uint> Release;

            [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged<IXMLDOMAttribute*, uint*, int> GetTypeInfoCount;

            [NativeTypeName("HRESULT (UINT, LCID, ITypeInfo **) __attribute__((stdcall))")]
            public delegate* unmanaged<IXMLDOMAttribute*, uint, uint, ITypeInfo**, int> GetTypeInfo;

            [NativeTypeName("HRESULT (const IID &, LPOLESTR *, UINT, LCID, DISPID *) __attribute__((stdcall))")]
            public delegate* unmanaged<IXMLDOMAttribute*, Guid*, ushort**, uint, uint, int*, int> GetIDsOfNames;

            [NativeTypeName("HRESULT (DISPID, const IID &, LCID, WORD, DISPPARAMS *, VARIANT *, EXCEPINFO *, UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged<IXMLDOMAttribute*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int> Invoke;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<IXMLDOMAttribute*, ushort**, int> get_nodeName;

            [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
            public delegate* unmanaged<IXMLDOMAttribute*, VARIANT*, int> get_nodeValue;

            [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
            public delegate* unmanaged<IXMLDOMAttribute*, VARIANT, int> put_nodeValue;

            [NativeTypeName("HRESULT (DOMNodeType *) __attribute__((stdcall))")]
            public delegate* unmanaged<IXMLDOMAttribute*, DOMNodeType*, int> get_nodeType;

            [NativeTypeName("HRESULT (IXMLDOMNode **) __attribute__((stdcall))")]
            public delegate* unmanaged<IXMLDOMAttribute*, IXMLDOMNode**, int> get_parentNode;

            [NativeTypeName("HRESULT (IXMLDOMNodeList **) __attribute__((stdcall))")]
            public delegate* unmanaged<IXMLDOMAttribute*, IXMLDOMNodeList**, int> get_childNodes;

            [NativeTypeName("HRESULT (IXMLDOMNode **) __attribute__((stdcall))")]
            public delegate* unmanaged<IXMLDOMAttribute*, IXMLDOMNode**, int> get_firstChild;

            [NativeTypeName("HRESULT (IXMLDOMNode **) __attribute__((stdcall))")]
            public delegate* unmanaged<IXMLDOMAttribute*, IXMLDOMNode**, int> get_lastChild;

            [NativeTypeName("HRESULT (IXMLDOMNode **) __attribute__((stdcall))")]
            public delegate* unmanaged<IXMLDOMAttribute*, IXMLDOMNode**, int> get_previousSibling;

            [NativeTypeName("HRESULT (IXMLDOMNode **) __attribute__((stdcall))")]
            public delegate* unmanaged<IXMLDOMAttribute*, IXMLDOMNode**, int> get_nextSibling;

            [NativeTypeName("HRESULT (IXMLDOMNamedNodeMap **) __attribute__((stdcall))")]
            public delegate* unmanaged<IXMLDOMAttribute*, IXMLDOMNamedNodeMap**, int> get_attributes;

            [NativeTypeName("HRESULT (IXMLDOMNode *, VARIANT, IXMLDOMNode **) __attribute__((stdcall))")]
            public delegate* unmanaged<IXMLDOMAttribute*, IXMLDOMNode*, VARIANT, IXMLDOMNode**, int> insertBefore;

            [NativeTypeName("HRESULT (IXMLDOMNode *, IXMLDOMNode *, IXMLDOMNode **) __attribute__((stdcall))")]
            public delegate* unmanaged<IXMLDOMAttribute*, IXMLDOMNode*, IXMLDOMNode*, IXMLDOMNode**, int> replaceChild;

            [NativeTypeName("HRESULT (IXMLDOMNode *, IXMLDOMNode **) __attribute__((stdcall))")]
            public delegate* unmanaged<IXMLDOMAttribute*, IXMLDOMNode*, IXMLDOMNode**, int> removeChild;

            [NativeTypeName("HRESULT (IXMLDOMNode *, IXMLDOMNode **) __attribute__((stdcall))")]
            public delegate* unmanaged<IXMLDOMAttribute*, IXMLDOMNode*, IXMLDOMNode**, int> appendChild;

            [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
            public delegate* unmanaged<IXMLDOMAttribute*, short*, int> hasChildNodes;

            [NativeTypeName("HRESULT (IXMLDOMDocument **) __attribute__((stdcall))")]
            public delegate* unmanaged<IXMLDOMAttribute*, IXMLDOMDocument**, int> get_ownerDocument;

            [NativeTypeName("HRESULT (VARIANT_BOOL, IXMLDOMNode **) __attribute__((stdcall))")]
            public delegate* unmanaged<IXMLDOMAttribute*, short, IXMLDOMNode**, int> cloneNode;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<IXMLDOMAttribute*, ushort**, int> get_nodeTypeString;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<IXMLDOMAttribute*, ushort**, int> get_text;

            [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
            public delegate* unmanaged<IXMLDOMAttribute*, ushort*, int> put_text;

            [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
            public delegate* unmanaged<IXMLDOMAttribute*, short*, int> get_specified;

            [NativeTypeName("HRESULT (IXMLDOMNode **) __attribute__((stdcall))")]
            public delegate* unmanaged<IXMLDOMAttribute*, IXMLDOMNode**, int> get_definition;

            [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
            public delegate* unmanaged<IXMLDOMAttribute*, VARIANT*, int> get_nodeTypedValue;

            [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
            public delegate* unmanaged<IXMLDOMAttribute*, VARIANT, int> put_nodeTypedValue;

            [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
            public delegate* unmanaged<IXMLDOMAttribute*, VARIANT*, int> get_dataType;

            [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
            public delegate* unmanaged<IXMLDOMAttribute*, ushort*, int> put_dataType;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<IXMLDOMAttribute*, ushort**, int> get_xml;

            [NativeTypeName("HRESULT (IXMLDOMNode *, BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<IXMLDOMAttribute*, IXMLDOMNode*, ushort**, int> transformNode;

            [NativeTypeName("HRESULT (BSTR, IXMLDOMNodeList **) __attribute__((stdcall))")]
            public delegate* unmanaged<IXMLDOMAttribute*, ushort*, IXMLDOMNodeList**, int> selectNodes;

            [NativeTypeName("HRESULT (BSTR, IXMLDOMNode **) __attribute__((stdcall))")]
            public delegate* unmanaged<IXMLDOMAttribute*, ushort*, IXMLDOMNode**, int> selectSingleNode;

            [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
            public delegate* unmanaged<IXMLDOMAttribute*, short*, int> get_parsed;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<IXMLDOMAttribute*, ushort**, int> get_namespaceURI;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<IXMLDOMAttribute*, ushort**, int> get_prefix;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<IXMLDOMAttribute*, ushort**, int> get_baseName;

            [NativeTypeName("HRESULT (IXMLDOMNode *, VARIANT) __attribute__((stdcall))")]
            public delegate* unmanaged<IXMLDOMAttribute*, IXMLDOMNode*, VARIANT, int> transformNodeToObject;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<IXMLDOMAttribute*, ushort**, int> get_name;

            [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
            public delegate* unmanaged<IXMLDOMAttribute*, VARIANT*, int> get_value;

            [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
            public delegate* unmanaged<IXMLDOMAttribute*, VARIANT, int> put_value;
        }
    }
}
