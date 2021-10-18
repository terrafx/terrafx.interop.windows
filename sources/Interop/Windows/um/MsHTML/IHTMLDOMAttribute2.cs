// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("3050F810-98B5-11CF-BB82-00AA00BDCE0B")]
    [NativeTypeName("struct IHTMLDOMAttribute2 : IDispatch")]
    [NativeInheritance("IDispatch")]
    public unsafe partial struct IHTMLDOMAttribute2
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IHTMLDOMAttribute2*, Guid*, void**, int>)(lpVtbl[0]))((IHTMLDOMAttribute2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IHTMLDOMAttribute2*, uint>)(lpVtbl[1]))((IHTMLDOMAttribute2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IHTMLDOMAttribute2*, uint>)(lpVtbl[2]))((IHTMLDOMAttribute2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfoCount([NativeTypeName("UINT *")] uint* pctinfo)
        {
            return ((delegate* unmanaged<IHTMLDOMAttribute2*, uint*, int>)(lpVtbl[3]))((IHTMLDOMAttribute2*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfo([NativeTypeName("UINT")] uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<IHTMLDOMAttribute2*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IHTMLDOMAttribute2*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, [NativeTypeName("UINT")] uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<IHTMLDOMAttribute2*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IHTMLDOMAttribute2*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, [NativeTypeName("UINT *")] uint* puArgErr)
        {
            return ((delegate* unmanaged<IHTMLDOMAttribute2*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IHTMLDOMAttribute2*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int get_name([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLDOMAttribute2*, ushort**, int>)(lpVtbl[7]))((IHTMLDOMAttribute2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int put_value([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLDOMAttribute2*, ushort*, int>)(lpVtbl[8]))((IHTMLDOMAttribute2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("HRESULT")]
        public int get_value([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLDOMAttribute2*, ushort**, int>)(lpVtbl[9]))((IHTMLDOMAttribute2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        [return: NativeTypeName("HRESULT")]
        public int get_expando([NativeTypeName("VARIANT_BOOL *")] short* p)
        {
            return ((delegate* unmanaged<IHTMLDOMAttribute2*, short*, int>)(lpVtbl[10]))((IHTMLDOMAttribute2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        [return: NativeTypeName("HRESULT")]
        public int get_nodeType([NativeTypeName("long *")] int* p)
        {
            return ((delegate* unmanaged<IHTMLDOMAttribute2*, int*, int>)(lpVtbl[11]))((IHTMLDOMAttribute2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        [return: NativeTypeName("HRESULT")]
        public int get_parentNode(IHTMLDOMNode** p)
        {
            return ((delegate* unmanaged<IHTMLDOMAttribute2*, IHTMLDOMNode**, int>)(lpVtbl[12]))((IHTMLDOMAttribute2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        [return: NativeTypeName("HRESULT")]
        public int get_childNodes(IDispatch** p)
        {
            return ((delegate* unmanaged<IHTMLDOMAttribute2*, IDispatch**, int>)(lpVtbl[13]))((IHTMLDOMAttribute2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        [return: NativeTypeName("HRESULT")]
        public int get_firstChild(IHTMLDOMNode** p)
        {
            return ((delegate* unmanaged<IHTMLDOMAttribute2*, IHTMLDOMNode**, int>)(lpVtbl[14]))((IHTMLDOMAttribute2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        [return: NativeTypeName("HRESULT")]
        public int get_lastChild(IHTMLDOMNode** p)
        {
            return ((delegate* unmanaged<IHTMLDOMAttribute2*, IHTMLDOMNode**, int>)(lpVtbl[15]))((IHTMLDOMAttribute2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        [return: NativeTypeName("HRESULT")]
        public int get_previousSibling(IHTMLDOMNode** p)
        {
            return ((delegate* unmanaged<IHTMLDOMAttribute2*, IHTMLDOMNode**, int>)(lpVtbl[16]))((IHTMLDOMAttribute2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        [return: NativeTypeName("HRESULT")]
        public int get_nextSibling(IHTMLDOMNode** p)
        {
            return ((delegate* unmanaged<IHTMLDOMAttribute2*, IHTMLDOMNode**, int>)(lpVtbl[17]))((IHTMLDOMAttribute2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        [return: NativeTypeName("HRESULT")]
        public int get_attributes(IDispatch** p)
        {
            return ((delegate* unmanaged<IHTMLDOMAttribute2*, IDispatch**, int>)(lpVtbl[18]))((IHTMLDOMAttribute2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        [return: NativeTypeName("HRESULT")]
        public int get_ownerDocument(IDispatch** p)
        {
            return ((delegate* unmanaged<IHTMLDOMAttribute2*, IDispatch**, int>)(lpVtbl[19]))((IHTMLDOMAttribute2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        [return: NativeTypeName("HRESULT")]
        public int insertBefore(IHTMLDOMNode* newChild, VARIANT refChild, IHTMLDOMNode** node)
        {
            return ((delegate* unmanaged<IHTMLDOMAttribute2*, IHTMLDOMNode*, VARIANT, IHTMLDOMNode**, int>)(lpVtbl[20]))((IHTMLDOMAttribute2*)Unsafe.AsPointer(ref this), newChild, refChild, node);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        [return: NativeTypeName("HRESULT")]
        public int replaceChild(IHTMLDOMNode* newChild, IHTMLDOMNode* oldChild, IHTMLDOMNode** node)
        {
            return ((delegate* unmanaged<IHTMLDOMAttribute2*, IHTMLDOMNode*, IHTMLDOMNode*, IHTMLDOMNode**, int>)(lpVtbl[21]))((IHTMLDOMAttribute2*)Unsafe.AsPointer(ref this), newChild, oldChild, node);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(22)]
        [return: NativeTypeName("HRESULT")]
        public int removeChild(IHTMLDOMNode* oldChild, IHTMLDOMNode** node)
        {
            return ((delegate* unmanaged<IHTMLDOMAttribute2*, IHTMLDOMNode*, IHTMLDOMNode**, int>)(lpVtbl[22]))((IHTMLDOMAttribute2*)Unsafe.AsPointer(ref this), oldChild, node);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(23)]
        [return: NativeTypeName("HRESULT")]
        public int appendChild(IHTMLDOMNode* newChild, IHTMLDOMNode** node)
        {
            return ((delegate* unmanaged<IHTMLDOMAttribute2*, IHTMLDOMNode*, IHTMLDOMNode**, int>)(lpVtbl[23]))((IHTMLDOMAttribute2*)Unsafe.AsPointer(ref this), newChild, node);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(24)]
        [return: NativeTypeName("HRESULT")]
        public int hasChildNodes([NativeTypeName("VARIANT_BOOL *")] short* fChildren)
        {
            return ((delegate* unmanaged<IHTMLDOMAttribute2*, short*, int>)(lpVtbl[24]))((IHTMLDOMAttribute2*)Unsafe.AsPointer(ref this), fChildren);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(25)]
        [return: NativeTypeName("HRESULT")]
        public int cloneNode([NativeTypeName("VARIANT_BOOL")] short fDeep, IHTMLDOMAttribute** clonedNode)
        {
            return ((delegate* unmanaged<IHTMLDOMAttribute2*, short, IHTMLDOMAttribute**, int>)(lpVtbl[25]))((IHTMLDOMAttribute2*)Unsafe.AsPointer(ref this), fDeep, clonedNode);
        }
    }
}
