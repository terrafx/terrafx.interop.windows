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
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
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
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfoCount([NativeTypeName("UINT *")] uint* pctinfo)
        {
            return ((delegate* unmanaged<IHTMLMarqueeElement*, uint*, int>)(lpVtbl[3]))((IHTMLMarqueeElement*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfo([NativeTypeName("UINT")] uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<IHTMLMarqueeElement*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IHTMLMarqueeElement*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, [NativeTypeName("UINT")] uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<IHTMLMarqueeElement*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IHTMLMarqueeElement*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, [NativeTypeName("UINT *")] uint* puArgErr)
        {
            return ((delegate* unmanaged<IHTMLMarqueeElement*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IHTMLMarqueeElement*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int put_bgColor(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLMarqueeElement*, VARIANT, int>)(lpVtbl[7]))((IHTMLMarqueeElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int get_bgColor(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLMarqueeElement*, VARIANT*, int>)(lpVtbl[8]))((IHTMLMarqueeElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("HRESULT")]
        public int put_scrollDelay([NativeTypeName("long")] int v)
        {
            return ((delegate* unmanaged<IHTMLMarqueeElement*, int, int>)(lpVtbl[9]))((IHTMLMarqueeElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        [return: NativeTypeName("HRESULT")]
        public int get_scrollDelay([NativeTypeName("long *")] int* p)
        {
            return ((delegate* unmanaged<IHTMLMarqueeElement*, int*, int>)(lpVtbl[10]))((IHTMLMarqueeElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        [return: NativeTypeName("HRESULT")]
        public int put_direction([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLMarqueeElement*, ushort*, int>)(lpVtbl[11]))((IHTMLMarqueeElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        [return: NativeTypeName("HRESULT")]
        public int get_direction([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLMarqueeElement*, ushort**, int>)(lpVtbl[12]))((IHTMLMarqueeElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        [return: NativeTypeName("HRESULT")]
        public int put_behavior([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLMarqueeElement*, ushort*, int>)(lpVtbl[13]))((IHTMLMarqueeElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        [return: NativeTypeName("HRESULT")]
        public int get_behavior([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLMarqueeElement*, ushort**, int>)(lpVtbl[14]))((IHTMLMarqueeElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        [return: NativeTypeName("HRESULT")]
        public int put_scrollAmount([NativeTypeName("long")] int v)
        {
            return ((delegate* unmanaged<IHTMLMarqueeElement*, int, int>)(lpVtbl[15]))((IHTMLMarqueeElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        [return: NativeTypeName("HRESULT")]
        public int get_scrollAmount([NativeTypeName("long *")] int* p)
        {
            return ((delegate* unmanaged<IHTMLMarqueeElement*, int*, int>)(lpVtbl[16]))((IHTMLMarqueeElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        [return: NativeTypeName("HRESULT")]
        public int put_loop([NativeTypeName("long")] int v)
        {
            return ((delegate* unmanaged<IHTMLMarqueeElement*, int, int>)(lpVtbl[17]))((IHTMLMarqueeElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        [return: NativeTypeName("HRESULT")]
        public int get_loop([NativeTypeName("long *")] int* p)
        {
            return ((delegate* unmanaged<IHTMLMarqueeElement*, int*, int>)(lpVtbl[18]))((IHTMLMarqueeElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        [return: NativeTypeName("HRESULT")]
        public int put_vspace([NativeTypeName("long")] int v)
        {
            return ((delegate* unmanaged<IHTMLMarqueeElement*, int, int>)(lpVtbl[19]))((IHTMLMarqueeElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        [return: NativeTypeName("HRESULT")]
        public int get_vspace([NativeTypeName("long *")] int* p)
        {
            return ((delegate* unmanaged<IHTMLMarqueeElement*, int*, int>)(lpVtbl[20]))((IHTMLMarqueeElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        [return: NativeTypeName("HRESULT")]
        public int put_hspace([NativeTypeName("long")] int v)
        {
            return ((delegate* unmanaged<IHTMLMarqueeElement*, int, int>)(lpVtbl[21]))((IHTMLMarqueeElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(22)]
        [return: NativeTypeName("HRESULT")]
        public int get_hspace([NativeTypeName("long *")] int* p)
        {
            return ((delegate* unmanaged<IHTMLMarqueeElement*, int*, int>)(lpVtbl[22]))((IHTMLMarqueeElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(23)]
        [return: NativeTypeName("HRESULT")]
        public int put_onfinish(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLMarqueeElement*, VARIANT, int>)(lpVtbl[23]))((IHTMLMarqueeElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(24)]
        [return: NativeTypeName("HRESULT")]
        public int get_onfinish(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLMarqueeElement*, VARIANT*, int>)(lpVtbl[24]))((IHTMLMarqueeElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(25)]
        [return: NativeTypeName("HRESULT")]
        public int put_onstart(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLMarqueeElement*, VARIANT, int>)(lpVtbl[25]))((IHTMLMarqueeElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(26)]
        [return: NativeTypeName("HRESULT")]
        public int get_onstart(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLMarqueeElement*, VARIANT*, int>)(lpVtbl[26]))((IHTMLMarqueeElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(27)]
        [return: NativeTypeName("HRESULT")]
        public int put_onbounce(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLMarqueeElement*, VARIANT, int>)(lpVtbl[27]))((IHTMLMarqueeElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(28)]
        [return: NativeTypeName("HRESULT")]
        public int get_onbounce(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLMarqueeElement*, VARIANT*, int>)(lpVtbl[28]))((IHTMLMarqueeElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(29)]
        [return: NativeTypeName("HRESULT")]
        public int put_width(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLMarqueeElement*, VARIANT, int>)(lpVtbl[29]))((IHTMLMarqueeElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(30)]
        [return: NativeTypeName("HRESULT")]
        public int get_width(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLMarqueeElement*, VARIANT*, int>)(lpVtbl[30]))((IHTMLMarqueeElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(31)]
        [return: NativeTypeName("HRESULT")]
        public int put_height(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLMarqueeElement*, VARIANT, int>)(lpVtbl[31]))((IHTMLMarqueeElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(32)]
        [return: NativeTypeName("HRESULT")]
        public int get_height(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLMarqueeElement*, VARIANT*, int>)(lpVtbl[32]))((IHTMLMarqueeElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(33)]
        [return: NativeTypeName("HRESULT")]
        public int put_trueSpeed([NativeTypeName("VARIANT_BOOL")] short v)
        {
            return ((delegate* unmanaged<IHTMLMarqueeElement*, short, int>)(lpVtbl[33]))((IHTMLMarqueeElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(34)]
        [return: NativeTypeName("HRESULT")]
        public int get_trueSpeed([NativeTypeName("VARIANT_BOOL *")] short* p)
        {
            return ((delegate* unmanaged<IHTMLMarqueeElement*, short*, int>)(lpVtbl[34]))((IHTMLMarqueeElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(35)]
        [return: NativeTypeName("HRESULT")]
        public int start()
        {
            return ((delegate* unmanaged<IHTMLMarqueeElement*, int>)(lpVtbl[35]))((IHTMLMarqueeElement*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(36)]
        [return: NativeTypeName("HRESULT")]
        public int stop()
        {
            return ((delegate* unmanaged<IHTMLMarqueeElement*, int>)(lpVtbl[36]))((IHTMLMarqueeElement*)Unsafe.AsPointer(ref this));
        }
    }
}
