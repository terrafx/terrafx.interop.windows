// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("3050F80F-98B5-11CF-BB82-00AA00BDCE0B")]
    [NativeTypeName("struct IHTMLElement4 : IDispatch")]
    [NativeInheritance("IDispatch")]
    public unsafe partial struct IHTMLElement4
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IHTMLElement4*, Guid*, void**, int>)(lpVtbl[0]))((IHTMLElement4*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IHTMLElement4*, uint>)(lpVtbl[1]))((IHTMLElement4*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IHTMLElement4*, uint>)(lpVtbl[2]))((IHTMLElement4*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfoCount([NativeTypeName("UINT *")] uint* pctinfo)
        {
            return ((delegate* unmanaged<IHTMLElement4*, uint*, int>)(lpVtbl[3]))((IHTMLElement4*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfo([NativeTypeName("UINT")] uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<IHTMLElement4*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IHTMLElement4*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, [NativeTypeName("UINT")] uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<IHTMLElement4*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IHTMLElement4*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, [NativeTypeName("UINT *")] uint* puArgErr)
        {
            return ((delegate* unmanaged<IHTMLElement4*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IHTMLElement4*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int put_onmousewheel(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLElement4*, VARIANT, int>)(lpVtbl[7]))((IHTMLElement4*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int get_onmousewheel(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLElement4*, VARIANT*, int>)(lpVtbl[8]))((IHTMLElement4*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("HRESULT")]
        public int normalize()
        {
            return ((delegate* unmanaged<IHTMLElement4*, int>)(lpVtbl[9]))((IHTMLElement4*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        [return: NativeTypeName("HRESULT")]
        public int getAttributeNode([NativeTypeName("BSTR")] ushort* bstrname, IHTMLDOMAttribute** ppAttribute)
        {
            return ((delegate* unmanaged<IHTMLElement4*, ushort*, IHTMLDOMAttribute**, int>)(lpVtbl[10]))((IHTMLElement4*)Unsafe.AsPointer(ref this), bstrname, ppAttribute);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        [return: NativeTypeName("HRESULT")]
        public int setAttributeNode(IHTMLDOMAttribute* pattr, IHTMLDOMAttribute** ppretAttribute)
        {
            return ((delegate* unmanaged<IHTMLElement4*, IHTMLDOMAttribute*, IHTMLDOMAttribute**, int>)(lpVtbl[11]))((IHTMLElement4*)Unsafe.AsPointer(ref this), pattr, ppretAttribute);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        [return: NativeTypeName("HRESULT")]
        public int removeAttributeNode(IHTMLDOMAttribute* pattr, IHTMLDOMAttribute** ppretAttribute)
        {
            return ((delegate* unmanaged<IHTMLElement4*, IHTMLDOMAttribute*, IHTMLDOMAttribute**, int>)(lpVtbl[12]))((IHTMLElement4*)Unsafe.AsPointer(ref this), pattr, ppretAttribute);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        [return: NativeTypeName("HRESULT")]
        public int put_onbeforeactivate(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLElement4*, VARIANT, int>)(lpVtbl[13]))((IHTMLElement4*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        [return: NativeTypeName("HRESULT")]
        public int get_onbeforeactivate(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLElement4*, VARIANT*, int>)(lpVtbl[14]))((IHTMLElement4*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        [return: NativeTypeName("HRESULT")]
        public int put_onfocusin(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLElement4*, VARIANT, int>)(lpVtbl[15]))((IHTMLElement4*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        [return: NativeTypeName("HRESULT")]
        public int get_onfocusin(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLElement4*, VARIANT*, int>)(lpVtbl[16]))((IHTMLElement4*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        [return: NativeTypeName("HRESULT")]
        public int put_onfocusout(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLElement4*, VARIANT, int>)(lpVtbl[17]))((IHTMLElement4*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        [return: NativeTypeName("HRESULT")]
        public int get_onfocusout(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLElement4*, VARIANT*, int>)(lpVtbl[18]))((IHTMLElement4*)Unsafe.AsPointer(ref this), p);
        }
    }
}
