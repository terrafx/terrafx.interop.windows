// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("305106F9-98B5-11CF-BB82-00AA00BDCE0B")]
    [NativeTypeName("struct IHTMLDOMAttribute4 : IDispatch")]
    [NativeInheritance("IDispatch")]
    public unsafe partial struct IHTMLDOMAttribute4
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IHTMLDOMAttribute4*, Guid*, void**, int>)(lpVtbl[0]))((IHTMLDOMAttribute4*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IHTMLDOMAttribute4*, uint>)(lpVtbl[1]))((IHTMLDOMAttribute4*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IHTMLDOMAttribute4*, uint>)(lpVtbl[2]))((IHTMLDOMAttribute4*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfoCount([NativeTypeName("UINT *")] uint* pctinfo)
        {
            return ((delegate* unmanaged<IHTMLDOMAttribute4*, uint*, int>)(lpVtbl[3]))((IHTMLDOMAttribute4*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfo([NativeTypeName("UINT")] uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<IHTMLDOMAttribute4*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IHTMLDOMAttribute4*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, [NativeTypeName("UINT")] uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<IHTMLDOMAttribute4*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IHTMLDOMAttribute4*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, [NativeTypeName("UINT *")] uint* puArgErr)
        {
            return ((delegate* unmanaged<IHTMLDOMAttribute4*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IHTMLDOMAttribute4*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int put_nodeValue(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLDOMAttribute4*, VARIANT, int>)(lpVtbl[7]))((IHTMLDOMAttribute4*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int get_nodeValue(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLDOMAttribute4*, VARIANT*, int>)(lpVtbl[8]))((IHTMLDOMAttribute4*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("HRESULT")]
        public int get_nodeName([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLDOMAttribute4*, ushort**, int>)(lpVtbl[9]))((IHTMLDOMAttribute4*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        [return: NativeTypeName("HRESULT")]
        public int get_name([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLDOMAttribute4*, ushort**, int>)(lpVtbl[10]))((IHTMLDOMAttribute4*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        [return: NativeTypeName("HRESULT")]
        public int put_value([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLDOMAttribute4*, ushort*, int>)(lpVtbl[11]))((IHTMLDOMAttribute4*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        [return: NativeTypeName("HRESULT")]
        public int get_value([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLDOMAttribute4*, ushort**, int>)(lpVtbl[12]))((IHTMLDOMAttribute4*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        [return: NativeTypeName("HRESULT")]
        public int get_firstChild(IHTMLDOMNode** p)
        {
            return ((delegate* unmanaged<IHTMLDOMAttribute4*, IHTMLDOMNode**, int>)(lpVtbl[13]))((IHTMLDOMAttribute4*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        [return: NativeTypeName("HRESULT")]
        public int get_lastChild(IHTMLDOMNode** p)
        {
            return ((delegate* unmanaged<IHTMLDOMAttribute4*, IHTMLDOMNode**, int>)(lpVtbl[14]))((IHTMLDOMAttribute4*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        [return: NativeTypeName("HRESULT")]
        public int get_childNodes(IDispatch** p)
        {
            return ((delegate* unmanaged<IHTMLDOMAttribute4*, IDispatch**, int>)(lpVtbl[15]))((IHTMLDOMAttribute4*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        [return: NativeTypeName("HRESULT")]
        public int hasAttributes([NativeTypeName("VARIANT_BOOL *")] short* pfHasAttributes)
        {
            return ((delegate* unmanaged<IHTMLDOMAttribute4*, short*, int>)(lpVtbl[16]))((IHTMLDOMAttribute4*)Unsafe.AsPointer(ref this), pfHasAttributes);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        [return: NativeTypeName("HRESULT")]
        public int hasChildNodes([NativeTypeName("VARIANT_BOOL *")] short* fChildren)
        {
            return ((delegate* unmanaged<IHTMLDOMAttribute4*, short*, int>)(lpVtbl[17]))((IHTMLDOMAttribute4*)Unsafe.AsPointer(ref this), fChildren);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        [return: NativeTypeName("HRESULT")]
        public int normalize()
        {
            return ((delegate* unmanaged<IHTMLDOMAttribute4*, int>)(lpVtbl[18]))((IHTMLDOMAttribute4*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        [return: NativeTypeName("HRESULT")]
        public int get_specified([NativeTypeName("VARIANT_BOOL *")] short* p)
        {
            return ((delegate* unmanaged<IHTMLDOMAttribute4*, short*, int>)(lpVtbl[19]))((IHTMLDOMAttribute4*)Unsafe.AsPointer(ref this), p);
        }
    }
}
