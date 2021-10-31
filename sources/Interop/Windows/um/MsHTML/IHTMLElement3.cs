// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("3050F673-98B5-11CF-BB82-00AA00BDCE0B")]
    [NativeTypeName("struct IHTMLElement3 : IDispatch")]
    [NativeInheritance("IDispatch")]
    public unsafe partial struct IHTMLElement3
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IHTMLElement3*, Guid*, void**, int>)(lpVtbl[0]))((IHTMLElement3*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IHTMLElement3*, uint>)(lpVtbl[1]))((IHTMLElement3*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IHTMLElement3*, uint>)(lpVtbl[2]))((IHTMLElement3*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetTypeInfoCount([NativeTypeName("UINT *")] uint* pctinfo)
        {
            return ((delegate* unmanaged<IHTMLElement3*, uint*, int>)(lpVtbl[3]))((IHTMLElement3*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetTypeInfo([NativeTypeName("UINT")] uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<IHTMLElement3*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IHTMLElement3*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, [NativeTypeName("UINT")] uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<IHTMLElement3*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IHTMLElement3*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, [NativeTypeName("UINT *")] uint* puArgErr)
        {
            return ((delegate* unmanaged<IHTMLElement3*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IHTMLElement3*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT mergeAttributes(IHTMLElement* mergeThis, VARIANT* pvarFlags)
        {
            return ((delegate* unmanaged<IHTMLElement3*, IHTMLElement*, VARIANT*, int>)(lpVtbl[7]))((IHTMLElement3*)Unsafe.AsPointer(ref this), mergeThis, pvarFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT get_isMultiLine([NativeTypeName("VARIANT_BOOL *")] short* p)
        {
            return ((delegate* unmanaged<IHTMLElement3*, short*, int>)(lpVtbl[8]))((IHTMLElement3*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT get_canHaveHTML([NativeTypeName("VARIANT_BOOL *")] short* p)
        {
            return ((delegate* unmanaged<IHTMLElement3*, short*, int>)(lpVtbl[9]))((IHTMLElement3*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT put_onlayoutcomplete(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLElement3*, VARIANT, int>)(lpVtbl[10]))((IHTMLElement3*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT get_onlayoutcomplete(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLElement3*, VARIANT*, int>)(lpVtbl[11]))((IHTMLElement3*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT put_onpage(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLElement3*, VARIANT, int>)(lpVtbl[12]))((IHTMLElement3*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT get_onpage(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLElement3*, VARIANT*, int>)(lpVtbl[13]))((IHTMLElement3*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HRESULT put_inflateBlock([NativeTypeName("VARIANT_BOOL")] short v)
        {
            return ((delegate* unmanaged<IHTMLElement3*, short, int>)(lpVtbl[14]))((IHTMLElement3*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public HRESULT get_inflateBlock([NativeTypeName("VARIANT_BOOL *")] short* p)
        {
            return ((delegate* unmanaged<IHTMLElement3*, short*, int>)(lpVtbl[15]))((IHTMLElement3*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        public HRESULT put_onbeforedeactivate(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLElement3*, VARIANT, int>)(lpVtbl[16]))((IHTMLElement3*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        public HRESULT get_onbeforedeactivate(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLElement3*, VARIANT*, int>)(lpVtbl[17]))((IHTMLElement3*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        public HRESULT setActive()
        {
            return ((delegate* unmanaged<IHTMLElement3*, int>)(lpVtbl[18]))((IHTMLElement3*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        public HRESULT put_contentEditable([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLElement3*, ushort*, int>)(lpVtbl[19]))((IHTMLElement3*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        public HRESULT get_contentEditable([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLElement3*, ushort**, int>)(lpVtbl[20]))((IHTMLElement3*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        public HRESULT get_isContentEditable([NativeTypeName("VARIANT_BOOL *")] short* p)
        {
            return ((delegate* unmanaged<IHTMLElement3*, short*, int>)(lpVtbl[21]))((IHTMLElement3*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(22)]
        public HRESULT put_hideFocus([NativeTypeName("VARIANT_BOOL")] short v)
        {
            return ((delegate* unmanaged<IHTMLElement3*, short, int>)(lpVtbl[22]))((IHTMLElement3*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(23)]
        public HRESULT get_hideFocus([NativeTypeName("VARIANT_BOOL *")] short* p)
        {
            return ((delegate* unmanaged<IHTMLElement3*, short*, int>)(lpVtbl[23]))((IHTMLElement3*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(24)]
        public HRESULT put_disabled([NativeTypeName("VARIANT_BOOL")] short v)
        {
            return ((delegate* unmanaged<IHTMLElement3*, short, int>)(lpVtbl[24]))((IHTMLElement3*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(25)]
        public HRESULT get_disabled([NativeTypeName("VARIANT_BOOL *")] short* p)
        {
            return ((delegate* unmanaged<IHTMLElement3*, short*, int>)(lpVtbl[25]))((IHTMLElement3*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(26)]
        public HRESULT get_isDisabled([NativeTypeName("VARIANT_BOOL *")] short* p)
        {
            return ((delegate* unmanaged<IHTMLElement3*, short*, int>)(lpVtbl[26]))((IHTMLElement3*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(27)]
        public HRESULT put_onmove(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLElement3*, VARIANT, int>)(lpVtbl[27]))((IHTMLElement3*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(28)]
        public HRESULT get_onmove(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLElement3*, VARIANT*, int>)(lpVtbl[28]))((IHTMLElement3*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(29)]
        public HRESULT put_oncontrolselect(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLElement3*, VARIANT, int>)(lpVtbl[29]))((IHTMLElement3*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(30)]
        public HRESULT get_oncontrolselect(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLElement3*, VARIANT*, int>)(lpVtbl[30]))((IHTMLElement3*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(31)]
        public HRESULT fireEvent([NativeTypeName("BSTR")] ushort* bstrEventName, VARIANT* pvarEventObject, [NativeTypeName("VARIANT_BOOL *")] short* pfCancelled)
        {
            return ((delegate* unmanaged<IHTMLElement3*, ushort*, VARIANT*, short*, int>)(lpVtbl[31]))((IHTMLElement3*)Unsafe.AsPointer(ref this), bstrEventName, pvarEventObject, pfCancelled);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(32)]
        public HRESULT put_onresizestart(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLElement3*, VARIANT, int>)(lpVtbl[32]))((IHTMLElement3*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(33)]
        public HRESULT get_onresizestart(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLElement3*, VARIANT*, int>)(lpVtbl[33]))((IHTMLElement3*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(34)]
        public HRESULT put_onresizeend(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLElement3*, VARIANT, int>)(lpVtbl[34]))((IHTMLElement3*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(35)]
        public HRESULT get_onresizeend(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLElement3*, VARIANT*, int>)(lpVtbl[35]))((IHTMLElement3*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(36)]
        public HRESULT put_onmovestart(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLElement3*, VARIANT, int>)(lpVtbl[36]))((IHTMLElement3*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(37)]
        public HRESULT get_onmovestart(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLElement3*, VARIANT*, int>)(lpVtbl[37]))((IHTMLElement3*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(38)]
        public HRESULT put_onmoveend(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLElement3*, VARIANT, int>)(lpVtbl[38]))((IHTMLElement3*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(39)]
        public HRESULT get_onmoveend(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLElement3*, VARIANT*, int>)(lpVtbl[39]))((IHTMLElement3*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(40)]
        public HRESULT put_onmouseenter(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLElement3*, VARIANT, int>)(lpVtbl[40]))((IHTMLElement3*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(41)]
        public HRESULT get_onmouseenter(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLElement3*, VARIANT*, int>)(lpVtbl[41]))((IHTMLElement3*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(42)]
        public HRESULT put_onmouseleave(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLElement3*, VARIANT, int>)(lpVtbl[42]))((IHTMLElement3*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(43)]
        public HRESULT get_onmouseleave(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLElement3*, VARIANT*, int>)(lpVtbl[43]))((IHTMLElement3*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(44)]
        public HRESULT put_onactivate(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLElement3*, VARIANT, int>)(lpVtbl[44]))((IHTMLElement3*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(45)]
        public HRESULT get_onactivate(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLElement3*, VARIANT*, int>)(lpVtbl[45]))((IHTMLElement3*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(46)]
        public HRESULT put_ondeactivate(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLElement3*, VARIANT, int>)(lpVtbl[46]))((IHTMLElement3*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(47)]
        public HRESULT get_ondeactivate(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLElement3*, VARIANT*, int>)(lpVtbl[47]))((IHTMLElement3*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(48)]
        public HRESULT dragDrop([NativeTypeName("VARIANT_BOOL *")] short* pfRet)
        {
            return ((delegate* unmanaged<IHTMLElement3*, short*, int>)(lpVtbl[48]))((IHTMLElement3*)Unsafe.AsPointer(ref this), pfRet);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(49)]
        public HRESULT get_glyphMode([NativeTypeName("LONG *")] int* p)
        {
            return ((delegate* unmanaged<IHTMLElement3*, int*, int>)(lpVtbl[49]))((IHTMLElement3*)Unsafe.AsPointer(ref this), p);
        }
    }
}
