// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/msxml.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("2933BF88-7B36-11D2-B20E-00C04F983E60")]
    [NativeTypeName("struct IXMLDOMComment : IXMLDOMCharacterData")]
    [NativeInheritance("IXMLDOMCharacterData")]
    public unsafe partial struct IXMLDOMComment
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IXMLDOMComment*, Guid*, void**, int>)(lpVtbl[0]))((IXMLDOMComment*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IXMLDOMComment*, uint>)(lpVtbl[1]))((IXMLDOMComment*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IXMLDOMComment*, uint>)(lpVtbl[2]))((IXMLDOMComment*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfoCount([NativeTypeName("UINT *")] uint* pctinfo)
        {
            return ((delegate* unmanaged<IXMLDOMComment*, uint*, int>)(lpVtbl[3]))((IXMLDOMComment*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfo([NativeTypeName("UINT")] uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<IXMLDOMComment*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IXMLDOMComment*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, [NativeTypeName("UINT")] uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<IXMLDOMComment*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IXMLDOMComment*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, [NativeTypeName("UINT *")] uint* puArgErr)
        {
            return ((delegate* unmanaged<IXMLDOMComment*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IXMLDOMComment*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int get_nodeName([NativeTypeName("BSTR *")] ushort** name)
        {
            return ((delegate* unmanaged<IXMLDOMComment*, ushort**, int>)(lpVtbl[7]))((IXMLDOMComment*)Unsafe.AsPointer(ref this), name);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int get_nodeValue(VARIANT* value)
        {
            return ((delegate* unmanaged<IXMLDOMComment*, VARIANT*, int>)(lpVtbl[8]))((IXMLDOMComment*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("HRESULT")]
        public int put_nodeValue(VARIANT value)
        {
            return ((delegate* unmanaged<IXMLDOMComment*, VARIANT, int>)(lpVtbl[9]))((IXMLDOMComment*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        [return: NativeTypeName("HRESULT")]
        public int get_nodeType(DOMNodeType* type)
        {
            return ((delegate* unmanaged<IXMLDOMComment*, DOMNodeType*, int>)(lpVtbl[10]))((IXMLDOMComment*)Unsafe.AsPointer(ref this), type);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        [return: NativeTypeName("HRESULT")]
        public int get_parentNode(IXMLDOMNode** parent)
        {
            return ((delegate* unmanaged<IXMLDOMComment*, IXMLDOMNode**, int>)(lpVtbl[11]))((IXMLDOMComment*)Unsafe.AsPointer(ref this), parent);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        [return: NativeTypeName("HRESULT")]
        public int get_childNodes(IXMLDOMNodeList** childList)
        {
            return ((delegate* unmanaged<IXMLDOMComment*, IXMLDOMNodeList**, int>)(lpVtbl[12]))((IXMLDOMComment*)Unsafe.AsPointer(ref this), childList);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        [return: NativeTypeName("HRESULT")]
        public int get_firstChild(IXMLDOMNode** firstChild)
        {
            return ((delegate* unmanaged<IXMLDOMComment*, IXMLDOMNode**, int>)(lpVtbl[13]))((IXMLDOMComment*)Unsafe.AsPointer(ref this), firstChild);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        [return: NativeTypeName("HRESULT")]
        public int get_lastChild(IXMLDOMNode** lastChild)
        {
            return ((delegate* unmanaged<IXMLDOMComment*, IXMLDOMNode**, int>)(lpVtbl[14]))((IXMLDOMComment*)Unsafe.AsPointer(ref this), lastChild);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        [return: NativeTypeName("HRESULT")]
        public int get_previousSibling(IXMLDOMNode** previousSibling)
        {
            return ((delegate* unmanaged<IXMLDOMComment*, IXMLDOMNode**, int>)(lpVtbl[15]))((IXMLDOMComment*)Unsafe.AsPointer(ref this), previousSibling);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        [return: NativeTypeName("HRESULT")]
        public int get_nextSibling(IXMLDOMNode** nextSibling)
        {
            return ((delegate* unmanaged<IXMLDOMComment*, IXMLDOMNode**, int>)(lpVtbl[16]))((IXMLDOMComment*)Unsafe.AsPointer(ref this), nextSibling);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        [return: NativeTypeName("HRESULT")]
        public int get_attributes(IXMLDOMNamedNodeMap** attributeMap)
        {
            return ((delegate* unmanaged<IXMLDOMComment*, IXMLDOMNamedNodeMap**, int>)(lpVtbl[17]))((IXMLDOMComment*)Unsafe.AsPointer(ref this), attributeMap);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        [return: NativeTypeName("HRESULT")]
        public int insertBefore(IXMLDOMNode* newChild, VARIANT refChild, IXMLDOMNode** outNewChild)
        {
            return ((delegate* unmanaged<IXMLDOMComment*, IXMLDOMNode*, VARIANT, IXMLDOMNode**, int>)(lpVtbl[18]))((IXMLDOMComment*)Unsafe.AsPointer(ref this), newChild, refChild, outNewChild);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        [return: NativeTypeName("HRESULT")]
        public int replaceChild(IXMLDOMNode* newChild, IXMLDOMNode* oldChild, IXMLDOMNode** outOldChild)
        {
            return ((delegate* unmanaged<IXMLDOMComment*, IXMLDOMNode*, IXMLDOMNode*, IXMLDOMNode**, int>)(lpVtbl[19]))((IXMLDOMComment*)Unsafe.AsPointer(ref this), newChild, oldChild, outOldChild);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        [return: NativeTypeName("HRESULT")]
        public int removeChild(IXMLDOMNode* childNode, IXMLDOMNode** oldChild)
        {
            return ((delegate* unmanaged<IXMLDOMComment*, IXMLDOMNode*, IXMLDOMNode**, int>)(lpVtbl[20]))((IXMLDOMComment*)Unsafe.AsPointer(ref this), childNode, oldChild);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        [return: NativeTypeName("HRESULT")]
        public int appendChild(IXMLDOMNode* newChild, IXMLDOMNode** outNewChild)
        {
            return ((delegate* unmanaged<IXMLDOMComment*, IXMLDOMNode*, IXMLDOMNode**, int>)(lpVtbl[21]))((IXMLDOMComment*)Unsafe.AsPointer(ref this), newChild, outNewChild);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(22)]
        [return: NativeTypeName("HRESULT")]
        public int hasChildNodes([NativeTypeName("VARIANT_BOOL *")] short* hasChild)
        {
            return ((delegate* unmanaged<IXMLDOMComment*, short*, int>)(lpVtbl[22]))((IXMLDOMComment*)Unsafe.AsPointer(ref this), hasChild);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(23)]
        [return: NativeTypeName("HRESULT")]
        public int get_ownerDocument(IXMLDOMDocument** XMLDOMDocument)
        {
            return ((delegate* unmanaged<IXMLDOMComment*, IXMLDOMDocument**, int>)(lpVtbl[23]))((IXMLDOMComment*)Unsafe.AsPointer(ref this), XMLDOMDocument);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(24)]
        [return: NativeTypeName("HRESULT")]
        public int cloneNode([NativeTypeName("VARIANT_BOOL")] short deep, IXMLDOMNode** cloneRoot)
        {
            return ((delegate* unmanaged<IXMLDOMComment*, short, IXMLDOMNode**, int>)(lpVtbl[24]))((IXMLDOMComment*)Unsafe.AsPointer(ref this), deep, cloneRoot);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(25)]
        [return: NativeTypeName("HRESULT")]
        public int get_nodeTypeString([NativeTypeName("BSTR *")] ushort** nodeType)
        {
            return ((delegate* unmanaged<IXMLDOMComment*, ushort**, int>)(lpVtbl[25]))((IXMLDOMComment*)Unsafe.AsPointer(ref this), nodeType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(26)]
        [return: NativeTypeName("HRESULT")]
        public int get_text([NativeTypeName("BSTR *")] ushort** text)
        {
            return ((delegate* unmanaged<IXMLDOMComment*, ushort**, int>)(lpVtbl[26]))((IXMLDOMComment*)Unsafe.AsPointer(ref this), text);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(27)]
        [return: NativeTypeName("HRESULT")]
        public int put_text([NativeTypeName("BSTR")] ushort* text)
        {
            return ((delegate* unmanaged<IXMLDOMComment*, ushort*, int>)(lpVtbl[27]))((IXMLDOMComment*)Unsafe.AsPointer(ref this), text);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(28)]
        [return: NativeTypeName("HRESULT")]
        public int get_specified([NativeTypeName("VARIANT_BOOL *")] short* isSpecified)
        {
            return ((delegate* unmanaged<IXMLDOMComment*, short*, int>)(lpVtbl[28]))((IXMLDOMComment*)Unsafe.AsPointer(ref this), isSpecified);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(29)]
        [return: NativeTypeName("HRESULT")]
        public int get_definition(IXMLDOMNode** definitionNode)
        {
            return ((delegate* unmanaged<IXMLDOMComment*, IXMLDOMNode**, int>)(lpVtbl[29]))((IXMLDOMComment*)Unsafe.AsPointer(ref this), definitionNode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(30)]
        [return: NativeTypeName("HRESULT")]
        public int get_nodeTypedValue(VARIANT* typedValue)
        {
            return ((delegate* unmanaged<IXMLDOMComment*, VARIANT*, int>)(lpVtbl[30]))((IXMLDOMComment*)Unsafe.AsPointer(ref this), typedValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(31)]
        [return: NativeTypeName("HRESULT")]
        public int put_nodeTypedValue(VARIANT typedValue)
        {
            return ((delegate* unmanaged<IXMLDOMComment*, VARIANT, int>)(lpVtbl[31]))((IXMLDOMComment*)Unsafe.AsPointer(ref this), typedValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(32)]
        [return: NativeTypeName("HRESULT")]
        public int get_dataType(VARIANT* dataTypeName)
        {
            return ((delegate* unmanaged<IXMLDOMComment*, VARIANT*, int>)(lpVtbl[32]))((IXMLDOMComment*)Unsafe.AsPointer(ref this), dataTypeName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(33)]
        [return: NativeTypeName("HRESULT")]
        public int put_dataType([NativeTypeName("BSTR")] ushort* dataTypeName)
        {
            return ((delegate* unmanaged<IXMLDOMComment*, ushort*, int>)(lpVtbl[33]))((IXMLDOMComment*)Unsafe.AsPointer(ref this), dataTypeName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(34)]
        [return: NativeTypeName("HRESULT")]
        public int get_xml([NativeTypeName("BSTR *")] ushort** xmlString)
        {
            return ((delegate* unmanaged<IXMLDOMComment*, ushort**, int>)(lpVtbl[34]))((IXMLDOMComment*)Unsafe.AsPointer(ref this), xmlString);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(35)]
        [return: NativeTypeName("HRESULT")]
        public int transformNode(IXMLDOMNode* stylesheet, [NativeTypeName("BSTR *")] ushort** xmlString)
        {
            return ((delegate* unmanaged<IXMLDOMComment*, IXMLDOMNode*, ushort**, int>)(lpVtbl[35]))((IXMLDOMComment*)Unsafe.AsPointer(ref this), stylesheet, xmlString);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(36)]
        [return: NativeTypeName("HRESULT")]
        public int selectNodes([NativeTypeName("BSTR")] ushort* queryString, IXMLDOMNodeList** resultList)
        {
            return ((delegate* unmanaged<IXMLDOMComment*, ushort*, IXMLDOMNodeList**, int>)(lpVtbl[36]))((IXMLDOMComment*)Unsafe.AsPointer(ref this), queryString, resultList);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(37)]
        [return: NativeTypeName("HRESULT")]
        public int selectSingleNode([NativeTypeName("BSTR")] ushort* queryString, IXMLDOMNode** resultNode)
        {
            return ((delegate* unmanaged<IXMLDOMComment*, ushort*, IXMLDOMNode**, int>)(lpVtbl[37]))((IXMLDOMComment*)Unsafe.AsPointer(ref this), queryString, resultNode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(38)]
        [return: NativeTypeName("HRESULT")]
        public int get_parsed([NativeTypeName("VARIANT_BOOL *")] short* isParsed)
        {
            return ((delegate* unmanaged<IXMLDOMComment*, short*, int>)(lpVtbl[38]))((IXMLDOMComment*)Unsafe.AsPointer(ref this), isParsed);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(39)]
        [return: NativeTypeName("HRESULT")]
        public int get_namespaceURI([NativeTypeName("BSTR *")] ushort** namespaceURI)
        {
            return ((delegate* unmanaged<IXMLDOMComment*, ushort**, int>)(lpVtbl[39]))((IXMLDOMComment*)Unsafe.AsPointer(ref this), namespaceURI);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(40)]
        [return: NativeTypeName("HRESULT")]
        public int get_prefix([NativeTypeName("BSTR *")] ushort** prefixString)
        {
            return ((delegate* unmanaged<IXMLDOMComment*, ushort**, int>)(lpVtbl[40]))((IXMLDOMComment*)Unsafe.AsPointer(ref this), prefixString);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(41)]
        [return: NativeTypeName("HRESULT")]
        public int get_baseName([NativeTypeName("BSTR *")] ushort** nameString)
        {
            return ((delegate* unmanaged<IXMLDOMComment*, ushort**, int>)(lpVtbl[41]))((IXMLDOMComment*)Unsafe.AsPointer(ref this), nameString);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(42)]
        [return: NativeTypeName("HRESULT")]
        public int transformNodeToObject(IXMLDOMNode* stylesheet, VARIANT outputObject)
        {
            return ((delegate* unmanaged<IXMLDOMComment*, IXMLDOMNode*, VARIANT, int>)(lpVtbl[42]))((IXMLDOMComment*)Unsafe.AsPointer(ref this), stylesheet, outputObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(43)]
        [return: NativeTypeName("HRESULT")]
        public int get_data([NativeTypeName("BSTR *")] ushort** data)
        {
            return ((delegate* unmanaged<IXMLDOMComment*, ushort**, int>)(lpVtbl[43]))((IXMLDOMComment*)Unsafe.AsPointer(ref this), data);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(44)]
        [return: NativeTypeName("HRESULT")]
        public int put_data([NativeTypeName("BSTR")] ushort* data)
        {
            return ((delegate* unmanaged<IXMLDOMComment*, ushort*, int>)(lpVtbl[44]))((IXMLDOMComment*)Unsafe.AsPointer(ref this), data);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(45)]
        [return: NativeTypeName("HRESULT")]
        public int get_length([NativeTypeName("long *")] int* dataLength)
        {
            return ((delegate* unmanaged<IXMLDOMComment*, int*, int>)(lpVtbl[45]))((IXMLDOMComment*)Unsafe.AsPointer(ref this), dataLength);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(46)]
        [return: NativeTypeName("HRESULT")]
        public int substringData([NativeTypeName("long")] int offset, [NativeTypeName("long")] int count, [NativeTypeName("BSTR *")] ushort** data)
        {
            return ((delegate* unmanaged<IXMLDOMComment*, int, int, ushort**, int>)(lpVtbl[46]))((IXMLDOMComment*)Unsafe.AsPointer(ref this), offset, count, data);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(47)]
        [return: NativeTypeName("HRESULT")]
        public int appendData([NativeTypeName("BSTR")] ushort* data)
        {
            return ((delegate* unmanaged<IXMLDOMComment*, ushort*, int>)(lpVtbl[47]))((IXMLDOMComment*)Unsafe.AsPointer(ref this), data);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(48)]
        [return: NativeTypeName("HRESULT")]
        public int insertData([NativeTypeName("long")] int offset, [NativeTypeName("BSTR")] ushort* data)
        {
            return ((delegate* unmanaged<IXMLDOMComment*, int, ushort*, int>)(lpVtbl[48]))((IXMLDOMComment*)Unsafe.AsPointer(ref this), offset, data);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(49)]
        [return: NativeTypeName("HRESULT")]
        public int deleteData([NativeTypeName("long")] int offset, [NativeTypeName("long")] int count)
        {
            return ((delegate* unmanaged<IXMLDOMComment*, int, int, int>)(lpVtbl[49]))((IXMLDOMComment*)Unsafe.AsPointer(ref this), offset, count);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(50)]
        [return: NativeTypeName("HRESULT")]
        public int replaceData([NativeTypeName("long")] int offset, [NativeTypeName("long")] int count, [NativeTypeName("BSTR")] ushort* data)
        {
            return ((delegate* unmanaged<IXMLDOMComment*, int, int, ushort*, int>)(lpVtbl[50]))((IXMLDOMComment*)Unsafe.AsPointer(ref this), offset, count, data);
        }
    }
}
