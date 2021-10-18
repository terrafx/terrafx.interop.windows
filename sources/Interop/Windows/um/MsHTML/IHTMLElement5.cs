// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("3051045D-98B5-11CF-BB82-00AA00BDCE0B")]
    [NativeTypeName("struct IHTMLElement5 : IDispatch")]
    [NativeInheritance("IDispatch")]
    public unsafe partial struct IHTMLElement5
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IHTMLElement5*, Guid*, void**, int>)(lpVtbl[0]))((IHTMLElement5*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IHTMLElement5*, uint>)(lpVtbl[1]))((IHTMLElement5*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IHTMLElement5*, uint>)(lpVtbl[2]))((IHTMLElement5*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfoCount([NativeTypeName("UINT *")] uint* pctinfo)
        {
            return ((delegate* unmanaged<IHTMLElement5*, uint*, int>)(lpVtbl[3]))((IHTMLElement5*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfo([NativeTypeName("UINT")] uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<IHTMLElement5*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IHTMLElement5*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, [NativeTypeName("UINT")] uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<IHTMLElement5*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IHTMLElement5*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, [NativeTypeName("UINT *")] uint* puArgErr)
        {
            return ((delegate* unmanaged<IHTMLElement5*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IHTMLElement5*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int getAttributeNode([NativeTypeName("BSTR")] ushort* bstrname, IHTMLDOMAttribute2** ppretAttribute)
        {
            return ((delegate* unmanaged<IHTMLElement5*, ushort*, IHTMLDOMAttribute2**, int>)(lpVtbl[7]))((IHTMLElement5*)Unsafe.AsPointer(ref this), bstrname, ppretAttribute);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int setAttributeNode(IHTMLDOMAttribute2* pattr, IHTMLDOMAttribute2** ppretAttribute)
        {
            return ((delegate* unmanaged<IHTMLElement5*, IHTMLDOMAttribute2*, IHTMLDOMAttribute2**, int>)(lpVtbl[8]))((IHTMLElement5*)Unsafe.AsPointer(ref this), pattr, ppretAttribute);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("HRESULT")]
        public int removeAttributeNode(IHTMLDOMAttribute2* pattr, IHTMLDOMAttribute2** ppretAttribute)
        {
            return ((delegate* unmanaged<IHTMLElement5*, IHTMLDOMAttribute2*, IHTMLDOMAttribute2**, int>)(lpVtbl[9]))((IHTMLElement5*)Unsafe.AsPointer(ref this), pattr, ppretAttribute);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        [return: NativeTypeName("HRESULT")]
        public int hasAttribute([NativeTypeName("BSTR")] ushort* name, [NativeTypeName("VARIANT_BOOL *")] short* pfHasAttribute)
        {
            return ((delegate* unmanaged<IHTMLElement5*, ushort*, short*, int>)(lpVtbl[10]))((IHTMLElement5*)Unsafe.AsPointer(ref this), name, pfHasAttribute);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        [return: NativeTypeName("HRESULT")]
        public int put_role([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLElement5*, ushort*, int>)(lpVtbl[11]))((IHTMLElement5*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        [return: NativeTypeName("HRESULT")]
        public int get_role([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLElement5*, ushort**, int>)(lpVtbl[12]))((IHTMLElement5*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        [return: NativeTypeName("HRESULT")]
        public int put_ariaBusy([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLElement5*, ushort*, int>)(lpVtbl[13]))((IHTMLElement5*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        [return: NativeTypeName("HRESULT")]
        public int get_ariaBusy([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLElement5*, ushort**, int>)(lpVtbl[14]))((IHTMLElement5*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        [return: NativeTypeName("HRESULT")]
        public int put_ariaChecked([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLElement5*, ushort*, int>)(lpVtbl[15]))((IHTMLElement5*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        [return: NativeTypeName("HRESULT")]
        public int get_ariaChecked([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLElement5*, ushort**, int>)(lpVtbl[16]))((IHTMLElement5*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        [return: NativeTypeName("HRESULT")]
        public int put_ariaDisabled([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLElement5*, ushort*, int>)(lpVtbl[17]))((IHTMLElement5*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        [return: NativeTypeName("HRESULT")]
        public int get_ariaDisabled([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLElement5*, ushort**, int>)(lpVtbl[18]))((IHTMLElement5*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        [return: NativeTypeName("HRESULT")]
        public int put_ariaExpanded([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLElement5*, ushort*, int>)(lpVtbl[19]))((IHTMLElement5*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        [return: NativeTypeName("HRESULT")]
        public int get_ariaExpanded([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLElement5*, ushort**, int>)(lpVtbl[20]))((IHTMLElement5*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        [return: NativeTypeName("HRESULT")]
        public int put_ariaHaspopup([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLElement5*, ushort*, int>)(lpVtbl[21]))((IHTMLElement5*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(22)]
        [return: NativeTypeName("HRESULT")]
        public int get_ariaHaspopup([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLElement5*, ushort**, int>)(lpVtbl[22]))((IHTMLElement5*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(23)]
        [return: NativeTypeName("HRESULT")]
        public int put_ariaHidden([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLElement5*, ushort*, int>)(lpVtbl[23]))((IHTMLElement5*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(24)]
        [return: NativeTypeName("HRESULT")]
        public int get_ariaHidden([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLElement5*, ushort**, int>)(lpVtbl[24]))((IHTMLElement5*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(25)]
        [return: NativeTypeName("HRESULT")]
        public int put_ariaInvalid([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLElement5*, ushort*, int>)(lpVtbl[25]))((IHTMLElement5*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(26)]
        [return: NativeTypeName("HRESULT")]
        public int get_ariaInvalid([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLElement5*, ushort**, int>)(lpVtbl[26]))((IHTMLElement5*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(27)]
        [return: NativeTypeName("HRESULT")]
        public int put_ariaMultiselectable([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLElement5*, ushort*, int>)(lpVtbl[27]))((IHTMLElement5*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(28)]
        [return: NativeTypeName("HRESULT")]
        public int get_ariaMultiselectable([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLElement5*, ushort**, int>)(lpVtbl[28]))((IHTMLElement5*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(29)]
        [return: NativeTypeName("HRESULT")]
        public int put_ariaPressed([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLElement5*, ushort*, int>)(lpVtbl[29]))((IHTMLElement5*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(30)]
        [return: NativeTypeName("HRESULT")]
        public int get_ariaPressed([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLElement5*, ushort**, int>)(lpVtbl[30]))((IHTMLElement5*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(31)]
        [return: NativeTypeName("HRESULT")]
        public int put_ariaReadonly([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLElement5*, ushort*, int>)(lpVtbl[31]))((IHTMLElement5*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(32)]
        [return: NativeTypeName("HRESULT")]
        public int get_ariaReadonly([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLElement5*, ushort**, int>)(lpVtbl[32]))((IHTMLElement5*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(33)]
        [return: NativeTypeName("HRESULT")]
        public int put_ariaRequired([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLElement5*, ushort*, int>)(lpVtbl[33]))((IHTMLElement5*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(34)]
        [return: NativeTypeName("HRESULT")]
        public int get_ariaRequired([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLElement5*, ushort**, int>)(lpVtbl[34]))((IHTMLElement5*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(35)]
        [return: NativeTypeName("HRESULT")]
        public int put_ariaSecret([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLElement5*, ushort*, int>)(lpVtbl[35]))((IHTMLElement5*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(36)]
        [return: NativeTypeName("HRESULT")]
        public int get_ariaSecret([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLElement5*, ushort**, int>)(lpVtbl[36]))((IHTMLElement5*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(37)]
        [return: NativeTypeName("HRESULT")]
        public int put_ariaSelected([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLElement5*, ushort*, int>)(lpVtbl[37]))((IHTMLElement5*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(38)]
        [return: NativeTypeName("HRESULT")]
        public int get_ariaSelected([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLElement5*, ushort**, int>)(lpVtbl[38]))((IHTMLElement5*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(39)]
        [return: NativeTypeName("HRESULT")]
        public int getAttribute([NativeTypeName("BSTR")] ushort* strAttributeName, VARIANT* AttributeValue)
        {
            return ((delegate* unmanaged<IHTMLElement5*, ushort*, VARIANT*, int>)(lpVtbl[39]))((IHTMLElement5*)Unsafe.AsPointer(ref this), strAttributeName, AttributeValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(40)]
        [return: NativeTypeName("HRESULT")]
        public int setAttribute([NativeTypeName("BSTR")] ushort* strAttributeName, VARIANT AttributeValue)
        {
            return ((delegate* unmanaged<IHTMLElement5*, ushort*, VARIANT, int>)(lpVtbl[40]))((IHTMLElement5*)Unsafe.AsPointer(ref this), strAttributeName, AttributeValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(41)]
        [return: NativeTypeName("HRESULT")]
        public int removeAttribute([NativeTypeName("BSTR")] ushort* strAttributeName, [NativeTypeName("VARIANT_BOOL *")] short* pfSuccess)
        {
            return ((delegate* unmanaged<IHTMLElement5*, ushort*, short*, int>)(lpVtbl[41]))((IHTMLElement5*)Unsafe.AsPointer(ref this), strAttributeName, pfSuccess);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(42)]
        [return: NativeTypeName("HRESULT")]
        public int get_attributes(IHTMLAttributeCollection3** p)
        {
            return ((delegate* unmanaged<IHTMLElement5*, IHTMLAttributeCollection3**, int>)(lpVtbl[42]))((IHTMLElement5*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(43)]
        [return: NativeTypeName("HRESULT")]
        public int put_ariaValuenow([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLElement5*, ushort*, int>)(lpVtbl[43]))((IHTMLElement5*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(44)]
        [return: NativeTypeName("HRESULT")]
        public int get_ariaValuenow([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLElement5*, ushort**, int>)(lpVtbl[44]))((IHTMLElement5*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(45)]
        [return: NativeTypeName("HRESULT")]
        public int put_ariaPosinset(short v)
        {
            return ((delegate* unmanaged<IHTMLElement5*, short, int>)(lpVtbl[45]))((IHTMLElement5*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(46)]
        [return: NativeTypeName("HRESULT")]
        public int get_ariaPosinset(short* p)
        {
            return ((delegate* unmanaged<IHTMLElement5*, short*, int>)(lpVtbl[46]))((IHTMLElement5*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(47)]
        [return: NativeTypeName("HRESULT")]
        public int put_ariaSetsize(short v)
        {
            return ((delegate* unmanaged<IHTMLElement5*, short, int>)(lpVtbl[47]))((IHTMLElement5*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(48)]
        [return: NativeTypeName("HRESULT")]
        public int get_ariaSetsize(short* p)
        {
            return ((delegate* unmanaged<IHTMLElement5*, short*, int>)(lpVtbl[48]))((IHTMLElement5*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(49)]
        [return: NativeTypeName("HRESULT")]
        public int put_ariaLevel(short v)
        {
            return ((delegate* unmanaged<IHTMLElement5*, short, int>)(lpVtbl[49]))((IHTMLElement5*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(50)]
        [return: NativeTypeName("HRESULT")]
        public int get_ariaLevel(short* p)
        {
            return ((delegate* unmanaged<IHTMLElement5*, short*, int>)(lpVtbl[50]))((IHTMLElement5*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(51)]
        [return: NativeTypeName("HRESULT")]
        public int put_ariaValuemin([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLElement5*, ushort*, int>)(lpVtbl[51]))((IHTMLElement5*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(52)]
        [return: NativeTypeName("HRESULT")]
        public int get_ariaValuemin([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLElement5*, ushort**, int>)(lpVtbl[52]))((IHTMLElement5*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(53)]
        [return: NativeTypeName("HRESULT")]
        public int put_ariaValuemax([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLElement5*, ushort*, int>)(lpVtbl[53]))((IHTMLElement5*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(54)]
        [return: NativeTypeName("HRESULT")]
        public int get_ariaValuemax([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLElement5*, ushort**, int>)(lpVtbl[54]))((IHTMLElement5*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(55)]
        [return: NativeTypeName("HRESULT")]
        public int put_ariaControls([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLElement5*, ushort*, int>)(lpVtbl[55]))((IHTMLElement5*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(56)]
        [return: NativeTypeName("HRESULT")]
        public int get_ariaControls([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLElement5*, ushort**, int>)(lpVtbl[56]))((IHTMLElement5*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(57)]
        [return: NativeTypeName("HRESULT")]
        public int put_ariaDescribedby([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLElement5*, ushort*, int>)(lpVtbl[57]))((IHTMLElement5*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(58)]
        [return: NativeTypeName("HRESULT")]
        public int get_ariaDescribedby([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLElement5*, ushort**, int>)(lpVtbl[58]))((IHTMLElement5*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(59)]
        [return: NativeTypeName("HRESULT")]
        public int put_ariaFlowto([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLElement5*, ushort*, int>)(lpVtbl[59]))((IHTMLElement5*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(60)]
        [return: NativeTypeName("HRESULT")]
        public int get_ariaFlowto([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLElement5*, ushort**, int>)(lpVtbl[60]))((IHTMLElement5*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(61)]
        [return: NativeTypeName("HRESULT")]
        public int put_ariaLabelledby([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLElement5*, ushort*, int>)(lpVtbl[61]))((IHTMLElement5*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(62)]
        [return: NativeTypeName("HRESULT")]
        public int get_ariaLabelledby([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLElement5*, ushort**, int>)(lpVtbl[62]))((IHTMLElement5*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(63)]
        [return: NativeTypeName("HRESULT")]
        public int put_ariaActivedescendant([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLElement5*, ushort*, int>)(lpVtbl[63]))((IHTMLElement5*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(64)]
        [return: NativeTypeName("HRESULT")]
        public int get_ariaActivedescendant([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLElement5*, ushort**, int>)(lpVtbl[64]))((IHTMLElement5*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(65)]
        [return: NativeTypeName("HRESULT")]
        public int put_ariaOwns([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLElement5*, ushort*, int>)(lpVtbl[65]))((IHTMLElement5*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(66)]
        [return: NativeTypeName("HRESULT")]
        public int get_ariaOwns([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLElement5*, ushort**, int>)(lpVtbl[66]))((IHTMLElement5*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(67)]
        [return: NativeTypeName("HRESULT")]
        public int hasAttributes([NativeTypeName("VARIANT_BOOL *")] short* pfHasAttributes)
        {
            return ((delegate* unmanaged<IHTMLElement5*, short*, int>)(lpVtbl[67]))((IHTMLElement5*)Unsafe.AsPointer(ref this), pfHasAttributes);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(68)]
        [return: NativeTypeName("HRESULT")]
        public int put_ariaLive([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLElement5*, ushort*, int>)(lpVtbl[68]))((IHTMLElement5*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(69)]
        [return: NativeTypeName("HRESULT")]
        public int get_ariaLive([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLElement5*, ushort**, int>)(lpVtbl[69]))((IHTMLElement5*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(70)]
        [return: NativeTypeName("HRESULT")]
        public int put_ariaRelevant([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLElement5*, ushort*, int>)(lpVtbl[70]))((IHTMLElement5*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(71)]
        [return: NativeTypeName("HRESULT")]
        public int get_ariaRelevant([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLElement5*, ushort**, int>)(lpVtbl[71]))((IHTMLElement5*)Unsafe.AsPointer(ref this), p);
        }
    }
}
