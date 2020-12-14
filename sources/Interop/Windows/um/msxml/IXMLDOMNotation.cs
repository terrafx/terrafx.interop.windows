// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/msxml.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("2933BF8C-7B36-11D2-B20E-00C04F983E60")]
    [NativeTypeName("struct IXMLDOMNotation : IXMLDOMNode")]
    public unsafe partial struct IXMLDOMNotation
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IXMLDOMNotation*, Guid*, void**, int>)(lpVtbl[0]))((IXMLDOMNotation*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IXMLDOMNotation*, uint>)(lpVtbl[1]))((IXMLDOMNotation*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IXMLDOMNotation*, uint>)(lpVtbl[2]))((IXMLDOMNotation*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfoCount([NativeTypeName("UINT *")] uint* pctinfo)
        {
            return ((delegate* unmanaged<IXMLDOMNotation*, uint*, int>)(lpVtbl[3]))((IXMLDOMNotation*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfo([NativeTypeName("UINT")] uint iTInfo, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("ITypeInfo **")] ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<IXMLDOMNotation*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IXMLDOMNotation*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, [NativeTypeName("UINT")] uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<IXMLDOMNotation*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IXMLDOMNotation*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, [NativeTypeName("DISPPARAMS *")] DISPPARAMS* pDispParams, [NativeTypeName("VARIANT *")] VARIANT* pVarResult, [NativeTypeName("EXCEPINFO *")] EXCEPINFO* pExcepInfo, [NativeTypeName("UINT *")] uint* puArgErr)
        {
            return ((delegate* unmanaged<IXMLDOMNotation*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IXMLDOMNotation*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_nodeName([NativeTypeName("BSTR *")] ushort** name)
        {
            return ((delegate* unmanaged<IXMLDOMNotation*, ushort**, int>)(lpVtbl[7]))((IXMLDOMNotation*)Unsafe.AsPointer(ref this), name);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_nodeValue([NativeTypeName("VARIANT *")] VARIANT* value)
        {
            return ((delegate* unmanaged<IXMLDOMNotation*, VARIANT*, int>)(lpVtbl[8]))((IXMLDOMNotation*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_nodeValue(VARIANT value)
        {
            return ((delegate* unmanaged<IXMLDOMNotation*, VARIANT, int>)(lpVtbl[9]))((IXMLDOMNotation*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_nodeType([NativeTypeName("DOMNodeType *")] DOMNodeType* type)
        {
            return ((delegate* unmanaged<IXMLDOMNotation*, DOMNodeType*, int>)(lpVtbl[10]))((IXMLDOMNotation*)Unsafe.AsPointer(ref this), type);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_parentNode([NativeTypeName("IXMLDOMNode **")] IXMLDOMNode** parent)
        {
            return ((delegate* unmanaged<IXMLDOMNotation*, IXMLDOMNode**, int>)(lpVtbl[11]))((IXMLDOMNotation*)Unsafe.AsPointer(ref this), parent);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_childNodes([NativeTypeName("IXMLDOMNodeList **")] IXMLDOMNodeList** childList)
        {
            return ((delegate* unmanaged<IXMLDOMNotation*, IXMLDOMNodeList**, int>)(lpVtbl[12]))((IXMLDOMNotation*)Unsafe.AsPointer(ref this), childList);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_firstChild([NativeTypeName("IXMLDOMNode **")] IXMLDOMNode** firstChild)
        {
            return ((delegate* unmanaged<IXMLDOMNotation*, IXMLDOMNode**, int>)(lpVtbl[13]))((IXMLDOMNotation*)Unsafe.AsPointer(ref this), firstChild);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_lastChild([NativeTypeName("IXMLDOMNode **")] IXMLDOMNode** lastChild)
        {
            return ((delegate* unmanaged<IXMLDOMNotation*, IXMLDOMNode**, int>)(lpVtbl[14]))((IXMLDOMNotation*)Unsafe.AsPointer(ref this), lastChild);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_previousSibling([NativeTypeName("IXMLDOMNode **")] IXMLDOMNode** previousSibling)
        {
            return ((delegate* unmanaged<IXMLDOMNotation*, IXMLDOMNode**, int>)(lpVtbl[15]))((IXMLDOMNotation*)Unsafe.AsPointer(ref this), previousSibling);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_nextSibling([NativeTypeName("IXMLDOMNode **")] IXMLDOMNode** nextSibling)
        {
            return ((delegate* unmanaged<IXMLDOMNotation*, IXMLDOMNode**, int>)(lpVtbl[16]))((IXMLDOMNotation*)Unsafe.AsPointer(ref this), nextSibling);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_attributes([NativeTypeName("IXMLDOMNamedNodeMap **")] IXMLDOMNamedNodeMap** attributeMap)
        {
            return ((delegate* unmanaged<IXMLDOMNotation*, IXMLDOMNamedNodeMap**, int>)(lpVtbl[17]))((IXMLDOMNotation*)Unsafe.AsPointer(ref this), attributeMap);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int insertBefore([NativeTypeName("IXMLDOMNode *")] IXMLDOMNode* newChild, VARIANT refChild, [NativeTypeName("IXMLDOMNode **")] IXMLDOMNode** outNewChild)
        {
            return ((delegate* unmanaged<IXMLDOMNotation*, IXMLDOMNode*, VARIANT, IXMLDOMNode**, int>)(lpVtbl[18]))((IXMLDOMNotation*)Unsafe.AsPointer(ref this), newChild, refChild, outNewChild);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int replaceChild([NativeTypeName("IXMLDOMNode *")] IXMLDOMNode* newChild, [NativeTypeName("IXMLDOMNode *")] IXMLDOMNode* oldChild, [NativeTypeName("IXMLDOMNode **")] IXMLDOMNode** outOldChild)
        {
            return ((delegate* unmanaged<IXMLDOMNotation*, IXMLDOMNode*, IXMLDOMNode*, IXMLDOMNode**, int>)(lpVtbl[19]))((IXMLDOMNotation*)Unsafe.AsPointer(ref this), newChild, oldChild, outOldChild);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int removeChild([NativeTypeName("IXMLDOMNode *")] IXMLDOMNode* childNode, [NativeTypeName("IXMLDOMNode **")] IXMLDOMNode** oldChild)
        {
            return ((delegate* unmanaged<IXMLDOMNotation*, IXMLDOMNode*, IXMLDOMNode**, int>)(lpVtbl[20]))((IXMLDOMNotation*)Unsafe.AsPointer(ref this), childNode, oldChild);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int appendChild([NativeTypeName("IXMLDOMNode *")] IXMLDOMNode* newChild, [NativeTypeName("IXMLDOMNode **")] IXMLDOMNode** outNewChild)
        {
            return ((delegate* unmanaged<IXMLDOMNotation*, IXMLDOMNode*, IXMLDOMNode**, int>)(lpVtbl[21]))((IXMLDOMNotation*)Unsafe.AsPointer(ref this), newChild, outNewChild);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int hasChildNodes([NativeTypeName("VARIANT_BOOL *")] short* hasChild)
        {
            return ((delegate* unmanaged<IXMLDOMNotation*, short*, int>)(lpVtbl[22]))((IXMLDOMNotation*)Unsafe.AsPointer(ref this), hasChild);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_ownerDocument([NativeTypeName("IXMLDOMDocument **")] IXMLDOMDocument** XMLDOMDocument)
        {
            return ((delegate* unmanaged<IXMLDOMNotation*, IXMLDOMDocument**, int>)(lpVtbl[23]))((IXMLDOMNotation*)Unsafe.AsPointer(ref this), XMLDOMDocument);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int cloneNode([NativeTypeName("VARIANT_BOOL")] short deep, [NativeTypeName("IXMLDOMNode **")] IXMLDOMNode** cloneRoot)
        {
            return ((delegate* unmanaged<IXMLDOMNotation*, short, IXMLDOMNode**, int>)(lpVtbl[24]))((IXMLDOMNotation*)Unsafe.AsPointer(ref this), deep, cloneRoot);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_nodeTypeString([NativeTypeName("BSTR *")] ushort** nodeType)
        {
            return ((delegate* unmanaged<IXMLDOMNotation*, ushort**, int>)(lpVtbl[25]))((IXMLDOMNotation*)Unsafe.AsPointer(ref this), nodeType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_text([NativeTypeName("BSTR *")] ushort** text)
        {
            return ((delegate* unmanaged<IXMLDOMNotation*, ushort**, int>)(lpVtbl[26]))((IXMLDOMNotation*)Unsafe.AsPointer(ref this), text);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_text([NativeTypeName("BSTR")] ushort* text)
        {
            return ((delegate* unmanaged<IXMLDOMNotation*, ushort*, int>)(lpVtbl[27]))((IXMLDOMNotation*)Unsafe.AsPointer(ref this), text);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_specified([NativeTypeName("VARIANT_BOOL *")] short* isSpecified)
        {
            return ((delegate* unmanaged<IXMLDOMNotation*, short*, int>)(lpVtbl[28]))((IXMLDOMNotation*)Unsafe.AsPointer(ref this), isSpecified);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_definition([NativeTypeName("IXMLDOMNode **")] IXMLDOMNode** definitionNode)
        {
            return ((delegate* unmanaged<IXMLDOMNotation*, IXMLDOMNode**, int>)(lpVtbl[29]))((IXMLDOMNotation*)Unsafe.AsPointer(ref this), definitionNode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_nodeTypedValue([NativeTypeName("VARIANT *")] VARIANT* typedValue)
        {
            return ((delegate* unmanaged<IXMLDOMNotation*, VARIANT*, int>)(lpVtbl[30]))((IXMLDOMNotation*)Unsafe.AsPointer(ref this), typedValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_nodeTypedValue(VARIANT typedValue)
        {
            return ((delegate* unmanaged<IXMLDOMNotation*, VARIANT, int>)(lpVtbl[31]))((IXMLDOMNotation*)Unsafe.AsPointer(ref this), typedValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_dataType([NativeTypeName("VARIANT *")] VARIANT* dataTypeName)
        {
            return ((delegate* unmanaged<IXMLDOMNotation*, VARIANT*, int>)(lpVtbl[32]))((IXMLDOMNotation*)Unsafe.AsPointer(ref this), dataTypeName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_dataType([NativeTypeName("BSTR")] ushort* dataTypeName)
        {
            return ((delegate* unmanaged<IXMLDOMNotation*, ushort*, int>)(lpVtbl[33]))((IXMLDOMNotation*)Unsafe.AsPointer(ref this), dataTypeName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_xml([NativeTypeName("BSTR *")] ushort** xmlString)
        {
            return ((delegate* unmanaged<IXMLDOMNotation*, ushort**, int>)(lpVtbl[34]))((IXMLDOMNotation*)Unsafe.AsPointer(ref this), xmlString);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int transformNode([NativeTypeName("IXMLDOMNode *")] IXMLDOMNode* stylesheet, [NativeTypeName("BSTR *")] ushort** xmlString)
        {
            return ((delegate* unmanaged<IXMLDOMNotation*, IXMLDOMNode*, ushort**, int>)(lpVtbl[35]))((IXMLDOMNotation*)Unsafe.AsPointer(ref this), stylesheet, xmlString);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int selectNodes([NativeTypeName("BSTR")] ushort* queryString, [NativeTypeName("IXMLDOMNodeList **")] IXMLDOMNodeList** resultList)
        {
            return ((delegate* unmanaged<IXMLDOMNotation*, ushort*, IXMLDOMNodeList**, int>)(lpVtbl[36]))((IXMLDOMNotation*)Unsafe.AsPointer(ref this), queryString, resultList);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int selectSingleNode([NativeTypeName("BSTR")] ushort* queryString, [NativeTypeName("IXMLDOMNode **")] IXMLDOMNode** resultNode)
        {
            return ((delegate* unmanaged<IXMLDOMNotation*, ushort*, IXMLDOMNode**, int>)(lpVtbl[37]))((IXMLDOMNotation*)Unsafe.AsPointer(ref this), queryString, resultNode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_parsed([NativeTypeName("VARIANT_BOOL *")] short* isParsed)
        {
            return ((delegate* unmanaged<IXMLDOMNotation*, short*, int>)(lpVtbl[38]))((IXMLDOMNotation*)Unsafe.AsPointer(ref this), isParsed);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_namespaceURI([NativeTypeName("BSTR *")] ushort** namespaceURI)
        {
            return ((delegate* unmanaged<IXMLDOMNotation*, ushort**, int>)(lpVtbl[39]))((IXMLDOMNotation*)Unsafe.AsPointer(ref this), namespaceURI);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_prefix([NativeTypeName("BSTR *")] ushort** prefixString)
        {
            return ((delegate* unmanaged<IXMLDOMNotation*, ushort**, int>)(lpVtbl[40]))((IXMLDOMNotation*)Unsafe.AsPointer(ref this), prefixString);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_baseName([NativeTypeName("BSTR *")] ushort** nameString)
        {
            return ((delegate* unmanaged<IXMLDOMNotation*, ushort**, int>)(lpVtbl[41]))((IXMLDOMNotation*)Unsafe.AsPointer(ref this), nameString);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int transformNodeToObject([NativeTypeName("IXMLDOMNode *")] IXMLDOMNode* stylesheet, VARIANT outputObject)
        {
            return ((delegate* unmanaged<IXMLDOMNotation*, IXMLDOMNode*, VARIANT, int>)(lpVtbl[42]))((IXMLDOMNotation*)Unsafe.AsPointer(ref this), stylesheet, outputObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_publicId([NativeTypeName("VARIANT *")] VARIANT* publicID)
        {
            return ((delegate* unmanaged<IXMLDOMNotation*, VARIANT*, int>)(lpVtbl[43]))((IXMLDOMNotation*)Unsafe.AsPointer(ref this), publicID);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_systemId([NativeTypeName("VARIANT *")] VARIANT* systemID)
        {
            return ((delegate* unmanaged<IXMLDOMNotation*, VARIANT*, int>)(lpVtbl[44]))((IXMLDOMNotation*)Unsafe.AsPointer(ref this), systemID);
        }
    }
}
