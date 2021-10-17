// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("3050F28B-98B5-11CF-BB82-00AA00BDCE0B")]
    [NativeTypeName("struct IHTMLScriptElement : IDispatch")]
    [NativeInheritance("IDispatch")]
    public unsafe partial struct IHTMLScriptElement
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IHTMLScriptElement*, Guid*, void**, int>)(lpVtbl[0]))((IHTMLScriptElement*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IHTMLScriptElement*, uint>)(lpVtbl[1]))((IHTMLScriptElement*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IHTMLScriptElement*, uint>)(lpVtbl[2]))((IHTMLScriptElement*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfoCount([NativeTypeName("UINT *")] uint* pctinfo)
        {
            return ((delegate* unmanaged<IHTMLScriptElement*, uint*, int>)(lpVtbl[3]))((IHTMLScriptElement*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfo([NativeTypeName("UINT")] uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<IHTMLScriptElement*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IHTMLScriptElement*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, [NativeTypeName("UINT")] uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<IHTMLScriptElement*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IHTMLScriptElement*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, [NativeTypeName("UINT *")] uint* puArgErr)
        {
            return ((delegate* unmanaged<IHTMLScriptElement*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IHTMLScriptElement*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int put_src([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLScriptElement*, ushort*, int>)(lpVtbl[7]))((IHTMLScriptElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int get_src([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLScriptElement*, ushort**, int>)(lpVtbl[8]))((IHTMLScriptElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("HRESULT")]
        public int put_htmlFor([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLScriptElement*, ushort*, int>)(lpVtbl[9]))((IHTMLScriptElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        [return: NativeTypeName("HRESULT")]
        public int get_htmlFor([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLScriptElement*, ushort**, int>)(lpVtbl[10]))((IHTMLScriptElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        [return: NativeTypeName("HRESULT")]
        public int put_event([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLScriptElement*, ushort*, int>)(lpVtbl[11]))((IHTMLScriptElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        [return: NativeTypeName("HRESULT")]
        public int get_event([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLScriptElement*, ushort**, int>)(lpVtbl[12]))((IHTMLScriptElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        [return: NativeTypeName("HRESULT")]
        public int put_text([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLScriptElement*, ushort*, int>)(lpVtbl[13]))((IHTMLScriptElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        [return: NativeTypeName("HRESULT")]
        public int get_text([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLScriptElement*, ushort**, int>)(lpVtbl[14]))((IHTMLScriptElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        [return: NativeTypeName("HRESULT")]
        public int put_defer([NativeTypeName("VARIANT_BOOL")] short v)
        {
            return ((delegate* unmanaged<IHTMLScriptElement*, short, int>)(lpVtbl[15]))((IHTMLScriptElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        [return: NativeTypeName("HRESULT")]
        public int get_defer([NativeTypeName("VARIANT_BOOL *")] short* p)
        {
            return ((delegate* unmanaged<IHTMLScriptElement*, short*, int>)(lpVtbl[16]))((IHTMLScriptElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        [return: NativeTypeName("HRESULT")]
        public int get_readyState([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLScriptElement*, ushort**, int>)(lpVtbl[17]))((IHTMLScriptElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        [return: NativeTypeName("HRESULT")]
        public int put_onerror(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLScriptElement*, VARIANT, int>)(lpVtbl[18]))((IHTMLScriptElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        [return: NativeTypeName("HRESULT")]
        public int get_onerror(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLScriptElement*, VARIANT*, int>)(lpVtbl[19]))((IHTMLScriptElement*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        [return: NativeTypeName("HRESULT")]
        public int put_type([NativeTypeName("BSTR")] ushort* v)
        {
            return ((delegate* unmanaged<IHTMLScriptElement*, ushort*, int>)(lpVtbl[20]))((IHTMLScriptElement*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        [return: NativeTypeName("HRESULT")]
        public int get_type([NativeTypeName("BSTR *")] ushort** p)
        {
            return ((delegate* unmanaged<IHTMLScriptElement*, ushort**, int>)(lpVtbl[21]))((IHTMLScriptElement*)Unsafe.AsPointer(ref this), p);
        }
    }
}
