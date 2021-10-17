// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("3050F319-98B5-11CF-BB82-00AA00BDCE0B")]
    [NativeTypeName("struct IHTMLFrameSetElement : IDispatch")]
    [NativeInheritance("IDispatch")]
    public unsafe partial struct IHTMLFrameSetElement
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IHTMLFrameSetElement*, Guid*, void**, int>)(lpVtbl[0]))((IHTMLFrameSetElement*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IHTMLFrameSetElement*, uint>)(lpVtbl[1]))((IHTMLFrameSetElement*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IHTMLFrameSetElement*, uint>)(lpVtbl[2]))((IHTMLFrameSetElement*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfoCount([NativeTypeName("UINT *")] uint* pctinfo)
        {
            return ((delegate* unmanaged<IHTMLFrameSetElement*, uint*, int>)(lpVtbl[3]))((IHTMLFrameSetElement*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfo([NativeTypeName("UINT")] uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<IHTMLFrameSetElement*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IHTMLFrameSetElement*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, [NativeTypeName("UINT")] uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<IHTMLFrameSetElement*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IHTMLFrameSetElement*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, [NativeTypeName("UINT *")] uint* puArgErr)
        {
            return ((delegate* unmanaged<IHTMLFrameSetElement*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IHTMLFrameSetElement*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int put_rows([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLFrameSetElement*, ushort*, int>)(lpVtbl[7]))((IHTMLFrameSetElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int get_rows([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLFrameSetElement*, ushort**, int>)(lpVtbl[8]))((IHTMLFrameSetElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("HRESULT")]
        public int put_cols([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLFrameSetElement*, ushort*, int>)(lpVtbl[9]))((IHTMLFrameSetElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        [return: NativeTypeName("HRESULT")]
        public int get_cols([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLFrameSetElement*, ushort**, int>)(lpVtbl[10]))((IHTMLFrameSetElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        [return: NativeTypeName("HRESULT")]
        public int put_border(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLFrameSetElement*, VARIANT, int>)(lpVtbl[11]))((IHTMLFrameSetElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        [return: NativeTypeName("HRESULT")]
        public int get_border(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLFrameSetElement*, VARIANT*, int>)(lpVtbl[12]))((IHTMLFrameSetElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        [return: NativeTypeName("HRESULT")]
        public int put_borderColor(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLFrameSetElement*, VARIANT, int>)(lpVtbl[13]))((IHTMLFrameSetElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        [return: NativeTypeName("HRESULT")]
        public int get_borderColor(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLFrameSetElement*, VARIANT*, int>)(lpVtbl[14]))((IHTMLFrameSetElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        [return: NativeTypeName("HRESULT")]
        public int put_frameBorder([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLFrameSetElement*, ushort*, int>)(lpVtbl[15]))((IHTMLFrameSetElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        [return: NativeTypeName("HRESULT")]
        public int get_frameBorder([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLFrameSetElement*, ushort**, int>)(lpVtbl[16]))((IHTMLFrameSetElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        [return: NativeTypeName("HRESULT")]
        public int put_frameSpacing(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLFrameSetElement*, VARIANT, int>)(lpVtbl[17]))((IHTMLFrameSetElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        [return: NativeTypeName("HRESULT")]
        public int get_frameSpacing(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLFrameSetElement*, VARIANT*, int>)(lpVtbl[18]))((IHTMLFrameSetElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        [return: NativeTypeName("HRESULT")]
        public int put_name([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLFrameSetElement*, ushort*, int>)(lpVtbl[19]))((IHTMLFrameSetElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        [return: NativeTypeName("HRESULT")]
        public int get_name([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLFrameSetElement*, ushort**, int>)(lpVtbl[20]))((IHTMLFrameSetElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        [return: NativeTypeName("HRESULT")]
        public int put_onload(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLFrameSetElement*, VARIANT, int>)(lpVtbl[21]))((IHTMLFrameSetElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(22)]
        [return: NativeTypeName("HRESULT")]
        public int get_onload(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLFrameSetElement*, VARIANT*, int>)(lpVtbl[22]))((IHTMLFrameSetElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(23)]
        [return: NativeTypeName("HRESULT")]
        public int put_onunload(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLFrameSetElement*, VARIANT, int>)(lpVtbl[23]))((IHTMLFrameSetElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(24)]
        [return: NativeTypeName("HRESULT")]
        public int get_onunload(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLFrameSetElement*, VARIANT*, int>)(lpVtbl[24]))((IHTMLFrameSetElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(25)]
        [return: NativeTypeName("HRESULT")]
        public int put_onbeforeunload(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLFrameSetElement*, VARIANT, int>)(lpVtbl[25]))((IHTMLFrameSetElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(26)]
        [return: NativeTypeName("HRESULT")]
        public int get_onbeforeunload(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLFrameSetElement*, VARIANT*, int>)(lpVtbl[26]))((IHTMLFrameSetElement*)Unsafe.AsPointer(ref this), p);
        }
    }
}
