// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("3050F434-98B5-11CF-BB82-00AA00BDCE0B")]
    [NativeTypeName("struct IHTMLElement2 : IDispatch")]
    [NativeInheritance("IDispatch")]
    public unsafe partial struct IHTMLElement2
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IHTMLElement2*, Guid*, void**, int>)(lpVtbl[0]))((IHTMLElement2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IHTMLElement2*, uint>)(lpVtbl[1]))((IHTMLElement2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IHTMLElement2*, uint>)(lpVtbl[2]))((IHTMLElement2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfoCount([NativeTypeName("UINT *")] uint* pctinfo)
        {
            return ((delegate* unmanaged<IHTMLElement2*, uint*, int>)(lpVtbl[3]))((IHTMLElement2*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfo([NativeTypeName("UINT")] uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<IHTMLElement2*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IHTMLElement2*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, [NativeTypeName("UINT")] uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<IHTMLElement2*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IHTMLElement2*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, [NativeTypeName("UINT *")] uint* puArgErr)
        {
            return ((delegate* unmanaged<IHTMLElement2*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IHTMLElement2*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int get_scopeName([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLElement2*, ushort**, int>)(lpVtbl[7]))((IHTMLElement2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int setCapture([NativeTypeName("VARIANT_BOOL")] short containerCapture = -1)
        {
            return ((delegate* unmanaged<IHTMLElement2*, short, int>)(lpVtbl[8]))((IHTMLElement2*)Unsafe.AsPointer(ref this), containerCapture);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("HRESULT")]
        public int releaseCapture()
        {
            return ((delegate* unmanaged<IHTMLElement2*, int>)(lpVtbl[9]))((IHTMLElement2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        [return: NativeTypeName("HRESULT")]
        public int put_onlosecapture(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLElement2*, VARIANT, int>)(lpVtbl[10]))((IHTMLElement2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        [return: NativeTypeName("HRESULT")]
        public int get_onlosecapture(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLElement2*, VARIANT*, int>)(lpVtbl[11]))((IHTMLElement2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        [return: NativeTypeName("HRESULT")]
        public int componentFromPoint([NativeTypeName("long")] int x, [NativeTypeName("long")] int y, [NativeTypeName("BSTR *")] ushort** component)
        {
            return ((delegate* unmanaged<IHTMLElement2*, int, int, ushort**, int>)(lpVtbl[12]))((IHTMLElement2*)Unsafe.AsPointer(ref this), x, y, component);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        [return: NativeTypeName("HRESULT")]
        public int doScroll(VARIANT component)
        {
            return ((delegate* unmanaged<IHTMLElement2*, VARIANT, int>)(lpVtbl[13]))((IHTMLElement2*)Unsafe.AsPointer(ref this), component);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        [return: NativeTypeName("HRESULT")]
        public int put_onscroll(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLElement2*, VARIANT, int>)(lpVtbl[14]))((IHTMLElement2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        [return: NativeTypeName("HRESULT")]
        public int get_onscroll(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLElement2*, VARIANT*, int>)(lpVtbl[15]))((IHTMLElement2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        [return: NativeTypeName("HRESULT")]
        public int put_ondrag(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLElement2*, VARIANT, int>)(lpVtbl[16]))((IHTMLElement2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        [return: NativeTypeName("HRESULT")]
        public int get_ondrag(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLElement2*, VARIANT*, int>)(lpVtbl[17]))((IHTMLElement2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        [return: NativeTypeName("HRESULT")]
        public int put_ondragend(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLElement2*, VARIANT, int>)(lpVtbl[18]))((IHTMLElement2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        [return: NativeTypeName("HRESULT")]
        public int get_ondragend(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLElement2*, VARIANT*, int>)(lpVtbl[19]))((IHTMLElement2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        [return: NativeTypeName("HRESULT")]
        public int put_ondragenter(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLElement2*, VARIANT, int>)(lpVtbl[20]))((IHTMLElement2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        [return: NativeTypeName("HRESULT")]
        public int get_ondragenter(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLElement2*, VARIANT*, int>)(lpVtbl[21]))((IHTMLElement2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(22)]
        [return: NativeTypeName("HRESULT")]
        public int put_ondragover(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLElement2*, VARIANT, int>)(lpVtbl[22]))((IHTMLElement2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(23)]
        [return: NativeTypeName("HRESULT")]
        public int get_ondragover(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLElement2*, VARIANT*, int>)(lpVtbl[23]))((IHTMLElement2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(24)]
        [return: NativeTypeName("HRESULT")]
        public int put_ondragleave(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLElement2*, VARIANT, int>)(lpVtbl[24]))((IHTMLElement2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(25)]
        [return: NativeTypeName("HRESULT")]
        public int get_ondragleave(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLElement2*, VARIANT*, int>)(lpVtbl[25]))((IHTMLElement2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(26)]
        [return: NativeTypeName("HRESULT")]
        public int put_ondrop(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLElement2*, VARIANT, int>)(lpVtbl[26]))((IHTMLElement2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(27)]
        [return: NativeTypeName("HRESULT")]
        public int get_ondrop(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLElement2*, VARIANT*, int>)(lpVtbl[27]))((IHTMLElement2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(28)]
        [return: NativeTypeName("HRESULT")]
        public int put_onbeforecut(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLElement2*, VARIANT, int>)(lpVtbl[28]))((IHTMLElement2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(29)]
        [return: NativeTypeName("HRESULT")]
        public int get_onbeforecut(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLElement2*, VARIANT*, int>)(lpVtbl[29]))((IHTMLElement2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(30)]
        [return: NativeTypeName("HRESULT")]
        public int put_oncut(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLElement2*, VARIANT, int>)(lpVtbl[30]))((IHTMLElement2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(31)]
        [return: NativeTypeName("HRESULT")]
        public int get_oncut(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLElement2*, VARIANT*, int>)(lpVtbl[31]))((IHTMLElement2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(32)]
        [return: NativeTypeName("HRESULT")]
        public int put_onbeforecopy(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLElement2*, VARIANT, int>)(lpVtbl[32]))((IHTMLElement2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(33)]
        [return: NativeTypeName("HRESULT")]
        public int get_onbeforecopy(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLElement2*, VARIANT*, int>)(lpVtbl[33]))((IHTMLElement2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(34)]
        [return: NativeTypeName("HRESULT")]
        public int put_oncopy(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLElement2*, VARIANT, int>)(lpVtbl[34]))((IHTMLElement2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(35)]
        [return: NativeTypeName("HRESULT")]
        public int get_oncopy(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLElement2*, VARIANT*, int>)(lpVtbl[35]))((IHTMLElement2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(36)]
        [return: NativeTypeName("HRESULT")]
        public int put_onbeforepaste(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLElement2*, VARIANT, int>)(lpVtbl[36]))((IHTMLElement2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(37)]
        [return: NativeTypeName("HRESULT")]
        public int get_onbeforepaste(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLElement2*, VARIANT*, int>)(lpVtbl[37]))((IHTMLElement2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(38)]
        [return: NativeTypeName("HRESULT")]
        public int put_onpaste(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLElement2*, VARIANT, int>)(lpVtbl[38]))((IHTMLElement2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(39)]
        [return: NativeTypeName("HRESULT")]
        public int get_onpaste(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLElement2*, VARIANT*, int>)(lpVtbl[39]))((IHTMLElement2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(40)]
        [return: NativeTypeName("HRESULT")]
        public int get_currentStyle(IHTMLCurrentStyle** p)
        {
            return ((delegate* unmanaged<IHTMLElement2*, IHTMLCurrentStyle**, int>)(lpVtbl[40]))((IHTMLElement2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(41)]
        [return: NativeTypeName("HRESULT")]
        public int put_onpropertychange(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLElement2*, VARIANT, int>)(lpVtbl[41]))((IHTMLElement2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(42)]
        [return: NativeTypeName("HRESULT")]
        public int get_onpropertychange(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLElement2*, VARIANT*, int>)(lpVtbl[42]))((IHTMLElement2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(43)]
        [return: NativeTypeName("HRESULT")]
        public int getClientRects(IHTMLRectCollection** pRectCol)
        {
            return ((delegate* unmanaged<IHTMLElement2*, IHTMLRectCollection**, int>)(lpVtbl[43]))((IHTMLElement2*)Unsafe.AsPointer(ref this), pRectCol);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(44)]
        [return: NativeTypeName("HRESULT")]
        public int getBoundingClientRect(IHTMLRect** pRect)
        {
            return ((delegate* unmanaged<IHTMLElement2*, IHTMLRect**, int>)(lpVtbl[44]))((IHTMLElement2*)Unsafe.AsPointer(ref this), pRect);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(45)]
        [return: NativeTypeName("HRESULT")]
        public int setExpression([NativeTypeName("BSTR")] ushort* propname, [NativeTypeName("BSTR")] ushort* expression, [NativeTypeName("BSTR")] ushort* language = null)
        {
            return ((delegate* unmanaged<IHTMLElement2*, ushort*, ushort*, ushort*, int>)(lpVtbl[45]))((IHTMLElement2*)Unsafe.AsPointer(ref this), propname, expression, language);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(46)]
        [return: NativeTypeName("HRESULT")]
        public int getExpression([NativeTypeName("BSTR")] ushort* propname, VARIANT* expression)
        {
            return ((delegate* unmanaged<IHTMLElement2*, ushort*, VARIANT*, int>)(lpVtbl[46]))((IHTMLElement2*)Unsafe.AsPointer(ref this), propname, expression);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(47)]
        [return: NativeTypeName("HRESULT")]
        public int removeExpression([NativeTypeName("BSTR")] ushort* propname, [NativeTypeName("VARIANT_BOOL *")] short* pfSuccess)
        {
            return ((delegate* unmanaged<IHTMLElement2*, ushort*, short*, int>)(lpVtbl[47]))((IHTMLElement2*)Unsafe.AsPointer(ref this), propname, pfSuccess);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(48)]
        [return: NativeTypeName("HRESULT")]
        public int put_tabIndex(short v)
        {
            return ((delegate* unmanaged<IHTMLElement2*, short, int>)(lpVtbl[48]))((IHTMLElement2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(49)]
        [return: NativeTypeName("HRESULT")]
        public int get_tabIndex(short* p)
        {
            return ((delegate* unmanaged<IHTMLElement2*, short*, int>)(lpVtbl[49]))((IHTMLElement2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(50)]
        [return: NativeTypeName("HRESULT")]
        public int focus()
        {
            return ((delegate* unmanaged<IHTMLElement2*, int>)(lpVtbl[50]))((IHTMLElement2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(51)]
        [return: NativeTypeName("HRESULT")]
        public int put_accessKey([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLElement2*, ushort*, int>)(lpVtbl[51]))((IHTMLElement2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(52)]
        [return: NativeTypeName("HRESULT")]
        public int get_accessKey([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLElement2*, ushort**, int>)(lpVtbl[52]))((IHTMLElement2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(53)]
        [return: NativeTypeName("HRESULT")]
        public int put_onblur(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLElement2*, VARIANT, int>)(lpVtbl[53]))((IHTMLElement2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(54)]
        [return: NativeTypeName("HRESULT")]
        public int get_onblur(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLElement2*, VARIANT*, int>)(lpVtbl[54]))((IHTMLElement2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(55)]
        [return: NativeTypeName("HRESULT")]
        public int put_onfocus(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLElement2*, VARIANT, int>)(lpVtbl[55]))((IHTMLElement2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(56)]
        [return: NativeTypeName("HRESULT")]
        public int get_onfocus(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLElement2*, VARIANT*, int>)(lpVtbl[56]))((IHTMLElement2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(57)]
        [return: NativeTypeName("HRESULT")]
        public int put_onresize(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLElement2*, VARIANT, int>)(lpVtbl[57]))((IHTMLElement2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(58)]
        [return: NativeTypeName("HRESULT")]
        public int get_onresize(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLElement2*, VARIANT*, int>)(lpVtbl[58]))((IHTMLElement2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(59)]
        [return: NativeTypeName("HRESULT")]
        public int blur()
        {
            return ((delegate* unmanaged<IHTMLElement2*, int>)(lpVtbl[59]))((IHTMLElement2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(60)]
        [return: NativeTypeName("HRESULT")]
        public int addFilter(IUnknown* pUnk)
        {
            return ((delegate* unmanaged<IHTMLElement2*, IUnknown*, int>)(lpVtbl[60]))((IHTMLElement2*)Unsafe.AsPointer(ref this), pUnk);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(61)]
        [return: NativeTypeName("HRESULT")]
        public int removeFilter(IUnknown* pUnk)
        {
            return ((delegate* unmanaged<IHTMLElement2*, IUnknown*, int>)(lpVtbl[61]))((IHTMLElement2*)Unsafe.AsPointer(ref this), pUnk);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(62)]
        [return: NativeTypeName("HRESULT")]
        public int get_clientHeight([NativeTypeName("long *")] int* p)
        {
            return ((delegate* unmanaged<IHTMLElement2*, int*, int>)(lpVtbl[62]))((IHTMLElement2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(63)]
        [return: NativeTypeName("HRESULT")]
        public int get_clientWidth([NativeTypeName("long *")] int* p)
        {
            return ((delegate* unmanaged<IHTMLElement2*, int*, int>)(lpVtbl[63]))((IHTMLElement2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(64)]
        [return: NativeTypeName("HRESULT")]
        public int get_clientTop([NativeTypeName("long *")] int* p)
        {
            return ((delegate* unmanaged<IHTMLElement2*, int*, int>)(lpVtbl[64]))((IHTMLElement2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(65)]
        [return: NativeTypeName("HRESULT")]
        public int get_clientLeft([NativeTypeName("long *")] int* p)
        {
            return ((delegate* unmanaged<IHTMLElement2*, int*, int>)(lpVtbl[65]))((IHTMLElement2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(66)]
        [return: NativeTypeName("HRESULT")]
        public int attachEvent([NativeTypeName("BSTR")] ushort* @event, IDispatch* pDisp, [NativeTypeName("VARIANT_BOOL *")] short* pfResult)
        {
            return ((delegate* unmanaged<IHTMLElement2*, ushort*, IDispatch*, short*, int>)(lpVtbl[66]))((IHTMLElement2*)Unsafe.AsPointer(ref this), @event, pDisp, pfResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(67)]
        [return: NativeTypeName("HRESULT")]
        public int detachEvent([NativeTypeName("BSTR")] ushort* @event, IDispatch* pDisp)
        {
            return ((delegate* unmanaged<IHTMLElement2*, ushort*, IDispatch*, int>)(lpVtbl[67]))((IHTMLElement2*)Unsafe.AsPointer(ref this), @event, pDisp);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(68)]
        [return: NativeTypeName("HRESULT")]
        public int get_readyState(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLElement2*, VARIANT*, int>)(lpVtbl[68]))((IHTMLElement2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(69)]
        [return: NativeTypeName("HRESULT")]
        public int put_onreadystatechange(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLElement2*, VARIANT, int>)(lpVtbl[69]))((IHTMLElement2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(70)]
        [return: NativeTypeName("HRESULT")]
        public int get_onreadystatechange(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLElement2*, VARIANT*, int>)(lpVtbl[70]))((IHTMLElement2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(71)]
        [return: NativeTypeName("HRESULT")]
        public int put_onrowsdelete(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLElement2*, VARIANT, int>)(lpVtbl[71]))((IHTMLElement2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(72)]
        [return: NativeTypeName("HRESULT")]
        public int get_onrowsdelete(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLElement2*, VARIANT*, int>)(lpVtbl[72]))((IHTMLElement2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(73)]
        [return: NativeTypeName("HRESULT")]
        public int put_onrowsinserted(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLElement2*, VARIANT, int>)(lpVtbl[73]))((IHTMLElement2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(74)]
        [return: NativeTypeName("HRESULT")]
        public int get_onrowsinserted(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLElement2*, VARIANT*, int>)(lpVtbl[74]))((IHTMLElement2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(75)]
        [return: NativeTypeName("HRESULT")]
        public int put_oncellchange(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLElement2*, VARIANT, int>)(lpVtbl[75]))((IHTMLElement2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(76)]
        [return: NativeTypeName("HRESULT")]
        public int get_oncellchange(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLElement2*, VARIANT*, int>)(lpVtbl[76]))((IHTMLElement2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(77)]
        [return: NativeTypeName("HRESULT")]
        public int put_dir([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLElement2*, ushort*, int>)(lpVtbl[77]))((IHTMLElement2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(78)]
        [return: NativeTypeName("HRESULT")]
        public int get_dir([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLElement2*, ushort**, int>)(lpVtbl[78]))((IHTMLElement2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(79)]
        [return: NativeTypeName("HRESULT")]
        public int createControlRange(IDispatch** range)
        {
            return ((delegate* unmanaged<IHTMLElement2*, IDispatch**, int>)(lpVtbl[79]))((IHTMLElement2*)Unsafe.AsPointer(ref this), range);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(80)]
        [return: NativeTypeName("HRESULT")]
        public int get_scrollHeight([NativeTypeName("long *")] int* p)
        {
            return ((delegate* unmanaged<IHTMLElement2*, int*, int>)(lpVtbl[80]))((IHTMLElement2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(81)]
        [return: NativeTypeName("HRESULT")]
        public int get_scrollWidth([NativeTypeName("long *")] int* p)
        {
            return ((delegate* unmanaged<IHTMLElement2*, int*, int>)(lpVtbl[81]))((IHTMLElement2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(82)]
        [return: NativeTypeName("HRESULT")]
        public int put_scrollTop([NativeTypeName("long")] int v)
        {
            return ((delegate* unmanaged<IHTMLElement2*, int, int>)(lpVtbl[82]))((IHTMLElement2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(83)]
        [return: NativeTypeName("HRESULT")]
        public int get_scrollTop([NativeTypeName("long *")] int* p)
        {
            return ((delegate* unmanaged<IHTMLElement2*, int*, int>)(lpVtbl[83]))((IHTMLElement2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(84)]
        [return: NativeTypeName("HRESULT")]
        public int put_scrollLeft([NativeTypeName("long")] int v)
        {
            return ((delegate* unmanaged<IHTMLElement2*, int, int>)(lpVtbl[84]))((IHTMLElement2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(85)]
        [return: NativeTypeName("HRESULT")]
        public int get_scrollLeft([NativeTypeName("long *")] int* p)
        {
            return ((delegate* unmanaged<IHTMLElement2*, int*, int>)(lpVtbl[85]))((IHTMLElement2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(86)]
        [return: NativeTypeName("HRESULT")]
        public int clearAttributes()
        {
            return ((delegate* unmanaged<IHTMLElement2*, int>)(lpVtbl[86]))((IHTMLElement2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(87)]
        [return: NativeTypeName("HRESULT")]
        public int mergeAttributes(IHTMLElement* mergeThis)
        {
            return ((delegate* unmanaged<IHTMLElement2*, IHTMLElement*, int>)(lpVtbl[87]))((IHTMLElement2*)Unsafe.AsPointer(ref this), mergeThis);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(88)]
        [return: NativeTypeName("HRESULT")]
        public int put_oncontextmenu(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLElement2*, VARIANT, int>)(lpVtbl[88]))((IHTMLElement2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(89)]
        [return: NativeTypeName("HRESULT")]
        public int get_oncontextmenu(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLElement2*, VARIANT*, int>)(lpVtbl[89]))((IHTMLElement2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(90)]
        [return: NativeTypeName("HRESULT")]
        public int insertAdjacentElement([NativeTypeName("BSTR")] ushort* where, IHTMLElement* insertedElement, IHTMLElement** inserted)
        {
            return ((delegate* unmanaged<IHTMLElement2*, ushort*, IHTMLElement*, IHTMLElement**, int>)(lpVtbl[90]))((IHTMLElement2*)Unsafe.AsPointer(ref this), where, insertedElement, inserted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(91)]
        [return: NativeTypeName("HRESULT")]
        public int applyElement(IHTMLElement* apply, [NativeTypeName("BSTR")] ushort* where, IHTMLElement** applied)
        {
            return ((delegate* unmanaged<IHTMLElement2*, IHTMLElement*, ushort*, IHTMLElement**, int>)(lpVtbl[91]))((IHTMLElement2*)Unsafe.AsPointer(ref this), apply, where, applied);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(92)]
        [return: NativeTypeName("HRESULT")]
        public int getAdjacentText([NativeTypeName("BSTR")] ushort* where, [NativeTypeName("BSTR *")] ushort** text)
        {
            return ((delegate* unmanaged<IHTMLElement2*, ushort*, ushort**, int>)(lpVtbl[92]))((IHTMLElement2*)Unsafe.AsPointer(ref this), where, text);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(93)]
        [return: NativeTypeName("HRESULT")]
        public int replaceAdjacentText([NativeTypeName("BSTR")] ushort* where, [NativeTypeName("BSTR")] ushort* newText, [NativeTypeName("BSTR *")] ushort** oldText)
        {
            return ((delegate* unmanaged<IHTMLElement2*, ushort*, ushort*, ushort**, int>)(lpVtbl[93]))((IHTMLElement2*)Unsafe.AsPointer(ref this), where, newText, oldText);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(94)]
        [return: NativeTypeName("HRESULT")]
        public int get_canHaveChildren([NativeTypeName("VARIANT_BOOL *")] short* p)
        {
            return ((delegate* unmanaged<IHTMLElement2*, short*, int>)(lpVtbl[94]))((IHTMLElement2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(95)]
        [return: NativeTypeName("HRESULT")]
        public int addBehavior([NativeTypeName("BSTR")] ushort* bstrUrl, VARIANT* pvarFactory, [NativeTypeName("long *")] int* pCookie)
        {
            return ((delegate* unmanaged<IHTMLElement2*, ushort*, VARIANT*, int*, int>)(lpVtbl[95]))((IHTMLElement2*)Unsafe.AsPointer(ref this), bstrUrl, pvarFactory, pCookie);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(96)]
        [return: NativeTypeName("HRESULT")]
        public int removeBehavior([NativeTypeName("long")] int cookie, [NativeTypeName("VARIANT_BOOL *")] short* pfResult)
        {
            return ((delegate* unmanaged<IHTMLElement2*, int, short*, int>)(lpVtbl[96]))((IHTMLElement2*)Unsafe.AsPointer(ref this), cookie, pfResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(97)]
        [return: NativeTypeName("HRESULT")]
        public int get_runtimeStyle(IHTMLStyle** p)
        {
            return ((delegate* unmanaged<IHTMLElement2*, IHTMLStyle**, int>)(lpVtbl[97]))((IHTMLElement2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(98)]
        [return: NativeTypeName("HRESULT")]
        public int get_behaviorUrns(IDispatch** p)
        {
            return ((delegate* unmanaged<IHTMLElement2*, IDispatch**, int>)(lpVtbl[98]))((IHTMLElement2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(99)]
        [return: NativeTypeName("HRESULT")]
        public int put_tagUrn([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLElement2*, ushort*, int>)(lpVtbl[99]))((IHTMLElement2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(100)]
        [return: NativeTypeName("HRESULT")]
        public int get_tagUrn([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLElement2*, ushort**, int>)(lpVtbl[100]))((IHTMLElement2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(101)]
        [return: NativeTypeName("HRESULT")]
        public int put_onbeforeeditfocus(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLElement2*, VARIANT, int>)(lpVtbl[101]))((IHTMLElement2*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(102)]
        [return: NativeTypeName("HRESULT")]
        public int get_onbeforeeditfocus(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLElement2*, VARIANT*, int>)(lpVtbl[102]))((IHTMLElement2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(103)]
        [return: NativeTypeName("HRESULT")]
        public int get_readyStateValue([NativeTypeName("long *")] int* p)
        {
            return ((delegate* unmanaged<IHTMLElement2*, int*, int>)(lpVtbl[103]))((IHTMLElement2*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(104)]
        [return: NativeTypeName("HRESULT")]
        public int getElementsByTagName([NativeTypeName("BSTR")] ushort* v, IHTMLElementCollection** pelColl)
        {
            return ((delegate* unmanaged<IHTMLElement2*, ushort*, IHTMLElementCollection**, int>)(lpVtbl[104]))((IHTMLElement2*)Unsafe.AsPointer(ref this), v, pelColl);
        }
    }
}
