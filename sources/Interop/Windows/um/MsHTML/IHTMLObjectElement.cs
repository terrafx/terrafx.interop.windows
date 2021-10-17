// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("3050F24F-98B5-11CF-BB82-00AA00BDCE0B")]
    [NativeTypeName("struct IHTMLObjectElement : IDispatch")]
    [NativeInheritance("IDispatch")]
    public unsafe partial struct IHTMLObjectElement
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IHTMLObjectElement*, Guid*, void**, int>)(lpVtbl[0]))((IHTMLObjectElement*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IHTMLObjectElement*, uint>)(lpVtbl[1]))((IHTMLObjectElement*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IHTMLObjectElement*, uint>)(lpVtbl[2]))((IHTMLObjectElement*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfoCount([NativeTypeName("UINT *")] uint* pctinfo)
        {
            return ((delegate* unmanaged<IHTMLObjectElement*, uint*, int>)(lpVtbl[3]))((IHTMLObjectElement*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfo([NativeTypeName("UINT")] uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<IHTMLObjectElement*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IHTMLObjectElement*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, [NativeTypeName("UINT")] uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<IHTMLObjectElement*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IHTMLObjectElement*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, [NativeTypeName("UINT *")] uint* puArgErr)
        {
            return ((delegate* unmanaged<IHTMLObjectElement*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IHTMLObjectElement*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int get_object(IDispatch** p)
        {
            return ((delegate* unmanaged<IHTMLObjectElement*, IDispatch**, int>)(lpVtbl[7]))((IHTMLObjectElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int get_classid([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLObjectElement*, ushort**, int>)(lpVtbl[8]))((IHTMLObjectElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("HRESULT")]
        public int get_data([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLObjectElement*, ushort**, int>)(lpVtbl[9]))((IHTMLObjectElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        [return: NativeTypeName("HRESULT")]
        public int putref_recordset(IDispatch* v)
        {
            return ((delegate* unmanaged<IHTMLObjectElement*, IDispatch*, int>)(lpVtbl[10]))((IHTMLObjectElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        [return: NativeTypeName("HRESULT")]
        public int get_recordset(IDispatch** p)
        {
            return ((delegate* unmanaged<IHTMLObjectElement*, IDispatch**, int>)(lpVtbl[11]))((IHTMLObjectElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        [return: NativeTypeName("HRESULT")]
        public int put_align([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLObjectElement*, ushort*, int>)(lpVtbl[12]))((IHTMLObjectElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        [return: NativeTypeName("HRESULT")]
        public int get_align([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLObjectElement*, ushort**, int>)(lpVtbl[13]))((IHTMLObjectElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        [return: NativeTypeName("HRESULT")]
        public int put_name([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLObjectElement*, ushort*, int>)(lpVtbl[14]))((IHTMLObjectElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        [return: NativeTypeName("HRESULT")]
        public int get_name([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLObjectElement*, ushort**, int>)(lpVtbl[15]))((IHTMLObjectElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        [return: NativeTypeName("HRESULT")]
        public int put_codeBase([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLObjectElement*, ushort*, int>)(lpVtbl[16]))((IHTMLObjectElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        [return: NativeTypeName("HRESULT")]
        public int get_codeBase([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLObjectElement*, ushort**, int>)(lpVtbl[17]))((IHTMLObjectElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        [return: NativeTypeName("HRESULT")]
        public int put_codeType([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLObjectElement*, ushort*, int>)(lpVtbl[18]))((IHTMLObjectElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        [return: NativeTypeName("HRESULT")]
        public int get_codeType([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLObjectElement*, ushort**, int>)(lpVtbl[19]))((IHTMLObjectElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        [return: NativeTypeName("HRESULT")]
        public int put_code([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLObjectElement*, ushort*, int>)(lpVtbl[20]))((IHTMLObjectElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        [return: NativeTypeName("HRESULT")]
        public int get_code([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLObjectElement*, ushort**, int>)(lpVtbl[21]))((IHTMLObjectElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(22)]
        [return: NativeTypeName("HRESULT")]
        public int get_BaseHref([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLObjectElement*, ushort**, int>)(lpVtbl[22]))((IHTMLObjectElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(23)]
        [return: NativeTypeName("HRESULT")]
        public int put_type([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLObjectElement*, ushort*, int>)(lpVtbl[23]))((IHTMLObjectElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(24)]
        [return: NativeTypeName("HRESULT")]
        public int get_type([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLObjectElement*, ushort**, int>)(lpVtbl[24]))((IHTMLObjectElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(25)]
        [return: NativeTypeName("HRESULT")]
        public int get_form(IHTMLFormElement** p)
        {
            return ((delegate* unmanaged<IHTMLObjectElement*, IHTMLFormElement**, int>)(lpVtbl[25]))((IHTMLObjectElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(26)]
        [return: NativeTypeName("HRESULT")]
        public int put_width(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLObjectElement*, VARIANT, int>)(lpVtbl[26]))((IHTMLObjectElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(27)]
        [return: NativeTypeName("HRESULT")]
        public int get_width(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLObjectElement*, VARIANT*, int>)(lpVtbl[27]))((IHTMLObjectElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(28)]
        [return: NativeTypeName("HRESULT")]
        public int put_height(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLObjectElement*, VARIANT, int>)(lpVtbl[28]))((IHTMLObjectElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(29)]
        [return: NativeTypeName("HRESULT")]
        public int get_height(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLObjectElement*, VARIANT*, int>)(lpVtbl[29]))((IHTMLObjectElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(30)]
        [return: NativeTypeName("HRESULT")]
        public int get_readyState([NativeTypeName("long *")] int* p)
        {
            return ((delegate* unmanaged<IHTMLObjectElement*, int*, int>)(lpVtbl[30]))((IHTMLObjectElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(31)]
        [return: NativeTypeName("HRESULT")]
        public int put_onreadystatechange(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLObjectElement*, VARIANT, int>)(lpVtbl[31]))((IHTMLObjectElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(32)]
        [return: NativeTypeName("HRESULT")]
        public int get_onreadystatechange(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLObjectElement*, VARIANT*, int>)(lpVtbl[32]))((IHTMLObjectElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(33)]
        [return: NativeTypeName("HRESULT")]
        public int put_onerror(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLObjectElement*, VARIANT, int>)(lpVtbl[33]))((IHTMLObjectElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(34)]
        [return: NativeTypeName("HRESULT")]
        public int get_onerror(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLObjectElement*, VARIANT*, int>)(lpVtbl[34]))((IHTMLObjectElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(35)]
        [return: NativeTypeName("HRESULT")]
        public int put_altHtml([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLObjectElement*, ushort*, int>)(lpVtbl[35]))((IHTMLObjectElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(36)]
        [return: NativeTypeName("HRESULT")]
        public int get_altHtml([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLObjectElement*, ushort**, int>)(lpVtbl[36]))((IHTMLObjectElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(37)]
        [return: NativeTypeName("HRESULT")]
        public int put_vspace([NativeTypeName("long")] int v)
        {
            return ((delegate* unmanaged<IHTMLObjectElement*, int, int>)(lpVtbl[37]))((IHTMLObjectElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(38)]
        [return: NativeTypeName("HRESULT")]
        public int get_vspace([NativeTypeName("long *")] int* p)
        {
            return ((delegate* unmanaged<IHTMLObjectElement*, int*, int>)(lpVtbl[38]))((IHTMLObjectElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(39)]
        [return: NativeTypeName("HRESULT")]
        public int put_hspace([NativeTypeName("long")] int v)
        {
            return ((delegate* unmanaged<IHTMLObjectElement*, int, int>)(lpVtbl[39]))((IHTMLObjectElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(40)]
        [return: NativeTypeName("HRESULT")]
        public int get_hspace([NativeTypeName("long *")] int* p)
        {
            return ((delegate* unmanaged<IHTMLObjectElement*, int*, int>)(lpVtbl[40]))((IHTMLObjectElement*)Unsafe.AsPointer(ref this), p);
        }
    }
}
