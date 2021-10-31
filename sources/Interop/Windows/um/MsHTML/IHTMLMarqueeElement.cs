// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("3050F2B5-98B5-11CF-BB82-00AA00BDCE0B")]
    [NativeTypeName("struct IHTMLMarqueeElement : IDispatch")]
    [NativeInheritance("IDispatch")]
    public unsafe partial struct IHTMLMarqueeElement
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IHTMLMarqueeElement*, Guid*, void**, int>)(lpVtbl[0]))((IHTMLMarqueeElement*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IHTMLMarqueeElement*, uint>)(lpVtbl[1]))((IHTMLMarqueeElement*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IHTMLMarqueeElement*, uint>)(lpVtbl[2]))((IHTMLMarqueeElement*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetTypeInfoCount([NativeTypeName("UINT *")] uint* pctinfo)
        {
            return ((delegate* unmanaged<IHTMLMarqueeElement*, uint*, int>)(lpVtbl[3]))((IHTMLMarqueeElement*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetTypeInfo([NativeTypeName("UINT")] uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<IHTMLMarqueeElement*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IHTMLMarqueeElement*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, [NativeTypeName("UINT")] uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<IHTMLMarqueeElement*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IHTMLMarqueeElement*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, [NativeTypeName("UINT *")] uint* puArgErr)
        {
            return ((delegate* unmanaged<IHTMLMarqueeElement*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IHTMLMarqueeElement*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT put_bgColor(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLMarqueeElement*, VARIANT, int>)(lpVtbl[7]))((IHTMLMarqueeElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT get_bgColor(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLMarqueeElement*, VARIANT*, int>)(lpVtbl[8]))((IHTMLMarqueeElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT put_scrollDelay([NativeTypeName("long")] int v)
        {
            return ((delegate* unmanaged<IHTMLMarqueeElement*, int, int>)(lpVtbl[9]))((IHTMLMarqueeElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT get_scrollDelay([NativeTypeName("long *")] int* p)
        {
            return ((delegate* unmanaged<IHTMLMarqueeElement*, int*, int>)(lpVtbl[10]))((IHTMLMarqueeElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT put_direction([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLMarqueeElement*, ushort*, int>)(lpVtbl[11]))((IHTMLMarqueeElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT get_direction([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLMarqueeElement*, ushort**, int>)(lpVtbl[12]))((IHTMLMarqueeElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT put_behavior([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLMarqueeElement*, ushort*, int>)(lpVtbl[13]))((IHTMLMarqueeElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HRESULT get_behavior([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLMarqueeElement*, ushort**, int>)(lpVtbl[14]))((IHTMLMarqueeElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public HRESULT put_scrollAmount([NativeTypeName("long")] int v)
        {
            return ((delegate* unmanaged<IHTMLMarqueeElement*, int, int>)(lpVtbl[15]))((IHTMLMarqueeElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        public HRESULT get_scrollAmount([NativeTypeName("long *")] int* p)
        {
            return ((delegate* unmanaged<IHTMLMarqueeElement*, int*, int>)(lpVtbl[16]))((IHTMLMarqueeElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        public HRESULT put_loop([NativeTypeName("long")] int v)
        {
            return ((delegate* unmanaged<IHTMLMarqueeElement*, int, int>)(lpVtbl[17]))((IHTMLMarqueeElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        public HRESULT get_loop([NativeTypeName("long *")] int* p)
        {
            return ((delegate* unmanaged<IHTMLMarqueeElement*, int*, int>)(lpVtbl[18]))((IHTMLMarqueeElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        public HRESULT put_vspace([NativeTypeName("long")] int v)
        {
            return ((delegate* unmanaged<IHTMLMarqueeElement*, int, int>)(lpVtbl[19]))((IHTMLMarqueeElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        public HRESULT get_vspace([NativeTypeName("long *")] int* p)
        {
            return ((delegate* unmanaged<IHTMLMarqueeElement*, int*, int>)(lpVtbl[20]))((IHTMLMarqueeElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        public HRESULT put_hspace([NativeTypeName("long")] int v)
        {
            return ((delegate* unmanaged<IHTMLMarqueeElement*, int, int>)(lpVtbl[21]))((IHTMLMarqueeElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(22)]
        public HRESULT get_hspace([NativeTypeName("long *")] int* p)
        {
            return ((delegate* unmanaged<IHTMLMarqueeElement*, int*, int>)(lpVtbl[22]))((IHTMLMarqueeElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(23)]
        public HRESULT put_onfinish(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLMarqueeElement*, VARIANT, int>)(lpVtbl[23]))((IHTMLMarqueeElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(24)]
        public HRESULT get_onfinish(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLMarqueeElement*, VARIANT*, int>)(lpVtbl[24]))((IHTMLMarqueeElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(25)]
        public HRESULT put_onstart(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLMarqueeElement*, VARIANT, int>)(lpVtbl[25]))((IHTMLMarqueeElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(26)]
        public HRESULT get_onstart(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLMarqueeElement*, VARIANT*, int>)(lpVtbl[26]))((IHTMLMarqueeElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(27)]
        public HRESULT put_onbounce(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLMarqueeElement*, VARIANT, int>)(lpVtbl[27]))((IHTMLMarqueeElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(28)]
        public HRESULT get_onbounce(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLMarqueeElement*, VARIANT*, int>)(lpVtbl[28]))((IHTMLMarqueeElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(29)]
        public HRESULT put_width(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLMarqueeElement*, VARIANT, int>)(lpVtbl[29]))((IHTMLMarqueeElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(30)]
        public HRESULT get_width(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLMarqueeElement*, VARIANT*, int>)(lpVtbl[30]))((IHTMLMarqueeElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(31)]
        public HRESULT put_height(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLMarqueeElement*, VARIANT, int>)(lpVtbl[31]))((IHTMLMarqueeElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(32)]
        public HRESULT get_height(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLMarqueeElement*, VARIANT*, int>)(lpVtbl[32]))((IHTMLMarqueeElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(33)]
        public HRESULT put_trueSpeed([NativeTypeName("VARIANT_BOOL")] short v)
        {
            return ((delegate* unmanaged<IHTMLMarqueeElement*, short, int>)(lpVtbl[33]))((IHTMLMarqueeElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(34)]
        public HRESULT get_trueSpeed([NativeTypeName("VARIANT_BOOL *")] short* p)
        {
            return ((delegate* unmanaged<IHTMLMarqueeElement*, short*, int>)(lpVtbl[34]))((IHTMLMarqueeElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(35)]
        public HRESULT start()
        {
            return ((delegate* unmanaged<IHTMLMarqueeElement*, int>)(lpVtbl[35]))((IHTMLMarqueeElement*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(36)]
        public HRESULT stop()
        {
            return ((delegate* unmanaged<IHTMLMarqueeElement*, int>)(lpVtbl[36]))((IHTMLMarqueeElement*)Unsafe.AsPointer(ref this));
        }
    }
}
