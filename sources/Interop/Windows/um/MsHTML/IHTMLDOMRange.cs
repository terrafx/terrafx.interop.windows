// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("305104AE-98B5-11CF-BB82-00AA00BDCE0B")]
    [NativeTypeName("struct IHTMLDOMRange : IDispatch")]
    [NativeInheritance("IDispatch")]
    public unsafe partial struct IHTMLDOMRange
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IHTMLDOMRange*, Guid*, void**, int>)(lpVtbl[0]))((IHTMLDOMRange*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IHTMLDOMRange*, uint>)(lpVtbl[1]))((IHTMLDOMRange*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IHTMLDOMRange*, uint>)(lpVtbl[2]))((IHTMLDOMRange*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetTypeInfoCount(uint* pctinfo)
        {
            return ((delegate* unmanaged<IHTMLDOMRange*, uint*, int>)(lpVtbl[3]))((IHTMLDOMRange*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<IHTMLDOMRange*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IHTMLDOMRange*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<IHTMLDOMRange*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IHTMLDOMRange*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
        {
            return ((delegate* unmanaged<IHTMLDOMRange*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IHTMLDOMRange*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT get_startContainer(IHTMLDOMNode** p)
        {
            return ((delegate* unmanaged<IHTMLDOMRange*, IHTMLDOMNode**, int>)(lpVtbl[7]))((IHTMLDOMRange*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT get_startOffset([NativeTypeName("long *")] int* p)
        {
            return ((delegate* unmanaged<IHTMLDOMRange*, int*, int>)(lpVtbl[8]))((IHTMLDOMRange*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT get_endContainer(IHTMLDOMNode** p)
        {
            return ((delegate* unmanaged<IHTMLDOMRange*, IHTMLDOMNode**, int>)(lpVtbl[9]))((IHTMLDOMRange*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT get_endOffset([NativeTypeName("long *")] int* p)
        {
            return ((delegate* unmanaged<IHTMLDOMRange*, int*, int>)(lpVtbl[10]))((IHTMLDOMRange*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT get_collapsed([NativeTypeName("VARIANT_BOOL *")] short* p)
        {
            return ((delegate* unmanaged<IHTMLDOMRange*, short*, int>)(lpVtbl[11]))((IHTMLDOMRange*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT get_commonAncestorContainer(IHTMLDOMNode** p)
        {
            return ((delegate* unmanaged<IHTMLDOMRange*, IHTMLDOMNode**, int>)(lpVtbl[12]))((IHTMLDOMRange*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT setStart(IDispatch* refNode, [NativeTypeName("long")] int offset)
        {
            return ((delegate* unmanaged<IHTMLDOMRange*, IDispatch*, int, int>)(lpVtbl[13]))((IHTMLDOMRange*)Unsafe.AsPointer(ref this), refNode, offset);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HRESULT setEnd(IDispatch* refNode, [NativeTypeName("long")] int offset)
        {
            return ((delegate* unmanaged<IHTMLDOMRange*, IDispatch*, int, int>)(lpVtbl[14]))((IHTMLDOMRange*)Unsafe.AsPointer(ref this), refNode, offset);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public HRESULT setStartBefore(IDispatch* refNode)
        {
            return ((delegate* unmanaged<IHTMLDOMRange*, IDispatch*, int>)(lpVtbl[15]))((IHTMLDOMRange*)Unsafe.AsPointer(ref this), refNode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        public HRESULT setStartAfter(IDispatch* refNode)
        {
            return ((delegate* unmanaged<IHTMLDOMRange*, IDispatch*, int>)(lpVtbl[16]))((IHTMLDOMRange*)Unsafe.AsPointer(ref this), refNode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        public HRESULT setEndBefore(IDispatch* refNode)
        {
            return ((delegate* unmanaged<IHTMLDOMRange*, IDispatch*, int>)(lpVtbl[17]))((IHTMLDOMRange*)Unsafe.AsPointer(ref this), refNode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        public HRESULT setEndAfter(IDispatch* refNode)
        {
            return ((delegate* unmanaged<IHTMLDOMRange*, IDispatch*, int>)(lpVtbl[18]))((IHTMLDOMRange*)Unsafe.AsPointer(ref this), refNode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        public HRESULT collapse([NativeTypeName("VARIANT_BOOL")] short toStart)
        {
            return ((delegate* unmanaged<IHTMLDOMRange*, short, int>)(lpVtbl[19]))((IHTMLDOMRange*)Unsafe.AsPointer(ref this), toStart);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        public HRESULT selectNode(IDispatch* refNode)
        {
            return ((delegate* unmanaged<IHTMLDOMRange*, IDispatch*, int>)(lpVtbl[20]))((IHTMLDOMRange*)Unsafe.AsPointer(ref this), refNode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        public HRESULT selectNodeContents(IDispatch* refNode)
        {
            return ((delegate* unmanaged<IHTMLDOMRange*, IDispatch*, int>)(lpVtbl[21]))((IHTMLDOMRange*)Unsafe.AsPointer(ref this), refNode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(22)]
        public HRESULT compareBoundaryPoints(short how, IDispatch* sourceRange, [NativeTypeName("long *")] int* compareResult)
        {
            return ((delegate* unmanaged<IHTMLDOMRange*, short, IDispatch*, int*, int>)(lpVtbl[22]))((IHTMLDOMRange*)Unsafe.AsPointer(ref this), how, sourceRange, compareResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(23)]
        public HRESULT deleteContents()
        {
            return ((delegate* unmanaged<IHTMLDOMRange*, int>)(lpVtbl[23]))((IHTMLDOMRange*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(24)]
        public HRESULT extractContents(IDispatch** ppDocumentFragment)
        {
            return ((delegate* unmanaged<IHTMLDOMRange*, IDispatch**, int>)(lpVtbl[24]))((IHTMLDOMRange*)Unsafe.AsPointer(ref this), ppDocumentFragment);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(25)]
        public HRESULT cloneContents(IDispatch** ppDocumentFragment)
        {
            return ((delegate* unmanaged<IHTMLDOMRange*, IDispatch**, int>)(lpVtbl[25]))((IHTMLDOMRange*)Unsafe.AsPointer(ref this), ppDocumentFragment);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(26)]
        public HRESULT insertNode(IDispatch* newNode)
        {
            return ((delegate* unmanaged<IHTMLDOMRange*, IDispatch*, int>)(lpVtbl[26]))((IHTMLDOMRange*)Unsafe.AsPointer(ref this), newNode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(27)]
        public HRESULT surroundContents(IDispatch* newParent)
        {
            return ((delegate* unmanaged<IHTMLDOMRange*, IDispatch*, int>)(lpVtbl[27]))((IHTMLDOMRange*)Unsafe.AsPointer(ref this), newParent);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(28)]
        public HRESULT cloneRange(IHTMLDOMRange** ppClonedRange)
        {
            return ((delegate* unmanaged<IHTMLDOMRange*, IHTMLDOMRange**, int>)(lpVtbl[28]))((IHTMLDOMRange*)Unsafe.AsPointer(ref this), ppClonedRange);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(29)]
        public HRESULT toString([NativeTypeName("BSTR *")] ushort** pRangeString)
        {
            return ((delegate* unmanaged<IHTMLDOMRange*, ushort**, int>)(lpVtbl[29]))((IHTMLDOMRange*)Unsafe.AsPointer(ref this), pRangeString);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(30)]
        public HRESULT detach()
        {
            return ((delegate* unmanaged<IHTMLDOMRange*, int>)(lpVtbl[30]))((IHTMLDOMRange*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(31)]
        public HRESULT getClientRects(IHTMLRectCollection** ppRectCol)
        {
            return ((delegate* unmanaged<IHTMLDOMRange*, IHTMLRectCollection**, int>)(lpVtbl[31]))((IHTMLDOMRange*)Unsafe.AsPointer(ref this), ppRectCol);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(32)]
        public HRESULT getBoundingClientRect(IHTMLRect** ppRect)
        {
            return ((delegate* unmanaged<IHTMLDOMRange*, IHTMLRect**, int>)(lpVtbl[32]))((IHTMLDOMRange*)Unsafe.AsPointer(ref this), ppRect);
        }
    }
}
