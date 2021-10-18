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
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
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
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfoCount([NativeTypeName("UINT *")] uint* pctinfo)
        {
            return ((delegate* unmanaged<IHTMLEventObj2*, uint*, int>)(lpVtbl[3]))((IHTMLEventObj2*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfo([NativeTypeName("UINT")] uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<IHTMLEventObj2*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IHTMLEventObj2*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, [NativeTypeName("UINT")] uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<IHTMLEventObj2*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IHTMLEventObj2*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, [NativeTypeName("UINT *")] uint* puArgErr)
        {
            return ((delegate* unmanaged<IHTMLEventObj2*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IHTMLEventObj2*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int setAttribute([NativeTypeName("BSTR")] ushort* strAttributeName, VARIANT AttributeValue, [NativeTypeName("LONG")] int lFlags = 1)
        {
            return ((delegate* unmanaged<IHTMLEventObj2*, ushort*, VARIANT, int, int>)(lpVtbl[7]))((IHTMLEventObj2*)Unsafe.AsPointer(ref this), strAttributeName, AttributeValue, lFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int getAttribute([NativeTypeName("BSTR")] ushort* strAttributeName, [NativeTypeName("LONG")] int lFlags, VARIANT* AttributeValue)
        {
            return ((delegate* unmanaged<IHTMLEventObj2*, ushort*, int, VARIANT*, int>)(lpVtbl[8]))((IHTMLEventObj2*)Unsafe.AsPointer(ref this), strAttributeName, lFlags, AttributeValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("HRESULT")]
        public int removeAttribute([NativeTypeName("BSTR")] ushort* strAttributeName, [NativeTypeName("LONG")] int lFlags, [NativeTypeName("VARIANT_BOOL *")] short* pfSuccess)
        {
            return ((delegate* unmanaged<IHTMLEventObj2*, ushort*, int, short*, int>)(lpVtbl[9]))((IHTMLEventObj2*)Unsafe.AsPointer(ref this), strAttributeName, lFlags, pfSuccess);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        [return: NativeTypeName("HRESULT")]
        public int put_propertyName([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLEventObj2*, ushort*, int>)(lpVtbl[10]))((IHTMLEventObj2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        [return: NativeTypeName("HRESULT")]
        public int get_propertyName([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLEventObj2*, ushort**, int>)(lpVtbl[11]))((IHTMLEventObj2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        [return: NativeTypeName("HRESULT")]
        public int putref_bookmarks(IHTMLBookmarkCollection* v)
        {
            return ((delegate* unmanaged<IHTMLEventObj2*, IHTMLBookmarkCollection*, int>)(lpVtbl[12]))((IHTMLEventObj2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        [return: NativeTypeName("HRESULT")]
        public int get_bookmarks(IHTMLBookmarkCollection** p)
        {
            return ((delegate* unmanaged<IHTMLEventObj2*, IHTMLBookmarkCollection**, int>)(lpVtbl[13]))((IHTMLEventObj2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        [return: NativeTypeName("HRESULT")]
        public int putref_recordset(IDispatch* v)
        {
            return ((delegate* unmanaged<IHTMLEventObj2*, IDispatch*, int>)(lpVtbl[14]))((IHTMLEventObj2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        [return: NativeTypeName("HRESULT")]
        public int get_recordset(IDispatch** p)
        {
            return ((delegate* unmanaged<IHTMLEventObj2*, IDispatch**, int>)(lpVtbl[15]))((IHTMLEventObj2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        [return: NativeTypeName("HRESULT")]
        public int put_dataFld([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLEventObj2*, ushort*, int>)(lpVtbl[16]))((IHTMLEventObj2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        [return: NativeTypeName("HRESULT")]
        public int get_dataFld([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLEventObj2*, ushort**, int>)(lpVtbl[17]))((IHTMLEventObj2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        [return: NativeTypeName("HRESULT")]
        public int putref_boundElements(IHTMLElementCollection* v)
        {
            return ((delegate* unmanaged<IHTMLEventObj2*, IHTMLElementCollection*, int>)(lpVtbl[18]))((IHTMLEventObj2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        [return: NativeTypeName("HRESULT")]
        public int get_boundElements(IHTMLElementCollection** p)
        {
            return ((delegate* unmanaged<IHTMLEventObj2*, IHTMLElementCollection**, int>)(lpVtbl[19]))((IHTMLEventObj2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        [return: NativeTypeName("HRESULT")]
        public int put_repeat([NativeTypeName("VARIANT_BOOL")] short v)
        {
            return ((delegate* unmanaged<IHTMLEventObj2*, short, int>)(lpVtbl[20]))((IHTMLEventObj2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        [return: NativeTypeName("HRESULT")]
        public int get_repeat([NativeTypeName("VARIANT_BOOL *")] short* p)
        {
            return ((delegate* unmanaged<IHTMLEventObj2*, short*, int>)(lpVtbl[21]))((IHTMLEventObj2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(22)]
        [return: NativeTypeName("HRESULT")]
        public int put_srcUrn([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLEventObj2*, ushort*, int>)(lpVtbl[22]))((IHTMLEventObj2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(23)]
        [return: NativeTypeName("HRESULT")]
        public int get_srcUrn([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLEventObj2*, ushort**, int>)(lpVtbl[23]))((IHTMLEventObj2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(24)]
        [return: NativeTypeName("HRESULT")]
        public int putref_srcElement(IHTMLElement* v)
        {
            return ((delegate* unmanaged<IHTMLEventObj2*, IHTMLElement*, int>)(lpVtbl[24]))((IHTMLEventObj2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(25)]
        [return: NativeTypeName("HRESULT")]
        public int get_srcElement(IHTMLElement** p)
        {
            return ((delegate* unmanaged<IHTMLEventObj2*, IHTMLElement**, int>)(lpVtbl[25]))((IHTMLEventObj2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(26)]
        [return: NativeTypeName("HRESULT")]
        public int put_altKey([NativeTypeName("VARIANT_BOOL")] short v)
        {
            return ((delegate* unmanaged<IHTMLEventObj2*, short, int>)(lpVtbl[26]))((IHTMLEventObj2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(27)]
        [return: NativeTypeName("HRESULT")]
        public int get_altKey([NativeTypeName("VARIANT_BOOL *")] short* p)
        {
            return ((delegate* unmanaged<IHTMLEventObj2*, short*, int>)(lpVtbl[27]))((IHTMLEventObj2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(28)]
        [return: NativeTypeName("HRESULT")]
        public int put_ctrlKey([NativeTypeName("VARIANT_BOOL")] short v)
        {
            return ((delegate* unmanaged<IHTMLEventObj2*, short, int>)(lpVtbl[28]))((IHTMLEventObj2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(29)]
        [return: NativeTypeName("HRESULT")]
        public int get_ctrlKey([NativeTypeName("VARIANT_BOOL *")] short* p)
        {
            return ((delegate* unmanaged<IHTMLEventObj2*, short*, int>)(lpVtbl[29]))((IHTMLEventObj2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(30)]
        [return: NativeTypeName("HRESULT")]
        public int put_shiftKey([NativeTypeName("VARIANT_BOOL")] short v)
        {
            return ((delegate* unmanaged<IHTMLEventObj2*, short, int>)(lpVtbl[30]))((IHTMLEventObj2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(31)]
        [return: NativeTypeName("HRESULT")]
        public int get_shiftKey([NativeTypeName("VARIANT_BOOL *")] short* p)
        {
            return ((delegate* unmanaged<IHTMLEventObj2*, short*, int>)(lpVtbl[31]))((IHTMLEventObj2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(32)]
        [return: NativeTypeName("HRESULT")]
        public int putref_fromElement(IHTMLElement* v)
        {
            return ((delegate* unmanaged<IHTMLEventObj2*, IHTMLElement*, int>)(lpVtbl[32]))((IHTMLEventObj2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(33)]
        [return: NativeTypeName("HRESULT")]
        public int get_fromElement(IHTMLElement** p)
        {
            return ((delegate* unmanaged<IHTMLEventObj2*, IHTMLElement**, int>)(lpVtbl[33]))((IHTMLEventObj2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(34)]
        [return: NativeTypeName("HRESULT")]
        public int putref_toElement(IHTMLElement* v)
        {
            return ((delegate* unmanaged<IHTMLEventObj2*, IHTMLElement*, int>)(lpVtbl[34]))((IHTMLEventObj2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(35)]
        [return: NativeTypeName("HRESULT")]
        public int get_toElement(IHTMLElement** p)
        {
            return ((delegate* unmanaged<IHTMLEventObj2*, IHTMLElement**, int>)(lpVtbl[35]))((IHTMLEventObj2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(36)]
        [return: NativeTypeName("HRESULT")]
        public int put_button([NativeTypeName("long")] int v)
        {
            return ((delegate* unmanaged<IHTMLEventObj2*, int, int>)(lpVtbl[36]))((IHTMLEventObj2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(37)]
        [return: NativeTypeName("HRESULT")]
        public int get_button([NativeTypeName("long *")] int* p)
        {
            return ((delegate* unmanaged<IHTMLEventObj2*, int*, int>)(lpVtbl[37]))((IHTMLEventObj2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(38)]
        [return: NativeTypeName("HRESULT")]
        public int put_type([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLEventObj2*, ushort*, int>)(lpVtbl[38]))((IHTMLEventObj2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(39)]
        [return: NativeTypeName("HRESULT")]
        public int get_type([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLEventObj2*, ushort**, int>)(lpVtbl[39]))((IHTMLEventObj2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(40)]
        [return: NativeTypeName("HRESULT")]
        public int put_qualifier([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLEventObj2*, ushort*, int>)(lpVtbl[40]))((IHTMLEventObj2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(41)]
        [return: NativeTypeName("HRESULT")]
        public int get_qualifier([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLEventObj2*, ushort**, int>)(lpVtbl[41]))((IHTMLEventObj2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(42)]
        [return: NativeTypeName("HRESULT")]
        public int put_reason([NativeTypeName("long")] int v)
        {
            return ((delegate* unmanaged<IHTMLEventObj2*, int, int>)(lpVtbl[42]))((IHTMLEventObj2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(43)]
        [return: NativeTypeName("HRESULT")]
        public int get_reason([NativeTypeName("long *")] int* p)
        {
            return ((delegate* unmanaged<IHTMLEventObj2*, int*, int>)(lpVtbl[43]))((IHTMLEventObj2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(44)]
        [return: NativeTypeName("HRESULT")]
        public int put_x([NativeTypeName("long")] int v)
        {
            return ((delegate* unmanaged<IHTMLEventObj2*, int, int>)(lpVtbl[44]))((IHTMLEventObj2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(45)]
        [return: NativeTypeName("HRESULT")]
        public int get_x([NativeTypeName("long *")] int* p)
        {
            return ((delegate* unmanaged<IHTMLEventObj2*, int*, int>)(lpVtbl[45]))((IHTMLEventObj2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(46)]
        [return: NativeTypeName("HRESULT")]
        public int put_y([NativeTypeName("long")] int v)
        {
            return ((delegate* unmanaged<IHTMLEventObj2*, int, int>)(lpVtbl[46]))((IHTMLEventObj2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(47)]
        [return: NativeTypeName("HRESULT")]
        public int get_y([NativeTypeName("long *")] int* p)
        {
            return ((delegate* unmanaged<IHTMLEventObj2*, int*, int>)(lpVtbl[47]))((IHTMLEventObj2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(48)]
        [return: NativeTypeName("HRESULT")]
        public int put_clientX([NativeTypeName("long")] int v)
        {
            return ((delegate* unmanaged<IHTMLEventObj2*, int, int>)(lpVtbl[48]))((IHTMLEventObj2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(49)]
        [return: NativeTypeName("HRESULT")]
        public int get_clientX([NativeTypeName("long *")] int* p)
        {
            return ((delegate* unmanaged<IHTMLEventObj2*, int*, int>)(lpVtbl[49]))((IHTMLEventObj2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(50)]
        [return: NativeTypeName("HRESULT")]
        public int put_clientY([NativeTypeName("long")] int v)
        {
            return ((delegate* unmanaged<IHTMLEventObj2*, int, int>)(lpVtbl[50]))((IHTMLEventObj2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(51)]
        [return: NativeTypeName("HRESULT")]
        public int get_clientY([NativeTypeName("long *")] int* p)
        {
            return ((delegate* unmanaged<IHTMLEventObj2*, int*, int>)(lpVtbl[51]))((IHTMLEventObj2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(52)]
        [return: NativeTypeName("HRESULT")]
        public int put_offsetX([NativeTypeName("long")] int v)
        {
            return ((delegate* unmanaged<IHTMLEventObj2*, int, int>)(lpVtbl[52]))((IHTMLEventObj2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(53)]
        [return: NativeTypeName("HRESULT")]
        public int get_offsetX([NativeTypeName("long *")] int* p)
        {
            return ((delegate* unmanaged<IHTMLEventObj2*, int*, int>)(lpVtbl[53]))((IHTMLEventObj2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(54)]
        [return: NativeTypeName("HRESULT")]
        public int put_offsetY([NativeTypeName("long")] int v)
        {
            return ((delegate* unmanaged<IHTMLEventObj2*, int, int>)(lpVtbl[54]))((IHTMLEventObj2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(55)]
        [return: NativeTypeName("HRESULT")]
        public int get_offsetY([NativeTypeName("long *")] int* p)
        {
            return ((delegate* unmanaged<IHTMLEventObj2*, int*, int>)(lpVtbl[55]))((IHTMLEventObj2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(56)]
        [return: NativeTypeName("HRESULT")]
        public int put_screenX([NativeTypeName("long")] int v)
        {
            return ((delegate* unmanaged<IHTMLEventObj2*, int, int>)(lpVtbl[56]))((IHTMLEventObj2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(57)]
        [return: NativeTypeName("HRESULT")]
        public int get_screenX([NativeTypeName("long *")] int* p)
        {
            return ((delegate* unmanaged<IHTMLEventObj2*, int*, int>)(lpVtbl[57]))((IHTMLEventObj2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(58)]
        [return: NativeTypeName("HRESULT")]
        public int put_screenY([NativeTypeName("long")] int v)
        {
            return ((delegate* unmanaged<IHTMLEventObj2*, int, int>)(lpVtbl[58]))((IHTMLEventObj2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(59)]
        [return: NativeTypeName("HRESULT")]
        public int get_screenY([NativeTypeName("long *")] int* p)
        {
            return ((delegate* unmanaged<IHTMLEventObj2*, int*, int>)(lpVtbl[59]))((IHTMLEventObj2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(60)]
        [return: NativeTypeName("HRESULT")]
        public int putref_srcFilter(IDispatch* v)
        {
            return ((delegate* unmanaged<IHTMLEventObj2*, IDispatch*, int>)(lpVtbl[60]))((IHTMLEventObj2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(61)]
        [return: NativeTypeName("HRESULT")]
        public int get_srcFilter(IDispatch** p)
        {
            return ((delegate* unmanaged<IHTMLEventObj2*, IDispatch**, int>)(lpVtbl[61]))((IHTMLEventObj2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(62)]
        [return: NativeTypeName("HRESULT")]
        public int get_dataTransfer(IHTMLDataTransfer** p)
        {
            return ((delegate* unmanaged<IHTMLEventObj2*, IHTMLDataTransfer**, int>)(lpVtbl[62]))((IHTMLEventObj2*)Unsafe.AsPointer(ref this), p);
        }
    }
}
