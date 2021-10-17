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
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
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
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfoCount([NativeTypeName("UINT *")] uint* pctinfo)
        {
            return ((delegate* unmanaged<IHTMLDOMRange*, uint*, int>)(lpVtbl[3]))((IHTMLDOMRange*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfo([NativeTypeName("UINT")] uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<IHTMLDOMRange*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IHTMLDOMRange*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, [NativeTypeName("UINT")] uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<IHTMLDOMRange*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IHTMLDOMRange*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, [NativeTypeName("UINT *")] uint* puArgErr)
        {
            return ((delegate* unmanaged<IHTMLDOMRange*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IHTMLDOMRange*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int get_startContainer(IHTMLDOMNode** p)
        {
            return ((delegate* unmanaged<IHTMLDOMRange*, IHTMLDOMNode**, int>)(lpVtbl[7]))((IHTMLDOMRange*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int get_startOffset([NativeTypeName("long *")] int* p)
        {
            return ((delegate* unmanaged<IHTMLDOMRange*, int*, int>)(lpVtbl[8]))((IHTMLDOMRange*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("HRESULT")]
        public int get_endContainer(IHTMLDOMNode** p)
        {
            return ((delegate* unmanaged<IHTMLDOMRange*, IHTMLDOMNode**, int>)(lpVtbl[9]))((IHTMLDOMRange*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        [return: NativeTypeName("HRESULT")]
        public int get_endOffset([NativeTypeName("long *")] int* p)
        {
            return ((delegate* unmanaged<IHTMLDOMRange*, int*, int>)(lpVtbl[10]))((IHTMLDOMRange*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        [return: NativeTypeName("HRESULT")]
        public int get_collapsed([NativeTypeName("VARIANT_BOOL *")] short* p)
        {
            return ((delegate* unmanaged<IHTMLDOMRange*, short*, int>)(lpVtbl[11]))((IHTMLDOMRange*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        [return: NativeTypeName("HRESULT")]
        public int get_commonAncestorContainer(IHTMLDOMNode** p)
        {
            return ((delegate* unmanaged<IHTMLDOMRange*, IHTMLDOMNode**, int>)(lpVtbl[12]))((IHTMLDOMRange*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        [return: NativeTypeName("HRESULT")]
        public int setStart(IDispatch* refNode, [NativeTypeName("long")] int offset)
        {
            return ((delegate* unmanaged<IHTMLDOMRange*, IDispatch*, int, int>)(lpVtbl[13]))((IHTMLDOMRange*)Unsafe.AsPointer(ref this), refNode, offset);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        [return: NativeTypeName("HRESULT")]
        public int setEnd(IDispatch* refNode, [NativeTypeName("long")] int offset)
        {
            return ((delegate* unmanaged<IHTMLDOMRange*, IDispatch*, int, int>)(lpVtbl[14]))((IHTMLDOMRange*)Unsafe.AsPointer(ref this), refNode, offset);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        [return: NativeTypeName("HRESULT")]
        public int setStartBefore(IDispatch* refNode)
        {
            return ((delegate* unmanaged<IHTMLDOMRange*, IDispatch*, int>)(lpVtbl[15]))((IHTMLDOMRange*)Unsafe.AsPointer(ref this), refNode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        [return: NativeTypeName("HRESULT")]
        public int setStartAfter(IDispatch* refNode)
        {
            return ((delegate* unmanaged<IHTMLDOMRange*, IDispatch*, int>)(lpVtbl[16]))((IHTMLDOMRange*)Unsafe.AsPointer(ref this), refNode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        [return: NativeTypeName("HRESULT")]
        public int setEndBefore(IDispatch* refNode)
        {
            return ((delegate* unmanaged<IHTMLDOMRange*, IDispatch*, int>)(lpVtbl[17]))((IHTMLDOMRange*)Unsafe.AsPointer(ref this), refNode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        [return: NativeTypeName("HRESULT")]
        public int setEndAfter(IDispatch* refNode)
        {
            return ((delegate* unmanaged<IHTMLDOMRange*, IDispatch*, int>)(lpVtbl[18]))((IHTMLDOMRange*)Unsafe.AsPointer(ref this), refNode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        [return: NativeTypeName("HRESULT")]
        public int collapse([NativeTypeName("VARIANT_BOOL")] short toStart)
        {
            return ((delegate* unmanaged<IHTMLDOMRange*, short, int>)(lpVtbl[19]))((IHTMLDOMRange*)Unsafe.AsPointer(ref this), toStart);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        [return: NativeTypeName("HRESULT")]
        public int selectNode(IDispatch* refNode)
        {
            return ((delegate* unmanaged<IHTMLDOMRange*, IDispatch*, int>)(lpVtbl[20]))((IHTMLDOMRange*)Unsafe.AsPointer(ref this), refNode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        [return: NativeTypeName("HRESULT")]
        public int selectNodeContents(IDispatch* refNode)
        {
            return ((delegate* unmanaged<IHTMLDOMRange*, IDispatch*, int>)(lpVtbl[21]))((IHTMLDOMRange*)Unsafe.AsPointer(ref this), refNode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(22)]
        [return: NativeTypeName("HRESULT")]
        public int compareBoundaryPoints(short how, IDispatch* sourceRange, [NativeTypeName("long *")] int* compareResult)
        {
            return ((delegate* unmanaged<IHTMLDOMRange*, short, IDispatch*, int*, int>)(lpVtbl[22]))((IHTMLDOMRange*)Unsafe.AsPointer(ref this), how, sourceRange, compareResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(23)]
        [return: NativeTypeName("HRESULT")]
        public int deleteContents()
        {
            return ((delegate* unmanaged<IHTMLDOMRange*, int>)(lpVtbl[23]))((IHTMLDOMRange*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(24)]
        [return: NativeTypeName("HRESULT")]
        public int extractContents(IDispatch** ppDocumentFragment)
        {
            return ((delegate* unmanaged<IHTMLDOMRange*, IDispatch**, int>)(lpVtbl[24]))((IHTMLDOMRange*)Unsafe.AsPointer(ref this), ppDocumentFragment);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(25)]
        [return: NativeTypeName("HRESULT")]
        public int cloneContents(IDispatch** ppDocumentFragment)
        {
            return ((delegate* unmanaged<IHTMLDOMRange*, IDispatch**, int>)(lpVtbl[25]))((IHTMLDOMRange*)Unsafe.AsPointer(ref this), ppDocumentFragment);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(26)]
        [return: NativeTypeName("HRESULT")]
        public int insertNode(IDispatch* newNode)
        {
            return ((delegate* unmanaged<IHTMLDOMRange*, IDispatch*, int>)(lpVtbl[26]))((IHTMLDOMRange*)Unsafe.AsPointer(ref this), newNode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(27)]
        [return: NativeTypeName("HRESULT")]
        public int surroundContents(IDispatch* newParent)
        {
            return ((delegate* unmanaged<IHTMLDOMRange*, IDispatch*, int>)(lpVtbl[27]))((IHTMLDOMRange*)Unsafe.AsPointer(ref this), newParent);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(28)]
        [return: NativeTypeName("HRESULT")]
        public int cloneRange(IHTMLDOMRange** ppClonedRange)
        {
            return ((delegate* unmanaged<IHTMLDOMRange*, IHTMLDOMRange**, int>)(lpVtbl[28]))((IHTMLDOMRange*)Unsafe.AsPointer(ref this), ppClonedRange);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(29)]
        [return: NativeTypeName("HRESULT")]
        public int toString([NativeTypeName("BSTR *")] ushort** pRangeString)
        {
            return ((delegate* unmanaged<IHTMLDOMRange*, ushort**, int>)(lpVtbl[29]))((IHTMLDOMRange*)Unsafe.AsPointer(ref this), pRangeString);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(30)]
        [return: NativeTypeName("HRESULT")]
        public int detach()
        {
            return ((delegate* unmanaged<IHTMLDOMRange*, int>)(lpVtbl[30]))((IHTMLDOMRange*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(31)]
        [return: NativeTypeName("HRESULT")]
        public int getClientRects(IHTMLRectCollection** ppRectCol)
        {
            return ((delegate* unmanaged<IHTMLDOMRange*, IHTMLRectCollection**, int>)(lpVtbl[31]))((IHTMLDOMRange*)Unsafe.AsPointer(ref this), ppRectCol);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(32)]
        [return: NativeTypeName("HRESULT")]
        public int getBoundingClientRect(IHTMLRect** ppRect)
        {
            return ((delegate* unmanaged<IHTMLDOMRange*, IHTMLRect**, int>)(lpVtbl[32]))((IHTMLDOMRange*)Unsafe.AsPointer(ref this), ppRect);
        }
    }
}
