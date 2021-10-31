// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("3050F48B-98B5-11CF-BB82-00AA00BDCE0B")]
    [NativeTypeName("struct IHTMLEventObj2 : IDispatch")]
    [NativeInheritance("IDispatch")]
    public unsafe partial struct IHTMLEventObj2
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IHTMLEventObj2*, Guid*, void**, int>)(lpVtbl[0]))((IHTMLEventObj2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IHTMLEventObj2*, uint>)(lpVtbl[1]))((IHTMLEventObj2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IHTMLEventObj2*, uint>)(lpVtbl[2]))((IHTMLEventObj2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetTypeInfoCount([NativeTypeName("UINT *")] uint* pctinfo)
        {
            return ((delegate* unmanaged<IHTMLEventObj2*, uint*, int>)(lpVtbl[3]))((IHTMLEventObj2*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetTypeInfo([NativeTypeName("UINT")] uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<IHTMLEventObj2*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IHTMLEventObj2*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, [NativeTypeName("UINT")] uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<IHTMLEventObj2*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IHTMLEventObj2*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, [NativeTypeName("UINT *")] uint* puArgErr)
        {
            return ((delegate* unmanaged<IHTMLEventObj2*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IHTMLEventObj2*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT setAttribute([NativeTypeName("BSTR")] ushort* strAttributeName, VARIANT AttributeValue, [NativeTypeName("LONG")] int lFlags = 1)
        {
            return ((delegate* unmanaged<IHTMLEventObj2*, ushort*, VARIANT, int, int>)(lpVtbl[7]))((IHTMLEventObj2*)Unsafe.AsPointer(ref this), strAttributeName, AttributeValue, lFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT getAttribute([NativeTypeName("BSTR")] ushort* strAttributeName, [NativeTypeName("LONG")] int lFlags, VARIANT* AttributeValue)
        {
            return ((delegate* unmanaged<IHTMLEventObj2*, ushort*, int, VARIANT*, int>)(lpVtbl[8]))((IHTMLEventObj2*)Unsafe.AsPointer(ref this), strAttributeName, lFlags, AttributeValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT removeAttribute([NativeTypeName("BSTR")] ushort* strAttributeName, [NativeTypeName("LONG")] int lFlags, [NativeTypeName("VARIANT_BOOL *")] short* pfSuccess)
        {
            return ((delegate* unmanaged<IHTMLEventObj2*, ushort*, int, short*, int>)(lpVtbl[9]))((IHTMLEventObj2*)Unsafe.AsPointer(ref this), strAttributeName, lFlags, pfSuccess);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT put_propertyName([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLEventObj2*, ushort*, int>)(lpVtbl[10]))((IHTMLEventObj2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT get_propertyName([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLEventObj2*, ushort**, int>)(lpVtbl[11]))((IHTMLEventObj2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT putref_bookmarks(IHTMLBookmarkCollection* v)
        {
            return ((delegate* unmanaged<IHTMLEventObj2*, IHTMLBookmarkCollection*, int>)(lpVtbl[12]))((IHTMLEventObj2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT get_bookmarks(IHTMLBookmarkCollection** p)
        {
            return ((delegate* unmanaged<IHTMLEventObj2*, IHTMLBookmarkCollection**, int>)(lpVtbl[13]))((IHTMLEventObj2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HRESULT putref_recordset(IDispatch* v)
        {
            return ((delegate* unmanaged<IHTMLEventObj2*, IDispatch*, int>)(lpVtbl[14]))((IHTMLEventObj2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public HRESULT get_recordset(IDispatch** p)
        {
            return ((delegate* unmanaged<IHTMLEventObj2*, IDispatch**, int>)(lpVtbl[15]))((IHTMLEventObj2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        public HRESULT put_dataFld([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLEventObj2*, ushort*, int>)(lpVtbl[16]))((IHTMLEventObj2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        public HRESULT get_dataFld([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLEventObj2*, ushort**, int>)(lpVtbl[17]))((IHTMLEventObj2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        public HRESULT putref_boundElements(IHTMLElementCollection* v)
        {
            return ((delegate* unmanaged<IHTMLEventObj2*, IHTMLElementCollection*, int>)(lpVtbl[18]))((IHTMLEventObj2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        public HRESULT get_boundElements(IHTMLElementCollection** p)
        {
            return ((delegate* unmanaged<IHTMLEventObj2*, IHTMLElementCollection**, int>)(lpVtbl[19]))((IHTMLEventObj2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        public HRESULT put_repeat([NativeTypeName("VARIANT_BOOL")] short v)
        {
            return ((delegate* unmanaged<IHTMLEventObj2*, short, int>)(lpVtbl[20]))((IHTMLEventObj2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        public HRESULT get_repeat([NativeTypeName("VARIANT_BOOL *")] short* p)
        {
            return ((delegate* unmanaged<IHTMLEventObj2*, short*, int>)(lpVtbl[21]))((IHTMLEventObj2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(22)]
        public HRESULT put_srcUrn([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLEventObj2*, ushort*, int>)(lpVtbl[22]))((IHTMLEventObj2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(23)]
        public HRESULT get_srcUrn([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLEventObj2*, ushort**, int>)(lpVtbl[23]))((IHTMLEventObj2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(24)]
        public HRESULT putref_srcElement(IHTMLElement* v)
        {
            return ((delegate* unmanaged<IHTMLEventObj2*, IHTMLElement*, int>)(lpVtbl[24]))((IHTMLEventObj2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(25)]
        public HRESULT get_srcElement(IHTMLElement** p)
        {
            return ((delegate* unmanaged<IHTMLEventObj2*, IHTMLElement**, int>)(lpVtbl[25]))((IHTMLEventObj2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(26)]
        public HRESULT put_altKey([NativeTypeName("VARIANT_BOOL")] short v)
        {
            return ((delegate* unmanaged<IHTMLEventObj2*, short, int>)(lpVtbl[26]))((IHTMLEventObj2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(27)]
        public HRESULT get_altKey([NativeTypeName("VARIANT_BOOL *")] short* p)
        {
            return ((delegate* unmanaged<IHTMLEventObj2*, short*, int>)(lpVtbl[27]))((IHTMLEventObj2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(28)]
        public HRESULT put_ctrlKey([NativeTypeName("VARIANT_BOOL")] short v)
        {
            return ((delegate* unmanaged<IHTMLEventObj2*, short, int>)(lpVtbl[28]))((IHTMLEventObj2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(29)]
        public HRESULT get_ctrlKey([NativeTypeName("VARIANT_BOOL *")] short* p)
        {
            return ((delegate* unmanaged<IHTMLEventObj2*, short*, int>)(lpVtbl[29]))((IHTMLEventObj2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(30)]
        public HRESULT put_shiftKey([NativeTypeName("VARIANT_BOOL")] short v)
        {
            return ((delegate* unmanaged<IHTMLEventObj2*, short, int>)(lpVtbl[30]))((IHTMLEventObj2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(31)]
        public HRESULT get_shiftKey([NativeTypeName("VARIANT_BOOL *")] short* p)
        {
            return ((delegate* unmanaged<IHTMLEventObj2*, short*, int>)(lpVtbl[31]))((IHTMLEventObj2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(32)]
        public HRESULT putref_fromElement(IHTMLElement* v)
        {
            return ((delegate* unmanaged<IHTMLEventObj2*, IHTMLElement*, int>)(lpVtbl[32]))((IHTMLEventObj2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(33)]
        public HRESULT get_fromElement(IHTMLElement** p)
        {
            return ((delegate* unmanaged<IHTMLEventObj2*, IHTMLElement**, int>)(lpVtbl[33]))((IHTMLEventObj2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(34)]
        public HRESULT putref_toElement(IHTMLElement* v)
        {
            return ((delegate* unmanaged<IHTMLEventObj2*, IHTMLElement*, int>)(lpVtbl[34]))((IHTMLEventObj2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(35)]
        public HRESULT get_toElement(IHTMLElement** p)
        {
            return ((delegate* unmanaged<IHTMLEventObj2*, IHTMLElement**, int>)(lpVtbl[35]))((IHTMLEventObj2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(36)]
        public HRESULT put_button([NativeTypeName("long")] int v)
        {
            return ((delegate* unmanaged<IHTMLEventObj2*, int, int>)(lpVtbl[36]))((IHTMLEventObj2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(37)]
        public HRESULT get_button([NativeTypeName("long *")] int* p)
        {
            return ((delegate* unmanaged<IHTMLEventObj2*, int*, int>)(lpVtbl[37]))((IHTMLEventObj2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(38)]
        public HRESULT put_type([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLEventObj2*, ushort*, int>)(lpVtbl[38]))((IHTMLEventObj2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(39)]
        public HRESULT get_type([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLEventObj2*, ushort**, int>)(lpVtbl[39]))((IHTMLEventObj2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(40)]
        public HRESULT put_qualifier([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLEventObj2*, ushort*, int>)(lpVtbl[40]))((IHTMLEventObj2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(41)]
        public HRESULT get_qualifier([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLEventObj2*, ushort**, int>)(lpVtbl[41]))((IHTMLEventObj2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(42)]
        public HRESULT put_reason([NativeTypeName("long")] int v)
        {
            return ((delegate* unmanaged<IHTMLEventObj2*, int, int>)(lpVtbl[42]))((IHTMLEventObj2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(43)]
        public HRESULT get_reason([NativeTypeName("long *")] int* p)
        {
            return ((delegate* unmanaged<IHTMLEventObj2*, int*, int>)(lpVtbl[43]))((IHTMLEventObj2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(44)]
        public HRESULT put_x([NativeTypeName("long")] int v)
        {
            return ((delegate* unmanaged<IHTMLEventObj2*, int, int>)(lpVtbl[44]))((IHTMLEventObj2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(45)]
        public HRESULT get_x([NativeTypeName("long *")] int* p)
        {
            return ((delegate* unmanaged<IHTMLEventObj2*, int*, int>)(lpVtbl[45]))((IHTMLEventObj2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(46)]
        public HRESULT put_y([NativeTypeName("long")] int v)
        {
            return ((delegate* unmanaged<IHTMLEventObj2*, int, int>)(lpVtbl[46]))((IHTMLEventObj2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(47)]
        public HRESULT get_y([NativeTypeName("long *")] int* p)
        {
            return ((delegate* unmanaged<IHTMLEventObj2*, int*, int>)(lpVtbl[47]))((IHTMLEventObj2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(48)]
        public HRESULT put_clientX([NativeTypeName("long")] int v)
        {
            return ((delegate* unmanaged<IHTMLEventObj2*, int, int>)(lpVtbl[48]))((IHTMLEventObj2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(49)]
        public HRESULT get_clientX([NativeTypeName("long *")] int* p)
        {
            return ((delegate* unmanaged<IHTMLEventObj2*, int*, int>)(lpVtbl[49]))((IHTMLEventObj2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(50)]
        public HRESULT put_clientY([NativeTypeName("long")] int v)
        {
            return ((delegate* unmanaged<IHTMLEventObj2*, int, int>)(lpVtbl[50]))((IHTMLEventObj2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(51)]
        public HRESULT get_clientY([NativeTypeName("long *")] int* p)
        {
            return ((delegate* unmanaged<IHTMLEventObj2*, int*, int>)(lpVtbl[51]))((IHTMLEventObj2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(52)]
        public HRESULT put_offsetX([NativeTypeName("long")] int v)
        {
            return ((delegate* unmanaged<IHTMLEventObj2*, int, int>)(lpVtbl[52]))((IHTMLEventObj2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(53)]
        public HRESULT get_offsetX([NativeTypeName("long *")] int* p)
        {
            return ((delegate* unmanaged<IHTMLEventObj2*, int*, int>)(lpVtbl[53]))((IHTMLEventObj2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(54)]
        public HRESULT put_offsetY([NativeTypeName("long")] int v)
        {
            return ((delegate* unmanaged<IHTMLEventObj2*, int, int>)(lpVtbl[54]))((IHTMLEventObj2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(55)]
        public HRESULT get_offsetY([NativeTypeName("long *")] int* p)
        {
            return ((delegate* unmanaged<IHTMLEventObj2*, int*, int>)(lpVtbl[55]))((IHTMLEventObj2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(56)]
        public HRESULT put_screenX([NativeTypeName("long")] int v)
        {
            return ((delegate* unmanaged<IHTMLEventObj2*, int, int>)(lpVtbl[56]))((IHTMLEventObj2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(57)]
        public HRESULT get_screenX([NativeTypeName("long *")] int* p)
        {
            return ((delegate* unmanaged<IHTMLEventObj2*, int*, int>)(lpVtbl[57]))((IHTMLEventObj2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(58)]
        public HRESULT put_screenY([NativeTypeName("long")] int v)
        {
            return ((delegate* unmanaged<IHTMLEventObj2*, int, int>)(lpVtbl[58]))((IHTMLEventObj2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(59)]
        public HRESULT get_screenY([NativeTypeName("long *")] int* p)
        {
            return ((delegate* unmanaged<IHTMLEventObj2*, int*, int>)(lpVtbl[59]))((IHTMLEventObj2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(60)]
        public HRESULT putref_srcFilter(IDispatch* v)
        {
            return ((delegate* unmanaged<IHTMLEventObj2*, IDispatch*, int>)(lpVtbl[60]))((IHTMLEventObj2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(61)]
        public HRESULT get_srcFilter(IDispatch** p)
        {
            return ((delegate* unmanaged<IHTMLEventObj2*, IDispatch**, int>)(lpVtbl[61]))((IHTMLEventObj2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(62)]
        public HRESULT get_dataTransfer(IHTMLDataTransfer** p)
        {
            return ((delegate* unmanaged<IHTMLEventObj2*, IHTMLDataTransfer**, int>)(lpVtbl[62]))((IHTMLEventObj2*)Unsafe.AsPointer(ref this), p);
        }
    }
}
