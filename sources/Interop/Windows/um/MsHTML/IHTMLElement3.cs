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
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
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
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfoCount([NativeTypeName("UINT *")] uint* pctinfo)
        {
            return ((delegate* unmanaged<IHTMLElement3*, uint*, int>)(lpVtbl[3]))((IHTMLElement3*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfo([NativeTypeName("UINT")] uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<IHTMLElement3*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IHTMLElement3*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, [NativeTypeName("UINT")] uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<IHTMLElement3*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IHTMLElement3*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, [NativeTypeName("UINT *")] uint* puArgErr)
        {
            return ((delegate* unmanaged<IHTMLElement3*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IHTMLElement3*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int mergeAttributes(IHTMLElement* mergeThis, VARIANT* pvarFlags)
        {
            return ((delegate* unmanaged<IHTMLElement3*, IHTMLElement*, VARIANT*, int>)(lpVtbl[7]))((IHTMLElement3*)Unsafe.AsPointer(ref this), mergeThis, pvarFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int get_isMultiLine([NativeTypeName("VARIANT_BOOL *")] short* p)
        {
            return ((delegate* unmanaged<IHTMLElement3*, short*, int>)(lpVtbl[8]))((IHTMLElement3*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("HRESULT")]
        public int get_canHaveHTML([NativeTypeName("VARIANT_BOOL *")] short* p)
        {
            return ((delegate* unmanaged<IHTMLElement3*, short*, int>)(lpVtbl[9]))((IHTMLElement3*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        [return: NativeTypeName("HRESULT")]
        public int put_onlayoutcomplete(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLElement3*, VARIANT, int>)(lpVtbl[10]))((IHTMLElement3*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        [return: NativeTypeName("HRESULT")]
        public int get_onlayoutcomplete(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLElement3*, VARIANT*, int>)(lpVtbl[11]))((IHTMLElement3*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        [return: NativeTypeName("HRESULT")]
        public int put_onpage(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLElement3*, VARIANT, int>)(lpVtbl[12]))((IHTMLElement3*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        [return: NativeTypeName("HRESULT")]
        public int get_onpage(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLElement3*, VARIANT*, int>)(lpVtbl[13]))((IHTMLElement3*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        [return: NativeTypeName("HRESULT")]
        public int put_inflateBlock([NativeTypeName("VARIANT_BOOL")] short v)
        {
            return ((delegate* unmanaged<IHTMLElement3*, short, int>)(lpVtbl[14]))((IHTMLElement3*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        [return: NativeTypeName("HRESULT")]
        public int get_inflateBlock([NativeTypeName("VARIANT_BOOL *")] short* p)
        {
            return ((delegate* unmanaged<IHTMLElement3*, short*, int>)(lpVtbl[15]))((IHTMLElement3*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        [return: NativeTypeName("HRESULT")]
        public int put_onbeforedeactivate(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLElement3*, VARIANT, int>)(lpVtbl[16]))((IHTMLElement3*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        [return: NativeTypeName("HRESULT")]
        public int get_onbeforedeactivate(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLElement3*, VARIANT*, int>)(lpVtbl[17]))((IHTMLElement3*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        [return: NativeTypeName("HRESULT")]
        public int setActive()
        {
            return ((delegate* unmanaged<IHTMLElement3*, int>)(lpVtbl[18]))((IHTMLElement3*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        [return: NativeTypeName("HRESULT")]
        public int put_contentEditable([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLElement3*, ushort*, int>)(lpVtbl[19]))((IHTMLElement3*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        [return: NativeTypeName("HRESULT")]
        public int get_contentEditable([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLElement3*, ushort**, int>)(lpVtbl[20]))((IHTMLElement3*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        [return: NativeTypeName("HRESULT")]
        public int get_isContentEditable([NativeTypeName("VARIANT_BOOL *")] short* p)
        {
            return ((delegate* unmanaged<IHTMLElement3*, short*, int>)(lpVtbl[21]))((IHTMLElement3*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(22)]
        [return: NativeTypeName("HRESULT")]
        public int put_hideFocus([NativeTypeName("VARIANT_BOOL")] short v)
        {
            return ((delegate* unmanaged<IHTMLElement3*, short, int>)(lpVtbl[22]))((IHTMLElement3*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(23)]
        [return: NativeTypeName("HRESULT")]
        public int get_hideFocus([NativeTypeName("VARIANT_BOOL *")] short* p)
        {
            return ((delegate* unmanaged<IHTMLElement3*, short*, int>)(lpVtbl[23]))((IHTMLElement3*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(24)]
        [return: NativeTypeName("HRESULT")]
        public int put_disabled([NativeTypeName("VARIANT_BOOL")] short v)
        {
            return ((delegate* unmanaged<IHTMLElement3*, short, int>)(lpVtbl[24]))((IHTMLElement3*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(25)]
        [return: NativeTypeName("HRESULT")]
        public int get_disabled([NativeTypeName("VARIANT_BOOL *")] short* p)
        {
            return ((delegate* unmanaged<IHTMLElement3*, short*, int>)(lpVtbl[25]))((IHTMLElement3*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(26)]
        [return: NativeTypeName("HRESULT")]
        public int get_isDisabled([NativeTypeName("VARIANT_BOOL *")] short* p)
        {
            return ((delegate* unmanaged<IHTMLElement3*, short*, int>)(lpVtbl[26]))((IHTMLElement3*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(27)]
        [return: NativeTypeName("HRESULT")]
        public int put_onmove(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLElement3*, VARIANT, int>)(lpVtbl[27]))((IHTMLElement3*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(28)]
        [return: NativeTypeName("HRESULT")]
        public int get_onmove(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLElement3*, VARIANT*, int>)(lpVtbl[28]))((IHTMLElement3*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(29)]
        [return: NativeTypeName("HRESULT")]
        public int put_oncontrolselect(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLElement3*, VARIANT, int>)(lpVtbl[29]))((IHTMLElement3*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(30)]
        [return: NativeTypeName("HRESULT")]
        public int get_oncontrolselect(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLElement3*, VARIANT*, int>)(lpVtbl[30]))((IHTMLElement3*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(31)]
        [return: NativeTypeName("HRESULT")]
        public int fireEvent([NativeTypeName("BSTR")] ushort* bstrEventName, VARIANT* pvarEventObject, [NativeTypeName("VARIANT_BOOL *")] short* pfCancelled)
        {
            return ((delegate* unmanaged<IHTMLElement3*, ushort*, VARIANT*, short*, int>)(lpVtbl[31]))((IHTMLElement3*)Unsafe.AsPointer(ref this), bstrEventName, pvarEventObject, pfCancelled);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(32)]
        [return: NativeTypeName("HRESULT")]
        public int put_onresizestart(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLElement3*, VARIANT, int>)(lpVtbl[32]))((IHTMLElement3*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(33)]
        [return: NativeTypeName("HRESULT")]
        public int get_onresizestart(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLElement3*, VARIANT*, int>)(lpVtbl[33]))((IHTMLElement3*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(34)]
        [return: NativeTypeName("HRESULT")]
        public int put_onresizeend(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLElement3*, VARIANT, int>)(lpVtbl[34]))((IHTMLElement3*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(35)]
        [return: NativeTypeName("HRESULT")]
        public int get_onresizeend(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLElement3*, VARIANT*, int>)(lpVtbl[35]))((IHTMLElement3*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(36)]
        [return: NativeTypeName("HRESULT")]
        public int put_onmovestart(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLElement3*, VARIANT, int>)(lpVtbl[36]))((IHTMLElement3*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(37)]
        [return: NativeTypeName("HRESULT")]
        public int get_onmovestart(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLElement3*, VARIANT*, int>)(lpVtbl[37]))((IHTMLElement3*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(38)]
        [return: NativeTypeName("HRESULT")]
        public int put_onmoveend(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLElement3*, VARIANT, int>)(lpVtbl[38]))((IHTMLElement3*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(39)]
        [return: NativeTypeName("HRESULT")]
        public int get_onmoveend(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLElement3*, VARIANT*, int>)(lpVtbl[39]))((IHTMLElement3*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(40)]
        [return: NativeTypeName("HRESULT")]
        public int put_onmouseenter(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLElement3*, VARIANT, int>)(lpVtbl[40]))((IHTMLElement3*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(41)]
        [return: NativeTypeName("HRESULT")]
        public int get_onmouseenter(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLElement3*, VARIANT*, int>)(lpVtbl[41]))((IHTMLElement3*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(42)]
        [return: NativeTypeName("HRESULT")]
        public int put_onmouseleave(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLElement3*, VARIANT, int>)(lpVtbl[42]))((IHTMLElement3*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(43)]
        [return: NativeTypeName("HRESULT")]
        public int get_onmouseleave(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLElement3*, VARIANT*, int>)(lpVtbl[43]))((IHTMLElement3*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(44)]
        [return: NativeTypeName("HRESULT")]
        public int put_onactivate(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLElement3*, VARIANT, int>)(lpVtbl[44]))((IHTMLElement3*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(45)]
        [return: NativeTypeName("HRESULT")]
        public int get_onactivate(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLElement3*, VARIANT*, int>)(lpVtbl[45]))((IHTMLElement3*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(46)]
        [return: NativeTypeName("HRESULT")]
        public int put_ondeactivate(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLElement3*, VARIANT, int>)(lpVtbl[46]))((IHTMLElement3*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(47)]
        [return: NativeTypeName("HRESULT")]
        public int get_ondeactivate(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLElement3*, VARIANT*, int>)(lpVtbl[47]))((IHTMLElement3*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(48)]
        [return: NativeTypeName("HRESULT")]
        public int dragDrop([NativeTypeName("VARIANT_BOOL *")] short* pfRet)
        {
            return ((delegate* unmanaged<IHTMLElement3*, short*, int>)(lpVtbl[48]))((IHTMLElement3*)Unsafe.AsPointer(ref this), pfRet);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(49)]
        [return: NativeTypeName("HRESULT")]
        public int get_glyphMode([NativeTypeName("LONG *")] int* p)
        {
            return ((delegate* unmanaged<IHTMLElement3*, int*, int>)(lpVtbl[49]))((IHTMLElement3*)Unsafe.AsPointer(ref this), p);
        }
    }
}
