// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("305107AA-98B5-11CF-BB82-00AA00BDCE0B")]
    [NativeTypeName("struct IHTMLElement7 : IDispatch")]
    [NativeInheritance("IDispatch")]
    public unsafe partial struct IHTMLElement7
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IHTMLElement7*, Guid*, void**, int>)(lpVtbl[0]))((IHTMLElement7*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IHTMLElement7*, uint>)(lpVtbl[1]))((IHTMLElement7*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IHTMLElement7*, uint>)(lpVtbl[2]))((IHTMLElement7*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetTypeInfoCount(uint* pctinfo)
        {
            return ((delegate* unmanaged<IHTMLElement7*, uint*, int>)(lpVtbl[3]))((IHTMLElement7*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<IHTMLElement7*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IHTMLElement7*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<IHTMLElement7*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IHTMLElement7*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
        {
            return ((delegate* unmanaged<IHTMLElement7*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IHTMLElement7*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT put_onmspointerdown(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLElement7*, VARIANT, int>)(lpVtbl[7]))((IHTMLElement7*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT get_onmspointerdown(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLElement7*, VARIANT*, int>)(lpVtbl[8]))((IHTMLElement7*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT put_onmspointermove(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLElement7*, VARIANT, int>)(lpVtbl[9]))((IHTMLElement7*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT get_onmspointermove(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLElement7*, VARIANT*, int>)(lpVtbl[10]))((IHTMLElement7*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT put_onmspointerup(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLElement7*, VARIANT, int>)(lpVtbl[11]))((IHTMLElement7*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT get_onmspointerup(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLElement7*, VARIANT*, int>)(lpVtbl[12]))((IHTMLElement7*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT put_onmspointerover(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLElement7*, VARIANT, int>)(lpVtbl[13]))((IHTMLElement7*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HRESULT get_onmspointerover(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLElement7*, VARIANT*, int>)(lpVtbl[14]))((IHTMLElement7*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public HRESULT put_onmspointerout(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLElement7*, VARIANT, int>)(lpVtbl[15]))((IHTMLElement7*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        public HRESULT get_onmspointerout(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLElement7*, VARIANT*, int>)(lpVtbl[16]))((IHTMLElement7*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        public HRESULT put_onmspointercancel(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLElement7*, VARIANT, int>)(lpVtbl[17]))((IHTMLElement7*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        public HRESULT get_onmspointercancel(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLElement7*, VARIANT*, int>)(lpVtbl[18]))((IHTMLElement7*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        public HRESULT put_onmspointerhover(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLElement7*, VARIANT, int>)(lpVtbl[19]))((IHTMLElement7*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        public HRESULT get_onmspointerhover(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLElement7*, VARIANT*, int>)(lpVtbl[20]))((IHTMLElement7*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        public HRESULT put_onmslostpointercapture(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLElement7*, VARIANT, int>)(lpVtbl[21]))((IHTMLElement7*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(22)]
        public HRESULT get_onmslostpointercapture(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLElement7*, VARIANT*, int>)(lpVtbl[22]))((IHTMLElement7*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(23)]
        public HRESULT put_onmsgotpointercapture(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLElement7*, VARIANT, int>)(lpVtbl[23]))((IHTMLElement7*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(24)]
        public HRESULT get_onmsgotpointercapture(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLElement7*, VARIANT*, int>)(lpVtbl[24]))((IHTMLElement7*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(25)]
        public HRESULT put_onmsgesturestart(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLElement7*, VARIANT, int>)(lpVtbl[25]))((IHTMLElement7*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(26)]
        public HRESULT get_onmsgesturestart(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLElement7*, VARIANT*, int>)(lpVtbl[26]))((IHTMLElement7*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(27)]
        public HRESULT put_onmsgesturechange(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLElement7*, VARIANT, int>)(lpVtbl[27]))((IHTMLElement7*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(28)]
        public HRESULT get_onmsgesturechange(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLElement7*, VARIANT*, int>)(lpVtbl[28]))((IHTMLElement7*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(29)]
        public HRESULT put_onmsgestureend(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLElement7*, VARIANT, int>)(lpVtbl[29]))((IHTMLElement7*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(30)]
        public HRESULT get_onmsgestureend(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLElement7*, VARIANT*, int>)(lpVtbl[30]))((IHTMLElement7*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(31)]
        public HRESULT put_onmsgesturehold(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLElement7*, VARIANT, int>)(lpVtbl[31]))((IHTMLElement7*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(32)]
        public HRESULT get_onmsgesturehold(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLElement7*, VARIANT*, int>)(lpVtbl[32]))((IHTMLElement7*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(33)]
        public HRESULT put_onmsgesturetap(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLElement7*, VARIANT, int>)(lpVtbl[33]))((IHTMLElement7*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(34)]
        public HRESULT get_onmsgesturetap(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLElement7*, VARIANT*, int>)(lpVtbl[34]))((IHTMLElement7*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(35)]
        public HRESULT put_onmsgesturedoubletap(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLElement7*, VARIANT, int>)(lpVtbl[35]))((IHTMLElement7*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(36)]
        public HRESULT get_onmsgesturedoubletap(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLElement7*, VARIANT*, int>)(lpVtbl[36]))((IHTMLElement7*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(37)]
        public HRESULT put_onmsinertiastart(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLElement7*, VARIANT, int>)(lpVtbl[37]))((IHTMLElement7*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(38)]
        public HRESULT get_onmsinertiastart(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLElement7*, VARIANT*, int>)(lpVtbl[38]))((IHTMLElement7*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(39)]
        public HRESULT msSetPointerCapture([NativeTypeName("long")] int pointerId)
        {
            return ((delegate* unmanaged<IHTMLElement7*, int, int>)(lpVtbl[39]))((IHTMLElement7*)Unsafe.AsPointer(ref this), pointerId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(40)]
        public HRESULT msReleasePointerCapture([NativeTypeName("long")] int pointerId)
        {
            return ((delegate* unmanaged<IHTMLElement7*, int, int>)(lpVtbl[40]))((IHTMLElement7*)Unsafe.AsPointer(ref this), pointerId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(41)]
        public HRESULT put_onmstransitionstart(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLElement7*, VARIANT, int>)(lpVtbl[41]))((IHTMLElement7*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(42)]
        public HRESULT get_onmstransitionstart(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLElement7*, VARIANT*, int>)(lpVtbl[42]))((IHTMLElement7*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(43)]
        public HRESULT put_onmstransitionend(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLElement7*, VARIANT, int>)(lpVtbl[43]))((IHTMLElement7*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(44)]
        public HRESULT get_onmstransitionend(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLElement7*, VARIANT*, int>)(lpVtbl[44]))((IHTMLElement7*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(45)]
        public HRESULT put_onmsanimationstart(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLElement7*, VARIANT, int>)(lpVtbl[45]))((IHTMLElement7*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(46)]
        public HRESULT get_onmsanimationstart(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLElement7*, VARIANT*, int>)(lpVtbl[46]))((IHTMLElement7*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(47)]
        public HRESULT put_onmsanimationend(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLElement7*, VARIANT, int>)(lpVtbl[47]))((IHTMLElement7*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(48)]
        public HRESULT get_onmsanimationend(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLElement7*, VARIANT*, int>)(lpVtbl[48]))((IHTMLElement7*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(49)]
        public HRESULT put_onmsanimationiteration(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLElement7*, VARIANT, int>)(lpVtbl[49]))((IHTMLElement7*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(50)]
        public HRESULT get_onmsanimationiteration(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLElement7*, VARIANT*, int>)(lpVtbl[50]))((IHTMLElement7*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(51)]
        public HRESULT put_oninvalid(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLElement7*, VARIANT, int>)(lpVtbl[51]))((IHTMLElement7*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(52)]
        public HRESULT get_oninvalid(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLElement7*, VARIANT*, int>)(lpVtbl[52]))((IHTMLElement7*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(53)]
        public HRESULT put_xmsAcceleratorKey([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLElement7*, ushort*, int>)(lpVtbl[53]))((IHTMLElement7*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(54)]
        public HRESULT get_xmsAcceleratorKey([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLElement7*, ushort**, int>)(lpVtbl[54]))((IHTMLElement7*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(55)]
        public HRESULT put_spellcheck(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLElement7*, VARIANT, int>)(lpVtbl[55]))((IHTMLElement7*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(56)]
        public HRESULT get_spellcheck(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLElement7*, VARIANT*, int>)(lpVtbl[56]))((IHTMLElement7*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(57)]
        public HRESULT put_onmsmanipulationstatechanged(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLElement7*, VARIANT, int>)(lpVtbl[57]))((IHTMLElement7*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(58)]
        public HRESULT get_onmsmanipulationstatechanged(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLElement7*, VARIANT*, int>)(lpVtbl[58]))((IHTMLElement7*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(59)]
        public HRESULT put_oncuechange(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLElement7*, VARIANT, int>)(lpVtbl[59]))((IHTMLElement7*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(60)]
        public HRESULT get_oncuechange(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLElement7*, VARIANT*, int>)(lpVtbl[60]))((IHTMLElement7*)Unsafe.AsPointer(ref this), p);
        }
    }
}
